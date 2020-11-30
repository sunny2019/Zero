
using System.Collections.Generic;
using GameFramework.Procedure;
using UnityGameFramework.Runtime;
using ProcedureOwner=GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

namespace GameMain
{
    public class Procedure_Demo1_Menu : ProcedureBase
    {
        protected override void OnEnter(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);
            GameEntry.UI.OpenUIForm("Assets/GameFrameworkDemo/Demo1_UI/UI_Menu.prefab","DefaultGroup");
        }
    }
}
