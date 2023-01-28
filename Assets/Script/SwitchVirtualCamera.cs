//Copyright by VincentLam 2021
using UnityEngine;
using Cinemachine;
public class SwitchVirtualCamera : MonoBehaviour
{
    public GameObject triggerCamera;

    GameObject currentCamera;

    private void Start()
    {
        currentCamera = CinemachineCore.Instance.GetActiveBrain(0).ActiveVirtualCamera.VirtualCameraGameObject;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!enabled) return;
        if (other.tag == "Player")
            SwitchToNew();
    }

    private void OnTriggerExit(Collider other)
    {
        if (!enabled) return;
        if (other.tag == "Player")
            SwitchToOri();
    }

    void SwitchToNew()
    {
        currentCamera.gameObject.SetActive(false);
        triggerCamera.gameObject.SetActive(true);
    }

    void SwitchToOri()
    {
        currentCamera.gameObject.SetActive(true);
        triggerCamera.gameObject.SetActive(false);
    }
}
