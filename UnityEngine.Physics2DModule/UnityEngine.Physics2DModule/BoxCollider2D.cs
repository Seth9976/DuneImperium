using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200001E RID: 30
	public sealed class BoxCollider2D : Collider2D
	{
		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000376 RID: 886 RVA: 0x0000B918 File Offset: 0x00009B18
		// (set) Token: 0x06000377 RID: 887 RVA: 0x00003B49 File Offset: 0x00001D49
		public Vector2 size
		{
			get
			{
				Vector2 vector;
				this.get_size_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_size_Injected(ref value);
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000378 RID: 888 RVA: 0x00003B53 File Offset: 0x00001D53
		// (set) Token: 0x06000379 RID: 889 RVA: 0x00003B65 File Offset: 0x00001D65
		public float edgeRadius
		{
			get
			{
				return BoxCollider2D.get_edgeRadiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BoxCollider2D.set_edgeRadiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600037A RID: 890 RVA: 0x00003B78 File Offset: 0x00001D78
		// (set) Token: 0x0600037B RID: 891 RVA: 0x00003B8A File Offset: 0x00001D8A
		public bool autoTiling
		{
			get
			{
				return BoxCollider2D.get_autoTilingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BoxCollider2D.set_autoTilingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600037C RID: 892 RVA: 0x0000B930 File Offset: 0x00009B30
		// (set) Token: 0x0600037D RID: 893 RVA: 0x00003B9D File Offset: 0x00001D9D
		public Vector2 center
		{
			get
			{
				return Vector2.zero;
			}
			set
			{
			}
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00003BA0 File Offset: 0x00001DA0
		public void get_size_Injected(out Vector2 ret)
		{
			BoxCollider2D.get_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00003BB3 File Offset: 0x00001DB3
		public void set_size_Injected(ref Vector2 value)
		{
			BoxCollider2D.set_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x040001BC RID: 444
		private static readonly BoxCollider2D.get_edgeRadiusDelegate get_edgeRadiusDelegateField = IL2CPP.ResolveICall<BoxCollider2D.get_edgeRadiusDelegate>("UnityEngine.BoxCollider2D::get_edgeRadius");

		// Token: 0x040001BD RID: 445
		private static readonly BoxCollider2D.set_edgeRadiusDelegate set_edgeRadiusDelegateField = IL2CPP.ResolveICall<BoxCollider2D.set_edgeRadiusDelegate>("UnityEngine.BoxCollider2D::set_edgeRadius");

		// Token: 0x040001BE RID: 446
		private static readonly BoxCollider2D.get_autoTilingDelegate get_autoTilingDelegateField = IL2CPP.ResolveICall<BoxCollider2D.get_autoTilingDelegate>("UnityEngine.BoxCollider2D::get_autoTiling");

		// Token: 0x040001BF RID: 447
		private static readonly BoxCollider2D.set_autoTilingDelegate set_autoTilingDelegateField = IL2CPP.ResolveICall<BoxCollider2D.set_autoTilingDelegate>("UnityEngine.BoxCollider2D::set_autoTiling");

		// Token: 0x040001C0 RID: 448
		private static readonly BoxCollider2D.get_size_InjectedDelegate get_size_InjectedDelegateField = IL2CPP.ResolveICall<BoxCollider2D.get_size_InjectedDelegate>("UnityEngine.BoxCollider2D::get_size_Injected");

		// Token: 0x040001C1 RID: 449
		private static readonly BoxCollider2D.set_size_InjectedDelegate set_size_InjectedDelegateField = IL2CPP.ResolveICall<BoxCollider2D.set_size_InjectedDelegate>("UnityEngine.BoxCollider2D::set_size_Injected");

		// Token: 0x0200013E RID: 318
		// (Invoke) Token: 0x060006A8 RID: 1704
		private delegate float get_edgeRadiusDelegate(IntPtr @this);

		// Token: 0x0200013F RID: 319
		// (Invoke) Token: 0x060006AA RID: 1706
		private delegate void set_edgeRadiusDelegate(IntPtr @this, float value);

		// Token: 0x02000140 RID: 320
		// (Invoke) Token: 0x060006AC RID: 1708
		private delegate bool get_autoTilingDelegate(IntPtr @this);

		// Token: 0x02000141 RID: 321
		// (Invoke) Token: 0x060006AE RID: 1710
		private delegate void set_autoTilingDelegate(IntPtr @this, bool value);

		// Token: 0x02000142 RID: 322
		// (Invoke) Token: 0x060006B0 RID: 1712
		private delegate void get_size_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000143 RID: 323
		// (Invoke) Token: 0x060006B2 RID: 1714
		private delegate void set_size_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
