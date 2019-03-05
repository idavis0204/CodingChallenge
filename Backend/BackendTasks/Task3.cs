using System;
using System.Collections.Generic;
using static BackendConsoleApp.Factory;

namespace BackendConsoleApp
{
    // NOTE: In a real world scenario, I would likely move each class defined here into its own separate file for improved maintainability.
    //       I've kept them all in one class here for ease of reference.

    /// <summary>
    /// Class used to produce factory products
    /// </summary>
    public class Factory
    {
        public enum ProductType
        {
            Robot = 0,
            Car = 1
        }

        public enum RobotType
        {
            RoboticDog,
            RoboticCat,
            RoboticDrone,
            RoboticCar
        }

        public enum CarType
        {
            Toyota,
            Ford,
            Opel,
            Honda
        }

        /// <summary>
        /// Builds a product for the provided product and item types
        /// </summary>
        /// <param name="productType"></param>
        /// <param name="itemType"></param>
        /// <returns>The built product</returns>
        public FactoryProduct BuildProduct(ProductType productType, Enum itemType)
        {
            ProductProducer producer;

            switch (productType)
            {
                case ProductType.Car:
                    producer = new CarProducer();
                    break;
                case ProductType.Robot:
                    producer = new RobotProducer();
                    break;
                default:
                    return null;
            }

            return producer.ProduceProduct(itemType);
        }
    }

    /// <summary>
    /// Generic factory product
    /// </summary>
    public abstract class FactoryProduct
    {
    }

    /// <summary>
    /// Concrete factory product implemetation for robot products
    /// </summary>
    public class RobotProduct : FactoryProduct
    {
        public RobotProduct(Robot robot)
        {
            // Map required fields from Robot class defined by service
        }
    }

    /// <summary>
    /// Concrete factory product implemetation for car products
    /// </summary>
    public class CarProduct : FactoryProduct
    {
        public CarProduct(Car car)
        {
            // Map required fields from Car class defined by service
        }
    }

    /// <summary>
    /// Generic class for producing factory products
    /// </summary>
    public abstract class ProductProducer
    {
        public PartsService partsService = new PartsService();
        public List<Parts> Parts { get; set; }

        public abstract FactoryProduct ProduceProduct(Enum itemType);
    }

    /// <summary>
    /// Concreate class for producing robot products
    /// </summary>
    public class RobotProducer : ProductProducer
    {
        public override FactoryProduct ProduceProduct(Enum itemType)
        {
            Parts = partsService.GetParts(itemType);
            RobotService robotService = new RobotService();

            switch (itemType)
            {
                case RobotType.RoboticCar:
                     return new RobotProduct(robotService.BuildRobotCar(Parts));
                case RobotType.RoboticCat:
                    return new RobotProduct(robotService.BuildRobotCat(Parts));
                case RobotType.RoboticDrone:
                    return new RobotProduct(robotService.BuildRobotDrone(Parts));
                case RobotType.RoboticDog:
                    return new RobotProduct(robotService.BuildRobotDog(Parts));
                default:
                    return null;
            }
        }
    }

    /// <summary>
    /// Concreate class for producing car products
    /// </summary>
    public class CarProducer : ProductProducer
    {
        public override FactoryProduct ProduceProduct(Enum itemType)
        {
            Parts = partsService.GetParts(itemType);
            CarService carService = new CarService();
            return new CarProduct(carService.BuildCar(Parts));
        }
    }

    // Skeleton classes for service realted objects to enable code to build, no actual implementation
    #region Services
    public class Parts
    {
        public Parts() { }
    }

    public class Car
    {
        public Car() { }
    }

    public class Robot
    {
        public Robot() { }
    }

    public class RobotService
    {
        public RobotService() { }
        public Robot BuildRobotDog(List<Parts> parts) { return new Robot(); }
        public Robot BuildRobotCat(List<Parts> parts) { return new Robot(); }
        public Robot BuildRobotDrone(List<Parts> parts) { return new Robot(); }
        public Robot BuildRobotCar(List<Parts> parts) { return new Robot(); }
    }

    public class CarService
    {
        public CarService() { }
        public Car BuildCar(List<Parts> parts) { return new Car(); }
    }

    public class PartsService
    {
        public PartsService() { }
        public List<Parts> GetParts(Enum itemType) { return new List<Parts>() { }; }
    }
    #endregion 
}
