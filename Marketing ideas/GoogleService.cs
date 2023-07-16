using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Marketing_ideas
{
    public class GoogleService : Service
    {
        protected string _website;
        protected string _adGoal;
        // the "g" indacates a google needed varable gheadlines is short for google headlines
        protected List<string> _gheadlines;
        protected List<string> _gdiscriptions;

        public void SetWebSite(string website)
        { _website = website; }
        public string GetWebSite()
        { return _website; }
        public void SetadGoal(string adGoal)
        { _adGoal = adGoal; }
        public string GetAdGoal()
        { return _adGoal; }
        public void SetGoogleHeadLines(List<string> ghealines)
        { _gheadlines = ghealines; }
        public List<string> GetGoogleHeadLines()
        { return _gheadlines; }
        public void SetGoogleDiscriptions(List<string> gdiscriptions)
        { _gdiscriptions = gdiscriptions; }
        public List<string> GetGoogleDiscrioptions()
        { return _gdiscriptions; }

        public void PromtGoogleHeadlines()
        {
            List<string> items = new List<string>();
            Console.WriteLine("Write 3 Headlines that are 30 chariters long");
            int times = 3;
            int counter = 0;
            while (times != counter)
            {
                string choice;
                do
                {
                    Console.Write("Enter Headline here: ");
                    choice = Console.ReadLine();
                    if (this.NumberofChariters(choice) > 90)
                    {
                        Console.WriteLine("Your input is too long. Please try again.");
                    }
                } while (NumberofChariters(choice) > 90);
                items.Add(choice);
                Console.WriteLine(items[counter]);
                counter++;
                
            }
            SetGoogleHeadLines(items);
        }
        public void PromtGoogleDiscriptions()
        {
            List<string> items = new List<string>();
            Console.WriteLine("Write 3 Headlines that are no longer than 90 characters each");
            int times = 3;
            int counter = 0;
            while (times != counter)
            {
                string choice;
                do
                {
                    Console.Write("Enter Keyword here: ");
                    choice = Console.ReadLine();
                    if (this.NumberofChariters(choice) > 90)
                    {
                        Console.WriteLine("Your input is too long. Please try again.");
                    }
                } while (NumberofChariters(choice) >= 90);
                items.Add(choice);
                counter++;
            }
            SetGoogleDiscriptions(items);
        }

        public GoogleService()
        {
            Console.WriteLine(" ********Section******** \n      'Buisness info'");
            Console.Write("What's your buissness name: ");
            this.SetName(Console.ReadLine());
            Console.Write("Write a short discription about your buisness: ");
            this.SetDescription(Console.ReadLine());
            this.PromtKeyWords();
            Console.Write("What Service do you offer *plummer* : ");
            this.SetService(Console.ReadLine());
            Console.Write("Where are you located: ");
            this.SetLocation(Console.ReadLine());
            Console.Write("Buissness phone number: ");
            this.SetPhoneNumber(Console.ReadLine());
            Console.Write("Enter Website with 'https://': ");
            this.SetWebSite(Console.ReadLine());
            Console.Write("What Ad Goal are you looking for 'Leads''Website traffic': ");
            this.SetadGoal(Console.ReadLine());
            Console.WriteLine("********Section******** \n      'Google ads Creation'");
            this.PromtGoogleHeadlines();
            this.PromtGoogleDiscriptions();
            
            
        }

    }
}
