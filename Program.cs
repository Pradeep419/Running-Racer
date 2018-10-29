using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RunningRace
{
   public class Program
    {
        public static void Main(string[] args)
        {

            Program prog = new Program();
            String racerA = "A";
            String racerB = "B";

            String[] roadofA = new String[100];
            String[] roadofB = new string[100];
            int positionA = 0;
            int positionB = 0;
            Console.WriteLine("Race Started!!!");

            while (true)
            {
                if (roadofA[99] != null || roadofB[99] != null)
                {
                    if (roadofA[99] == racerA)
                    {
                        Console.WriteLine("A Won the Game");
                    }
                    else
                    {
                        Console.WriteLine("B Won the Game");
                    }


                    break;

                }
                    
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("A rolling the Dice!!!");
                    Thread.Sleep(2000);
                    int valueofA = prog.ValueonDice();
                    Console.WriteLine($"A Rolled {valueofA}");
                    if (valueofA == 0)
                    {
                        Console.WriteLine("U can't move");
                    }
                    else
                    {

                        if (positionA + valueofA == 99)
                        {
                            roadofA[positionA + valueofA] = racerA;
                            Console.WriteLine("A Won the game");
                            Thread.Sleep(2000);
                            break;
                        }

                        else if (positionA + valueofA > 99)
                            Console.WriteLine("Don't Move");
                        else
                        {
                            if (roadofB[positionA + valueofA] == null)
                            {
                                roadofA[positionA] = null;
                                roadofA[positionA + valueofA] = racerA;
                                positionA = positionA + valueofA;
                                Console.WriteLine($"A Moved to {positionA}");

                            }
                            else
                            {
                                roadofB[0] = racerB;
                                positionB = 0;
                                Console.WriteLine("A killed B");
                                roadofA[positionA + valueofA] = racerA;
                                positionA = positionA + valueofA;
                                Console.WriteLine($"A Moved to {positionA}");
                            }

                        }
                    }

                    Console.WriteLine(" ");
                    Console.WriteLine("B rolling the Dice");
                    Thread.Sleep(2000);
                    int valueofB = prog.ValueonDice();
                    Console.WriteLine($"B Rolled {valueofB}");
                    if (valueofB == 0)
                        Console.WriteLine("U can't move");
                    else
                    {

                        if (positionB + valueofB == 99)
                        {
                            roadofB[positionB + valueofB] = racerB;
                            Console.WriteLine("B Won the game");
                            Thread.Sleep(2000);
                            break;

                        }
                            

                        else if (positionB + valueofB > 99)
                            Console.WriteLine("Don't Move");
                        else
                        {
                            if (roadofA[positionB + valueofB] == null)
                            {
                                roadofB[positionB] = null;
                                roadofB[positionB + valueofB] = racerB;
                                positionB = positionB + valueofB;
                                Console.WriteLine($"B Moved to {positionB}");

                            }
                            else
                            {
                                roadofA[0] = racerA;
                                positionA = 0;
                                Console.WriteLine("B killed A");
                                roadofB[positionB + valueofB] = racerB;
                                positionB = positionB + valueofB;
                                Console.WriteLine($"B Moved to {positionB}");
                            }

                        }
                    }

                }

            }

        }
        public int ValueonDice()
        {

            Random r = new Random();
            int value = r.Next(0, 9);
            return value;

        }
    }
}
