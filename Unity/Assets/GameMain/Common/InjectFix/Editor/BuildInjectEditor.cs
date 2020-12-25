using System.IO;
using UnityEditor;
using UnityEngine;

namespace GameMain
{
    public class BuildInjectEditor
    {
        private const string PathchDir = "Assets/GameMain/Common/InjectFix/ByteFiles/";
        private const string CustomOtherPatch = "Assembly-CSharp.patch.bytes";
        private const string CustomAssetsAndPluginPatch = "Assembly-CSharp-filepass.patch.bytes";

        [MenuItem("InjectFix/InjectAll", false, 1)]
        static void InjectAll()
        {

            DeleteOldPatch();
            Patch();
            AssetDatabase.Refresh();
        }

        static void DeleteOldPatch()
        {
            if (File.Exists(PathchDir + CustomOtherPatch))
            {
                File.Delete(PathchDir + CustomOtherPatch);
                File.Delete(PathchDir + CustomOtherPatch + ".meta");
            }

            if (File.Exists(PathchDir + CustomAssetsAndPluginPatch))
            {
                File.Delete(PathchDir + CustomAssetsAndPluginPatch);
                File.Delete(PathchDir + CustomAssetsAndPluginPatch + ".meta");
            }
        }
        static void Patch()
        {
            switch (Application.platform)
            {
                case RuntimePlatform.Android:
                    IFix.Editor.IFixEditor.GenPlatformPatch(IFix.Editor.IFixEditor.Platform.android, "./" + PathchDir);
                    IFix.Editor.IFixEditor.InjectAssemblys();
                    break;
                case RuntimePlatform.IPhonePlayer:
                    IFix.Editor.IFixEditor.GenPlatformPatch(IFix.Editor.IFixEditor.Platform.ios, "./" + PathchDir);
                    IFix.Editor.IFixEditor.InjectAssemblys();
                    break;
                default:
                    IFix.Editor.IFixEditor.GenPlatformPatch(IFix.Editor.IFixEditor.Platform.standalone, "./" + PathchDir);
                    IFix.Editor.IFixEditor.InjectAssemblys();
                    break;
            }
        }
    }
}