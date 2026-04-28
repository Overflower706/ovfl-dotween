// Custom DOTween Audio Extensions
// Minimal implementation for AudioSource extensions
// Uses "Ex" suffix to avoid conflicts with DOTween Pro

using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace DG.Tweening
{
    public static class DOTweenExtensionsAudio
    {
        /// <summary>Tweens an AudioSource's volume to the given value.
        /// Also stores the AudioSource as the tween's target so it can be used for filtered operations</summary>
        /// <param name="endValue">The end value to reach (0 to 1)</param>
        /// <param name="duration">The duration of the tween</param>
        public static TweenerCore<float, float, FloatOptions> DOFadeEx(this AudioSource target, float endValue, float duration)
        {
            if (endValue < 0) endValue = 0;
            else if (endValue > 1) endValue = 1;
            TweenerCore<float, float, FloatOptions> t = DOTween.To(() => target.volume, x => target.volume = x, endValue, duration);
            t.SetTarget(target);
            return t;
        }
    }
}
