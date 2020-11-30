
using System.Collections.Generic;
using GameFramework.Procedure;
using UnityGameFramework.Runtime;
using ProcedureOwner=GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

namespace GameMain
{
    public class Procedure_Demo1_Luncher : ProcedureBase
    {
        protected override void OnEnter(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);
            GameEntry.Scene.UnloadAllScene();
            GameEntry.Scene.LoadScene("Assets/GameFrameworkDemo/Demo1_UI/Demo1_Menu.unity",this);
            ChangeState<Procedure_Demo1_Menu>(procedureOwner);
        }
    }
}
