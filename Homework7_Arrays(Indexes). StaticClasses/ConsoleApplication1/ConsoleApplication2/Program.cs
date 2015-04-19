using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Article
    {
        private string _name;
        private string _store;
        private double _cost;

        public Article(string name, string store, double cost)
        {
            _name = name;
            _store = store;
            _cost = cost;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public void GetInfo()
        {
            Console.WriteLine("Name : {0}, Store : {1}, Cost: {2}", _name, _store, _cost);
        }
    }

    public class Store
    {
        private Article[] _articles;

        public Store(Article[] articles)
        {
            _articles = articles;
        }

        public void GetInfo(int artId)
        {
            if (artId < 0 || artId > _articles.Length - 1)
            {
                Console.WriteLine("Incorrect index");
            }
            else
            {
                _articles[artId].GetInfo();
            }
        }

        public void GetInfo(string name)
        {
            for (int i = 0; i < _articles.Length; i++)
            {
                if (_articles[i].Name == name)
                {
                    _articles[i].GetInfo();
                    return;
                }
            }

            Console.WriteLine("Nothing matched");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var arts = new Article[] {
                new Article("book", "knigga", 14.88),
                new Article("table", "ikea", 1233.23),
                new Article("plane", "aero", 40002.32)
            };
            var store = new Store(arts);

            store.GetInfo(1);
            store.GetInfo("plane");

            Console.ReadLine();
        }
    }
}
