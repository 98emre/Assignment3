using Assignment3.Animals;
using Assignment3.Birds;
using Assignment3.Errors;
using Assignment3.Persons;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Welcome to the system");

                //Person person = new Person();
                //person.Age = -25;
                //person.FName = "Emre";
                //person.LName = "Demirel";
                //person.Height = 177;
                //person.Weight = 95;

                //Console.WriteLine(person.toString());

                //PersonHandler personHandler = new PersonHandler();
                //Person person = personHandler.CreatePerson(25, "Emre2", "Demirel2", 177, 95);

                //Console.WriteLine(personHandler.GetPersonInfo(person));
                //personHandler.SetAge(person,30);
                //personHandler.SetWeight(person,85);
                //personHandler.SetFirstName(person,"Real Emre");
                //personHandler.SetLastName(person, "Real Demirel");

                //Console.WriteLine(personHandler.GetPersonInfo(person));

                //Person person2 = personHandler.CreatePerson(-100, "New Emre2", "New Demirel2", 177, 95);
                //Console.WriteLine(person2.toString());

                //List<UserError> errors = new List<UserError>();
                //errors.Add(new NumericInputError());
                //errors.Add(new TextInputError());
                //errors.Add(new AdminError());
                //errors.Add(new LoginError());
                //errors.Add(new EmailError());

                //foreach (var error in errors)
                //{
                //    Console.WriteLine(error.UEMessage());
                //}

                List<Animal> animals = new List<Animal>();
                animals.Add(new Dog("Houndoom", 50, 8, "Labrador"));
                animals.Add(new Horse("Arceus", 100, 5, "White"));
                animals.Add(new Hedgehog("Sonic", 30, 12, 20));
                animals.Add(new Wolf("Arcanine", 50, 8, true));
                animals.Add(new Worm("Weedle", 3,1,true));
               

                animals.Add(new Bird("Pidgeotto", 5.1, 10, true));
                animals.Add(new Flamingo("Moltres", 10, 6, true,false));
                animals.Add(new Pelican("Zapdos", 12, 8,true, false));
                animals.Add(new Swan("Articuno", 11, 10, true, true));


                animals.Add(new Wolfman("Darkness", 95, 25, true));

                foreach (Animal animal in animals)
                {
                    Console.WriteLine(animal.Stats());
                    animal.DoSound();
                    Console.WriteLine();

                    if (animal is IPerson)
                    {
                        IPerson iPerson = (IPerson)animal;
                        iPerson.Talk();
                        Console.WriteLine();
                    }
                }

                animals.Add(new Dog("Entei", 50, 8, "Legendary"));
                animals.Add(new Dog("Raikou", 65, 8, "Legendary"));
                animals.Add(new Dog("Suicune", 60, 10, "Legendary"));

                foreach (Animal animal in animals)
                {
                    if (animal is Dog)
                    {
                        Dog dog = (Dog)animal;
                        Console.WriteLine(dog.DogFact());
                    }
                }

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error message: {ex.Message}");
            }
        }
    }
}
