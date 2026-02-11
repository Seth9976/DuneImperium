using System;
using Google.Apis.Http;
using Google.Apis.Requests;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Net.Http;
using Il2CppSystem.Reflection;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Services
{
	// Token: 0x0200000D RID: 13
	public class IClientService : Il2CppObjectBase
	{
		// Token: 0x060000F7 RID: 247 RVA: 0x000087F8 File Offset: 0x000069F8
		// Note: this type is marked as 'beforefieldinit'.
		static IClientService()
		{
			Il2CppClassPointerStore<IClientService>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.dll", "Google.Apis.Services", "IClientService");
			IClientService.NativeMethodInfoPtr_get_HttpClient_Public_Abstract_Virtual_New_get_ConfigurableHttpClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClientService>.NativeClassPtr, 100663494);
			IClientService.NativeMethodInfoPtr_get_HttpClientInitializer_Public_Abstract_Virtual_New_get_IConfigurableHttpClientInitializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClientService>.NativeClassPtr, 100663495);
			IClientService.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClientService>.NativeClassPtr, 100663496);
			IClientService.NativeMethodInfoPtr_get_BaseUri_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClientService>.NativeClassPtr, 100663497);
			IClientService.NativeMethodInfoPtr_get_BasePath_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClientService>.NativeClassPtr, 100663498);
			IClientService.NativeMethodInfoPtr_get_Features_Public_Abstract_Virtual_New_get_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClientService>.NativeClassPtr, 100663499);
			IClientService.NativeMethodInfoPtr_get_GZipEnabled_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClientService>.NativeClassPtr, 100663500);
			IClientService.NativeMethodInfoPtr_get_ApiKey_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClientService>.NativeClassPtr, 100663501);
			IClientService.NativeMethodInfoPtr_get_ApplicationName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClientService>.NativeClassPtr, 100663502);
			IClientService.NativeMethodInfoPtr_SetRequestSerailizedContent_Public_Abstract_Virtual_New_Void_HttpRequestMessage_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClientService>.NativeClassPtr, 100663503);
			IClientService.NativeMethodInfoPtr_get_Serializer_Public_Abstract_Virtual_New_get_ISerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClientService>.NativeClassPtr, 100663504);
			IClientService.NativeMethodInfoPtr_SerializeObject_Public_Abstract_Virtual_New_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClientService>.NativeClassPtr, 100663505);
			IClientService.NativeMethodInfoPtr_DeserializeResponse_Public_Abstract_Virtual_New_Task_1_T_HttpResponseMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClientService>.NativeClassPtr, 100663506);
			IClientService.NativeMethodInfoPtr_DeserializeError_Public_Abstract_Virtual_New_Task_1_RequestError_HttpResponseMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClientService>.NativeClassPtr, 100663507);
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00008938 File Offset: 0x00006B38
		public unsafe virtual ConfigurableHttpClient HttpClient
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClientService.NativeMethodInfoPtr_get_HttpClient_Public_Abstract_Virtual_New_get_ConfigurableHttpClient_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurableHttpClient>(intPtr3) : null;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00008984 File Offset: 0x00006B84
		public unsafe virtual IConfigurableHttpClientInitializer HttpClientInitializer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClientService.NativeMethodInfoPtr_get_HttpClientInitializer_Public_Abstract_Virtual_New_get_IConfigurableHttpClientInitializer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConfigurableHttpClientInitializer>(intPtr3) : null;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000FA RID: 250 RVA: 0x000089D0 File Offset: 0x00006BD0
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClientService.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00008A14 File Offset: 0x00006C14
		public unsafe virtual string BaseUri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClientService.NativeMethodInfoPtr_get_BaseUri_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00008A58 File Offset: 0x00006C58
		public unsafe virtual string BasePath
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClientService.NativeMethodInfoPtr_get_BasePath_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00008A9C File Offset: 0x00006C9C
		public unsafe virtual IList<string> Features
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClientService.NativeMethodInfoPtr_get_Features_Public_Abstract_Virtual_New_get_IList_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr3) : null;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00008AE8 File Offset: 0x00006CE8
		public unsafe virtual bool GZipEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClientService.NativeMethodInfoPtr_get_GZipEnabled_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00008B30 File Offset: 0x00006D30
		public unsafe virtual string ApiKey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClientService.NativeMethodInfoPtr_get_ApiKey_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00008B74 File Offset: 0x00006D74
		public unsafe virtual string ApplicationName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClientService.NativeMethodInfoPtr_get_ApplicationName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00008BB8 File Offset: 0x00006DB8
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClientService.NativeMethodInfoPtr_SetRequestSerailizedContent_Public_Abstract_Virtual_New_Void_HttpRequestMessage_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00008C18 File Offset: 0x00006E18
		public unsafe virtual ISerializer Serializer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClientService.NativeMethodInfoPtr_get_Serializer_Public_Abstract_Virtual_New_get_ISerializer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISerializer>(intPtr3) : null;
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00008C64 File Offset: 0x00006E64
		[CallerCount(0)]
		public unsafe virtual string SerializeObject(Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClientService.NativeMethodInfoPtr_SerializeObject_Public_Abstract_Virtual_New_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00008CB8 File Offset: 0x00006EB8
		[CallerCount(0)]
		public unsafe virtual Task<T> DeserializeResponse<T>(HttpResponseMessage response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClientService.MethodInfoStoreGeneric_DeserializeResponse_Public_Abstract_Virtual_New_Task_1_T_HttpResponseMessage_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00008D14 File Offset: 0x00006F14
		[CallerCount(0)]
		public unsafe virtual Task<RequestError> DeserializeError(HttpResponseMessage response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClientService.NativeMethodInfoPtr_DeserializeError_Public_Abstract_Virtual_New_Task_1_RequestError_HttpResponseMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<RequestError>>(intPtr3) : null;
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000025AE File Offset: 0x000007AE
		public IClientService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_get_HttpClient_Public_Abstract_Virtual_New_get_ConfigurableHttpClient_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_get_HttpClientInitializer_Public_Abstract_Virtual_New_get_IConfigurableHttpClientInitializer_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseUri_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_get_BasePath_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_get_Features_Public_Abstract_Virtual_New_get_IList_1_String_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_get_GZipEnabled_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_get_ApiKey_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_get_ApplicationName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_SetRequestSerailizedContent_Public_Abstract_Virtual_New_Void_HttpRequestMessage_Object_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_get_Serializer_Public_Abstract_Virtual_New_get_ISerializer_0;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr_SerializeObject_Public_Abstract_Virtual_New_String_Object_0;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeResponse_Public_Abstract_Virtual_New_Task_1_T_HttpResponseMessage_0;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeError_Public_Abstract_Virtual_New_Task_1_RequestError_HttpResponseMessage_0;

		// Token: 0x02000034 RID: 52
		private sealed class MethodInfoStoreGeneric_DeserializeResponse_Public_Abstract_Virtual_New_Task_1_T_HttpResponseMessage_0<T>
		{
			// Token: 0x040001F3 RID: 499
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IClientService.NativeMethodInfoPtr_DeserializeResponse_Public_Abstract_Virtual_New_Task_1_T_HttpResponseMessage_0, Il2CppClassPointerStore<IClientService>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
