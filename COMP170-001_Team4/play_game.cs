using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCS
{
    public class Room1
    {
        public static void Test()
        {
            Iri(); //
        }
        public static void Iri() //Room name.
        {
            Inventory items = new Inventory(); //What the user has in his inventory that he can use
            Inventory objects = new Inventory(); //Items in the room that can be examined
            int counter = 1; //Used for the for loop that allows the user to continuously enter commands.
            int deathcount = 0; //Certain things add to the deathcount. Once it hits 2, you die.
			int cheesecount = 1;//This is just so a different response comes out if you eat the cheese a second time.
            string prompt = "";
			string begin = UI.PromptLine (">> ");
			if (begin == "begin") { 
				ForReader (0, 5);
            for (int i = 0; i < counter; i++) //The forloop the user goes through continously to enter commands.
            {
                prompt = UI.PromptLine(">> ");
                Console.WriteLine();
					counter++; //Helps make an endless loop (at least till break; is used for the user to get out).
					if (prompt == "read note") {
						ForReader (16, 18);

					} else if (prompt == "look around") {
						ForReader (18, 29);

					} else if (prompt == "help") {
						ForReader (5, 16);

					} else if ((prompt == "examine bookshelf") && (items.CheckInventory ("Bookshelf") == false)) {
						ForReader (35, 39);
						items.Additem (new Item ("Bookshelf", "It's a bookshelf"));
					
					} else if (prompt == "examine poster") {
						ForReader (39, 42);
					} else if (prompt == "examine book" || prompt == "grab book" || prompt == "examine red book") {
						ForReader (42, 46);

					} else if ((prompt == "examine bookshelf closer" || prompt == "examine bookshelf") && items.CheckInventory ("Bookshelf")) {
						ForReader (46, 53);

					} else if (prompt == "move bookshelf") {
						ForReader (55, 58);

					} else if ((prompt == "use hammer on vulnerable wall") && (items.CheckInventory ("Hammer") == true)) {
						ForReader (58, 61);

					} else if (prompt == "examine coatrack" || prompt == "examine coat rack") {
						ForReader (61, 63);

					} else if (prompt == "examine coat" || prompt == "examine trench coat") {
						ForReader (63, 65);

					} else if (prompt == "examine hammer") {
						if (objects.CheckInventory ("Hammer") == false) {
							objects.Additem (new Item ("Hammer", "It appears to have blood on it, and be durable. Might be useful."));
						}
						objects.ExamineItem ("Hammer");

					} else if (prompt == "pickup hammer") {
						if (items.CheckInventory ("Hammer") == false) {
							items.Additem (new Item ("Hammer", "It appears to have blood, and be durable. Might be useful."));
							ForReader (31, 33);
						} else
							ForReader (76, 78);
					
					} else if (items.CheckInventory ("Hammer") && (prompt == "use hammer on wall")) {
						ForReader (53, 55);

					} else if (items.CheckInventory ("Hammer") && (prompt == "use hammer on poster")) {
						items.AddMagic ("Hammer");
						objects.AddMagic ("Hammer");
						items.Additem (new Item ("Magic Hammer", "The hammer is infused with a special kind of magic that has the glowing word 'break;' written all over it. You feel the power surge through you, feeling like you can break anything."));
						items.ExamineItem ("Magic Hammer");

					} else if ((prompt == "examine magic hammer") && items.CheckInventory ("Magic Hammer")) {
						items.ExamineItem ("Magic Hammer");
					} else if (prompt == "examine desk") {
						ForReader (65, 70);

					} else if (prompt == "examine journal") {
						if (objects.CheckInventory ("Journal") == false) {
							objects.Additem (new Item ("Journal", "A brown leather journal. The insides note the use of scientific experiments including a hammer, and what appears to be a poster."));
						}
						objects.ExamineItem ("Journal");

					} else if (prompt == "pickup journal") {
						if (items.CheckInventory ("Journal") == false) {
							items.Additem (new Item ("Journal", "A brown leather journal. The insides note the use of scientific experiments including a hammer, and what appears to be a poster."));
							ForReader (131, 133);
						} else
							ForReader (76, 78);
					
					} else if (prompt == "examine drawer" || prompt == "open drawer") {
						ForReader (70, 74);

					} else if (prompt == "examine screwdriver") {
						if (objects.CheckInventory ("Screwdriver") == false) {
							objects.Additem (new Item ("Screwdriver", "A cross type screwdriver."));
						}
						objects.ExamineItem ("Screwdriver");

					} else if (prompt == "pickup screwdriver") {
						if (items.CheckInventory ("Screwdriver") == false) {
							items.Additem (new Item ("Screwdriver", "A cross type screwdriver."));
							ForReader (74, 76);
						} else
							ForReader (76, 78);
					
					} else if (prompt == "examine computer") {
						ForReader (78, 82);
					} else if (prompt == "examine paper clips") {
						ForReader (82, 85);
					} else if (prompt == "pickup pen") {
						if (items.CheckInventory ("Pen") == false) {
							items.Additem (new Item ("Pen", "A blue PaperMate pen."));
							ForReader (85, 87);
						} else
							ForReader (76, 78);
					} else if (prompt == "examine pen") {
						if (objects.CheckInventory ("Pen") == false) {
							objects.Additem (new Item ("Pen", "A blue PaperMate pen."));
						}
						objects.ExamineItem ("Pen");
					} else if (prompt == "examine scissors") {
						if (objects.CheckInventory ("Scissors") == false) {
							objects.Additem (new Item ("Scissors", "A pair of elementary grade scissors that are too dull to cut anything. Literally worthless."));
						}
						objects.ExamineItem ("Scissors");

					} else if (prompt == "examine gun") {
						if (objects.CheckInventory ("Gun") == false) {
							objects.Additem (new Item ("Gun", "An AWP with one bullet left. Use the bullet wisely."));
							objects.ExamineItem ("Gun");
						}
						objects.ExamineItem ("Gun");

					} else if (prompt == "pickup gun" || prompt == "pickup AWP" || prompt == "pickup awp") {
						if (items.CheckInventory ("Gun") == false) {
							items.Additem (new Item ("Gun", "An AWP with one bullet left. Use the bullet wisely."));
							ForReader (89, 91);
						} else
							ForReader (76, 78);
					
					} else if ((prompt == "use gun on myself") && (items.CheckInventory ("Gun"))) {
						ForReader (91, 93);
						break;

					} else if ((prompt == "use gun on wall") && (items.CheckInventory ("Gun"))) {
						ForReader (93, 96);
						items.AddMagic ("Gun");
						objects.AddMagic ("Gun");
						deathcount++;
						ForReader (133, 134);
						Console.WriteLine (3 - deathcount);

					} else if ((prompt == "use gun on poster") && (items.CheckInventory ("Gun"))) {
						ForReader (96, 100);
						objects.AddMagic ("Gun");
						items.AddMagic ("Gun");
						items.Additem (new Item ("Magic Gun", "The gun is now infused with the word 'break' all over it. This might help you escape. You have an infinite amount of bullets."));
						items.ExamineItem ("Magic Gun");
						ForReader (100, 102);

					} else if ((prompt == "use magic gun on vulnerable wall") && (items.CheckInventory ("Magic Gun"))) {
						ForReader (102, 104);
						items.Additem (new Item ("Escape", "Used to escape the room."));

					} else if ((prompt == "use magic hammer on vulnerable wall") && (items.CheckInventory ("Magic Hammer"))) {
						ForReader (102, 104);
						items.Additem (new Item ("Escape", "Used to escape the room."));
					} else if ((prompt == "escape room") && (items.CheckInventory ("Escape"))) {
						ForReader (104, 106);
						break;

					} else if (prompt == "examine cheese") {
						ForReader (106, 108);
					} else if (prompt == "use cheese" || prompt == "eat cheese") {
						if ((prompt == "use cheese" || prompt == "eat cheese") && (cheesecount == 1)) {
							deathcount++;
							cheesecount++;
							ForReader (108, 111);
							ForReader (133, 134);
							Console.WriteLine (3 - deathcount);
						} else if ((prompt == "use cheese" || prompt == "eat cheese") && (cheesecount == 2)) {
							ForReader (111, 115);
							deathcount++;
							ForReader (133, 134);
							Console.WriteLine (3 - deathcount);
							if (deathcount >= 3) {
								ForReader (115, 117);
								Environment.Exit (3);
							}
						}
					} else if (deathcount >= 2) {
						ForReader (115, 117);
						Environment.Exit (3);
					} else if (prompt == "use apple" || prompt == "eat apple") {
						deathcount++;
						ForReader (117, 121);
						ForReader (133, 134);
						Console.WriteLine (3 - deathcount);
					} else if (prompt == "use bed" || prompt == "sleep on bed" || prompt == "nap") {
						deathcount++;
						ForReader (121, 127);
						ForReader (133, 134);
						Console.WriteLine (3 - deathcount);

					} else if (prompt == "examine rug" || prompt == "use rug") {
						deathcount++;
						ForReader (127, 131); 
						ForReader (133, 134);
						Console.WriteLine (3 - deathcount);
					} else if (prompt == "punch wall" || prompt == "kick wall") {
						ForReader (53, 55);
					} else if (prompt == "check inventory" || prompt == "inventory") {
						items.PrintInventory ();
					} else if (prompt == "examine bed") {
						ForReader (135, 139);
					}
                else
                    ForReader(29, 31);
            }
        }
		}
        public static void ForReader(int adder, int number)
        {
            StreamReader first_reader = new StreamReader("reader_room1.txt");
            var everything = first_reader.ReadToEnd();
            first_reader.Close();
            string[] everyline = everything.Split('\n');
            while (adder < number)
            {
                Console.WriteLine(everyline[adder]);
                adder++;
            }
        }
    }
}


