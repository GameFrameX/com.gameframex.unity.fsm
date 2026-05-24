<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="GameFrameX Logo" width="160"/>

# Game Frame X FSM 有限状態マシンコンポーネント

[![License](https://img.shields.io/github/license/gameframex/com.gameframex.unity.fsm)](https://github.com/gameframex/com.gameframex.unity.fsm/blob/main/LICENSE)
[![Version](https://img.shields.io/github/v/release/gameframex/com.gameframex.unity.fsm)](https://github.com/gameframex/com.gameframex.unity.fsm/releases)
[![Documentation](https://img.shields.io/badge/Documentation-ドキュメント-blue)](https://gameframex.doc.alianblank.com)

インディゲーム開発者向けオールインワンソリューション · インディ開発者の夢を支援

[ドキュメント](https://gameframex.doc.alianblank.com) · [クイックスタート](#クイックスタート) · [QQグループ](https://qm.qq.com/q/5kbDVBdUeS) · **言語**

[English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | **日本語** | [한국어](README.ko.md)

</div>

---

## プロジェクト概要

**FSM 有限状態マシンコンポーネント (Fsm Component)** - 有限状態マシン（FSM）の作成、取得、検査、破棄を管理および制御するためのインターフェースを提供します。

### 機能

- `Count` プロパティ：現在の状態マシンの数を取得します。
- `HasFsm` メソッド：指定された型の状態マシンが既に存在するかを確認します。
- `GetFsm` メソッド：指定された型で状態マシンインスタンスを取得します。
- `GetAllFsmList` メソッド：すべての状態マシンインスタンスを取得します。
- `CreateFsm` メソッド：新しい状態マシンインスタンスを作成します。
- `DestroyFsm` メソッド：指定された状態マシンインスタンスを破棄します。

## クイックスタート

### インストール方法（いずれかを選択）

1. `manifest.json` の `dependencies` に以下を追加：
   ```json
   {
      "com.gameframex.unity.fsm": "https://github.com/AlianBlank/com.gameframex.unity.fsm.git"
   }
   ```
2. Unity の `Packages Manager` で `Git URL` を使用して追加：`https://github.com/AlianBlank/com.gameframex.unity.fsm.git`
3. リポジトリを直接ダウンロードして Unity プロジェクトの `Packages` ディレクトリに配置すると、自動的に読み込まれます。

## 使用例

### 状態マシンの作成

`CreateFsm` メソッドを使用して新しい有限状態マシンを作成します。オーナーオブジェクト、状態マシン名（オプション）、状態のコレクションを提供する必要があります。

```csharp
public IFsm<T> CreateFsm<T>(T owner, params FsmState<T>[] states) where T : class
{
    return m_FsmManager.CreateFsm(owner, states);
}
```

### 状態マシンの取得

オーナーの型または名前で対応する有限状態マシンを取得します。

```csharp
public IFsm<T> GetFsm<T>() where T : class
{
    return m_FsmManager.GetFsm<T>();
}
```

### 状態マシンの存在確認

`HasFsm` メソッドを呼び出して、特定の有限状態マシンが作成されているかを確認します。

```csharp
public bool HasFsm<T>() where T : class
{
    return m_FsmManager.HasFsm<T>();
}
```

### 状態マシンの破棄

`DestroyFsm` メソッドを使用して不要になった状態マシンを破棄し、リソースを解放します。

```csharp
public bool DestroyFsm<T>(IFsm<T> fsm) where T : class
{
    return m_FsmManager.DestroyFsm(fsm);
}
```

> **注意：** 状態マシン管理メソッドを呼び出す前に、状態マシンマネージャー `m_FsmManager` が正しく初期化されていることを確認してください。このコンポーネントは他のフレームワークモジュールと連携するため、ゲームフレームワークが正しく設定および初期化されていることを確認してください。

## ドキュメントとリソース

- [ドキュメント](https://gameframex.doc.alianblank.com)

## コミュニティとサポート

- [QQグループ](https://qm.qq.com/q/5kbDVBdUeS)

## 変更履歴

変更履歴は [Releases](https://github.com/gameframex/com.gameframex.unity.fsm/releases) をご覧ください。

## ライセンス

このプロジェクトは [MIT ライセンス](https://github.com/gameframex/com.gameframex.unity.fsm/blob/main/LICENSE) の下で公開されています。
