using System.Text;
using GameMain;
using UnityEngine.UI;
using UnityGameFramework.Runtime;

public class Demo1_UIMenu : UGuiForm
{
    public Text txt_Title;

    public Button btn_TestButton;

    protected override void OnOpen(object userData)
    {
        base.OnOpen(userData);
        
        Demo4_InjectFixCalcu calcu = new Demo4_InjectFixCalcu();
        Log.Debug("TestInjectFix: 10 + 9 =" + calcu.Add(10, 9));
        Log.Debug("TestInjectFix: 10 - 2 =" + calcu.Sub(10, 2));
        
        StringBuilder sb=new StringBuilder();
        sb.AppendLine("TestInjectFix: 10 + 9 =" + calcu.Add(10, 9));
        sb.AppendLine("TestInjectFix: 10 - 2 =" + calcu.Sub(10, 2));
        txt_Title.text = sb.ToString();
        
        
        btn_TestButton.onClick.AddListener(()=>{ Log.Debug("点击了button");});
    }
}
