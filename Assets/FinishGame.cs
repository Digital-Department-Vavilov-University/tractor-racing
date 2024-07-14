using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class FinishGame : MonoBehaviour
{

    public GameObject LabelWin;
    public GameObject LabelLose;
    [SerializeField] private CarAIControl carAIController;
    [SerializeField] private CarUserControl carUserController;

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.CompareTag("Player")) LabelWin.SetActive(true);
        else if (collider.CompareTag("Enemy")) LabelLose.SetActive(true);
        carAIController.enabled = false;
        carAIController.GetComponent<Rigidbody>().isKinematic = true;
        carUserController.enabled = false;
        carUserController.GetComponent<Rigidbody>().isKinematic = true;

    }
}
