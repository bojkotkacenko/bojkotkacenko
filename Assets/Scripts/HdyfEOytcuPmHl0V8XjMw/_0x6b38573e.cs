using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// Dresses all three result cards - pause, win and loss - with this garden's words,
/// palette and buttons, and raises them. The template's own card contents are
/// switched off first, so nothing of its wording or its unassigned close icon can
/// reach a screenshot (rule C.3).
public sealed class _0x6b38573e : MonoBehaviour
{
    [SerializeField]
    private TMP_FontAsset _font;
    private TextMeshProUGUI _0x367a214f(Transform _0x293bb958, string _0xc7ea76fb)
    {
        return _0xd3e5c9ef.Caption(_0x293bb958, _0x05de5f6d._0x9f44454c(new byte[14] { 58, 13, 27, 29, 4, 28, 42, 7, 12, 17, 60, 13, 16, 28 }, 104), new Vector2(0f, -10f), new Vector2(860f, 90f), this._font, _0xc7ea76fb, 42f, _0xe94e3611.Cream, TextAlignmentOptions.Center);
    }

    private TextMeshProUGUI _0x399ccd96;
    [SerializeField]
    private Sprite _pauseArt;
    // -------- button handlers --------
    private void _0xbee98a81()
    {
        if (_0x6e6daaaf.Instance != null)
            _0x6e6daaaf.Instance._0x29da2ed9();
        if (this._game != null)
            this._game._0xa2d82089();
    }

    private const float CardHeight = 1080f;
    [SerializeField]
    private Sprite _closeIcon;
    public void _0x333312ab(string _0xdb4080df)
    {
        _0x0593ece4 _0x5ba1a588 = _0x6e6daaaf.Instance != null ? _0x6e6daaaf.Instance._0xa401efea(_0xb0135da5._0x9123adc7.PAUSE) : null;
        if (_0x5ba1a588 == null)
            return;
        _0xf6b60f03.SetText(this._0x7644b7f6, _0x05de5f6d._0x9f44454c(new byte[13] { 118, 99, 105, 103, 2, 99, 2, 96, 112, 103, 99, 118, 106 }, 34));
        _0xf6b60f03.SetText(this._0x57707435, _0x05de5f6d._0x9f44454c(new byte[20] { 124, 96, 109, 8, 111, 105, 122, 108, 109, 102, 8, 127, 97, 100, 100, 8, 127, 105, 97, 124 }, 40));
        _0xf6b60f03.SetText(this._0xaabfdc54, _0xdb4080df);
        _0x6e6daaaf.Instance._0x8717e92b(_0xb0135da5._0x9123adc7.PAUSE);
    }

    private TextMeshProUGUI _0x57707435;
    private void _0xaa68e630(Transform _0x3098392f, Sprite _0xc5153612)
    {
        _0xd3e5c9ef.Picture(_0x3098392f, _0x05de5f6d._0x9f44454c(new byte[9] { 116, 67, 85, 83, 74, 82, 103, 84, 82 }, 38), new Vector2(0f, 205f), new Vector2(250f, 250f), _0xc5153612, _0xe94e3611.White);
    }

    [SerializeField]
    private _0x2fae4a14 _game;
    [SerializeField]
    private Sprite _winArt;
    private TextMeshProUGUI _0x99a9066b;
    [SerializeField]
    private Sprite _loseArt;
    private TextMeshProUGUI _0x7375cce2;
    private TextMeshProUGUI _0xdf58c495(Transform _0x6dc3c778, string _0x56e70658, Color _0xbcb1a06e)
    {
        return _0xd3e5c9ef.Caption(_0x6dc3c778, _0x05de5f6d._0x9f44454c(new byte[10] { 18, 37, 51, 53, 44, 52, 8, 37, 33, 36 }, 64), new Vector2(0f, 390f), new Vector2(700f, 90f), this._font, _0x56e70658, 52f, _0xbcb1a06e, TextAlignmentOptions.Center);
    }

    /// A card the capture run never dismisses must let go by itself, or the run
    /// parks on it for the rest of the window.
    public void _0xaeb8793e(float _0xa820dd15)
    {
        DOVirtual.DelayedCall(_0xa820dd15, () => this._0xbee98a81(), false);
    }

    private TextMeshProUGUI _0xdb09dc1f;
    private void _0x31eed618()
    {
        if (_0x6e6daaaf.Instance != null)
            _0x6e6daaaf.Instance._0x29da2ed9();
        if (_0x24245b46.Instance != null)
        {
            _0x24245b46.Instance._0x11e6a30d(true);
            _0x24245b46.Instance._0x27fae1f7(_0xb0135da5._0x73d482f8.SCENE_1);
        }
    }

    private TextMeshProUGUI _0x7644b7f6;
    private Button _0xa2263157(Transform _0x0506cd01, string _0xfd264d93)
    {
        return _0xd3e5c9ef.Action(_0x0506cd01, _0x05de5f6d._0x9f44454c(new byte[13] { 133, 178, 164, 162, 187, 163, 135, 165, 190, 186, 182, 165, 174 }, 215), new Vector2(0f, -265f), new Vector2(620f, 140f), _0xe94e3611.Leaf, _0xe94e3611.LeafDeep, _0xe94e3611.Cream, this._font, _0xfd264d93, 44f, this._roundPlate);
    }

    // -------- card construction --------
    private Transform _0x6ca02aba(_0x0593ece4 _0x16e04991, Color _0xff2cdb9a)
    {
        Transform _0x602d0218 = _0x16e04991.Content != null ? _0x16e04991.Content.transform : _0x16e04991.transform;
        for (int _0x456f142e = _0x602d0218.childCount - 1; _0x456f142e >= 0; _0x456f142e--)
            _0x602d0218.GetChild(_0x456f142e).gameObject.SetActive(false);
        RectTransform _0xa49be856 = _0xd3e5c9ef.Node(_0x602d0218, _0x05de5f6d._0x9f44454c(new byte[10] { 12, 59, 45, 43, 50, 42, 29, 63, 44, 58 }, 94), Vector2.zero, new Vector2(CardWidth, CardHeight));
        Image _0xb3b5e534 = _0xa49be856.gameObject.AddComponent<Image>();
        _0xb3b5e534.type = Image.Type.Sliced;
        _0xb3b5e534.sprite = this._roundPlate;
        _0xb3b5e534.pixelsPerUnitMultiplier = _0xd3e5c9ef.PlateRoundness(new Vector2(CardWidth, CardHeight));
        _0xb3b5e534.color = _0xff2cdb9a;
        _0xb3b5e534.raycastTarget = true;
        Image _0xe93c1638 = _0xd3e5c9ef.Plate(_0xa49be856, _0x05de5f6d._0x9f44454c(new byte[10] { 130, 181, 163, 165, 188, 164, 146, 191, 180, 169 }, 208), Vector2.zero, new Vector2(CardWidth - 16f, CardHeight - 16f), _0xe94e3611.Forest, this._roundPlate);
        _0xe93c1638.raycastTarget = false;
        return _0xa49be856;
    }

    private TextMeshProUGUI _0xf21bfdcc;
    public void _0x7fa11dd1(string _0x01d79e31, string _0x9007d927)
    {
        _0x0593ece4 _0x1b5d00a2 = _0x6e6daaaf.Instance != null ? _0x6e6daaaf.Instance._0xa401efea(_0xb0135da5._0x9123adc7.LOSE) : null;
        if (_0x1b5d00a2 == null)
            return;
        _0xf6b60f03.SetText(this._0x86d28410, _0x05de5f6d._0x9f44454c(new byte[15] { 0, 28, 17, 116, 16, 21, 13, 116, 29, 7, 116, 27, 2, 17, 6 }, 84));
        _0xf6b60f03.SetText(this._0x99a9066b, _0x01d79e31);
        _0xf6b60f03.SetText(this._0xdb09dc1f, _0x9007d927);
        _0x6e6daaaf.Instance._0x8717e92b(_0xb0135da5._0x9123adc7.LOSE);
    }

    private void _0x3384be6b()
    {
        if (_0x6e6daaaf.Instance != null)
            _0x6e6daaaf.Instance._0x29da2ed9();
        if (_0x24245b46.Instance != null)
        {
            _0x24245b46.Instance._0x11e6a30d(true);
            _0x24245b46.Instance._0x27fae1f7(_0xb0135da5._0x73d482f8.SCENE_0);
        }
    }

    public void _0x3290b3a0(_0x2fae4a14 _0x9ba38e8c, TMP_FontAsset _0x7f382ed4, Sprite _0x9bf762c2, Sprite _0xec76c9ef, Sprite _0xd95ccd82, Sprite _0xe0bfe440, Sprite _0xdd1aee31)
    {
        this._game = _0x9ba38e8c;
        this._font = _0x7f382ed4;
        this._roundPlate = _0x9bf762c2;
        this._closeIcon = _0xec76c9ef;
        this._winArt = _0xd95ccd82;
        this._loseArt = _0xe0bfe440;
        this._pauseArt = _0xdd1aee31;
        _0x0593ece4 _0x92050ba7 = _0x6e6daaaf.Instance != null ? _0x6e6daaaf.Instance._0xa401efea(_0xb0135da5._0x9123adc7.WIN) : null;
        if (_0x92050ba7 != null)
        {
            Transform _0xcd421b24 = this._0x6ca02aba(_0x92050ba7, _0xe94e3611.Sun);
            this._0x399ccd96 = this._0xdf58c495(_0xcd421b24, _0x05de5f6d._0x9f44454c(new byte[12] { 216, 219, 201, 209, 223, 206, 201, 186, 220, 207, 214, 214 }, 154), _0xe94e3611.Sun);
            this._0xaa68e630(_0xcd421b24, _0xd95ccd82);
            this._0x7375cce2 = this._0x367a214f(_0xcd421b24, _0x05de5f6d._0x9f44454c(new byte[19] { 231, 244, 231, 240, 251, 130, 237, 240, 230, 231, 240, 130, 235, 241, 130, 230, 237, 236, 231 }, 162));
            this._0xf21bfdcc = this._0x36ff9b4d(_0xcd421b24, _0x05de5f6d._0x9f44454c(new byte[9] { 132, 144, 151, 139, 150, 226, 242, 237, 242 }, 194));
            Button _0xc63016d2 = this._0xa2263157(_0xcd421b24, _0x05de5f6d._0x9f44454c(new byte[11] { 119, 124, 97, 109, 25, 126, 120, 107, 125, 124, 119 }, 57));
            _0xc63016d2.onClick.AddListener(() => this._0xb5a2f2fa());
            this._0x11cc0a89 = _0xc63016d2.GetComponentInChildren<TextMeshProUGUI>();
            Button _0x11181cbb = this._0x9bee054c(_0xcd421b24, _0x05de5f6d._0x9f44454c(new byte[4] { 243, 251, 240, 235 }, 190));
            _0x11181cbb.onClick.AddListener(() => this._0x3384be6b());
            Button _0x0de47ccb = this._0xe8fc7125(_0xcd421b24);
            _0x0de47ccb.onClick.AddListener(() => this._0x3384be6b());
        }

        _0x0593ece4 _0x0ee9ab8e = _0x6e6daaaf.Instance != null ? _0x6e6daaaf.Instance._0xa401efea(_0xb0135da5._0x9123adc7.LOSE) : null;
        if (_0x0ee9ab8e != null)
        {
            Transform _0x66703eac = this._0x6ca02aba(_0x0ee9ab8e, _0xe94e3611.Coral);
            this._0x86d28410 = this._0xdf58c495(_0x66703eac, _0x05de5f6d._0x9f44454c(new byte[15] { 87, 75, 70, 35, 71, 66, 90, 35, 74, 80, 35, 76, 85, 70, 81 }, 3), _0xe94e3611.Sun);
            this._0xaa68e630(_0x66703eac, _0xe0bfe440);
            this._0x99a9066b = this._0x367a214f(_0x66703eac, _0x05de5f6d._0x9f44454c(new byte[23] { 205, 194, 221, 206, 171, 205, 217, 222, 194, 223, 216, 171, 220, 206, 197, 223, 171, 202, 216, 223, 217, 202, 210 }, 139));
            this._0xdb09dc1f = this._0x36ff9b4d(_0x66703eac, _0x05de5f6d._0x9f44454c(new byte[10] { 159, 144, 149, 149, 156, 157, 249, 233, 246, 233 }, 217));
            Button _0xe8e83bf9 = this._0xa2263157(_0x66703eac, _0x05de5f6d._0x9f44454c(new byte[9] { 149, 147, 152, 225, 128, 134, 128, 136, 143 }, 193));
            _0xe8e83bf9.onClick.AddListener(() => this._0x31eed618());
            Button _0xc2cc8779 = this._0x9bee054c(_0x66703eac, _0x05de5f6d._0x9f44454c(new byte[4] { 240, 248, 243, 232 }, 189));
            _0xc2cc8779.onClick.AddListener(() => this._0x3384be6b());
            Button _0x429e2f10 = this._0xe8fc7125(_0x66703eac);
            _0x429e2f10.onClick.AddListener(() => this._0x3384be6b());
        }

        _0x0593ece4 _0x3db5d42e = _0x6e6daaaf.Instance != null ? _0x6e6daaaf.Instance._0xa401efea(_0xb0135da5._0x9123adc7.PAUSE) : null;
        if (_0x3db5d42e != null)
        {
            Transform _0xda199e1d = this._0x6ca02aba(_0x3db5d42e, _0xe94e3611.Leaf);
            this._0x7644b7f6 = this._0xdf58c495(_0xda199e1d, _0x05de5f6d._0x9f44454c(new byte[13] { 109, 120, 114, 124, 25, 120, 25, 123, 107, 124, 120, 109, 113 }, 57), _0xe94e3611.Sun);
            this._0xaa68e630(_0xda199e1d, _0xdd1aee31);
            this._0x57707435 = this._0x367a214f(_0xda199e1d, _0x05de5f6d._0x9f44454c(new byte[20] { 86, 74, 71, 34, 69, 67, 80, 70, 71, 76, 34, 85, 75, 78, 78, 34, 85, 67, 75, 86 }, 2));
            this._0xaabfdc54 = this._0x36ff9b4d(_0xda199e1d, _0x05de5f6d._0x9f44454c(new byte[9] { 61, 41, 46, 50, 47, 91, 75, 84, 75 }, 123));
            Button _0x8e6295f9 = this._0xa2263157(_0xda199e1d, _0x05de5f6d._0x9f44454c(new byte[6] { 137, 158, 136, 142, 150, 158 }, 219));
            _0x8e6295f9.onClick.AddListener(() => this._0xbee98a81());
            Button _0x986ae637 = this._0x9bee054c(_0xda199e1d, _0x05de5f6d._0x9f44454c(new byte[4] { 58, 50, 57, 34 }, 119));
            _0x986ae637.onClick.AddListener(() => this._0x3384be6b());
            Button _0x07fda441 = this._0xe8fc7125(_0xda199e1d);
            _0x07fda441.onClick.AddListener(() => this._0xbee98a81());
        }
    }

    private void _0xb5a2f2fa()
    {
        if (_0x6e6daaaf.Instance != null)
            _0x6e6daaaf.Instance._0x29da2ed9();
        if (this._game != null)
            this._game._0xbd8be817();
        if (_0x24245b46.Instance != null)
        {
            _0x24245b46.Instance._0x11e6a30d(true);
            _0x24245b46.Instance._0x27fae1f7(_0xb0135da5._0x73d482f8.SCENE_1);
        }
    }

    public void _0x998707a0(string _0xa5ff3807, string _0x9c508192, bool _0x033b8ede)
    {
        _0x0593ece4 _0x3d29712c = _0x6e6daaaf.Instance != null ? _0x6e6daaaf.Instance._0xa401efea(_0xb0135da5._0x9123adc7.WIN) : null;
        if (_0x3d29712c == null)
            return;
        _0xf6b60f03.SetText(this._0x399ccd96, _0x05de5f6d._0x9f44454c(new byte[12] { 56, 59, 41, 49, 63, 46, 41, 90, 60, 47, 54, 54 }, 122));
        _0xf6b60f03.SetText(this._0x7375cce2, _0xa5ff3807);
        _0xf6b60f03.SetText(this._0xf21bfdcc, _0x9c508192);
        _0xf6b60f03.SetText(this._0x11cc0a89, _0x033b8ede ? _0x05de5f6d._0x9f44454c(new byte[10] { 227, 255, 242, 234, 147, 242, 244, 242, 250, 253 }, 179) : _0x05de5f6d._0x9f44454c(new byte[11] { 253, 246, 235, 231, 147, 244, 242, 225, 247, 246, 253 }, 179));
        _0x6e6daaaf.Instance._0x8717e92b(_0xb0135da5._0x9123adc7.WIN);
    }

    private const float CardWidth = 980f;
    private TextMeshProUGUI _0xaabfdc54;
    [SerializeField]
    private Sprite _roundPlate;
    private Button _0x9bee054c(Transform _0x2cf0375b, string _0x319ecb92)
    {
        return _0xd3e5c9ef.Action(_0x2cf0375b, _0x05de5f6d._0x9f44454c(new byte[15] { 157, 170, 188, 186, 163, 187, 156, 170, 172, 160, 161, 171, 174, 189, 182 }, 207), new Vector2(0f, -420f), new Vector2(480f, 120f), _0xe94e3611.Moss, _0xe94e3611.Forest, _0xe94e3611.Sun, this._font, _0x319ecb92, 38f, this._roundPlate);
    }

    /// The close cross is the ONLY button with no caption - it carries an icon this
    /// build generated, never the template's unassigned image (rule C.17).
    private Button _0xe8fc7125(Transform _0x2861d205)
    {
        return _0xd3e5c9ef.IconAction(_0x2861d205, _0x05de5f6d._0x9f44454c(new byte[11] { 150, 161, 183, 177, 168, 176, 135, 168, 171, 183, 161 }, 196), new Vector2(415f, 478f), new Vector2(96f, 96f), _0xe94e3611.Moss, _0xe94e3611.Forest, this._closeIcon, this._roundPlate);
    }

    private TextMeshProUGUI _0x11cc0a89;
    private TextMeshProUGUI _0x36ff9b4d(Transform _0x2dd0837b, string _0x63f400de)
    {
        return _0xd3e5c9ef.Caption(_0x2dd0837b, _0x05de5f6d._0x9f44454c(new byte[11] { 112, 71, 81, 87, 78, 86, 103, 90, 86, 80, 67 }, 34), new Vector2(0f, -115f), new Vector2(860f, 70f), this._font, _0x63f400de, 34f, _0xe94e3611.CreamSoft, TextAlignmentOptions.Center);
    }

    private TextMeshProUGUI _0x86d28410;
}

internal static class _0x05de5f6d
{
    internal static string _0x9f44454c(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}