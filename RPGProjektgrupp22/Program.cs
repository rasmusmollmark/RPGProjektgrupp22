namespace RPGProjektgrupp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Story();
            Queue<Dungeon> r1Queue = new Queue<Dungeon>();
            for (int i = 0; i < 4 + 1; i++)
            {
                r1Queue.Enqueue(new Dungeon());
            }
        }
    }
}