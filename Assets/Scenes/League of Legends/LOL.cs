using UnityEngine;
using UnityEngine.AI;

public class LOL : MonoBehaviour
{
    Rigidbody rb;
    public Camera camera;
    public NavMeshAgent agent;
    private float bulletSpeed = 6.0f;
    [SerializeField] private  Transform BullerPoint;//球を出す位置
    [SerializeField] GameObject ball;//出す球

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        rb = GetComponent<Rigidbody>();//Rigidbody取得
        
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        //スクリーン座標の取得
        if (Input.GetMouseButton(0))
        {
            Debug.Log("mouse click");
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                agent.SetDestination(hit.point);
            }
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {

            GameObject shotObj = Instantiate(ball, BullerPoint.position, BullerPoint.rotation);

            Rigidbody rb = shotObj.GetComponent<Rigidbody>();//生成した弾のRigidbodyを取得

            rb.velocity = shotObj.transform.forward * bulletSpeed;

            Destroy(shotObj, 5f);//5秒後に消す
        }
        if (Input.GetKeyDown(KeyCode.W))
        {

        }
        if (Input.GetKeyDown(KeyCode.E))
        {

        }
        if (Input.GetKeyDown(KeyCode.R))
        {

        }

    }
}
