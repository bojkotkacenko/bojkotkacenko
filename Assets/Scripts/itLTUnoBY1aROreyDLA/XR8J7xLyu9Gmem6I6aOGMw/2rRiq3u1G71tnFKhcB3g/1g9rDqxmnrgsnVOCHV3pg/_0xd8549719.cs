using UnityEngine;
using UnityEngine.UI;

public class _0xd8549719 : MonoBehaviour
{
    public int PopToShowIndex;
    public Button Button;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsShowLastPop;
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0x6e6daaaf.Instance._0xbcc5d291();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0x6e6daaaf.Instance._0x29da2ed9());
        else
            this.Button.onClick.AddListener(() => _0x6e6daaaf.Instance._0x8717e92b(this.PopToShowIndex));
    }

    public bool IsHideAllPops;
}