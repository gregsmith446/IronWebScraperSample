using System;
using IronWebScraper;
using IronWebScraperSample.HelloScraperSample;

namespace IronWebScraperSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Object From Hello Scrape class
            HelloScraper scrape = new HelloScraper();
            // Start Scraping
            scrape.Start();
        }
    }
}
