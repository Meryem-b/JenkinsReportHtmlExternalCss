using HtmlAgilityPack;
using System;
using System.Data;
using System.IO;
using System.Linq;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Jenkins TA Job Number");
            string pageNumber = Console.ReadLine();
            var buildNumber = Int32.Parse(pageNumber);
            int passedScenarios = 0;
            int failedScenarios = 0;
            int otherScenarios = 0;

            //direkt c klasörünün altında console.jenkins dosyası olusturdum orda her şey.
            //file copy de external css için css dosyasını gösterir. Ama bunu yap
            File.Copy("C:\\console.jenkins\\ConsoleApp1\\ConsoleApp1\\style.css", "C:\\console.jenkins\\style.css", true);

            StreamWriter page = new StreamWriter(@"C:\console.jenkins\JenkinsReport.html"); // html web sayfası oluşturuyor path'e.

            for (int groupNumber = 4; groupNumber > 0; groupNumber--, buildNumber--)
            {
                HtmlWeb web = new HtmlWeb();
                HtmlDocument documentWeb = web.Load($"C:/console.jenkins/{buildNumber}/htmlreports/Extent_20Report/dashboard.html");

                var passed = documentWeb.DocumentNode.SelectNodes("/html/body/div/div/div[3]/div/div/div[1]/div[2]/div/div[3]/div[1]/small/b").First().InnerText;
                var failed = documentWeb.DocumentNode.SelectNodes("/html/body/div/div/div[3]/div/div/div[1]/div[2]/div/div[3]/div[2]/small/b[1]").First().InnerText;
                var others = documentWeb.DocumentNode.SelectNodes("/html/body/div/div/div[3]/div/div/div[1]/div[2]/div/div[3]/div[2]/small/b[2]").First().InnerText;

                passedScenarios += Int32.Parse(passed);
                failedScenarios += Int32.Parse(failed);
                otherScenarios += Int32.Parse(others);

                page.WriteLine("<div class='buildReport'>");
                page.WriteLine($"<h>Build Number: {buildNumber}</h>");
                page.WriteLine("<br>");
                page.WriteLine($"<h style='color:red;'>Group Number: {groupNumber}</h>");
                page.WriteLine("<form id ='userForm'>");
                page.WriteLine("<pre>");
                page.WriteLine($"Passed Scenarios: {passed}");
                page.WriteLine($"Failed Scenarios: {failed}");
                page.WriteLine($"Others: {others}");

                //bu alltakinde yeni sayfalar açtırıyor
                page.WriteLine($"<a href='C:/reports/{buildNumber}/htmlreports/Extent_20Report/dashboard.html' target='_blank'>");
                page.WriteLine("<button type ='button' class='btn btn-success'>Go to Jenkins Report</button>");
                page.WriteLine("</a>");
                page.WriteLine("</pre>");
                page.WriteLine("</form>");
                page.WriteLine("</div>");
            }

            Console.WriteLine("For Scenarios");
            Console.WriteLine("Passed Scenarios: " + passedScenarios.ToString());
            Console.WriteLine("Failed Scenarios: " + failedScenarios.ToString());
            Console.WriteLine("Others : " + otherScenarios.ToString());
            Console.ReadLine();

            //HTML Code
            page.WriteLine("<!DOCTYPE html>");
            //external css olacaksa böyle 
            page.WriteLine("<head>");
            page.WriteLine("<link rel='stylesheet' href='style.css'>");
            page.WriteLine("</head>");
            page.WriteLine("<body>");
            page.WriteLine("<div class='totalScenarios'>");
            page.WriteLine("<h3>Passed Scenarios: </h3> <span>" + passedScenarios + "</span>");
            page.WriteLine("<h3>Failed Scenarios: </h3> <span>" + failedScenarios + "</span>");
            page.WriteLine("<h3>Others: </h3> <span>" + otherScenarios + "</span>");
            page.WriteLine("</div>");
            page.WriteLine("</body></html>");
            page.Close();
        }

    }
}

