using System;
using System.Collections.Generic;

namespace FlyweightStructural {
    class ConcreteFlyweight:Flyweight {
        public override void Operation(int extrinsicstate) {
            Console.WriteLine($"ConcreteFlyweight: {extrinsicstate}");
        }
    }
}