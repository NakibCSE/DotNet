using CreationalPattern.Prototype;
using CreationalPattern.Singleton;

Logger logger = Logger.GetLogger();
Logger logger2 = Logger.GetLogger();

Car car = new Car();
car.Fuel = 200;
car.Model = "Toyota";
car.Speed = 100;

Car car2 = car.Copy();
 
