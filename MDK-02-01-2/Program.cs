namespace ConsoleApp6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Запуск программы...");
            List<Cars> cars = new();
            while (true)
            {
                string statement = "";
                Console.WriteLine("Введите 1, чтобы посмотреть все машины в автосалоне.");
                Console.WriteLine("Введите 2, чтобы посмотреть машину под номером в автосалоне");
                Console.WriteLine("Введите 3, чтобы добавить машину в автосалон");
                Console.WriteLine("Введите 4, чтобы удалить машину из автосалона");
                Console.WriteLine("Введите 5, чтобы выйти из программы.");
                statement = Console.ReadLine();
                switch (statement)
                {
                    case "1":

                        break;

                    case "2":

                        break;

                    case "3":

                        break;

                    case "4":

                        break;

                    case "5":
                        Console.WriteLine("Выход из программы...");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Неправильный ввод. Пожалуйста, выберите один из вариантов (1-5).");
                        break;
                }
            }
        }
    }

    public class Cars
    {
        private string brand, price, year, gearbox, fuel, volume, drive;

        public Cars(string brand, string price, string year, string gearbox, string fuel, string volume, string drive)
        {
            this.brand = brand;
            this.price = price;
            this.year = year;
            this.gearbox = gearbox;
            this.fuel = fuel;
            this.volume = volume;
            this.drive = drive;
        }

        public void Output()
        {
            Console.WriteLine($"Марка: {brand}\nЦена: {price}\nГод: {year}\nКПП: {gearbox}\nТопливо: {fuel}\nОбъём: {volume}\nПривод: {drive}\n");
        }
    }
}