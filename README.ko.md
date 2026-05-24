<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="GameFrameX Logo" width="160"/>

# Game Frame X FSM 유한 상태 머신 컴포넌트

[![License](https://img.shields.io/github/license/gameframex/com.gameframex.unity.fsm)](https://github.com/gameframex/com.gameframex.unity.fsm/blob/main/LICENSE)
[![Version](https://img.shields.io/github/v/release/gameframex/com.gameframex.unity.fsm)](https://github.com/gameframex/com.gameframex.unity.fsm/releases)
[![Documentation](https://img.shields.io/badge/Documentation-문서-blue)](https://gameframex.doc.alianblank.com)

인디 게임 개발자를 위한 올인원 솔루션 · 인디 개발자의 꿈을 실현

[문서](https://gameframex.doc.alianblank.com) · [빠른 시작](#빠른-시작) · [QQ 그룹](https://qm.qq.com/q/5kbDVBdUeS) · **언어**

[English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | **한국어**

</div>

---

## 프로젝트 개요

**FSM 유한 상태 머신 컴포넌트 (Fsm Component)** - 유한 상태 머신(FSM)의 생성, 가져오기, 검사 및 파괴를 관리하고 제어하는 인터페이스를 제공합니다.

### 기능

- `Count` 속성: 현재 상태 머신의 수를 가져옵니다.
- `HasFsm` 메서드: 지정된 유형의 상태 머신이 이미 존재하는지 확인합니다.
- `GetFsm` 메서드: 지정된 유형으로 상태 머신 인스턴스를 가져옵니다.
- `GetAllFsmList` 메서드: 모든 상태 머신 인스턴스를 가져옵니다.
- `CreateFsm` 메서드: 새로운 상태 머신 인스턴스를 생성합니다.
- `DestroyFsm` 메서드: 지정된 상태 머신 인스턴스를 파괴합니다.

## 빠른 시작

### 설치 방법 (선택)

1. `manifest.json`의 `dependencies`에 다음 내용을 추가:
   ```json
   {
      "com.gameframex.unity.fsm": "https://github.com/AlianBlank/com.gameframex.unity.fsm.git"
   }
   ```
2. Unity의 `Packages Manager`에서 `Git URL`을 사용하여 추가: `https://github.com/AlianBlank/com.gameframex.unity.fsm.git`
3. 저장소를 직접 다운로드하여 Unity 프로젝트의 `Packages` 디렉토리에 배치하면 자동으로 로드됩니다.

## 사용 예시

### 상태 머신 생성

`CreateFsm` 메서드를 사용하여 새로운 유한 상태 머신을 생성합니다. 소유자 객체, 상태 머신 이름(선택) 및 상태 컬렉션을 제공해야 합니다.

```csharp
public IFsm<T> CreateFsm<T>(T owner, params FsmState<T>[] states) where T : class
{
    return m_FsmManager.CreateFsm(owner, states);
}
```

### 상태 머신 가져오기

소유자 유형 또는 이름으로 해당 유한 상태 머신을 가져옵니다.

```csharp
public IFsm<T> GetFsm<T>() where T : class
{
    return m_FsmManager.GetFsm<T>();
}
```

### 상태 머신 존재 확인

`HasFsm` 메서드를 호출하여 특정 유한 상태 머신이 생성되었는지 확인합니다.

```csharp
public bool HasFsm<T>() where T : class
{
    return m_FsmManager.HasFsm<T>();
}
```

### 상태 머신 파괴

`DestroyFsm` 메서드를 사용하여 더 이상 필요하지 않은 상태 머신을 파괴하고 리소스를 회수합니다.

```csharp
public bool DestroyFsm<T>(IFsm<T> fsm) where T : class
{
    return m_FsmManager.DestroyFsm(fsm);
}
```

> **참고:** 상태 머신 관리 메서드를 호출하기 전에 상태 머신 관리자 `m_FsmManager`가 올바르게 초기화되었는지 확인하세요. 이 컴포넌트는 다른 프레임워크 모듈과 상호작용하므로 게임 프레임워크가 올바르게 설정되고 초기화되었는지 확인하세요.

## 문서 및 자료

- [문서](https://gameframex.doc.alianblank.com)

## 커뮤니티 및 지원

- [QQ 그룹](https://qm.qq.com/q/5kbDVBdUeS)

## 변경 로그

변경 로그는 [Releases](https://github.com/gameframex/com.gameframex.unity.fsm/releases)에서 확인하세요.

## 라이선스

이 프로젝트는 [MIT 라이선스](https://github.com/gameframex/com.gameframex.unity.fsm/blob/main/LICENSE)에 따라 배포됩니다.
