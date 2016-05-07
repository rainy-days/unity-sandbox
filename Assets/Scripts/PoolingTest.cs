using UnityEngine;
using System.Collections;
using RainyDays;

public class PoolingTest : MonoBehaviour {

	public float waitSeconds = 1.0f;
	public Pool pool;
	public int acquireCount = 1;

	// Use this for initialization
	IEnumerator Start () {
		
		yield return new WaitForSeconds(waitSeconds);
		for (int i = 0; i < acquireCount; ++i) {
			pool.Ask (this.transform, (r) => {
				r.result.transform.position = new Vector3 ((float)r.result.IndexInPool, 0.0f, 0.0f);
			});
		}
	}
}
