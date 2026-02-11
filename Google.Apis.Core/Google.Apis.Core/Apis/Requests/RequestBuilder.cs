using System;
using Google.Apis.Logging;
using Google.Apis.Util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Net.Http;
using Il2CppSystem.Text;
using Il2CppSystem.Text.RegularExpressions;

namespace Google.Apis.Requests
{
	// Token: 0x02000012 RID: 18
	public class RequestBuilder : Object
	{
		// Token: 0x0600007C RID: 124 RVA: 0x00005F7C File Offset: 0x0000417C
		// Note: this type is marked as 'beforefieldinit'.
		static RequestBuilder()
		{
			Il2CppClassPointerStore<RequestBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Requests", "RequestBuilder");
			RequestBuilder.NativeFieldInfoPtr_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestBuilder>.NativeClassPtr, "Logger");
			RequestBuilder.NativeFieldInfoPtr_PathParametersPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestBuilder>.NativeClassPtr, "PathParametersPattern");
			RequestBuilder.NativeFieldInfoPtr_SupportedMethods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestBuilder>.NativeClassPtr, "SupportedMethods");
			RequestBuilder.NativeFieldInfoPtr__PathParameters_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestBuilder>.NativeClassPtr, "<PathParameters>k__BackingField");
			RequestBuilder.NativeFieldInfoPtr__QueryParameters_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestBuilder>.NativeClassPtr, "<QueryParameters>k__BackingField");
			RequestBuilder.NativeFieldInfoPtr__BaseUri_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestBuilder>.NativeClassPtr, "<BaseUri>k__BackingField");
			RequestBuilder.NativeFieldInfoPtr__Path_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestBuilder>.NativeClassPtr, "<Path>k__BackingField");
			RequestBuilder.NativeFieldInfoPtr_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestBuilder>.NativeClassPtr, "method");
			RequestBuilder.NativeFieldInfoPtr_OPERATORS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestBuilder>.NativeClassPtr, "OPERATORS");
			RequestBuilder.NativeMethodInfoPtr_get_PathParameters_Private_get_IDictionary_2_String_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestBuilder>.NativeClassPtr, 100663364);
			RequestBuilder.NativeMethodInfoPtr_set_PathParameters_Private_set_Void_IDictionary_2_String_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestBuilder>.NativeClassPtr, 100663365);
			RequestBuilder.NativeMethodInfoPtr_get_QueryParameters_Private_get_List_1_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestBuilder>.NativeClassPtr, 100663366);
			RequestBuilder.NativeMethodInfoPtr_set_QueryParameters_Private_set_Void_List_1_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestBuilder>.NativeClassPtr, 100663367);
			RequestBuilder.NativeMethodInfoPtr_get_BaseUri_Public_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestBuilder>.NativeClassPtr, 100663368);
			RequestBuilder.NativeMethodInfoPtr_set_BaseUri_Public_set_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestBuilder>.NativeClassPtr, 100663369);
			RequestBuilder.NativeMethodInfoPtr_get_Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestBuilder>.NativeClassPtr, 100663370);
			RequestBuilder.NativeMethodInfoPtr_set_Path_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestBuilder>.NativeClassPtr, 100663371);
			RequestBuilder.NativeMethodInfoPtr_get_Method_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestBuilder>.NativeClassPtr, 100663372);
			RequestBuilder.NativeMethodInfoPtr_set_Method_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestBuilder>.NativeClassPtr, 100663373);
			RequestBuilder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestBuilder>.NativeClassPtr, 100663374);
			RequestBuilder.NativeMethodInfoPtr_BuildUri_Public_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestBuilder>.NativeClassPtr, 100663375);
			RequestBuilder.NativeMethodInfoPtr_UriJoin_Private_Uri_Uri_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestBuilder>.NativeClassPtr, 100663376);
			RequestBuilder.NativeMethodInfoPtr_BuildRestPath_Private_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestBuilder>.NativeClassPtr, 100663377);
			RequestBuilder.NativeMethodInfoPtr_AddParameter_Public_Void_RequestParameterType_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestBuilder>.NativeClassPtr, 100663378);
			RequestBuilder.NativeMethodInfoPtr_CreateRequest_Public_HttpRequestMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestBuilder>.NativeClassPtr, 100663379);
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00006198 File Offset: 0x00004398
		// (set) Token: 0x0600007E RID: 126 RVA: 0x000061D8 File Offset: 0x000043D8
		public unsafe IDictionary<string, IList<string>> PathParameters
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestBuilder.NativeMethodInfoPtr_get_PathParameters_Private_get_IDictionary_2_String_IList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, IList<string>>>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestBuilder.NativeMethodInfoPtr_set_PathParameters_Private_set_Void_IDictionary_2_String_IList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600007F RID: 127 RVA: 0x0000621C File Offset: 0x0000441C
		// (set) Token: 0x06000080 RID: 128 RVA: 0x0000625C File Offset: 0x0000445C
		public unsafe List<KeyValuePair<string, string>> QueryParameters
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestBuilder.NativeMethodInfoPtr_get_QueryParameters_Private_get_List_1_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<string, string>>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestBuilder.NativeMethodInfoPtr_set_QueryParameters_Private_set_Void_List_1_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000081 RID: 129 RVA: 0x000062A0 File Offset: 0x000044A0
		// (set) Token: 0x06000082 RID: 130 RVA: 0x000062E0 File Offset: 0x000044E0
		public unsafe Uri BaseUri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestBuilder.NativeMethodInfoPtr_get_BaseUri_Public_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestBuilder.NativeMethodInfoPtr_set_BaseUri_Public_set_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00006324 File Offset: 0x00004524
		// (set) Token: 0x06000084 RID: 132 RVA: 0x0000635C File Offset: 0x0000455C
		public unsafe string Path
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestBuilder.NativeMethodInfoPtr_get_Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestBuilder.NativeMethodInfoPtr_set_Path_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000085 RID: 133 RVA: 0x000063A0 File Offset: 0x000045A0
		// (set) Token: 0x06000086 RID: 134 RVA: 0x000063D8 File Offset: 0x000045D8
		public unsafe string Method
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestBuilder.NativeMethodInfoPtr_get_Method_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1210217, RefRangeEnd = 1210221, XrefRangeStart = 1210203, XrefRangeEnd = 1210217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestBuilder.NativeMethodInfoPtr_set_Method_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000641C File Offset: 0x0000461C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1210252, RefRangeEnd = 1210258, XrefRangeStart = 1210221, XrefRangeEnd = 1210252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RequestBuilder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestBuilder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestBuilder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00006458 File Offset: 0x00004658
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1210322, RefRangeEnd = 1210327, XrefRangeStart = 1210258, XrefRangeEnd = 1210322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Uri BuildUri()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestBuilder.NativeMethodInfoPtr_BuildUri_Public_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00006498 File Offset: 0x00004698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1210327, XrefRangeEnd = 1210357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Uri UriJoin(Uri baseUri, string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestBuilder.NativeMethodInfoPtr_UriJoin_Private_Uri_Uri_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000064FC File Offset: 0x000046FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1210507, RefRangeEnd = 1210508, XrefRangeStart = 1210357, XrefRangeEnd = 1210507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder BuildRestPath()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestBuilder.NativeMethodInfoPtr_BuildRestPath_Private_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000653C File Offset: 0x0000473C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1210544, RefRangeEnd = 1210552, XrefRangeStart = 1210508, XrefRangeEnd = 1210544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddParameter(RequestParameterType type, string name, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestBuilder.NativeMethodInfoPtr_AddParameter_Public_Void_RequestParameterType_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000065A0 File Offset: 0x000047A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1210561, RefRangeEnd = 1210565, XrefRangeStart = 1210552, XrefRangeEnd = 1210561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpRequestMessage CreateRequest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestBuilder.NativeMethodInfoPtr_CreateRequest_Public_HttpRequestMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpRequestMessage>(intPtr3) : null;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000022C0 File Offset: 0x000004C0
		public RequestBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600008E RID: 142 RVA: 0x000065E0 File Offset: 0x000047E0
		// (set) Token: 0x0600008F RID: 143 RVA: 0x000022C9 File Offset: 0x000004C9
		public unsafe static ILogger Logger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RequestBuilder.NativeFieldInfoPtr_Logger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RequestBuilder.NativeFieldInfoPtr_Logger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00006608 File Offset: 0x00004808
		// (set) Token: 0x06000091 RID: 145 RVA: 0x000022DB File Offset: 0x000004DB
		public unsafe static Regex PathParametersPattern
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RequestBuilder.NativeFieldInfoPtr_PathParametersPattern, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RequestBuilder.NativeFieldInfoPtr_PathParametersPattern, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00006630 File Offset: 0x00004830
		// (set) Token: 0x06000093 RID: 147 RVA: 0x000022ED File Offset: 0x000004ED
		public unsafe static IEnumerable<string> SupportedMethods
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RequestBuilder.NativeFieldInfoPtr_SupportedMethods, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RequestBuilder.NativeFieldInfoPtr_SupportedMethods, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00006658 File Offset: 0x00004858
		// (set) Token: 0x06000095 RID: 149 RVA: 0x000022FF File Offset: 0x000004FF
		public unsafe IDictionary<string, IList<string>> _PathParameters_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestBuilder.NativeFieldInfoPtr__PathParameters_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary<string, IList<string>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestBuilder.NativeFieldInfoPtr__PathParameters_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00006688 File Offset: 0x00004888
		// (set) Token: 0x06000097 RID: 151 RVA: 0x0000231E File Offset: 0x0000051E
		public unsafe List<KeyValuePair<string, string>> _QueryParameters_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestBuilder.NativeFieldInfoPtr__QueryParameters_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<string, string>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestBuilder.NativeFieldInfoPtr__QueryParameters_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000098 RID: 152 RVA: 0x000066B8 File Offset: 0x000048B8
		// (set) Token: 0x06000099 RID: 153 RVA: 0x0000233D File Offset: 0x0000053D
		public unsafe Uri _BaseUri_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestBuilder.NativeFieldInfoPtr__BaseUri_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestBuilder.NativeFieldInfoPtr__BaseUri_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600009A RID: 154 RVA: 0x000066E8 File Offset: 0x000048E8
		// (set) Token: 0x0600009B RID: 155 RVA: 0x0000235C File Offset: 0x0000055C
		public unsafe string _Path_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestBuilder.NativeFieldInfoPtr__Path_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestBuilder.NativeFieldInfoPtr__Path_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00006710 File Offset: 0x00004910
		// (set) Token: 0x0600009D RID: 157 RVA: 0x0000237B File Offset: 0x0000057B
		public unsafe string method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestBuilder.NativeFieldInfoPtr_method);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestBuilder.NativeFieldInfoPtr_method), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00006738 File Offset: 0x00004938
		// (set) Token: 0x0600009F RID: 159 RVA: 0x0000239A File Offset: 0x0000059A
		public unsafe static string OPERATORS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RequestBuilder.NativeFieldInfoPtr_OPERATORS, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RequestBuilder.NativeFieldInfoPtr_OPERATORS, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeFieldInfoPtr_Logger;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeFieldInfoPtr_PathParametersPattern;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeFieldInfoPtr_SupportedMethods;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeFieldInfoPtr__PathParameters_k__BackingField;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeFieldInfoPtr__QueryParameters_k__BackingField;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeFieldInfoPtr__BaseUri_k__BackingField;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeFieldInfoPtr__Path_k__BackingField;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeFieldInfoPtr_method;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeFieldInfoPtr_OPERATORS;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_get_PathParameters_Private_get_IDictionary_2_String_IList_1_String_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_set_PathParameters_Private_set_Void_IDictionary_2_String_IList_1_String_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_get_QueryParameters_Private_get_List_1_KeyValuePair_2_String_String_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_set_QueryParameters_Private_set_Void_List_1_KeyValuePair_2_String_String_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseUri_Public_get_Uri_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_set_BaseUri_Public_set_Void_Uri_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_get_Path_Public_get_String_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_set_Path_Public_set_Void_String_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_get_Method_Public_get_String_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_set_Method_Public_set_Void_String_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_BuildUri_Public_Uri_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_UriJoin_Private_Uri_Uri_String_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_BuildRestPath_Private_StringBuilder_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_AddParameter_Public_Void_RequestParameterType_String_String_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_CreateRequest_Public_HttpRequestMessage_0;

		// Token: 0x02000049 RID: 73
		[ObfuscatedName("Google.Apis.Requests.RequestBuilder+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060002C7 RID: 711 RVA: 0x0000E22C File Offset: 0x0000C42C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RequestBuilder.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RequestBuilder>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestBuilder.__c>.NativeClassPtr);
				RequestBuilder.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestBuilder.__c>.NativeClassPtr, "<>9");
				RequestBuilder.__c.NativeFieldInfoPtr___9__25_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestBuilder.__c>.NativeClassPtr, "<>9__25_0");
				RequestBuilder.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestBuilder.__c>.NativeClassPtr, 100663381);
				RequestBuilder.__c.NativeMethodInfoPtr__BuildUri_b__25_0_Internal_String_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestBuilder.__c>.NativeClassPtr, 100663382);
			}

			// Token: 0x060002C8 RID: 712 RVA: 0x0000E2A8 File Offset: 0x0000C4A8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestBuilder.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestBuilder.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002C9 RID: 713 RVA: 0x0000E2E4 File Offset: 0x0000C4E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1210190, XrefRangeEnd = 1210203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _BuildUri_b__25_0(KeyValuePair<string, string> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestBuilder.__c.NativeMethodInfoPtr__BuildUri_b__25_0_Internal_String_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060002CA RID: 714 RVA: 0x0000322A File Offset: 0x0000142A
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000D5 RID: 213
			// (get) Token: 0x060002CB RID: 715 RVA: 0x0000E334 File Offset: 0x0000C534
			// (set) Token: 0x060002CC RID: 716 RVA: 0x00003233 File Offset: 0x00001433
			public unsafe static RequestBuilder.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RequestBuilder.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestBuilder.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RequestBuilder.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000D6 RID: 214
			// (get) Token: 0x060002CD RID: 717 RVA: 0x0000E35C File Offset: 0x0000C55C
			// (set) Token: 0x060002CE RID: 718 RVA: 0x00003245 File Offset: 0x00001445
			public unsafe static Func<KeyValuePair<string, string>, string> __9__25_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RequestBuilder.__c.NativeFieldInfoPtr___9__25_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, string>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RequestBuilder.__c.NativeFieldInfoPtr___9__25_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001D9 RID: 473
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040001DA RID: 474
			private static readonly IntPtr NativeFieldInfoPtr___9__25_0;

			// Token: 0x040001DB RID: 475
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001DC RID: 476
			private static readonly IntPtr NativeMethodInfoPtr__BuildUri_b__25_0_Internal_String_KeyValuePair_2_String_String_0;
		}
	}
}
