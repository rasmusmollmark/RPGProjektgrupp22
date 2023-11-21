namespace RPGProjektgrupp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Story();
            
            for (int i = 0; i < 4; i++)
            {
                new Dungeon(i);
            }
        }
    }
}