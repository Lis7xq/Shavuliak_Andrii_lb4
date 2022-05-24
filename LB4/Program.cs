using System;
using System .Linq;

namespace LB4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PaperBook paperBook = new PaperBook();
            Ebook ebook = new Ebook();
            Grafiti grafiti = new Grafiti();
            Page page = new Page();
            
            Console.WriteLine("1 - Book 2 - Book(info)" + "\n" + "3 - Ebook" + "\n" + "4 - Graffiti"+ "\n" + "5 - Page");
            bool breake = false;
            do
            {
                switch (Console.ReadLine())
                {
                    case "1": paperBook.words(); break;
                    case "2": Console.WriteLine(paperBook.ToString()); break;
                    case "3": Console.WriteLine(ebook.ToString());break;
                    case "4": Console.WriteLine(grafiti.ToString()); break;
                    case "5": Console.WriteLine(page.ToString()); break;

                    default: Console.WriteLine(""); break;
                }
            } while (!breake);

        }
    }
    public abstract class Text
    {
        public string font { get; set; }
        public virtual int pages { get; set; }
        public string tcolor { get; set; }
    }
    
    public class PaperBook : Text
    {


        public PaperBook()
        {
            
            font = "Times new Roman";
            pages = 100;
            tcolor = "arial grey";
        }
        
        public int words()
        {
            
            Console.WriteLine("Enter text");
            string input = Console.ReadLine();

            int ind = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input.Substring(i, 1) != " ")
                    ind++;
            }
            Console.WriteLine("number of letters {0}", ind);
            

            
            Console.WriteLine("enter character:");
            string s = Console.ReadLine();
            int count = input.ToCharArray().Where(c => c == s[0]).Count();
            Console.WriteLine(count);
            

            return ind;

        }

        public override string ToString()
        {
            return "Amount of pages - " + this.pages + "; Font - " + this.font + "; Text color - " + this.tcolor;
            
        }


    }

    public class Ebook : Text
    {
        public Ebook()
        {

            font = "Carlic";
            
            tcolor = "arial white";

        }

        public override string ToString()
        {
            return "Font - " + this.font + "; Text color - " + this.tcolor;

        }

    }

    public class Grafiti : Text
    {

        public Grafiti()
        {

            font = "Robotic";
            
            tcolor = "green";

        }

        public override string ToString()
        {
            return "Font - " + this.font + "; Text color - " + this.tcolor;

        }

    }

    public class Page : Text
    {

        public Page()
        {

            font = "Calibri";
            pages = 1;
            tcolor = "arial dark";

        }


        public override string ToString()
        {
            return "Amount of pages - " + this.pages + "; Font - " + this.font + "; Text color - " + this.tcolor;

        }

    }
}
