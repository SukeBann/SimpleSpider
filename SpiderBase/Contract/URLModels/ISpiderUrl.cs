using System.Security.Cryptography;

namespace SpiderBase.Contract.URLModels
{
    /// <summary>
    /// 调度器处理的Url封装对象，
    /// Url传入后处理为Request 被下载器成功下载后填充 Response
    /// </summary>
    public interface ISpiderUrl
    {
        /// <summary>
        /// 计算源链接md5值作为UrlKey 用于排重与作为链接调度器 Request字典的键
        /// </summary>
        public string UrlKey { get; }
        
        /// <summary>
        /// 原始链接
        /// </summary>
        public string OriginUrl { get; set; }

        /// <summary>
        /// 是否为Request
        /// </summary>
        public bool IsRequest { get; }
        
        /// <summary>
        /// 是否为Response
        /// </summary>
        public bool IsResponse { get; }
        
        /// <summary>
        /// 封装的请求
        /// </summary>
        public ISpiderRequest? SpiderRequest { get; }
        
        /// <summary>
        /// 请求成功的响应
        /// </summary>
        public ISpiderResponse? SpiderResponse { get; }
        
        
        
    }
}