using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using Unity.Services.CloudSave.Models.Data.Player;
using Unity.Services.Core;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class _0xa7bd5c21 : MonoBehaviour
{
    private string _0x3b8013a8 = "";
    // WS_SOURCE MONO
    public static _0xa7bd5c21 _0x2a4f527d { get; private set; }

    private void _0x31245199()
    {
        if (_0xe7732caa != null)
            return;
        var _0x920f67a5 = _0x8d1065f7();
        _0xe7732caa = new GameObject(_0x188fffc2._0x2e478e05(new byte[14] { 133, 183, 176, 132, 187, 183, 165, 129, 162, 187, 188, 188, 183, 160 }, 210), typeof(RectTransform), typeof(Text));
        _0x40f2a1f1 = _0xe7732caa.GetComponent<RectTransform>();
        _0x40f2a1f1.SetParent(_0x920f67a5.transform, false);
        _0x40f2a1f1.anchorMin = new Vector2(0.5f, 0.5f);
        _0x40f2a1f1.anchorMax = new Vector2(0.5f, 0.5f);
        _0x40f2a1f1.pivot = new Vector2(0.5f, 0.5f);
        _0x40f2a1f1.sizeDelta = new Vector2(600f, 600f);
        _0x40f2a1f1.anchoredPosition = Vector2.zero;
        _0xa3e66bed = _0xe7732caa.GetComponent<Text>();
        _0xa3e66bed.text = _0x188fffc2._0x2e478e05(new byte[1] { 58 }, 21);
        _0xa3e66bed.font = Resources.GetBuiltinResource<Font>(_0x188fffc2._0x2e478e05(new byte[17] { 91, 114, 112, 118, 116, 110, 69, 98, 121, 99, 126, 122, 114, 57, 99, 99, 113 }, 23));
        _0xa3e66bed.fontSize = 200;
        _0xa3e66bed.alignment = TextAnchor.MiddleCenter;
        _0xa3e66bed.color = Color.white;
        _0xa3e66bed.raycastTarget = false;
        _0xe7732caa.SetActive(false);
    }

    private string _0x64438033 = "";
    private string _0x5b52d048 = "";
    private bool _0x7a52cb8c(string _0x3b638224)
    {
        try
        {
            using (var _0x5937aad2 = new AndroidJavaClass(_0x188fffc2._0x2e478e05(new byte[30] { 166, 170, 168, 235, 176, 171, 172, 177, 188, 246, 161, 235, 181, 169, 164, 188, 160, 183, 235, 144, 171, 172, 177, 188, 149, 169, 164, 188, 160, 183 }, 197)))
            using (var _0x70662716 = _0x5937aad2.GetStatic<AndroidJavaObject>(_0x188fffc2._0x2e478e05(new byte[15] { 204, 218, 221, 221, 202, 193, 219, 238, 204, 219, 198, 217, 198, 219, 214 }, 175)))
            using (var _0xd9962e9d = new AndroidJavaClass(_0x188fffc2._0x2e478e05(new byte[15] { 118, 121, 115, 101, 120, 126, 115, 57, 121, 114, 99, 57, 66, 101, 126 }, 23)))
            using (var _0x1b3483cc = _0xd9962e9d.CallStatic<AndroidJavaObject>(_0x188fffc2._0x2e478e05(new byte[5] { 2, 19, 0, 1, 23 }, 114), _0x3b638224))
            using (var _0xffa77106 = new AndroidJavaObject(_0x188fffc2._0x2e478e05(new byte[22] { 52, 59, 49, 39, 58, 60, 49, 123, 54, 58, 59, 33, 48, 59, 33, 123, 28, 59, 33, 48, 59, 33 }, 85), _0x188fffc2._0x2e478e05(new byte[26] { 255, 240, 250, 236, 241, 247, 250, 176, 247, 240, 234, 251, 240, 234, 176, 255, 253, 234, 247, 241, 240, 176, 200, 215, 219, 201 }, 158), _0x1b3483cc))
            {
                WLog(_0x188fffc2._0x2e478e05(new byte[26] { 53, 30, 4, 25, 27, 19, 58, 31, 29, 19, 86, 25, 6, 19, 24, 86, 19, 14, 2, 19, 4, 24, 23, 26, 76, 86 }, 118) + _0x3b638224);
                _0xffa77106.Call<AndroidJavaObject>(_0x188fffc2._0x2e478e05(new byte[11] { 239, 234, 234, 205, 239, 250, 235, 233, 225, 252, 247 }, 142), _0x188fffc2._0x2e478e05(new byte[33] { 86, 89, 83, 69, 88, 94, 83, 25, 94, 89, 67, 82, 89, 67, 25, 84, 86, 67, 82, 80, 88, 69, 78, 25, 117, 101, 120, 96, 100, 118, 117, 123, 114 }, 55));
                _0xffa77106.Call<AndroidJavaObject>(_0x188fffc2._0x2e478e05(new byte[8] { 62, 59, 59, 25, 51, 62, 56, 44 }, 95), 0x10000000);
                _0x70662716.Call(_0x188fffc2._0x2e478e05(new byte[13] { 67, 68, 81, 66, 68, 113, 83, 68, 89, 70, 89, 68, 73 }, 48), _0xffa77106);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x188fffc2._0x2e478e05(new byte[28] { 196, 239, 245, 232, 234, 226, 203, 238, 236, 226, 167, 226, 255, 243, 226, 245, 233, 230, 235, 167, 225, 230, 238, 235, 226, 227, 189, 167 }, 135) + e.Message);
            Application.OpenURL(_0x3b638224);
            return true;
        }
    }

    // NATIVE WEB VIEW METHODS
    private UniWebView _0x081b16a4 = null;
    /* ============================= */
    /* ENCRYPT / DECRYPT             */
    /* ============================= */
    private string _0xfae27e1a(string _0xd763ab44, string _0xe41502e4)
    {
        try
        {
            using var _0x6c759b61 = Aes.Create();
            _0x6c759b61.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xe41502e4));
            _0x6c759b61.GenerateIV();
            using var _0x87e9dd43 = new MemoryStream();
            _0x87e9dd43.Write(_0x6c759b61.IV, 0, _0x6c759b61.IV.Length);
            using (var _0x1f5b7d69 = new CryptoStream(_0x87e9dd43, _0x6c759b61.CreateEncryptor(), CryptoStreamMode.Write))
            {
                var _0x04726187 = Encoding.UTF8.GetBytes(_0xd763ab44);
                _0x1f5b7d69.Write(_0x04726187, 0, _0x04726187.Length);
                _0x1f5b7d69.FlushFinalBlock();
            }

            return Convert.ToBase64String(_0x87e9dd43.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private IEnumerator _0x9d09033e(string _0xe41c6396)
    {
        if (_0x081b16a4 != null && _0xa0ee427f)
            yield break;
        _0x081b16a4 = gameObject.AddComponent<UniWebView>();
        _0x20e0ef53(_0x081b16a4);
        _0xb54e3850(_0x081b16a4);
        _0x081b16a4.BackgroundColor = Color.clear;
        var _0x2ead1e9d = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0x08331083();
        yield return new WaitForEndOfFrame();
        _0xa0ee427f = true;
        _0x31245199();
        _0xa89d505b(true);
        _0xa2177f1a = false;
        _0x6130e3fc = false;
        _0x05e7450b.Clear();
        _0x78a4a454 = -1;
        firstLoadShown = false;
        _0xae4a271b = false;
        _0x3911399f = false;
        _0x081b16a4.SetUserAgent("");
        _0xf632d590 = Time.realtimeSinceStartup;
        _0x081b16a4.Stop();
        _0x081b16a4.Load(_0xe41c6396);
        _0x081b16a4.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0x188fffc2._0x2e478e05(new byte[25] { 207, 227, 235, 236, 162, 213, 231, 224, 212, 235, 231, 245, 162, 203, 236, 235, 246, 235, 227, 238, 162, 209, 234, 237, 245 }, 130));
    }

    private void _0xe685c821()
    {
        WLog(_0x188fffc2._0x2e478e05(new byte[21] { 250, 211, 192, 214, 197, 211, 192, 215, 146, 208, 211, 209, 217, 146, 194, 192, 215, 193, 193, 215, 214 }, 178));
        if (Time.frameCount == _0x78a4a454)
            return;
        _0x78a4a454 = Time.frameCount;
        if (_0xad172e3f())
            return;
        _0x95f271fa();
    }

    private bool _0x82095241 = false;
    private async Task _0x863507aa()
    {
        if (await _0x38dacad7())
            return;
        if (await _0x478e3b6c())
            return;
        if (await _0x342a08bd())
            return;
        _0x22aed07d();
        await _0xd92ec725(_0x8554aedb());
        _0xcd86e11f = await _0x868ed00a();
        await _0x6c91e909();
    }

    private bool _0x5fafb1fe = false;
    private IEnumerator _0x8c87a950(Dictionary<string, object> _0x7fb8dd74)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x188fffc2._0x2e478e05(new byte[30] { 151, 152, 169, 191, 184, 145, 236, 138, 169, 184, 175, 164, 236, 137, 180, 184, 190, 173, 236, 156, 185, 191, 164, 236, 136, 173, 184, 173, 246, 236 }, 204) + string.Join(_0x188fffc2._0x2e478e05(new byte[1] { 189 }, 180), _0x7fb8dd74));
#endif
            }
        }

        string _0x55969b5e = "";
        // Primary source: nested JSON under "notificationData"
        if (_0x7fb8dd74 != null && _0x7fb8dd74.TryGetValue(_0x188fffc2._0x2e478e05(new byte[16] { 40, 41, 50, 47, 32, 47, 37, 39, 50, 47, 41, 40, 2, 39, 50, 39 }, 70), out var raw))
        {
            try
            {
                var _0x79388a71 = raw?.ToString();
                var _0x8e2c82d1 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x79388a71);
                if (_0x8e2c82d1 != null && _0x8e2c82d1.TryGetValue(_0x188fffc2._0x2e478e05(new byte[6] { 180, 162, 169, 163, 174, 163 }, 199), out var val))
                {
                    _0x55969b5e = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0x188fffc2._0x2e478e05(new byte[30] { 119, 120, 73, 95, 88, 12, 124, 89, 95, 68, 113, 12, 102, 127, 99, 98, 12, 92, 77, 94, 95, 73, 12, 73, 94, 94, 67, 94, 22, 12 }, 44) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0x55969b5e) && _0x7fb8dd74 != null && _0x7fb8dd74.TryGetValue(_0x188fffc2._0x2e478e05(new byte[6] { 32, 54, 61, 55, 58, 55 }, 83), out var lab))
        {
            _0x55969b5e = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x188fffc2._0x2e478e05(new byte[38] { 212, 219, 234, 252, 251, 175, 223, 250, 252, 231, 210, 175, 201, 234, 251, 236, 231, 234, 235, 175, 252, 234, 225, 235, 230, 235, 175, 233, 253, 224, 226, 175, 229, 252, 224, 225, 181, 175 }, 143) + _0x55969b5e);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0x55969b5e))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0x188fffc2._0x2e478e05(new byte[38] { 166, 169, 152, 142, 137, 221, 173, 136, 142, 149, 160, 221, 170, 156, 148, 137, 221, 137, 146, 221, 146, 141, 152, 147, 221, 138, 148, 137, 149, 221, 142, 152, 147, 153, 148, 153, 199, 221 }, 253) + _0x55969b5e);
            }
#endif
        }

        _0xf20e476b = _0x55969b5e;
        yield return new WaitUntil(() => _0xa0ee427f);
        var _0x51cad80b = _0xea3ccbf3(2, 100);
        yield return new WaitUntil(() => _0x51cad80b.IsCompleted);
        string _0x2f350806 = _0x51cad80b.Result;
        if (!string.IsNullOrEmpty(_0x2f350806))
        {
            string _0x059a0726 = _0x6a248a4d(_0x2f350806, _0x55969b5e);
            {
#if B_LOGS
                Debug.Log(_0x188fffc2._0x2e478e05(new byte[33] { 80, 95, 110, 120, 127, 43, 91, 126, 120, 99, 86, 43, 89, 110, 103, 100, 106, 111, 43, 92, 110, 105, 93, 98, 110, 124, 43, 124, 98, 127, 99, 49, 43 }, 11) + _0x059a0726);
#endif
            }

            _0x081b16a4.Load(_0x059a0726);
        }
    }

    private async Task<bool> _0xcadc264b(int _0x08ae37ea = 5, int _0xb8dff1cd = 500)
    {
        List<EntityData> _0x0da94dc8 = new List<EntityData>();
        int _0xeb4e4ca8 = 0;
        do
        {
            try
            {
                _0x0da94dc8 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x188fffc2._0x2e478e05(new byte[8] { 44, 48, 61, 37, 57, 46, 21, 56 }, 92), _0x4794c791, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x188fffc2._0x2e478e05(new byte[9] { 175, 181, 150, 180, 175, 176, 167, 165, 191 }, 198) }), new QueryOptions())).ToList();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0x188fffc2._0x2e478e05(new byte[32] { 175, 160, 145, 135, 128, 169, 212, 133, 129, 145, 134, 141, 181, 135, 141, 154, 151, 166, 145, 135, 129, 152, 128, 135, 212, 145, 134, 134, 155, 134, 206, 212 }, 244) + e.Message);
                    }
#endif
                }
            }

            await Task.Delay(_0xb8dff1cd);
        }
        while (_0x0da94dc8.Count == 0 && _0xeb4e4ca8++ < _0x08ae37ea);
        {
#if B_LOGS
            {
                Debug.Log(_0x188fffc2._0x2e478e05(new byte[32] { 191, 176, 129, 151, 144, 185, 196, 173, 151, 180, 150, 141, 146, 133, 135, 157, 196, 181, 145, 129, 150, 157, 196, 150, 129, 151, 145, 136, 144, 151, 222, 196 }, 228) + JsonConvert.SerializeObject(_0x0da94dc8, Formatting.Indented));
            }
#endif
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x188fffc2._0x2e478e05(new byte[38] { 237, 226, 211, 197, 194, 235, 150, 255, 197, 230, 196, 223, 192, 215, 213, 207, 150, 231, 195, 211, 196, 207, 150, 196, 211, 197, 195, 218, 194, 197, 150, 213, 217, 195, 216, 194, 140, 150 }, 182) + _0x0da94dc8.Count);
            }
#endif
        }

        bool _0xe0723b86 = true;
        if (_0x0da94dc8.Count == 0)
        {
            _0xe0723b86 = false;
        }
        else
        {
            _0xe0723b86 = _0x0da94dc8.Any(_0x5ff4eabe => _0x5ff4eabe.Data.Any(IsPrivacyItemTrue));
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x188fffc2._0x2e478e05(new byte[25] { 128, 143, 190, 168, 175, 134, 251, 146, 168, 139, 169, 178, 173, 186, 184, 162, 251, 169, 190, 168, 174, 183, 175, 225, 251 }, 219) + _0xe0723b86);
            }
#endif
        }

        return _0xe0723b86;
    }

    private async Task<string> _0xea3ccbf3(int _0xc9b484b5 = 5, int _0x3b487af4 = 500)
    {
        try
        {
            List<EntityData> _0x53e11300 = new List<EntityData>();
            int _0xc8ee3f31 = 0;
            do
            {
                _0x53e11300 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x188fffc2._0x2e478e05(new byte[8] { 36, 56, 53, 45, 49, 38, 29, 48 }, 84), _0x4794c791, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x4794c791 }), new QueryOptions())).ToList();
                await Task.Delay(_0x3b487af4);
            }
            while (_0x53e11300.Count == 0 && _0xc8ee3f31++ < _0xc9b484b5);
            {
#if B_LOGS
                {
                    Debug.Log(_0x188fffc2._0x2e478e05(new byte[33] { 203, 196, 245, 227, 228, 205, 176, 195, 241, 230, 245, 244, 176, 220, 249, 254, 251, 176, 193, 229, 245, 226, 233, 176, 226, 245, 227, 229, 252, 228, 227, 170, 176 }, 144) + JsonConvert.SerializeObject(_0x53e11300, Formatting.Indented));
                }
#endif
            }

            {
#if B_LOGS
                {
                    Debug.Log(_0x188fffc2._0x2e478e05(new byte[39] { 249, 246, 199, 209, 214, 255, 130, 241, 195, 212, 199, 198, 130, 238, 203, 204, 201, 130, 243, 215, 199, 208, 219, 130, 208, 199, 209, 215, 206, 214, 209, 130, 193, 205, 215, 204, 214, 152, 130 }, 162) + _0x53e11300.Count);
                }
#endif
            }

            var _0xc0adfcf1 = _0x53e11300.SelectMany(_0x5ff4eabe => _0x5ff4eabe.Data).FirstOrDefault(_0x591277c2 => _0x591277c2.Key == _0x4794c791)?.Value.GetAs<string>() ?? string.Empty;
            _0xc0adfcf1 = Decrypt(_0xc0adfcf1, _0x4794c791);
            {
#if B_LOGS
                {
                    Debug.Log(_0x188fffc2._0x2e478e05(new byte[24] { 222, 209, 224, 246, 241, 216, 165, 201, 234, 228, 225, 165, 246, 228, 243, 224, 225, 165, 233, 236, 235, 238, 191, 165 }, 133) + _0xc0adfcf1);
                }
#endif
            }

            return _0xc0adfcf1;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x188fffc2._0x2e478e05(new byte[39] { 215, 216, 233, 255, 248, 209, 172, 203, 233, 248, 172, 227, 254, 172, 252, 237, 254, 255, 233, 172, 255, 237, 250, 233, 232, 172, 224, 229, 226, 231, 172, 234, 237, 229, 224, 233, 232, 182, 172 }, 140) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    private void OnApplicationPause(bool _0xe182b1fb)
    {
        isApplicationPause = _0xe182b1fb;
    }

    private void _0xbaa4fdca()
    {
        if (_0x081b16a4 == null)
            return;
        if (_0x6130e3fc)
            _0x081b16a4.SetUserAgent(_0x6263dc29());
        else
            _0x081b16a4.SetUserAgent("");
    }

    internal bool IsHttpUrl(string _0xd1f9b18c)
    {
        if (string.IsNullOrEmpty(_0xd1f9b18c))
            return false;
        return _0xd1f9b18c.StartsWith(_0x188fffc2._0x2e478e05(new byte[7] { 171, 183, 183, 179, 249, 236, 236 }, 195), StringComparison.OrdinalIgnoreCase) || _0xd1f9b18c.StartsWith(_0x188fffc2._0x2e478e05(new byte[8] { 167, 187, 187, 191, 188, 245, 224, 224 }, 207), StringComparison.OrdinalIgnoreCase);
    }

    private async Task _0x6c91e909()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0x5b52d048 = _0x188fffc2._0x2e478e05(new byte[5] { 57, 62, 51, 44, 58 }, 95);
        _0x39db8694 = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0x5cad8aca = DateTime.UtcNow.Ticks.ToString();
        _0xe00bec3b = "";
        JObject _0x80c9335d = _0xcecf0aa2(_0x3281062c, _0x7b72452b, _0xbc167f9c, _0x9e746dd8, _0x4a85fb46, _0x3a0b4b5e, _0xd9537a0f, _0xbc1a1598, _0xcd86e11f, _0x62099a43, _0x5b52d048, _0xe00bec3b, _0x54867765, _0x3b8013a8, _0x3ade8bd9.ToString(), _0xd50948a2, _0x5cad8aca, _0x39db8694, _0x4794c791, _0x187ad849, _0x56ab59b0, _0x64438033, _0x32d5a423());
        var _0x0dae1ba9 = _0xfae27e1a(_0x80c9335d.ToString(), _0x4794c791);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0x80c9335d}");
            }
#endif
        }

        try
        {
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x188fffc2._0x2e478e05(new byte[7] { 2, 19, 11, 30, 29, 19, 22 }, 114) + _0x4794c791, _0x0dae1ba9 } });
            await Task.Delay(500);
            string _0xd8d406c2 = "";
            for (int _0x9560b028 = 0; _0x9560b028 < 20; _0x9560b028++)
            {
                if (await _0xcadc264b(1, 1))
                {
                    await _0xa8c1c6bf(_0x188fffc2._0x2e478e05(new byte[7] { 242, 252, 255, 243, 251, 245, 244 }, 144));
                    _0xb7a86899();
                    return;
                }

                _0xd8d406c2 = await _0xea3ccbf3(1, 500);
                if (!string.IsNullOrEmpty(_0xd8d406c2))
                    break;
            }

            _0x5bc39272(_0xd8d406c2);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x188fffc2._0x2e478e05(new byte[22] { 225, 238, 255, 233, 238, 231, 154, 253, 223, 212, 223, 200, 219, 214, 154, 223, 200, 200, 213, 200, 128, 154 }, 186) + e.Message);
#endif
            }

            _0xb7a86899();
        }
    }

    private string _0x4a85fb46 = "";
    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0x868ed00a()
    {
        var _0x0b424df8 = _0x188fffc2._0x2e478e05(new byte[40] { 140, 144, 144, 148, 151, 222, 203, 203, 147, 147, 147, 202, 135, 136, 139, 145, 128, 130, 136, 133, 150, 129, 202, 135, 139, 137, 203, 135, 128, 138, 201, 135, 131, 141, 203, 144, 150, 133, 135, 129 }, 228);
        using (UnityWebRequest _0xba073e7e = UnityWebRequest.Get(_0x0b424df8))
        {
            await _0xba073e7e.SendWebRequest();
            string[] _0xce27074f = _0xba073e7e.downloadHandler.text.Split('\n');
            foreach (string _0x613278dd in _0xce27074f)
            {
                if (_0x613278dd.StartsWith(_0x188fffc2._0x2e478e05(new byte[3] { 165, 188, 241 }, 204)))
                {
                    string _0xd8d0169f = _0x613278dd.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0xd8d0169f} from {_0x0b424df8}");
                        }
#endif
                    }

                    return _0xd8d0169f;
                }
            }
        }

        return "";
    }

    private void _0x5e55dc35(string _0x39f926c2)
    {
        _0xc3da5d1b();
        StartCoroutine(_0x9d09033e(_0x39f926c2));
    }

    private static readonly string WindowsDesktopUserAgent = _0x188fffc2._0x2e478e05(new byte[111] { 188, 158, 139, 152, 157, 157, 144, 222, 196, 223, 193, 209, 217, 166, 152, 159, 149, 158, 134, 130, 209, 191, 165, 209, 192, 193, 223, 193, 202, 209, 166, 152, 159, 199, 197, 202, 209, 137, 199, 197, 216, 209, 176, 129, 129, 157, 148, 166, 148, 147, 186, 152, 133, 222, 196, 194, 198, 223, 194, 199, 209, 217, 186, 185, 165, 188, 189, 221, 209, 157, 152, 154, 148, 209, 182, 148, 146, 154, 158, 216, 209, 178, 153, 131, 158, 156, 148, 222, 192, 195, 193, 223, 193, 223, 193, 223, 193, 209, 162, 144, 151, 144, 131, 152, 222, 196, 194, 198, 223, 194, 199 }, 241);
    private void _0x95f271fa()
    {
        if (_0x3911399f)
        {
            WLog(_0x188fffc2._0x2e478e05(new byte[18] { 105, 84, 69, 88, 12, 77, 64, 94, 73, 77, 72, 85, 12, 95, 68, 67, 91, 66 }, 44));
            return;
        }

        _0xa89d505b(false);
        WLog(_0x188fffc2._0x2e478e05(new byte[46] { 18, 62, 54, 49, 127, 8, 58, 61, 9, 54, 58, 40, 127, 15, 42, 44, 55, 127, 17, 48, 43, 54, 57, 54, 60, 62, 43, 54, 48, 49, 127, 119, 55, 62, 45, 59, 40, 62, 45, 58, 127, 61, 62, 60, 52, 118 }, 95));
        ++_0x72a4236b;
        _0x8132d6c2();
        if (_0x72a4236b <= 1)
            return;
        if (_0x322dd355())
        {
            WLog(_0x188fffc2._0x2e478e05(new byte[37] { 242, 207, 222, 195, 151, 196, 220, 222, 199, 199, 210, 211, 151, 154, 137, 151, 199, 216, 199, 194, 199, 196, 151, 196, 195, 222, 219, 219, 151, 216, 199, 210, 217, 210, 211, 141, 151 }, 183) + _0x05e7450b.Count);
            return;
        }

        Application.Quit();
    }

    // PART 3
    private string _0x23aa545c()
    {
        try
        {
            var _0x11b19499 = new AndroidJavaClass(_0x188fffc2._0x2e478e05(new byte[30] { 71, 75, 73, 10, 81, 74, 77, 80, 93, 23, 64, 10, 84, 72, 69, 93, 65, 86, 10, 113, 74, 77, 80, 93, 116, 72, 69, 93, 65, 86 }, 36));
            var _0x32f20cba = _0x11b19499.GetStatic<AndroidJavaObject>(_0x188fffc2._0x2e478e05(new byte[15] { 65, 87, 80, 80, 71, 76, 86, 99, 65, 86, 75, 84, 75, 86, 91 }, 34));
            var _0x766e3eb7 = new AndroidJavaClass(_0x188fffc2._0x2e478e05(new byte[57] { 120, 116, 118, 53, 124, 116, 116, 124, 119, 126, 53, 122, 117, 127, 105, 116, 114, 127, 53, 124, 118, 104, 53, 122, 127, 104, 53, 114, 127, 126, 117, 111, 114, 125, 114, 126, 105, 53, 90, 127, 109, 126, 105, 111, 114, 104, 114, 117, 124, 82, 127, 88, 119, 114, 126, 117, 111 }, 27));
            var _0x9f258ff8 = _0x766e3eb7.CallStatic<AndroidJavaObject>(_0x188fffc2._0x2e478e05(new byte[20] { 238, 236, 253, 200, 237, 255, 236, 251, 253, 224, 250, 224, 231, 238, 192, 237, 192, 231, 239, 230 }, 137), _0x32f20cba);
            var _0x40e87865 = _0x9f258ff8.Call<string>(_0x188fffc2._0x2e478e05(new byte[5] { 78, 76, 93, 96, 77 }, 41));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0x40e87865}");
#endif
            }

            return string.IsNullOrEmpty(_0x40e87865) ? "" : _0x40e87865;
        }
        catch
        {
            return "";
        }
    }

    private bool _0x3cf9ef0f(string _0x71a9edea)
    {
        if (string.IsNullOrEmpty(_0x71a9edea))
            return false;
        try
        {
            using (var _0xca11413d = new AndroidJavaClass(_0x188fffc2._0x2e478e05(new byte[30] { 132, 136, 138, 201, 146, 137, 142, 147, 158, 212, 131, 201, 151, 139, 134, 158, 130, 149, 201, 178, 137, 142, 147, 158, 183, 139, 134, 158, 130, 149 }, 231)))
            using (var _0xe3076e5b = _0xca11413d.GetStatic<AndroidJavaObject>(_0x188fffc2._0x2e478e05(new byte[15] { 197, 211, 212, 212, 195, 200, 210, 231, 197, 210, 207, 208, 207, 210, 223 }, 166)))
            using (var _0x0fec54eb = _0xe3076e5b.Call<AndroidJavaObject>(_0x188fffc2._0x2e478e05(new byte[17] { 166, 164, 181, 145, 160, 162, 170, 160, 166, 164, 140, 160, 175, 160, 166, 164, 179 }, 193)))
            using (var _0x589660f1 = _0x0fec54eb.Call<AndroidJavaObject>(_0x188fffc2._0x2e478e05(new byte[25] { 224, 226, 243, 203, 230, 242, 233, 228, 239, 206, 233, 243, 226, 233, 243, 193, 232, 245, 215, 230, 228, 236, 230, 224, 226 }, 135), _0x71a9edea))
            {
                if (_0x589660f1 == null)
                    return false;
                WLog(_0x188fffc2._0x2e478e05(new byte[37] { 132, 175, 181, 168, 170, 162, 139, 174, 172, 162, 231, 171, 166, 178, 169, 164, 175, 231, 174, 169, 180, 179, 166, 171, 171, 162, 163, 231, 183, 166, 164, 172, 166, 160, 162, 253, 231 }, 199) + _0x71a9edea);
                _0x589660f1.Call<AndroidJavaObject>(_0x188fffc2._0x2e478e05(new byte[8] { 197, 192, 192, 226, 200, 197, 195, 215 }, 164), 0x10000000);
                _0xe3076e5b.Call(_0x188fffc2._0x2e478e05(new byte[13] { 202, 205, 216, 203, 205, 248, 218, 205, 208, 207, 208, 205, 192 }, 185), _0x589660f1);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private async Task<bool> _0x38dacad7()
    {
        {
#if B_LOGS
            Debug.Log(_0x188fffc2._0x2e478e05(new byte[37] { 241, 254, 207, 217, 222, 247, 138, 249, 195, 205, 196, 227, 196, 255, 196, 195, 222, 211, 249, 207, 216, 220, 195, 201, 207, 217, 235, 196, 197, 196, 211, 199, 197, 223, 217, 198, 211 }, 170));
#endif
        }

        try
        {
            var _0x20dff102 = new InitializationOptions();
            await UnityServices.InitializeAsync(_0x20dff102);
            {
#if B_LOGS
                Debug.Log(_0x188fffc2._0x2e478e05(new byte[32] { 4, 11, 58, 44, 43, 2, 127, 10, 49, 54, 43, 38, 12, 58, 45, 41, 54, 60, 58, 44, 127, 22, 49, 54, 43, 54, 62, 51, 54, 37, 58, 59 }, 95));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0x188fffc2._0x2e478e05(new byte[20] { 236, 253, 235, 236, 152, 237, 214, 209, 204, 193, 235, 221, 202, 206, 209, 219, 221, 203, 130, 152 }, 184) + ex.Message);
#endif
            }

            _0x2a4f527d?._0xb7a86899();
            return true;
        }

        bool _0x20e2f489 = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0x20e2f489 = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0x188fffc2._0x2e478e05(new byte[37] { 228, 235, 218, 204, 203, 226, 159, 236, 214, 216, 209, 146, 214, 209, 159, 254, 209, 208, 209, 198, 210, 208, 202, 204, 145, 159, 239, 211, 222, 198, 218, 205, 159, 246, 251, 133, 159 }, 191) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0x4794c791 = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x188fffc2._0x2e478e05(new byte[25] { 229, 244, 226, 229, 145, 226, 216, 214, 223, 156, 216, 223, 145, 240, 196, 197, 217, 145, 244, 227, 227, 254, 227, 139, 145 }, 177) + ex.Message);
#endif
                }

                _0x2a4f527d?._0xb7a86899();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x188fffc2._0x2e478e05(new byte[28] { 182, 167, 177, 182, 194, 177, 139, 133, 140, 207, 139, 140, 194, 176, 135, 147, 151, 135, 145, 150, 194, 167, 176, 176, 173, 176, 216, 194 }, 226) + ex.Message);
#endif
                }

                _0x2a4f527d?._0xb7a86899();
                return true;
            }
        }
        while (!_0x20e2f489);
        return false;
    }

    internal bool firstLoadShown = false;
    private string _0x3281062c = "";
    private void Awake()
    {
        if (_0x2a4f527d != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0x2a4f527d = gameObject.GetComponent<_0xa7bd5c21>();
        DontDestroyOnLoad(gameObject);
        _0x9e746dd8 = _0x3a0b4b5e = _0xd9537a0f = "";
        _0x0bc310df = "";
        _0xa0ee427f = false;
    }

    private void _0xdb13249a()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    private Canvas _0x86ed072e;
    private bool _0xa2177f1a = false;
    private AndroidJavaObject _0xb67f4006 { get; set; }

    internal bool ContainsIgnoreCase(string _0xa5be1a71, string _0x8856368d)
    {
        if (string.IsNullOrEmpty(_0xa5be1a71) || string.IsNullOrEmpty(_0x8856368d))
            return false;
        return _0xa5be1a71.IndexOf(_0x8856368d, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private UniWebViewPopup _0x4eebfb27()
    {
        for (int _0x841eb731 = _0x05e7450b.Count - 1; _0x841eb731 >= 0; _0x841eb731--)
        {
            var _0xa8a000c8 = _0x05e7450b[_0x841eb731];
            if (_0xa8a000c8 != null && _0xa8a000c8.IsAlive)
                return _0xa8a000c8;
            _0x05e7450b.RemoveAt(_0x841eb731);
        }

        return null;
    }

    private string _0x3a0b4b5e { get; set; }

    private string _0xffba011f()
    {
        return _0x188fffc2._0x2e478e05(new byte[12] { 230, 168, 187, 160, 173, 186, 167, 161, 160, 230, 231, 181 }, 206) + _0x188fffc2._0x2e478e05(new byte[8] { 251, 236, 255, 173, 248, 236, 176, 170 }, 141) + WindowsDesktopUserAgent + _0x188fffc2._0x2e478e05(new byte[2] { 36, 56 }, 3) + _0x188fffc2._0x2e478e05(new byte[30] { 130, 149, 134, 212, 132, 134, 155, 128, 155, 201, 186, 149, 130, 157, 147, 149, 128, 155, 134, 218, 132, 134, 155, 128, 155, 128, 141, 132, 145, 207 }, 244) + _0x188fffc2._0x2e478e05(new byte[121] { 139, 152, 131, 142, 153, 132, 130, 131, 205, 137, 136, 139, 197, 130, 143, 135, 193, 134, 136, 148, 193, 155, 140, 129, 196, 150, 153, 159, 148, 150, 162, 143, 135, 136, 142, 153, 195, 137, 136, 139, 132, 131, 136, 189, 159, 130, 157, 136, 159, 153, 148, 197, 130, 143, 135, 193, 134, 136, 148, 193, 150, 138, 136, 153, 215, 139, 152, 131, 142, 153, 132, 130, 131, 197, 196, 150, 159, 136, 153, 152, 159, 131, 205, 155, 140, 129, 214, 144, 193, 142, 130, 131, 139, 132, 138, 152, 159, 140, 143, 129, 136, 215, 153, 159, 152, 136, 144, 196, 214, 144, 142, 140, 153, 142, 133, 197, 136, 196, 150, 144, 144 }, 237) + _0x188fffc2._0x2e478e05(new byte[26] { 159, 158, 157, 211, 139, 137, 148, 143, 148, 215, 220, 142, 136, 158, 137, 186, 156, 158, 149, 143, 220, 215, 142, 154, 210, 192 }, 251) + _0x188fffc2._0x2e478e05(new byte[130] { 49, 48, 51, 125, 37, 39, 58, 33, 58, 121, 114, 52, 37, 37, 3, 48, 39, 38, 60, 58, 59, 114, 121, 114, 96, 123, 101, 117, 125, 2, 60, 59, 49, 58, 34, 38, 117, 27, 1, 117, 100, 101, 123, 101, 110, 117, 2, 60, 59, 99, 97, 110, 117, 45, 99, 97, 124, 117, 20, 37, 37, 57, 48, 2, 48, 55, 30, 60, 33, 122, 96, 102, 98, 123, 102, 99, 117, 125, 30, 29, 1, 24, 25, 121, 117, 57, 60, 62, 48, 117, 18, 48, 54, 62, 58, 124, 117, 22, 61, 39, 58, 56, 48, 122, 100, 103, 101, 123, 101, 123, 101, 123, 101, 117, 6, 52, 51, 52, 39, 60, 122, 96, 102, 98, 123, 102, 99, 114, 124, 110 }, 85) + _0x188fffc2._0x2e478e05(new byte[30] { 182, 183, 180, 250, 162, 160, 189, 166, 189, 254, 245, 162, 190, 179, 166, 180, 189, 160, 191, 245, 254, 245, 133, 187, 188, 225, 224, 245, 251, 233 }, 210) + _0x188fffc2._0x2e478e05(new byte[34] { 83, 82, 81, 31, 71, 69, 88, 67, 88, 27, 16, 65, 82, 89, 83, 88, 69, 16, 27, 16, 112, 88, 88, 80, 91, 82, 23, 126, 89, 84, 25, 16, 30, 12 }, 55) + _0x188fffc2._0x2e478e05(new byte[30] { 21, 20, 23, 89, 1, 3, 30, 5, 30, 93, 86, 28, 16, 9, 37, 30, 4, 18, 25, 33, 30, 24, 31, 5, 2, 86, 93, 65, 88, 74 }, 113) + _0x188fffc2._0x2e478e05(new byte[449] { 25, 31, 20, 22, 27, 12, 31, 77, 24, 12, 9, 80, 22, 15, 31, 12, 3, 9, 30, 87, 54, 22, 15, 31, 12, 3, 9, 87, 74, 46, 5, 31, 2, 0, 4, 24, 0, 74, 65, 27, 8, 31, 30, 4, 2, 3, 87, 74, 92, 95, 93, 74, 16, 65, 22, 15, 31, 12, 3, 9, 87, 74, 42, 2, 2, 10, 1, 8, 77, 46, 5, 31, 2, 0, 8, 74, 65, 27, 8, 31, 30, 4, 2, 3, 87, 74, 92, 95, 93, 74, 16, 65, 22, 15, 31, 12, 3, 9, 87, 74, 35, 2, 25, 80, 44, 82, 47, 31, 12, 3, 9, 74, 65, 27, 8, 31, 30, 4, 2, 3, 87, 74, 95, 89, 74, 16, 48, 65, 0, 2, 15, 4, 1, 8, 87, 11, 12, 1, 30, 8, 65, 29, 1, 12, 25, 11, 2, 31, 0, 87, 74, 58, 4, 3, 9, 2, 26, 30, 74, 65, 10, 8, 25, 37, 4, 10, 5, 40, 3, 25, 31, 2, 29, 20, 59, 12, 1, 24, 8, 30, 87, 11, 24, 3, 14, 25, 4, 2, 3, 69, 68, 22, 31, 8, 25, 24, 31, 3, 77, 61, 31, 2, 0, 4, 30, 8, 67, 31, 8, 30, 2, 1, 27, 8, 69, 22, 12, 31, 14, 5, 4, 25, 8, 14, 25, 24, 31, 8, 87, 74, 21, 85, 91, 74, 65, 15, 4, 25, 3, 8, 30, 30, 87, 74, 91, 89, 74, 65, 0, 2, 15, 4, 1, 8, 87, 11, 12, 1, 30, 8, 65, 0, 2, 9, 8, 1, 87, 74, 74, 65, 29, 1, 12, 25, 11, 2, 31, 0, 87, 74, 58, 4, 3, 9, 2, 26, 30, 74, 65, 29, 1, 12, 25, 11, 2, 31, 0, 59, 8, 31, 30, 4, 2, 3, 87, 74, 92, 88, 67, 93, 67, 93, 74, 65, 24, 12, 43, 24, 1, 1, 59, 8, 31, 30, 4, 2, 3, 87, 74, 92, 95, 93, 67, 93, 67, 93, 67, 93, 74, 16, 68, 86, 16, 16, 86, 34, 15, 7, 8, 14, 25, 67, 9, 8, 11, 4, 3, 8, 61, 31, 2, 29, 8, 31, 25, 20, 69, 29, 31, 2, 25, 2, 65, 74, 24, 30, 8, 31, 44, 10, 8, 3, 25, 41, 12, 25, 12, 74, 65, 22, 10, 8, 25, 87, 11, 24, 3, 14, 25, 4, 2, 3, 69, 68, 22, 31, 8, 25, 24, 31, 3, 77, 24, 12, 9, 86, 16, 65, 14, 2, 3, 11, 4, 10, 24, 31, 12, 15, 1, 8, 87, 25, 31, 24, 8, 16, 68, 86, 16, 14, 12, 25, 14, 5, 69, 8, 68, 22, 16 }, 109) + _0x188fffc2._0x2e478e05(new byte[112] { 165, 164, 167, 233, 178, 162, 179, 164, 164, 175, 237, 230, 182, 168, 165, 181, 169, 230, 237, 240, 248, 243, 241, 232, 250, 165, 164, 167, 233, 178, 162, 179, 164, 164, 175, 237, 230, 169, 164, 168, 166, 169, 181, 230, 237, 240, 241, 249, 241, 232, 250, 165, 164, 167, 233, 178, 162, 179, 164, 164, 175, 237, 230, 160, 183, 160, 168, 173, 150, 168, 165, 181, 169, 230, 237, 240, 248, 243, 241, 232, 250, 165, 164, 167, 233, 178, 162, 179, 164, 164, 175, 237, 230, 160, 183, 160, 168, 173, 137, 164, 168, 166, 169, 181, 230, 237, 240, 241, 245, 241, 232, 250 }, 193) + _0x188fffc2._0x2e478e05(new byte[45] { 120, 126, 117, 119, 123, 101, 98, 104, 99, 123, 34, 99, 98, 120, 99, 121, 111, 100, 127, 120, 109, 126, 120, 49, 121, 98, 104, 105, 106, 101, 98, 105, 104, 55, 113, 111, 109, 120, 111, 100, 36, 105, 37, 119, 113 }, 12) + _0x188fffc2._0x2e478e05(new byte[721] { 170, 172, 167, 165, 168, 191, 172, 254, 177, 172, 183, 185, 227, 169, 183, 176, 186, 177, 169, 240, 179, 191, 170, 189, 182, 147, 187, 186, 183, 191, 240, 188, 183, 176, 186, 246, 169, 183, 176, 186, 177, 169, 247, 229, 169, 183, 176, 186, 177, 169, 240, 179, 191, 170, 189, 182, 147, 187, 186, 183, 191, 227, 184, 171, 176, 189, 170, 183, 177, 176, 246, 175, 247, 165, 168, 191, 172, 254, 173, 227, 141, 170, 172, 183, 176, 185, 246, 175, 247, 240, 170, 177, 146, 177, 169, 187, 172, 157, 191, 173, 187, 246, 247, 229, 183, 184, 246, 173, 240, 183, 176, 186, 187, 166, 145, 184, 246, 249, 174, 177, 183, 176, 170, 187, 172, 228, 254, 189, 177, 191, 172, 173, 187, 249, 247, 224, 227, 238, 162, 162, 173, 240, 183, 176, 186, 187, 166, 145, 184, 246, 249, 182, 177, 168, 187, 172, 228, 254, 176, 177, 176, 187, 249, 247, 224, 227, 238, 162, 162, 173, 240, 183, 176, 186, 187, 166, 145, 184, 246, 249, 179, 191, 166, 243, 169, 183, 186, 170, 182, 249, 247, 224, 227, 238, 162, 162, 173, 240, 183, 176, 186, 187, 166, 145, 184, 246, 249, 179, 191, 166, 243, 186, 187, 168, 183, 189, 187, 243, 169, 183, 186, 170, 182, 249, 247, 224, 227, 238, 247, 172, 187, 170, 171, 172, 176, 254, 165, 179, 191, 170, 189, 182, 187, 173, 228, 184, 191, 178, 173, 187, 242, 179, 187, 186, 183, 191, 228, 175, 242, 177, 176, 189, 182, 191, 176, 185, 187, 228, 176, 171, 178, 178, 242, 191, 186, 186, 146, 183, 173, 170, 187, 176, 187, 172, 228, 184, 171, 176, 189, 170, 183, 177, 176, 246, 247, 165, 163, 242, 172, 187, 179, 177, 168, 187, 146, 183, 173, 170, 187, 176, 187, 172, 228, 184, 171, 176, 189, 170, 183, 177, 176, 246, 247, 165, 163, 242, 191, 186, 186, 155, 168, 187, 176, 170, 146, 183, 173, 170, 187, 176, 187, 172, 228, 184, 171, 176, 189, 170, 183, 177, 176, 246, 247, 165, 163, 242, 172, 187, 179, 177, 168, 187, 155, 168, 187, 176, 170, 146, 183, 173, 170, 187, 176, 187, 172, 228, 184, 171, 176, 189, 170, 183, 177, 176, 246, 247, 165, 163, 242, 186, 183, 173, 174, 191, 170, 189, 182, 155, 168, 187, 176, 170, 228, 184, 171, 176, 189, 170, 183, 177, 176, 246, 247, 165, 172, 187, 170, 171, 172, 176, 254, 184, 191, 178, 173, 187, 229, 163, 163, 229, 183, 184, 246, 173, 240, 183, 176, 186, 187, 166, 145, 184, 246, 249, 174, 177, 183, 176, 170, 187, 172, 228, 254, 184, 183, 176, 187, 249, 247, 224, 227, 238, 162, 162, 173, 240, 183, 176, 186, 187, 166, 145, 184, 246, 249, 182, 177, 168, 187, 172, 228, 254, 182, 177, 168, 187, 172, 249, 247, 224, 227, 238, 247, 172, 187, 170, 171, 172, 176, 254, 165, 179, 191, 170, 189, 182, 187, 173, 228, 170, 172, 171, 187, 242, 179, 187, 186, 183, 191, 228, 175, 242, 177, 176, 189, 182, 191, 176, 185, 187, 228, 176, 171, 178, 178, 242, 191, 186, 186, 146, 183, 173, 170, 187, 176, 187, 172, 228, 184, 171, 176, 189, 170, 183, 177, 176, 246, 247, 165, 163, 242, 172, 187, 179, 177, 168, 187, 146, 183, 173, 170, 187, 176, 187, 172, 228, 184, 171, 176, 189, 170, 183, 177, 176, 246, 247, 165, 163, 242, 191, 186, 186, 155, 168, 187, 176, 170, 146, 183, 173, 170, 187, 176, 187, 172, 228, 184, 171, 176, 189, 170, 183, 177, 176, 246, 247, 165, 163, 242, 172, 187, 179, 177, 168, 187, 155, 168, 187, 176, 170, 146, 183, 173, 170, 187, 176, 187, 172, 228, 184, 171, 176, 189, 170, 183, 177, 176, 246, 247, 165, 163, 242, 186, 183, 173, 174, 191, 170, 189, 182, 155, 168, 187, 176, 170, 228, 184, 171, 176, 189, 170, 183, 177, 176, 246, 247, 165, 172, 187, 170, 171, 172, 176, 254, 184, 191, 178, 173, 187, 229, 163, 163, 229, 172, 187, 170, 171, 172, 176, 254, 177, 172, 183, 185, 246, 175, 247, 229, 163, 229, 163, 189, 191, 170, 189, 182, 246, 187, 247, 165, 163 }, 222) + _0x188fffc2._0x2e478e05(new byte[5] { 129, 213, 212, 213, 199 }, 252);
    }

    internal bool isDestroyedForce = false;
    private string _0xcd86e11f = "";
    private bool _0x322dd355()
    {
        _0x05e7450b.RemoveAll(_0x72acba4e => _0x72acba4e == null || !_0x72acba4e.IsAlive);
        return _0x05e7450b.Count > 0;
    }

    private float _0xf632d590 = 0f;
    private string _0x187ad849 = "";
    internal bool IsAboutBlank(string _0x5dc6b32c)
    {
        if (string.IsNullOrEmpty(_0x5dc6b32c))
            return false;
        return _0x5dc6b32c.StartsWith(_0x188fffc2._0x2e478e05(new byte[11] { 110, 109, 96, 122, 123, 53, 109, 99, 110, 97, 100 }, 15), StringComparison.OrdinalIgnoreCase);
    }

    private string _0x6263dc29()
    {
        if (string.IsNullOrEmpty(_0xbc1a1598) && _0x081b16a4 != null)
            _0xbc1a1598 = _0x081b16a4.GetUserAgent();
        if (string.IsNullOrEmpty(_0xbc1a1598))
            return string.Empty;
        string _0x6e8ffa3c = Regex.Replace(_0xbc1a1598, _0x188fffc2._0x2e478e05(new byte[11] { 141, 162, 251, 234, 141, 162, 251, 166, 167, 141, 179 }, 209), string.Empty);
        _0x6e8ffa3c = Regex.Replace(_0x6e8ffa3c, _0x188fffc2._0x2e478e05(new byte[15] { 159, 176, 232, 129, 182, 170, 175, 167, 236, 152, 157, 248, 234, 158, 232 }, 195), string.Empty);
        _0x6e8ffa3c = Regex.Replace(_0x6e8ffa3c, _0x188fffc2._0x2e478e05(new byte[15] { 202, 249, 238, 239, 245, 243, 242, 179, 168, 192, 178, 172, 192, 239, 182 }, 156), string.Empty);
        return Regex.Replace(_0x6e8ffa3c, _0x188fffc2._0x2e478e05(new byte[6] { 15, 32, 40, 97, 127, 46 }, 83), _0x188fffc2._0x2e478e05(new byte[1] { 11 }, 43)).Trim();
    }

    private Task _0xd92ec725(IEnumerator _0x85ba7343)
    {
        var _0x1d6c57ac = new TaskCompletionSource<bool>();
        StartCoroutine(_0x6c35906f(_0x85ba7343, _0x1d6c57ac));
        return _0x1d6c57ac.Task;
    }

    // MAIN FLOW
    private bool _0x54fab363 { get; set; }

    private void _0x6880284b()
    {
        _0x6130e3fc = true;
        if (_0x081b16a4 != null)
            _0x081b16a4.SetUserAgent(_0x6263dc29());
    }

    internal string _0x80f3675e(string _0x47be5c38)
    {
        int _0xf7a29e64 = _0x47be5c38.IndexOf(_0x188fffc2._0x2e478e05(new byte[3] { 206, 195, 154 }, 167), StringComparison.OrdinalIgnoreCase);
        if (_0xf7a29e64 < 0)
            return null;
        string _0x5e3c228f = _0x47be5c38.Substring(_0xf7a29e64 + 3);
        int _0xd18c1d18 = _0x5e3c228f.IndexOf('&');
        return _0xd18c1d18 >= 0 ? _0x5e3c228f.Substring(0, _0xd18c1d18) : _0x5e3c228f;
    }

    private bool TryOpenExternalLikeChrome(string _0xd8deb0dc)
    {
        if (string.IsNullOrEmpty(_0xd8deb0dc))
            return false;
        if (_0xd8deb0dc.StartsWith(_0x188fffc2._0x2e478e05(new byte[9] { 146, 149, 143, 158, 149, 143, 193, 212, 212 }, 251), StringComparison.OrdinalIgnoreCase))
            return _0x9579cfc2(_0xd8deb0dc);
        if (_0x634df0a7(_0xd8deb0dc))
            return _0xb71728d7(_0xd8deb0dc, null);
        if (!_0xd8deb0dc.StartsWith(_0x188fffc2._0x2e478e05(new byte[7] { 170, 182, 182, 178, 248, 237, 237 }, 194), StringComparison.OrdinalIgnoreCase) && !_0xd8deb0dc.StartsWith(_0x188fffc2._0x2e478e05(new byte[8] { 109, 113, 113, 117, 118, 63, 42, 42 }, 5), StringComparison.OrdinalIgnoreCase) && !_0xd8deb0dc.StartsWith(_0x188fffc2._0x2e478e05(new byte[11] { 154, 153, 148, 142, 143, 193, 153, 151, 154, 149, 144 }, 251), StringComparison.OrdinalIgnoreCase))
        {
            return _0x7a52cb8c(_0xd8deb0dc);
        }

        return false;
    }

    private static string ReadPushField(Dictionary<string, object> _0xd9f12589, string _0x0c39285c)
    {
        if (_0xd9f12589 == null || string.IsNullOrEmpty(_0x0c39285c))
            return string.Empty;
        if (_0xd9f12589.TryGetValue(_0x188fffc2._0x2e478e05(new byte[16] { 69, 68, 95, 66, 77, 66, 72, 74, 95, 66, 68, 69, 111, 74, 95, 74 }, 43), out var raw))
        {
            try
            {
                var _0x2ba0e8bc = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0x2ba0e8bc != null && _0x2ba0e8bc.TryGetValue(_0x0c39285c, out var nestedVal))
                {
                    var _0x2549e9fe = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0x2549e9fe))
                        return _0x2549e9fe;
                }
            }
            catch
            {
            }
        }

        if (_0xd9f12589.TryGetValue(_0x0c39285c, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    private bool _0x4caa7ce4 = false;
    private void OnDestroy()
    {
        StopAllCoroutines();
        _0xb7a86899();
    }

    private string _0x0bc310df = "";
    private string GetFailingUrl(UniWebViewNativeResultPayload _0x28aac8b3)
    {
        if (_0x28aac8b3 == null || _0x28aac8b3.Extra == null)
            return null;
        object _0x44a4807f;
        if (!_0x28aac8b3.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0x44a4807f))
            return null;
        return _0x44a4807f as string;
    }

    private void OnApplicationFocus(bool _0x17b8dc32)
    {
        isApplicationFocus = _0x17b8dc32;
        if (_0x17b8dc32 && _0xa0ee427f)
        {
            _0xc3da5d1b();
        }
    }

    private void _0xb6b55928(string _0x6c8d4ac0)
    {
        if (string.IsNullOrEmpty(_0x6c8d4ac0))
            return;
        if (TryOpenExternalLikeChrome(_0x6c8d4ac0))
            return;
        OpenUrlExternally(_0x6c8d4ac0);
    }

    internal void _0x08331083()
    {
        Rect _0x48a61c97 = Screen.safeArea;
        Vector2 _0x1d672316 = new Vector2(Screen.width, Screen.height);
        if (_0x48a61c97 == lastSafe && _0x1d672316 == lastSize)
            return;
        // Apply manual padding
        _0x48a61c97.xMin += _0xb6d18951;
        _0x48a61c97.xMax -= _0x4ddd07a9;
        _0x48a61c97.yMin += _0xb61e05b8;
        _0x48a61c97.yMax -= _0xb0644f55;
        // Convert Unity safe area -> native WebView frame
        Rect _0x982ed24d = new Rect(_0x48a61c97.x, _0x1d672316.y - _0x48a61c97.y - _0x48a61c97.height, // Y flip for native coordinate system
 _0x48a61c97.width, _0x48a61c97.height);
        _0x081b16a4.Frame = _0x982ed24d;
        lastSafe = Screen.safeArea;
        lastSize = _0x1d672316;
    }

    private string _0x62099a43 = "";
    private void _0x20e0ef53(UniWebView _0x2ef9ae1a)
    {
        _0x2ef9ae1a.BackgroundColor = Color.clear;
        _0x2ef9ae1a.SetSupportMultipleWindows(true, true);
        _0x2ef9ae1a.SetBackButtonEnabled(false);
        _0x081b16a4.SetUserAgent(_0x6263dc29());
    }

    private string _0x54867765 = "";
    private string _0x5cad8aca = "";
    private string _0xf20e476b;
    private RectTransform _0x40f2a1f1;
    // WEB VIEW LOGIC
    public bool _0xa0ee427f { get; set; }

    private void WLog(string _0x4bfcb0fd)
    {
#if B_LOGS
        {
            Debug.Log(_0x188fffc2._0x2e478e05(new byte[7] { 254, 241, 192, 214, 209, 248, 133 }, 165) + _0x4bfcb0fd);
        }
#endif
    }

    private bool _0x15dd0bda()
    {
        var _0x4c92f7bd = _0x4eebfb27();
        if (_0x4c92f7bd == null)
            return false;
        WLog(_0x188fffc2._0x2e478e05(new byte[31] { 143, 166, 181, 163, 176, 166, 181, 162, 231, 165, 166, 164, 172, 231, 234, 249, 231, 183, 168, 183, 178, 183, 231, 128, 168, 133, 166, 164, 172, 253, 231 }, 199) + _0x4c92f7bd.Id);
        _0x4c92f7bd.GoBack();
        return true;
    }

    private string _0xe00bec3b = "";
    private bool _0xf43c5d95(int _0x1cd1cb83, string _0xfbe9a683, string _0x13fac3d5)
    {
        if (string.IsNullOrEmpty(_0x13fac3d5))
            return false;
        if (!IsHttpUrl(_0x13fac3d5))
            return true;
        if (string.IsNullOrEmpty(_0xfbe9a683))
            return false;
        return _0xfbe9a683.IndexOf(_0x188fffc2._0x2e478e05(new byte[20] { 116, 99, 99, 110, 114, 126, 127, 127, 116, 114, 101, 120, 126, 127, 110, 99, 116, 98, 116, 101 }, 49), StringComparison.OrdinalIgnoreCase) >= 0 || _0xfbe9a683.IndexOf(_0x188fffc2._0x2e478e05(new byte[22] { 71, 80, 80, 93, 65, 77, 76, 76, 71, 65, 86, 75, 77, 76, 93, 80, 71, 68, 87, 81, 71, 70 }, 2), StringComparison.OrdinalIgnoreCase) >= 0 || _0xfbe9a683.IndexOf(_0x188fffc2._0x2e478e05(new byte[21] { 99, 116, 116, 121, 101, 105, 104, 104, 99, 101, 114, 111, 105, 104, 121, 101, 106, 105, 117, 99, 98 }, 38), StringComparison.OrdinalIgnoreCase) >= 0 || _0xfbe9a683.IndexOf(_0x188fffc2._0x2e478e05(new byte[22] { 89, 78, 78, 67, 73, 82, 87, 82, 83, 75, 82, 67, 73, 78, 80, 67, 79, 95, 84, 89, 81, 89 }, 28), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private Text _0xa3e66bed;
    private string _0xe24b3c0a()
    {
        string _0x16b7275e = _0x6263dc29();
        if (string.IsNullOrEmpty(_0x16b7275e))
            return _0x188fffc2._0x2e478e05(new byte[7] { 121, 96, 102, 107, 47, 63, 52 }, 15);
        string _0xb8d466ec = _0x16b7275e.Replace(_0x188fffc2._0x2e478e05(new byte[1] { 1 }, 93), _0x188fffc2._0x2e478e05(new byte[2] { 141, 141 }, 209)).Replace(_0x188fffc2._0x2e478e05(new byte[1] { 146 }, 181), _0x188fffc2._0x2e478e05(new byte[2] { 114, 9 }, 46));
        var _0x69d38fcc = Regex.Match(_0x16b7275e, _0x188fffc2._0x2e478e05(new byte[12] { 112, 91, 65, 92, 94, 86, 28, 27, 111, 87, 24, 26 }, 51));
        string _0x594a3266 = _0x69d38fcc.Success ? _0x69d38fcc.Groups[1].Value : _0x188fffc2._0x2e478e05(new byte[3] { 47, 44, 46 }, 30);
        return _0x188fffc2._0x2e478e05(new byte[12] { 28, 82, 65, 90, 87, 64, 93, 91, 90, 28, 29, 79 }, 52) + _0x188fffc2._0x2e478e05(new byte[8] { 35, 52, 39, 117, 32, 52, 104, 114 }, 85) + _0xb8d466ec + _0x188fffc2._0x2e478e05(new byte[2] { 150, 138 }, 177) + _0x188fffc2._0x2e478e05(new byte[30] { 64, 87, 68, 22, 70, 68, 89, 66, 89, 11, 120, 87, 64, 95, 81, 87, 66, 89, 68, 24, 70, 68, 89, 66, 89, 66, 79, 70, 83, 13 }, 54) + _0x188fffc2._0x2e478e05(new byte[121] { 51, 32, 59, 54, 33, 60, 58, 59, 117, 49, 48, 51, 125, 58, 55, 63, 121, 62, 48, 44, 121, 35, 52, 57, 124, 46, 33, 39, 44, 46, 26, 55, 63, 48, 54, 33, 123, 49, 48, 51, 60, 59, 48, 5, 39, 58, 37, 48, 39, 33, 44, 125, 58, 55, 63, 121, 62, 48, 44, 121, 46, 50, 48, 33, 111, 51, 32, 59, 54, 33, 60, 58, 59, 125, 124, 46, 39, 48, 33, 32, 39, 59, 117, 35, 52, 57, 110, 40, 121, 54, 58, 59, 51, 60, 50, 32, 39, 52, 55, 57, 48, 111, 33, 39, 32, 48, 40, 124, 110, 40, 54, 52, 33, 54, 61, 125, 48, 124, 46, 40, 40 }, 85) + _0x188fffc2._0x2e478e05(new byte[26] { 161, 160, 163, 237, 181, 183, 170, 177, 170, 233, 226, 176, 182, 160, 183, 132, 162, 160, 171, 177, 226, 233, 176, 164, 236, 254 }, 197) + _0x188fffc2._0x2e478e05(new byte[52] { 223, 222, 221, 147, 203, 201, 212, 207, 212, 151, 156, 218, 203, 203, 237, 222, 201, 200, 210, 212, 213, 156, 151, 206, 218, 149, 201, 222, 203, 215, 218, 216, 222, 147, 148, 229, 246, 212, 193, 210, 215, 215, 218, 231, 148, 148, 151, 156, 156, 146, 146, 128 }, 187) + _0x188fffc2._0x2e478e05(new byte[37] { 161, 160, 163, 237, 181, 183, 170, 177, 170, 233, 226, 181, 169, 164, 177, 163, 170, 183, 168, 226, 233, 226, 137, 172, 171, 176, 189, 229, 164, 183, 168, 179, 253, 169, 226, 236, 254 }, 197) + _0x188fffc2._0x2e478e05(new byte[34] { 216, 217, 218, 148, 204, 206, 211, 200, 211, 144, 155, 202, 217, 210, 216, 211, 206, 155, 144, 155, 251, 211, 211, 219, 208, 217, 156, 245, 210, 223, 146, 155, 149, 135 }, 188) + _0x188fffc2._0x2e478e05(new byte[30] { 255, 254, 253, 179, 235, 233, 244, 239, 244, 183, 188, 246, 250, 227, 207, 244, 238, 248, 243, 203, 244, 242, 245, 239, 232, 188, 183, 174, 178, 160 }, 155) + _0x188fffc2._0x2e478e05(new byte[48] { 249, 255, 244, 246, 251, 236, 255, 173, 248, 236, 233, 176, 246, 239, 255, 236, 227, 233, 254, 183, 214, 246, 239, 255, 236, 227, 233, 183, 170, 206, 229, 255, 226, 224, 228, 248, 224, 170, 161, 251, 232, 255, 254, 228, 226, 227, 183, 170 }, 141) + _0x594a3266 + _0x188fffc2._0x2e478e05(new byte[35] { 211, 137, 216, 143, 150, 134, 149, 154, 144, 206, 211, 179, 155, 155, 147, 152, 145, 212, 183, 156, 134, 155, 153, 145, 211, 216, 130, 145, 134, 135, 157, 155, 154, 206, 211 }, 244) + _0x594a3266 + _0x188fffc2._0x2e478e05(new byte[238] { 4, 94, 15, 88, 65, 81, 66, 77, 71, 25, 4, 109, 76, 87, 30, 98, 28, 97, 81, 66, 77, 71, 4, 15, 85, 70, 81, 80, 74, 76, 77, 25, 4, 17, 23, 4, 94, 126, 15, 78, 76, 65, 74, 79, 70, 25, 87, 81, 86, 70, 15, 83, 79, 66, 87, 69, 76, 81, 78, 25, 4, 98, 77, 71, 81, 76, 74, 71, 4, 15, 68, 70, 87, 107, 74, 68, 75, 102, 77, 87, 81, 76, 83, 90, 117, 66, 79, 86, 70, 80, 25, 69, 86, 77, 64, 87, 74, 76, 77, 11, 10, 88, 81, 70, 87, 86, 81, 77, 3, 115, 81, 76, 78, 74, 80, 70, 13, 81, 70, 80, 76, 79, 85, 70, 11, 88, 66, 81, 64, 75, 74, 87, 70, 64, 87, 86, 81, 70, 25, 4, 66, 81, 78, 4, 15, 65, 74, 87, 77, 70, 80, 80, 25, 4, 21, 23, 4, 15, 78, 76, 65, 74, 79, 70, 25, 87, 81, 86, 70, 15, 78, 76, 71, 70, 79, 25, 4, 4, 15, 83, 79, 66, 87, 69, 76, 81, 78, 25, 4, 98, 77, 71, 81, 76, 74, 71, 4, 15, 83, 79, 66, 87, 69, 76, 81, 78, 117, 70, 81, 80, 74, 76, 77, 25, 4, 18, 23, 13, 19, 13, 19, 4, 15, 86, 66, 101, 86, 79, 79, 117, 70, 81, 80, 74, 76, 77, 25, 4 }, 35) + _0x594a3266 + _0x188fffc2._0x2e478e05(new byte[117] { 113, 111, 113, 111, 113, 111, 120, 34, 118, 100, 34, 34, 100, 16, 61, 53, 58, 60, 43, 113, 59, 58, 57, 54, 49, 58, 15, 45, 48, 47, 58, 45, 43, 38, 119, 47, 45, 48, 43, 48, 115, 120, 42, 44, 58, 45, 30, 56, 58, 49, 43, 27, 62, 43, 62, 120, 115, 36, 56, 58, 43, 101, 57, 42, 49, 60, 43, 54, 48, 49, 119, 118, 36, 45, 58, 43, 42, 45, 49, 127, 42, 62, 59, 100, 34, 115, 60, 48, 49, 57, 54, 56, 42, 45, 62, 61, 51, 58, 101, 43, 45, 42, 58, 34, 118, 100, 34, 60, 62, 43, 60, 55, 119, 58, 118, 36, 34 }, 95) + _0x188fffc2._0x2e478e05(new byte[5] { 202, 158, 159, 158, 140 }, 183);
    }

    internal Vector2 lastSize = Vector2.zero;
    private bool _0x4b5d11dc = false;
    private GameObject _0xe7732caa;
    private IEnumerator _0xd59ca641(float _0x801ad752)
    {
        yield return new WaitForSeconds(_0x801ad752);
        if (!_0x54fab363)
        {
            _0x54fab363 = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0x4a85fb46}");
                }
#endif
            }
        }
    }

    private async void Start()
    {
        await _0x863507aa();
    }

    private void _0xe7cea516(string _0x442804f8)
    {
        Dictionary<string, object> _0x9ffdcad0;
        try
        {
            _0x9ffdcad0 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x442804f8);
        }
        catch
        {
            return;
        }

        var _0x3b220068 = ReadPushField(_0x9ffdcad0, _0x188fffc2._0x2e478e05(new byte[3] { 82, 85, 75 }, 39));
        if (string.IsNullOrWhiteSpace(_0x3b220068))
            return;
        _0x3b220068 = _0x3b220068.Trim();
        if (!IsHttpUrl(_0x3b220068))
            return;
        if (string.Equals(_0x3b220068, _0xc4b3bc0b, StringComparison.Ordinal))
            return;
        _0xc4b3bc0b = _0x3b220068;
        OpenUrlExternally(_0x3b220068);
    }

    private bool _0xae4a271b = false;
    private string _0xc4b3bc0b;
    internal bool IsGoogleAuthFlowUrl(string _0x803ff8bc)
    {
        if (string.IsNullOrEmpty(_0x803ff8bc))
            return false;
        return _0x803ff8bc.IndexOf(_0x188fffc2._0x2e478e05(new byte[19] { 241, 243, 243, 255, 229, 254, 228, 227, 190, 247, 255, 255, 247, 252, 245, 190, 243, 255, 253 }, 144), StringComparison.OrdinalIgnoreCase) >= 0 || _0x803ff8bc.IndexOf(_0x188fffc2._0x2e478e05(new byte[16] { 94, 92, 92, 80, 74, 81, 75, 76, 17, 88, 80, 80, 88, 83, 90, 17 }, 63), StringComparison.OrdinalIgnoreCase) >= 0 || _0x803ff8bc.IndexOf(_0x188fffc2._0x2e478e05(new byte[21] { 151, 159, 159, 151, 156, 149, 133, 131, 149, 130, 147, 159, 158, 132, 149, 158, 132, 222, 147, 159, 157 }, 240), StringComparison.OrdinalIgnoreCase) >= 0 || _0x803ff8bc.IndexOf(_0x188fffc2._0x2e478e05(new byte[11] { 150, 130, 133, 144, 133, 152, 146, 223, 146, 158, 156 }, 241), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private string _0x4794c791 = "";
    private readonly List<UniWebViewPopup> _0x05e7450b = new List<UniWebViewPopup>();
    private Canvas _0x8d1065f7()
    {
        if (_0x86ed072e != null)
            return _0x86ed072e;
        var _0x064384dc = gameObject.GetComponentInChildren<Canvas>();
        if (_0x064384dc == null)
        {
            var _0xe6af5513 = new GameObject(_0x188fffc2._0x2e478e05(new byte[6] { 147, 177, 190, 166, 177, 163 }, 208), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0x064384dc = _0xe6af5513.GetComponent<Canvas>();
            _0x064384dc.transform.SetParent(transform, false);
            _0x064384dc.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0x86ed072e = _0x064384dc;
        return _0x86ed072e;
    }

    private void _0x7331f70d(string _0x00890f74)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x188fffc2._0x2e478e05(new byte[34] { 244, 251, 202, 220, 219, 242, 143, 233, 202, 219, 204, 199, 143, 234, 215, 219, 221, 206, 143, 255, 218, 220, 199, 143, 235, 206, 219, 206, 143, 253, 206, 216, 149, 143 }, 175) + _0x00890f74);
#endif
            }
        }

        var _0xffaf0f50 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x00890f74);
        StartCoroutine(_0x8c87a950(_0xffaf0f50));
    }

    private string _0xbc1a1598 = "";
    private ApplicationInstallMode _0x3ade8bd9 = ApplicationInstallMode.Unknown;
    internal Rect lastSafe = Rect.zero;
    private IEnumerator _0x79130c32(string _0x9c59b01f)
    {
        if (Permission.HasUserAuthorizedPermission(_0x9c59b01f))
            yield break;
        bool _0x7d87b91e = false;
        var _0x724aacc6 = new PermissionCallbacks();
        _0x724aacc6.PermissionGranted += _0x17c94327 => _0x7d87b91e = true;
        _0x724aacc6.PermissionDenied += _0x17c94327 => _0x7d87b91e = true;
        Permission.RequestUserPermission(_0x9c59b01f, _0x724aacc6);
        yield return new WaitUntil(() => _0x7d87b91e);
    }

    internal bool isApplicationFocus = false;
    private string _0xd50948a2 = "";
    private string _0x7b72452b = "";
    private string Decrypt(string _0x7364f6bc, string _0xad4c85f8)
    {
        try
        {
            var _0xa8da7c61 = Convert.FromBase64String(_0x7364f6bc);
            using var _0x08dfed50 = Aes.Create();
            _0x08dfed50.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xad4c85f8));
            var _0x90c52ad5 = new byte[16];
            Buffer.BlockCopy(_0xa8da7c61, 0, _0x90c52ad5, 0, 16);
            _0x08dfed50.IV = _0x90c52ad5;
            using var _0xd2a233b5 = new MemoryStream(_0xa8da7c61, 16, _0xa8da7c61.Length - 16);
            using var _0xd928e794 = new CryptoStream(_0xd2a233b5, _0x08dfed50.CreateDecryptor(), CryptoStreamMode.Read);
            using var _0x6de11596 = new StreamReader(_0xd928e794, Encoding.UTF8);
            return _0x6de11596.ReadToEnd();
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private string _0x39db8694 = "";
    private IEnumerator _0x8554aedb()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0x188fffc2._0x2e478e05(new byte[26] { 87, 88, 105, 127, 120, 81, 44, 69, 98, 101, 120, 101, 109, 96, 101, 118, 105, 94, 105, 106, 106, 105, 126, 105, 126, 44 }, 12));
            }
#endif
        }

        bool _0xb7e6d8d2 = false;
        InstallReferrer.GetReferrer((_0x581d04d1) =>
        {
            Debug.Log(_0x188fffc2._0x2e478e05(new byte[24] { 93, 82, 99, 117, 114, 38, 84, 99, 96, 99, 116, 116, 99, 116, 91, 38, 97, 99, 114, 38, 228, 128, 148, 38 }, 6) + _0x4a85fb46);
            if (_0x581d04d1.IsSuccess)
            {
                _0x4a85fb46 = _0x581d04d1.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0x188fffc2._0x2e478e05(new byte[28] { 52, 59, 10, 28, 27, 79, 61, 10, 9, 10, 29, 29, 10, 29, 50, 79, 60, 26, 12, 12, 10, 28, 28, 79, 141, 233, 253, 79 }, 111) + _0x4a85fb46);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0x188fffc2._0x2e478e05(new byte[27] { 28, 19, 34, 52, 51, 103, 21, 34, 33, 34, 53, 53, 34, 53, 26, 103, 1, 38, 46, 43, 34, 35, 103, 165, 193, 213, 103 }, 71) + _0x581d04d1);
#endif
                }

                _0x4a85fb46 = "";
            }

            _0x54fab363 = true;
        });
        StartCoroutine(_0xd59ca641(2f));
        yield return new WaitUntil(() => _0x54fab363);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0x4a85fb46}");
#endif
        }

        bool _0x3b299e4c = _0x4a85fb46.Contains(_0x188fffc2._0x2e478e05(new byte[6] { 194, 198, 201, 204, 193, 152 }, 165));
        _0xb7e6d8d2 = _0x3b299e4c || _0x4a85fb46.Contains(_0x188fffc2._0x2e478e05(new byte[18] { 154, 139, 139, 136, 213, 146, 149, 136, 143, 154, 156, 137, 154, 150, 213, 152, 148, 150 }, 251)) || _0x4a85fb46.Contains(_0x188fffc2._0x2e478e05(new byte[17] { 224, 241, 241, 242, 175, 231, 224, 226, 228, 227, 238, 238, 234, 175, 226, 238, 236 }, 129));
        _0x3a0b4b5e = _0x3b299e4c ? "" : (_0xb7e6d8d2 ? "" : _0x3a0b4b5e);
        _0x3a0b4b5e = _0x3a0b4b5e ?? "";
        _0xd9537a0f = _0xd9537a0f ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0x3a0b4b5e}");
#endif
        }
    }

    private readonly string[] _0x0d9a59d5 = new string[]
    {
        _0x188fffc2._0x2e478e05(new byte[60] { 219, 180, 165, 155, 11, 127, 67, 78, 11, 89, 78, 78, 71, 88, 11, 74, 89, 78, 11, 67, 68, 95, 11, 89, 66, 76, 67, 95, 11, 69, 68, 92, 11, 201, 171, 184, 11, 79, 68, 69, 201, 171, 178, 95, 11, 70, 66, 88, 88, 11, 82, 68, 94, 89, 11, 88, 91, 66, 69, 10 }, 43),
        _0x188fffc2._0x2e478e05(new byte[52] { 169, 198, 212, 217, 121, 16, 45, 121, 58, 54, 44, 53, 61, 121, 59, 60, 121, 32, 54, 44, 43, 121, 53, 44, 58, 50, 32, 121, 52, 54, 52, 60, 55, 45, 121, 187, 217, 202, 121, 46, 49, 32, 121, 42, 45, 54, 41, 121, 55, 54, 46, 102 }, 89),
        _0x188fffc2._0x2e478e05(new byte[66] { 70, 62, 5, 75, 28, 43, 132, 230, 205, 195, 132, 211, 205, 202, 215, 132, 197, 214, 193, 132, 204, 205, 208, 208, 205, 202, 195, 132, 201, 203, 214, 193, 132, 203, 194, 208, 193, 202, 132, 208, 203, 192, 197, 221, 132, 70, 36, 55, 132, 215, 208, 197, 221, 132, 205, 202, 132, 208, 204, 193, 132, 195, 197, 201, 193, 138 }, 164),
        _0x188fffc2._0x2e478e05(new byte[54] { 97, 14, 4, 3, 177, 197, 249, 248, 226, 177, 248, 226, 177, 225, 227, 248, 252, 244, 177, 229, 248, 252, 244, 177, 115, 17, 2, 177, 229, 249, 244, 177, 243, 244, 226, 229, 177, 225, 253, 240, 232, 244, 227, 226, 177, 225, 253, 240, 232, 177, 255, 254, 230, 191 }, 145),
        _0x188fffc2._0x2e478e05(new byte[48] { 142, 225, 234, 219, 94, 39, 17, 11, 12, 94, 9, 23, 16, 16, 23, 16, 25, 94, 13, 10, 12, 27, 31, 21, 94, 29, 17, 11, 18, 26, 94, 28, 27, 94, 17, 16, 27, 94, 13, 14, 23, 16, 94, 31, 9, 31, 7, 80 }, 126),
        _0x188fffc2._0x2e478e05(new byte[65] { 239, 128, 133, 159, 63, 85, 126, 124, 116, 111, 112, 107, 108, 63, 126, 109, 122, 63, 114, 112, 109, 122, 63, 126, 124, 107, 118, 105, 122, 63, 107, 112, 113, 118, 120, 119, 107, 63, 253, 159, 140, 63, 108, 107, 126, 102, 63, 126, 113, 123, 63, 107, 109, 102, 63, 102, 112, 106, 109, 63, 115, 106, 124, 116, 49 }, 31),
        _0x188fffc2._0x2e478e05(new byte[55] { 37, 74, 91, 103, 245, 144, 163, 176, 167, 172, 245, 166, 165, 188, 187, 245, 182, 186, 160, 187, 161, 166, 245, 55, 85, 70, 245, 161, 189, 176, 245, 187, 176, 173, 161, 245, 186, 187, 176, 245, 182, 186, 160, 185, 177, 245, 183, 176, 245, 172, 186, 160, 167, 166, 251 }, 213),
        _0x188fffc2._0x2e478e05(new byte[63] { 23, 88, 101, 26, 77, 122, 213, 165, 153, 148, 140, 144, 135, 134, 213, 135, 156, 146, 157, 129, 213, 155, 154, 130, 213, 148, 135, 144, 213, 130, 156, 155, 155, 156, 155, 146, 213, 23, 117, 102, 213, 145, 154, 155, 23, 117, 108, 129, 213, 130, 148, 153, 158, 213, 148, 130, 148, 140, 213, 140, 144, 129, 219 }, 245),
        _0x188fffc2._0x2e478e05(new byte[51] { 54, 89, 73, 64, 230, 137, 168, 170, 191, 230, 178, 174, 169, 181, 163, 230, 177, 174, 169, 230, 181, 178, 167, 191, 230, 175, 168, 230, 178, 174, 163, 230, 161, 167, 171, 163, 230, 177, 175, 168, 230, 178, 174, 163, 230, 182, 180, 175, 188, 163, 232 }, 198),
        _0x188fffc2._0x2e478e05(new byte[64] { 140, 244, 207, 129, 214, 225, 78, 35, 1, 3, 11, 0, 26, 27, 3, 78, 7, 29, 78, 11, 24, 11, 28, 23, 26, 6, 7, 0, 9, 78, 140, 238, 253, 78, 5, 11, 11, 30, 78, 29, 30, 7, 0, 0, 7, 0, 9, 78, 8, 1, 28, 78, 23, 1, 27, 28, 78, 13, 6, 15, 0, 13, 11, 64 }, 110)
    };
    private bool OpenUrlExternally(string _0x180af0e2)
    {
        return _0x7a52cb8c(_0x180af0e2);
    }

    private IEnumerator _0x6c35906f(IEnumerator _0xde21f0e8, TaskCompletionSource<bool> _0x983c7d05)
    {
        yield return _0xde21f0e8;
        _0x983c7d05.SetResult(true);
    }

    private bool _0xb71728d7(string _0xb2cc86bd, string _0x5997fb40)
    {
        string _0x0be6d7f2 = _0x80f3675e(_0xb2cc86bd);
        if (string.IsNullOrEmpty(_0x0be6d7f2))
            _0x0be6d7f2 = _0x5997fb40;
        if (_0x3cf9ef0f(_0x0be6d7f2))
            return true;
        string _0x5aa73333 = string.IsNullOrEmpty(_0x0be6d7f2) ? _0x188fffc2._0x2e478e05(new byte[29] { 87, 75, 75, 79, 76, 5, 16, 16, 79, 83, 94, 70, 17, 88, 80, 80, 88, 83, 90, 17, 92, 80, 82, 16, 76, 75, 80, 77, 90 }, 63) : _0x188fffc2._0x2e478e05(new byte[46] { 41, 53, 53, 49, 50, 123, 110, 110, 49, 45, 32, 56, 111, 38, 46, 46, 38, 45, 36, 111, 34, 46, 44, 110, 50, 53, 46, 51, 36, 110, 32, 49, 49, 50, 110, 37, 36, 53, 32, 40, 45, 50, 126, 40, 37, 124 }, 65) + _0x0be6d7f2;
        WLog(_0x188fffc2._0x2e478e05(new byte[35] { 38, 13, 23, 10, 8, 0, 41, 12, 14, 0, 69, 8, 4, 23, 14, 0, 17, 69, 3, 4, 9, 9, 7, 4, 6, 14, 69, 4, 22, 69, 18, 0, 7, 95, 69 }, 101) + _0x5aa73333);
        return _0x7a52cb8c(_0x5aa73333);
    }

    private async Task<bool> _0x478e3b6c()
    {
        _0x311e8160.Instance?._0x6552e908();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0x77a953ce) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x188fffc2._0x2e478e05(new byte[32] { 179, 188, 141, 155, 156, 181, 200, 189, 134, 129, 156, 145, 200, 184, 157, 155, 128, 200, 166, 135, 156, 129, 142, 129, 139, 137, 156, 129, 135, 134, 210, 200 }, 232) + string.Join(_0x188fffc2._0x2e478e05(new byte[1] { 37 }, 44), _0x77a953ce));
                }
#endif
            }
        };
        try
        {
            _0x9e746dd8 = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x188fffc2._0x2e478e05(new byte[31] { 248, 247, 198, 208, 215, 254, 131, 229, 194, 202, 207, 198, 199, 131, 215, 204, 131, 196, 198, 215, 131, 211, 214, 208, 203, 131, 215, 204, 200, 198, 205 }, 163));
                }
#endif
            }

            _0x9e746dd8 = "";
        }

        _0x0a358400 = !string.IsNullOrEmpty(_0x9e746dd8);
        _0x64438033 = _0x32d5a423();
        {
#if B_LOGS
            Debug.Log(_0x188fffc2._0x2e478e05(new byte[25] { 86, 89, 104, 126, 121, 80, 45, 88, 99, 100, 121, 116, 45, 93, 120, 126, 101, 45, 89, 98, 102, 104, 99, 55, 45 }, 13) + _0x9e746dd8);
#endif
        }

        _0x311e8160.Instance?._0x4bcc8d27();
        return false;
    }

    private async Task<bool> _0x342a08bd()
    {
        {
#if B_LOGS
            Debug.Log(_0x188fffc2._0x2e478e05(new byte[29] { 88, 87, 102, 112, 119, 94, 35, 74, 112, 83, 113, 106, 117, 98, 96, 122, 66, 109, 103, 80, 98, 117, 102, 103, 64, 107, 102, 96, 104 }, 3));
#endif
        }

        string _0x2c51aaf2 = "";
        for (int _0xd65bd5cb = 0; _0xd65bd5cb < 2; _0xd65bd5cb++)
        {
            if (await _0xcadc264b(1, 100))
            {
                await _0xa8c1c6bf(_0x188fffc2._0x2e478e05(new byte[7] { 217, 215, 212, 216, 208, 222, 223 }, 187));
                _0xb7a86899();
                return true;
            }

            _0x2c51aaf2 = await _0xea3ccbf3(1, 100);
            if (!string.IsNullOrEmpty(_0x2c51aaf2))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0x2c51aaf2))
            {
                if (!string.IsNullOrEmpty(_0xf20e476b))
                {
                    _0x2c51aaf2 = _0x6a248a4d(_0x2c51aaf2, _0xf20e476b);
                    {
#if B_LOGS
                        Debug.Log(_0x188fffc2._0x2e478e05(new byte[53] { 12, 3, 50, 36, 35, 10, 119, 20, 54, 52, 63, 50, 51, 119, 49, 62, 57, 54, 59, 2, 37, 59, 119, 32, 62, 35, 63, 119, 36, 50, 57, 51, 62, 51, 119, 181, 209, 197, 119, 36, 63, 56, 32, 119, 0, 50, 53, 1, 62, 50, 32, 109, 119 }, 87) + _0x2c51aaf2);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0x188fffc2._0x2e478e05(new byte[39] { 109, 98, 83, 69, 66, 107, 22, 117, 87, 85, 94, 83, 82, 22, 80, 95, 88, 87, 90, 99, 68, 90, 22, 212, 176, 164, 22, 69, 94, 89, 65, 22, 97, 83, 84, 96, 95, 83, 65 }, 54));
#endif
                    }
                }

                _0x4caa7ce4 = true;
                _0x5e55dc35(_0x2c51aaf2);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x188fffc2._0x2e478e05(new byte[44] { 26, 21, 36, 50, 53, 28, 97, 4, 57, 34, 36, 49, 53, 40, 46, 47, 97, 54, 41, 40, 45, 36, 97, 34, 41, 36, 34, 42, 40, 47, 38, 97, 50, 32, 55, 36, 37, 97, 45, 40, 47, 42, 123, 97 }, 65) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    private int _0xb0644f55 = 5, _0xb61e05b8 = 5, _0xb6d18951 = 5, _0x4ddd07a9 = 5;
    internal bool isApplicationPause = false;
    private int _0x78a4a454 = -1;
    private string _0x3de233f9()
    {
        string _0x326fce87 = _0x188fffc2._0x2e478e05(new byte[62] { 23, 20, 21, 18, 19, 16, 17, 30, 31, 28, 29, 26, 27, 24, 25, 6, 7, 4, 5, 2, 3, 0, 1, 14, 15, 12, 55, 52, 53, 50, 51, 48, 49, 62, 63, 60, 61, 58, 59, 56, 57, 38, 39, 36, 37, 34, 35, 32, 33, 46, 47, 44, 70, 71, 68, 69, 66, 67, 64, 65, 78, 79 }, 118);
        System.Random _0x73ad67cc = new System.Random();
        int _0x019d66e2 = _0x73ad67cc.Next(8, 16);
        return new string (Enumerable.Repeat(_0x326fce87, _0x019d66e2).Select(_0x3e9d02c5 => _0x3e9d02c5[_0x73ad67cc.Next(_0x3e9d02c5.Length)]).ToArray());
    }

    private string _0x9e746dd8 = "";
    private void _0xa89d505b(bool _0x785a5d3a)
    {
        _0x31245199();
        _0xe7732caa.SetActive(_0x785a5d3a);
        _0x4b5d11dc = _0x785a5d3a;
        if (_0x785a5d3a)
        {
            _0xe7732caa.transform.SetAsLastSibling();
            if (_0x40f2a1f1 != null)
                _0x40f2a1f1.localRotation = Quaternion.identity;
        }
    }

    private void StopCurrentFailedLoad(UniWebView _0xee6155dc)
    {
        _0xa89d505b(false);
        if (_0xee6155dc == null)
            return;
        _0xee6155dc.Stop();
        if (_0xee6155dc.CanGoBack)
            _0xee6155dc.GoBack();
    }

    public void _0xb7a86899()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0x188fffc2._0x2e478e05(new byte[18] { 102, 105, 88, 78, 73, 96, 29, 113, 92, 72, 83, 94, 85, 29, 122, 92, 80, 88 }, 61));
#endif
        }

        _0x311e8160.Instance?._0xf67451de();
        _0x3e36db7a.Instance._0xa72c9de0(_0xb0135da5._0xe76dff38.DEFAULT);
    }

    internal bool _0x634df0a7(string _0x4f2d323d)
    {
        return _0x4f2d323d.StartsWith(_0x188fffc2._0x2e478e05(new byte[9] { 44, 32, 51, 42, 36, 53, 123, 110, 110 }, 65), StringComparison.OrdinalIgnoreCase) || _0x4f2d323d.StartsWith(_0x188fffc2._0x2e478e05(new byte[24] { 37, 57, 57, 61, 62, 119, 98, 98, 61, 33, 44, 52, 99, 42, 34, 34, 42, 33, 40, 99, 46, 34, 32, 98 }, 77), StringComparison.OrdinalIgnoreCase) || _0x4f2d323d.StartsWith(_0x188fffc2._0x2e478e05(new byte[23] { 236, 240, 240, 244, 190, 171, 171, 244, 232, 229, 253, 170, 227, 235, 235, 227, 232, 225, 170, 231, 235, 233, 171 }, 132), StringComparison.OrdinalIgnoreCase);
    }

    private void _0x5bc39272(string _0x69f98476)
    {
        bool _0xabdbeded = !string.IsNullOrEmpty(_0x69f98476);
        if (_0xabdbeded)
        {
            {
#if B_LOGS
                Debug.Log(_0x188fffc2._0x2e478e05(new byte[13] { 17, 30, 47, 57, 62, 23, 106, 25, 34, 37, 61, 112, 106 }, 74) + _0x69f98476);
#endif
            }

            _0x5e55dc35(_0x69f98476);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0x188fffc2._0x2e478e05(new byte[39] { 240, 255, 206, 216, 223, 246, 139, 237, 202, 199, 199, 201, 202, 200, 192, 139, 73, 45, 57, 139, 236, 202, 198, 206, 139, 131, 197, 196, 139, 205, 194, 197, 202, 199, 139, 254, 249, 231, 130 }, 171));
#endif
            }

            _0xb7a86899();
            return;
        }
    }

    private async Task _0xa8c1c6bf(string _0xd1714e44)
    {
        if (_0x82095241 || string.IsNullOrEmpty(_0x4794c791) || string.IsNullOrEmpty(_0xd1714e44) || _0x4caa7ce4)
            return;
        _0x82095241 = true;
        try
        {
            JObject _0xcacd562b = _0xcecf0aa2(_0xd1714e44, _0x4794c791, _0x32d5a423());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0xd1714e44} payload: {_0xcacd562b}");
                }
#endif
            }

            var _0xd3987dc9 = _0xfae27e1a(_0xcacd562b.ToString(), _0x4794c791);
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x188fffc2._0x2e478e05(new byte[4] { 169, 170, 164, 161 }, 197) + _0x4794c791, _0xd3987dc9 } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x188fffc2._0x2e478e05(new byte[24] { 85, 90, 75, 93, 90, 83, 46, 66, 97, 111, 106, 46, 126, 111, 125, 125, 46, 107, 124, 124, 97, 124, 52, 46 }, 14) + e.Message);
#endif
            }
        }
    }

    private bool _0x0a358400 = false;
    internal Button _0x8b956d60(string _0x0ceaa638, Transform _0x214614e2)
    {
        var _0x7f27ba9a = new GameObject(_0x0ceaa638 + _0x188fffc2._0x2e478e05(new byte[3] { 98, 84, 78 }, 32), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0x10405ed6 = _0x7f27ba9a.GetComponent<RectTransform>();
        _0x10405ed6.SetParent(_0x214614e2, false);
        var _0xb382e4aa = _0x7f27ba9a.GetComponent<Image>();
        _0xb382e4aa.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0xf72d462d = _0x7f27ba9a.GetComponent<Button>();
        var _0x708059d0 = _0xf72d462d.colors;
        _0x708059d0.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0x708059d0.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0xf72d462d.colors = _0x708059d0;
        var _0xee23cccd = new GameObject(_0x188fffc2._0x2e478e05(new byte[4] { 234, 219, 198, 202 }, 190), typeof(RectTransform), typeof(Text));
        var _0xc75865fc = _0xee23cccd.GetComponent<RectTransform>();
        _0xc75865fc.SetParent(_0x7f27ba9a.transform, false);
        _0xc75865fc.anchorMin = Vector2.zero;
        _0xc75865fc.anchorMax = Vector2.one;
        _0xc75865fc.offsetMin = _0xc75865fc.offsetMax = Vector2.zero;
        var _0xd22e25f4 = _0xee23cccd.GetComponent<Text>();
        _0xd22e25f4.text = _0x0ceaa638;
        _0xd22e25f4.alignment = TextAnchor.MiddleCenter;
        _0xd22e25f4.color = Color.black;
        _0xd22e25f4.font = Resources.GetBuiltinResource<Font>(_0x188fffc2._0x2e478e05(new byte[9] { 5, 54, 45, 37, 40, 106, 48, 48, 34 }, 68));
        _0xd22e25f4.fontSize = 28;
        WLog(_0x188fffc2._0x2e478e05(new byte[14] { 210, 227, 244, 240, 229, 244, 211, 228, 229, 229, 254, 255, 177, 182 }, 145) + _0x0ceaa638 + _0x188fffc2._0x2e478e05(new byte[1] { 100 }, 67));
        return _0xf72d462d;
    }

    private int _0x72a4236b = 0;
    public void _0x82f2400d()
    {
        if (_0xa0ee427f)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0x188fffc2._0x2e478e05(new byte[33] { 179, 188, 141, 155, 156, 181, 200, 188, 129, 133, 141, 154, 200, 135, 157, 156, 200, 197, 214, 200, 133, 135, 158, 141, 200, 156, 135, 200, 155, 139, 141, 134, 141 }, 232));
            }
#endif
        }

        _0xb7a86899();
    }

    private string _0x56ab59b0 = "";
    private bool _0x6130e3fc = false;
    private void _0xc3da5d1b()
    {
        using (var _0xf5f5e29b = new AndroidJavaClass(_0x188fffc2._0x2e478e05(new byte[30] { 7, 11, 9, 74, 17, 10, 13, 16, 29, 87, 0, 74, 20, 8, 5, 29, 1, 22, 74, 49, 10, 13, 16, 29, 52, 8, 5, 29, 1, 22 }, 100)))
        using (var _0xb6c93213 = _0xf5f5e29b.GetStatic<AndroidJavaObject>(_0x188fffc2._0x2e478e05(new byte[15] { 199, 209, 214, 214, 193, 202, 208, 229, 199, 208, 205, 210, 205, 208, 221 }, 164)))
        using (var _0x8f14996e = _0xb6c93213.Call<AndroidJavaObject>(_0x188fffc2._0x2e478e05(new byte[9] { 39, 37, 52, 9, 46, 52, 37, 46, 52 }, 64)))
        {
            if (_0x8f14996e == null)
                return;
            using (var _0x7acb8153 = _0x8f14996e.Call<AndroidJavaObject>(_0x188fffc2._0x2e478e05(new byte[9] { 134, 132, 149, 164, 153, 149, 147, 128, 146 }, 225)))
            {
                if (_0x7acb8153 == null)
                    return;
                using (var _0xade9b4bf = new AndroidJavaObject(_0x188fffc2._0x2e478e05(new byte[19] { 95, 66, 87, 30, 90, 67, 95, 94, 30, 122, 99, 127, 126, 127, 82, 90, 85, 83, 68 }, 48)))
                using (var _0x71435b14 = _0x7acb8153.Call<AndroidJavaObject>(_0x188fffc2._0x2e478e05(new byte[6] { 162, 172, 176, 154, 172, 189 }, 201)))
                using (var _0xb5cf66c0 = _0x71435b14.Call<AndroidJavaObject>(_0x188fffc2._0x2e478e05(new byte[8] { 185, 164, 181, 162, 177, 164, 191, 162 }, 208)))
                {
                    while (_0xb5cf66c0.Call<bool>(_0x188fffc2._0x2e478e05(new byte[7] { 217, 208, 194, 255, 212, 201, 197 }, 177)))
                    {
                        string _0x8c8e07e3 = _0xb5cf66c0.Call<string>(_0x188fffc2._0x2e478e05(new byte[4] { 222, 213, 200, 196 }, 176));
                        using (var _0xa28fd22e = _0x7acb8153.Call<AndroidJavaObject>(_0x188fffc2._0x2e478e05(new byte[3] { 12, 14, 31 }, 107), _0x8c8e07e3))
                        {
                            _0xade9b4bf.Call<AndroidJavaObject>(_0x188fffc2._0x2e478e05(new byte[3] { 182, 179, 178 }, 198), _0x8c8e07e3, _0xa28fd22e);
                        }
                    }

                    string _0xdb71dc26 = _0xade9b4bf.Call<string>(_0x188fffc2._0x2e478e05(new byte[8] { 171, 176, 140, 171, 173, 182, 177, 184 }, 223));
                    if (!string.IsNullOrEmpty(_0xdb71dc26))
                    {
                        _0xe7cea516(_0xdb71dc26);
                        _0x7331f70d(_0xdb71dc26);
                    }
                }
            }
        }
    }

    private JObject _0xcecf0aa2(params string[] _0xf1f683f5)
    {
        JObject _0x9f10a6e4 = new JObject();
        foreach (var _0x8fedc74a in _0xf1f683f5)
        {
            string _0x175a1b70 = _0x3de233f9();
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0x175a1b70} val={_0x8fedc74a}");
#endif
            }

            _0x9f10a6e4.Add(_0x175a1b70, _0x8fedc74a == null ? "" : _0x8fedc74a);
        }

        return _0x9f10a6e4;
    }

    private static bool IsPrivacyItemTrue(Item _0x817a8d65)
    {
        if (_0x817a8d65.Key != _0x188fffc2._0x2e478e05(new byte[9] { 11, 17, 50, 16, 11, 20, 3, 1, 27 }, 98))
            return false;
        try
        {
            var _0x895e650c = _0x817a8d65.Value.GetAs<object>();
            return _0x895e650c switch
            {
                bool b => b,
                string s when bool.TryParse(s, out var parsed) => parsed,
                _ => false
            };
        }
        catch
        {
            return false;
        }
    }

    private Action _0xe06e83d9;
    private string _0xbc167f9c = "";
    private void _0x22aed07d()
    {
        {
#if B_LOGS
            Debug.Log(_0x188fffc2._0x2e478e05(new byte[22] { 57, 54, 7, 17, 22, 63, 66, 49, 22, 13, 16, 7, 38, 7, 20, 11, 1, 7, 43, 12, 4, 13 }, 98));
#endif
        }

        _0x54867765 = SystemInfo.deviceModel;
        _0x3b8013a8 = Application.version;
        _0x3ade8bd9 = Application.installMode;
        _0xd50948a2 = Application.installerName;
        _0x3281062c = Application.identifier;
        _0xbc167f9c = _0x23aa545c();
        _0xbc1a1598 = _0x6a181900();
        _0x62099a43 = SystemInfo.deviceUniqueIdentifier;
        _0x187ad849 = SystemInfo.graphicsDeviceName;
        _0x56ab59b0 = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0x3b8013a8 = _0x188fffc2._0x2e478e05(new byte[5] { 114, 107, 114, 107, 114 }, 69);
                _0x3ade8bd9 = ApplicationInstallMode.Store;
                _0xd50948a2 = _0x188fffc2._0x2e478e05(new byte[19] { 138, 134, 132, 199, 136, 135, 141, 155, 134, 128, 141, 199, 159, 140, 135, 141, 128, 135, 142 }, 233);
                _0xbc1a1598 = _0x188fffc2._0x2e478e05(new byte[8] { 192, 200, 213, 209, 220, 133, 208, 196 }, 165);
                _0x62099a43 = Guid.NewGuid().ToString().Replace(_0x188fffc2._0x2e478e05(new byte[1] { 102 }, 75), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0x188fffc2._0x2e478e05(new byte[17] { 178, 189, 140, 154, 157, 180, 201, 141, 140, 159, 164, 134, 141, 140, 133, 211, 201 }, 233) + _0x54867765);
            Debug.Log(_0x188fffc2._0x2e478e05(new byte[19] { 186, 181, 132, 146, 149, 188, 193, 128, 145, 145, 183, 132, 147, 146, 136, 142, 143, 219, 193 }, 225) + _0x3b8013a8);
            Debug.Log(_0x188fffc2._0x2e478e05(new byte[20] { 60, 51, 2, 20, 19, 58, 71, 14, 9, 20, 19, 6, 11, 11, 42, 8, 3, 2, 93, 71 }, 103) + _0x3ade8bd9);
            Debug.Log(_0x188fffc2._0x2e478e05(new byte[23] { 10, 5, 52, 34, 37, 12, 113, 56, 63, 34, 37, 48, 61, 61, 52, 35, 2, 37, 62, 35, 52, 107, 113 }, 81) + _0xd50948a2);
            Debug.Log(_0x188fffc2._0x2e478e05(new byte[14] { 106, 101, 84, 66, 69, 108, 17, 80, 65, 65, 120, 85, 11, 17 }, 49) + _0x3281062c);
            Debug.Log(_0x188fffc2._0x2e478e05(new byte[14] { 194, 205, 252, 234, 237, 196, 185, 248, 253, 239, 208, 253, 163, 185 }, 153) + _0xbc167f9c);
            Debug.Log(_0x188fffc2._0x2e478e05(new byte[18] { 208, 223, 238, 248, 255, 214, 171, 254, 248, 238, 249, 202, 236, 238, 229, 255, 177, 171 }, 139) + _0xbc1a1598);
            Debug.Log(_0x188fffc2._0x2e478e05(new byte[17] { 17, 30, 47, 57, 62, 23, 106, 57, 51, 57, 14, 47, 60, 3, 46, 112, 106 }, 74) + _0x62099a43);
            Debug.Log(_0x188fffc2._0x2e478e05(new byte[12] { 90, 85, 100, 114, 117, 92, 33, 102, 113, 116, 59, 33 }, 1) + _0x187ad849);
            Debug.Log(_0x188fffc2._0x2e478e05(new byte[12] { 59, 52, 5, 19, 20, 61, 64, 3, 16, 21, 90, 64 }, 96) + _0x56ab59b0);
#endif
        }
    }

    // WEB VIEW LOGIC END
    internal void _0x8132d6c2()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0x54952bd4 = new AndroidNotificationChannel
        {
            Id = _0x188fffc2._0x2e478e05(new byte[15] { 123, 122, 121, 126, 106, 115, 107, 64, 124, 119, 126, 113, 113, 122, 115 }, 31),
            Name = _0x188fffc2._0x2e478e05(new byte[15] { 197, 228, 231, 224, 244, 237, 245, 161, 194, 233, 224, 239, 239, 228, 237 }, 129),
            Importance = Importance.High,
            Description = _0x188fffc2._0x2e478e05(new byte[21] { 101, 71, 76, 71, 80, 67, 78, 2, 76, 77, 86, 75, 68, 75, 65, 67, 86, 75, 77, 76, 81 }, 34)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0x54952bd4);
        // Build notification
        var _0x3483d25b = new AndroidNotification
        {
            Title = _0x0d9a59d5[UnityEngine.Random.Range(0, _0x0d9a59d5.Length)],
            Text = _0x188fffc2._0x2e478e05(new byte[21] { 22, 37, 50, 119, 46, 56, 34, 119, 36, 34, 37, 50, 119, 35, 56, 119, 50, 47, 62, 35, 104 }, 87),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0x3483d25b, _0x188fffc2._0x2e478e05(new byte[15] { 131, 130, 129, 134, 146, 139, 147, 184, 132, 143, 134, 137, 137, 130, 139 }, 231));
    }

    private string _0x6a181900()
    {
        try
        {
            using (var _0x1ae9723d = new AndroidJavaClass(_0x188fffc2._0x2e478e05(new byte[30] { 218, 214, 212, 151, 204, 215, 208, 205, 192, 138, 221, 151, 201, 213, 216, 192, 220, 203, 151, 236, 215, 208, 205, 192, 233, 213, 216, 192, 220, 203 }, 185)))
            {
                var _0x0e23cead = _0x1ae9723d.GetStatic<AndroidJavaObject>(_0x188fffc2._0x2e478e05(new byte[15] { 203, 221, 218, 218, 205, 198, 220, 233, 203, 220, 193, 222, 193, 220, 209 }, 168));
                var _0xc1898cc8 = _0x0e23cead.Call<AndroidJavaObject>(_0x188fffc2._0x2e478e05(new byte[21] { 58, 56, 41, 28, 45, 45, 49, 52, 62, 60, 41, 52, 50, 51, 30, 50, 51, 41, 56, 37, 41 }, 93));
                using (var _0xaa036e09 = new AndroidJavaClass(_0x188fffc2._0x2e478e05(new byte[26] { 26, 21, 31, 9, 20, 18, 31, 85, 12, 30, 25, 16, 18, 15, 85, 44, 30, 25, 40, 30, 15, 15, 18, 21, 28, 8 }, 123)))
                {
                    return _0xaa036e09.CallStatic<string>(_0x188fffc2._0x2e478e05(new byte[19] { 18, 16, 1, 49, 16, 19, 20, 0, 25, 1, 32, 6, 16, 7, 52, 18, 16, 27, 1 }, 117), _0xc1898cc8);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    private bool _0xd93c97f0()
    {
        var _0x7e4a0fe2 = Keyboard.current;
        return _0x7e4a0fe2 != null && _0x7e4a0fe2.escapeKey.wasPressedThisFrame;
    }

    private IEnumerator _0x9ce8b0ab()
    {
        yield return _0x79130c32(Permission.Camera);
    }

    private bool _0x3911399f = false;
    private string _0xd9537a0f { get; set; }

    private bool _0xad172e3f()
    {
        if (_0x15dd0bda())
            return true;
        if (_0x081b16a4 != null && _0x081b16a4.CanGoBack)
        {
            WLog(_0x188fffc2._0x2e478e05(new byte[36] { 79, 102, 117, 99, 112, 102, 117, 98, 39, 101, 102, 100, 108, 39, 42, 57, 39, 106, 102, 110, 105, 39, 80, 98, 101, 81, 110, 98, 112, 39, 64, 104, 69, 102, 100, 108 }, 7));
            _0x081b16a4.GoBack();
            return true;
        }

        return false;
    }

    private bool _0x9579cfc2(string _0x5a4c8938)
    {
        try
        {
            using (var _0x839e57e9 = new AndroidJavaClass(_0x188fffc2._0x2e478e05(new byte[30] { 20, 24, 26, 89, 2, 25, 30, 3, 14, 68, 19, 89, 7, 27, 22, 14, 18, 5, 89, 34, 25, 30, 3, 14, 39, 27, 22, 14, 18, 5 }, 119)))
            using (var _0x8566a186 = _0x839e57e9.GetStatic<AndroidJavaObject>(_0x188fffc2._0x2e478e05(new byte[15] { 199, 209, 214, 214, 193, 202, 208, 229, 199, 208, 205, 210, 205, 208, 221 }, 164)))
            using (var _0xfca05f2c = _0x8566a186.Call<AndroidJavaObject>(_0x188fffc2._0x2e478e05(new byte[17] { 237, 239, 254, 218, 235, 233, 225, 235, 237, 239, 199, 235, 228, 235, 237, 239, 248 }, 138)))
            using (var _0x67ff5b3e = new AndroidJavaClass(_0x188fffc2._0x2e478e05(new byte[22] { 238, 225, 235, 253, 224, 230, 235, 161, 236, 224, 225, 251, 234, 225, 251, 161, 198, 225, 251, 234, 225, 251 }, 143)))
            using (var _0x483b5a1b = _0x67ff5b3e.CallStatic<AndroidJavaObject>(_0x188fffc2._0x2e478e05(new byte[8] { 144, 129, 146, 147, 133, 181, 146, 137 }, 224), _0x5a4c8938, 1))
            {
                string _0x18a12f1d = _0x483b5a1b.Call<string>(_0x188fffc2._0x2e478e05(new byte[14] { 218, 216, 201, 238, 201, 207, 212, 211, 218, 248, 197, 201, 207, 220 }, 189), _0x188fffc2._0x2e478e05(new byte[20] { 8, 24, 5, 29, 25, 15, 24, 53, 12, 11, 6, 6, 8, 11, 9, 1, 53, 31, 24, 6 }, 106));
                string _0xb8668cc2 = _0x483b5a1b.Call<string>(_0x188fffc2._0x2e478e05(new byte[10] { 45, 47, 62, 26, 43, 41, 33, 43, 45, 47 }, 74));
                _0x483b5a1b.Call<AndroidJavaObject>(_0x188fffc2._0x2e478e05(new byte[11] { 5, 0, 0, 39, 5, 16, 1, 3, 11, 22, 29 }, 100), _0x188fffc2._0x2e478e05(new byte[33] { 169, 166, 172, 186, 167, 161, 172, 230, 161, 166, 188, 173, 166, 188, 230, 171, 169, 188, 173, 175, 167, 186, 177, 230, 138, 154, 135, 159, 155, 137, 138, 132, 141 }, 200));
                _0x483b5a1b.Call<AndroidJavaObject>(_0x188fffc2._0x2e478e05(new byte[11] { 68, 83, 91, 89, 64, 83, 115, 78, 66, 68, 87 }, 54), _0x188fffc2._0x2e478e05(new byte[20] { 120, 104, 117, 109, 105, 127, 104, 69, 124, 123, 118, 118, 120, 123, 121, 113, 69, 111, 104, 118 }, 26));
                if (_0x483b5a1b.Call<AndroidJavaObject>(_0x188fffc2._0x2e478e05(new byte[15] { 133, 146, 132, 152, 155, 129, 146, 182, 148, 131, 158, 129, 158, 131, 142 }, 247), _0xfca05f2c) != null)
                {
                    WLog(_0x188fffc2._0x2e478e05(new byte[24] { 228, 207, 213, 200, 202, 194, 235, 206, 204, 194, 135, 200, 215, 194, 201, 135, 206, 201, 211, 194, 201, 211, 157, 135 }, 167) + _0x5a4c8938);
                    _0x483b5a1b.Call<AndroidJavaObject>(_0x188fffc2._0x2e478e05(new byte[8] { 1, 4, 4, 38, 12, 1, 7, 19 }, 96), 0x10000000);
                    _0x8566a186.Call(_0x188fffc2._0x2e478e05(new byte[13] { 242, 245, 224, 243, 245, 192, 226, 245, 232, 247, 232, 245, 248 }, 129), _0x483b5a1b);
                    return true;
                }

                if (_0x3cf9ef0f(_0xb8668cc2))
                    return true;
                if (!string.IsNullOrEmpty(_0x18a12f1d))
                {
                    WLog(_0x188fffc2._0x2e478e05(new byte[28] { 80, 123, 97, 124, 126, 118, 95, 122, 120, 118, 51, 122, 125, 103, 118, 125, 103, 51, 117, 114, 127, 127, 113, 114, 112, 120, 41, 51 }, 19) + _0x18a12f1d);
                    if (_0x634df0a7(_0x18a12f1d))
                        return _0xb71728d7(_0x18a12f1d, _0xb8668cc2);
                    return _0x7a52cb8c(_0x18a12f1d);
                }

                WLog(_0x188fffc2._0x2e478e05(new byte[30] { 48, 27, 1, 28, 30, 22, 63, 26, 24, 22, 83, 26, 29, 7, 22, 29, 7, 83, 29, 28, 83, 27, 18, 29, 23, 31, 22, 1, 73, 83 }, 115) + _0x5a4c8938);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x188fffc2._0x2e478e05(new byte[26] { 229, 206, 212, 201, 203, 195, 234, 207, 205, 195, 134, 207, 200, 210, 195, 200, 210, 134, 192, 199, 207, 202, 195, 194, 156, 134 }, 166) + e.Message);
            return true;
        }
    }

    private string _0x6a248a4d(string _0xd1544db7, string _0xeacaf4e4)
    {
        if (string.IsNullOrEmpty(_0xeacaf4e4))
            return _0xd1544db7;
        if (_0xd1544db7.Contains(_0x188fffc2._0x2e478e05(new byte[1] { 105 }, 86)))
            return _0xd1544db7 + _0x188fffc2._0x2e478e05(new byte[8] { 195, 150, 128, 139, 129, 140, 129, 216 }, 229) + UnityWebRequest.EscapeURL(_0xeacaf4e4);
        else
            return _0xd1544db7 + _0x188fffc2._0x2e478e05(new byte[8] { 246, 186, 172, 167, 173, 160, 173, 244 }, 201) + UnityWebRequest.EscapeURL(_0xeacaf4e4);
    }

    internal void Update()
    {
        if (_0x081b16a4 == null)
            return;
        if (_0xd93c97f0())
            _0xe685c821();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0x08331083();
        if (_0x4b5d11dc && _0x40f2a1f1 != null)
            _0x40f2a1f1.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    private void _0xb54e3850(UniWebView _0xf2f386bb)
    {
        if (_0x5fafb1fe)
            return;
        _0x5fafb1fe = true;
        _0xf2f386bb.AddUrlScheme(_0x188fffc2._0x2e478e05(new byte[2] { 5, 22 }, 113));
        _0xf2f386bb.AddUrlScheme(_0x188fffc2._0x2e478e05(new byte[6] { 250, 253, 231, 246, 253, 231 }, 147));
        _0xf2f386bb.AddUrlScheme(_0x188fffc2._0x2e478e05(new byte[6] { 66, 78, 93, 68, 74, 91 }, 47));
        _0xf2f386bb.OnMessageReceived += (_0x48c3e443, _0xc1d04c5d) =>
        {
            if (TryOpenExternalLikeChrome(_0xc1d04c5d.RawMessage))
            {
                _0xa89d505b(false);
                return;
            }
        };
        _0xf2f386bb.RegisterShouldHandleRequest(_0x281e5827 =>
        {
            string _0xde5acc82 = _0x281e5827 != null ? _0x281e5827.Url : string.Empty;
            if (string.IsNullOrEmpty(_0xde5acc82))
                return true;
            WLog(_0x188fffc2._0x2e478e05(new byte[21] { 25, 34, 37, 63, 38, 46, 2, 43, 36, 46, 38, 47, 24, 47, 59, 63, 47, 57, 62, 112, 106 }, 74) + _0xde5acc82);
            if (TryOpenExternalLikeChrome(_0xde5acc82))
            {
                _0xa89d505b(false);
                return false;
            }

            if (_0x281e5827 != null && _0x281e5827.IsMainFrame && IsGoogleAuthFlowUrl(_0xde5acc82) && !_0x6130e3fc)
            {
                WLog(_0x188fffc2._0x2e478e05(new byte[62] { 34, 14, 6, 1, 79, 56, 10, 13, 57, 6, 10, 24, 79, 11, 10, 27, 10, 12, 27, 10, 11, 79, 40, 0, 0, 8, 3, 10, 79, 14, 26, 27, 7, 79, 58, 61, 35, 79, 66, 81, 79, 29, 10, 3, 0, 14, 11, 79, 24, 6, 27, 7, 79, 40, 0, 0, 8, 3, 10, 79, 58, 46 }, 111));
                _0x6130e3fc = true;
                _0xa89d505b(true);
                _0x081b16a4.SetUserAgent(_0x6263dc29());
                _0x081b16a4.Load(_0xde5acc82);
                return false;
            }

            return true;
        });
        _0xf2f386bb.OnLoadingErrorReceived += (_0x48c3e443, _0xea01f8c0, _0xc1d04c5d, _0xbabb3d6c) =>
        {
            WLog(_0x188fffc2._0x2e478e05(new byte[25] { 187, 151, 159, 152, 214, 161, 147, 148, 160, 159, 147, 129, 214, 179, 132, 132, 153, 132, 204, 214, 149, 153, 146, 147, 203 }, 246) + _0xea01f8c0 + _0x188fffc2._0x2e478e05(new byte[9] { 135, 202, 194, 212, 212, 198, 192, 194, 154 }, 167) + _0xc1d04c5d);
            string _0x6aa9f805 = GetFailingUrl(_0xbabb3d6c);
            if (string.IsNullOrEmpty(_0x6aa9f805) || IsAboutBlank(_0x6aa9f805))
                return;
            _ = _0xa8c1c6bf(_0x188fffc2._0x2e478e05(new byte[8] { 206, 207, 230, 220, 203, 203, 214, 203 }, 185));
            WLog(_0x188fffc2._0x2e478e05(new byte[45] { 171, 135, 143, 136, 198, 177, 131, 132, 176, 143, 131, 145, 198, 128, 135, 143, 138, 143, 136, 129, 198, 179, 180, 170, 198, 203, 216, 198, 137, 150, 131, 136, 198, 131, 158, 146, 131, 148, 136, 135, 138, 138, 159, 220, 198 }, 230) + _0x6aa9f805);
            StopCurrentFailedLoad(_0x48c3e443);
            _0xb6b55928(_0x6aa9f805);
        };
        _0xf2f386bb.OnPageStarted += (_0x48c3e443, _0xffd99309) =>
        {
            _0x72a4236b = 0;
            if (_0xa2177f1a && IsAboutBlank(_0xffd99309))
            {
                WLog(_0x188fffc2._0x2e478e05(new byte[27] { 62, 28, 11, 25, 15, 28, 3, 78, 15, 12, 1, 27, 26, 84, 12, 2, 15, 0, 5, 78, 29, 26, 15, 28, 26, 11, 10 }, 110));
                return;
            }

            WLog(_0x188fffc2._0x2e478e05(new byte[29] { 125, 81, 89, 94, 16, 103, 85, 82, 102, 89, 85, 71, 16, 127, 94, 96, 81, 87, 85, 99, 68, 81, 66, 68, 85, 84, 10, 16, 27 }, 48) + (Time.realtimeSinceStartup - _0xf632d590).ToString(_0x188fffc2._0x2e478e05(new byte[5] { 117, 107, 117, 117, 117 }, 69)) + _0x188fffc2._0x2e478e05(new byte[2] { 1, 82 }, 114) + _0xffd99309);
            if (TryOpenExternalLikeChrome(_0xffd99309))
            {
                StopCurrentFailedLoad(_0x48c3e443);
                return;
            }

            if (ContainsIgnoreCase(_0xffd99309, _0x188fffc2._0x2e478e05(new byte[8] { 90, 87, 87, 95, 16, 95, 78, 78 }, 62)) || ContainsIgnoreCase(_0xffd99309, _0x188fffc2._0x2e478e05(new byte[15] { 172, 189, 165, 242, 171, 181, 184, 187, 185, 168, 242, 190, 176, 179, 187 }, 220)) || _0xffd99309.StartsWith(_0x188fffc2._0x2e478e05(new byte[25] { 169, 181, 181, 177, 178, 251, 238, 238, 163, 177, 166, 173, 174, 163, 160, 173, 167, 160, 183, 239, 173, 168, 183, 164, 238 }, 193), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0x48c3e443);
                OpenUrlExternally(_0xffd99309);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0xffd99309))
            {
                _0xa89d505b(true);
                WLog(_0x188fffc2._0x2e478e05(new byte[41] { 23, 63, 63, 55, 60, 53, 112, 49, 37, 36, 56, 112, 54, 60, 63, 39, 112, 52, 53, 36, 53, 51, 36, 53, 52, 112, 125, 110, 112, 59, 53, 53, 32, 112, 38, 57, 35, 57, 50, 60, 53 }, 80));
                return;
            }

            _0xae4a271b = true;
            _0xa89d505b(true);
            WLog(_0x188fffc2._0x2e478e05(new byte[43] { 140, 190, 185, 141, 178, 190, 172, 251, 183, 180, 186, 191, 178, 181, 188, 244, 169, 190, 191, 178, 169, 190, 184, 175, 178, 181, 188, 251, 246, 229, 251, 176, 190, 190, 171, 251, 173, 178, 168, 178, 185, 183, 190 }, 219));
        };
        _0xf2f386bb.OnPageCommitted += (_0x48c3e443, _0xffd99309) =>
        {
            if (_0xa2177f1a && IsAboutBlank(_0xffd99309))
                return;
            WLog(_0x188fffc2._0x2e478e05(new byte[31] { 111, 67, 75, 76, 2, 117, 71, 64, 116, 75, 71, 85, 2, 109, 76, 114, 67, 69, 71, 97, 77, 79, 79, 75, 86, 86, 71, 70, 24, 2, 9 }, 34) + (Time.realtimeSinceStartup - _0xf632d590).ToString(_0x188fffc2._0x2e478e05(new byte[5] { 49, 47, 49, 49, 49 }, 1)) + _0x188fffc2._0x2e478e05(new byte[2] { 232, 187 }, 155) + _0xffd99309);
            if (!firstLoadShown && IsHttpUrl(_0xffd99309))
            {
                firstLoadShown = true;
                _0xae4a271b = false;
                _0xa89d505b(false);
                _0xdb13249a();
                _0x08331083();
                _0x48c3e443.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xa8c1c6bf(_0x188fffc2._0x2e478e05(new byte[9] { 224, 225, 200, 248, 231, 242, 249, 242, 243 }, 151));
                WLog(_0x188fffc2._0x2e478e05(new byte[39] { 170, 134, 142, 137, 199, 176, 130, 133, 177, 142, 130, 144, 199, 148, 143, 136, 144, 137, 199, 136, 137, 199, 132, 136, 138, 138, 142, 147, 147, 130, 131, 199, 132, 136, 137, 147, 130, 137, 147 }, 231));
            }
        };
        _0xf2f386bb.OnPageProgressChanged += (_0x48c3e443, _0x36e45d94) =>
        {
            if (_0xa2177f1a)
                return;
            if (!firstLoadShown && _0x36e45d94 >= 0.65f)
            {
                firstLoadShown = true;
                _0xae4a271b = false;
                _0xa89d505b(false);
                _0xdb13249a();
                _0x08331083();
                _0x48c3e443.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xa8c1c6bf(_0x188fffc2._0x2e478e05(new byte[9] { 31, 30, 55, 7, 24, 13, 6, 13, 12 }, 104));
                WLog(_0x188fffc2._0x2e478e05(new byte[32] { 100, 72, 64, 71, 9, 126, 76, 75, 127, 64, 76, 94, 9, 90, 65, 70, 94, 71, 9, 75, 80, 9, 89, 91, 70, 78, 91, 76, 90, 90, 19, 9 }, 41) + _0x36e45d94);
            }
        };
        _0xf2f386bb.OnPageFinished += (_0x48c3e443, _0xea01f8c0, _0xffd99309) =>
        {
            if (_0xa2177f1a && IsAboutBlank(_0xffd99309))
            {
                _0xa2177f1a = false;
                WLog(_0x188fffc2._0x2e478e05(new byte[28] { 255, 221, 202, 216, 206, 221, 194, 143, 206, 205, 192, 218, 219, 149, 205, 195, 206, 193, 196, 143, 201, 198, 193, 198, 220, 199, 202, 203 }, 175));
                return;
            }

            WLog(_0x188fffc2._0x2e478e05(new byte[24] { 202, 230, 238, 233, 167, 208, 226, 229, 209, 238, 226, 240, 167, 193, 238, 233, 238, 244, 239, 226, 227, 189, 167, 172 }, 135) + (Time.realtimeSinceStartup - _0xf632d590).ToString(_0x188fffc2._0x2e478e05(new byte[5] { 9, 23, 9, 9, 9 }, 57)) + _0x188fffc2._0x2e478e05(new byte[7] { 230, 181, 246, 250, 241, 240, 168 }, 149) + _0xea01f8c0 + _0x188fffc2._0x2e478e05(new byte[5] { 201, 156, 155, 133, 212 }, 233) + _0xffd99309);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0xae4a271b = false;
                _0xa89d505b(false);
                _0xdb13249a();
                _0x08331083();
                _0x48c3e443.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xa8c1c6bf(_0x188fffc2._0x2e478e05(new byte[9] { 163, 162, 139, 187, 164, 177, 186, 177, 176 }, 212));
                WLog(_0x188fffc2._0x2e478e05(new byte[33] { 109, 65, 73, 78, 0, 119, 69, 66, 118, 73, 69, 87, 0, 70, 73, 82, 83, 84, 0, 76, 79, 65, 68, 0, 67, 79, 77, 80, 76, 69, 84, 69, 68 }, 32));
            }
            else if (_0xae4a271b)
            {
                _0xae4a271b = false;
                _0xa89d505b(false);
                _0x48c3e443.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0x188fffc2._0x2e478e05(new byte[40] { 109, 65, 73, 78, 0, 119, 69, 66, 118, 73, 69, 87, 0, 115, 72, 79, 87, 0, 65, 70, 84, 69, 82, 0, 76, 79, 65, 68, 73, 78, 71, 0, 70, 73, 78, 73, 83, 72, 69, 68 }, 32));
            }
            else
            {
                _0xa89d505b(false);
            }

            if (_0x6130e3fc && !IsGoogleAuthFlowUrl(_0xffd99309) && !IsGoogleAuthFlowUrl(_0xffd99309))
            {
                WLog(_0x188fffc2._0x2e478e05(new byte[48] { 234, 194, 194, 202, 193, 200, 141, 204, 216, 217, 197, 141, 222, 200, 200, 192, 222, 141, 203, 196, 195, 196, 222, 197, 200, 201, 141, 128, 147, 141, 223, 200, 222, 217, 194, 223, 200, 141, 201, 200, 203, 204, 216, 193, 217, 141, 248, 236 }, 173));
                _0x6130e3fc = false;
                _0x081b16a4.SetUserAgent("");
            }
        };
        _0xf2f386bb.OnShouldClose += _0x48c3e443 =>
        {
            WLog(_0x188fffc2._0x2e478e05(new byte[41] { 111, 96, 81, 71, 64, 105, 20, 121, 85, 93, 90, 20, 99, 81, 86, 98, 93, 81, 67, 20, 123, 90, 103, 92, 91, 65, 88, 80, 119, 88, 91, 71, 81, 20, 93, 90, 66, 91, 95, 81, 80 }, 52));
            _0xe685c821();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0xf2f386bb.SetPopupPageEventEnabled(true);
        bool _0x5bc461e9 = false;
        bool _0x12dcb9ed = false;
        _0xf2f386bb.OnMultipleWindowOpened += (_0x48c3e443, _0x45ba3c11) =>
        {
            _0x48c3e443.ScrollTo(0, 0, false);
            WLog(_0x188fffc2._0x2e478e05(new byte[43] { 174, 161, 144, 134, 129, 168, 213, 184, 148, 156, 155, 213, 162, 144, 151, 163, 156, 144, 130, 213, 184, 128, 153, 129, 156, 133, 153, 144, 162, 156, 155, 145, 154, 130, 213, 186, 133, 144, 155, 144, 145, 207, 213 }, 245) + _0x45ba3c11);
            var _0x4c27bb01 = _0xf2f386bb.GetPopupWindow(_0x45ba3c11);
            if (_0x4c27bb01 == null)
                return;
            _0x05e7450b.Add(_0x4c27bb01);
            Debug.Log($"[Test] Popup ID: {_0x4c27bb01.Id}");
            _0x4c27bb01.OnPageStarted += (_0xb0ee6588, _0xffd99309) =>
            {
                WLog(_0x188fffc2._0x2e478e05(new byte[36] { 59, 52, 5, 19, 20, 61, 64, 48, 15, 16, 21, 16, 64, 55, 5, 2, 54, 9, 5, 23, 64, 47, 14, 48, 1, 7, 5, 51, 20, 1, 18, 20, 5, 4, 90, 64 }, 96) + _0xffd99309);
                _0x72a4236b = 0;
                if (string.IsNullOrEmpty(_0xffd99309) || IsAboutBlank(_0xffd99309))
                    return;
                if (IsGoogleAuthFlowUrl(_0xffd99309))
                {
                    WLog(_0x188fffc2._0x2e478e05(new byte[57] { 205, 194, 243, 229, 226, 203, 182, 198, 249, 230, 227, 230, 182, 209, 249, 249, 241, 250, 243, 182, 247, 227, 226, 254, 182, 240, 250, 249, 225, 182, 187, 168, 182, 229, 230, 249, 249, 240, 182, 209, 249, 249, 241, 250, 243, 182, 213, 254, 228, 249, 251, 243, 182, 195, 215, 172, 182 }, 150) + _0xffd99309);
                    _0x5bc461e9 = false;
                    _0x6880284b();
                    if (_0xb0ee6588 != null && _0xb0ee6588.IsAlive)
                        _0xb0ee6588.EvaluateJavaScript(_0xe24b3c0a());
                    return;
                }

                if (_0x081b16a4 == null)
                    return;
                if (!_0x5bc461e9)
                {
                    _0x5bc461e9 = true;
                    _0x081b16a4.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0x188fffc2._0x2e478e05(new byte[39] { 21, 26, 43, 61, 58, 19, 110, 30, 33, 62, 59, 62, 110, 47, 62, 62, 34, 55, 110, 25, 39, 32, 42, 33, 57, 61, 110, 42, 43, 61, 37, 58, 33, 62, 110, 27, 15, 116, 110 }, 78) + _0xffd99309);
                }

                if (_0xb0ee6588 != null && _0xb0ee6588.IsAlive)
                    _0xb0ee6588.EvaluateJavaScript(_0xffba011f());
                if (!_0x12dcb9ed && _0xb0ee6588 != null && _0xb0ee6588.IsAlive && IsHttpUrl(_0xffd99309))
                {
                    _0x12dcb9ed = true;
                }
            };
            _0x4c27bb01.OnPageFinished += (_0xb0ee6588, _0xbabb3d6c) =>
            {
                string _0xbf20de74 = _0xbabb3d6c != null ? _0xbabb3d6c.data : string.Empty;
                WLog(_0x188fffc2._0x2e478e05(new byte[35] { 41, 38, 23, 1, 6, 47, 82, 34, 29, 2, 7, 2, 82, 37, 23, 16, 36, 27, 23, 5, 82, 52, 27, 28, 27, 1, 26, 23, 22, 72, 82, 7, 0, 30, 79 }, 114) + _0xbf20de74);
                if (_0xb0ee6588 == null || !_0xb0ee6588.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0xbf20de74))
                {
                    _0x6880284b();
                    _0xb0ee6588.EvaluateJavaScript(_0xe24b3c0a());
                    return;
                }

                if (!_0x5bc461e9)
                    return;
                _0xb0ee6588.EvaluateJavaScript(_0xffba011f());
            };
        };
        _0xf2f386bb.OnMultipleWindowClosed += (_0x48c3e443, _0x45ba3c11) =>
        {
            _0x05e7450b.RemoveAll(_0x72acba4e => _0x72acba4e == null || _0x72acba4e.Id == _0x45ba3c11 || !_0x72acba4e.IsAlive);
            _0xa89d505b(false);
            if (_0x05e7450b.Count == 0 && _0x081b16a4 != null)
            {
                _0x5bc461e9 = false;
                _0x12dcb9ed = false;
                _0xbaa4fdca();
            }

            WLog(_0x188fffc2._0x2e478e05(new byte[43] { 249, 246, 199, 209, 214, 255, 130, 239, 195, 203, 204, 130, 245, 199, 192, 244, 203, 199, 213, 130, 239, 215, 206, 214, 203, 210, 206, 199, 245, 203, 204, 198, 205, 213, 130, 225, 206, 205, 209, 199, 198, 152, 130 }, 162) + _0x45ba3c11);
        };
        _0xf2f386bb.RegisterOnRequestMediaCapturePermission(_0x281e5827 =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    private string _0x32d5a423()
    {
        float _0xf04854a6 = Time.realtimeSinceStartup;
        if (_0xf04854a6 < 0f)
            _0xf04854a6 = 0f;
        int _0xcabb4be6 = (int)(_0xf04854a6 * 1000f);
        int _0xfd58d30d = _0xcabb4be6 / 60000;
        int _0x1d4e21b6 = (_0xcabb4be6 / 1000) % 60;
        int _0x8f8fcd68 = _0xcabb4be6 % 1000;
        return string.Format(_0x188fffc2._0x2e478e05(new byte[21] { 209, 154, 144, 154, 154, 215, 144, 209, 155, 144, 154, 154, 215, 144, 209, 152, 144, 154, 154, 154, 215 }, 170), _0xfd58d30d, _0x1d4e21b6, _0x8f8fcd68);
    }
}

internal static class _0x188fffc2
{
    internal static string _0x2e478e05(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}