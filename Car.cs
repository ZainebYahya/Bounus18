using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bounus18
{
    class Car
    {
        #region fields
        protected string make;
        protected string model;
        protected int year;
        protected double price;
        #endregion
        #region properties
        
        

        public string Make { set; get; }// we can do it this way or :
        
        public string Model//or this way
        {
            set { model = value; }//
            get { return model; }//


        }//

        public int Year
        {
            set
            {
                if (!Regex.Match(value.ToString(), @"^\d{2,4}$").Success)



                    throw new FormatException("Wrong year format");
                year = value;
            }
            get { return year; }
        }
        public double Price
        {
            set { price = value; }
            get { return price; }
        }
        #endregion


        #region constructor
       public Car(string carmake, string carmodel, int caryear, double carprice)
        {
            Make = carmake;
            Model = carmodel;
            Year = caryear;
            Price = carprice;
            



        }

        


        public override string ToString()
        {
            return string.Format($"\t{ Make}  \t{ Model}  \t{ Year}  \t{ Price} ");
        }



        #endregion

    }

    
    } 