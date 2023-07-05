using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.Classes
{
    internal class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }
        public Motorcycle(string make, string model, int year, bool hasSidecar) : base(make, model, year)
        {
            HasSidecar = hasSidecar;
        }
        public override string ToString() => $"Motocycle: {base.Make}, {base.Model}, {base.Year}, {HasSidecar}";
    }
}
