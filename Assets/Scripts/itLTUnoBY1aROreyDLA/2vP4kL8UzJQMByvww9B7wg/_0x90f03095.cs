using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x90f03095 : MonoBehaviour
{
    private int _0x52d7d071 => this.ScoreCurrent;

    private static _0x90f03095 _0x36c5dd66;
    private int _0x68d725ff => this.CustomTimeInitial + _0x24245b46._0x8105d274._0x0dd2a96e * 10;

    public List<TMP_Text> SubtitleText = new();
    [HideInInspector]
    public int CurrentGameIndex;
    public List<Button> HomeButtons = new();
    public int CustomTimeInitial = 30;
    [HideInInspector]
    public int TimeLeft;
    private void _0x2002c86f()
    {
        if (this.ScoreCurrent >= this._0xcb5ede2e)
            this._0x879d7225();
        else
            this._0x82f15618();
    }

    [HideInInspector]
    public bool IsGameEnd;
    [HideInInspector]
    public int ScoreCurrent;
    private void _0xd93120c9()
    {
        this.IsGameEnd = true;
        _0x24245b46.IsAfterLevelComplete = true;
    }

    public List<TMP_Text> TimerText = new();
    public List<TMP_Text> LevelNumberText = new();
    private void Awake()
    {
        _0x36c5dd66 = this.gameObject.GetComponent<_0x90f03095>();
    }

    public int CustomTargetScore = 10;
    private void _0xb50fb101()
    {
        if (this.ScoreCurrent > _0x24245b46._0x8105d274._0xb15da8ca)
            _0x24245b46._0x8105d274._0xb15da8ca = this.ScoreCurrent;
        if (_0xf58e0432.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0xcb5ede2e)
                this._0x879d7225();
    }

    private void _0x87a243f9()
    {
        this.TimerText.ForEach(_0xb1aa650c => _0xb1aa650c.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0xd79e3a7b._0xaf2c3517(new byte[6] { 1, 1, 48, 86, 31, 31 }, 108)));
    }

    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0x68d725ff;
        this.CurrentGameIndex = _0x24245b46.Instance._0xde0b75d4;
        foreach (Button _0xe4f0dda3 in this.HomeButtons)
            _0xe4f0dda3.onClick.AddListener(() =>
            {
                this._0xcbb0a24f();
            });
        foreach (Button _0xd3edccaa in this.PauseButtons)
            _0xd3edccaa.onClick.AddListener(() =>
            {
                _0x24245b46.Instance._0x11e6a30d(false);
                _0x6e6daaaf.Instance._0x8717e92b(_0xb0135da5._0x9123adc7.PAUSE);
            });
        this._0x9f582c17();
        this.LevelNumberText.ForEach(_0xb1aa650c => _0xb1aa650c.text = $"LVL {_0x24245b46._0x8105d274._0x0dd2a96e + 1}");
        if (_0xf58e0432.Instance.IsTimerEnabled)
        {
            this._0x87a243f9();
            this.StartCoroutine(this._0x25696722());
        }
    }

    private int _0xcb5ede2e => this.CustomTargetScore + _0x24245b46._0x8105d274._0x0dd2a96e * 10;

    public void _0xcbb0a24f()
    {
        _0x24245b46.Instance._0x11e6a30d(true);
        _0x24245b46.Instance._0x27fae1f7(_0xb0135da5._0x73d482f8.SCENE_0);
    }

    private IEnumerator _0x25696722()
    {
        this._0x87a243f9();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0x24245b46.Instance._0xde0b75d4 == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0x24245b46.Instance._0x2748193d)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0x87a243f9();
            }
        }

        if (!this.IsGameEnd)
            this._0x82f15618();
    }

    public void _0x82f15618()
    {
        if (_0xf58e0432.Instance.IsOnlyWinGameEndEnabled)
            this._0x879d7225();
        if (!this.IsGameEnd)
        {
            this._0xd93120c9();
            _0x24245b46.IsAfterLevelComplete = false;
            _0x24245b46.IsAfterLevelFailed = true;
            _0x0593ece4 _0x2d776c68 = _0x6e6daaaf.Instance._0xa401efea(_0xb0135da5._0x9123adc7.LOSE).GetComponent<_0x0593ece4>();
            if (_0xf58e0432.Instance.IsCheckScoreEnabled)
                _0x2d776c68.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xcb5ede2e}";
            else
                _0x2d776c68.ContentMainText.text = $"{this.ScoreCurrent}";
            _0x2d776c68.ContentAdditionalText.text = $"{0}";
            _0xb0135da5._0x0c1629aa._0x2d6060af += 0;
            _0x6e6daaaf.Instance._0x8717e92b(_0xb0135da5._0x9123adc7.LOSE);
        }
    }

    private void _0x9f582c17()
    {
        if (_0xf58e0432.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0xb1aa650c => _0xb1aa650c.text = $"{this.ScoreCurrent}/{this._0xcb5ede2e}");
        else
            this.ScoreText.ForEach(_0xb1aa650c => _0xb1aa650c.text = $"{this.ScoreCurrent}");
    }

    public List<TMP_Text> ScoreText = new();
    public List<Button> PauseButtons = new();
    public void _0x879d7225()
    {
        if (!this.IsGameEnd)
        {
            this._0xd93120c9();
            _0x24245b46.IsAfterLevelComplete = true;
            _0x24245b46.IsAfterLevelFailed = false;
            _0x0593ece4 _0x22d20084 = _0x6e6daaaf.Instance._0xa401efea(_0xb0135da5._0x9123adc7.WIN).GetComponent<_0x0593ece4>();
            if (_0xf58e0432.Instance.IsCheckScoreEnabled)
                _0x22d20084.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xcb5ede2e}";
            else
                _0x22d20084.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0xf58e0432.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0xb0135da5._0x0c1629aa._0x2d6060af)
                    _0xb0135da5._0x0c1629aa._0x2d6060af = this.ScoreCurrent;
                _0x22d20084.ContentAdditionalText.text = $"{_0xb0135da5._0x0c1629aa._0x2d6060af}";
            }
            else
            {
                _0x22d20084.ContentAdditionalText.text = $"{this._0x52d7d071}";
                _0xb0135da5._0x0c1629aa._0x2d6060af += this._0x52d7d071;
            }

            if (_0xf58e0432.Instance.IsLevelIncrementOnWin)
                ++_0x24245b46._0x8105d274._0x0dd2a96e;
            _0x6e6daaaf.Instance._0x8717e92b(_0xb0135da5._0x9123adc7.WIN);
        }
    }

    public void _0xfffbf892(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0x9f582c17();
            this._0xb50fb101();
        }
    }
}

internal static class _0xd79e3a7b
{
    internal static string _0xaf2c3517(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}