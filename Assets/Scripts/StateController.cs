using UnityEngine;
using TMPro;

public class StateController : MonoBehaviour
{
    [SerializeField] private State[] states;

    [SerializeField] private TextMeshProUGUI titleText;
    [SerializeField] private TextMeshProUGUI storyText;

    private int _index;

    void Start()
    {
        SetDefaultState();
    }

    public void GoLeft()
    {
        var index = states[_index].GetLeftIndex();
        TriggerState(index);
    }

    public void GoRight()
    {
        var index = states[_index].GetRightIndex();
        TriggerState(index);
    }

    private void TriggerState(int index)
    {
        var state = states[index];

        storyText.text = state.GetStateStory();
        titleText.text = state.GetTitle();

        _index = index;
    }

    private void SetDefaultState()
    {
        TriggerState(_index);
    }
}