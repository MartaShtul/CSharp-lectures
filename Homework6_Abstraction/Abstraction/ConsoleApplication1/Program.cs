using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public interface IPlayeble
    {
        void Play();
        void Pause();
        void Stop();
    }

    public interface IRecordable
    {
        void Record();
        void Pause();
        void Stop();
    }

    public class Player : IRecordable , IPlayeble
    {
        void IPlayeble.Pause()
        {
            Console.WriteLine("Playing is paused");
        }

        void IPlayeble.Stop()
        {
            Console.WriteLine("Playing is stopped");
        }

        public void Record()
        {
            Console.WriteLine("Record is started");
        }

        void IRecordable.Pause()
        {
            Console.WriteLine("Record is paused");
        }

        void IRecordable.Stop()
        {
            Console.WriteLine("Record is stopped");
        }

        public void Play()
        {
            Console.WriteLine("Playing is started");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            IPlayeble playeblaPlayer = player as IPlayeble;

            playeblaPlayer.Play();
            playeblaPlayer.Stop();
            playeblaPlayer.Pause();

            IRecordable recoPlayer = player as IRecordable;

            recoPlayer.Record();
            recoPlayer.Pause();
            recoPlayer.Stop();

            Console.ReadLine();
        }
    }
}
