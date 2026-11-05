using UnityEngine.UIElements;
using UnityEditor;

namespace DrBlackRat.VRC.ModernUIs.Editor
{
    [CustomEditor(typeof(Integrations.WhitelistToAccessTxlBridge))]
    public class WhitelistToAccessTxlEditor : UnityEditor.Editor
    {
        public VisualTreeAsset visualTree;

        public override VisualElement CreateInspectorGUI()
        {
            VisualElement root = new VisualElement();
            
            // UXML
            visualTree.CloneTree(root);
            
            return root;
        }
    }
}
