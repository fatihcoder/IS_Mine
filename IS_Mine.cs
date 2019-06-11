using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IS_Mine : MonoBehaviour {
	[Header("Is_Name")]
	public string Startt;
	public string End;
	[Header("[ --> IS_Mine <-- ]")]
	public List<MonoBehaviour> MonoBehaviours;
	public List<Camera> Cameras;

	public List<GameObject> GameObjects;

	public List<Collider> Colliders;
	
	public List<Rigidbody> Rigidbodys;

	public UnityEvent Eventi;
	[Space(30),Header("[ --> DontMine <-- ]")]
	public List<MonoBehaviour> _MonoBehaviours;
	public List<Camera> _Cameras;

	public List<GameObject> _GameObjects;

	public List<Collider> _Colliders;
	
	public List<Rigidbody> _Rigidbodys;

	public UnityEvent _Eventi;
	

	void Start () {
        if (GetComponent<PhotonView>().isMine){
			Eventi.Invoke();
			name = Startt+name+End;
			ISMine_();
        }else{
	 	    _dontMine(); 
			_Eventi.Invoke();
		}
	 }


	public void ISMine_(){
		for (int i = 0; i < MonoBehaviours.Count; i++){
			_MonoBehaviours[i].enabled = true;
		}


		for (int i = 0; i < Cameras.Count; i++){
			_Cameras[i].enabled = true;
		}


	

		for (int i = 0; i < GameObjects.Count; i++){
			_GameObjects[i].active = true;
		}



		for (int i = 0; i < Colliders.Count; i++){
			_Colliders[i].enabled = true;
		}


		for (int i = 0; i < Rigidbodys.Count; i++){
			_Rigidbodys[i].useGravity = true;
			_Rigidbodys[i].isKinematic = false;
        }





	}


	public void _dontMine(){
		for (int i = 0; i < _MonoBehaviours.Count; i++){
			_MonoBehaviours[i].enabled = false;
		}


		for (int i = 0; i < _Cameras.Count; i++){
			_Cameras[i].enabled = false;
		}


	

		for (int i = 0; i < _GameObjects.Count; i++){
			_GameObjects[i].active = false;
		}



		for (int i = 0; i < _Colliders.Count; i++){
			_Colliders[i].enabled = false;
		}


		for (int i = 0; i < _Rigidbodys.Count; i++){
			_Rigidbodys[i].useGravity = false;
			_Rigidbodys[i].isKinematic = true;
        }





	}



}
