/***********************************************************************
ABIE Development team
***********************************************************************/

using CsvHelper;
using Presidents.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;

namespace Presidents.DataLayer
{
    public class FileControl
    {
        public List<PresidentDto> GetPresidentsInfo()
        {
            CsvHelper.Configuration.Configuration configuration = new CsvHelper.Configuration.Configuration
            {
                AllowComments = true,
                DetectColumnCountChanges = true,
                HasHeaderRecord = false,
                Delimiter = ";",
                CultureInfo = CultureInfo.InvariantCulture
            };
            configuration.RegisterClassMap<PresidentMapper>();
            string content = GetCsv("https://globantfiles.blob.core.windows.net/files/PresidentList.csv?st=2018-10-04T22%3A57%3A32Z&se=2019-10-05T22%3A57%3A00Z&sp=rl&sv=2018-03-28&sr=b&sig=AR7ipO7sJeb5aW5tBVimHoLK0tn%2FIa5I8Fh2KUVNIJo%3D");
            TextReader textReader = new StringReader(content);
            CsvReader csvReader = new CsvReader(textReader, configuration);
            IEnumerable<PresidentDto> records = csvReader.GetRecords<PresidentDto>();
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