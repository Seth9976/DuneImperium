using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x02000016 RID: 22
	public class ISteamHTTP : SteamInterface
	{
		// Token: 0x060002B9 RID: 697 RVA: 0x0001E684 File Offset: 0x0001C884
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamHTTP()
		{
			Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "ISteamHTTP");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr);
			ISteamHTTP.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663952);
			ISteamHTTP.NativeMethodInfoPtr_SteamAPI_SteamHTTP_v003_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663953);
			ISteamHTTP.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663954);
			ISteamHTTP.NativeMethodInfoPtr_SteamAPI_SteamGameServerHTTP_v003_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663955);
			ISteamHTTP.NativeMethodInfoPtr_GetServerInterfacePointer_Public_Virtual_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663956);
			ISteamHTTP.NativeMethodInfoPtr__CreateHTTPRequest_Private_Static_HTTPRequestHandle_IntPtr_HTTPMethod_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663957);
			ISteamHTTP.NativeMethodInfoPtr_CreateHTTPRequest_Internal_HTTPRequestHandle_HTTPMethod_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663958);
			ISteamHTTP.NativeMethodInfoPtr__SetHTTPRequestContextValue_Private_Static_Boolean_IntPtr_HTTPRequestHandle_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663959);
			ISteamHTTP.NativeMethodInfoPtr_SetHTTPRequestContextValue_Internal_Boolean_HTTPRequestHandle_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663960);
			ISteamHTTP.NativeMethodInfoPtr__SetHTTPRequestNetworkActivityTimeout_Private_Static_Boolean_IntPtr_HTTPRequestHandle_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663961);
			ISteamHTTP.NativeMethodInfoPtr_SetHTTPRequestNetworkActivityTimeout_Internal_Boolean_HTTPRequestHandle_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663962);
			ISteamHTTP.NativeMethodInfoPtr__SetHTTPRequestHeaderValue_Private_Static_Boolean_IntPtr_HTTPRequestHandle_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663963);
			ISteamHTTP.NativeMethodInfoPtr_SetHTTPRequestHeaderValue_Internal_Boolean_HTTPRequestHandle_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663964);
			ISteamHTTP.NativeMethodInfoPtr__SetHTTPRequestGetOrPostParameter_Private_Static_Boolean_IntPtr_HTTPRequestHandle_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663965);
			ISteamHTTP.NativeMethodInfoPtr_SetHTTPRequestGetOrPostParameter_Internal_Boolean_HTTPRequestHandle_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663966);
			ISteamHTTP.NativeMethodInfoPtr__SendHTTPRequest_Private_Static_Boolean_IntPtr_HTTPRequestHandle_byref_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663967);
			ISteamHTTP.NativeMethodInfoPtr_SendHTTPRequest_Internal_Boolean_HTTPRequestHandle_byref_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663968);
			ISteamHTTP.NativeMethodInfoPtr__SendHTTPRequestAndStreamResponse_Private_Static_Boolean_IntPtr_HTTPRequestHandle_byref_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663969);
			ISteamHTTP.NativeMethodInfoPtr_SendHTTPRequestAndStreamResponse_Internal_Boolean_HTTPRequestHandle_byref_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663970);
			ISteamHTTP.NativeMethodInfoPtr__DeferHTTPRequest_Private_Static_Boolean_IntPtr_HTTPRequestHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663971);
			ISteamHTTP.NativeMethodInfoPtr_DeferHTTPRequest_Internal_Boolean_HTTPRequestHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663972);
			ISteamHTTP.NativeMethodInfoPtr__PrioritizeHTTPRequest_Private_Static_Boolean_IntPtr_HTTPRequestHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663973);
			ISteamHTTP.NativeMethodInfoPtr_PrioritizeHTTPRequest_Internal_Boolean_HTTPRequestHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663974);
			ISteamHTTP.NativeMethodInfoPtr__GetHTTPResponseHeaderSize_Private_Static_Boolean_IntPtr_HTTPRequestHandle_String_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663975);
			ISteamHTTP.NativeMethodInfoPtr_GetHTTPResponseHeaderSize_Internal_Boolean_HTTPRequestHandle_String_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663976);
			ISteamHTTP.NativeMethodInfoPtr__GetHTTPResponseHeaderValue_Private_Static_Boolean_IntPtr_HTTPRequestHandle_String_byref_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663977);
			ISteamHTTP.NativeMethodInfoPtr_GetHTTPResponseHeaderValue_Internal_Boolean_HTTPRequestHandle_String_byref_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663978);
			ISteamHTTP.NativeMethodInfoPtr__GetHTTPResponseBodySize_Private_Static_Boolean_IntPtr_HTTPRequestHandle_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663979);
			ISteamHTTP.NativeMethodInfoPtr_GetHTTPResponseBodySize_Internal_Boolean_HTTPRequestHandle_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663980);
			ISteamHTTP.NativeMethodInfoPtr__GetHTTPResponseBodyData_Private_Static_Boolean_IntPtr_HTTPRequestHandle_byref_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663981);
			ISteamHTTP.NativeMethodInfoPtr_GetHTTPResponseBodyData_Internal_Boolean_HTTPRequestHandle_byref_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663982);
			ISteamHTTP.NativeMethodInfoPtr__GetHTTPStreamingResponseBodyData_Private_Static_Boolean_IntPtr_HTTPRequestHandle_UInt32_byref_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663983);
			ISteamHTTP.NativeMethodInfoPtr_GetHTTPStreamingResponseBodyData_Internal_Boolean_HTTPRequestHandle_UInt32_byref_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663984);
			ISteamHTTP.NativeMethodInfoPtr__ReleaseHTTPRequest_Private_Static_Boolean_IntPtr_HTTPRequestHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663985);
			ISteamHTTP.NativeMethodInfoPtr_ReleaseHTTPRequest_Internal_Boolean_HTTPRequestHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663986);
			ISteamHTTP.NativeMethodInfoPtr__GetHTTPDownloadProgressPct_Private_Static_Boolean_IntPtr_HTTPRequestHandle_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663987);
			ISteamHTTP.NativeMethodInfoPtr_GetHTTPDownloadProgressPct_Internal_Boolean_HTTPRequestHandle_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663988);
			ISteamHTTP.NativeMethodInfoPtr__SetHTTPRequestRawPostBody_Private_Static_Boolean_IntPtr_HTTPRequestHandle_String_Il2CppStructArray_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663989);
			ISteamHTTP.NativeMethodInfoPtr_SetHTTPRequestRawPostBody_Internal_Boolean_HTTPRequestHandle_String_Il2CppStructArray_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663990);
			ISteamHTTP.NativeMethodInfoPtr__CreateCookieContainer_Private_Static_HTTPCookieContainerHandle_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663991);
			ISteamHTTP.NativeMethodInfoPtr_CreateCookieContainer_Internal_HTTPCookieContainerHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663992);
			ISteamHTTP.NativeMethodInfoPtr__ReleaseCookieContainer_Private_Static_Boolean_IntPtr_HTTPCookieContainerHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663993);
			ISteamHTTP.NativeMethodInfoPtr_ReleaseCookieContainer_Internal_Boolean_HTTPCookieContainerHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663994);
			ISteamHTTP.NativeMethodInfoPtr__SetCookie_Private_Static_Boolean_IntPtr_HTTPCookieContainerHandle_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663995);
			ISteamHTTP.NativeMethodInfoPtr_SetCookie_Internal_Boolean_HTTPCookieContainerHandle_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663996);
			ISteamHTTP.NativeMethodInfoPtr__SetHTTPRequestCookieContainer_Private_Static_Boolean_IntPtr_HTTPRequestHandle_HTTPCookieContainerHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663997);
			ISteamHTTP.NativeMethodInfoPtr_SetHTTPRequestCookieContainer_Internal_Boolean_HTTPRequestHandle_HTTPCookieContainerHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663998);
			ISteamHTTP.NativeMethodInfoPtr__SetHTTPRequestUserAgentInfo_Private_Static_Boolean_IntPtr_HTTPRequestHandle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100663999);
			ISteamHTTP.NativeMethodInfoPtr_SetHTTPRequestUserAgentInfo_Internal_Boolean_HTTPRequestHandle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100664000);
			ISteamHTTP.NativeMethodInfoPtr__SetHTTPRequestRequiresVerifiedCertificate_Private_Static_Boolean_IntPtr_HTTPRequestHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100664001);
			ISteamHTTP.NativeMethodInfoPtr_SetHTTPRequestRequiresVerifiedCertificate_Internal_Boolean_HTTPRequestHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100664002);
			ISteamHTTP.NativeMethodInfoPtr__SetHTTPRequestAbsoluteTimeoutMS_Private_Static_Boolean_IntPtr_HTTPRequestHandle_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100664003);
			ISteamHTTP.NativeMethodInfoPtr_SetHTTPRequestAbsoluteTimeoutMS_Internal_Boolean_HTTPRequestHandle_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100664004);
			ISteamHTTP.NativeMethodInfoPtr__GetHTTPRequestWasTimedOut_Private_Static_Boolean_IntPtr_HTTPRequestHandle_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100664005);
			ISteamHTTP.NativeMethodInfoPtr_GetHTTPRequestWasTimedOut_Internal_Boolean_HTTPRequestHandle_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr, 100664006);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0001EB00 File Offset: 0x0001CD00
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 930944, RefRangeEnd = 930966, XrefRangeStart = 930944, XrefRangeEnd = 930966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamHTTP(bool IsGameServer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamHTTP>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref IsGameServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0001EB48 File Offset: 0x0001CD48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932625, XrefRangeEnd = 932627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SteamAPI_SteamHTTP_v003()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr_SteamAPI_SteamHTTP_v003_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0001EB78 File Offset: 0x0001CD78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IntPtr GetUserInterfacePointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamHTTP.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0001EBC0 File Offset: 0x0001CDC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932627, XrefRangeEnd = 932629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SteamAPI_SteamGameServerHTTP_v003()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr_SteamAPI_SteamGameServerHTTP_v003_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0001EBF0 File Offset: 0x0001CDF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IntPtr GetServerInterfacePointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamHTTP.NativeMethodInfoPtr_GetServerInterfacePointer_Public_Virtual_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0001EC38 File Offset: 0x0001CE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932629, XrefRangeEnd = 932632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HTTPRequestHandle _CreateHTTPRequest(IntPtr self, HTTPMethod eHTTPRequestMethod, string pchAbsoluteURL)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eHTTPRequestMethod;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchAbsoluteURL);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr__CreateHTTPRequest_Private_Static_HTTPRequestHandle_IntPtr_HTTPMethod_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0001EC98 File Offset: 0x0001CE98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932632, XrefRangeEnd = 932635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HTTPRequestHandle CreateHTTPRequest(HTTPMethod eHTTPRequestMethod, string pchAbsoluteURL)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eHTTPRequestMethod;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchAbsoluteURL);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr_CreateHTTPRequest_Internal_HTTPRequestHandle_HTTPMethod_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0001ECF4 File Offset: 0x0001CEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932635, XrefRangeEnd = 932637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetHTTPRequestContextValue(IntPtr self, HTTPRequestHandle hRequest, ulong ulContextValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ulContextValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr__SetHTTPRequestContextValue_Private_Static_Boolean_IntPtr_HTTPRequestHandle_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0001ED50 File Offset: 0x0001CF50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932637, XrefRangeEnd = 932639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ulContextValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr_SetHTTPRequestContextValue_Internal_Boolean_HTTPRequestHandle_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0001EDA8 File Offset: 0x0001CFA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932639, XrefRangeEnd = 932641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetHTTPRequestNetworkActivityTimeout(IntPtr self, HTTPRequestHandle hRequest, uint unTimeoutSeconds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unTimeoutSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr__SetHTTPRequestNetworkActivityTimeout_Private_Static_Boolean_IntPtr_HTTPRequestHandle_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0001EE04 File Offset: 0x0001D004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932641, XrefRangeEnd = 932643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unTimeoutSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr_SetHTTPRequestNetworkActivityTimeout_Internal_Boolean_HTTPRequestHandle_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0001EE5C File Offset: 0x0001D05C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932643, XrefRangeEnd = 932648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetHTTPRequestHeaderValue(IntPtr self, HTTPRequestHandle hRequest, string pchHeaderName, string pchHeaderValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchHeaderName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchHeaderValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr__SetHTTPRequestHeaderValue_Private_Static_Boolean_IntPtr_HTTPRequestHandle_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0001EECC File Offset: 0x0001D0CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932648, XrefRangeEnd = 932653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, string pchHeaderValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchHeaderName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchHeaderValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr_SetHTTPRequestHeaderValue_Internal_Boolean_HTTPRequestHandle_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0001EF3C File Offset: 0x0001D13C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932653, XrefRangeEnd = 932658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetHTTPRequestGetOrPostParameter(IntPtr self, HTTPRequestHandle hRequest, string pchParamName, string pchParamValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchParamName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchParamValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr__SetHTTPRequestGetOrPostParameter_Private_Static_Boolean_IntPtr_HTTPRequestHandle_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0001EFAC File Offset: 0x0001D1AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932658, XrefRangeEnd = 932663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, string pchParamName, string pchParamValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchParamName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchParamValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr_SetHTTPRequestGetOrPostParameter_Internal_Boolean_HTTPRequestHandle_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0001F01C File Offset: 0x0001D21C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932663, XrefRangeEnd = 932665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SendHTTPRequest(IntPtr self, HTTPRequestHandle hRequest, ref SteamAPICall_t pCallHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pCallHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr__SendHTTPRequest_Private_Static_Boolean_IntPtr_HTTPRequestHandle_byref_SteamAPICall_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0001F078 File Offset: 0x0001D278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932665, XrefRangeEnd = 932667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SendHTTPRequest(HTTPRequestHandle hRequest, ref SteamAPICall_t pCallHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pCallHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr_SendHTTPRequest_Internal_Boolean_HTTPRequestHandle_byref_SteamAPICall_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0001F0D0 File Offset: 0x0001D2D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932667, XrefRangeEnd = 932669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SendHTTPRequestAndStreamResponse(IntPtr self, HTTPRequestHandle hRequest, ref SteamAPICall_t pCallHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pCallHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr__SendHTTPRequestAndStreamResponse_Private_Static_Boolean_IntPtr_HTTPRequestHandle_byref_SteamAPICall_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0001F12C File Offset: 0x0001D32C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932669, XrefRangeEnd = 932671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, ref SteamAPICall_t pCallHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pCallHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr_SendHTTPRequestAndStreamResponse_Internal_Boolean_HTTPRequestHandle_byref_SteamAPICall_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0001F184 File Offset: 0x0001D384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932671, XrefRangeEnd = 932673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _DeferHTTPRequest(IntPtr self, HTTPRequestHandle hRequest)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr__DeferHTTPRequest_Private_Static_Boolean_IntPtr_HTTPRequestHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0001F1D0 File Offset: 0x0001D3D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932673, XrefRangeEnd = 932675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DeferHTTPRequest(HTTPRequestHandle hRequest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr_DeferHTTPRequest_Internal_Boolean_HTTPRequestHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0001F21C File Offset: 0x0001D41C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932675, XrefRangeEnd = 932677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _PrioritizeHTTPRequest(IntPtr self, HTTPRequestHandle hRequest)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr__PrioritizeHTTPRequest_Private_Static_Boolean_IntPtr_HTTPRequestHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0001F268 File Offset: 0x0001D468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932677, XrefRangeEnd = 932679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PrioritizeHTTPRequest(HTTPRequestHandle hRequest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr_PrioritizeHTTPRequest_Internal_Boolean_HTTPRequestHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0001F2B4 File Offset: 0x0001D4B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932679, XrefRangeEnd = 932682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetHTTPResponseHeaderSize(IntPtr self, HTTPRequestHandle hRequest, string pchHeaderName, ref uint unResponseHeaderSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchHeaderName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &unResponseHeaderSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr__GetHTTPResponseHeaderSize_Private_Static_Boolean_IntPtr_HTTPRequestHandle_String_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0001F320 File Offset: 0x0001D520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932682, XrefRangeEnd = 932685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, string pchHeaderName, ref uint unResponseHeaderSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchHeaderName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &unResponseHeaderSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr_GetHTTPResponseHeaderSize_Internal_Boolean_HTTPRequestHandle_String_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0001F38C File Offset: 0x0001D58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932685, XrefRangeEnd = 932688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetHTTPResponseHeaderValue(IntPtr self, HTTPRequestHandle hRequest, string pchHeaderName, ref byte pHeaderValueBuffer, uint unBufferSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchHeaderName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pHeaderValueBuffer;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr__GetHTTPResponseHeaderValue_Private_Static_Boolean_IntPtr_HTTPRequestHandle_String_byref_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0001F408 File Offset: 0x0001D608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932688, XrefRangeEnd = 932691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, ref byte pHeaderValueBuffer, uint unBufferSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchHeaderName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pHeaderValueBuffer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr_GetHTTPResponseHeaderValue_Internal_Boolean_HTTPRequestHandle_String_byref_Byte_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0001F480 File Offset: 0x0001D680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932691, XrefRangeEnd = 932693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetHTTPResponseBodySize(IntPtr self, HTTPRequestHandle hRequest, ref uint unBodySize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &unBodySize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr__GetHTTPResponseBodySize_Private_Static_Boolean_IntPtr_HTTPRequestHandle_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0001F4DC File Offset: 0x0001D6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932693, XrefRangeEnd = 932695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetHTTPResponseBodySize(HTTPRequestHandle hRequest, ref uint unBodySize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &unBodySize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr_GetHTTPResponseBodySize_Internal_Boolean_HTTPRequestHandle_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0001F534 File Offset: 0x0001D734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932695, XrefRangeEnd = 932697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetHTTPResponseBodyData(IntPtr self, HTTPRequestHandle hRequest, ref byte pBodyDataBuffer, uint unBufferSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pBodyDataBuffer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr__GetHTTPResponseBodyData_Private_Static_Boolean_IntPtr_HTTPRequestHandle_byref_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0001F59C File Offset: 0x0001D79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932697, XrefRangeEnd = 932699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetHTTPResponseBodyData(HTTPRequestHandle hRequest, ref byte pBodyDataBuffer, uint unBufferSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pBodyDataBuffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr_GetHTTPResponseBodyData_Internal_Boolean_HTTPRequestHandle_byref_Byte_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0001F604 File Offset: 0x0001D804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932699, XrefRangeEnd = 932701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetHTTPStreamingResponseBodyData(IntPtr self, HTTPRequestHandle hRequest, uint cOffset, ref byte pBodyDataBuffer, uint unBufferSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cOffset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pBodyDataBuffer;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr__GetHTTPStreamingResponseBodyData_Private_Static_Boolean_IntPtr_HTTPRequestHandle_UInt32_byref_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0001F67C File Offset: 0x0001D87C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932701, XrefRangeEnd = 932703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, ref byte pBodyDataBuffer, uint unBufferSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pBodyDataBuffer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr_GetHTTPStreamingResponseBodyData_Internal_Boolean_HTTPRequestHandle_UInt32_byref_Byte_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0001F6F0 File Offset: 0x0001D8F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932703, XrefRangeEnd = 932705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _ReleaseHTTPRequest(IntPtr self, HTTPRequestHandle hRequest)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr__ReleaseHTTPRequest_Private_Static_Boolean_IntPtr_HTTPRequestHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0001F73C File Offset: 0x0001D93C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932705, XrefRangeEnd = 932707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReleaseHTTPRequest(HTTPRequestHandle hRequest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr_ReleaseHTTPRequest_Internal_Boolean_HTTPRequestHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0001F788 File Offset: 0x0001D988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932707, XrefRangeEnd = 932709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetHTTPDownloadProgressPct(IntPtr self, HTTPRequestHandle hRequest, ref float pflPercentOut)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pflPercentOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr__GetHTTPDownloadProgressPct_Private_Static_Boolean_IntPtr_HTTPRequestHandle_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0001F7E4 File Offset: 0x0001D9E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932709, XrefRangeEnd = 932711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, ref float pflPercentOut)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pflPercentOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr_GetHTTPDownloadProgressPct_Internal_Boolean_HTTPRequestHandle_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0001F83C File Offset: 0x0001DA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932711, XrefRangeEnd = 932714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetHTTPRequestRawPostBody(IntPtr self, HTTPRequestHandle hRequest, string pchContentType, [In] [Out] Il2CppStructArray<byte> pubBody, uint unBodyLen)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchContentType);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBodyLen;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr__SetHTTPRequestRawPostBody_Private_Static_Boolean_IntPtr_HTTPRequestHandle_String_Il2CppStructArray_1_Byte_UInt32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pubBody = ((intPtr4 == 0) ? null : new Il2CppStructArray<byte>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0001F8CC File Offset: 0x0001DACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932714, XrefRangeEnd = 932717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, string pchContentType, [In] [Out] Il2CppStructArray<byte> pubBody, uint unBodyLen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchContentType);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBodyLen;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr_SetHTTPRequestRawPostBody_Internal_Boolean_HTTPRequestHandle_String_Il2CppStructArray_1_Byte_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pubBody = ((intPtr4 == 0) ? null : new Il2CppStructArray<byte>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0001F958 File Offset: 0x0001DB58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932717, XrefRangeEnd = 932719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HTTPCookieContainerHandle _CreateCookieContainer(IntPtr self, bool bAllowResponsesToModify)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bAllowResponsesToModify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr__CreateCookieContainer_Private_Static_HTTPCookieContainerHandle_IntPtr_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0001F9A4 File Offset: 0x0001DBA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932719, XrefRangeEnd = 932721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HTTPCookieContainerHandle CreateCookieContainer(bool bAllowResponsesToModify)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bAllowResponsesToModify;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr_CreateCookieContainer_Internal_HTTPCookieContainerHandle_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0001F9F0 File Offset: 0x0001DBF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932721, XrefRangeEnd = 932723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _ReleaseCookieContainer(IntPtr self, HTTPCookieContainerHandle hCookieContainer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hCookieContainer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr__ReleaseCookieContainer_Private_Static_Boolean_IntPtr_HTTPCookieContainerHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0001FA3C File Offset: 0x0001DC3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932723, XrefRangeEnd = 932725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hCookieContainer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr_ReleaseCookieContainer_Internal_Boolean_HTTPCookieContainerHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0001FA88 File Offset: 0x0001DC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932725, XrefRangeEnd = 932732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetCookie(IntPtr self, HTTPCookieContainerHandle hCookieContainer, string pchHost, string pchUrl, string pchCookie)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hCookieContainer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchHost);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchUrl);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchCookie);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr__SetCookie_Private_Static_Boolean_IntPtr_HTTPCookieContainerHandle_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0001FB0C File Offset: 0x0001DD0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932732, XrefRangeEnd = 932739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetCookie(HTTPCookieContainerHandle hCookieContainer, string pchHost, string pchUrl, string pchCookie)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hCookieContainer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchHost);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchUrl);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchCookie);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr_SetCookie_Internal_Boolean_HTTPCookieContainerHandle_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0001FB8C File Offset: 0x0001DD8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932739, XrefRangeEnd = 932741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetHTTPRequestCookieContainer(IntPtr self, HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hCookieContainer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr__SetHTTPRequestCookieContainer_Private_Static_Boolean_IntPtr_HTTPRequestHandle_HTTPCookieContainerHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0001FBE8 File Offset: 0x0001DDE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932741, XrefRangeEnd = 932743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hCookieContainer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr_SetHTTPRequestCookieContainer_Internal_Boolean_HTTPRequestHandle_HTTPCookieContainerHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0001FC40 File Offset: 0x0001DE40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932743, XrefRangeEnd = 932746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetHTTPRequestUserAgentInfo(IntPtr self, HTTPRequestHandle hRequest, string pchUserAgentInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchUserAgentInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr__SetHTTPRequestUserAgentInfo_Private_Static_Boolean_IntPtr_HTTPRequestHandle_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0001FCA0 File Offset: 0x0001DEA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932746, XrefRangeEnd = 932749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, string pchUserAgentInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchUserAgentInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr_SetHTTPRequestUserAgentInfo_Internal_Boolean_HTTPRequestHandle_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0001FCFC File Offset: 0x0001DEFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932749, XrefRangeEnd = 932751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetHTTPRequestRequiresVerifiedCertificate(IntPtr self, HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bRequireVerifiedCertificate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr__SetHTTPRequestRequiresVerifiedCertificate_Private_Static_Boolean_IntPtr_HTTPRequestHandle_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0001FD58 File Offset: 0x0001DF58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932751, XrefRangeEnd = 932753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bRequireVerifiedCertificate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr_SetHTTPRequestRequiresVerifiedCertificate_Internal_Boolean_HTTPRequestHandle_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0001FDB0 File Offset: 0x0001DFB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932753, XrefRangeEnd = 932755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetHTTPRequestAbsoluteTimeoutMS(IntPtr self, HTTPRequestHandle hRequest, uint unMilliseconds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unMilliseconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr__SetHTTPRequestAbsoluteTimeoutMS_Private_Static_Boolean_IntPtr_HTTPRequestHandle_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0001FE0C File Offset: 0x0001E00C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932755, XrefRangeEnd = 932757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unMilliseconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr_SetHTTPRequestAbsoluteTimeoutMS_Internal_Boolean_HTTPRequestHandle_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0001FE64 File Offset: 0x0001E064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932757, XrefRangeEnd = 932759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetHTTPRequestWasTimedOut(IntPtr self, HTTPRequestHandle hRequest, ref bool pbWasTimedOut)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hRequest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pbWasTimedOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr__GetHTTPRequestWasTimedOut_Private_Static_Boolean_IntPtr_HTTPRequestHandle_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0001FEC0 File Offset: 0x0001E0C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932759, XrefRangeEnd = 932761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, ref bool pbWasTimedOut)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pbWasTimedOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamHTTP.NativeMethodInfoPtr_GetHTTPRequestWasTimedOut_Internal_Boolean_HTTPRequestHandle_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00002324 File Offset: 0x00000524
		public ISteamHTTP(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000356 RID: 854
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeMethodInfoPtr_SteamAPI_SteamHTTP_v003_Internal_Static_IntPtr_0;

		// Token: 0x04000358 RID: 856
		private static readonly IntPtr NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0;

		// Token: 0x04000359 RID: 857
		private static readonly IntPtr NativeMethodInfoPtr_SteamAPI_SteamGameServerHTTP_v003_Internal_Static_IntPtr_0;

		// Token: 0x0400035A RID: 858
		private static readonly IntPtr NativeMethodInfoPtr_GetServerInterfacePointer_Public_Virtual_IntPtr_0;

		// Token: 0x0400035B RID: 859
		private static readonly IntPtr NativeMethodInfoPtr__CreateHTTPRequest_Private_Static_HTTPRequestHandle_IntPtr_HTTPMethod_String_0;

		// Token: 0x0400035C RID: 860
		private static readonly IntPtr NativeMethodInfoPtr_CreateHTTPRequest_Internal_HTTPRequestHandle_HTTPMethod_String_0;

		// Token: 0x0400035D RID: 861
		private static readonly IntPtr NativeMethodInfoPtr__SetHTTPRequestContextValue_Private_Static_Boolean_IntPtr_HTTPRequestHandle_UInt64_0;

		// Token: 0x0400035E RID: 862
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestContextValue_Internal_Boolean_HTTPRequestHandle_UInt64_0;

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeMethodInfoPtr__SetHTTPRequestNetworkActivityTimeout_Private_Static_Boolean_IntPtr_HTTPRequestHandle_UInt32_0;

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestNetworkActivityTimeout_Internal_Boolean_HTTPRequestHandle_UInt32_0;

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeMethodInfoPtr__SetHTTPRequestHeaderValue_Private_Static_Boolean_IntPtr_HTTPRequestHandle_String_String_0;

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestHeaderValue_Internal_Boolean_HTTPRequestHandle_String_String_0;

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeMethodInfoPtr__SetHTTPRequestGetOrPostParameter_Private_Static_Boolean_IntPtr_HTTPRequestHandle_String_String_0;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestGetOrPostParameter_Internal_Boolean_HTTPRequestHandle_String_String_0;

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeMethodInfoPtr__SendHTTPRequest_Private_Static_Boolean_IntPtr_HTTPRequestHandle_byref_SteamAPICall_t_0;

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeMethodInfoPtr_SendHTTPRequest_Internal_Boolean_HTTPRequestHandle_byref_SteamAPICall_t_0;

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeMethodInfoPtr__SendHTTPRequestAndStreamResponse_Private_Static_Boolean_IntPtr_HTTPRequestHandle_byref_SteamAPICall_t_0;

		// Token: 0x04000368 RID: 872
		private static readonly IntPtr NativeMethodInfoPtr_SendHTTPRequestAndStreamResponse_Internal_Boolean_HTTPRequestHandle_byref_SteamAPICall_t_0;

		// Token: 0x04000369 RID: 873
		private static readonly IntPtr NativeMethodInfoPtr__DeferHTTPRequest_Private_Static_Boolean_IntPtr_HTTPRequestHandle_0;

		// Token: 0x0400036A RID: 874
		private static readonly IntPtr NativeMethodInfoPtr_DeferHTTPRequest_Internal_Boolean_HTTPRequestHandle_0;

		// Token: 0x0400036B RID: 875
		private static readonly IntPtr NativeMethodInfoPtr__PrioritizeHTTPRequest_Private_Static_Boolean_IntPtr_HTTPRequestHandle_0;

		// Token: 0x0400036C RID: 876
		private static readonly IntPtr NativeMethodInfoPtr_PrioritizeHTTPRequest_Internal_Boolean_HTTPRequestHandle_0;

		// Token: 0x0400036D RID: 877
		private static readonly IntPtr NativeMethodInfoPtr__GetHTTPResponseHeaderSize_Private_Static_Boolean_IntPtr_HTTPRequestHandle_String_byref_UInt32_0;

		// Token: 0x0400036E RID: 878
		private static readonly IntPtr NativeMethodInfoPtr_GetHTTPResponseHeaderSize_Internal_Boolean_HTTPRequestHandle_String_byref_UInt32_0;

		// Token: 0x0400036F RID: 879
		private static readonly IntPtr NativeMethodInfoPtr__GetHTTPResponseHeaderValue_Private_Static_Boolean_IntPtr_HTTPRequestHandle_String_byref_Byte_UInt32_0;

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeMethodInfoPtr_GetHTTPResponseHeaderValue_Internal_Boolean_HTTPRequestHandle_String_byref_Byte_UInt32_0;

		// Token: 0x04000371 RID: 881
		private static readonly IntPtr NativeMethodInfoPtr__GetHTTPResponseBodySize_Private_Static_Boolean_IntPtr_HTTPRequestHandle_byref_UInt32_0;

		// Token: 0x04000372 RID: 882
		private static readonly IntPtr NativeMethodInfoPtr_GetHTTPResponseBodySize_Internal_Boolean_HTTPRequestHandle_byref_UInt32_0;

		// Token: 0x04000373 RID: 883
		private static readonly IntPtr NativeMethodInfoPtr__GetHTTPResponseBodyData_Private_Static_Boolean_IntPtr_HTTPRequestHandle_byref_Byte_UInt32_0;

		// Token: 0x04000374 RID: 884
		private static readonly IntPtr NativeMethodInfoPtr_GetHTTPResponseBodyData_Internal_Boolean_HTTPRequestHandle_byref_Byte_UInt32_0;

		// Token: 0x04000375 RID: 885
		private static readonly IntPtr NativeMethodInfoPtr__GetHTTPStreamingResponseBodyData_Private_Static_Boolean_IntPtr_HTTPRequestHandle_UInt32_byref_Byte_UInt32_0;

		// Token: 0x04000376 RID: 886
		private static readonly IntPtr NativeMethodInfoPtr_GetHTTPStreamingResponseBodyData_Internal_Boolean_HTTPRequestHandle_UInt32_byref_Byte_UInt32_0;

		// Token: 0x04000377 RID: 887
		private static readonly IntPtr NativeMethodInfoPtr__ReleaseHTTPRequest_Private_Static_Boolean_IntPtr_HTTPRequestHandle_0;

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseHTTPRequest_Internal_Boolean_HTTPRequestHandle_0;

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeMethodInfoPtr__GetHTTPDownloadProgressPct_Private_Static_Boolean_IntPtr_HTTPRequestHandle_byref_Single_0;

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeMethodInfoPtr_GetHTTPDownloadProgressPct_Internal_Boolean_HTTPRequestHandle_byref_Single_0;

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeMethodInfoPtr__SetHTTPRequestRawPostBody_Private_Static_Boolean_IntPtr_HTTPRequestHandle_String_Il2CppStructArray_1_Byte_UInt32_0;

		// Token: 0x0400037C RID: 892
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestRawPostBody_Internal_Boolean_HTTPRequestHandle_String_Il2CppStructArray_1_Byte_UInt32_0;

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeMethodInfoPtr__CreateCookieContainer_Private_Static_HTTPCookieContainerHandle_IntPtr_Boolean_0;

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeMethodInfoPtr_CreateCookieContainer_Internal_HTTPCookieContainerHandle_Boolean_0;

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeMethodInfoPtr__ReleaseCookieContainer_Private_Static_Boolean_IntPtr_HTTPCookieContainerHandle_0;

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseCookieContainer_Internal_Boolean_HTTPCookieContainerHandle_0;

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeMethodInfoPtr__SetCookie_Private_Static_Boolean_IntPtr_HTTPCookieContainerHandle_String_String_String_0;

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeMethodInfoPtr_SetCookie_Internal_Boolean_HTTPCookieContainerHandle_String_String_String_0;

		// Token: 0x04000383 RID: 899
		private static readonly IntPtr NativeMethodInfoPtr__SetHTTPRequestCookieContainer_Private_Static_Boolean_IntPtr_HTTPRequestHandle_HTTPCookieContainerHandle_0;

		// Token: 0x04000384 RID: 900
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestCookieContainer_Internal_Boolean_HTTPRequestHandle_HTTPCookieContainerHandle_0;

		// Token: 0x04000385 RID: 901
		private static readonly IntPtr NativeMethodInfoPtr__SetHTTPRequestUserAgentInfo_Private_Static_Boolean_IntPtr_HTTPRequestHandle_String_0;

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestUserAgentInfo_Internal_Boolean_HTTPRequestHandle_String_0;

		// Token: 0x04000387 RID: 903
		private static readonly IntPtr NativeMethodInfoPtr__SetHTTPRequestRequiresVerifiedCertificate_Private_Static_Boolean_IntPtr_HTTPRequestHandle_Boolean_0;

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestRequiresVerifiedCertificate_Internal_Boolean_HTTPRequestHandle_Boolean_0;

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeMethodInfoPtr__SetHTTPRequestAbsoluteTimeoutMS_Private_Static_Boolean_IntPtr_HTTPRequestHandle_UInt32_0;

		// Token: 0x0400038A RID: 906
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestAbsoluteTimeoutMS_Internal_Boolean_HTTPRequestHandle_UInt32_0;

		// Token: 0x0400038B RID: 907
		private static readonly IntPtr NativeMethodInfoPtr__GetHTTPRequestWasTimedOut_Private_Static_Boolean_IntPtr_HTTPRequestHandle_byref_Boolean_0;

		// Token: 0x0400038C RID: 908
		private static readonly IntPtr NativeMethodInfoPtr_GetHTTPRequestWasTimedOut_Internal_Boolean_HTTPRequestHandle_byref_Boolean_0;
	}
}
