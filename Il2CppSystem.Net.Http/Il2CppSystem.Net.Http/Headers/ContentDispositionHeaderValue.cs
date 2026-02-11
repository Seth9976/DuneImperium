using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Net.Http.Headers
{
	// Token: 0x0200001C RID: 28
	public class ContentDispositionHeaderValue : Object
	{
		// Token: 0x060001CA RID: 458 RVA: 0x0000B268 File Offset: 0x00009468
		// Note: this type is marked as 'beforefieldinit'.
		static ContentDispositionHeaderValue()
		{
			Il2CppClassPointerStore<ContentDispositionHeaderValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http.Headers", "ContentDispositionHeaderValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContentDispositionHeaderValue>.NativeClassPtr);
			ContentDispositionHeaderValue.NativeFieldInfoPtr_dispositionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentDispositionHeaderValue>.NativeClassPtr, "dispositionType");
			ContentDispositionHeaderValue.NativeFieldInfoPtr_parameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentDispositionHeaderValue>.NativeClassPtr, "parameters");
			ContentDispositionHeaderValue.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentDispositionHeaderValue>.NativeClassPtr, 100663552);
			ContentDispositionHeaderValue.NativeMethodInfoPtr__ctor_Protected_Void_ContentDispositionHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentDispositionHeaderValue>.NativeClassPtr, 100663553);
			ContentDispositionHeaderValue.NativeMethodInfoPtr_get_Parameters_Public_get_ICollection_1_NameValueHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentDispositionHeaderValue>.NativeClassPtr, 100663554);
			ContentDispositionHeaderValue.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentDispositionHeaderValue>.NativeClassPtr, 100663555);
			ContentDispositionHeaderValue.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentDispositionHeaderValue>.NativeClassPtr, 100663556);
			ContentDispositionHeaderValue.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentDispositionHeaderValue>.NativeClassPtr, 100663557);
			ContentDispositionHeaderValue.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentDispositionHeaderValue>.NativeClassPtr, 100663558);
			ContentDispositionHeaderValue.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_ContentDispositionHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentDispositionHeaderValue>.NativeClassPtr, 100663559);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000B360 File Offset: 0x00009560
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContentDispositionHeaderValue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContentDispositionHeaderValue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentDispositionHeaderValue.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0000B39C File Offset: 0x0000959C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1173198, RefRangeEnd = 1173199, XrefRangeStart = 1173165, XrefRangeEnd = 1173198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContentDispositionHeaderValue(ContentDispositionHeaderValue source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContentDispositionHeaderValue>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentDispositionHeaderValue.NativeMethodInfoPtr__ctor_Protected_Void_ContentDispositionHeaderValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001CD RID: 461 RVA: 0x0000B3E8 File Offset: 0x000095E8
		public unsafe ICollection<NameValueHeaderValue> Parameters
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173199, XrefRangeEnd = 1173206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentDispositionHeaderValue.NativeMethodInfoPtr_get_Parameters_Public_get_ICollection_1_NameValueHeaderValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<NameValueHeaderValue>>(intPtr3) : null;
			}
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0000B428 File Offset: 0x00009628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173206, XrefRangeEnd = 1173210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object System_ICloneable_Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentDispositionHeaderValue.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000B468 File Offset: 0x00009668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173210, XrefRangeEnd = 1173217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentDispositionHeaderValue.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0000B4C0 File Offset: 0x000096C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173217, XrefRangeEnd = 1173221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentDispositionHeaderValue.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000B508 File Offset: 0x00009708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173221, XrefRangeEnd = 1173225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentDispositionHeaderValue.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0000B54C File Offset: 0x0000974C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173225, XrefRangeEnd = 1173253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string input, out ContentDispositionHeaderValue parsedValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ContentDispositionHeaderValue.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_ContentDispositionHeaderValue_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			parsedValue = ((intPtr4 == 0) ? null : new ContentDispositionHeaderValue(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00002BA4 File Offset: 0x00000DA4
		public ContentDispositionHeaderValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x0000B5B0 File Offset: 0x000097B0
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x00002BAD File Offset: 0x00000DAD
		public unsafe string dispositionType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentDispositionHeaderValue.NativeFieldInfoPtr_dispositionType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentDispositionHeaderValue.NativeFieldInfoPtr_dispositionType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x0000B5D8 File Offset: 0x000097D8
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x00002BCC File Offset: 0x00000DCC
		public unsafe List<NameValueHeaderValue> parameters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentDispositionHeaderValue.NativeFieldInfoPtr_parameters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NameValueHeaderValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentDispositionHeaderValue.NativeFieldInfoPtr_parameters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeFieldInfoPtr_dispositionType;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeFieldInfoPtr_parameters;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_ContentDispositionHeaderValue_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_get_Parameters_Public_get_ICollection_1_NameValueHeaderValue_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_ContentDispositionHeaderValue_0;
	}
}
