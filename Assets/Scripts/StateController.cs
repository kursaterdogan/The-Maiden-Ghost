using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StateController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI titleText;
    [SerializeField] TextMeshProUGUI storyText;
    [SerializeField] State[] states;

    private string title = "The Maiden Ghost";

    private int index;

    public void GoNext()
    {
        TriggerState(states[index].GetRightIndex());

    }

    public void GoBack()
    {
        TriggerState(states[index].GetLeftIndex());

    }

    private void TriggerState(int index)
    {
        storyText.text = states[index].GetStateStory();
        if (index == 0)
            titleText.text = title;
        else
            titleText.text = index.ToString();

        this.index = index;

    }

}
