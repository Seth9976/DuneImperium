using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace lotus
{
	// Token: 0x02000073 RID: 115
	[Serializable]
	public class PoolDefinition : Object
	{
		// Token: 0x060006C5 RID: 1733 RVA: 0x0001FCF0 File Offset: 0x0001DEF0
		// Note: this type is marked as 'beforefieldinit'.
		static PoolDefinition()
		{
			Il2CppClassPointerStore<PoolDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "PoolDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoolDefinition>.NativeClassPtr);
			PoolDefinition.NativeFieldInfoPtr_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolDefinition>.NativeClassPtr, "Prefab");
			PoolDefinition.NativeFieldInfoPtr_PrePoolCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolDefinition>.NativeClassPtr, "PrePoolCount");
			PoolDefinition.NativeFieldInfoPtr_MaxPoolCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolDefinition>.NativeClassPtr, "MaxPoolCount");
			PoolDefinition.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolDefinition>.NativeClassPtr, 100664225);
			PoolDefinition.NativeMethodInfoPtr_Clone_Public_PoolDefinition_PoolableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolDefinition>.NativeClassPtr, 100664226);
			PoolDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolDefinition>.NativeClassPtr, 100664227);
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x0001FD98 File Offset: 0x0001DF98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113562, XrefRangeEnd = 1113569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoolDefinition.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x0001FDDC File Offset: 0x0001DFDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113569, XrefRangeEnd = 1113574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PoolDefinition Clone(PoolableItem prefab)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolDefinition.NativeMethodInfoPtr_Clone_Public_PoolDefinition_PoolableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PoolDefinition>(intPtr3) : null;
			}
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x0001FE2C File Offset: 0x0001E02C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PoolDefinition()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoolDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00005575 File Offset: 0x00003775
		public PoolDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060006CA RID: 1738 RVA: 0x0001FE68 File Offset: 0x0001E068
		// (set) Token: 0x060006CB RID: 1739 RVA: 0x0000557E File Offset: 0x0000377E
		public unsafe PoolableItem Prefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolDefinition.NativeFieldInfoPtr_Prefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoolableItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolDefinition.NativeFieldInfoPtr_Prefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060006CC RID: 1740 RVA: 0x0001FE98 File Offset: 0x0001E098
		// (set) Token: 0x060006CD RID: 1741 RVA: 0x0000559D File Offset: 0x0000379D
		public unsafe int PrePoolCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolDefinition.NativeFieldInfoPtr_PrePoolCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolDefinition.NativeFieldInfoPtr_PrePoolCount)) = value;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x0001FEC0 File Offset: 0x0001E0C0
		// (set) Token: 0x060006CF RID: 1743 RVA: 0x000055B8 File Offset: 0x000037B8
		public unsafe int MaxPoolCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolDefinition.NativeFieldInfoPtr_MaxPoolCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolDefinition.NativeFieldInfoPtr_MaxPoolCount)) = value;
			}
		}

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeFieldInfoPtr_Prefab;

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeFieldInfoPtr_PrePoolCount;

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeFieldInfoPtr_MaxPoolCount;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_PoolDefinition_PoolableItem_0;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
