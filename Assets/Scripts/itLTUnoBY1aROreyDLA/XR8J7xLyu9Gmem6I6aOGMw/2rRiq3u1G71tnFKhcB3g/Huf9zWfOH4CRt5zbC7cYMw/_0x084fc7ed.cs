using UnityEngine;
using UnityEngine.UI;

public class _0x084fc7ed : MonoBehaviour
{
    public int NextTutorialPanelIndex;
    public int EndTutorialPanelIndex = 1;
    public Button NextTutorialButton;
    public Button TutorialEndButton;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x3e36db7a.Instance._0xa72c9de0(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0x24245b46.Instance._0x724e6152());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x3e36db7a.Instance._0xa72c9de0(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0x3e36db7a.Instance._0xa72c9de0(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0x24245b46.Instance._0x724e6152());
        }
    }

    public bool IsTutorialEndPanel;
}