using UnityEngine;

/// <summary>
/// Control hundle properties
/// </summary>
public class HurdleController : MonoBehaviour
{

    [SerializeField]
    private RectTransform TopPipe;

    [SerializeField]
    private RectTransform BottomPipe;

    [SerializeField]
    [Range(13,20)]
    private int GapInHurdle = 15;

    private float TopPipeLimit;

    private float HurdleGapLength;
    
    private float ParentHeight;
    // Start is called before the first frame update
    void Start()
    {
        ParentHeight = CanvasManager.Instance.GetHeight();


        HurdleGapLength = (ParentHeight * (GapInHurdle / 100.0f));

        
        //Set the top pipe length from 30-60% of the screen height
        TopPipeLimit = (ParentHeight * (Random.Range(20.0f, 70.0f) / 100.0f));

        TopPipe.sizeDelta = new Vector2(TopPipe.sizeDelta.x, TopPipeLimit);

        //Set the bottom pipe size by adding the hurdle size and top pipe size and then subtract from total screen height 
        BottomPipe.sizeDelta = new Vector2(BottomPipe.sizeDelta.x, ParentHeight - (TopPipeLimit + HurdleGapLength));


        //Set the size and center of the box collider according to the pipe size

        TopPipe.gameObject.GetComponent<BoxCollider>().size = new Vector3(TopPipe.sizeDelta.x, TopPipe.sizeDelta.y, 10);

        TopPipe.gameObject.GetComponent<BoxCollider>().center = new Vector3(0, -TopPipe.sizeDelta.y/2, 0);

        BottomPipe.gameObject.GetComponent<BoxCollider>().size = new Vector3(BottomPipe.sizeDelta.x, BottomPipe.sizeDelta.y, 10);

        BottomPipe.gameObject.GetComponent<BoxCollider>().center = new Vector3(0, BottomPipe.sizeDelta.y / 2, 0);




    }

    void OnBecameInvisible()
    {

        enabled = false;

    }
}
