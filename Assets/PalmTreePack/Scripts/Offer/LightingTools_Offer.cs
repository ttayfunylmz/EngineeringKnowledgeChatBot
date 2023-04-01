// Terms of the use :
// * You can only use this script to offer platers for other or your games
// * You cannot offer anythings else like sexual contents or other things (just content for children)

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System;
using System.Linq;
[ExecuteInEditMode]
public class LightingTools_Offer : MonoBehaviour {

	WWW www;
	[Space(3)]
	// Button sprites
	[HideInInspector] public Texture[] targetTextures;

	// Games icon urls
	[HideInInspector]public string[] ImagesURL;
	// Internal
	Texture2D[] textures;

	[HideInInspector]
	public string[] LinksURL;

	// Game links file with https, splited with lines     
	[HideInInspector] public string gameLinks;

	// Activated when player is online    (Ad border    )
	[HideInInspector] public bool isLoading;

	void Start()
	{
		
		textures = new Texture2D[targetTextures.Length];

		LinksURL = new string[targetTextures.Length];

		for(int a = 0;a<textures.Length;a++)
			textures[a] =  new Texture2D(4, 4, TextureFormat.DXT1, false);

		Reload ();

	}

	public void Reload()
	{
		StopCoroutine (ReadLinks());
		StopCoroutine (ReadImages ());
		isLoading = true;

		StartCoroutine (ReadLinks ());
	}
	public void LoadAd(int id)
	{
		if(LinksURL [id].Contains("https"))
			Application.OpenURL (LinksURL [id]);
		else
			Application.OpenURL(LinksURL [id]);
		
	}

	int loaded;
	IEnumerator ReadImages()
	{
		for(int b = 0;b<ImagesURL.Length;b++)
		{
			if (b >= loaded) {
				www = new WWW (ImagesURL [b]);

				yield return www;
				www.LoadImageIntoTexture (textures [b]);
				targetTextures[b] = textures[b];
				www.Dispose ();
				www = null;
				loaded++;
			}

		}
		isLoading = false;
	}
	IEnumerator ReadLinks()
	{
		// Read Link URLs
		www = new WWW (gameLinks);

		yield return www;

		string	longStringFromFile = www.text;
		List<string> lines = new List<string>(
			longStringFromFile
			.Split(new string[] { "\r","\n" },
				StringSplitOptions.RemoveEmptyEntries) );
		// remove comment lines...
		lines = lines
			.Where(line => !(line.StartsWith("//")
				|| line.StartsWith("#")))
			.ToList();

		for(int c = 0;c<lines.Count;c++)
			LinksURL [c] = lines [c];

		www.Dispose ();
		www = null;

		StartCoroutine(ReadImages ());
	}
}
	   