﻿using System;
using System.Collections.Generic;
using System.Text;
using Ubiety.Dns.Core.Common;

namespace mabextendedFETest.Utility
{
    public class APIResponse
    {
        public APIResponse()
        {

        }
        public APIResponse(ResponseCode code, string message, object data = null)
        {
            Code = code;
            Message = message;
            Document = data;
        }
        public ResponseCode Code { get; set; }
        public string Message { get; set; }
        public object Document { get; set; }

    }
    public enum ResponseCode
    {
        ERROR = 0,
        SUCCESS = 1
    }

}
