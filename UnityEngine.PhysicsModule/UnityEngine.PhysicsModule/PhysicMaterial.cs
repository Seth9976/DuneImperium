using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000026 RID: 38
	public class PhysicMaterial : Object
	{
		// Token: 0x0600038F RID: 911 RVA: 0x00003F71 File Offset: 0x00002171
		public static void Internal_CreateDynamicsMaterial(PhysicMaterial mat, string name)
		{
			PhysicMaterial.Internal_CreateDynamicsMaterialDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mat), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000390 RID: 912 RVA: 0x00003F89 File Offset: 0x00002189
		// (set) Token: 0x06000391 RID: 913 RVA: 0x00003F9B File Offset: 0x0000219B
		public float bounciness
		{
			get
			{
				return PhysicMaterial.get_bouncinessDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PhysicMaterial.set_bouncinessDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000392 RID: 914 RVA: 0x00003FAE File Offset: 0x000021AE
		// (set) Token: 0x06000393 RID: 915 RVA: 0x00003FC0 File Offset: 0x000021C0
		public float dynamicFriction
		{
			get
			{
				return PhysicMaterial.get_dynamicFrictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PhysicMaterial.set_dynamicFrictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000394 RID: 916 RVA: 0x00003FD3 File Offset: 0x000021D3
		// (set) Token: 0x06000395 RID: 917 RVA: 0x00003FE5 File Offset: 0x000021E5
		public float staticFriction
		{
			get
			{
				return PhysicMaterial.get_staticFrictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PhysicMaterial.set_staticFrictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000396 RID: 918 RVA: 0x00003FF8 File Offset: 0x000021F8
		// (set) Token: 0x06000397 RID: 919 RVA: 0x0000400A File Offset: 0x0000220A
		public PhysicMaterialCombine frictionCombine
		{
			get
			{
				return PhysicMaterial.get_frictionCombineDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PhysicMaterial.set_frictionCombineDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000398 RID: 920 RVA: 0x0000401D File Offset: 0x0000221D
		// (set) Token: 0x06000399 RID: 921 RVA: 0x0000402F File Offset: 0x0000222F
		public PhysicMaterialCombine bounceCombine
		{
			get
			{
				return PhysicMaterial.get_bounceCombineDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PhysicMaterial.set_bounceCombineDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600039A RID: 922 RVA: 0x0000BE7C File Offset: 0x0000A07C
		// (set) Token: 0x0600039B RID: 923 RVA: 0x00004042 File Offset: 0x00002242
		public float bouncyness
		{
			get
			{
				return this.bounciness;
			}
			set
			{
				this.bounciness = value;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600039C RID: 924 RVA: 0x0000BE94 File Offset: 0x0000A094
		// (set) Token: 0x0600039D RID: 925 RVA: 0x0000404D File Offset: 0x0000224D
		public Vector3 frictionDirection2
		{
			get
			{
				return Vector3.zero;
			}
			set
			{
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600039E RID: 926 RVA: 0x0000BEAC File Offset: 0x0000A0AC
		// (set) Token: 0x0600039F RID: 927 RVA: 0x00004050 File Offset: 0x00002250
		public float dynamicFriction2
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x0000BEC4 File Offset: 0x0000A0C4
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x00004053 File Offset: 0x00002253
		public float staticFriction2
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x0000BEDC File Offset: 0x0000A0DC
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x00004056 File Offset: 0x00002256
		public Vector3 frictionDirection
		{
			get
			{
				return Vector3.zero;
			}
			set
			{
			}
		}

		// Token: 0x0400029A RID: 666
		private static readonly PhysicMaterial.Internal_CreateDynamicsMaterialDelegate Internal_CreateDynamicsMaterialDelegateField = IL2CPP.ResolveICall<PhysicMaterial.Internal_CreateDynamicsMaterialDelegate>("UnityEngine.PhysicMaterial::Internal_CreateDynamicsMaterial");

		// Token: 0x0400029B RID: 667
		private static readonly PhysicMaterial.get_bouncinessDelegate get_bouncinessDelegateField = IL2CPP.ResolveICall<PhysicMaterial.get_bouncinessDelegate>("UnityEngine.PhysicMaterial::get_bounciness");

		// Token: 0x0400029C RID: 668
		private static readonly PhysicMaterial.set_bouncinessDelegate set_bouncinessDelegateField = IL2CPP.ResolveICall<PhysicMaterial.set_bouncinessDelegate>("UnityEngine.PhysicMaterial::set_bounciness");

		// Token: 0x0400029D RID: 669
		private static readonly PhysicMaterial.get_dynamicFrictionDelegate get_dynamicFrictionDelegateField = IL2CPP.ResolveICall<PhysicMaterial.get_dynamicFrictionDelegate>("UnityEngine.PhysicMaterial::get_dynamicFriction");

		// Token: 0x0400029E RID: 670
		private static readonly PhysicMaterial.set_dynamicFrictionDelegate set_dynamicFrictionDelegateField = IL2CPP.ResolveICall<PhysicMaterial.set_dynamicFrictionDelegate>("UnityEngine.PhysicMaterial::set_dynamicFriction");

		// Token: 0x0400029F RID: 671
		private static readonly PhysicMaterial.get_staticFrictionDelegate get_staticFrictionDelegateField = IL2CPP.ResolveICall<PhysicMaterial.get_staticFrictionDelegate>("UnityEngine.PhysicMaterial::get_staticFriction");

		// Token: 0x040002A0 RID: 672
		private static readonly PhysicMaterial.set_staticFrictionDelegate set_staticFrictionDelegateField = IL2CPP.ResolveICall<PhysicMaterial.set_staticFrictionDelegate>("UnityEngine.PhysicMaterial::set_staticFriction");

		// Token: 0x040002A1 RID: 673
		private static readonly PhysicMaterial.get_frictionCombineDelegate get_frictionCombineDelegateField = IL2CPP.ResolveICall<PhysicMaterial.get_frictionCombineDelegate>("UnityEngine.PhysicMaterial::get_frictionCombine");

		// Token: 0x040002A2 RID: 674
		private static readonly PhysicMaterial.set_frictionCombineDelegate set_frictionCombineDelegateField = IL2CPP.ResolveICall<PhysicMaterial.set_frictionCombineDelegate>("UnityEngine.PhysicMaterial::set_frictionCombine");

		// Token: 0x040002A3 RID: 675
		private static readonly PhysicMaterial.get_bounceCombineDelegate get_bounceCombineDelegateField = IL2CPP.ResolveICall<PhysicMaterial.get_bounceCombineDelegate>("UnityEngine.PhysicMaterial::get_bounceCombine");

		// Token: 0x040002A4 RID: 676
		private static readonly PhysicMaterial.set_bounceCombineDelegate set_bounceCombineDelegateField = IL2CPP.ResolveICall<PhysicMaterial.set_bounceCombineDelegate>("UnityEngine.PhysicMaterial::set_bounceCombine");

		// Token: 0x0200016D RID: 365
		// (Invoke) Token: 0x060006B2 RID: 1714
		private delegate void Internal_CreateDynamicsMaterialDelegate(IntPtr mat, IntPtr name);

		// Token: 0x0200016E RID: 366
		// (Invoke) Token: 0x060006B4 RID: 1716
		private delegate float get_bouncinessDelegate(IntPtr @this);

		// Token: 0x0200016F RID: 367
		// (Invoke) Token: 0x060006B6 RID: 1718
		private delegate void set_bouncinessDelegate(IntPtr @this, float value);

		// Token: 0x02000170 RID: 368
		// (Invoke) Token: 0x060006B8 RID: 1720
		private delegate float get_dynamicFrictionDelegate(IntPtr @this);

		// Token: 0x02000171 RID: 369
		// (Invoke) Token: 0x060006BA RID: 1722
		private delegate void set_dynamicFrictionDelegate(IntPtr @this, float value);

		// Token: 0x02000172 RID: 370
		// (Invoke) Token: 0x060006BC RID: 1724
		private delegate float get_staticFrictionDelegate(IntPtr @this);

		// Token: 0x02000173 RID: 371
		// (Invoke) Token: 0x060006BE RID: 1726
		private delegate void set_staticFrictionDelegate(IntPtr @this, float value);

		// Token: 0x02000174 RID: 372
		// (Invoke) Token: 0x060006C0 RID: 1728
		private delegate PhysicMaterialCombine get_frictionCombineDelegate(IntPtr @this);

		// Token: 0x02000175 RID: 373
		// (Invoke) Token: 0x060006C2 RID: 1730
		private delegate void set_frictionCombineDelegate(IntPtr @this, PhysicMaterialCombine value);

		// Token: 0x02000176 RID: 374
		// (Invoke) Token: 0x060006C4 RID: 1732
		private delegate PhysicMaterialCombine get_bounceCombineDelegate(IntPtr @this);

		// Token: 0x02000177 RID: 375
		// (Invoke) Token: 0x060006C6 RID: 1734
		private delegate void set_bounceCombineDelegate(IntPtr @this, PhysicMaterialCombine value);
	}
}
