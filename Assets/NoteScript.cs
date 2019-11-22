using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteScript : MonoBehaviour {

    //必要なノーツを宣言
    public GameObject note;

    //ノーツが落ちるタイミングの配列
    float[] timing = { 10.2f, 30.4f, 5.2f,4.5f };

    //ノーツのリスト
    List<GameObject> notes = new List<GameObject>();
    


    //時間を計測する変数
    float timer;

    //ノーツの順番が入る変数
    int noteNumber = 0;


    // Use this for initialization
    void Start () {
        //最初にtimingの配列の要素数だけノーツを生成する
        for (int i = 0; i < timing.Length; ++i)
        {

            //ノーツの配列にそれぞれ代入していく
            notes.Add(Instantiate(note));
        }

    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        //順番が来たら落としていく
        if(timing[noteNumber] < timer)
        {
            //ノーツが落ちるスクリプトをONにする
            notes[noteNumber].gameObject.GetComponent<NoteUnder>().enabled = true;

            timer = 0;
            noteNumber++;
        }
	}

}
