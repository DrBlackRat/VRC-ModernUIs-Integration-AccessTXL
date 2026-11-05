using UnityEngine;
using UnityEditor;

namespace DrBlackRat.VRC.ModernUIs.Integrations.Editor
{
    public static class ModernUIsIntegrationsAccessTXLMenu
    {
        [MenuItem("Tools/DrBlackRat/ModernUIs Integrations/AccessTXL/Add AccessTXL to Whitelist Bridge Prefab to Scene", false, 2)]
        public static void AddToWhitelistBridgePrefab()
        {
            GameObject prefab = AssetDatabase.LoadAssetAtPath<GameObject>("Packages/xyz.drblackrat.vrc.modernuis.integrations.accesstxl/Runtime/Prefabs/AccessTXL To Whitelist Bridge.prefab");
            PrefabUtility.InstantiatePrefab(prefab);
        }
    
        [MenuItem("Tools/DrBlackRat/ModernUIs Integrations/AccessTXL/Add to Whitelist to AccessTXL Bridge Prefab to Scene", false, 3)]
        public static void AddToAccessTXLPrefab()
        {
            GameObject prefab = AssetDatabase.LoadAssetAtPath<GameObject>("Packages/xyz.drblackrat.vrc.modernuis.integrations.accesstxl/Runtime/Prefabs/Whitelist To AccessTXL Bridge.prefab");
            PrefabUtility.InstantiatePrefab(prefab);
        }
        
        [MenuItem("Tools/DrBlackRat/ModernUIs Integrations/AccessTXL/Show ReadMe", false, 4)]
        public static void ShowReadMe()
        {
            PingAsset("Packages/xyz.drblackrat.vrc.modernuis.integrations.accesstxl/README.md");
        }
        
        [MenuItem("Tools/DrBlackRat/ModernUIs Integrations/AccessTXL/Open GitHub", false, 5)]
        public static void OpenGitHub()
        {
            Application.OpenURL("https://github.com/DrBlackRat/VRC-ModernUIs-Integration-AccessTXL");
        }
        
        private static void PingAsset(string path)
        {
            var folder = AssetDatabase.LoadAssetAtPath<Object>(path);

            if (folder != null)
            {
                Selection.activeObject = folder;
                EditorGUIUtility.PingObject(folder);
            }
        }
    }
}
