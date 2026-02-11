using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Animations
{
	// Token: 0x0200005C RID: 92
	public sealed class RotationConstraint : Behaviour
	{
		// Token: 0x06000521 RID: 1313 RVA: 0x000041CB File Offset: 0x000023CB
		public static void Internal_Create(RotationConstraint self)
		{
			RotationConstraint.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x000041DD File Offset: 0x000023DD
		// (set) Token: 0x06000523 RID: 1315 RVA: 0x000041EF File Offset: 0x000023EF
		public float weight
		{
			get
			{
				return RotationConstraint.get_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RotationConstraint.set_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x000133EC File Offset: 0x000115EC
		// (set) Token: 0x06000525 RID: 1317 RVA: 0x00004202 File Offset: 0x00002402
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

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x00013404 File Offset: 0x00011604
		// (set) Token: 0x06000527 RID: 1319 RVA: 0x0000420C File Offset: 0x0000240C
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

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x00004216 File Offset: 0x00002416
		// (set) Token: 0x06000529 RID: 1321 RVA: 0x00004228 File Offset: 0x00002428
		public Axis rotationAxis
		{
			get
			{
				return RotationConstraint.get_rotationAxisDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RotationConstraint.set_rotationAxisDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x0000423B File Offset: 0x0000243B
		// (set) Token: 0x0600052B RID: 1323 RVA: 0x0000424D File Offset: 0x0000244D
		public bool constraintActive
		{
			get
			{
				return RotationConstraint.get_constraintActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RotationConstraint.set_constraintActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x00004260 File Offset: 0x00002460
		// (set) Token: 0x0600052D RID: 1325 RVA: 0x00004272 File Offset: 0x00002472
		public bool locked
		{
			get
			{
				return RotationConstraint.get_lockedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RotationConstraint.set_lockedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x0001341C File Offset: 0x0001161C
		public int sourceCount
		{
			get
			{
				return RotationConstraint.GetSourceCountInternal(this);
			}
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00004285 File Offset: 0x00002485
		public static int GetSourceCountInternal(RotationConstraint self)
		{
			return RotationConstraint.GetSourceCountInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00004297 File Offset: 0x00002497
		public void RemoveSource(int index)
		{
			this.ValidateSourceIndex(index);
			this.RemoveSourceInternal(index);
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x000042AA File Offset: 0x000024AA
		public void RemoveSourceInternal(int index)
		{
			RotationConstraint.RemoveSourceInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00013434 File Offset: 0x00011634
		public void ValidateSourceIndex(int index)
		{
			bool flag = this.sourceCount == 0;
			if (flag)
			{
				throw new InvalidOperationException("The RotationConstraint component has no sources.");
			}
			bool flag2 = index < 0 || index >= this.sourceCount;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("index", String.Format("Constraint source index {0} is out of bounds (0-{1}).", index, this.sourceCount));
			}
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x000042BD File Offset: 0x000024BD
		public void get_rotationAtRest_Injected(out Vector3 ret)
		{
			RotationConstraint.get_rotationAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x000042D0 File Offset: 0x000024D0
		public void set_rotationAtRest_Injected(ref Vector3 value)
		{
			RotationConstraint.set_rotationAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x000042E3 File Offset: 0x000024E3
		public void get_rotationOffset_Injected(out Vector3 ret)
		{
			RotationConstraint.get_rotationOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x000042F6 File Offset: 0x000024F6
		public void set_rotationOffset_Injected(ref Vector3 value)
		{
			RotationConstraint.set_rotationOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000460 RID: 1120
		private static readonly RotationConstraint.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<RotationConstraint.Internal_CreateDelegate>("UnityEngine.Animations.RotationConstraint::Internal_Create");

		// Token: 0x04000461 RID: 1121
		private static readonly RotationConstraint.get_weightDelegate get_weightDelegateField = IL2CPP.ResolveICall<RotationConstraint.get_weightDelegate>("UnityEngine.Animations.RotationConstraint::get_weight");

		// Token: 0x04000462 RID: 1122
		private static readonly RotationConstraint.set_weightDelegate set_weightDelegateField = IL2CPP.ResolveICall<RotationConstraint.set_weightDelegate>("UnityEngine.Animations.RotationConstraint::set_weight");

		// Token: 0x04000463 RID: 1123
		private static readonly RotationConstraint.get_rotationAxisDelegate get_rotationAxisDelegateField = IL2CPP.ResolveICall<RotationConstraint.get_rotationAxisDelegate>("UnityEngine.Animations.RotationConstraint::get_rotationAxis");

		// Token: 0x04000464 RID: 1124
		private static readonly RotationConstraint.set_rotationAxisDelegate set_rotationAxisDelegateField = IL2CPP.ResolveICall<RotationConstraint.set_rotationAxisDelegate>("UnityEngine.Animations.RotationConstraint::set_rotationAxis");

		// Token: 0x04000465 RID: 1125
		private static readonly RotationConstraint.get_constraintActiveDelegate get_constraintActiveDelegateField = IL2CPP.ResolveICall<RotationConstraint.get_constraintActiveDelegate>("UnityEngine.Animations.RotationConstraint::get_constraintActive");

		// Token: 0x04000466 RID: 1126
		private static readonly RotationConstraint.set_constraintActiveDelegate set_constraintActiveDelegateField = IL2CPP.ResolveICall<RotationConstraint.set_constraintActiveDelegate>("UnityEngine.Animations.RotationConstraint::set_constraintActive");

		// Token: 0x04000467 RID: 1127
		private static readonly RotationConstraint.get_lockedDelegate get_lockedDelegateField = IL2CPP.ResolveICall<RotationConstraint.get_lockedDelegate>("UnityEngine.Animations.RotationConstraint::get_locked");

		// Token: 0x04000468 RID: 1128
		private static readonly RotationConstraint.set_lockedDelegate set_lockedDelegateField = IL2CPP.ResolveICall<RotationConstraint.set_lockedDelegate>("UnityEngine.Animations.RotationConstraint::set_locked");

		// Token: 0x04000469 RID: 1129
		private static readonly RotationConstraint.GetSourceCountInternalDelegate GetSourceCountInternalDelegateField = IL2CPP.ResolveICall<RotationConstraint.GetSourceCountInternalDelegate>("UnityEngine.Animations.RotationConstraint::GetSourceCountInternal");

		// Token: 0x0400046A RID: 1130
		private static readonly RotationConstraint.RemoveSourceInternalDelegate RemoveSourceInternalDelegateField = IL2CPP.ResolveICall<RotationConstraint.RemoveSourceInternalDelegate>("UnityEngine.Animations.RotationConstraint::RemoveSourceInternal");

		// Token: 0x0400046B RID: 1131
		private static readonly RotationConstraint.get_rotationAtRest_InjectedDelegate get_rotationAtRest_InjectedDelegateField = IL2CPP.ResolveICall<RotationConstraint.get_rotationAtRest_InjectedDelegate>("UnityEngine.Animations.RotationConstraint::get_rotationAtRest_Injected");

		// Token: 0x0400046C RID: 1132
		private static readonly RotationConstraint.set_rotationAtRest_InjectedDelegate set_rotationAtRest_InjectedDelegateField = IL2CPP.ResolveICall<RotationConstraint.set_rotationAtRest_InjectedDelegate>("UnityEngine.Animations.RotationConstraint::set_rotationAtRest_Injected");

		// Token: 0x0400046D RID: 1133
		private static readonly RotationConstraint.get_rotationOffset_InjectedDelegate get_rotationOffset_InjectedDelegateField = IL2CPP.ResolveICall<RotationConstraint.get_rotationOffset_InjectedDelegate>("UnityEngine.Animations.RotationConstraint::get_rotationOffset_Injected");

		// Token: 0x0400046E RID: 1134
		private static readonly RotationConstraint.set_rotationOffset_InjectedDelegate set_rotationOffset_InjectedDelegateField = IL2CPP.ResolveICall<RotationConstraint.set_rotationOffset_InjectedDelegate>("UnityEngine.Animations.RotationConstraint::set_rotationOffset_Injected");

		// Token: 0x02000177 RID: 375
		// (Invoke) Token: 0x060007C9 RID: 1993
		private delegate void Internal_CreateDelegate(IntPtr self);

		// Token: 0x02000178 RID: 376
		// (Invoke) Token: 0x060007CB RID: 1995
		private delegate float get_weightDelegate(IntPtr @this);

		// Token: 0x02000179 RID: 377
		// (Invoke) Token: 0x060007CD RID: 1997
		private delegate void set_weightDelegate(IntPtr @this, float value);

		// Token: 0x0200017A RID: 378
		// (Invoke) Token: 0x060007CF RID: 1999
		private delegate Axis get_rotationAxisDelegate(IntPtr @this);

		// Token: 0x0200017B RID: 379
		// (Invoke) Token: 0x060007D1 RID: 2001
		private delegate void set_rotationAxisDelegate(IntPtr @this, Axis value);

		// Token: 0x0200017C RID: 380
		// (Invoke) Token: 0x060007D3 RID: 2003
		private delegate bool get_constraintActiveDelegate(IntPtr @this);

		// Token: 0x0200017D RID: 381
		// (Invoke) Token: 0x060007D5 RID: 2005
		private delegate void set_constraintActiveDelegate(IntPtr @this, bool value);

		// Token: 0x0200017E RID: 382
		// (Invoke) Token: 0x060007D7 RID: 2007
		private delegate bool get_lockedDelegate(IntPtr @this);

		// Token: 0x0200017F RID: 383
		// (Invoke) Token: 0x060007D9 RID: 2009
		private delegate void set_lockedDelegate(IntPtr @this, bool value);

		// Token: 0x02000180 RID: 384
		// (Invoke) Token: 0x060007DB RID: 2011
		private delegate int GetSourceCountInternalDelegate(IntPtr self);

		// Token: 0x02000181 RID: 385
		// (Invoke) Token: 0x060007DD RID: 2013
		private delegate void RemoveSourceInternalDelegate(IntPtr @this, int index);

		// Token: 0x02000182 RID: 386
		// (Invoke) Token: 0x060007DF RID: 2015
		private delegate void get_rotationAtRest_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000183 RID: 387
		// (Invoke) Token: 0x060007E1 RID: 2017
		private delegate void set_rotationAtRest_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000184 RID: 388
		// (Invoke) Token: 0x060007E3 RID: 2019
		private delegate void get_rotationOffset_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000185 RID: 389
		// (Invoke) Token: 0x060007E5 RID: 2021
		private delegate void set_rotationOffset_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
