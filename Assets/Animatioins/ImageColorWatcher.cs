﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageColorWatcher : MonoBehaviour {

    Color lastColor;
    Image img;

#if UNITY_EDITOR
    [MultilineAttribute(2)]
    public string readMe = "动画改变Image.color时并不会生效，\n需要用这个脚本来触发color的setter";
#endif

    void Start() {
        img = GetComponent<Image>();
        lastColor = img.color;
    }
    void LateUpdate() {
        if (img.color != lastColor) {
            lastColor = img.color;
            img.color = new Color();
            img.color = lastColor;
        }
    }
}
