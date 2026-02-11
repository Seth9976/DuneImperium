using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x020002D3 RID: 723
	public static class RendererExtensions
	{
		// Token: 0x06002D32 RID: 11570 RVA: 0x00011C09 File Offset: 0x0000FE09
		public static void UpdateGIMaterials(Renderer renderer)
		{
			RendererExtensions.UpdateGIMaterialsForRenderer(renderer);
		}

		// Token: 0x06002D33 RID: 11571 RVA: 0x00011C13 File Offset: 0x0000FE13
		public static void UpdateGIMaterialsForRenderer(Renderer renderer)
		{
			RendererExtensions.UpdateGIMaterialsForRendererDelegateField(IL2CPP.Il2CppObjectBaseToPtr(renderer));
		}

		// Token: 0x0400288D RID: 10381
		private static readonly RendererExtensions.UpdateGIMaterialsForRendererDelegate UpdateGIMaterialsForRendererDelegateField = IL2CPP.ResolveICall<RendererExtensions.UpdateGIMaterialsForRendererDelegate>("UnityEngine.RendererExtensions::UpdateGIMaterialsForRenderer");

		// Token: 0x02000B1B RID: 2843
		// (Invoke) Token: 0x06003F2B RID: 16171
		private delegate void UpdateGIMaterialsForRendererDelegate(IntPtr renderer);
	}
}
