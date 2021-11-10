using System;
using System.Collections.Generic;


namespace ex3
{
    class Pentagon
    {
        private List<ValueTuple<double, double>> penta; //struct wil be better
        public Pentagon()
        {
            penta = new List<ValueTuple<double, double>>();
        }
        public void AddPoint(ValueTuple<double, double> p)
        {
            if (this.penta.Count < 5)
                this.penta.Add(p);
        }
        public double GetArea()
        {
            if (this.penta.Count != 5)
            {
                Console.WriteLine("Error");
                return double.NaN;
            }
            else
            {
                double S = this.penta[0].Item1 * this.penta[1].Item2 +
                    this.penta[1].Item1 * this.penta[2].Item2 +
                    this.penta[2].Item1 * this.penta[3].Item2 +
                    this.penta[3].Item1 * this.penta[4].Item2 +
                    this.penta[4].Item1 * this.penta[0].Item2 -
                    this.penta[1].Item1 * this.penta[0].Item2 -
                    this.penta[2].Item1 * this.penta[1].Item2 -
                    this.penta[3].Item1 * this.penta[2].Item2 -
                    this.penta[4].Item1 * this.penta[3].Item2 -
                    this.penta[0].Item1 * this.penta[4].Item2;
                S = Math.Abs(S / 2);
                return S;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            char pointAlpha = 'A';

            Pentagon myPenta = new Pentagon();

            while (pointAlpha != 'F')
            {
                Console.Write("Input {0} coordinates: ", pointAlpha);
                string a = Console.ReadLine();
                if (a == "q")
                    break;
                else
                {
                    (double X, double Y) point;
                    string[] coord = a.Split(";");
                    point.X = double.Parse(coord[0]);
                    point.Y = double.Parse(coord[1]);
                    pointAlpha++;
                    myPenta.AddPoint(point);
                }
            }

            Console.WriteLine("Area is: {0}", myPenta.GetArea());

        }
    }
}