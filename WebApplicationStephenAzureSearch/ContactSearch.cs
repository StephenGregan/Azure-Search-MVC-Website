using Microsoft.Azure.Search;
using Microsoft.Azure.Search.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WebApplicationStephenAzureSearch
{
    public class ContactSearch
    {
        private static SearchServiceClient _searchClient;
        private static ISearchIndexClient _indexClient;
        private static string IndexName = "contactsearch";
        private static ISearchIndexClient _indexZipClient;
        private static string IndexZiptCodes = "zipcodes";

        public static string errorMeesage;

        static ContactSearch()
        {
            try
            {
                string searchServiceName = ConfigurationManager.AppSettings["SearchServiceName"];
                string apiKey = ConfigurationManager.AppSettings["SearchServiceApiKey"];

                _searchClient = new SearchServiceClient(searchServiceName, new SearchCredentials(apiKey));
                _indexClient = _searchClient.Indexes.GetClient(IndexName);
                _indexZipClient = _searchClient.Indexes.GetClient(IndexZiptCodes);
            }
            catch (Exception e)
            {
                errorMeesage = e.Message.ToString();
            }
        }

        public DocumentSearchResult Search(string searchText, string businessTitleFacet, string postingTypeFacet, string salaryRangeFacet,
            string sortType, double lat, double lon, int currentPage, int maxDistance, string maxDistanceLat, string maxDistanceLon)
        {
            try
            {
                SearchParameters sp = new SearchParameters()
                {




                };

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error message : " + ex);


            }





        }

    }
}