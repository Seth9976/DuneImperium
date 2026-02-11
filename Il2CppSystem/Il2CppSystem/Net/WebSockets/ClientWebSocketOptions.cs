using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Net.Security;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppSystem.Net.WebSockets
{
	// Token: 0x02000255 RID: 597
	public sealed class ClientWebSocketOptions : Object
	{
		// Token: 0x06002809 RID: 10249 RVA: 0x000B6B04 File Offset: 0x000B4D04
		// Note: this type is marked as 'beforefieldinit'.
		static ClientWebSocketOptions()
		{
			Il2CppClassPointerStore<ClientWebSocketOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.WebSockets", "ClientWebSocketOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientWebSocketOptions>.NativeClassPtr);
			ClientWebSocketOptions.NativeFieldInfoPtr__isReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientWebSocketOptions>.NativeClassPtr, "_isReadOnly");
			ClientWebSocketOptions.NativeFieldInfoPtr__requestedSubProtocols = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientWebSocketOptions>.NativeClassPtr, "_requestedSubProtocols");
			ClientWebSocketOptions.NativeFieldInfoPtr__requestHeaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientWebSocketOptions>.NativeClassPtr, "_requestHeaders");
			ClientWebSocketOptions.NativeFieldInfoPtr__keepAliveInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientWebSocketOptions>.NativeClassPtr, "_keepAliveInterval");
			ClientWebSocketOptions.NativeFieldInfoPtr__useDefaultCredentials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientWebSocketOptions>.NativeClassPtr, "_useDefaultCredentials");
			ClientWebSocketOptions.NativeFieldInfoPtr__credentials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientWebSocketOptions>.NativeClassPtr, "_credentials");
			ClientWebSocketOptions.NativeFieldInfoPtr__proxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientWebSocketOptions>.NativeClassPtr, "_proxy");
			ClientWebSocketOptions.NativeFieldInfoPtr__clientCertificates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientWebSocketOptions>.NativeClassPtr, "_clientCertificates");
			ClientWebSocketOptions.NativeFieldInfoPtr__cookies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientWebSocketOptions>.NativeClassPtr, "_cookies");
			ClientWebSocketOptions.NativeFieldInfoPtr__receiveBufferSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientWebSocketOptions>.NativeClassPtr, "_receiveBufferSize");
			ClientWebSocketOptions.NativeFieldInfoPtr__sendBufferSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientWebSocketOptions>.NativeClassPtr, "_sendBufferSize");
			ClientWebSocketOptions.NativeFieldInfoPtr__buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientWebSocketOptions>.NativeClassPtr, "_buffer");
			ClientWebSocketOptions.NativeFieldInfoPtr__remoteCertificateValidationCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientWebSocketOptions>.NativeClassPtr, "_remoteCertificateValidationCallback");
			ClientWebSocketOptions.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWebSocketOptions>.NativeClassPtr, 100669275);
			ClientWebSocketOptions.NativeMethodInfoPtr_SetRequestHeader_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWebSocketOptions>.NativeClassPtr, 100669276);
			ClientWebSocketOptions.NativeMethodInfoPtr_get_RequestHeaders_Internal_get_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWebSocketOptions>.NativeClassPtr, 100669277);
			ClientWebSocketOptions.NativeMethodInfoPtr_get_RequestedSubProtocols_Internal_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWebSocketOptions>.NativeClassPtr, 100669278);
			ClientWebSocketOptions.NativeMethodInfoPtr_set_Proxy_Public_set_Void_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWebSocketOptions>.NativeClassPtr, 100669279);
			ClientWebSocketOptions.NativeMethodInfoPtr_get_ClientCertificates_Public_get_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWebSocketOptions>.NativeClassPtr, 100669280);
			ClientWebSocketOptions.NativeMethodInfoPtr_get_Cookies_Public_get_CookieContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWebSocketOptions>.NativeClassPtr, 100669281);
			ClientWebSocketOptions.NativeMethodInfoPtr_get_KeepAliveInterval_Public_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWebSocketOptions>.NativeClassPtr, 100669282);
			ClientWebSocketOptions.NativeMethodInfoPtr_set_KeepAliveInterval_Public_set_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWebSocketOptions>.NativeClassPtr, 100669283);
			ClientWebSocketOptions.NativeMethodInfoPtr_get_ReceiveBufferSize_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWebSocketOptions>.NativeClassPtr, 100669284);
			ClientWebSocketOptions.NativeMethodInfoPtr_get_SendBufferSize_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWebSocketOptions>.NativeClassPtr, 100669285);
			ClientWebSocketOptions.NativeMethodInfoPtr_get_Buffer_Internal_get_Nullable_1_ArraySegment_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWebSocketOptions>.NativeClassPtr, 100669286);
			ClientWebSocketOptions.NativeMethodInfoPtr_SetToReadOnly_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWebSocketOptions>.NativeClassPtr, 100669287);
			ClientWebSocketOptions.NativeMethodInfoPtr_ThrowIfReadOnly_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientWebSocketOptions>.NativeClassPtr, 100669288);
		}

		// Token: 0x0600280A RID: 10250 RVA: 0x000B6D50 File Offset: 0x000B4F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493014, XrefRangeEnd = 493031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClientWebSocketOptions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientWebSocketOptions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientWebSocketOptions.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600280B RID: 10251 RVA: 0x000B6D8C File Offset: 0x000B4F8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 493038, RefRangeEnd = 493039, XrefRangeStart = 493031, XrefRangeEnd = 493038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRequestHeader(string headerName, string headerValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(headerName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(headerValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientWebSocketOptions.NativeMethodInfoPtr_SetRequestHeader_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x0600280C RID: 10252 RVA: 0x000B6DE0 File Offset: 0x000B4FE0
		public unsafe WebHeaderCollection RequestHeaders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientWebSocketOptions.NativeMethodInfoPtr_get_RequestHeaders_Internal_get_WebHeaderCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x0600280D RID: 10253 RVA: 0x000B6E20 File Offset: 0x000B5020
		public unsafe List<string> RequestedSubProtocols
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientWebSocketOptions.NativeMethodInfoPtr_get_RequestedSubProtocols_Internal_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
		}

		// Token: 0x17000CBB RID: 3259
		// (set) Token: 0x0600280E RID: 10254 RVA: 0x000B6E60 File Offset: 0x000B5060
		public unsafe IWebProxy Proxy
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493039, XrefRangeEnd = 493046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientWebSocketOptions.NativeMethodInfoPtr_set_Proxy_Public_set_Void_IWebProxy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x0600280F RID: 10255 RVA: 0x000B6EA4 File Offset: 0x000B50A4
		public unsafe X509CertificateCollection ClientCertificates
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493046, XrefRangeEnd = 493051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientWebSocketOptions.NativeMethodInfoPtr_get_ClientCertificates_Public_get_X509CertificateCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x06002810 RID: 10256 RVA: 0x000B6EE4 File Offset: 0x000B50E4
		public unsafe CookieContainer Cookies
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientWebSocketOptions.NativeMethodInfoPtr_get_Cookies_Public_get_CookieContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CookieContainer>(intPtr3) : null;
			}
		}

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x06002811 RID: 10257 RVA: 0x000B6F24 File Offset: 0x000B5124
		// (set) Token: 0x06002812 RID: 10258 RVA: 0x000B6F60 File Offset: 0x000B5160
		public unsafe TimeSpan KeepAliveInterval
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientWebSocketOptions.NativeMethodInfoPtr_get_KeepAliveInterval_Public_get_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 493063, RefRangeEnd = 493064, XrefRangeStart = 493051, XrefRangeEnd = 493063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientWebSocketOptions.NativeMethodInfoPtr_set_KeepAliveInterval_Public_set_Void_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x06002813 RID: 10259 RVA: 0x000B6FA0 File Offset: 0x000B51A0
		public unsafe int ReceiveBufferSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientWebSocketOptions.NativeMethodInfoPtr_get_ReceiveBufferSize_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x06002814 RID: 10260 RVA: 0x000B6FDC File Offset: 0x000B51DC
		public unsafe int SendBufferSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientWebSocketOptions.NativeMethodInfoPtr_get_SendBufferSize_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x06002815 RID: 10261 RVA: 0x000B7018 File Offset: 0x000B5218
		public unsafe Nullable<ArraySegment<byte>> Buffer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientWebSocketOptions.NativeMethodInfoPtr_get_Buffer_Internal_get_Nullable_1_ArraySegment_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<ArraySegment<byte>>(intPtr);
			}
		}

		// Token: 0x06002816 RID: 10262 RVA: 0x000B7050 File Offset: 0x000B5250
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 478427, RefRangeEnd = 478428, XrefRangeStart = 478427, XrefRangeEnd = 478428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetToReadOnly()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientWebSocketOptions.NativeMethodInfoPtr_SetToReadOnly_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002817 RID: 10263 RVA: 0x000B7084 File Offset: 0x000B5284
		[CallerCount(0)]
		public unsafe void ThrowIfReadOnly()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientWebSocketOptions.NativeMethodInfoPtr_ThrowIfReadOnly_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002818 RID: 10264 RVA: 0x0001143D File Offset: 0x0000F63D
		public ClientWebSocketOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x06002819 RID: 10265 RVA: 0x000B70B8 File Offset: 0x000B52B8
		// (set) Token: 0x0600281A RID: 10266 RVA: 0x00011446 File Offset: 0x0000F646
		public unsafe bool _isReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocketOptions.NativeFieldInfoPtr__isReadOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocketOptions.NativeFieldInfoPtr__isReadOnly)) = value;
			}
		}

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x0600281B RID: 10267 RVA: 0x000B70E0 File Offset: 0x000B52E0
		// (set) Token: 0x0600281C RID: 10268 RVA: 0x00011461 File Offset: 0x0000F661
		public unsafe List<string> _requestedSubProtocols
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocketOptions.NativeFieldInfoPtr__requestedSubProtocols);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocketOptions.NativeFieldInfoPtr__requestedSubProtocols), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x0600281D RID: 10269 RVA: 0x000B7110 File Offset: 0x000B5310
		// (set) Token: 0x0600281E RID: 10270 RVA: 0x00011480 File Offset: 0x0000F680
		public unsafe WebHeaderCollection _requestHeaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocketOptions.NativeFieldInfoPtr__requestHeaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocketOptions.NativeFieldInfoPtr__requestHeaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x0600281F RID: 10271 RVA: 0x000B7140 File Offset: 0x000B5340
		// (set) Token: 0x06002820 RID: 10272 RVA: 0x0001149F File Offset: 0x0000F69F
		public unsafe TimeSpan _keepAliveInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocketOptions.NativeFieldInfoPtr__keepAliveInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocketOptions.NativeFieldInfoPtr__keepAliveInterval)) = value;
			}
		}

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x06002821 RID: 10273 RVA: 0x000B7168 File Offset: 0x000B5368
		// (set) Token: 0x06002822 RID: 10274 RVA: 0x000114BA File Offset: 0x0000F6BA
		public unsafe bool _useDefaultCredentials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocketOptions.NativeFieldInfoPtr__useDefaultCredentials);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocketOptions.NativeFieldInfoPtr__useDefaultCredentials)) = value;
			}
		}

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x06002823 RID: 10275 RVA: 0x000B7190 File Offset: 0x000B5390
		// (set) Token: 0x06002824 RID: 10276 RVA: 0x000114D5 File Offset: 0x0000F6D5
		public unsafe ICredentials _credentials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocketOptions.NativeFieldInfoPtr__credentials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocketOptions.NativeFieldInfoPtr__credentials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x06002825 RID: 10277 RVA: 0x000B71C0 File Offset: 0x000B53C0
		// (set) Token: 0x06002826 RID: 10278 RVA: 0x000114F4 File Offset: 0x0000F6F4
		public unsafe IWebProxy _proxy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocketOptions.NativeFieldInfoPtr__proxy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocketOptions.NativeFieldInfoPtr__proxy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x06002827 RID: 10279 RVA: 0x000B71F0 File Offset: 0x000B53F0
		// (set) Token: 0x06002828 RID: 10280 RVA: 0x00011513 File Offset: 0x0000F713
		public unsafe X509CertificateCollection _clientCertificates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocketOptions.NativeFieldInfoPtr__clientCertificates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocketOptions.NativeFieldInfoPtr__clientCertificates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x06002829 RID: 10281 RVA: 0x000B7220 File Offset: 0x000B5420
		// (set) Token: 0x0600282A RID: 10282 RVA: 0x00011532 File Offset: 0x0000F732
		public unsafe CookieContainer _cookies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocketOptions.NativeFieldInfoPtr__cookies);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookieContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocketOptions.NativeFieldInfoPtr__cookies), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x0600282B RID: 10283 RVA: 0x000B7250 File Offset: 0x000B5450
		// (set) Token: 0x0600282C RID: 10284 RVA: 0x00011551 File Offset: 0x0000F751
		public unsafe int _receiveBufferSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocketOptions.NativeFieldInfoPtr__receiveBufferSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocketOptions.NativeFieldInfoPtr__receiveBufferSize)) = value;
			}
		}

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x0600282D RID: 10285 RVA: 0x000B7278 File Offset: 0x000B5478
		// (set) Token: 0x0600282E RID: 10286 RVA: 0x0001156C File Offset: 0x0000F76C
		public unsafe int _sendBufferSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocketOptions.NativeFieldInfoPtr__sendBufferSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocketOptions.NativeFieldInfoPtr__sendBufferSize)) = value;
			}
		}

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x0600282F RID: 10287 RVA: 0x000B72A0 File Offset: 0x000B54A0
		// (set) Token: 0x06002830 RID: 10288 RVA: 0x00011587 File Offset: 0x0000F787
		public Nullable<ArraySegment<byte>> _buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocketOptions.NativeFieldInfoPtr__buffer);
				return new Nullable<ArraySegment<byte>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<ArraySegment<byte>>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocketOptions.NativeFieldInfoPtr__buffer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<ArraySegment<byte>>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x06002831 RID: 10289 RVA: 0x000B72D0 File Offset: 0x000B54D0
		// (set) Token: 0x06002832 RID: 10290 RVA: 0x000115B5 File Offset: 0x0000F7B5
		public unsafe RemoteCertificateValidationCallback _remoteCertificateValidationCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocketOptions.NativeFieldInfoPtr__remoteCertificateValidationCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RemoteCertificateValidationCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientWebSocketOptions.NativeFieldInfoPtr__remoteCertificateValidationCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FC6 RID: 8134
		private static readonly IntPtr NativeFieldInfoPtr__isReadOnly;

		// Token: 0x04001FC7 RID: 8135
		private static readonly IntPtr NativeFieldInfoPtr__requestedSubProtocols;

		// Token: 0x04001FC8 RID: 8136
		private static readonly IntPtr NativeFieldInfoPtr__requestHeaders;

		// Token: 0x04001FC9 RID: 8137
		private static readonly IntPtr NativeFieldInfoPtr__keepAliveInterval;

		// Token: 0x04001FCA RID: 8138
		private static readonly IntPtr NativeFieldInfoPtr__useDefaultCredentials;

		// Token: 0x04001FCB RID: 8139
		private static readonly IntPtr NativeFieldInfoPtr__credentials;

		// Token: 0x04001FCC RID: 8140
		private static readonly IntPtr NativeFieldInfoPtr__proxy;

		// Token: 0x04001FCD RID: 8141
		private static readonly IntPtr NativeFieldInfoPtr__clientCertificates;

		// Token: 0x04001FCE RID: 8142
		private static readonly IntPtr NativeFieldInfoPtr__cookies;

		// Token: 0x04001FCF RID: 8143
		private static readonly IntPtr NativeFieldInfoPtr__receiveBufferSize;

		// Token: 0x04001FD0 RID: 8144
		private static readonly IntPtr NativeFieldInfoPtr__sendBufferSize;

		// Token: 0x04001FD1 RID: 8145
		private static readonly IntPtr NativeFieldInfoPtr__buffer;

		// Token: 0x04001FD2 RID: 8146
		private static readonly IntPtr NativeFieldInfoPtr__remoteCertificateValidationCallback;

		// Token: 0x04001FD3 RID: 8147
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04001FD4 RID: 8148
		private static readonly IntPtr NativeMethodInfoPtr_SetRequestHeader_Public_Void_String_String_0;

		// Token: 0x04001FD5 RID: 8149
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestHeaders_Internal_get_WebHeaderCollection_0;

		// Token: 0x04001FD6 RID: 8150
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestedSubProtocols_Internal_get_List_1_String_0;

		// Token: 0x04001FD7 RID: 8151
		private static readonly IntPtr NativeMethodInfoPtr_set_Proxy_Public_set_Void_IWebProxy_0;

		// Token: 0x04001FD8 RID: 8152
		private static readonly IntPtr NativeMethodInfoPtr_get_ClientCertificates_Public_get_X509CertificateCollection_0;

		// Token: 0x04001FD9 RID: 8153
		private static readonly IntPtr NativeMethodInfoPtr_get_Cookies_Public_get_CookieContainer_0;

		// Token: 0x04001FDA RID: 8154
		private static readonly IntPtr NativeMethodInfoPtr_get_KeepAliveInterval_Public_get_TimeSpan_0;

		// Token: 0x04001FDB RID: 8155
		private static readonly IntPtr NativeMethodInfoPtr_set_KeepAliveInterval_Public_set_Void_TimeSpan_0;

		// Token: 0x04001FDC RID: 8156
		private static readonly IntPtr NativeMethodInfoPtr_get_ReceiveBufferSize_Internal_get_Int32_0;

		// Token: 0x04001FDD RID: 8157
		private static readonly IntPtr NativeMethodInfoPtr_get_SendBufferSize_Internal_get_Int32_0;

		// Token: 0x04001FDE RID: 8158
		private static readonly IntPtr NativeMethodInfoPtr_get_Buffer_Internal_get_Nullable_1_ArraySegment_1_Byte_0;

		// Token: 0x04001FDF RID: 8159
		private static readonly IntPtr NativeMethodInfoPtr_SetToReadOnly_Internal_Void_0;

		// Token: 0x04001FE0 RID: 8160
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfReadOnly_Private_Void_0;
	}
}
