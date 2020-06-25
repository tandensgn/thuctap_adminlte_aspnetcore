using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTEASPNETEmployees.HttpResponse
{
    public class Response
    {
        public bool IsSuccess { get; set; }
        public string ErrorCode { get; set; }
        public string Message { get; set; }
    }
    public class ResponseURL
    {
        public bool IsSuccess { get; set; }
        public string ErrorCode { get; set; }
        public string Message { get; set; }
        public string url { get; set; }
    }
}
