using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeSim2._0.Maui.Models
{
    public partial class VehicleD : Base
    {
        private string make;
        private string model;
        private string imgUrl;

        public string Make
        {
            get { return make; }
            set { make = value; NotifyPropertyChanged(); }
        }
        public string Model
        {
            get { return model; }
            set { model = value; NotifyPropertyChanged(); }
        }
        public string ImageUrl
        {
            get { return imgUrl; }
            set { imgUrl = value; NotifyPropertyChanged(); }
        }
        public VehicleD(string make, string model, string imgUrl)
        {
            this.Make = make;
            this.Model = model;
            this.ImageUrl = imgUrl;
        }
    }
}
