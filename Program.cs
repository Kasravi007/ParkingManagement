
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using ParkingManagement.ParkingFloor_Ns;
using ParkingManagement.Vehicle_Ns;
using ParkingManagement.ParkingSlot_Ns;
using ParkingManagement.ParkingLot_Ns;

IHostBuilder hostBuilder=Host.CreateDefaultBuilder();

              hostBuilder.ConfigureServices(service=>{
                service.AddSingleton<ParkingLot,UnderGroundParkingLot>();
                service.AddSingleton<ParkingFloor,ConcreteParkingFloor>();
                service.AddTransient<ParkingSlot,NormalParkingSlot>();
              });
IHost host=hostBuilder.Build();




