using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000E0 RID: 224
	public sealed class X509SubjectKeyIdentifierExtension : X509Extension
	{
		// Token: 0x06000EEE RID: 3822 RVA: 0x00054678 File Offset: 0x00052878
		// Note: this type is marked as 'beforefieldinit'.
		static X509SubjectKeyIdentifierExtension()
		{
			Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509SubjectKeyIdentifierExtension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr);
			X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr_oid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, "oid");
			X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr_friendlyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, "friendlyName");
			X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr__subjectKeyIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, "_subjectKeyIdentifier");
			X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr__ski = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, "_ski");
			X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr__status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, "_status");
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100665463);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100665464);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100665465);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100665466);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr__ctor_Public_Void_PublicKey_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100665467);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr__ctor_Public_Void_PublicKey_X509SubjectKeyIdentifierHashAlgorithm_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100665468);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_get_SubjectKeyIdentifier_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100665469);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100665470);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_FromHexChar_Internal_Static_Byte_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100665471);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_FromHexChars_Internal_Static_Byte_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100665472);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_FromHex_Internal_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100665473);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100665474);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_Encode_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100665475);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100665476);
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x00054824 File Offset: 0x00052A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 455886, XrefRangeEnd = 455898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509SubjectKeyIdentifierExtension()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x00054860 File Offset: 0x00052A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 455898, XrefRangeEnd = 455912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509SubjectKeyIdentifierExtension(AsnEncodedData encodedSubjectKeyIdentifier, bool critical)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(encodedSubjectKeyIdentifier);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref critical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x000548BC File Offset: 0x00052ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 455912, XrefRangeEnd = 455948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509SubjectKeyIdentifierExtension(Il2CppStructArray<byte> subjectKeyIdentifier, bool critical)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(subjectKeyIdentifier);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref critical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x00054918 File Offset: 0x00052B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 455948, XrefRangeEnd = 455988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509SubjectKeyIdentifierExtension(string subjectKeyIdentifier, bool critical)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(subjectKeyIdentifier);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref critical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x00054974 File Offset: 0x00052B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 455988, XrefRangeEnd = 455989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509SubjectKeyIdentifierExtension(PublicKey key, bool critical)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref critical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr__ctor_Public_Void_PublicKey_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x000549D0 File Offset: 0x00052BD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 456057, RefRangeEnd = 456059, XrefRangeStart = 455989, XrefRangeEnd = 456057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509SubjectKeyIdentifierExtension(PublicKey key, X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref algorithm;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref critical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr__ctor_Public_Void_PublicKey_X509SubjectKeyIdentifierHashAlgorithm_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000EF5 RID: 3829 RVA: 0x00054A38 File Offset: 0x00052C38
		public unsafe string SubjectKeyIdentifier
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 456061, RefRangeEnd = 456063, XrefRangeStart = 456059, XrefRangeEnd = 456061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_get_SubjectKeyIdentifier_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x00054A70 File Offset: 0x00052C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456063, XrefRangeEnd = 456083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyFrom(AsnEncodedData asnEncodedData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asnEncodedData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x00054AB4 File Offset: 0x00052CB4
		[CallerCount(0)]
		public unsafe static byte FromHexChar(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_FromHexChar_Internal_Static_Byte_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x00054AF4 File Offset: 0x00052CF4
		[CallerCount(0)]
		public unsafe static byte FromHexChars(char c1, char c2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_FromHexChars_Internal_Static_Byte_Char_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x00054B40 File Offset: 0x00052D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456083, XrefRangeEnd = 456094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> FromHex(string hex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(hex);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_FromHex_Internal_Static_Il2CppStructArray_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x00054B84 File Offset: 0x00052D84
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 456103, RefRangeEnd = 456106, XrefRangeStart = 456094, XrefRangeEnd = 456103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsnDecodeStatus Decode(Il2CppStructArray<byte> extension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extension);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x00054BD4 File Offset: 0x00052DD4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 456111, RefRangeEnd = 456114, XrefRangeStart = 456106, XrefRangeEnd = 456111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> Encode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_Encode_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x00054C14 File Offset: 0x00052E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456114, XrefRangeEnd = 456135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(bool multiLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x0000766F File Offset: 0x0000586F
		public X509SubjectKeyIdentifierExtension(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000EFE RID: 3838 RVA: 0x00054C58 File Offset: 0x00052E58
		// (set) Token: 0x06000EFF RID: 3839 RVA: 0x00007678 File Offset: 0x00005878
		public unsafe static string oid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr_oid, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr_oid, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000F00 RID: 3840 RVA: 0x00054C78 File Offset: 0x00052E78
		// (set) Token: 0x06000F01 RID: 3841 RVA: 0x0000768A File Offset: 0x0000588A
		public unsafe static string friendlyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr_friendlyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr_friendlyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000F02 RID: 3842 RVA: 0x00054C98 File Offset: 0x00052E98
		// (set) Token: 0x06000F03 RID: 3843 RVA: 0x0000769C File Offset: 0x0000589C
		public unsafe Il2CppStructArray<byte> _subjectKeyIdentifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr__subjectKeyIdentifier);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr__subjectKeyIdentifier), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000F04 RID: 3844 RVA: 0x00054CC8 File Offset: 0x00052EC8
		// (set) Token: 0x06000F05 RID: 3845 RVA: 0x000076BB File Offset: 0x000058BB
		public unsafe string _ski
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr__ski);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr__ski), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000F06 RID: 3846 RVA: 0x00054CF0 File Offset: 0x00052EF0
		// (set) Token: 0x06000F07 RID: 3847 RVA: 0x000076DA File Offset: 0x000058DA
		public unsafe AsnDecodeStatus _status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr__status);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr__status)) = value;
			}
		}

		// Token: 0x04000C32 RID: 3122
		private static readonly IntPtr NativeFieldInfoPtr_oid;

		// Token: 0x04000C33 RID: 3123
		private static readonly IntPtr NativeFieldInfoPtr_friendlyName;

		// Token: 0x04000C34 RID: 3124
		private static readonly IntPtr NativeFieldInfoPtr__subjectKeyIdentifier;

		// Token: 0x04000C35 RID: 3125
		private static readonly IntPtr NativeFieldInfoPtr__ski;

		// Token: 0x04000C36 RID: 3126
		private static readonly IntPtr NativeFieldInfoPtr__status;

		// Token: 0x04000C37 RID: 3127
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C38 RID: 3128
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0;

		// Token: 0x04000C39 RID: 3129
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Boolean_0;

		// Token: 0x04000C3A RID: 3130
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;

		// Token: 0x04000C3B RID: 3131
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PublicKey_Boolean_0;

		// Token: 0x04000C3C RID: 3132
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PublicKey_X509SubjectKeyIdentifierHashAlgorithm_Boolean_0;

		// Token: 0x04000C3D RID: 3133
		private static readonly IntPtr NativeMethodInfoPtr_get_SubjectKeyIdentifier_Public_get_String_0;

		// Token: 0x04000C3E RID: 3134
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0;

		// Token: 0x04000C3F RID: 3135
		private static readonly IntPtr NativeMethodInfoPtr_FromHexChar_Internal_Static_Byte_Char_0;

		// Token: 0x04000C40 RID: 3136
		private static readonly IntPtr NativeMethodInfoPtr_FromHexChars_Internal_Static_Byte_Char_Char_0;

		// Token: 0x04000C41 RID: 3137
		private static readonly IntPtr NativeMethodInfoPtr_FromHex_Internal_Static_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x04000C42 RID: 3138
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000C43 RID: 3139
		private static readonly IntPtr NativeMethodInfoPtr_Encode_Internal_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000C44 RID: 3140
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0;
	}
}
