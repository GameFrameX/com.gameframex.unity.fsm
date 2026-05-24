<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="GameFrameX Logo" width="160"/>

# Game Frame X FSM Component

[![License](https://img.shields.io/github/license/gameframex/com.gameframex.unity.fsm)](https://github.com/gameframex/com.gameframex.unity.fsm/blob/main/LICENSE)
[![Version](https://img.shields.io/github/v/release/gameframex/com.gameframex.unity.fsm)](https://github.com/gameframex/com.gameframex.unity.fsm/releases)
[![Documentation](https://img.shields.io/badge/Documentation-Documentation-blue)](https://gameframex.doc.alianblank.com)

All-in-One Solution for Indie Game Development · Empowering Indie Developers' Dreams

[Documentation](https://gameframex.doc.alianblank.com) · [Quick Start](#quick-start) · [QQ Group](https://qm.qq.com/q/5kbDVBdUeS) · **Language**

[English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>

---

## Project Overview

The **FSM (Finite State Machine) Component** provides interfaces for managing and controlling the creation, retrieval, inspection, and destruction of finite state machines.

### Features

- `Count` property: Get the current number of state machines.
- `HasFsm` method: Check if a state machine of the specified type already exists.
- `GetFsm` method: Get a state machine instance by specified type.
- `GetAllFsmList` method: Get all state machine instances.
- `CreateFsm` method: Create a new state machine instance.
- `DestroyFsm` method: Destroy a specified state machine instance.

## Quick Start

### Installation

Choose one of the following methods:

1. Add to `manifest.json` dependencies:
   ```json
   {
      "com.gameframex.unity.fsm": "https://github.com/AlianBlank/com.gameframex.unity.fsm.git"
   }
   ```
2. Use **Packages Manager** in Unity with **Git URL**: `https://github.com/AlianBlank/com.gameframex.unity.fsm.git`
3. Clone the repository into your Unity project's `Packages` directory. It will be loaded automatically.

## Usage Examples

### Creating a State Machine

Use `CreateFsm` to create a new finite state machine. You need to provide an owner object, an optional name, and a collection of states.

```csharp
public IFsm<T> CreateFsm<T>(T owner, params FsmState<T>[] states) where T : class
{
    return m_FsmManager.CreateFsm(owner, states);
}
```

### Getting a State Machine

Retrieve a finite state machine by owner type or name.

```csharp
public IFsm<T> GetFsm<T>() where T : class
{
    return m_FsmManager.GetFsm<T>();
}
```

### Checking State Machine Existence

Call `HasFsm` to confirm whether a specific finite state machine has been created.

```csharp
public bool HasFsm<T>() where T : class
{
    return m_FsmManager.HasFsm<T>();
}
```

### Destroying a State Machine

Use `DestroyFsm` to destroy a state machine that is no longer needed, reclaiming resources.

```csharp
public bool DestroyFsm<T>(IFsm<T> fsm) where T : class
{
    return m_FsmManager.DestroyFsm(fsm);
}
```

> **Note:** Ensure the FSM manager `m_FsmManager` is properly initialized before calling any state machine management methods. This component interacts with other framework modules, so ensure the game framework is correctly set up and initialized.

## Documentation & Resources

- [Documentation](https://gameframex.doc.alianblank.com)

## Community & Support

- [QQ Group](https://qm.qq.com/q/5kbDVBdUeS)

## Changelog

See [Releases](https://github.com/gameframex/com.gameframex.unity.fsm/releases) for changelog.

## License

This project is licensed under the [MIT License](https://github.com/gameframex/com.gameframex.unity.fsm/blob/main/LICENSE).
