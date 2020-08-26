using TMPro;
using UnityEngine;

public class StateController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI titleText;
    [SerializeField] TextMeshProUGUI storyText;
    [SerializeField] State[] states;

    private string _title = "The Maiden Ghost";

    private int _index;

    public void GoNext()
    {
        TriggerState(states[_index].GetRightIndex());

    }

    public void GoBack()
    {
        TriggerState(states[_index].GetLeftIndex());

    }

    private void TriggerState(int index)
    {
        storyText.text = states[index].GetStateStory();
        if (index == 0)
            titleText.text = _title;
        else
            titleText.text = index.ToString();

        this._index = index;

    }

}
