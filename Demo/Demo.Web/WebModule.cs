using Autofac;
using Demo.Application.Services;
using Demo.Data;
using Demo.Domain;
using Demo.Domain.Repositories;
using Demo.Domain.Services;
using Demo.Infrastructure;
using Demo.Infrastructure.Repositories;
using Demo.Models;

namespace Demo
{
    public class WebModule : Module
    {
        private readonly string _connetionString;
        private readonly string _migrationAssembly;
        public WebModule(string connectionString, string migrationAssembly)
        {
            _connetionString = connectionString;
            _migrationAssembly = migrationAssembly;
        }
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Item>().As<IItemcs>().InstancePerLifetimeScope();
            builder.RegisterType<ApplicationDbContext>().AsSelf()
                .WithParameter("connectionString", _connetionString)
                .WithParameter("migrationAssembly", _migrationAssembly)
                .InstancePerLifetimeScope();

            builder.RegisterType<ApplicationUnitOfWork>().As<IApplicationUnitOfWork>()
                .InstancePerLifetimeScope();

            builder.RegisterType<BookRepository>().As<IBookRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<AuthorRepository>().As<IAuthorRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<BookService>().As<IBookService>()
                .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
