using UnityEditor;
using UnityEngine;

namespace Sunmax0731.GameDataContentEditorSuite
{
    public sealed class GameDataContentEditorSuiteWindow : EditorWindow
    {
        [MenuItem("Tools/Sunmax0731/ゲームデータ・コンテンツ編集スイート")]
        public static void Open()
        {
            GetWindow<GameDataContentEditorSuiteWindow>("ゲームデータ・コンテンツ編集スイート");
        }

        private void OnGUI()
        {
            EditorGUILayout.LabelField("ゲームデータ・コンテンツ編集スイート", EditorStyles.boldLabel);
            EditorGUILayout.HelpBox("データ編集、検証、プレビューを同じUnity Editorワークフローにする。", MessageType.Info);
            if (GUILayout.Button("Open documentation"))
            {
                Application.OpenURL("https://github.com/Sunmax0731/game-data-content-editor-suite");
            }
        }
    }
}
