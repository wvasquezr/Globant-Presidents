/***********************************************************************
ABIE Development team
***********************************************************************/

using Presidents.Common;
using Presidents.DataLayer;
using Presidents.Entities;
using System.Collections.Generic;

namespace Presidents.BusinessLayer
{
    public class PresidentControl
    {
        public List<PresidentDto> GetPresidentsInfo(PresidentFieldEnum sortBy, bool isDescending = false)
        {
            DataLayer.FileControl fileControl = new FileControl();
            return fileControl.GetPresidentsInfo(sortBy, isDescending);
        }
    }
}