using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Creational.Singleton.Singleton
{
    public sealed class Cache
    {
        private static readonly Cache _instance = new Cache();
        private readonly Dictionary<string, string> _entries;
        private Cache()
        {
            _entries = new Dictionary<string, string>();
        }
        public void AddEntry(string key, string value)
        {
            Console.WriteLine($"AddEntry: {key}:{value}");
            _entries.Add(key, value);
        }
        public string GetValue(string key)
        {
            return _entries.GetValueOrDefault(key);
        }
        public IEnumerable<string> GetEntries()
        {
            return _entries.Select(x => $"{x.Key}:{x.Value}");
        }
        public static Cache GetInstance()
        {
            return _instance;
        }
    }
}
