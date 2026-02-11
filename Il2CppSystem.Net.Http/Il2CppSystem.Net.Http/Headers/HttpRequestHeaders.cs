using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.Http.Headers
{
	// Token: 0x02000027 RID: 39
	public sealed class HttpRequestHeaders : HttpHeaders
	{
		// Token: 0x0600027A RID: 634 RVA: 0x0000E57C File Offset: 0x0000C77C
		// Note: this type is marked as 'beforefieldinit'.
		static HttpRequestHeaders()
		{
			Il2CppClassPointerStore<HttpRequestHeaders>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http.Headers", "HttpRequestHeaders");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpRequestHeaders>.NativeClassPtr);
			HttpRequestHeaders.NativeFieldInfoPtr_expectContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpRequestHeaders>.NativeClassPtr, "expectContinue");
			HttpRequestHeaders.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestHeaders>.NativeClassPtr, 100663684);
			HttpRequestHeaders.NativeMethodInfoPtr_get_AcceptEncoding_Public_get_HttpHeaderValueCollection_1_StringWithQualityHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestHeaders>.NativeClassPtr, 100663685);
			HttpRequestHeaders.NativeMethodInfoPtr_get_Authorization_Public_get_AuthenticationHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestHeaders>.NativeClassPtr, 100663686);
			HttpRequestHeaders.NativeMethodInfoPtr_set_Authorization_Public_set_Void_AuthenticationHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestHeaders>.NativeClassPtr, 100663687);
			HttpRequestHeaders.NativeMethodInfoPtr_get_Connection_Public_get_HttpHeaderValueCollection_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestHeaders>.NativeClassPtr, 100663688);
			HttpRequestHeaders.NativeMethodInfoPtr_get_ConnectionClose_Public_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestHeaders>.NativeClassPtr, 100663689);
			HttpRequestHeaders.NativeMethodInfoPtr_get_Expect_Public_get_HttpHeaderValueCollection_1_NameValueWithParametersHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestHeaders>.NativeClassPtr, 100663690);
			HttpRequestHeaders.NativeMethodInfoPtr_get_ExpectContinue_Public_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestHeaders>.NativeClassPtr, 100663691);
			HttpRequestHeaders.NativeMethodInfoPtr_set_ExpectContinue_Public_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestHeaders>.NativeClassPtr, 100663692);
			HttpRequestHeaders.NativeMethodInfoPtr_get_Host_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestHeaders>.NativeClassPtr, 100663693);
			HttpRequestHeaders.NativeMethodInfoPtr_get_IfMatch_Public_get_HttpHeaderValueCollection_1_EntityTagHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestHeaders>.NativeClassPtr, 100663694);
			HttpRequestHeaders.NativeMethodInfoPtr_set_IfModifiedSince_Public_set_Void_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestHeaders>.NativeClassPtr, 100663695);
			HttpRequestHeaders.NativeMethodInfoPtr_get_IfNoneMatch_Public_get_HttpHeaderValueCollection_1_EntityTagHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestHeaders>.NativeClassPtr, 100663696);
			HttpRequestHeaders.NativeMethodInfoPtr_set_IfUnmodifiedSince_Public_set_Void_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestHeaders>.NativeClassPtr, 100663697);
			HttpRequestHeaders.NativeMethodInfoPtr_set_Range_Public_set_Void_RangeHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestHeaders>.NativeClassPtr, 100663698);
			HttpRequestHeaders.NativeMethodInfoPtr_get_TransferEncoding_Public_get_HttpHeaderValueCollection_1_TransferCodingHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestHeaders>.NativeClassPtr, 100663699);
			HttpRequestHeaders.NativeMethodInfoPtr_get_TransferEncodingChunked_Public_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestHeaders>.NativeClassPtr, 100663700);
			HttpRequestHeaders.NativeMethodInfoPtr_AddHeaders_Internal_Void_HttpRequestHeaders_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestHeaders>.NativeClassPtr, 100663701);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000E728 File Offset: 0x0000C928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174360, XrefRangeEnd = 1174364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpRequestHeaders()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpRequestHeaders>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestHeaders.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600027C RID: 636 RVA: 0x0000E764 File Offset: 0x0000C964
		public unsafe HttpHeaderValueCollection<StringWithQualityHeaderValue> AcceptEncoding
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1174369, RefRangeEnd = 1174371, XrefRangeStart = 1174364, XrefRangeEnd = 1174369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestHeaders.NativeMethodInfoPtr_get_AcceptEncoding_Public_get_HttpHeaderValueCollection_1_StringWithQualityHeaderValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpHeaderValueCollection<StringWithQualityHeaderValue>>(intPtr3) : null;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600027D RID: 637 RVA: 0x0000E7A4 File Offset: 0x0000C9A4
		// (set) Token: 0x0600027E RID: 638 RVA: 0x0000E7E4 File Offset: 0x0000C9E4
		public unsafe AuthenticationHeaderValue Authorization
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1174376, RefRangeEnd = 1174379, XrefRangeStart = 1174371, XrefRangeEnd = 1174376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestHeaders.NativeMethodInfoPtr_get_Authorization_Public_get_AuthenticationHeaderValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AuthenticationHeaderValue>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1174384, RefRangeEnd = 1174385, XrefRangeStart = 1174379, XrefRangeEnd = 1174384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestHeaders.NativeMethodInfoPtr_set_Authorization_Public_set_Void_AuthenticationHeaderValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600027F RID: 639 RVA: 0x0000E828 File Offset: 0x0000CA28
		public unsafe HttpHeaderValueCollection<string> Connection
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174385, XrefRangeEnd = 1174390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestHeaders.NativeMethodInfoPtr_get_Connection_Public_get_HttpHeaderValueCollection_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpHeaderValueCollection<string>>(intPtr3) : null;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000280 RID: 640 RVA: 0x0000E868 File Offset: 0x0000CA68
		public unsafe Nullable<bool> ConnectionClose
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174390, XrefRangeEnd = 1174416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestHeaders.NativeMethodInfoPtr_get_ConnectionClose_Public_get_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000281 RID: 641 RVA: 0x0000E8A0 File Offset: 0x0000CAA0
		public unsafe HttpHeaderValueCollection<NameValueWithParametersHeaderValue> Expect
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174416, XrefRangeEnd = 1174421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestHeaders.NativeMethodInfoPtr_get_Expect_Public_get_HttpHeaderValueCollection_1_NameValueWithParametersHeaderValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpHeaderValueCollection<NameValueWithParametersHeaderValue>>(intPtr3) : null;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000282 RID: 642 RVA: 0x0000E8E0 File Offset: 0x0000CAE0
		// (set) Token: 0x06000283 RID: 643 RVA: 0x0000E918 File Offset: 0x0000CB18
		public unsafe Nullable<bool> ExpectContinue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174421, XrefRangeEnd = 1174448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestHeaders.NativeMethodInfoPtr_get_ExpectContinue_Public_get_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1174490, RefRangeEnd = 1174492, XrefRangeStart = 1174448, XrefRangeEnd = 1174490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestHeaders.NativeMethodInfoPtr_set_ExpectContinue_Public_set_Void_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000284 RID: 644 RVA: 0x0000E960 File Offset: 0x0000CB60
		public unsafe string Host
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1174497, RefRangeEnd = 1174498, XrefRangeStart = 1174492, XrefRangeEnd = 1174497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestHeaders.NativeMethodInfoPtr_get_Host_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000285 RID: 645 RVA: 0x0000E998 File Offset: 0x0000CB98
		public unsafe HttpHeaderValueCollection<EntityTagHeaderValue> IfMatch
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1174503, RefRangeEnd = 1174505, XrefRangeStart = 1174498, XrefRangeEnd = 1174503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestHeaders.NativeMethodInfoPtr_get_IfMatch_Public_get_HttpHeaderValueCollection_1_EntityTagHeaderValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpHeaderValueCollection<EntityTagHeaderValue>>(intPtr3) : null;
			}
		}

		// Token: 0x170000CD RID: 205
		// (set) Token: 0x06000286 RID: 646 RVA: 0x0000E9D8 File Offset: 0x0000CBD8
		public unsafe Nullable<DateTimeOffset> IfModifiedSince
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1174514, RefRangeEnd = 1174516, XrefRangeStart = 1174505, XrefRangeEnd = 1174514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestHeaders.NativeMethodInfoPtr_set_IfModifiedSince_Public_set_Void_Nullable_1_DateTimeOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000287 RID: 647 RVA: 0x0000EA20 File Offset: 0x0000CC20
		public unsafe HttpHeaderValueCollection<EntityTagHeaderValue> IfNoneMatch
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1174521, RefRangeEnd = 1174523, XrefRangeStart = 1174516, XrefRangeEnd = 1174521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestHeaders.NativeMethodInfoPtr_get_IfNoneMatch_Public_get_HttpHeaderValueCollection_1_EntityTagHeaderValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpHeaderValueCollection<EntityTagHeaderValue>>(intPtr3) : null;
			}
		}

		// Token: 0x170000CF RID: 207
		// (set) Token: 0x06000288 RID: 648 RVA: 0x0000EA60 File Offset: 0x0000CC60
		public unsafe Nullable<DateTimeOffset> IfUnmodifiedSince
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1174532, RefRangeEnd = 1174534, XrefRangeStart = 1174523, XrefRangeEnd = 1174532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestHeaders.NativeMethodInfoPtr_set_IfUnmodifiedSince_Public_set_Void_Nullable_1_DateTimeOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000D0 RID: 208
		// (set) Token: 0x06000289 RID: 649 RVA: 0x0000EAA8 File Offset: 0x0000CCA8
		public unsafe RangeHeaderValue Range
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1174539, RefRangeEnd = 1174540, XrefRangeStart = 1174534, XrefRangeEnd = 1174539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestHeaders.NativeMethodInfoPtr_set_Range_Public_set_Void_RangeHeaderValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600028A RID: 650 RVA: 0x0000EAEC File Offset: 0x0000CCEC
		public unsafe HttpHeaderValueCollection<TransferCodingHeaderValue> TransferEncoding
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174540, XrefRangeEnd = 1174545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestHeaders.NativeMethodInfoPtr_get_TransferEncoding_Public_get_HttpHeaderValueCollection_1_TransferCodingHeaderValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpHeaderValueCollection<TransferCodingHeaderValue>>(intPtr3) : null;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600028B RID: 651 RVA: 0x0000EB2C File Offset: 0x0000CD2C
		public unsafe Nullable<bool> TransferEncodingChunked
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174545, XrefRangeEnd = 1174572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestHeaders.NativeMethodInfoPtr_get_TransferEncodingChunked_Public_get_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
			}
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000EB64 File Offset: 0x0000CD64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1174594, RefRangeEnd = 1174595, XrefRangeStart = 1174572, XrefRangeEnd = 1174594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddHeaders(HttpRequestHeaders headers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(headers);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestHeaders.NativeMethodInfoPtr_AddHeaders_Internal_Void_HttpRequestHeaders_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00002F21 File Offset: 0x00001121
		public HttpRequestHeaders(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600028E RID: 654 RVA: 0x0000EBA8 File Offset: 0x0000CDA8
		// (set) Token: 0x0600028F RID: 655 RVA: 0x00002F2A File Offset: 0x0000112A
		public Nullable<bool> expectContinue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpRequestHeaders.NativeFieldInfoPtr_expectContinue);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpRequestHeaders.NativeFieldInfoPtr_expectContinue), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeFieldInfoPtr_expectContinue;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeMethodInfoPtr_get_AcceptEncoding_Public_get_HttpHeaderValueCollection_1_StringWithQualityHeaderValue_0;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeMethodInfoPtr_get_Authorization_Public_get_AuthenticationHeaderValue_0;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeMethodInfoPtr_set_Authorization_Public_set_Void_AuthenticationHeaderValue_0;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeMethodInfoPtr_get_Connection_Public_get_HttpHeaderValueCollection_1_String_0;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeMethodInfoPtr_get_ConnectionClose_Public_get_Nullable_1_Boolean_0;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeMethodInfoPtr_get_Expect_Public_get_HttpHeaderValueCollection_1_NameValueWithParametersHeaderValue_0;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeMethodInfoPtr_get_ExpectContinue_Public_get_Nullable_1_Boolean_0;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeMethodInfoPtr_set_ExpectContinue_Public_set_Void_Nullable_1_Boolean_0;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeMethodInfoPtr_get_Host_Public_get_String_0;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeMethodInfoPtr_get_IfMatch_Public_get_HttpHeaderValueCollection_1_EntityTagHeaderValue_0;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeMethodInfoPtr_set_IfModifiedSince_Public_set_Void_Nullable_1_DateTimeOffset_0;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeMethodInfoPtr_get_IfNoneMatch_Public_get_HttpHeaderValueCollection_1_EntityTagHeaderValue_0;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeMethodInfoPtr_set_IfUnmodifiedSince_Public_set_Void_Nullable_1_DateTimeOffset_0;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeMethodInfoPtr_set_Range_Public_set_Void_RangeHeaderValue_0;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr_get_TransferEncoding_Public_get_HttpHeaderValueCollection_1_TransferCodingHeaderValue_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr_get_TransferEncodingChunked_Public_get_Nullable_1_Boolean_0;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr_AddHeaders_Internal_Void_HttpRequestHeaders_0;

		// Token: 0x02000059 RID: 89
		[ObfuscatedName("System.Net.Http.Headers.HttpRequestHeaders+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060004C5 RID: 1221 RVA: 0x00016CFC File Offset: 0x00014EFC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<HttpRequestHeaders.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HttpRequestHeaders>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpRequestHeaders.__c>.NativeClassPtr);
				HttpRequestHeaders.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpRequestHeaders.__c>.NativeClassPtr, "<>9");
				HttpRequestHeaders.__c.NativeFieldInfoPtr___9__19_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpRequestHeaders.__c>.NativeClassPtr, "<>9__19_0");
				HttpRequestHeaders.__c.NativeFieldInfoPtr___9__29_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpRequestHeaders.__c>.NativeClassPtr, "<>9__29_0");
				HttpRequestHeaders.__c.NativeFieldInfoPtr___9__30_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpRequestHeaders.__c>.NativeClassPtr, "<>9__30_0");
				HttpRequestHeaders.__c.NativeFieldInfoPtr___9__71_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpRequestHeaders.__c>.NativeClassPtr, "<>9__71_0");
				HttpRequestHeaders.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestHeaders.__c>.NativeClassPtr, 100663703);
				HttpRequestHeaders.__c.NativeMethodInfoPtr__get_ConnectionClose_b__19_0_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestHeaders.__c>.NativeClassPtr, 100663704);
				HttpRequestHeaders.__c.NativeMethodInfoPtr__get_ExpectContinue_b__29_0_Internal_Boolean_TransferCodingHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestHeaders.__c>.NativeClassPtr, 100663705);
				HttpRequestHeaders.__c.NativeMethodInfoPtr__set_ExpectContinue_b__30_0_Internal_Boolean_NameValueWithParametersHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestHeaders.__c>.NativeClassPtr, 100663706);
				HttpRequestHeaders.__c.NativeMethodInfoPtr__get_TransferEncodingChunked_b__71_0_Internal_Boolean_TransferCodingHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestHeaders.__c>.NativeClassPtr, 100663707);
			}

			// Token: 0x060004C6 RID: 1222 RVA: 0x00016DF0 File Offset: 0x00014FF0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpRequestHeaders.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestHeaders.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004C7 RID: 1223 RVA: 0x00016E2C File Offset: 0x0001502C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174303, XrefRangeEnd = 1174306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_ConnectionClose_b__19_0(string l)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(l);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestHeaders.__c.NativeMethodInfoPtr__get_ConnectionClose_b__19_0_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060004C8 RID: 1224 RVA: 0x00016E7C File Offset: 0x0001507C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174306, XrefRangeEnd = 1174310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_ExpectContinue_b__29_0(TransferCodingHeaderValue l)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestHeaders.__c.NativeMethodInfoPtr__get_ExpectContinue_b__29_0_Internal_Boolean_TransferCodingHeaderValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060004C9 RID: 1225 RVA: 0x00016ECC File Offset: 0x000150CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174310, XrefRangeEnd = 1174356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _set_ExpectContinue_b__30_0(NameValueWithParametersHeaderValue l)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestHeaders.__c.NativeMethodInfoPtr__set_ExpectContinue_b__30_0_Internal_Boolean_NameValueWithParametersHeaderValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060004CA RID: 1226 RVA: 0x00016F1C File Offset: 0x0001511C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174356, XrefRangeEnd = 1174360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_TransferEncodingChunked_b__71_0(TransferCodingHeaderValue l)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestHeaders.__c.NativeMethodInfoPtr__get_TransferEncodingChunked_b__71_0_Internal_Boolean_TransferCodingHeaderValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060004CB RID: 1227 RVA: 0x00004087 File Offset: 0x00002287
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700016F RID: 367
			// (get) Token: 0x060004CC RID: 1228 RVA: 0x00016F6C File Offset: 0x0001516C
			// (set) Token: 0x060004CD RID: 1229 RVA: 0x00004090 File Offset: 0x00002290
			public unsafe static HttpRequestHeaders.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HttpRequestHeaders.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpRequestHeaders.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HttpRequestHeaders.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000170 RID: 368
			// (get) Token: 0x060004CE RID: 1230 RVA: 0x00016F94 File Offset: 0x00015194
			// (set) Token: 0x060004CF RID: 1231 RVA: 0x000040A2 File Offset: 0x000022A2
			public unsafe static Predicate<string> __9__19_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HttpRequestHeaders.__c.NativeFieldInfoPtr___9__19_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HttpRequestHeaders.__c.NativeFieldInfoPtr___9__19_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000171 RID: 369
			// (get) Token: 0x060004D0 RID: 1232 RVA: 0x00016FBC File Offset: 0x000151BC
			// (set) Token: 0x060004D1 RID: 1233 RVA: 0x000040B4 File Offset: 0x000022B4
			public unsafe static Predicate<TransferCodingHeaderValue> __9__29_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HttpRequestHeaders.__c.NativeFieldInfoPtr___9__29_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<TransferCodingHeaderValue>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HttpRequestHeaders.__c.NativeFieldInfoPtr___9__29_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000172 RID: 370
			// (get) Token: 0x060004D2 RID: 1234 RVA: 0x00016FE4 File Offset: 0x000151E4
			// (set) Token: 0x060004D3 RID: 1235 RVA: 0x000040C6 File Offset: 0x000022C6
			public unsafe static Predicate<NameValueWithParametersHeaderValue> __9__30_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HttpRequestHeaders.__c.NativeFieldInfoPtr___9__30_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<NameValueWithParametersHeaderValue>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HttpRequestHeaders.__c.NativeFieldInfoPtr___9__30_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000173 RID: 371
			// (get) Token: 0x060004D4 RID: 1236 RVA: 0x0001700C File Offset: 0x0001520C
			// (set) Token: 0x060004D5 RID: 1237 RVA: 0x000040D8 File Offset: 0x000022D8
			public unsafe static Predicate<TransferCodingHeaderValue> __9__71_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HttpRequestHeaders.__c.NativeFieldInfoPtr___9__71_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<TransferCodingHeaderValue>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HttpRequestHeaders.__c.NativeFieldInfoPtr___9__71_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000357 RID: 855
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000358 RID: 856
			private static readonly IntPtr NativeFieldInfoPtr___9__19_0;

			// Token: 0x04000359 RID: 857
			private static readonly IntPtr NativeFieldInfoPtr___9__29_0;

			// Token: 0x0400035A RID: 858
			private static readonly IntPtr NativeFieldInfoPtr___9__30_0;

			// Token: 0x0400035B RID: 859
			private static readonly IntPtr NativeFieldInfoPtr___9__71_0;

			// Token: 0x0400035C RID: 860
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400035D RID: 861
			private static readonly IntPtr NativeMethodInfoPtr__get_ConnectionClose_b__19_0_Internal_Boolean_String_0;

			// Token: 0x0400035E RID: 862
			private static readonly IntPtr NativeMethodInfoPtr__get_ExpectContinue_b__29_0_Internal_Boolean_TransferCodingHeaderValue_0;

			// Token: 0x0400035F RID: 863
			private static readonly IntPtr NativeMethodInfoPtr__set_ExpectContinue_b__30_0_Internal_Boolean_NameValueWithParametersHeaderValue_0;

			// Token: 0x04000360 RID: 864
			private static readonly IntPtr NativeMethodInfoPtr__get_TransferEncodingChunked_b__71_0_Internal_Boolean_TransferCodingHeaderValue_0;
		}
	}
}
