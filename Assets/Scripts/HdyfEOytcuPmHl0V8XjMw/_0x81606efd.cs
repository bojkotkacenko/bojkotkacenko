using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The garden's own head-up display, built from objects this build created: a top
/// bar with back and pause, the day bar, the fruit counter with its leaf pips, and
/// the standing hint that names the gesture (rules C.2 and C.6).
public sealed class _0x81606efd : MonoBehaviour
{
    public void _0x19f25550(Transform _0x253c98a0, Camera _0x738a567d, TMP_FontAsset _0xef0a11a8, Sprite _0x6675d541, Sprite _0xab216a89, Sprite _0x003cff24, Sprite _0xcbd0f49a, Sprite _0x54febfcb)
    {
        this._body = _0x253c98a0 as RectTransform;
        this._view = _0x738a567d;
        this._font = _0xef0a11a8;
        this._0x1f7fa137 = _0x253c98a0.GetComponentInParent<Canvas>();
        // First child, so every button built after it wins the raycast.
        this._tapSurface = _0xd3e5c9ef.HitLayer(_0x253c98a0, _0xac16077d._0xbfd37c49(new byte[14] { 62, 19, 5, 28, 38, 19, 2, 33, 7, 0, 20, 19, 17, 23 }, 114));
        _0xd3e5c9ef.Plate(_0x253c98a0, _0xac16077d._0xbfd37c49(new byte[10] { 249, 196, 213, 229, 222, 193, 230, 208, 194, 217 }, 177), new Vector2(0f, TopRowY), new Vector2(1160f, 150f), _0xe94e3611.WithAlpha(_0xe94e3611.NightGarden, 0.55f), _0x6675d541);
        this._backButton = _0xd3e5c9ef.IconAction(_0x253c98a0, _0xac16077d._0xbfd37c49(new byte[7] { 138, 183, 166, 128, 163, 161, 169 }, 194), new Vector2(-480f, TopRowY), new Vector2(118f, 118f), _0xe94e3611.Moss, _0xe94e3611.Forest, _0x003cff24, _0x6675d541);
        this._pauseButton = _0xd3e5c9ef.IconAction(_0x253c98a0, _0xac16077d._0xbfd37c49(new byte[8] { 219, 230, 247, 195, 242, 230, 224, 246 }, 147), new Vector2(480f, TopRowY), new Vector2(118f, 118f), _0xe94e3611.Sun, _0xe94e3611.Forest, _0xcbd0f49a, _0x6675d541);
        Image _0x9193ef1e = _0xd3e5c9ef.Plate(_0x253c98a0, _0xac16077d._0xbfd37c49(new byte[8] { 64, 125, 108, 88, 125, 122, 123, 109 }, 8), new Vector2(0f, TopRowY), new Vector2(420f, 100f), _0xe94e3611.WithAlpha(_0xe94e3611.Forest, 0.95f), _0x6675d541);
        this._purseText = _0xd3e5c9ef.Caption(_0x9193ef1e.rectTransform, _0xac16077d._0xbfd37c49(new byte[12] { 134, 187, 170, 158, 187, 188, 189, 171, 154, 171, 182, 186 }, 206), Vector2.zero, new Vector2(384f, 76f), _0xef0a11a8, _0xac16077d._0xbfd37c49(new byte[7] { 244, 228, 135, 139, 141, 138, 151 }, 196), 36f, _0xe94e3611.Sun, TextAlignmentOptions.Center);
        this._goalText = _0xd3e5c9ef.Caption(_0x253c98a0, _0xac16077d._0xbfd37c49(new byte[7] { 172, 145, 128, 163, 139, 133, 136 }, 228), new Vector2(0f, GoalY), new Vector2(920f, 70f), _0xef0a11a8, _0xac16077d._0xbfd37c49(new byte[17] { 4, 11, 14, 14, 98, 7, 20, 7, 16, 27, 98, 0, 3, 17, 9, 7, 22 }, 66), 40f, _0xe94e3611.Cream, TextAlignmentOptions.Center);
        Image _0x014b7731;
        _0xd3e5c9ef.Bar(_0x253c98a0, _0xac16077d._0xbfd37c49(new byte[9] { 20, 41, 56, 24, 61, 37, 30, 61, 46 }, 92), new Vector2(0f, BarY), new Vector2(760f, 40f), _0xe94e3611.WithAlpha(_0xe94e3611.Forest, 0.9f), _0xe94e3611.Leaf, _0x6675d541, out _0x014b7731);
        this._barFill = _0x014b7731;
        this._clockText = _0xd3e5c9ef.Caption(_0x253c98a0, _0xac16077d._0xbfd37c49(new byte[8] { 12, 49, 32, 7, 40, 43, 39, 47 }, 68), new Vector2(520f, BarY), new Vector2(200f, 56f), _0xef0a11a8, _0xac16077d._0xbfd37c49(new byte[2] { 125, 30 }, 77), 32f, _0xe94e3611.CreamSoft, TextAlignmentOptions.Center);
        // The counter and the leaf column keep separate horizontal lanes (rule C.25):
        // the text ends at -30 and the first leaf starts at +51.
        this._countText = _0xd3e5c9ef.Caption(_0x253c98a0, _0xac16077d._0xbfd37c49(new byte[8] { 25, 36, 53, 18, 62, 36, 63, 37 }, 81), new Vector2(CountCentreX, CountY), new Vector2(420f, 64f), _0xef0a11a8, _0xac16077d._0xbfd37c49(new byte[9] { 177, 165, 162, 190, 163, 215, 199, 216, 206 }, 247), 38f, _0xe94e3611.Sun, TextAlignmentOptions.Left);
        this._leaves = new Image[LeafCount];
        for (int _0xec2e1ec0 = 0; _0xec2e1ec0 < LeafCount; _0xec2e1ec0++)
            this._leaves[_0xec2e1ec0] = _0xd3e5c9ef.Picture(_0x253c98a0, _0xac16077d._0xbfd37c49(new byte[7] { 56, 5, 20, 60, 21, 17, 22 }, 112), new Vector2(PipCentreX + (_0xec2e1ec0 - 2) * PipPitch, CountY), new Vector2(54f, 54f), _0x54febfcb, _0xe94e3611.Leaf);
        RectTransform _0xc15b447a = _0xd3e5c9ef.Node(_0x253c98a0, _0xac16077d._0xbfd37c49(new byte[7] { 92, 97, 112, 92, 125, 122, 96 }, 20), new Vector2(0f, HintY), new Vector2(1000f, 104f));
        Image _0xd1e8f906 = _0xc15b447a.gameObject.AddComponent<Image>();
        _0xd1e8f906.type = Image.Type.Sliced;
        _0xd1e8f906.sprite = _0xab216a89;
        _0xd1e8f906.pixelsPerUnitMultiplier = 1f;
        _0xd1e8f906.color = _0xe94e3611.LeafDeep;
        _0xd1e8f906.raycastTarget = false;
        _0xd3e5c9ef.Caption(_0xc15b447a, _0xac16077d._0xbfd37c49(new byte[11] { 81, 108, 125, 81, 112, 119, 109, 77, 124, 97, 109 }, 25), Vector2.zero, new Vector2(900f, 70f), _0xef0a11a8, _0xac16077d._0xbfd37c49(new byte[36] { 146, 135, 150, 230, 146, 142, 131, 230, 132, 135, 149, 141, 131, 146, 230, 146, 142, 135, 146, 230, 145, 135, 136, 146, 149, 230, 146, 142, 143, 149, 230, 128, 148, 147, 143, 146 }, 198), 36f, _0xe94e3611.Cream, TextAlignmentOptions.Center);
        this._tagCounts = new TextMeshProUGUI[_0x95f69594.BasketCount];
        for (int _0x3a97a8e7 = 0; _0x3a97a8e7 < _0x95f69594.BasketCount; _0x3a97a8e7++)
            this._tagCounts[_0x3a97a8e7] = _0xd3e5c9ef.Caption(_0x253c98a0, _0xac16077d._0xbfd37c49(new byte[11] { 200, 245, 228, 212, 225, 231, 195, 239, 245, 238, 244 }, 128), Vector2.zero, new Vector2(240f, 62f), _0xef0a11a8, _0xac16077d._0xbfd37c49(new byte[3] { 20, 11, 23 }, 36), 40f, _0xe94e3611.Cream, TextAlignmentOptions.Center);
    }

    public void _0x43a76b93(float _0xb33ee095, float _0xc3a3dbd0)
    {
        _0xd3e5c9ef.SetBarFill(this._barFill, _0xb33ee095);
        if (this._barFill != null)
            this._barFill.color = _0xb33ee095 < 0.25f ? _0xe94e3611.Coral : _0xe94e3611.Leaf;
        _0xf6b60f03.SetText(this._clockText, Mathf.CeilToInt(Mathf.Max(0f, _0xc3a3dbd0)) + _0xac16077d._0xbfd37c49(new byte[1] { 237 }, 190));
    }

    public void _0x66cbfe19(string _0xee15f6b4)
    {
        _0xf6b60f03.SetText(this._goalText, _0xee15f6b4);
    }

    public void _0xb7a87845(Vector3[] _0xd3164f25)
    {
        if (_0xd3164f25 == null || this._body == null)
            return;
        Camera _0x337f45be = this._0x1f7fa137 != null && this._0x1f7fa137.renderMode != RenderMode.ScreenSpaceOverlay ? this._0x1f7fa137.worldCamera : null;
        Camera _0x6530dd0e = this._view != null ? this._view : Camera.main;
        for (int _0xd8a649ef = 0; _0xd8a649ef < this._tagCounts.Length && _0xd8a649ef < _0xd3164f25.Length; _0xd8a649ef++)
        {
            if (this._tagCounts[_0xd8a649ef] == null || _0x6530dd0e == null)
                continue;
            Vector2 _0x723614cd = RectTransformUtility.WorldToScreenPoint(_0x6530dd0e, _0xd3164f25[_0xd8a649ef]);
            Vector2 _0x1ed0b7e0;
            if (RectTransformUtility.ScreenPointToLocalPointInRectangle(this._body, _0x723614cd, _0x337f45be, out _0x1ed0b7e0))
                this._tagCounts[_0xd8a649ef].rectTransform.anchoredPosition = _0x1ed0b7e0;
        }
    }

    [SerializeField]
    private TextMeshProUGUI _goalText;
    private const float CountCentreX = -240f;
    private const float GoalY = 985f;
    private const float HintY = -1150f;
    [SerializeField]
    private RectTransform _body;
    public void _0xfe8093c2(int _0xd47538f4)
    {
        if (this._leaves == null)
            return;
        for (int _0x50cefe98 = 0; _0x50cefe98 < this._leaves.Length; _0x50cefe98++)
            if (this._leaves[_0x50cefe98] != null)
                this._leaves[_0x50cefe98].color = _0x50cefe98 < _0xd47538f4 ? _0xe94e3611.Leaf : _0xe94e3611.WithAlpha(_0xe94e3611.Coral, 0.35f);
    }

    [SerializeField]
    private Button _pauseButton;
    [SerializeField]
    private TextMeshProUGUI[] _tagCounts = new TextMeshProUGUI[_0x95f69594.BasketCount];
    private const float BarY = 895f;
    public void _0xab2ad08e(int _0xb9b55e8d, int _0x28a1628c)
    {
        _0xf6b60f03.SetText(this._countText, _0xac16077d._0xbfd37c49(new byte[6] { 131, 151, 144, 140, 145, 229 }, 197) + _0xb9b55e8d + _0xac16077d._0xbfd37c49(new byte[1] { 96 }, 79) + _0x28a1628c);
    }

    [SerializeField]
    private Image[] _leaves = new Image[LeafCount];
    public void _0x55a0b741(int _0xe05a22e1, int _0x620bfe44, int _0x3060046b)
    {
        if (this._tagCounts == null || _0xe05a22e1 < 0 || _0xe05a22e1 >= this._tagCounts.Length)
            return;
        _0xf6b60f03.SetText(this._tagCounts[_0xe05a22e1], _0x620bfe44 + _0xac16077d._0xbfd37c49(new byte[1] { 114 }, 93) + _0x3060046b);
        if (this._tagCounts[_0xe05a22e1] != null)
            _0xf6b60f03.Apply(this._tagCounts[_0xe05a22e1], _0x620bfe44 >= _0x3060046b ? _0xe94e3611.Sun : _0xe94e3611.Cream, 40f);
    }

    private const float TopRowY = 1150f;
    [SerializeField]
    private TextMeshProUGUI _clockText;
    [SerializeField]
    private Image _tapSurface;
    private const float PipCentreX = 250f;
    private const float CountY = 805f;
    public void _0x022bbf6b(int _0x3d9aa9c1)
    {
        _0xf6b60f03.SetText(this._purseText, _0x3d9aa9c1 + _0xac16077d._0xbfd37c49(new byte[6] { 218, 185, 181, 179, 180, 169 }, 250));
    }

    public Image _0xe80fc8be
    {
        get
        {
            return this._tapSurface;
        }
    }

    private Canvas _0x1f7fa137;
    [SerializeField]
    private Button _backButton;
    public Button _0xe7547050
    {
        get
        {
            return this._backButton;
        }
    }

    public Button _0x42828e37
    {
        get
        {
            return this._pauseButton;
        }
    }

    [SerializeField]
    private TextMeshProUGUI _countText;
    [SerializeField]
    private Camera _view;
    private const float PipPitch = 86f;
    [SerializeField]
    private TextMeshProUGUI _purseText;
    [SerializeField]
    private Image _barFill;
    [SerializeField]
    private TMP_FontAsset _font;
    private const int LeafCount = 5;
}

internal static class _0xac16077d
{
    internal static string _0xbfd37c49(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}