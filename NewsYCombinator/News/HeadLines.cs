using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using OpenQA.Selenium;

namespace NewsYCombinator.News
{
    public class HeadLines : BaseClass.BaseClass
    {
        List<int> list1;
        public HeadLines()
        { 
            list1 = new List<int>();
                

        }
            
    
        public  void HeadLineList()
        {
            //Product items
            Console.WriteLine("-----------------------------HEADLINE------------------------------");
            IList<IWebElement> news = driver.FindElements(By.ClassName("storylink"));

            foreach (IWebElement topic in news)
            {
                string headLines = topic.Text;
                Console.WriteLine(headLines);

            }
        }
        public  void HeadLinePoints()
        {
           
            //Product items
            Console.WriteLine("-----------------------------POINTS------------------------------");
            IList<IWebElement> points = driver.FindElements(By.ClassName("score"));

            foreach (IWebElement point in points)
            {
                string headLinePoints = point.Text;
                Console.WriteLine(headLinePoints);
            }
            
           
        }
        public  void Display_Records()
        {

            //Product items
            IList<IWebElement> records = driver.FindElements(By.XPath("//span[@class='score']|//td[@class='title']"));

            foreach (IWebElement topic in records)
            {
                string headlinescore = topic.Text;
                Console.WriteLine(headlinescore);
            }
        }
        
        public  void  SortTheDataPointWise()
        {
            IList<IWebElement> points = driver.FindElements(By.ClassName("score"));
            foreach (IWebElement point in points)
            {
                 string headLinePoints = point.Text;
                //Console.WriteLine(headLinePoints);
                string input = headLinePoints;
                string[] numbers = Regex.Split(input, @"\D+");
                foreach (string value in numbers)
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        int i = int.Parse(value);
                        //Console.WriteLine(i);
                       // List<int> list1 = new List<int>();
                        list1.Add(i);
                        Console.WriteLine("Points: {0}", i);
                        

                    }
                   
                }
                

            }
            HighestPoint();
        }
        public  void HighestPoint()
        {
            var res = list1.OrderByDescending(g => g).Take(1);
            foreach(var g in res)
            {
                Console.WriteLine("Highest Point:{0}", g);
            }


        }
                

    }
}
