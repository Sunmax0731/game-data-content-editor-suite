using UnityEditor;
using UnityEngine;

namespace Sunmax0731.GameDataContentEditorSuite
{
    public sealed class GameDataContentEditorSuiteWindow : EditorWindow
    {
        [MenuItem("Tools/Sunmax0731/game-data-content-editor-suite")]
        public static void Open() => GetWindow<GameDataContentEditorSuiteWindow>("game-data-content-editor-suite");

        private void OnGUI()
        {
            GUILayout.Label("ゲームデータ・コンテンツ編集スイート", EditorStyles.boldLabel);
            GUILayout.Label("Closed alpha editor package is importable.");
        }
    }
}
