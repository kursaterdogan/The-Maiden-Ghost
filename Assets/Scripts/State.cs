using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [SerializeField] private int leftIndex;
    [SerializeField] private int rightIndex;

    [SerializeField] private string title;
    [TextArea(5, 15)] [SerializeField] private string story;

    public int GetLeftIndex()
    {
        return leftIndex;
    }

    public int GetRightIndex()
    {
        return rightIndex;
    }

    public string GetTitle()
    {
        return title;
    }

    public string GetStory()
    {
        return story;
    }
}