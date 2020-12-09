
using System.Collections.Generic;
using GameFramework.Procedure;
using GameFramework.Resource;
using UnityEngine;
using UnityGameFramework.Runtime;
using ProcedureOwner=GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

namespace GameMain
{
    public class Procedure_Demo1_Menu : ProcedureBase
    {
        protected override void OnEnter(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);
            GameEntry.UI.OpenUIForm("Assets/GameMain/Common/Demo/Demo1_UI/UI_Menu.prefab","DefaultGroup");
            GameEntry.Resource.LoadAsset("Assets/GameMain/Common/Demo/Demo3_WebglUpdateFile/go_TestCube.prefab",typeof(GameObject),new LoadAssetCallbacks(successcallback));
        }

        private void successcallback(string assetname, object asset, float duration, object userdata)
        {
            GameObject go= GameObject.Instantiate(asset as GameObject);
        }


        public override bool UseNativeDialog { get; }
    }
}
