using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketing_ideas
{
    public class ServiceAnalyzer : Analyzer
    {
        public List<string> headlineformat = new List<string>();
        public List<string> discriptionformat = new List<string>();

        public  int KeyWordAnalyzer(List<string> KeyWords, List<string> Headers,string location,string service,int choice)
        {
            List<int> HeadLine = new List<int>();
            int count = 0;
            KeyWords.Add(location); 
            KeyWords.Add(service);
            int scorecount = 0;
            foreach (string line in Headers)
            {
                int num = 0;
                List<string> words = new List<string>(line.Split(' '));
                foreach (string word in words)
                {
                    
                    foreach (string keyword in KeyWords)
                        if (word.Contains(keyword))
                        { scorecount++;
                            num++;
                        }
                        else { scorecount = scorecount + 0;
                            num = num + 0;
                        }
      
                }
                HeadLine.Add(num);
                count++;
                if (choice == 1)
                {
                    headlineformat.Add($"{count}. {line} score {HeadLine[count - 1]}");
                }
                else if (choice == 2) 
                
                { discriptionformat.Add($"{count}. {line} score {HeadLine[count - 1]}"); }

            }
            return (scorecount);
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
            if (type == "header")
            {
                if (item > num)
                {
                    string message = "You have enough keywords in your Headers";
                    return message;
                }
                else
                {
                    string message = "You don't have enough keywords in your header";
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

            return "Invalid type";  // default return value in case type is not "header" or "description"
        }
    }
}
