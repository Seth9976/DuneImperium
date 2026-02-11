using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000022 RID: 34
	public class AnchoredJoint2D : Joint2D
	{
		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x0000C064 File Offset: 0x0000A264
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x00003F52 File Offset: 0x00002152
		public Vector2 anchor
		{
			get
			{
				Vector2 vector;
				this.get_anchor_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_anchor_Injected(ref value);
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x0000C07C File Offset: 0x0000A27C
		// (set) Token: 0x060003C5 RID: 965 RVA: 0x00003F5C File Offset: 0x0000215C
		public Vector2 connectedAnchor
		{
			get
			{
				Vector2 vector;
				this.get_connectedAnchor_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_connectedAnchor_Injected(ref value);
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x00003F66 File Offset: 0x00002166
		// (set) Token: 0x060003C7 RID: 967 RVA: 0x00003F78 File Offset: 0x00002178
		public bool autoConfigureConnectedAnchor
		{
			get
			{
				return AnchoredJoint2D.get_autoConfigureConnectedAnchorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AnchoredJoint2D.set_autoConfigureConnectedAnchorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00003F8B File Offset: 0x0000218B
		public void get_anchor_Injected(out Vector2 ret)
		{
			AnchoredJoint2D.get_anchor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00003F9E File Offset: 0x0000219E
		public void set_anchor_Injected(ref Vector2 value)
		{
			AnchoredJoint2D.set_anchor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00003FB1 File Offset: 0x000021B1
		public void get_connectedAnchor_Injected(out Vector2 ret)
		{
			AnchoredJoint2D.get_connectedAnchor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00003FC4 File Offset: 0x000021C4
		public void set_connectedAnchor_Injected(ref Vector2 value)
		{
			AnchoredJoint2D.set_connectedAnchor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x040001F1 RID: 497
		private static readonly AnchoredJoint2D.get_autoConfigureConnectedAnchorDelegate get_autoConfigureConnectedAnchorDelegateField = IL2CPP.ResolveICall<AnchoredJoint2D.get_autoConfigureConnectedAnchorDelegate>("UnityEngine.AnchoredJoint2D::get_autoConfigureConnectedAnchor");

		// Token: 0x040001F2 RID: 498
		private static readonly AnchoredJoint2D.set_autoConfigureConnectedAnchorDelegate set_autoConfigureConnectedAnchorDelegateField = IL2CPP.ResolveICall<AnchoredJoint2D.set_autoConfigureConnectedAnchorDelegate>("UnityEngine.AnchoredJoint2D::set_autoConfigureConnectedAnchor");

		// Token: 0x040001F3 RID: 499
		private static readonly AnchoredJoint2D.get_anchor_InjectedDelegate get_anchor_InjectedDelegateField = IL2CPP.ResolveICall<AnchoredJoint2D.get_anchor_InjectedDelegate>("UnityEngine.AnchoredJoint2D::get_anchor_Injected");

		// Token: 0x040001F4 RID: 500
		private static readonly AnchoredJoint2D.set_anchor_InjectedDelegate set_anchor_InjectedDelegateField = IL2CPP.ResolveICall<AnchoredJoint2D.set_anchor_InjectedDelegate>("UnityEngine.AnchoredJoint2D::set_anchor_Injected");

		// Token: 0x040001F5 RID: 501
		private static readonly AnchoredJoint2D.get_connectedAnchor_InjectedDelegate get_connectedAnchor_InjectedDelegateField = IL2CPP.ResolveICall<AnchoredJoint2D.get_connectedAnchor_InjectedDelegate>("UnityEngine.AnchoredJoint2D::get_connectedAnchor_Injected");

		// Token: 0x040001F6 RID: 502
		private static readonly AnchoredJoint2D.set_connectedAnchor_InjectedDelegate set_connectedAnchor_InjectedDelegateField = IL2CPP.ResolveICall<AnchoredJoint2D.set_connectedAnchor_InjectedDelegate>("UnityEngine.AnchoredJoint2D::set_connectedAnchor_Injected");

		// Token: 0x02000175 RID: 373
		// (Invoke) Token: 0x06000712 RID: 1810
		private delegate bool get_autoConfigureConnectedAnchorDelegate(IntPtr @this);

		// Token: 0x02000176 RID: 374
		// (Invoke) Token: 0x06000714 RID: 1812
		private delegate void set_autoConfigureConnectedAnchorDelegate(IntPtr @this, bool value);

		// Token: 0x02000177 RID: 375
		// (Invoke) Token: 0x06000716 RID: 1814
		private delegate void get_anchor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000178 RID: 376
		// (Invoke) Token: 0x06000718 RID: 1816
		private delegate void set_anchor_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000179 RID: 377
		// (Invoke) Token: 0x0600071A RID: 1818
		private delegate void get_connectedAnchor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200017A RID: 378
		// (Invoke) Token: 0x0600071C RID: 1820
		private delegate void set_connectedAnchor_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
