using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000C7 RID: 199
	public sealed class X500DistinguishedName : AsnEncodedData
	{
		// Token: 0x06000D0A RID: 3338 RVA: 0x0004CBD8 File Offset: 0x0004ADD8
		// Note: this type is marked as 'beforefieldinit'.
		static X500DistinguishedName()
		{
			Il2CppClassPointerStore<X500DistinguishedName>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X500DistinguishedName");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X500DistinguishedName>.NativeClassPtr);
			X500DistinguishedName.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X500DistinguishedName>.NativeClassPtr, "name");
			X500DistinguishedName.NativeFieldInfoPtr_canonEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X500DistinguishedName>.NativeClassPtr, "canonEncoding");
			X500DistinguishedName.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X500DistinguishedName>.NativeClassPtr, 100665169);
			X500DistinguishedName.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X500DistinguishedName>.NativeClassPtr, 100665170);
			X500DistinguishedName.NativeMethodInfoPtr__ctor_Public_Void_String_X500DistinguishedNameFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X500DistinguishedName>.NativeClassPtr, 100665171);
			X500DistinguishedName.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X500DistinguishedName>.NativeClassPtr, 100665172);
			X500DistinguishedName.NativeMethodInfoPtr_Decode_Public_String_X500DistinguishedNameFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X500DistinguishedName>.NativeClassPtr, 100665173);
			X500DistinguishedName.NativeMethodInfoPtr_Format_Public_Virtual_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X500DistinguishedName>.NativeClassPtr, 100665174);
			X500DistinguishedName.NativeMethodInfoPtr_GetSeparator_Private_Static_String_X500DistinguishedNameFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X500DistinguishedName>.NativeClassPtr, 100665175);
			X500DistinguishedName.NativeMethodInfoPtr_DecodeRawData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X500DistinguishedName>.NativeClassPtr, 100665176);
			X500DistinguishedName.NativeMethodInfoPtr_Canonize_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X500DistinguishedName>.NativeClassPtr, 100665177);
			X500DistinguishedName.NativeMethodInfoPtr_AreEqual_Internal_Static_Boolean_X500DistinguishedName_X500DistinguishedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X500DistinguishedName>.NativeClassPtr, 100665178);
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x0004CCF8 File Offset: 0x0004AEF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 452937, RefRangeEnd = 452939, XrefRangeStart = 452913, XrefRangeEnd = 452937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X500DistinguishedName(Il2CppStructArray<byte> encodedDistinguishedName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X500DistinguishedName>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(encodedDistinguishedName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X500DistinguishedName.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x0004CD44 File Offset: 0x0004AF44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 452940, RefRangeEnd = 452941, XrefRangeStart = 452939, XrefRangeEnd = 452940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X500DistinguishedName(string distinguishedName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X500DistinguishedName>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(distinguishedName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X500DistinguishedName.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x0004CD90 File Offset: 0x0004AF90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 452976, RefRangeEnd = 452977, XrefRangeStart = 452941, XrefRangeEnd = 452976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X500DistinguishedName(string distinguishedName, X500DistinguishedNameFlags flag)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X500DistinguishedName>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(distinguishedName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flag;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X500DistinguishedName.NativeMethodInfoPtr__ctor_Public_Void_String_X500DistinguishedNameFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000D0E RID: 3342 RVA: 0x0004CDEC File Offset: 0x0004AFEC
		public unsafe string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X500DistinguishedName.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x0004CE24 File Offset: 0x0004B024
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 452993, RefRangeEnd = 452998, XrefRangeStart = 452977, XrefRangeEnd = 452993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Decode(X500DistinguishedNameFlags flag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flag;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X500DistinguishedName.NativeMethodInfoPtr_Decode_Public_String_X500DistinguishedNameFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x0004CE68 File Offset: 0x0004B068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452998, XrefRangeEnd = 453002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string Format(bool multiLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X500DistinguishedName.NativeMethodInfoPtr_Format_Public_Virtual_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x0004CEAC File Offset: 0x0004B0AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453002, XrefRangeEnd = 453006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetSeparator(X500DistinguishedNameFlags flag)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flag;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X500DistinguishedName.NativeMethodInfoPtr_GetSeparator_Private_Static_String_X500DistinguishedNameFlags_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x0004CEE4 File Offset: 0x0004B0E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 453020, RefRangeEnd = 453021, XrefRangeStart = 453006, XrefRangeEnd = 453020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DecodeRawData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X500DistinguishedName.NativeMethodInfoPtr_DecodeRawData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x0004CF18 File Offset: 0x0004B118
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 453046, RefRangeEnd = 453048, XrefRangeStart = 453021, XrefRangeEnd = 453046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Canonize(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X500DistinguishedName.NativeMethodInfoPtr_Canonize_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x0004CF54 File Offset: 0x0004B154
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 453062, RefRangeEnd = 453063, XrefRangeStart = 453048, XrefRangeEnd = 453062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AreEqual(X500DistinguishedName name1, X500DistinguishedName name2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(name2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X500DistinguishedName.NativeMethodInfoPtr_AreEqual_Internal_Static_Boolean_X500DistinguishedName_X500DistinguishedName_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x00006D32 File Offset: 0x00004F32
		public X500DistinguishedName(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000D16 RID: 3350 RVA: 0x0004CFA8 File Offset: 0x0004B1A8
		// (set) Token: 0x06000D17 RID: 3351 RVA: 0x00006D3B File Offset: 0x00004F3B
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X500DistinguishedName.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X500DistinguishedName.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000D18 RID: 3352 RVA: 0x0004CFD0 File Offset: 0x0004B1D0
		// (set) Token: 0x06000D19 RID: 3353 RVA: 0x00006D5A File Offset: 0x00004F5A
		public unsafe Il2CppStructArray<byte> canonEncoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X500DistinguishedName.NativeFieldInfoPtr_canonEncoding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X500DistinguishedName.NativeFieldInfoPtr_canonEncoding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000ACC RID: 2764
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000ACD RID: 2765
		private static readonly IntPtr NativeFieldInfoPtr_canonEncoding;

		// Token: 0x04000ACE RID: 2766
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000ACF RID: 2767
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000AD0 RID: 2768
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_X500DistinguishedNameFlags_0;

		// Token: 0x04000AD1 RID: 2769
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04000AD2 RID: 2770
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Public_String_X500DistinguishedNameFlags_0;

		// Token: 0x04000AD3 RID: 2771
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Virtual_String_Boolean_0;

		// Token: 0x04000AD4 RID: 2772
		private static readonly IntPtr NativeMethodInfoPtr_GetSeparator_Private_Static_String_X500DistinguishedNameFlags_0;

		// Token: 0x04000AD5 RID: 2773
		private static readonly IntPtr NativeMethodInfoPtr_DecodeRawData_Private_Void_0;

		// Token: 0x04000AD6 RID: 2774
		private static readonly IntPtr NativeMethodInfoPtr_Canonize_Private_Static_String_String_0;

		// Token: 0x04000AD7 RID: 2775
		private static readonly IntPtr NativeMethodInfoPtr_AreEqual_Internal_Static_Boolean_X500DistinguishedName_X500DistinguishedName_0;
	}
}
