using System.Collections.Generic;
using System;
using System.Linq;
using System.Reflection;



namespace IFix.Config
{
    [Configure]
    public class GameMainConfig
    {
        [IFix]
        static IEnumerable<Type> hotfix
        {
            get
            {
                
                //用linq+反射返回某命名空间下的所有类型
                return (from type in Assembly.Load("Assembly-CSharp").GetTypes()
                    where type.Namespace == "GameMain"
                    select type).ToList();
            }
        }
    }
    [Configure]
    public class CustomConfig
    {
        [IFix]
        static IEnumerable<Type> hotfix
        {
            get
            {
                return new List<Type>()
                {
                };
            }
        }
    }
}