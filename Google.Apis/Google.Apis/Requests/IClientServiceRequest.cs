using System;
using Google.Apis.Discovery;
using Google.Apis.Services;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Net.Http;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Requests
{
	// Token: 0x02000012 RID: 18
	public class IClientServiceRequest : Il2CppObjectBase
	{
		// Token: 0x06000156 RID: 342 RVA: 0x0000A1A0 File Offset: 0x000083A0
		// Note: this type is marked as 'beforefieldinit'.
		static IClientServiceRequest()
		{
			Il2CppClassPointerStore<IClientServiceRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.dll", "Google.Apis.Requests", "IClientServiceRequest");
			IClientServiceRequest.NativeMethodInfoPtr_get_MethodName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClientServiceRequest>.NativeClassPtr, 100663591);
			IClientServiceRequest.NativeMethodInfoPtr_get_RestPath_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClientServiceRequest>.NativeClassPtr, 100663592);
			IClientServiceRequest.NativeMethodInfoPtr_get_HttpMethod_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClientServiceRequest>.NativeClassPtr, 100663593);
			IClientServiceRequest.NativeMethodInfoPtr_get_RequestParameters_Public_Abstract_Virtual_New_get_IDictionary_2_String_IParameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClientServiceRequest>.NativeClassPtr, 100663594);
			IClientServiceRequest.NativeMethodInfoPtr_get_Service_Public_Abstract_Virtual_New_get_IClientService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClientServiceRequest>.NativeClassPtr, 100663595);
			IClientServiceRequest.NativeMethodInfoPtr_CreateRequest_Public_Abstract_Virtual_New_HttpRequestMessage_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClientServiceRequest>.NativeClassPtr, 100663596);
			IClientServiceRequest.NativeMethodInfoPtr_ExecuteAsStreamAsync_Public_Abstract_Virtual_New_Task_1_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClientServiceRequest>.NativeClassPtr, 100663597);
			IClientServiceRequest.NativeMethodInfoPtr_ExecuteAsStreamAsync_Public_Abstract_Virtual_New_Task_1_Stream_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClientServiceRequest>.NativeClassPtr, 100663598);
			IClientServiceRequest.NativeMethodInfoPtr_ExecuteAsStream_Public_Abstract_Virtual_New_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClientServiceRequest>.NativeClassPtr, 100663599);
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000157 RID: 343 RVA: 0x0000A27C File Offset: 0x0000847C
		public unsafe virtual string MethodName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClientServiceRequest.NativeMethodInfoPtr_get_MethodName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000158 RID: 344 RVA: 0x0000A2C0 File Offset: 0x000084C0
		public unsafe virtual string RestPath
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClientServiceRequest.NativeMethodInfoPtr_get_RestPath_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000159 RID: 345 RVA: 0x0000A304 File Offset: 0x00008504
		public unsafe virtual string HttpMethod
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClientServiceRequest.NativeMethodInfoPtr_get_HttpMethod_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600015A RID: 346 RVA: 0x0000A348 File Offset: 0x00008548
		public unsafe virtual IDictionary<string, IParameter> RequestParameters
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClientServiceRequest.NativeMethodInfoPtr_get_RequestParameters_Public_Abstract_Virtual_New_get_IDictionary_2_String_IParameter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, IParameter>>(intPtr3) : null;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600015B RID: 347 RVA: 0x0000A394 File Offset: 0x00008594
		public unsafe virtual IClientService Service
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClientServiceRequest.NativeMethodInfoPtr_get_Service_Public_Abstract_Virtual_New_get_IClientService_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IClientService>(intPtr3) : null;
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000A3E0 File Offset: 0x000085E0
		[CallerCount(0)]
		public unsafe virtual HttpRequestMessage CreateRequest(Nullable<bool> overrideGZipEnabled = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(overrideGZipEnabled));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClientServiceRequest.NativeMethodInfoPtr_CreateRequest_Public_Abstract_Virtual_New_HttpRequestMessage_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpRequestMessage>(intPtr3) : null;
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000A440 File Offset: 0x00008640
		[CallerCount(0)]
		public unsafe virtual Task<Stream> ExecuteAsStreamAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClientServiceRequest.NativeMethodInfoPtr_ExecuteAsStreamAsync_Public_Abstract_Virtual_New_Task_1_Stream_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Stream>>(intPtr3) : null;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000A48C File Offset: 0x0000868C
		[CallerCount(0)]
		public unsafe virtual Task<Stream> ExecuteAsStreamAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClientServiceRequest.NativeMethodInfoPtr_ExecuteAsStreamAsync_Public_Abstract_Virtual_New_Task_1_Stream_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Stream>>(intPtr3) : null;
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000A4EC File Offset: 0x000086EC
		[CallerCount(0)]
		public unsafe virtual Stream ExecuteAsStream()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClientServiceRequest.NativeMethodInfoPtr_ExecuteAsStream_Public_Abstract_Virtual_New_Stream_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000273F File Offset: 0x0000093F
		public IClientServiceRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr_get_RestPath_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr_get_HttpMethod_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestParameters_Public_Abstract_Virtual_New_get_IDictionary_2_String_IParameter_0;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr_get_Service_Public_Abstract_Virtual_New_get_IClientService_0;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeMethodInfoPtr_CreateRequest_Public_Abstract_Virtual_New_HttpRequestMessage_Nullable_1_Boolean_0;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteAsStreamAsync_Public_Abstract_Virtual_New_Task_1_Stream_0;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteAsStreamAsync_Public_Abstract_Virtual_New_Task_1_Stream_CancellationToken_0;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteAsStream_Public_Abstract_Virtual_New_Stream_0;
	}
}
