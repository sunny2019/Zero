using GameFramework.Event;
using UnityEngine;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

namespace GameMain
{
    public class Procedure_Main : ProcedureBase
    {
        protected override void OnEnter(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);
            
            GameEntry.Event.Subscribe(LoadSceneSuccessEventArgs.EventId, OnLoadS);
            GameEntry.Event.Subscribe(LoadSceneFailureEventArgs.EventId, OnLoadF);
            GameEntry.Scene.UnloadAllScene();
            GameEntry.Scene.LoadScene("Assets/GameMain/Common/Demo/Demo1_UI/Demo1_Menu.unity", this);
        }

        private void OnLoadF(object sender, GameEventArgs e)
        {
            LoadSceneFailureEventArgs ne = (LoadSceneFailureEventArgs) e;
            if (ne.UserData != this)
            {
                return;
            }
        }

        private void OnLoadS(object sender, GameEventArgs e)
        {
            LoadSceneSuccessEventArgs ne = (LoadSceneSuccessEventArgs) e;
            if (ne.UserData != this)
            {
                return;
            }

            isFinshed = true;
        }

        protected override void OnUpdate(ProcedureOwner procedureOwner, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
            if (isFinshed)
            {
                ChangeState<Procedure_Demo1_Menu>(procedureOwner);
            }
        }


        protected override void OnLeave(ProcedureOwner procedureOwner, bool isShutdown)
        {
            base.OnLeave(procedureOwner, isShutdown);
            GameEntry.Event.Unsubscribe(LoadSceneSuccessEventArgs.EventId, OnLoadS);
            GameEntry.Event.Unsubscribe(LoadSceneFailureEventArgs.EventId, OnLoadF);
        }

        public bool isFinshed = false;
    }
}