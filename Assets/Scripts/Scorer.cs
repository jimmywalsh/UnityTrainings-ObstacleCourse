using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int _numberOfCollisons = 0;

    private void incrementHits()
    {
        _numberOfCollisons++;
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            incrementHits();
            Debug.Log($"You've bumped into a thing {_numberOfCollisons} times.");
        }
    }
}
