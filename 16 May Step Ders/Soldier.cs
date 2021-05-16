using System;

namespace _16_May_Step_Ders
{
    public abstract class Soldier
    {
        public int HP { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }

        public void Attack()
        {
            Console.WriteLine($"{Name} attacked and damaging {Damage}.");
        }
        public void Defend()
        {
            Console.WriteLine($"{Name} defending and has health {HP} point.");
        }

    }
}
