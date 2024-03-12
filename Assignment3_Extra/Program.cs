using Assignment3_Extra.Problem1;
using Assignment3_Extra.Problem2;
using Assignment3_Extra.Problem3;
using Assignment3_Extra.Problem4;
using Assignment3_Extra.Problem4.Exceptions;

namespace Assignment3_Extra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to the system\n");

                 /* //Problem 1

                    Person person = new Person("Emre", 25);
                    Child child = new Child("Emre Child", 14);

                    Console.WriteLine(person.ToString());
                    Console.WriteLine(child.ToString());
                */


                /* //Problem 2

                    Book book = new Book("Title", "Emre", 11.2);
                    GoldenEditionBook goldenEditionBook = new GoldenEditionBook("Gold Title", "Emre gold", 12.0);

                    Console.WriteLine(book.ToString());
                    Console.WriteLine(goldenEditionBook.ToString());
                */


                /* //Problem 3

                    Student student = new Student("Peter", "Svensson", "0812111");
                    Console.WriteLine(student.ToString());

                    Worker worker = new Worker("Stefan", "Mk321",1590,10);
                    Console.WriteLine(worker.ToString());
                
                */



                /* //Problem 4

                    int numberofsongs = int.Parse(Console.ReadLine());

                    PlayList playList = new PlayList();

                    for (int i = 0; i < numberofsongs; i++)
                    {
                        string[] songinfo = Console.ReadLine().Split(";");

                        string artist = songinfo[0];
                        string name = songinfo[1];

                        string[] lengths = songinfo[2].Split(":");

                        int minutes = int.Parse(lengths[0]);
                        int seconds = int.Parse(lengths[1]);

                        try
                        {
                            playList.AddSong(new Song(artist, name, minutes, seconds));
                        }

                        catch (InvalidSongException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }

                    playList.PrintPlayListInfo();

                */

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
    }
}
