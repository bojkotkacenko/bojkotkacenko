using DG.Tweening;
using UnityEngine;

/// Slow float for the abstract leaf coronet mark. Sizes are passed in, never guessed,
/// so the motion scales with whatever rect the mark was given.
public sealed class _0x8c8dd86b : MonoBehaviour
{
    private void _0x3ad4e29a()
    {
        if (this._mark == null)
            return;
        this._0xbaaa9ac6 = this._mark.anchoredPosition.y;
        DOTween.Kill(this._mark, true);
        this._mark.DOAnchorPosY(this._0xbaaa9ac6 + this._travel, this._period * 0.5f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }

    [SerializeField]
    private RectTransform _mark;
    [SerializeField]
    private float _period = 3f;
    [SerializeField]
    private float _travel = 10f;
    private void OnDisable()
    {
        if (this._mark != null)
            DOTween.Kill(this._mark, true);
    }

    public void _0x951bc792(RectTransform _0x2b4e84a5, float _0x8f58ed36, float _0xa955433c)
    {
        this._mark = _0x2b4e84a5;
        this._travel = _0x8f58ed36;
        this._period = Mathf.Max(0.4f, _0xa955433c);
        this._0x3ad4e29a();
    }

    private float _0xbaaa9ac6;
}