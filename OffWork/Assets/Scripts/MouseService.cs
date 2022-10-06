using UnityEngine;

public class MouseService
{
    private readonly Camera _mainCamera;
    
    public MouseService()
    {
        _mainCamera = Camera.main;    
    }

    private Vector2 GetMousePositionInWorldSpace() =>
        _mainCamera.ScreenToWorldPoint(Input.mousePosition);

    public Vector2 GetToMouseDirectionNormalized(Vector2 origin) =>
        GetToMouseDirection(origin).normalized;
    public Vector2 GetToMouseDirection(Vector2 origin) =>
        (GetMousePositionInWorldSpace() - origin);
}