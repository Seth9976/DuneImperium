using System;
using Google.Apis.Requests;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Util
{
	// Token: 0x0200000C RID: 12
	public sealed class StandardResponse<InnerType> : Object
	{
		// Token: 0x06000052 RID: 82 RVA: 0x0000547C File Offset: 0x0000367C
		// Note: this type is marked as 'beforefieldinit'.
		static StandardResponse()
		{
			Il2CppClassPointerStore<StandardResponse<InnerType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Util", "StandardResponse`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<InnerType>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StandardResponse<InnerType>>.NativeClassPtr);
			StandardResponse<InnerType>.NativeFieldInfoPtr__Data_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardResponse<InnerType>>.NativeClassPtr, "<Data>k__BackingField");
			StandardResponse<InnerType>.NativeFieldInfoPtr__Error_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardResponse<InnerType>>.NativeClassPtr, "<Error>k__BackingField");
			StandardResponse<InnerType>.NativeMethodInfoPtr_get_Data_Public_get_InnerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardResponse<InnerType>>.NativeClassPtr, 100663337);
			StandardResponse<InnerType>.NativeMethodInfoPtr_set_Data_Public_set_Void_InnerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardResponse<InnerType>>.NativeClassPtr, 100663338);
			StandardResponse<InnerType>.NativeMethodInfoPtr_get_Error_Public_get_RequestError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardResponse<InnerType>>.NativeClassPtr, 100663339);
			StandardResponse<InnerType>.NativeMethodInfoPtr_set_Error_Public_set_Void_RequestError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardResponse<InnerType>>.NativeClassPtr, 100663340);
			StandardResponse<InnerType>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardResponse<InnerType>>.NativeClassPtr, 100663341);
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00005574 File Offset: 0x00003774
		// (set) Token: 0x06000054 RID: 84 RVA: 0x000055B0 File Offset: 0x000037B0
		public unsafe InnerType Data
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardResponse<InnerType>.NativeMethodInfoPtr_get_Data_Public_get_InnerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<InnerType>(intPtr, false, true);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(InnerType).IsValueType)
					{
						InnerType innerType = value;
						intPtr = ((innerType is string) ? IL2CPP.ManagedStringToIl2Cpp(innerType as string) : IL2CPP.Il2CppObjectBaseToPtr(innerType as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StandardResponse<InnerType>.NativeMethodInfoPtr_set_Data_Public_set_Void_InnerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00005628 File Offset: 0x00003828
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00005668 File Offset: 0x00003868
		public unsafe RequestError Error
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardResponse<InnerType>.NativeMethodInfoPtr_get_Error_Public_get_RequestError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RequestError>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardResponse<InnerType>.NativeMethodInfoPtr_set_Error_Public_set_Void_RequestError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000056AC File Offset: 0x000038AC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StandardResponse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StandardResponse<InnerType>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardResponse<InnerType>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000021DA File Offset: 0x000003DA
		public StandardResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000059 RID: 89 RVA: 0x000056E8 File Offset: 0x000038E8
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00005710 File Offset: 0x00003910
		public unsafe InnerType _Data_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardResponse<InnerType>.NativeFieldInfoPtr__Data_k__BackingField);
				return IL2CPP.PointerToValueGeneric<InnerType>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardResponse<InnerType>.NativeFieldInfoPtr__Data_k__BackingField);
				Type typeFromHandle = typeof(InnerType);
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

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600005B RID: 91 RVA: 0x000057B8 File Offset: 0x000039B8
		// (set) Token: 0x0600005C RID: 92 RVA: 0x000021E3 File Offset: 0x000003E3
		public unsafe RequestError _Error_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardResponse<InnerType>.NativeFieldInfoPtr__Error_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestError>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardResponse<InnerType>.NativeFieldInfoPtr__Error_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr__Data_k__BackingField;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeFieldInfoPtr__Error_k__BackingField;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_get_InnerType_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_set_Data_Public_set_Void_InnerType_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_get_Error_Public_get_RequestError_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_set_Error_Public_set_Void_RequestError_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
