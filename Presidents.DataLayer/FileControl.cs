/***********************************************************************
ABIE Development team
***********************************************************************/

using CsvHelper;
using Presidents.Common;
using Presidents.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;

namespace Presidents.DataLayer
{
    public class FileControl : IAction
    {
        public List<PresidentDto> GetPresidentsInfo(PresidentFieldEnum sortByEnum, bool isDescending)
        {
            // Setup the CSV reader
            CsvHelper.Configuration.Configuration configuration = new CsvHelper.Configuration.Configuration
            {
                AllowComments = true,
                DetectColumnCountChanges = true,
                HasHeaderRecord = false,
                Delimiter = ";",
                CultureInfo = CultureInfo.InvariantCulture
            };
            configuration.RegisterClassMap<PresidentMapper>();
            // Read the CSV content
            string content = GetCsv(Parameter.PresidentsCsv);
            TextReader textReader = new StringReader(content);
            CsvReader csvReader = new CsvReader(textReader, configuration);
            IEnumerable<PresidentDto> records = csvReader.GetRecords<PresidentDto>();
            // Order the list
            if (sortByEnum != PresidentFieldEnum.None)
            {
                var propertyInfo = typeof(PresidentDto).GetProperty(sortByEnum.ToString());
                if (propertyInfo != null)
                {
                    records = isDescending
                        ? records.OrderByDescending(item => propertyInfo.GetValue(item, null))
                        : records.OrderBy(item => propertyInfo.GetValue(item, null));
                }
            }

            return records.ToList();
        }

        private string GetCsv(string url)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            StreamReader sr = new StreamReader(resp.GetResponseStream() ?? throw new InvalidOperationException());
            string results = sr.ReadToEnd();
            sr.Close();
            return results;
        }
    }
}