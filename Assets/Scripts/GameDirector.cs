using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour {

	public AudioClip audioMaru;
	public AudioClip audioBastsu;
	private AudioSource audioSource;

	public void Start () {
		this.audioSource = gameObject.GetComponent<AudioSource>();
	}

	public void Update () {
		if (Input.GetMouseButtonDown(0)) {
		    string objName = getTouchObjName();
			switch (objName) {
				case "Maru":
					audioSource.clip = this.audioMaru;
					audioSource.Play();
					break;
				case "Batsu":
					audioSource.clip = this.audioBastsu;
					audioSource.Play();
					break;
				default:
					break;
			}
	　	}
	}

	/// <summary>
	/// タッチされたオブジェクト名取得
	/// </summary>
	/// <returns>オブジェクト名 ない場合は空文字</returns>
	private string getTouchObjName () {
	　　Vector3 aTapPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
	　　Collider2D aCollider2d = Physics2D.OverlapPoint(aTapPoint);
	　　if (aCollider2d) {
	　　　	GameObject obj = aCollider2d.transform.gameObject;
	　　　	return obj.name;
	　　}
		return "";
	}
}
