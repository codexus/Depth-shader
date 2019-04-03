using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleSetter : MonoBehaviour
{
    private static int SCALE_ID = Shader.PropertyToID("_Scale");

    private SpriteRenderer spriteRenderer { get { if (_sr == null) _sr = GetComponent<SpriteRenderer>(); return _sr; } }
    private SpriteRenderer _sr;

    private new Camera camera { get { if (_camera == null) _camera = Camera.main; return _camera; } }
    private Camera _camera;

    private Vector4 data;

    [SerializeField] private float scale = 0.2f;

    void Update()
    {
        Vector4 viwport = camera.ScreenToViewportPoint(Input.mousePosition - new Vector3(Screen.width * 0.5f, Screen.height * 0.5f));
        spriteRenderer.sharedMaterial.SetVector(SCALE_ID, viwport * scale);
    }
}
