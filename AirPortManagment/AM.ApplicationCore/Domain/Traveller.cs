﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Traveller:Passenger
    {

        public string HealthInformation { get; set; }

        public string  Nationality { get; set; }

        public override string ToString()
        {
            return "Health Info: " + this.HealthInformation + "Nationality : " + this.Nationality;
        }

        public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("ena Traveller");
        }
    }
}
