using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeStefan
{
    class MyDateTime
    {
        int year;
        int month;
        int day;

        public static MyDateTime Now { get {
                return new MyDateTime(2019, 9, 9);
            } }

        public MyDateTime(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }
    }

    enum PlayerType{
        Goalie,
        Defence,
        Forward
    }
    class Player
    {
        public string Namn { get; set; }
        public PlayerType Position { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var henke = new Player(); henke.Namn = "henrik Lundqvist"; henke.Position = PlayerType.Goalie;
            var foppa = new Player();foppa.Namn = "Peter Forsberg";foppa.Position = PlayerType.Forward;
            var lista = new List<Player>();
            lista.Add(henke);
            lista.Add(foppa);
            foreach (var player in lista)
                if (player.Position == PlayerType.Goalie)
                    Console.WriteLine(player.Namn);

            DateTime date = DateTime.Now;

            DateTime julAfton = new DateTime(2019, 12, 24);
            var dayOfWeek = julAfton.DayOfWeek;
            Console.WriteLine(dayOfWeek);

            Console.WriteLine("Skriv en in dag på engelska");
            var s = Console.ReadLine();
            var day = Enum.Parse(typeof(DayOfWeek), s);
            

            TimeSpan timeSpan = julAfton - date;




            Console.Write("Ange datum:");
            string input = Console.ReadLine();
            DateTime dt;



            bool ok = DateTime.TryParseExact(input, "yyyy-MM-dd", 
                CultureInfo.CurrentCulture, 
                DateTimeStyles.None, out dt);

            dt = DateTime.ParseExact(input, "yyyy-MM-dd", CultureInfo.CurrentCulture);

            
            
            var datum = DateTime.Now;

            Console.WriteLine("Ange betalningsvillkor antal dagar");
            int dagar = 30;
            var forfalloDatum = datum.AddDays(dagar);
            if (forfalloDatum.DayOfWeek == DayOfWeek.Sunday)
                forfalloDatum = forfalloDatum.AddDays(1);
            if (forfalloDatum.DayOfWeek == DayOfWeek.Saturday)
                forfalloDatum = forfalloDatum.AddDays(-1);



            Console.WriteLine(forfalloDatum);



            Console.WriteLine(datum);
            Console.WriteLine(datum.ToString("yyyy-MM-dd"));

            Console.WriteLine(datum.ToString("yyyy"));
            Console.WriteLine(datum.Year.ToString());


            Console.WriteLine(datum.ToString("hh:mm:ss"));
            Console.WriteLine(datum.ToString("h:m:s"));
        }
    }
}
