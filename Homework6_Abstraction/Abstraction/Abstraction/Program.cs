using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class AbstractHandler{
        public abstract void Open();
        public abstract void Save();
        public abstract void Change();
        public abstract void Create();
    }

    public class TxtHandler : AbstractHandler
    {

        public override void Open()
        {
            Console.WriteLine("TXT Opened");
        }

        public override void Save()
        {
            Console.WriteLine("TXT Saved");
        }

        public override void Change()
        {
            Console.WriteLine("TXT Changed");
        }

        public override void Create()
        {
            Console.WriteLine("TXT Created");
        }
    }

    public class XMLHandler : AbstractHandler
    {

        public override void Open()
        {
            Console.WriteLine("XML Opened");
        }

        public override void Save()
        {
            Console.WriteLine("XML Saved");
        }

        public override void Change()
        {
            Console.WriteLine("XML Changed");
        }

        public override void Create()
        {
            Console.WriteLine("XML Created");
        }
    }

    public class DOCHandler : AbstractHandler
    {

        public override void Open()
        {
            Console.WriteLine("DOC Opened");
        }

        public override void Save()
        {
            Console.WriteLine("DOC Saved");
        }

        public override void Change()
        {
            Console.WriteLine("DOC Changed");
        }

        public override void Create()
        {
            Console.WriteLine("DOC Created");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            AbstractHandler doc = new DOCHandler();

            doc.Change();

            AbstractHandler xml = new XMLHandler();

            xml.Create();

            AbstractHandler txt = new TxtHandler();

            txt.Open();
        }
    }
}
