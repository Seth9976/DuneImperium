using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000265 RID: 613
	public class SignatureDescription : Object
	{
		// Token: 0x060027B7 RID: 10167 RVA: 0x000D7728 File Offset: 0x000D5928
		// Note: this type is marked as 'beforefieldinit'.
		static SignatureDescription()
		{
			Il2CppClassPointerStore<SignatureDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "SignatureDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SignatureDescription>.NativeClassPtr);
			SignatureDescription.NativeFieldInfoPtr__strKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignatureDescription>.NativeClassPtr, "_strKey");
			SignatureDescription.NativeFieldInfoPtr__strDigest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignatureDescription>.NativeClassPtr, "_strDigest");
			SignatureDescription.NativeFieldInfoPtr__strFormatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignatureDescription>.NativeClassPtr, "_strFormatter");
			SignatureDescription.NativeFieldInfoPtr__strDeformatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignatureDescription>.NativeClassPtr, "_strDeformatter");
			SignatureDescription.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureDescription>.NativeClassPtr, 100669850);
			SignatureDescription.NativeMethodInfoPtr_set_KeyAlgorithm_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureDescription>.NativeClassPtr, 100669851);
			SignatureDescription.NativeMethodInfoPtr_set_DigestAlgorithm_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureDescription>.NativeClassPtr, 100669852);
			SignatureDescription.NativeMethodInfoPtr_set_FormatterAlgorithm_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureDescription>.NativeClassPtr, 100669853);
			SignatureDescription.NativeMethodInfoPtr_set_DeformatterAlgorithm_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureDescription>.NativeClassPtr, 100669854);
		}

		// Token: 0x060027B8 RID: 10168 RVA: 0x000D780C File Offset: 0x000D5A0C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SignatureDescription()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SignatureDescription>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureDescription.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700081A RID: 2074
		// (set) Token: 0x060027B9 RID: 10169 RVA: 0x000D7848 File Offset: 0x000D5A48
		public unsafe string KeyAlgorithm
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureDescription.NativeMethodInfoPtr_set_KeyAlgorithm_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700081B RID: 2075
		// (set) Token: 0x060027BA RID: 10170 RVA: 0x000D788C File Offset: 0x000D5A8C
		public unsafe string DigestAlgorithm
		{
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureDescription.NativeMethodInfoPtr_set_DigestAlgorithm_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700081C RID: 2076
		// (set) Token: 0x060027BB RID: 10171 RVA: 0x000D78D0 File Offset: 0x000D5AD0
		public unsafe string FormatterAlgorithm
		{
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureDescription.NativeMethodInfoPtr_set_FormatterAlgorithm_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700081D RID: 2077
		// (set) Token: 0x060027BC RID: 10172 RVA: 0x000D7914 File Offset: 0x000D5B14
		public unsafe string DeformatterAlgorithm
		{
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureDescription.NativeMethodInfoPtr_set_DeformatterAlgorithm_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060027BD RID: 10173 RVA: 0x0000CF9E File Offset: 0x0000B19E
		public SignatureDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x060027BE RID: 10174 RVA: 0x000D7958 File Offset: 0x000D5B58
		// (set) Token: 0x060027BF RID: 10175 RVA: 0x0000CFA7 File Offset: 0x0000B1A7
		public unsafe string _strKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignatureDescription.NativeFieldInfoPtr__strKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignatureDescription.NativeFieldInfoPtr__strKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x060027C0 RID: 10176 RVA: 0x000D7980 File Offset: 0x000D5B80
		// (set) Token: 0x060027C1 RID: 10177 RVA: 0x0000CFC6 File Offset: 0x0000B1C6
		public unsafe string _strDigest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignatureDescription.NativeFieldInfoPtr__strDigest);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignatureDescription.NativeFieldInfoPtr__strDigest), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x060027C2 RID: 10178 RVA: 0x000D79A8 File Offset: 0x000D5BA8
		// (set) Token: 0x060027C3 RID: 10179 RVA: 0x0000CFE5 File Offset: 0x0000B1E5
		public unsafe string _strFormatter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignatureDescription.NativeFieldInfoPtr__strFormatter);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignatureDescription.NativeFieldInfoPtr__strFormatter), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x060027C4 RID: 10180 RVA: 0x000D79D0 File Offset: 0x000D5BD0
		// (set) Token: 0x060027C5 RID: 10181 RVA: 0x0000D004 File Offset: 0x0000B204
		public unsafe string _strDeformatter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignatureDescription.NativeFieldInfoPtr__strDeformatter);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignatureDescription.NativeFieldInfoPtr__strDeformatter), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002222 RID: 8738
		private static readonly IntPtr NativeFieldInfoPtr__strKey;

		// Token: 0x04002223 RID: 8739
		private static readonly IntPtr NativeFieldInfoPtr__strDigest;

		// Token: 0x04002224 RID: 8740
		private static readonly IntPtr NativeFieldInfoPtr__strFormatter;

		// Token: 0x04002225 RID: 8741
		private static readonly IntPtr NativeFieldInfoPtr__strDeformatter;

		// Token: 0x04002226 RID: 8742
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002227 RID: 8743
		private static readonly IntPtr NativeMethodInfoPtr_set_KeyAlgorithm_Public_set_Void_String_0;

		// Token: 0x04002228 RID: 8744
		private static readonly IntPtr NativeMethodInfoPtr_set_DigestAlgorithm_Public_set_Void_String_0;

		// Token: 0x04002229 RID: 8745
		private static readonly IntPtr NativeMethodInfoPtr_set_FormatterAlgorithm_Public_set_Void_String_0;

		// Token: 0x0400222A RID: 8746
		private static readonly IntPtr NativeMethodInfoPtr_set_DeformatterAlgorithm_Public_set_Void_String_0;
	}
}
