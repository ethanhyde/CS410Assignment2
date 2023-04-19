using UnityEngine;
using UnityEngine.UI;     

public class DistanceToEnd : MonoBehaviour {

    [SerializeField]
    private Transform checkpoint;

    [SerializeField]
    private Text distanceText;
    private float distance;
    private void Update()
    {

        // Calculate distance value between character and checkpoint

        // Found here https://www.youtube.com/watch?v=tg2M35CVP4E
        distance = (checkpoint.transform.position - transform.position).magnitude;
        distanceText.text = "Distance: " + distance.ToString("F1") + " meters";
    }

}