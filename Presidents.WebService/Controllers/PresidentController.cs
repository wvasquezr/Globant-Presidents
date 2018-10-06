/***********************************************************************
ABIE Development team
***********************************************************************/

using Presidents.BusinessLayer;
using Presidents.Common;
using Presidents.Entities;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Presidents.WebService.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PresidentController : ApiController
    {
        /// <summary>
        /// Gets a list of the presidents of US.
        /// </summary>
        /// <param name="sortBy">The sort by.</param>
        /// <param name="isDescending">if set to <c>true</c> [is descending].</param>
        /// <returns>List of <type>PresidentDto</type></returns>
        [HttpGet]
        public List<PresidentDto> Get(PresidentFieldEnum sortBy = PresidentFieldEnum.None, bool isDescending = false)
        {
            PresidentControl presidentControl = new PresidentControl();
            return presidentControl.GetPresidentsInfo(sortBy, isDescending);
        }
    }
}