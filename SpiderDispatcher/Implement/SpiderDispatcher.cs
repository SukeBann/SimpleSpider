using System.Collections.Generic;
using Masuit.Tools.Security;
using SpiderBase.Contract.URLModels;
using SpiderConfig.Models.ConfigModels.Contracts;
using SpiderDispatcher.Contract;

namespace SpiderDispatcher.Implement
{
    
    public class SpiderDispatcher:ISpiderDispatcher
    {
        public SpiderDispatcher(ISpiderDispatcherConfig spiderDispatcherConfig)
        {
            SpiderRequests = new();
            SpiderDispatcherConfig = spiderDispatcherConfig;
        }

        public Dictionary<string, ISpiderUrl> SpiderRequests { get; set; }
        
        /// <summary>
        /// 链接调度器配置， 在构造函数中赋值
        /// </summary>
        private ISpiderDispatcherConfig SpiderDispatcherConfig  { get; set; }

        public void AddRequest(string spiderUrl)
        {
            var urlMd5 = spiderUrl.MDString();
            
        }

        public ISpiderResponse GetResponse()
        {
            throw new System.NotImplementedException();
        }
    }
}