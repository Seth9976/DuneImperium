using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x0200009F RID: 159
	public class SetBasicFilterRequest : Object
	{
		// Token: 0x06000D40 RID: 3392 RVA: 0x0003DCE0 File Offset: 0x0003BEE0
		// Note: this type is marked as 'beforefieldinit'.
		static SetBasicFilterRequest()
		{
			Il2CppClassPointerStore<SetBasicFilterRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "SetBasicFilterRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetBasicFilterRequest>.NativeClassPtr);
			SetBasicFilterRequest.NativeFieldInfoPtr__Filter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetBasicFilterRequest>.NativeClassPtr, "<Filter>k__BackingField");
			SetBasicFilterRequest.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetBasicFilterRequest>.NativeClassPtr, "<ETag>k__BackingField");
			SetBasicFilterRequest.NativeMethodInfoPtr_get_Filter_Public_Virtual_New_get_BasicFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetBasicFilterRequest>.NativeClassPtr, 100665137);
			SetBasicFilterRequest.NativeMethodInfoPtr_set_Filter_Public_Virtual_New_set_Void_BasicFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetBasicFilterRequest>.NativeClassPtr, 100665138);
			SetBasicFilterRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetBasicFilterRequest>.NativeClassPtr, 100665139);
			SetBasicFilterRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetBasicFilterRequest>.NativeClassPtr, 100665140);
			SetBasicFilterRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetBasicFilterRequest>.NativeClassPtr, 100665141);
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06000D41 RID: 3393 RVA: 0x0003DD9C File Offset: 0x0003BF9C
		// (set) Token: 0x06000D42 RID: 3394 RVA: 0x0003DDE8 File Offset: 0x0003BFE8
		public unsafe virtual BasicFilter Filter
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SetBasicFilterRequest.NativeMethodInfoPtr_get_Filter_Public_Virtual_New_get_BasicFilter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BasicFilter>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SetBasicFilterRequest.NativeMethodInfoPtr_set_Filter_Public_Virtual_New_set_Void_BasicFilter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06000D43 RID: 3395 RVA: 0x0003DE38 File Offset: 0x0003C038
		// (set) Token: 0x06000D44 RID: 3396 RVA: 0x0003DE7C File Offset: 0x0003C07C
		public unsafe virtual string ETag
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SetBasicFilterRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SetBasicFilterRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x0003DECC File Offset: 0x0003C0CC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetBasicFilterRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetBasicFilterRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetBasicFilterRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x000085DB File Offset: 0x000067DB
		public SetBasicFilterRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06000D47 RID: 3399 RVA: 0x0003DF08 File Offset: 0x0003C108
		// (set) Token: 0x06000D48 RID: 3400 RVA: 0x000085E4 File Offset: 0x000067E4
		public unsafe BasicFilter _Filter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetBasicFilterRequest.NativeFieldInfoPtr__Filter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BasicFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetBasicFilterRequest.NativeFieldInfoPtr__Filter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06000D49 RID: 3401 RVA: 0x0003DF38 File Offset: 0x0003C138
		// (set) Token: 0x06000D4A RID: 3402 RVA: 0x00008603 File Offset: 0x00006803
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetBasicFilterRequest.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetBasicFilterRequest.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400092C RID: 2348
		private static readonly IntPtr NativeFieldInfoPtr__Filter_k__BackingField;

		// Token: 0x0400092D RID: 2349
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x0400092E RID: 2350
		private static readonly IntPtr NativeMethodInfoPtr_get_Filter_Public_Virtual_New_get_BasicFilter_0;

		// Token: 0x0400092F RID: 2351
		private static readonly IntPtr NativeMethodInfoPtr_set_Filter_Public_Virtual_New_set_Void_BasicFilter_0;

		// Token: 0x04000930 RID: 2352
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000931 RID: 2353
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000932 RID: 2354
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
