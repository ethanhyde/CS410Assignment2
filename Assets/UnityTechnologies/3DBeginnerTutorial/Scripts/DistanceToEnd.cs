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
        // Calculate distance value between character and checkpoint
        distance = (checkpoint.transform.position - transform.position).magnitude;

        // Display distance value via UI text
        // distance.ToString("F1") shows value with 1 digit after period
        // so 12.234 will be shown as 12.2 for example
        // distance.ToString("F2") will show 12.23 in this case
        distanceText.text = "Distance: " + distance.ToString("F1") + " meters";
    }

}