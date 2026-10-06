using DG.Tweening;
using UnityEngine;

/// One basket at the edge of the lawn. It knows which fruit its tag asks for and how
/// many are still missing, and it answers every tap visibly - a happy bob or a shake
/// with a warm flash (rule C.7).
public sealed class _0xdc8bbf7d : MonoBehaviour
{
    public bool _0x11ba2178(int _0x8cb5b4a1)
    {
        if (this._0x39316c5b)
            return false;
        return _0x8cb5b4a1 == _0x95f69594.JokerFruit || _0x8cb5b4a1 == this._0x85b02334;
    }

    [SerializeField]
    private SpriteRenderer _renderer;
    [SerializeField]
    private BoxCollider2D _bounds;
    public Vector3 _0xca377c48
    {
        get
        {
            return this.transform.position + new Vector3(0f, this._0x160bcdc5 * 0.22f, 0f);
        }
    }

    private int _0xb3004ed8;
    public bool _0x39316c5b
    {
        get
        {
            return this._0xb3004ed8 >= this._0xdd0b5795;
        }
    }

    public int _0x4f64c644
    {
        get
        {
            return this._0xdd0b5795;
        }
    }

    public int _0x8c9f5197
    {
        get
        {
            return this._0xb3004ed8;
        }
    }

    private int _0xdd0b5795;
    public void _0xac066080(Sprite _0x911b75f1, float _0x7fdb7dd8, int _0x2ac78b32, int _0x18da17eb, int _0x9fa94532)
    {
        if (this._renderer == null)
            this._renderer = this.GetComponent<SpriteRenderer>();
        if (this._bounds == null)
            this._bounds = this.GetComponent<BoxCollider2D>();
        this._0x160bcdc5 = Mathf.Max(0.05f, _0x7fdb7dd8);
        this._0x85b02334 = _0x18da17eb;
        this._0xdd0b5795 = Mathf.Max(1, _0x9fa94532);
        this._0xb3004ed8 = 0;
        if (this._renderer != null)
        {
            this._renderer.sprite = _0x911b75f1;
            this._renderer.drawMode = SpriteDrawMode.Sliced;
            this._renderer.size = new Vector2(this._0x160bcdc5, this._0x160bcdc5);
            this._renderer.sortingOrder = _0x2ac78b32;
            this._renderer.color = Color.white;
        }

        if (this._bounds != null)
            this._bounds.size = new Vector2(this._0x160bcdc5 * 1.05f, this._0x160bcdc5 * 1.15f);
        this.transform.localScale = Vector3.one;
    }

    private float _0x160bcdc5 = 1f;
    private int _0x85b02334;
    public void _0xfd474923()
    {
        this._0xb3004ed8 = Mathf.Min(this._0xdd0b5795, this._0xb3004ed8 + 1);
        Transform _0xc1d399aa = this.transform;
        DOTween.Kill(_0xc1d399aa, true);
        _0xc1d399aa.localScale = Vector3.one;
        _0xc1d399aa.DOPunchScale(Vector3.one * 0.12f, 0.25f, 8, 0.8f);
    }

    public bool _0x70d6a616(Vector3 _0x81d6ea17)
    {
        float _0x88481fa9 = this._0x160bcdc5 * 0.62f;
        float _0xbec1edd6 = this._0x160bcdc5 * 0.72f;
        Vector3 _0x13a17724 = _0x81d6ea17 - this.transform.position;
        return Mathf.Abs(_0x13a17724.x) <= _0x88481fa9 && Mathf.Abs(_0x13a17724.y) <= _0xbec1edd6;
    }

    public void _0x7a11f103()
    {
        Transform _0x62a17075 = this.transform;
        DOTween.Kill(_0x62a17075, true);
        _0x62a17075.localScale = new Vector3(0.9f, 0.9f, 1f);
        _0x62a17075.DOScale(1f, 0.35f).SetEase(Ease.OutBack);
    }

    public void _0x0919ea04()
    {
        Transform _0xfe3ac256 = this.transform;
        DOTween.Kill(_0xfe3ac256, true);
        _0xfe3ac256.localScale = Vector3.one;
        _0xfe3ac256.DOPunchPosition(new Vector3(this._0x160bcdc5 * 0.14f, 0f, 0f), 0.30f, 14, 0.9f);
        SpriteRenderer _0x32c3c491 = this._renderer;
        if (_0x32c3c491 == null)
            return;
        Sequence _0x927bce88 = DOTween.Sequence();
        _0x927bce88.Append(DOTween.To(() => _0x32c3c491.color, _0xcbfbcadf => _0x32c3c491.color = _0xcbfbcadf, _0xe94e3611.Coral, 0.1f));
        _0x927bce88.Append(DOTween.To(() => _0x32c3c491.color, _0xcbfbcadf => _0x32c3c491.color = _0xcbfbcadf, Color.white, 0.22f));
        _0x927bce88.SetTarget(_0x32c3c491);
    }

    public int _0x16d32c02
    {
        get
        {
            return this._0x85b02334;
        }
    }
}