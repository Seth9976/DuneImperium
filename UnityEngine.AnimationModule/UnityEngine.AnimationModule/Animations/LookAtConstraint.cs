using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Animations
{
	// Token: 0x0200005E RID: 94
	public sealed class LookAtConstraint : Behaviour
	{
		// Token: 0x0600054F RID: 1359 RVA: 0x00004447 File Offset: 0x00002647
		public static void Internal_Create(LookAtConstraint self)
		{
			LookAtConstraint.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x00004459 File Offset: 0x00002659
		// (set) Token: 0x06000551 RID: 1361 RVA: 0x0000446B File Offset: 0x0000266B
		public float weight
		{
			get
			{
				return LookAtConstraint.get_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LookAtConstraint.set_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x0000447E File Offset: 0x0000267E
		// (set) Token: 0x06000553 RID: 1363 RVA: 0x00004490 File Offset: 0x00002690
		public float roll
		{
			get
			{
				return LookAtConstraint.get_rollDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LookAtConstraint.set_rollDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000554 RID: 1364 RVA: 0x000044A3 File Offset: 0x000026A3
		// (set) Token: 0x06000555 RID: 1365 RVA: 0x000044B5 File Offset: 0x000026B5
		public bool constraintActive
		{
			get
			{
				return LookAtConstraint.get_constraintActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LookAtConstraint.set_constraintActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000556 RID: 1366 RVA: 0x000044C8 File Offset: 0x000026C8
		// (set) Token: 0x06000557 RID: 1367 RVA: 0x000044DA File Offset: 0x000026DA
		public bool locked
		{
			get
			{
				return LookAtConstraint.get_lockedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LookAtConstraint.set_lockedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x00013768 File Offset: 0x00011968
		// (set) Token: 0x06000559 RID: 1369 RVA: 0x000044ED File Offset: 0x000026ED
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

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x0600055A RID: 1370 RVA: 0x00013780 File Offset: 0x00011980
		// (set) Token: 0x0600055B RID: 1371 RVA: 0x000044F7 File Offset: 0x000026F7
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

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600055C RID: 1372 RVA: 0x00013798 File Offset: 0x00011998
		// (set) Token: 0x0600055D RID: 1373 RVA: 0x00004501 File Offset: 0x00002701
		public Transform worldUpObject
		{
			get
			{
				IntPtr intPtr = LookAtConstraint.get_worldUpObjectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				LookAtConstraint.set_worldUpObjectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x00004519 File Offset: 0x00002719
		// (set) Token: 0x0600055F RID: 1375 RVA: 0x0000452B File Offset: 0x0000272B
		public bool useUpObject
		{
			get
			{
				return LookAtConstraint.get_useUpObjectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LookAtConstraint.set_useUpObjectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000560 RID: 1376 RVA: 0x000137C4 File Offset: 0x000119C4
		public int sourceCount
		{
			get
			{
				return LookAtConstraint.GetSourceCountInternal(this);
			}
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x0000453E File Offset: 0x0000273E
		public static int GetSourceCountInternal(LookAtConstraint self)
		{
			return LookAtConstraint.GetSourceCountInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00004550 File Offset: 0x00002750
		public void RemoveSource(int index)
		{
			this.ValidateSourceIndex(index);
			this.RemoveSourceInternal(index);
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00004563 File Offset: 0x00002763
		public void RemoveSourceInternal(int index)
		{
			LookAtConstraint.RemoveSourceInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x000137DC File Offset: 0x000119DC
		public void ValidateSourceIndex(int index)
		{
			bool flag = this.sourceCount == 0;
			if (flag)
			{
				throw new InvalidOperationException("The LookAtConstraint component has no sources.");
			}
			bool flag2 = index < 0 || index >= this.sourceCount;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("index", String.Format("Constraint source index {0} is out of bounds (0-{1}).", index, this.sourceCount));
			}
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00004576 File Offset: 0x00002776
		public void get_rotationAtRest_Injected(out Vector3 ret)
		{
			LookAtConstraint.get_rotationAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00004589 File Offset: 0x00002789
		public void set_rotationAtRest_Injected(ref Vector3 value)
		{
			LookAtConstraint.set_rotationAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0000459C File Offset: 0x0000279C
		public void get_rotationOffset_Injected(out Vector3 ret)
		{
			LookAtConstraint.get_rotationOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x000045AF File Offset: 0x000027AF
		public void set_rotationOffset_Injected(ref Vector3 value)
		{
			LookAtConstraint.set_rotationOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0400047E RID: 1150
		private static readonly LookAtConstraint.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<LookAtConstraint.Internal_CreateDelegate>("UnityEngine.Animations.LookAtConstraint::Internal_Create");

		// Token: 0x0400047F RID: 1151
		private static readonly LookAtConstraint.get_weightDelegate get_weightDelegateField = IL2CPP.ResolveICall<LookAtConstraint.get_weightDelegate>("UnityEngine.Animations.LookAtConstraint::get_weight");

		// Token: 0x04000480 RID: 1152
		private static readonly LookAtConstraint.set_weightDelegate set_weightDelegateField = IL2CPP.ResolveICall<LookAtConstraint.set_weightDelegate>("UnityEngine.Animations.LookAtConstraint::set_weight");

		// Token: 0x04000481 RID: 1153
		private static readonly LookAtConstraint.get_rollDelegate get_rollDelegateField = IL2CPP.ResolveICall<LookAtConstraint.get_rollDelegate>("UnityEngine.Animations.LookAtConstraint::get_roll");

		// Token: 0x04000482 RID: 1154
		private static readonly LookAtConstraint.set_rollDelegate set_rollDelegateField = IL2CPP.ResolveICall<LookAtConstraint.set_rollDelegate>("UnityEngine.Animations.LookAtConstraint::set_roll");

		// Token: 0x04000483 RID: 1155
		private static readonly LookAtConstraint.get_constraintActiveDelegate get_constraintActiveDelegateField = IL2CPP.ResolveICall<LookAtConstraint.get_constraintActiveDelegate>("UnityEngine.Animations.LookAtConstraint::get_constraintActive");

		// Token: 0x04000484 RID: 1156
		private static readonly LookAtConstraint.set_constraintActiveDelegate set_constraintActiveDelegateField = IL2CPP.ResolveICall<LookAtConstraint.set_constraintActiveDelegate>("UnityEngine.Animations.LookAtConstraint::set_constraintActive");

		// Token: 0x04000485 RID: 1157
		private static readonly LookAtConstraint.get_lockedDelegate get_lockedDelegateField = IL2CPP.ResolveICall<LookAtConstraint.get_lockedDelegate>("UnityEngine.Animations.LookAtConstraint::get_locked");

		// Token: 0x04000486 RID: 1158
		private static readonly LookAtConstraint.set_lockedDelegate set_lockedDelegateField = IL2CPP.ResolveICall<LookAtConstraint.set_lockedDelegate>("UnityEngine.Animations.LookAtConstraint::set_locked");

		// Token: 0x04000487 RID: 1159
		private static readonly LookAtConstraint.get_worldUpObjectDelegate get_worldUpObjectDelegateField = IL2CPP.ResolveICall<LookAtConstraint.get_worldUpObjectDelegate>("UnityEngine.Animations.LookAtConstraint::get_worldUpObject");

		// Token: 0x04000488 RID: 1160
		private static readonly LookAtConstraint.set_worldUpObjectDelegate set_worldUpObjectDelegateField = IL2CPP.ResolveICall<LookAtConstraint.set_worldUpObjectDelegate>("UnityEngine.Animations.LookAtConstraint::set_worldUpObject");

		// Token: 0x04000489 RID: 1161
		private static readonly LookAtConstraint.get_useUpObjectDelegate get_useUpObjectDelegateField = IL2CPP.ResolveICall<LookAtConstraint.get_useUpObjectDelegate>("UnityEngine.Animations.LookAtConstraint::get_useUpObject");

		// Token: 0x0400048A RID: 1162
		private static readonly LookAtConstraint.set_useUpObjectDelegate set_useUpObjectDelegateField = IL2CPP.ResolveICall<LookAtConstraint.set_useUpObjectDelegate>("UnityEngine.Animations.LookAtConstraint::set_useUpObject");

		// Token: 0x0400048B RID: 1163
		private static readonly LookAtConstraint.GetSourceCountInternalDelegate GetSourceCountInternalDelegateField = IL2CPP.ResolveICall<LookAtConstraint.GetSourceCountInternalDelegate>("UnityEngine.Animations.LookAtConstraint::GetSourceCountInternal");

		// Token: 0x0400048C RID: 1164
		private static readonly LookAtConstraint.RemoveSourceInternalDelegate RemoveSourceInternalDelegateField = IL2CPP.ResolveICall<LookAtConstraint.RemoveSourceInternalDelegate>("UnityEngine.Animations.LookAtConstraint::RemoveSourceInternal");

		// Token: 0x0400048D RID: 1165
		private static readonly LookAtConstraint.get_rotationAtRest_InjectedDelegate get_rotationAtRest_InjectedDelegateField = IL2CPP.ResolveICall<LookAtConstraint.get_rotationAtRest_InjectedDelegate>("UnityEngine.Animations.LookAtConstraint::get_rotationAtRest_Injected");

		// Token: 0x0400048E RID: 1166
		private static readonly LookAtConstraint.set_rotationAtRest_InjectedDelegate set_rotationAtRest_InjectedDelegateField = IL2CPP.ResolveICall<LookAtConstraint.set_rotationAtRest_InjectedDelegate>("UnityEngine.Animations.LookAtConstraint::set_rotationAtRest_Injected");

		// Token: 0x0400048F RID: 1167
		private static readonly LookAtConstraint.get_rotationOffset_InjectedDelegate get_rotationOffset_InjectedDelegateField = IL2CPP.ResolveICall<LookAtConstraint.get_rotationOffset_InjectedDelegate>("UnityEngine.Animations.LookAtConstraint::get_rotationOffset_Injected");

		// Token: 0x04000490 RID: 1168
		private static readonly LookAtConstraint.set_rotationOffset_InjectedDelegate set_rotationOffset_InjectedDelegateField = IL2CPP.ResolveICall<LookAtConstraint.set_rotationOffset_InjectedDelegate>("UnityEngine.Animations.LookAtConstraint::set_rotationOffset_Injected");

		// Token: 0x02000195 RID: 405
		// (Invoke) Token: 0x06000805 RID: 2053
		private delegate void Internal_CreateDelegate(IntPtr self);

		// Token: 0x02000196 RID: 406
		// (Invoke) Token: 0x06000807 RID: 2055
		private delegate float get_weightDelegate(IntPtr @this);

		// Token: 0x02000197 RID: 407
		// (Invoke) Token: 0x06000809 RID: 2057
		private delegate void set_weightDelegate(IntPtr @this, float value);

		// Token: 0x02000198 RID: 408
		// (Invoke) Token: 0x0600080B RID: 2059
		private delegate float get_rollDelegate(IntPtr @this);

		// Token: 0x02000199 RID: 409
		// (Invoke) Token: 0x0600080D RID: 2061
		private delegate void set_rollDelegate(IntPtr @this, float value);

		// Token: 0x0200019A RID: 410
		// (Invoke) Token: 0x0600080F RID: 2063
		private delegate bool get_constraintActiveDelegate(IntPtr @this);

		// Token: 0x0200019B RID: 411
		// (Invoke) Token: 0x06000811 RID: 2065
		private delegate void set_constraintActiveDelegate(IntPtr @this, bool value);

		// Token: 0x0200019C RID: 412
		// (Invoke) Token: 0x06000813 RID: 2067
		private delegate bool get_lockedDelegate(IntPtr @this);

		// Token: 0x0200019D RID: 413
		// (Invoke) Token: 0x06000815 RID: 2069
		private delegate void set_lockedDelegate(IntPtr @this, bool value);

		// Token: 0x0200019E RID: 414
		// (Invoke) Token: 0x06000817 RID: 2071
		private delegate IntPtr get_worldUpObjectDelegate(IntPtr @this);

		// Token: 0x0200019F RID: 415
		// (Invoke) Token: 0x06000819 RID: 2073
		private delegate void set_worldUpObjectDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020001A0 RID: 416
		// (Invoke) Token: 0x0600081B RID: 2075
		private delegate bool get_useUpObjectDelegate(IntPtr @this);

		// Token: 0x020001A1 RID: 417
		// (Invoke) Token: 0x0600081D RID: 2077
		private delegate void set_useUpObjectDelegate(IntPtr @this, bool value);

		// Token: 0x020001A2 RID: 418
		// (Invoke) Token: 0x0600081F RID: 2079
		private delegate int GetSourceCountInternalDelegate(IntPtr self);

		// Token: 0x020001A3 RID: 419
		// (Invoke) Token: 0x06000821 RID: 2081
		private delegate void RemoveSourceInternalDelegate(IntPtr @this, int index);

		// Token: 0x020001A4 RID: 420
		// (Invoke) Token: 0x06000823 RID: 2083
		private delegate void get_rotationAtRest_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020001A5 RID: 421
		// (Invoke) Token: 0x06000825 RID: 2085
		private delegate void set_rotationAtRest_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020001A6 RID: 422
		// (Invoke) Token: 0x06000827 RID: 2087
		private delegate void get_rotationOffset_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020001A7 RID: 423
		// (Invoke) Token: 0x06000829 RID: 2089
		private delegate void set_rotationOffset_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
