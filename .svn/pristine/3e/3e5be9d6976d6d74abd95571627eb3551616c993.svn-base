using FuXin.Lis.API.Filters;
using FuXin.Lis.API.Models;
using FuXin.Lis.API.Models.LaoNianRenTiJian;
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
    /// <summary>
    /// 老年人体检系统对接
    /// </summary>
    [RoutePrefix("laonianrentijian")]
    public class LaoNianRenTiJianController : BaseController
    {
        private readonly IYiChangService _yiChangService;

        private ResponseBase _responseBase;

        public LaoNianRenTiJianController()
        {
            _yiChangService = new YiChangService();
            _responseBase = new ResponseBase();
        }

        [HttpPost]
        [NotAuthentication]
        [Route("postsampleinfo")]
        public async Task<IHttpActionResult>  PostSampleInfo([FromBody]SampleInfo entity)
        {
            //_responseBase.Code = 0; _responseBase.Msg = "success";
            if (string.IsNullOrEmpty(entity.PatientNo))
            {
                _responseBase.Code = 30010;
                _responseBase.Msg= "患者编号不能为空[PatientNo]";
            }

           return Json(_responseBase);
        }
    }
}
