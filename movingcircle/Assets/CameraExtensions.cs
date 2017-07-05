using UnityEngine;

public static class CameraExtensions
{
    public static CamBounds GetBounds(this Camera cam, float boundObjRadius = 0)
    {
        return new CamBounds(cam, boundObjRadius);
    }

}

public struct CamBounds
{
    public float Top { get; set; }
    public float Bottom { get; set; }
    public float Left { get; set; }
    public float Right { get; set; }
    public float Aspect { get; set; }

    public CamBounds(Camera cam, float boundObjRadius = 0)
    {
        Top = cam.transform.position.y + cam.orthographicSize - boundObjRadius;
        Bottom = cam.transform.position.y - cam.orthographicSize + boundObjRadius;
        Right = cam.transform.position.x + cam.orthographicSize * cam.aspect - boundObjRadius;
        Left = cam.transform.position.x - cam.orthographicSize * cam.aspect + boundObjRadius;
        Aspect = cam.aspect;
    }
}