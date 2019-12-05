using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratornay_rabota5
{
    public class ParallelSearchThreadParam
    {
        public List<string> tempList { get; set; }
        public string wordPattern { get; set; }
        public int maxDist { get; set; }
        public int ThreadNum { get; set; }

    }
}
