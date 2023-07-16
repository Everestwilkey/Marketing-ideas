using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Marketing_ideas
{
    public class ProductAnalyzer : Analyzer
    {
        
        public List<string> format = new List<string>();

        public int totalscore;

        public int DescriptionProuductAnalyzer(List<string> KeyWords, string item1)
        {
            List<string> keywords = KeyWords;
            int scorecount = 0;
            List<string> descriptionlist = new List<string>(item1.Split(""));
            foreach (string word in descriptionlist)
            {
                foreach (string keyword in keywords)
                    if (word.Contains(keyword))
                    { scorecount++; }
                    else { scorecount = scorecount + 0; }
            }
            totalscore += scorecount;
            return scorecount;
        }

        public int KeyWordAnalyzer(List<string> KeyWords, List<string> items)
        {
            List<int> features = new List<int>();
            int count = 0;
            int i = 0;
            int scorecount = 0;
            foreach (string line in items)
            {
                int num = 0;
                List<string> words = new List<string>(line.Split(' '));
                foreach (string word in words)
                {
                    foreach (string keyword in KeyWords)
                        if (word.Contains(keyword))
                        { 
                            scorecount++;
                            num++;
                        }
                        else { 
                            scorecount = scorecount + 0;
                            num = num + 0;
                        }

                }
                features.Add(num);
                count++;
                format.Add($"{count}. {line} score {features[i]}");
                i++;

            }
            totalscore += scorecount;
            return scorecount;

        }
                public override string KeyWordNumbers(List<string> keywords, int num)
        {
            if (keywords.Count >= num)
            { string message = "You have enough keywords";
                return message;
            }
            else 
            {
                string message = "You do not have enough keywords";
                return message;
            }
        }
        public override string Recommendation(int item, int num, string type)
        {
            if (type == "feature")
            {
                if (item > num)
                {
                    string message = "You have enough keywords in your features";
                    return message;
                }
                else
                {
                    string message = "You don't have enough keywords in your features";
                    return message;
                }
            }
            else if (type == "description")
            {
                if (item > num)
                {
                    string message = "You have enough keywords in your description";
                    return message;
                }
                else
                {
                    string message = "You don't have enough keywords in your description";
                    return message;
                }
            }
            else if (type == "titel")
            {
                if (item > num)
                {
                    string message = "You have enough keywords in your titel";
                    return message;
                }
                else
                {
                    string message = "You don't have enough keywords in your titel";
                    return message;
                }
            }
            return "Invalid type";  // default return value in case type is not "header" or "description"
        }
        public void ScoreSet()
        { SetScore(totalscore); }
        
    }
}
    