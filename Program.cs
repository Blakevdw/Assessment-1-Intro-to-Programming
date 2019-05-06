using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_1
{
	class DiceRollProgram
	{
		public static int ChosenRandom { get; private set; }

		static int RollTheDice(Random rndObject)
		{




			int nr = rndObject.Next(1, 7);

			return nr;
		}

		static void Main(string[] args)
		{
			Random rnd = new Random();
			List<int> Dices = new List<int>();

			Console.WriteLine("\nHello There! Want to Play a little game?");
			Console.WriteLine("Look to the Following instructions below this text!");
			Console.WriteLine("Good luck!");

			bool go = true;
			while (go)
			{

				Console.WriteLine("\n\t[1] Roll the dice\n" +
					"\t[2] Look at your results\n" +
					"\t[3] Terminate the Program");


				Console.Write("\tChoose: ");
				int choose;
				int.TryParse(Console.ReadLine(), out choose);

				switch (choose)
				{
					case 1:
						Console.Write("\n\tHow many dices do you want to roll?: ");
						bool input = int.TryParse(Console.ReadLine(), out int number);

						if (input)
						{
							for (int i = 0; i < number; i++)
							{
								Dices.Add(RollTheDice(rnd));
							}
						}

						break;
					case 2:
						Console.WriteLine("\n\tDices have been rolled: ");

						foreach (int dice in Dices)
						{
							Console.WriteLine("\t" + dice);
						}

						break;
					case 3:
						Console.WriteLine("\n\tThank you for rolling the dice!");
						System.Threading.Thread.Sleep(1000);

						int[] arr = new int[] { 5, 5, 5 };

						int sum = 0;
						foreach (var item in arr)
						{
							sum += item;
						}

						Console.WriteLine("The Total is {0}", sum);
						Console.ReadLine();
							
						int count = 6;

						int[] numbers = new int[count];

						for (int i = 0; i < count; i++)
						{

							numbers[i] = rnd.Next(1, 6);
						}

						double avg = numbers.Average();

						Console.WriteLine("The average is: {0}", avg);
						Console.ReadLine();


						go = false;
						break;



					default:
						Console.WriteLine("\n\tChoose between 1-3 in the above menu.");
						break;



				}
				Console.ReadKey(true);
				Console.ReadLine();
			}

		}

	}
}