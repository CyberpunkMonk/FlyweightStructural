using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightStructural {
    class UnsharedConcreteFlyweight:Flyweight {
        public override void Operation(int extrinsicstate) {
            Console.WriteLine($"UnsharedConcreteFlyweight: {extrinsicstate}");
        }
    }
}