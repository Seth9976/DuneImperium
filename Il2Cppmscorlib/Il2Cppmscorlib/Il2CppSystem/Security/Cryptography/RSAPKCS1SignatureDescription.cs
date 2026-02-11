using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000266 RID: 614
	public class RSAPKCS1SignatureDescription : SignatureDescription
	{
		// Token: 0x060027C6 RID: 10182 RVA: 0x000D79F8 File Offset: 0x000D5BF8
		// Note: this type is marked as 'beforefieldinit'.
		static RSAPKCS1SignatureDescription()
		{
			Il2CppClassPointerStore<RSAPKCS1SignatureDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RSAPKCS1SignatureDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RSAPKCS1SignatureDescription>.NativeClassPtr);
			RSAPKCS1SignatureDescription.NativeFieldInfoPtr__hashAlgorithm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAPKCS1SignatureDescription>.NativeClassPtr, "_hashAlgorithm");
			RSAPKCS1SignatureDescription.NativeMethodInfoPtr__ctor_Protected_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAPKCS1SignatureDescription>.NativeClassPtr, 100669855);
		}

		// Token: 0x060027C7 RID: 10183 RVA: 0x000D7A50 File Offset: 0x000D5C50
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1373800, RefRangeEnd = 1373805, XrefRangeStart = 1373788, XrefRangeEnd = 1373800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RSAPKCS1SignatureDescription(string hashAlgorithm, string digestAlgorithm)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSAPKCS1SignatureDescription>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(hashAlgorithm);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(digestAlgorithm);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAPKCS1SignatureDescription.NativeMethodInfoPtr__ctor_Protected_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027C8 RID: 10184 RVA: 0x0000D023 File Offset: 0x0000B223
		public RSAPKCS1SignatureDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x060027C9 RID: 10185 RVA: 0x000D7AB0 File Offset: 0x000D5CB0
		// (set) Token: 0x060027CA RID: 10186 RVA: 0x0000D02C File Offset: 0x0000B22C
		public unsafe string _hashAlgorithm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAPKCS1SignatureDescription.NativeFieldInfoPtr__hashAlgorithm);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAPKCS1SignatureDescription.NativeFieldInfoPtr__hashAlgorithm), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400222B RID: 8747
		private static readonly IntPtr NativeFieldInfoPtr__hashAlgorithm;

		// Token: 0x0400222C RID: 8748
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_String_0;
	}
}
