﻿using System.Collections.Generic;
using GameFramework.Procedure;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

namespace GameMain
{
    public class Procedure_Demo1_Luncher : ProcedureBase
    {
        protected override void OnEnter(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);
            GameEntry.Resource.InitResources(OnFinshed);
        }

        protected override void OnUpdate(ProcedureOwner procedureOwner, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
            if (isFinshed)
            {
                ChangeState<Procedure_Demo1_Menu>(procedureOwner);
            }
        }

        public bool isFinshed = false;

        private void OnFinshed()
        {
            GameEntry.Scene.UnloadAllScene();
            GameEntry.Scene.LoadScene("Assets/GameFrameworkDemo/Demo1_UI/Demo1_Menu.unity", this);
            isFinshed = true;
        }
    }
}