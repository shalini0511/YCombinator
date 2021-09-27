using NUnit.Framework;

namespace NewsYCombinator
{
    public class Tests:BaseClass.BaseClass
    {

        [Test, Order(1)]
        public void DisplayHeadLines()
        {
            News.HeadLines news = new News.HeadLines();
            news.HeadLineList();
            news.HeadLinePoints();
            news.Display_Records();
            news.SortTheDataPointWise();

        }
    }
}