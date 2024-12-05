using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace VeSim2._0.Maui.Models
{
    public partial class Vehicle : ObservableObject
    {
        [ObservableProperty]
        private Guid id;

        [ObservableProperty]
        private string make;

        [ObservableProperty]
        private string model;

        [ObservableProperty]
        private string imageUrl;

        public Vehicle(string make, string model, string imgurl)
        {
            this.Id = Guid.NewGuid();
            this.Make = make;
            this.Model = model;
            this.ImageUrl = imgurl;
        }
    }
}
