using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000D2 RID: 210
	public class X509ChainElement : Object
	{
		// Token: 0x06000DE5 RID: 3557 RVA: 0x00050780 File Offset: 0x0004E980
		// Note: this type is marked as 'beforefieldinit'.
		static X509ChainElement()
		{
			Il2CppClassPointerStore<X509ChainElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509ChainElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509ChainElement>.NativeClassPtr);
			X509ChainElement.NativeFieldInfoPtr_certificate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainElement>.NativeClassPtr, "certificate");
			X509ChainElement.NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainElement>.NativeClassPtr, "status");
			X509ChainElement.NativeFieldInfoPtr_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainElement>.NativeClassPtr, "info");
			X509ChainElement.NativeFieldInfoPtr_compressed_status_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainElement>.NativeClassPtr, "compressed_status_flags");
			X509ChainElement.NativeMethodInfoPtr__ctor_Internal_Void_X509Certificate2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElement>.NativeClassPtr, 100665323);
			X509ChainElement.NativeMethodInfoPtr_get_Certificate_Public_get_X509Certificate2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElement>.NativeClassPtr, 100665324);
			X509ChainElement.NativeMethodInfoPtr_get_ChainElementStatus_Public_get_Il2CppReferenceArray_1_X509ChainStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElement>.NativeClassPtr, 100665325);
			X509ChainElement.NativeMethodInfoPtr_get_StatusFlags_Internal_get_X509ChainStatusFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElement>.NativeClassPtr, 100665326);
			X509ChainElement.NativeMethodInfoPtr_set_StatusFlags_Internal_set_Void_X509ChainStatusFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElement>.NativeClassPtr, 100665327);
			X509ChainElement.NativeMethodInfoPtr_Count_Private_Int32_X509ChainStatusFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElement>.NativeClassPtr, 100665328);
			X509ChainElement.NativeMethodInfoPtr_Set_Private_Void_Il2CppReferenceArray_1_X509ChainStatus_byref_Int32_X509ChainStatusFlags_X509ChainStatusFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElement>.NativeClassPtr, 100665329);
			X509ChainElement.NativeMethodInfoPtr_UncompressFlags_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElement>.NativeClassPtr, 100665330);
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x000508A0 File Offset: 0x0004EAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454441, XrefRangeEnd = 454446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509ChainElement(X509Certificate2 certificate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509ChainElement>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElement.NativeMethodInfoPtr__ctor_Internal_Void_X509Certificate2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000DE7 RID: 3559 RVA: 0x000508EC File Offset: 0x0004EAEC
		public unsafe X509Certificate2 Certificate
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElement.NativeMethodInfoPtr_get_Certificate_Public_get_X509Certificate2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate2>(intPtr3) : null;
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000DE8 RID: 3560 RVA: 0x0005092C File Offset: 0x0004EB2C
		public unsafe Il2CppReferenceArray<X509ChainStatus> ChainElementStatus
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElement.NativeMethodInfoPtr_get_ChainElementStatus_Public_get_Il2CppReferenceArray_1_X509ChainStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<X509ChainStatus>>(intPtr3) : null;
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000DE9 RID: 3561 RVA: 0x0005096C File Offset: 0x0004EB6C
		// (set) Token: 0x06000DEA RID: 3562 RVA: 0x000509A8 File Offset: 0x0004EBA8
		public unsafe X509ChainStatusFlags StatusFlags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElement.NativeMethodInfoPtr_get_StatusFlags_Internal_get_X509ChainStatusFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElement.NativeMethodInfoPtr_set_StatusFlags_Internal_set_Void_X509ChainStatusFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x000509E8 File Offset: 0x0004EBE8
		[CallerCount(0)]
		public unsafe int Count(X509ChainStatusFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElement.NativeMethodInfoPtr_Count_Private_Int32_X509ChainStatusFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x00050A34 File Offset: 0x0004EC34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454446, XrefRangeEnd = 454448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(Il2CppReferenceArray<X509ChainStatus> status, ref int position, X509ChainStatusFlags flags, X509ChainStatusFlags mask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(status);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElement.NativeMethodInfoPtr_Set_Private_Void_Il2CppReferenceArray_1_X509ChainStatus_byref_Int32_X509ChainStatusFlags_X509ChainStatusFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x00050AA0 File Offset: 0x0004ECA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 454568, RefRangeEnd = 454570, XrefRangeStart = 454448, XrefRangeEnd = 454568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UncompressFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElement.NativeMethodInfoPtr_UncompressFlags_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x00007071 File Offset: 0x00005271
		public X509ChainElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000DEF RID: 3567 RVA: 0x00050AD4 File Offset: 0x0004ECD4
		// (set) Token: 0x06000DF0 RID: 3568 RVA: 0x0000707A File Offset: 0x0000527A
		public unsafe X509Certificate2 certificate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainElement.NativeFieldInfoPtr_certificate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Certificate2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainElement.NativeFieldInfoPtr_certificate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000DF1 RID: 3569 RVA: 0x00050B04 File Offset: 0x0004ED04
		// (set) Token: 0x06000DF2 RID: 3570 RVA: 0x00007099 File Offset: 0x00005299
		public unsafe Il2CppReferenceArray<X509ChainStatus> status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainElement.NativeFieldInfoPtr_status);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<X509ChainStatus>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainElement.NativeFieldInfoPtr_status), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000DF3 RID: 3571 RVA: 0x00050B34 File Offset: 0x0004ED34
		// (set) Token: 0x06000DF4 RID: 3572 RVA: 0x000070B8 File Offset: 0x000052B8
		public unsafe string info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainElement.NativeFieldInfoPtr_info);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainElement.NativeFieldInfoPtr_info), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000DF5 RID: 3573 RVA: 0x00050B5C File Offset: 0x0004ED5C
		// (set) Token: 0x06000DF6 RID: 3574 RVA: 0x000070D7 File Offset: 0x000052D7
		public unsafe X509ChainStatusFlags compressed_status_flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainElement.NativeFieldInfoPtr_compressed_status_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainElement.NativeFieldInfoPtr_compressed_status_flags)) = value;
			}
		}

		// Token: 0x04000B77 RID: 2935
		private static readonly IntPtr NativeFieldInfoPtr_certificate;

		// Token: 0x04000B78 RID: 2936
		private static readonly IntPtr NativeFieldInfoPtr_status;

		// Token: 0x04000B79 RID: 2937
		private static readonly IntPtr NativeFieldInfoPtr_info;

		// Token: 0x04000B7A RID: 2938
		private static readonly IntPtr NativeFieldInfoPtr_compressed_status_flags;

		// Token: 0x04000B7B RID: 2939
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_X509Certificate2_0;

		// Token: 0x04000B7C RID: 2940
		private static readonly IntPtr NativeMethodInfoPtr_get_Certificate_Public_get_X509Certificate2_0;

		// Token: 0x04000B7D RID: 2941
		private static readonly IntPtr NativeMethodInfoPtr_get_ChainElementStatus_Public_get_Il2CppReferenceArray_1_X509ChainStatus_0;

		// Token: 0x04000B7E RID: 2942
		private static readonly IntPtr NativeMethodInfoPtr_get_StatusFlags_Internal_get_X509ChainStatusFlags_0;

		// Token: 0x04000B7F RID: 2943
		private static readonly IntPtr NativeMethodInfoPtr_set_StatusFlags_Internal_set_Void_X509ChainStatusFlags_0;

		// Token: 0x04000B80 RID: 2944
		private static readonly IntPtr NativeMethodInfoPtr_Count_Private_Int32_X509ChainStatusFlags_0;

		// Token: 0x04000B81 RID: 2945
		private static readonly IntPtr NativeMethodInfoPtr_Set_Private_Void_Il2CppReferenceArray_1_X509ChainStatus_byref_Int32_X509ChainStatusFlags_X509ChainStatusFlags_0;

		// Token: 0x04000B82 RID: 2946
		private static readonly IntPtr NativeMethodInfoPtr_UncompressFlags_Internal_Void_0;
	}
}
