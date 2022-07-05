using System;
using System.Collections.Generic;
using System.Text;

namespace TrainApp
{

        public static class TrainApi
    {
        public static Train GetSingleTrain(string trainName)
        {
            string urlParams = trainName;
            var response = ApiHelpers.RunAsync<Train>(url, urlParams);

            return response;
        }
    }
    {
    }
}
