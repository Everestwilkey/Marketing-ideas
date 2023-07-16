using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketing_ideas
{
        public class Menue
    {
        public Menue()
        {
            Console.WriteLine("Welcome to the Marketing One Stop!");
            Console.WriteLine("What are you looking to start Marketing");
            Console.WriteLine("1. Products");
            Console.WriteLine("2. Services");
            Console.Write("Write you number here: ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    GoogleProduct googleProduct = new GoogleProduct();
                    ProductAnalyzer productAnalyzer = new ProductAnalyzer();
                    List<string> keywords1 = new List<string>(googleProduct.GetKeyWords());
                    List<string> features = new List<string>(googleProduct.GetGoogleProductFeature());
                    string productId = googleProduct.GetGoogleProuductId();
                    string productName = googleProduct.GetProductname();
                    string productDescription = googleProduct.GetProductdescription();
                    string productTitel = googleProduct.GetGoogleProductTitel();
                    int featuregoal = productAnalyzer.KeyWordAnalyzer(keywords1, features);
                    int titelgoal = productAnalyzer.DescriptionProuductAnalyzer(keywords1, productTitel);
                    int desgoal = productAnalyzer.DescriptionProuductAnalyzer(keywords1, productDescription);
                    string productmes = productAnalyzer.KeyWordNumbers(keywords1, 25);
                    string recommendationfeature = productAnalyzer.Recommendation(featuregoal, 5, "feature");
                    string recommendationtitel = productAnalyzer.Recommendation(titelgoal, 3, "titel");
                    string recommendationdescriptoin = productAnalyzer.Recommendation(desgoal, 6, "description");
                    Console.WriteLine();
                    Console.ReadKey();
                    Console.WriteLine($"Name:{googleProduct.Getname()}");
                    Console.WriteLine($"Title:{googleProduct.GetGoogleProductTitel()}");
                    Console.WriteLine($"this is the Score {titelgoal}");
                    Console.WriteLine(recommendationtitel);
                    Console.WriteLine();
                    foreach (string i in productAnalyzer.format)
                    {
                        Console.WriteLine(i);
                    }
                    Console.WriteLine($"this is the Score {featuregoal}");
                    Console.WriteLine(recommendationfeature);
                    Console.WriteLine();
                    Console.WriteLine($"product description{googleProduct.GetProductdescription()}");
                    Console.WriteLine($"this is the Score {desgoal}");
                    Console.WriteLine(recommendationdescriptoin);
                    Console.ReadKey();


                    break;

                case "2":
                    GoogleService service = new GoogleService();
                    ServiceAnalyzer analyzer = new ServiceAnalyzer();
                    List<string> keywords = new List<string>(service.GetKeyWords());
                    List<string> headers = new List<string>(service.GetGoogleHeadLines());
                    List<string> description = new List<string>(service.GetGoogleDiscrioptions());
                    string typeOfService = service.GetService();
                    string location = service.GetLocation();
                    int headerscore = analyzer.KeyWordAnalyzer(keywords, headers, location, typeOfService, 1);
                    int descriptionscore = analyzer.KeyWordAnalyzer(keywords, description, location, typeOfService, 2);
                    string message = analyzer.KeyWordNumbers(keywords, 25);
                    string recommendationheader = analyzer.Recommendation(headerscore, 3, "header");
                    string recommendationdescription = analyzer.Recommendation(descriptionscore, 5, "description");
                    Console.WriteLine();
                    Console.ReadKey();
                    Console.WriteLine($"Name:{service.Getname()}");
                    Console.WriteLine($"generic discription:{service.Getdescription()}");
                    Console.WriteLine();
                    foreach (string item in analyzer.headlineformat)
                    { Console.WriteLine($"Google headlines:{item}"); }
                    Console.WriteLine($"this is the Score {headerscore}");
                    Console.WriteLine(recommendationheader);
                    Console.WriteLine();
                    foreach (string line in analyzer.discriptionformat)
                    { Console.WriteLine($"Google description:{line}");}
                    Console.WriteLine($"this is the Score {descriptionscore}");
                    Console.WriteLine(recommendationdescription);
                    Console.WriteLine();
                    Console.ReadKey();
                    break;
            }
        }
    }
}
