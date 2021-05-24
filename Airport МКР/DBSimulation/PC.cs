using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSimulation
{
    class PC
    {

        private double _flight_number;
        public double flight_number
        {
            get
            {
                return _flight_number;
            }
            set
            {
                if (value >= 0)
                    _flight_number = value;
                else
                    throw new Exception("Номер рейсу не може бути відємним");
            }
        }

        public string City_of_arrival { get; set; }

        private double _Number_of_seats;
        public double Number_of_seats
        {
            get
            {
                return _Number_of_seats;
            }
            set
            {
                if (value >= 0)
                    _Number_of_seats = value;
                else
                    throw new Exception("Номер місця не може бути відємним");
            }
        }



        private double _flight_time;
        public double flight_time
        {
            get
            {
                return _flight_time;
            }
            set
            {
                if (value >= 0)
                    _flight_time = value;
                else
                    throw new Exception("Час перельоту не може бути відємним");
            }
        }

        private double _ticket_price;
        public double ticket_price
        {
            get
            {
                return _ticket_price;
            }
            set
            {
                if (value >= 0)
                    _ticket_price = value;
                else
                    throw new Exception("Ціна перельоту не може бути відємним");
            }
        }



        public PC(double flight_number, string City_of_arrival, double Number_of_seats, double flight_time, double ticket_price)
        {
            this.flight_number = flight_number;
            this.City_of_arrival = City_of_arrival;
            this.Number_of_seats = Number_of_seats;
            this.flight_time = flight_time;
            this.ticket_price = ticket_price;

        }

    }
}
