using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Marketing_ideas
{
    public abstract class Advertisement
    {
        protected string _name;
        protected string _description;
        protected List<string> _keywords;

        public void SetName(string name)
        {
           _name = name;  
        }

        public string Getname()
        { return _name; }

        public void SetDescription(string discription)
        { _description = discription; }

        public string Getdescription() 
        { return _description;}

        public void Setkeywords(List<string> keywords)
        { _keywords = keywords; }
        public List<string> GetKeyWords() 
        { return _keywords;}

        public void PromtKeyWords()
        {List<string> items = new List<string>();
            bool finshied = false;
            Console.Write("how many Keywords:");
            int times = int.Parse(Console.ReadLine());
            int conter = 0;
            while (times != conter)
            {
                Console.Write("Enter Keyword here: ");
                string choice = Console.ReadLine();
                items.Add(choice);
                conter++;
                
            }
            Setkeywords(items);
        }
        public int NumberofChariters(string vaule)
        { return vaule.Length; }
    }
}
