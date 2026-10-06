using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// One garden card in the chooser. An open card starts the day; a locked one answers
/// with a shake and a warm flash, so the tap is visibly acknowledged (rule C.7).
public sealed class _0x08f31702 : MonoBehaviour
{
    [SerializeField]
    private int _gardenIndex;
    [SerializeField]
    private _0x53858555 _progress;
    [SerializeField]
    private Image _flash;
    private void _0x0be99e11()
    {
        if (this._card != null)
        {
            DOTween.Kill(this._card, true);
            this._card.DOPunchPosition(new Vector3(18f, 0f, 0f), 0.25f, 12, 0.9f);
        }

        if (this._flash != null)
        {
            Image _0x39cb3028 = this._flash;
            DOTween.Kill(_0x39cb3028, true);
            _0x39cb3028.color = _0xe94e3611.WithAlpha(_0xe94e3611.Coral, 0f);
            Sequence _0x6496d5e5 = DOTween.Sequence();
            _0x6496d5e5.Append(DOTween.To(() => _0x39cb3028.color.a, _0xf7c9b9d0 => _0x39cb3028.color = _0xe94e3611.WithAlpha(_0xe94e3611.Coral, _0xf7c9b9d0), 0.5f, 0.12f));
            _0x6496d5e5.Append(DOTween.To(() => _0x39cb3028.color.a, _0xf7c9b9d0 => _0x39cb3028.color = _0xe94e3611.WithAlpha(_0xe94e3611.Coral, _0xf7c9b9d0), 0f, 0.22f));
            _0x6496d5e5.SetTarget(_0x39cb3028);
        }
    }

    public void _0x8e0fbeff(Button _0x5cca53ab, RectTransform _0xb711996f, Image _0xccec8e3e, _0x53858555 _0x73943eb7, int _0x2e4bb0a7)
    {
        this._button = _0x5cca53ab;
        this._card = _0xb711996f;
        this._flash = _0xccec8e3e;
        this._progress = _0x73943eb7;
        this._gardenIndex = _0x2e4bb0a7;
        if (this._button != null)
            this._button.onClick.AddListener(() => this._0x7e140829());
    }

    private void _0x7e140829()
    {
        if (this._progress == null)
            return;
        if (this._progress._0x2c16c753(this._gardenIndex))
        {
            this._progress._0x72738754(this._gardenIndex);
            if (_0x24245b46.Instance != null)
                _0x24245b46.Instance._0x27fae1f7(_0xb0135da5._0x73d482f8.SCENE_1);
            return;
        }

        this._0x0be99e11();
    }

    [SerializeField]
    private RectTransform _card;
    [SerializeField]
    private Button _button;
}