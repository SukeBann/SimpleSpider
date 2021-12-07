using SpiderConfig.Models.ConfigModels.Contracts;

namespace SpiderCore.Contract
{   
    /// <summary>
    /// 负责创建SpiderCore的实例
    /// </summary>
    public interface ISpiderCoreFactory
    {
        /// <summary>
        /// 使用ISpiderConfig创建一个ISpiderCore实例
        /// </summary>
        /// <param name="spiderConfig"></param>
        /// <returns></returns>
        public ISpiderCore CreateSpiderCore(ISpiderConfig spiderConfig);
    }
}