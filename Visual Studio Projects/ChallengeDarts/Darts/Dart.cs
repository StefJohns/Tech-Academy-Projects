using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    public class Dart
    {   
        //must have an instance of the Random class
        private Random _rndm;
        public int Points { get; set; }
        //create the public bools for the pointMultiplier
        public bool IsDouble { get; set; }
        public bool IsTriple { get; set; }

        //need a dart to reference in other documents
        public Dart(Random random)
        {
            _rndm = random;
        }

        //must have a Throw() method
        public void Throw()
        {
            Points = _rndm.Next(0, 21);

            int pointMultiplier = _rndm.Next(1, 101);

            if (pointMultiplier > 90 && pointMultiplier < 95)
                IsDouble = true;
            else if (pointMultiplier > 95)
                IsTriple = true;
        }

    }
}
