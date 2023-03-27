using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._03hm
{
    abstract class Hero
    {
        public string name;
        public int damag;
        public int speed;
        public int hp;
        public int armor;

        abstract public void Print();
    }
    class Human : Hero
    {
        public override void Print()
        {
            name = "Human";
            damag = 20;
            speed = 20;
            hp = 150;
            armor = 0;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Attack: {damag}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Hp: {hp}");
            Console.WriteLine($"Armor: {armor}");
        }
    }
    class Elf : Hero
    {
        public override void Print()
        {
            name = "Elf";
            damag = 15;
            speed = 30;
            hp = 100;
            armor = 0;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Attack: {damag}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Hp: {hp}");
            Console.WriteLine($"Armor: {armor}");
        }
    }
    class Dworf : Hero
    {
        public override void Print()
        {
            name = "Dwarf";
            damag = 50;
            speed = 20;
            hp = 150;
            armor = 30;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Attack: {damag}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Hp: {hp}");
            Console.WriteLine($"Armor: {armor}");
        }
    }
    class Decorator : Hero
    {
        protected Hero person;

        public Decorator(Hero person)
        {
            this.person = person;
        }
        public void SetPerson(Hero person)
        {
            this.person = person;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Attack: {damag}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Hp: {hp}");
            Console.WriteLine($"Armor: {armor}");
        }
    }
    class Human_Warrior : Decorator
    {
        public Human_Warrior(Hero person) : base(person)
        {
            this.person = person;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Attack: {damag += 20}");
            Console.WriteLine($"Speed: {speed += 10}");
            Console.WriteLine($"Hp: {hp += 50}");
            Console.WriteLine($"Armor: {armor += 20}");
        }
    }
    class Swords_man : Decorator
    {
        public Swords_man(Hero person) : base(person)
        {
            this.person = person;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Damag: {damag += 40}");
            Console.WriteLine($"Speed: {speed -= 10}");
            Console.WriteLine($"Hp: {hp += 50}");
            Console.WriteLine($"Armor: {armor += 40}");
        }
    }
    class Archer : Decorator
    {
        public Archer(Hero person) : base(person)
        {
            this.person = person;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Attack: {damag}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"hp: {hp}");
            Console.WriteLine($"Armor: {armor}");
        }
    }
    class Rider : Decorator
    {
        public Rider(Hero person) : base(person)
        {
            this.person = person;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Attack: {damag}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Hp: {hp}");
            Console.WriteLine($"Armor: {armor}");
        }
    }
    class mag : Decorator
    {
        public mag(Hero person) : base(person)
        {
            this.person = person;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Attack: {damag}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Hp: {hp}");
            Console.WriteLine($"Armor: {armor}");
        }
    }
    class Alchimic : Decorator
    {
        public Alchimic(Hero person) : base(person)
        {
            this.person = person;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Attack: {damag}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Hp: {hp}");
            Console.WriteLine($"Armor: {armor}");
        }
    }
    class Ninga : Decorator
    {
        public Ninga(Hero person) : base(person)
        {
            this.person = person;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Attack: {damag}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Hp: {hp}");
            Console.WriteLine($"Armor: {armor}");
        }
    }
    class ElfWarrior : Decorator
    {
        public ElfWarrior(Hero person) : base(person)
        {
            this.person = person;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Attack: {damag}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Hp: {hp}");
            Console.WriteLine($"Armor: {armor}");
        }
    }
    class ElfMage : Decorator
    {
        public ElfMage(Hero person) : base(person)
        {
            this.person = person;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Attack: {damag}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Hp: {hp}");
            Console.WriteLine($"Armor: {armor}");
        }
    }
    class Crossbowelf : Decorator
    {
        public Crossbowelf(Hero person) : base(person)
        {
            this.person = person;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Attack: {damag}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Hp: {hp}");
            Console.WriteLine($"Armor: {armor}");
        }
    }
    class EvilMage : Decorator
    {
        public EvilMage(Hero person) : base(person)
        {
            this.person = person;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Attack: {damag}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Hp: {hp}");
            Console.WriteLine($"Armor: {armor}");
        }
    }
    class GoodMage : Decorator
    {
        public GoodMage(Hero person) : base(person)
        {
            this.person = person;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Attack: {damag}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Hp: {hp}");
            Console.WriteLine($"Armor: {armor}");
        }
    }
    class DwarfCuznets : Decorator
    {
        public DwarfCuznets(Hero person) : base(person)
        {
            this.person = person;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Attack: {damag}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Hp: {hp}");
            Console.WriteLine($"Armor: {armor}");
        }
    }
     class DwarfWarrior : Decorator
    {
        public DwarfWarrior(Hero person) : base(person)
        {
            this.person = person;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Attack: {damag}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"hpHp: {hp}");
            Console.WriteLine($"Armor: {armor}");
        }
    }
    class Client
    {
        public void SetPerson(Hero person)
        {
            person.Print();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            var a = new Human();
            client.SetPerson(a);
            Console.WriteLine();
            Human_Warrior hw = new Human_Warrior(a);
            client.SetPerson(hw);
            Console.WriteLine();
            Swords_man sw = new Swords_man(a);
            client.SetPerson(sw);
            Console.WriteLine();
            ElfMage em = new ElfMage(a);
            client.SetPerson(em);
            Console.WriteLine();
            ElfWarrior ew = new ElfWarrior(a);
            client.SetPerson(em);
            Console.WriteLine();
            DwarfCuznets dc = new DwarfCuznets(a);
            client.SetPerson(dc);
            Console.WriteLine();
            DwarfWarrior dw = new DwarfWarrior(a);
            client.SetPerson(dw);
            Console.WriteLine();
        }
    }
}