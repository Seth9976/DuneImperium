using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000276 RID: 630
	public class RSAPKCS1SignatureDeformatter : AsymmetricSignatureDeformatter
	{
		// Token: 0x060028B3 RID: 10419 RVA: 0x000DAD38 File Offset: 0x000D8F38
		// Note: this type is marked as 'beforefieldinit'.
		static RSAPKCS1SignatureDeformatter()
		{
			Il2CppClassPointerStore<RSAPKCS1SignatureDeformatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RSAPKCS1SignatureDeformatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RSAPKCS1SignatureDeformatter>.NativeClassPtr);
			RSAPKCS1SignatureDeformatter.NativeFieldInfoPtr_rsa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAPKCS1SignatureDeformatter>.NativeClassPtr, "rsa");
			RSAPKCS1SignatureDeformatter.NativeFieldInfoPtr_hashName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAPKCS1SignatureDeformatter>.NativeClassPtr, "hashName");
			RSAPKCS1SignatureDeformatter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAPKCS1SignatureDeformatter>.NativeClassPtr, 100669965);
			RSAPKCS1SignatureDeformatter.NativeMethodInfoPtr__ctor_Public_Void_AsymmetricAlgorithm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAPKCS1SignatureDeformatter>.NativeClassPtr, 100669966);
			RSAPKCS1SignatureDeformatter.NativeMethodInfoPtr_SetHashAlgorithm_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAPKCS1SignatureDeformatter>.NativeClassPtr, 100669967);
			RSAPKCS1SignatureDeformatter.NativeMethodInfoPtr_SetKey_Public_Virtual_Void_AsymmetricAlgorithm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAPKCS1SignatureDeformatter>.NativeClassPtr, 100669968);
			RSAPKCS1SignatureDeformatter.NativeMethodInfoPtr_VerifySignature_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAPKCS1SignatureDeformatter>.NativeClassPtr, 100669969);
		}

		// Token: 0x060028B4 RID: 10420 RVA: 0x000DADF4 File Offset: 0x000D8FF4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RSAPKCS1SignatureDeformatter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSAPKCS1SignatureDeformatter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAPKCS1SignatureDeformatter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028B5 RID: 10421 RVA: 0x000DAE30 File Offset: 0x000D9030
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1374942, RefRangeEnd = 1374945, XrefRangeStart = 1374941, XrefRangeEnd = 1374942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RSAPKCS1SignatureDeformatter(AsymmetricAlgorithm key)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSAPKCS1SignatureDeformatter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAPKCS1SignatureDeformatter.NativeMethodInfoPtr__ctor_Public_Void_AsymmetricAlgorithm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028B6 RID: 10422 RVA: 0x000DAE7C File Offset: 0x000D907C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1374945, XrefRangeEnd = 1374952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetHashAlgorithm(string strName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RSAPKCS1SignatureDeformatter.NativeMethodInfoPtr_SetHashAlgorithm_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028B7 RID: 10423 RVA: 0x000DAECC File Offset: 0x000D90CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1374952, XrefRangeEnd = 1374964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetKey(AsymmetricAlgorithm key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RSAPKCS1SignatureDeformatter.NativeMethodInfoPtr_SetKey_Public_Virtual_Void_AsymmetricAlgorithm_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028B8 RID: 10424 RVA: 0x000DAF1C File Offset: 0x000D911C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1374964, XrefRangeEnd = 1374968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool VerifySignature(Il2CppStructArray<byte> rgbHash, Il2CppStructArray<byte> rgbSignature)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgbHash);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rgbSignature);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RSAPKCS1SignatureDeformatter.NativeMethodInfoPtr_VerifySignature_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028B9 RID: 10425 RVA: 0x0000D69D File Offset: 0x0000B89D
		public RSAPKCS1SignatureDeformatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x060028BA RID: 10426 RVA: 0x000DAF88 File Offset: 0x000D9188
		// (set) Token: 0x060028BB RID: 10427 RVA: 0x0000D6A6 File Offset: 0x0000B8A6
		public unsafe RSA rsa
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAPKCS1SignatureDeformatter.NativeFieldInfoPtr_rsa);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RSA>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAPKCS1SignatureDeformatter.NativeFieldInfoPtr_rsa), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x060028BC RID: 10428 RVA: 0x000DAFB8 File Offset: 0x000D91B8
		// (set) Token: 0x060028BD RID: 10429 RVA: 0x0000D6C5 File Offset: 0x0000B8C5
		public unsafe string hashName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAPKCS1SignatureDeformatter.NativeFieldInfoPtr_hashName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAPKCS1SignatureDeformatter.NativeFieldInfoPtr_hashName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040022C5 RID: 8901
		private static readonly IntPtr NativeFieldInfoPtr_rsa;

		// Token: 0x040022C6 RID: 8902
		private static readonly IntPtr NativeFieldInfoPtr_hashName;

		// Token: 0x040022C7 RID: 8903
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040022C8 RID: 8904
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AsymmetricAlgorithm_0;

		// Token: 0x040022C9 RID: 8905
		private static readonly IntPtr NativeMethodInfoPtr_SetHashAlgorithm_Public_Virtual_Void_String_0;

		// Token: 0x040022CA RID: 8906
		private static readonly IntPtr NativeMethodInfoPtr_SetKey_Public_Virtual_Void_AsymmetricAlgorithm_0;

		// Token: 0x040022CB RID: 8907
		private static readonly IntPtr NativeMethodInfoPtr_VerifySignature_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;
	}
}
