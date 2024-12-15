using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VeSim2._0.Maui.Models;

namespace VeSim2._0.Maui.ViewModels
{
    public partial class MVM : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Vehicle> vehicles;

        private string samplepic = "https://picsum.photos/300/200";
        
        public MVM()
        {
            this.Vehicles = new ObservableCollection<Vehicle>();
            AddSampleData();

            
            
        }
        [RelayCommand]
        public void ViewAdd(VehicleD vehicleD)
        {
            
            Vehicles.Add(new Vehicle("Toyota","Camry", "https://hips.hearstapps.com/hmg-prod/images/2005072-03-camry-se-1579105800.jpg"));

        }

        [RelayCommand]
        public void AddVehicle(VehicleD vehicleD)
        {
            Vehicle vehicle = new Vehicle(vehicleD.Make, vehicleD.Model, vehicleD.ImageUrl);
            Vehicles.Add(vehicle);

        }
        

        void EditVehicle(string make, string model, string imgurl)
        {

        }

        void AddSampleData()
        {
            AddVehicle(new VehicleD("Toyota", "Supra", "https://media.autoexpress.co.uk/image/private/s--X-WVjvBW--/f_auto,t_content-image-full-desktop@1/v1721841294/evo/2024/7/evo%20Fast%20Fleet%20Toyota%20Supra%202-10.jpg"));
            AddVehicle(new VehicleD("Toyota", "AE86", "https://www.topgear.com/sites/default/files/2023/01/20230113_01_44.jpg"));
            AddVehicle(new VehicleD("Nissan", "GTR R35", "https://www.seasoncars.com/wp-content/uploads/2022/07/nissan-gt-r-t-spec-1.jpg"));
            AddVehicle(new VehicleD("Honda", "S2000", "https://bidders-highway.fra1.cdn.digitaloceanspaces.com/16095eac9ed6562df759abd27153b9e1"));
            AddVehicle(new VehicleD("Mazda", "Rx7", "https://media.graphassets.com/resize=fit:crop,height:800,width:1200/output=format:jpg,quality:90/lZCf4DTMqF4x6gn8PSWg"));
            AddVehicle(new VehicleD("Rolls Royce", "Phantom", "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1c/2019_Rolls-Royce_Phantom_V12_Automatic_6.75.jpg/1200px-2019_Rolls-Royce_Phantom_V12_Automatic_6.75.jpg"));
            AddVehicle(new VehicleD("Lamborghini", "Aventador", "https://cdn.motor1.com/images/mgl/4JyZA/s3/lamborghini-aventador-lp-780-4-ultimae.jpg"));
        }

    }
}
