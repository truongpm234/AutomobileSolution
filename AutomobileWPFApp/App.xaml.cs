﻿using System.Configuration;
using System.Data;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using AutomobileClibrary.Repository;
namespace AutomobileWPFApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ServiceProvider serviceProvider;
        public App()
        {
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton(typeof(ICarRepository), typeof(CarRepository));
            services.AddSingleton<WindowCarManagement>();
        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            var windowCarManagement = serviceProvider.GetService<WindowCarManagement>();
            windowCarManagement.Show();
        }
    }

}
