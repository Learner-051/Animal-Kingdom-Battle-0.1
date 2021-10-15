using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
   /* public GameObject player;        
    private Vector3 offset;             
    void Start()
    {
        //offset = transform.position - player.transform.position;
    } 
    void LateUpdate()
    {
        transform.position = player.transform.position;
    }
    */
      public static CameraController instance;
    // Start is called before the first frame update
    //public GameObject[] prefabs;
    private Vector3 offset;
    [SerializeField]
    private GameObject player;
    private bool isInitialized = false;
    // int i = IAnimal.Cnt;
    //int i ;
    // Start is called before the first frame update
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }
    public void Initialize(GameObject player)
    {
        this.player = player;
        offset = transform.position - player.transform.position;

        isInitialized = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(isInitialized)
        transform.position = player.transform.position + offset;

    }
}
