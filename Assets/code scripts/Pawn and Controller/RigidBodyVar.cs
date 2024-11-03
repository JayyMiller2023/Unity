using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyVar : MonoBehaviour
{
   Rigidbody rigidbody;
   Vector3 moveVector;
   float speed;
   rigidbody = this.gameObject.GetComponent<Rigidbody>;
   rigidbody.MovePosition(rigidBody.position * moveVector * speed * Time.deltaTime);
}
