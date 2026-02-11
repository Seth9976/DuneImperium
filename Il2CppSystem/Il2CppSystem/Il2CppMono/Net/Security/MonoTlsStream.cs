using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Interface;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Net;
using Il2CppSystem.Net.Security;
using Il2CppSystem.Net.Sockets;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppMono.Net.Security
{
	// Token: 0x02000021 RID: 33
	public class MonoTlsStream : Object
	{
		// Token: 0x06000212 RID: 530 RVA: 0x0002315C File Offset: 0x0002135C
		// Note: this type is marked as 'beforefieldinit'.
		static MonoTlsStream()
		{
			Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "MonoTlsStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr);
			MonoTlsStream.NativeFieldInfoPtr_provider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, "provider");
			MonoTlsStream.NativeFieldInfoPtr_networkStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, "networkStream");
			MonoTlsStream.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, "request");
			MonoTlsStream.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, "settings");
			MonoTlsStream.NativeFieldInfoPtr_sslStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, "sslStream");
			MonoTlsStream.NativeFieldInfoPtr_sslStreamLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, "sslStreamLock");
			MonoTlsStream.NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, "status");
			MonoTlsStream.NativeFieldInfoPtr__CertificateValidationFailed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, "<CertificateValidationFailed>k__BackingField");
			MonoTlsStream.NativeMethodInfoPtr_get_Request_Internal_get_HttpWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, 100663672);
			MonoTlsStream.NativeMethodInfoPtr_get_ExceptionStatus_Internal_get_WebExceptionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, 100663673);
			MonoTlsStream.NativeMethodInfoPtr_get_CertificateValidationFailed_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, 100663674);
			MonoTlsStream.NativeMethodInfoPtr_set_CertificateValidationFailed_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, 100663675);
			MonoTlsStream.NativeMethodInfoPtr__ctor_Public_Void_HttpWebRequest_NetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, 100663676);
			MonoTlsStream.NativeMethodInfoPtr_CreateStream_Internal_Task_1_Stream_WebConnectionTunnel_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, 100663677);
			MonoTlsStream.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, 100663678);
			MonoTlsStream.NativeMethodInfoPtr_CloseSslStream_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, 100663679);
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000213 RID: 531 RVA: 0x000232CC File Offset: 0x000214CC
		public unsafe HttpWebRequest Request
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsStream.NativeMethodInfoPtr_get_Request_Internal_get_HttpWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr3) : null;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000214 RID: 532 RVA: 0x0002330C File Offset: 0x0002150C
		public unsafe WebExceptionStatus ExceptionStatus
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsStream.NativeMethodInfoPtr_get_ExceptionStatus_Internal_get_WebExceptionStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000215 RID: 533 RVA: 0x00023348 File Offset: 0x00021548
		// (set) Token: 0x06000216 RID: 534 RVA: 0x00023384 File Offset: 0x00021584
		public unsafe bool CertificateValidationFailed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsStream.NativeMethodInfoPtr_get_CertificateValidationFailed_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsStream.NativeMethodInfoPtr_set_CertificateValidationFailed_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000217 RID: 535 RVA: 0x000233C4 File Offset: 0x000215C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429179, RefRangeEnd = 429180, XrefRangeStart = 429143, XrefRangeEnd = 429179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoTlsStream(HttpWebRequest request, NetworkStream networkStream)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsStream.NativeMethodInfoPtr__ctor_Public_Void_HttpWebRequest_NetworkStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00023424 File Offset: 0x00021624
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429196, RefRangeEnd = 429197, XrefRangeStart = 429180, XrefRangeEnd = 429196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Stream> CreateStream(WebConnectionTunnel tunnel, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tunnel);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsStream.NativeMethodInfoPtr_CreateStream_Internal_Task_1_Stream_WebConnectionTunnel_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Stream>>(intPtr3) : null;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0002348C File Offset: 0x0002168C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429198, RefRangeEnd = 429199, XrefRangeStart = 429197, XrefRangeEnd = 429198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsStream.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x000234C0 File Offset: 0x000216C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429205, RefRangeEnd = 429206, XrefRangeStart = 429199, XrefRangeEnd = 429205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseSslStream()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsStream.NativeMethodInfoPtr_CloseSslStream_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002BD7 File Offset: 0x00000DD7
		public MonoTlsStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600021C RID: 540 RVA: 0x000234F4 File Offset: 0x000216F4
		// (set) Token: 0x0600021D RID: 541 RVA: 0x00002BE0 File Offset: 0x00000DE0
		public unsafe MobileTlsProvider provider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr_provider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MobileTlsProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr_provider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600021E RID: 542 RVA: 0x00023524 File Offset: 0x00021724
		// (set) Token: 0x0600021F RID: 543 RVA: 0x00002BFF File Offset: 0x00000DFF
		public unsafe NetworkStream networkStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr_networkStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr_networkStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000220 RID: 544 RVA: 0x00023554 File Offset: 0x00021754
		// (set) Token: 0x06000221 RID: 545 RVA: 0x00002C1E File Offset: 0x00000E1E
		public unsafe HttpWebRequest request
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr_request);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000222 RID: 546 RVA: 0x00023584 File Offset: 0x00021784
		// (set) Token: 0x06000223 RID: 547 RVA: 0x00002C3D File Offset: 0x00000E3D
		public unsafe MonoTlsSettings settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr_settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000224 RID: 548 RVA: 0x000235B4 File Offset: 0x000217B4
		// (set) Token: 0x06000225 RID: 549 RVA: 0x00002C5C File Offset: 0x00000E5C
		public unsafe SslStream sslStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr_sslStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SslStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr_sslStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000226 RID: 550 RVA: 0x000235E4 File Offset: 0x000217E4
		// (set) Token: 0x06000227 RID: 551 RVA: 0x00002C7B File Offset: 0x00000E7B
		public unsafe Object sslStreamLock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr_sslStreamLock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr_sslStreamLock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000228 RID: 552 RVA: 0x00023614 File Offset: 0x00021814
		// (set) Token: 0x06000229 RID: 553 RVA: 0x00002C9A File Offset: 0x00000E9A
		public unsafe WebExceptionStatus status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr_status);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr_status)) = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600022A RID: 554 RVA: 0x0002363C File Offset: 0x0002183C
		// (set) Token: 0x0600022B RID: 555 RVA: 0x00002CB5 File Offset: 0x00000EB5
		public unsafe bool _CertificateValidationFailed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr__CertificateValidationFailed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr__CertificateValidationFailed_k__BackingField)) = value;
			}
		}

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeFieldInfoPtr_provider;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeFieldInfoPtr_networkStream;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeFieldInfoPtr_request;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeFieldInfoPtr_settings;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeFieldInfoPtr_sslStream;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeFieldInfoPtr_sslStreamLock;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeFieldInfoPtr_status;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeFieldInfoPtr__CertificateValidationFailed_k__BackingField;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr_get_Request_Internal_get_HttpWebRequest_0;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeMethodInfoPtr_get_ExceptionStatus_Internal_get_WebExceptionStatus_0;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeMethodInfoPtr_get_CertificateValidationFailed_Internal_get_Boolean_0;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeMethodInfoPtr_set_CertificateValidationFailed_Internal_set_Void_Boolean_0;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_HttpWebRequest_NetworkStream_0;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_CreateStream_Internal_Task_1_Stream_WebConnectionTunnel_CancellationToken_0;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeMethodInfoPtr_CloseSslStream_Private_Void_0;

		// Token: 0x020002A2 RID: 674
		[ObfuscatedName("Mono.Net.Security.MonoTlsStream+<CreateStream>d__18")]
		public sealed class _CreateStream_d__18 : ValueType
		{
			// Token: 0x06002AA4 RID: 10916 RVA: 0x000BE9D8 File Offset: 0x000BCBD8
			// Note: this type is marked as 'beforefieldinit'.
			static _CreateStream_d__18()
			{
				Il2CppClassPointerStore<MonoTlsStream._CreateStream_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, "<CreateStream>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoTlsStream._CreateStream_d__18>.NativeClassPtr);
				MonoTlsStream._CreateStream_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream._CreateStream_d__18>.NativeClassPtr, "<>1__state");
				MonoTlsStream._CreateStream_d__18.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream._CreateStream_d__18>.NativeClassPtr, "<>t__builder");
				MonoTlsStream._CreateStream_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream._CreateStream_d__18>.NativeClassPtr, "<>4__this");
				MonoTlsStream._CreateStream_d__18.NativeFieldInfoPtr_tunnel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream._CreateStream_d__18>.NativeClassPtr, "tunnel");
				MonoTlsStream._CreateStream_d__18.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream._CreateStream_d__18>.NativeClassPtr, "cancellationToken");
				MonoTlsStream._CreateStream_d__18.NativeFieldInfoPtr__socket_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream._CreateStream_d__18>.NativeClassPtr, "<socket>5__2");
				MonoTlsStream._CreateStream_d__18.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream._CreateStream_d__18>.NativeClassPtr, "<>u__1");
				MonoTlsStream._CreateStream_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsStream._CreateStream_d__18>.NativeClassPtr, 100663680);
				MonoTlsStream._CreateStream_d__18.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsStream._CreateStream_d__18>.NativeClassPtr, 100663681);
			}

			// Token: 0x06002AA5 RID: 10917 RVA: 0x000BEAB8 File Offset: 0x000BCCB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429096, XrefRangeEnd = 429137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsStream._CreateStream_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002AA6 RID: 10918 RVA: 0x000BEAF0 File Offset: 0x000BCCF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429137, XrefRangeEnd = 429143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsStream._CreateStream_d__18.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002AA7 RID: 10919 RVA: 0x00012E0A File Offset: 0x0001100A
			public _CreateStream_d__18(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002AA8 RID: 10920 RVA: 0x00012E13 File Offset: 0x00011013
			public _CreateStream_d__18()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoTlsStream._CreateStream_d__18>.NativeClassPtr))
			{
			}

			// Token: 0x17000D80 RID: 3456
			// (get) Token: 0x06002AA9 RID: 10921 RVA: 0x000BEB38 File Offset: 0x000BCD38
			// (set) Token: 0x06002AAA RID: 10922 RVA: 0x00012E25 File Offset: 0x00011025
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D81 RID: 3457
			// (get) Token: 0x06002AAB RID: 10923 RVA: 0x000BEB60 File Offset: 0x000BCD60
			// (set) Token: 0x06002AAC RID: 10924 RVA: 0x00012E40 File Offset: 0x00011040
			public AsyncTaskMethodBuilder<Stream> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__18.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Stream>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Stream>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__18.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Stream>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000D82 RID: 3458
			// (get) Token: 0x06002AAD RID: 10925 RVA: 0x000BEB90 File Offset: 0x000BCD90
			// (set) Token: 0x06002AAE RID: 10926 RVA: 0x00012E6E File Offset: 0x0001106E
			public unsafe MonoTlsStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTlsStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D83 RID: 3459
			// (get) Token: 0x06002AAF RID: 10927 RVA: 0x000BEBC0 File Offset: 0x000BCDC0
			// (set) Token: 0x06002AB0 RID: 10928 RVA: 0x00012E8D File Offset: 0x0001108D
			public unsafe WebConnectionTunnel tunnel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__18.NativeFieldInfoPtr_tunnel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebConnectionTunnel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__18.NativeFieldInfoPtr_tunnel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D84 RID: 3460
			// (get) Token: 0x06002AB1 RID: 10929 RVA: 0x000BEBF0 File Offset: 0x000BCDF0
			// (set) Token: 0x06002AB2 RID: 10930 RVA: 0x00012EAC File Offset: 0x000110AC
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__18.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__18.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000D85 RID: 3461
			// (get) Token: 0x06002AB3 RID: 10931 RVA: 0x000BEC20 File Offset: 0x000BCE20
			// (set) Token: 0x06002AB4 RID: 10932 RVA: 0x00012EDA File Offset: 0x000110DA
			public unsafe Socket _socket_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__18.NativeFieldInfoPtr__socket_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__18.NativeFieldInfoPtr__socket_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D86 RID: 3462
			// (get) Token: 0x06002AB5 RID: 10933 RVA: 0x000BEC50 File Offset: 0x000BCE50
			// (set) Token: 0x06002AB6 RID: 10934 RVA: 0x00012EF9 File Offset: 0x000110F9
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__18.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__18.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040021AA RID: 8618
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040021AB RID: 8619
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040021AC RID: 8620
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040021AD RID: 8621
			private static readonly IntPtr NativeFieldInfoPtr_tunnel;

			// Token: 0x040021AE RID: 8622
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040021AF RID: 8623
			private static readonly IntPtr NativeFieldInfoPtr__socket_5__2;

			// Token: 0x040021B0 RID: 8624
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040021B1 RID: 8625
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040021B2 RID: 8626
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
