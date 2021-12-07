using System.Security.Cryptography;

namespace SpiderBase.Contract.URLModels
{
    public interface ISpiderRequest
    {
        /// <summary>
        /// 原始链接
        /// </summary>
        public string OriginUrl { get; set; }
    
        /// <summary>
        /// 计算源链接md5值作为UrlKey 用于排重与作为链接调度器 Request字典的键
        /// </summary>
        public string UrlKey { get; }
        
        
        
    }
}