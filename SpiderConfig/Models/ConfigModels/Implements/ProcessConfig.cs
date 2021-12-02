using System;
using SpiderConfig.Enum;
using SpiderConfig.Models.ConfigModels.Contracts;

namespace SpiderConfig.Models.ConfigModels.Implements
{
    public class ProcessConfig:IProgressConfig
    {
        public ProcessConfig(string actionName, ActionTypeEnum actionTypeEnum)
        {
            ActionName = actionName;
            ActionTypeEnum = actionTypeEnum;
        }

        public string ActionName { get; set; }
        
        public ActionTypeEnum ActionTypeEnum { get; set; }
        
        public string ActionBegin(Func<string> action)
        {
            return action.Invoke();
        }
    }
}