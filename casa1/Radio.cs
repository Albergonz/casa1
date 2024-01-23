using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casa1
{
    internal class Radio
    {
        public float Volume { get; set; }
        public float Aumenta()
        {
            Volume = Volume + ((10 * Volume) / 100);
            return Volume;
        }

        public float Diminuisci()
        {
            Volume = Volume - ((10 * Volume) / 100);
            return Volume;
        }
    }
}
