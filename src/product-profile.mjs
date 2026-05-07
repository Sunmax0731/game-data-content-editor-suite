export const productProfile = {
  "repository": "game-data-content-editor-suite",
  "title": "ゲームデータ・コンテンツ編集スイート",
  "domain": "UnityEditor",
  "hostApp": null,
  "rank": 33,
  "ideaNo": 3,
  "overview": "ScriptableObject、CSV、JSON、ゲームコンテンツ編集を同じDB風ビューで扱う。",
  "problem": "ゲームデータとコンテンツ編集がファイルやInspectorに散らばり、整合性を見落としやすい。",
  "differentiation": "データ編集、検証、プレビューを同じUnity Editorワークフローにする。",
  "publish": "GitHub Release / BOOTH",
  "surface": "Unity EditorWindow + validation core",
  "entity": "game data row",
  "requiredFields": [
    "id",
    "title",
    "source",
    "schema",
    "contentPath",
    "owner",
    "acceptance"
  ],
  "warningField": "preview",
  "benchmarkRepos": [
    "Sunmax0731/release-output-check-flow",
    "Sunmax0731/git-release-publish-assistant",
    "Sunmax0731/movie-telop-transcriber",
    "Sunmax0731/codex-remote-android"
  ]
};
