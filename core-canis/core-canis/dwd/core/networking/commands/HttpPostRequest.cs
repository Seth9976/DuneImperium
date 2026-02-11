using System;
using dwd.core.networking.downloadHandlers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace dwd.core.networking.commands
{
	// Token: 0x0200012A RID: 298
	public class HttpPostRequest : DwdWebRequestCommand
	{
		// Token: 0x060010E3 RID: 4323 RVA: 0x0005679C File Offset: 0x0005499C
		// Note: this type is marked as 'beforefieldinit'.
		static HttpPostRequest()
		{
			Il2CppClassPointerStore<HttpPostRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.networking.commands", "HttpPostRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpPostRequest>.NativeClassPtr);
			HttpPostRequest.NativeMethodInfoPtr__ctor_Public_Void_String_String_IDictionary_2_String_String_DwdDownloadHandler_Int32_Action_1_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpPostRequest>.NativeClassPtr, 100665755);
			HttpPostRequest.NativeMethodInfoPtr__ctor_Public_Void_String_WWWForm_DwdDownloadHandler_Int32_Action_1_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpPostRequest>.NativeClassPtr, 100665756);
			HttpPostRequest.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_IDictionary_2_String_String_DwdDownloadHandler_Int32_Action_1_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpPostRequest>.NativeClassPtr, 100665757);
		}

		// Token: 0x060010E4 RID: 4324 RVA: 0x00056808 File Offset: 0x00054A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870311, XrefRangeEnd = 870314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpPostRequest(string url, string postData, IDictionary<string, string> headers = null, DwdDownloadHandler downloadHandler = null, int timeout = 30, Action<UnityWebRequest> requestInitializer = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpPostRequest>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(postData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(headers);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(downloadHandler);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(requestInitializer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpPostRequest.NativeMethodInfoPtr__ctor_Public_Void_String_String_IDictionary_2_String_String_DwdDownloadHandler_Int32_Action_1_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x000568AC File Offset: 0x00054AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870314, XrefRangeEnd = 870317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpPostRequest(string url, WWWForm postDataAndHeaders, DwdDownloadHandler downloadHandler = null, int timeout = 30, Action<UnityWebRequest> requestInitializer = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpPostRequest>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(postDataAndHeaders);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(downloadHandler);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(requestInitializer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpPostRequest.NativeMethodInfoPtr__ctor_Public_Void_String_WWWForm_DwdDownloadHandler_Int32_Action_1_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x0005693C File Offset: 0x00054B3C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 870351, RefRangeEnd = 870355, XrefRangeStart = 870317, XrefRangeEnd = 870351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpPostRequest(string url, Il2CppStructArray<byte> postData, IDictionary<string, string> headers = null, DwdDownloadHandler downloadHandler = null, int timeout = 30, Action<UnityWebRequest> requestInitializer = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpPostRequest>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(postData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(headers);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(downloadHandler);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(requestInitializer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpPostRequest.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_IDictionary_2_String_String_DwdDownloadHandler_Int32_Action_1_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x00007E78 File Offset: 0x00006078
		public HttpPostRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BFC RID: 3068
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_IDictionary_2_String_String_DwdDownloadHandler_Int32_Action_1_UnityWebRequest_0;

		// Token: 0x04000BFD RID: 3069
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_WWWForm_DwdDownloadHandler_Int32_Action_1_UnityWebRequest_0;

		// Token: 0x04000BFE RID: 3070
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_IDictionary_2_String_String_DwdDownloadHandler_Int32_Action_1_UnityWebRequest_0;
	}
}
