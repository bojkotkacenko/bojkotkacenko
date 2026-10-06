using DG.Tweening;
using UnityEngine;

/// One piece of fruit. Every size here is derived from a base the round computed
/// from the camera, so a tween can never be written against a literal (rule C.0).
public sealed class _0x02b14df7 : MonoBehaviour
{
    public void _0x27f37bda()
    {
        DOTween.Kill(this.transform, true);
        this.transform.localScale = Vector3.one;
        this.transform.DOScale(1.03f, 0.8f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }

    public void _0x4e78b2ab(Vector3 _0x50a82ee2, float _0xd442a094, TweenCallback _0xe3dbce2d)
    {
        DOTween.Kill(this.transform, true);
        Transform _0xa1f7b0f7 = this.transform;
        Tween _0xc2b7e948 = _0xa1f7b0f7.DOMove(_0x50a82ee2, _0xd442a094).SetEase(Ease.OutBack);
        _0xc2b7e948.OnComplete(_0xe3dbce2d);
    }

    public void _0x509f0d5e(float _0xde42d892, TweenCallback _0x867b8f07)
    {
        DOTween.Kill(this.transform, true);
        Transform _0xf601fb0d = this.transform;
        Tween _0x8ff5de76 = _0xf601fb0d.DOScale(0.2f, _0xde42d892).SetEase(Ease.InBack);
        _0x8ff5de76.OnComplete(_0x867b8f07);
    }

    private float _0x59673d29 = 1f;
    public void _0x4e0e6413(Vector3 _0x29b90346)
    {
        DOTween.Kill(this.transform, true);
        this.transform.position = _0x29b90346;
        this.transform.localScale = Vector3.one;
    }

    public void _0xcdf4e174(Sprite _0xabde4887, float _0xa115036f, int _0x3dbe9e30, bool _0x7ba7292c, Color _0x89c65f62)
    {
        if (this._renderer == null)
            this._renderer = this.GetComponent<SpriteRenderer>();
        this._0x59673d29 = Mathf.Max(0.05f, _0xa115036f);
        this._0xd13625e6 = _0x7ba7292c;
        if (this._renderer == null)
            return;
        this._renderer.sprite = _0xabde4887;
        this._renderer.drawMode = SpriteDrawMode.Sliced;
        this._renderer.size = new Vector2(this._0x59673d29, this._0x59673d29);
        this._renderer.sortingOrder = _0x3dbe9e30;
        this._renderer.color = _0x7ba7292c ? _0x89c65f62 : Color.white;
        this.transform.localScale = Vector3.one;
    }

    /// Arc flight: the height is a share of the travel, so it reads the same on any
    /// aspect without a single hand-tuned number.
    public void _0x8d700a3e(Vector3 _0x1336603e, float _0x31f3736d, TweenCallback _0xffd89e42)
    {
        DOTween.Kill(this.transform, true);
        Vector3 _0x90d16bc2 = this.transform.position;
        float _0x0816989b = Mathf.Abs(_0x1336603e.y - _0x90d16bc2.y) * 0.45f + this._0x59673d29 * 0.6f;
        Transform _0xec9055ef = this.transform;
        float _0x23bb55ee = 0f;
        Tween _0x8b60bb02 = DOTween.To(() => _0x23bb55ee, _0xf7c9b9d0 =>
        {
            _0x23bb55ee = _0xf7c9b9d0;
            float _0x0c47dd7e = _0x23bb55ee;
            Vector3 _0xc99e9b65 = Vector3.Lerp(_0x90d16bc2, _0x1336603e, _0x0c47dd7e);
            _0xc99e9b65.y += Mathf.Sin(_0x0c47dd7e * Mathf.PI) * _0x0816989b;
            _0xec9055ef.position = _0xc99e9b65;
        }, 1f, _0x31f3736d).SetEase(Ease.OutQuad);
        _0x8b60bb02.OnComplete(_0xffd89e42);
        _0xec9055ef.DOScale(1.08f, _0x31f3736d * 0.5f).SetEase(Ease.OutQuad).SetLoops(2, LoopType.Yoyo);
    }

    [SerializeField]
    private SpriteRenderer _renderer;
    public bool _0x70a33862
    {
        get
        {
            return this._0xd13625e6;
        }
    }

    private bool _0xd13625e6;
}