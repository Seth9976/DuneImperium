using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000043 RID: 67
	public sealed class AvatarMask : Object
	{
		// Token: 0x06000488 RID: 1160 RVA: 0x00003994 File Offset: 0x00001B94
		public static void Internal_Create(AvatarMask self)
		{
			AvatarMask.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x00012960 File Offset: 0x00010B60
		public int humanoidBodyPartCount
		{
			get
			{
				return 13;
			}
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x000039A6 File Offset: 0x00001BA6
		public bool GetHumanoidBodyPartActive(AvatarMaskBodyPart index)
		{
			return AvatarMask.GetHumanoidBodyPartActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x000039B9 File Offset: 0x00001BB9
		public void SetHumanoidBodyPartActive(AvatarMaskBodyPart index, bool value)
		{
			AvatarMask.SetHumanoidBodyPartActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, value);
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x000039CD File Offset: 0x00001BCD
		// (set) Token: 0x0600048D RID: 1165 RVA: 0x000039DF File Offset: 0x00001BDF
		public int transformCount
		{
			get
			{
				return AvatarMask.get_transformCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AvatarMask.set_transformCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x000039F2 File Offset: 0x00001BF2
		public void AddTransformPath(Transform transform)
		{
			this.AddTransformPath(transform, true);
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x000039FE File Offset: 0x00001BFE
		public void AddTransformPath(Transform transform, bool recursive)
		{
			AvatarMask.AddTransformPathDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(transform), recursive);
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00003A17 File Offset: 0x00001C17
		public void RemoveTransformPath(Transform transform)
		{
			this.RemoveTransformPath(transform, true);
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00003A23 File Offset: 0x00001C23
		public void RemoveTransformPath(Transform transform, bool recursive)
		{
			AvatarMask.RemoveTransformPathDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(transform), recursive);
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00012974 File Offset: 0x00010B74
		public string GetTransformPath(int index)
		{
			IntPtr intPtr = AvatarMask.GetTransformPathDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00003A3C File Offset: 0x00001C3C
		public void SetTransformPath(int index, string path)
		{
			AvatarMask.SetTransformPathDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, IL2CPP.ManagedStringToIl2Cpp(path));
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00003A55 File Offset: 0x00001C55
		public float GetTransformWeight(int index)
		{
			return AvatarMask.GetTransformWeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00003A68 File Offset: 0x00001C68
		public void SetTransformWeight(int index, float weight)
		{
			AvatarMask.SetTransformWeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, weight);
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x0001299C File Offset: 0x00010B9C
		public bool GetTransformActive(int index)
		{
			return this.GetTransformWeight(index) > 0.5f;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00003A7C File Offset: 0x00001C7C
		public void SetTransformActive(int index, bool value)
		{
			this.SetTransformWeight(index, value ? 1f : 0f);
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x00003A96 File Offset: 0x00001C96
		public bool hasFeetIK
		{
			get
			{
				return AvatarMask.get_hasFeetIKDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x000129BC File Offset: 0x00010BBC
		public void Copy(AvatarMask other)
		{
			for (AvatarMaskBodyPart avatarMaskBodyPart = AvatarMaskBodyPart.Root; avatarMaskBodyPart < AvatarMaskBodyPart.LastBodyPart; avatarMaskBodyPart++)
			{
				this.SetHumanoidBodyPartActive(avatarMaskBodyPart, other.GetHumanoidBodyPartActive(avatarMaskBodyPart));
			}
			this.transformCount = other.transformCount;
			for (int i = 0; i < other.transformCount; i++)
			{
				this.SetTransformPath(i, other.GetTransformPath(i));
				this.SetTransformActive(i, other.GetTransformActive(i));
			}
		}

		// Token: 0x040003F0 RID: 1008
		private static readonly AvatarMask.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<AvatarMask.Internal_CreateDelegate>("UnityEngine.AvatarMask::Internal_Create");

		// Token: 0x040003F1 RID: 1009
		private static readonly AvatarMask.GetHumanoidBodyPartActiveDelegate GetHumanoidBodyPartActiveDelegateField = IL2CPP.ResolveICall<AvatarMask.GetHumanoidBodyPartActiveDelegate>("UnityEngine.AvatarMask::GetHumanoidBodyPartActive");

		// Token: 0x040003F2 RID: 1010
		private static readonly AvatarMask.SetHumanoidBodyPartActiveDelegate SetHumanoidBodyPartActiveDelegateField = IL2CPP.ResolveICall<AvatarMask.SetHumanoidBodyPartActiveDelegate>("UnityEngine.AvatarMask::SetHumanoidBodyPartActive");

		// Token: 0x040003F3 RID: 1011
		private static readonly AvatarMask.get_transformCountDelegate get_transformCountDelegateField = IL2CPP.ResolveICall<AvatarMask.get_transformCountDelegate>("UnityEngine.AvatarMask::get_transformCount");

		// Token: 0x040003F4 RID: 1012
		private static readonly AvatarMask.set_transformCountDelegate set_transformCountDelegateField = IL2CPP.ResolveICall<AvatarMask.set_transformCountDelegate>("UnityEngine.AvatarMask::set_transformCount");

		// Token: 0x040003F5 RID: 1013
		private static readonly AvatarMask.AddTransformPathDelegate AddTransformPathDelegateField = IL2CPP.ResolveICall<AvatarMask.AddTransformPathDelegate>("UnityEngine.AvatarMask::AddTransformPath");

		// Token: 0x040003F6 RID: 1014
		private static readonly AvatarMask.RemoveTransformPathDelegate RemoveTransformPathDelegateField = IL2CPP.ResolveICall<AvatarMask.RemoveTransformPathDelegate>("UnityEngine.AvatarMask::RemoveTransformPath");

		// Token: 0x040003F7 RID: 1015
		private static readonly AvatarMask.GetTransformPathDelegate GetTransformPathDelegateField = IL2CPP.ResolveICall<AvatarMask.GetTransformPathDelegate>("UnityEngine.AvatarMask::GetTransformPath");

		// Token: 0x040003F8 RID: 1016
		private static readonly AvatarMask.SetTransformPathDelegate SetTransformPathDelegateField = IL2CPP.ResolveICall<AvatarMask.SetTransformPathDelegate>("UnityEngine.AvatarMask::SetTransformPath");

		// Token: 0x040003F9 RID: 1017
		private static readonly AvatarMask.GetTransformWeightDelegate GetTransformWeightDelegateField = IL2CPP.ResolveICall<AvatarMask.GetTransformWeightDelegate>("UnityEngine.AvatarMask::GetTransformWeight");

		// Token: 0x040003FA RID: 1018
		private static readonly AvatarMask.SetTransformWeightDelegate SetTransformWeightDelegateField = IL2CPP.ResolveICall<AvatarMask.SetTransformWeightDelegate>("UnityEngine.AvatarMask::SetTransformWeight");

		// Token: 0x040003FB RID: 1019
		private static readonly AvatarMask.get_hasFeetIKDelegate get_hasFeetIKDelegateField = IL2CPP.ResolveICall<AvatarMask.get_hasFeetIKDelegate>("UnityEngine.AvatarMask::get_hasFeetIK");

		// Token: 0x02000122 RID: 290
		// (Invoke) Token: 0x06000721 RID: 1825
		private delegate void Internal_CreateDelegate(IntPtr self);

		// Token: 0x02000123 RID: 291
		// (Invoke) Token: 0x06000723 RID: 1827
		private delegate bool GetHumanoidBodyPartActiveDelegate(IntPtr @this, AvatarMaskBodyPart index);

		// Token: 0x02000124 RID: 292
		// (Invoke) Token: 0x06000725 RID: 1829
		private delegate void SetHumanoidBodyPartActiveDelegate(IntPtr @this, AvatarMaskBodyPart index, bool value);

		// Token: 0x02000125 RID: 293
		// (Invoke) Token: 0x06000727 RID: 1831
		private delegate int get_transformCountDelegate(IntPtr @this);

		// Token: 0x02000126 RID: 294
		// (Invoke) Token: 0x06000729 RID: 1833
		private delegate void set_transformCountDelegate(IntPtr @this, int value);

		// Token: 0x02000127 RID: 295
		// (Invoke) Token: 0x0600072B RID: 1835
		private delegate void AddTransformPathDelegate(IntPtr @this, IntPtr transform, bool recursive);

		// Token: 0x02000128 RID: 296
		// (Invoke) Token: 0x0600072D RID: 1837
		private delegate void RemoveTransformPathDelegate(IntPtr @this, IntPtr transform, bool recursive);

		// Token: 0x02000129 RID: 297
		// (Invoke) Token: 0x0600072F RID: 1839
		private delegate IntPtr GetTransformPathDelegate(IntPtr @this, int index);

		// Token: 0x0200012A RID: 298
		// (Invoke) Token: 0x06000731 RID: 1841
		private delegate void SetTransformPathDelegate(IntPtr @this, int index, IntPtr path);

		// Token: 0x0200012B RID: 299
		// (Invoke) Token: 0x06000733 RID: 1843
		private delegate float GetTransformWeightDelegate(IntPtr @this, int index);

		// Token: 0x0200012C RID: 300
		// (Invoke) Token: 0x06000735 RID: 1845
		private delegate void SetTransformWeightDelegate(IntPtr @this, int index, float weight);

		// Token: 0x0200012D RID: 301
		// (Invoke) Token: 0x06000737 RID: 1847
		private delegate bool get_hasFeetIKDelegate(IntPtr @this);
	}
}
