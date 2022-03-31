using System;

namespace Paintball
{
    class Program
    {
        static void Main(string[] args)
        {
            PaintballGun gun = new PaintballGun(20, 16, false);


            while (true)
            {
                Console.WriteLine($"{gun.Balls} balls, {gun.BallsLoaded} loaded");

                if (gun.IsEmpty())
                {
                    Console.WriteLine("WARNING! You're out of ammo!");
                }

                Console.WriteLine("SPACE to shoot, r to reload, + to add ammo, q to quit");

                char key = Console.ReadKey(true).KeyChar;

                switch (key)
                {
                    // space key
                    case ' ':
                        Console.WriteLine($"Shooting returned {gun.Shoot()}");
                        break;
                    case 'r':
                        gun.Reload();
                        break;
                    case '+':
                        gun.Balls += gun.MagazineSize;
                        break;
                    case 'q':
                        return;
                }

            }

        }
    }
}
