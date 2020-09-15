﻿using System;
using UnityEngine;

public class ScenarioWalls : MonoBehaviour {
  [SerializeField]
  private GameObject wallLeft;
  [SerializeField]
  private GameObject wallRight;
  [SerializeField]
  private GameObject wallTop;
  [SerializeField]
  private GameObject wallBottom;
  private Camera cameraMain;

  private void Awake() {
    cameraMain = Camera.main;
  }

  void Update() {
    SetWallsPositions();
    ScaleWalls();
  }

  void SetWallsPositions() {
    wallLeft.transform.position = cameraMain.ViewportToWorldPoint(new Vector2(0f, 0.5f));
    wallRight.transform.position = cameraMain.ViewportToWorldPoint(new Vector2(1f, 0.5f));
    wallTop.transform.position = cameraMain.ViewportToWorldPoint(new Vector2(0.5f, 1f));
    wallBottom.transform.position = cameraMain.ViewportToWorldPoint(new Vector2(0.5f, 0f));
  }

  void ScaleWalls() {
    double width = cameraMain.orthographicSize * 2.0 * Screen.width / Screen.height;
    double height = cameraMain.orthographicSize * 2.0;
    wallBottom.transform.localScale = new Vector3(0.1f, (float) width, 0.1f);
    wallTop.transform.localScale = new Vector3(0.1f, (float) width, 0.1f);
    wallLeft.transform.localScale = new Vector3(0.1f, (float) height, 0.1f);
    wallRight.transform.localScale = new Vector3(0.1f, (float) height, 0.1f);
  }
}