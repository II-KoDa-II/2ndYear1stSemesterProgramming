using System;
using System.Xml;

namespace Lab1 {
	class Program {
		static void Main(string[] args) {

			int switcher;
			
			Console.WriteLine("Select the task:\n\n" +

				"1\nShip moves with speed ν1 meters / sec in a stale water.\n" +
				"Boat travels through moving ship's L meters length in t seconds.\n" +
				"Find boat's ν2 speed relative to water (absolute speed).\n\n" +
				
				"2\nLibrary's card index for each book contains the following data:\n" +
				"Title, Author, Number of copies, Publishing year.\n" +
				"Output books' data of a selected author and count a number of book copies, published in a selected year.\n\n");

			switcher = Convert.ToInt32(Console.ReadLine());
			switch (switcher) {
				default:
				Console.WriteLine("\nTask chosen incorrectly.");
				break;
				
				case 1:
				
				double ShipSpeed_nu1;
				double ShipLength_L;
				double TravelTime_t;

				double RelativeSpeed_nur;
				double BoatSpeed_nu2;

				Console.WriteLine("\nEnter ν1:");
				ShipSpeed_nu1 = Convert.ToDouble(Console.ReadLine());

				Console.WriteLine("\nEnter L:");
				ShipLength_L = Convert.ToDouble(Console.ReadLine());

				Console.WriteLine("\nEnter t:");
				TravelTime_t = Convert.ToDouble(Console.ReadLine());

				if (ShipSpeed_nu1 < 0 || ShipLength_L <= 0 || TravelTime_t <= 0) {
					Console.WriteLine("\n\nEntered incorrect data:\n");
					
					if (ShipSpeed_nu1 < 0 || ShipLength_L < 0 || TravelTime_t < 0) {
						Console.WriteLine("One or more values are negative");
					}
					if (ShipLength_L == 0) {
						Console.WriteLine("Your ship is missing at least 1 dimension");
					}
					if (TravelTime_t == 0) {
						Console.WriteLine("Even light has travel time");
					}

					break;
				}

					RelativeSpeed_nur = ShipLength_L / TravelTime_t;
				Console.WriteLine("\n\nRelative speed νr\n" +
					"= " + ShipLength_L + " / " + TravelTime_t + " = " + RelativeSpeed_nur);

				BoatSpeed_nu2 = RelativeSpeed_nur + ShipSpeed_nu1;
				Console.WriteLine("\nRelative speed νr\n" +
					"= " + ShipLength_L + " + " + TravelTime_t + " = " + BoatSpeed_nu2 + "\n");

				break;



				case 2:

				int ID;
				string Title;
				string Author;
				int Copies;
				int Year;

				string InputAuthor;
				int InputYear;
				int AuthorBuffer = 0;
				int CopiesBuffer = 0;

				XmlDocument doc = new XmlDocument();
				doc.Load("XMLFile1.xml");
				XmlNodeList nodes = doc.DocumentElement.SelectNodes("/Catalog/Book");

				Console.WriteLine("\nSelect author:");
				InputAuthor = Console.ReadLine();

				Console.WriteLine("\nSelect Year:");
				InputYear = Convert.ToInt32(Console.ReadLine());

				foreach (XmlNode node in nodes) {
					ID = Convert.ToInt32(node.SelectSingleNode("ID").InnerText);
					Title = node.SelectSingleNode("Title").InnerText;
					Author = node.SelectSingleNode("Author").InnerText;
					Copies = Convert.ToInt32(node.SelectSingleNode("Copies").InnerText);
					Year = Convert.ToInt32(node.SelectSingleNode("Year").InnerText);

					if (InputAuthor == Author) {
						Console.WriteLine("\n\nTitle: " + Title +
							"\nAuthor: " + Author +
							"\nCopies: " + Copies +
							"\nYear: " + Year);

						AuthorBuffer = 1;
					}

					if (InputYear == Year) {
						CopiesBuffer += Copies;
					}
				}

				if (AuthorBuffer == 0) {
					Console.WriteLine("\n\nNo books found featuring " + InputAuthor);
				}

				Console.WriteLine("\n\nFound " + CopiesBuffer + " books released in " + InputYear);

				break;
			}
		}
	}
}
