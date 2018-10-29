using UnityEngine;
using System.Collections;


public class RawImageMoviePlayer : MonoBehaviour 
{
	public UnityEngine.UI.RawImage imageSource;

	public bool play;
	public bool isLoop = true;

	public MovieTexture movie;

	// Use this for initialization
	void Start () 
	{
		movie = (MovieTexture)imageSource.texture;
		movie.loop = isLoop;
		movie.Play ();
	}

	// Update is called once per frame
	void Update () 
	{
		if (!movie.isPlaying && play)
			movie.Play();
	}

	public void ChangeMovie(MovieTexture movie)
	{
		imageSource.texture = movie;

		this.movie = (MovieTexture)imageSource.texture;
		this.movie.loop = isLoop;
	}

	public void OnDisable()
	{
		if (movie != null && movie.isPlaying)
			movie.Stop();
	}
}