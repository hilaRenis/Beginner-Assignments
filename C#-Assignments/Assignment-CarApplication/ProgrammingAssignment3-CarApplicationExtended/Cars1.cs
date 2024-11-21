using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment3_CarApplicationExtended
{
    public class Cars1
    {
        private string brand;
        private int maxSpeed;
        private int currentSpeed;
        private int increaseSpeed = 7;
        private int decreaseSpeed = 10;

        public void SetBrand(string brand)
        {
            this.brand = brand;
        }

        public string GetBrand()
        {
            return brand;
        }

        public string GetInfo()
        {
            return "Car: " + brand + ": " + currentSpeed + "/" + maxSpeed + "km/h";
        }

        public void SetMaxSpeed(int maxSpeed)
        {
            this.maxSpeed = maxSpeed;
        }

        public void SetCurrentSpeed(int currentSpeed)
        {
            this.currentSpeed = currentSpeed;
        }

        public void SpeedUp()
        {
            if (currentSpeed + increaseSpeed <= maxSpeed)
            {
                currentSpeed = currentSpeed + increaseSpeed;
            }
            else
            {
                currentSpeed = maxSpeed;
            }
        }

        public void SlowDown()
        {
            if (currentSpeed - decreaseSpeed > 0)
            {
                currentSpeed = currentSpeed - decreaseSpeed;
            }
            else
            {
                currentSpeed = 0;
            }
        }
    }
}
