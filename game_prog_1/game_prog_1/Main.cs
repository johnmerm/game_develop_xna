using System;

namespace game_prog_1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World! This application will calculate your average gold-collecting performance");
			Console.Write ("What is your sum of gold you have collected:");
			int gold = int.Parse (Console.ReadLine ());
			Console.Write ("After how many hours (can be a decimal float):");
			float hours = float.Parse (Console.ReadLine ());
			float minutes = hours * 60;
			float goldPerMin = gold / minutes;
			Console.WriteLine ("You've collected " 
			                   + gold + " pieces in " + hours + " hours." +
			                   	"Your rate is " + goldPerMin + " pieces per minute");





		}
	}
}
