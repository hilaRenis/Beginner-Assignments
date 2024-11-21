using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_4_week11
{
    public class Car
    {
        private Position position;
        private int speed;

        public void setSpeed (int speed)
        {
            this.speed = speed;
        }

        public int getSpeed ()
        {
            return speed;
        }

        public void setPosition (Position position)
        {
            this.position = position;
        }

        public Position getPosition ()
        {
            return position;
        }

        public void StartMoving()
        {
            int newXPosition = position.getX() + speed;
            position.setX(newXPosition);
        }
    }
}
