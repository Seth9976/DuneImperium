using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Net.Http;
using Il2CppSystem.Net.Http.Headers;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Http
{
	// Token: 0x02000039 RID: 57
	public sealed class GzipDeflateHandler : DelegatingHandler
	{
		// Token: 0x06000279 RID: 633 RVA: 0x0000D1B4 File Offset: 0x0000B3B4
		// Note: this type is marked as 'beforefieldinit'.
		static GzipDeflateHandler()
		{
			Il2CppClassPointerStore<GzipDeflateHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Http", "GzipDeflateHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GzipDeflateHandler>.NativeClassPtr);
			GzipDeflateHandler.NativeFieldInfoPtr_GzipEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GzipDeflateHandler>.NativeClassPtr, "GzipEncoding");
			GzipDeflateHandler.NativeFieldInfoPtr_DeflateEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GzipDeflateHandler>.NativeClassPtr, "DeflateEncoding");
			GzipDeflateHandler.NativeFieldInfoPtr_s_gzipAcceptHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GzipDeflateHandler>.NativeClassPtr, "s_gzipAcceptHeader");
			GzipDeflateHandler.NativeFieldInfoPtr_s_deflateAcceptHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GzipDeflateHandler>.NativeClassPtr, "s_deflateAcceptHeader");
			GzipDeflateHandler.NativeFieldInfoPtr_s_gzipReplacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GzipDeflateHandler>.NativeClassPtr, "s_gzipReplacement");
			GzipDeflateHandler.NativeFieldInfoPtr_s_deflateReplacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GzipDeflateHandler>.NativeClassPtr, "s_deflateReplacement");
			GzipDeflateHandler.NativeMethodInfoPtr__ctor_Internal_Void_HttpMessageHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GzipDeflateHandler>.NativeClassPtr, 100663689);
			GzipDeflateHandler.NativeMethodInfoPtr_SendAsync_Protected_Virtual_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GzipDeflateHandler>.NativeClassPtr, 100663690);
			GzipDeflateHandler.NativeMethodInfoPtr___n__0_Private_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GzipDeflateHandler>.NativeClassPtr, 100663692);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000D298 File Offset: 0x0000B498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GzipDeflateHandler(HttpMessageHandler innerHandler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GzipDeflateHandler>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(innerHandler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GzipDeflateHandler.NativeMethodInfoPtr__ctor_Internal_Void_HttpMessageHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000D2E4 File Offset: 0x0000B4E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212757, XrefRangeEnd = 1212773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GzipDeflateHandler.NativeMethodInfoPtr_SendAsync_Protected_Virtual_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<HttpResponseMessage>>(intPtr3) : null;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000D34C File Offset: 0x0000B54C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GzipDeflateHandler.NativeMethodInfoPtr___n__0_Private_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<HttpResponseMessage>>(intPtr3) : null;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000302B File Offset: 0x0000122B
		public GzipDeflateHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600027E RID: 638 RVA: 0x0000D3B4 File Offset: 0x0000B5B4
		// (set) Token: 0x0600027F RID: 639 RVA: 0x00003034 File Offset: 0x00001234
		public unsafe static string GzipEncoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GzipDeflateHandler.NativeFieldInfoPtr_GzipEncoding, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GzipDeflateHandler.NativeFieldInfoPtr_GzipEncoding, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000280 RID: 640 RVA: 0x0000D3D4 File Offset: 0x0000B5D4
		// (set) Token: 0x06000281 RID: 641 RVA: 0x00003046 File Offset: 0x00001246
		public unsafe static string DeflateEncoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GzipDeflateHandler.NativeFieldInfoPtr_DeflateEncoding, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GzipDeflateHandler.NativeFieldInfoPtr_DeflateEncoding, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000282 RID: 642 RVA: 0x0000D3F4 File Offset: 0x0000B5F4
		// (set) Token: 0x06000283 RID: 643 RVA: 0x00003058 File Offset: 0x00001258
		public unsafe static StringWithQualityHeaderValue s_gzipAcceptHeader
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GzipDeflateHandler.NativeFieldInfoPtr_s_gzipAcceptHeader, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringWithQualityHeaderValue>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GzipDeflateHandler.NativeFieldInfoPtr_s_gzipAcceptHeader, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000284 RID: 644 RVA: 0x0000D41C File Offset: 0x0000B61C
		// (set) Token: 0x06000285 RID: 645 RVA: 0x0000306A File Offset: 0x0000126A
		public unsafe static StringWithQualityHeaderValue s_deflateAcceptHeader
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GzipDeflateHandler.NativeFieldInfoPtr_s_deflateAcceptHeader, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringWithQualityHeaderValue>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GzipDeflateHandler.NativeFieldInfoPtr_s_deflateAcceptHeader, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000286 RID: 646 RVA: 0x0000D444 File Offset: 0x0000B644
		// (set) Token: 0x06000287 RID: 647 RVA: 0x0000307C File Offset: 0x0000127C
		public unsafe static Func<Stream, Stream> s_gzipReplacement
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GzipDeflateHandler.NativeFieldInfoPtr_s_gzipReplacement, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Stream, Stream>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GzipDeflateHandler.NativeFieldInfoPtr_s_gzipReplacement, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000288 RID: 648 RVA: 0x0000D46C File Offset: 0x0000B66C
		// (set) Token: 0x06000289 RID: 649 RVA: 0x0000308E File Offset: 0x0000128E
		public unsafe static Func<Stream, Stream> s_deflateReplacement
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GzipDeflateHandler.NativeFieldInfoPtr_s_deflateReplacement, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Stream, Stream>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GzipDeflateHandler.NativeFieldInfoPtr_s_deflateReplacement, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeFieldInfoPtr_GzipEncoding;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeFieldInfoPtr_DeflateEncoding;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeFieldInfoPtr_s_gzipAcceptHeader;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeFieldInfoPtr_s_deflateAcceptHeader;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeFieldInfoPtr_s_gzipReplacement;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeFieldInfoPtr_s_deflateReplacement;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_HttpMessageHandler_0;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr_SendAsync_Protected_Virtual_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0;

		// Token: 0x02000063 RID: 99
		[ObfuscatedName("Google.Apis.Http.GzipDeflateHandler+<SendAsync>d__7")]
		public sealed class _SendAsync_d__7 : ValueType
		{
			// Token: 0x060003DF RID: 991 RVA: 0x000116B4 File Offset: 0x0000F8B4
			// Note: this type is marked as 'beforefieldinit'.
			static _SendAsync_d__7()
			{
				Il2CppClassPointerStore<GzipDeflateHandler._SendAsync_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GzipDeflateHandler>.NativeClassPtr, "<SendAsync>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GzipDeflateHandler._SendAsync_d__7>.NativeClassPtr);
				GzipDeflateHandler._SendAsync_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GzipDeflateHandler._SendAsync_d__7>.NativeClassPtr, "<>1__state");
				GzipDeflateHandler._SendAsync_d__7.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GzipDeflateHandler._SendAsync_d__7>.NativeClassPtr, "<>t__builder");
				GzipDeflateHandler._SendAsync_d__7.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GzipDeflateHandler._SendAsync_d__7>.NativeClassPtr, "request");
				GzipDeflateHandler._SendAsync_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GzipDeflateHandler._SendAsync_d__7>.NativeClassPtr, "<>4__this");
				GzipDeflateHandler._SendAsync_d__7.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GzipDeflateHandler._SendAsync_d__7>.NativeClassPtr, "cancellationToken");
				GzipDeflateHandler._SendAsync_d__7.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GzipDeflateHandler._SendAsync_d__7>.NativeClassPtr, "<>u__1");
				GzipDeflateHandler._SendAsync_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GzipDeflateHandler._SendAsync_d__7>.NativeClassPtr, 100663693);
				GzipDeflateHandler._SendAsync_d__7.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GzipDeflateHandler._SendAsync_d__7>.NativeClassPtr, 100663694);
			}

			// Token: 0x060003E0 RID: 992 RVA: 0x00011780 File Offset: 0x0000F980
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212662, XrefRangeEnd = 1212743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GzipDeflateHandler._SendAsync_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003E1 RID: 993 RVA: 0x000117B8 File Offset: 0x0000F9B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212743, XrefRangeEnd = 1212749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GzipDeflateHandler._SendAsync_d__7.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003E2 RID: 994 RVA: 0x00003D6E File Offset: 0x00001F6E
			public _SendAsync_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060003E3 RID: 995 RVA: 0x00003D77 File Offset: 0x00001F77
			public _SendAsync_d__7()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GzipDeflateHandler._SendAsync_d__7>.NativeClassPtr))
			{
			}

			// Token: 0x17000131 RID: 305
			// (get) Token: 0x060003E4 RID: 996 RVA: 0x00011800 File Offset: 0x0000FA00
			// (set) Token: 0x060003E5 RID: 997 RVA: 0x00003D89 File Offset: 0x00001F89
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GzipDeflateHandler._SendAsync_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GzipDeflateHandler._SendAsync_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000132 RID: 306
			// (get) Token: 0x060003E6 RID: 998 RVA: 0x00011828 File Offset: 0x0000FA28
			// (set) Token: 0x060003E7 RID: 999 RVA: 0x00003DA4 File Offset: 0x00001FA4
			public AsyncTaskMethodBuilder<HttpResponseMessage> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GzipDeflateHandler._SendAsync_d__7.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<HttpResponseMessage>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<HttpResponseMessage>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GzipDeflateHandler._SendAsync_d__7.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<HttpResponseMessage>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000133 RID: 307
			// (get) Token: 0x060003E8 RID: 1000 RVA: 0x00011858 File Offset: 0x0000FA58
			// (set) Token: 0x060003E9 RID: 1001 RVA: 0x00003DD2 File Offset: 0x00001FD2
			public unsafe HttpRequestMessage request
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GzipDeflateHandler._SendAsync_d__7.NativeFieldInfoPtr_request);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpRequestMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GzipDeflateHandler._SendAsync_d__7.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000134 RID: 308
			// (get) Token: 0x060003EA RID: 1002 RVA: 0x00011888 File Offset: 0x0000FA88
			// (set) Token: 0x060003EB RID: 1003 RVA: 0x00003DF1 File Offset: 0x00001FF1
			public unsafe GzipDeflateHandler __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GzipDeflateHandler._SendAsync_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GzipDeflateHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GzipDeflateHandler._SendAsync_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000135 RID: 309
			// (get) Token: 0x060003EC RID: 1004 RVA: 0x000118B8 File Offset: 0x0000FAB8
			// (set) Token: 0x060003ED RID: 1005 RVA: 0x00003E10 File Offset: 0x00002010
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GzipDeflateHandler._SendAsync_d__7.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GzipDeflateHandler._SendAsync_d__7.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000136 RID: 310
			// (get) Token: 0x060003EE RID: 1006 RVA: 0x000118E8 File Offset: 0x0000FAE8
			// (set) Token: 0x060003EF RID: 1007 RVA: 0x00003E3E File Offset: 0x0000203E
			public ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GzipDeflateHandler._SendAsync_d__7.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GzipDeflateHandler._SendAsync_d__7.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000283 RID: 643
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000284 RID: 644
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000285 RID: 645
			private static readonly IntPtr NativeFieldInfoPtr_request;

			// Token: 0x04000286 RID: 646
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000287 RID: 647
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04000288 RID: 648
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000289 RID: 649
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400028A RID: 650
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000064 RID: 100
		[ObfuscatedName("Google.Apis.Http.GzipDeflateHandler+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060003F0 RID: 1008 RVA: 0x00011918 File Offset: 0x0000FB18
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GzipDeflateHandler.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GzipDeflateHandler>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GzipDeflateHandler.__c>.NativeClassPtr);
				GzipDeflateHandler.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GzipDeflateHandler.__c>.NativeClassPtr, "<>9");
				GzipDeflateHandler.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GzipDeflateHandler.__c>.NativeClassPtr, 100663696);
				GzipDeflateHandler.__c.NativeMethodInfoPtr___cctor_b__8_0_Internal_Stream_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GzipDeflateHandler.__c>.NativeClassPtr, 100663697);
				GzipDeflateHandler.__c.NativeMethodInfoPtr___cctor_b__8_1_Internal_Stream_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GzipDeflateHandler.__c>.NativeClassPtr, 100663698);
			}

			// Token: 0x060003F1 RID: 1009 RVA: 0x00011994 File Offset: 0x0000FB94
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GzipDeflateHandler.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GzipDeflateHandler.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003F2 RID: 1010 RVA: 0x000119D0 File Offset: 0x0000FBD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212749, XrefRangeEnd = 1212753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Stream __cctor_b__8_0(Stream original)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GzipDeflateHandler.__c.NativeMethodInfoPtr___cctor_b__8_0_Internal_Stream_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
				}
			}

			// Token: 0x060003F3 RID: 1011 RVA: 0x00011A20 File Offset: 0x0000FC20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212753, XrefRangeEnd = 1212757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Stream __cctor_b__8_1(Stream original)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GzipDeflateHandler.__c.NativeMethodInfoPtr___cctor_b__8_1_Internal_Stream_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
				}
			}

			// Token: 0x060003F4 RID: 1012 RVA: 0x00003E6C File Offset: 0x0000206C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000137 RID: 311
			// (get) Token: 0x060003F5 RID: 1013 RVA: 0x00011A70 File Offset: 0x0000FC70
			// (set) Token: 0x060003F6 RID: 1014 RVA: 0x00003E75 File Offset: 0x00002075
			public unsafe static GzipDeflateHandler.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GzipDeflateHandler.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GzipDeflateHandler.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GzipDeflateHandler.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400028B RID: 651
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400028C RID: 652
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400028D RID: 653
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__8_0_Internal_Stream_Stream_0;

			// Token: 0x0400028E RID: 654
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__8_1_Internal_Stream_Stream_0;
		}
	}
}
