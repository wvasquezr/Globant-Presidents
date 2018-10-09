/***********************************************************************
ABIE Development team
***********************************************************************/

using Presidents.Common;
using Presidents.Entities;
using System.Collections.Generic;

namespace Presidents.BusinessLayer
{
    public class PresidentControl : IAction
    {
        //protected IAction Action;

        //public PresidentControl(IAction action)
        //{
        //    Action = action;
        //}

        public List<PresidentDto> GetPresidentsInfo(PresidentFieldEnum sortBy, bool isDescending = false)
        {
            return UnityImplementation.FileControl.GetPresidentsInfo(sortBy, isDescending);
        }
    }
}