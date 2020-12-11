using GameFramework;
using GameMain;
using UnityEngine;
using UnityEngine.UI;
using UnityGameFramework.Runtime;

public class Demo1_UIMenu : UGuiForm
{

    public Button btn_TestButton;

    protected override void OnOpen(object userData)
    {
        base.OnOpen(userData);
        btn_TestButton.onClick.AddListener(()=>{ Log.Debug("点击了button");});
    }
}
