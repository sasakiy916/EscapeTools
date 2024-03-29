using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(PlaySE))]
public class PlaySEEditor : Editor

{
    int selectedBGM = 0;
    SoundManager soundManager;
    void Awake()
    {
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
    }

    public override void OnInspectorGUI()
    {
        EditorGUI.BeginChangeCheck();
        base.OnInspectorGUI();

        // PlaySE playSE = (PlaySE)target;
        // BGM一覧のドロップダウン表示
        if (soundManager.SEAudios.Length != 0)
        {
            selectedBGM = EditorGUILayout.Popup(
                // new GUIContent("ドロップダウン"),
                "使用SE",
                selectedBGM,
                soundManager.GetSENames()
            );

            if (GUILayout.Button("再生"))
            {
                soundManager.PlaySE(soundManager.SEAudios[selectedBGM]);
            }
        }
        else
        {
            selectedBGM = -1;
            GUILayout.Label("SoundMangerにSEを登録してください");
        }


        // インスペクタの値が変更されたら
        if (EditorGUI.EndChangeCheck())
        {
            if (selectedBGM == -1 && soundManager.Audios[0] != null) selectedBGM = 0;
            // ドロップダウンで選択したBGMをAuidoClipにセット
            soundManager.SetAuidoBGM(selectedBGM);
        }
    }
}