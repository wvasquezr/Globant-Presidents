/***********************************************************************
ABIE Development team
***********************************************************************/

using Presidents.DataLayer;
using Presidents.Entities;
using System.Collections.Generic;

namespace Presidents.BusinessLayer
{
    public class PresidentControl
    {
        public List<PresidentDto> GetPresidentsInfo()
        {
            DataLayer.FileControl fileControl = new FileControl();
            return fileControl.GetPresidentsInfo();
        }
    }
}