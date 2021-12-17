using System.Collections.Generic;
using SpiderBase.Contract.URLModels;

namespace SpiderDispatcher.Contract
{
    /// <summary>
    /// SpiderDispatcher爬虫链接调度器核心定义
    /// </summary>
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
        /// <param name="spiderUrl">链接</param>
        public void AddRequest(string spiderUrl);
        
        /// <summary>
        /// 获取一个 Response
        /// </summary>
        /// <returns></returns>
        public ISpiderResponse GetResponse();

    }

}