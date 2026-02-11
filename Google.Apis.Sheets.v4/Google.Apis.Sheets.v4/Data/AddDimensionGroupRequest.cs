using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x0200000A RID: 10
	public class AddDimensionGroupRequest : Object
	{
		// Token: 0x06000091 RID: 145 RVA: 0x0000D294 File Offset: 0x0000B494
		// Note: this type is marked as 'beforefieldinit'.
		static AddDimensionGroupRequest()
		{
			Il2CppClassPointerStore<AddDimensionGroupRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "AddDimensionGroupRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddDimensionGroupRequest>.NativeClassPtr);
			AddDimensionGroupRequest.NativeFieldInfoPtr__Range_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddDimensionGroupRequest>.NativeClassPtr, "<Range>k__BackingField");
			AddDimensionGroupRequest.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddDimensionGroupRequest>.NativeClassPtr, "<ETag>k__BackingField");
			AddDimensionGroupRequest.NativeMethodInfoPtr_get_Range_Public_Virtual_New_get_DimensionRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddDimensionGroupRequest>.NativeClassPtr, 100663588);
			AddDimensionGroupRequest.NativeMethodInfoPtr_set_Range_Public_Virtual_New_set_Void_DimensionRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddDimensionGroupRequest>.NativeClassPtr, 100663589);
			AddDimensionGroupRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddDimensionGroupRequest>.NativeClassPtr, 100663590);
			AddDimensionGroupRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddDimensionGroupRequest>.NativeClassPtr, 100663591);
			AddDimensionGroupRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddDimensionGroupRequest>.NativeClassPtr, 100663592);
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0000D350 File Offset: 0x0000B550
		// (set) Token: 0x06000093 RID: 147 RVA: 0x0000D39C File Offset: 0x0000B59C
		public unsafe virtual DimensionRange Range
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddDimensionGroupRequest.NativeMethodInfoPtr_get_Range_Public_Virtual_New_get_DimensionRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DimensionRange>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddDimensionGroupRequest.NativeMethodInfoPtr_set_Range_Public_Virtual_New_set_Void_DimensionRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000094 RID: 148 RVA: 0x0000D3EC File Offset: 0x0000B5EC
		// (set) Token: 0x06000095 RID: 149 RVA: 0x0000D430 File Offset: 0x0000B630
		public unsafe virtual string ETag
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddDimensionGroupRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddDimensionGroupRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000D480 File Offset: 0x0000B680
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddDimensionGroupRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddDimensionGroupRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddDimensionGroupRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000244B File Offset: 0x0000064B
		public AddDimensionGroupRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000098 RID: 152 RVA: 0x0000D4BC File Offset: 0x0000B6BC
		// (set) Token: 0x06000099 RID: 153 RVA: 0x00002454 File Offset: 0x00000654
		public unsafe DimensionRange _Range_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddDimensionGroupRequest.NativeFieldInfoPtr__Range_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DimensionRange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddDimensionGroupRequest.NativeFieldInfoPtr__Range_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600009A RID: 154 RVA: 0x0000D4EC File Offset: 0x0000B6EC
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00002473 File Offset: 0x00000673
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddDimensionGroupRequest.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddDimensionGroupRequest.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeFieldInfoPtr__Range_k__BackingField;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_get_Range_Public_Virtual_New_get_DimensionRange_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_set_Range_Public_Virtual_New_set_Void_DimensionRange_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
