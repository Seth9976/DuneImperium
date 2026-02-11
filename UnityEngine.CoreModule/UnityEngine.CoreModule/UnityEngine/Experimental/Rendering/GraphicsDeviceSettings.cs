using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x0200036B RID: 875
	public static class GraphicsDeviceSettings
	{
		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06002F44 RID: 12100 RVA: 0x00012EF2 File Offset: 0x000110F2
		// (set) Token: 0x06002F45 RID: 12101 RVA: 0x00012EFE File Offset: 0x000110FE
		public static WaitForPresentSyncPoint waitForPresentSyncPoint
		{
			get
			{
				return GraphicsDeviceSettings.get_waitForPresentSyncPointDelegateField();
			}
			set
			{
				GraphicsDeviceSettings.set_waitForPresentSyncPointDelegateField(value);
			}
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06002F46 RID: 12102 RVA: 0x00012F0B File Offset: 0x0001110B
		// (set) Token: 0x06002F47 RID: 12103 RVA: 0x00012F17 File Offset: 0x00011117
		public static GraphicsJobsSyncPoint graphicsJobsSyncPoint
		{
			get
			{
				return GraphicsDeviceSettings.get_graphicsJobsSyncPointDelegateField();
			}
			set
			{
				GraphicsDeviceSettings.set_graphicsJobsSyncPointDelegateField(value);
			}
		}

		// Token: 0x04002A6F RID: 10863
		private static readonly GraphicsDeviceSettings.get_waitForPresentSyncPointDelegate get_waitForPresentSyncPointDelegateField = IL2CPP.ResolveICall<GraphicsDeviceSettings.get_waitForPresentSyncPointDelegate>("UnityEngine.Experimental.Rendering.GraphicsDeviceSettings::get_waitForPresentSyncPoint");

		// Token: 0x04002A70 RID: 10864
		private static readonly GraphicsDeviceSettings.set_waitForPresentSyncPointDelegate set_waitForPresentSyncPointDelegateField = IL2CPP.ResolveICall<GraphicsDeviceSettings.set_waitForPresentSyncPointDelegate>("UnityEngine.Experimental.Rendering.GraphicsDeviceSettings::set_waitForPresentSyncPoint");

		// Token: 0x04002A71 RID: 10865
		private static readonly GraphicsDeviceSettings.get_graphicsJobsSyncPointDelegate get_graphicsJobsSyncPointDelegateField = IL2CPP.ResolveICall<GraphicsDeviceSettings.get_graphicsJobsSyncPointDelegate>("UnityEngine.Experimental.Rendering.GraphicsDeviceSettings::get_graphicsJobsSyncPoint");

		// Token: 0x04002A72 RID: 10866
		private static readonly GraphicsDeviceSettings.set_graphicsJobsSyncPointDelegate set_graphicsJobsSyncPointDelegateField = IL2CPP.ResolveICall<GraphicsDeviceSettings.set_graphicsJobsSyncPointDelegate>("UnityEngine.Experimental.Rendering.GraphicsDeviceSettings::set_graphicsJobsSyncPoint");

		// Token: 0x02000BAE RID: 2990
		// (Invoke) Token: 0x0600404D RID: 16461
		private delegate WaitForPresentSyncPoint get_waitForPresentSyncPointDelegate();

		// Token: 0x02000BAF RID: 2991
		// (Invoke) Token: 0x0600404F RID: 16463
		private delegate void set_waitForPresentSyncPointDelegate(WaitForPresentSyncPoint value);

		// Token: 0x02000BB0 RID: 2992
		// (Invoke) Token: 0x06004051 RID: 16465
		private delegate GraphicsJobsSyncPoint get_graphicsJobsSyncPointDelegate();

		// Token: 0x02000BB1 RID: 2993
		// (Invoke) Token: 0x06004053 RID: 16467
		private delegate void set_graphicsJobsSyncPointDelegate(GraphicsJobsSyncPoint value);
	}
}
