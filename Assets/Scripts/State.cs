using UnityEngine;

[CreateAssetMenu(menuName = "State")]

public class State : ScriptableObject
{
    [SerializeField] private int left;
    [SerializeField] private int right;

    [TextArea(5, 15)] [SerializeField] string storyText;

    public string GetStateStory()
    {
        return storyText;
    }

    public int GetLeftIndex()
    {
        return left;
    }

    public int GetRightIndex()
    {
        return right;
    }

}