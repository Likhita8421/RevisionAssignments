
Console.WriteLine("1.Constructor\n2.Inheritance\n3.Polymorphism\n4.Abstraction\n5.Exception\n6.Interface\n");
Console.WriteLine("Enter Your Choice:");
int choice = Convert.ToInt32(Console.ReadLine());

switch(choice)
{
    case 1:
        OopsConcepts.Car Mahindra = new OopsConcepts.Car();
        Console.WriteLine(Mahindra.model);  // Print the value of model
        break;

    case 2:
        OopsConcepts.Dog beagle = new OopsConcepts.Dog();        // object of derived class

        beagle.dogName = "Daisy";                  // access field and method of base class
        beagle.display();

        beagle.getName();                         // access method from own class

        Console.ReadLine();

        break;

    case 3:
        OopsConcepts.Employee[] emp = new OopsConcepts.Employee[4];
        {
            emp[0] = new OopsConcepts.Employee();
            emp[1] = new OopsConcepts.PartTimeEmployee();
            emp[2] = new OopsConcepts.FullTimeEmployee();
            emp[3] = new OopsConcepts.TemporaryEmployee();

            foreach (var employee in emp)
            {
                employee.PrintFullName();
            }
        }
        break;

    case 4:
        {
            OopsConcepts.Laptop laptop = new OopsConcepts.Laptop();
            laptop.Brand = "Dell";
            laptop.Model = "Inspiron 14R";
            laptop.LaptopDetails();
        }
        break;

    case 5:
        OopsConcepts.Class1 exception = new OopsConcepts.Class1();
        exception.exception();
        break;

    case 6:
        OopsConcepts.Cat cat = new OopsConcepts.Cat();
        cat.animalSound();

        break;
    default:
        Console.WriteLine("Enter valid Option.");
        break;

}
