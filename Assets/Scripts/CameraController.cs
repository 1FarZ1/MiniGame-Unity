using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
  public GameObject player;

  private Vector3 offset;

  void Start ()
  {

    // lbo3d bin le camera et le player 
      offset = transform.position - player.transform.position;
  }

  void LateUpdate ()
  {

    // hna nbdaw nattachiw le camera llplayer
      transform.position = player.transform.position + offset;
  }
}
