using Microsoft.Xna.Framework;
using Nez;
using Nez.Sprites;

public class ExampleScene : Scene
{
    Entity Logo;
    public override void OnStart()
    {
        base.OnStart();

        ClearColor = new Color(20, 20, 34);

        Logo = AddEntity(new Entity());
        Logo.AddComponent(new SpriteRenderer(Content.LoadTexture("Content/nez.png")));
        Logo.Transform.SetScale(8f);

        Camera.Position = Logo.Position;
    }
    public override void Update()
    {
        base.Update();

        if(Logo != null)
            Logo.Transform.Rotation = Mathf.Sin(Time.TimeSinceSceneLoad * 2f) * 0.4f;
    }
}