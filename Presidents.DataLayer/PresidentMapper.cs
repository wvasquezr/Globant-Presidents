/***********************************************************************
ABIE Development team
***********************************************************************/

using CsvHelper.Configuration;
using Presidents.Common;
using Presidents.Entities;

namespace Presidents.DataLayer
{
    internal sealed class PresidentMapper : ClassMap<PresidentDto>
    {
        public PresidentMapper()
        {
            Map(m => m.Name).ConvertUsing(row => row.GetField<string>(0).StripNullString());
            Map(m => m.BirthDay).ConvertUsing(row => row.GetField<string>(1).ValidateDateTime());
            Map(m => m.BirthPlace).ConvertUsing(row => row.GetField<string>(2).StripNullString());
            Map(m => m.DeathDay).ConvertUsing(row => row.GetField<string>(3).ValidateNullDateTime());
            Map(m => m.DeathPlace).ConvertUsing(row => row.GetField<string>(4).StripNullString());
        }
    }
}