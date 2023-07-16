using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketing_ideas
{
    internal class Product: Advertisement
    {
        protected string _productname;
        protected string _productdescription;
        protected string _productcategory;

        public void SetProductname(string name)
        { this._productname = name; }
        public string GetProductname()
        { return this._productname; }
        public void SetProductdescription(string description) 
        {  this._productdescription = description; }
        public string GetProductdescription()
        { return this._productdescription; }
        public void SetProductcategory(string category)
        { this._productcategory = category; }
        public string GetProductcategory()
        { return this._productcategory; }


    }
}
