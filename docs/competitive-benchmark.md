# Competitive Benchmark

## 比較対象

- Unity Inspector
- Odin Inspector
- Google Sheets import
- custom ScriptableObject editors

## 採用する評価基準

- 入力から検証、証跡、再実行までが1つの流れであること。
- 手動確認が必要な項目を warning として残せること。
- 公開前に docs、release checklist、security/privacy を確認できること。
- データ編集、検証、プレビューを同じUnity Editorワークフローにする。

## 差別化

この repo は Unity EditorWindow + validation core に閉じた最小実装だけでなく、QCDS、traceability、manual test、docs ZIP を含めた公開前の運用品質を製品の一部として扱う。
