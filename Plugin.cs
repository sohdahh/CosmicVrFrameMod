using System;
using System.IO;
using System.Reflection;
using BepInEx;
using CosmicVrFrameMod;
using Photon.Voice;
using Unity.Mathematics;
using UnityEngine;
using Utilla;

namespace CosmicVrFrameMod
{
    [BepInDependency("org.legoandmars.gorillatag.utilla", "1.5.0")]
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {


        public bool active;
        bool inRoom;

        void Start()
        {
            Utilla.Events.GameInitialized += OnGameInitialized;
        }

        void OnEnable()
        {
            AssetObj.SetActive(true);

            active = true;

            HarmonyPatches.ApplyHarmonyPatches();
        }

        void OnDisable()
        {
            AssetObj.SetActive(false);

            active = false;

            HarmonyPatches.RemoveHarmonyPatches();
        }

        public GameObject AssetObj;
        void OnGameInitialized(object sender, EventArgs e)
        {
            var assetBundle = LoadAssetBundle("Cosmicframe.cosmic");
            GameObject Obj = assetBundle.LoadAsset<GameObject>("pfpObj");

            AssetObj = Instantiate(Obj);
            AssetObj.transform.position = new Vector3(-68.8561f, 12.3656f, -84.2387f);
            AssetObj.transform.rotation = Quaternion.Euler(270.6168f, 326.6051f, 0.0002f);
            AssetObj.transform.localScale = new Vector3(3.2488f, 34.8836f, 37.3948f);
            AssetObj.layer = 8;



            GameObject gameObject = assetBundle.LoadAsset<GameObject>("CaveagainObj");

            AssetObj = Instantiate(Obj);
            AssetObj.transform.position = new Vector3(-68.8561f, 12.3656f, -84.2387f);
            AssetObj.transform.rotation = Quaternion.Euler(270.6168f, 326.6051f, 0.0002f);
            AssetObj.transform.localScale = new Vector3(3.2488f, 34.8836f, 37.3948f);
            AssetObj.layer = 8;


            GameObject gameObject1 = assetBundle.LoadAsset<GameObject>("CaveColorsObj");

            AssetObj = Instantiate(Obj);
            AssetObj.transform.position = new Vector3(-68.8561f, 12.3656f, -84.2387f);
            AssetObj.transform.rotation = Quaternion.Euler(270.6168f, 326.6051f, 0.0002f);
            AssetObj.transform.localScale = new Vector3(3.2488f, 34.8836f, 37.3948f);
            AssetObj.layer = 8;

            GameObject gameObject2 = assetBundle.LoadAsset<GameObject>("CaveObj");

            AssetObj = Instantiate(Obj);
            AssetObj.transform.position = new Vector3(-68.8561f, 12.3656f, -84.2387f);
            AssetObj.transform.rotation = Quaternion.Euler(270.6168f, 326.6051f, 0.0002f);
            AssetObj.transform.localScale = new Vector3(3.2488f, 34.8836f, 37.3948f);
            AssetObj.layer = 8;

            GameObject gameObject3 = assetBundle.LoadAsset<GameObject>("MirrorObj");

            AssetObj = Instantiate(Obj);
            AssetObj.transform.position = new Vector3(-68.8561f, 12.3656f, -84.2387f);
            AssetObj.transform.rotation = Quaternion.Euler(270.6168f, 326.6051f, 0.0002f);
            AssetObj.transform.localScale = new Vector3(3.2488f, 34.8836f, 37.3948f);
            AssetObj.layer = 8;

            GameObject gameObject4 = assetBundle.LoadAsset<GameObject>("TheMonkeObj");

            AssetObj = Instantiate(Obj);
            AssetObj.transform.position = new Vector3(-68.8561f, 12.3656f, -84.2387f);
            AssetObj.transform.rotation = Quaternion.Euler(270.6168f, 326.6051f, 0.0002f);
            AssetObj.transform.localScale = new Vector3(3.2488f, 34.8836f, 37.3948f);
            AssetObj.layer = 8;
        }

            AssetBundle LoadAssetBundle(string path)
            {
                try
                {
                    Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(path);
                    AssetBundle bundle = AssetBundle.LoadFromStream(stream);
                    stream.Close();
                    Debug.Log("[" + PluginInfo.GUID + "] Success loading asset bundle");
                    return bundle;
                }
                catch (Exception a)
                {
                    Debug.Log("[" + PluginInfo.Name + "] Error loading asset bundle: " + a.Message + " " + path);
                    throw;
                }
            }
    }
}