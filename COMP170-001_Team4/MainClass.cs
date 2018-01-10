using System;
using System.IO;
using System.Collections.Generic;

namespace IntroCS
{
	public class PlayEscapeGame
	{
		public static void Main (string [] args) //Beginning narrative/story of the game, including basic user directions.
		{
			StreamReader reader = new StreamReader ("game_introduction.txt");// reads in the introduction
			var allLines = reader.ReadToEnd ();
			reader.Close ();
			string [] lines = allLines.Split('\n');
			foreach (string line in lines){
				Console.WriteLine (line);
			}

			Console.WriteLine ("You will begin this game shortly, good luck"); // used this line as a transition from user directions to game play
			Room1.Test();



		}
	}
}




