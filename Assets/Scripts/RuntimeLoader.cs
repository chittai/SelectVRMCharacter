using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRM;
using UniRx;

public class RuntimeLoader : MonoBehaviour {

    public async void LoadVrm(string name)
    {
        var path = Application.streamingAssetsPath + "/" + name + ".vrm";

        var www = new WWW(path);

        await www;

        var gameObject = await VRMImporter.LoadVrmAsync(www.bytes);

        gameObject.transform.position = new Vector3(1, 1, 1);

        gameObject.name = name;

    }
}
