namespace Interfaces
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Tiger fluffy = new Tiger(70.5f);
            //Penguin penny = new Penguin(21);
            //Goose jeff = new Goose(5.5f);
            //Bat betty = new Bat(0.7f);

            //List<Animal> animals = new List<Animal>()
            // { fluffy, penny, jeff, betty };

            //foreach (Animal animal in animals)
            //{
            //    if (animal is IFly flyingAnimal)
            //    {
            //        flyingAnimal.Fly();
            //    }
            //    if (animal is IHunt huntingAnimal)
            //    {
            //        huntingAnimal.Hunt();
            //    }
            //    if (animal is ISwim swimmingAnimal)
            //    {
            //        swimmingAnimal.Swim();
            //    }

            //}
            Tiger fluffy = new Tiger(80);
            Penguin penny = new Penguin(20.4f);
            Goose jeff = new Goose(3);
            Bat betty = new Bat(0.7f);

            Sky sky = new Sky();
            sky.AddAnimalInEnvironment(betty);
            sky.AddAnimalInEnvironment(jeff);

            sky.CheckAnimalsInEnvironment();

            Water water = new Water();
            water.AddAnimalInEnvironment(penny);
            water.AddAnimalInEnvironment(jeff);

            water.CheckAnimalsInEnvironment();

            HuntingGround huntingGround = new HuntingGround();

            huntingGround.AddAnimalInEnvironment(penny);
            huntingGround.AddAnimalInEnvironment(fluffy);
            huntingGround.AddAnimalInEnvironment(betty);
            //   huntingGround.AddAnimalInEnvironment(jeff);  jeff cant hunt but can go into the huntingground???

            huntingGround.CheckAnimalsInEnvironment();
            List<Animal> animals = new List<Animal>()
             { fluffy, penny, jeff, betty };
            CompareWeight compareWeight = new CompareWeight(false);

            animals.Sort(compareWeight);


            foreach (var animal in animals)
            {
                Console.WriteLine(animal.GetType().Name + animal.Weight.ToString());
            }


        }
    }
}
