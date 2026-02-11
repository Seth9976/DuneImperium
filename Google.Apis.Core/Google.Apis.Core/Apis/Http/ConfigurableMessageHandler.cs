using System;
using Google.Apis.Logging;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Net.Http;
using Il2CppSystem.Net.Http.Headers;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Http
{
	// Token: 0x02000027 RID: 39
	public class ConfigurableMessageHandler : DelegatingHandler
	{
		// Token: 0x06000192 RID: 402 RVA: 0x0000A1A8 File Offset: 0x000083A8
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigurableMessageHandler()
		{
			Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Http", "ConfigurableMessageHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr);
			ConfigurableMessageHandler.NativeFieldInfoPtr_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, "Logger");
			ConfigurableMessageHandler.NativeFieldInfoPtr_MaxAllowedNumTries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, "MaxAllowedNumTries");
			ConfigurableMessageHandler.NativeFieldInfoPtr_UnsuccessfulResponseHandlerKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, "UnsuccessfulResponseHandlerKey");
			ConfigurableMessageHandler.NativeFieldInfoPtr_ExceptionHandlerKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, "ExceptionHandlerKey");
			ConfigurableMessageHandler.NativeFieldInfoPtr_ExecuteInterceptorKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, "ExecuteInterceptorKey");
			ConfigurableMessageHandler.NativeFieldInfoPtr_ResponseStreamInterceptorProviderKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, "ResponseStreamInterceptorProviderKey");
			ConfigurableMessageHandler.NativeFieldInfoPtr_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, "ApiVersion");
			ConfigurableMessageHandler.NativeFieldInfoPtr_UserAgentSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, "UserAgentSuffix");
			ConfigurableMessageHandler.NativeFieldInfoPtr_unsuccessfulResponseHandlersLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, "unsuccessfulResponseHandlersLock");
			ConfigurableMessageHandler.NativeFieldInfoPtr_exceptionHandlersLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, "exceptionHandlersLock");
			ConfigurableMessageHandler.NativeFieldInfoPtr_executeInterceptorsLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, "executeInterceptorsLock");
			ConfigurableMessageHandler.NativeFieldInfoPtr_unsuccessfulResponseHandlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, "unsuccessfulResponseHandlers");
			ConfigurableMessageHandler.NativeFieldInfoPtr_exceptionHandlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, "exceptionHandlers");
			ConfigurableMessageHandler.NativeFieldInfoPtr_executeInterceptors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, "executeInterceptors");
			ConfigurableMessageHandler.NativeFieldInfoPtr__loggingRequestId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, "_loggingRequestId");
			ConfigurableMessageHandler.NativeFieldInfoPtr__instanceLogger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, "_instanceLogger");
			ConfigurableMessageHandler.NativeFieldInfoPtr_numTries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, "numTries");
			ConfigurableMessageHandler.NativeFieldInfoPtr_numRedirects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, "numRedirects");
			ConfigurableMessageHandler.NativeFieldInfoPtr__FollowRedirect_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, "<FollowRedirect>k__BackingField");
			ConfigurableMessageHandler.NativeFieldInfoPtr__IsLoggingEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, "<IsLoggingEnabled>k__BackingField");
			ConfigurableMessageHandler.NativeFieldInfoPtr__LogEvents_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, "<LogEvents>k__BackingField");
			ConfigurableMessageHandler.NativeFieldInfoPtr__ApplicationName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, "<ApplicationName>k__BackingField");
			ConfigurableMessageHandler.NativeFieldInfoPtr__GoogleApiClientHeader_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, "<GoogleApiClientHeader>k__BackingField");
			ConfigurableMessageHandler.NativeMethodInfoPtr_get_UnsuccessfulResponseHandlers_Public_get_IList_1_IHttpUnsuccessfulResponseHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, 100663562);
			ConfigurableMessageHandler.NativeMethodInfoPtr_AddUnsuccessfulResponseHandler_Public_Void_IHttpUnsuccessfulResponseHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, 100663563);
			ConfigurableMessageHandler.NativeMethodInfoPtr_RemoveUnsuccessfulResponseHandler_Public_Void_IHttpUnsuccessfulResponseHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, 100663564);
			ConfigurableMessageHandler.NativeMethodInfoPtr_get_ExceptionHandlers_Public_get_IList_1_IHttpExceptionHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, 100663565);
			ConfigurableMessageHandler.NativeMethodInfoPtr_AddExceptionHandler_Public_Void_IHttpExceptionHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, 100663566);
			ConfigurableMessageHandler.NativeMethodInfoPtr_RemoveExceptionHandler_Public_Void_IHttpExceptionHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, 100663567);
			ConfigurableMessageHandler.NativeMethodInfoPtr_get_ExecuteInterceptors_Public_get_IList_1_IHttpExecuteInterceptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, 100663568);
			ConfigurableMessageHandler.NativeMethodInfoPtr_AddExecuteInterceptor_Public_Void_IHttpExecuteInterceptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, 100663569);
			ConfigurableMessageHandler.NativeMethodInfoPtr_RemoveExecuteInterceptor_Public_Void_IHttpExecuteInterceptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, 100663570);
			ConfigurableMessageHandler.NativeMethodInfoPtr_get_InstanceLogger_Internal_get_ILogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, 100663571);
			ConfigurableMessageHandler.NativeMethodInfoPtr_set_InstanceLogger_Internal_set_Void_ILogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, 100663572);
			ConfigurableMessageHandler.NativeMethodInfoPtr_get_NumTries_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, 100663573);
			ConfigurableMessageHandler.NativeMethodInfoPtr_set_NumTries_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, 100663574);
			ConfigurableMessageHandler.NativeMethodInfoPtr_get_NumRedirects_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, 100663575);
			ConfigurableMessageHandler.NativeMethodInfoPtr_set_NumRedirects_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, 100663576);
			ConfigurableMessageHandler.NativeMethodInfoPtr_get_FollowRedirect_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, 100663577);
			ConfigurableMessageHandler.NativeMethodInfoPtr_set_FollowRedirect_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, 100663578);
			ConfigurableMessageHandler.NativeMethodInfoPtr_get_IsLoggingEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, 100663579);
			ConfigurableMessageHandler.NativeMethodInfoPtr_set_IsLoggingEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, 100663580);
			ConfigurableMessageHandler.NativeMethodInfoPtr_get_LogEvents_Public_get_LogEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, 100663581);
			ConfigurableMessageHandler.NativeMethodInfoPtr_set_LogEvents_Public_set_Void_LogEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, 100663582);
			ConfigurableMessageHandler.NativeMethodInfoPtr_get_ApplicationName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, 100663583);
			ConfigurableMessageHandler.NativeMethodInfoPtr_set_ApplicationName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, 100663584);
			ConfigurableMessageHandler.NativeMethodInfoPtr_get_GoogleApiClientHeader_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, 100663585);
			ConfigurableMessageHandler.NativeMethodInfoPtr_set_GoogleApiClientHeader_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, 100663586);
			ConfigurableMessageHandler.NativeMethodInfoPtr__ctor_Public_Void_HttpMessageHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, 100663587);
			ConfigurableMessageHandler.NativeMethodInfoPtr_LogHeaders_Private_Void_String_HttpHeaders_HttpHeaders_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, 100663588);
			ConfigurableMessageHandler.NativeMethodInfoPtr_LogBody_Private_Task_String_HttpContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, 100663589);
			ConfigurableMessageHandler.NativeMethodInfoPtr_SendAsync_Protected_Virtual_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, 100663590);
			ConfigurableMessageHandler.NativeMethodInfoPtr_HandleRedirect_Private_Boolean_HttpResponseMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, 100663591);
			ConfigurableMessageHandler.NativeMethodInfoPtr_Method_Internal_Static_Boolean_IDisposable_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, 100663593);
			ConfigurableMessageHandler.NativeMethodInfoPtr___n__0_Private_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, 100663594);
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000193 RID: 403 RVA: 0x0000A624 File Offset: 0x00008824
		public unsafe IList<IHttpUnsuccessfulResponseHandler> UnsuccessfulResponseHandlers
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableMessageHandler.NativeMethodInfoPtr_get_UnsuccessfulResponseHandlers_Public_get_IList_1_IHttpUnsuccessfulResponseHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<IHttpUnsuccessfulResponseHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000A664 File Offset: 0x00008864
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1212054, RefRangeEnd = 1212057, XrefRangeStart = 1212047, XrefRangeEnd = 1212054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddUnsuccessfulResponseHandler(IHttpUnsuccessfulResponseHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableMessageHandler.NativeMethodInfoPtr_AddUnsuccessfulResponseHandler_Public_Void_IHttpUnsuccessfulResponseHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000A6A8 File Offset: 0x000088A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212057, XrefRangeEnd = 1212064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveUnsuccessfulResponseHandler(IHttpUnsuccessfulResponseHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableMessageHandler.NativeMethodInfoPtr_RemoveUnsuccessfulResponseHandler_Public_Void_IHttpUnsuccessfulResponseHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000196 RID: 406 RVA: 0x0000A6EC File Offset: 0x000088EC
		public unsafe IList<IHttpExceptionHandler> ExceptionHandlers
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableMessageHandler.NativeMethodInfoPtr_get_ExceptionHandlers_Public_get_IList_1_IHttpExceptionHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<IHttpExceptionHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0000A72C File Offset: 0x0000892C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1212071, RefRangeEnd = 1212072, XrefRangeStart = 1212064, XrefRangeEnd = 1212071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddExceptionHandler(IHttpExceptionHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableMessageHandler.NativeMethodInfoPtr_AddExceptionHandler_Public_Void_IHttpExceptionHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000A770 File Offset: 0x00008970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212072, XrefRangeEnd = 1212079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveExceptionHandler(IHttpExceptionHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableMessageHandler.NativeMethodInfoPtr_RemoveExceptionHandler_Public_Void_IHttpExceptionHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000199 RID: 409 RVA: 0x0000A7B4 File Offset: 0x000089B4
		public unsafe IList<IHttpExecuteInterceptor> ExecuteInterceptors
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableMessageHandler.NativeMethodInfoPtr_get_ExecuteInterceptors_Public_get_IList_1_IHttpExecuteInterceptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<IHttpExecuteInterceptor>>(intPtr3) : null;
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000A7F4 File Offset: 0x000089F4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1212086, RefRangeEnd = 1212090, XrefRangeStart = 1212079, XrefRangeEnd = 1212086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddExecuteInterceptor(IHttpExecuteInterceptor interceptor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(interceptor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableMessageHandler.NativeMethodInfoPtr_AddExecuteInterceptor_Public_Void_IHttpExecuteInterceptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000A838 File Offset: 0x00008A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212090, XrefRangeEnd = 1212097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveExecuteInterceptor(IHttpExecuteInterceptor interceptor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(interceptor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableMessageHandler.NativeMethodInfoPtr_RemoveExecuteInterceptor_Public_Void_IHttpExecuteInterceptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600019C RID: 412 RVA: 0x0000A87C File Offset: 0x00008A7C
		// (set) Token: 0x0600019D RID: 413 RVA: 0x0000A8BC File Offset: 0x00008ABC
		public unsafe ILogger InstanceLogger
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableMessageHandler.NativeMethodInfoPtr_get_InstanceLogger_Internal_get_ILogger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212097, XrefRangeEnd = 1212102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableMessageHandler.NativeMethodInfoPtr_set_InstanceLogger_Internal_set_Void_ILogger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600019E RID: 414 RVA: 0x0000A900 File Offset: 0x00008B00
		// (set) Token: 0x0600019F RID: 415 RVA: 0x0000A93C File Offset: 0x00008B3C
		public unsafe int NumTries
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableMessageHandler.NativeMethodInfoPtr_get_NumTries_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableMessageHandler.NativeMethodInfoPtr_set_NumTries_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x0000A97C File Offset: 0x00008B7C
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x0000A9B8 File Offset: 0x00008BB8
		public unsafe int NumRedirects
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableMessageHandler.NativeMethodInfoPtr_get_NumRedirects_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableMessageHandler.NativeMethodInfoPtr_set_NumRedirects_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x0000A9F8 File Offset: 0x00008BF8
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x0000AA34 File Offset: 0x00008C34
		public unsafe bool FollowRedirect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableMessageHandler.NativeMethodInfoPtr_get_FollowRedirect_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableMessageHandler.NativeMethodInfoPtr_set_FollowRedirect_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x0000AA74 File Offset: 0x00008C74
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x0000AAB0 File Offset: 0x00008CB0
		public unsafe bool IsLoggingEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableMessageHandler.NativeMethodInfoPtr_get_IsLoggingEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableMessageHandler.NativeMethodInfoPtr_set_IsLoggingEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x0000AAF0 File Offset: 0x00008CF0
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x0000AB2C File Offset: 0x00008D2C
		public unsafe ConfigurableMessageHandler.LogEventType LogEvents
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableMessageHandler.NativeMethodInfoPtr_get_LogEvents_Public_get_LogEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableMessageHandler.NativeMethodInfoPtr_set_LogEvents_Public_set_Void_LogEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x0000AB6C File Offset: 0x00008D6C
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x0000ABA4 File Offset: 0x00008DA4
		public unsafe string ApplicationName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableMessageHandler.NativeMethodInfoPtr_get_ApplicationName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableMessageHandler.NativeMethodInfoPtr_set_ApplicationName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001AA RID: 426 RVA: 0x0000ABE8 File Offset: 0x00008DE8
		// (set) Token: 0x060001AB RID: 427 RVA: 0x0000AC20 File Offset: 0x00008E20
		public unsafe string GoogleApiClientHeader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableMessageHandler.NativeMethodInfoPtr_get_GoogleApiClientHeader_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableMessageHandler.NativeMethodInfoPtr_set_GoogleApiClientHeader_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000AC64 File Offset: 0x00008E64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1212142, RefRangeEnd = 1212143, XrefRangeStart = 1212102, XrefRangeEnd = 1212142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigurableMessageHandler(HttpMessageHandler httpMessageHandler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(httpMessageHandler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableMessageHandler.NativeMethodInfoPtr__ctor_Public_Void_HttpMessageHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000ACB0 File Offset: 0x00008EB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1212201, RefRangeEnd = 1212203, XrefRangeStart = 1212143, XrefRangeEnd = 1212201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogHeaders(string initialText, HttpHeaders headers1, HttpHeaders headers2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(initialText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(headers1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(headers2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableMessageHandler.NativeMethodInfoPtr_LogHeaders_Private_Void_String_HttpHeaders_HttpHeaders_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000AD18 File Offset: 0x00008F18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1212215, RefRangeEnd = 1212217, XrefRangeStart = 1212203, XrefRangeEnd = 1212215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task LogBody(string fmtText, HttpContent content)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fmtText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableMessageHandler.NativeMethodInfoPtr_LogBody_Private_Task_String_HttpContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000AD7C File Offset: 0x00008F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212217, XrefRangeEnd = 1212234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurableMessageHandler.NativeMethodInfoPtr_SendAsync_Protected_Virtual_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<HttpResponseMessage>>(intPtr3) : null;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000ADF0 File Offset: 0x00008FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212234, XrefRangeEnd = 1212270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HandleRedirect(HttpResponseMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableMessageHandler.NativeMethodInfoPtr_HandleRedirect_Private_Boolean_HttpResponseMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000AE40 File Offset: 0x00009040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212270, XrefRangeEnd = 1212273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Method_Internal_Static_Boolean_IDisposable_PDM_0(IDisposable disposable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(disposable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableMessageHandler.NativeMethodInfoPtr_Method_Internal_Static_Boolean_IDisposable_PDM_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000AE84 File Offset: 0x00009084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212273, XrefRangeEnd = 1212309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<HttpResponseMessage> __n__0(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableMessageHandler.NativeMethodInfoPtr___n__0_Private_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<HttpResponseMessage>>(intPtr3) : null;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00002965 File Offset: 0x00000B65
		public ConfigurableMessageHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x0000AEEC File Offset: 0x000090EC
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x0000296E File Offset: 0x00000B6E
		public unsafe static ILogger Logger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConfigurableMessageHandler.NativeFieldInfoPtr_Logger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConfigurableMessageHandler.NativeFieldInfoPtr_Logger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x0000AF14 File Offset: 0x00009114
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x00002980 File Offset: 0x00000B80
		public unsafe static int MaxAllowedNumTries
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ConfigurableMessageHandler.NativeFieldInfoPtr_MaxAllowedNumTries, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConfigurableMessageHandler.NativeFieldInfoPtr_MaxAllowedNumTries, (void*)(&value));
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x0000AF30 File Offset: 0x00009130
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x0000298E File Offset: 0x00000B8E
		public unsafe static string UnsuccessfulResponseHandlerKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConfigurableMessageHandler.NativeFieldInfoPtr_UnsuccessfulResponseHandlerKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConfigurableMessageHandler.NativeFieldInfoPtr_UnsuccessfulResponseHandlerKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001BA RID: 442 RVA: 0x0000AF50 File Offset: 0x00009150
		// (set) Token: 0x060001BB RID: 443 RVA: 0x000029A0 File Offset: 0x00000BA0
		public unsafe static string ExceptionHandlerKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConfigurableMessageHandler.NativeFieldInfoPtr_ExceptionHandlerKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConfigurableMessageHandler.NativeFieldInfoPtr_ExceptionHandlerKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001BC RID: 444 RVA: 0x0000AF70 File Offset: 0x00009170
		// (set) Token: 0x060001BD RID: 445 RVA: 0x000029B2 File Offset: 0x00000BB2
		public unsafe static string ExecuteInterceptorKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConfigurableMessageHandler.NativeFieldInfoPtr_ExecuteInterceptorKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConfigurableMessageHandler.NativeFieldInfoPtr_ExecuteInterceptorKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001BE RID: 446 RVA: 0x0000AF90 File Offset: 0x00009190
		// (set) Token: 0x060001BF RID: 447 RVA: 0x000029C4 File Offset: 0x00000BC4
		public unsafe static string ResponseStreamInterceptorProviderKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConfigurableMessageHandler.NativeFieldInfoPtr_ResponseStreamInterceptorProviderKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConfigurableMessageHandler.NativeFieldInfoPtr_ResponseStreamInterceptorProviderKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x0000AFB0 File Offset: 0x000091B0
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x000029D6 File Offset: 0x00000BD6
		public unsafe static string ApiVersion
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConfigurableMessageHandler.NativeFieldInfoPtr_ApiVersion, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConfigurableMessageHandler.NativeFieldInfoPtr_ApiVersion, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x0000AFD0 File Offset: 0x000091D0
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x000029E8 File Offset: 0x00000BE8
		public unsafe static string UserAgentSuffix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConfigurableMessageHandler.NativeFieldInfoPtr_UserAgentSuffix, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConfigurableMessageHandler.NativeFieldInfoPtr_UserAgentSuffix, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x0000AFF0 File Offset: 0x000091F0
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x000029FA File Offset: 0x00000BFA
		public unsafe Object unsuccessfulResponseHandlersLock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler.NativeFieldInfoPtr_unsuccessfulResponseHandlersLock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler.NativeFieldInfoPtr_unsuccessfulResponseHandlersLock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x0000B020 File Offset: 0x00009220
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x00002A19 File Offset: 0x00000C19
		public unsafe Object exceptionHandlersLock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler.NativeFieldInfoPtr_exceptionHandlersLock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler.NativeFieldInfoPtr_exceptionHandlersLock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x0000B050 File Offset: 0x00009250
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x00002A38 File Offset: 0x00000C38
		public unsafe Object executeInterceptorsLock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler.NativeFieldInfoPtr_executeInterceptorsLock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler.NativeFieldInfoPtr_executeInterceptorsLock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001CA RID: 458 RVA: 0x0000B080 File Offset: 0x00009280
		// (set) Token: 0x060001CB RID: 459 RVA: 0x00002A57 File Offset: 0x00000C57
		public unsafe IList<IHttpUnsuccessfulResponseHandler> unsuccessfulResponseHandlers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler.NativeFieldInfoPtr_unsuccessfulResponseHandlers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<IHttpUnsuccessfulResponseHandler>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler.NativeFieldInfoPtr_unsuccessfulResponseHandlers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001CC RID: 460 RVA: 0x0000B0B0 File Offset: 0x000092B0
		// (set) Token: 0x060001CD RID: 461 RVA: 0x00002A76 File Offset: 0x00000C76
		public unsafe IList<IHttpExceptionHandler> exceptionHandlers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler.NativeFieldInfoPtr_exceptionHandlers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<IHttpExceptionHandler>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler.NativeFieldInfoPtr_exceptionHandlers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001CE RID: 462 RVA: 0x0000B0E0 File Offset: 0x000092E0
		// (set) Token: 0x060001CF RID: 463 RVA: 0x00002A95 File Offset: 0x00000C95
		public unsafe IList<IHttpExecuteInterceptor> executeInterceptors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler.NativeFieldInfoPtr_executeInterceptors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<IHttpExecuteInterceptor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler.NativeFieldInfoPtr_executeInterceptors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x0000B110 File Offset: 0x00009310
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x00002AB4 File Offset: 0x00000CB4
		public unsafe int _loggingRequestId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler.NativeFieldInfoPtr__loggingRequestId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler.NativeFieldInfoPtr__loggingRequestId)) = value;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x0000B138 File Offset: 0x00009338
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x00002ACF File Offset: 0x00000CCF
		public unsafe ILogger _instanceLogger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler.NativeFieldInfoPtr__instanceLogger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler.NativeFieldInfoPtr__instanceLogger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x0000B168 File Offset: 0x00009368
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x00002AEE File Offset: 0x00000CEE
		public unsafe int numTries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler.NativeFieldInfoPtr_numTries);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler.NativeFieldInfoPtr_numTries)) = value;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x0000B190 File Offset: 0x00009390
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x00002B09 File Offset: 0x00000D09
		public unsafe int numRedirects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler.NativeFieldInfoPtr_numRedirects);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler.NativeFieldInfoPtr_numRedirects)) = value;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x0000B1B8 File Offset: 0x000093B8
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x00002B24 File Offset: 0x00000D24
		public unsafe bool _FollowRedirect_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler.NativeFieldInfoPtr__FollowRedirect_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler.NativeFieldInfoPtr__FollowRedirect_k__BackingField)) = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001DA RID: 474 RVA: 0x0000B1E0 File Offset: 0x000093E0
		// (set) Token: 0x060001DB RID: 475 RVA: 0x00002B3F File Offset: 0x00000D3F
		public unsafe bool _IsLoggingEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler.NativeFieldInfoPtr__IsLoggingEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler.NativeFieldInfoPtr__IsLoggingEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001DC RID: 476 RVA: 0x0000B208 File Offset: 0x00009408
		// (set) Token: 0x060001DD RID: 477 RVA: 0x00002B5A File Offset: 0x00000D5A
		public unsafe ConfigurableMessageHandler.LogEventType _LogEvents_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler.NativeFieldInfoPtr__LogEvents_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler.NativeFieldInfoPtr__LogEvents_k__BackingField)) = value;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001DE RID: 478 RVA: 0x0000B230 File Offset: 0x00009430
		// (set) Token: 0x060001DF RID: 479 RVA: 0x00002B75 File Offset: 0x00000D75
		public unsafe string _ApplicationName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler.NativeFieldInfoPtr__ApplicationName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler.NativeFieldInfoPtr__ApplicationName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x0000B258 File Offset: 0x00009458
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x00002B94 File Offset: 0x00000D94
		public unsafe string _GoogleApiClientHeader_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler.NativeFieldInfoPtr__GoogleApiClientHeader_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler.NativeFieldInfoPtr__GoogleApiClientHeader_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeFieldInfoPtr_Logger;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeFieldInfoPtr_MaxAllowedNumTries;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeFieldInfoPtr_UnsuccessfulResponseHandlerKey;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeFieldInfoPtr_ExceptionHandlerKey;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeFieldInfoPtr_ExecuteInterceptorKey;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeFieldInfoPtr_ResponseStreamInterceptorProviderKey;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeFieldInfoPtr_ApiVersion;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeFieldInfoPtr_UserAgentSuffix;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeFieldInfoPtr_unsuccessfulResponseHandlersLock;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeFieldInfoPtr_exceptionHandlersLock;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeFieldInfoPtr_executeInterceptorsLock;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeFieldInfoPtr_unsuccessfulResponseHandlers;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeFieldInfoPtr_exceptionHandlers;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeFieldInfoPtr_executeInterceptors;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeFieldInfoPtr__loggingRequestId;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeFieldInfoPtr__instanceLogger;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeFieldInfoPtr_numTries;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeFieldInfoPtr_numRedirects;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeFieldInfoPtr__FollowRedirect_k__BackingField;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeFieldInfoPtr__IsLoggingEnabled_k__BackingField;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeFieldInfoPtr__LogEvents_k__BackingField;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeFieldInfoPtr__ApplicationName_k__BackingField;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeFieldInfoPtr__GoogleApiClientHeader_k__BackingField;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_get_UnsuccessfulResponseHandlers_Public_get_IList_1_IHttpUnsuccessfulResponseHandler_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_AddUnsuccessfulResponseHandler_Public_Void_IHttpUnsuccessfulResponseHandler_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_RemoveUnsuccessfulResponseHandler_Public_Void_IHttpUnsuccessfulResponseHandler_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_get_ExceptionHandlers_Public_get_IList_1_IHttpExceptionHandler_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_AddExceptionHandler_Public_Void_IHttpExceptionHandler_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_RemoveExceptionHandler_Public_Void_IHttpExceptionHandler_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_get_ExecuteInterceptors_Public_get_IList_1_IHttpExecuteInterceptor_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_AddExecuteInterceptor_Public_Void_IHttpExecuteInterceptor_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_RemoveExecuteInterceptor_Public_Void_IHttpExecuteInterceptor_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_get_InstanceLogger_Internal_get_ILogger_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_set_InstanceLogger_Internal_set_Void_ILogger_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_get_NumTries_Public_get_Int32_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_set_NumTries_Public_set_Void_Int32_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr_get_NumRedirects_Public_get_Int32_0;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeMethodInfoPtr_set_NumRedirects_Public_set_Void_Int32_0;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr_get_FollowRedirect_Public_get_Boolean_0;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr_set_FollowRedirect_Public_set_Void_Boolean_0;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLoggingEnabled_Public_get_Boolean_0;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr_set_IsLoggingEnabled_Public_set_Void_Boolean_0;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr_get_LogEvents_Public_get_LogEventType_0;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr_set_LogEvents_Public_set_Void_LogEventType_0;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr_get_ApplicationName_Public_get_String_0;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr_set_ApplicationName_Public_set_Void_String_0;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_get_GoogleApiClientHeader_Public_get_String_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_set_GoogleApiClientHeader_Public_set_Void_String_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_HttpMessageHandler_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_LogHeaders_Private_Void_String_HttpHeaders_HttpHeaders_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_LogBody_Private_Task_String_HttpContent_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_SendAsync_Protected_Virtual_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_HandleRedirect_Private_Boolean_HttpResponseMessage_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Boolean_IDisposable_PDM_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0;

		// Token: 0x0200005B RID: 91
		[Flags]
		public enum LogEventType
		{
			// Token: 0x0400023D RID: 573
			None = 0,
			// Token: 0x0400023E RID: 574
			RequestUri = 1,
			// Token: 0x0400023F RID: 575
			RequestHeaders = 2,
			// Token: 0x04000240 RID: 576
			RequestBody = 4,
			// Token: 0x04000241 RID: 577
			ResponseStatus = 8,
			// Token: 0x04000242 RID: 578
			ResponseHeaders = 16,
			// Token: 0x04000243 RID: 579
			ResponseBody = 32,
			// Token: 0x04000244 RID: 580
			ResponseAbnormal = 64
		}

		// Token: 0x0200005C RID: 92
		[ObfuscatedName("Google.Apis.Http.ConfigurableMessageHandler+<LogBody>d__62")]
		public sealed class _LogBody_d__62 : ValueType
		{
			// Token: 0x0600036C RID: 876 RVA: 0x000102D4 File Offset: 0x0000E4D4
			// Note: this type is marked as 'beforefieldinit'.
			static _LogBody_d__62()
			{
				Il2CppClassPointerStore<ConfigurableMessageHandler._LogBody_d__62>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, "<LogBody>d__62");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurableMessageHandler._LogBody_d__62>.NativeClassPtr);
				ConfigurableMessageHandler._LogBody_d__62.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler._LogBody_d__62>.NativeClassPtr, "<>1__state");
				ConfigurableMessageHandler._LogBody_d__62.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler._LogBody_d__62>.NativeClassPtr, "<>t__builder");
				ConfigurableMessageHandler._LogBody_d__62.NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler._LogBody_d__62>.NativeClassPtr, "content");
				ConfigurableMessageHandler._LogBody_d__62.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler._LogBody_d__62>.NativeClassPtr, "<>4__this");
				ConfigurableMessageHandler._LogBody_d__62.NativeFieldInfoPtr_fmtText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler._LogBody_d__62>.NativeClassPtr, "fmtText");
				ConfigurableMessageHandler._LogBody_d__62.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler._LogBody_d__62>.NativeClassPtr, "<>u__1");
				ConfigurableMessageHandler._LogBody_d__62.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableMessageHandler._LogBody_d__62>.NativeClassPtr, 100663595);
				ConfigurableMessageHandler._LogBody_d__62.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableMessageHandler._LogBody_d__62>.NativeClassPtr, 100663596);
			}

			// Token: 0x0600036D RID: 877 RVA: 0x000103A0 File Offset: 0x0000E5A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211572, XrefRangeEnd = 1211607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableMessageHandler._LogBody_d__62.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600036E RID: 878 RVA: 0x000103D8 File Offset: 0x0000E5D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211607, XrefRangeEnd = 1211611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableMessageHandler._LogBody_d__62.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600036F RID: 879 RVA: 0x00003823 File Offset: 0x00001A23
			public _LogBody_d__62(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000370 RID: 880 RVA: 0x0000382C File Offset: 0x00001A2C
			public _LogBody_d__62()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigurableMessageHandler._LogBody_d__62>.NativeClassPtr))
			{
			}

			// Token: 0x17000108 RID: 264
			// (get) Token: 0x06000371 RID: 881 RVA: 0x00010420 File Offset: 0x0000E620
			// (set) Token: 0x06000372 RID: 882 RVA: 0x0000383E File Offset: 0x00001A3E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._LogBody_d__62.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._LogBody_d__62.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000109 RID: 265
			// (get) Token: 0x06000373 RID: 883 RVA: 0x00010448 File Offset: 0x0000E648
			// (set) Token: 0x06000374 RID: 884 RVA: 0x00003859 File Offset: 0x00001A59
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._LogBody_d__62.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._LogBody_d__62.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700010A RID: 266
			// (get) Token: 0x06000375 RID: 885 RVA: 0x00010478 File Offset: 0x0000E678
			// (set) Token: 0x06000376 RID: 886 RVA: 0x00003887 File Offset: 0x00001A87
			public unsafe HttpContent content
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._LogBody_d__62.NativeFieldInfoPtr_content);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpContent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._LogBody_d__62.NativeFieldInfoPtr_content), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700010B RID: 267
			// (get) Token: 0x06000377 RID: 887 RVA: 0x000104A8 File Offset: 0x0000E6A8
			// (set) Token: 0x06000378 RID: 888 RVA: 0x000038A6 File Offset: 0x00001AA6
			public unsafe ConfigurableMessageHandler __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._LogBody_d__62.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurableMessageHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._LogBody_d__62.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700010C RID: 268
			// (get) Token: 0x06000379 RID: 889 RVA: 0x000104D8 File Offset: 0x0000E6D8
			// (set) Token: 0x0600037A RID: 890 RVA: 0x000038C5 File Offset: 0x00001AC5
			public unsafe string fmtText
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._LogBody_d__62.NativeFieldInfoPtr_fmtText);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._LogBody_d__62.NativeFieldInfoPtr_fmtText), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700010D RID: 269
			// (get) Token: 0x0600037B RID: 891 RVA: 0x00010500 File Offset: 0x0000E700
			// (set) Token: 0x0600037C RID: 892 RVA: 0x000038E4 File Offset: 0x00001AE4
			public ConfiguredTaskAwaitable<Il2CppStructArray<byte>>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._LogBody_d__62.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<Il2CppStructArray<byte>>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Il2CppStructArray<byte>>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._LogBody_d__62.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Il2CppStructArray<byte>>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000245 RID: 581
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000246 RID: 582
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000247 RID: 583
			private static readonly IntPtr NativeFieldInfoPtr_content;

			// Token: 0x04000248 RID: 584
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000249 RID: 585
			private static readonly IntPtr NativeFieldInfoPtr_fmtText;

			// Token: 0x0400024A RID: 586
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400024B RID: 587
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400024C RID: 588
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200005D RID: 93
		[ObfuscatedName("Google.Apis.Http.ConfigurableMessageHandler+<SendAsync>d__63")]
		public sealed class _SendAsync_d__63 : ValueType
		{
			// Token: 0x0600037D RID: 893 RVA: 0x00010530 File Offset: 0x0000E730
			// Note: this type is marked as 'beforefieldinit'.
			static _SendAsync_d__63()
			{
				Il2CppClassPointerStore<ConfigurableMessageHandler._SendAsync_d__63>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigurableMessageHandler>.NativeClassPtr, "<SendAsync>d__63");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurableMessageHandler._SendAsync_d__63>.NativeClassPtr);
				ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler._SendAsync_d__63>.NativeClassPtr, "<>1__state");
				ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler._SendAsync_d__63>.NativeClassPtr, "<>t__builder");
				ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler._SendAsync_d__63>.NativeClassPtr, "<>4__this");
				ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler._SendAsync_d__63>.NativeClassPtr, "request");
				ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler._SendAsync_d__63>.NativeClassPtr, "cancellationToken");
				ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr__loggable_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler._SendAsync_d__63>.NativeClassPtr, "<loggable>5__2");
				ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr__loggingRequestId_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler._SendAsync_d__63>.NativeClassPtr, "<loggingRequestId>5__3");
				ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr__triesRemaining_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler._SendAsync_d__63>.NativeClassPtr, "<triesRemaining>5__4");
				ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr__redirectRemaining_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler._SendAsync_d__63>.NativeClassPtr, "<redirectRemaining>5__5");
				ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr__lastException_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler._SendAsync_d__63>.NativeClassPtr, "<lastException>5__6");
				ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr__response_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler._SendAsync_d__63>.NativeClassPtr, "<response>5__7");
				ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr___7__wrap7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler._SendAsync_d__63>.NativeClassPtr, "<>7__wrap7");
				ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler._SendAsync_d__63>.NativeClassPtr, "<>u__1");
				ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler._SendAsync_d__63>.NativeClassPtr, "<>u__2");
				ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr___7__wrap8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler._SendAsync_d__63>.NativeClassPtr, "<>7__wrap8");
				ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr___7__wrap9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler._SendAsync_d__63>.NativeClassPtr, "<>7__wrap9");
				ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler._SendAsync_d__63>.NativeClassPtr, "<>u__3");
				ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr___7__wrap10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler._SendAsync_d__63>.NativeClassPtr, "<>7__wrap10");
				ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr___7__wrap11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableMessageHandler._SendAsync_d__63>.NativeClassPtr, "<>7__wrap11");
				ConfigurableMessageHandler._SendAsync_d__63.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableMessageHandler._SendAsync_d__63>.NativeClassPtr, 100663597);
				ConfigurableMessageHandler._SendAsync_d__63.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableMessageHandler._SendAsync_d__63>.NativeClassPtr, 100663598);
			}

			// Token: 0x0600037E RID: 894 RVA: 0x00010700 File Offset: 0x0000E900
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211611, XrefRangeEnd = 1212041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableMessageHandler._SendAsync_d__63.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600037F RID: 895 RVA: 0x00010738 File Offset: 0x0000E938
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212041, XrefRangeEnd = 1212047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableMessageHandler._SendAsync_d__63.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000380 RID: 896 RVA: 0x00003912 File Offset: 0x00001B12
			public _SendAsync_d__63(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000381 RID: 897 RVA: 0x0000391B File Offset: 0x00001B1B
			public _SendAsync_d__63()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigurableMessageHandler._SendAsync_d__63>.NativeClassPtr))
			{
			}

			// Token: 0x1700010E RID: 270
			// (get) Token: 0x06000382 RID: 898 RVA: 0x00010780 File Offset: 0x0000E980
			// (set) Token: 0x06000383 RID: 899 RVA: 0x0000392D File Offset: 0x00001B2D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700010F RID: 271
			// (get) Token: 0x06000384 RID: 900 RVA: 0x000107A8 File Offset: 0x0000E9A8
			// (set) Token: 0x06000385 RID: 901 RVA: 0x00003948 File Offset: 0x00001B48
			public AsyncTaskMethodBuilder<HttpResponseMessage> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<HttpResponseMessage>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<HttpResponseMessage>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<HttpResponseMessage>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000110 RID: 272
			// (get) Token: 0x06000386 RID: 902 RVA: 0x000107D8 File Offset: 0x0000E9D8
			// (set) Token: 0x06000387 RID: 903 RVA: 0x00003976 File Offset: 0x00001B76
			public unsafe ConfigurableMessageHandler __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurableMessageHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000111 RID: 273
			// (get) Token: 0x06000388 RID: 904 RVA: 0x00010808 File Offset: 0x0000EA08
			// (set) Token: 0x06000389 RID: 905 RVA: 0x00003995 File Offset: 0x00001B95
			public unsafe HttpRequestMessage request
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr_request);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpRequestMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000112 RID: 274
			// (get) Token: 0x0600038A RID: 906 RVA: 0x00010838 File Offset: 0x0000EA38
			// (set) Token: 0x0600038B RID: 907 RVA: 0x000039B4 File Offset: 0x00001BB4
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000113 RID: 275
			// (get) Token: 0x0600038C RID: 908 RVA: 0x00010868 File Offset: 0x0000EA68
			// (set) Token: 0x0600038D RID: 909 RVA: 0x000039E2 File Offset: 0x00001BE2
			public unsafe bool _loggable_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr__loggable_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr__loggable_5__2)) = value;
				}
			}

			// Token: 0x17000114 RID: 276
			// (get) Token: 0x0600038E RID: 910 RVA: 0x00010890 File Offset: 0x0000EA90
			// (set) Token: 0x0600038F RID: 911 RVA: 0x000039FD File Offset: 0x00001BFD
			public unsafe string _loggingRequestId_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr__loggingRequestId_5__3);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr__loggingRequestId_5__3), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000115 RID: 277
			// (get) Token: 0x06000390 RID: 912 RVA: 0x000108B8 File Offset: 0x0000EAB8
			// (set) Token: 0x06000391 RID: 913 RVA: 0x00003A1C File Offset: 0x00001C1C
			public unsafe int _triesRemaining_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr__triesRemaining_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr__triesRemaining_5__4)) = value;
				}
			}

			// Token: 0x17000116 RID: 278
			// (get) Token: 0x06000392 RID: 914 RVA: 0x000108E0 File Offset: 0x0000EAE0
			// (set) Token: 0x06000393 RID: 915 RVA: 0x00003A37 File Offset: 0x00001C37
			public unsafe int _redirectRemaining_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr__redirectRemaining_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr__redirectRemaining_5__5)) = value;
				}
			}

			// Token: 0x17000117 RID: 279
			// (get) Token: 0x06000394 RID: 916 RVA: 0x00010908 File Offset: 0x0000EB08
			// (set) Token: 0x06000395 RID: 917 RVA: 0x00003A52 File Offset: 0x00001C52
			public unsafe Exception _lastException_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr__lastException_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr__lastException_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000118 RID: 280
			// (get) Token: 0x06000396 RID: 918 RVA: 0x00010938 File Offset: 0x0000EB38
			// (set) Token: 0x06000397 RID: 919 RVA: 0x00003A71 File Offset: 0x00001C71
			public unsafe HttpResponseMessage _response_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr__response_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpResponseMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr__response_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000119 RID: 281
			// (get) Token: 0x06000398 RID: 920 RVA: 0x00010968 File Offset: 0x0000EB68
			// (set) Token: 0x06000399 RID: 921 RVA: 0x00003A90 File Offset: 0x00001C90
			public List<IHttpExecuteInterceptor>.Enumerator __7__wrap7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr___7__wrap7);
					return new List<IHttpExecuteInterceptor>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<IHttpExecuteInterceptor>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr___7__wrap7), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<IHttpExecuteInterceptor>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700011A RID: 282
			// (get) Token: 0x0600039A RID: 922 RVA: 0x00010998 File Offset: 0x0000EB98
			// (set) Token: 0x0600039B RID: 923 RVA: 0x00003ABE File Offset: 0x00001CBE
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700011B RID: 283
			// (get) Token: 0x0600039C RID: 924 RVA: 0x000109C8 File Offset: 0x0000EBC8
			// (set) Token: 0x0600039D RID: 925 RVA: 0x00003AEC File Offset: 0x00001CEC
			public ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700011C RID: 284
			// (get) Token: 0x0600039E RID: 926 RVA: 0x000109F8 File Offset: 0x0000EBF8
			// (set) Token: 0x0600039F RID: 927 RVA: 0x00003B1A File Offset: 0x00001D1A
			public List<IHttpExceptionHandler>.Enumerator __7__wrap8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr___7__wrap8);
					return new List<IHttpExceptionHandler>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<IHttpExceptionHandler>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr___7__wrap8), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<IHttpExceptionHandler>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700011D RID: 285
			// (get) Token: 0x060003A0 RID: 928 RVA: 0x00010A28 File Offset: 0x0000EC28
			// (set) Token: 0x060003A1 RID: 929 RVA: 0x00003B48 File Offset: 0x00001D48
			public unsafe bool __7__wrap9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr___7__wrap9);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr___7__wrap9)) = value;
				}
			}

			// Token: 0x1700011E RID: 286
			// (get) Token: 0x060003A2 RID: 930 RVA: 0x00010A50 File Offset: 0x0000EC50
			// (set) Token: 0x060003A3 RID: 931 RVA: 0x00003B63 File Offset: 0x00001D63
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr___u__3);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr___u__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700011F RID: 287
			// (get) Token: 0x060003A4 RID: 932 RVA: 0x00010A80 File Offset: 0x0000EC80
			// (set) Token: 0x060003A5 RID: 933 RVA: 0x00003B91 File Offset: 0x00001D91
			public List<IHttpUnsuccessfulResponseHandler>.Enumerator __7__wrap10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr___7__wrap10);
					return new List<IHttpUnsuccessfulResponseHandler>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<IHttpUnsuccessfulResponseHandler>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr___7__wrap10), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<IHttpUnsuccessfulResponseHandler>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000120 RID: 288
			// (get) Token: 0x060003A6 RID: 934 RVA: 0x00010AB0 File Offset: 0x0000ECB0
			// (set) Token: 0x060003A7 RID: 935 RVA: 0x00003BBF File Offset: 0x00001DBF
			public unsafe bool __7__wrap11
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr___7__wrap11);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableMessageHandler._SendAsync_d__63.NativeFieldInfoPtr___7__wrap11)) = value;
				}
			}

			// Token: 0x0400024D RID: 589
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400024E RID: 590
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400024F RID: 591
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000250 RID: 592
			private static readonly IntPtr NativeFieldInfoPtr_request;

			// Token: 0x04000251 RID: 593
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04000252 RID: 594
			private static readonly IntPtr NativeFieldInfoPtr__loggable_5__2;

			// Token: 0x04000253 RID: 595
			private static readonly IntPtr NativeFieldInfoPtr__loggingRequestId_5__3;

			// Token: 0x04000254 RID: 596
			private static readonly IntPtr NativeFieldInfoPtr__triesRemaining_5__4;

			// Token: 0x04000255 RID: 597
			private static readonly IntPtr NativeFieldInfoPtr__redirectRemaining_5__5;

			// Token: 0x04000256 RID: 598
			private static readonly IntPtr NativeFieldInfoPtr__lastException_5__6;

			// Token: 0x04000257 RID: 599
			private static readonly IntPtr NativeFieldInfoPtr__response_5__7;

			// Token: 0x04000258 RID: 600
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap7;

			// Token: 0x04000259 RID: 601
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400025A RID: 602
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400025B RID: 603
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap8;

			// Token: 0x0400025C RID: 604
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap9;

			// Token: 0x0400025D RID: 605
			private static readonly IntPtr NativeFieldInfoPtr___u__3;

			// Token: 0x0400025E RID: 606
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap10;

			// Token: 0x0400025F RID: 607
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap11;

			// Token: 0x04000260 RID: 608
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000261 RID: 609
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
