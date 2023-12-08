using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BeerSong
{
    public class BeerSong
    {
        public void Sing()
        {
            int beerBottles = 99;

            for (int i = 0; i < 100; i++)
            {


                if (beerBottles == 2)
                {
                    Console.WriteLine("1 bottle of beer on the wall 1 bottle of beer.");
                    Console.WriteLine("Take 1 down and pass it around 1 bottle of beer on the wall");
                }

                else
                {
                    Console.WriteLine($" {beerBottles} bottles of beer on the wall,{beerBottles} bottle of beer.");
                    Console.WriteLine($"Take one down and pass it around, {beerBottles - 1} bottles of beer on the wall ");

                    beerBottles--;

                }


            }
        } 
                
         
    }
}