using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample_UnchangeableInPlayingAttribute : MonoBehaviour {

    [UnchangeableInPlaying]
    public float hoge;
    [UnchangeableInPlaying]
    public string fuga;
}
