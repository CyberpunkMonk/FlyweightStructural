using System;
using System.Collections;

namespace FlyweightStructural {
    class MainApp {
        static void Main() {
            //Arbitrary Extrinsic state
            int extrinsicstate = 22;

            FlyweightFactory factory = new FlyweightFactory();

            //Work with different flyweight instances
            Flyweight fx = factory.GetFlyweight("X");
            fx.Operation(--extrinsicstate);
            Flyweight fy = factory.GetFlyweight("Y");
            fy.Operation(--extrinsicstate);
            Flyweight fz = factory.GetFlyweight("Z");
            fz.Operation(--extrinsicstate);

            UnsharedConcreteFlyweight fu = new UnsharedConcreteFlyweight();
            fu.Operation(--extrinsicstate);

            //wait for user
            Console.ReadKey();
        }
    }
}