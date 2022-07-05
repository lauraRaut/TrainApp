using System;
using System.Collections.Generic;
using System.Text;
using APIHelpers;

namespace TrainApp
{

        public static class TrainApi
    {
        const string url = "https://rata.digitraffic.fi/api/v1/";
        public static Train GetSingleTrain(string trainName)
        {
            string urlParams = trainName;
            var response = ApiHelper.RunAsync<Train>(url, urlParams).GetAwaiter().GetResult();

            return response;
        }
    }
    
    }

