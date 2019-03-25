Animal a1 = new Animal
           {
               X = 4,
               Color = ConsoleColor.Red
           };

           Animal a2 = new Animal("Chalo")
           {
               X = 2, Color = ConsoleColor.Yellow
           };

           for (int i = 0; i< 50; i++)
           {
               a1.Draw(true);
               a2.Draw();
               Thread.Sleep(150);
               a1.Draw(false);
               a2.Draw(false);
               a1.X++;
               a2.X++;

           }