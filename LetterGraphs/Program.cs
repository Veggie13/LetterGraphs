using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LetterGraphs
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = new Dictionary<string, int>();
            string input = "ABCCDEFGFGDEBHFIGDGDBJFKLKMNOBIFKPDEFGJLQQCBDEBHFIGDNKBAFCCRBBSGTRLDUNKDBVJBMDWBDNMNKDFKLBNKCFXBDEFGDEBJLQQCBGAFCCPBDWNIBUFHHFMLCDSGDEBPNSKUIBWBWRBIDEBHFKSCFGSCGNHFOBSKUKFKBMNNIUFKSDBGHNIJSIDNKBSIBKNIDEHFHDTNKBQBINHFOBNKBQBINGBOBKABGDHNLIDBBKAFDESNKBFKHINKDQBINGBOBKUNDGFVDEIBBNKB";
            for (int i = 0; i < input.Length - 2; i++)
            {
                string sub = input.Substring(i, 3);
                if (!counter.ContainsKey(sub))
                    counter[sub] = 0;
                counter[sub]++;
            }

            var list = counter.ToList();
            list.Sort((p1, p2) => (p2.Value.CompareTo(p1.Value)));
            foreach (string tri in list.ConvertAll((p) => (p.Key)))
            {
                Console.WriteLine("{0}: {1}", tri, counter[tri]);
            }

            Console.ReadLine();
        }
    }
}
