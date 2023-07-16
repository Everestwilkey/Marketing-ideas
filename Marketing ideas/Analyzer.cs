using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketing_ideas
{
      public abstract class Analyzer
    {
        private int _score = 0;
        public void SetScore(int score)
        { _score = score; }
        public int GetScore()
        { return _score; }

        public abstract string KeyWordNumbers(List<string> keywords, int num);
        public abstract string Recommendation(int item, int num, string type);
        
    }
}
