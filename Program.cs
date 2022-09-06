using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            fxs.MainColor = "White";
            Tesla modelS = new Tesla();
            modelS.MainColor = "Pink";
            Cessna mx410 = new Cessna();
            mx410.MainColor = "Black";
            Ram r1500 = new Ram();
            r1500.MainColor = "Rust";
            fxs.Drive();
            fxs.Turn();
            fxs.Stop();

            modelS.Drive();
            modelS.Turn();
            modelS.Stop();

            mx410.Drive();
            mx410.Turn();
            mx410.Stop();

            r1500.Drive();
            r1500.Turn();
            r1500.Stop();
        }
    }
}

