using System;
using Google.Apis.Services;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Net.Http;

namespace Google.Apis.Upload
{
	// Token: 0x0200000A RID: 10
	public class ResumableUpload<TRequest, TResponse> : ResumableUpload<TRequest>
	{
		// Token: 0x060000A7 RID: 167 RVA: 0x000072EC File Offset: 0x000054EC
		// Note: this type is marked as 'beforefieldinit'.
		static ResumableUpload()
		{
			Il2CppClassPointerStore<ResumableUpload<TRequest, TResponse>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Google.Apis.dll", "Google.Apis.Upload", "ResumableUpload`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRequest>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResponse>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResumableUpload<TRequest, TResponse>>.NativeClassPtr);
			ResumableUpload<TRequest, TResponse>.NativeFieldInfoPtr__ResponseBody_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload<TRequest, TResponse>>.NativeClassPtr, "<ResponseBody>k__BackingField");
			ResumableUpload<TRequest, TResponse>.NativeFieldInfoPtr_ResponseReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload<TRequest, TResponse>>.NativeClassPtr, "ResponseReceived");
			ResumableUpload<TRequest, TResponse>.NativeMethodInfoPtr__ctor_Protected_Void_IClientService_String_String_Stream_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload<TRequest, TResponse>>.NativeClassPtr, 100663421);
			ResumableUpload<TRequest, TResponse>.NativeMethodInfoPtr_get_ResponseBody_Public_get_TResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload<TRequest, TResponse>>.NativeClassPtr, 100663422);
			ResumableUpload<TRequest, TResponse>.NativeMethodInfoPtr_set_ResponseBody_Private_set_Void_TResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload<TRequest, TResponse>>.NativeClassPtr, 100663423);
			ResumableUpload<TRequest, TResponse>.NativeMethodInfoPtr_add_ResponseReceived_Public_add_Void_Action_1_TResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload<TRequest, TResponse>>.NativeClassPtr, 100663424);
			ResumableUpload<TRequest, TResponse>.NativeMethodInfoPtr_remove_ResponseReceived_Public_rem_Void_Action_1_TResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload<TRequest, TResponse>>.NativeClassPtr, 100663425);
			ResumableUpload<TRequest, TResponse>.NativeMethodInfoPtr_ProcessResponse_Protected_Virtual_Void_HttpResponseMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload<TRequest, TResponse>>.NativeClassPtr, 100663426);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000740C File Offset: 0x0000560C
		[CallerCount(0)]
		public unsafe ResumableUpload(IClientService service, string path, string httpMethod, Stream contentStream, string contentType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResumableUpload<TRequest, TResponse>>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload<TRequest, TResponse>.NativeMethodInfoPtr__ctor_Protected_Void_IClientService_String_String_Stream_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x000074A4 File Offset: 0x000056A4
		// (set) Token: 0x060000AA RID: 170 RVA: 0x000074E0 File Offset: 0x000056E0
		public unsafe TResponse ResponseBody
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196780, XrefRangeEnd = 1196784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload<TRequest, TResponse>.NativeMethodInfoPtr_get_ResponseBody_Public_get_TResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TResponse>(intPtr, false, true);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196784, XrefRangeEnd = 1196787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TResponse).IsValueType)
					{
						TResponse tresponse = value;
						intPtr = ((tresponse is string) ? IL2CPP.ManagedStringToIl2Cpp(tresponse as string) : IL2CPP.Il2CppObjectBaseToPtr(tresponse as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ResumableUpload<TRequest, TResponse>.NativeMethodInfoPtr_set_ResponseBody_Private_set_Void_TResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00007558 File Offset: 0x00005758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196787, XrefRangeEnd = 1196794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ResponseReceived(Action<TResponse> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload<TRequest, TResponse>.NativeMethodInfoPtr_add_ResponseReceived_Public_add_Void_Action_1_TResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000759C File Offset: 0x0000579C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196794, XrefRangeEnd = 1196801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ResponseReceived(Action<TResponse> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload<TRequest, TResponse>.NativeMethodInfoPtr_remove_ResponseReceived_Public_rem_Void_Action_1_TResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000075E0 File Offset: 0x000057E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196801, XrefRangeEnd = 1196806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ProcessResponse(HttpResponseMessage response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResumableUpload<TRequest, TResponse>.NativeMethodInfoPtr_ProcessResponse_Protected_Virtual_Void_HttpResponseMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002403 File Offset: 0x00000603
		public ResumableUpload(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00007630 File Offset: 0x00005830
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x00007658 File Offset: 0x00005858
		public unsafe TResponse _ResponseBody_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload<TRequest, TResponse>.NativeFieldInfoPtr__ResponseBody_k__BackingField);
				return IL2CPP.PointerToValueGeneric<TResponse>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload<TRequest, TResponse>.NativeFieldInfoPtr__ResponseBody_k__BackingField);
				Type typeFromHandle = typeof(TResponse);
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

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00007700 File Offset: 0x00005900
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x0000240C File Offset: 0x0000060C
		public unsafe Action<TResponse> ResponseReceived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload<TRequest, TResponse>.NativeFieldInfoPtr_ResponseReceived);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TResponse>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload<TRequest, TResponse>.NativeFieldInfoPtr_ResponseReceived), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeFieldInfoPtr__ResponseBody_k__BackingField;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeFieldInfoPtr_ResponseReceived;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_IClientService_String_String_Stream_String_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_get_ResponseBody_Public_get_TResponse_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_set_ResponseBody_Private_set_Void_TResponse_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_add_ResponseReceived_Public_add_Void_Action_1_TResponse_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_remove_ResponseReceived_Public_rem_Void_Action_1_TResponse_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_ProcessResponse_Protected_Virtual_Void_HttpResponseMessage_0;
	}
}
