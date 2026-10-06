using UnityEngine;

public class _0xf58e0432 : MonoBehaviour
{
    public bool IsTutorialEnabled;
    private void _0x391fd787()
    {
        {
#if !B_LOGS
        {
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }

    public bool IsStoryEnabled;
    public bool IsCheckScoreEnabled;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0xf58e0432>();
            DontDestroyOnLoad(this.gameObject);
            this._0x391fd787();
        }
        else
        {
            this._0x0c7a00a0();
            Destroy(this.gameObject);
        }
    }

    private void _0x0c7a00a0()
    {
    }

    public bool IsSkipSplashEnabled;
    public static _0xf58e0432 Instance;
    public bool IsBestScoreEnabled;
    public bool IsTimerEnabled;
    public bool IsLevelIncrementOnWin;
    public bool IsOnlyWinGameEndEnabled;
    public bool IsLevelSelectorEnabled;
}