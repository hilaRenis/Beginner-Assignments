using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3_4_week11
{
    public partial class Form1 : Form
    {
        private Car car = new Car();

        private const int speedDefault = 2;
        private const int timerIntervalDefault = 25;

        public Form1()
        {
            InitializeComponent();
            car.setPosition(getCarFirstPosition());
            car.setSpeed(speedDefault);
        }

        private Position getCarFirstPosition()
        {
            Position position = new Position();
            position.setX(carImage_pb.Location.X);
            position.setY(carImage_pb.Location.Y);
            return position;
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            car.StartMoving();
            StartMovementTimer();
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            interval_timer.Stop();
        }

        private void interval_timer_Tick(object sender, EventArgs e)
        {
            car.StartMoving();
            UpdateCarImageLocation();
        }

        private void UpdateCarImageLocation()
        {
            carImage_pb.Location = new Point(car.getPosition().getX(), car.getPosition().getY());
        }

        private void StartMovementTimer()
        {
            interval_timer.Interval = timerIntervalDefault;
            interval_timer.Enabled = true;
        }
    }
}
