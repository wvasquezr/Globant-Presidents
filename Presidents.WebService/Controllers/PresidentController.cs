/***********************************************************************
ABIE Development team
***********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Presidents.BusinessLayer;
using Presidents.Entities;

namespace Presidents.WebService.Controllers
{
    public class PresidentController : ApiController
    {
        public List<PresidentDto> Get()
        {
            PresidentControl presidentControl = new PresidentControl();
            return presidentControl.GetPresidentsInfo();
        }
    }
}