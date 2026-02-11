using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Animations
{
	// Token: 0x0200005B RID: 91
	public sealed class PositionConstraint : Behaviour
	{
		// Token: 0x0600050A RID: 1290 RVA: 0x0000408D File Offset: 0x0000228D
		public static void Internal_Create(PositionConstraint self)
		{
			PositionConstraint.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x0000409F File Offset: 0x0000229F
		// (set) Token: 0x0600050C RID: 1292 RVA: 0x000040B1 File Offset: 0x000022B1
		public float weight
		{
			get
			{
				return PositionConstraint.get_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PositionConstraint.set_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x0001324C File Offset: 0x0001144C
		// (set) Token: 0x0600050E RID: 1294 RVA: 0x000040C4 File Offset: 0x000022C4
		public Vector3 translationAtRest
		{
			get
			{
				Vector3 vector;
				this.get_translationAtRest_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_translationAtRest_Injected(ref value);
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x00013264 File Offset: 0x00011464
		// (set) Token: 0x06000510 RID: 1296 RVA: 0x000040CE File Offset: 0x000022CE
		public Vector3 translationOffset
		{
			get
			{
				Vector3 vector;
				this.get_translationOffset_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_translationOffset_Injected(ref value);
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x000040D8 File Offset: 0x000022D8
		// (set) Token: 0x06000512 RID: 1298 RVA: 0x000040EA File Offset: 0x000022EA
		public Axis translationAxis
		{
			get
			{
				return PositionConstraint.get_translationAxisDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PositionConstraint.set_translationAxisDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x000040FD File Offset: 0x000022FD
		// (set) Token: 0x06000514 RID: 1300 RVA: 0x0000410F File Offset: 0x0000230F
		public bool constraintActive
		{
			get
			{
				return PositionConstraint.get_constraintActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PositionConstraint.set_constraintActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x00004122 File Offset: 0x00002322
		// (set) Token: 0x06000516 RID: 1302 RVA: 0x00004134 File Offset: 0x00002334
		public bool locked
		{
			get
			{
				return PositionConstraint.get_lockedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PositionConstraint.set_lockedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x0001327C File Offset: 0x0001147C
		public int sourceCount
		{
			get
			{
				return PositionConstraint.GetSourceCountInternal(this);
			}
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00004147 File Offset: 0x00002347
		public static int GetSourceCountInternal(PositionConstraint self)
		{
			return PositionConstraint.GetSourceCountInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00004159 File Offset: 0x00002359
		public void RemoveSource(int index)
		{
			this.ValidateSourceIndex(index);
			this.RemoveSourceInternal(index);
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0000416C File Offset: 0x0000236C
		public void RemoveSourceInternal(int index)
		{
			PositionConstraint.RemoveSourceInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00013294 File Offset: 0x00011494
		public void ValidateSourceIndex(int index)
		{
			bool flag = this.sourceCount == 0;
			if (flag)
			{
				throw new InvalidOperationException("The PositionConstraint component has no sources.");
			}
			bool flag2 = index < 0 || index >= this.sourceCount;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("index", String.Format("Constraint source index {0} is out of bounds (0-{1}).", index, this.sourceCount));
			}
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0000417F File Offset: 0x0000237F
		public void get_translationAtRest_Injected(out Vector3 ret)
		{
			PositionConstraint.get_translationAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00004192 File Offset: 0x00002392
		public void set_translationAtRest_Injected(ref Vector3 value)
		{
			PositionConstraint.set_translationAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x000041A5 File Offset: 0x000023A5
		public void get_translationOffset_Injected(out Vector3 ret)
		{
			PositionConstraint.get_translationOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x000041B8 File Offset: 0x000023B8
		public void set_translationOffset_Injected(ref Vector3 value)
		{
			PositionConstraint.set_translationOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000451 RID: 1105
		private static readonly PositionConstraint.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<PositionConstraint.Internal_CreateDelegate>("UnityEngine.Animations.PositionConstraint::Internal_Create");

		// Token: 0x04000452 RID: 1106
		private static readonly PositionConstraint.get_weightDelegate get_weightDelegateField = IL2CPP.ResolveICall<PositionConstraint.get_weightDelegate>("UnityEngine.Animations.PositionConstraint::get_weight");

		// Token: 0x04000453 RID: 1107
		private static readonly PositionConstraint.set_weightDelegate set_weightDelegateField = IL2CPP.ResolveICall<PositionConstraint.set_weightDelegate>("UnityEngine.Animations.PositionConstraint::set_weight");

		// Token: 0x04000454 RID: 1108
		private static readonly PositionConstraint.get_translationAxisDelegate get_translationAxisDelegateField = IL2CPP.ResolveICall<PositionConstraint.get_translationAxisDelegate>("UnityEngine.Animations.PositionConstraint::get_translationAxis");

		// Token: 0x04000455 RID: 1109
		private static readonly PositionConstraint.set_translationAxisDelegate set_translationAxisDelegateField = IL2CPP.ResolveICall<PositionConstraint.set_translationAxisDelegate>("UnityEngine.Animations.PositionConstraint::set_translationAxis");

		// Token: 0x04000456 RID: 1110
		private static readonly PositionConstraint.get_constraintActiveDelegate get_constraintActiveDelegateField = IL2CPP.ResolveICall<PositionConstraint.get_constraintActiveDelegate>("UnityEngine.Animations.PositionConstraint::get_constraintActive");

		// Token: 0x04000457 RID: 1111
		private static readonly PositionConstraint.set_constraintActiveDelegate set_constraintActiveDelegateField = IL2CPP.ResolveICall<PositionConstraint.set_constraintActiveDelegate>("UnityEngine.Animations.PositionConstraint::set_constraintActive");

		// Token: 0x04000458 RID: 1112
		private static readonly PositionConstraint.get_lockedDelegate get_lockedDelegateField = IL2CPP.ResolveICall<PositionConstraint.get_lockedDelegate>("UnityEngine.Animations.PositionConstraint::get_locked");

		// Token: 0x04000459 RID: 1113
		private static readonly PositionConstraint.set_lockedDelegate set_lockedDelegateField = IL2CPP.ResolveICall<PositionConstraint.set_lockedDelegate>("UnityEngine.Animations.PositionConstraint::set_locked");

		// Token: 0x0400045A RID: 1114
		private static readonly PositionConstraint.GetSourceCountInternalDelegate GetSourceCountInternalDelegateField = IL2CPP.ResolveICall<PositionConstraint.GetSourceCountInternalDelegate>("UnityEngine.Animations.PositionConstraint::GetSourceCountInternal");

		// Token: 0x0400045B RID: 1115
		private static readonly PositionConstraint.RemoveSourceInternalDelegate RemoveSourceInternalDelegateField = IL2CPP.ResolveICall<PositionConstraint.RemoveSourceInternalDelegate>("UnityEngine.Animations.PositionConstraint::RemoveSourceInternal");

		// Token: 0x0400045C RID: 1116
		private static readonly PositionConstraint.get_translationAtRest_InjectedDelegate get_translationAtRest_InjectedDelegateField = IL2CPP.ResolveICall<PositionConstraint.get_translationAtRest_InjectedDelegate>("UnityEngine.Animations.PositionConstraint::get_translationAtRest_Injected");

		// Token: 0x0400045D RID: 1117
		private static readonly PositionConstraint.set_translationAtRest_InjectedDelegate set_translationAtRest_InjectedDelegateField = IL2CPP.ResolveICall<PositionConstraint.set_translationAtRest_InjectedDelegate>("UnityEngine.Animations.PositionConstraint::set_translationAtRest_Injected");

		// Token: 0x0400045E RID: 1118
		private static readonly PositionConstraint.get_translationOffset_InjectedDelegate get_translationOffset_InjectedDelegateField = IL2CPP.ResolveICall<PositionConstraint.get_translationOffset_InjectedDelegate>("UnityEngine.Animations.PositionConstraint::get_translationOffset_Injected");

		// Token: 0x0400045F RID: 1119
		private static readonly PositionConstraint.set_translationOffset_InjectedDelegate set_translationOffset_InjectedDelegateField = IL2CPP.ResolveICall<PositionConstraint.set_translationOffset_InjectedDelegate>("UnityEngine.Animations.PositionConstraint::set_translationOffset_Injected");

		// Token: 0x02000168 RID: 360
		// (Invoke) Token: 0x060007AB RID: 1963
		private delegate void Internal_CreateDelegate(IntPtr self);

		// Token: 0x02000169 RID: 361
		// (Invoke) Token: 0x060007AD RID: 1965
		private delegate float get_weightDelegate(IntPtr @this);

		// Token: 0x0200016A RID: 362
		// (Invoke) Token: 0x060007AF RID: 1967
		private delegate void set_weightDelegate(IntPtr @this, float value);

		// Token: 0x0200016B RID: 363
		// (Invoke) Token: 0x060007B1 RID: 1969
		private delegate Axis get_translationAxisDelegate(IntPtr @this);

		// Token: 0x0200016C RID: 364
		// (Invoke) Token: 0x060007B3 RID: 1971
		private delegate void set_translationAxisDelegate(IntPtr @this, Axis value);

		// Token: 0x0200016D RID: 365
		// (Invoke) Token: 0x060007B5 RID: 1973
		private delegate bool get_constraintActiveDelegate(IntPtr @this);

		// Token: 0x0200016E RID: 366
		// (Invoke) Token: 0x060007B7 RID: 1975
		private delegate void set_constraintActiveDelegate(IntPtr @this, bool value);

		// Token: 0x0200016F RID: 367
		// (Invoke) Token: 0x060007B9 RID: 1977
		private delegate bool get_lockedDelegate(IntPtr @this);

		// Token: 0x02000170 RID: 368
		// (Invoke) Token: 0x060007BB RID: 1979
		private delegate void set_lockedDelegate(IntPtr @this, bool value);

		// Token: 0x02000171 RID: 369
		// (Invoke) Token: 0x060007BD RID: 1981
		private delegate int GetSourceCountInternalDelegate(IntPtr self);

		// Token: 0x02000172 RID: 370
		// (Invoke) Token: 0x060007BF RID: 1983
		private delegate void RemoveSourceInternalDelegate(IntPtr @this, int index);

		// Token: 0x02000173 RID: 371
		// (Invoke) Token: 0x060007C1 RID: 1985
		private delegate void get_translationAtRest_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000174 RID: 372
		// (Invoke) Token: 0x060007C3 RID: 1987
		private delegate void set_translationAtRest_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000175 RID: 373
		// (Invoke) Token: 0x060007C5 RID: 1989
		private delegate void get_translationOffset_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000176 RID: 374
		// (Invoke) Token: 0x060007C7 RID: 1991
		private delegate void set_translationOffset_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
