# OVFL DOTween Extensions

DOTween Pro와 충돌 없이 사용할 수 있는 경량 DOTween 확장 메서드 패키지입니다.  
`Ex` 접미사를 사용해 DOTween Pro의 내장 확장과 이름 충돌을 방지합니다.

## 제공 API

### AudioSource
```csharp
audioSource.DOFadeEx(endValue: 0f, duration: 1f); // volume 트윈
```

### CanvasGroup
```csharp
canvasGroup.DOFadeEx(endValue: 0f, duration: 0.5f); // alpha 트윈
```

### Image
```csharp
image.DOColorEx(Color.red, duration: 0.3f);       // color 트윈
image.DOFillAmountEx(endValue: 1f, duration: 1f); // fillAmount 트윈
```

### RectTransform
```csharp
rectTransform.DOAnchorPosXEx(endValue: 100f, duration: 0.3f); // anchoredPosition.X 트윈
```

### Slider
```csharp
slider.DOValueEx(endValue: 1f, duration: 0.5f); // value 트윈
```

## 설치 방법

사용하는 프로젝트에 **DOTween**이 먼저 설치되어 있어야 합니다.

### Package Manager (git URL)
1. **Window > Package Manager** 열기
2. 좌상단 **+** → **Add package from git URL...**
3. 아래 URL 입력:
   ```
   https://github.com/Overflower706/dotween.git
   ```

### manifest.json 직접 편집
```json
{
  "dependencies": {
    "com.ovfl.dotween": "https://github.com/Overflower706/dotween.git"
  }
}
```

## 요구사항

- Unity 6000.1 이상
- DOTween (Free 또는 Pro)
