using System;

namespace Csharp
{
    // 객체(OOP Object Oriented Programming)

    //Knight

    // 속성 : hp attack pos
    // 기능 : Move Attack Die

    class Knight
    {
        static public int counter = 1; // 오로지 1개만 존재!

        public int id;
        public int hp;
        public int attack;

        public Knight()
        {
            id = counter;
            counter++;

            hp = 100;
            attack = 10;
            Console.WriteLine("생성자 호출!");
        }

        public Knight(int hp) : this()
        {
            this.hp = hp;
            Console.WriteLine("int 생성자 호출!");
        }

        public Knight(int hp, int attack) : this()
        {
            this.hp = hp;
            this.attack = attack;
            Console.WriteLine("int, int 생성자 호출!");
        }
        public Knight Clone()
        {
            Knight knight = new Knight();
            return knight;
        }
        public void Move()
        {
            Console.WriteLine("Knight Move");
        }
        public void Attack()
        {
            Console.WriteLine("Knight Attack");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight(50, 5);

            Knight knight2 = knight.Clone();


            knight.Move();
            knight.Attack();
           
        }
    }
}
