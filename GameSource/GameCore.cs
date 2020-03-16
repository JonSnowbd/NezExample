using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Nez;
using Nez.ImGuiTools;

namespace GameSource
{
	public class GameCore : Core
	{
		public static VirtualButton DebugToggle;
		override protected void Initialize()
		{
			base.Initialize();

			// Toggles ImGui Inspector
			DebugToggle = new VirtualButton().AddKeyboardKey(Keys.F1);

			// Adding the ImGui manager with a minimal approach.
			var mgr = new ImGuiManager();
			mgr.ShowSeperateGameWindow = false;
			mgr.ShowCoreWindow = false;

			RegisterGlobalManager(mgr);
			mgr.SetEnabled(false);

			// Finally move into the example scene. Change this to wherever you wanna go!
			Scene = new ExampleScene();
		}

		protected override void Update(GameTime gameTime)
		{
			base.Update(gameTime);
			if (DebugToggle.IsPressed)
			{
				var mgr = GetGlobalManager<ImGuiManager>();
				var newstate = !mgr.Enabled;
				mgr.SetEnabled(newstate);
				DebugRenderEnabled = newstate;
			}
		}
	}
}
