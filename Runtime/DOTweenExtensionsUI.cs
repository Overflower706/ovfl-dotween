// Custom DOTween UI Extensions
// Minimal implementation for UI component extensions
// Uses "Ex" suffix to avoid conflicts with DOTween Pro

using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.UI;

namespace DG.Tweening
{
    public static class DOTweenExtensionsUI
    {
        #region CanvasGroup

        /// <summary>Tweens a CanvasGroup's alpha color to the given value.
        /// Also stores the canvasGroup as the tween's target so it can be used for filtered operations</summary>
        /// <param name="endValue">The end value to reach</param>
        /// <param name="duration">The duration of the tween</param>
        public static TweenerCore<float, float, FloatOptions> DOFadeEx(this CanvasGroup target, float endValue, float duration)
        {
            TweenerCore<float, float, FloatOptions> t = DOTween.To(() => target.alpha, x => target.alpha = x, endValue, duration);
            t.SetTarget(target);
            return t;
        }

        #endregion

        #region Image

        /// <summary>Tweens an Image's color to the given value.
        /// Also stores the image as the tween's target so it can be used for filtered operations</summary>
        /// <param name="endValue">The end value to reach</param>
        /// <param name="duration">The duration of the tween</param>
        public static TweenerCore<Color, Color, ColorOptions> DOColorEx(this Image target, Color endValue, float duration)
        {
            TweenerCore<Color, Color, ColorOptions> t = DOTween.To(() => target.color, x => target.color = x, endValue, duration);
            t.SetTarget(target);
            return t;
        }

        /// <summary>Tweens an Image's fillAmount to the given value.
        /// Also stores the image as the tween's target so it can be used for filtered operations</summary>
        /// <param name="endValue">The end value to reach (0 to 1)</param>
        /// <param name="duration">The duration of the tween</param>
        public static TweenerCore<float, float, FloatOptions> DOFillAmountEx(this Image target, float endValue, float duration)
        {
            if (endValue > 1) endValue = 1;
            else if (endValue < 0) endValue = 0;
            TweenerCore<float, float, FloatOptions> t = DOTween.To(() => target.fillAmount, x => target.fillAmount = x, endValue, duration);
            t.SetTarget(target);
            return t;
        }

        #endregion

        #region RectTransform

        /// <summary>Tweens a RectTransform's anchoredPosition X to the given value.
        /// Also stores the RectTransform as the tween's target so it can be used for filtered operations</summary>
        /// <param name="endValue">The end value to reach</param>
        /// <param name="duration">The duration of the tween</param>
        /// <param name="snapping">If TRUE the tween will smoothly snap all values to integers</param>
        public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosXEx(this RectTransform target, float endValue, float duration, bool snapping = false)
        {
            TweenerCore<Vector2, Vector2, VectorOptions> t = DOTween.To(() => target.anchoredPosition, x => target.anchoredPosition = x, new Vector2(endValue, 0), duration);
            t.SetOptions(AxisConstraint.X, snapping).SetTarget(target);
            return t;
        }

        #endregion

        #region Slider

        /// <summary>Tweens a Slider's value to the given value.
        /// Also stores the Slider as the tween's target so it can be used for filtered operations</summary>
        /// <param name="endValue">The end value to reach</param>
        /// <param name="duration">The duration of the tween</param>
        /// <param name="snapping">If TRUE the tween will smoothly snap all values to integers</param>
        public static TweenerCore<float, float, FloatOptions> DOValueEx(this Slider target, float endValue, float duration, bool snapping = false)
        {
            TweenerCore<float, float, FloatOptions> t = DOTween.To(() => target.value, x => target.value = x, endValue, duration);
            t.SetOptions(snapping).SetTarget(target);
            return t;
        }

        #endregion
    }
}
