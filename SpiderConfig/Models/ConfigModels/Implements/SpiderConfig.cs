using System;
using SpiderConfig.Enum;
using SpiderConfig.Models.ConfigModels.Contracts;

namespace SpiderConfig.Models.ConfigModels.Implements
{
    public class SpiderConfig:ISpiderConfig
    {
        public SpiderConfig(ISpiderDispatcherConfig spiderDispatcherConfig, 
            ISpiderProcessorConfig spiderProcessorConfig, 
            ISpiderDownloaderConfig spiderDownloaderConfig, 
            ISpiderPipelineConfig spiderPipelineConfig)
        {
            SpiderDispatcherConfig = spiderDispatcherConfig;
            SpiderProcessorConfig = spiderProcessorConfig;
            SpiderDownloaderConfig = spiderDownloaderConfig;
            SpiderPipelineConfig = spiderPipelineConfig;
        }

        public ISpiderDispatcherConfig SpiderDispatcherConfig { get; set; }
        public ISpiderProcessorConfig SpiderProcessorConfig { get; set; }
        public ISpiderDownloaderConfig SpiderDownloaderConfig { get; set; }
        public ISpiderPipelineConfig SpiderPipelineConfig { get; set; }
    }
}