using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset;

	// Use this for initialization
	void Start ()
	{
	    offset = transform.position - player.transform.position;
	}
	
	/// <remarks>
	/// LateUpdate is called every frame, like Update, but is guaranteed to run 
	/// after all items have been processed in Update, so we know that player 
	/// has moved in its Update.
	/// </remarks>
	void LateUpdate ()
	{
	    transform.position = player.transform.position + offset;
	}
}
