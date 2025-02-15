﻿using System.Text;
using CreationalPattern.AbstractFactory;
using CreationalPattern.Builder;
using CreationalPattern.Factory;
using CreationalPattern.Prototype;
using CreationalPattern.Singleton;

Logger logger = Logger.GetLogger();
Logger logger2 = Logger.GetLogger();

CreationalPattern.Prototype.Car car = new CreationalPattern.Prototype.Car();
car.Fuel = 200;
car.Model = "Toyota";
car.Speed = 100;

CreationalPattern.Prototype.Car car2 = car.Copy();

ItemBuilder itemBuilder = new ItemBuilder();
itemBuilder.SetValue3("Password");
itemBuilder.SetValue1("Username");

Item item = itemBuilder.GetItem();

StringBuilder stringBuilder = new StringBuilder();
stringBuilder.Append("Password");
stringBuilder.Append("Username");

string text = stringBuilder.ToString();
 
CreationalPattern.Factory.CarFactory carFactory = new CreationalPattern.Factory.CarFactory();
CreationalPattern.Factory.Car car3 =  carFactory.CreateCar("Toyota", "AXIO", "Blue", 300);

CreationalPattern.AbstractFactory.CarFactory abstractFactory = new CreationalPattern.AbstractFactory.NissanFactory();
Engine engine = abstractFactory.EngineFactory.CreateEngine();
HeadLigth headLigth =  abstractFactory.HeadLightFactory.CreateHeadLight();

