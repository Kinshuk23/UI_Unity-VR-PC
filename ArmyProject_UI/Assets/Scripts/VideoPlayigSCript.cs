using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlayigSCript : MonoBehaviour 
{
	public VideoClip[] m_VideoClip;
	public VideoPlayer vp;
	public int VideoClipIndex = 0;
	private VideoPlayer m_VideoPlayer;
	float length;

	void Start () 
	{
		m_VideoPlayer = vp;
		m_VideoPlayer.clip = m_VideoClip [VideoClipIndex];
		Debug.Log ("Invoke Wil be Called");
		//StartCoroutine (NextVideo());
		InvokeRepeating ("VideoPlayingFunction", 25, 25);
		//InvokeRepeating ("VideoPlayingFunction", m_VideoPlayer.clip, m_VideoPlayer.clip.length);
	}
		
	/*IEnumerator NextVideo()
	{
		yield return new WaitForSeconds (m_VideoPlayer.clip.length);
		VideoClipIndex++;
		m_VideoPlayer.clip = m_VideoClip [VideoClipIndex];
		yield return new WaitForSeconds (m_VideoPlayer.clip.length);
		VideoClipIndex++;
		m_VideoPlayer.clip = m_VideoClip [VideoClipIndex];
	}*/

	public void VideoPlayingFunction ()
	{
		Debug.Log ("In The Video Function");
		VideoClipIndex = Random.Range (0,2);
		m_VideoPlayer.clip = m_VideoClip [VideoClipIndex];
	}

}
