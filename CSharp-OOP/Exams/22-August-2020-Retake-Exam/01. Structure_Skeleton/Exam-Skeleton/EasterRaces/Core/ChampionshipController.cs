using EasterRaces.Core.Contracts;
using EasterRaces.Models.Cars;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Models.Drivers;
using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Models.Races;
using EasterRaces.Models.Races.Contracts;
using EasterRaces.Repositories;
using EasterRaces.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Core
{
    public class ChampionshipController : IChampionshipController
    {
        private readonly IRepository<ICar> carRepository;
        private readonly IRepository<IDriver> driverRepository;
        private readonly IRepository<IRace> raceRepository;

        public ChampionshipController()
        {
            carRepository = new CarRepository();
            driverRepository = new DriverRepository();
            raceRepository = new RaceRepository();
        }

        public string AddCarToDriver(string driverName, string carModel)
        {
            IDriver driver = driverRepository.GetByName(driverName);
            ICar car = carRepository.GetByName(carModel);

            if (driver == null)
            {
                throw new InvalidOperationException($"Driver {driverName} could not be found.");
            }

            if (car == null)
            {
                throw new InvalidOperationException($"Car {carModel} could not be found.");
            }

            driver.AddCar(car);
            return $"Driver {driverName} received car {carModel}.";
        }

        public string AddDriverToRace(string raceName, string driverName)
        {
            Driver driver = new Driver(driverName);

            IRace race = raceRepository.Models.FirstOrDefault(r => r.Name == raceName);

            if(race == null)
            {
                throw new InvalidOperationException($"Race {raceName} could not be found.");
            }

            if(!driverRepository.Models.Contains(driver))
            {
                throw new InvalidOperationException($"Driver {driverName} could not be found.");
            }

            race.AddDriver(driver);

            return $"Driver {driverName} added in {raceName} race.";
        }

        public string CreateCar(string type, string model, int horsePower)
        {
            ICar car = null;

            if (type == "Muscle")
            {
                car = new MuscleCar(model, horsePower);
            }
            else if (type == "Sports")
            {
                car = new SportsCar(model, horsePower);
            }

            if(carRepository.Models.Contains(car))
            {
                throw new ArgumentException($"Car {model} is already created.");
            }

            return $"{GetType().Name} {model} is created.";
        }

        public string CreateDriver(string driverName)
        {
            Driver driver = new Driver(driverName);

            if (driverRepository.Models.Contains(driver))
            {
                throw new ArgumentException($"Driver {driverName} is already created.");
            }

            driverRepository.Add(driver);

            return $"Driver {driverName} is created.";
        }

        public string CreateRace(string name, int laps)
        {
            Race race = new Race(name, laps);

            if(raceRepository.Models.Contains(race))
            {
                throw new InvalidOperationException($"Race {name} is already create.");
            }

            raceRepository.Add(race);

            return $"Race {name} is created.";
        }

        public string StartRace(string raceName)
        {
            IRace race = raceRepository.Models.FirstOrDefault(r => r.Name == raceName);

            if (race == null)
            {
                throw new InvalidOperationException($"Race {raceName} could not be found.");
            }

            if(race.Drivers.Count < 3)
            {
                throw new InvalidOperationException($"Race {raceName} cannot start with less than 3 participants.");
            }

           List<IDriver> orderedDrivers = (List<IDriver>)race.Drivers;

            orderedDrivers = (List<IDriver>)orderedDrivers.OrderByDescending(d => d.Car.CalculateRacePoints(race.Laps));


            return $"Driver {orderedDrivers[0]} wins {race.Name} race.\r\n" +
                   $"Driver {orderedDrivers[1]} is second in {race.Name} race.\r\n" +
                   $"Driver {orderedDrivers[2]} is third in {race.Name} race.";

        }
    }
}
