using Cirrious.CrossCore.IoC;
using Weather.Common.Services;

namespace Weather.Common
{
    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        IMvxIoCProvider container;
        public override void Initialize()
        {
            container = MvxSimpleIoCContainer.Initialize();

            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();


            //container.RegisterType<IWeatherService, WeatherService>();
            container.RegisterSingleton<IWeatherService>(new WeatherService());
            RegisterAppStart<ViewModels.FirstViewModel>();
        }
    }
}