﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Динамическое_изменение_размеров {

    class Program {
        static void Main(string[] args) {
            List<Shoe> shoeCloset = new List<Shoe>();

            shoeCloset.Add(new Shoe() { Style = Style.Sneakers, Color = "Черный" });
            shoeCloset.Add(new Shoe() { Style = Style.Clogs, Color = "Коричневый" });
            shoeCloset.Add(new Shoe() { Style = Style.Wingtips, Color = "Черный" });
            shoeCloset.Add(new Shoe() { Style = Style.Loafers, Color = "Белый" });
            shoeCloset.Add(new Shoe() { Style = Style.Loafers, Color = "Краснй" });
            shoeCloset.Add(new Shoe() { Style = Style.Sneakers, Color = "Зеленый" });

            int numberOfShoes = shoeCloset.Count;
            foreach(Shoe shoe in shoeCloset) {
                shoe.Style = Style.Flipflops;
                shoe.Color = "Оранжевый";
                }

            shoeCloset.RemoveAt(4);

            Shoe thirdShoe = shoeCloset[2];
            Shoe secondShoe = shoeCloset[1];
            shoeCloset.Clear();

            shoeCloset.Add(thirdShoe);
            if(shoeCloset.Contains(secondShoe))
                Console.WriteLine("Удивительно!");

            Console.ReadKey();
            
            }
        }
    class Shoe {
        public Style Style;
        public string Color;
        }
    enum Style {
        Sneakers,
        Loafers,
        Sandals,
        Flipflops,
        Wingtips,
        Clogs,
        }

    }
