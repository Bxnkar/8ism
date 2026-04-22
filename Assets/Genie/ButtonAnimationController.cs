using UnityEngine;
using UnityEngine.UI;

public class ButtonAnimationController : MonoBehaviour
{
    [Header("Drag Civilian 3 GameObject here")]
    public Animator humanoidAnimator;

    [Header("UI Buttons")]
    public Button brushTeethButton;
    public Button combHairButton;
    public Button turnOnButtonBtn;
    public Button stopButton;

    void Start()
    {
        if (humanoidAnimator == null)
        {
            Debug.LogError("MISSING: Drag Civilian 3 into the Humanoid Animator slot!");
            return;
        }

        if (brushTeethButton != null)
            brushTeethButton.onClick.AddListener(PlayBrushTeeth);

        if (combHairButton != null)
            combHairButton.onClick.AddListener(PlayCombHair);

        if (turnOnButtonBtn != null)
            turnOnButtonBtn.onClick.AddListener(PlayTurnOnButton);

        if (stopButton != null)
            stopButton.onClick.AddListener(StopAnimation);

        Debug.Log("ButtonAnimationController ready!");
    }

    public void PlayBrushTeeth()
    {
        humanoidAnimator.Play("BrushTeeth", 0, 0f);
        Debug.Log("Playing BrushTeeth");
    }

    public void PlayCombHair()
    {
        humanoidAnimator.Play("CombHair", 0, 0f);
        Debug.Log("Playing CombHair");
    }

    public void PlayTurnOnButton()
    {
        humanoidAnimator.Play("TurnOnButton", 0, 0f);
        Debug.Log("Playing TurnOnButton");
    }

    public void StopAnimation()
    {
        humanoidAnimator.Play("Idle", 0, 0f);
        Debug.Log("Stopped");
    }
}