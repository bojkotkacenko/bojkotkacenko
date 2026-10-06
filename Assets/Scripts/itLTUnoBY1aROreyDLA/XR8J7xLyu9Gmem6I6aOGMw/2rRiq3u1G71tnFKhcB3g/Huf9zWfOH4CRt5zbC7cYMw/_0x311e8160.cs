using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x311e8160 : MonoBehaviour
{
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x311e8160>();
    }

    public void _0x6552e908()
    {
        this._0x5736f068?.Pause();
    }

    private Sequence _0x5736f068;
    public float FirstAnimationTime = 10.0f;
    public float SecondPassSliderValue = 0.5f;
    public void _0xf67451de()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0x5736f068?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0x813093f9 = false;
    }

    public void _0xffc1a7f1()
    {
        this._0x5736f068?.Kill();
        this.AnimationSlider.value = _0x813093f9 ? this.SecondPassSliderValue : 0.05f;
    }

    public float DefaultAnimationTime = 0.4f;
    private void _0xcddc4924()
    {
        this.AnimationSlider.value = 0.05f;
        _0x813093f9 = !_0x813093f9;
        this._0x5736f068 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0xf7c9b9d0 => this.AnimationSlider.value = _0xf7c9b9d0, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0xa7bd5c21._0x2a4f527d?._0x82f2400d();
        });
    }

    public static _0x311e8160 Instance;
    public GameObject Error;
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0xb0135da5._0x73d482f8.SCENE_0 && !_0x813093f9)
        {
            this._0xcddc4924();
        }
        else
        {
            this._0xe7435fdc();
        }
    }

    public GameObject Background;
    private static bool _0x813093f9 = false;
    public void _0xe7435fdc()
    {
        this._0xffc1a7f1();
        bool _0x9576858d = _0x813093f9;
        this._0x5736f068 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0xf7c9b9d0 => this.AnimationSlider.value = _0xf7c9b9d0, _0x9576858d ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0x813093f9 = !_0x813093f9;
    }

    public Slider AnimationSlider;
    public GameObject Content;
    public void _0x4bcc8d27()
    {
        this._0x5736f068?.Play();
    }
}