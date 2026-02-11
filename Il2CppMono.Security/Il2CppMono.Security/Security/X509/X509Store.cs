using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Il2CppMono.Security.X509
{
	// Token: 0x02000011 RID: 17
	public class X509Store : Object
	{
		// Token: 0x06000150 RID: 336 RVA: 0x00009768 File Offset: 0x00007968
		// Note: this type is marked as 'beforefieldinit'.
		static X509Store()
		{
			Il2CppClassPointerStore<X509Store>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.X509", "X509Store");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Store>.NativeClassPtr);
			X509Store.NativeFieldInfoPtr__storePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Store>.NativeClassPtr, "_storePath");
			X509Store.NativeFieldInfoPtr__certificates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Store>.NativeClassPtr, "_certificates");
			X509Store.NativeFieldInfoPtr__crls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Store>.NativeClassPtr, "_crls");
			X509Store.NativeFieldInfoPtr__crl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Store>.NativeClassPtr, "_crl");
			X509Store.NativeFieldInfoPtr__newFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Store>.NativeClassPtr, "_newFormat");
			X509Store.NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Store>.NativeClassPtr, 100663509);
			X509Store.NativeMethodInfoPtr_get_Certificates_Public_get_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Store>.NativeClassPtr, 100663510);
			X509Store.NativeMethodInfoPtr_get_Crls_Public_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Store>.NativeClassPtr, 100663511);
			X509Store.NativeMethodInfoPtr_Load_Private_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Store>.NativeClassPtr, 100663512);
			X509Store.NativeMethodInfoPtr_LoadCertificate_Private_X509Certificate_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Store>.NativeClassPtr, 100663513);
			X509Store.NativeMethodInfoPtr_LoadCrl_Private_X509Crl_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Store>.NativeClassPtr, 100663514);
			X509Store.NativeMethodInfoPtr_CheckStore_Private_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Store>.NativeClassPtr, 100663515);
			X509Store.NativeMethodInfoPtr_BuildCertificatesCollection_Private_X509CertificateCollection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Store>.NativeClassPtr, 100663516);
			X509Store.NativeMethodInfoPtr_BuildCrlsCollection_Private_ArrayList_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Store>.NativeClassPtr, 100663517);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000098B0 File Offset: 0x00007AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148111, XrefRangeEnd = 1148113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Store(string path, bool crl, bool newFormat)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Store>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref crl;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newFormat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Store.NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00009918 File Offset: 0x00007B18
		public unsafe X509CertificateCollection Certificates
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1148115, RefRangeEnd = 1148116, XrefRangeStart = 1148113, XrefRangeEnd = 1148115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Store.NativeMethodInfoPtr_get_Certificates_Public_get_X509CertificateCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000153 RID: 339 RVA: 0x00009958 File Offset: 0x00007B58
		public unsafe ArrayList Crls
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1148123, RefRangeEnd = 1148124, XrefRangeStart = 1148116, XrefRangeEnd = 1148123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Store.NativeMethodInfoPtr_get_Crls_Public_get_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00009998 File Offset: 0x00007B98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1148135, RefRangeEnd = 1148137, XrefRangeStart = 1148124, XrefRangeEnd = 1148135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> Load(string filename)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Store.NativeMethodInfoPtr_Load_Private_Il2CppStructArray_1_Byte_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000099E8 File Offset: 0x00007BE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1148142, RefRangeEnd = 1148143, XrefRangeStart = 1148137, XrefRangeEnd = 1148142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate LoadCertificate(string filename)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Store.NativeMethodInfoPtr_LoadCertificate_Private_X509Certificate_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00009A38 File Offset: 0x00007C38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1148157, RefRangeEnd = 1148158, XrefRangeStart = 1148143, XrefRangeEnd = 1148157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Crl LoadCrl(string filename)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Store.NativeMethodInfoPtr_LoadCrl_Private_X509Crl_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Crl>(intPtr3) : null;
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00009A88 File Offset: 0x00007C88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1148163, RefRangeEnd = 1148165, XrefRangeStart = 1148158, XrefRangeEnd = 1148163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckStore(string path, bool throwException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwException;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Store.NativeMethodInfoPtr_CheckStore_Private_Boolean_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00009AE4 File Offset: 0x00007CE4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1148182, RefRangeEnd = 1148185, XrefRangeStart = 1148165, XrefRangeEnd = 1148182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509CertificateCollection BuildCertificatesCollection(string storeName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(storeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Store.NativeMethodInfoPtr_BuildCertificatesCollection_Private_X509CertificateCollection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00009B34 File Offset: 0x00007D34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1148200, RefRangeEnd = 1148201, XrefRangeStart = 1148185, XrefRangeEnd = 1148200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayList BuildCrlsCollection(string storeName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(storeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Store.NativeMethodInfoPtr_BuildCrlsCollection_Private_ArrayList_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000028D1 File Offset: 0x00000AD1
		public X509Store(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00009B84 File Offset: 0x00007D84
		// (set) Token: 0x0600015C RID: 348 RVA: 0x000028DA File Offset: 0x00000ADA
		public unsafe string _storePath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Store.NativeFieldInfoPtr__storePath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Store.NativeFieldInfoPtr__storePath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00009BAC File Offset: 0x00007DAC
		// (set) Token: 0x0600015E RID: 350 RVA: 0x000028F9 File Offset: 0x00000AF9
		public unsafe X509CertificateCollection _certificates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Store.NativeFieldInfoPtr__certificates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Store.NativeFieldInfoPtr__certificates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00009BDC File Offset: 0x00007DDC
		// (set) Token: 0x06000160 RID: 352 RVA: 0x00002918 File Offset: 0x00000B18
		public unsafe ArrayList _crls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Store.NativeFieldInfoPtr__crls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Store.NativeFieldInfoPtr__crls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00009C0C File Offset: 0x00007E0C
		// (set) Token: 0x06000162 RID: 354 RVA: 0x00002937 File Offset: 0x00000B37
		public unsafe bool _crl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Store.NativeFieldInfoPtr__crl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Store.NativeFieldInfoPtr__crl)) = value;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00009C34 File Offset: 0x00007E34
		// (set) Token: 0x06000164 RID: 356 RVA: 0x00002952 File Offset: 0x00000B52
		public unsafe bool _newFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Store.NativeFieldInfoPtr__newFormat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Store.NativeFieldInfoPtr__newFormat)) = value;
			}
		}

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeFieldInfoPtr__storePath;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeFieldInfoPtr__certificates;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeFieldInfoPtr__crls;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeFieldInfoPtr__crl;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeFieldInfoPtr__newFormat;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_Boolean_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr_get_Certificates_Public_get_X509CertificateCollection_0;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeMethodInfoPtr_get_Crls_Public_get_ArrayList_0;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeMethodInfoPtr_Load_Private_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr_LoadCertificate_Private_X509Certificate_String_0;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr_LoadCrl_Private_X509Crl_String_0;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr_CheckStore_Private_Boolean_String_Boolean_0;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr_BuildCertificatesCollection_Private_X509CertificateCollection_String_0;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeMethodInfoPtr_BuildCrlsCollection_Private_ArrayList_String_0;
	}
}
