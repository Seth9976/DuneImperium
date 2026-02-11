using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x020002D9 RID: 729
	public sealed class OcclusionArea : Component
	{
		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06002D38 RID: 11576 RVA: 0x000B34B4 File Offset: 0x000B16B4
		// (set) Token: 0x06002D39 RID: 11577 RVA: 0x00011CA8 File Offset: 0x0000FEA8
		public Vector3 center
		{
			get
			{
				Vector3 vector;
				this.get_center_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_center_Injected(ref value);
			}
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06002D3A RID: 11578 RVA: 0x000B34CC File Offset: 0x000B16CC
		// (set) Token: 0x06002D3B RID: 11579 RVA: 0x00011CB2 File Offset: 0x0000FEB2
		public Vector3 size
		{
			get
			{
				Vector3 vector;
				this.get_size_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_size_Injected(ref value);
			}
		}

		// Token: 0x06002D3C RID: 11580 RVA: 0x00011CBC File Offset: 0x0000FEBC
		public void get_center_Injected(out Vector3 ret)
		{
			OcclusionArea.get_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06002D3D RID: 11581 RVA: 0x00011CCF File Offset: 0x0000FECF
		public void set_center_Injected(ref Vector3 value)
		{
			OcclusionArea.set_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06002D3E RID: 11582 RVA: 0x00011CE2 File Offset: 0x0000FEE2
		public void get_size_Injected(out Vector3 ret)
		{
			OcclusionArea.get_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06002D3F RID: 11583 RVA: 0x00011CF5 File Offset: 0x0000FEF5
		public void set_size_Injected(ref Vector3 value)
		{
			OcclusionArea.set_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04002890 RID: 10384
		private static readonly OcclusionArea.get_center_InjectedDelegate get_center_InjectedDelegateField = IL2CPP.ResolveICall<OcclusionArea.get_center_InjectedDelegate>("UnityEngine.OcclusionArea::get_center_Injected");

		// Token: 0x04002891 RID: 10385
		private static readonly OcclusionArea.set_center_InjectedDelegate set_center_InjectedDelegateField = IL2CPP.ResolveICall<OcclusionArea.set_center_InjectedDelegate>("UnityEngine.OcclusionArea::set_center_Injected");

		// Token: 0x04002892 RID: 10386
		private static readonly OcclusionArea.get_size_InjectedDelegate get_size_InjectedDelegateField = IL2CPP.ResolveICall<OcclusionArea.get_size_InjectedDelegate>("UnityEngine.OcclusionArea::get_size_Injected");

		// Token: 0x04002893 RID: 10387
		private static readonly OcclusionArea.set_size_InjectedDelegate set_size_InjectedDelegateField = IL2CPP.ResolveICall<OcclusionArea.set_size_InjectedDelegate>("UnityEngine.OcclusionArea::set_size_Injected");

		// Token: 0x02000B1E RID: 2846
		// (Invoke) Token: 0x06003F31 RID: 16177
		private delegate void get_center_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000B1F RID: 2847
		// (Invoke) Token: 0x06003F33 RID: 16179
		private delegate void set_center_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000B20 RID: 2848
		// (Invoke) Token: 0x06003F35 RID: 16181
		private delegate void get_size_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000B21 RID: 2849
		// (Invoke) Token: 0x06003F37 RID: 16183
		private delegate void set_size_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
