using UnityEngine;

[CreateAssetMenu(menuName = "State")]

public class State : ScriptableObject
{
    [SerializeField] private int leftIndex;
    [SerializeField] private int rightIndex;

    [TextArea(5, 15)] [SerializeField] string storyText;

    public string GetStateStory()
    {
        return storyText;
    }

    public int GetLeftIndex()
    {
        return leftIndex;
    }

    public int GetRightIndex()
    {
        return rightIndex;
    }

}