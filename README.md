# game-data-content-editor-suite

ゲームデータ・コンテンツ編集スイート は、ScriptableObject、CSV、JSON、ゲームコンテンツ編集を同じDB風ビューで扱う。

## 何を解決するか

ゲームデータとコンテンツ編集がファイルやInspectorに散らばり、整合性を見落としやすい。

## 差別化

データ編集、検証、プレビューを同じUnity Editorワークフローにする。

## 公開先

- GitHub Release / BOOTH

## 現在の到達点

- core / validators / report / review-model / CLI に責務を分割済み
- Unity EditorWindow + validation core の最小実装または配布用骨格を同梱済み
- 代表シナリオ `samples/representative-suite.json` で正常系、必須項目不足、warning、混在バッチを自動検証済み
- 厳格 QCDS は Quality、Cost、Delivery、Satisfaction の全観点 S+ で評価済み
- docs ZIP は `dist/game-data-content-editor-suite-docs.zip`

## 主要コマンド

```powershell
npm test
npm start
```

## 重要ドキュメント

- [要件定義](docs/requirements.md)
- [仕様](docs/specification.md)
- [設計](docs/design.md)
- [手動テスト](docs/manual-test.md)
- [厳格手動テスト追補](docs/strict-manual-test-addendum.md)
- [QCDS評価](docs/qcds-evaluation.md)
- [厳格QCDS metrics](docs/qcds-strict-metrics.json)
- [トレーサビリティ](docs/traceability-matrix.md)

## 参照したアイデアパック

- created_idea: `D:\AI\UnityEditor\created_idea_003_game-data-content-editor-suite`
- idea ZIP: `D:\AI\UnityEditor\created_idea_003_game-data-content-editor-suite\idea_003_game-data-content-editor-suite.zip`
- PICKUP rank: 33
- Domain: UnityEditor
