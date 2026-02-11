using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x020000B5 RID: 181
	public class UnmergeCellsRequest : Object
	{
		// Token: 0x06000F7A RID: 3962 RVA: 0x000466F4 File Offset: 0x000448F4
		// Note: this type is marked as 'beforefieldinit'.
		static UnmergeCellsRequest()
		{
			Il2CppClassPointerStore<UnmergeCellsRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "UnmergeCellsRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnmergeCellsRequest>.NativeClassPtr);
			UnmergeCellsRequest.NativeFieldInfoPtr__Range_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmergeCellsRequest>.NativeClassPtr, "<Range>k__BackingField");
			UnmergeCellsRequest.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmergeCellsRequest>.NativeClassPtr, "<ETag>k__BackingField");
			UnmergeCellsRequest.NativeMethodInfoPtr_get_Range_Public_Virtual_New_get_GridRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmergeCellsRequest>.NativeClassPtr, 100665411);
			UnmergeCellsRequest.NativeMethodInfoPtr_set_Range_Public_Virtual_New_set_Void_GridRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmergeCellsRequest>.NativeClassPtr, 100665412);
			UnmergeCellsRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmergeCellsRequest>.NativeClassPtr, 100665413);
			UnmergeCellsRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmergeCellsRequest>.NativeClassPtr, 100665414);
			UnmergeCellsRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmergeCellsRequest>.NativeClassPtr, 100665415);
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06000F7B RID: 3963 RVA: 0x000467B0 File Offset: 0x000449B0
		// (set) Token: 0x06000F7C RID: 3964 RVA: 0x000467FC File Offset: 0x000449FC
		public unsafe virtual GridRange Range
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmergeCellsRequest.NativeMethodInfoPtr_get_Range_Public_Virtual_New_get_GridRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GridRange>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmergeCellsRequest.NativeMethodInfoPtr_set_Range_Public_Virtual_New_set_Void_GridRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06000F7D RID: 3965 RVA: 0x0004684C File Offset: 0x00044A4C
		// (set) Token: 0x06000F7E RID: 3966 RVA: 0x00046890 File Offset: 0x00044A90
		public unsafe virtual string ETag
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmergeCellsRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmergeCellsRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x000468E0 File Offset: 0x00044AE0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnmergeCellsRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnmergeCellsRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnmergeCellsRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x0000973C File Offset: 0x0000793C
		public UnmergeCellsRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06000F81 RID: 3969 RVA: 0x0004691C File Offset: 0x00044B1C
		// (set) Token: 0x06000F82 RID: 3970 RVA: 0x00009745 File Offset: 0x00007945
		public unsafe GridRange _Range_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmergeCellsRequest.NativeFieldInfoPtr__Range_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridRange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmergeCellsRequest.NativeFieldInfoPtr__Range_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06000F83 RID: 3971 RVA: 0x0004694C File Offset: 0x00044B4C
		// (set) Token: 0x06000F84 RID: 3972 RVA: 0x00009764 File Offset: 0x00007964
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmergeCellsRequest.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmergeCellsRequest.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000ABC RID: 2748
		private static readonly IntPtr NativeFieldInfoPtr__Range_k__BackingField;

		// Token: 0x04000ABD RID: 2749
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000ABE RID: 2750
		private static readonly IntPtr NativeMethodInfoPtr_get_Range_Public_Virtual_New_get_GridRange_0;

		// Token: 0x04000ABF RID: 2751
		private static readonly IntPtr NativeMethodInfoPtr_set_Range_Public_Virtual_New_set_Void_GridRange_0;

		// Token: 0x04000AC0 RID: 2752
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000AC1 RID: 2753
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000AC2 RID: 2754
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
