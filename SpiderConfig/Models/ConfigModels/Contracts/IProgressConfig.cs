using System;
using SpiderConfig.Enum;

namespace SpiderConfig.Models.ConfigModels.Contracts
{
    /// <summary>
    /// 定义一串流程中的一个操作
    /// </summary>
    public interface IProgressConfig
    {
        /// <summary>
        /// 操作名称
        /// </summary>
        public string ActionName { get; set; }
        
        /// <summary>
        /// 操作类型，用于操作记录展示，具体的操作行为在ActionBegin传入的action定义
        /// </summary> 
        public ActionTypeEnum ActionTypeEnum { get; set; }

        /// <summary>
        /// 开始操作
        /// </summary>
        /// <param name="func">具体怎么操作文本内容</param>
        /// <returns></returns>
        public string ActionBegin(Func<string> func);
    }
}