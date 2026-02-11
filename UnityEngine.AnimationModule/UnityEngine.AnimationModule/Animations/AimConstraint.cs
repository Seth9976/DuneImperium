using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Animations
{
	// Token: 0x0200004F RID: 79
	public sealed class AimConstraint : Behaviour
	{
		// Token: 0x060004BE RID: 1214 RVA: 0x00003C58 File Offset: 0x00001E58
		public static void Internal_Create(AimConstraint self)
		{
			AimConstraint.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x00003C6A File Offset: 0x00001E6A
		// (set) Token: 0x060004C0 RID: 1216 RVA: 0x00003C7C File Offset: 0x00001E7C
		public float weight
		{
			get
			{
				return AimConstraint.get_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AimConstraint.set_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x00003C8F File Offset: 0x00001E8F
		// (set) Token: 0x060004C2 RID: 1218 RVA: 0x00003CA1 File Offset: 0x00001EA1
		public bool constraintActive
		{
			get
			{
				return AimConstraint.get_constraintActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AimConstraint.set_constraintActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x00003CB4 File Offset: 0x00001EB4
		// (set) Token: 0x060004C4 RID: 1220 RVA: 0x00003CC6 File Offset: 0x00001EC6
		public bool locked
		{
			get
			{
				return AimConstraint.get_lockedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AimConstraint.set_lockedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x00012EB0 File Offset: 0x000110B0
		// (set) Token: 0x060004C6 RID: 1222 RVA: 0x00003CD9 File Offset: 0x00001ED9
		public Vector3 rotationAtRest
		{
			get
			{
				Vector3 vector;
				this.get_rotationAtRest_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_rotationAtRest_Injected(ref value);
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x00012EC8 File Offset: 0x000110C8
		// (set) Token: 0x060004C8 RID: 1224 RVA: 0x00003CE3 File Offset: 0x00001EE3
		public Vector3 rotationOffset
		{
			get
			{
				Vector3 vector;
				this.get_rotationOffset_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_rotationOffset_Injected(ref value);
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x00003CED File Offset: 0x00001EED
		// (set) Token: 0x060004CA RID: 1226 RVA: 0x00003CFF File Offset: 0x00001EFF
		public Axis rotationAxis
		{
			get
			{
				return AimConstraint.get_rotationAxisDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AimConstraint.set_rotationAxisDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x00012EE0 File Offset: 0x000110E0
		// (set) Token: 0x060004CC RID: 1228 RVA: 0x00003D12 File Offset: 0x00001F12
		public Vector3 aimVector
		{
			get
			{
				Vector3 vector;
				this.get_aimVector_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_aimVector_Injected(ref value);
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x00012EF8 File Offset: 0x000110F8
		// (set) Token: 0x060004CE RID: 1230 RVA: 0x00003D1C File Offset: 0x00001F1C
		public Vector3 upVector
		{
			get
			{
				Vector3 vector;
				this.get_upVector_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_upVector_Injected(ref value);
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x00012F10 File Offset: 0x00011110
		// (set) Token: 0x060004D0 RID: 1232 RVA: 0x00003D26 File Offset: 0x00001F26
		public Vector3 worldUpVector
		{
			get
			{
				Vector3 vector;
				this.get_worldUpVector_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_worldUpVector_Injected(ref value);
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x00012F28 File Offset: 0x00011128
		// (set) Token: 0x060004D2 RID: 1234 RVA: 0x00003D30 File Offset: 0x00001F30
		public Transform worldUpObject
		{
			get
			{
				IntPtr intPtr = AimConstraint.get_worldUpObjectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				AimConstraint.set_worldUpObjectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x00003D48 File Offset: 0x00001F48
		// (set) Token: 0x060004D4 RID: 1236 RVA: 0x00003D5A File Offset: 0x00001F5A
		public AimConstraint.WorldUpType worldUpType
		{
			get
			{
				return AimConstraint.get_worldUpTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AimConstraint.set_worldUpTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x00012F54 File Offset: 0x00011154
		public int sourceCount
		{
			get
			{
				return AimConstraint.GetSourceCountInternal(this);
			}
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00003D6D File Offset: 0x00001F6D
		public static int GetSourceCountInternal(AimConstraint self)
		{
			return AimConstraint.GetSourceCountInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00003D7F File Offset: 0x00001F7F
		public void RemoveSource(int index)
		{
			this.ValidateSourceIndex(index);
			this.RemoveSourceInternal(index);
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00003D92 File Offset: 0x00001F92
		public void RemoveSourceInternal(int index)
		{
			AimConstraint.RemoveSourceInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00012F6C File Offset: 0x0001116C
		public void ValidateSourceIndex(int index)
		{
			bool flag = this.sourceCount == 0;
			if (flag)
			{
				throw new InvalidOperationException("The AimConstraint component has no sources.");
			}
			bool flag2 = index < 0 || index >= this.sourceCount;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("index", String.Format("Constraint source index {0} is out of bounds (0-{1}).", index, this.sourceCount));
			}
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00003DA5 File Offset: 0x00001FA5
		public void get_rotationAtRest_Injected(out Vector3 ret)
		{
			AimConstraint.get_rotationAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00003DB8 File Offset: 0x00001FB8
		public void set_rotationAtRest_Injected(ref Vector3 value)
		{
			AimConstraint.set_rotationAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00003DCB File Offset: 0x00001FCB
		public void get_rotationOffset_Injected(out Vector3 ret)
		{
			AimConstraint.get_rotationOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00003DDE File Offset: 0x00001FDE
		public void set_rotationOffset_Injected(ref Vector3 value)
		{
			AimConstraint.set_rotationOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00003DF1 File Offset: 0x00001FF1
		public void get_aimVector_Injected(out Vector3 ret)
		{
			AimConstraint.get_aimVector_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00003E04 File Offset: 0x00002004
		public void set_aimVector_Injected(ref Vector3 value)
		{
			AimConstraint.set_aimVector_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00003E17 File Offset: 0x00002017
		public void get_upVector_Injected(out Vector3 ret)
		{
			AimConstraint.get_upVector_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00003E2A File Offset: 0x0000202A
		public void set_upVector_Injected(ref Vector3 value)
		{
			AimConstraint.set_upVector_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00003E3D File Offset: 0x0000203D
		public void get_worldUpVector_Injected(out Vector3 ret)
		{
			AimConstraint.get_worldUpVector_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00003E50 File Offset: 0x00002050
		public void set_worldUpVector_Injected(ref Vector3 value)
		{
			AimConstraint.set_worldUpVector_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000410 RID: 1040
		private static readonly AimConstraint.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<AimConstraint.Internal_CreateDelegate>("UnityEngine.Animations.AimConstraint::Internal_Create");

		// Token: 0x04000411 RID: 1041
		private static readonly AimConstraint.get_weightDelegate get_weightDelegateField = IL2CPP.ResolveICall<AimConstraint.get_weightDelegate>("UnityEngine.Animations.AimConstraint::get_weight");

		// Token: 0x04000412 RID: 1042
		private static readonly AimConstraint.set_weightDelegate set_weightDelegateField = IL2CPP.ResolveICall<AimConstraint.set_weightDelegate>("UnityEngine.Animations.AimConstraint::set_weight");

		// Token: 0x04000413 RID: 1043
		private static readonly AimConstraint.get_constraintActiveDelegate get_constraintActiveDelegateField = IL2CPP.ResolveICall<AimConstraint.get_constraintActiveDelegate>("UnityEngine.Animations.AimConstraint::get_constraintActive");

		// Token: 0x04000414 RID: 1044
		private static readonly AimConstraint.set_constraintActiveDelegate set_constraintActiveDelegateField = IL2CPP.ResolveICall<AimConstraint.set_constraintActiveDelegate>("UnityEngine.Animations.AimConstraint::set_constraintActive");

		// Token: 0x04000415 RID: 1045
		private static readonly AimConstraint.get_lockedDelegate get_lockedDelegateField = IL2CPP.ResolveICall<AimConstraint.get_lockedDelegate>("UnityEngine.Animations.AimConstraint::get_locked");

		// Token: 0x04000416 RID: 1046
		private static readonly AimConstraint.set_lockedDelegate set_lockedDelegateField = IL2CPP.ResolveICall<AimConstraint.set_lockedDelegate>("UnityEngine.Animations.AimConstraint::set_locked");

		// Token: 0x04000417 RID: 1047
		private static readonly AimConstraint.get_rotationAxisDelegate get_rotationAxisDelegateField = IL2CPP.ResolveICall<AimConstraint.get_rotationAxisDelegate>("UnityEngine.Animations.AimConstraint::get_rotationAxis");

		// Token: 0x04000418 RID: 1048
		private static readonly AimConstraint.set_rotationAxisDelegate set_rotationAxisDelegateField = IL2CPP.ResolveICall<AimConstraint.set_rotationAxisDelegate>("UnityEngine.Animations.AimConstraint::set_rotationAxis");

		// Token: 0x04000419 RID: 1049
		private static readonly AimConstraint.get_worldUpObjectDelegate get_worldUpObjectDelegateField = IL2CPP.ResolveICall<AimConstraint.get_worldUpObjectDelegate>("UnityEngine.Animations.AimConstraint::get_worldUpObject");

		// Token: 0x0400041A RID: 1050
		private static readonly AimConstraint.set_worldUpObjectDelegate set_worldUpObjectDelegateField = IL2CPP.ResolveICall<AimConstraint.set_worldUpObjectDelegate>("UnityEngine.Animations.AimConstraint::set_worldUpObject");

		// Token: 0x0400041B RID: 1051
		private static readonly AimConstraint.get_worldUpTypeDelegate get_worldUpTypeDelegateField = IL2CPP.ResolveICall<AimConstraint.get_worldUpTypeDelegate>("UnityEngine.Animations.AimConstraint::get_worldUpType");

		// Token: 0x0400041C RID: 1052
		private static readonly AimConstraint.set_worldUpTypeDelegate set_worldUpTypeDelegateField = IL2CPP.ResolveICall<AimConstraint.set_worldUpTypeDelegate>("UnityEngine.Animations.AimConstraint::set_worldUpType");

		// Token: 0x0400041D RID: 1053
		private static readonly AimConstraint.GetSourceCountInternalDelegate GetSourceCountInternalDelegateField = IL2CPP.ResolveICall<AimConstraint.GetSourceCountInternalDelegate>("UnityEngine.Animations.AimConstraint::GetSourceCountInternal");

		// Token: 0x0400041E RID: 1054
		private static readonly AimConstraint.RemoveSourceInternalDelegate RemoveSourceInternalDelegateField = IL2CPP.ResolveICall<AimConstraint.RemoveSourceInternalDelegate>("UnityEngine.Animations.AimConstraint::RemoveSourceInternal");

		// Token: 0x0400041F RID: 1055
		private static readonly AimConstraint.get_rotationAtRest_InjectedDelegate get_rotationAtRest_InjectedDelegateField = IL2CPP.ResolveICall<AimConstraint.get_rotationAtRest_InjectedDelegate>("UnityEngine.Animations.AimConstraint::get_rotationAtRest_Injected");

		// Token: 0x04000420 RID: 1056
		private static readonly AimConstraint.set_rotationAtRest_InjectedDelegate set_rotationAtRest_InjectedDelegateField = IL2CPP.ResolveICall<AimConstraint.set_rotationAtRest_InjectedDelegate>("UnityEngine.Animations.AimConstraint::set_rotationAtRest_Injected");

		// Token: 0x04000421 RID: 1057
		private static readonly AimConstraint.get_rotationOffset_InjectedDelegate get_rotationOffset_InjectedDelegateField = IL2CPP.ResolveICall<AimConstraint.get_rotationOffset_InjectedDelegate>("UnityEngine.Animations.AimConstraint::get_rotationOffset_Injected");

		// Token: 0x04000422 RID: 1058
		private static readonly AimConstraint.set_rotationOffset_InjectedDelegate set_rotationOffset_InjectedDelegateField = IL2CPP.ResolveICall<AimConstraint.set_rotationOffset_InjectedDelegate>("UnityEngine.Animations.AimConstraint::set_rotationOffset_Injected");

		// Token: 0x04000423 RID: 1059
		private static readonly AimConstraint.get_aimVector_InjectedDelegate get_aimVector_InjectedDelegateField = IL2CPP.ResolveICall<AimConstraint.get_aimVector_InjectedDelegate>("UnityEngine.Animations.AimConstraint::get_aimVector_Injected");

		// Token: 0x04000424 RID: 1060
		private static readonly AimConstraint.set_aimVector_InjectedDelegate set_aimVector_InjectedDelegateField = IL2CPP.ResolveICall<AimConstraint.set_aimVector_InjectedDelegate>("UnityEngine.Animations.AimConstraint::set_aimVector_Injected");

		// Token: 0x04000425 RID: 1061
		private static readonly AimConstraint.get_upVector_InjectedDelegate get_upVector_InjectedDelegateField = IL2CPP.ResolveICall<AimConstraint.get_upVector_InjectedDelegate>("UnityEngine.Animations.AimConstraint::get_upVector_Injected");

		// Token: 0x04000426 RID: 1062
		private static readonly AimConstraint.set_upVector_InjectedDelegate set_upVector_InjectedDelegateField = IL2CPP.ResolveICall<AimConstraint.set_upVector_InjectedDelegate>("UnityEngine.Animations.AimConstraint::set_upVector_Injected");

		// Token: 0x04000427 RID: 1063
		private static readonly AimConstraint.get_worldUpVector_InjectedDelegate get_worldUpVector_InjectedDelegateField = IL2CPP.ResolveICall<AimConstraint.get_worldUpVector_InjectedDelegate>("UnityEngine.Animations.AimConstraint::get_worldUpVector_Injected");

		// Token: 0x04000428 RID: 1064
		private static readonly AimConstraint.set_worldUpVector_InjectedDelegate set_worldUpVector_InjectedDelegateField = IL2CPP.ResolveICall<AimConstraint.set_worldUpVector_InjectedDelegate>("UnityEngine.Animations.AimConstraint::set_worldUpVector_Injected");

		// Token: 0x0200013B RID: 315
		public enum WorldUpType
		{
			// Token: 0x040004B6 RID: 1206
			SceneUp,
			// Token: 0x040004B7 RID: 1207
			ObjectUp,
			// Token: 0x040004B8 RID: 1208
			ObjectRotationUp,
			// Token: 0x040004B9 RID: 1209
			Vector,
			// Token: 0x040004BA RID: 1210
			None
		}

		// Token: 0x0200013C RID: 316
		// (Invoke) Token: 0x06000753 RID: 1875
		private delegate void Internal_CreateDelegate(IntPtr self);

		// Token: 0x0200013D RID: 317
		// (Invoke) Token: 0x06000755 RID: 1877
		private delegate float get_weightDelegate(IntPtr @this);

		// Token: 0x0200013E RID: 318
		// (Invoke) Token: 0x06000757 RID: 1879
		private delegate void set_weightDelegate(IntPtr @this, float value);

		// Token: 0x0200013F RID: 319
		// (Invoke) Token: 0x06000759 RID: 1881
		private delegate bool get_constraintActiveDelegate(IntPtr @this);

		// Token: 0x02000140 RID: 320
		// (Invoke) Token: 0x0600075B RID: 1883
		private delegate void set_constraintActiveDelegate(IntPtr @this, bool value);

		// Token: 0x02000141 RID: 321
		// (Invoke) Token: 0x0600075D RID: 1885
		private delegate bool get_lockedDelegate(IntPtr @this);

		// Token: 0x02000142 RID: 322
		// (Invoke) Token: 0x0600075F RID: 1887
		private delegate void set_lockedDelegate(IntPtr @this, bool value);

		// Token: 0x02000143 RID: 323
		// (Invoke) Token: 0x06000761 RID: 1889
		private delegate Axis get_rotationAxisDelegate(IntPtr @this);

		// Token: 0x02000144 RID: 324
		// (Invoke) Token: 0x06000763 RID: 1891
		private delegate void set_rotationAxisDelegate(IntPtr @this, Axis value);

		// Token: 0x02000145 RID: 325
		// (Invoke) Token: 0x06000765 RID: 1893
		private delegate IntPtr get_worldUpObjectDelegate(IntPtr @this);

		// Token: 0x02000146 RID: 326
		// (Invoke) Token: 0x06000767 RID: 1895
		private delegate void set_worldUpObjectDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000147 RID: 327
		// (Invoke) Token: 0x06000769 RID: 1897
		private delegate AimConstraint.WorldUpType get_worldUpTypeDelegate(IntPtr @this);

		// Token: 0x02000148 RID: 328
		// (Invoke) Token: 0x0600076B RID: 1899
		private delegate void set_worldUpTypeDelegate(IntPtr @this, AimConstraint.WorldUpType value);

		// Token: 0x02000149 RID: 329
		// (Invoke) Token: 0x0600076D RID: 1901
		private delegate int GetSourceCountInternalDelegate(IntPtr self);

		// Token: 0x0200014A RID: 330
		// (Invoke) Token: 0x0600076F RID: 1903
		private delegate void RemoveSourceInternalDelegate(IntPtr @this, int index);

		// Token: 0x0200014B RID: 331
		// (Invoke) Token: 0x06000771 RID: 1905
		private delegate void get_rotationAtRest_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200014C RID: 332
		// (Invoke) Token: 0x06000773 RID: 1907
		private delegate void set_rotationAtRest_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200014D RID: 333
		// (Invoke) Token: 0x06000775 RID: 1909
		private delegate void get_rotationOffset_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200014E RID: 334
		// (Invoke) Token: 0x06000777 RID: 1911
		private delegate void set_rotationOffset_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200014F RID: 335
		// (Invoke) Token: 0x06000779 RID: 1913
		private delegate void get_aimVector_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000150 RID: 336
		// (Invoke) Token: 0x0600077B RID: 1915
		private delegate void set_aimVector_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000151 RID: 337
		// (Invoke) Token: 0x0600077D RID: 1917
		private delegate void get_upVector_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000152 RID: 338
		// (Invoke) Token: 0x0600077F RID: 1919
		private delegate void set_upVector_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000153 RID: 339
		// (Invoke) Token: 0x06000781 RID: 1921
		private delegate void get_worldUpVector_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000154 RID: 340
		// (Invoke) Token: 0x06000783 RID: 1923
		private delegate void set_worldUpVector_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
