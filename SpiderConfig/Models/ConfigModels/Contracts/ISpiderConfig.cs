using System;
using System.Reflection.Metadata.Ecma335;
using SpiderConfig.Enum;

namespace SpiderConfig.Models.ConfigModels.Contracts
{
    /// <summary>
    /// 爬虫工程配置
    /// </summary>
    public interface ISpiderConfig
    {
        /// <summary>
        /// 链接调度器配置
        /// </summary>
        public ISpiderDispatcherConfig SpiderDispatcherConfig { get; set; }
        
        /// <summary>
        /// 内容处理器配置
        /// </summary>
        public ISpiderProcessorConfig SpiderProcessorConfig { get; set; }
        
        /// <summary>
        /// 下载器配置
        /// </summary>
        public ISpiderDownloaderConfig SpiderDownloaderConfig { get; set; }
        
        /// <summary>
        /// 数据管道配置
        /// </summary>
        public ISpiderPipelineConfig SpiderPipelineConfig { get; set; }
    }
}