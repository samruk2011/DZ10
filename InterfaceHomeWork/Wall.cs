﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHomeWork
{
    class Wall:IPart
    {
        public bool IsPartComplete = false;
        int count = 0;
        public void Build()
        {
            count++;
            if (count == 4)
            {
                Console.WriteLine("-----------------------------------------\n" +
                   "|***************************************|\n" +
                   "|***************************************|\n" +
                   "|***************************************|\n" +
                   "|***************************************|\n" +
                   "|***************************************|\n" +
                   "|***************************************|\n" +
                   "|***************************************|\n" +
                   "|***************************************|\n" +
                   "|***************************************|\n" +
                   "|***************************************|\n" +
                   "|***************************************|\n" +
                   "|***************************************|\n" +
                   "|***************************************|\n");
                IsPartComplete = true;
            }

        }
    }
}
