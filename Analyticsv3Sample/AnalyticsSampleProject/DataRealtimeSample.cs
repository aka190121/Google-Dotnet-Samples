 
// Copyright 2015 DAIMTO :  www.daimto.com
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by DAIMTO-Google-apis-Sample-generator 1.0.0
//     Build date: 11/30/2015 22:16:59
//     C# generater version: 1.0.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Google.Apis.Analytics.v3;
using Google.Apis.Analytics.v3.Data;

namespace DAIMTO.Analytics.v3.Sample
{
    class DataRealtimeSample
    {
		/// <summary>
        /// Returns real time data for a view (profile).
		/// Documentation: https://developers.google.com/analytics//v3/realtime/get
		/// </summary>
		/// <param name="service">Valid authentcated AnalyticsService</param>
		/// <param name="ids">Unique table ID for retrieving real time data. Table ID is of the form ga:XXXX, where XXXX is the Analytics view (profile) ID.</param>
		/// <param name="metrics">A comma-separated list of real time metrics. E.g., 'rt:activeUsers'. At least one metric must be specified.</param>
		/// <returns>RealtimeData </returns>
	    public static RealtimeData Get(AnalyticsService service, string ids, string metrics)
	    {
		    //Note Genrate Argument Exception (https://msdn.microsoft.com/en-us/library/system.argumentexception(loband).aspx)
		    try
            {  
			return 			service.Data.Realtime.Get(ids, metrics).Execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Request Failed " + ex.Message);
                throw ex;
            }
		 }
		
    }
}