//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2020 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using GameFramework.Resource;
using UnityEngine;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

namespace GameMain
{
    public class ProcedureSplash : ProcedureBase
    {
        public bool SplashOver;

        protected override void OnEnter(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);
            //先设置一下默认字体
            UGuiForm.SetMainFont(GameEntry.BuiltinData.DefaultFont);
            // TODO: 增加一个 Splash 动画，这里先跳过
            SplashOver = true;
        }


        protected override void OnUpdate(ProcedureOwner procedureOwner, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);

            if (SplashOver)
            {
                //是编辑器资源模式或者Package资源模式时直接进入ProcedurePreload中
                ChangeState(procedureOwner,
                    GameEntry.Base.EditorResourceMode || GameEntry.Resource.ResourceMode == ResourceMode.Package ? typeof(ProcedurePreload) : typeof(ProcedureCheckVersion));
            }
        }
    }
}