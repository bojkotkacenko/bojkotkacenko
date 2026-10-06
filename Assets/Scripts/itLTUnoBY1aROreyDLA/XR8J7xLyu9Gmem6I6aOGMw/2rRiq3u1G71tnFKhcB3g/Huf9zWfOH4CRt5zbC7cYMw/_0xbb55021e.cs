using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xbb55021e : MonoBehaviour
{
    public bool IsScaledDownOnAwake = true;
    public TMP_Text HeaderText;
    public void _0xab975e0a()
    {
        this._0xcfcb9e77();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    private void _0x313b3e8a()
    {
        if (this.OuterBackground != null)
        {
            Image _0xf7a0140b = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xf7a0140b, true);
            _0xf7a0140b.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    private void _0xcfcb9e77()
    {
        if (this.OuterBackground != null)
        {
            Image _0xe4f21b60 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xe4f21b60, true);
            _0xe4f21b60.DOFade(0f, this.ScaleDuration);
        }
    }

    public Ease Ease = Ease.OutSine;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x00212b53();
    }

    public GameObject OuterBackground;
    public void _0x474d95cf()
    {
        this._0xc0d57dae();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0x3e36db7a.Instance._0x1ab03d30(_0x3e36db7a.Instance.CurrentPanelIndex);
    }

    public TMP_Text MainText;
    public void Show()
    {
        this._0x313b3e8a();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0x3e36db7a.Instance._0x1ab03d30(_0x3e36db7a.Instance.CurrentPanelIndex);
            });
        }
    }

    public GameObject Content;
    public float ScaleDuration = 0.4f;
    private bool _0x01e0d2fa => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    private void _0x00212b53()
    {
        if (this.OuterBackground != null)
        {
            Image _0x55eb1fb9 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x55eb1fb9, true);
            _0x55eb1fb9.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    private void _0xc0d57dae()
    {
        if (this.OuterBackground != null)
        {
            Image _0x2b56f5cf = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x2b56f5cf, true);
            _0x2b56f5cf.DOFade(1f, 0f);
        }
    }
}