using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSale.Models
{
    [Serializable]
    public class CarInventory
    {
        private static int maxNumberCarInventory = 100;
        private List<Car> inventoryCar;

        public CarInventory()
        {
            this.inventoryCar = new List<Car>();
        }

        public void loadCars(List<Car> listOfCars,out string log)
        {
            int nAdd = 0;
            int nUpd = 0;
            int nDel = 0;
            foreach(Car car in listOfCars){
                if (!this.inventoryCar.Any(item => item.GetBrand() == car.GetBrand() && item.GetModel() == car.GetModel() 
                && item.GetProduceYear() == car.GetProduceYear() && item.GetPrice() == car.GetPrice()))
                {
                    string logCar = "";
                    AddCarInventory(car,out logCar);
                    nAdd++;

                }
                else
                {
                    nUpd++;
                }
            }
            List<Car> removeList = new List<Car>();
            
            foreach (Car car in this.inventoryCar)
            {
                if (!listOfCars.Any(item => item.GetBrand() == car.GetBrand() && item.GetModel() == car.GetModel()
                && item.GetProduceYear() == car.GetProduceYear() && item.GetPrice() == car.GetPrice()))
                {
                    removeList.Add(car);
                    //RemoveCarInventory(car);
                    nDel++;
                }
            }
            this.inventoryCar.RemoveAll(item => removeList.Any(car => item.GetBrand() == car.GetBrand() && item.GetModel() == car.GetModel()
                && item.GetProduceYear() == car.GetProduceYear() && item.GetPrice() == car.GetPrice()));
            log = String.Format("Importing cars: New {0}, Update {1}, Deleted {2}", nAdd, nUpd, nDel);

         }

        public List<Car> GetList()
        {
            return this.inventoryCar;
        }
        public int getNextId()
        {
            int id = 0;
            foreach (Car car in this.inventoryCar)
            {
                if(id < car.id)
                {
                    id = car.id;
                }
            }

            return id + 1;
         }
        public void AddCarInventory(Car car, out string log)
        {
            if (!this.inventoryCar.Any(item => item.GetBrand() == car.GetBrand() && item.GetModel() == car.GetModel()
                && item.GetProduceYear() == car.GetProduceYear() && item.GetPrice() == car.GetPrice()))
            {
                if (this.inventoryCar.Count <= maxNumberCarInventory)
                {
                    if(car.id == 0)
                    {
                        car.id = getNextId();
                    }
                    this.inventoryCar.Add(car);
                    log = "OK";
                } else
                {
                    log = "You have exceeded the limit of Inventory";
                }
            }else
            {
                log = "This car already exists at Inventory";
            }
        }

        public void RemoveCarInventory(Car car)
        {
            if (this.inventoryCar.Any(item => item.id == car.id))
            {
                this.inventoryCar.Remove(this.inventoryCar.Single(item => item.id == car.id));
            }
        }

        //To show entire Inventory/ To search inventory based on brand/model/price
        public Car [] GetCar()
        {
            return this.inventoryCar.ToArray();
        }

        public Car[] GetTheBrand(string brand)
        {
            List<Car> carBrand = new List<Car>();

            foreach (Car c in this.inventoryCar)
            {
                if (c.GetBrand().Contains(brand))
                {
                    carBrand.Add(c);
                }
            }

            return carBrand.ToArray();
        }

        public Car[] GetTheModel(string model)
        {
            List<Car> carModel = new List<Car>();

            foreach (Car m in this.inventoryCar)
            {
                if (m.GetBrand().Contains(model))
                {
                    carModel.Add(m);
                }
            }

            return carModel.ToArray();
        }

        public Car[] GetThePrice(int price)
        {
            List<Car> carPrice = new List<Car>();

            foreach (Car p in this.inventoryCar)
            {
                if (p.GetPrice() == price)
                {
                    carPrice.Add(p);
                }
            }

            return carPrice.ToArray();
        }
    }
}
