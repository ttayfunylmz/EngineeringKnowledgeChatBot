using UnityEditor;
using UnityEngine;

public class ALIyerEdonAssets_Lighting : EditorWindow
{
    [MenuItem("Window/Lighting Tools")]
    public static void ShowWindow()
    {
        GetWindow<ALIyerEdonAssets_Lighting>(false, "Lighting Tools", true);
    }
    public static void DrawUILine(Color color, int thickness = 2, int padding = 10)
    {
        Rect r = EditorGUILayout.GetControlRect(GUILayout.Height(padding + thickness));
        r.height = thickness;
        r.y += padding / 2;
        r.x -= 2;
        r.width += 6;
        EditorGUI.DrawRect(r, color);
    }

    private const int windowWidth = 610;
    private const int windowHeight = 500;
    Vector2 _scrollPosition;
    public bool dontShow;

    void OnEnable()
    {

        titleContent = new GUIContent("Lighting Tools and Assets");
        maxSize = new Vector2(windowWidth, windowHeight);
        minSize = maxSize;

        if (EditorPrefs.GetInt("dontShow_Palm_Pack_Free") == 3)
            dontShow = true;
        if (EditorPrefs.GetInt("dontShow_Palm_Pack_Free") != 3)
            dontShow = false;

        if (!GameObject.FindObjectOfType<LightingTools_Offer>())
        {
            GameObject adsLoader = GameObject.Instantiate(new GameObject("Offers") as GameObject, Vector3.zero, Quaternion.identity);

            GameObject.DestroyImmediate(GameObject.Find("Offers"));
            GameObject.Find("Offers(Clone)").name = "Offers";

            adsLoader.AddComponent<LightingTools_Offer>(); 

            adsLoader.GetComponent<LightingTools_Offer>().targetTextures = new Texture[12];
            adsLoader.GetComponent<LightingTools_Offer>().ImagesURL = new string[12];

            adsLoader.GetComponent<LightingTools_Offer>().ImagesURL[0] = "http://89.163.206.23/AssetStore/TreeOffers/Border.jpg";
            adsLoader.GetComponent<LightingTools_Offer>().ImagesURL[1] = "http://89.163.206.23/AssetStore/TreeOffers/Offer_1.jpg";
            adsLoader.GetComponent<LightingTools_Offer>().ImagesURL[2] = "http://89.163.206.23/AssetStore/TreeOffers/Offer_2.jpg";
            adsLoader.GetComponent<LightingTools_Offer>().ImagesURL[3] = "http://89.163.206.23/AssetStore/TreeOffers/Offer_3.jpg";
            adsLoader.GetComponent<LightingTools_Offer>().ImagesURL[4] = "http://89.163.206.23/AssetStore/TreeOffers/Offer_4.jpg";
            adsLoader.GetComponent<LightingTools_Offer>().ImagesURL[5] = "http://89.163.206.23/AssetStore/TreeOffers/Offer_5.jpg";
            adsLoader.GetComponent<LightingTools_Offer>().ImagesURL[6] = "http://89.163.206.23/AssetStore/TreeOffers/Offer_6.jpg";
            adsLoader.GetComponent<LightingTools_Offer>().ImagesURL[7] = "http://89.163.206.23/AssetStore/TreeOffers/Offer_7.jpg";
            adsLoader.GetComponent<LightingTools_Offer>().ImagesURL[8] = "http://89.163.206.23/AssetStore/TreeOffers/Offer_8.jpg";
            adsLoader.GetComponent<LightingTools_Offer>().ImagesURL[9] = "http://89.163.206.23/AssetStore/TreeOffers/Offer_9.jpg";
            adsLoader.GetComponent<LightingTools_Offer>().ImagesURL[10] = "http://89.163.206.23/AssetStore/TreeOffers/Offer_10.jpg";
            adsLoader.GetComponent<LightingTools_Offer>().ImagesURL[11] = "http://89.163.206.23/AssetStore/TreeOffers/Offer_11.jpg";

            adsLoader.GetComponent<LightingTools_Offer>().gameLinks = "http://89.163.206.23/AssetStore/TreeOffers/OfferLink.txt";

        }

    }

    private void OnGUI()
    {
        Texture2D border = new Texture2D(4, 4);
        Texture2D ad1 = new Texture2D(4, 4);
        Texture2D ad2 = new Texture2D(4, 4);
        Texture2D ad3 = new Texture2D(4, 4);
        Texture2D ad4 = new Texture2D(4, 4);
        Texture2D ad5 = new Texture2D(4, 4);
        Texture2D ad6 = new Texture2D(4, 4);
        Texture2D ad7 = new Texture2D(4, 4);
        Texture2D ad8 = new Texture2D(4, 4);
        Texture2D ad9 = new Texture2D(4, 4);
        Texture2D ad10 = new Texture2D(4, 4);
        Texture2D ad11 = new Texture2D(4, 4);

        if (GameObject.FindObjectOfType<LightingTools_Offer>())
        {
            if (GameObject.FindObjectOfType<LightingTools_Offer>().targetTextures[0])
                border = GameObject.FindObjectOfType<LightingTools_Offer>().targetTextures[0] as Texture2D;
            //________________________________________________________________________________________________
            if (GameObject.FindObjectOfType<LightingTools_Offer>().targetTextures[1])
                ad1 = GameObject.FindObjectOfType<LightingTools_Offer>().targetTextures[1] as Texture2D;
            //________________________________________________________________________________________________
            if (GameObject.FindObjectOfType<LightingTools_Offer>().targetTextures[2])
                ad2 = GameObject.FindObjectOfType<LightingTools_Offer>().targetTextures[2] as Texture2D;
            //________________________________________________________________________________________________
            if (GameObject.FindObjectOfType<LightingTools_Offer>().targetTextures[3])
                ad3 = GameObject.FindObjectOfType<LightingTools_Offer>().targetTextures[3] as Texture2D;
            //________________________________________________________________________________________________
            if (GameObject.FindObjectOfType<LightingTools_Offer>().targetTextures[4])
                ad4 = GameObject.FindObjectOfType<LightingTools_Offer>().targetTextures[4] as Texture2D;
            //________________________________________________________________________________________________
            if (GameObject.FindObjectOfType<LightingTools_Offer>().targetTextures[5])
                ad5 = GameObject.FindObjectOfType<LightingTools_Offer>().targetTextures[5] as Texture2D;
            //________________________________________________________________________________________________
            if (GameObject.FindObjectOfType<LightingTools_Offer>().targetTextures[6])
                ad6 = GameObject.FindObjectOfType<LightingTools_Offer>().targetTextures[6] as Texture2D;
            //________________________________________________________________________________________________
            if (GameObject.FindObjectOfType<LightingTools_Offer>().targetTextures[7])
                ad7 = GameObject.FindObjectOfType<LightingTools_Offer>().targetTextures[7] as Texture2D;
            //________________________________________________________________________________________________
            if (GameObject.FindObjectOfType<LightingTools_Offer>().targetTextures[8])
                ad8 = GameObject.FindObjectOfType<LightingTools_Offer>().targetTextures[8] as Texture2D;
            //________________________________________________________________________________________________
            if (GameObject.FindObjectOfType<LightingTools_Offer>().targetTextures[9])
                ad9 = GameObject.FindObjectOfType<LightingTools_Offer>().targetTextures[9] as Texture2D;
            //________________________________________________________________________________________________
            if (GameObject.FindObjectOfType<LightingTools_Offer>().targetTextures[10])
                ad10 = GameObject.FindObjectOfType<LightingTools_Offer>().targetTextures[10] as Texture2D;
            //________________________________________________________________________________________________
            if (GameObject.FindObjectOfType<LightingTools_Offer>().targetTextures[11])
                ad11 = GameObject.FindObjectOfType<LightingTools_Offer>().targetTextures[11] as Texture2D;
            //________________________________________________________________________________________________
        
        }


        EditorGUILayout.Space();
        EditorGUILayout.HelpBox("Buy My Lighting Assets", MessageType.None);
        EditorGUILayout.Space();


        var dontShowRef = dontShow;

        dontShow = EditorGUILayout.Toggle("Don't show for a long time", dontShow);

        if (dontShowRef != dontShow)
        {
            if (dontShow == true)            
                EditorPrefs.SetInt("dontShow_Palm_Pack_Free", 3); // 3 == true
            if (dontShow == false)
                EditorPrefs.SetInt("dontShow_Palm_Pack_Free", 0); // 0 = false
        }

        if (GameObject.FindObjectOfType<LightingTools_Offer>().isLoading)
            EditorGUILayout.HelpBox("\n                                                                                       Loading Offers...\n", MessageType.None);

        EditorGUILayout.Space();

        _scrollPosition = EditorGUILayout.BeginScrollView(_scrollPosition,
                     false,
                     false,
                     GUILayout.Width(windowWidth),
                     GUILayout.Height(windowHeight-20));        //---------Ad 1-------------------------------------------------
                                                                //  GUILayout.BeginVertical("Box");


        if (GUILayout.Button(border, "", GUILayout.Width(600), GUILayout.Height(130)))
        {
            Application.OpenURL(GameObject.FindObjectOfType<LightingTools_Offer>().LinksURL[0]);
        }

        if (GUILayout.Button(ad1, "", GUILayout.Width(600), GUILayout.Height(130)))
        {
            Application.OpenURL(GameObject.FindObjectOfType<LightingTools_Offer>().LinksURL[1]);
        }

        if (GUILayout.Button(ad2, "", GUILayout.Width(600), GUILayout.Height(130)))
        {
            Application.OpenURL(GameObject.FindObjectOfType<LightingTools_Offer>().LinksURL[2]);
        }

        if (GUILayout.Button(ad3, "", GUILayout.Width(600), GUILayout.Height(130)))
        {
            Application.OpenURL(GameObject.FindObjectOfType<LightingTools_Offer>().LinksURL[3]);
        }

        if (GUILayout.Button(ad4, "", GUILayout.Width(600), GUILayout.Height(130)))
        {
            Application.OpenURL(GameObject.FindObjectOfType<LightingTools_Offer>().LinksURL[4]);
        }

        if (GUILayout.Button(ad5, "", GUILayout.Width(600), GUILayout.Height(130)))
        {
            Application.OpenURL(GameObject.FindObjectOfType<LightingTools_Offer>().LinksURL[5]);
        }

        if (GUILayout.Button(ad6, "", GUILayout.Width(600), GUILayout.Height(130)))
        {
            Application.OpenURL(GameObject.FindObjectOfType<LightingTools_Offer>().LinksURL[6]);
        }

        if (GUILayout.Button(ad7, "", GUILayout.Width(600), GUILayout.Height(130)))
        {
            Application.OpenURL(GameObject.FindObjectOfType<LightingTools_Offer>().LinksURL[7]);
        }

        if (GUILayout.Button(ad8, "", GUILayout.Width(600), GUILayout.Height(130)))
        {
            Application.OpenURL(GameObject.FindObjectOfType<LightingTools_Offer>().LinksURL[8]);
        }

        if (GUILayout.Button(ad9, "", GUILayout.Width(600), GUILayout.Height(130)))
        {
            Application.OpenURL(GameObject.FindObjectOfType<LightingTools_Offer>().LinksURL[9]);
        }

        if (GUILayout.Button(ad10, "", GUILayout.Width(600), GUILayout.Height(130)))
        {
            Application.OpenURL(GameObject.FindObjectOfType<LightingTools_Offer>().LinksURL[10]);
        }

        if (GUILayout.Button(ad11, "", GUILayout.Width(600), GUILayout.Height(130)))
        {
            Application.OpenURL(GameObject.FindObjectOfType<LightingTools_Offer>().LinksURL[11]);
        }
        EditorGUILayout.EndScrollView();

    }

    void OnInspectorUpdate()
    {
        // Call Repaint on OnInspectorUpdate as it repaints the windows
        // less times as if it was OnGUI/Update
        Repaint();
    }
    void OnDestroy()
    {
        GameObject.DestroyImmediate(GameObject.FindObjectOfType<LightingTools_Offer>().gameObject);
    }
}


[InitializeOnLoad]
public class Startup
{
    static Startup() 
    {
        EditorPrefs.SetInt("showCounts_Palm_Pack_Free", EditorPrefs.GetInt("showCounts_Palm_Pack_Free") + 1);
        if (EditorPrefs.GetInt("showCounts_Palm_Pack_Free") < 2)
        { 
            EditorApplication.ExecuteMenuItem("Window/Lighting Tools");            
        }                 
        else          
        {   
            if (EditorPrefs.GetInt("dontShow_Palm_Pack_Free") == 3)
            {
                if (EditorPrefs.GetInt("showCounts_Palm_Pack_Free") >= 210)
                    EditorPrefs.SetInt("showCounts_Palm_Pack_Free", 0);
            }
            else
            {
                if (EditorPrefs.GetInt("showCounts_Palm_Pack_Free") >= 50)
                    EditorPrefs.SetInt("showCounts_Palm_Pack_Free", 0);
            }
        }            
    }
} 
