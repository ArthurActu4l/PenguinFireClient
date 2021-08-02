using UnityEngine;

public class GunManager : MonoBehaviour
{
    public Transform bone;
    void GunRotation(Quaternion gunRotation)
    {
        transform.localRotation = Quaternion.Lerp(transform.localRotation, gunRotation, 20f * Time.smoothDeltaTime);
    }
}
