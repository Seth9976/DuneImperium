using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Interface;
using Il2CppSystem.Collections;
using Il2CppSystem.IO;
using Il2CppSystem.Net.Security;
using Il2CppSystem.Security.Authentication.ExtendedProtection;
using Il2CppSystem.Security.Cryptography.X509Certificates;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net
{
	// Token: 0x020001FA RID: 506
	public sealed class HttpListener : Object
	{
		// Token: 0x06001F92 RID: 8082 RVA: 0x00096A44 File Offset: 0x00094C44
		// Note: this type is marked as 'beforefieldinit'.
		static HttpListener()
		{
			Il2CppClassPointerStore<HttpListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HttpListener");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpListener>.NativeClassPtr);
			HttpListener.NativeFieldInfoPtr_tlsProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, "tlsProvider");
			HttpListener.NativeFieldInfoPtr_tlsSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, "tlsSettings");
			HttpListener.NativeFieldInfoPtr_certificate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, "certificate");
			HttpListener.NativeFieldInfoPtr_auth_schemes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, "auth_schemes");
			HttpListener.NativeFieldInfoPtr_prefixes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, "prefixes");
			HttpListener.NativeFieldInfoPtr_auth_selector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, "auth_selector");
			HttpListener.NativeFieldInfoPtr_realm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, "realm");
			HttpListener.NativeFieldInfoPtr_ignore_write_exceptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, "ignore_write_exceptions");
			HttpListener.NativeFieldInfoPtr_listening = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, "listening");
			HttpListener.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, "disposed");
			HttpListener.NativeFieldInfoPtr__internalLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, "_internalLock");
			HttpListener.NativeFieldInfoPtr_registry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, "registry");
			HttpListener.NativeFieldInfoPtr_ctx_queue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, "ctx_queue");
			HttpListener.NativeFieldInfoPtr_wait_queue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, "wait_queue");
			HttpListener.NativeFieldInfoPtr_connections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, "connections");
			HttpListener.NativeFieldInfoPtr_defaultServiceNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, "defaultServiceNames");
			HttpListener.NativeFieldInfoPtr_extendedProtectionPolicy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, "extendedProtectionPolicy");
			HttpListener.NativeMethodInfoPtr_LoadCertificateAndKey_Internal_X509Certificate_IPAddress_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, 100668078);
			HttpListener.NativeMethodInfoPtr_CreateSslStream_Internal_SslStream_Stream_Boolean_RemoteCertificateValidationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, 100668079);
			HttpListener.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, 100668080);
			HttpListener.NativeMethodInfoPtr_get_AuthenticationSchemes_Public_get_AuthenticationSchemes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, 100668081);
			HttpListener.NativeMethodInfoPtr_get_AuthenticationSchemeSelectorDelegate_Public_get_AuthenticationSchemeSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, 100668082);
			HttpListener.NativeMethodInfoPtr_get_IgnoreWriteExceptions_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, 100668083);
			HttpListener.NativeMethodInfoPtr_get_IsListening_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, 100668084);
			HttpListener.NativeMethodInfoPtr_get_Prefixes_Public_get_HttpListenerPrefixCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, 100668085);
			HttpListener.NativeMethodInfoPtr_get_Realm_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, 100668086);
			HttpListener.NativeMethodInfoPtr_Close_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, 100668087);
			HttpListener.NativeMethodInfoPtr_Cleanup_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, 100668088);
			HttpListener.NativeMethodInfoPtr_BeginGetContext_Public_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, 100668089);
			HttpListener.NativeMethodInfoPtr_EndGetContext_Public_HttpListenerContext_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, 100668090);
			HttpListener.NativeMethodInfoPtr_SelectAuthenticationScheme_Internal_AuthenticationSchemes_HttpListenerContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, 100668091);
			HttpListener.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, 100668092);
			HttpListener.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, 100668093);
			HttpListener.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, 100668094);
			HttpListener.NativeMethodInfoPtr_GetContextAsync_Public_Task_1_HttpListenerContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, 100668095);
			HttpListener.NativeMethodInfoPtr_CheckDisposed_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, 100668096);
			HttpListener.NativeMethodInfoPtr_GetContextFromQueue_Private_HttpListenerContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, 100668097);
			HttpListener.NativeMethodInfoPtr_RegisterContext_Internal_Void_HttpListenerContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, 100668098);
			HttpListener.NativeMethodInfoPtr_UnregisterContext_Internal_Void_HttpListenerContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, 100668099);
			HttpListener.NativeMethodInfoPtr_AddConnection_Internal_Void_HttpConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, 100668100);
			HttpListener.NativeMethodInfoPtr_RemoveConnection_Internal_Void_HttpConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListener>.NativeClassPtr, 100668101);
		}

		// Token: 0x06001F93 RID: 8083 RVA: 0x00096DA8 File Offset: 0x00094FA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 480298, RefRangeEnd = 480299, XrefRangeStart = 480246, XrefRangeEnd = 480298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate LoadCertificateAndKey(IPAddress addr, int port)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(addr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListener.NativeMethodInfoPtr_LoadCertificateAndKey_Internal_X509Certificate_IPAddress_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
		}

		// Token: 0x06001F94 RID: 8084 RVA: 0x00096E08 File Offset: 0x00095008
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 480313, RefRangeEnd = 480314, XrefRangeStart = 480299, XrefRangeEnd = 480313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SslStream CreateSslStream(Stream innerStream, bool ownsStream, RemoteCertificateValidationCallback callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(innerStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ownsStream;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListener.NativeMethodInfoPtr_CreateSslStream_Internal_SslStream_Stream_Boolean_RemoteCertificateValidationCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SslStream>(intPtr3) : null;
		}

		// Token: 0x06001F95 RID: 8085 RVA: 0x00096E78 File Offset: 0x00095078
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 480362, RefRangeEnd = 480365, XrefRangeStart = 480314, XrefRangeEnd = 480362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpListener()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpListener>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListener.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06001F96 RID: 8086 RVA: 0x00096EB4 File Offset: 0x000950B4
		public unsafe AuthenticationSchemes AuthenticationSchemes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListener.NativeMethodInfoPtr_get_AuthenticationSchemes_Public_get_AuthenticationSchemes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06001F97 RID: 8087 RVA: 0x00096EF0 File Offset: 0x000950F0
		public unsafe AuthenticationSchemeSelector AuthenticationSchemeSelectorDelegate
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListener.NativeMethodInfoPtr_get_AuthenticationSchemeSelectorDelegate_Public_get_AuthenticationSchemeSelector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AuthenticationSchemeSelector>(intPtr3) : null;
			}
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06001F98 RID: 8088 RVA: 0x00096F30 File Offset: 0x00095130
		public unsafe bool IgnoreWriteExceptions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListener.NativeMethodInfoPtr_get_IgnoreWriteExceptions_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06001F99 RID: 8089 RVA: 0x00096F6C File Offset: 0x0009516C
		public unsafe bool IsListening
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListener.NativeMethodInfoPtr_get_IsListening_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06001F9A RID: 8090 RVA: 0x00096FA8 File Offset: 0x000951A8
		public unsafe HttpListenerPrefixCollection Prefixes
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 480366, RefRangeEnd = 480369, XrefRangeStart = 480365, XrefRangeEnd = 480366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListener.NativeMethodInfoPtr_get_Prefixes_Public_get_HttpListenerPrefixCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpListenerPrefixCollection>(intPtr3) : null;
			}
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06001F9B RID: 8091 RVA: 0x00096FE8 File Offset: 0x000951E8
		public unsafe string Realm
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListener.NativeMethodInfoPtr_get_Realm_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001F9C RID: 8092 RVA: 0x00097020 File Offset: 0x00095220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480369, XrefRangeEnd = 480375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool force)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref force;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListener.NativeMethodInfoPtr_Close_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F9D RID: 8093 RVA: 0x00097060 File Offset: 0x00095260
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 480445, RefRangeEnd = 480448, XrefRangeStart = 480375, XrefRangeEnd = 480445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup(bool close_existing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref close_existing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListener.NativeMethodInfoPtr_Cleanup_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F9E RID: 8094 RVA: 0x000970A0 File Offset: 0x000952A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 480467, RefRangeEnd = 480468, XrefRangeStart = 480448, XrefRangeEnd = 480467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginGetContext(AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListener.NativeMethodInfoPtr_BeginGetContext_Public_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06001F9F RID: 8095 RVA: 0x00097104 File Offset: 0x00095304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480468, XrefRangeEnd = 480491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpListenerContext EndGetContext(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListener.NativeMethodInfoPtr_EndGetContext_Public_HttpListenerContext_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpListenerContext>(intPtr3) : null;
			}
		}

		// Token: 0x06001FA0 RID: 8096 RVA: 0x00097154 File Offset: 0x00095354
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 480491, RefRangeEnd = 480492, XrefRangeStart = 480491, XrefRangeEnd = 480491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AuthenticationSchemes SelectAuthenticationScheme(HttpListenerContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListener.NativeMethodInfoPtr_SelectAuthenticationScheme_Internal_AuthenticationSchemes_HttpListenerContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001FA1 RID: 8097 RVA: 0x000971A4 File Offset: 0x000953A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 480497, RefRangeEnd = 480500, XrefRangeStart = 480492, XrefRangeEnd = 480497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListener.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FA2 RID: 8098 RVA: 0x000971D8 File Offset: 0x000953D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480500, XrefRangeEnd = 480507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListener.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FA3 RID: 8099 RVA: 0x0009720C File Offset: 0x0009540C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480507, XrefRangeEnd = 480513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListener.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FA4 RID: 8100 RVA: 0x00097240 File Offset: 0x00095440
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 480531, RefRangeEnd = 480532, XrefRangeStart = 480513, XrefRangeEnd = 480531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<HttpListenerContext> GetContextAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListener.NativeMethodInfoPtr_GetContextAsync_Public_Task_1_HttpListenerContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<HttpListenerContext>>(intPtr3) : null;
		}

		// Token: 0x06001FA5 RID: 8101 RVA: 0x00097280 File Offset: 0x00095480
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 480532, RefRangeEnd = 480547, XrefRangeStart = 480532, XrefRangeEnd = 480532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckDisposed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListener.NativeMethodInfoPtr_CheckDisposed_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FA6 RID: 8102 RVA: 0x000972B4 File Offset: 0x000954B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480547, XrefRangeEnd = 480550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpListenerContext GetContextFromQueue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListener.NativeMethodInfoPtr_GetContextFromQueue_Private_HttpListenerContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpListenerContext>(intPtr3) : null;
		}

		// Token: 0x06001FA7 RID: 8103 RVA: 0x000972F4 File Offset: 0x000954F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480550, XrefRangeEnd = 480566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterContext(HttpListenerContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListener.NativeMethodInfoPtr_RegisterContext_Internal_Void_HttpListenerContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FA8 RID: 8104 RVA: 0x00097338 File Offset: 0x00095538
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 480574, RefRangeEnd = 480578, XrefRangeStart = 480566, XrefRangeEnd = 480574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterContext(HttpListenerContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListener.NativeMethodInfoPtr_UnregisterContext_Internal_Void_HttpListenerContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FA9 RID: 8105 RVA: 0x0009737C File Offset: 0x0009557C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480578, XrefRangeEnd = 480579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddConnection(HttpConnection cnc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cnc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListener.NativeMethodInfoPtr_AddConnection_Internal_Void_HttpConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FAA RID: 8106 RVA: 0x000973C0 File Offset: 0x000955C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480579, XrefRangeEnd = 480580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveConnection(HttpConnection cnc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cnc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListener.NativeMethodInfoPtr_RemoveConnection_Internal_Void_HttpConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FAB RID: 8107 RVA: 0x0000D727 File Offset: 0x0000B927
		public HttpListener(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06001FAC RID: 8108 RVA: 0x00097404 File Offset: 0x00095604
		// (set) Token: 0x06001FAD RID: 8109 RVA: 0x0000D730 File Offset: 0x0000B930
		public unsafe MonoTlsProvider tlsProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListener.NativeFieldInfoPtr_tlsProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTlsProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListener.NativeFieldInfoPtr_tlsProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06001FAE RID: 8110 RVA: 0x00097434 File Offset: 0x00095634
		// (set) Token: 0x06001FAF RID: 8111 RVA: 0x0000D74F File Offset: 0x0000B94F
		public unsafe MonoTlsSettings tlsSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListener.NativeFieldInfoPtr_tlsSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListener.NativeFieldInfoPtr_tlsSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06001FB0 RID: 8112 RVA: 0x00097464 File Offset: 0x00095664
		// (set) Token: 0x06001FB1 RID: 8113 RVA: 0x0000D76E File Offset: 0x0000B96E
		public unsafe X509Certificate certificate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListener.NativeFieldInfoPtr_certificate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListener.NativeFieldInfoPtr_certificate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06001FB2 RID: 8114 RVA: 0x00097494 File Offset: 0x00095694
		// (set) Token: 0x06001FB3 RID: 8115 RVA: 0x0000D78D File Offset: 0x0000B98D
		public unsafe AuthenticationSchemes auth_schemes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListener.NativeFieldInfoPtr_auth_schemes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListener.NativeFieldInfoPtr_auth_schemes)) = value;
			}
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06001FB4 RID: 8116 RVA: 0x000974BC File Offset: 0x000956BC
		// (set) Token: 0x06001FB5 RID: 8117 RVA: 0x0000D7A8 File Offset: 0x0000B9A8
		public unsafe HttpListenerPrefixCollection prefixes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListener.NativeFieldInfoPtr_prefixes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpListenerPrefixCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListener.NativeFieldInfoPtr_prefixes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06001FB6 RID: 8118 RVA: 0x000974EC File Offset: 0x000956EC
		// (set) Token: 0x06001FB7 RID: 8119 RVA: 0x0000D7C7 File Offset: 0x0000B9C7
		public unsafe AuthenticationSchemeSelector auth_selector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListener.NativeFieldInfoPtr_auth_selector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AuthenticationSchemeSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListener.NativeFieldInfoPtr_auth_selector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x06001FB8 RID: 8120 RVA: 0x0009751C File Offset: 0x0009571C
		// (set) Token: 0x06001FB9 RID: 8121 RVA: 0x0000D7E6 File Offset: 0x0000B9E6
		public unsafe string realm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListener.NativeFieldInfoPtr_realm);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListener.NativeFieldInfoPtr_realm), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06001FBA RID: 8122 RVA: 0x00097544 File Offset: 0x00095744
		// (set) Token: 0x06001FBB RID: 8123 RVA: 0x0000D805 File Offset: 0x0000BA05
		public unsafe bool ignore_write_exceptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListener.NativeFieldInfoPtr_ignore_write_exceptions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListener.NativeFieldInfoPtr_ignore_write_exceptions)) = value;
			}
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06001FBC RID: 8124 RVA: 0x0009756C File Offset: 0x0009576C
		// (set) Token: 0x06001FBD RID: 8125 RVA: 0x0000D820 File Offset: 0x0000BA20
		public unsafe bool listening
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListener.NativeFieldInfoPtr_listening);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListener.NativeFieldInfoPtr_listening)) = value;
			}
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06001FBE RID: 8126 RVA: 0x00097594 File Offset: 0x00095794
		// (set) Token: 0x06001FBF RID: 8127 RVA: 0x0000D83B File Offset: 0x0000BA3B
		public unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListener.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListener.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06001FC0 RID: 8128 RVA: 0x000975BC File Offset: 0x000957BC
		// (set) Token: 0x06001FC1 RID: 8129 RVA: 0x0000D856 File Offset: 0x0000BA56
		public unsafe Object _internalLock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListener.NativeFieldInfoPtr__internalLock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListener.NativeFieldInfoPtr__internalLock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06001FC2 RID: 8130 RVA: 0x000975EC File Offset: 0x000957EC
		// (set) Token: 0x06001FC3 RID: 8131 RVA: 0x0000D875 File Offset: 0x0000BA75
		public unsafe Hashtable registry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListener.NativeFieldInfoPtr_registry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListener.NativeFieldInfoPtr_registry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06001FC4 RID: 8132 RVA: 0x0009761C File Offset: 0x0009581C
		// (set) Token: 0x06001FC5 RID: 8133 RVA: 0x0000D894 File Offset: 0x0000BA94
		public unsafe ArrayList ctx_queue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListener.NativeFieldInfoPtr_ctx_queue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListener.NativeFieldInfoPtr_ctx_queue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06001FC6 RID: 8134 RVA: 0x0009764C File Offset: 0x0009584C
		// (set) Token: 0x06001FC7 RID: 8135 RVA: 0x0000D8B3 File Offset: 0x0000BAB3
		public unsafe ArrayList wait_queue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListener.NativeFieldInfoPtr_wait_queue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListener.NativeFieldInfoPtr_wait_queue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06001FC8 RID: 8136 RVA: 0x0009767C File Offset: 0x0009587C
		// (set) Token: 0x06001FC9 RID: 8137 RVA: 0x0000D8D2 File Offset: 0x0000BAD2
		public unsafe Hashtable connections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListener.NativeFieldInfoPtr_connections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListener.NativeFieldInfoPtr_connections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06001FCA RID: 8138 RVA: 0x000976AC File Offset: 0x000958AC
		// (set) Token: 0x06001FCB RID: 8139 RVA: 0x0000D8F1 File Offset: 0x0000BAF1
		public unsafe ServiceNameStore defaultServiceNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListener.NativeFieldInfoPtr_defaultServiceNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServiceNameStore>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListener.NativeFieldInfoPtr_defaultServiceNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06001FCC RID: 8140 RVA: 0x000976DC File Offset: 0x000958DC
		// (set) Token: 0x06001FCD RID: 8141 RVA: 0x0000D910 File Offset: 0x0000BB10
		public unsafe ExtendedProtectionPolicy extendedProtectionPolicy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListener.NativeFieldInfoPtr_extendedProtectionPolicy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExtendedProtectionPolicy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListener.NativeFieldInfoPtr_extendedProtectionPolicy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040018D9 RID: 6361
		private static readonly IntPtr NativeFieldInfoPtr_tlsProvider;

		// Token: 0x040018DA RID: 6362
		private static readonly IntPtr NativeFieldInfoPtr_tlsSettings;

		// Token: 0x040018DB RID: 6363
		private static readonly IntPtr NativeFieldInfoPtr_certificate;

		// Token: 0x040018DC RID: 6364
		private static readonly IntPtr NativeFieldInfoPtr_auth_schemes;

		// Token: 0x040018DD RID: 6365
		private static readonly IntPtr NativeFieldInfoPtr_prefixes;

		// Token: 0x040018DE RID: 6366
		private static readonly IntPtr NativeFieldInfoPtr_auth_selector;

		// Token: 0x040018DF RID: 6367
		private static readonly IntPtr NativeFieldInfoPtr_realm;

		// Token: 0x040018E0 RID: 6368
		private static readonly IntPtr NativeFieldInfoPtr_ignore_write_exceptions;

		// Token: 0x040018E1 RID: 6369
		private static readonly IntPtr NativeFieldInfoPtr_listening;

		// Token: 0x040018E2 RID: 6370
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x040018E3 RID: 6371
		private static readonly IntPtr NativeFieldInfoPtr__internalLock;

		// Token: 0x040018E4 RID: 6372
		private static readonly IntPtr NativeFieldInfoPtr_registry;

		// Token: 0x040018E5 RID: 6373
		private static readonly IntPtr NativeFieldInfoPtr_ctx_queue;

		// Token: 0x040018E6 RID: 6374
		private static readonly IntPtr NativeFieldInfoPtr_wait_queue;

		// Token: 0x040018E7 RID: 6375
		private static readonly IntPtr NativeFieldInfoPtr_connections;

		// Token: 0x040018E8 RID: 6376
		private static readonly IntPtr NativeFieldInfoPtr_defaultServiceNames;

		// Token: 0x040018E9 RID: 6377
		private static readonly IntPtr NativeFieldInfoPtr_extendedProtectionPolicy;

		// Token: 0x040018EA RID: 6378
		private static readonly IntPtr NativeMethodInfoPtr_LoadCertificateAndKey_Internal_X509Certificate_IPAddress_Int32_0;

		// Token: 0x040018EB RID: 6379
		private static readonly IntPtr NativeMethodInfoPtr_CreateSslStream_Internal_SslStream_Stream_Boolean_RemoteCertificateValidationCallback_0;

		// Token: 0x040018EC RID: 6380
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040018ED RID: 6381
		private static readonly IntPtr NativeMethodInfoPtr_get_AuthenticationSchemes_Public_get_AuthenticationSchemes_0;

		// Token: 0x040018EE RID: 6382
		private static readonly IntPtr NativeMethodInfoPtr_get_AuthenticationSchemeSelectorDelegate_Public_get_AuthenticationSchemeSelector_0;

		// Token: 0x040018EF RID: 6383
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreWriteExceptions_Public_get_Boolean_0;

		// Token: 0x040018F0 RID: 6384
		private static readonly IntPtr NativeMethodInfoPtr_get_IsListening_Public_get_Boolean_0;

		// Token: 0x040018F1 RID: 6385
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefixes_Public_get_HttpListenerPrefixCollection_0;

		// Token: 0x040018F2 RID: 6386
		private static readonly IntPtr NativeMethodInfoPtr_get_Realm_Public_get_String_0;

		// Token: 0x040018F3 RID: 6387
		private static readonly IntPtr NativeMethodInfoPtr_Close_Private_Void_Boolean_0;

		// Token: 0x040018F4 RID: 6388
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Private_Void_Boolean_0;

		// Token: 0x040018F5 RID: 6389
		private static readonly IntPtr NativeMethodInfoPtr_BeginGetContext_Public_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x040018F6 RID: 6390
		private static readonly IntPtr NativeMethodInfoPtr_EndGetContext_Public_HttpListenerContext_IAsyncResult_0;

		// Token: 0x040018F7 RID: 6391
		private static readonly IntPtr NativeMethodInfoPtr_SelectAuthenticationScheme_Internal_AuthenticationSchemes_HttpListenerContext_0;

		// Token: 0x040018F8 RID: 6392
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040018F9 RID: 6393
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x040018FA RID: 6394
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040018FB RID: 6395
		private static readonly IntPtr NativeMethodInfoPtr_GetContextAsync_Public_Task_1_HttpListenerContext_0;

		// Token: 0x040018FC RID: 6396
		private static readonly IntPtr NativeMethodInfoPtr_CheckDisposed_Internal_Void_0;

		// Token: 0x040018FD RID: 6397
		private static readonly IntPtr NativeMethodInfoPtr_GetContextFromQueue_Private_HttpListenerContext_0;

		// Token: 0x040018FE RID: 6398
		private static readonly IntPtr NativeMethodInfoPtr_RegisterContext_Internal_Void_HttpListenerContext_0;

		// Token: 0x040018FF RID: 6399
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterContext_Internal_Void_HttpListenerContext_0;

		// Token: 0x04001900 RID: 6400
		private static readonly IntPtr NativeMethodInfoPtr_AddConnection_Internal_Void_HttpConnection_0;

		// Token: 0x04001901 RID: 6401
		private static readonly IntPtr NativeMethodInfoPtr_RemoveConnection_Internal_Void_HttpConnection_0;
	}
}
