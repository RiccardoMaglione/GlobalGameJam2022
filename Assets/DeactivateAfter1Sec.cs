using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateAfter1Sec : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Deactivate());
    }

    public IEnumerator Deactivate()
    {
        yield return new WaitForSecondsRealtime(1);
        this.gameObject.SetActive(false);
    }
}
