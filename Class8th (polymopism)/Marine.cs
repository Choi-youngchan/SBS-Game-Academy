
namespace Class8th__polymopism_
{
    internal class Marine : Unit
    {
        private int steamPack;
        public Marine()
        {
            health = 40;
            attack = 6;
            defense = 0;

            steamPack = 5;

            Console.WriteLine("Create Marine");
        }

        override public void Show()
        {
            Console.WriteLine("health 변수의 값 : " + health);
            Console.WriteLine("attack 변수의 값 : " + attack);
            Console.WriteLine("defense 변수의 값 : " + defense);
        }

        new public void Skill()
        {
            Console.WriteLine("Steam Pack");
        }

    }
}
