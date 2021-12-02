using System;
using System.Collections.Generic;

namespace SpiderConfig.Models.ConfigModels.Implements
{
    /// <summary>
    /// 工程主体配置部分
    /// </summary>
    public class ProjectConfig
    {
        /// <summary>
        /// 配置Id
        /// </summary>
        public int Id { get; set; }          
        
        /// <summary>
        /// 工程名称
        /// </summary>
        public string? ProjectName { get; set; }
        
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        
        /// <summary>
        /// 入口站点
        /// </summary>
        public List<string> Entrance { get; set; } = new();
        
        /// <summary>
        /// 域名约束
        /// </summary>
        public string? Constraint { get; set; }

        /// <summary>
        /// 流程配置
        /// </summary>
        public List<ProcessConfig> ProcessConfigs { get; set; }

    }

}