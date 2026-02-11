using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000022 RID: 34
	public class HumanTrait : Object
	{
		// Token: 0x0600027A RID: 634 RVA: 0x0000F840 File Offset: 0x0000DA40
		// Note: this type is marked as 'beforefieldinit'.
		static HumanTrait()
		{
			Il2CppClassPointerStore<HumanTrait>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "HumanTrait");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HumanTrait>.NativeClassPtr);
			HumanTrait.NativeMethodInfoPtr_GetBoneIndexFromMono_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanTrait>.NativeClassPtr, 100663727);
			HumanTrait.get_MuscleCountDelegateField = IL2CPP.ResolveICall<HumanTrait.get_MuscleCountDelegate>("UnityEngine.HumanTrait::get_MuscleCount");
			HumanTrait.GetBoneIndexToMonoDelegateField = IL2CPP.ResolveICall<HumanTrait.GetBoneIndexToMonoDelegate>("UnityEngine.HumanTrait::GetBoneIndexToMono");
			HumanTrait.get_MuscleNameDelegateField = IL2CPP.ResolveICall<HumanTrait.get_MuscleNameDelegate>("UnityEngine.HumanTrait::get_MuscleName");
			HumanTrait.get_BoneCountDelegateField = IL2CPP.ResolveICall<HumanTrait.get_BoneCountDelegate>("UnityEngine.HumanTrait::get_BoneCount");
			HumanTrait.get_BoneNameDelegateField = IL2CPP.ResolveICall<HumanTrait.get_BoneNameDelegate>("UnityEngine.HumanTrait::get_BoneName");
			HumanTrait.Internal_MuscleFromBoneDelegateField = IL2CPP.ResolveICall<HumanTrait.Internal_MuscleFromBoneDelegate>("UnityEngine.HumanTrait::Internal_MuscleFromBone");
			HumanTrait.Internal_BoneFromMuscleDelegateField = IL2CPP.ResolveICall<HumanTrait.Internal_BoneFromMuscleDelegate>("UnityEngine.HumanTrait::Internal_BoneFromMuscle");
			HumanTrait.Internal_RequiredBoneDelegateField = IL2CPP.ResolveICall<HumanTrait.Internal_RequiredBoneDelegate>("UnityEngine.HumanTrait::Internal_RequiredBone");
			HumanTrait.get_RequiredBoneCountDelegateField = IL2CPP.ResolveICall<HumanTrait.get_RequiredBoneCountDelegate>("UnityEngine.HumanTrait::get_RequiredBoneCount");
			HumanTrait.GetMuscleDefaultMinDelegateField = IL2CPP.ResolveICall<HumanTrait.GetMuscleDefaultMinDelegate>("UnityEngine.HumanTrait::GetMuscleDefaultMin");
			HumanTrait.GetMuscleDefaultMaxDelegateField = IL2CPP.ResolveICall<HumanTrait.GetMuscleDefaultMaxDelegate>("UnityEngine.HumanTrait::GetMuscleDefaultMax");
			HumanTrait.Internal_GetBoneHierarchyMassDelegateField = IL2CPP.ResolveICall<HumanTrait.Internal_GetBoneHierarchyMassDelegate>("UnityEngine.HumanTrait::Internal_GetBoneHierarchyMass");
			HumanTrait.Internal_GetParentDelegateField = IL2CPP.ResolveICall<HumanTrait.Internal_GetParentDelegate>("UnityEngine.HumanTrait::Internal_GetParent");
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000F948 File Offset: 0x0000DB48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220834, XrefRangeEnd = 1220836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetBoneIndexFromMono(int humanId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref humanId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HumanTrait.NativeMethodInfoPtr_GetBoneIndexFromMono_Internal_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x000027A4 File Offset: 0x000009A4
		public HumanTrait(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600027D RID: 637 RVA: 0x000027AD File Offset: 0x000009AD
		public static int MuscleCount
		{
			get
			{
				return HumanTrait.get_MuscleCountDelegateField();
			}
		}

		// Token: 0x0600027E RID: 638 RVA: 0x000027B9 File Offset: 0x000009B9
		public static int GetBoneIndexToMono(int boneIndex)
		{
			return HumanTrait.GetBoneIndexToMonoDelegateField(boneIndex);
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600027F RID: 639 RVA: 0x0000F988 File Offset: 0x0000DB88
		public static Il2CppStringArray MuscleName
		{
			get
			{
				IntPtr intPtr = HumanTrait.get_MuscleNameDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000280 RID: 640 RVA: 0x000027C6 File Offset: 0x000009C6
		public static int BoneCount
		{
			get
			{
				return HumanTrait.get_BoneCountDelegateField();
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000281 RID: 641 RVA: 0x0000F9B0 File Offset: 0x0000DBB0
		public static Il2CppStringArray BoneName
		{
			get
			{
				IntPtr intPtr = HumanTrait.get_BoneNameDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000F9D8 File Offset: 0x0000DBD8
		public static int MuscleFromBone(int i, int dofIndex)
		{
			return HumanTrait.Internal_MuscleFromBone(HumanTrait.GetBoneIndexFromMono(i), dofIndex);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x000027D2 File Offset: 0x000009D2
		public static int Internal_MuscleFromBone(int i, int dofIndex)
		{
			return HumanTrait.Internal_MuscleFromBoneDelegateField(i, dofIndex);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000F9F8 File Offset: 0x0000DBF8
		public static int BoneFromMuscle(int i)
		{
			return HumanTrait.GetBoneIndexToMono(HumanTrait.Internal_BoneFromMuscle(i));
		}

		// Token: 0x06000285 RID: 645 RVA: 0x000027E0 File Offset: 0x000009E0
		public static int Internal_BoneFromMuscle(int i)
		{
			return HumanTrait.Internal_BoneFromMuscleDelegateField(i);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0000FA18 File Offset: 0x0000DC18
		public static bool RequiredBone(int i)
		{
			return HumanTrait.Internal_RequiredBone(HumanTrait.GetBoneIndexFromMono(i));
		}

		// Token: 0x06000287 RID: 647 RVA: 0x000027ED File Offset: 0x000009ED
		public static bool Internal_RequiredBone(int i)
		{
			return HumanTrait.Internal_RequiredBoneDelegateField(i);
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000288 RID: 648 RVA: 0x000027FA File Offset: 0x000009FA
		public static int RequiredBoneCount
		{
			get
			{
				return HumanTrait.get_RequiredBoneCountDelegateField();
			}
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00002806 File Offset: 0x00000A06
		public static float GetMuscleDefaultMin(int i)
		{
			return HumanTrait.GetMuscleDefaultMinDelegateField(i);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00002813 File Offset: 0x00000A13
		public static float GetMuscleDefaultMax(int i)
		{
			return HumanTrait.GetMuscleDefaultMaxDelegateField(i);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000FA38 File Offset: 0x0000DC38
		public static float GetBoneDefaultHierarchyMass(int i)
		{
			return HumanTrait.Internal_GetBoneHierarchyMass(HumanTrait.GetBoneIndexFromMono(i));
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000FA58 File Offset: 0x0000DC58
		public static int GetParentBone(int i)
		{
			int num = HumanTrait.Internal_GetParent(HumanTrait.GetBoneIndexFromMono(i));
			return (num != -1) ? HumanTrait.GetBoneIndexToMono(num) : (-1);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00002820 File Offset: 0x00000A20
		public static float Internal_GetBoneHierarchyMass(int i)
		{
			return HumanTrait.Internal_GetBoneHierarchyMassDelegateField(i);
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000282D File Offset: 0x00000A2D
		public static int Internal_GetParent(int i)
		{
			return HumanTrait.Internal_GetParentDelegateField(i);
		}

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeMethodInfoPtr_GetBoneIndexFromMono_Internal_Static_Int32_Int32_0;

		// Token: 0x0400028C RID: 652
		private static readonly HumanTrait.get_MuscleCountDelegate get_MuscleCountDelegateField;

		// Token: 0x0400028D RID: 653
		private static readonly HumanTrait.GetBoneIndexToMonoDelegate GetBoneIndexToMonoDelegateField;

		// Token: 0x0400028E RID: 654
		private static readonly HumanTrait.get_MuscleNameDelegate get_MuscleNameDelegateField;

		// Token: 0x0400028F RID: 655
		private static readonly HumanTrait.get_BoneCountDelegate get_BoneCountDelegateField;

		// Token: 0x04000290 RID: 656
		private static readonly HumanTrait.get_BoneNameDelegate get_BoneNameDelegateField;

		// Token: 0x04000291 RID: 657
		private static readonly HumanTrait.Internal_MuscleFromBoneDelegate Internal_MuscleFromBoneDelegateField;

		// Token: 0x04000292 RID: 658
		private static readonly HumanTrait.Internal_BoneFromMuscleDelegate Internal_BoneFromMuscleDelegateField;

		// Token: 0x04000293 RID: 659
		private static readonly HumanTrait.Internal_RequiredBoneDelegate Internal_RequiredBoneDelegateField;

		// Token: 0x04000294 RID: 660
		private static readonly HumanTrait.get_RequiredBoneCountDelegate get_RequiredBoneCountDelegateField;

		// Token: 0x04000295 RID: 661
		private static readonly HumanTrait.GetMuscleDefaultMinDelegate GetMuscleDefaultMinDelegateField;

		// Token: 0x04000296 RID: 662
		private static readonly HumanTrait.GetMuscleDefaultMaxDelegate GetMuscleDefaultMaxDelegateField;

		// Token: 0x04000297 RID: 663
		private static readonly HumanTrait.Internal_GetBoneHierarchyMassDelegate Internal_GetBoneHierarchyMassDelegateField;

		// Token: 0x04000298 RID: 664
		private static readonly HumanTrait.Internal_GetParentDelegate Internal_GetParentDelegateField;

		// Token: 0x02000085 RID: 133
		// (Invoke) Token: 0x060005E7 RID: 1511
		private delegate int get_MuscleCountDelegate();

		// Token: 0x02000086 RID: 134
		// (Invoke) Token: 0x060005E9 RID: 1513
		private delegate int GetBoneIndexToMonoDelegate(int boneIndex);

		// Token: 0x02000087 RID: 135
		// (Invoke) Token: 0x060005EB RID: 1515
		private delegate IntPtr get_MuscleNameDelegate();

		// Token: 0x02000088 RID: 136
		// (Invoke) Token: 0x060005ED RID: 1517
		private delegate int get_BoneCountDelegate();

		// Token: 0x02000089 RID: 137
		// (Invoke) Token: 0x060005EF RID: 1519
		private delegate IntPtr get_BoneNameDelegate();

		// Token: 0x0200008A RID: 138
		// (Invoke) Token: 0x060005F1 RID: 1521
		private delegate int Internal_MuscleFromBoneDelegate(int i, int dofIndex);

		// Token: 0x0200008B RID: 139
		// (Invoke) Token: 0x060005F3 RID: 1523
		private delegate int Internal_BoneFromMuscleDelegate(int i);

		// Token: 0x0200008C RID: 140
		// (Invoke) Token: 0x060005F5 RID: 1525
		private delegate bool Internal_RequiredBoneDelegate(int i);

		// Token: 0x0200008D RID: 141
		// (Invoke) Token: 0x060005F7 RID: 1527
		private delegate int get_RequiredBoneCountDelegate();

		// Token: 0x0200008E RID: 142
		// (Invoke) Token: 0x060005F9 RID: 1529
		private delegate float GetMuscleDefaultMinDelegate(int i);

		// Token: 0x0200008F RID: 143
		// (Invoke) Token: 0x060005FB RID: 1531
		private delegate float GetMuscleDefaultMaxDelegate(int i);

		// Token: 0x02000090 RID: 144
		// (Invoke) Token: 0x060005FD RID: 1533
		private delegate float Internal_GetBoneHierarchyMassDelegate(int i);

		// Token: 0x02000091 RID: 145
		// (Invoke) Token: 0x060005FF RID: 1535
		private delegate int Internal_GetParentDelegate(int i);
	}
}
