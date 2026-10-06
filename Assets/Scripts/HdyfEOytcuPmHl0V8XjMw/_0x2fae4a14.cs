using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// One day in the garden: three baskets with written orders, a tray that hands over
/// one fruit at a time, and a clock long enough that an untouched run still fills the
/// whole capture window (rule C.5).
///
/// Every world size below is derived from the camera, never typed in (rule C.0), and
/// every sorting order comes from the named table in SpriteOrders (rule C.21).
public sealed class _0x2fae4a14 : MonoBehaviour
{
    private _0x02b14df7 _0x37f0e64b;
    private void Update()
    {
        if (this._0x28b80711 == _0x0dfd5774.Finished)
            return;
        bool _0x970877a0 = _0x24245b46.Instance == null || _0x24245b46.Instance._0x2748193d;
        if (!_0x970877a0)
            return;
        if (this._0xac160712 < 6)
        {
            this._0xac160712++;
            if (this._0x7c79924e != null)
                this._0x7c79924e._0xb7a87845(this._0xec4ba007);
        }

        this._0x062fdf27 += Time.deltaTime;
        if (this._0xea1bade0 != null && this._0x851eda68 != null)
        {
            float _0x3a3b11d7 = this._0x062fdf27 * 0.55f + this._0x851eda68.ButterflyPhase;
            this._0xea1bade0.transform.position = new Vector3(Mathf.Sin(_0x3a3b11d7) * this._0x35f89bd4 * this._0x851eda68.ButterflySpan, this._0x15be11be * DecorLevel + Mathf.Sin(_0x3a3b11d7 * 2.1f) * this._0x15be11be * 0.03f, 0f);
        }

        if (this._0x28b80711 == _0x0dfd5774.Intro)
            return;
        this._0x8d0fab5b -= Time.deltaTime;
        if (this._0x8d0fab5b <= 0f)
        {
            this._0x8d0fab5b = 0f;
            this._0x22c64001();
            this._0xfe896eb6(_0x57f4edc1._0xd7c152fe(new byte[17] { 216, 196, 201, 172, 223, 217, 194, 172, 219, 201, 194, 216, 172, 200, 195, 219, 194 }, 140));
            return;
        }

        if (this._0x7c79924e != null)
            this._0x7c79924e._0x43a76b93(this._0x8d0fab5b / this._0xfe08c088, this._0x8d0fab5b);
    }

    private Camera _0xbcb8916e;
    private const float BasketLevel = -0.590f;
    // -------- construction --------
    private void _0x1f49a00c()
    {
        Transform _0xc3c742de = this._0x40df2e86(_0xb0135da5._0xe76dff38.DEFAULT);
        if (_0xc3c742de == null)
            return;
        // The template's own HUD belongs to another game; it is switched off whole
        // rather than reused (rule C.2). Any branch holding a result card is left
        // alone - those are raised by the controller, not by this panel.
        for (int _0xb082125c = _0xc3c742de.childCount - 1; _0xb082125c >= 0; _0xb082125c--)
        {
            Transform _0xdd43d572 = _0xc3c742de.GetChild(_0xb082125c);
            if (_0xdd43d572 == null || _0xdd43d572.GetComponentInChildren<_0x0593ece4>(true) != null)
                continue;
            _0xdd43d572.gameObject.SetActive(false);
        }

        this._0x7c79924e = this.gameObject.AddComponent<_0x81606efd>();
        this._0x7c79924e._0x19f25550(_0xc3c742de, this._0xbcb8916e, this._font, this._roundPlate, this._ribbonArt, this._backIcon, this._pauseIcon, this._pipArt);
        Image _0x7f495d38 = this._0x7c79924e._0xe80fc8be;
        if (_0x7f495d38 != null)
        {
            _0x99a5cf1c _0x5060ac0b = _0x7f495d38.gameObject.AddComponent<_0x99a5cf1c>();
            _0x5060ac0b._0xf48bc332(this, this._0xbcb8916e);
        }

        Button _0x7fa01618 = this._0x7c79924e._0xe7547050;
        if (_0x7fa01618 != null)
            _0x7fa01618.onClick.AddListener(() => this._0x979b8d2c());
        Button _0x41455771 = this._0x7c79924e._0x42828e37;
        if (_0x41455771 != null)
            _0x41455771.onClick.AddListener(() => this._0xdf07c8e1());
    }

    [SerializeField]
    private Sprite _emblemArt;
    private void _0x56f3f6f4(int _0x2e02a05c)
    {
        _0xdc8bbf7d _0x88f45af4 = this._0x5ca158a1[_0x2e02a05c];
        if (_0x88f45af4 == null)
            return;
        _0x88f45af4._0xfd474923();
        this._0x498bdc8a(_0x88f45af4._0xca377c48);
        this._0x6c7734d4++;
        this._0x9d4dcf0d++;
        this._0x8d0fab5b = Mathf.Min(this._0xfe08c088, this._0x8d0fab5b + RewardSeconds);
        if (_0x88f45af4._0x39316c5b && this._0x17ada086[_0x2e02a05c] != null)
            this._0x17ada086[_0x2e02a05c]._0xd2e55066(_0xe94e3611.Mix(Color.white, _0xe94e3611.Sun, 0.65f));
        this._0x22c64001();
        this._0xd9adc4c5();
    }

    [SerializeField]
    private Sprite[] _fruitArt = new Sprite[5];
    private Transform _0x586a8c5d;
    private const float RewardSeconds = 4f;
    private const float TrayLevel = 0.110f;
    private readonly Vector3[] _0xec4ba007 = new Vector3[_0x95f69594.BasketCount];
    private readonly _0xf15601ad[] _0x17ada086 = new _0xf15601ad[_0x95f69594.BasketCount];
    private const float PauseReleaseSeconds = 9f;
    [SerializeField]
    private Sprite _pauseIcon;
    private int _0x45ffc22b;
    [SerializeField]
    private _0xf15601ad _tagPrefab;
    private int _0xe8aa9659;
    private float _0x15be11be = 5f;
    private void _0x549f8d17()
    {
        GameObject _0x6a6b6fcc = new GameObject(_0x57f4edc1._0xd7c152fe(new byte[4] { 255, 210, 196, 221 }, 179));
        _0x6a6b6fcc.transform.SetParent(this.transform, false);
        this._0x586a8c5d = _0x6a6b6fcc.transform;
        float _0x826851ab = this._0x3cf8106a * 0.86f;
        float _0x75fe38c7 = this._0x3cf8106a * 0.81f;
        float _0x2d40ebe2 = this._0x3cf8106a * 0.39f;
        float _0x7c319fcf = this._0x3cf8106a * 1.30f;
        float _0xf26eb86e = this._0x3cf8106a * 0.95f;
        float _0x381c9dd7 = this._0x3cf8106a * 0.38f;
        float _0x89214597 = this._0x3cf8106a * 0.30f;
        float _0xfeb283b1 = this._0x3cf8106a * 0.26f;
        if (this._decorPrefab != null)
        {
            SpriteRenderer _0x398ac964 = Instantiate(this._decorPrefab, this._0x586a8c5d);
            _0x398ac964.sprite = this._trayArt;
            _0x398ac964.drawMode = SpriteDrawMode.Sliced;
            _0x398ac964.size = new Vector2(_0x7c319fcf, _0x7c319fcf);
            _0x398ac964.sortingOrder = _0x065c3466.TrayOrder;
            _0x398ac964.transform.position = new Vector3(0f, this._0x15be11be * TrayLevel, 0f);
            _0x398ac964.transform.localScale = Vector3.one;
            for (int _0x217d3a33 = 0; _0x217d3a33 < this._0x851eda68.PropPosition.Length; _0x217d3a33++)
            {
                SpriteRenderer _0x863a7454 = Instantiate(this._decorPrefab, this._0x586a8c5d);
                _0x863a7454.sprite = this._pipArt;
                _0x863a7454.drawMode = SpriteDrawMode.Sliced;
                _0x863a7454.size = new Vector2(_0x89214597, _0x89214597);
                _0x863a7454.sortingOrder = _0x065c3466.BackdropOrder;
                _0x863a7454.color = _0xe94e3611.WithAlpha(_0xe94e3611.Leaf, 0.75f);
                _0x863a7454.transform.position = new Vector3(this._0x851eda68.PropPosition[_0x217d3a33].x * this._0x35f89bd4, this._0x15be11be * DecorLevel + this._0x851eda68.PropPosition[_0x217d3a33].y * this._0x15be11be * 0.035f, 0f);
                _0x863a7454.transform.localScale = Vector3.one;
                _0x863a7454.transform.localRotation = Quaternion.Euler(0f, 0f, this._0x851eda68.PropTurn[_0x217d3a33]);
            }

            this._0xea1bade0 = Instantiate(this._decorPrefab, this._0x586a8c5d);
            this._0xea1bade0.sprite = this._butterflyArt;
            this._0xea1bade0.drawMode = SpriteDrawMode.Sliced;
            this._0xea1bade0.size = new Vector2(_0xfeb283b1, _0xfeb283b1);
            this._0xea1bade0.sortingOrder = _0x065c3466.DecorOrder;
            this._0xea1bade0.transform.localScale = Vector3.one;
        }

        for (int _0x38777efa = 0; _0x38777efa < _0x95f69594.BasketCount; _0x38777efa++)
        {
            float _0x79390e58 = (_0x38777efa - 1) * this._0x3cf8106a;
            if (this._basketPrefab != null)
            {
                _0xdc8bbf7d _0xc88c74ed = Instantiate(this._basketPrefab, this._0x586a8c5d);
                _0xc88c74ed.transform.position = new Vector3(_0x79390e58, this._0x15be11be * BasketLevel, 0f);
                Sprite _0x414b9a48 = this._basketArt != null && this._0x851eda68.BasketArt[_0x38777efa] < this._basketArt.Length ? this._basketArt[this._0x851eda68.BasketArt[_0x38777efa]] : null;
                _0xc88c74ed._0xac066080(_0x414b9a48, _0x826851ab, _0x065c3466.BasketOrder, this._0x851eda68.BasketFruit[_0x38777efa], this._0x851eda68.BasketTarget[_0x38777efa]);
                _0xc88c74ed._0x7a11f103();
                this._0x5ca158a1[_0x38777efa] = _0xc88c74ed;
            }

            if (this._tagPrefab != null)
            {
                _0xf15601ad _0xdd1eb96f = Instantiate(this._tagPrefab, this._0x586a8c5d);
                _0xdd1eb96f.transform.position = new Vector3(_0x79390e58, this._0x15be11be * TagLevel, 0f);
                Sprite _0xb71403e5 = this._0x4025dae6(this._0x851eda68.BasketFruit[_0x38777efa]);
                _0xdd1eb96f._0xcef8e884(this._tagArt, _0xb71403e5, _0x75fe38c7, _0x2d40ebe2, _0x065c3466.TagOrder, _0x065c3466.TagIconOrder, this._0x15be11be * (TagIconLevel - TagLevel));
                _0xdd1eb96f._0x164dcff8(this._0x15be11be * 0.12f, 0.45f, 0.08f * _0x38777efa);
                this._0x17ada086[_0x38777efa] = _0xdd1eb96f;
            }

            this._0xec4ba007[_0x38777efa] = new Vector3(_0x79390e58, this._0x15be11be * TagCountLevel, 0f);
        }

        Vector3[] _0xa4795268 = new Vector3[3];
        for (int _0x52cf2ea6 = 0; _0x52cf2ea6 < _0xa4795268.Length; _0x52cf2ea6++)
            _0xa4795268[_0x52cf2ea6] = new Vector3((_0x52cf2ea6 - 1) * this._0x3cf8106a * 0.58f, this._0x15be11be * QueueLevel, 0f);
        this._0xa117df5a = this.gameObject.AddComponent<_0x67b6c9da>();
        this._0xa117df5a._0x91d11cad(this._fruitPrefab, this._queuePrefab, this._0x586a8c5d, this._fruitArt, this._goldenArt, _0xf26eb86e, _0x381c9dd7, new Vector3(0f, this._0x15be11be * FruitLevel, 0f), _0xa4795268, _0xe94e3611.Mix(_0xe94e3611.White, _0xe94e3611.Lilac, 0.35f));
        if (this._0x7c79924e != null)
            this._0x7c79924e._0xb7a87845(this._0xec4ba007);
    }

    [SerializeField]
    private Sprite _backIcon;
    [SerializeField]
    private Sprite _closeIcon;
    private const float TagCountLevel = -0.328f;
    private SpriteRenderer _0xea1bade0;
    private float _0x3cf8106a = 1f;
    private int _0x9ce6250b()
    {
        int _0x1d9989be = Mathf.Max(0, LeafBudget - this._0xe8aa9659);
        return this._0x6c7734d4 * 10 + Mathf.CeilToInt(Mathf.Max(0f, this._0x8d0fab5b)) * 2 + _0x1d9989be * 25;
    }

    [SerializeField]
    private _0x53858555 _progress;
    // -------- helpers --------
    private void _0x22c64001()
    {
        if (this._0x7c79924e == null)
            return;
        this._0x7c79924e._0x66cbfe19(this._0xd5e6ce73 != null ? _0x57f4edc1._0xd7c152fe(new byte[21] { 105, 102, 99, 99, 15, 106, 121, 106, 125, 118, 15, 109, 110, 124, 100, 106, 123, 15, 102, 97, 15 }, 47) + this._0xd5e6ce73._0x351be776 : _0x57f4edc1._0xd7c152fe(new byte[17] { 149, 154, 159, 159, 243, 150, 133, 150, 129, 138, 243, 145, 146, 128, 152, 150, 135 }, 211));
        this._0x7c79924e._0xab2ad08e(this._0x6c7734d4, this._0x567e15a0());
        this._0x7c79924e._0xfe8093c2(Mathf.Max(0, LeafBudget - this._0xe8aa9659));
        this._0x7c79924e._0x43a76b93(this._0x8d0fab5b / this._0xfe08c088, this._0x8d0fab5b);
        this._0x7c79924e._0x022bbf6b(_0xb0135da5._0x0c1629aa._0x2d6060af);
        for (int _0xc3fadc0f = 0; _0xc3fadc0f < _0x95f69594.BasketCount; _0xc3fadc0f++)
            if (this._0x5ca158a1[_0xc3fadc0f] != null)
                this._0x7c79924e._0x55a0b741(_0xc3fadc0f, this._0x5ca158a1[_0xc3fadc0f]._0x8c9f5197, this._0x5ca158a1[_0xc3fadc0f]._0x4f64c644);
    }

    private void _0x498bdc8a(Vector3 _0x9ff9edf6)
    {
        if (this._sparkPrefab == null)
            return;
        SpriteRenderer _0x80e77d07 = Instantiate(this._sparkPrefab, this._0x586a8c5d);
        _0x80e77d07.sprite = this._pipArt;
        _0x80e77d07.drawMode = SpriteDrawMode.Sliced;
        float _0x1e506ccb = this._0x3cf8106a * 0.30f;
        _0x80e77d07.size = new Vector2(_0x1e506ccb, _0x1e506ccb);
        _0x80e77d07.sortingOrder = _0x065c3466.SparkOrder;
        _0x80e77d07.color = _0xe94e3611.Sun;
        _0x80e77d07.transform.position = _0x9ff9edf6;
        _0x80e77d07.transform.localScale = Vector3.one;
        GameObject _0x7855e50d = _0x80e77d07.gameObject;
        // The burst grows from the size the camera gave it, never from a literal.
        float _0x6b943cde = _0x1e506ccb * 1.9f;
        DOTween.To(() => _0x80e77d07.size.x, _0xf7c9b9d0 => _0x80e77d07.size = new Vector2(_0xf7c9b9d0, _0xf7c9b9d0), _0x6b943cde, 0.4f).SetEase(Ease.OutQuad).SetTarget(_0x80e77d07);
        DOTween.To(() => _0x80e77d07.color, _0xcbfbcadf => _0x80e77d07.color = _0xcbfbcadf, _0xe94e3611.WithAlpha(_0xe94e3611.Sun, 0f), 0.4f).SetTarget(_0x80e77d07).OnComplete(() => Destroy(_0x7855e50d));
    }

    [SerializeField]
    private _0xdc8bbf7d _basketPrefab;
    private readonly _0xdc8bbf7d[] _0x5ca158a1 = new _0xdc8bbf7d[_0x95f69594.BasketCount];
    private void _0xf55b517e()
    {
        this._0x7aa96de3 = this.gameObject.AddComponent<_0x6b38573e>();
        this._0x7aa96de3._0x3290b3a0(this, this._font, this._roundPlate, this._closeIcon, this._goldenArt, this._pipArt, this._emblemArt);
    }

    private const float QueueLevel = 0.470f;
    private void _0x1061295a(int _0x84b419e0)
    {
        _0xdc8bbf7d _0x645e6011 = this._0x5ca158a1[_0x84b419e0];
        if (_0x645e6011 != null)
            _0x645e6011._0x0919ea04();
        this._0xe8aa9659++;
        this._0x28b80711 = _0x0dfd5774.Rejecting;
        _0x02b14df7 _0xc2605c65 = this._0x37f0e64b;
        Vector3 _0x14c898c2 = this._0xa117df5a != null ? this._0xa117df5a._0x53d2323a : _0xc2605c65.transform.position;
        _0xc2605c65._0x8d700a3e(_0x14c898c2 + new Vector3(0f, this._0x3cf8106a * 0.18f, 0f), ReturnSeconds, () => this._0x2f3fdb48());
        this._0x22c64001();
        if (this._0xe8aa9659 >= LeafBudget)
            this._0xfe896eb6(_0x57f4edc1._0xd7c152fe(new byte[23] { 159, 144, 143, 156, 249, 159, 139, 140, 144, 141, 138, 249, 142, 156, 151, 141, 249, 152, 138, 141, 139, 152, 128 }, 217));
    }

    [SerializeField]
    private TMPro.TMP_FontAsset _font;
    private int _0xac160712;
    private const float DecorLevel = -0.115f;
    private void _0x2f3fdb48()
    {
        if (this._0x28b80711 == _0x0dfd5774.Finished)
            return;
        if (this._0x37f0e64b != null && this._0xa117df5a != null)
        {
            this._0x37f0e64b._0x4e0e6413(this._0xa117df5a._0x53d2323a);
            this._0x37f0e64b._0x27f37bda();
        }

        this._0x28b80711 = _0x0dfd5774.Serving;
    }

    [SerializeField]
    private Sprite _roundPlate;
    private const float FlightSeconds = 0.42f;
    private Sprite _0x4025dae6(int _0xab9c6e79)
    {
        if (_0xab9c6e79 == _0x95f69594.JokerFruit)
            return this._goldenArt;
        if (this._fruitArt == null || this._fruitArt.Length == 0)
            return null;
        return this._fruitArt[Mathf.Clamp(_0xab9c6e79, 0, this._fruitArt.Length - 1)];
    }

    private const int LeafBudget = 5;
    // -------- endings --------
    private void _0xcdcf342e()
    {
        if (this._0x28b80711 == _0x0dfd5774.Finished)
            return;
        this._0x28b80711 = _0x0dfd5774.Finished;
        int _0x98a6f6df = this._0x9ce6250b();
        int _0x81095dea = this._gardens != null ? this._gardens.Length : 1;
        if (this._progress != null)
        {
            this._progress._0xe242de08(this._0x45ffc22b, _0x98a6f6df);
            this._progress._0xa42a833b(this._0x45ffc22b);
        }

        _0xb0135da5._0x0c1629aa._0x2d6060af = _0xb0135da5._0x0c1629aa._0x2d6060af + _0x98a6f6df;
        this._0x22c64001();
        bool _0x7fcebf7d = this._0x45ffc22b >= _0x81095dea - 1;
        string _0x6c1fa94f = _0x57f4edc1._0xd7c152fe(new byte[6] { 175, 187, 188, 160, 189, 201 }, 233) + this._0x6c7734d4 + _0x57f4edc1._0xd7c152fe(new byte[1] { 59 }, 20) + this._0x567e15a0() + _0x57f4edc1._0xd7c152fe(new byte[13] { 79, 79, 79, 59, 38, 34, 42, 79, 35, 42, 41, 59, 79 }, 111) + Mathf.CeilToInt(this._0x8d0fab5b) + _0x57f4edc1._0xd7c152fe(new byte[11] { 13, 126, 126, 126, 29, 17, 23, 16, 13, 126, 117 }, 94) + _0x98a6f6df;
        if (this._0x7aa96de3 != null)
            this._0x7aa96de3._0x998707a0(_0x57f4edc1._0xd7c152fe(new byte[19] { 150, 133, 150, 129, 138, 243, 156, 129, 151, 150, 129, 243, 154, 128, 243, 151, 156, 157, 150 }, 211), _0x6c1fa94f, _0x7fcebf7d);
    }

    private void _0x979b8d2c()
    {
        if (_0x24245b46.Instance == null)
            return;
        _0x24245b46.Instance._0x11e6a30d(true);
        _0x24245b46.Instance._0x27fae1f7(_0xb0135da5._0x73d482f8.SCENE_0);
    }

    private _0x6b38573e _0x7aa96de3;
    private float _0x8d0fab5b;
    private const float IntroSeconds = 0.8f;
    [SerializeField]
    private Sprite _tagArt;
    [SerializeField]
    private Sprite[] _basketArt = new Sprite[3];
    private float _0xfe08c088 = 1f;
    private _0x95f69594 _0x851eda68;
    [SerializeField]
    private Sprite _butterflyArt;
    private Transform _0x40df2e86(int _0xccad53e0)
    {
        if (_0x3e36db7a.Instance == null || _0x3e36db7a.Instance.Panels == null)
            return null;
        if (_0xccad53e0 < 0 || _0xccad53e0 >= _0x3e36db7a.Instance.Panels.Count)
            return null;
        _0xbb55021e _0xe51ac0c8 = _0x3e36db7a.Instance.Panels[_0xccad53e0];
        if (_0xe51ac0c8 == null || _0xe51ac0c8.Content == null)
            return null;
        return _0xe51ac0c8.Content.transform;
    }

    private const float TagLevel = -0.270f;
    private const float TagIconLevel = -0.220f;
    [SerializeField]
    private SpriteRenderer _decorPrefab;
    public void _0xa2d82089()
    {
        if (_0x24245b46.Instance != null)
            _0x24245b46.Instance._0x11e6a30d(true);
    }

    [SerializeField]
    private Sprite _pipArt;
    private void _0xfe896eb6(string _0x6de9afb8)
    {
        if (this._0x28b80711 == _0x0dfd5774.Finished)
            return;
        this._0x28b80711 = _0x0dfd5774.Finished;
        int _0xac1e1fb4 = this._0x9ce6250b();
        if (this._progress != null)
            this._progress._0xe242de08(this._0x45ffc22b, _0xac1e1fb4);
        int _0xa5acd8d8 = this._progress != null ? this._progress._0x64bacb1c(this._0x45ffc22b) : _0xac1e1fb4;
        string _0x7b31fee3 = _0x57f4edc1._0xd7c152fe(new byte[7] { 67, 76, 73, 73, 64, 65, 37 }, 5) + this._0x6c7734d4 + _0x57f4edc1._0xd7c152fe(new byte[1] { 252 }, 211) + this._0x567e15a0() + _0x57f4edc1._0xd7c152fe(new byte[8] { 2, 2, 2, 96, 103, 113, 118, 2 }, 34) + _0xa5acd8d8;
        if (this._0x7aa96de3 != null)
            this._0x7aa96de3._0x7fa11dd1(_0x6de9afb8, _0x7b31fee3);
    }

    [SerializeField]
    private Sprite _ribbonArt;
    private void Start()
    {
        this._0xbcb8916e = Camera.main;
        if (this._0xbcb8916e != null)
        {
            this._0x15be11be = this._0xbcb8916e.orthographicSize;
            this._0x35f89bd4 = this._0x15be11be * this._0xbcb8916e.aspect;
        }

        this._0x3cf8106a = 2f * this._0x35f89bd4 * BoardFraction / _0x95f69594.BasketCount;
        int _0x8cebffe3 = this._gardens != null ? this._gardens.Length : 0;
        this._0x45ffc22b = this._progress != null ? Mathf.Clamp(this._progress._0xeeedc340, 0, Mathf.Max(0, _0x8cebffe3 - 1)) : 0;
        this._0xd5e6ce73 = _0x8cebffe3 > 0 ? this._gardens[this._0x45ffc22b] : new _0xbff45879();
        int _0xdb289e9a = this._progress != null ? this._progress._0xd89ed500() : 1;
        _0x4c822025 _0x4b2b60d8 = new _0x4c822025();
        this._0x851eda68 = _0x4b2b60d8._0x4d470176(this._0xd5e6ce73, this._0x45ffc22b, _0xdb289e9a);
        this._0xfe08c088 = Mathf.Max(30f, this._0x851eda68.DaySeconds);
        this._0x8d0fab5b = this._0xfe08c088;
        this._0x1f49a00c();
        this._0x549f8d17();
        this._0xf55b517e();
        this._0x22c64001();
        this._0x28b80711 = _0x0dfd5774.Intro;
        DOVirtual.DelayedCall(IntroSeconds, () => this._0xb3bae38b(), false);
    }

    private int _0x567e15a0()
    {
        int _0x22d1353c = 0;
        for (int _0x0d8c05b0 = 0; _0x0d8c05b0 < _0x95f69594.BasketCount; _0x0d8c05b0++)
            if (this._0x5ca158a1[_0x0d8c05b0] != null)
                _0x22d1353c += this._0x5ca158a1[_0x0d8c05b0]._0x4f64c644;
        return _0x22d1353c;
    }

    private _0x67b6c9da _0xa117df5a;
    private const float FruitLevel = 0.260f;
    [SerializeField]
    private _0xbff45879[] _gardens = new _0xbff45879[0];
    private bool _0x73776e60()
    {
        for (int _0x919406b7 = 0; _0x919406b7 < _0x95f69594.BasketCount; _0x919406b7++)
            if (this._0x5ca158a1[_0x919406b7] == null || !this._0x5ca158a1[_0x919406b7]._0x39316c5b)
                return false;
        return true;
    }

    [SerializeField]
    private SpriteRenderer _sparkPrefab;
    private bool _0x662555e2(int _0x846bd226)
    {
        for (int _0x13ef04fd = 0; _0x13ef04fd < _0x95f69594.BasketCount; _0x13ef04fd++)
            if (this._0x5ca158a1[_0x13ef04fd] != null && this._0x5ca158a1[_0x13ef04fd]._0x11ba2178(_0x846bd226))
                return true;
        return false;
    }

    [SerializeField]
    private _0x02b14df7 _fruitPrefab;
    private float _0x35f89bd4 = 2.3f;
    // -------- round --------
    private void _0xb3bae38b()
    {
        if (this._0x28b80711 == _0x0dfd5774.Finished)
            return;
        this._0x28b80711 = _0x0dfd5774.Serving;
        this._0xd9adc4c5();
    }

    private void _0x7084fc5a(int _0xb5c71633)
    {
        _0xdc8bbf7d _0xccde1c81 = this._0x5ca158a1[_0xb5c71633];
        _0x02b14df7 _0x7745da72 = this._0x37f0e64b;
        this._0x28b80711 = _0x0dfd5774.Flying;
        _0x7745da72._0x8d700a3e(_0xccde1c81._0xca377c48, FlightSeconds, () => this._0x56f3f6f4(_0xb5c71633));
    }

    private int _0x9d4dcf0d;
    public void _0xbd8be817()
    {
        if (this._progress == null)
            return;
        int _0x9db95437 = this._gardens != null ? this._gardens.Length : 1;
        this._progress._0x72738754(Mathf.Min(this._0x45ffc22b + 1, Mathf.Max(0, _0x9db95437 - 1)));
    }

    private void _0xd9adc4c5()
    {
        if (this._0x28b80711 == _0x0dfd5774.Finished)
            return;
        if (this._0x37f0e64b != null)
        {
            Destroy(this._0x37f0e64b.gameObject);
            this._0x37f0e64b = null;
        }

        if (this._0x73776e60())
        {
            this._0xcdcf342e();
            return;
        }

        if (this._0x851eda68 == null || this._0x9d4dcf0d >= this._0x851eda68.Queue.Count)
        {
            this._0xfe896eb6(_0x57f4edc1._0xd7c152fe(new byte[17] { 0, 28, 17, 116, 0, 6, 21, 13, 116, 29, 7, 116, 17, 25, 4, 0, 13 }, 84));
            return;
        }

        int _0x22226067 = this._0x851eda68.Queue[this._0x9d4dcf0d];
        if (!this._0x662555e2(_0x22226067))
        {
            // Surplus arrival: set it aside and move on, so a spare fruit can never
            // park the day.
            this._0x9d4dcf0d++;
            DOVirtual.DelayedCall(0.25f, () => this._0xd9adc4c5(), false);
            return;
        }

        this._0x37f0e64b = this._0xa117df5a._0xeeb767f3(_0x22226067);
        this._0xa117df5a._0x440f7d99(this._0x851eda68.Queue, this._0x9d4dcf0d + 1);
        this._0x28b80711 = _0x0dfd5774.Serving;
        this._0x22c64001();
    }

    [SerializeField]
    private Sprite _goldenArt;
    private const float ReturnSeconds = 0.30f;
    [SerializeField]
    private _0x02b14df7 _queuePrefab;
    private _0x0dfd5774 _0x28b80711 = _0x0dfd5774.Intro;
    private float _0x062fdf27;
    public void _0xdf07c8e1()
    {
        if (this._0x28b80711 == _0x0dfd5774.Finished)
            return;
        if (_0x24245b46.Instance != null)
            _0x24245b46.Instance._0x11e6a30d(false);
        if (this._0x7aa96de3 == null)
            return;
        this._0x7aa96de3._0x333312ab(_0x57f4edc1._0xd7c152fe(new byte[6] { 32, 52, 51, 47, 50, 70 }, 102) + this._0x6c7734d4 + _0x57f4edc1._0xd7c152fe(new byte[1] { 55 }, 24) + this._0x567e15a0() + _0x57f4edc1._0xd7c152fe(new byte[10] { 122, 122, 122, 22, 31, 27, 12, 31, 9, 122 }, 90) + Mathf.Max(0, LeafBudget - this._0xe8aa9659) + _0x57f4edc1._0xd7c152fe(new byte[1] { 222 }, 241) + LeafBudget);
        this._0x7aa96de3._0xaeb8793e(PauseReleaseSeconds);
    }

    private const float BoardFraction = 0.92f;
    [SerializeField]
    private Sprite _trayArt;
    public void _0x64f57b93(Vector2 _0x747c155c)
    {
        if (this._0x28b80711 != _0x0dfd5774.Serving || this._0x37f0e64b == null || this._0x851eda68 == null)
            return;
        if (_0x24245b46.Instance != null && !_0x24245b46.Instance._0x2748193d)
            return;
        int _0x4bb3c634 = -1;
        for (int _0x2a3c9d15 = 0; _0x2a3c9d15 < _0x95f69594.BasketCount; _0x2a3c9d15++)
            if (this._0x5ca158a1[_0x2a3c9d15] != null && this._0x5ca158a1[_0x2a3c9d15]._0x70d6a616(new Vector3(_0x747c155c.x, _0x747c155c.y, 0f)))
                _0x4bb3c634 = _0x2a3c9d15;
        if (_0x4bb3c634 < 0)
            return;
        int _0x7ed2ecee = this._0x851eda68.Queue[this._0x9d4dcf0d];
        _0xdc8bbf7d _0x91127ad6 = this._0x5ca158a1[_0x4bb3c634];
        if (_0x91127ad6._0x11ba2178(_0x7ed2ecee))
            this._0x7084fc5a(_0x4bb3c634);
        else
            this._0x1061295a(_0x4bb3c634);
    }

    private _0xbff45879 _0xd5e6ce73;
    private _0x81606efd _0x7c79924e;
    private enum _0x0dfd5774
    {
        Intro,
        Serving,
        Flying,
        Rejecting,
        Finished,
    }

    private int _0x6c7734d4;
}

internal static class _0x57f4edc1
{
    internal static string _0xd7c152fe(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}