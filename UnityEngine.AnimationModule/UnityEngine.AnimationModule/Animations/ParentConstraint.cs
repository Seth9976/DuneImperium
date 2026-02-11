using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Animations
{
	// Token: 0x0200005F RID: 95
	public sealed class ParentConstraint : Behaviour
	{
		// Token: 0x0600056A RID: 1386 RVA: 0x000045C2 File Offset: 0x000027C2
		public static void Internal_Create(ParentConstraint self)
		{
			ParentConstraint.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x000045D4 File Offset: 0x000027D4
		// (set) Token: 0x0600056C RID: 1388 RVA: 0x000045E6 File Offset: 0x000027E6
		public float weight
		{
			get
			{
				return ParentConstraint.get_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParentConstraint.set_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x000045F9 File Offset: 0x000027F9
		// (set) Token: 0x0600056E RID: 1390 RVA: 0x0000460B File Offset: 0x0000280B
		public bool constraintActive
		{
			get
			{
				return ParentConstraint.get_constraintActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParentConstraint.set_constraintActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x0000461E File Offset: 0x0000281E
		// (set) Token: 0x06000570 RID: 1392 RVA: 0x00004630 File Offset: 0x00002830
		public bool locked
		{
			get
			{
				return ParentConstraint.get_lockedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParentConstraint.set_lockedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x000139C8 File Offset: 0x00011BC8
		public int sourceCount
		{
			get
			{
				return ParentConstraint.GetSourceCountInternal(this);
			}
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00004643 File Offset: 0x00002843
		public static int GetSourceCountInternal(ParentConstraint self)
		{
			return ParentConstraint.GetSourceCountInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x000139E0 File Offset: 0x00011BE0
		// (set) Token: 0x06000574 RID: 1396 RVA: 0x00004655 File Offset: 0x00002855
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

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x000139F8 File Offset: 0x00011BF8
		// (set) Token: 0x06000576 RID: 1398 RVA: 0x0000465F File Offset: 0x0000285F
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

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x00013A10 File Offset: 0x00011C10
		// (set) Token: 0x06000578 RID: 1400 RVA: 0x00004669 File Offset: 0x00002869
		public Il2CppStructArray<Vector3> translationOffsets
		{
			get
			{
				IntPtr intPtr = ParentConstraint.get_translationOffsetsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				ParentConstraint.set_translationOffsetsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x00013A3C File Offset: 0x00011C3C
		// (set) Token: 0x0600057A RID: 1402 RVA: 0x00004681 File Offset: 0x00002881
		public Il2CppStructArray<Vector3> rotationOffsets
		{
			get
			{
				IntPtr intPtr = ParentConstraint.get_rotationOffsetsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				ParentConstraint.set_rotationOffsetsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x00004699 File Offset: 0x00002899
		// (set) Token: 0x0600057C RID: 1404 RVA: 0x000046AB File Offset: 0x000028AB
		public Axis translationAxis
		{
			get
			{
				return ParentConstraint.get_translationAxisDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParentConstraint.set_translationAxisDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x000046BE File Offset: 0x000028BE
		// (set) Token: 0x0600057E RID: 1406 RVA: 0x000046D0 File Offset: 0x000028D0
		public Axis rotationAxis
		{
			get
			{
				return ParentConstraint.get_rotationAxisDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParentConstraint.set_rotationAxisDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00013A68 File Offset: 0x00011C68
		public Vector3 GetTranslationOffset(int index)
		{
			this.ValidateSourceIndex(index);
			return this.GetTranslationOffsetInternal(index);
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x000046E3 File Offset: 0x000028E3
		public void SetTranslationOffset(int index, Vector3 value)
		{
			this.ValidateSourceIndex(index);
			this.SetTranslationOffsetInternal(index, value);
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00013A8C File Offset: 0x00011C8C
		public Vector3 GetTranslationOffsetInternal(int index)
		{
			Vector3 vector;
			this.GetTranslationOffsetInternal_Injected(index, out vector);
			return vector;
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x000046F7 File Offset: 0x000028F7
		public void SetTranslationOffsetInternal(int index, Vector3 value)
		{
			this.SetTranslationOffsetInternal_Injected(index, ref value);
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00013AA4 File Offset: 0x00011CA4
		public Vector3 GetRotationOffset(int index)
		{
			this.ValidateSourceIndex(index);
			return this.GetRotationOffsetInternal(index);
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00004702 File Offset: 0x00002902
		public void SetRotationOffset(int index, Vector3 value)
		{
			this.ValidateSourceIndex(index);
			this.SetRotationOffsetInternal(index, value);
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00013AC8 File Offset: 0x00011CC8
		public Vector3 GetRotationOffsetInternal(int index)
		{
			Vector3 vector;
			this.GetRotationOffsetInternal_Injected(index, out vector);
			return vector;
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00004716 File Offset: 0x00002916
		public void SetRotationOffsetInternal(int index, Vector3 value)
		{
			this.SetRotationOffsetInternal_Injected(index, ref value);
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00013AE0 File Offset: 0x00011CE0
		public void ValidateSourceIndex(int index)
		{
			bool flag = this.sourceCount == 0;
			if (flag)
			{
				throw new InvalidOperationException("The ParentConstraint component has no sources.");
			}
			bool flag2 = index < 0 || index >= this.sourceCount;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("index", String.Format("Constraint source index {0} is out of bounds (0-{1}).", index, this.sourceCount));
			}
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00004721 File Offset: 0x00002921
		public void RemoveSource(int index)
		{
			this.ValidateSourceIndex(index);
			this.RemoveSourceInternal(index);
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x00004734 File Offset: 0x00002934
		public void RemoveSourceInternal(int index)
		{
			ParentConstraint.RemoveSourceInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x00004747 File Offset: 0x00002947
		public void get_translationAtRest_Injected(out Vector3 ret)
		{
			ParentConstraint.get_translationAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x0000475A File Offset: 0x0000295A
		public void set_translationAtRest_Injected(ref Vector3 value)
		{
			ParentConstraint.set_translationAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x0000476D File Offset: 0x0000296D
		public void get_rotationAtRest_Injected(out Vector3 ret)
		{
			ParentConstraint.get_rotationAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00004780 File Offset: 0x00002980
		public void set_rotationAtRest_Injected(ref Vector3 value)
		{
			ParentConstraint.set_rotationAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00004793 File Offset: 0x00002993
		public void GetTranslationOffsetInternal_Injected(int index, out Vector3 ret)
		{
			ParentConstraint.GetTranslationOffsetInternal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, out ret);
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x000047A7 File Offset: 0x000029A7
		public void SetTranslationOffsetInternal_Injected(int index, ref Vector3 value)
		{
			ParentConstraint.SetTranslationOffsetInternal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, ref value);
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x000047BB File Offset: 0x000029BB
		public void GetRotationOffsetInternal_Injected(int index, out Vector3 ret)
		{
			ParentConstraint.GetRotationOffsetInternal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, out ret);
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x000047CF File Offset: 0x000029CF
		public void SetRotationOffsetInternal_Injected(int index, ref Vector3 value)
		{
			ParentConstraint.SetRotationOffsetInternal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, ref value);
		}

		// Token: 0x04000491 RID: 1169
		private static readonly ParentConstraint.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<ParentConstraint.Internal_CreateDelegate>("UnityEngine.Animations.ParentConstraint::Internal_Create");

		// Token: 0x04000492 RID: 1170
		private static readonly ParentConstraint.get_weightDelegate get_weightDelegateField = IL2CPP.ResolveICall<ParentConstraint.get_weightDelegate>("UnityEngine.Animations.ParentConstraint::get_weight");

		// Token: 0x04000493 RID: 1171
		private static readonly ParentConstraint.set_weightDelegate set_weightDelegateField = IL2CPP.ResolveICall<ParentConstraint.set_weightDelegate>("UnityEngine.Animations.ParentConstraint::set_weight");

		// Token: 0x04000494 RID: 1172
		private static readonly ParentConstraint.get_constraintActiveDelegate get_constraintActiveDelegateField = IL2CPP.ResolveICall<ParentConstraint.get_constraintActiveDelegate>("UnityEngine.Animations.ParentConstraint::get_constraintActive");

		// Token: 0x04000495 RID: 1173
		private static readonly ParentConstraint.set_constraintActiveDelegate set_constraintActiveDelegateField = IL2CPP.ResolveICall<ParentConstraint.set_constraintActiveDelegate>("UnityEngine.Animations.ParentConstraint::set_constraintActive");

		// Token: 0x04000496 RID: 1174
		private static readonly ParentConstraint.get_lockedDelegate get_lockedDelegateField = IL2CPP.ResolveICall<ParentConstraint.get_lockedDelegate>("UnityEngine.Animations.ParentConstraint::get_locked");

		// Token: 0x04000497 RID: 1175
		private static readonly ParentConstraint.set_lockedDelegate set_lockedDelegateField = IL2CPP.ResolveICall<ParentConstraint.set_lockedDelegate>("UnityEngine.Animations.ParentConstraint::set_locked");

		// Token: 0x04000498 RID: 1176
		private static readonly ParentConstraint.GetSourceCountInternalDelegate GetSourceCountInternalDelegateField = IL2CPP.ResolveICall<ParentConstraint.GetSourceCountInternalDelegate>("UnityEngine.Animations.ParentConstraint::GetSourceCountInternal");

		// Token: 0x04000499 RID: 1177
		private static readonly ParentConstraint.get_translationOffsetsDelegate get_translationOffsetsDelegateField = IL2CPP.ResolveICall<ParentConstraint.get_translationOffsetsDelegate>("UnityEngine.Animations.ParentConstraint::get_translationOffsets");

		// Token: 0x0400049A RID: 1178
		private static readonly ParentConstraint.set_translationOffsetsDelegate set_translationOffsetsDelegateField = IL2CPP.ResolveICall<ParentConstraint.set_translationOffsetsDelegate>("UnityEngine.Animations.ParentConstraint::set_translationOffsets");

		// Token: 0x0400049B RID: 1179
		private static readonly ParentConstraint.get_rotationOffsetsDelegate get_rotationOffsetsDelegateField = IL2CPP.ResolveICall<ParentConstraint.get_rotationOffsetsDelegate>("UnityEngine.Animations.ParentConstraint::get_rotationOffsets");

		// Token: 0x0400049C RID: 1180
		private static readonly ParentConstraint.set_rotationOffsetsDelegate set_rotationOffsetsDelegateField = IL2CPP.ResolveICall<ParentConstraint.set_rotationOffsetsDelegate>("UnityEngine.Animations.ParentConstraint::set_rotationOffsets");

		// Token: 0x0400049D RID: 1181
		private static readonly ParentConstraint.get_translationAxisDelegate get_translationAxisDelegateField = IL2CPP.ResolveICall<ParentConstraint.get_translationAxisDelegate>("UnityEngine.Animations.ParentConstraint::get_translationAxis");

		// Token: 0x0400049E RID: 1182
		private static readonly ParentConstraint.set_translationAxisDelegate set_translationAxisDelegateField = IL2CPP.ResolveICall<ParentConstraint.set_translationAxisDelegate>("UnityEngine.Animations.ParentConstraint::set_translationAxis");

		// Token: 0x0400049F RID: 1183
		private static readonly ParentConstraint.get_rotationAxisDelegate get_rotationAxisDelegateField = IL2CPP.ResolveICall<ParentConstraint.get_rotationAxisDelegate>("UnityEngine.Animations.ParentConstraint::get_rotationAxis");

		// Token: 0x040004A0 RID: 1184
		private static readonly ParentConstraint.set_rotationAxisDelegate set_rotationAxisDelegateField = IL2CPP.ResolveICall<ParentConstraint.set_rotationAxisDelegate>("UnityEngine.Animations.ParentConstraint::set_rotationAxis");

		// Token: 0x040004A1 RID: 1185
		private static readonly ParentConstraint.RemoveSourceInternalDelegate RemoveSourceInternalDelegateField = IL2CPP.ResolveICall<ParentConstraint.RemoveSourceInternalDelegate>("UnityEngine.Animations.ParentConstraint::RemoveSourceInternal");

		// Token: 0x040004A2 RID: 1186
		private static readonly ParentConstraint.get_translationAtRest_InjectedDelegate get_translationAtRest_InjectedDelegateField = IL2CPP.ResolveICall<ParentConstraint.get_translationAtRest_InjectedDelegate>("UnityEngine.Animations.ParentConstraint::get_translationAtRest_Injected");

		// Token: 0x040004A3 RID: 1187
		private static readonly ParentConstraint.set_translationAtRest_InjectedDelegate set_translationAtRest_InjectedDelegateField = IL2CPP.ResolveICall<ParentConstraint.set_translationAtRest_InjectedDelegate>("UnityEngine.Animations.ParentConstraint::set_translationAtRest_Injected");

		// Token: 0x040004A4 RID: 1188
		private static readonly ParentConstraint.get_rotationAtRest_InjectedDelegate get_rotationAtRest_InjectedDelegateField = IL2CPP.ResolveICall<ParentConstraint.get_rotationAtRest_InjectedDelegate>("UnityEngine.Animations.ParentConstraint::get_rotationAtRest_Injected");

		// Token: 0x040004A5 RID: 1189
		private static readonly ParentConstraint.set_rotationAtRest_InjectedDelegate set_rotationAtRest_InjectedDelegateField = IL2CPP.ResolveICall<ParentConstraint.set_rotationAtRest_InjectedDelegate>("UnityEngine.Animations.ParentConstraint::set_rotationAtRest_Injected");

		// Token: 0x040004A6 RID: 1190
		private static readonly ParentConstraint.GetTranslationOffsetInternal_InjectedDelegate GetTranslationOffsetInternal_InjectedDelegateField = IL2CPP.ResolveICall<ParentConstraint.GetTranslationOffsetInternal_InjectedDelegate>("UnityEngine.Animations.ParentConstraint::GetTranslationOffsetInternal_Injected");

		// Token: 0x040004A7 RID: 1191
		private static readonly ParentConstraint.SetTranslationOffsetInternal_InjectedDelegate SetTranslationOffsetInternal_InjectedDelegateField = IL2CPP.ResolveICall<ParentConstraint.SetTranslationOffsetInternal_InjectedDelegate>("UnityEngine.Animations.ParentConstraint::SetTranslationOffsetInternal_Injected");

		// Token: 0x040004A8 RID: 1192
		private static readonly ParentConstraint.GetRotationOffsetInternal_InjectedDelegate GetRotationOffsetInternal_InjectedDelegateField = IL2CPP.ResolveICall<ParentConstraint.GetRotationOffsetInternal_InjectedDelegate>("UnityEngine.Animations.ParentConstraint::GetRotationOffsetInternal_Injected");

		// Token: 0x040004A9 RID: 1193
		private static readonly ParentConstraint.SetRotationOffsetInternal_InjectedDelegate SetRotationOffsetInternal_InjectedDelegateField = IL2CPP.ResolveICall<ParentConstraint.SetRotationOffsetInternal_InjectedDelegate>("UnityEngine.Animations.ParentConstraint::SetRotationOffsetInternal_Injected");

		// Token: 0x020001A8 RID: 424
		// (Invoke) Token: 0x0600082B RID: 2091
		private delegate void Internal_CreateDelegate(IntPtr self);

		// Token: 0x020001A9 RID: 425
		// (Invoke) Token: 0x0600082D RID: 2093
		private delegate float get_weightDelegate(IntPtr @this);

		// Token: 0x020001AA RID: 426
		// (Invoke) Token: 0x0600082F RID: 2095
		private delegate void set_weightDelegate(IntPtr @this, float value);

		// Token: 0x020001AB RID: 427
		// (Invoke) Token: 0x06000831 RID: 2097
		private delegate bool get_constraintActiveDelegate(IntPtr @this);

		// Token: 0x020001AC RID: 428
		// (Invoke) Token: 0x06000833 RID: 2099
		private delegate void set_constraintActiveDelegate(IntPtr @this, bool value);

		// Token: 0x020001AD RID: 429
		// (Invoke) Token: 0x06000835 RID: 2101
		private delegate bool get_lockedDelegate(IntPtr @this);

		// Token: 0x020001AE RID: 430
		// (Invoke) Token: 0x06000837 RID: 2103
		private delegate void set_lockedDelegate(IntPtr @this, bool value);

		// Token: 0x020001AF RID: 431
		// (Invoke) Token: 0x06000839 RID: 2105
		private delegate int GetSourceCountInternalDelegate(IntPtr self);

		// Token: 0x020001B0 RID: 432
		// (Invoke) Token: 0x0600083B RID: 2107
		private delegate IntPtr get_translationOffsetsDelegate(IntPtr @this);

		// Token: 0x020001B1 RID: 433
		// (Invoke) Token: 0x0600083D RID: 2109
		private delegate void set_translationOffsetsDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020001B2 RID: 434
		// (Invoke) Token: 0x0600083F RID: 2111
		private delegate IntPtr get_rotationOffsetsDelegate(IntPtr @this);

		// Token: 0x020001B3 RID: 435
		// (Invoke) Token: 0x06000841 RID: 2113
		private delegate void set_rotationOffsetsDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020001B4 RID: 436
		// (Invoke) Token: 0x06000843 RID: 2115
		private delegate Axis get_translationAxisDelegate(IntPtr @this);

		// Token: 0x020001B5 RID: 437
		// (Invoke) Token: 0x06000845 RID: 2117
		private delegate void set_translationAxisDelegate(IntPtr @this, Axis value);

		// Token: 0x020001B6 RID: 438
		// (Invoke) Token: 0x06000847 RID: 2119
		private delegate Axis get_rotationAxisDelegate(IntPtr @this);

		// Token: 0x020001B7 RID: 439
		// (Invoke) Token: 0x06000849 RID: 2121
		private delegate void set_rotationAxisDelegate(IntPtr @this, Axis value);

		// Token: 0x020001B8 RID: 440
		// (Invoke) Token: 0x0600084B RID: 2123
		private delegate void RemoveSourceInternalDelegate(IntPtr @this, int index);

		// Token: 0x020001B9 RID: 441
		// (Invoke) Token: 0x0600084D RID: 2125
		private delegate void get_translationAtRest_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020001BA RID: 442
		// (Invoke) Token: 0x0600084F RID: 2127
		private delegate void set_translationAtRest_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020001BB RID: 443
		// (Invoke) Token: 0x06000851 RID: 2129
		private delegate void get_rotationAtRest_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020001BC RID: 444
		// (Invoke) Token: 0x06000853 RID: 2131
		private delegate void set_rotationAtRest_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020001BD RID: 445
		// (Invoke) Token: 0x06000855 RID: 2133
		private delegate void GetTranslationOffsetInternal_InjectedDelegate(IntPtr @this, int index, [Out] IntPtr ret);

		// Token: 0x020001BE RID: 446
		// (Invoke) Token: 0x06000857 RID: 2135
		private delegate void SetTranslationOffsetInternal_InjectedDelegate(IntPtr @this, int index, IntPtr value);

		// Token: 0x020001BF RID: 447
		// (Invoke) Token: 0x06000859 RID: 2137
		private delegate void GetRotationOffsetInternal_InjectedDelegate(IntPtr @this, int index, [Out] IntPtr ret);

		// Token: 0x020001C0 RID: 448
		// (Invoke) Token: 0x0600085B RID: 2139
		private delegate void SetRotationOffsetInternal_InjectedDelegate(IntPtr @this, int index, IntPtr value);
	}
}
