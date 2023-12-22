using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SoundManager))]
public class SoundManagerEditor : Editor
{
    int selectedBGM = 1;
    public override void OnInspectorGUI()
    {
        EditorGUI.BeginChangeCheck();

        // 通常のインスペクタ表示
        base.OnInspectorGUI();

        SoundManager soundManager = (SoundManager)target;
        // BGM一覧のドロップダウン表示
        if (soundManager.Audios.Length != 0)
        {
            selectedBGM = EditorGUILayout.Popup(
                // new GUIContent("ドロップダウン"),
                "BGM一覧",
                selectedBGM,
                soundManager.GetAudioNames()
            );
        }
        else
        {
            selectedBGM = -1;
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