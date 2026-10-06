using DG.Tweening;
using UnityEngine;

/// The wooden order tag under a basket: which fruit, and how many are still wanted.
/// The number itself is a UGUI label the HUD owns, so all text stays in one unit
/// system (rule C.12).
public sealed class _0xf15601ad : MonoBehaviour
{
    public void _0xcef8e884(Sprite _0xc4bcbd79, Sprite _0x12480010, float _0x04253702, float _0x9020e585, int _0xb323168b, int _0x36d87b86, float _0x6923fcbd)
    {
        if (this._plate == null)
            this._plate = this.GetComponent<SpriteRenderer>();
        if (this._plate != null)
        {
            this._plate.sprite = _0xc4bcbd79;
            this._plate.drawMode = SpriteDrawMode.Sliced;
            this._plate.size = new Vector2(_0x04253702, _0x04253702);
            this._plate.sortingOrder = _0xb323168b;
            this._plate.color = Color.white;
        }

        if (this._icon != null)
        {
            this._icon.sprite = _0x12480010;
            this._icon.drawMode = SpriteDrawMode.Sliced;
            this._icon.size = new Vector2(_0x9020e585, _0x9020e585);
            this._icon.sortingOrder = _0x36d87b86;
            this._icon.color = Color.white;
            this._icon.transform.localPosition = new Vector3(0f, _0x6923fcbd, 0f);
        }

        this.transform.localScale = Vector3.one;
    }

    [SerializeField]
    private SpriteRenderer _icon;
    public void _0xd2e55066(Color _0x39668893)
    {
        if (this._plate == null)
            return;
        SpriteRenderer _0x61c72157 = this._plate;
        DOTween.Kill(_0x61c72157, true);
        DOTween.To(() => _0x61c72157.color, _0xcbfbcadf => _0x61c72157.color = _0xcbfbcadf, _0x39668893, 0.25f).SetTarget(_0x61c72157);
    }

    public void _0x164dcff8(float _0x2ed83efe, float _0x92d7fc88, float _0xa867ad66)
    {
        Transform _0x70e9623d = this.transform;
        Vector3 _0x37e43aa3 = _0x70e9623d.position;
        _0x70e9623d.position = new Vector3(_0x37e43aa3.x, _0x37e43aa3.y - _0x2ed83efe, _0x37e43aa3.z);
        DOTween.Kill(_0x70e9623d, true);
        _0x70e9623d.DOMoveY(_0x37e43aa3.y, _0x92d7fc88).SetEase(Ease.OutBack).SetDelay(_0xa867ad66);
    }

    [SerializeField]
    private SpriteRenderer _plate;
}