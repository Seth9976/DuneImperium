using System;
using Google.Apis.Requests;
using Google.Apis.Services;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Net.Http;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Upload
{
	// Token: 0x02000009 RID: 9
	public class ResumableUpload<TRequest> : ResumableUpload
	{
		// Token: 0x06000085 RID: 133 RVA: 0x00006A94 File Offset: 0x00004C94
		// Note: this type is marked as 'beforefieldinit'.
		static ResumableUpload()
		{
			Il2CppClassPointerStore<ResumableUpload<TRequest>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Google.Apis.dll", "Google.Apis.Upload", "ResumableUpload`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRequest>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResumableUpload<TRequest>>.NativeClassPtr);
			ResumableUpload<TRequest>.NativeFieldInfoPtr_PayloadContentTypeHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload<TRequest>>.NativeClassPtr, "PayloadContentTypeHeader");
			ResumableUpload<TRequest>.NativeFieldInfoPtr_PayloadContentLengthHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload<TRequest>>.NativeClassPtr, "PayloadContentLengthHeader");
			ResumableUpload<TRequest>.NativeFieldInfoPtr_UploadType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload<TRequest>>.NativeClassPtr, "UploadType");
			ResumableUpload<TRequest>.NativeFieldInfoPtr_Resumable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload<TRequest>>.NativeClassPtr, "Resumable");
			ResumableUpload<TRequest>.NativeFieldInfoPtr__Service_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload<TRequest>>.NativeClassPtr, "<Service>k__BackingField");
			ResumableUpload<TRequest>.NativeFieldInfoPtr__Path_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload<TRequest>>.NativeClassPtr, "<Path>k__BackingField");
			ResumableUpload<TRequest>.NativeFieldInfoPtr__HttpMethod_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload<TRequest>>.NativeClassPtr, "<HttpMethod>k__BackingField");
			ResumableUpload<TRequest>.NativeFieldInfoPtr__ContentType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload<TRequest>>.NativeClassPtr, "<ContentType>k__BackingField");
			ResumableUpload<TRequest>.NativeFieldInfoPtr__Body_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload<TRequest>>.NativeClassPtr, "<Body>k__BackingField");
			ResumableUpload<TRequest>.NativeMethodInfoPtr__ctor_Protected_Void_IClientService_String_String_Stream_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload<TRequest>>.NativeClassPtr, 100663405);
			ResumableUpload<TRequest>.NativeMethodInfoPtr_get_Service_Public_get_IClientService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload<TRequest>>.NativeClassPtr, 100663406);
			ResumableUpload<TRequest>.NativeMethodInfoPtr_set_Service_Private_set_Void_IClientService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload<TRequest>>.NativeClassPtr, 100663407);
			ResumableUpload<TRequest>.NativeMethodInfoPtr_get_Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload<TRequest>>.NativeClassPtr, 100663408);
			ResumableUpload<TRequest>.NativeMethodInfoPtr_set_Path_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload<TRequest>>.NativeClassPtr, 100663409);
			ResumableUpload<TRequest>.NativeMethodInfoPtr_get_HttpMethod_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload<TRequest>>.NativeClassPtr, 100663410);
			ResumableUpload<TRequest>.NativeMethodInfoPtr_set_HttpMethod_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload<TRequest>>.NativeClassPtr, 100663411);
			ResumableUpload<TRequest>.NativeMethodInfoPtr_get_ContentType_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload<TRequest>>.NativeClassPtr, 100663412);
			ResumableUpload<TRequest>.NativeMethodInfoPtr_set_ContentType_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload<TRequest>>.NativeClassPtr, 100663413);
			ResumableUpload<TRequest>.NativeMethodInfoPtr_get_Body_Public_get_TRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload<TRequest>>.NativeClassPtr, 100663414);
			ResumableUpload<TRequest>.NativeMethodInfoPtr_set_Body_Public_set_Void_TRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload<TRequest>>.NativeClassPtr, 100663415);
			ResumableUpload<TRequest>.NativeMethodInfoPtr_InitiateSessionAsync_Public_Virtual_Task_1_Uri_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload<TRequest>>.NativeClassPtr, 100663416);
			ResumableUpload<TRequest>.NativeMethodInfoPtr_CreateInitializeRequest_Private_HttpRequestMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload<TRequest>>.NativeClassPtr, 100663417);
			ResumableUpload<TRequest>.NativeMethodInfoPtr_SetAllPropertyValues_Private_Void_RequestBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload<TRequest>>.NativeClassPtr, 100663418);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00006CCC File Offset: 0x00004ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196640, XrefRangeEnd = 1196678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResumableUpload(IClientService service, string path, string httpMethod, Stream contentStream, string contentType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResumableUpload<TRequest>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(service);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(httpMethod);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contentStream);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(contentType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload<TRequest>.NativeMethodInfoPtr__ctor_Protected_Void_IClientService_String_String_Stream_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00006D64 File Offset: 0x00004F64
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00006DA4 File Offset: 0x00004FA4
		public unsafe IClientService Service
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196678, XrefRangeEnd = 1196679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload<TRequest>.NativeMethodInfoPtr_get_Service_Public_get_IClientService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IClientService>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196679, XrefRangeEnd = 1196682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload<TRequest>.NativeMethodInfoPtr_set_Service_Private_set_Void_IClientService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00006DE8 File Offset: 0x00004FE8
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00006E20 File Offset: 0x00005020
		public unsafe string Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196682, XrefRangeEnd = 1196683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload<TRequest>.NativeMethodInfoPtr_get_Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196683, XrefRangeEnd = 1196686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload<TRequest>.NativeMethodInfoPtr_set_Path_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00006E64 File Offset: 0x00005064
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00006E9C File Offset: 0x0000509C
		public unsafe string HttpMethod
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196686, XrefRangeEnd = 1196687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload<TRequest>.NativeMethodInfoPtr_get_HttpMethod_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196687, XrefRangeEnd = 1196690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload<TRequest>.NativeMethodInfoPtr_set_HttpMethod_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00006EE0 File Offset: 0x000050E0
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00006F18 File Offset: 0x00005118
		public unsafe string ContentType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196690, XrefRangeEnd = 1196691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload<TRequest>.NativeMethodInfoPtr_get_ContentType_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196691, XrefRangeEnd = 1196694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload<TRequest>.NativeMethodInfoPtr_set_ContentType_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00006F5C File Offset: 0x0000515C
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00006F98 File Offset: 0x00005198
		public unsafe TRequest Body
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196694, XrefRangeEnd = 1196698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload<TRequest>.NativeMethodInfoPtr_get_Body_Public_get_TRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TRequest>(intPtr, false, true);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196698, XrefRangeEnd = 1196701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TRequest).IsValueType)
					{
						TRequest trequest = value;
						intPtr = ((trequest is string) ? IL2CPP.ManagedStringToIl2Cpp(trequest as string) : IL2CPP.Il2CppObjectBaseToPtr(trequest as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ResumableUpload<TRequest>.NativeMethodInfoPtr_set_Body_Public_set_Void_TRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00007010 File Offset: 0x00005210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196701, XrefRangeEnd = 1196713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<Uri> InitiateSessionAsync(CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResumableUpload<TRequest>.NativeMethodInfoPtr_InitiateSessionAsync_Public_Virtual_Task_1_Uri_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Uri>>(intPtr3) : null;
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00007070 File Offset: 0x00005270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196713, XrefRangeEnd = 1196751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpRequestMessage CreateInitializeRequest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload<TRequest>.NativeMethodInfoPtr_CreateInitializeRequest_Private_HttpRequestMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpRequestMessage>(intPtr3) : null;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000070B0 File Offset: 0x000052B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196751, XrefRangeEnd = 1196780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAllPropertyValues(RequestBuilder requestBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requestBuilder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload<TRequest>.NativeMethodInfoPtr_SetAllPropertyValues_Private_Void_RequestBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002336 File Offset: 0x00000536
		public ResumableUpload(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000095 RID: 149 RVA: 0x000070F4 File Offset: 0x000052F4
		// (set) Token: 0x06000096 RID: 150 RVA: 0x0000233F File Offset: 0x0000053F
		public unsafe static string PayloadContentTypeHeader
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResumableUpload<TRequest>.NativeFieldInfoPtr_PayloadContentTypeHeader, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResumableUpload<TRequest>.NativeFieldInfoPtr_PayloadContentTypeHeader, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00007114 File Offset: 0x00005314
		// (set) Token: 0x06000098 RID: 152 RVA: 0x00002351 File Offset: 0x00000551
		public unsafe static string PayloadContentLengthHeader
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResumableUpload<TRequest>.NativeFieldInfoPtr_PayloadContentLengthHeader, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResumableUpload<TRequest>.NativeFieldInfoPtr_PayloadContentLengthHeader, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00007134 File Offset: 0x00005334
		// (set) Token: 0x0600009A RID: 154 RVA: 0x00002363 File Offset: 0x00000563
		public unsafe static string UploadType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResumableUpload<TRequest>.NativeFieldInfoPtr_UploadType, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResumableUpload<TRequest>.NativeFieldInfoPtr_UploadType, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00007154 File Offset: 0x00005354
		// (set) Token: 0x0600009C RID: 156 RVA: 0x00002375 File Offset: 0x00000575
		public unsafe static string Resumable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResumableUpload<TRequest>.NativeFieldInfoPtr_Resumable, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResumableUpload<TRequest>.NativeFieldInfoPtr_Resumable, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00007174 File Offset: 0x00005374
		// (set) Token: 0x0600009E RID: 158 RVA: 0x00002387 File Offset: 0x00000587
		public unsafe IClientService _Service_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload<TRequest>.NativeFieldInfoPtr__Service_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IClientService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload<TRequest>.NativeFieldInfoPtr__Service_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600009F RID: 159 RVA: 0x000071A4 File Offset: 0x000053A4
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x000023A6 File Offset: 0x000005A6
		public unsafe string _Path_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload<TRequest>.NativeFieldInfoPtr__Path_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload<TRequest>.NativeFieldInfoPtr__Path_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x000071CC File Offset: 0x000053CC
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x000023C5 File Offset: 0x000005C5
		public unsafe string _HttpMethod_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload<TRequest>.NativeFieldInfoPtr__HttpMethod_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload<TRequest>.NativeFieldInfoPtr__HttpMethod_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x000071F4 File Offset: 0x000053F4
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x000023E4 File Offset: 0x000005E4
		public unsafe string _ContentType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload<TRequest>.NativeFieldInfoPtr__ContentType_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload<TRequest>.NativeFieldInfoPtr__ContentType_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x0000721C File Offset: 0x0000541C
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x00007244 File Offset: 0x00005444
		public unsafe TRequest _Body_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload<TRequest>.NativeFieldInfoPtr__Body_k__BackingField);
				return IL2CPP.PointerToValueGeneric<TRequest>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload<TRequest>.NativeFieldInfoPtr__Body_k__BackingField);
				Type typeFromHandle = typeof(TRequest);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeFieldInfoPtr_PayloadContentTypeHeader;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeFieldInfoPtr_PayloadContentLengthHeader;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr_UploadType;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeFieldInfoPtr_Resumable;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeFieldInfoPtr__Service_k__BackingField;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeFieldInfoPtr__Path_k__BackingField;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeFieldInfoPtr__HttpMethod_k__BackingField;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeFieldInfoPtr__ContentType_k__BackingField;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeFieldInfoPtr__Body_k__BackingField;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_IClientService_String_String_Stream_String_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_get_Service_Public_get_IClientService_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_set_Service_Private_set_Void_IClientService_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_get_Path_Public_get_String_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_set_Path_Private_set_Void_String_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_get_HttpMethod_Public_get_String_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_set_HttpMethod_Private_set_Void_String_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentType_Public_get_String_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_set_ContentType_Private_set_Void_String_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_get_Body_Public_get_TRequest_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_set_Body_Public_set_Void_TRequest_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_InitiateSessionAsync_Public_Virtual_Task_1_Uri_CancellationToken_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_CreateInitializeRequest_Private_HttpRequestMessage_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_SetAllPropertyValues_Private_Void_RequestBuilder_0;

		// Token: 0x0200002F RID: 47
		[ObfuscatedName("Google.Apis.Upload.ResumableUpload`1+<InitiateSessionAsync>d__25")]
		public sealed class _InitiateSessionAsync_d__25 : ValueType
		{
			// Token: 0x06000285 RID: 645 RVA: 0x0000DF84 File Offset: 0x0000C184
			// Note: this type is marked as 'beforefieldinit'.
			static _InitiateSessionAsync_d__25()
			{
				Il2CppClassPointerStore<ResumableUpload<TRequest>._InitiateSessionAsync_d__25>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResumableUpload<TRequest>>.NativeClassPtr, "<InitiateSessionAsync>d__25"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRequest>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResumableUpload<TRequest>._InitiateSessionAsync_d__25>.NativeClassPtr);
				ResumableUpload<TRequest>._InitiateSessionAsync_d__25.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload<TRequest>._InitiateSessionAsync_d__25>.NativeClassPtr, "<>1__state");
				ResumableUpload<TRequest>._InitiateSessionAsync_d__25.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload<TRequest>._InitiateSessionAsync_d__25>.NativeClassPtr, "<>t__builder");
				ResumableUpload<TRequest>._InitiateSessionAsync_d__25.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload<TRequest>._InitiateSessionAsync_d__25>.NativeClassPtr, "<>4__this");
				ResumableUpload<TRequest>._InitiateSessionAsync_d__25.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload<TRequest>._InitiateSessionAsync_d__25>.NativeClassPtr, "cancellationToken");
				ResumableUpload<TRequest>._InitiateSessionAsync_d__25.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload<TRequest>._InitiateSessionAsync_d__25>.NativeClassPtr, "<>u__1");
				ResumableUpload<TRequest>._InitiateSessionAsync_d__25.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload<TRequest>._InitiateSessionAsync_d__25>.NativeClassPtr, "<>u__2");
				ResumableUpload<TRequest>._InitiateSessionAsync_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload<TRequest>._InitiateSessionAsync_d__25>.NativeClassPtr, 100663419);
				ResumableUpload<TRequest>._InitiateSessionAsync_d__25.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload<TRequest>._InitiateSessionAsync_d__25>.NativeClassPtr, 100663420);
			}

			// Token: 0x06000286 RID: 646 RVA: 0x0000E08C File Offset: 0x0000C28C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196602, XrefRangeEnd = 1196634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload<TRequest>._InitiateSessionAsync_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000287 RID: 647 RVA: 0x0000E0C4 File Offset: 0x0000C2C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196634, XrefRangeEnd = 1196640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload<TRequest>._InitiateSessionAsync_d__25.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000288 RID: 648 RVA: 0x0000327D File Offset: 0x0000147D
			public _InitiateSessionAsync_d__25(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000289 RID: 649 RVA: 0x00003286 File Offset: 0x00001486
			public _InitiateSessionAsync_d__25()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResumableUpload<TRequest>._InitiateSessionAsync_d__25>.NativeClassPtr))
			{
			}

			// Token: 0x170000DC RID: 220
			// (get) Token: 0x0600028A RID: 650 RVA: 0x0000E10C File Offset: 0x0000C30C
			// (set) Token: 0x0600028B RID: 651 RVA: 0x00003298 File Offset: 0x00001498
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload<TRequest>._InitiateSessionAsync_d__25.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload<TRequest>._InitiateSessionAsync_d__25.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000DD RID: 221
			// (get) Token: 0x0600028C RID: 652 RVA: 0x0000E134 File Offset: 0x0000C334
			// (set) Token: 0x0600028D RID: 653 RVA: 0x000032B3 File Offset: 0x000014B3
			public AsyncTaskMethodBuilder<Uri> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload<TRequest>._InitiateSessionAsync_d__25.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Uri>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Uri>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload<TRequest>._InitiateSessionAsync_d__25.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Uri>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000DE RID: 222
			// (get) Token: 0x0600028E RID: 654 RVA: 0x0000E164 File Offset: 0x0000C364
			// (set) Token: 0x0600028F RID: 655 RVA: 0x000032E1 File Offset: 0x000014E1
			public unsafe ResumableUpload<TRequest> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload<TRequest>._InitiateSessionAsync_d__25.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResumableUpload<TRequest>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload<TRequest>._InitiateSessionAsync_d__25.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000DF RID: 223
			// (get) Token: 0x06000290 RID: 656 RVA: 0x0000E194 File Offset: 0x0000C394
			// (set) Token: 0x06000291 RID: 657 RVA: 0x00003300 File Offset: 0x00001500
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload<TRequest>._InitiateSessionAsync_d__25.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload<TRequest>._InitiateSessionAsync_d__25.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000E0 RID: 224
			// (get) Token: 0x06000292 RID: 658 RVA: 0x0000E1C4 File Offset: 0x0000C3C4
			// (set) Token: 0x06000293 RID: 659 RVA: 0x0000332E File Offset: 0x0000152E
			public ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload<TRequest>._InitiateSessionAsync_d__25.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload<TRequest>._InitiateSessionAsync_d__25.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000E1 RID: 225
			// (get) Token: 0x06000294 RID: 660 RVA: 0x0000E1F4 File Offset: 0x0000C3F4
			// (set) Token: 0x06000295 RID: 661 RVA: 0x0000335C File Offset: 0x0000155C
			public ConfiguredTaskAwaitable<GoogleApiException>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload<TRequest>._InitiateSessionAsync_d__25.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<GoogleApiException>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<GoogleApiException>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload<TRequest>._InitiateSessionAsync_d__25.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<GoogleApiException>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040001BC RID: 444
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040001BD RID: 445
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040001BE RID: 446
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040001BF RID: 447
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040001C0 RID: 448
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040001C1 RID: 449
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040001C2 RID: 450
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001C3 RID: 451
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
