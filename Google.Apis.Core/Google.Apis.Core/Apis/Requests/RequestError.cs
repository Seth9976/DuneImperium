using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Requests
{
	// Token: 0x02000013 RID: 19
	public class RequestError : Object
	{
		// Token: 0x060000A0 RID: 160 RVA: 0x00006758 File Offset: 0x00004958
		// Note: this type is marked as 'beforefieldinit'.
		static RequestError()
		{
			Il2CppClassPointerStore<RequestError>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Requests", "RequestError");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestError>.NativeClassPtr);
			RequestError.NativeFieldInfoPtr__Errors_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestError>.NativeClassPtr, "<Errors>k__BackingField");
			RequestError.NativeFieldInfoPtr__Code_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestError>.NativeClassPtr, "<Code>k__BackingField");
			RequestError.NativeFieldInfoPtr__Message_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestError>.NativeClassPtr, "<Message>k__BackingField");
			RequestError.NativeMethodInfoPtr_get_Errors_Public_get_IList_1_SingleError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestError>.NativeClassPtr, 100663383);
			RequestError.NativeMethodInfoPtr_set_Errors_Public_set_Void_IList_1_SingleError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestError>.NativeClassPtr, 100663384);
			RequestError.NativeMethodInfoPtr_get_Code_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestError>.NativeClassPtr, 100663385);
			RequestError.NativeMethodInfoPtr_set_Code_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestError>.NativeClassPtr, 100663386);
			RequestError.NativeMethodInfoPtr_get_Message_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestError>.NativeClassPtr, 100663387);
			RequestError.NativeMethodInfoPtr_set_Message_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestError>.NativeClassPtr, 100663388);
			RequestError.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestError>.NativeClassPtr, 100663389);
			RequestError.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestError>.NativeClassPtr, 100663390);
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00006864 File Offset: 0x00004A64
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x000068A4 File Offset: 0x00004AA4
		public unsafe IList<SingleError> Errors
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestError.NativeMethodInfoPtr_get_Errors_Public_get_IList_1_SingleError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<SingleError>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestError.NativeMethodInfoPtr_set_Errors_Public_set_Void_IList_1_SingleError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x000068E8 File Offset: 0x00004AE8
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x00006924 File Offset: 0x00004B24
		public unsafe int Code
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestError.NativeMethodInfoPtr_get_Code_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 311421, RefRangeEnd = 311423, XrefRangeStart = 311421, XrefRangeEnd = 311423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestError.NativeMethodInfoPtr_set_Code_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00006964 File Offset: 0x00004B64
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x0000699C File Offset: 0x00004B9C
		public unsafe string Message
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestError.NativeMethodInfoPtr_get_Message_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestError.NativeMethodInfoPtr_set_Message_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000069E0 File Offset: 0x00004BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1210565, XrefRangeEnd = 1210610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RequestError.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00006A24 File Offset: 0x00004C24
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RequestError()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestError>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestError.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000023AC File Offset: 0x000005AC
		public RequestError(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00006A60 File Offset: 0x00004C60
		// (set) Token: 0x060000AB RID: 171 RVA: 0x000023B5 File Offset: 0x000005B5
		public unsafe IList<SingleError> _Errors_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestError.NativeFieldInfoPtr__Errors_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<SingleError>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestError.NativeFieldInfoPtr__Errors_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00006A90 File Offset: 0x00004C90
		// (set) Token: 0x060000AD RID: 173 RVA: 0x000023D4 File Offset: 0x000005D4
		public unsafe int _Code_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestError.NativeFieldInfoPtr__Code_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestError.NativeFieldInfoPtr__Code_k__BackingField)) = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00006AB8 File Offset: 0x00004CB8
		// (set) Token: 0x060000AF RID: 175 RVA: 0x000023EF File Offset: 0x000005EF
		public unsafe string _Message_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestError.NativeFieldInfoPtr__Message_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestError.NativeFieldInfoPtr__Message_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeFieldInfoPtr__Errors_k__BackingField;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr__Code_k__BackingField;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeFieldInfoPtr__Message_k__BackingField;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_get_Errors_Public_get_IList_1_SingleError_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_set_Errors_Public_set_Void_IList_1_SingleError_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_get_Code_Public_get_Int32_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_set_Code_Public_set_Void_Int32_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_get_String_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_set_Message_Public_set_Void_String_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200004A RID: 74
		public enum ErrorCodes
		{
			// Token: 0x040001DE RID: 478
			ETagConditionFailed = 412
		}
	}
}
