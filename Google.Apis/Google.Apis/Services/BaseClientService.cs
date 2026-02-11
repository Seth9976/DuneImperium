using System;
using Google.Apis.Discovery;
using Google.Apis.Http;
using Google.Apis.Logging;
using Google.Apis.Requests;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Net.Http;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Services
{
	// Token: 0x0200000C RID: 12
	public class BaseClientService : Object
	{
		// Token: 0x060000C7 RID: 199 RVA: 0x00007BB4 File Offset: 0x00005DB4
		// Note: this type is marked as 'beforefieldinit'.
		static BaseClientService()
		{
			Il2CppClassPointerStore<BaseClientService>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.dll", "Google.Apis.Services", "BaseClientService");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr);
			BaseClientService.NativeFieldInfoPtr_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, "Logger");
			BaseClientService.NativeFieldInfoPtr_DefaultMaxUrlLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, "DefaultMaxUrlLength");
			BaseClientService.NativeFieldInfoPtr__BaseUriOverride_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, "<BaseUriOverride>k__BackingField");
			BaseClientService.NativeFieldInfoPtr__HttpClient_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, "<HttpClient>k__BackingField");
			BaseClientService.NativeFieldInfoPtr__HttpClientInitializer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, "<HttpClientInitializer>k__BackingField");
			BaseClientService.NativeFieldInfoPtr__GZipEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, "<GZipEnabled>k__BackingField");
			BaseClientService.NativeFieldInfoPtr__ApiKey_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, "<ApiKey>k__BackingField");
			BaseClientService.NativeFieldInfoPtr__ApplicationName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, "<ApplicationName>k__BackingField");
			BaseClientService.NativeFieldInfoPtr__Serializer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, "<Serializer>k__BackingField");
			BaseClientService.NativeMethodInfoPtr__ctor_Protected_Void_Initializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, 100663437);
			BaseClientService.NativeMethodInfoPtr_get_BaseUriOverride_Protected_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, 100663438);
			BaseClientService.NativeMethodInfoPtr_HasFeature_Private_Boolean_Features_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, 100663439);
			BaseClientService.NativeMethodInfoPtr_CreateHttpClient_Private_ConfigurableHttpClient_Initializer_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, 100663440);
			BaseClientService.NativeMethodInfoPtr_CreateBackOffHandler_Protected_Virtual_New_BackOffHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, 100663441);
			BaseClientService.NativeMethodInfoPtr_get_HttpClient_Public_Virtual_Final_New_get_ConfigurableHttpClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, 100663442);
			BaseClientService.NativeMethodInfoPtr_set_HttpClient_Private_set_Void_ConfigurableHttpClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, 100663443);
			BaseClientService.NativeMethodInfoPtr_get_HttpClientInitializer_Public_Virtual_Final_New_get_IConfigurableHttpClientInitializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, 100663444);
			BaseClientService.NativeMethodInfoPtr_set_HttpClientInitializer_Private_set_Void_IConfigurableHttpClientInitializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, 100663445);
			BaseClientService.NativeMethodInfoPtr_get_GZipEnabled_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, 100663446);
			BaseClientService.NativeMethodInfoPtr_set_GZipEnabled_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, 100663447);
			BaseClientService.NativeMethodInfoPtr_get_ApiKey_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, 100663448);
			BaseClientService.NativeMethodInfoPtr_set_ApiKey_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, 100663449);
			BaseClientService.NativeMethodInfoPtr_get_ApplicationName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, 100663450);
			BaseClientService.NativeMethodInfoPtr_set_ApplicationName_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, 100663451);
			BaseClientService.NativeMethodInfoPtr_SetRequestSerailizedContent_Public_Virtual_Final_New_Void_HttpRequestMessage_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, 100663452);
			BaseClientService.NativeMethodInfoPtr_get_Serializer_Public_Virtual_Final_New_get_ISerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, 100663453);
			BaseClientService.NativeMethodInfoPtr_set_Serializer_Private_set_Void_ISerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, 100663454);
			BaseClientService.NativeMethodInfoPtr_SerializeObject_Public_Virtual_New_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, 100663455);
			BaseClientService.NativeMethodInfoPtr_DeserializeResponse_Public_Virtual_New_Task_1_T_HttpResponseMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, 100663456);
			BaseClientService.NativeMethodInfoPtr_DeserializeError_Public_Virtual_New_Task_1_RequestError_HttpResponseMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, 100663457);
			BaseClientService.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, 100663458);
			BaseClientService.NativeMethodInfoPtr_get_BaseUri_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, 100663459);
			BaseClientService.NativeMethodInfoPtr_get_BasePath_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, 100663460);
			BaseClientService.NativeMethodInfoPtr_get_BatchUri_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, 100663461);
			BaseClientService.NativeMethodInfoPtr_get_BatchPath_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, 100663462);
			BaseClientService.NativeMethodInfoPtr_get_Features_Public_Abstract_Virtual_New_get_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, 100663463);
			BaseClientService.NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, 100663464);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00007EC8 File Offset: 0x000060C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1197074, RefRangeEnd = 1197076, XrefRangeStart = 1197011, XrefRangeEnd = 1197074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseClientService(BaseClientService.Initializer initializer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(initializer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.NativeMethodInfoPtr__ctor_Protected_Void_Initializer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00007F14 File Offset: 0x00006114
		public unsafe string BaseUriOverride
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.NativeMethodInfoPtr_get_BaseUriOverride_Protected_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00007F4C File Offset: 0x0000614C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1197083, RefRangeEnd = 1197084, XrefRangeStart = 1197076, XrefRangeEnd = 1197083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasFeature(Features feature)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref feature;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.NativeMethodInfoPtr_HasFeature_Private_Boolean_Features_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00007F98 File Offset: 0x00006198
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1197115, RefRangeEnd = 1197116, XrefRangeStart = 1197084, XrefRangeEnd = 1197115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigurableHttpClient CreateHttpClient(BaseClientService.Initializer initializer, string versionHeader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(initializer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(versionHeader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.NativeMethodInfoPtr_CreateHttpClient_Private_ConfigurableHttpClient_Initializer_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurableHttpClient>(intPtr3) : null;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00007FFC File Offset: 0x000061FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197116, XrefRangeEnd = 1197124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual BackOffHandler CreateBackOffHandler()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseClientService.NativeMethodInfoPtr_CreateBackOffHandler_Protected_Virtual_New_BackOffHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BackOffHandler>(intPtr3) : null;
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00008048 File Offset: 0x00006248
		// (set) Token: 0x060000CE RID: 206 RVA: 0x00008088 File Offset: 0x00006288
		public unsafe virtual ConfigurableHttpClient HttpClient
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.NativeMethodInfoPtr_get_HttpClient_Public_Virtual_Final_New_get_ConfigurableHttpClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurableHttpClient>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.NativeMethodInfoPtr_set_HttpClient_Private_set_Void_ConfigurableHttpClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000CF RID: 207 RVA: 0x000080CC File Offset: 0x000062CC
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x0000810C File Offset: 0x0000630C
		public unsafe virtual IConfigurableHttpClientInitializer HttpClientInitializer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.NativeMethodInfoPtr_get_HttpClientInitializer_Public_Virtual_Final_New_get_IConfigurableHttpClientInitializer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConfigurableHttpClientInitializer>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.NativeMethodInfoPtr_set_HttpClientInitializer_Private_set_Void_IConfigurableHttpClientInitializer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00008150 File Offset: 0x00006350
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x0000818C File Offset: 0x0000638C
		public unsafe virtual bool GZipEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.NativeMethodInfoPtr_get_GZipEnabled_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 287297, RefRangeEnd = 287316, XrefRangeStart = 287297, XrefRangeEnd = 287316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.NativeMethodInfoPtr_set_GZipEnabled_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x000081CC File Offset: 0x000063CC
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x00008204 File Offset: 0x00006404
		public unsafe virtual string ApiKey
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.NativeMethodInfoPtr_get_ApiKey_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.NativeMethodInfoPtr_set_ApiKey_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00008248 File Offset: 0x00006448
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x00008280 File Offset: 0x00006480
		public unsafe virtual string ApplicationName
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.NativeMethodInfoPtr_get_ApplicationName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.NativeMethodInfoPtr_set_ApplicationName_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000082C4 File Offset: 0x000064C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197124, XrefRangeEnd = 1197125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetRequestSerailizedContent(HttpRequestMessage request, Object body)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(body);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.NativeMethodInfoPtr_SetRequestSerailizedContent_Public_Virtual_Final_New_Void_HttpRequestMessage_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00008318 File Offset: 0x00006518
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x00008358 File Offset: 0x00006558
		public unsafe virtual ISerializer Serializer
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.NativeMethodInfoPtr_get_Serializer_Public_Virtual_Final_New_get_ISerializer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISerializer>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.NativeMethodInfoPtr_set_Serializer_Private_set_Void_ISerializer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000839C File Offset: 0x0000659C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197125, XrefRangeEnd = 1197129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string SerializeObject(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseClientService.NativeMethodInfoPtr_SerializeObject_Public_Virtual_New_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000083F0 File Offset: 0x000065F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197129, XrefRangeEnd = 1197138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<T> DeserializeResponse<T>(HttpResponseMessage response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseClientService.MethodInfoStoreGeneric_DeserializeResponse_Public_Virtual_New_Task_1_T_HttpResponseMessage_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<T>>(intPtr3) : null;
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000844C File Offset: 0x0000664C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197138, XrefRangeEnd = 1197153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<RequestError> DeserializeError(HttpResponseMessage response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseClientService.NativeMethodInfoPtr_DeserializeError_Public_Virtual_New_Task_1_RequestError_HttpResponseMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<RequestError>>(intPtr3) : null;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000DD RID: 221 RVA: 0x000084A8 File Offset: 0x000066A8
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseClientService.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000DE RID: 222 RVA: 0x000084EC File Offset: 0x000066EC
		public unsafe virtual string BaseUri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseClientService.NativeMethodInfoPtr_get_BaseUri_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00008530 File Offset: 0x00006730
		public unsafe virtual string BasePath
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseClientService.NativeMethodInfoPtr_get_BasePath_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00008574 File Offset: 0x00006774
		public unsafe virtual string BatchUri
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseClientService.NativeMethodInfoPtr_get_BatchUri_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x000085B8 File Offset: 0x000067B8
		public unsafe virtual string BatchPath
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseClientService.NativeMethodInfoPtr_get_BatchPath_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x000085FC File Offset: 0x000067FC
		public unsafe virtual IList<string> Features
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseClientService.NativeMethodInfoPtr_get_Features_Public_Abstract_Virtual_New_get_IList_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr3) : null;
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00008648 File Offset: 0x00006848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197153, XrefRangeEnd = 1197154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseClientService.NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000024B0 File Offset: 0x000006B0
		public BaseClientService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00008684 File Offset: 0x00006884
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x000024B9 File Offset: 0x000006B9
		public unsafe static ILogger Logger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseClientService.NativeFieldInfoPtr_Logger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseClientService.NativeFieldInfoPtr_Logger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x000086AC File Offset: 0x000068AC
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x000024CB File Offset: 0x000006CB
		public unsafe static uint DefaultMaxUrlLength
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(BaseClientService.NativeFieldInfoPtr_DefaultMaxUrlLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseClientService.NativeFieldInfoPtr_DefaultMaxUrlLength, (void*)(&value));
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x000086C8 File Offset: 0x000068C8
		// (set) Token: 0x060000EA RID: 234 RVA: 0x000024D9 File Offset: 0x000006D9
		public unsafe string _BaseUriOverride_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService.NativeFieldInfoPtr__BaseUriOverride_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService.NativeFieldInfoPtr__BaseUriOverride_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000EB RID: 235 RVA: 0x000086F0 File Offset: 0x000068F0
		// (set) Token: 0x060000EC RID: 236 RVA: 0x000024F8 File Offset: 0x000006F8
		public unsafe ConfigurableHttpClient _HttpClient_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService.NativeFieldInfoPtr__HttpClient_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurableHttpClient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService.NativeFieldInfoPtr__HttpClient_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00008720 File Offset: 0x00006920
		// (set) Token: 0x060000EE RID: 238 RVA: 0x00002517 File Offset: 0x00000717
		public unsafe IConfigurableHttpClientInitializer _HttpClientInitializer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService.NativeFieldInfoPtr__HttpClientInitializer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IConfigurableHttpClientInitializer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService.NativeFieldInfoPtr__HttpClientInitializer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00008750 File Offset: 0x00006950
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x00002536 File Offset: 0x00000736
		public unsafe bool _GZipEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService.NativeFieldInfoPtr__GZipEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService.NativeFieldInfoPtr__GZipEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00008778 File Offset: 0x00006978
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x00002551 File Offset: 0x00000751
		public unsafe string _ApiKey_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService.NativeFieldInfoPtr__ApiKey_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService.NativeFieldInfoPtr__ApiKey_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x000087A0 File Offset: 0x000069A0
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x00002570 File Offset: 0x00000770
		public unsafe string _ApplicationName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService.NativeFieldInfoPtr__ApplicationName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService.NativeFieldInfoPtr__ApplicationName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x000087C8 File Offset: 0x000069C8
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x0000258F File Offset: 0x0000078F
		public unsafe ISerializer _Serializer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService.NativeFieldInfoPtr__Serializer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISerializer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService.NativeFieldInfoPtr__Serializer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeFieldInfoPtr_Logger;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeFieldInfoPtr_DefaultMaxUrlLength;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeFieldInfoPtr__BaseUriOverride_k__BackingField;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeFieldInfoPtr__HttpClient_k__BackingField;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeFieldInfoPtr__HttpClientInitializer_k__BackingField;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeFieldInfoPtr__GZipEnabled_k__BackingField;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeFieldInfoPtr__ApiKey_k__BackingField;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeFieldInfoPtr__ApplicationName_k__BackingField;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeFieldInfoPtr__Serializer_k__BackingField;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Initializer_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseUriOverride_Protected_get_String_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_HasFeature_Private_Boolean_Features_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_CreateHttpClient_Private_ConfigurableHttpClient_Initializer_String_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_CreateBackOffHandler_Protected_Virtual_New_BackOffHandler_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_get_HttpClient_Public_Virtual_Final_New_get_ConfigurableHttpClient_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_set_HttpClient_Private_set_Void_ConfigurableHttpClient_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_get_HttpClientInitializer_Public_Virtual_Final_New_get_IConfigurableHttpClientInitializer_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_set_HttpClientInitializer_Private_set_Void_IConfigurableHttpClientInitializer_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_get_GZipEnabled_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_set_GZipEnabled_Private_set_Void_Boolean_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_get_ApiKey_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_set_ApiKey_Private_set_Void_String_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_get_ApplicationName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_set_ApplicationName_Private_set_Void_String_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_SetRequestSerailizedContent_Public_Virtual_Final_New_Void_HttpRequestMessage_Object_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_get_Serializer_Public_Virtual_Final_New_get_ISerializer_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_set_Serializer_Private_set_Void_ISerializer_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_SerializeObject_Public_Virtual_New_String_Object_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeResponse_Public_Virtual_New_Task_1_T_HttpResponseMessage_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeError_Public_Virtual_New_Task_1_RequestError_HttpResponseMessage_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseUri_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_get_BasePath_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_get_BatchUri_Public_Virtual_New_get_String_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_get_BatchPath_Public_Virtual_New_get_String_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_get_Features_Public_Abstract_Virtual_New_get_IList_1_String_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0;

		// Token: 0x02000030 RID: 48
		public class Initializer : Object
		{
			// Token: 0x06000296 RID: 662 RVA: 0x0000E224 File Offset: 0x0000C424
			// Note: this type is marked as 'beforefieldinit'.
			static Initializer()
			{
				Il2CppClassPointerStore<BaseClientService.Initializer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, "Initializer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseClientService.Initializer>.NativeClassPtr);
				BaseClientService.Initializer.NativeFieldInfoPtr__HttpClientFactory_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseClientService.Initializer>.NativeClassPtr, "<HttpClientFactory>k__BackingField");
				BaseClientService.Initializer.NativeFieldInfoPtr__HttpClientInitializer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseClientService.Initializer>.NativeClassPtr, "<HttpClientInitializer>k__BackingField");
				BaseClientService.Initializer.NativeFieldInfoPtr__DefaultExponentialBackOffPolicy_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseClientService.Initializer>.NativeClassPtr, "<DefaultExponentialBackOffPolicy>k__BackingField");
				BaseClientService.Initializer.NativeFieldInfoPtr__GZipEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseClientService.Initializer>.NativeClassPtr, "<GZipEnabled>k__BackingField");
				BaseClientService.Initializer.NativeFieldInfoPtr__Serializer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseClientService.Initializer>.NativeClassPtr, "<Serializer>k__BackingField");
				BaseClientService.Initializer.NativeFieldInfoPtr__ApiKey_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseClientService.Initializer>.NativeClassPtr, "<ApiKey>k__BackingField");
				BaseClientService.Initializer.NativeFieldInfoPtr__ApplicationName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseClientService.Initializer>.NativeClassPtr, "<ApplicationName>k__BackingField");
				BaseClientService.Initializer.NativeFieldInfoPtr__MaxUrlLength_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseClientService.Initializer>.NativeClassPtr, "<MaxUrlLength>k__BackingField");
				BaseClientService.Initializer.NativeFieldInfoPtr__BaseUri_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseClientService.Initializer>.NativeClassPtr, "<BaseUri>k__BackingField");
				BaseClientService.Initializer.NativeFieldInfoPtr__VersionHeaderBuilder_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseClientService.Initializer>.NativeClassPtr, "<VersionHeaderBuilder>k__BackingField");
				BaseClientService.Initializer.NativeFieldInfoPtr_InvalidApplicationNameCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseClientService.Initializer>.NativeClassPtr, "InvalidApplicationNameCharacters");
				BaseClientService.Initializer.NativeMethodInfoPtr_get_HttpClientFactory_Public_get_IHttpClientFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService.Initializer>.NativeClassPtr, 100663466);
				BaseClientService.Initializer.NativeMethodInfoPtr_set_HttpClientFactory_Public_set_Void_IHttpClientFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService.Initializer>.NativeClassPtr, 100663467);
				BaseClientService.Initializer.NativeMethodInfoPtr_get_HttpClientInitializer_Public_get_IConfigurableHttpClientInitializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService.Initializer>.NativeClassPtr, 100663468);
				BaseClientService.Initializer.NativeMethodInfoPtr_set_HttpClientInitializer_Public_set_Void_IConfigurableHttpClientInitializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService.Initializer>.NativeClassPtr, 100663469);
				BaseClientService.Initializer.NativeMethodInfoPtr_get_DefaultExponentialBackOffPolicy_Public_get_ExponentialBackOffPolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService.Initializer>.NativeClassPtr, 100663470);
				BaseClientService.Initializer.NativeMethodInfoPtr_set_DefaultExponentialBackOffPolicy_Public_set_Void_ExponentialBackOffPolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService.Initializer>.NativeClassPtr, 100663471);
				BaseClientService.Initializer.NativeMethodInfoPtr_get_GZipEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService.Initializer>.NativeClassPtr, 100663472);
				BaseClientService.Initializer.NativeMethodInfoPtr_set_GZipEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService.Initializer>.NativeClassPtr, 100663473);
				BaseClientService.Initializer.NativeMethodInfoPtr_get_Serializer_Public_get_ISerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService.Initializer>.NativeClassPtr, 100663474);
				BaseClientService.Initializer.NativeMethodInfoPtr_set_Serializer_Public_set_Void_ISerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService.Initializer>.NativeClassPtr, 100663475);
				BaseClientService.Initializer.NativeMethodInfoPtr_get_ApiKey_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService.Initializer>.NativeClassPtr, 100663476);
				BaseClientService.Initializer.NativeMethodInfoPtr_set_ApiKey_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService.Initializer>.NativeClassPtr, 100663477);
				BaseClientService.Initializer.NativeMethodInfoPtr_get_ApplicationName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService.Initializer>.NativeClassPtr, 100663478);
				BaseClientService.Initializer.NativeMethodInfoPtr_set_ApplicationName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService.Initializer>.NativeClassPtr, 100663479);
				BaseClientService.Initializer.NativeMethodInfoPtr_get_MaxUrlLength_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService.Initializer>.NativeClassPtr, 100663480);
				BaseClientService.Initializer.NativeMethodInfoPtr_set_MaxUrlLength_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService.Initializer>.NativeClassPtr, 100663481);
				BaseClientService.Initializer.NativeMethodInfoPtr_get_BaseUri_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService.Initializer>.NativeClassPtr, 100663482);
				BaseClientService.Initializer.NativeMethodInfoPtr_set_BaseUri_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService.Initializer>.NativeClassPtr, 100663483);
				BaseClientService.Initializer.NativeMethodInfoPtr_get_VersionHeaderBuilder_Public_get_VersionHeaderBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService.Initializer>.NativeClassPtr, 100663484);
				BaseClientService.Initializer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService.Initializer>.NativeClassPtr, 100663485);
				BaseClientService.Initializer.NativeMethodInfoPtr_Validate_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService.Initializer>.NativeClassPtr, 100663486);
			}

			// Token: 0x170000ED RID: 237
			// (get) Token: 0x06000297 RID: 663 RVA: 0x0000E4D0 File Offset: 0x0000C6D0
			// (set) Token: 0x06000298 RID: 664 RVA: 0x0000E510 File Offset: 0x0000C710
			public unsafe IHttpClientFactory HttpClientFactory
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.Initializer.NativeMethodInfoPtr_get_HttpClientFactory_Public_get_IHttpClientFactory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IHttpClientFactory>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.Initializer.NativeMethodInfoPtr_set_HttpClientFactory_Public_set_Void_IHttpClientFactory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170000EE RID: 238
			// (get) Token: 0x06000299 RID: 665 RVA: 0x0000E554 File Offset: 0x0000C754
			// (set) Token: 0x0600029A RID: 666 RVA: 0x0000E594 File Offset: 0x0000C794
			public unsafe IConfigurableHttpClientInitializer HttpClientInitializer
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.Initializer.NativeMethodInfoPtr_get_HttpClientInitializer_Public_get_IConfigurableHttpClientInitializer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConfigurableHttpClientInitializer>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.Initializer.NativeMethodInfoPtr_set_HttpClientInitializer_Public_set_Void_IConfigurableHttpClientInitializer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170000EF RID: 239
			// (get) Token: 0x0600029B RID: 667 RVA: 0x0000E5D8 File Offset: 0x0000C7D8
			// (set) Token: 0x0600029C RID: 668 RVA: 0x0000E614 File Offset: 0x0000C814
			public unsafe ExponentialBackOffPolicy DefaultExponentialBackOffPolicy
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.Initializer.NativeMethodInfoPtr_get_DefaultExponentialBackOffPolicy_Public_get_ExponentialBackOffPolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 287294, RefRangeEnd = 287297, XrefRangeStart = 287294, XrefRangeEnd = 287297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.Initializer.NativeMethodInfoPtr_set_DefaultExponentialBackOffPolicy_Public_set_Void_ExponentialBackOffPolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170000F0 RID: 240
			// (get) Token: 0x0600029D RID: 669 RVA: 0x0000E654 File Offset: 0x0000C854
			// (set) Token: 0x0600029E RID: 670 RVA: 0x0000E690 File Offset: 0x0000C890
			public unsafe bool GZipEnabled
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.Initializer.NativeMethodInfoPtr_get_GZipEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.Initializer.NativeMethodInfoPtr_set_GZipEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170000F1 RID: 241
			// (get) Token: 0x0600029F RID: 671 RVA: 0x0000E6D0 File Offset: 0x0000C8D0
			// (set) Token: 0x060002A0 RID: 672 RVA: 0x0000E710 File Offset: 0x0000C910
			public unsafe ISerializer Serializer
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.Initializer.NativeMethodInfoPtr_get_Serializer_Public_get_ISerializer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISerializer>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.Initializer.NativeMethodInfoPtr_set_Serializer_Public_set_Void_ISerializer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170000F2 RID: 242
			// (get) Token: 0x060002A1 RID: 673 RVA: 0x0000E754 File Offset: 0x0000C954
			// (set) Token: 0x060002A2 RID: 674 RVA: 0x0000E78C File Offset: 0x0000C98C
			public unsafe string ApiKey
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.Initializer.NativeMethodInfoPtr_get_ApiKey_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.Initializer.NativeMethodInfoPtr_set_ApiKey_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170000F3 RID: 243
			// (get) Token: 0x060002A3 RID: 675 RVA: 0x0000E7D0 File Offset: 0x0000C9D0
			// (set) Token: 0x060002A4 RID: 676 RVA: 0x0000E808 File Offset: 0x0000CA08
			public unsafe string ApplicationName
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.Initializer.NativeMethodInfoPtr_get_ApplicationName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.Initializer.NativeMethodInfoPtr_set_ApplicationName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170000F4 RID: 244
			// (get) Token: 0x060002A5 RID: 677 RVA: 0x0000E84C File Offset: 0x0000CA4C
			// (set) Token: 0x060002A6 RID: 678 RVA: 0x0000E888 File Offset: 0x0000CA88
			public unsafe uint MaxUrlLength
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.Initializer.NativeMethodInfoPtr_get_MaxUrlLength_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.Initializer.NativeMethodInfoPtr_set_MaxUrlLength_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170000F5 RID: 245
			// (get) Token: 0x060002A7 RID: 679 RVA: 0x0000E8C8 File Offset: 0x0000CAC8
			// (set) Token: 0x060002A8 RID: 680 RVA: 0x0000E900 File Offset: 0x0000CB00
			public unsafe string BaseUri
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.Initializer.NativeMethodInfoPtr_get_BaseUri_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.Initializer.NativeMethodInfoPtr_set_BaseUri_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170000F6 RID: 246
			// (get) Token: 0x060002A9 RID: 681 RVA: 0x0000E944 File Offset: 0x0000CB44
			public unsafe VersionHeaderBuilder VersionHeaderBuilder
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.Initializer.NativeMethodInfoPtr_get_VersionHeaderBuilder_Public_get_VersionHeaderBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<VersionHeaderBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x060002AA RID: 682 RVA: 0x0000E984 File Offset: 0x0000CB84
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1196853, RefRangeEnd = 1196855, XrefRangeStart = 1196840, XrefRangeEnd = 1196853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Initializer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseClientService.Initializer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.Initializer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002AB RID: 683 RVA: 0x0000E9C0 File Offset: 0x0000CBC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196855, XrefRangeEnd = 1196873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Validate()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.Initializer.NativeMethodInfoPtr_Validate_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002AC RID: 684 RVA: 0x0000338A File Offset: 0x0000158A
			public Initializer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000E2 RID: 226
			// (get) Token: 0x060002AD RID: 685 RVA: 0x0000E9F4 File Offset: 0x0000CBF4
			// (set) Token: 0x060002AE RID: 686 RVA: 0x00003393 File Offset: 0x00001593
			public unsafe IHttpClientFactory _HttpClientFactory_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService.Initializer.NativeFieldInfoPtr__HttpClientFactory_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IHttpClientFactory>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService.Initializer.NativeFieldInfoPtr__HttpClientFactory_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000E3 RID: 227
			// (get) Token: 0x060002AF RID: 687 RVA: 0x0000EA24 File Offset: 0x0000CC24
			// (set) Token: 0x060002B0 RID: 688 RVA: 0x000033B2 File Offset: 0x000015B2
			public unsafe IConfigurableHttpClientInitializer _HttpClientInitializer_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService.Initializer.NativeFieldInfoPtr__HttpClientInitializer_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IConfigurableHttpClientInitializer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService.Initializer.NativeFieldInfoPtr__HttpClientInitializer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000E4 RID: 228
			// (get) Token: 0x060002B1 RID: 689 RVA: 0x0000EA54 File Offset: 0x0000CC54
			// (set) Token: 0x060002B2 RID: 690 RVA: 0x000033D1 File Offset: 0x000015D1
			public unsafe ExponentialBackOffPolicy _DefaultExponentialBackOffPolicy_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService.Initializer.NativeFieldInfoPtr__DefaultExponentialBackOffPolicy_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService.Initializer.NativeFieldInfoPtr__DefaultExponentialBackOffPolicy_k__BackingField)) = value;
				}
			}

			// Token: 0x170000E5 RID: 229
			// (get) Token: 0x060002B3 RID: 691 RVA: 0x0000EA7C File Offset: 0x0000CC7C
			// (set) Token: 0x060002B4 RID: 692 RVA: 0x000033EC File Offset: 0x000015EC
			public unsafe bool _GZipEnabled_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService.Initializer.NativeFieldInfoPtr__GZipEnabled_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService.Initializer.NativeFieldInfoPtr__GZipEnabled_k__BackingField)) = value;
				}
			}

			// Token: 0x170000E6 RID: 230
			// (get) Token: 0x060002B5 RID: 693 RVA: 0x0000EAA4 File Offset: 0x0000CCA4
			// (set) Token: 0x060002B6 RID: 694 RVA: 0x00003407 File Offset: 0x00001607
			public unsafe ISerializer _Serializer_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService.Initializer.NativeFieldInfoPtr__Serializer_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISerializer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService.Initializer.NativeFieldInfoPtr__Serializer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000E7 RID: 231
			// (get) Token: 0x060002B7 RID: 695 RVA: 0x0000EAD4 File Offset: 0x0000CCD4
			// (set) Token: 0x060002B8 RID: 696 RVA: 0x00003426 File Offset: 0x00001626
			public unsafe string _ApiKey_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService.Initializer.NativeFieldInfoPtr__ApiKey_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService.Initializer.NativeFieldInfoPtr__ApiKey_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170000E8 RID: 232
			// (get) Token: 0x060002B9 RID: 697 RVA: 0x0000EAFC File Offset: 0x0000CCFC
			// (set) Token: 0x060002BA RID: 698 RVA: 0x00003445 File Offset: 0x00001645
			public unsafe string _ApplicationName_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService.Initializer.NativeFieldInfoPtr__ApplicationName_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService.Initializer.NativeFieldInfoPtr__ApplicationName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170000E9 RID: 233
			// (get) Token: 0x060002BB RID: 699 RVA: 0x0000EB24 File Offset: 0x0000CD24
			// (set) Token: 0x060002BC RID: 700 RVA: 0x00003464 File Offset: 0x00001664
			public unsafe uint _MaxUrlLength_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService.Initializer.NativeFieldInfoPtr__MaxUrlLength_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService.Initializer.NativeFieldInfoPtr__MaxUrlLength_k__BackingField)) = value;
				}
			}

			// Token: 0x170000EA RID: 234
			// (get) Token: 0x060002BD RID: 701 RVA: 0x0000EB4C File Offset: 0x0000CD4C
			// (set) Token: 0x060002BE RID: 702 RVA: 0x0000347F File Offset: 0x0000167F
			public unsafe string _BaseUri_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService.Initializer.NativeFieldInfoPtr__BaseUri_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService.Initializer.NativeFieldInfoPtr__BaseUri_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170000EB RID: 235
			// (get) Token: 0x060002BF RID: 703 RVA: 0x0000EB74 File Offset: 0x0000CD74
			// (set) Token: 0x060002C0 RID: 704 RVA: 0x0000349E File Offset: 0x0000169E
			public unsafe VersionHeaderBuilder _VersionHeaderBuilder_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService.Initializer.NativeFieldInfoPtr__VersionHeaderBuilder_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VersionHeaderBuilder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService.Initializer.NativeFieldInfoPtr__VersionHeaderBuilder_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000EC RID: 236
			// (get) Token: 0x060002C1 RID: 705 RVA: 0x0000EBA4 File Offset: 0x0000CDA4
			// (set) Token: 0x060002C2 RID: 706 RVA: 0x000034BD File Offset: 0x000016BD
			public unsafe static string InvalidApplicationNameCharacters
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BaseClientService.Initializer.NativeFieldInfoPtr_InvalidApplicationNameCharacters, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BaseClientService.Initializer.NativeFieldInfoPtr_InvalidApplicationNameCharacters, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040001C4 RID: 452
			private static readonly IntPtr NativeFieldInfoPtr__HttpClientFactory_k__BackingField;

			// Token: 0x040001C5 RID: 453
			private static readonly IntPtr NativeFieldInfoPtr__HttpClientInitializer_k__BackingField;

			// Token: 0x040001C6 RID: 454
			private static readonly IntPtr NativeFieldInfoPtr__DefaultExponentialBackOffPolicy_k__BackingField;

			// Token: 0x040001C7 RID: 455
			private static readonly IntPtr NativeFieldInfoPtr__GZipEnabled_k__BackingField;

			// Token: 0x040001C8 RID: 456
			private static readonly IntPtr NativeFieldInfoPtr__Serializer_k__BackingField;

			// Token: 0x040001C9 RID: 457
			private static readonly IntPtr NativeFieldInfoPtr__ApiKey_k__BackingField;

			// Token: 0x040001CA RID: 458
			private static readonly IntPtr NativeFieldInfoPtr__ApplicationName_k__BackingField;

			// Token: 0x040001CB RID: 459
			private static readonly IntPtr NativeFieldInfoPtr__MaxUrlLength_k__BackingField;

			// Token: 0x040001CC RID: 460
			private static readonly IntPtr NativeFieldInfoPtr__BaseUri_k__BackingField;

			// Token: 0x040001CD RID: 461
			private static readonly IntPtr NativeFieldInfoPtr__VersionHeaderBuilder_k__BackingField;

			// Token: 0x040001CE RID: 462
			private static readonly IntPtr NativeFieldInfoPtr_InvalidApplicationNameCharacters;

			// Token: 0x040001CF RID: 463
			private static readonly IntPtr NativeMethodInfoPtr_get_HttpClientFactory_Public_get_IHttpClientFactory_0;

			// Token: 0x040001D0 RID: 464
			private static readonly IntPtr NativeMethodInfoPtr_set_HttpClientFactory_Public_set_Void_IHttpClientFactory_0;

			// Token: 0x040001D1 RID: 465
			private static readonly IntPtr NativeMethodInfoPtr_get_HttpClientInitializer_Public_get_IConfigurableHttpClientInitializer_0;

			// Token: 0x040001D2 RID: 466
			private static readonly IntPtr NativeMethodInfoPtr_set_HttpClientInitializer_Public_set_Void_IConfigurableHttpClientInitializer_0;

			// Token: 0x040001D3 RID: 467
			private static readonly IntPtr NativeMethodInfoPtr_get_DefaultExponentialBackOffPolicy_Public_get_ExponentialBackOffPolicy_0;

			// Token: 0x040001D4 RID: 468
			private static readonly IntPtr NativeMethodInfoPtr_set_DefaultExponentialBackOffPolicy_Public_set_Void_ExponentialBackOffPolicy_0;

			// Token: 0x040001D5 RID: 469
			private static readonly IntPtr NativeMethodInfoPtr_get_GZipEnabled_Public_get_Boolean_0;

			// Token: 0x040001D6 RID: 470
			private static readonly IntPtr NativeMethodInfoPtr_set_GZipEnabled_Public_set_Void_Boolean_0;

			// Token: 0x040001D7 RID: 471
			private static readonly IntPtr NativeMethodInfoPtr_get_Serializer_Public_get_ISerializer_0;

			// Token: 0x040001D8 RID: 472
			private static readonly IntPtr NativeMethodInfoPtr_set_Serializer_Public_set_Void_ISerializer_0;

			// Token: 0x040001D9 RID: 473
			private static readonly IntPtr NativeMethodInfoPtr_get_ApiKey_Public_get_String_0;

			// Token: 0x040001DA RID: 474
			private static readonly IntPtr NativeMethodInfoPtr_set_ApiKey_Public_set_Void_String_0;

			// Token: 0x040001DB RID: 475
			private static readonly IntPtr NativeMethodInfoPtr_get_ApplicationName_Public_get_String_0;

			// Token: 0x040001DC RID: 476
			private static readonly IntPtr NativeMethodInfoPtr_set_ApplicationName_Public_set_Void_String_0;

			// Token: 0x040001DD RID: 477
			private static readonly IntPtr NativeMethodInfoPtr_get_MaxUrlLength_Public_get_UInt32_0;

			// Token: 0x040001DE RID: 478
			private static readonly IntPtr NativeMethodInfoPtr_set_MaxUrlLength_Public_set_Void_UInt32_0;

			// Token: 0x040001DF RID: 479
			private static readonly IntPtr NativeMethodInfoPtr_get_BaseUri_Public_get_String_0;

			// Token: 0x040001E0 RID: 480
			private static readonly IntPtr NativeMethodInfoPtr_set_BaseUri_Public_set_Void_String_0;

			// Token: 0x040001E1 RID: 481
			private static readonly IntPtr NativeMethodInfoPtr_get_VersionHeaderBuilder_Public_get_VersionHeaderBuilder_0;

			// Token: 0x040001E2 RID: 482
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001E3 RID: 483
			private static readonly IntPtr NativeMethodInfoPtr_Validate_Internal_Void_0;

			// Token: 0x0200004D RID: 77
			[ObfuscatedName("Google.Apis.Services.BaseClientService+Initializer+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x0600046A RID: 1130 RVA: 0x000135C8 File Offset: 0x000117C8
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<BaseClientService.Initializer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BaseClientService.Initializer>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseClientService.Initializer.__c>.NativeClassPtr);
					BaseClientService.Initializer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseClientService.Initializer.__c>.NativeClassPtr, "<>9");
					BaseClientService.Initializer.__c.NativeFieldInfoPtr___9__41_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseClientService.Initializer.__c>.NativeClassPtr, "<>9__41_0");
					BaseClientService.Initializer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService.Initializer.__c>.NativeClassPtr, 100663488);
					BaseClientService.Initializer.__c.NativeMethodInfoPtr__Validate_b__41_0_Internal_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService.Initializer.__c>.NativeClassPtr, 100663489);
				}

				// Token: 0x0600046B RID: 1131 RVA: 0x00013644 File Offset: 0x00011844
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseClientService.Initializer.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.Initializer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600046C RID: 1132 RVA: 0x00013680 File Offset: 0x00011880
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196807, XrefRangeEnd = 1196840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _Validate_b__41_0(char c)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref c;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService.Initializer.__c.NativeMethodInfoPtr__Validate_b__41_0_Internal_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x0600046D RID: 1133 RVA: 0x0000492B File Offset: 0x00002B2B
				public __c(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x1700018A RID: 394
				// (get) Token: 0x0600046E RID: 1134 RVA: 0x000136CC File Offset: 0x000118CC
				// (set) Token: 0x0600046F RID: 1135 RVA: 0x00004934 File Offset: 0x00002B34
				public unsafe static BaseClientService.Initializer.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(BaseClientService.Initializer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseClientService.Initializer.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(BaseClientService.Initializer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700018B RID: 395
				// (get) Token: 0x06000470 RID: 1136 RVA: 0x000136F4 File Offset: 0x000118F4
				// (set) Token: 0x06000471 RID: 1137 RVA: 0x00004946 File Offset: 0x00002B46
				public unsafe static Func<char, bool> __9__41_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(BaseClientService.Initializer.__c.NativeFieldInfoPtr___9__41_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<char, bool>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(BaseClientService.Initializer.__c.NativeFieldInfoPtr___9__41_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040002BD RID: 701
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x040002BE RID: 702
				private static readonly IntPtr NativeFieldInfoPtr___9__41_0;

				// Token: 0x040002BF RID: 703
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x040002C0 RID: 704
				private static readonly IntPtr NativeMethodInfoPtr__Validate_b__41_0_Internal_Boolean_Char_0;
			}
		}

		// Token: 0x02000031 RID: 49
		[ObfuscatedName("Google.Apis.Services.BaseClientService+<DeserializeResponse>d__36`1")]
		public sealed class _DeserializeResponse_d__36<T> : ValueType
		{
			// Token: 0x060002C3 RID: 707 RVA: 0x0000EBC4 File Offset: 0x0000CDC4
			// Note: this type is marked as 'beforefieldinit'.
			static _DeserializeResponse_d__36()
			{
				Il2CppClassPointerStore<BaseClientService._DeserializeResponse_d__36<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, "<DeserializeResponse>d__36`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseClientService._DeserializeResponse_d__36<T>>.NativeClassPtr);
				BaseClientService._DeserializeResponse_d__36<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseClientService._DeserializeResponse_d__36<T>>.NativeClassPtr, "<>1__state");
				BaseClientService._DeserializeResponse_d__36<T>.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseClientService._DeserializeResponse_d__36<T>>.NativeClassPtr, "<>t__builder");
				BaseClientService._DeserializeResponse_d__36<T>.NativeFieldInfoPtr_response = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseClientService._DeserializeResponse_d__36<T>>.NativeClassPtr, "response");
				BaseClientService._DeserializeResponse_d__36<T>.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseClientService._DeserializeResponse_d__36<T>>.NativeClassPtr, "<>4__this");
				BaseClientService._DeserializeResponse_d__36<T>.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseClientService._DeserializeResponse_d__36<T>>.NativeClassPtr, "<>u__1");
				BaseClientService._DeserializeResponse_d__36<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService._DeserializeResponse_d__36<T>>.NativeClassPtr, 100663490);
				BaseClientService._DeserializeResponse_d__36<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService._DeserializeResponse_d__36<T>>.NativeClassPtr, 100663491);
			}

			// Token: 0x060002C4 RID: 708 RVA: 0x0000ECB8 File Offset: 0x0000CEB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196873, XrefRangeEnd = 1196930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService._DeserializeResponse_d__36<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002C5 RID: 709 RVA: 0x0000ECF0 File Offset: 0x0000CEF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196930, XrefRangeEnd = 1196982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService._DeserializeResponse_d__36<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060002C6 RID: 710 RVA: 0x000034CF File Offset: 0x000016CF
			public _DeserializeResponse_d__36(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060002C7 RID: 711 RVA: 0x000034D8 File Offset: 0x000016D8
			public _DeserializeResponse_d__36()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseClientService._DeserializeResponse_d__36<T>>.NativeClassPtr))
			{
			}

			// Token: 0x170000F7 RID: 247
			// (get) Token: 0x060002C8 RID: 712 RVA: 0x0000ED38 File Offset: 0x0000CF38
			// (set) Token: 0x060002C9 RID: 713 RVA: 0x000034EA File Offset: 0x000016EA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService._DeserializeResponse_d__36<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService._DeserializeResponse_d__36<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000F8 RID: 248
			// (get) Token: 0x060002CA RID: 714 RVA: 0x0000ED60 File Offset: 0x0000CF60
			// (set) Token: 0x060002CB RID: 715 RVA: 0x00003505 File Offset: 0x00001705
			public AsyncTaskMethodBuilder<T> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService._DeserializeResponse_d__36<T>.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService._DeserializeResponse_d__36<T>.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000F9 RID: 249
			// (get) Token: 0x060002CC RID: 716 RVA: 0x0000ED90 File Offset: 0x0000CF90
			// (set) Token: 0x060002CD RID: 717 RVA: 0x00003533 File Offset: 0x00001733
			public unsafe HttpResponseMessage response
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService._DeserializeResponse_d__36<T>.NativeFieldInfoPtr_response);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpResponseMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService._DeserializeResponse_d__36<T>.NativeFieldInfoPtr_response), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000FA RID: 250
			// (get) Token: 0x060002CE RID: 718 RVA: 0x0000EDC0 File Offset: 0x0000CFC0
			// (set) Token: 0x060002CF RID: 719 RVA: 0x00003552 File Offset: 0x00001752
			public unsafe BaseClientService __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService._DeserializeResponse_d__36<T>.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseClientService>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService._DeserializeResponse_d__36<T>.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000FB RID: 251
			// (get) Token: 0x060002D0 RID: 720 RVA: 0x0000EDF0 File Offset: 0x0000CFF0
			// (set) Token: 0x060002D1 RID: 721 RVA: 0x00003571 File Offset: 0x00001771
			public ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService._DeserializeResponse_d__36<T>.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService._DeserializeResponse_d__36<T>.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040001E4 RID: 484
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040001E5 RID: 485
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040001E6 RID: 486
			private static readonly IntPtr NativeFieldInfoPtr_response;

			// Token: 0x040001E7 RID: 487
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040001E8 RID: 488
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040001E9 RID: 489
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001EA RID: 490
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000032 RID: 50
		[ObfuscatedName("Google.Apis.Services.BaseClientService+<DeserializeError>d__37")]
		public sealed class _DeserializeError_d__37 : ValueType
		{
			// Token: 0x060002D2 RID: 722 RVA: 0x0000EE20 File Offset: 0x0000D020
			// Note: this type is marked as 'beforefieldinit'.
			static _DeserializeError_d__37()
			{
				Il2CppClassPointerStore<BaseClientService._DeserializeError_d__37>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BaseClientService>.NativeClassPtr, "<DeserializeError>d__37");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseClientService._DeserializeError_d__37>.NativeClassPtr);
				BaseClientService._DeserializeError_d__37.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseClientService._DeserializeError_d__37>.NativeClassPtr, "<>1__state");
				BaseClientService._DeserializeError_d__37.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseClientService._DeserializeError_d__37>.NativeClassPtr, "<>t__builder");
				BaseClientService._DeserializeError_d__37.NativeFieldInfoPtr_response = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseClientService._DeserializeError_d__37>.NativeClassPtr, "response");
				BaseClientService._DeserializeError_d__37.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseClientService._DeserializeError_d__37>.NativeClassPtr, "<>4__this");
				BaseClientService._DeserializeError_d__37.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseClientService._DeserializeError_d__37>.NativeClassPtr, "<>u__1");
				BaseClientService._DeserializeError_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService._DeserializeError_d__37>.NativeClassPtr, 100663492);
				BaseClientService._DeserializeError_d__37.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseClientService._DeserializeError_d__37>.NativeClassPtr, 100663493);
			}

			// Token: 0x060002D3 RID: 723 RVA: 0x0000EED8 File Offset: 0x0000D0D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196982, XrefRangeEnd = 1197005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService._DeserializeError_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002D4 RID: 724 RVA: 0x0000EF10 File Offset: 0x0000D110
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197005, XrefRangeEnd = 1197011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseClientService._DeserializeError_d__37.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060002D5 RID: 725 RVA: 0x0000359F File Offset: 0x0000179F
			public _DeserializeError_d__37(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060002D6 RID: 726 RVA: 0x000035A8 File Offset: 0x000017A8
			public _DeserializeError_d__37()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseClientService._DeserializeError_d__37>.NativeClassPtr))
			{
			}

			// Token: 0x170000FC RID: 252
			// (get) Token: 0x060002D7 RID: 727 RVA: 0x0000EF58 File Offset: 0x0000D158
			// (set) Token: 0x060002D8 RID: 728 RVA: 0x000035BA File Offset: 0x000017BA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService._DeserializeError_d__37.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService._DeserializeError_d__37.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000FD RID: 253
			// (get) Token: 0x060002D9 RID: 729 RVA: 0x0000EF80 File Offset: 0x0000D180
			// (set) Token: 0x060002DA RID: 730 RVA: 0x000035D5 File Offset: 0x000017D5
			public AsyncTaskMethodBuilder<RequestError> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService._DeserializeError_d__37.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<RequestError>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<RequestError>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService._DeserializeError_d__37.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<RequestError>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000FE RID: 254
			// (get) Token: 0x060002DB RID: 731 RVA: 0x0000EFB0 File Offset: 0x0000D1B0
			// (set) Token: 0x060002DC RID: 732 RVA: 0x00003603 File Offset: 0x00001803
			public unsafe HttpResponseMessage response
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService._DeserializeError_d__37.NativeFieldInfoPtr_response);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpResponseMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService._DeserializeError_d__37.NativeFieldInfoPtr_response), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000FF RID: 255
			// (get) Token: 0x060002DD RID: 733 RVA: 0x0000EFE0 File Offset: 0x0000D1E0
			// (set) Token: 0x060002DE RID: 734 RVA: 0x00003622 File Offset: 0x00001822
			public unsafe BaseClientService __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService._DeserializeError_d__37.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseClientService>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService._DeserializeError_d__37.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000100 RID: 256
			// (get) Token: 0x060002DF RID: 735 RVA: 0x0000F010 File Offset: 0x0000D210
			// (set) Token: 0x060002E0 RID: 736 RVA: 0x00003641 File Offset: 0x00001841
			public ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService._DeserializeError_d__37.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseClientService._DeserializeError_d__37.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040001EB RID: 491
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040001EC RID: 492
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040001ED RID: 493
			private static readonly IntPtr NativeFieldInfoPtr_response;

			// Token: 0x040001EE RID: 494
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040001EF RID: 495
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040001F0 RID: 496
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001F1 RID: 497
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000033 RID: 51
		private sealed class MethodInfoStoreGeneric_DeserializeResponse_Public_Virtual_New_Task_1_T_HttpResponseMessage_0<T>
		{
			// Token: 0x040001F2 RID: 498
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BaseClientService.NativeMethodInfoPtr_DeserializeResponse_Public_Virtual_New_Task_1_T_HttpResponseMessage_0, Il2CppClassPointerStore<BaseClientService>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
