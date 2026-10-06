using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0xb0135da5;

public class _0x24245b46 : MonoBehaviour
{
    private static void MakeGrid(List<RectTransform> _0x103f144a, AspectRatioFitter _0x191d05af, float _0x524bc60e, int _0xabbda657, int _0x8a06fbeb)
    {
        _0x191d05af.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0x191d05af.aspectRatio = _0x524bc60e;
        foreach (RectTransform _0x883de9a4 in _0x103f144a)
        {
            int _0xd99a1514 = _0x883de9a4.transform.GetSiblingIndex();
            _0x883de9a4.anchorMin = new Vector3(Mathf.FloorToInt((float)_0xd99a1514 % _0xabbda657) * (1f / _0xabbda657), (_0x8a06fbeb - (Mathf.FloorToInt((float)_0xd99a1514 / _0xabbda657) % _0x8a06fbeb + 1f)) * (1f / _0x8a06fbeb));
            _0x883de9a4.anchorMax = new Vector3(Mathf.FloorToInt((float)_0xd99a1514 % _0xabbda657 + 1f) * (1f / _0xabbda657), (_0x8a06fbeb - Mathf.FloorToInt((float)_0xd99a1514 / _0xabbda657) % _0x8a06fbeb) * (1f / _0x8a06fbeb));
            _0x883de9a4.offsetMin = Vector2.zero;
            _0x883de9a4.offsetMax = Vector2.zero;
        }
    }

    public void _0x11e6a30d(bool _0x65841d76)
    {
        this._0x2748193d = _0x65841d76;
        this._0x48ab0d69(!this._0x2748193d);
        Physics2D.simulationMode = this._0x2748193d ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0xc5a061cf(this.EnvironmentWithTweensToToggle);
    }

    private static _0xf58daef7 _0xb72a2668 => _0xf58daef7.ALL_SCENES_SETTING_SINGLETONS[0];

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x24245b46>();
        this.RootGameObject = GameObject.FindWithTag(_0x20fa3210._0xbe1c7aaf(new byte[4] { 10, 55, 55, 44 }, 88));
        if (this._0xde0b75d4 == _0x73d482f8.SCENE_0)
            this._0x11e6a30d(true);
        else
            this._0x11e6a30d(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0x517f7391>(true).ToList();
    }

    public void _0x27fae1f7(int _0xfa2bfca0)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0xf9d0ab3e(_0xfa2bfca0));
    }

    public Button DeleteProgressDataButton;
    private void _0x48ab0d69(bool _0xd8fd4098)
    {
        Rigidbody2D[] _0x1a4b1d74 = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0x8ac12cc1 in _0x1a4b1d74)
            if (_0xd8fd4098)
                _0x8ac12cc1.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0x8ac12cc1.constraints = RigidbodyConstraints2D.None;
    }

    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    public Canvas MainCanvas;
    private void _0xc5a061cf(Transform _0x158ad7d8)
    {
        Transform[] _0xaf739269 = _0x158ad7d8.GetComponentsInChildren<Transform>();
        foreach (Transform _0xed89cad2 in _0xaf739269)
            if (_0xed89cad2 != null && DOTween.IsTweening(_0xed89cad2))
            {
                if (this._0x2748193d)
                    DOTween.Play(_0xed89cad2);
                else
                    DOTween.Pause(_0xed89cad2);
            }
    }

    public void _0x724e6152()
    {
        _0x8105d274._0xcd60561f = true;
    }

    public Button ShowResetTutorialButton;
    private static void ExitGame()
    {
        Application.Quit();
    }

    public Transform Environment;
    public void _0x528bd5d1()
    {
        foreach (_0x517f7391 _0xfff52b74 in this.MoneyCountContainers)
            _0xfff52b74._0x330623d1();
    }

    public static bool IsAfterLevelComplete;
    public static _0x24245b46 Instance;
    private static _0xf58daef7 GAME_INDEX_SETTINGS(int _0xb0c0cf1b)
    {
        return _0xf58daef7.ALL_SCENES_SETTING_SINGLETONS[_0xb0c0cf1b];
    }

    public int _0xde0b75d4 => SceneManager.GetActiveScene().buildIndex;
    public bool _0x2748193d { get; private set; }
    public static _0xf58daef7 _0x8105d274 => _0xf58daef7.ALL_SCENES_SETTING_SINGLETONS[Instance._0xde0b75d4];

    [HideInInspector]
    public List<_0x517f7391> MoneyCountContainers = new();
    public void _0x10f06c15()
    {
        this._0x27fae1f7(SceneManager.GetActiveScene().buildIndex);
    }

    private void Start()
    {
        if (this._0xde0b75d4 != _0x73d482f8.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance._0x27fae1f7(_0x73d482f8.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0x8105d274._0xcd60561f = false;
            _0x6e6daaaf.Instance._0x29da2ed9();
            _0x3e36db7a.Instance._0xa72c9de0(_0xe76dff38.TUTORIAL0);
        });
    }

    public Transform EnvironmentWithTweensToToggle;
    private IEnumerator _0xf9d0ab3e(int _0xfedf4b75)
    {
        _0x3e36db7a.Instance._0xa72c9de0(_0xe76dff38.SPLASH);
        AsyncOperation _0x8d313f1d = SceneManager.LoadSceneAsync(_0xfedf4b75);
        while (!_0x8d313f1d.isDone)
            yield return null;
    }

    public static bool IsAfterLevelFailed = false;
    private IEnumerator _0x677ea3bd(string _0x28248611)
    {
        _0x3e36db7a.Instance._0xa72c9de0(_0xe76dff38.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0x5dc24abd = SceneManager.LoadSceneAsync(_0x28248611);
        while (!_0x5dc24abd.isDone)
            yield return null;
    }

    private void _0x8547c915()
    {
        IsAfterLevelComplete = true;
        Instance._0x27fae1f7(_0x73d482f8.SCENE_0);
    }
}

internal static class _0x20fa3210
{
    internal static string _0xbe1c7aaf(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}