using System;
using System.Xml;

namespace Lab0 {
	class Program {
		static void Main(string[] args) {
			int switcher;

			Console.WriteLine("Select the task:\n\n" +

				"1\nКорабль движется в неподвижной воде равномерно и прямолинейно со скоростью ν1 метров в секунду.\n" +
				"Катер проходит расстояние от начала до конца движущегося коробля за t секунд.\n" +
				"Определить скорость катера ν2 относительно воды (абсолютная скорость), если длина коробля L метров.\n\n" +

				"2\nКартотека библиотеки на каждую книгу имеет следующие данные:\n" +
				"Название, Автор, Количество экземпляров, Год издания.\n" +
				"Вывести данные о книгах введенного автора и подсчитать общее число экземпляров книг, выпущенных в заданном году.\n");

			switcher = Convert.ToInt32(Console.ReadLine());
			switch (switcher) {
				default:
					Console.WriteLine("\nНеправильно выбрано задание, введите 1 или 2.");
					break;

				case 1:

					double ShipSpeed_nu1;
					double ShipLength_L;
					double TravelTime_t;
					string Buffer;
					double i;

					double RelativeSpeed_nur;
					double BoatSpeed_nu2;

					Console.WriteLine("\nВведите ν1 (м/с):");
					Buffer = Console.ReadLine();
					if (!double.TryParse(Buffer, out i)) {
						Console.WriteLine("\nВведено некоректное значение:\nВведено нечисловое значение");
						break;
					}
					ShipSpeed_nu1 = Convert.ToDouble(Buffer);
					
					if (ShipSpeed_nu1 < 0) {
						Console.WriteLine("\nВведено некоректное значение:\nНе допускаются отрицательные значения");
						break;
					}

				Console.WriteLine("\nВведите L (метры):");
				Buffer = Console.ReadLine();
				if (!double.TryParse(Buffer, out i)) {
					Console.WriteLine("\nВведено некоректное значение:\nВведено нечисловое значение");
					break;
				}
				ShipLength_L = Convert.ToDouble(Buffer);

					if (ShipLength_L < 0) {
						Console.WriteLine("\nВведено некоректное значение:\nНе допускаются отрицательные значения");
						break;
					}
					if (ShipLength_L == 0) {
						Console.WriteLine("\nВведено некоректное значение:\nУ коробля отсутствует как минимум 1 измерение");
						break;
					}

					Console.WriteLine("\nВведите t (секунды):");
				Buffer = Console.ReadLine();
				if (!double.TryParse(Buffer, out i)) {
					Console.WriteLine("\nВведено некоректное значение:\nВведено нечисловое значение");
					break;
				}
				TravelTime_t = Convert.ToDouble(Buffer);

					if (TravelTime_t < 0)	{
						Console.WriteLine("\nВведено некоректное значение:\nНе допускаются отрицательные значения");
						break;
					}
					if (TravelTime_t == 0) {
						Console.WriteLine("\nВведено некоректное значение:\nДаже свет имеет время путешествия");
						break;
					}

				RelativeSpeed_nur = ShipLength_L / TravelTime_t;
				Console.WriteLine("\n\nСкорость катера относительно корабля νr (м/с)\n" +
					"= " + ShipLength_L + " / " + TravelTime_t + " = " + RelativeSpeed_nur);

				BoatSpeed_nu2 = RelativeSpeed_nur + ShipSpeed_nu1;
				Console.WriteLine("\nАбсолютная скорость катера ν2\n" +
					"= " + RelativeSpeed_nur + " + " + ShipSpeed_nu1 + " = " + BoatSpeed_nu2 + "\n");

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

				Console.WriteLine("\nСуществующие книги:");
				foreach (XmlNode node in nodes) {
					Console.WriteLine("\nID: " + node.SelectSingleNode("ID").InnerText +
						"\nНазвание: " + node.SelectSingleNode("Title").InnerText +
						"\nАвтор: " + node.SelectSingleNode("Author").InnerText +
						"\nКоличество экземпляров: " + node.SelectSingleNode("Copies").InnerText +
						"\nГод издания: " + node.SelectSingleNode("Year").InnerText);
				}

				Console.WriteLine("\n\nSelect author:");
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
						Console.WriteLine("\n\nНазвание: " + Title +
							"\nАвтор: " + Author +
							"\nКоличество экземпляров: " + Copies +
							"\nГод издания: " + Year);

						AuthorBuffer = 1;
					}

					if (InputYear == Year) {
						CopiesBuffer += Copies;
					}
				}

				if (AuthorBuffer == 0) {
					Console.WriteLine("\n\nНе найдено книг с автором " + InputAuthor);
				}

				Console.WriteLine("\n\nНайдено " + CopiesBuffer + " экземпляров книг выпущенных в " + InputYear + " году");

				break;
			}
		}
	}
}
