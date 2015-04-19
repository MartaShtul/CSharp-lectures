using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            var goodPupil = new GoodPupil();
            var badPupil = new BadPupil();
            var room = new ClassRoom(goodPupil, badPupil, goodPupil);

            room.DoStudy();
            room.DoRead();
            room.DoWrite();
            room.DoRelax();

            Console.ReadLine();
        }
    }

    class ClassRoom
    {
        Pupil[] _pupils;

        public ClassRoom(params Pupil[] pupils)
        {
            if (pupils.Length < 1 || pupils.Length > 4)
            {
                _pupils = new Pupil[0];
            }
            else
            {
                _pupils = pupils;
            }
        }

        public void DoStudy()
        {
            for (int i = 0; i < _pupils.Length; i++)
            {
                _pupils[i].Study();
            }
        }

        public void DoRead()
        {
            for (int i = 0; i < _pupils.Length; i++)
            {
                _pupils[i].Read();
            }
        }

        public void DoWrite()
        {
            for (int i = 0; i < _pupils.Length; i++)
            {
                _pupils[i].Write();
            }
        }

        public void DoRelax()
        {
            for (int i = 0; i < _pupils.Length; i++)
            {
                _pupils[i].Relax();
            }
        }

    }

    class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("PUPIL STUDY");
        }

        public virtual void Read()
        {
            Console.WriteLine("PUPIL READ");
        }

        public virtual void Write()
        {
            Console.WriteLine("PUPIL WRITE");
        }

        public virtual void Relax()
        {
            Console.WriteLine("PUPIL RELAX");
        }
    }

    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Good pupil is stading");
        }
        public override void Read()
        {
            Console.WriteLine("Good pupil is reading");
        }
        public override void Write()
        {
            Console.WriteLine("Good pupil is writing");
        }
        public override void Relax()
        {
            Console.WriteLine("Good pupil is NEVER RELAXING");
        }
    }

    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Bad pupil is NEVER STUDING");
        }
        public override void Read()
        {
            Console.WriteLine("Bad pupil cant read");
        }
        public override void Write()
        {
            Console.WriteLine("Bad pupil is writing song");
        }
        public override void Relax()
        {
            Console.WriteLine("Bad pupil is relaxing all the time");
        }
    }
}
