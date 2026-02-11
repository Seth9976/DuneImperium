using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x020002D8 RID: 728
	public sealed class OcclusionPortal : Component
	{
		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06002D35 RID: 11573 RVA: 0x00011C45 File Offset: 0x0000FE45
		// (set) Token: 0x06002D36 RID: 11574 RVA: 0x00011C57 File Offset: 0x0000FE57
		public bool open
		{
			get
			{
				return OcclusionPortal.get_openDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				OcclusionPortal.set_openDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0400288E RID: 10382
		private static readonly OcclusionPortal.get_openDelegate get_openDelegateField = IL2CPP.ResolveICall<OcclusionPortal.get_openDelegate>("UnityEngine.OcclusionPortal::get_open");

		// Token: 0x0400288F RID: 10383
		private static readonly OcclusionPortal.set_openDelegate set_openDelegateField = IL2CPP.ResolveICall<OcclusionPortal.set_openDelegate>("UnityEngine.OcclusionPortal::set_open");

		// Token: 0x02000B1C RID: 2844
		// (Invoke) Token: 0x06003F2D RID: 16173
		private delegate bool get_openDelegate(IntPtr @this);

		// Token: 0x02000B1D RID: 2845
		// (Invoke) Token: 0x06003F2F RID: 16175
		private delegate void set_openDelegate(IntPtr @this, bool value);
	}
}
