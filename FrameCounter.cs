using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameCounter : MonoBehaviour
{
    private float deltaTime = 0f;

    [SerializeField , Range(1, 100)]
    private int size = 25;

    [SerializeField]
    private Color color = Color.green;

    public bool isShow;


    // Update is called once per frame
    void Update()
    {
        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;

        if (Input.GetKeyDown(KeyCode.F1))
        {
            isShow = !isShow;
        }
    }

    private void OnGUI()
    {
        if (isShow)
        {
            GUIStyle style = new GUIStyle();
            Rect rect = new Rect(30, 30, Screen.width, Screen.height);
            style.alignment = TextAnchor.UpperLeft;
            style.fontSize = size;
            style.normal.textColor = color; // 유니티 GUI 세팅

            float ms = deltaTime * 1000f;
            float fps = 1.0f / deltaTime;
            string text = string.Format("{0:0.} FPS ({1:0.0} ms )", fps, ms);

            GUI.Label(rect, text, style);


        }
    }
}
