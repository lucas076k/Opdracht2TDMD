using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data
{
    public class Light
    {
        public string Name { get; set; }
    }
    public class LightState
    {
        public bool On { get; set; }
        public int Bri { get; set; }
        public int Hue { get; set; }
        public int Sat { get; set; }
    }
}
