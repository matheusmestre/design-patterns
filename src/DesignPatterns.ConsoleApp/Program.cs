using DesignPatterns.Behavorial.Command.Client;
using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Structural.Adapter.Client;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Facade;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.ConsoleApp
{
    internal class Program
    {
        private static IEnumerable<MenuOption> _menuOptions;
        static void Main(string[] args)
        {
            var option = string.Empty;

            SeedMenuOptions();

            while(option != "q") {
                
                option = ShowMenuAndGetKey();
                
                Console.WriteLine();

                var menuOption = _menuOptions.FirstOrDefault(x => x.Key == option);
                if (menuOption == default) { 
                    Console.WriteLine("*** Invalid Option ***");
                    Console.ReadKey();
                    continue;
                }

                Console.Clear();
                menuOption.Trigger();
                Console.WriteLine();
                Console.ReadKey();
            }
        }
        private static string ShowMenuAndGetKey()
        {
            Console.Clear();
            Console.WriteLine("##### DESIGN PATTERNS #####");
            Console.WriteLine();

            var groupName = string.Empty;
            foreach(var opt in _menuOptions) {

                if (groupName != opt.GroupName) 
                {
                    Console.WriteLine();
                    Console.WriteLine($"  {opt.GroupName.ToUpper()}");
                    groupName = opt.GroupName;
                }

                Console.WriteLine($"  {opt.Key} - {opt.Description}");
            }

            Console.WriteLine();
            Console.WriteLine("  q - Exit");
            Console.WriteLine();
            Console.Write("Choose an option and press enter: ");
            return Console.ReadLine();
        }
        private static void SeedMenuOptions()
        {
            _menuOptions = new List<MenuOption>()
            {
                new MenuOption("1", "Abstract Factory", "Creational", AbstractFactoryExecutor.Execute),
                new MenuOption("2", "Factory Method", "Creational", FactoryMethodExecutor.Execute),
                new MenuOption("3", "Singleton", "Creational", SingletonExecutor.Execute),
                new MenuOption("4", "Adapter", "Structural", AdapterExecutor.Execute),
                new MenuOption("5", "Facade", "Structural", FacadeExecutor.Execute),
                new MenuOption("6", "Composite", "Structural", CompositeExecutor.Execute),
                new MenuOption("7", "Command", "Behavorial", CommandExecutor.Execute),
            };
        }
    }
    public class MenuOption
    {
        public MenuOption(string key, string description, string groupName, Action trigger)
        {
            Key = key;
            Description = description;  
            GroupName = groupName;
            Trigger = trigger;
        }
        public string Key { get; private set; }
        public string Description { get; private set; }
        public string GroupName { get; set; }
        public Action Trigger { get; private set; }
    }
}
