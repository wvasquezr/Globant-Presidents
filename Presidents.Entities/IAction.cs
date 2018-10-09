/***********************************************************************
ABIE Development team
***********************************************************************/

using Presidents.Common;
using System.Collections.Generic;

namespace Presidents.Entities
{
    public interface IAction
    {
        List<PresidentDto> GetPresidentsInfo(PresidentFieldEnum sortBy, bool isDescending = false);
    }
}