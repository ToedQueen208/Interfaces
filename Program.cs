namespace Interfaces
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Tiger fluffy = new Tiger(70.5f);
            Penguin penny = new Penguin(21);
            Goose jeff = new Goose(5.5f);
            Bat betty = new Bat(0.7f);

            List<Animal> animals = new List<Animal>()
             { fluffy, penny, jeff, betty };

            foreach (Animal animal in animals)
            {
                if (animal is IFly flyingAnimal)
                {
                    flyingAnimal.Fly();
                }
                if (animal is IHunt huntingAnimal)
                {
                    huntingAnimal.Hunt();
                }
                if (animal is ISwim swimmingAnimal)
                {
                    swimmingAnimal.Swim();
                }

            }
        }
    }
}
