using UnityEngine;
using UnityEngine.UI;

public class Progress : MonoBehaviour
{
    private ushort coin = 0;
    public ushort Coin => coin;
    [SerializeField] private Text textCoin;
    private int countCheckPoint = 0;
    public int CountCheckPoint => countCheckPoint;
    private Rigidbody rigidbody;
    private void Awake()
    {
        countCheckPoint = FindObjectOfType<CheckPoints>().transform.childCount;
        rigidbody = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("CheckPoint"))
        {
            coin++;
            textCoin.text = "Coin = "+coin.ToString();
            collider.gameObject.SetActive(false);
            if (coin %5 == 0) rigidbody.mass -= 500;
        }
    }
}
    
