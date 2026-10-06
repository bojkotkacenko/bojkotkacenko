using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// Three boards that explain the one gesture this game has. Each step changes the
/// picture, the heading colour and the active pip, so two captured frames can never
/// look the same.
public sealed class _0x4ae2c94f : MonoBehaviour
{
    private int _0x4a7f4855;
    [SerializeField]
    private TextMeshProUGUI _actionLabel;
    [SerializeField]
    private _0xe2863a9e _gardens;
    [SerializeField]
    private Image[] _pips = new Image[StepCount];
    [SerializeField]
    private _0xe2863a9e _gate;
    public void _0x367d3c61()
    {
        this._0x4a7f4855 = 0;
        this._0x297c4d64();
    }

    private const int StepCount = 3;
    [SerializeField]
    private Image _art;
    public void _0xb9a46556(Transform _0xd2757474, TMP_FontAsset _0x48b021ac, Sprite _0xeec7c232, Sprite _0xf0d1b3b6, Sprite _0xd9472a5a, Sprite _0xc37d8e73, Sprite _0x98022745, Sprite _0x9d00f02a, _0xe2863a9e _0x7fc26e3e, _0xe2863a9e _0x2c435d4b)
    {
        this._gate = _0x7fc26e3e;
        this._gardens = _0x2c435d4b;
        this._art0 = new Sprite[StepCount];
        this._art0[0] = _0xc37d8e73;
        this._art0[1] = _0x98022745;
        this._art0[2] = _0x9d00f02a;
        RectTransform _0x342ee2e0 = _0xd3e5c9ef.Sheet(_0xd2757474, _0x543878be._0x6bc87688(new byte[10] { 87, 112, 104, 75, 112, 76, 119, 122, 122, 107 }, 31));
        Image _0xf97d3d46 = _0xd3e5c9ef.Shade(_0x342ee2e0, _0x543878be._0x6bc87688(new byte[10] { 38, 1, 25, 58, 1, 61, 6, 15, 10, 11 }, 110), _0xe94e3611.WithAlpha(_0xe94e3611.NightGarden, 0.90f), _0xeec7c232);
        Button _0xb712bd76 = _0xf97d3d46.gameObject.AddComponent<Button>();
        _0xb712bd76.transition = Selectable.Transition.None;
        _0xb979e81f _0xdea0cba4 = _0xf97d3d46.gameObject.AddComponent<_0xb979e81f>();
        _0xdea0cba4._0x85ee218d(_0xb712bd76, _0x7fc26e3e, null, true);
        this._card = _0xd3e5c9ef.Node(_0x342ee2e0, _0x543878be._0x6bc87688(new byte[9] { 165, 130, 154, 185, 130, 174, 140, 159, 137 }, 237), new Vector2(0f, 150f), new Vector2(980f, 1400f));
        Image _0x3d757f7d = this._card.gameObject.AddComponent<Image>();
        _0x3d757f7d.type = Image.Type.Sliced;
        _0x3d757f7d.sprite = _0xeec7c232;
        _0x3d757f7d.pixelsPerUnitMultiplier = _0xd3e5c9ef.PlateRoundness(new Vector2(980f, 1400f));
        _0x3d757f7d.color = _0xe94e3611.LeafDeep;
        _0x3d757f7d.raycastTarget = true;
        Image _0xb6e7ff3e = _0xd3e5c9ef.Plate(this._card, _0x543878be._0x6bc87688(new byte[9] { 86, 113, 105, 74, 113, 92, 113, 122, 103 }, 30), Vector2.zero, new Vector2(966f, 1386f), _0xe94e3611.Forest, _0xeec7c232);
        _0xb6e7ff3e.raycastTarget = false;
        this._art = _0xd3e5c9ef.Picture(this._card, _0x543878be._0x6bc87688(new byte[8] { 140, 171, 179, 144, 171, 133, 182, 176 }, 196), new Vector2(0f, 380f), new Vector2(420f, 420f), _0xc37d8e73, _0xe94e3611.White);
        this._heading = _0xd3e5c9ef.Caption(this._card, _0x543878be._0x6bc87688(new byte[12] { 124, 91, 67, 96, 91, 124, 81, 85, 80, 93, 90, 83 }, 52), new Vector2(0f, 90f), new Vector2(880f, 80f), _0x48b021ac, _0x543878be._0x6bc87688(new byte[19] { 23, 22, 29, 120, 30, 10, 13, 17, 12, 120, 25, 12, 120, 25, 120, 12, 17, 21, 29 }, 88), 48f, _0xe94e3611.Cream, TextAlignmentOptions.Center);
        this._body = _0xd3e5c9ef.Caption(this._card, _0x543878be._0x6bc87688(new byte[9] { 105, 78, 86, 117, 78, 117, 68, 89, 85 }, 33), new Vector2(0f, -70f), new Vector2(880f, 200f), _0x48b021ac, _0x543878be._0x6bc87688(new byte[52] { 227, 130, 228, 240, 247, 235, 246, 130, 238, 227, 236, 230, 241, 130, 237, 236, 130, 246, 234, 231, 130, 246, 240, 227, 251, 140, 168, 246, 234, 240, 231, 231, 130, 224, 227, 241, 233, 231, 246, 241, 130, 245, 227, 235, 246, 130, 224, 231, 238, 237, 245, 140 }, 162), 38f, _0xe94e3611.CreamSoft, TextAlignmentOptions.Center);
        this._pips = new Image[StepCount];
        for (int _0x28177bad = 0; _0x28177bad < StepCount; _0x28177bad++)
            this._pips[_0x28177bad] = _0xd3e5c9ef.Picture(this._card, _0x543878be._0x6bc87688(new byte[8] { 170, 141, 149, 182, 141, 178, 139, 146 }, 226), new Vector2((_0x28177bad - 1) * 60f, -260f), new Vector2(40f, 40f), _0xd9472a5a, _0xe94e3611.Moss);
        Button _0x768a27ed = _0xd3e5c9ef.Action(this._card, _0x543878be._0x6bc87688(new byte[9] { 221, 250, 226, 193, 250, 219, 240, 237, 225 }, 149), new Vector2(0f, -470f), new Vector2(560f, 132f), _0xe94e3611.Leaf, _0xe94e3611.LeafDeep, _0xe94e3611.Cream, _0x48b021ac, _0x543878be._0x6bc87688(new byte[4] { 28, 23, 10, 6 }, 82), 44f, _0xeec7c232);
        _0x768a27ed.onClick.AddListener(() => this._0xe28b075d());
        this._actionLabel = _0x768a27ed.GetComponentInChildren<TextMeshProUGUI>();
        Button _0x9e4f1895 = _0xd3e5c9ef.IconAction(_0x342ee2e0, _0x543878be._0x6bc87688(new byte[12] { 80, 119, 111, 76, 119, 95, 121, 106, 124, 125, 118, 107 }, 24), new Vector2(470f, 1075f), new Vector2(110f, 110f), _0xe94e3611.LeafDeep, _0xe94e3611.Forest, _0xf0d1b3b6, _0xeec7c232);
        _0xb979e81f _0x9c1db909 = _0x9e4f1895.gameObject.AddComponent<_0xb979e81f>();
        _0x9c1db909._0x85ee218d(_0x9e4f1895, _0x2c435d4b, _0x7fc26e3e, false);
        this._0x4a7f4855 = 0;
        this._0x297c4d64();
    }

    [SerializeField]
    private TextMeshProUGUI _body;
    [SerializeField]
    private TextMeshProUGUI _heading;
    [SerializeField]
    private RectTransform _card;
    private void _0xe28b075d()
    {
        if (this._0x4a7f4855 >= StepCount - 1)
        {
            if (this._gate != null)
                this._gate._0xf5b3e926();
            if (this._gardens != null)
                this._gardens._0xf7e30ac2();
            this._0x4a7f4855 = 0;
            this._0x297c4d64();
            return;
        }

        this._0x4a7f4855++;
        this._0x297c4d64();
        if (this._card != null)
        {
            DOTween.Kill(this._card, true);
            this._card.localScale = new Vector3(0.97f, 0.97f, 1f);
            this._card.DOScale(1f, 0.18f).SetEase(Ease.OutBack);
        }
    }

    [SerializeField]
    private Sprite[] _art0 = new Sprite[StepCount];
    private void _0x297c4d64()
    {
        string _0x868445e7 = _0x543878be._0x6bc87688(new byte[19] { 142, 143, 132, 225, 135, 147, 148, 136, 149, 225, 128, 149, 225, 128, 225, 149, 136, 140, 132 }, 193);
        string _0xf805a847 = _0x543878be._0x6bc87688(new byte[52] { 238, 143, 233, 253, 250, 230, 251, 143, 227, 238, 225, 235, 252, 143, 224, 225, 143, 251, 231, 234, 143, 251, 253, 238, 246, 129, 165, 251, 231, 253, 234, 234, 143, 237, 238, 252, 228, 234, 251, 252, 143, 248, 238, 230, 251, 143, 237, 234, 227, 224, 248, 129 }, 175);
        Color _0x0eb8a7db = _0xe94e3611.Cream;
        if (this._0x4a7f4855 == 1)
        {
            _0x868445e7 = _0x543878be._0x6bc87688(new byte[20] { 80, 69, 84, 36, 80, 76, 65, 36, 86, 77, 67, 76, 80, 36, 70, 69, 87, 79, 65, 80 }, 4);
            _0xf805a847 = _0x543878be._0x6bc87688(new byte[48] { 143, 139, 137, 130, 234, 158, 139, 141, 234, 153, 130, 133, 157, 153, 234, 157, 130, 139, 158, 234, 139, 234, 136, 139, 153, 129, 143, 158, 192, 157, 139, 132, 158, 153, 234, 139, 132, 142, 234, 130, 133, 157, 234, 135, 139, 132, 147, 228 }, 202);
            _0x0eb8a7db = _0xe94e3611.Leaf;
        }
        else if (this._0x4a7f4855 >= 2)
        {
            _0x868445e7 = _0x543878be._0x6bc87688(new byte[22] { 186, 181, 170, 185, 220, 175, 176, 181, 172, 175, 220, 185, 178, 184, 220, 168, 180, 185, 220, 184, 189, 165 }, 252);
            _0xf805a847 = _0x543878be._0x6bc87688(new byte[63] { 9, 104, 31, 26, 7, 6, 15, 104, 10, 9, 27, 3, 13, 28, 104, 11, 7, 27, 28, 27, 104, 7, 6, 13, 104, 4, 13, 9, 14, 102, 66, 14, 1, 30, 13, 104, 4, 13, 9, 30, 13, 27, 104, 9, 6, 12, 104, 28, 0, 13, 104, 12, 9, 17, 104, 1, 27, 104, 7, 30, 13, 26, 102 }, 72);
            _0x0eb8a7db = _0xe94e3611.Sun;
        }

        if (this._heading != null)
        {
            _0xf6b60f03.Apply(this._heading, _0x0eb8a7db, 48f);
            _0xf6b60f03.SetText(this._heading, _0x868445e7);
        }

        _0xf6b60f03.SetText(this._body, _0xf805a847);
        if (this._art != null && this._art0 != null && this._0x4a7f4855 < this._art0.Length)
        {
            Image _0x1c6bbddf = this._art;
            _0x1c6bbddf.sprite = this._art0[this._0x4a7f4855];
            _0x1c6bbddf.preserveAspect = true;
        }

        for (int _0xaef7ec62 = 0; _0xaef7ec62 < StepCount; _0xaef7ec62++)
            if (this._pips != null && _0xaef7ec62 < this._pips.Length && this._pips[_0xaef7ec62] != null)
                this._pips[_0xaef7ec62].color = _0xaef7ec62 == this._0x4a7f4855 ? _0xe94e3611.Sun : _0xe94e3611.Moss;
        if (this._actionLabel != null)
            _0xf6b60f03.SetText(this._actionLabel, this._0x4a7f4855 >= StepCount - 1 ? _0x543878be._0x6bc87688(new byte[15] { 164, 175, 168, 168, 180, 162, 199, 166, 199, 160, 166, 181, 163, 162, 169 }, 231) : _0x543878be._0x6bc87688(new byte[4] { 81, 90, 71, 75 }, 31));
    }
}

internal static class _0x543878be
{
    internal static string _0x6bc87688(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}