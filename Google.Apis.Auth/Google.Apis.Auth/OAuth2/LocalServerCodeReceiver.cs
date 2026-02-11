using System;
using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Logging;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.Specialized;
using Il2CppSystem.IO;
using Il2CppSystem.Net;
using Il2CppSystem.Net.Sockets;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Text;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
	// Token: 0x02000018 RID: 24
	public class LocalServerCodeReceiver : Object
	{
		// Token: 0x0600010D RID: 269 RVA: 0x0000AA18 File Offset: 0x00008C18
		// Note: this type is marked as 'beforefieldinit'.
		static LocalServerCodeReceiver()
		{
			Il2CppClassPointerStore<LocalServerCodeReceiver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2", "LocalServerCodeReceiver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalServerCodeReceiver>.NativeClassPtr);
			LocalServerCodeReceiver.NativeFieldInfoPtr_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver>.NativeClassPtr, "Logger");
			LocalServerCodeReceiver.NativeFieldInfoPtr_LoopbackCallbackPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver>.NativeClassPtr, "LoopbackCallbackPath");
			LocalServerCodeReceiver.NativeFieldInfoPtr_CallbackUriTemplateLocalhost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver>.NativeClassPtr, "CallbackUriTemplateLocalhost");
			LocalServerCodeReceiver.NativeFieldInfoPtr_CallbackUriTemplate127001 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver>.NativeClassPtr, "CallbackUriTemplate127001");
			LocalServerCodeReceiver.NativeFieldInfoPtr_DefaultClosePageResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver>.NativeClassPtr, "DefaultClosePageResponse");
			LocalServerCodeReceiver.NativeFieldInfoPtr_s_lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver>.NativeClassPtr, "s_lock");
			LocalServerCodeReceiver.NativeFieldInfoPtr_s_callbackUriTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver>.NativeClassPtr, "s_callbackUriTemplate");
			LocalServerCodeReceiver.NativeFieldInfoPtr_s_receivedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver>.NativeClassPtr, "s_receivedCallback");
			LocalServerCodeReceiver.NativeFieldInfoPtr__callbackUriTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver>.NativeClassPtr, "_callbackUriTemplate");
			LocalServerCodeReceiver.NativeFieldInfoPtr__closePageResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver>.NativeClassPtr, "_closePageResponse");
			LocalServerCodeReceiver.NativeFieldInfoPtr_redirectUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver>.NativeClassPtr, "redirectUri");
			LocalServerCodeReceiver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver>.NativeClassPtr, 100663535);
			LocalServerCodeReceiver.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver>.NativeClassPtr, 100663536);
			LocalServerCodeReceiver.NativeMethodInfoPtr_get_RedirectUri_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver>.NativeClassPtr, 100663537);
			LocalServerCodeReceiver.NativeMethodInfoPtr_ReceiveCodeAsync_Public_Virtual_Final_New_Task_1_AuthorizationCodeResponseUrl_AuthorizationCodeRequestUrl_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver>.NativeClassPtr, 100663538);
			LocalServerCodeReceiver.NativeMethodInfoPtr_GetRandomUnusedPort_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver>.NativeClassPtr, 100663539);
			LocalServerCodeReceiver.NativeMethodInfoPtr_StartListener_Private_HttpListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver>.NativeClassPtr, 100663540);
			LocalServerCodeReceiver.NativeMethodInfoPtr_GetResponseFromListener_Private_Task_1_AuthorizationCodeResponseUrl_HttpListener_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver>.NativeClassPtr, 100663541);
			LocalServerCodeReceiver.NativeMethodInfoPtr_OpenBrowser_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver>.NativeClassPtr, 100663542);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000ABC4 File Offset: 0x00008DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154821, XrefRangeEnd = 1154824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalServerCodeReceiver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalServerCodeReceiver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000AC00 File Offset: 0x00008E00
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1154887, RefRangeEnd = 1154890, XrefRangeStart = 1154824, XrefRangeEnd = 1154887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalServerCodeReceiver(string closePageResponse)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalServerCodeReceiver>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(closePageResponse);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000110 RID: 272 RVA: 0x0000AC4C File Offset: 0x00008E4C
		public unsafe virtual string RedirectUri
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154890, XrefRangeEnd = 1154900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.NativeMethodInfoPtr_get_RedirectUri_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000AC84 File Offset: 0x00008E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154900, XrefRangeEnd = 1154916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<AuthorizationCodeResponseUrl> ReceiveCodeAsync(AuthorizationCodeRequestUrl url, CancellationToken taskCancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(taskCancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.NativeMethodInfoPtr_ReceiveCodeAsync_Public_Virtual_Final_New_Task_1_AuthorizationCodeResponseUrl_AuthorizationCodeRequestUrl_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<AuthorizationCodeResponseUrl>>(intPtr3) : null;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1154931, RefRangeEnd = 1154935, XrefRangeStart = 1154916, XrefRangeEnd = 1154931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetRandomUnusedPort()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.NativeMethodInfoPtr_GetRandomUnusedPort_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000AD1C File Offset: 0x00008F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154935, XrefRangeEnd = 1154952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpListener StartListener()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.NativeMethodInfoPtr_StartListener_Private_HttpListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpListener>(intPtr3) : null;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000AD5C File Offset: 0x00008F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154952, XrefRangeEnd = 1154968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<AuthorizationCodeResponseUrl> GetResponseFromListener(HttpListener listener, CancellationToken ct)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ct));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.NativeMethodInfoPtr_GetResponseFromListener_Private_Task_1_AuthorizationCodeResponseUrl_HttpListener_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<AuthorizationCodeResponseUrl>>(intPtr3) : null;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000ADC4 File Offset: 0x00008FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154968, XrefRangeEnd = 1154969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OpenBrowser(string url)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.NativeMethodInfoPtr_OpenBrowser_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002767 File Offset: 0x00000967
		public LocalServerCodeReceiver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000117 RID: 279 RVA: 0x0000AE14 File Offset: 0x00009014
		// (set) Token: 0x06000118 RID: 280 RVA: 0x00002770 File Offset: 0x00000970
		public unsafe static ILogger Logger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LocalServerCodeReceiver.NativeFieldInfoPtr_Logger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalServerCodeReceiver.NativeFieldInfoPtr_Logger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000119 RID: 281 RVA: 0x0000AE3C File Offset: 0x0000903C
		// (set) Token: 0x0600011A RID: 282 RVA: 0x00002782 File Offset: 0x00000982
		public unsafe static string LoopbackCallbackPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LocalServerCodeReceiver.NativeFieldInfoPtr_LoopbackCallbackPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalServerCodeReceiver.NativeFieldInfoPtr_LoopbackCallbackPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600011B RID: 283 RVA: 0x0000AE5C File Offset: 0x0000905C
		// (set) Token: 0x0600011C RID: 284 RVA: 0x00002794 File Offset: 0x00000994
		public unsafe static string CallbackUriTemplateLocalhost
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LocalServerCodeReceiver.NativeFieldInfoPtr_CallbackUriTemplateLocalhost, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalServerCodeReceiver.NativeFieldInfoPtr_CallbackUriTemplateLocalhost, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600011D RID: 285 RVA: 0x0000AE7C File Offset: 0x0000907C
		// (set) Token: 0x0600011E RID: 286 RVA: 0x000027A6 File Offset: 0x000009A6
		public unsafe static string CallbackUriTemplate127001
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LocalServerCodeReceiver.NativeFieldInfoPtr_CallbackUriTemplate127001, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalServerCodeReceiver.NativeFieldInfoPtr_CallbackUriTemplate127001, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600011F RID: 287 RVA: 0x0000AE9C File Offset: 0x0000909C
		// (set) Token: 0x06000120 RID: 288 RVA: 0x000027B8 File Offset: 0x000009B8
		public unsafe static string DefaultClosePageResponse
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LocalServerCodeReceiver.NativeFieldInfoPtr_DefaultClosePageResponse, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalServerCodeReceiver.NativeFieldInfoPtr_DefaultClosePageResponse, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000121 RID: 289 RVA: 0x0000AEBC File Offset: 0x000090BC
		// (set) Token: 0x06000122 RID: 290 RVA: 0x000027CA File Offset: 0x000009CA
		public unsafe static Object s_lock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LocalServerCodeReceiver.NativeFieldInfoPtr_s_lock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalServerCodeReceiver.NativeFieldInfoPtr_s_lock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000123 RID: 291 RVA: 0x0000AEE4 File Offset: 0x000090E4
		// (set) Token: 0x06000124 RID: 292 RVA: 0x000027DC File Offset: 0x000009DC
		public unsafe static string s_callbackUriTemplate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LocalServerCodeReceiver.NativeFieldInfoPtr_s_callbackUriTemplate, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalServerCodeReceiver.NativeFieldInfoPtr_s_callbackUriTemplate, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000125 RID: 293 RVA: 0x0000AF04 File Offset: 0x00009104
		// (set) Token: 0x06000126 RID: 294 RVA: 0x000027EE File Offset: 0x000009EE
		public unsafe static bool s_receivedCallback
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(LocalServerCodeReceiver.NativeFieldInfoPtr_s_receivedCallback, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalServerCodeReceiver.NativeFieldInfoPtr_s_receivedCallback, (void*)(&value));
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000127 RID: 295 RVA: 0x0000AF20 File Offset: 0x00009120
		// (set) Token: 0x06000128 RID: 296 RVA: 0x000027FC File Offset: 0x000009FC
		public unsafe string _callbackUriTemplate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.NativeFieldInfoPtr__callbackUriTemplate);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.NativeFieldInfoPtr__callbackUriTemplate), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000129 RID: 297 RVA: 0x0000AF48 File Offset: 0x00009148
		// (set) Token: 0x0600012A RID: 298 RVA: 0x0000281B File Offset: 0x00000A1B
		public unsafe string _closePageResponse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.NativeFieldInfoPtr__closePageResponse);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.NativeFieldInfoPtr__closePageResponse), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600012B RID: 299 RVA: 0x0000AF70 File Offset: 0x00009170
		// (set) Token: 0x0600012C RID: 300 RVA: 0x0000283A File Offset: 0x00000A3A
		public unsafe string redirectUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.NativeFieldInfoPtr_redirectUri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.NativeFieldInfoPtr_redirectUri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeFieldInfoPtr_Logger;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeFieldInfoPtr_LoopbackCallbackPath;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeFieldInfoPtr_CallbackUriTemplateLocalhost;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeFieldInfoPtr_CallbackUriTemplate127001;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeFieldInfoPtr_DefaultClosePageResponse;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeFieldInfoPtr_s_lock;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeFieldInfoPtr_s_callbackUriTemplate;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeFieldInfoPtr_s_receivedCallback;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeFieldInfoPtr__callbackUriTemplate;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeFieldInfoPtr__closePageResponse;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeFieldInfoPtr_redirectUri;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_get_RedirectUri_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveCodeAsync_Public_Virtual_Final_New_Task_1_AuthorizationCodeResponseUrl_AuthorizationCodeRequestUrl_CancellationToken_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomUnusedPort_Private_Static_Int32_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_StartListener_Private_HttpListener_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_GetResponseFromListener_Private_Task_1_AuthorizationCodeResponseUrl_HttpListener_CancellationToken_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_OpenBrowser_Private_Boolean_String_0;

		// Token: 0x0200004C RID: 76
		public class LimitedLocalhostHttpServer : Object
		{
			// Token: 0x060004C0 RID: 1216 RVA: 0x000169CC File Offset: 0x00014BCC
			// Note: this type is marked as 'beforefieldinit'.
			static LimitedLocalhostHttpServer()
			{
				Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalServerCodeReceiver>.NativeClassPtr, "LimitedLocalhostHttpServer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer>.NativeClassPtr);
				LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeFieldInfoPtr_MaxRequestLineLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer>.NativeClassPtr, "MaxRequestLineLength");
				LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeFieldInfoPtr_MaxHeadersLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer>.NativeClassPtr, "MaxHeadersLength");
				LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeFieldInfoPtr_NetworkReadBufferSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer>.NativeClassPtr, "NetworkReadBufferSize");
				LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeFieldInfoPtr_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer>.NativeClassPtr, "Logger");
				LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeFieldInfoPtr__listener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer>.NativeClassPtr, "_listener");
				LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeFieldInfoPtr__cts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer>.NativeClassPtr, "_cts");
				LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeFieldInfoPtr__closePageResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer>.NativeClassPtr, "_closePageResponse");
				LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeFieldInfoPtr__Port_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer>.NativeClassPtr, "<Port>k__BackingField");
				LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeMethodInfoPtr_Start_Public_Static_LimitedLocalhostHttpServer_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer>.NativeClassPtr, 100663544);
				LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeMethodInfoPtr__ctor_Private_Void_TcpListener_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer>.NativeClassPtr, 100663545);
				LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeMethodInfoPtr_get_Port_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer>.NativeClassPtr, 100663546);
				LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeMethodInfoPtr_GetQueryParamsAsync_Public_Task_1_Dictionary_2_String_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer>.NativeClassPtr, 100663547);
				LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeMethodInfoPtr_GetQueryParamsFromClientAsync_Private_Task_1_Dictionary_2_String_String_TcpClient_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer>.NativeClassPtr, 100663548);
				LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeMethodInfoPtr_ReadRequestLine_Private_Task_1_String_Func_1_Task_1_Nullable_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer>.NativeClassPtr, 100663549);
				LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeMethodInfoPtr_ValidateAndGetRequestParams_Private_Dictionary_2_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer>.NativeClassPtr, 100663550);
				LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeMethodInfoPtr_WaitForAllHeaders_Private_Task_Func_1_Task_1_Nullable_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer>.NativeClassPtr, 100663551);
				LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeMethodInfoPtr_WriteResponse_Private_Task_NetworkStream_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer>.NativeClassPtr, 100663552);
				LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer>.NativeClassPtr, 100663553);
			}

			// Token: 0x060004C1 RID: 1217 RVA: 0x00016B60 File Offset: 0x00014D60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154451, XrefRangeEnd = 1154480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static LocalServerCodeReceiver.LimitedLocalhostHttpServer Start(string url, string closePageResponse)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(closePageResponse);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeMethodInfoPtr_Start_Public_Static_LimitedLocalhostHttpServer_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalServerCodeReceiver.LimitedLocalhostHttpServer>(intPtr3) : null;
			}

			// Token: 0x060004C2 RID: 1218 RVA: 0x00016BB8 File Offset: 0x00014DB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154480, XrefRangeEnd = 1154492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LimitedLocalhostHttpServer(TcpListener listener, string closePageResponse)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(closePageResponse);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeMethodInfoPtr__ctor_Private_Void_TcpListener_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170001C3 RID: 451
			// (get) Token: 0x060004C3 RID: 1219 RVA: 0x00016C18 File Offset: 0x00014E18
			public unsafe int Port
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeMethodInfoPtr_get_Port_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060004C4 RID: 1220 RVA: 0x00016C54 File Offset: 0x00014E54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154492, XrefRangeEnd = 1154507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Task<Dictionary<string, string>> GetQueryParamsAsync(CancellationToken cancellationToken = null)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeMethodInfoPtr_GetQueryParamsAsync_Public_Task_1_Dictionary_2_String_String_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Dictionary<string, string>>>(intPtr3) : null;
				}
			}

			// Token: 0x060004C5 RID: 1221 RVA: 0x00016CAC File Offset: 0x00014EAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154507, XrefRangeEnd = 1154523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Task<Dictionary<string, string>> GetQueryParamsFromClientAsync(TcpClient client, CancellationToken cancellationToken)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(client);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeMethodInfoPtr_GetQueryParamsFromClientAsync_Private_Task_1_Dictionary_2_String_String_TcpClient_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Dictionary<string, string>>>(intPtr3) : null;
			}

			// Token: 0x060004C6 RID: 1222 RVA: 0x00016D14 File Offset: 0x00014F14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154523, XrefRangeEnd = 1154537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Task<string> ReadRequestLine(Func<Task<Nullable<char>>> getChar)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(getChar);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeMethodInfoPtr_ReadRequestLine_Private_Task_1_String_Func_1_Task_1_Nullable_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<string>>(intPtr3) : null;
				}
			}

			// Token: 0x060004C7 RID: 1223 RVA: 0x00016D64 File Offset: 0x00014F64
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1154607, RefRangeEnd = 1154608, XrefRangeStart = 1154537, XrefRangeEnd = 1154607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Dictionary<string, string> ValidateAndGetRequestParams(string requestLine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(requestLine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeMethodInfoPtr_ValidateAndGetRequestParams_Private_Dictionary_2_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
				}
			}

			// Token: 0x060004C8 RID: 1224 RVA: 0x00016DB4 File Offset: 0x00014FB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154608, XrefRangeEnd = 1154618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Task WaitForAllHeaders(Func<Task<Nullable<char>>> getChar)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(getChar);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeMethodInfoPtr_WaitForAllHeaders_Private_Task_Func_1_Task_1_Nullable_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
				}
			}

			// Token: 0x060004C9 RID: 1225 RVA: 0x00016E04 File Offset: 0x00015004
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154618, XrefRangeEnd = 1154630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Task WriteResponse(NetworkStream stream, CancellationToken cancellationToken)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeMethodInfoPtr_WriteResponse_Private_Task_NetworkStream_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}

			// Token: 0x060004CA RID: 1226 RVA: 0x00016E6C File Offset: 0x0001506C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154630, XrefRangeEnd = 1154633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004CB RID: 1227 RVA: 0x00004826 File Offset: 0x00002A26
			public LimitedLocalhostHttpServer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001BB RID: 443
			// (get) Token: 0x060004CC RID: 1228 RVA: 0x00016EA0 File Offset: 0x000150A0
			// (set) Token: 0x060004CD RID: 1229 RVA: 0x0000482F File Offset: 0x00002A2F
			public unsafe static int MaxRequestLineLength
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeFieldInfoPtr_MaxRequestLineLength, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeFieldInfoPtr_MaxRequestLineLength, (void*)(&value));
				}
			}

			// Token: 0x170001BC RID: 444
			// (get) Token: 0x060004CE RID: 1230 RVA: 0x00016EBC File Offset: 0x000150BC
			// (set) Token: 0x060004CF RID: 1231 RVA: 0x0000483D File Offset: 0x00002A3D
			public unsafe static int MaxHeadersLength
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeFieldInfoPtr_MaxHeadersLength, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeFieldInfoPtr_MaxHeadersLength, (void*)(&value));
				}
			}

			// Token: 0x170001BD RID: 445
			// (get) Token: 0x060004D0 RID: 1232 RVA: 0x00016ED8 File Offset: 0x000150D8
			// (set) Token: 0x060004D1 RID: 1233 RVA: 0x0000484B File Offset: 0x00002A4B
			public unsafe static int NetworkReadBufferSize
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeFieldInfoPtr_NetworkReadBufferSize, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeFieldInfoPtr_NetworkReadBufferSize, (void*)(&value));
				}
			}

			// Token: 0x170001BE RID: 446
			// (get) Token: 0x060004D2 RID: 1234 RVA: 0x00016EF4 File Offset: 0x000150F4
			// (set) Token: 0x060004D3 RID: 1235 RVA: 0x00004859 File Offset: 0x00002A59
			public unsafe static ILogger Logger
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeFieldInfoPtr_Logger, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeFieldInfoPtr_Logger, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001BF RID: 447
			// (get) Token: 0x060004D4 RID: 1236 RVA: 0x00016F1C File Offset: 0x0001511C
			// (set) Token: 0x060004D5 RID: 1237 RVA: 0x0000486B File Offset: 0x00002A6B
			public unsafe TcpListener _listener
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeFieldInfoPtr__listener);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TcpListener>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeFieldInfoPtr__listener), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001C0 RID: 448
			// (get) Token: 0x060004D6 RID: 1238 RVA: 0x00016F4C File Offset: 0x0001514C
			// (set) Token: 0x060004D7 RID: 1239 RVA: 0x0000488A File Offset: 0x00002A8A
			public unsafe CancellationTokenSource _cts
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeFieldInfoPtr__cts);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeFieldInfoPtr__cts), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001C1 RID: 449
			// (get) Token: 0x060004D8 RID: 1240 RVA: 0x00016F7C File Offset: 0x0001517C
			// (set) Token: 0x060004D9 RID: 1241 RVA: 0x000048A9 File Offset: 0x00002AA9
			public unsafe string _closePageResponse
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeFieldInfoPtr__closePageResponse);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeFieldInfoPtr__closePageResponse), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170001C2 RID: 450
			// (get) Token: 0x060004DA RID: 1242 RVA: 0x00016FA4 File Offset: 0x000151A4
			// (set) Token: 0x060004DB RID: 1243 RVA: 0x000048C8 File Offset: 0x00002AC8
			public unsafe int _Port_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeFieldInfoPtr__Port_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer.NativeFieldInfoPtr__Port_k__BackingField)) = value;
				}
			}

			// Token: 0x040002F5 RID: 757
			private static readonly IntPtr NativeFieldInfoPtr_MaxRequestLineLength;

			// Token: 0x040002F6 RID: 758
			private static readonly IntPtr NativeFieldInfoPtr_MaxHeadersLength;

			// Token: 0x040002F7 RID: 759
			private static readonly IntPtr NativeFieldInfoPtr_NetworkReadBufferSize;

			// Token: 0x040002F8 RID: 760
			private static readonly IntPtr NativeFieldInfoPtr_Logger;

			// Token: 0x040002F9 RID: 761
			private static readonly IntPtr NativeFieldInfoPtr__listener;

			// Token: 0x040002FA RID: 762
			private static readonly IntPtr NativeFieldInfoPtr__cts;

			// Token: 0x040002FB RID: 763
			private static readonly IntPtr NativeFieldInfoPtr__closePageResponse;

			// Token: 0x040002FC RID: 764
			private static readonly IntPtr NativeFieldInfoPtr__Port_k__BackingField;

			// Token: 0x040002FD RID: 765
			private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Static_LimitedLocalhostHttpServer_String_String_0;

			// Token: 0x040002FE RID: 766
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_TcpListener_String_0;

			// Token: 0x040002FF RID: 767
			private static readonly IntPtr NativeMethodInfoPtr_get_Port_Public_get_Int32_0;

			// Token: 0x04000300 RID: 768
			private static readonly IntPtr NativeMethodInfoPtr_GetQueryParamsAsync_Public_Task_1_Dictionary_2_String_String_CancellationToken_0;

			// Token: 0x04000301 RID: 769
			private static readonly IntPtr NativeMethodInfoPtr_GetQueryParamsFromClientAsync_Private_Task_1_Dictionary_2_String_String_TcpClient_CancellationToken_0;

			// Token: 0x04000302 RID: 770
			private static readonly IntPtr NativeMethodInfoPtr_ReadRequestLine_Private_Task_1_String_Func_1_Task_1_Nullable_1_Char_0;

			// Token: 0x04000303 RID: 771
			private static readonly IntPtr NativeMethodInfoPtr_ValidateAndGetRequestParams_Private_Dictionary_2_String_String_String_0;

			// Token: 0x04000304 RID: 772
			private static readonly IntPtr NativeMethodInfoPtr_WaitForAllHeaders_Private_Task_Func_1_Task_1_Nullable_1_Char_0;

			// Token: 0x04000305 RID: 773
			private static readonly IntPtr NativeMethodInfoPtr_WriteResponse_Private_Task_NetworkStream_CancellationToken_0;

			// Token: 0x04000306 RID: 774
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x02000074 RID: 116
			public class ServerException : Exception
			{
				// Token: 0x06000777 RID: 1911 RVA: 0x000069B6 File Offset: 0x00004BB6
				// Note: this type is marked as 'beforefieldinit'.
				static ServerException()
				{
					Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.ServerException>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer>.NativeClassPtr, "ServerException");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.ServerException>.NativeClassPtr);
					LocalServerCodeReceiver.LimitedLocalhostHttpServer.ServerException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.ServerException>.NativeClassPtr, 100663555);
				}

				// Token: 0x06000778 RID: 1912 RVA: 0x0001DB0C File Offset: 0x0001BD0C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154087, XrefRangeEnd = 1154091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ServerException(string msg)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.ServerException>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.LimitedLocalhostHttpServer.ServerException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06000779 RID: 1913 RVA: 0x000069EA File Offset: 0x00004BEA
				public ServerException(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04000468 RID: 1128
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
			}

			// Token: 0x02000075 RID: 117
			[ObfuscatedName("Google.Apis.Auth.OAuth2.LocalServerCodeReceiver+LimitedLocalhostHttpServer+<GetQueryParamsAsync>d__13")]
			public sealed class _GetQueryParamsAsync_d__13 : ValueType
			{
				// Token: 0x0600077A RID: 1914 RVA: 0x0001DB58 File Offset: 0x0001BD58
				// Note: this type is marked as 'beforefieldinit'.
				static _GetQueryParamsAsync_d__13()
				{
					Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer>.NativeClassPtr, "<GetQueryParamsAsync>d__13");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13>.NativeClassPtr);
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13>.NativeClassPtr, "<>1__state");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13>.NativeClassPtr, "<>t__builder");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13>.NativeClassPtr, "<>4__this");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13>.NativeClassPtr, "cancellationToken");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13.NativeFieldInfoPtr__cts_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13>.NativeClassPtr, "<cts>5__2");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13>.NativeClassPtr, "<>7__wrap2");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13.NativeFieldInfoPtr__client_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13>.NativeClassPtr, "<client>5__4");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13>.NativeClassPtr, "<>u__1");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13>.NativeClassPtr, "<>u__2");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13>.NativeClassPtr, 100663556);
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13>.NativeClassPtr, 100663557);
				}

				// Token: 0x0600077B RID: 1915 RVA: 0x0001DC60 File Offset: 0x0001BE60
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154091, XrefRangeEnd = 1154173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600077C RID: 1916 RVA: 0x0001DC98 File Offset: 0x0001BE98
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154173, XrefRangeEnd = 1154179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600077D RID: 1917 RVA: 0x000069F3 File Offset: 0x00004BF3
				public _GetQueryParamsAsync_d__13(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0600077E RID: 1918 RVA: 0x000069FC File Offset: 0x00004BFC
				public _GetQueryParamsAsync_d__13()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13>.NativeClassPtr))
				{
				}

				// Token: 0x170002BC RID: 700
				// (get) Token: 0x0600077F RID: 1919 RVA: 0x0001DCE0 File Offset: 0x0001BEE0
				// (set) Token: 0x06000780 RID: 1920 RVA: 0x00006A0E File Offset: 0x00004C0E
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170002BD RID: 701
				// (get) Token: 0x06000781 RID: 1921 RVA: 0x0001DD08 File Offset: 0x0001BF08
				// (set) Token: 0x06000782 RID: 1922 RVA: 0x00006A29 File Offset: 0x00004C29
				public AsyncTaskMethodBuilder<Dictionary<string, string>> __t__builder
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13.NativeFieldInfoPtr___t__builder);
						return new AsyncTaskMethodBuilder<Dictionary<string, string>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Dictionary<string, string>>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Dictionary<string, string>>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x170002BE RID: 702
				// (get) Token: 0x06000783 RID: 1923 RVA: 0x0001DD38 File Offset: 0x0001BF38
				// (set) Token: 0x06000784 RID: 1924 RVA: 0x00006A57 File Offset: 0x00004C57
				public unsafe LocalServerCodeReceiver.LimitedLocalhostHttpServer __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalServerCodeReceiver.LimitedLocalhostHttpServer>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170002BF RID: 703
				// (get) Token: 0x06000785 RID: 1925 RVA: 0x0001DD68 File Offset: 0x0001BF68
				// (set) Token: 0x06000786 RID: 1926 RVA: 0x00006A76 File Offset: 0x00004C76
				public CancellationToken cancellationToken
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13.NativeFieldInfoPtr_cancellationToken);
						return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x170002C0 RID: 704
				// (get) Token: 0x06000787 RID: 1927 RVA: 0x0001DD98 File Offset: 0x0001BF98
				// (set) Token: 0x06000788 RID: 1928 RVA: 0x00006AA4 File Offset: 0x00004CA4
				public unsafe CancellationTokenSource _cts_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13.NativeFieldInfoPtr__cts_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13.NativeFieldInfoPtr__cts_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170002C1 RID: 705
				// (get) Token: 0x06000789 RID: 1929 RVA: 0x0001DDC8 File Offset: 0x0001BFC8
				// (set) Token: 0x0600078A RID: 1930 RVA: 0x00006AC3 File Offset: 0x00004CC3
				public CancellationTokenRegistration __7__wrap2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13.NativeFieldInfoPtr___7__wrap2);
						return new CancellationTokenRegistration(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13.NativeFieldInfoPtr___7__wrap2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x170002C2 RID: 706
				// (get) Token: 0x0600078B RID: 1931 RVA: 0x0001DDF8 File Offset: 0x0001BFF8
				// (set) Token: 0x0600078C RID: 1932 RVA: 0x00006AF1 File Offset: 0x00004CF1
				public unsafe TcpClient _client_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13.NativeFieldInfoPtr__client_5__4);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<TcpClient>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13.NativeFieldInfoPtr__client_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170002C3 RID: 707
				// (get) Token: 0x0600078D RID: 1933 RVA: 0x0001DE28 File Offset: 0x0001C028
				// (set) Token: 0x0600078E RID: 1934 RVA: 0x00006B10 File Offset: 0x00004D10
				public ConfiguredTaskAwaitable<TcpClient>.ConfiguredTaskAwaiter __u__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13.NativeFieldInfoPtr___u__1);
						return new ConfiguredTaskAwaitable<TcpClient>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TcpClient>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TcpClient>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x170002C4 RID: 708
				// (get) Token: 0x0600078F RID: 1935 RVA: 0x0001DE58 File Offset: 0x0001C058
				// (set) Token: 0x06000790 RID: 1936 RVA: 0x00006B3E File Offset: 0x00004D3E
				public ConfiguredTaskAwaitable<Dictionary<string, string>>.ConfiguredTaskAwaiter __u__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13.NativeFieldInfoPtr___u__2);
						return new ConfiguredTaskAwaitable<Dictionary<string, string>>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Dictionary<string, string>>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsAsync_d__13.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Dictionary<string, string>>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x04000469 RID: 1129
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400046A RID: 1130
				private static readonly IntPtr NativeFieldInfoPtr___t__builder;

				// Token: 0x0400046B RID: 1131
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400046C RID: 1132
				private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

				// Token: 0x0400046D RID: 1133
				private static readonly IntPtr NativeFieldInfoPtr__cts_5__2;

				// Token: 0x0400046E RID: 1134
				private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

				// Token: 0x0400046F RID: 1135
				private static readonly IntPtr NativeFieldInfoPtr__client_5__4;

				// Token: 0x04000470 RID: 1136
				private static readonly IntPtr NativeFieldInfoPtr___u__1;

				// Token: 0x04000471 RID: 1137
				private static readonly IntPtr NativeFieldInfoPtr___u__2;

				// Token: 0x04000472 RID: 1138
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

				// Token: 0x04000473 RID: 1139
				private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
			}

			// Token: 0x02000076 RID: 118
			[ObfuscatedName("Google.Apis.Auth.OAuth2.LocalServerCodeReceiver+LimitedLocalhostHttpServer+<>c__DisplayClass14_0")]
			public sealed class __c__DisplayClass14_0 : Object
			{
				// Token: 0x06000791 RID: 1937 RVA: 0x0001DE88 File Offset: 0x0001C088
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass14_0()
				{
					Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer>.NativeClassPtr, "<>c__DisplayClass14_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_0>.NativeClassPtr);
					LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_0.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_0>.NativeClassPtr, "stream");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_0.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_0>.NativeClassPtr, "cancellationToken");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_0>.NativeClassPtr, 100663558);
					LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_0.NativeMethodInfoPtr__GetQueryParamsFromClientAsync_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_0>.NativeClassPtr, 100663559);
				}

				// Token: 0x06000792 RID: 1938 RVA: 0x0001DF04 File Offset: 0x0001C104
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass14_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06000793 RID: 1939 RVA: 0x0001DF40 File Offset: 0x0001C140
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154179, XrefRangeEnd = 1154181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _GetQueryParamsFromClientAsync_b__0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_0.NativeMethodInfoPtr__GetQueryParamsFromClientAsync_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06000794 RID: 1940 RVA: 0x00006B6C File Offset: 0x00004D6C
				public __c__DisplayClass14_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170002C5 RID: 709
				// (get) Token: 0x06000795 RID: 1941 RVA: 0x0001DF74 File Offset: 0x0001C174
				// (set) Token: 0x06000796 RID: 1942 RVA: 0x00006B75 File Offset: 0x00004D75
				public unsafe NetworkStream stream
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_0.NativeFieldInfoPtr_stream);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkStream>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_0.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170002C6 RID: 710
				// (get) Token: 0x06000797 RID: 1943 RVA: 0x0001DFA4 File Offset: 0x0001C1A4
				// (set) Token: 0x06000798 RID: 1944 RVA: 0x00006B94 File Offset: 0x00004D94
				public CancellationToken cancellationToken
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_0.NativeFieldInfoPtr_cancellationToken);
						return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_0.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x04000474 RID: 1140
				private static readonly IntPtr NativeFieldInfoPtr_stream;

				// Token: 0x04000475 RID: 1141
				private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

				// Token: 0x04000476 RID: 1142
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04000477 RID: 1143
				private static readonly IntPtr NativeMethodInfoPtr__GetQueryParamsFromClientAsync_b__0_Internal_Void_0;
			}

			// Token: 0x02000077 RID: 119
			[ObfuscatedName("Google.Apis.Auth.OAuth2.LocalServerCodeReceiver+LimitedLocalhostHttpServer+<>c__DisplayClass14_1")]
			public sealed class __c__DisplayClass14_1 : Object
			{
				// Token: 0x06000799 RID: 1945 RVA: 0x0001DFD4 File Offset: 0x0001C1D4
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass14_1()
				{
					Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer>.NativeClassPtr, "<>c__DisplayClass14_1");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1>.NativeClassPtr);
					LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.NativeFieldInfoPtr_bufferOfs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1>.NativeClassPtr, "bufferOfs");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.NativeFieldInfoPtr_bufferSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1>.NativeClassPtr, "bufferSize");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1>.NativeClassPtr, "buffer");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.NativeFieldInfoPtr_field_Public___c__DisplayClass14_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1>.NativeClassPtr, "CS$<>8__locals1");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1>.NativeClassPtr, 100663560);
					LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.NativeMethodInfoPtr__GetQueryParamsFromClientAsync_b__1_Internal_Task_1_Nullable_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1>.NativeClassPtr, 100663561);
				}

				// Token: 0x0600079A RID: 1946 RVA: 0x0001E078 File Offset: 0x0001C278
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass14_1()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600079B RID: 1947 RVA: 0x0001E0B4 File Offset: 0x0001C2B4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154214, XrefRangeEnd = 1154228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Task<Nullable<char>> _GetQueryParamsFromClientAsync_b__1()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.NativeMethodInfoPtr__GetQueryParamsFromClientAsync_b__1_Internal_Task_1_Nullable_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<char>>>(intPtr3) : null;
				}

				// Token: 0x0600079C RID: 1948 RVA: 0x00006BC2 File Offset: 0x00004DC2
				public __c__DisplayClass14_1(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170002C7 RID: 711
				// (get) Token: 0x0600079D RID: 1949 RVA: 0x0001E0F4 File Offset: 0x0001C2F4
				// (set) Token: 0x0600079E RID: 1950 RVA: 0x00006BCB File Offset: 0x00004DCB
				public unsafe int bufferOfs
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.NativeFieldInfoPtr_bufferOfs);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.NativeFieldInfoPtr_bufferOfs)) = value;
					}
				}

				// Token: 0x170002C8 RID: 712
				// (get) Token: 0x0600079F RID: 1951 RVA: 0x0001E11C File Offset: 0x0001C31C
				// (set) Token: 0x060007A0 RID: 1952 RVA: 0x00006BE6 File Offset: 0x00004DE6
				public unsafe int bufferSize
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.NativeFieldInfoPtr_bufferSize);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.NativeFieldInfoPtr_bufferSize)) = value;
					}
				}

				// Token: 0x170002C9 RID: 713
				// (get) Token: 0x060007A1 RID: 1953 RVA: 0x0001E144 File Offset: 0x0001C344
				// (set) Token: 0x060007A2 RID: 1954 RVA: 0x00006C01 File Offset: 0x00004E01
				public unsafe Il2CppStructArray<byte> buffer
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.NativeFieldInfoPtr_buffer);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170002CA RID: 714
				// (get) Token: 0x060007A3 RID: 1955 RVA: 0x0001E174 File Offset: 0x0001C374
				// (set) Token: 0x060007A4 RID: 1956 RVA: 0x00006C20 File Offset: 0x00004E20
				public unsafe LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_0 field_Public___c__DisplayClass14_0_0
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.NativeFieldInfoPtr_field_Public___c__DisplayClass14_0_0);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.NativeFieldInfoPtr_field_Public___c__DisplayClass14_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04000478 RID: 1144
				private static readonly IntPtr NativeFieldInfoPtr_bufferOfs;

				// Token: 0x04000479 RID: 1145
				private static readonly IntPtr NativeFieldInfoPtr_bufferSize;

				// Token: 0x0400047A RID: 1146
				private static readonly IntPtr NativeFieldInfoPtr_buffer;

				// Token: 0x0400047B RID: 1147
				private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass14_0_0;

				// Token: 0x0400047C RID: 1148
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400047D RID: 1149
				private static readonly IntPtr NativeMethodInfoPtr__GetQueryParamsFromClientAsync_b__1_Internal_Task_1_Nullable_1_Char_0;

				// Token: 0x0200007F RID: 127
				[ObfuscatedName("Google.Apis.Auth.OAuth2.LocalServerCodeReceiver+LimitedLocalhostHttpServer+<>c__DisplayClass14_1+<<GetQueryParamsFromClientAsync>b__1>d")]
				public sealed class __GetQueryParamsFromClientAsync_b__1_d : ValueType
				{
					// Token: 0x06000813 RID: 2067 RVA: 0x0001F3A0 File Offset: 0x0001D5A0
					// Note: this type is marked as 'beforefieldinit'.
					static __GetQueryParamsFromClientAsync_b__1_d()
					{
						Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.__GetQueryParamsFromClientAsync_b__1_d>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1>.NativeClassPtr, "<<GetQueryParamsFromClientAsync>b__1>d");
						IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.__GetQueryParamsFromClientAsync_b__1_d>.NativeClassPtr);
						LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.__GetQueryParamsFromClientAsync_b__1_d.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.__GetQueryParamsFromClientAsync_b__1_d>.NativeClassPtr, "<>1__state");
						LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.__GetQueryParamsFromClientAsync_b__1_d.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.__GetQueryParamsFromClientAsync_b__1_d>.NativeClassPtr, "<>t__builder");
						LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.__GetQueryParamsFromClientAsync_b__1_d.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.__GetQueryParamsFromClientAsync_b__1_d>.NativeClassPtr, "<>4__this");
						LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.__GetQueryParamsFromClientAsync_b__1_d.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.__GetQueryParamsFromClientAsync_b__1_d>.NativeClassPtr, "<>u__1");
						LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.__GetQueryParamsFromClientAsync_b__1_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.__GetQueryParamsFromClientAsync_b__1_d>.NativeClassPtr, 100663562);
						LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.__GetQueryParamsFromClientAsync_b__1_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.__GetQueryParamsFromClientAsync_b__1_d>.NativeClassPtr, 100663563);
					}

					// Token: 0x06000814 RID: 2068 RVA: 0x0001F444 File Offset: 0x0001D644
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154181, XrefRangeEnd = 1154208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					public unsafe void MoveNext()
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.__GetQueryParamsFromClientAsync_b__1_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}

					// Token: 0x06000815 RID: 2069 RVA: 0x0001F47C File Offset: 0x0001D67C
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154208, XrefRangeEnd = 1154214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						checked
						{
							IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
							*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
							IntPtr intPtr2;
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.__GetQueryParamsFromClientAsync_b__1_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}

					// Token: 0x06000816 RID: 2070 RVA: 0x0000715A File Offset: 0x0000535A
					public __GetQueryParamsFromClientAsync_b__1_d(IntPtr pointer)
						: base(pointer)
					{
					}

					// Token: 0x06000817 RID: 2071 RVA: 0x00007163 File Offset: 0x00005363
					public __GetQueryParamsFromClientAsync_b__1_d()
						: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.__GetQueryParamsFromClientAsync_b__1_d>.NativeClassPtr))
					{
					}

					// Token: 0x170002EE RID: 750
					// (get) Token: 0x06000818 RID: 2072 RVA: 0x0001F4C4 File Offset: 0x0001D6C4
					// (set) Token: 0x06000819 RID: 2073 RVA: 0x00007175 File Offset: 0x00005375
					public unsafe int __1__state
					{
						get
						{
							IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.__GetQueryParamsFromClientAsync_b__1_d.NativeFieldInfoPtr___1__state);
							return *intPtr;
						}
						set
						{
							*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.__GetQueryParamsFromClientAsync_b__1_d.NativeFieldInfoPtr___1__state)) = value;
						}
					}

					// Token: 0x170002EF RID: 751
					// (get) Token: 0x0600081A RID: 2074 RVA: 0x0001F4EC File Offset: 0x0001D6EC
					// (set) Token: 0x0600081B RID: 2075 RVA: 0x00007190 File Offset: 0x00005390
					public AsyncTaskMethodBuilder<Nullable<char>> __t__builder
					{
						get
						{
							IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.__GetQueryParamsFromClientAsync_b__1_d.NativeFieldInfoPtr___t__builder);
							return new AsyncTaskMethodBuilder<Nullable<char>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<char>>>.NativeClassPtr, intPtr));
						}
						set
						{
							cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.__GetQueryParamsFromClientAsync_b__1_d.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<char>>>.NativeClassPtr, (UIntPtr)0));
						}
					}

					// Token: 0x170002F0 RID: 752
					// (get) Token: 0x0600081C RID: 2076 RVA: 0x0001F51C File Offset: 0x0001D71C
					// (set) Token: 0x0600081D RID: 2077 RVA: 0x000071BE File Offset: 0x000053BE
					public unsafe LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1 __4__this
					{
						get
						{
							IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.__GetQueryParamsFromClientAsync_b__1_d.NativeFieldInfoPtr___4__this);
							IntPtr intPtr2 = *intPtr;
							return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1>(intPtr2) : null;
						}
						set
						{
							IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.__GetQueryParamsFromClientAsync_b__1_d.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
						}
					}

					// Token: 0x170002F1 RID: 753
					// (get) Token: 0x0600081E RID: 2078 RVA: 0x0001F54C File Offset: 0x0001D74C
					// (set) Token: 0x0600081F RID: 2079 RVA: 0x000071DD File Offset: 0x000053DD
					public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
					{
						get
						{
							IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.__GetQueryParamsFromClientAsync_b__1_d.NativeFieldInfoPtr___u__1);
							return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
						}
						set
						{
							cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1.__GetQueryParamsFromClientAsync_b__1_d.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
						}
					}

					// Token: 0x040004BF RID: 1215
					private static readonly IntPtr NativeFieldInfoPtr___1__state;

					// Token: 0x040004C0 RID: 1216
					private static readonly IntPtr NativeFieldInfoPtr___t__builder;

					// Token: 0x040004C1 RID: 1217
					private static readonly IntPtr NativeFieldInfoPtr___4__this;

					// Token: 0x040004C2 RID: 1218
					private static readonly IntPtr NativeFieldInfoPtr___u__1;

					// Token: 0x040004C3 RID: 1219
					private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

					// Token: 0x040004C4 RID: 1220
					private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
				}
			}

			// Token: 0x02000078 RID: 120
			[ObfuscatedName("Google.Apis.Auth.OAuth2.LocalServerCodeReceiver+LimitedLocalhostHttpServer+<GetQueryParamsFromClientAsync>d__14")]
			public sealed class _GetQueryParamsFromClientAsync_d__14 : ValueType
			{
				// Token: 0x060007A5 RID: 1957 RVA: 0x0001E1A4 File Offset: 0x0001C3A4
				// Note: this type is marked as 'beforefieldinit'.
				static _GetQueryParamsFromClientAsync_d__14()
				{
					Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer>.NativeClassPtr, "<GetQueryParamsFromClientAsync>d__14");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14>.NativeClassPtr);
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14>.NativeClassPtr, "<>1__state");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14>.NativeClassPtr, "<>t__builder");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14>.NativeClassPtr, "cancellationToken");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14.NativeFieldInfoPtr_client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14>.NativeClassPtr, "client");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14>.NativeClassPtr, "<>4__this");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14>.NativeClassPtr, "<>8__1");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14>.NativeClassPtr, "<>7__wrap1");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14.NativeFieldInfoPtr__getChar_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14>.NativeClassPtr, "<getChar>5__3");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14.NativeFieldInfoPtr__requestParams_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14>.NativeClassPtr, "<requestParams>5__4");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14>.NativeClassPtr, "<>u__1");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14>.NativeClassPtr, "<>u__2");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14>.NativeClassPtr, 100663564);
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14>.NativeClassPtr, 100663565);
				}

				// Token: 0x060007A6 RID: 1958 RVA: 0x0001E2D4 File Offset: 0x0001C4D4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154228, XrefRangeEnd = 1154335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060007A7 RID: 1959 RVA: 0x0001E30C File Offset: 0x0001C50C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154335, XrefRangeEnd = 1154341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060007A8 RID: 1960 RVA: 0x00006C3F File Offset: 0x00004E3F
				public _GetQueryParamsFromClientAsync_d__14(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060007A9 RID: 1961 RVA: 0x00006C48 File Offset: 0x00004E48
				public _GetQueryParamsFromClientAsync_d__14()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14>.NativeClassPtr))
				{
				}

				// Token: 0x170002CB RID: 715
				// (get) Token: 0x060007AA RID: 1962 RVA: 0x0001E354 File Offset: 0x0001C554
				// (set) Token: 0x060007AB RID: 1963 RVA: 0x00006C5A File Offset: 0x00004E5A
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170002CC RID: 716
				// (get) Token: 0x060007AC RID: 1964 RVA: 0x0001E37C File Offset: 0x0001C57C
				// (set) Token: 0x060007AD RID: 1965 RVA: 0x00006C75 File Offset: 0x00004E75
				public AsyncTaskMethodBuilder<Dictionary<string, string>> __t__builder
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14.NativeFieldInfoPtr___t__builder);
						return new AsyncTaskMethodBuilder<Dictionary<string, string>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Dictionary<string, string>>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Dictionary<string, string>>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x170002CD RID: 717
				// (get) Token: 0x060007AE RID: 1966 RVA: 0x0001E3AC File Offset: 0x0001C5AC
				// (set) Token: 0x060007AF RID: 1967 RVA: 0x00006CA3 File Offset: 0x00004EA3
				public CancellationToken cancellationToken
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14.NativeFieldInfoPtr_cancellationToken);
						return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x170002CE RID: 718
				// (get) Token: 0x060007B0 RID: 1968 RVA: 0x0001E3DC File Offset: 0x0001C5DC
				// (set) Token: 0x060007B1 RID: 1969 RVA: 0x00006CD1 File Offset: 0x00004ED1
				public unsafe TcpClient client
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14.NativeFieldInfoPtr_client);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<TcpClient>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14.NativeFieldInfoPtr_client), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170002CF RID: 719
				// (get) Token: 0x060007B2 RID: 1970 RVA: 0x0001E40C File Offset: 0x0001C60C
				// (set) Token: 0x060007B3 RID: 1971 RVA: 0x00006CF0 File Offset: 0x00004EF0
				public unsafe LocalServerCodeReceiver.LimitedLocalhostHttpServer __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalServerCodeReceiver.LimitedLocalhostHttpServer>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170002D0 RID: 720
				// (get) Token: 0x060007B4 RID: 1972 RVA: 0x0001E43C File Offset: 0x0001C63C
				// (set) Token: 0x060007B5 RID: 1973 RVA: 0x00006D0F File Offset: 0x00004F0F
				public unsafe LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1 __8__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14.NativeFieldInfoPtr___8__1);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c__DisplayClass14_1>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170002D1 RID: 721
				// (get) Token: 0x060007B6 RID: 1974 RVA: 0x0001E46C File Offset: 0x0001C66C
				// (set) Token: 0x060007B7 RID: 1975 RVA: 0x00006D2E File Offset: 0x00004F2E
				public CancellationTokenRegistration __7__wrap1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14.NativeFieldInfoPtr___7__wrap1);
						return new CancellationTokenRegistration(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x170002D2 RID: 722
				// (get) Token: 0x060007B8 RID: 1976 RVA: 0x0001E49C File Offset: 0x0001C69C
				// (set) Token: 0x060007B9 RID: 1977 RVA: 0x00006D5C File Offset: 0x00004F5C
				public unsafe Func<Task<Nullable<char>>> _getChar_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14.NativeFieldInfoPtr__getChar_5__3);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Task<Nullable<char>>>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14.NativeFieldInfoPtr__getChar_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170002D3 RID: 723
				// (get) Token: 0x060007BA RID: 1978 RVA: 0x0001E4CC File Offset: 0x0001C6CC
				// (set) Token: 0x060007BB RID: 1979 RVA: 0x00006D7B File Offset: 0x00004F7B
				public unsafe Dictionary<string, string> _requestParams_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14.NativeFieldInfoPtr__requestParams_5__4);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14.NativeFieldInfoPtr__requestParams_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170002D4 RID: 724
				// (get) Token: 0x060007BC RID: 1980 RVA: 0x0001E4FC File Offset: 0x0001C6FC
				// (set) Token: 0x060007BD RID: 1981 RVA: 0x00006D9A File Offset: 0x00004F9A
				public ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14.NativeFieldInfoPtr___u__1);
						return new ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x170002D5 RID: 725
				// (get) Token: 0x060007BE RID: 1982 RVA: 0x0001E52C File Offset: 0x0001C72C
				// (set) Token: 0x060007BF RID: 1983 RVA: 0x00006DC8 File Offset: 0x00004FC8
				public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14.NativeFieldInfoPtr___u__2);
						return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._GetQueryParamsFromClientAsync_d__14.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x0400047E RID: 1150
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400047F RID: 1151
				private static readonly IntPtr NativeFieldInfoPtr___t__builder;

				// Token: 0x04000480 RID: 1152
				private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

				// Token: 0x04000481 RID: 1153
				private static readonly IntPtr NativeFieldInfoPtr_client;

				// Token: 0x04000482 RID: 1154
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04000483 RID: 1155
				private static readonly IntPtr NativeFieldInfoPtr___8__1;

				// Token: 0x04000484 RID: 1156
				private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

				// Token: 0x04000485 RID: 1157
				private static readonly IntPtr NativeFieldInfoPtr__getChar_5__3;

				// Token: 0x04000486 RID: 1158
				private static readonly IntPtr NativeFieldInfoPtr__requestParams_5__4;

				// Token: 0x04000487 RID: 1159
				private static readonly IntPtr NativeFieldInfoPtr___u__1;

				// Token: 0x04000488 RID: 1160
				private static readonly IntPtr NativeFieldInfoPtr___u__2;

				// Token: 0x04000489 RID: 1161
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400048A RID: 1162
				private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
			}

			// Token: 0x02000079 RID: 121
			[ObfuscatedName("Google.Apis.Auth.OAuth2.LocalServerCodeReceiver+LimitedLocalhostHttpServer+<ReadRequestLine>d__15")]
			public sealed class _ReadRequestLine_d__15 : ValueType
			{
				// Token: 0x060007C0 RID: 1984 RVA: 0x0001E55C File Offset: 0x0001C75C
				// Note: this type is marked as 'beforefieldinit'.
				static _ReadRequestLine_d__15()
				{
					Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._ReadRequestLine_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer>.NativeClassPtr, "<ReadRequestLine>d__15");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._ReadRequestLine_d__15>.NativeClassPtr);
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._ReadRequestLine_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._ReadRequestLine_d__15>.NativeClassPtr, "<>1__state");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._ReadRequestLine_d__15.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._ReadRequestLine_d__15>.NativeClassPtr, "<>t__builder");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._ReadRequestLine_d__15.NativeFieldInfoPtr_getChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._ReadRequestLine_d__15>.NativeClassPtr, "getChar");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._ReadRequestLine_d__15.NativeFieldInfoPtr__requestLine_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._ReadRequestLine_d__15>.NativeClassPtr, "<requestLine>5__2");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._ReadRequestLine_d__15.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._ReadRequestLine_d__15>.NativeClassPtr, "<>u__1");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._ReadRequestLine_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._ReadRequestLine_d__15>.NativeClassPtr, 100663566);
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._ReadRequestLine_d__15.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._ReadRequestLine_d__15>.NativeClassPtr, 100663567);
				}

				// Token: 0x060007C1 RID: 1985 RVA: 0x0001E614 File Offset: 0x0001C814
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154341, XrefRangeEnd = 1154377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.LimitedLocalhostHttpServer._ReadRequestLine_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060007C2 RID: 1986 RVA: 0x0001E64C File Offset: 0x0001C84C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154377, XrefRangeEnd = 1154383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.LimitedLocalhostHttpServer._ReadRequestLine_d__15.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060007C3 RID: 1987 RVA: 0x00006DF6 File Offset: 0x00004FF6
				public _ReadRequestLine_d__15(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060007C4 RID: 1988 RVA: 0x00006DFF File Offset: 0x00004FFF
				public _ReadRequestLine_d__15()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._ReadRequestLine_d__15>.NativeClassPtr))
				{
				}

				// Token: 0x170002D6 RID: 726
				// (get) Token: 0x060007C5 RID: 1989 RVA: 0x0001E694 File Offset: 0x0001C894
				// (set) Token: 0x060007C6 RID: 1990 RVA: 0x00006E11 File Offset: 0x00005011
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._ReadRequestLine_d__15.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._ReadRequestLine_d__15.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170002D7 RID: 727
				// (get) Token: 0x060007C7 RID: 1991 RVA: 0x0001E6BC File Offset: 0x0001C8BC
				// (set) Token: 0x060007C8 RID: 1992 RVA: 0x00006E2C File Offset: 0x0000502C
				public AsyncTaskMethodBuilder<string> __t__builder
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._ReadRequestLine_d__15.NativeFieldInfoPtr___t__builder);
						return new AsyncTaskMethodBuilder<string>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<string>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._ReadRequestLine_d__15.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<string>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x170002D8 RID: 728
				// (get) Token: 0x060007C9 RID: 1993 RVA: 0x0001E6EC File Offset: 0x0001C8EC
				// (set) Token: 0x060007CA RID: 1994 RVA: 0x00006E5A File Offset: 0x0000505A
				public unsafe Func<Task<Nullable<char>>> getChar
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._ReadRequestLine_d__15.NativeFieldInfoPtr_getChar);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Task<Nullable<char>>>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._ReadRequestLine_d__15.NativeFieldInfoPtr_getChar), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170002D9 RID: 729
				// (get) Token: 0x060007CB RID: 1995 RVA: 0x0001E71C File Offset: 0x0001C91C
				// (set) Token: 0x060007CC RID: 1996 RVA: 0x00006E79 File Offset: 0x00005079
				public unsafe StringBuilder _requestLine_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._ReadRequestLine_d__15.NativeFieldInfoPtr__requestLine_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._ReadRequestLine_d__15.NativeFieldInfoPtr__requestLine_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170002DA RID: 730
				// (get) Token: 0x060007CD RID: 1997 RVA: 0x0001E74C File Offset: 0x0001C94C
				// (set) Token: 0x060007CE RID: 1998 RVA: 0x00006E98 File Offset: 0x00005098
				public ConfiguredTaskAwaitable<Nullable<char>>.ConfiguredTaskAwaiter __u__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._ReadRequestLine_d__15.NativeFieldInfoPtr___u__1);
						return new ConfiguredTaskAwaitable<Nullable<char>>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Nullable<char>>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._ReadRequestLine_d__15.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Nullable<char>>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x0400048B RID: 1163
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400048C RID: 1164
				private static readonly IntPtr NativeFieldInfoPtr___t__builder;

				// Token: 0x0400048D RID: 1165
				private static readonly IntPtr NativeFieldInfoPtr_getChar;

				// Token: 0x0400048E RID: 1166
				private static readonly IntPtr NativeFieldInfoPtr__requestLine_5__2;

				// Token: 0x0400048F RID: 1167
				private static readonly IntPtr NativeFieldInfoPtr___u__1;

				// Token: 0x04000490 RID: 1168
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

				// Token: 0x04000491 RID: 1169
				private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
			}

			// Token: 0x0200007A RID: 122
			[ObfuscatedName("Google.Apis.Auth.OAuth2.LocalServerCodeReceiver+LimitedLocalhostHttpServer+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x060007CF RID: 1999 RVA: 0x0001E77C File Offset: 0x0001C97C
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c>.NativeClassPtr);
					LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c>.NativeClassPtr, "<>9");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c>.NativeClassPtr, "<>9__16_0");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c.NativeFieldInfoPtr___9__16_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c>.NativeClassPtr, "<>9__16_1");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c.NativeFieldInfoPtr___9__16_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c>.NativeClassPtr, "<>9__16_2");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c>.NativeClassPtr, 100663569);
					LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c.NativeMethodInfoPtr__ValidateAndGetRequestParams_b__16_0_Internal___f__AnonymousType0_2_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c>.NativeClassPtr, 100663570);
					LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c.NativeMethodInfoPtr__ValidateAndGetRequestParams_b__16_1_Internal_String___f__AnonymousType0_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c>.NativeClassPtr, 100663571);
					LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c.NativeMethodInfoPtr__ValidateAndGetRequestParams_b__16_2_Internal_String___f__AnonymousType0_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c>.NativeClassPtr, 100663572);
				}

				// Token: 0x060007D0 RID: 2000 RVA: 0x0001E848 File Offset: 0x0001CA48
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060007D1 RID: 2001 RVA: 0x0001E884 File Offset: 0x0001CA84
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154383, XrefRangeEnd = 1154403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __f__AnonymousType0<string, string> _ValidateAndGetRequestParams_b__16_0(string param)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(param);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c.NativeMethodInfoPtr__ValidateAndGetRequestParams_b__16_0_Internal___f__AnonymousType0_2_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<__f__AnonymousType0<string, string>>(intPtr3) : null;
					}
				}

				// Token: 0x060007D2 RID: 2002 RVA: 0x0001E8D4 File Offset: 0x0001CAD4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154403, XrefRangeEnd = 1154404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _ValidateAndGetRequestParams_b__16_1(__f__AnonymousType0<string, string> x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c.NativeMethodInfoPtr__ValidateAndGetRequestParams_b__16_1_Internal_String___f__AnonymousType0_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x060007D3 RID: 2003 RVA: 0x0001E91C File Offset: 0x0001CB1C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154404, XrefRangeEnd = 1154405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _ValidateAndGetRequestParams_b__16_2(__f__AnonymousType0<string, string> x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c.NativeMethodInfoPtr__ValidateAndGetRequestParams_b__16_2_Internal_String___f__AnonymousType0_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x060007D4 RID: 2004 RVA: 0x00006EC6 File Offset: 0x000050C6
				public __c(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170002DB RID: 731
				// (get) Token: 0x060007D5 RID: 2005 RVA: 0x0001E964 File Offset: 0x0001CB64
				// (set) Token: 0x060007D6 RID: 2006 RVA: 0x00006ECF File Offset: 0x000050CF
				public unsafe static LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170002DC RID: 732
				// (get) Token: 0x060007D7 RID: 2007 RVA: 0x0001E98C File Offset: 0x0001CB8C
				// (set) Token: 0x060007D8 RID: 2008 RVA: 0x00006EE1 File Offset: 0x000050E1
				public unsafe static Func<string, __f__AnonymousType0<string, string>> __9__16_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, __f__AnonymousType0<string, string>>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170002DD RID: 733
				// (get) Token: 0x060007D9 RID: 2009 RVA: 0x0001E9B4 File Offset: 0x0001CBB4
				// (set) Token: 0x060007DA RID: 2010 RVA: 0x00006EF3 File Offset: 0x000050F3
				public unsafe static Func<__f__AnonymousType0<string, string>, string> __9__16_1
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c.NativeFieldInfoPtr___9__16_1, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<__f__AnonymousType0<string, string>, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c.NativeFieldInfoPtr___9__16_1, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170002DE RID: 734
				// (get) Token: 0x060007DB RID: 2011 RVA: 0x0001E9DC File Offset: 0x0001CBDC
				// (set) Token: 0x060007DC RID: 2012 RVA: 0x00006F05 File Offset: 0x00005105
				public unsafe static Func<__f__AnonymousType0<string, string>, string> __9__16_2
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c.NativeFieldInfoPtr___9__16_2, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<__f__AnonymousType0<string, string>, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(LocalServerCodeReceiver.LimitedLocalhostHttpServer.__c.NativeFieldInfoPtr___9__16_2, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04000492 RID: 1170
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x04000493 RID: 1171
				private static readonly IntPtr NativeFieldInfoPtr___9__16_0;

				// Token: 0x04000494 RID: 1172
				private static readonly IntPtr NativeFieldInfoPtr___9__16_1;

				// Token: 0x04000495 RID: 1173
				private static readonly IntPtr NativeFieldInfoPtr___9__16_2;

				// Token: 0x04000496 RID: 1174
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04000497 RID: 1175
				private static readonly IntPtr NativeMethodInfoPtr__ValidateAndGetRequestParams_b__16_0_Internal___f__AnonymousType0_2_String_String_String_0;

				// Token: 0x04000498 RID: 1176
				private static readonly IntPtr NativeMethodInfoPtr__ValidateAndGetRequestParams_b__16_1_Internal_String___f__AnonymousType0_2_String_String_0;

				// Token: 0x04000499 RID: 1177
				private static readonly IntPtr NativeMethodInfoPtr__ValidateAndGetRequestParams_b__16_2_Internal_String___f__AnonymousType0_2_String_String_0;
			}

			// Token: 0x0200007B RID: 123
			[ObfuscatedName("Google.Apis.Auth.OAuth2.LocalServerCodeReceiver+LimitedLocalhostHttpServer+<WaitForAllHeaders>d__17")]
			public sealed class _WaitForAllHeaders_d__17 : ValueType
			{
				// Token: 0x060007DD RID: 2013 RVA: 0x0001EA04 File Offset: 0x0001CC04
				// Note: this type is marked as 'beforefieldinit'.
				static _WaitForAllHeaders_d__17()
				{
					Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._WaitForAllHeaders_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer>.NativeClassPtr, "<WaitForAllHeaders>d__17");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._WaitForAllHeaders_d__17>.NativeClassPtr);
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._WaitForAllHeaders_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._WaitForAllHeaders_d__17>.NativeClassPtr, "<>1__state");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._WaitForAllHeaders_d__17.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._WaitForAllHeaders_d__17>.NativeClassPtr, "<>t__builder");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._WaitForAllHeaders_d__17.NativeFieldInfoPtr_getChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._WaitForAllHeaders_d__17>.NativeClassPtr, "getChar");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._WaitForAllHeaders_d__17.NativeFieldInfoPtr__byteCount_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._WaitForAllHeaders_d__17>.NativeClassPtr, "<byteCount>5__2");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._WaitForAllHeaders_d__17.NativeFieldInfoPtr__lineLength_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._WaitForAllHeaders_d__17>.NativeClassPtr, "<lineLength>5__3");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._WaitForAllHeaders_d__17.NativeFieldInfoPtr__c1_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._WaitForAllHeaders_d__17>.NativeClassPtr, "<c1>5__4");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._WaitForAllHeaders_d__17.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._WaitForAllHeaders_d__17>.NativeClassPtr, "<>u__1");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._WaitForAllHeaders_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._WaitForAllHeaders_d__17>.NativeClassPtr, 100663573);
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._WaitForAllHeaders_d__17.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._WaitForAllHeaders_d__17>.NativeClassPtr, 100663574);
				}

				// Token: 0x060007DE RID: 2014 RVA: 0x0001EAE4 File Offset: 0x0001CCE4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154405, XrefRangeEnd = 1154426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.LimitedLocalhostHttpServer._WaitForAllHeaders_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060007DF RID: 2015 RVA: 0x0001EB1C File Offset: 0x0001CD1C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154426, XrefRangeEnd = 1154430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.LimitedLocalhostHttpServer._WaitForAllHeaders_d__17.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060007E0 RID: 2016 RVA: 0x00006F17 File Offset: 0x00005117
				public _WaitForAllHeaders_d__17(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060007E1 RID: 2017 RVA: 0x00006F20 File Offset: 0x00005120
				public _WaitForAllHeaders_d__17()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._WaitForAllHeaders_d__17>.NativeClassPtr))
				{
				}

				// Token: 0x170002DF RID: 735
				// (get) Token: 0x060007E2 RID: 2018 RVA: 0x0001EB64 File Offset: 0x0001CD64
				// (set) Token: 0x060007E3 RID: 2019 RVA: 0x00006F32 File Offset: 0x00005132
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._WaitForAllHeaders_d__17.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._WaitForAllHeaders_d__17.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170002E0 RID: 736
				// (get) Token: 0x060007E4 RID: 2020 RVA: 0x0001EB8C File Offset: 0x0001CD8C
				// (set) Token: 0x060007E5 RID: 2021 RVA: 0x00006F4D File Offset: 0x0000514D
				public AsyncTaskMethodBuilder __t__builder
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._WaitForAllHeaders_d__17.NativeFieldInfoPtr___t__builder);
						return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._WaitForAllHeaders_d__17.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x170002E1 RID: 737
				// (get) Token: 0x060007E6 RID: 2022 RVA: 0x0001EBBC File Offset: 0x0001CDBC
				// (set) Token: 0x060007E7 RID: 2023 RVA: 0x00006F7B File Offset: 0x0000517B
				public unsafe Func<Task<Nullable<char>>> getChar
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._WaitForAllHeaders_d__17.NativeFieldInfoPtr_getChar);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Task<Nullable<char>>>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._WaitForAllHeaders_d__17.NativeFieldInfoPtr_getChar), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170002E2 RID: 738
				// (get) Token: 0x060007E8 RID: 2024 RVA: 0x0001EBEC File Offset: 0x0001CDEC
				// (set) Token: 0x060007E9 RID: 2025 RVA: 0x00006F9A File Offset: 0x0000519A
				public unsafe int _byteCount_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._WaitForAllHeaders_d__17.NativeFieldInfoPtr__byteCount_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._WaitForAllHeaders_d__17.NativeFieldInfoPtr__byteCount_5__2)) = value;
					}
				}

				// Token: 0x170002E3 RID: 739
				// (get) Token: 0x060007EA RID: 2026 RVA: 0x0001EC14 File Offset: 0x0001CE14
				// (set) Token: 0x060007EB RID: 2027 RVA: 0x00006FB5 File Offset: 0x000051B5
				public unsafe int _lineLength_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._WaitForAllHeaders_d__17.NativeFieldInfoPtr__lineLength_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._WaitForAllHeaders_d__17.NativeFieldInfoPtr__lineLength_5__3)) = value;
					}
				}

				// Token: 0x170002E4 RID: 740
				// (get) Token: 0x060007EC RID: 2028 RVA: 0x0001EC3C File Offset: 0x0001CE3C
				// (set) Token: 0x060007ED RID: 2029 RVA: 0x00006FD0 File Offset: 0x000051D0
				public unsafe char _c1_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._WaitForAllHeaders_d__17.NativeFieldInfoPtr__c1_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._WaitForAllHeaders_d__17.NativeFieldInfoPtr__c1_5__4)) = value;
					}
				}

				// Token: 0x170002E5 RID: 741
				// (get) Token: 0x060007EE RID: 2030 RVA: 0x0001EC64 File Offset: 0x0001CE64
				// (set) Token: 0x060007EF RID: 2031 RVA: 0x00006FEB File Offset: 0x000051EB
				public ConfiguredTaskAwaitable<Nullable<char>>.ConfiguredTaskAwaiter __u__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._WaitForAllHeaders_d__17.NativeFieldInfoPtr___u__1);
						return new ConfiguredTaskAwaitable<Nullable<char>>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Nullable<char>>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._WaitForAllHeaders_d__17.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Nullable<char>>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x0400049A RID: 1178
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400049B RID: 1179
				private static readonly IntPtr NativeFieldInfoPtr___t__builder;

				// Token: 0x0400049C RID: 1180
				private static readonly IntPtr NativeFieldInfoPtr_getChar;

				// Token: 0x0400049D RID: 1181
				private static readonly IntPtr NativeFieldInfoPtr__byteCount_5__2;

				// Token: 0x0400049E RID: 1182
				private static readonly IntPtr NativeFieldInfoPtr__lineLength_5__3;

				// Token: 0x0400049F RID: 1183
				private static readonly IntPtr NativeFieldInfoPtr__c1_5__4;

				// Token: 0x040004A0 RID: 1184
				private static readonly IntPtr NativeFieldInfoPtr___u__1;

				// Token: 0x040004A1 RID: 1185
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

				// Token: 0x040004A2 RID: 1186
				private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
			}

			// Token: 0x0200007C RID: 124
			[ObfuscatedName("Google.Apis.Auth.OAuth2.LocalServerCodeReceiver+LimitedLocalhostHttpServer+<WriteResponse>d__18")]
			public sealed class _WriteResponse_d__18 : ValueType
			{
				// Token: 0x060007F0 RID: 2032 RVA: 0x0001EC94 File Offset: 0x0001CE94
				// Note: this type is marked as 'beforefieldinit'.
				static _WriteResponse_d__18()
				{
					Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._WriteResponse_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer>.NativeClassPtr, "<WriteResponse>d__18");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._WriteResponse_d__18>.NativeClassPtr);
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._WriteResponse_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._WriteResponse_d__18>.NativeClassPtr, "<>1__state");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._WriteResponse_d__18.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._WriteResponse_d__18>.NativeClassPtr, "<>t__builder");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._WriteResponse_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._WriteResponse_d__18>.NativeClassPtr, "<>4__this");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._WriteResponse_d__18.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._WriteResponse_d__18>.NativeClassPtr, "stream");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._WriteResponse_d__18.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._WriteResponse_d__18>.NativeClassPtr, "cancellationToken");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._WriteResponse_d__18.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._WriteResponse_d__18>.NativeClassPtr, "<>u__1");
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._WriteResponse_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._WriteResponse_d__18>.NativeClassPtr, 100663575);
					LocalServerCodeReceiver.LimitedLocalhostHttpServer._WriteResponse_d__18.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._WriteResponse_d__18>.NativeClassPtr, 100663576);
				}

				// Token: 0x060007F1 RID: 2033 RVA: 0x0001ED60 File Offset: 0x0001CF60
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154430, XrefRangeEnd = 1154447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.LimitedLocalhostHttpServer._WriteResponse_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060007F2 RID: 2034 RVA: 0x0001ED98 File Offset: 0x0001CF98
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154447, XrefRangeEnd = 1154451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.LimitedLocalhostHttpServer._WriteResponse_d__18.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060007F3 RID: 2035 RVA: 0x00007019 File Offset: 0x00005219
				public _WriteResponse_d__18(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060007F4 RID: 2036 RVA: 0x00007022 File Offset: 0x00005222
				public _WriteResponse_d__18()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalServerCodeReceiver.LimitedLocalhostHttpServer._WriteResponse_d__18>.NativeClassPtr))
				{
				}

				// Token: 0x170002E6 RID: 742
				// (get) Token: 0x060007F5 RID: 2037 RVA: 0x0001EDE0 File Offset: 0x0001CFE0
				// (set) Token: 0x060007F6 RID: 2038 RVA: 0x00007034 File Offset: 0x00005234
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._WriteResponse_d__18.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._WriteResponse_d__18.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170002E7 RID: 743
				// (get) Token: 0x060007F7 RID: 2039 RVA: 0x0001EE08 File Offset: 0x0001D008
				// (set) Token: 0x060007F8 RID: 2040 RVA: 0x0000704F File Offset: 0x0000524F
				public AsyncTaskMethodBuilder __t__builder
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._WriteResponse_d__18.NativeFieldInfoPtr___t__builder);
						return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._WriteResponse_d__18.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x170002E8 RID: 744
				// (get) Token: 0x060007F9 RID: 2041 RVA: 0x0001EE38 File Offset: 0x0001D038
				// (set) Token: 0x060007FA RID: 2042 RVA: 0x0000707D File Offset: 0x0000527D
				public unsafe LocalServerCodeReceiver.LimitedLocalhostHttpServer __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._WriteResponse_d__18.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalServerCodeReceiver.LimitedLocalhostHttpServer>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._WriteResponse_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170002E9 RID: 745
				// (get) Token: 0x060007FB RID: 2043 RVA: 0x0001EE68 File Offset: 0x0001D068
				// (set) Token: 0x060007FC RID: 2044 RVA: 0x0000709C File Offset: 0x0000529C
				public unsafe NetworkStream stream
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._WriteResponse_d__18.NativeFieldInfoPtr_stream);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkStream>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._WriteResponse_d__18.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170002EA RID: 746
				// (get) Token: 0x060007FD RID: 2045 RVA: 0x0001EE98 File Offset: 0x0001D098
				// (set) Token: 0x060007FE RID: 2046 RVA: 0x000070BB File Offset: 0x000052BB
				public CancellationToken cancellationToken
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._WriteResponse_d__18.NativeFieldInfoPtr_cancellationToken);
						return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._WriteResponse_d__18.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x170002EB RID: 747
				// (get) Token: 0x060007FF RID: 2047 RVA: 0x0001EEC8 File Offset: 0x0001D0C8
				// (set) Token: 0x06000800 RID: 2048 RVA: 0x000070E9 File Offset: 0x000052E9
				public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._WriteResponse_d__18.NativeFieldInfoPtr___u__1);
						return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.LimitedLocalhostHttpServer._WriteResponse_d__18.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x040004A3 RID: 1187
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040004A4 RID: 1188
				private static readonly IntPtr NativeFieldInfoPtr___t__builder;

				// Token: 0x040004A5 RID: 1189
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040004A6 RID: 1190
				private static readonly IntPtr NativeFieldInfoPtr_stream;

				// Token: 0x040004A7 RID: 1191
				private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

				// Token: 0x040004A8 RID: 1192
				private static readonly IntPtr NativeFieldInfoPtr___u__1;

				// Token: 0x040004A9 RID: 1193
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

				// Token: 0x040004AA RID: 1194
				private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
			}
		}

		// Token: 0x0200004D RID: 77
		[ObfuscatedName("Google.Apis.Auth.OAuth2.LocalServerCodeReceiver+<ReceiveCodeAsync>d__16")]
		public sealed class _ReceiveCodeAsync_d__16 : ValueType
		{
			// Token: 0x060004DC RID: 1244 RVA: 0x00016FCC File Offset: 0x000151CC
			// Note: this type is marked as 'beforefieldinit'.
			static _ReceiveCodeAsync_d__16()
			{
				Il2CppClassPointerStore<LocalServerCodeReceiver._ReceiveCodeAsync_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalServerCodeReceiver>.NativeClassPtr, "<ReceiveCodeAsync>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalServerCodeReceiver._ReceiveCodeAsync_d__16>.NativeClassPtr);
				LocalServerCodeReceiver._ReceiveCodeAsync_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver._ReceiveCodeAsync_d__16>.NativeClassPtr, "<>1__state");
				LocalServerCodeReceiver._ReceiveCodeAsync_d__16.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver._ReceiveCodeAsync_d__16>.NativeClassPtr, "<>t__builder");
				LocalServerCodeReceiver._ReceiveCodeAsync_d__16.NativeFieldInfoPtr_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver._ReceiveCodeAsync_d__16>.NativeClassPtr, "url");
				LocalServerCodeReceiver._ReceiveCodeAsync_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver._ReceiveCodeAsync_d__16>.NativeClassPtr, "<>4__this");
				LocalServerCodeReceiver._ReceiveCodeAsync_d__16.NativeFieldInfoPtr_taskCancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver._ReceiveCodeAsync_d__16>.NativeClassPtr, "taskCancellationToken");
				LocalServerCodeReceiver._ReceiveCodeAsync_d__16.NativeFieldInfoPtr__listener_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver._ReceiveCodeAsync_d__16>.NativeClassPtr, "<listener>5__2");
				LocalServerCodeReceiver._ReceiveCodeAsync_d__16.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver._ReceiveCodeAsync_d__16>.NativeClassPtr, "<>u__1");
				LocalServerCodeReceiver._ReceiveCodeAsync_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver._ReceiveCodeAsync_d__16>.NativeClassPtr, 100663577);
				LocalServerCodeReceiver._ReceiveCodeAsync_d__16.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver._ReceiveCodeAsync_d__16>.NativeClassPtr, 100663578);
			}

			// Token: 0x060004DD RID: 1245 RVA: 0x000170AC File Offset: 0x000152AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154633, XrefRangeEnd = 1154708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver._ReceiveCodeAsync_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004DE RID: 1246 RVA: 0x000170E4 File Offset: 0x000152E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154708, XrefRangeEnd = 1154714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver._ReceiveCodeAsync_d__16.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060004DF RID: 1247 RVA: 0x000048E3 File Offset: 0x00002AE3
			public _ReceiveCodeAsync_d__16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060004E0 RID: 1248 RVA: 0x000048EC File Offset: 0x00002AEC
			public _ReceiveCodeAsync_d__16()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalServerCodeReceiver._ReceiveCodeAsync_d__16>.NativeClassPtr))
			{
			}

			// Token: 0x170001C4 RID: 452
			// (get) Token: 0x060004E1 RID: 1249 RVA: 0x0001712C File Offset: 0x0001532C
			// (set) Token: 0x060004E2 RID: 1250 RVA: 0x000048FE File Offset: 0x00002AFE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver._ReceiveCodeAsync_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver._ReceiveCodeAsync_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170001C5 RID: 453
			// (get) Token: 0x060004E3 RID: 1251 RVA: 0x00017154 File Offset: 0x00015354
			// (set) Token: 0x060004E4 RID: 1252 RVA: 0x00004919 File Offset: 0x00002B19
			public AsyncTaskMethodBuilder<AuthorizationCodeResponseUrl> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver._ReceiveCodeAsync_d__16.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<AuthorizationCodeResponseUrl>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<AuthorizationCodeResponseUrl>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver._ReceiveCodeAsync_d__16.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<AuthorizationCodeResponseUrl>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170001C6 RID: 454
			// (get) Token: 0x060004E5 RID: 1253 RVA: 0x00017184 File Offset: 0x00015384
			// (set) Token: 0x060004E6 RID: 1254 RVA: 0x00004947 File Offset: 0x00002B47
			public unsafe AuthorizationCodeRequestUrl url
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver._ReceiveCodeAsync_d__16.NativeFieldInfoPtr_url);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AuthorizationCodeRequestUrl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver._ReceiveCodeAsync_d__16.NativeFieldInfoPtr_url), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001C7 RID: 455
			// (get) Token: 0x060004E7 RID: 1255 RVA: 0x000171B4 File Offset: 0x000153B4
			// (set) Token: 0x060004E8 RID: 1256 RVA: 0x00004966 File Offset: 0x00002B66
			public unsafe LocalServerCodeReceiver __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver._ReceiveCodeAsync_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalServerCodeReceiver>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver._ReceiveCodeAsync_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001C8 RID: 456
			// (get) Token: 0x060004E9 RID: 1257 RVA: 0x000171E4 File Offset: 0x000153E4
			// (set) Token: 0x060004EA RID: 1258 RVA: 0x00004985 File Offset: 0x00002B85
			public CancellationToken taskCancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver._ReceiveCodeAsync_d__16.NativeFieldInfoPtr_taskCancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver._ReceiveCodeAsync_d__16.NativeFieldInfoPtr_taskCancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170001C9 RID: 457
			// (get) Token: 0x060004EB RID: 1259 RVA: 0x00017214 File Offset: 0x00015414
			// (set) Token: 0x060004EC RID: 1260 RVA: 0x000049B3 File Offset: 0x00002BB3
			public unsafe HttpListener _listener_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver._ReceiveCodeAsync_d__16.NativeFieldInfoPtr__listener_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpListener>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver._ReceiveCodeAsync_d__16.NativeFieldInfoPtr__listener_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001CA RID: 458
			// (get) Token: 0x060004ED RID: 1261 RVA: 0x00017244 File Offset: 0x00015444
			// (set) Token: 0x060004EE RID: 1262 RVA: 0x000049D2 File Offset: 0x00002BD2
			public ConfiguredTaskAwaitable<AuthorizationCodeResponseUrl>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver._ReceiveCodeAsync_d__16.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<AuthorizationCodeResponseUrl>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<AuthorizationCodeResponseUrl>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver._ReceiveCodeAsync_d__16.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<AuthorizationCodeResponseUrl>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000307 RID: 775
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000308 RID: 776
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000309 RID: 777
			private static readonly IntPtr NativeFieldInfoPtr_url;

			// Token: 0x0400030A RID: 778
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400030B RID: 779
			private static readonly IntPtr NativeFieldInfoPtr_taskCancellationToken;

			// Token: 0x0400030C RID: 780
			private static readonly IntPtr NativeFieldInfoPtr__listener_5__2;

			// Token: 0x0400030D RID: 781
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400030E RID: 782
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400030F RID: 783
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200004E RID: 78
		[ObfuscatedName("Google.Apis.Auth.OAuth2.LocalServerCodeReceiver+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : Object
		{
			// Token: 0x060004EF RID: 1263 RVA: 0x00017274 File Offset: 0x00015474
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<LocalServerCodeReceiver.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalServerCodeReceiver>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalServerCodeReceiver.__c__DisplayClass19_0>.NativeClassPtr);
				LocalServerCodeReceiver.__c__DisplayClass19_0.NativeFieldInfoPtr_coll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.__c__DisplayClass19_0>.NativeClassPtr, "coll");
				LocalServerCodeReceiver.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver.__c__DisplayClass19_0>.NativeClassPtr, 100663579);
				LocalServerCodeReceiver.__c__DisplayClass19_0.NativeMethodInfoPtr__GetResponseFromListener_b__1_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver.__c__DisplayClass19_0>.NativeClassPtr, 100663580);
			}

			// Token: 0x060004F0 RID: 1264 RVA: 0x000172DC File Offset: 0x000154DC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalServerCodeReceiver.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004F1 RID: 1265 RVA: 0x00017318 File Offset: 0x00015518
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154714, XrefRangeEnd = 1154716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetResponseFromListener_b__1(string k)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(k);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.__c__DisplayClass19_0.NativeMethodInfoPtr__GetResponseFromListener_b__1_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060004F2 RID: 1266 RVA: 0x00004A00 File Offset: 0x00002C00
			public __c__DisplayClass19_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001CB RID: 459
			// (get) Token: 0x060004F3 RID: 1267 RVA: 0x00017360 File Offset: 0x00015560
			// (set) Token: 0x060004F4 RID: 1268 RVA: 0x00004A09 File Offset: 0x00002C09
			public unsafe NameValueCollection coll
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.__c__DisplayClass19_0.NativeFieldInfoPtr_coll);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NameValueCollection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver.__c__DisplayClass19_0.NativeFieldInfoPtr_coll), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000310 RID: 784
			private static readonly IntPtr NativeFieldInfoPtr_coll;

			// Token: 0x04000311 RID: 785
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000312 RID: 786
			private static readonly IntPtr NativeMethodInfoPtr__GetResponseFromListener_b__1_Internal_String_String_0;
		}

		// Token: 0x0200004F RID: 79
		[ObfuscatedName("Google.Apis.Auth.OAuth2.LocalServerCodeReceiver+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060004F5 RID: 1269 RVA: 0x00017390 File Offset: 0x00015590
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LocalServerCodeReceiver.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalServerCodeReceiver>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalServerCodeReceiver.__c>.NativeClassPtr);
				LocalServerCodeReceiver.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.__c>.NativeClassPtr, "<>9");
				LocalServerCodeReceiver.__c.NativeFieldInfoPtr___9__19_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver.__c>.NativeClassPtr, "<>9__19_0");
				LocalServerCodeReceiver.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver.__c>.NativeClassPtr, 100663582);
				LocalServerCodeReceiver.__c.NativeMethodInfoPtr__GetResponseFromListener_b__19_0_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver.__c>.NativeClassPtr, 100663583);
			}

			// Token: 0x060004F6 RID: 1270 RVA: 0x0001740C File Offset: 0x0001560C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalServerCodeReceiver.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004F7 RID: 1271 RVA: 0x00017448 File Offset: 0x00015648
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetResponseFromListener_b__19_0(string k)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(k);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver.__c.NativeMethodInfoPtr__GetResponseFromListener_b__19_0_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060004F8 RID: 1272 RVA: 0x00004A28 File Offset: 0x00002C28
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001CC RID: 460
			// (get) Token: 0x060004F9 RID: 1273 RVA: 0x00017490 File Offset: 0x00015690
			// (set) Token: 0x060004FA RID: 1274 RVA: 0x00004A31 File Offset: 0x00002C31
			public unsafe static LocalServerCodeReceiver.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LocalServerCodeReceiver.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalServerCodeReceiver.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LocalServerCodeReceiver.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001CD RID: 461
			// (get) Token: 0x060004FB RID: 1275 RVA: 0x000174B8 File Offset: 0x000156B8
			// (set) Token: 0x060004FC RID: 1276 RVA: 0x00004A43 File Offset: 0x00002C43
			public unsafe static Func<string, string> __9__19_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LocalServerCodeReceiver.__c.NativeFieldInfoPtr___9__19_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LocalServerCodeReceiver.__c.NativeFieldInfoPtr___9__19_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000313 RID: 787
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000314 RID: 788
			private static readonly IntPtr NativeFieldInfoPtr___9__19_0;

			// Token: 0x04000315 RID: 789
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000316 RID: 790
			private static readonly IntPtr NativeMethodInfoPtr__GetResponseFromListener_b__19_0_Internal_String_String_0;
		}

		// Token: 0x02000050 RID: 80
		[ObfuscatedName("Google.Apis.Auth.OAuth2.LocalServerCodeReceiver+<GetResponseFromListener>d__19")]
		public sealed class _GetResponseFromListener_d__19 : ValueType
		{
			// Token: 0x060004FD RID: 1277 RVA: 0x000174E0 File Offset: 0x000156E0
			// Note: this type is marked as 'beforefieldinit'.
			static _GetResponseFromListener_d__19()
			{
				Il2CppClassPointerStore<LocalServerCodeReceiver._GetResponseFromListener_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalServerCodeReceiver>.NativeClassPtr, "<GetResponseFromListener>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalServerCodeReceiver._GetResponseFromListener_d__19>.NativeClassPtr);
				LocalServerCodeReceiver._GetResponseFromListener_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver._GetResponseFromListener_d__19>.NativeClassPtr, "<>1__state");
				LocalServerCodeReceiver._GetResponseFromListener_d__19.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver._GetResponseFromListener_d__19>.NativeClassPtr, "<>t__builder");
				LocalServerCodeReceiver._GetResponseFromListener_d__19.NativeFieldInfoPtr_ct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver._GetResponseFromListener_d__19>.NativeClassPtr, "ct");
				LocalServerCodeReceiver._GetResponseFromListener_d__19.NativeFieldInfoPtr_listener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver._GetResponseFromListener_d__19>.NativeClassPtr, "listener");
				LocalServerCodeReceiver._GetResponseFromListener_d__19.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver._GetResponseFromListener_d__19>.NativeClassPtr, "<>8__1");
				LocalServerCodeReceiver._GetResponseFromListener_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver._GetResponseFromListener_d__19>.NativeClassPtr, "<>4__this");
				LocalServerCodeReceiver._GetResponseFromListener_d__19.NativeFieldInfoPtr__context_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver._GetResponseFromListener_d__19>.NativeClassPtr, "<context>5__2");
				LocalServerCodeReceiver._GetResponseFromListener_d__19.NativeFieldInfoPtr__output_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver._GetResponseFromListener_d__19>.NativeClassPtr, "<output>5__3");
				LocalServerCodeReceiver._GetResponseFromListener_d__19.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver._GetResponseFromListener_d__19>.NativeClassPtr, "<>7__wrap3");
				LocalServerCodeReceiver._GetResponseFromListener_d__19.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver._GetResponseFromListener_d__19>.NativeClassPtr, "<>u__1");
				LocalServerCodeReceiver._GetResponseFromListener_d__19.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalServerCodeReceiver._GetResponseFromListener_d__19>.NativeClassPtr, "<>u__2");
				LocalServerCodeReceiver._GetResponseFromListener_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver._GetResponseFromListener_d__19>.NativeClassPtr, 100663584);
				LocalServerCodeReceiver._GetResponseFromListener_d__19.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalServerCodeReceiver._GetResponseFromListener_d__19>.NativeClassPtr, 100663585);
			}

			// Token: 0x060004FE RID: 1278 RVA: 0x00017610 File Offset: 0x00015810
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154716, XrefRangeEnd = 1154815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver._GetResponseFromListener_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004FF RID: 1279 RVA: 0x00017648 File Offset: 0x00015848
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154815, XrefRangeEnd = 1154821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalServerCodeReceiver._GetResponseFromListener_d__19.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000500 RID: 1280 RVA: 0x00004A55 File Offset: 0x00002C55
			public _GetResponseFromListener_d__19(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000501 RID: 1281 RVA: 0x00004A5E File Offset: 0x00002C5E
			public _GetResponseFromListener_d__19()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalServerCodeReceiver._GetResponseFromListener_d__19>.NativeClassPtr))
			{
			}

			// Token: 0x170001CE RID: 462
			// (get) Token: 0x06000502 RID: 1282 RVA: 0x00017690 File Offset: 0x00015890
			// (set) Token: 0x06000503 RID: 1283 RVA: 0x00004A70 File Offset: 0x00002C70
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver._GetResponseFromListener_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver._GetResponseFromListener_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170001CF RID: 463
			// (get) Token: 0x06000504 RID: 1284 RVA: 0x000176B8 File Offset: 0x000158B8
			// (set) Token: 0x06000505 RID: 1285 RVA: 0x00004A8B File Offset: 0x00002C8B
			public AsyncTaskMethodBuilder<AuthorizationCodeResponseUrl> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver._GetResponseFromListener_d__19.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<AuthorizationCodeResponseUrl>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<AuthorizationCodeResponseUrl>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver._GetResponseFromListener_d__19.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<AuthorizationCodeResponseUrl>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170001D0 RID: 464
			// (get) Token: 0x06000506 RID: 1286 RVA: 0x000176E8 File Offset: 0x000158E8
			// (set) Token: 0x06000507 RID: 1287 RVA: 0x00004AB9 File Offset: 0x00002CB9
			public CancellationToken ct
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver._GetResponseFromListener_d__19.NativeFieldInfoPtr_ct);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver._GetResponseFromListener_d__19.NativeFieldInfoPtr_ct), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170001D1 RID: 465
			// (get) Token: 0x06000508 RID: 1288 RVA: 0x00017718 File Offset: 0x00015918
			// (set) Token: 0x06000509 RID: 1289 RVA: 0x00004AE7 File Offset: 0x00002CE7
			public unsafe HttpListener listener
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver._GetResponseFromListener_d__19.NativeFieldInfoPtr_listener);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpListener>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver._GetResponseFromListener_d__19.NativeFieldInfoPtr_listener), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001D2 RID: 466
			// (get) Token: 0x0600050A RID: 1290 RVA: 0x00017748 File Offset: 0x00015948
			// (set) Token: 0x0600050B RID: 1291 RVA: 0x00004B06 File Offset: 0x00002D06
			public unsafe LocalServerCodeReceiver.__c__DisplayClass19_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver._GetResponseFromListener_d__19.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalServerCodeReceiver.__c__DisplayClass19_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver._GetResponseFromListener_d__19.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001D3 RID: 467
			// (get) Token: 0x0600050C RID: 1292 RVA: 0x00017778 File Offset: 0x00015978
			// (set) Token: 0x0600050D RID: 1293 RVA: 0x00004B25 File Offset: 0x00002D25
			public unsafe LocalServerCodeReceiver __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver._GetResponseFromListener_d__19.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalServerCodeReceiver>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver._GetResponseFromListener_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001D4 RID: 468
			// (get) Token: 0x0600050E RID: 1294 RVA: 0x000177A8 File Offset: 0x000159A8
			// (set) Token: 0x0600050F RID: 1295 RVA: 0x00004B44 File Offset: 0x00002D44
			public unsafe HttpListenerContext _context_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver._GetResponseFromListener_d__19.NativeFieldInfoPtr__context_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpListenerContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver._GetResponseFromListener_d__19.NativeFieldInfoPtr__context_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001D5 RID: 469
			// (get) Token: 0x06000510 RID: 1296 RVA: 0x000177D8 File Offset: 0x000159D8
			// (set) Token: 0x06000511 RID: 1297 RVA: 0x00004B63 File Offset: 0x00002D63
			public unsafe Stream _output_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver._GetResponseFromListener_d__19.NativeFieldInfoPtr__output_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver._GetResponseFromListener_d__19.NativeFieldInfoPtr__output_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001D6 RID: 470
			// (get) Token: 0x06000512 RID: 1298 RVA: 0x00017808 File Offset: 0x00015A08
			// (set) Token: 0x06000513 RID: 1299 RVA: 0x00004B82 File Offset: 0x00002D82
			public CancellationTokenRegistration __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver._GetResponseFromListener_d__19.NativeFieldInfoPtr___7__wrap3);
					return new CancellationTokenRegistration(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver._GetResponseFromListener_d__19.NativeFieldInfoPtr___7__wrap3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170001D7 RID: 471
			// (get) Token: 0x06000514 RID: 1300 RVA: 0x00017838 File Offset: 0x00015A38
			// (set) Token: 0x06000515 RID: 1301 RVA: 0x00004BB0 File Offset: 0x00002DB0
			public ConfiguredTaskAwaitable<HttpListenerContext>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver._GetResponseFromListener_d__19.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<HttpListenerContext>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpListenerContext>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver._GetResponseFromListener_d__19.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpListenerContext>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170001D8 RID: 472
			// (get) Token: 0x06000516 RID: 1302 RVA: 0x00017868 File Offset: 0x00015A68
			// (set) Token: 0x06000517 RID: 1303 RVA: 0x00004BDE File Offset: 0x00002DDE
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver._GetResponseFromListener_d__19.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalServerCodeReceiver._GetResponseFromListener_d__19.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000317 RID: 791
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000318 RID: 792
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000319 RID: 793
			private static readonly IntPtr NativeFieldInfoPtr_ct;

			// Token: 0x0400031A RID: 794
			private static readonly IntPtr NativeFieldInfoPtr_listener;

			// Token: 0x0400031B RID: 795
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400031C RID: 796
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400031D RID: 797
			private static readonly IntPtr NativeFieldInfoPtr__context_5__2;

			// Token: 0x0400031E RID: 798
			private static readonly IntPtr NativeFieldInfoPtr__output_5__3;

			// Token: 0x0400031F RID: 799
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x04000320 RID: 800
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000321 RID: 801
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04000322 RID: 802
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000323 RID: 803
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
