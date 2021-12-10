using System.Collections.Generic;
using SpiderBase.Contract.URLModels;

namespace SpiderDispatcher.Contract
{
    public interface ISpiderDispatcher
    {
        /// <summary>
        /// 链接调度器存放ISpiderRequest的字典
        /// 利用链接转换md5作为键进行访问
        /// </summary>
        public Dictionary<string, ISpiderUrl> SpiderRequests { get; set; }

        /// <summary>
        /// 向调度器队列添加一个request
        /// </summary>
        /// <param name="spiderUrl"></param>
        public void AddRequest(ISpiderUrl spiderUrl);
        
        /// <summary>
        /// 获取一个 Response
        /// </summary>
        /// <returns></returns>
        public ISpiderUrl GetResponse();

    }

}