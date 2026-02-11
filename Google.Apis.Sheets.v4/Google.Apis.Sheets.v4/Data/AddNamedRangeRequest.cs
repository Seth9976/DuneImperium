using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x0200000E RID: 14
	public class AddNamedRangeRequest : Object
	{
		// Token: 0x060000BD RID: 189 RVA: 0x0000DC94 File Offset: 0x0000BE94
		// Note: this type is marked as 'beforefieldinit'.
		static AddNamedRangeRequest()
		{
			Il2CppClassPointerStore<AddNamedRangeRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "AddNamedRangeRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddNamedRangeRequest>.NativeClassPtr);
			AddNamedRangeRequest.NativeFieldInfoPtr__NamedRange_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddNamedRangeRequest>.NativeClassPtr, "<NamedRange>k__BackingField");
			AddNamedRangeRequest.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddNamedRangeRequest>.NativeClassPtr, "<ETag>k__BackingField");
			AddNamedRangeRequest.NativeMethodInfoPtr_get_NamedRange_Public_Virtual_New_get_NamedRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddNamedRangeRequest>.NativeClassPtr, 100663608);
			AddNamedRangeRequest.NativeMethodInfoPtr_set_NamedRange_Public_Virtual_New_set_Void_NamedRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddNamedRangeRequest>.NativeClassPtr, 100663609);
			AddNamedRangeRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddNamedRangeRequest>.NativeClassPtr, 100663610);
			AddNamedRangeRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddNamedRangeRequest>.NativeClassPtr, 100663611);
			AddNamedRangeRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddNamedRangeRequest>.NativeClassPtr, 100663612);
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000BE RID: 190 RVA: 0x0000DD50 File Offset: 0x0000BF50
		// (set) Token: 0x060000BF RID: 191 RVA: 0x0000DD9C File Offset: 0x0000BF9C
		public unsafe virtual NamedRange NamedRange
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddNamedRangeRequest.NativeMethodInfoPtr_get_NamedRange_Public_Virtual_New_get_NamedRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NamedRange>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddNamedRangeRequest.NativeMethodInfoPtr_set_NamedRange_Public_Virtual_New_set_Void_NamedRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x0000DDEC File Offset: 0x0000BFEC
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x0000DE30 File Offset: 0x0000C030
		public unsafe virtual string ETag
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddNamedRangeRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddNamedRangeRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000DE80 File Offset: 0x0000C080
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddNamedRangeRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddNamedRangeRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddNamedRangeRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002567 File Offset: 0x00000767
		public AddNamedRangeRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x0000DEBC File Offset: 0x0000C0BC
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x00002570 File Offset: 0x00000770
		public unsafe NamedRange _NamedRange_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddNamedRangeRequest.NativeFieldInfoPtr__NamedRange_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NamedRange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddNamedRangeRequest.NativeFieldInfoPtr__NamedRange_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x0000DEEC File Offset: 0x0000C0EC
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x0000258F File Offset: 0x0000078F
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddNamedRangeRequest.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddNamedRangeRequest.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeFieldInfoPtr__NamedRange_k__BackingField;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_get_NamedRange_Public_Virtual_New_get_NamedRange_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_set_NamedRange_Public_Virtual_New_set_Void_NamedRange_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
