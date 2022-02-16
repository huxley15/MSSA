using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6._2
{
    interface CRUD //create, read, update, delete
    {
        ICollection<tblCar> ReadCars();
        int GetMaxVIN();
        void AddRecord(tblCar obj);
        void DeleteRecord(tblCar obj);
        tblCar FindCar(int id);
        void UpdateRecord(int id, tblCar carchanges);
    }
    class CarRepository : CRUD
    {
        CarEntities entities;
        public CarRepository()
        {
            entities = new CarEntities();
        }
        public void AddRecord(tblCar obj)
        {
            entities.tblCars.Add(obj); //update list
            entities.SaveChanges(); //update database
        }

        public void DeleteRecord(tblCar obj)
        {
            entities.tblCars.Remove(obj);
            entities.SaveChanges();
        }

        public tblCar FindCar(int id)
        {
            var car = entities.tblCars.First(n => n.VIN == id);
            if (car != null)
            {
                return car;
            }
            else
                return null;
        }

        public int GetMaxVIN()
        {
            return entities.tblCars.Max(p => p.VIN);
        }

        public ICollection<tblCar> ReadCars()
        {
            return entities.tblCars.ToList();
        }

        public void UpdateRecord(int id, tblCar carchanges)
        {
            var cartoupdate = entities.tblCars.Find(id);

            cartoupdate.Make=carchanges.Make;
            cartoupdate.Model = carchanges.Model;
            cartoupdate.Year = carchanges.Year;
            cartoupdate.Price = carchanges.Price;
            cartoupdate.Color = carchanges.Color;

            entities.SaveChanges();
        }
    }
}
