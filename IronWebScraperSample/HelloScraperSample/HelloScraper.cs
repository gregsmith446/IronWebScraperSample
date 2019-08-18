using IronWebScraper;

namespace IronWebScraperSample.HelloScraperSample
{
    public class HelloScraper : WebScraper
    {
        // the Init() method initializes your web-scraper.
        // Request at least one start url... and set allowed/banned domain or url patterns.

        public override void Init()
        {
            License.LicenseKey = "LicenseKey"; // Write License Key
            this.LoggingLevel = WebScraper.LogLevel.All; // All Events Are Logged
            this.Request("https://blog.scrapinghub.com", Parse);
        }

        //  this method creates the default Response handler for your web scraper.
        /// If you have multiple page types, you can add additional similar methods.

        public override void Parse(Response response)
        {
            // Loop on all Links
            foreach (var title_link in response.Css("h2.entry-title a"))
            {
                // Read Node's Text
                string strTitle = title_link.TextContentClean;
         
                // Save Result to File
                System.Console.WriteLine(strTitle);
            }

            // Loop On All Links
            if (response.CssExists("div.prev-post > a[href]"))
            {
                // Get Link URL
                var next_page = response.Css("div.prev-post > a[href]")[0].Attributes["href"];
                // Scrape Next URL
                this.Request(next_page, Parse);
            }
        }
    }
}
