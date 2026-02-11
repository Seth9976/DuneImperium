using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Btls
{
	// Token: 0x0200002E RID: 46
	public class MonoBtlsKey : MonoBtlsObject
	{
		// Token: 0x060002C0 RID: 704 RVA: 0x0002597C File Offset: 0x00023B7C
		// Note: this type is marked as 'beforefieldinit'.
		static MonoBtlsKey()
		{
			Il2CppClassPointerStore<MonoBtlsKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "MonoBtlsKey");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsKey>.NativeClassPtr);
			MonoBtlsKey.NativeMethodInfoPtr_mono_btls_key_new_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsKey>.NativeClassPtr, 100663772);
			MonoBtlsKey.NativeMethodInfoPtr_mono_btls_key_free_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsKey>.NativeClassPtr, 100663773);
			MonoBtlsKey.NativeMethodInfoPtr_mono_btls_key_up_ref_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsKey>.NativeClassPtr, 100663774);
			MonoBtlsKey.NativeMethodInfoPtr_mono_btls_key_get_bytes_Private_Static_Int32_IntPtr_byref_IntPtr_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsKey>.NativeClassPtr, 100663775);
			MonoBtlsKey.NativeMethodInfoPtr_mono_btls_key_assign_rsa_private_key_Private_Static_Int32_IntPtr_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsKey>.NativeClassPtr, 100663776);
			MonoBtlsKey.NativeMethodInfoPtr_get_Handle_Internal_get_BoringKeyHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsKey>.NativeClassPtr, 100663777);
			MonoBtlsKey.NativeMethodInfoPtr__ctor_Internal_Void_BoringKeyHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsKey>.NativeClassPtr, 100663778);
			MonoBtlsKey.NativeMethodInfoPtr_GetBytes_Public_Il2CppStructArray_1_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsKey>.NativeClassPtr, 100663779);
			MonoBtlsKey.NativeMethodInfoPtr_Copy_Public_MonoBtlsKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsKey>.NativeClassPtr, 100663780);
			MonoBtlsKey.NativeMethodInfoPtr_CreateFromRSAPrivateKey_Public_Static_MonoBtlsKey_RSA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsKey>.NativeClassPtr, 100663781);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00025A74 File Offset: 0x00023C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430021, XrefRangeEnd = 430023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr mono_btls_key_new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsKey.NativeMethodInfoPtr_mono_btls_key_new_Private_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00025AA4 File Offset: 0x00023CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430023, XrefRangeEnd = 430025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void mono_btls_key_free(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsKey.NativeMethodInfoPtr_mono_btls_key_free_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00025AD8 File Offset: 0x00023CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430025, XrefRangeEnd = 430027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr mono_btls_key_up_ref(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsKey.NativeMethodInfoPtr_mono_btls_key_up_ref_Private_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00025B18 File Offset: 0x00023D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430027, XrefRangeEnd = 430029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_key_get_bytes(IntPtr handle, out IntPtr data, out int size, int include_private_bits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref include_private_bits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsKey.NativeMethodInfoPtr_mono_btls_key_get_bytes_Private_Static_Int32_IntPtr_byref_IntPtr_byref_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00025B80 File Offset: 0x00023D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430029, XrefRangeEnd = 430031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_key_assign_rsa_private_key(IntPtr handle, Il2CppStructArray<byte> der, int der_length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(der);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref der_length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsKey.NativeMethodInfoPtr_mono_btls_key_assign_rsa_private_key_Private_Static_Int32_IntPtr_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x00025BE0 File Offset: 0x00023DE0
		public new unsafe MonoBtlsKey.BoringKeyHandle Handle
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 430034, RefRangeEnd = 430038, XrefRangeStart = 430031, XrefRangeEnd = 430034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsKey.NativeMethodInfoPtr_get_Handle_Internal_get_BoringKeyHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsKey.BoringKeyHandle>(intPtr3) : null;
			}
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00025C20 File Offset: 0x00023E20
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsKey(MonoBtlsKey.BoringKeyHandle handle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsKey>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsKey.NativeMethodInfoPtr__ctor_Internal_Void_BoringKeyHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00025C6C File Offset: 0x00023E6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 430053, RefRangeEnd = 430055, XrefRangeStart = 430038, XrefRangeEnd = 430053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetBytes(bool include_private_bits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref include_private_bits;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsKey.NativeMethodInfoPtr_GetBytes_Public_Il2CppStructArray_1_Byte_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00025CB8 File Offset: 0x00023EB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 430072, RefRangeEnd = 430074, XrefRangeStart = 430055, XrefRangeEnd = 430072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsKey Copy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsKey.NativeMethodInfoPtr_Copy_Public_MonoBtlsKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsKey>(intPtr3) : null;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00025CF8 File Offset: 0x00023EF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 430089, RefRangeEnd = 430090, XrefRangeStart = 430074, XrefRangeEnd = 430089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoBtlsKey CreateFromRSAPrivateKey(RSA privateKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(privateKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsKey.NativeMethodInfoPtr_CreateFromRSAPrivateKey_Public_Static_MonoBtlsKey_RSA_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsKey>(intPtr3) : null;
			}
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0000303C File Offset: 0x0000123C
		public MonoBtlsKey(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_key_new_Private_Static_IntPtr_0;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_key_free_Private_Static_Void_IntPtr_0;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_key_up_ref_Private_Static_IntPtr_IntPtr_0;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_key_get_bytes_Private_Static_Int32_IntPtr_byref_IntPtr_byref_Int32_Int32_0;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_key_assign_rsa_private_key_Private_Static_Int32_IntPtr_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Internal_get_BoringKeyHandle_0;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BoringKeyHandle_0;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Il2CppStructArray_1_Byte_Boolean_0;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_MonoBtlsKey_0;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeMethodInfoPtr_CreateFromRSAPrivateKey_Public_Static_MonoBtlsKey_RSA_0;

		// Token: 0x020002AC RID: 684
		public class BoringKeyHandle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x06002AE1 RID: 10977 RVA: 0x00013104 File Offset: 0x00011304
			// Note: this type is marked as 'beforefieldinit'.
			static BoringKeyHandle()
			{
				Il2CppClassPointerStore<MonoBtlsKey.BoringKeyHandle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoBtlsKey>.NativeClassPtr, "BoringKeyHandle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsKey.BoringKeyHandle>.NativeClassPtr);
				MonoBtlsKey.BoringKeyHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsKey.BoringKeyHandle>.NativeClassPtr, 100663783);
			}

			// Token: 0x06002AE2 RID: 10978 RVA: 0x000BF37C File Offset: 0x000BD57C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430019, XrefRangeEnd = 430021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool ReleaseHandle()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsKey.BoringKeyHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002AE3 RID: 10979 RVA: 0x00013138 File Offset: 0x00011338
			public BoringKeyHandle(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040021C7 RID: 8647
			private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;
		}
	}
}
