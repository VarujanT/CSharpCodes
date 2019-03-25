public override void Move()
        {
            int temp = rd.Next(1, 101);
            if (temp <= 25) X += 4;
            else if (temp <= 40) X += 2;
            else if (temp <= 60) X -= 2;
            else if (temp <= 70) X -= 1;
        }