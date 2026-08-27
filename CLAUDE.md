# CLAUDE.md

## 언어

모든 답변은 한국어로 작성한다.

## 패키지 개요

`com.ovfl.dotween`은 DOTween 확장 메서드 패키지. Unity 내장 타입에 대한 트윈 편의 메서드를 제공한다.

- 전제 조건: 사용 프로젝트에 **DOTween**이 설치되어 있어야 함
- 사용 프로젝트: Catverse

## 제공하는 확장 메서드 대상

| 타입 | 주요 확장 메서드 |
|------|---------------|
| `AudioSource` | 볼륨 페이드 등 오디오 트윈 |
| `CanvasGroup` | alpha 트윈 (FadeIn/FadeOut) |
| `Image` | fillAmount, color 트윈 |
| `RectTransform` | anchoredPosition, sizeDelta 트윈 |
| `Slider` | value 트윈 |

## 테스트

기능 구현 시 적절한 테스트도 함께 구현한다.
