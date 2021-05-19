using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite root = new Composite();
            Composite branch = new Composite();
            Player player = new Player();
            Mountain mountain = new Mountain();
            branch.Add(mountain);
            root.Add(player);
            root.Add(branch);
            root.Draw();
        }
    }
}
