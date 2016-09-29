using UnityEngine;
using UnityEngine.UI;

public class hudDisplay : MonoBehaviour {
    public Text cameraTxt;
    public Text worldTxt;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Transform t = Camera.main.gameObject.transform;
        cameraTxt.text = "Position:" + t.position.ToString() + "\nRotation: " + t.rotation.ToString();
        worldTxt.text = cameraTxt.text;

        //NOTES:
        //1) head movement distorts the hud (white -> RGB)
        //2) turning off hololens (sleep) while debugger is running produced an error (empty error box).
        //3) world text seems a lot easier to read than hud text... maybe I can work on a script to have the hud follow
        //      losely... maybe this would prevent the RGB shift but still keep it on had at all (most) times.
    }
}
