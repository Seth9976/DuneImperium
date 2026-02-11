using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200001C RID: 28
	public sealed class CapsuleCollider2D : Collider2D
	{
		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000359 RID: 857 RVA: 0x0000B730 File Offset: 0x00009930
		// (set) Token: 0x0600035A RID: 858 RVA: 0x000039A7 File Offset: 0x00001BA7
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

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600035B RID: 859 RVA: 0x000039B1 File Offset: 0x00001BB1
		// (set) Token: 0x0600035C RID: 860 RVA: 0x000039C3 File Offset: 0x00001BC3
		public CapsuleDirection2D direction
		{
			get
			{
				return CapsuleCollider2D.get_directionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CapsuleCollider2D.set_directionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600035D RID: 861 RVA: 0x000039D6 File Offset: 0x00001BD6
		public void get_size_Injected(out Vector2 ret)
		{
			CapsuleCollider2D.get_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600035E RID: 862 RVA: 0x000039E9 File Offset: 0x00001BE9
		public void set_size_Injected(ref Vector2 value)
		{
			CapsuleCollider2D.set_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x040001A7 RID: 423
		private static readonly CapsuleCollider2D.get_directionDelegate get_directionDelegateField = IL2CPP.ResolveICall<CapsuleCollider2D.get_directionDelegate>("UnityEngine.CapsuleCollider2D::get_direction");

		// Token: 0x040001A8 RID: 424
		private static readonly CapsuleCollider2D.set_directionDelegate set_directionDelegateField = IL2CPP.ResolveICall<CapsuleCollider2D.set_directionDelegate>("UnityEngine.CapsuleCollider2D::set_direction");

		// Token: 0x040001A9 RID: 425
		private static readonly CapsuleCollider2D.get_size_InjectedDelegate get_size_InjectedDelegateField = IL2CPP.ResolveICall<CapsuleCollider2D.get_size_InjectedDelegate>("UnityEngine.CapsuleCollider2D::get_size_Injected");

		// Token: 0x040001AA RID: 426
		private static readonly CapsuleCollider2D.set_size_InjectedDelegate set_size_InjectedDelegateField = IL2CPP.ResolveICall<CapsuleCollider2D.set_size_InjectedDelegate>("UnityEngine.CapsuleCollider2D::set_size_Injected");

		// Token: 0x02000129 RID: 297
		// (Invoke) Token: 0x0600067E RID: 1662
		private delegate CapsuleDirection2D get_directionDelegate(IntPtr @this);

		// Token: 0x0200012A RID: 298
		// (Invoke) Token: 0x06000680 RID: 1664
		private delegate void set_directionDelegate(IntPtr @this, CapsuleDirection2D value);

		// Token: 0x0200012B RID: 299
		// (Invoke) Token: 0x06000682 RID: 1666
		private delegate void get_size_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200012C RID: 300
		// (Invoke) Token: 0x06000684 RID: 1668
		private delegate void set_size_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
