using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Net.Http.Headers;

namespace Il2CppSystem.Net.Http
{
	// Token: 0x02000013 RID: 19
	public class HttpResponseMessage : Object
	{
		// Token: 0x0600011B RID: 283 RVA: 0x0000863C File Offset: 0x0000683C
		// Note: this type is marked as 'beforefieldinit'.
		static HttpResponseMessage()
		{
			Il2CppClassPointerStore<HttpResponseMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http", "HttpResponseMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpResponseMessage>.NativeClassPtr);
			HttpResponseMessage.NativeFieldInfoPtr_headers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpResponseMessage>.NativeClassPtr, "headers");
			HttpResponseMessage.NativeFieldInfoPtr_reasonPhrase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpResponseMessage>.NativeClassPtr, "reasonPhrase");
			HttpResponseMessage.NativeFieldInfoPtr_statusCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpResponseMessage>.NativeClassPtr, "statusCode");
			HttpResponseMessage.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpResponseMessage>.NativeClassPtr, "version");
			HttpResponseMessage.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpResponseMessage>.NativeClassPtr, "disposed");
			HttpResponseMessage.NativeFieldInfoPtr__Content_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpResponseMessage>.NativeClassPtr, "<Content>k__BackingField");
			HttpResponseMessage.NativeFieldInfoPtr__RequestMessage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpResponseMessage>.NativeClassPtr, "<RequestMessage>k__BackingField");
			HttpResponseMessage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpResponseMessage>.NativeClassPtr, 100663457);
			HttpResponseMessage.NativeMethodInfoPtr__ctor_Public_Void_HttpStatusCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpResponseMessage>.NativeClassPtr, 100663458);
			HttpResponseMessage.NativeMethodInfoPtr_get_Content_Public_get_HttpContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpResponseMessage>.NativeClassPtr, 100663459);
			HttpResponseMessage.NativeMethodInfoPtr_set_Content_Public_set_Void_HttpContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpResponseMessage>.NativeClassPtr, 100663460);
			HttpResponseMessage.NativeMethodInfoPtr_get_Headers_Public_get_HttpResponseHeaders_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpResponseMessage>.NativeClassPtr, 100663461);
			HttpResponseMessage.NativeMethodInfoPtr_get_IsSuccessStatusCode_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpResponseMessage>.NativeClassPtr, 100663462);
			HttpResponseMessage.NativeMethodInfoPtr_get_ReasonPhrase_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpResponseMessage>.NativeClassPtr, 100663463);
			HttpResponseMessage.NativeMethodInfoPtr_set_ReasonPhrase_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpResponseMessage>.NativeClassPtr, 100663464);
			HttpResponseMessage.NativeMethodInfoPtr_get_RequestMessage_Public_get_HttpRequestMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpResponseMessage>.NativeClassPtr, 100663465);
			HttpResponseMessage.NativeMethodInfoPtr_set_RequestMessage_Public_set_Void_HttpRequestMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpResponseMessage>.NativeClassPtr, 100663466);
			HttpResponseMessage.NativeMethodInfoPtr_get_StatusCode_Public_get_HttpStatusCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpResponseMessage>.NativeClassPtr, 100663467);
			HttpResponseMessage.NativeMethodInfoPtr_set_StatusCode_Public_set_Void_HttpStatusCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpResponseMessage>.NativeClassPtr, 100663468);
			HttpResponseMessage.NativeMethodInfoPtr_get_Version_Public_get_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpResponseMessage>.NativeClassPtr, 100663469);
			HttpResponseMessage.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpResponseMessage>.NativeClassPtr, 100663470);
			HttpResponseMessage.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpResponseMessage>.NativeClassPtr, 100663471);
			HttpResponseMessage.NativeMethodInfoPtr_EnsureSuccessStatusCode_Public_HttpResponseMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpResponseMessage>.NativeClassPtr, 100663472);
			HttpResponseMessage.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpResponseMessage>.NativeClassPtr, 100663473);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000884C File Offset: 0x00006A4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1172015, RefRangeEnd = 1172016, XrefRangeStart = 1172014, XrefRangeEnd = 1172015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpResponseMessage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpResponseMessage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpResponseMessage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00008888 File Offset: 0x00006A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172016, XrefRangeEnd = 1172017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpResponseMessage(HttpStatusCode statusCode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpResponseMessage>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref statusCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpResponseMessage.NativeMethodInfoPtr__ctor_Public_Void_HttpStatusCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600011E RID: 286 RVA: 0x000088D0 File Offset: 0x00006AD0
		// (set) Token: 0x0600011F RID: 287 RVA: 0x00008910 File Offset: 0x00006B10
		public unsafe HttpContent Content
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpResponseMessage.NativeMethodInfoPtr_get_Content_Public_get_HttpContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpContent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpResponseMessage.NativeMethodInfoPtr_set_Content_Public_set_Void_HttpContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00008954 File Offset: 0x00006B54
		public unsafe HttpResponseHeaders Headers
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 1172025, RefRangeEnd = 1172040, XrefRangeStart = 1172017, XrefRangeEnd = 1172025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpResponseMessage.NativeMethodInfoPtr_get_Headers_Public_get_HttpResponseHeaders_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpResponseHeaders>(intPtr3) : null;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00008994 File Offset: 0x00006B94
		public unsafe bool IsSuccessStatusCode
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 1172040, RefRangeEnd = 1172050, XrefRangeStart = 1172040, XrefRangeEnd = 1172040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpResponseMessage.NativeMethodInfoPtr_get_IsSuccessStatusCode_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000122 RID: 290 RVA: 0x000089D0 File Offset: 0x00006BD0
		// (set) Token: 0x06000123 RID: 291 RVA: 0x00008A08 File Offset: 0x00006C08
		public unsafe string ReasonPhrase
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1172051, RefRangeEnd = 1172052, XrefRangeStart = 1172050, XrefRangeEnd = 1172051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpResponseMessage.NativeMethodInfoPtr_get_ReasonPhrase_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpResponseMessage.NativeMethodInfoPtr_set_ReasonPhrase_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00008A4C File Offset: 0x00006C4C
		// (set) Token: 0x06000125 RID: 293 RVA: 0x00008A8C File Offset: 0x00006C8C
		public unsafe HttpRequestMessage RequestMessage
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpResponseMessage.NativeMethodInfoPtr_get_RequestMessage_Public_get_HttpRequestMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpRequestMessage>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpResponseMessage.NativeMethodInfoPtr_set_RequestMessage_Public_set_Void_HttpRequestMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00008AD0 File Offset: 0x00006CD0
		// (set) Token: 0x06000127 RID: 295 RVA: 0x00008B0C File Offset: 0x00006D0C
		public unsafe HttpStatusCode StatusCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpResponseMessage.NativeMethodInfoPtr_get_StatusCode_Public_get_HttpStatusCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1172052, RefRangeEnd = 1172053, XrefRangeStart = 1172052, XrefRangeEnd = 1172052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpResponseMessage.NativeMethodInfoPtr_set_StatusCode_Public_set_Void_HttpStatusCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00008B4C File Offset: 0x00006D4C
		public unsafe Version Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172053, XrefRangeEnd = 1172057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpResponseMessage.NativeMethodInfoPtr_get_Version_Public_get_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00008B8C File Offset: 0x00006D8C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 451127, RefRangeEnd = 451138, XrefRangeStart = 451127, XrefRangeEnd = 451138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpResponseMessage.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00008BC0 File Offset: 0x00006DC0
		[CallerCount(0)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpResponseMessage.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00008C0C File Offset: 0x00006E0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1172057, RefRangeEnd = 1172058, XrefRangeStart = 1172057, XrefRangeEnd = 1172057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpResponseMessage EnsureSuccessStatusCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpResponseMessage.NativeMethodInfoPtr_EnsureSuccessStatusCode_Public_HttpResponseMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpResponseMessage>(intPtr3) : null;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00008C4C File Offset: 0x00006E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172058, XrefRangeEnd = 1172098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpResponseMessage.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002760 File Offset: 0x00000960
		public HttpResponseMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00008C90 File Offset: 0x00006E90
		// (set) Token: 0x0600012F RID: 303 RVA: 0x00002769 File Offset: 0x00000969
		public unsafe HttpResponseHeaders headers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpResponseMessage.NativeFieldInfoPtr_headers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpResponseHeaders>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpResponseMessage.NativeFieldInfoPtr_headers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00008CC0 File Offset: 0x00006EC0
		// (set) Token: 0x06000131 RID: 305 RVA: 0x00002788 File Offset: 0x00000988
		public unsafe string reasonPhrase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpResponseMessage.NativeFieldInfoPtr_reasonPhrase);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpResponseMessage.NativeFieldInfoPtr_reasonPhrase), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00008CE8 File Offset: 0x00006EE8
		// (set) Token: 0x06000133 RID: 307 RVA: 0x000027A7 File Offset: 0x000009A7
		public unsafe HttpStatusCode statusCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpResponseMessage.NativeFieldInfoPtr_statusCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpResponseMessage.NativeFieldInfoPtr_statusCode)) = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00008D10 File Offset: 0x00006F10
		// (set) Token: 0x06000135 RID: 309 RVA: 0x000027C2 File Offset: 0x000009C2
		public unsafe Version version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpResponseMessage.NativeFieldInfoPtr_version);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpResponseMessage.NativeFieldInfoPtr_version), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00008D40 File Offset: 0x00006F40
		// (set) Token: 0x06000137 RID: 311 RVA: 0x000027E1 File Offset: 0x000009E1
		public unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpResponseMessage.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpResponseMessage.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00008D68 File Offset: 0x00006F68
		// (set) Token: 0x06000139 RID: 313 RVA: 0x000027FC File Offset: 0x000009FC
		public unsafe HttpContent _Content_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpResponseMessage.NativeFieldInfoPtr__Content_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpResponseMessage.NativeFieldInfoPtr__Content_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00008D98 File Offset: 0x00006F98
		// (set) Token: 0x0600013B RID: 315 RVA: 0x0000281B File Offset: 0x00000A1B
		public unsafe HttpRequestMessage _RequestMessage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpResponseMessage.NativeFieldInfoPtr__RequestMessage_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpRequestMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpResponseMessage.NativeFieldInfoPtr__RequestMessage_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeFieldInfoPtr_headers;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeFieldInfoPtr_reasonPhrase;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeFieldInfoPtr_statusCode;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeFieldInfoPtr__Content_k__BackingField;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeFieldInfoPtr__RequestMessage_k__BackingField;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_HttpStatusCode_0;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr_get_Content_Public_get_HttpContent_0;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr_set_Content_Public_set_Void_HttpContent_0;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeMethodInfoPtr_get_Headers_Public_get_HttpResponseHeaders_0;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSuccessStatusCode_Public_get_Boolean_0;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr_get_ReasonPhrase_Public_get_String_0;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_set_ReasonPhrase_Public_set_Void_String_0;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestMessage_Public_get_HttpRequestMessage_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_set_RequestMessage_Public_set_Void_HttpRequestMessage_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_get_StatusCode_Public_get_HttpStatusCode_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_set_StatusCode_Public_set_Void_HttpStatusCode_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_get_Version_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_EnsureSuccessStatusCode_Public_HttpResponseMessage_0;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
