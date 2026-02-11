using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Animations
{
	// Token: 0x0200005D RID: 93
	public sealed class ScaleConstraint : Behaviour
	{
		// Token: 0x06000538 RID: 1336 RVA: 0x00004309 File Offset: 0x00002509
		public static void Internal_Create(ScaleConstraint self)
		{
			ScaleConstraint.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x0000431B File Offset: 0x0000251B
		// (set) Token: 0x0600053A RID: 1338 RVA: 0x0000432D File Offset: 0x0000252D
		public float weight
		{
			get
			{
				return ScaleConstraint.get_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ScaleConstraint.set_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x0001358C File Offset: 0x0001178C
		// (set) Token: 0x0600053C RID: 1340 RVA: 0x00004340 File Offset: 0x00002540
		public Vector3 scaleAtRest
		{
			get
			{
				Vector3 vector;
				this.get_scaleAtRest_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_scaleAtRest_Injected(ref value);
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x000135A4 File Offset: 0x000117A4
		// (set) Token: 0x0600053E RID: 1342 RVA: 0x0000434A File Offset: 0x0000254A
		public Vector3 scaleOffset
		{
			get
			{
				Vector3 vector;
				this.get_scaleOffset_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_scaleOffset_Injected(ref value);
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x00004354 File Offset: 0x00002554
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x00004366 File Offset: 0x00002566
		public Axis scalingAxis
		{
			get
			{
				return ScaleConstraint.get_scalingAxisDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ScaleConstraint.set_scalingAxisDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x00004379 File Offset: 0x00002579
		// (set) Token: 0x06000542 RID: 1346 RVA: 0x0000438B File Offset: 0x0000258B
		public bool constraintActive
		{
			get
			{
				return ScaleConstraint.get_constraintActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ScaleConstraint.set_constraintActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x0000439E File Offset: 0x0000259E
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x000043B0 File Offset: 0x000025B0
		public bool locked
		{
			get
			{
				return ScaleConstraint.get_lockedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ScaleConstraint.set_lockedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x000135BC File Offset: 0x000117BC
		public int sourceCount
		{
			get
			{
				return ScaleConstraint.GetSourceCountInternal(this);
			}
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x000043C3 File Offset: 0x000025C3
		public static int GetSourceCountInternal(ScaleConstraint self)
		{
			return ScaleConstraint.GetSourceCountInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x000043D5 File Offset: 0x000025D5
		public void RemoveSource(int index)
		{
			this.ValidateSourceIndex(index);
			this.RemoveSourceInternal(index);
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x000043E8 File Offset: 0x000025E8
		public void RemoveSourceInternal(int index)
		{
			ScaleConstraint.RemoveSourceInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x000135D4 File Offset: 0x000117D4
		public void ValidateSourceIndex(int index)
		{
			bool flag = this.sourceCount == 0;
			if (flag)
			{
				throw new InvalidOperationException("The ScaleConstraint component has no sources.");
			}
			bool flag2 = index < 0 || index >= this.sourceCount;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("index", String.Format("Constraint source index {0} is out of bounds (0-{1}).", index, this.sourceCount));
			}
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x000043FB File Offset: 0x000025FB
		public void get_scaleAtRest_Injected(out Vector3 ret)
		{
			ScaleConstraint.get_scaleAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x0000440E File Offset: 0x0000260E
		public void set_scaleAtRest_Injected(ref Vector3 value)
		{
			ScaleConstraint.set_scaleAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00004421 File Offset: 0x00002621
		public void get_scaleOffset_Injected(out Vector3 ret)
		{
			ScaleConstraint.get_scaleOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00004434 File Offset: 0x00002634
		public void set_scaleOffset_Injected(ref Vector3 value)
		{
			ScaleConstraint.set_scaleOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0400046F RID: 1135
		private static readonly ScaleConstraint.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<ScaleConstraint.Internal_CreateDelegate>("UnityEngine.Animations.ScaleConstraint::Internal_Create");

		// Token: 0x04000470 RID: 1136
		private static readonly ScaleConstraint.get_weightDelegate get_weightDelegateField = IL2CPP.ResolveICall<ScaleConstraint.get_weightDelegate>("UnityEngine.Animations.ScaleConstraint::get_weight");

		// Token: 0x04000471 RID: 1137
		private static readonly ScaleConstraint.set_weightDelegate set_weightDelegateField = IL2CPP.ResolveICall<ScaleConstraint.set_weightDelegate>("UnityEngine.Animations.ScaleConstraint::set_weight");

		// Token: 0x04000472 RID: 1138
		private static readonly ScaleConstraint.get_scalingAxisDelegate get_scalingAxisDelegateField = IL2CPP.ResolveICall<ScaleConstraint.get_scalingAxisDelegate>("UnityEngine.Animations.ScaleConstraint::get_scalingAxis");

		// Token: 0x04000473 RID: 1139
		private static readonly ScaleConstraint.set_scalingAxisDelegate set_scalingAxisDelegateField = IL2CPP.ResolveICall<ScaleConstraint.set_scalingAxisDelegate>("UnityEngine.Animations.ScaleConstraint::set_scalingAxis");

		// Token: 0x04000474 RID: 1140
		private static readonly ScaleConstraint.get_constraintActiveDelegate get_constraintActiveDelegateField = IL2CPP.ResolveICall<ScaleConstraint.get_constraintActiveDelegate>("UnityEngine.Animations.ScaleConstraint::get_constraintActive");

		// Token: 0x04000475 RID: 1141
		private static readonly ScaleConstraint.set_constraintActiveDelegate set_constraintActiveDelegateField = IL2CPP.ResolveICall<ScaleConstraint.set_constraintActiveDelegate>("UnityEngine.Animations.ScaleConstraint::set_constraintActive");

		// Token: 0x04000476 RID: 1142
		private static readonly ScaleConstraint.get_lockedDelegate get_lockedDelegateField = IL2CPP.ResolveICall<ScaleConstraint.get_lockedDelegate>("UnityEngine.Animations.ScaleConstraint::get_locked");

		// Token: 0x04000477 RID: 1143
		private static readonly ScaleConstraint.set_lockedDelegate set_lockedDelegateField = IL2CPP.ResolveICall<ScaleConstraint.set_lockedDelegate>("UnityEngine.Animations.ScaleConstraint::set_locked");

		// Token: 0x04000478 RID: 1144
		private static readonly ScaleConstraint.GetSourceCountInternalDelegate GetSourceCountInternalDelegateField = IL2CPP.ResolveICall<ScaleConstraint.GetSourceCountInternalDelegate>("UnityEngine.Animations.ScaleConstraint::GetSourceCountInternal");

		// Token: 0x04000479 RID: 1145
		private static readonly ScaleConstraint.RemoveSourceInternalDelegate RemoveSourceInternalDelegateField = IL2CPP.ResolveICall<ScaleConstraint.RemoveSourceInternalDelegate>("UnityEngine.Animations.ScaleConstraint::RemoveSourceInternal");

		// Token: 0x0400047A RID: 1146
		private static readonly ScaleConstraint.get_scaleAtRest_InjectedDelegate get_scaleAtRest_InjectedDelegateField = IL2CPP.ResolveICall<ScaleConstraint.get_scaleAtRest_InjectedDelegate>("UnityEngine.Animations.ScaleConstraint::get_scaleAtRest_Injected");

		// Token: 0x0400047B RID: 1147
		private static readonly ScaleConstraint.set_scaleAtRest_InjectedDelegate set_scaleAtRest_InjectedDelegateField = IL2CPP.ResolveICall<ScaleConstraint.set_scaleAtRest_InjectedDelegate>("UnityEngine.Animations.ScaleConstraint::set_scaleAtRest_Injected");

		// Token: 0x0400047C RID: 1148
		private static readonly ScaleConstraint.get_scaleOffset_InjectedDelegate get_scaleOffset_InjectedDelegateField = IL2CPP.ResolveICall<ScaleConstraint.get_scaleOffset_InjectedDelegate>("UnityEngine.Animations.ScaleConstraint::get_scaleOffset_Injected");

		// Token: 0x0400047D RID: 1149
		private static readonly ScaleConstraint.set_scaleOffset_InjectedDelegate set_scaleOffset_InjectedDelegateField = IL2CPP.ResolveICall<ScaleConstraint.set_scaleOffset_InjectedDelegate>("UnityEngine.Animations.ScaleConstraint::set_scaleOffset_Injected");

		// Token: 0x02000186 RID: 390
		// (Invoke) Token: 0x060007E7 RID: 2023
		private delegate void Internal_CreateDelegate(IntPtr self);

		// Token: 0x02000187 RID: 391
		// (Invoke) Token: 0x060007E9 RID: 2025
		private delegate float get_weightDelegate(IntPtr @this);

		// Token: 0x02000188 RID: 392
		// (Invoke) Token: 0x060007EB RID: 2027
		private delegate void set_weightDelegate(IntPtr @this, float value);

		// Token: 0x02000189 RID: 393
		// (Invoke) Token: 0x060007ED RID: 2029
		private delegate Axis get_scalingAxisDelegate(IntPtr @this);

		// Token: 0x0200018A RID: 394
		// (Invoke) Token: 0x060007EF RID: 2031
		private delegate void set_scalingAxisDelegate(IntPtr @this, Axis value);

		// Token: 0x0200018B RID: 395
		// (Invoke) Token: 0x060007F1 RID: 2033
		private delegate bool get_constraintActiveDelegate(IntPtr @this);

		// Token: 0x0200018C RID: 396
		// (Invoke) Token: 0x060007F3 RID: 2035
		private delegate void set_constraintActiveDelegate(IntPtr @this, bool value);

		// Token: 0x0200018D RID: 397
		// (Invoke) Token: 0x060007F5 RID: 2037
		private delegate bool get_lockedDelegate(IntPtr @this);

		// Token: 0x0200018E RID: 398
		// (Invoke) Token: 0x060007F7 RID: 2039
		private delegate void set_lockedDelegate(IntPtr @this, bool value);

		// Token: 0x0200018F RID: 399
		// (Invoke) Token: 0x060007F9 RID: 2041
		private delegate int GetSourceCountInternalDelegate(IntPtr self);

		// Token: 0x02000190 RID: 400
		// (Invoke) Token: 0x060007FB RID: 2043
		private delegate void RemoveSourceInternalDelegate(IntPtr @this, int index);

		// Token: 0x02000191 RID: 401
		// (Invoke) Token: 0x060007FD RID: 2045
		private delegate void get_scaleAtRest_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000192 RID: 402
		// (Invoke) Token: 0x060007FF RID: 2047
		private delegate void set_scaleAtRest_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000193 RID: 403
		// (Invoke) Token: 0x06000801 RID: 2049
		private delegate void get_scaleOffset_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000194 RID: 404
		// (Invoke) Token: 0x06000803 RID: 2051
		private delegate void set_scaleOffset_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
