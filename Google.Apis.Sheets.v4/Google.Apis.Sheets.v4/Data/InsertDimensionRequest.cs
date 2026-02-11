using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x0200007C RID: 124
	public class InsertDimensionRequest : Object
	{
		// Token: 0x0600095F RID: 2399 RVA: 0x0002EA98 File Offset: 0x0002CC98
		// Note: this type is marked as 'beforefieldinit'.
		static InsertDimensionRequest()
		{
			Il2CppClassPointerStore<InsertDimensionRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "InsertDimensionRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InsertDimensionRequest>.NativeClassPtr);
			InsertDimensionRequest.NativeFieldInfoPtr__InheritFromBefore_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InsertDimensionRequest>.NativeClassPtr, "<InheritFromBefore>k__BackingField");
			InsertDimensionRequest.NativeFieldInfoPtr__Range_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InsertDimensionRequest>.NativeClassPtr, "<Range>k__BackingField");
			InsertDimensionRequest.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InsertDimensionRequest>.NativeClassPtr, "<ETag>k__BackingField");
			InsertDimensionRequest.NativeMethodInfoPtr_get_InheritFromBefore_Public_Virtual_New_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InsertDimensionRequest>.NativeClassPtr, 100664658);
			InsertDimensionRequest.NativeMethodInfoPtr_set_InheritFromBefore_Public_Virtual_New_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InsertDimensionRequest>.NativeClassPtr, 100664659);
			InsertDimensionRequest.NativeMethodInfoPtr_get_Range_Public_Virtual_New_get_DimensionRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InsertDimensionRequest>.NativeClassPtr, 100664660);
			InsertDimensionRequest.NativeMethodInfoPtr_set_Range_Public_Virtual_New_set_Void_DimensionRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InsertDimensionRequest>.NativeClassPtr, 100664661);
			InsertDimensionRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InsertDimensionRequest>.NativeClassPtr, 100664662);
			InsertDimensionRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InsertDimensionRequest>.NativeClassPtr, 100664663);
			InsertDimensionRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InsertDimensionRequest>.NativeClassPtr, 100664664);
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000960 RID: 2400 RVA: 0x0002EB90 File Offset: 0x0002CD90
		// (set) Token: 0x06000961 RID: 2401 RVA: 0x0002EBD4 File Offset: 0x0002CDD4
		public unsafe virtual Nullable<bool> InheritFromBefore
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InsertDimensionRequest.NativeMethodInfoPtr_get_InheritFromBefore_Public_Virtual_New_get_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InsertDimensionRequest.NativeMethodInfoPtr_set_InheritFromBefore_Public_Virtual_New_set_Void_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000962 RID: 2402 RVA: 0x0002EC28 File Offset: 0x0002CE28
		// (set) Token: 0x06000963 RID: 2403 RVA: 0x0002EC74 File Offset: 0x0002CE74
		public unsafe virtual DimensionRange Range
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InsertDimensionRequest.NativeMethodInfoPtr_get_Range_Public_Virtual_New_get_DimensionRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DimensionRange>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InsertDimensionRequest.NativeMethodInfoPtr_set_Range_Public_Virtual_New_set_Void_DimensionRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000964 RID: 2404 RVA: 0x0002ECC4 File Offset: 0x0002CEC4
		// (set) Token: 0x06000965 RID: 2405 RVA: 0x0002ED08 File Offset: 0x0002CF08
		public unsafe virtual string ETag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InsertDimensionRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InsertDimensionRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x0002ED58 File Offset: 0x0002CF58
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InsertDimensionRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InsertDimensionRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InsertDimensionRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00006838 File Offset: 0x00004A38
		public InsertDimensionRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000968 RID: 2408 RVA: 0x0002ED94 File Offset: 0x0002CF94
		// (set) Token: 0x06000969 RID: 2409 RVA: 0x00006841 File Offset: 0x00004A41
		public Nullable<bool> _InheritFromBefore_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InsertDimensionRequest.NativeFieldInfoPtr__InheritFromBefore_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InsertDimensionRequest.NativeFieldInfoPtr__InheritFromBefore_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x0600096A RID: 2410 RVA: 0x0002EDC4 File Offset: 0x0002CFC4
		// (set) Token: 0x0600096B RID: 2411 RVA: 0x0000686F File Offset: 0x00004A6F
		public unsafe DimensionRange _Range_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InsertDimensionRequest.NativeFieldInfoPtr__Range_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DimensionRange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InsertDimensionRequest.NativeFieldInfoPtr__Range_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x0600096C RID: 2412 RVA: 0x0002EDF4 File Offset: 0x0002CFF4
		// (set) Token: 0x0600096D RID: 2413 RVA: 0x0000688E File Offset: 0x00004A8E
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InsertDimensionRequest.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InsertDimensionRequest.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400066F RID: 1647
		private static readonly IntPtr NativeFieldInfoPtr__InheritFromBefore_k__BackingField;

		// Token: 0x04000670 RID: 1648
		private static readonly IntPtr NativeFieldInfoPtr__Range_k__BackingField;

		// Token: 0x04000671 RID: 1649
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000672 RID: 1650
		private static readonly IntPtr NativeMethodInfoPtr_get_InheritFromBefore_Public_Virtual_New_get_Nullable_1_Boolean_0;

		// Token: 0x04000673 RID: 1651
		private static readonly IntPtr NativeMethodInfoPtr_set_InheritFromBefore_Public_Virtual_New_set_Void_Nullable_1_Boolean_0;

		// Token: 0x04000674 RID: 1652
		private static readonly IntPtr NativeMethodInfoPtr_get_Range_Public_Virtual_New_get_DimensionRange_0;

		// Token: 0x04000675 RID: 1653
		private static readonly IntPtr NativeMethodInfoPtr_set_Range_Public_Virtual_New_set_Void_DimensionRange_0;

		// Token: 0x04000676 RID: 1654
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000677 RID: 1655
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000678 RID: 1656
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
