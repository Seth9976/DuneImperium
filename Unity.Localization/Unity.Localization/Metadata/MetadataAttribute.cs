using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Localization.Metadata
{
	// Token: 0x020000CF RID: 207
	public class MetadataAttribute : Attribute
	{
		// Token: 0x06000ABD RID: 2749 RVA: 0x00031BC0 File Offset: 0x0002FDC0
		// Note: this type is marked as 'beforefieldinit'.
		static MetadataAttribute()
		{
			Il2CppClassPointerStore<MetadataAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Metadata", "MetadataAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MetadataAttribute>.NativeClassPtr);
			MetadataAttribute.NativeFieldInfoPtr__MenuItem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetadataAttribute>.NativeClassPtr, "<MenuItem>k__BackingField");
			MetadataAttribute.NativeFieldInfoPtr__AllowMultiple_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetadataAttribute>.NativeClassPtr, "<AllowMultiple>k__BackingField");
			MetadataAttribute.NativeFieldInfoPtr__AllowedTypes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetadataAttribute>.NativeClassPtr, "<AllowedTypes>k__BackingField");
			MetadataAttribute.NativeMethodInfoPtr_get_MenuItem_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataAttribute>.NativeClassPtr, 100665087);
			MetadataAttribute.NativeMethodInfoPtr_set_MenuItem_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataAttribute>.NativeClassPtr, 100665088);
			MetadataAttribute.NativeMethodInfoPtr_get_AllowMultiple_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataAttribute>.NativeClassPtr, 100665089);
			MetadataAttribute.NativeMethodInfoPtr_set_AllowMultiple_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataAttribute>.NativeClassPtr, 100665090);
			MetadataAttribute.NativeMethodInfoPtr_get_AllowedTypes_Public_get_MetadataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataAttribute>.NativeClassPtr, 100665091);
			MetadataAttribute.NativeMethodInfoPtr_set_AllowedTypes_Public_set_Void_MetadataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataAttribute>.NativeClassPtr, 100665092);
			MetadataAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataAttribute>.NativeClassPtr, 100665093);
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x00031CB8 File Offset: 0x0002FEB8
		// (set) Token: 0x06000ABF RID: 2751 RVA: 0x00031CF0 File Offset: 0x0002FEF0
		public unsafe string MenuItem
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetadataAttribute.NativeMethodInfoPtr_get_MenuItem_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetadataAttribute.NativeMethodInfoPtr_set_MenuItem_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x00031D34 File Offset: 0x0002FF34
		// (set) Token: 0x06000AC1 RID: 2753 RVA: 0x00031D70 File Offset: 0x0002FF70
		public unsafe bool AllowMultiple
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetadataAttribute.NativeMethodInfoPtr_get_AllowMultiple_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetadataAttribute.NativeMethodInfoPtr_set_AllowMultiple_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x00031DB0 File Offset: 0x0002FFB0
		// (set) Token: 0x06000AC3 RID: 2755 RVA: 0x00031DEC File Offset: 0x0002FFEC
		public unsafe MetadataType AllowedTypes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetadataAttribute.NativeMethodInfoPtr_get_AllowedTypes_Public_get_MetadataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetadataAttribute.NativeMethodInfoPtr_set_AllowedTypes_Public_set_Void_MetadataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x00031E2C File Offset: 0x0003002C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078899, XrefRangeEnd = 1078900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MetadataAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MetadataAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetadataAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x000067DE File Offset: 0x000049DE
		public MetadataAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x00031E68 File Offset: 0x00030068
		// (set) Token: 0x06000AC7 RID: 2759 RVA: 0x000067E7 File Offset: 0x000049E7
		public unsafe string _MenuItem_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetadataAttribute.NativeFieldInfoPtr__MenuItem_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetadataAttribute.NativeFieldInfoPtr__MenuItem_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000AC8 RID: 2760 RVA: 0x00031E90 File Offset: 0x00030090
		// (set) Token: 0x06000AC9 RID: 2761 RVA: 0x00006806 File Offset: 0x00004A06
		public unsafe bool _AllowMultiple_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetadataAttribute.NativeFieldInfoPtr__AllowMultiple_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetadataAttribute.NativeFieldInfoPtr__AllowMultiple_k__BackingField)) = value;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000ACA RID: 2762 RVA: 0x00031EB8 File Offset: 0x000300B8
		// (set) Token: 0x06000ACB RID: 2763 RVA: 0x00006821 File Offset: 0x00004A21
		public unsafe MetadataType _AllowedTypes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetadataAttribute.NativeFieldInfoPtr__AllowedTypes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetadataAttribute.NativeFieldInfoPtr__AllowedTypes_k__BackingField)) = value;
			}
		}

		// Token: 0x04000790 RID: 1936
		private static readonly IntPtr NativeFieldInfoPtr__MenuItem_k__BackingField;

		// Token: 0x04000791 RID: 1937
		private static readonly IntPtr NativeFieldInfoPtr__AllowMultiple_k__BackingField;

		// Token: 0x04000792 RID: 1938
		private static readonly IntPtr NativeFieldInfoPtr__AllowedTypes_k__BackingField;

		// Token: 0x04000793 RID: 1939
		private static readonly IntPtr NativeMethodInfoPtr_get_MenuItem_Public_get_String_0;

		// Token: 0x04000794 RID: 1940
		private static readonly IntPtr NativeMethodInfoPtr_set_MenuItem_Public_set_Void_String_0;

		// Token: 0x04000795 RID: 1941
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowMultiple_Public_get_Boolean_0;

		// Token: 0x04000796 RID: 1942
		private static readonly IntPtr NativeMethodInfoPtr_set_AllowMultiple_Public_set_Void_Boolean_0;

		// Token: 0x04000797 RID: 1943
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowedTypes_Public_get_MetadataType_0;

		// Token: 0x04000798 RID: 1944
		private static readonly IntPtr NativeMethodInfoPtr_set_AllowedTypes_Public_set_Void_MetadataType_0;

		// Token: 0x04000799 RID: 1945
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
