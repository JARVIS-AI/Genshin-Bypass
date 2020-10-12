using System;
using System.Diagnostics;

namespace Genslich
{
    public static class Genslich
    {
        static Genslich()
        {
            Console.WriteLine("DLL MAIN (Only DLL_PROCESS_ATTACH) :D");
        }
    }
}
