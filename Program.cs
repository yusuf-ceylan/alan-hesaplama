using System;

namespace alan_hesaplama
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("İşem yapılmak istenen geometrik şekil: ");
            string shape = Console.ReadLine().ToLower();

            Shape shapes;

            switch (shape)
            {
                case "daire":
                    Console.WriteLine("Dairenin yarıçapını giriniz: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    shapes = new Circle(radius);
                    break;

                case "üçgen":
                    Console.WriteLine("1. kenarın uzunluğunu giriniz: ");
                    double Tside1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("2. kenarın uzunluğunu giriniz: ");
                    double Tside2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("3. kenarın uzunluğunu giriniz: ");
                    double Tside3 = Convert.ToDouble(Console.ReadLine());
                    shapes = new Triangle(Tside1, Tside2, Tside3);
                    break;

                case "kare":
                    Console.WriteLine("Kenar uzunluğunu giriniz: ");
                    double Sside = Convert.ToDouble(Console.ReadLine());
                    shapes = new Square(Sside);
                    break;

                case "dikdörtgen":
                    Console.WriteLine("Kısa kenarı giriniz: ");
                    double width = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Uzun kenarı giriniz: ");
                    double height = Convert.ToDouble(Console.ReadLine());
                    shapes = new Rectangle(width, height);
                    break;

                default:
                    Console.WriteLine("Seçtiğiniz geometrik şekil bulunamıyor! Lütfen geçerli bir geometrik şekil seçiniz!");
                    return;
            }

            Console.WriteLine("Hesaplamak istediğiniz boyutu seçin: ");
            string calculationType = Console.ReadLine().ToLower();

            double Result = 0;

            switch (calculationType)
            {
                case "alan":
                    Result = shapes.calArea();
                    break;

                case "çevre":
                    Result = shapes.calPerimete();
                    break;
                default:
                    Console.WriteLine("seçim algılanamadı. Lütfen çevre veya alan seçeneklerini kullanınız!");
                    return;
            }

            Console.WriteLine(Result);

        }
    }
}
