using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000243 RID: 579
	public class DSASignatureDeformatter : AsymmetricSignatureDeformatter
	{
		// Token: 0x060025E7 RID: 9703 RVA: 0x000D0B00 File Offset: 0x000CED00
		// Note: this type is marked as 'beforefieldinit'.
		static DSASignatureDeformatter()
		{
			Il2CppClassPointerStore<DSASignatureDeformatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "DSASignatureDeformatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DSASignatureDeformatter>.NativeClassPtr);
			DSASignatureDeformatter.NativeFieldInfoPtr__dsaKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSASignatureDeformatter>.NativeClassPtr, "_dsaKey");
			DSASignatureDeformatter.NativeFieldInfoPtr__oid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSASignatureDeformatter>.NativeClassPtr, "_oid");
			DSASignatureDeformatter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSASignatureDeformatter>.NativeClassPtr, 100669628);
			DSASignatureDeformatter.NativeMethodInfoPtr__ctor_Public_Void_AsymmetricAlgorithm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSASignatureDeformatter>.NativeClassPtr, 100669629);
			DSASignatureDeformatter.NativeMethodInfoPtr_SetKey_Public_Virtual_Void_AsymmetricAlgorithm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSASignatureDeformatter>.NativeClassPtr, 100669630);
			DSASignatureDeformatter.NativeMethodInfoPtr_SetHashAlgorithm_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSASignatureDeformatter>.NativeClassPtr, 100669631);
			DSASignatureDeformatter.NativeMethodInfoPtr_VerifySignature_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSASignatureDeformatter>.NativeClassPtr, 100669632);
		}

		// Token: 0x060025E8 RID: 9704 RVA: 0x000D0BBC File Offset: 0x000CEDBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371971, XrefRangeEnd = 1371979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DSASignatureDeformatter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DSASignatureDeformatter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSASignatureDeformatter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025E9 RID: 9705 RVA: 0x000D0BF8 File Offset: 0x000CEDF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1371999, RefRangeEnd = 1372001, XrefRangeStart = 1371979, XrefRangeEnd = 1371999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DSASignatureDeformatter(AsymmetricAlgorithm key)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DSASignatureDeformatter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSASignatureDeformatter.NativeMethodInfoPtr__ctor_Public_Void_AsymmetricAlgorithm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060025EA RID: 9706 RVA: 0x000D0C44 File Offset: 0x000CEE44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372001, XrefRangeEnd = 1372013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetKey(AsymmetricAlgorithm key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DSASignatureDeformatter.NativeMethodInfoPtr_SetKey_Public_Virtual_Void_AsymmetricAlgorithm_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060025EB RID: 9707 RVA: 0x000D0C94 File Offset: 0x000CEE94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372013, XrefRangeEnd = 1372018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetHashAlgorithm(string strName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DSASignatureDeformatter.NativeMethodInfoPtr_SetHashAlgorithm_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060025EC RID: 9708 RVA: 0x000D0CE4 File Offset: 0x000CEEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372018, XrefRangeEnd = 1372037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DSASignatureDeformatter.NativeMethodInfoPtr_VerifySignature_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025ED RID: 9709 RVA: 0x0000C499 File Offset: 0x0000A699
		public DSASignatureDeformatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x060025EE RID: 9710 RVA: 0x000D0D50 File Offset: 0x000CEF50
		// (set) Token: 0x060025EF RID: 9711 RVA: 0x0000C4A2 File Offset: 0x0000A6A2
		public unsafe DSA _dsaKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSASignatureDeformatter.NativeFieldInfoPtr__dsaKey);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DSA>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSASignatureDeformatter.NativeFieldInfoPtr__dsaKey), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x060025F0 RID: 9712 RVA: 0x000D0D80 File Offset: 0x000CEF80
		// (set) Token: 0x060025F1 RID: 9713 RVA: 0x0000C4C1 File Offset: 0x0000A6C1
		public unsafe string _oid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSASignatureDeformatter.NativeFieldInfoPtr__oid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSASignatureDeformatter.NativeFieldInfoPtr__oid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040020ED RID: 8429
		private static readonly IntPtr NativeFieldInfoPtr__dsaKey;

		// Token: 0x040020EE RID: 8430
		private static readonly IntPtr NativeFieldInfoPtr__oid;

		// Token: 0x040020EF RID: 8431
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040020F0 RID: 8432
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AsymmetricAlgorithm_0;

		// Token: 0x040020F1 RID: 8433
		private static readonly IntPtr NativeMethodInfoPtr_SetKey_Public_Virtual_Void_AsymmetricAlgorithm_0;

		// Token: 0x040020F2 RID: 8434
		private static readonly IntPtr NativeMethodInfoPtr_SetHashAlgorithm_Public_Virtual_Void_String_0;

		// Token: 0x040020F3 RID: 8435
		private static readonly IntPtr NativeMethodInfoPtr_VerifySignature_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;
	}
}
