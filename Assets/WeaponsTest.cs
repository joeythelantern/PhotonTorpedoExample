using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsTest : MonoBehaviour
{
    public GameObject prefab;
    public AudioClip clip;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            GameObject _temp = Instantiate(prefab, new Vector3(0, 0, 0), transform.rotation);
            _temp.AddComponent<AudioSource>().playOnAwake = false;
            _temp.GetComponent<AudioSource>().clip = clip;
            _temp.GetComponent<AudioSource>().Play();
        }
    }
}
