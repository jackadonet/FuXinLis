using FuXin.Lis.API.Filters;
using FuXin.Lis.BLL.Common;
using FuXin.Lis.BLL.Common.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace FuXin.Lis.API.Controllers.ZhiJiang
{
    [RoutePrefix("zhijiang/renmin")]
    public class CommDataController : BaseController
    {
        private readonly IYiChangService _yiChangService;

        public CommDataController()
        {
            _yiChangService = new YiChangService();
        }
        [HttpGet]
        [NotAuthentication]
        [Route("getlist")]
        public async Task<IHttpActionResult>  GetList()
        {
           var list = await _yiChangService.GetList();
           return Json(list);
        }
    }
}
