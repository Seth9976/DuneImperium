using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Net.Http.Headers;

namespace Il2CppSystem.Net.Http
{
	// Token: 0x02000012 RID: 18
	public class HttpRequestMessage : Object
	{
		// Token: 0x060000F9 RID: 249 RVA: 0x00007E6C File Offset: 0x0000606C
		// Note: this type is marked as 'beforefieldinit'.
		static HttpRequestMessage()
		{
			Il2CppClassPointerStore<HttpRequestMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http", "HttpRequestMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpRequestMessage>.NativeClassPtr);
			HttpRequestMessage.NativeFieldInfoPtr_headers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpRequestMessage>.NativeClassPtr, "headers");
			HttpRequestMessage.NativeFieldInfoPtr_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpRequestMessage>.NativeClassPtr, "method");
			HttpRequestMessage.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpRequestMessage>.NativeClassPtr, "version");
			HttpRequestMessage.NativeFieldInfoPtr_properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpRequestMessage>.NativeClassPtr, "properties");
			HttpRequestMessage.NativeFieldInfoPtr_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpRequestMessage>.NativeClassPtr, "uri");
			HttpRequestMessage.NativeFieldInfoPtr_is_used = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpRequestMessage>.NativeClassPtr, "is_used");
			HttpRequestMessage.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpRequestMessage>.NativeClassPtr, "disposed");
			HttpRequestMessage.NativeFieldInfoPtr__Content_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpRequestMessage>.NativeClassPtr, "<Content>k__BackingField");
			HttpRequestMessage.NativeMethodInfoPtr__ctor_Public_Void_HttpMethod_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestMessage>.NativeClassPtr, 100663441);
			HttpRequestMessage.NativeMethodInfoPtr__ctor_Public_Void_HttpMethod_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestMessage>.NativeClassPtr, 100663442);
			HttpRequestMessage.NativeMethodInfoPtr_get_Content_Public_get_HttpContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestMessage>.NativeClassPtr, 100663443);
			HttpRequestMessage.NativeMethodInfoPtr_set_Content_Public_set_Void_HttpContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestMessage>.NativeClassPtr, 100663444);
			HttpRequestMessage.NativeMethodInfoPtr_get_Headers_Public_get_HttpRequestHeaders_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestMessage>.NativeClassPtr, 100663445);
			HttpRequestMessage.NativeMethodInfoPtr_get_Method_Public_get_HttpMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestMessage>.NativeClassPtr, 100663446);
			HttpRequestMessage.NativeMethodInfoPtr_set_Method_Public_set_Void_HttpMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestMessage>.NativeClassPtr, 100663447);
			HttpRequestMessage.NativeMethodInfoPtr_get_Properties_Public_get_IDictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestMessage>.NativeClassPtr, 100663448);
			HttpRequestMessage.NativeMethodInfoPtr_get_RequestUri_Public_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestMessage>.NativeClassPtr, 100663449);
			HttpRequestMessage.NativeMethodInfoPtr_set_RequestUri_Public_set_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestMessage>.NativeClassPtr, 100663450);
			HttpRequestMessage.NativeMethodInfoPtr_IsAllowedAbsoluteUri_Private_Static_Boolean_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestMessage>.NativeClassPtr, 100663451);
			HttpRequestMessage.NativeMethodInfoPtr_get_Version_Public_get_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestMessage>.NativeClassPtr, 100663452);
			HttpRequestMessage.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestMessage>.NativeClassPtr, 100663453);
			HttpRequestMessage.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestMessage>.NativeClassPtr, 100663454);
			HttpRequestMessage.NativeMethodInfoPtr_SetIsUsed_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestMessage>.NativeClassPtr, 100663455);
			HttpRequestMessage.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestMessage>.NativeClassPtr, 100663456);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000807C File Offset: 0x0000627C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1171803, RefRangeEnd = 1171806, XrefRangeStart = 1171796, XrefRangeEnd = 1171803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpRequestMessage(HttpMethod method, string requestUri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpRequestMessage>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(requestUri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestMessage.NativeMethodInfoPtr__ctor_Public_Void_HttpMethod_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000080DC File Offset: 0x000062DC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1171818, RefRangeEnd = 1171826, XrefRangeStart = 1171806, XrefRangeEnd = 1171818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpRequestMessage(HttpMethod method, Uri requestUri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpRequestMessage>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(requestUri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestMessage.NativeMethodInfoPtr__ctor_Public_Void_HttpMethod_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000FC RID: 252 RVA: 0x0000813C File Offset: 0x0000633C
		// (set) Token: 0x060000FD RID: 253 RVA: 0x0000817C File Offset: 0x0000637C
		public unsafe HttpContent Content
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestMessage.NativeMethodInfoPtr_get_Content_Public_get_HttpContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestMessage.NativeMethodInfoPtr_set_Content_Public_set_Void_HttpContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000FE RID: 254 RVA: 0x000081C0 File Offset: 0x000063C0
		public unsafe HttpRequestHeaders Headers
		{
			[CallerCount(39)]
			[CachedScanResults(RefRangeStart = 1171834, RefRangeEnd = 1171873, XrefRangeStart = 1171826, XrefRangeEnd = 1171834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestMessage.NativeMethodInfoPtr_get_Headers_Public_get_HttpRequestHeaders_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpRequestHeaders>(intPtr3) : null;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00008200 File Offset: 0x00006400
		// (set) Token: 0x06000100 RID: 256 RVA: 0x00008240 File Offset: 0x00006440
		public unsafe HttpMethod Method
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestMessage.NativeMethodInfoPtr_get_Method_Public_get_HttpMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpMethod>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1171883, RefRangeEnd = 1171887, XrefRangeStart = 1171873, XrefRangeEnd = 1171883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestMessage.NativeMethodInfoPtr_set_Method_Public_set_Void_HttpMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00008284 File Offset: 0x00006484
		public unsafe IDictionary<string, Object> Properties
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 1171894, RefRangeEnd = 1171904, XrefRangeStart = 1171887, XrefRangeEnd = 1171894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestMessage.NativeMethodInfoPtr_get_Properties_Public_get_IDictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000102 RID: 258 RVA: 0x000082C4 File Offset: 0x000064C4
		// (set) Token: 0x06000103 RID: 259 RVA: 0x00008304 File Offset: 0x00006504
		public unsafe Uri RequestUri
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestMessage.NativeMethodInfoPtr_get_RequestUri_Public_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1171937, RefRangeEnd = 1171946, XrefRangeStart = 1171904, XrefRangeEnd = 1171937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestMessage.NativeMethodInfoPtr_set_RequestUri_Public_set_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00008348 File Offset: 0x00006548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171946, XrefRangeEnd = 1171966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsAllowedAbsoluteUri(Uri uri)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestMessage.NativeMethodInfoPtr_IsAllowedAbsoluteUri_Private_Static_Boolean_Uri_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000105 RID: 261 RVA: 0x0000838C File Offset: 0x0000658C
		public unsafe Version Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171966, XrefRangeEnd = 1171970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestMessage.NativeMethodInfoPtr_get_Version_Public_get_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000083CC File Offset: 0x000065CC
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 451127, RefRangeEnd = 451138, XrefRangeStart = 451127, XrefRangeEnd = 451138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestMessage.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00008400 File Offset: 0x00006600
		[CallerCount(0)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpRequestMessage.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000844C File Offset: 0x0000664C
		[CallerCount(0)]
		public unsafe bool SetIsUsed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestMessage.NativeMethodInfoPtr_SetIsUsed_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00008488 File Offset: 0x00006688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171970, XrefRangeEnd = 1172014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpRequestMessage.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002667 File Offset: 0x00000867
		public HttpRequestMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600010B RID: 267 RVA: 0x000084CC File Offset: 0x000066CC
		// (set) Token: 0x0600010C RID: 268 RVA: 0x00002670 File Offset: 0x00000870
		public unsafe HttpRequestHeaders headers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpRequestMessage.NativeFieldInfoPtr_headers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpRequestHeaders>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpRequestMessage.NativeFieldInfoPtr_headers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600010D RID: 269 RVA: 0x000084FC File Offset: 0x000066FC
		// (set) Token: 0x0600010E RID: 270 RVA: 0x0000268F File Offset: 0x0000088F
		public unsafe HttpMethod method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpRequestMessage.NativeFieldInfoPtr_method);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpMethod>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpRequestMessage.NativeFieldInfoPtr_method), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600010F RID: 271 RVA: 0x0000852C File Offset: 0x0000672C
		// (set) Token: 0x06000110 RID: 272 RVA: 0x000026AE File Offset: 0x000008AE
		public unsafe Version version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpRequestMessage.NativeFieldInfoPtr_version);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpRequestMessage.NativeFieldInfoPtr_version), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000111 RID: 273 RVA: 0x0000855C File Offset: 0x0000675C
		// (set) Token: 0x06000112 RID: 274 RVA: 0x000026CD File Offset: 0x000008CD
		public unsafe Dictionary<string, Object> properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpRequestMessage.NativeFieldInfoPtr_properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpRequestMessage.NativeFieldInfoPtr_properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000113 RID: 275 RVA: 0x0000858C File Offset: 0x0000678C
		// (set) Token: 0x06000114 RID: 276 RVA: 0x000026EC File Offset: 0x000008EC
		public unsafe Uri uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpRequestMessage.NativeFieldInfoPtr_uri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpRequestMessage.NativeFieldInfoPtr_uri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000115 RID: 277 RVA: 0x000085BC File Offset: 0x000067BC
		// (set) Token: 0x06000116 RID: 278 RVA: 0x0000270B File Offset: 0x0000090B
		public unsafe bool is_used
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpRequestMessage.NativeFieldInfoPtr_is_used);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpRequestMessage.NativeFieldInfoPtr_is_used)) = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000117 RID: 279 RVA: 0x000085E4 File Offset: 0x000067E4
		// (set) Token: 0x06000118 RID: 280 RVA: 0x00002726 File Offset: 0x00000926
		public unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpRequestMessage.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpRequestMessage.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000119 RID: 281 RVA: 0x0000860C File Offset: 0x0000680C
		// (set) Token: 0x0600011A RID: 282 RVA: 0x00002741 File Offset: 0x00000941
		public unsafe HttpContent _Content_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpRequestMessage.NativeFieldInfoPtr__Content_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpRequestMessage.NativeFieldInfoPtr__Content_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeFieldInfoPtr_headers;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeFieldInfoPtr_method;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeFieldInfoPtr_properties;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeFieldInfoPtr_uri;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeFieldInfoPtr_is_used;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeFieldInfoPtr__Content_k__BackingField;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_HttpMethod_String_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_HttpMethod_Uri_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_get_Content_Public_get_HttpContent_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_set_Content_Public_set_Void_HttpContent_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_get_Headers_Public_get_HttpRequestHeaders_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_get_Method_Public_get_HttpMethod_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_set_Method_Public_set_Void_HttpMethod_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_get_IDictionary_2_String_Object_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestUri_Public_get_Uri_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_set_RequestUri_Public_set_Void_Uri_0;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_IsAllowedAbsoluteUri_Private_Static_Boolean_Uri_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_get_Version_0;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_SetIsUsed_Internal_Boolean_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
