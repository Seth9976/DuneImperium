using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000015 RID: 21
	public class AddSlicerResponse : Object
	{
		// Token: 0x0600010A RID: 266 RVA: 0x0000EE14 File Offset: 0x0000D014
		// Note: this type is marked as 'beforefieldinit'.
		static AddSlicerResponse()
		{
			Il2CppClassPointerStore<AddSlicerResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "AddSlicerResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddSlicerResponse>.NativeClassPtr);
			AddSlicerResponse.NativeFieldInfoPtr__Slicer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddSlicerResponse>.NativeClassPtr, "<Slicer>k__BackingField");
			AddSlicerResponse.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddSlicerResponse>.NativeClassPtr, "<ETag>k__BackingField");
			AddSlicerResponse.NativeMethodInfoPtr_get_Slicer_Public_Virtual_New_get_Slicer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddSlicerResponse>.NativeClassPtr, 100663643);
			AddSlicerResponse.NativeMethodInfoPtr_set_Slicer_Public_Virtual_New_set_Void_Slicer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddSlicerResponse>.NativeClassPtr, 100663644);
			AddSlicerResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddSlicerResponse>.NativeClassPtr, 100663645);
			AddSlicerResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddSlicerResponse>.NativeClassPtr, 100663646);
			AddSlicerResponse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddSlicerResponse>.NativeClassPtr, 100663647);
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600010B RID: 267 RVA: 0x0000EED0 File Offset: 0x0000D0D0
		// (set) Token: 0x0600010C RID: 268 RVA: 0x0000EF1C File Offset: 0x0000D11C
		public unsafe virtual Slicer Slicer
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddSlicerResponse.NativeMethodInfoPtr_get_Slicer_Public_Virtual_New_get_Slicer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Slicer>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddSlicerResponse.NativeMethodInfoPtr_set_Slicer_Public_Virtual_New_set_Void_Slicer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600010D RID: 269 RVA: 0x0000EF6C File Offset: 0x0000D16C
		// (set) Token: 0x0600010E RID: 270 RVA: 0x0000EFB0 File Offset: 0x0000D1B0
		public unsafe virtual string ETag
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddSlicerResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddSlicerResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000F000 File Offset: 0x0000D200
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddSlicerResponse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddSlicerResponse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddSlicerResponse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002758 File Offset: 0x00000958
		public AddSlicerResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000111 RID: 273 RVA: 0x0000F03C File Offset: 0x0000D23C
		// (set) Token: 0x06000112 RID: 274 RVA: 0x00002761 File Offset: 0x00000961
		public unsafe Slicer _Slicer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddSlicerResponse.NativeFieldInfoPtr__Slicer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slicer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddSlicerResponse.NativeFieldInfoPtr__Slicer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000113 RID: 275 RVA: 0x0000F06C File Offset: 0x0000D26C
		// (set) Token: 0x06000114 RID: 276 RVA: 0x00002780 File Offset: 0x00000980
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddSlicerResponse.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddSlicerResponse.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeFieldInfoPtr__Slicer_k__BackingField;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_get_Slicer_Public_Virtual_New_get_Slicer_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_set_Slicer_Public_Virtual_New_set_Void_Slicer_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
