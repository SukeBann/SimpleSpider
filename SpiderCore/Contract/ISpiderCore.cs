using SpiderConfig.Models.ConfigModels.Contracts;
using SpiderDispatcher.Contract;
using SpiderDownloader.Contract;
using SpiderLog.Contract;
using SpiderPipeline.Contract;
using SpiderProcessor.Contract;

namespace SpiderCore.Contract
{   
    /// <summary>
    /// 整个爬虫框架的控制核心的接口定义
    /// 如需创建一个SpiderCore的实例 请使用<see cref="SpiderCore.Contract.ISpiderCoreFactory"/>
    /// </summary>
    public interface ISpiderCore
    {
        /// <summary>
        /// 运行配置
        /// </summary>
        public ISpiderConfig SpiderConfig { get; set; }

        
        #region Components
        
        /// <summary>
        /// 链接调度器
        /// </summary>
        public ISpiderDispatcher SpiderDispatcher { get; set; }
        
        /// <summary>
        /// 内容提取器
        /// </summary>
        public ISpiderProcessor SpiderProcessor { get; set; }
        
        /// <summary>
        /// 链接下载器
        /// </summary>
        public ISpiderDownloader SpiderDownloader { get; set; }
        
        /// <summary>
        /// 数据管道 负责数据后续的处理
        /// </summary>
        public ISpiderPipeline SpiderPipeline { get; set; }
        
        /// <summary>
        /// 运行日志
        /// </summary>
        public ISpiderLog SpiderLog { get; set; }
        
        #endregion
        
        
        /// <summary>
        /// 启动此控制核心
        /// </summary>
        public void StartUp();

        /// <summary>
        /// 初始化ISpiderCore
        /// </summary>
        public void InitSpiderCore();

    }

}