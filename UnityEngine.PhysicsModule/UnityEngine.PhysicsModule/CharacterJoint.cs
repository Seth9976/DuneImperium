using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200002C RID: 44
	public class CharacterJoint : Joint
	{
		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x0000C448 File Offset: 0x0000A648
		// (set) Token: 0x060003F1 RID: 1009 RVA: 0x00004486 File Offset: 0x00002686
		public Vector3 swingAxis
		{
			get
			{
				Vector3 vector;
				this.get_swingAxis_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_swingAxis_Injected(ref value);
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x00004490 File Offset: 0x00002690
		// (set) Token: 0x060003F3 RID: 1011 RVA: 0x000044A2 File Offset: 0x000026A2
		public bool enableProjection
		{
			get
			{
				return CharacterJoint.get_enableProjectionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CharacterJoint.set_enableProjectionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x000044B5 File Offset: 0x000026B5
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x000044C7 File Offset: 0x000026C7
		public float projectionDistance
		{
			get
			{
				return CharacterJoint.get_projectionDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CharacterJoint.set_projectionDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x000044DA File Offset: 0x000026DA
		// (set) Token: 0x060003F7 RID: 1015 RVA: 0x000044EC File Offset: 0x000026EC
		public float projectionAngle
		{
			get
			{
				return CharacterJoint.get_projectionAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CharacterJoint.set_projectionAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x000044FF File Offset: 0x000026FF
		public void get_swingAxis_Injected(out Vector3 ret)
		{
			CharacterJoint.get_swingAxis_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00004512 File Offset: 0x00002712
		public void set_swingAxis_Injected(ref Vector3 value)
		{
			CharacterJoint.set_swingAxis_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x040002DC RID: 732
		private static readonly CharacterJoint.get_enableProjectionDelegate get_enableProjectionDelegateField = IL2CPP.ResolveICall<CharacterJoint.get_enableProjectionDelegate>("UnityEngine.CharacterJoint::get_enableProjection");

		// Token: 0x040002DD RID: 733
		private static readonly CharacterJoint.set_enableProjectionDelegate set_enableProjectionDelegateField = IL2CPP.ResolveICall<CharacterJoint.set_enableProjectionDelegate>("UnityEngine.CharacterJoint::set_enableProjection");

		// Token: 0x040002DE RID: 734
		private static readonly CharacterJoint.get_projectionDistanceDelegate get_projectionDistanceDelegateField = IL2CPP.ResolveICall<CharacterJoint.get_projectionDistanceDelegate>("UnityEngine.CharacterJoint::get_projectionDistance");

		// Token: 0x040002DF RID: 735
		private static readonly CharacterJoint.set_projectionDistanceDelegate set_projectionDistanceDelegateField = IL2CPP.ResolveICall<CharacterJoint.set_projectionDistanceDelegate>("UnityEngine.CharacterJoint::set_projectionDistance");

		// Token: 0x040002E0 RID: 736
		private static readonly CharacterJoint.get_projectionAngleDelegate get_projectionAngleDelegateField = IL2CPP.ResolveICall<CharacterJoint.get_projectionAngleDelegate>("UnityEngine.CharacterJoint::get_projectionAngle");

		// Token: 0x040002E1 RID: 737
		private static readonly CharacterJoint.set_projectionAngleDelegate set_projectionAngleDelegateField = IL2CPP.ResolveICall<CharacterJoint.set_projectionAngleDelegate>("UnityEngine.CharacterJoint::set_projectionAngle");

		// Token: 0x040002E2 RID: 738
		private static readonly CharacterJoint.get_swingAxis_InjectedDelegate get_swingAxis_InjectedDelegateField = IL2CPP.ResolveICall<CharacterJoint.get_swingAxis_InjectedDelegate>("UnityEngine.CharacterJoint::get_swingAxis_Injected");

		// Token: 0x040002E3 RID: 739
		private static readonly CharacterJoint.set_swingAxis_InjectedDelegate set_swingAxis_InjectedDelegateField = IL2CPP.ResolveICall<CharacterJoint.set_swingAxis_InjectedDelegate>("UnityEngine.CharacterJoint::set_swingAxis_Injected");

		// Token: 0x020001AF RID: 431
		// (Invoke) Token: 0x06000736 RID: 1846
		private delegate bool get_enableProjectionDelegate(IntPtr @this);

		// Token: 0x020001B0 RID: 432
		// (Invoke) Token: 0x06000738 RID: 1848
		private delegate void set_enableProjectionDelegate(IntPtr @this, bool value);

		// Token: 0x020001B1 RID: 433
		// (Invoke) Token: 0x0600073A RID: 1850
		private delegate float get_projectionDistanceDelegate(IntPtr @this);

		// Token: 0x020001B2 RID: 434
		// (Invoke) Token: 0x0600073C RID: 1852
		private delegate void set_projectionDistanceDelegate(IntPtr @this, float value);

		// Token: 0x020001B3 RID: 435
		// (Invoke) Token: 0x0600073E RID: 1854
		private delegate float get_projectionAngleDelegate(IntPtr @this);

		// Token: 0x020001B4 RID: 436
		// (Invoke) Token: 0x06000740 RID: 1856
		private delegate void set_projectionAngleDelegate(IntPtr @this, float value);

		// Token: 0x020001B5 RID: 437
		// (Invoke) Token: 0x06000742 RID: 1858
		private delegate void get_swingAxis_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020001B6 RID: 438
		// (Invoke) Token: 0x06000744 RID: 1860
		private delegate void set_swingAxis_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
