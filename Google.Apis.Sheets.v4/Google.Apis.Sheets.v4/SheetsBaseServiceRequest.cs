using System;
using Google.Apis.Requests;
using Google.Apis.Services;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4
{
	// Token: 0x02000003 RID: 3
	public class SheetsBaseServiceRequest<TResponse> : ClientServiceRequest<TResponse>
	{
		// Token: 0x06000012 RID: 18 RVA: 0x0000B44C File Offset: 0x0000964C
		// Note: this type is marked as 'beforefieldinit'.
		static SheetsBaseServiceRequest()
		{
			Il2CppClassPointerStore<SheetsBaseServiceRequest<TResponse>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4", "SheetsBaseServiceRequest`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResponse>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SheetsBaseServiceRequest<TResponse>>.NativeClassPtr);
			SheetsBaseServiceRequest<TResponse>.NativeFieldInfoPtr__Xgafv_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetsBaseServiceRequest<TResponse>>.NativeClassPtr, "<Xgafv>k__BackingField");
			SheetsBaseServiceRequest<TResponse>.NativeFieldInfoPtr__AccessToken_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetsBaseServiceRequest<TResponse>>.NativeClassPtr, "<AccessToken>k__BackingField");
			SheetsBaseServiceRequest<TResponse>.NativeFieldInfoPtr__Alt_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetsBaseServiceRequest<TResponse>>.NativeClassPtr, "<Alt>k__BackingField");
			SheetsBaseServiceRequest<TResponse>.NativeFieldInfoPtr__Callback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetsBaseServiceRequest<TResponse>>.NativeClassPtr, "<Callback>k__BackingField");
			SheetsBaseServiceRequest<TResponse>.NativeFieldInfoPtr__Fields_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetsBaseServiceRequest<TResponse>>.NativeClassPtr, "<Fields>k__BackingField");
			SheetsBaseServiceRequest<TResponse>.NativeFieldInfoPtr__Key_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetsBaseServiceRequest<TResponse>>.NativeClassPtr, "<Key>k__BackingField");
			SheetsBaseServiceRequest<TResponse>.NativeFieldInfoPtr__OauthToken_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetsBaseServiceRequest<TResponse>>.NativeClassPtr, "<OauthToken>k__BackingField");
			SheetsBaseServiceRequest<TResponse>.NativeFieldInfoPtr__PrettyPrint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetsBaseServiceRequest<TResponse>>.NativeClassPtr, "<PrettyPrint>k__BackingField");
			SheetsBaseServiceRequest<TResponse>.NativeFieldInfoPtr__QuotaUser_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetsBaseServiceRequest<TResponse>>.NativeClassPtr, "<QuotaUser>k__BackingField");
			SheetsBaseServiceRequest<TResponse>.NativeFieldInfoPtr__UploadType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetsBaseServiceRequest<TResponse>>.NativeClassPtr, "<UploadType>k__BackingField");
			SheetsBaseServiceRequest<TResponse>.NativeFieldInfoPtr__UploadProtocol_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetsBaseServiceRequest<TResponse>>.NativeClassPtr, "<UploadProtocol>k__BackingField");
			SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr__ctor_Protected_Void_IClientService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetsBaseServiceRequest<TResponse>>.NativeClassPtr, 100663309);
			SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_get_Xgafv_Public_Virtual_New_get_Nullable_1_XgafvEnum_TResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetsBaseServiceRequest<TResponse>>.NativeClassPtr, 100663310);
			SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_set_Xgafv_Public_Virtual_New_set_Void_Nullable_1_XgafvEnum_TResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetsBaseServiceRequest<TResponse>>.NativeClassPtr, 100663311);
			SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_get_AccessToken_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetsBaseServiceRequest<TResponse>>.NativeClassPtr, 100663312);
			SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_set_AccessToken_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetsBaseServiceRequest<TResponse>>.NativeClassPtr, 100663313);
			SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_get_Alt_Public_Virtual_New_get_Nullable_1_AltEnum_TResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetsBaseServiceRequest<TResponse>>.NativeClassPtr, 100663314);
			SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_set_Alt_Public_Virtual_New_set_Void_Nullable_1_AltEnum_TResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetsBaseServiceRequest<TResponse>>.NativeClassPtr, 100663315);
			SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_get_Callback_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetsBaseServiceRequest<TResponse>>.NativeClassPtr, 100663316);
			SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_set_Callback_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetsBaseServiceRequest<TResponse>>.NativeClassPtr, 100663317);
			SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_get_Fields_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetsBaseServiceRequest<TResponse>>.NativeClassPtr, 100663318);
			SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_set_Fields_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetsBaseServiceRequest<TResponse>>.NativeClassPtr, 100663319);
			SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_get_Key_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetsBaseServiceRequest<TResponse>>.NativeClassPtr, 100663320);
			SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_set_Key_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetsBaseServiceRequest<TResponse>>.NativeClassPtr, 100663321);
			SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_get_OauthToken_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetsBaseServiceRequest<TResponse>>.NativeClassPtr, 100663322);
			SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_set_OauthToken_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetsBaseServiceRequest<TResponse>>.NativeClassPtr, 100663323);
			SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_get_PrettyPrint_Public_Virtual_New_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetsBaseServiceRequest<TResponse>>.NativeClassPtr, 100663324);
			SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_set_PrettyPrint_Public_Virtual_New_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetsBaseServiceRequest<TResponse>>.NativeClassPtr, 100663325);
			SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_get_QuotaUser_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetsBaseServiceRequest<TResponse>>.NativeClassPtr, 100663326);
			SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_set_QuotaUser_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetsBaseServiceRequest<TResponse>>.NativeClassPtr, 100663327);
			SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_get_UploadType_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetsBaseServiceRequest<TResponse>>.NativeClassPtr, 100663328);
			SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_set_UploadType_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetsBaseServiceRequest<TResponse>>.NativeClassPtr, 100663329);
			SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_get_UploadProtocol_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetsBaseServiceRequest<TResponse>>.NativeClassPtr, 100663330);
			SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_set_UploadProtocol_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetsBaseServiceRequest<TResponse>>.NativeClassPtr, 100663331);
			SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetsBaseServiceRequest<TResponse>>.NativeClassPtr, 100663332);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000B774 File Offset: 0x00009974
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 1117738, RefRangeEnd = 1117772, XrefRangeStart = 1117735, XrefRangeEnd = 1117738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SheetsBaseServiceRequest(IClientService service)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SheetsBaseServiceRequest<TResponse>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(service);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr__ctor_Protected_Void_IClientService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000014 RID: 20 RVA: 0x0000B7C0 File Offset: 0x000099C0
		// (set) Token: 0x06000015 RID: 21 RVA: 0x0000B804 File Offset: 0x00009A04
		public unsafe virtual Nullable<SheetsBaseServiceRequest<TResponse>.XgafvEnum> Xgafv
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_get_Xgafv_Public_Virtual_New_get_Nullable_1_XgafvEnum_TResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<SheetsBaseServiceRequest<TResponse>.XgafvEnum>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_set_Xgafv_Public_Virtual_New_set_Void_Nullable_1_XgafvEnum_TResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000016 RID: 22 RVA: 0x0000B858 File Offset: 0x00009A58
		// (set) Token: 0x06000017 RID: 23 RVA: 0x0000B89C File Offset: 0x00009A9C
		public unsafe virtual string AccessToken
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_get_AccessToken_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_set_AccessToken_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000018 RID: 24 RVA: 0x0000B8EC File Offset: 0x00009AEC
		// (set) Token: 0x06000019 RID: 25 RVA: 0x0000B930 File Offset: 0x00009B30
		public unsafe virtual Nullable<SheetsBaseServiceRequest<TResponse>.AltEnum> Alt
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_get_Alt_Public_Virtual_New_get_Nullable_1_AltEnum_TResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<SheetsBaseServiceRequest<TResponse>.AltEnum>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_set_Alt_Public_Virtual_New_set_Void_Nullable_1_AltEnum_TResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600001A RID: 26 RVA: 0x0000B984 File Offset: 0x00009B84
		// (set) Token: 0x0600001B RID: 27 RVA: 0x0000B9C8 File Offset: 0x00009BC8
		public unsafe virtual string Callback
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_get_Callback_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_set_Callback_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600001C RID: 28 RVA: 0x0000BA18 File Offset: 0x00009C18
		// (set) Token: 0x0600001D RID: 29 RVA: 0x0000BA5C File Offset: 0x00009C5C
		public unsafe virtual string Fields
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_get_Fields_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_set_Fields_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600001E RID: 30 RVA: 0x0000BAAC File Offset: 0x00009CAC
		// (set) Token: 0x0600001F RID: 31 RVA: 0x0000BAF0 File Offset: 0x00009CF0
		public unsafe virtual string Key
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_get_Key_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_set_Key_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000020 RID: 32 RVA: 0x0000BB40 File Offset: 0x00009D40
		// (set) Token: 0x06000021 RID: 33 RVA: 0x0000BB84 File Offset: 0x00009D84
		public unsafe virtual string OauthToken
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_get_OauthToken_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_set_OauthToken_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000022 RID: 34 RVA: 0x0000BBD4 File Offset: 0x00009DD4
		// (set) Token: 0x06000023 RID: 35 RVA: 0x0000BC18 File Offset: 0x00009E18
		public unsafe virtual Nullable<bool> PrettyPrint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_get_PrettyPrint_Public_Virtual_New_get_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_set_PrettyPrint_Public_Virtual_New_set_Void_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000024 RID: 36 RVA: 0x0000BC6C File Offset: 0x00009E6C
		// (set) Token: 0x06000025 RID: 37 RVA: 0x0000BCB0 File Offset: 0x00009EB0
		public unsafe virtual string QuotaUser
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_get_QuotaUser_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_set_QuotaUser_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000026 RID: 38 RVA: 0x0000BD00 File Offset: 0x00009F00
		// (set) Token: 0x06000027 RID: 39 RVA: 0x0000BD44 File Offset: 0x00009F44
		public unsafe virtual string UploadType
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_get_UploadType_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_set_UploadType_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000028 RID: 40 RVA: 0x0000BD94 File Offset: 0x00009F94
		// (set) Token: 0x06000029 RID: 41 RVA: 0x0000BDD8 File Offset: 0x00009FD8
		public unsafe virtual string UploadProtocol
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_get_UploadProtocol_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_set_UploadProtocol_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000BE28 File Offset: 0x0000A028
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 1117923, RefRangeEnd = 1117940, XrefRangeStart = 1117772, XrefRangeEnd = 1117923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitParameters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SheetsBaseServiceRequest<TResponse>.NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002098 File Offset: 0x00000298
		public SheetsBaseServiceRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600002C RID: 44 RVA: 0x0000BE64 File Offset: 0x0000A064
		// (set) Token: 0x0600002D RID: 45 RVA: 0x000020A1 File Offset: 0x000002A1
		public Nullable<SheetsBaseServiceRequest<TResponse>.XgafvEnum> _Xgafv_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetsBaseServiceRequest<TResponse>.NativeFieldInfoPtr__Xgafv_k__BackingField);
				return new Nullable<SheetsBaseServiceRequest<TResponse>.XgafvEnum>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<SheetsBaseServiceRequest<TResponse>.XgafvEnum>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetsBaseServiceRequest<TResponse>.NativeFieldInfoPtr__Xgafv_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<SheetsBaseServiceRequest<TResponse>.XgafvEnum>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600002E RID: 46 RVA: 0x0000BE94 File Offset: 0x0000A094
		// (set) Token: 0x0600002F RID: 47 RVA: 0x000020CF File Offset: 0x000002CF
		public unsafe string _AccessToken_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetsBaseServiceRequest<TResponse>.NativeFieldInfoPtr__AccessToken_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetsBaseServiceRequest<TResponse>.NativeFieldInfoPtr__AccessToken_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000030 RID: 48 RVA: 0x0000BEBC File Offset: 0x0000A0BC
		// (set) Token: 0x06000031 RID: 49 RVA: 0x000020EE File Offset: 0x000002EE
		public Nullable<SheetsBaseServiceRequest<TResponse>.AltEnum> _Alt_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetsBaseServiceRequest<TResponse>.NativeFieldInfoPtr__Alt_k__BackingField);
				return new Nullable<SheetsBaseServiceRequest<TResponse>.AltEnum>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<SheetsBaseServiceRequest<TResponse>.AltEnum>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetsBaseServiceRequest<TResponse>.NativeFieldInfoPtr__Alt_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<SheetsBaseServiceRequest<TResponse>.AltEnum>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000032 RID: 50 RVA: 0x0000BEEC File Offset: 0x0000A0EC
		// (set) Token: 0x06000033 RID: 51 RVA: 0x0000211C File Offset: 0x0000031C
		public unsafe string _Callback_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetsBaseServiceRequest<TResponse>.NativeFieldInfoPtr__Callback_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetsBaseServiceRequest<TResponse>.NativeFieldInfoPtr__Callback_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000034 RID: 52 RVA: 0x0000BF14 File Offset: 0x0000A114
		// (set) Token: 0x06000035 RID: 53 RVA: 0x0000213B File Offset: 0x0000033B
		public unsafe string _Fields_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetsBaseServiceRequest<TResponse>.NativeFieldInfoPtr__Fields_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetsBaseServiceRequest<TResponse>.NativeFieldInfoPtr__Fields_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000036 RID: 54 RVA: 0x0000BF3C File Offset: 0x0000A13C
		// (set) Token: 0x06000037 RID: 55 RVA: 0x0000215A File Offset: 0x0000035A
		public unsafe string _Key_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetsBaseServiceRequest<TResponse>.NativeFieldInfoPtr__Key_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetsBaseServiceRequest<TResponse>.NativeFieldInfoPtr__Key_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000038 RID: 56 RVA: 0x0000BF64 File Offset: 0x0000A164
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00002179 File Offset: 0x00000379
		public unsafe string _OauthToken_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetsBaseServiceRequest<TResponse>.NativeFieldInfoPtr__OauthToken_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetsBaseServiceRequest<TResponse>.NativeFieldInfoPtr__OauthToken_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003A RID: 58 RVA: 0x0000BF8C File Offset: 0x0000A18C
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00002198 File Offset: 0x00000398
		public Nullable<bool> _PrettyPrint_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetsBaseServiceRequest<TResponse>.NativeFieldInfoPtr__PrettyPrint_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetsBaseServiceRequest<TResponse>.NativeFieldInfoPtr__PrettyPrint_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600003C RID: 60 RVA: 0x0000BFBC File Offset: 0x0000A1BC
		// (set) Token: 0x0600003D RID: 61 RVA: 0x000021C6 File Offset: 0x000003C6
		public unsafe string _QuotaUser_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetsBaseServiceRequest<TResponse>.NativeFieldInfoPtr__QuotaUser_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetsBaseServiceRequest<TResponse>.NativeFieldInfoPtr__QuotaUser_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600003E RID: 62 RVA: 0x0000BFE4 File Offset: 0x0000A1E4
		// (set) Token: 0x0600003F RID: 63 RVA: 0x000021E5 File Offset: 0x000003E5
		public unsafe string _UploadType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetsBaseServiceRequest<TResponse>.NativeFieldInfoPtr__UploadType_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetsBaseServiceRequest<TResponse>.NativeFieldInfoPtr__UploadType_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000040 RID: 64 RVA: 0x0000C00C File Offset: 0x0000A20C
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00002204 File Offset: 0x00000404
		public unsafe string _UploadProtocol_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetsBaseServiceRequest<TResponse>.NativeFieldInfoPtr__UploadProtocol_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetsBaseServiceRequest<TResponse>.NativeFieldInfoPtr__UploadProtocol_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeFieldInfoPtr__Xgafv_k__BackingField;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeFieldInfoPtr__AccessToken_k__BackingField;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeFieldInfoPtr__Alt_k__BackingField;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeFieldInfoPtr__Callback_k__BackingField;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr__Fields_k__BackingField;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr__Key_k__BackingField;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr__OauthToken_k__BackingField;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr__PrettyPrint_k__BackingField;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr__QuotaUser_k__BackingField;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeFieldInfoPtr__UploadType_k__BackingField;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeFieldInfoPtr__UploadProtocol_k__BackingField;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_IClientService_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_get_Xgafv_Public_Virtual_New_get_Nullable_1_XgafvEnum_TResponse_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_set_Xgafv_Public_Virtual_New_set_Void_Nullable_1_XgafvEnum_TResponse_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_get_AccessToken_Public_Virtual_New_get_String_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_set_AccessToken_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_get_Alt_Public_Virtual_New_get_Nullable_1_AltEnum_TResponse_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_set_Alt_Public_Virtual_New_set_Void_Nullable_1_AltEnum_TResponse_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_get_Callback_Public_Virtual_New_get_String_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_set_Callback_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_get_Fields_Public_Virtual_New_get_String_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_set_Fields_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_New_get_String_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_set_Key_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_get_OauthToken_Public_Virtual_New_get_String_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_set_OauthToken_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_get_PrettyPrint_Public_Virtual_New_get_Nullable_1_Boolean_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_set_PrettyPrint_Public_Virtual_New_set_Void_Nullable_1_Boolean_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_get_QuotaUser_Public_Virtual_New_get_String_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_set_QuotaUser_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_get_UploadType_Public_Virtual_New_get_String_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_set_UploadType_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_get_UploadProtocol_Public_Virtual_New_get_String_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_set_UploadProtocol_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_InitParameters_Protected_Virtual_Void_0;

		// Token: 0x020000D2 RID: 210
		public enum XgafvEnum
		{
			// Token: 0x04000C33 RID: 3123
			Value1,
			// Token: 0x04000C34 RID: 3124
			Value2
		}

		// Token: 0x020000D3 RID: 211
		public enum AltEnum
		{
			// Token: 0x04000C36 RID: 3126
			Json,
			// Token: 0x04000C37 RID: 3127
			Media,
			// Token: 0x04000C38 RID: 3128
			Proto
		}
	}
}
