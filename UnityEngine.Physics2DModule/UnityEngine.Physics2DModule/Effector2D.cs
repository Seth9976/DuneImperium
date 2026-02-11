using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200002C RID: 44
	public class Effector2D : Behaviour
	{
		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x000045C2 File Offset: 0x000027C2
		// (set) Token: 0x0600042B RID: 1067 RVA: 0x000045D4 File Offset: 0x000027D4
		public bool useColliderMask
		{
			get
			{
				return Effector2D.get_useColliderMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Effector2D.set_useColliderMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x000045E7 File Offset: 0x000027E7
		// (set) Token: 0x0600042D RID: 1069 RVA: 0x000045F9 File Offset: 0x000027F9
		public int colliderMask
		{
			get
			{
				return Effector2D.get_colliderMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Effector2D.set_colliderMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x0000460C File Offset: 0x0000280C
		public bool requiresCollider
		{
			get
			{
				return Effector2D.get_requiresColliderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x0000461E File Offset: 0x0000281E
		public bool designedForTrigger
		{
			get
			{
				return Effector2D.get_designedForTriggerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x00004630 File Offset: 0x00002830
		public bool designedForNonTrigger
		{
			get
			{
				return Effector2D.get_designedForNonTriggerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x04000244 RID: 580
		private static readonly Effector2D.get_useColliderMaskDelegate get_useColliderMaskDelegateField = IL2CPP.ResolveICall<Effector2D.get_useColliderMaskDelegate>("UnityEngine.Effector2D::get_useColliderMask");

		// Token: 0x04000245 RID: 581
		private static readonly Effector2D.set_useColliderMaskDelegate set_useColliderMaskDelegateField = IL2CPP.ResolveICall<Effector2D.set_useColliderMaskDelegate>("UnityEngine.Effector2D::set_useColliderMask");

		// Token: 0x04000246 RID: 582
		private static readonly Effector2D.get_colliderMaskDelegate get_colliderMaskDelegateField = IL2CPP.ResolveICall<Effector2D.get_colliderMaskDelegate>("UnityEngine.Effector2D::get_colliderMask");

		// Token: 0x04000247 RID: 583
		private static readonly Effector2D.set_colliderMaskDelegate set_colliderMaskDelegateField = IL2CPP.ResolveICall<Effector2D.set_colliderMaskDelegate>("UnityEngine.Effector2D::set_colliderMask");

		// Token: 0x04000248 RID: 584
		private static readonly Effector2D.get_requiresColliderDelegate get_requiresColliderDelegateField = IL2CPP.ResolveICall<Effector2D.get_requiresColliderDelegate>("UnityEngine.Effector2D::get_requiresCollider");

		// Token: 0x04000249 RID: 585
		private static readonly Effector2D.get_designedForTriggerDelegate get_designedForTriggerDelegateField = IL2CPP.ResolveICall<Effector2D.get_designedForTriggerDelegate>("UnityEngine.Effector2D::get_designedForTrigger");

		// Token: 0x0400024A RID: 586
		private static readonly Effector2D.get_designedForNonTriggerDelegate get_designedForNonTriggerDelegateField = IL2CPP.ResolveICall<Effector2D.get_designedForNonTriggerDelegate>("UnityEngine.Effector2D::get_designedForNonTrigger");

		// Token: 0x020001C8 RID: 456
		// (Invoke) Token: 0x060007B8 RID: 1976
		private delegate bool get_useColliderMaskDelegate(IntPtr @this);

		// Token: 0x020001C9 RID: 457
		// (Invoke) Token: 0x060007BA RID: 1978
		private delegate void set_useColliderMaskDelegate(IntPtr @this, bool value);

		// Token: 0x020001CA RID: 458
		// (Invoke) Token: 0x060007BC RID: 1980
		private delegate int get_colliderMaskDelegate(IntPtr @this);

		// Token: 0x020001CB RID: 459
		// (Invoke) Token: 0x060007BE RID: 1982
		private delegate void set_colliderMaskDelegate(IntPtr @this, int value);

		// Token: 0x020001CC RID: 460
		// (Invoke) Token: 0x060007C0 RID: 1984
		private delegate bool get_requiresColliderDelegate(IntPtr @this);

		// Token: 0x020001CD RID: 461
		// (Invoke) Token: 0x060007C2 RID: 1986
		private delegate bool get_designedForTriggerDelegate(IntPtr @this);

		// Token: 0x020001CE RID: 462
		// (Invoke) Token: 0x060007C4 RID: 1988
		private delegate bool get_designedForNonTriggerDelegate(IntPtr @this);
	}
}
