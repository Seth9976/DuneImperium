using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x020000C5 RID: 197
	public class UpdateSheetPropertiesRequest : Object
	{
		// Token: 0x06001096 RID: 4246 RVA: 0x0004AAB0 File Offset: 0x00048CB0
		// Note: this type is marked as 'beforefieldinit'.
		static UpdateSheetPropertiesRequest()
		{
			Il2CppClassPointerStore<UpdateSheetPropertiesRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "UpdateSheetPropertiesRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateSheetPropertiesRequest>.NativeClassPtr);
			UpdateSheetPropertiesRequest.NativeFieldInfoPtr__Fields_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSheetPropertiesRequest>.NativeClassPtr, "<Fields>k__BackingField");
			UpdateSheetPropertiesRequest.NativeFieldInfoPtr__Properties_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSheetPropertiesRequest>.NativeClassPtr, "<Properties>k__BackingField");
			UpdateSheetPropertiesRequest.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSheetPropertiesRequest>.NativeClassPtr, "<ETag>k__BackingField");
			UpdateSheetPropertiesRequest.NativeMethodInfoPtr_get_Fields_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSheetPropertiesRequest>.NativeClassPtr, 100665545);
			UpdateSheetPropertiesRequest.NativeMethodInfoPtr_set_Fields_Public_Virtual_New_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSheetPropertiesRequest>.NativeClassPtr, 100665546);
			UpdateSheetPropertiesRequest.NativeMethodInfoPtr_get_Properties_Public_Virtual_New_get_SheetProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSheetPropertiesRequest>.NativeClassPtr, 100665547);
			UpdateSheetPropertiesRequest.NativeMethodInfoPtr_set_Properties_Public_Virtual_New_set_Void_SheetProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSheetPropertiesRequest>.NativeClassPtr, 100665548);
			UpdateSheetPropertiesRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSheetPropertiesRequest>.NativeClassPtr, 100665549);
			UpdateSheetPropertiesRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSheetPropertiesRequest>.NativeClassPtr, 100665550);
			UpdateSheetPropertiesRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSheetPropertiesRequest>.NativeClassPtr, 100665551);
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06001097 RID: 4247 RVA: 0x0004ABA8 File Offset: 0x00048DA8
		// (set) Token: 0x06001098 RID: 4248 RVA: 0x0004ABF4 File Offset: 0x00048DF4
		public unsafe virtual Object Fields
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateSheetPropertiesRequest.NativeMethodInfoPtr_get_Fields_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateSheetPropertiesRequest.NativeMethodInfoPtr_set_Fields_Public_Virtual_New_set_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06001099 RID: 4249 RVA: 0x0004AC44 File Offset: 0x00048E44
		// (set) Token: 0x0600109A RID: 4250 RVA: 0x0004AC90 File Offset: 0x00048E90
		public unsafe virtual SheetProperties Properties
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateSheetPropertiesRequest.NativeMethodInfoPtr_get_Properties_Public_Virtual_New_get_SheetProperties_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SheetProperties>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateSheetPropertiesRequest.NativeMethodInfoPtr_set_Properties_Public_Virtual_New_set_Void_SheetProperties_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x0600109B RID: 4251 RVA: 0x0004ACE0 File Offset: 0x00048EE0
		// (set) Token: 0x0600109C RID: 4252 RVA: 0x0004AD24 File Offset: 0x00048F24
		public unsafe virtual string ETag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateSheetPropertiesRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateSheetPropertiesRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x0004AD74 File Offset: 0x00048F74
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UpdateSheetPropertiesRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateSheetPropertiesRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateSheetPropertiesRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x00009F5A File Offset: 0x0000815A
		public UpdateSheetPropertiesRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x0600109F RID: 4255 RVA: 0x0004ADB0 File Offset: 0x00048FB0
		// (set) Token: 0x060010A0 RID: 4256 RVA: 0x00009F63 File Offset: 0x00008163
		public unsafe Object _Fields_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateSheetPropertiesRequest.NativeFieldInfoPtr__Fields_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateSheetPropertiesRequest.NativeFieldInfoPtr__Fields_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x060010A1 RID: 4257 RVA: 0x0004ADE0 File Offset: 0x00048FE0
		// (set) Token: 0x060010A2 RID: 4258 RVA: 0x00009F82 File Offset: 0x00008182
		public unsafe SheetProperties _Properties_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateSheetPropertiesRequest.NativeFieldInfoPtr__Properties_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SheetProperties>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateSheetPropertiesRequest.NativeFieldInfoPtr__Properties_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x060010A3 RID: 4259 RVA: 0x0004AE10 File Offset: 0x00049010
		// (set) Token: 0x060010A4 RID: 4260 RVA: 0x00009FA1 File Offset: 0x000081A1
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateSheetPropertiesRequest.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateSheetPropertiesRequest.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000B7D RID: 2941
		private static readonly IntPtr NativeFieldInfoPtr__Fields_k__BackingField;

		// Token: 0x04000B7E RID: 2942
		private static readonly IntPtr NativeFieldInfoPtr__Properties_k__BackingField;

		// Token: 0x04000B7F RID: 2943
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000B80 RID: 2944
		private static readonly IntPtr NativeMethodInfoPtr_get_Fields_Public_Virtual_New_get_Object_0;

		// Token: 0x04000B81 RID: 2945
		private static readonly IntPtr NativeMethodInfoPtr_set_Fields_Public_Virtual_New_set_Void_Object_0;

		// Token: 0x04000B82 RID: 2946
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_Virtual_New_get_SheetProperties_0;

		// Token: 0x04000B83 RID: 2947
		private static readonly IntPtr NativeMethodInfoPtr_set_Properties_Public_Virtual_New_set_Void_SheetProperties_0;

		// Token: 0x04000B84 RID: 2948
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000B85 RID: 2949
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000B86 RID: 2950
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
