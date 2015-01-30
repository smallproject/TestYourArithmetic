using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Your_Arithmetic
{
    class difficulty_level
    {
        public int min { get; set; }
        public int max { get; set; }

        public difficulty_level(int level, int score)
        {
            level = score/10;

            if (level == 0)
            {
                level = 1;
            }

            min = level*10;
            max = level*20;
        }
    }
}
