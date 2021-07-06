using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuXin.Lis.API.Models
{
    public class ResponseBase
    {
        public Int32 Code { get; set; } = 0;
        public String Msg { get; set; } = "success";

        //public ResponseBase(Int32 Code, String Msg)
        //{
        //    this.Code = Code;
        //    this.Msg = Msg;
        //}
    }

    public class ResponseData<T> : ResponseBase
    {
        public T Data { get; set; }
    }
}