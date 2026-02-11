using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000034 RID: 52
	public sealed class PhysicsMaterial2D : Object
	{
		// Token: 0x06000492 RID: 1170 RVA: 0x00004C0D File Offset: 0x00002E0D
		public static void Create_Internal(PhysicsMaterial2D scriptMaterial, string name)
		{
			PhysicsMaterial2D.Create_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(scriptMaterial), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x00004C25 File Offset: 0x00002E25
		// (set) Token: 0x06000494 RID: 1172 RVA: 0x00004C37 File Offset: 0x00002E37
		public float bounciness
		{
			get
			{
				return PhysicsMaterial2D.get_bouncinessDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PhysicsMaterial2D.set_bouncinessDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x00004C4A File Offset: 0x00002E4A
		// (set) Token: 0x06000496 RID: 1174 RVA: 0x00004C5C File Offset: 0x00002E5C
		public float friction
		{
			get
			{
				return PhysicsMaterial2D.get_frictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PhysicsMaterial2D.set_frictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x04000297 RID: 663
		private static readonly PhysicsMaterial2D.Create_InternalDelegate Create_InternalDelegateField = IL2CPP.ResolveICall<PhysicsMaterial2D.Create_InternalDelegate>("UnityEngine.PhysicsMaterial2D::Create_Internal");

		// Token: 0x04000298 RID: 664
		private static readonly PhysicsMaterial2D.get_bouncinessDelegate get_bouncinessDelegateField = IL2CPP.ResolveICall<PhysicsMaterial2D.get_bouncinessDelegate>("UnityEngine.PhysicsMaterial2D::get_bounciness");

		// Token: 0x04000299 RID: 665
		private static readonly PhysicsMaterial2D.set_bouncinessDelegate set_bouncinessDelegateField = IL2CPP.ResolveICall<PhysicsMaterial2D.set_bouncinessDelegate>("UnityEngine.PhysicsMaterial2D::set_bounciness");

		// Token: 0x0400029A RID: 666
		private static readonly PhysicsMaterial2D.get_frictionDelegate get_frictionDelegateField = IL2CPP.ResolveICall<PhysicsMaterial2D.get_frictionDelegate>("UnityEngine.PhysicsMaterial2D::get_friction");

		// Token: 0x0400029B RID: 667
		private static readonly PhysicsMaterial2D.set_frictionDelegate set_frictionDelegateField = IL2CPP.ResolveICall<PhysicsMaterial2D.set_frictionDelegate>("UnityEngine.PhysicsMaterial2D::set_friction");

		// Token: 0x0200021B RID: 539
		// (Invoke) Token: 0x0600085E RID: 2142
		private delegate void Create_InternalDelegate(IntPtr scriptMaterial, IntPtr name);

		// Token: 0x0200021C RID: 540
		// (Invoke) Token: 0x06000860 RID: 2144
		private delegate float get_bouncinessDelegate(IntPtr @this);

		// Token: 0x0200021D RID: 541
		// (Invoke) Token: 0x06000862 RID: 2146
		private delegate void set_bouncinessDelegate(IntPtr @this, float value);

		// Token: 0x0200021E RID: 542
		// (Invoke) Token: 0x06000864 RID: 2148
		private delegate float get_frictionDelegate(IntPtr @this);

		// Token: 0x0200021F RID: 543
		// (Invoke) Token: 0x06000866 RID: 2150
		private delegate void set_frictionDelegate(IntPtr @this, float value);
	}
}
