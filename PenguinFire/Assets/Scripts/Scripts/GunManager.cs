using UnityEngine;

public class GunManager : MonoBehaviour
{
    public Transform bone;
    public GameObject[] audioPrefab;

    public void InstantiateGunEffects(int soundEffectID)
    {
        GameObject instantiatedPrefab = Instantiate(audioPrefab[soundEffectID], transform.position, Quaternion.identity, transform.parent.parent) as GameObject;
        instantiatedPrefab.GetComponent<AudioSource>().spatialBlend = 1f;
        instantiatedPrefab.GetComponent<AudioSource>().PlayDelayed(0f);
        Debug.Log("Instantiated");
    }
}
