using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x0593ece4 : MonoBehaviour
{
    private void Start()
    {
    // Content.SetActive(false);
    }

    public TMP_Text ContentMainText;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x11085ed4();
    }

    private bool _0x99c24550 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public TMP_Text ContentHeaderText;
    public bool IsOnlyYScale;
    public float scaleDuration = 0.4f;
    public static void HideAllPops()
    {
        _0x6e6daaaf.Instance._0x29da2ed9();
    }

    public Image ContentImage;
    private void _0x11085ed4()
    {
        DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(0f, 0.01f);
        else
            this.Content.transform.DOScale(0f, 0.01f);
        this.Content.SetActive(false);
    }

    public bool IsScaledDownOnAwake = true;
    public void _0xe91c7d3d()
    {
        if (this.Content.gameObject.activeSelf)
        {
            DOTween.Kill(this.Content.transform, true);
            if (this.IsOnlyYScale)
                this.Content.transform.DOScaleY(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
            else
                this.Content.transform.DOScale(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
        }
    }

    public GameObject Content;
    public Ease ease = Ease.OutSine;
    public void Show()
    {
        this.Content.SetActive(true);
        if ((DOTween.TweensByTarget(this.Content.transform)?.Count ?? 0) > 0)
            DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
        else
            this.Content.transform.DOScale(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
    }

    public TMP_Text ContentAdditionalText;
}