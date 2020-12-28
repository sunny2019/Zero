using System.IO;
using UnityEditor;

namespace GameMain
{
    public class EditorBaseTool
    {
        /// <summary>
        /// 获取当前Project中所选路径
        /// </summary>
        /// <returns></returns>
        static string GetSelectedPathOrFallback()
        {
            string path = "Assets";
            foreach (UnityEngine.Object obj in Selection.GetFiltered(typeof(UnityEngine.Object), SelectionMode.Assets))
            {
                path = AssetDatabase.GetAssetPath(obj);
                if (!string.IsNullOrEmpty(path) && File.Exists(path))
                {
                    //如果是目录获得目录名，如果是文件获得文件所在的目录名
                    path = Path.GetDirectoryName(path);
                    break;
                }
            }

            return path;
        }

        /// <summary>
        /// 打开savePanel,返回一个完整的编辑器文件路径
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="extension"></param>
        /// <returns></returns>
        public static string EditorSelectPath(string title, string fileName, string extension)
        {
            return EditorUtility.SaveFilePanel("脚本生成", GetSelectedPathOrFallback(), fileName, extension);
        }
    }
}