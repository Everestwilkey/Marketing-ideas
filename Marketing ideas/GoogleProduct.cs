using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketing_ideas
{
    internal class GoogleProduct : Product
    {
        protected List<string> _gproductfeature;
        protected string _gproductid;
        protected string _gproductWebsite;
        protected string _gproducttitel;

        public void SetGoogleProductFeature(List<string> features)
        { _gproductfeature = features; }
        public List<string> GetGoogleProductFeature()
        { return _gproductfeature; }
        public void SetGoogleProductId(string productid)
        { _gproductid = productid; }
        public string GetGoogleProuductId()
        { return _gproductid; }
        public void SetGoogleProductWebsite(string Website)
        { _gproductWebsite = Website; } 
        public string GetGoogleProductWebsite()
        { return _gproductWebsite; }
        public void SetGoogleProductTitel(string titel)
        { _gproducttitel = titel; }
        public string GetGoogleProductTitel()
        { return _gproducttitel; }

        public void Promptforfeatures()
        {
            {
                List<string> items = new List<string>();
                Console.Write("how many Features:");
                int times = int.Parse(Console.ReadLine());
                int conter = 0;
                while (times != conter)
                {
                    Console.Write("Enter Feature: ");
                    string choice = Console.ReadLine();
                    items.Add(choice);
                    conter++;

                }
                SetGoogleProductFeature(items);
            }
        }

        public GoogleProduct()
        {
            
          Console.WriteLine(" ********Section******** \n      'Buisness info'");
          Console.Write("What's your buissness name: ");
          this.SetName(Console.ReadLine());
          Console.Write("Write a short discription about your buisness: ");
          this.SetDescription(Console.ReadLine());
          this.PromtKeyWords();
          Console.Write("What is your product name: ");
          this.SetProductname(Console.ReadLine());
          Console.Write("Write a short description about a product: ");
          this.SetProductdescription(Console.ReadLine());
          Console.Write("What is your product category: ");
          this.SetProductcategory(Console.ReadLine());
          this.Promptforfeatures();
          Console.Write("What is your product ID: ");
          this.SetGoogleProductId(Console.ReadLine());
            Console.Write("What is your product Website with 'https://': ");
          this.SetGoogleProductWebsite(Console.ReadLine());
            Console.Write("What is your product Title:");
          this.SetGoogleProductTitel(Console.ReadLine());
        }


    }
}
