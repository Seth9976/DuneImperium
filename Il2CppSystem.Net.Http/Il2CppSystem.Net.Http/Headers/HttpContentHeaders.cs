using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Net.Http.Headers
{
	// Token: 0x02000023 RID: 35
	public sealed class HttpContentHeaders : HttpHeaders
	{
		// Token: 0x06000223 RID: 547 RVA: 0x0000CA88 File Offset: 0x0000AC88
		// Note: this type is marked as 'beforefieldinit'.
		static HttpContentHeaders()
		{
			Il2CppClassPointerStore<HttpContentHeaders>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http.Headers", "HttpContentHeaders");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpContentHeaders>.NativeClassPtr);
			HttpContentHeaders.NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpContentHeaders>.NativeClassPtr, "content");
			HttpContentHeaders.NativeMethodInfoPtr__ctor_Internal_Void_HttpContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContentHeaders>.NativeClassPtr, 100663610);
			HttpContentHeaders.NativeMethodInfoPtr_get_Allow_Public_get_ICollection_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContentHeaders>.NativeClassPtr, 100663611);
			HttpContentHeaders.NativeMethodInfoPtr_get_ContentEncoding_Public_get_ICollection_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContentHeaders>.NativeClassPtr, 100663612);
			HttpContentHeaders.NativeMethodInfoPtr_get_ContentDisposition_Public_get_ContentDispositionHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContentHeaders>.NativeClassPtr, 100663613);
			HttpContentHeaders.NativeMethodInfoPtr_set_ContentDisposition_Public_set_Void_ContentDispositionHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContentHeaders>.NativeClassPtr, 100663614);
			HttpContentHeaders.NativeMethodInfoPtr_get_ContentLanguage_Public_get_ICollection_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContentHeaders>.NativeClassPtr, 100663615);
			HttpContentHeaders.NativeMethodInfoPtr_get_ContentLength_Public_get_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContentHeaders>.NativeClassPtr, 100663616);
			HttpContentHeaders.NativeMethodInfoPtr_set_ContentLength_Public_set_Void_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContentHeaders>.NativeClassPtr, 100663617);
			HttpContentHeaders.NativeMethodInfoPtr_get_ContentLocation_Public_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContentHeaders>.NativeClassPtr, 100663618);
			HttpContentHeaders.NativeMethodInfoPtr_set_ContentLocation_Public_set_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContentHeaders>.NativeClassPtr, 100663619);
			HttpContentHeaders.NativeMethodInfoPtr_get_ContentMD5_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContentHeaders>.NativeClassPtr, 100663620);
			HttpContentHeaders.NativeMethodInfoPtr_set_ContentMD5_Public_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContentHeaders>.NativeClassPtr, 100663621);
			HttpContentHeaders.NativeMethodInfoPtr_get_ContentRange_Public_get_ContentRangeHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContentHeaders>.NativeClassPtr, 100663622);
			HttpContentHeaders.NativeMethodInfoPtr_set_ContentRange_Public_set_Void_ContentRangeHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContentHeaders>.NativeClassPtr, 100663623);
			HttpContentHeaders.NativeMethodInfoPtr_get_ContentType_Public_get_MediaTypeHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContentHeaders>.NativeClassPtr, 100663624);
			HttpContentHeaders.NativeMethodInfoPtr_set_ContentType_Public_set_Void_MediaTypeHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContentHeaders>.NativeClassPtr, 100663625);
			HttpContentHeaders.NativeMethodInfoPtr_get_Expires_Public_get_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContentHeaders>.NativeClassPtr, 100663626);
			HttpContentHeaders.NativeMethodInfoPtr_set_Expires_Public_set_Void_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContentHeaders>.NativeClassPtr, 100663627);
			HttpContentHeaders.NativeMethodInfoPtr_get_LastModified_Public_get_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContentHeaders>.NativeClassPtr, 100663628);
			HttpContentHeaders.NativeMethodInfoPtr_set_LastModified_Public_set_Void_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContentHeaders>.NativeClassPtr, 100663629);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000CC5C File Offset: 0x0000AE5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173549, XrefRangeEnd = 1173554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpContentHeaders(HttpContent content)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpContentHeaders>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContentHeaders.NativeMethodInfoPtr__ctor_Internal_Void_HttpContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000225 RID: 549 RVA: 0x0000CCA8 File Offset: 0x0000AEA8
		public unsafe ICollection<string> Allow
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173554, XrefRangeEnd = 1173559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContentHeaders.NativeMethodInfoPtr_get_Allow_Public_get_ICollection_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<string>>(intPtr3) : null;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000226 RID: 550 RVA: 0x0000CCE8 File Offset: 0x0000AEE8
		public unsafe ICollection<string> ContentEncoding
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1173564, RefRangeEnd = 1173570, XrefRangeStart = 1173559, XrefRangeEnd = 1173564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContentHeaders.NativeMethodInfoPtr_get_ContentEncoding_Public_get_ICollection_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<string>>(intPtr3) : null;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000227 RID: 551 RVA: 0x0000CD28 File Offset: 0x0000AF28
		// (set) Token: 0x06000228 RID: 552 RVA: 0x0000CD68 File Offset: 0x0000AF68
		public unsafe ContentDispositionHeaderValue ContentDisposition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173570, XrefRangeEnd = 1173575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContentHeaders.NativeMethodInfoPtr_get_ContentDisposition_Public_get_ContentDispositionHeaderValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContentDispositionHeaderValue>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173575, XrefRangeEnd = 1173580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContentHeaders.NativeMethodInfoPtr_set_ContentDisposition_Public_set_Void_ContentDispositionHeaderValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000229 RID: 553 RVA: 0x0000CDAC File Offset: 0x0000AFAC
		public unsafe ICollection<string> ContentLanguage
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173580, XrefRangeEnd = 1173585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContentHeaders.NativeMethodInfoPtr_get_ContentLanguage_Public_get_ICollection_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<string>>(intPtr3) : null;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600022A RID: 554 RVA: 0x0000CDEC File Offset: 0x0000AFEC
		// (set) Token: 0x0600022B RID: 555 RVA: 0x0000CE24 File Offset: 0x0000B024
		public unsafe Nullable<long> ContentLength
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1173597, RefRangeEnd = 1173599, XrefRangeStart = 1173585, XrefRangeEnd = 1173597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContentHeaders.NativeMethodInfoPtr_get_ContentLength_Public_get_Nullable_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<long>(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1173604, RefRangeEnd = 1173606, XrefRangeStart = 1173599, XrefRangeEnd = 1173604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContentHeaders.NativeMethodInfoPtr_set_ContentLength_Public_set_Void_Nullable_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600022C RID: 556 RVA: 0x0000CE6C File Offset: 0x0000B06C
		// (set) Token: 0x0600022D RID: 557 RVA: 0x0000CEAC File Offset: 0x0000B0AC
		public unsafe Uri ContentLocation
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173606, XrefRangeEnd = 1173611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContentHeaders.NativeMethodInfoPtr_get_ContentLocation_Public_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173611, XrefRangeEnd = 1173616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContentHeaders.NativeMethodInfoPtr_set_ContentLocation_Public_set_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600022E RID: 558 RVA: 0x0000CEF0 File Offset: 0x0000B0F0
		// (set) Token: 0x0600022F RID: 559 RVA: 0x0000CF30 File Offset: 0x0000B130
		public unsafe Il2CppStructArray<byte> ContentMD5
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173616, XrefRangeEnd = 1173621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContentHeaders.NativeMethodInfoPtr_get_ContentMD5_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173621, XrefRangeEnd = 1173630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContentHeaders.NativeMethodInfoPtr_set_ContentMD5_Public_set_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000230 RID: 560 RVA: 0x0000CF74 File Offset: 0x0000B174
		// (set) Token: 0x06000231 RID: 561 RVA: 0x0000CFB4 File Offset: 0x0000B1B4
		public unsafe ContentRangeHeaderValue ContentRange
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173630, XrefRangeEnd = 1173635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContentHeaders.NativeMethodInfoPtr_get_ContentRange_Public_get_ContentRangeHeaderValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContentRangeHeaderValue>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173635, XrefRangeEnd = 1173640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContentHeaders.NativeMethodInfoPtr_set_ContentRange_Public_set_Void_ContentRangeHeaderValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000232 RID: 562 RVA: 0x0000CFF8 File Offset: 0x0000B1F8
		// (set) Token: 0x06000233 RID: 563 RVA: 0x0000D038 File Offset: 0x0000B238
		public unsafe MediaTypeHeaderValue ContentType
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1173645, RefRangeEnd = 1173647, XrefRangeStart = 1173640, XrefRangeEnd = 1173645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContentHeaders.NativeMethodInfoPtr_get_ContentType_Public_get_MediaTypeHeaderValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MediaTypeHeaderValue>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1173652, RefRangeEnd = 1173656, XrefRangeStart = 1173647, XrefRangeEnd = 1173652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContentHeaders.NativeMethodInfoPtr_set_ContentType_Public_set_Void_MediaTypeHeaderValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000234 RID: 564 RVA: 0x0000D07C File Offset: 0x0000B27C
		// (set) Token: 0x06000235 RID: 565 RVA: 0x0000D0B4 File Offset: 0x0000B2B4
		public unsafe Nullable<DateTimeOffset> Expires
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173656, XrefRangeEnd = 1173661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContentHeaders.NativeMethodInfoPtr_get_Expires_Public_get_Nullable_1_DateTimeOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<DateTimeOffset>(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173661, XrefRangeEnd = 1173670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContentHeaders.NativeMethodInfoPtr_set_Expires_Public_set_Void_Nullable_1_DateTimeOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000236 RID: 566 RVA: 0x0000D0FC File Offset: 0x0000B2FC
		// (set) Token: 0x06000237 RID: 567 RVA: 0x0000D134 File Offset: 0x0000B334
		public unsafe Nullable<DateTimeOffset> LastModified
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173670, XrefRangeEnd = 1173675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContentHeaders.NativeMethodInfoPtr_get_LastModified_Public_get_Nullable_1_DateTimeOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<DateTimeOffset>(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173675, XrefRangeEnd = 1173684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContentHeaders.NativeMethodInfoPtr_set_LastModified_Public_set_Void_Nullable_1_DateTimeOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00002DC3 File Offset: 0x00000FC3
		public HttpContentHeaders(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000239 RID: 569 RVA: 0x0000D17C File Offset: 0x0000B37C
		// (set) Token: 0x0600023A RID: 570 RVA: 0x00002DCC File Offset: 0x00000FCC
		public unsafe HttpContent content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContentHeaders.NativeFieldInfoPtr_content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpContentHeaders.NativeFieldInfoPtr_content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeFieldInfoPtr_content;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_HttpContent_0;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr_get_Allow_Public_get_ICollection_1_String_0;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentEncoding_Public_get_ICollection_1_String_0;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentDisposition_Public_get_ContentDispositionHeaderValue_0;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeMethodInfoPtr_set_ContentDisposition_Public_set_Void_ContentDispositionHeaderValue_0;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentLanguage_Public_get_ICollection_1_String_0;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentLength_Public_get_Nullable_1_Int64_0;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_set_ContentLength_Public_set_Void_Nullable_1_Int64_0;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentLocation_Public_get_Uri_0;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeMethodInfoPtr_set_ContentLocation_Public_set_Void_Uri_0;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentMD5_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeMethodInfoPtr_set_ContentMD5_Public_set_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentRange_Public_get_ContentRangeHeaderValue_0;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeMethodInfoPtr_set_ContentRange_Public_set_Void_ContentRangeHeaderValue_0;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentType_Public_get_MediaTypeHeaderValue_0;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeMethodInfoPtr_set_ContentType_Public_set_Void_MediaTypeHeaderValue_0;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeMethodInfoPtr_get_Expires_Public_get_Nullable_1_DateTimeOffset_0;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeMethodInfoPtr_set_Expires_Public_set_Void_Nullable_1_DateTimeOffset_0;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeMethodInfoPtr_get_LastModified_Public_get_Nullable_1_DateTimeOffset_0;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeMethodInfoPtr_set_LastModified_Public_set_Void_Nullable_1_DateTimeOffset_0;
	}
}
