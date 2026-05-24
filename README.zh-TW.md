<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="GameFrameX Logo" width="160"/>

# Game Frame X FSM 有限狀態機組件

[![License](https://img.shields.io/github/license/gameframex/com.gameframex.unity.fsm)](https://github.com/gameframex/com.gameframex.unity.fsm/blob/main/LICENSE)
[![Version](https://img.shields.io/github/v/release/gameframex/com.gameframex.unity.fsm)](https://github.com/gameframex/com.gameframex.unity.fsm/releases)
[![Documentation](https://img.shields.io/badge/Documentation-文檔-blue)](https://gameframex.doc.alianblank.com)

獨立遊戲前後端一體化解決方案 · 獨立遊戲開發者的圓夢大使

[文檔](https://gameframex.doc.alianblank.com) · [快速開始](#快速開始) · [QQ群](https://qm.qq.com/q/5kbDVBdUeS) · **語言**

[English](README.md) | [简体中文](README.zh-CN.md) | **繁體中文** | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>

---

## 項目簡介

**FSM 有限狀態機組件 (Fsm Component)** - 提供狀態機組件相關的介面，用於管理和控制有限狀態機（FSM）的建立、取得、檢查以及銷毀。

### 功能

- `Count` 屬性：取得目前狀態機的數量。
- `HasFsm` 方法：檢查指定類型的狀態機是否已經存在。
- `GetFsm` 方法：根據指定類型取得狀態機實例。
- `GetAllFsmList` 方法：取得所有狀態機實例。
- `CreateFsm` 方法：建立新的狀態機實例。
- `DestroyFsm` 方法：銷毀指定的狀態機實例。

## 快速開始

### 安裝方式（任選其一）

1. 直接在 `manifest.json` 的 `dependencies` 節點下新增以下內容：
   ```json
   {
      "com.gameframex.unity.fsm": "https://github.com/AlianBlank/com.gameframex.unity.fsm.git"
   }
   ```
2. 在 Unity 的 `Packages Manager` 中使用 `Git URL` 的方式新增庫，地址為：`https://github.com/AlianBlank/com.gameframex.unity.fsm.git`
3. 直接下載倉庫放置到 Unity 專案的 `Packages` 目錄下，會自動載入識別。

## 使用範例

### 建立狀態機

使用 `CreateFsm` 方法建立一個新的有限狀態機。需要提供擁有者物件、狀態機名稱（可選）和狀態集合。

```csharp
public IFsm<T> CreateFsm<T>(T owner, params FsmState<T>[] states) where T : class
{
    return m_FsmManager.CreateFsm(owner, states);
}
```

### 取得狀態機

根據擁有者類型或名稱來取得對應的有限狀態機。

```csharp
public IFsm<T> GetFsm<T>() where T : class
{
    return m_FsmManager.GetFsm<T>();
}
```

### 檢查狀態機存在

呼叫 `HasFsm` 方法確認是否已建立特定的有限狀態機。

```csharp
public bool HasFsm<T>() where T : class
{
    return m_FsmManager.HasFsm<T>();
}
```

### 銷毀狀態機

使用 `DestroyFsm` 方法銷毀不再需要的狀態機，回收資源。

```csharp
public bool DestroyFsm<T>(IFsm<T> fsm) where T : class
{
    return m_FsmManager.DestroyFsm(fsm);
}
```

> **注意：** 確保在呼叫任何狀態機管理方法之前，狀態機管理器 `m_FsmManager` 已被正確初始化，否則可能會引發錯誤。此組件需要與遊戲框架的其他模組和組件進行互動使用，需保證遊戲框架已被正確設定並初始化。

## 文檔與資源

- [文檔](https://gameframex.doc.alianblank.com)

## 社區與支援

- [QQ群](https://qm.qq.com/q/5kbDVBdUeS)

## 更新日誌

查看 [Releases](https://github.com/gameframex/com.gameframex.unity.fsm/releases) 了解更新日誌。

## 開源協議

本專案基於 [MIT 協議](https://github.com/gameframex/com.gameframex.unity.fsm/blob/main/LICENSE) 開源。
