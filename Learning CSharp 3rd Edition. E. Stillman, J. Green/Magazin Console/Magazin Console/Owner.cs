﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin_Console {
    class Owner {
        private Jewels returnedContents;
        public void ReceiveContents(Jewels safeContents) {
            returnedContents = safeContents;
            Console.WriteLine("Thank you for returning my jewels! " + safeContents.Sparkle());
            }
        }
    }
