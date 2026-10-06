using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The garden chooser: eight cards, two per row, locked ones dimmed and labelled.
/// An empty list still says something rather than showing a blank sheet (rule G).
public sealed class _0xc7e38e61 : MonoBehaviour
{
    private const float GutterCentre = -190f;
    private const float RowPitch = 340f;
    private const float ColumnX = 290f;
    private void _0xacdee6cb(Transform _0xc440ca57, _0xbff45879 _0x1b10b4e0, int _0x188f1378, _0x53858555 _0x27ba00f3, TMP_FontAsset _0xa55d01fb, Sprite _0x91b70bef, Sprite _0x885f8742)
    {
        bool _0x758d851a = _0x27ba00f3 != null && _0x27ba00f3._0x2c16c753(_0x188f1378);
        float _0x570f989a = _0x188f1378 % 2 == 0 ? -ColumnX : ColumnX;
        float _0x27f92910 = TopRowY - RowPitch * (_0x188f1378 / 2);
        Color _0x45b25a5e = _0x758d851a ? _0xe94e3611.LeafDeep : _0xe94e3611.Moss;
        Color _0xac142ace = _0x758d851a ? _0xe94e3611.Forest : _0xe94e3611.WithAlpha(_0xe94e3611.Moss, 0.65f);
        RectTransform _0x9ac357fa = _0xd3e5c9ef.Node(_0xc440ca57, _0x4d197591._0x12a06047(new byte[10] { 187, 157, 142, 152, 153, 146, 191, 157, 142, 152 }, 252), new Vector2(_0x570f989a, _0x27f92910), new Vector2(CardWidth, CardHeight));
        Image _0x856a14a7 = _0x9ac357fa.gameObject.AddComponent<Image>();
        _0x856a14a7.type = Image.Type.Sliced;
        _0x856a14a7.sprite = _0x91b70bef;
        _0x856a14a7.pixelsPerUnitMultiplier = _0xd3e5c9ef.PlateRoundness(new Vector2(CardWidth, CardHeight));
        _0x856a14a7.color = _0x45b25a5e;
        _0x856a14a7.raycastTarget = true;
        Image _0xd14c49f4 = _0xd3e5c9ef.Plate(_0x9ac357fa, _0x4d197591._0x12a06047(new byte[14] { 206, 232, 251, 237, 236, 231, 202, 232, 251, 237, 203, 230, 237, 240 }, 137), Vector2.zero, new Vector2(CardWidth - 14f, CardHeight - 14f), _0xac142ace, _0x91b70bef);
        _0xd14c49f4.raycastTarget = false;
        Image _0xced71d11 = _0xd3e5c9ef.Plate(_0x9ac357fa, _0x4d197591._0x12a06047(new byte[15] { 253, 219, 200, 222, 223, 212, 249, 219, 200, 222, 252, 214, 219, 201, 210 }, 186), Vector2.zero, new Vector2(CardWidth - 14f, CardHeight - 14f), _0xe94e3611.WithAlpha(_0xe94e3611.Coral, 0f), _0x91b70bef);
        _0xced71d11.raycastTarget = false;
        // The number sits alone in its gutter; the title column starts clear of it, so
        // no letter ever runs under the badge (rule C.25).
        _0xd3e5c9ef.Caption(_0x9ac357fa, _0x4d197591._0x12a06047(new byte[12] { 26, 60, 47, 57, 56, 51, 19, 40, 48, 63, 56, 47 }, 93), new Vector2(GutterCentre, 100f), new Vector2(GutterHalf * 2f, 56f), _0xa55d01fb, (_0x188f1378 + 1).ToString(), 44f, _0x758d851a ? _0xe94e3611.Sun : _0xe94e3611.CreamSoft, TextAlignmentOptions.Center);
        float _0x5b917846 = GutterCentre + GutterHalf + TextGap;
        float _0x0a3ad550 = CardWidth * 0.5f - _0x5b917846 - 24f;
        _0xd3e5c9ef.Caption(_0x9ac357fa, _0x4d197591._0x12a06047(new byte[10] { 76, 106, 121, 111, 110, 101, 69, 106, 102, 110 }, 11), new Vector2(_0x5b917846 + _0x0a3ad550 * 0.5f, 100f), new Vector2(_0x0a3ad550, 56f), _0xa55d01fb, _0x1b10b4e0 != null ? _0x1b10b4e0._0x351be776 : _0x4d197591._0x12a06047(new byte[6] { 253, 251, 232, 254, 255, 244 }, 186), 38f, _0xe94e3611.Cream, TextAlignmentOptions.Left);
        int _0xb40a093a = _0x1b10b4e0 != null ? _0x1b10b4e0._0x2e59e1a7 : 9;
        _0xd3e5c9ef.Caption(_0x9ac357fa, _0x4d197591._0x12a06047(new byte[10] { 119, 81, 66, 84, 85, 94, 119, 95, 81, 92 }, 48), new Vector2(0f, 28f), new Vector2(CardWidth - 60f, 48f), _0xa55d01fb, _0x758d851a ? _0xb40a093a + _0x4d197591._0x12a06047(new byte[6] { 138, 236, 248, 255, 227, 254 }, 170) : _0x4d197591._0x12a06047(new byte[14] { 128, 143, 136, 143, 149, 142, 230, 129, 135, 148, 130, 131, 136, 230 }, 198) + _0x188f1378 + _0x4d197591._0x12a06047(new byte[6] { 163, 197, 202, 209, 208, 215 }, 131), 32f, _0xe94e3611.CreamSoft, TextAlignmentOptions.Center);
        int _0x51022223 = _0x27ba00f3 != null ? _0x27ba00f3._0x64bacb1c(_0x188f1378) : 0;
        _0xd3e5c9ef.Caption(_0x9ac357fa, _0x4d197591._0x12a06047(new byte[10] { 223, 249, 234, 252, 253, 246, 218, 253, 235, 236 }, 152), new Vector2(0f, -30f), new Vector2(CardWidth - 60f, 48f), _0xa55d01fb, _0x51022223 > 0 ? _0x4d197591._0x12a06047(new byte[5] { 17, 22, 0, 7, 115 }, 83) + _0x51022223 : _0x4d197591._0x12a06047(new byte[13] { 195, 194, 173, 223, 200, 206, 194, 223, 201, 173, 212, 200, 217 }, 141), 32f, _0x758d851a ? _0xe94e3611.Leaf : _0xe94e3611.CreamSoft, TextAlignmentOptions.Center);
        // Pips keep their own row under the text, never beside it.
        for (int _0xefdf439f = 0; _0xefdf439f < 3; _0xefdf439f++)
        {
            Color _0x78630f00 = _0x758d851a && _0x51022223 > 0 && _0xefdf439f < Mathf.Min(3, 1 + _0x51022223 / 80) ? _0xe94e3611.Leaf : _0xe94e3611.WithAlpha(_0xe94e3611.CreamSoft, 0.35f);
            _0xd3e5c9ef.Picture(_0x9ac357fa, _0x4d197591._0x12a06047(new byte[9] { 161, 135, 148, 130, 131, 136, 182, 143, 150 }, 230), new Vector2((_0xefdf439f - 1) * 54f, -98f), new Vector2(36f, 36f), _0x885f8742, _0x78630f00);
        }

        Button _0x185780b6 = _0x9ac357fa.gameObject.AddComponent<Button>();
        _0x185780b6.targetGraphic = _0x856a14a7;
        _0x185780b6.transition = Selectable.Transition.ColorTint;
        ColorBlock _0x296f1ce7 = _0x185780b6.colors;
        _0x296f1ce7.normalColor = _0xe94e3611.White;
        _0x296f1ce7.highlightedColor = _0xe94e3611.White;
        _0x296f1ce7.pressedColor = new Color(0.72f, 0.80f, 0.70f, 1f);
        _0x296f1ce7.selectedColor = _0xe94e3611.White;
        _0x296f1ce7.disabledColor = new Color(0.55f, 0.58f, 0.54f, 0.6f);
        _0x296f1ce7.fadeDuration = 0.08f;
        _0x185780b6.colors = _0x296f1ce7;
        _0x08f31702 _0x29680f52 = _0x9ac357fa.gameObject.AddComponent<_0x08f31702>();
        _0x29680f52._0x8e0fbeff(_0x185780b6, _0x9ac357fa, _0xced71d11, _0x27ba00f3, _0x188f1378);
    }

    private const float CardWidth = 520f;
    private const float CardHeight = 300f;
    [SerializeField]
    private _0xe2863a9e _gate;
    private const float GutterHalf = 45f;
    public void _0x94e1c93a(Transform _0x1be0e1ef, _0xbff45879[] _0x93ab7bf5, _0x53858555 _0xd6da3e8a, TMP_FontAsset _0x82d67456, Sprite _0x19f6ab35, Sprite _0x484fe448, Sprite _0xf1ef420e, _0xe2863a9e _0xce15e01d)
    {
        this._progress = _0xd6da3e8a;
        this._gate = _0xce15e01d;
        RectTransform _0x8e48525c = _0xd3e5c9ef.Sheet(_0x1be0e1ef, _0x4d197591._0x12a06047(new byte[11] { 127, 89, 74, 92, 93, 86, 107, 80, 93, 93, 76 }, 56));
        Image _0xe205336e = _0xd3e5c9ef.Shade(_0x8e48525c, _0x4d197591._0x12a06047(new byte[11] { 174, 136, 155, 141, 140, 135, 186, 129, 136, 141, 140 }, 233), _0xe94e3611.WithAlpha(_0xe94e3611.NightGarden, 0.86f), _0x19f6ab35);
        Button _0x8f100fc8 = _0xe205336e.gameObject.AddComponent<Button>();
        _0x8f100fc8.transition = Selectable.Transition.None;
        _0xb979e81f _0x2c47482e = _0xe205336e.gameObject.AddComponent<_0xb979e81f>();
        _0x2c47482e._0x85ee218d(_0x8f100fc8, _0xce15e01d, null, true);
        _0xd3e5c9ef.Caption(_0x8e48525c, _0x4d197591._0x12a06047(new byte[11] { 239, 201, 218, 204, 205, 198, 252, 193, 220, 196, 205 }, 168), new Vector2(0f, 1075f), new Vector2(700f, 80f), _0x82d67456, _0x4d197591._0x12a06047(new byte[15] { 85, 94, 89, 89, 69, 83, 54, 87, 54, 81, 87, 68, 82, 83, 88 }, 22), 52f, _0xe94e3611.Cream, TextAlignmentOptions.Center);
        Button _0x1f0aa6e6 = _0xd3e5c9ef.IconAction(_0x8e48525c, _0x4d197591._0x12a06047(new byte[11] { 37, 3, 16, 6, 7, 12, 33, 14, 13, 17, 7 }, 98), new Vector2(470f, 1075f), new Vector2(110f, 110f), _0xe94e3611.LeafDeep, _0xe94e3611.Forest, _0x484fe448, _0x19f6ab35);
        _0xb979e81f _0x6acbc442 = _0x1f0aa6e6.gameObject.AddComponent<_0xb979e81f>();
        _0x6acbc442._0x85ee218d(_0x1f0aa6e6, _0xce15e01d, null, true);
        int _0x0e779a72 = _0x93ab7bf5 == null ? 0 : _0x93ab7bf5.Length;
        if (_0x0e779a72 == 0)
        {
            _0xd3e5c9ef.Caption(_0x8e48525c, _0x4d197591._0x12a06047(new byte[11] { 165, 131, 144, 134, 135, 140, 167, 143, 146, 150, 155 }, 226), Vector2.zero, new Vector2(900f, 90f), _0x82d67456, _0x4d197591._0x12a06047(new byte[19] { 148, 149, 142, 146, 147, 148, 157, 250, 142, 149, 250, 138, 147, 153, 145, 250, 131, 159, 142 }, 218), 40f, _0xe94e3611.Cream, TextAlignmentOptions.Center);
            return;
        }

        for (int _0xb5f3872d = 0; _0xb5f3872d < _0x0e779a72; _0xb5f3872d++)
            this._0xacdee6cb(_0x8e48525c, _0x93ab7bf5[_0xb5f3872d], _0xb5f3872d, _0xd6da3e8a, _0x82d67456, _0x19f6ab35, _0xf1ef420e);
    }

    private const float TopRowY = 640f;
    private const float TextGap = 25f;
    [SerializeField]
    private _0x53858555 _progress;
}

internal static class _0x4d197591
{
    internal static string _0x12a06047(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}