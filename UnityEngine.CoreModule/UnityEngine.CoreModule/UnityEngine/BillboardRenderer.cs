using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x020002CE RID: 718
	public sealed class BillboardRenderer : Renderer
	{
		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06002D2F RID: 11567 RVA: 0x000B3488 File Offset: 0x000B1688
		// (set) Token: 0x06002D30 RID: 11568 RVA: 0x00011BE0 File Offset: 0x0000FDE0
		public BillboardAsset billboard
		{
			get
			{
				IntPtr intPtr = BillboardRenderer.get_billboardDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BillboardAsset>(intPtr2) : null;
			}
			set
			{
				BillboardRenderer.set_billboardDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002881 RID: 10369
		private static readonly BillboardRenderer.get_billboardDelegate get_billboardDelegateField = IL2CPP.ResolveICall<BillboardRenderer.get_billboardDelegate>("UnityEngine.BillboardRenderer::get_billboard");

		// Token: 0x04002882 RID: 10370
		private static readonly BillboardRenderer.set_billboardDelegate set_billboardDelegateField = IL2CPP.ResolveICall<BillboardRenderer.set_billboardDelegate>("UnityEngine.BillboardRenderer::set_billboard");

		// Token: 0x02000B19 RID: 2841
		// (Invoke) Token: 0x06003F27 RID: 16167
		private delegate IntPtr get_billboardDelegate(IntPtr @this);

		// Token: 0x02000B1A RID: 2842
		// (Invoke) Token: 0x06003F29 RID: 16169
		private delegate void set_billboardDelegate(IntPtr @this, IntPtr value);
	}
}
