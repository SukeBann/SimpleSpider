using System.Collections.Generic;

namespace SpiderDispatcher.Contract
{
    public interface ISpiderDispatcher
    {
        /// <summary>
        /// 链接调度器存放ISpiderRequest的字典
        /// 利用链接转换md5作为键进行访问
        /// </summary>
        public Dictionary<string, ISpiderRequest> SpiderRequests { get; set; }
    }

}