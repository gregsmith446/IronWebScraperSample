using System;

namespace IronWebScraperSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Object From Hello Scrape class
            HelloScraperSample.HelloScraper scrape = new HelloScraperSample.HelloScraper();
            // Start Scraping
            scrape.Start();
        }
    }
}
