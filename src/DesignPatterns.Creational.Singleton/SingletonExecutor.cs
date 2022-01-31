using DesignPatterns.Creational.Singleton.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Singleton
{
    public static class SingletonExecutor
    {
        public static void Execute()
        {
            var cache1 = Cache.GetInstance();
            var cache2 = Cache.GetInstance();
            var cache3 = Cache.GetInstance();                        
            if (cache1 == cache2 && cache2 == cache3 && cache1 == cache3)
                Console.WriteLine("Same instances");                
            
            Console.WriteLine();

            var cache = Cache.GetInstance();
            cache.AddEntry("key1", "value1");
            cache.AddEntry("key2", "value2");
            cache.AddEntry("key3", "value3");
            cache.AddEntry("key4", "value4");
            cache.AddEntry("key5", "value5");

            Console.WriteLine();

            var newCache = Cache.GetInstance();

            var entries = newCache.GetEntries();
            foreach(var entry in entries)
                Console.WriteLine($"Existing Entry: {entry}");
        }
    }
}
