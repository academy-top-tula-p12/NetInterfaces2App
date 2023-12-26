using NetInterfaces2App;
using System.Threading.Channels;

IMovable movable = new Transport();
movable.Move();
movable = new Car();
movable.Move();

Transport transport = new Transport();
transport.Move();
transport = new Car();
transport.Move();

Car car = new Car();
car.Move();

Animal animal = new Animal();
IMovable movableAnimal = animal;
(animal as IMovable).Move();
movableAnimal.Move();

IGroundMovable movableGroundAnimal = animal;
(animal as IGroundMovable).Move();
movableGroundAnimal.Move();

//
Message message = new("Hello world");
Messanger<Message> messanger = new Messanger<Message>();
messanger.Send(message);
//

User<Passport> user = new User<Passport>();

struct Passport
{
    public string Series { set; get; }
    public int Number { set; get; }
}

interface IMovable
{
    void Move() => Console.WriteLine("Object move!");
}

interface IGroundMovable : IMovable
{
    new void Move() => Console.WriteLine("Object move on ground!");
}

class Transport : IMovable
{
    public void Move() => Console.WriteLine("Transport move!");
}

class Car : Transport
{
    public new void Move()
    {
        Console.WriteLine("Car move!");
    }
}

class Animal : IGroundMovable
{
    //public void Move()
    
}





