using System;


class Program
{
    static void Main()
    {

		//Change this variable to set the highest number you want to calculate.

		int Limit = 255;

		//Uncomment the next two lines set the Limit at runtime.

		//Console.WriteLine("Set the highest number you want to calculate");
		//int.TryParse(Console.ReadLine(), out Limit);

        Random rnd = new();
	int Number = rnd.Next(Limit);
	Console.WriteLine("Convert this number to Hexadecimal: " +  Number);
	bool Correct = false;
	while(Correct == false) {
		string Answer;
		Answer = Console.ReadLine();
		Console.WriteLine(Answer);
		int Size = Answer.Length -1;
		foreach(char character in Answer) {
			int ToSub = 0;
			int Remainder = 0;
			int Multiplier = 0;
			char Character = character;
			if (Character == 'A') {ToSub = 10;}
			else if (Character == 'B') {ToSub = 11;}
			else if (Character == 'C') {ToSub = 12;}
			else if (Character == 'D') {ToSub = 13;}
			else if (Character == 'E') {ToSub = 14;}
			else if (Character == 'F') {ToSub = 15;}
			else {
			int.TryParse(Character.ToString(), out ToSub);}
			Multiplier = Convert.ToInt32(Math.Pow(16, Size));
			Size--;
			Remainder = Number - (ToSub * Multiplier);
			Number = Remainder;
			if (Remainder == 0) {Correct = true;}
		}
	}
    }
}











