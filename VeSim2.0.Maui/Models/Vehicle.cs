using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace VeSim2._0.Maui.Models
{
    public partial class Vehicle : VehicleD
    {
        private Guid id;

        public Guid Id
        {
            get { return id; }
            set { id = value; NotifyPropertyChanged(); }

        }
        public Vehicle(string make, string model, string imgUrl) : base(make, model, imgUrl) //needs to inherit back to the base class
        {
            this.Id = Guid.NewGuid();
            this.Make = make;
            this.Model = model;
            this.ImageUrl = imgUrl;
        }
    }
}
