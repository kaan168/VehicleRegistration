using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleRegister.Models
{
    public class Vehicle
    {

        [Key]
        public int VehichleId { get; set; }

        public string plateOfVehicle;

        public string NicknameOfVehicle;

        public string brandOfVehicle;

        public string modelOfVehicle;

        public string typeOfVehicle;

        public string colorOfVehicle;

        public bool active;



    }
}
