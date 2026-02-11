using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000C8 RID: 200
	public sealed class X509BasicConstraintsExtension : X509Extension
	{
		// Token: 0x06000D1A RID: 3354 RVA: 0x0004D000 File Offset: 0x0004B200
		// Note: this type is marked as 'beforefieldinit'.
		static X509BasicConstraintsExtension()
		{
			Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509BasicConstraintsExtension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr);
			X509BasicConstraintsExtension.NativeFieldInfoPtr_oid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, "oid");
			X509BasicConstraintsExtension.NativeFieldInfoPtr_friendlyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, "friendlyName");
			X509BasicConstraintsExtension.NativeFieldInfoPtr__certificateAuthority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, "_certificateAuthority");
			X509BasicConstraintsExtension.NativeFieldInfoPtr__hasPathLengthConstraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, "_hasPathLengthConstraint");
			X509BasicConstraintsExtension.NativeFieldInfoPtr__pathLengthConstraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, "_pathLengthConstraint");
			X509BasicConstraintsExtension.NativeFieldInfoPtr__status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, "_status");
			X509BasicConstraintsExtension.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, 100665179);
			X509BasicConstraintsExtension.NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, 100665180);
			X509BasicConstraintsExtension.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, 100665181);
			X509BasicConstraintsExtension.NativeMethodInfoPtr_get_CertificateAuthority_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, 100665182);
			X509BasicConstraintsExtension.NativeMethodInfoPtr_get_HasPathLengthConstraint_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, 100665183);
			X509BasicConstraintsExtension.NativeMethodInfoPtr_get_PathLengthConstraint_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, 100665184);
			X509BasicConstraintsExtension.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, 100665185);
			X509BasicConstraintsExtension.NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, 100665186);
			X509BasicConstraintsExtension.NativeMethodInfoPtr_Encode_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, 100665187);
			X509BasicConstraintsExtension.NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, 100665188);
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x0004D170 File Offset: 0x0004B370
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 453075, RefRangeEnd = 453076, XrefRangeStart = 453063, XrefRangeEnd = 453075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509BasicConstraintsExtension()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509BasicConstraintsExtension.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x0004D1AC File Offset: 0x0004B3AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453076, XrefRangeEnd = 453090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509BasicConstraintsExtension(AsnEncodedData encodedBasicConstraints, bool critical)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(encodedBasicConstraints);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref critical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509BasicConstraintsExtension.NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x0004D208 File Offset: 0x0004B408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453090, XrefRangeEnd = 453132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509BasicConstraintsExtension(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref certificateAuthority;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasPathLengthConstraint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pathLengthConstraint;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref critical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509BasicConstraintsExtension.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000D1E RID: 3358 RVA: 0x0004D27C File Offset: 0x0004B47C
		public unsafe bool CertificateAuthority
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509BasicConstraintsExtension.NativeMethodInfoPtr_get_CertificateAuthority_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000D1F RID: 3359 RVA: 0x0004D2B8 File Offset: 0x0004B4B8
		public unsafe bool HasPathLengthConstraint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509BasicConstraintsExtension.NativeMethodInfoPtr_get_HasPathLengthConstraint_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000D20 RID: 3360 RVA: 0x0004D2F4 File Offset: 0x0004B4F4
		public unsafe int PathLengthConstraint
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 453132, RefRangeEnd = 453134, XrefRangeStart = 453132, XrefRangeEnd = 453132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509BasicConstraintsExtension.NativeMethodInfoPtr_get_PathLengthConstraint_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x0004D330 File Offset: 0x0004B530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453134, XrefRangeEnd = 453154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyFrom(AsnEncodedData asnEncodedData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asnEncodedData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509BasicConstraintsExtension.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x0004D374 File Offset: 0x0004B574
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 453155, RefRangeEnd = 453158, XrefRangeStart = 453154, XrefRangeEnd = 453155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsnDecodeStatus Decode(Il2CppStructArray<byte> extension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extension);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509BasicConstraintsExtension.NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x0004D3C4 File Offset: 0x0004B5C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453158, XrefRangeEnd = 453181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> Encode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509BasicConstraintsExtension.NativeMethodInfoPtr_Encode_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x0004D404 File Offset: 0x0004B604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453181, XrefRangeEnd = 453217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(bool multiLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509BasicConstraintsExtension.NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x00006D79 File Offset: 0x00004F79
		public X509BasicConstraintsExtension(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000D26 RID: 3366 RVA: 0x0004D448 File Offset: 0x0004B648
		// (set) Token: 0x06000D27 RID: 3367 RVA: 0x00006D82 File Offset: 0x00004F82
		public unsafe static string oid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509BasicConstraintsExtension.NativeFieldInfoPtr_oid, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509BasicConstraintsExtension.NativeFieldInfoPtr_oid, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000D28 RID: 3368 RVA: 0x0004D468 File Offset: 0x0004B668
		// (set) Token: 0x06000D29 RID: 3369 RVA: 0x00006D94 File Offset: 0x00004F94
		public unsafe static string friendlyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509BasicConstraintsExtension.NativeFieldInfoPtr_friendlyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509BasicConstraintsExtension.NativeFieldInfoPtr_friendlyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000D2A RID: 3370 RVA: 0x0004D488 File Offset: 0x0004B688
		// (set) Token: 0x06000D2B RID: 3371 RVA: 0x00006DA6 File Offset: 0x00004FA6
		public unsafe bool _certificateAuthority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509BasicConstraintsExtension.NativeFieldInfoPtr__certificateAuthority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509BasicConstraintsExtension.NativeFieldInfoPtr__certificateAuthority)) = value;
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000D2C RID: 3372 RVA: 0x0004D4B0 File Offset: 0x0004B6B0
		// (set) Token: 0x06000D2D RID: 3373 RVA: 0x00006DC1 File Offset: 0x00004FC1
		public unsafe bool _hasPathLengthConstraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509BasicConstraintsExtension.NativeFieldInfoPtr__hasPathLengthConstraint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509BasicConstraintsExtension.NativeFieldInfoPtr__hasPathLengthConstraint)) = value;
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000D2E RID: 3374 RVA: 0x0004D4D8 File Offset: 0x0004B6D8
		// (set) Token: 0x06000D2F RID: 3375 RVA: 0x00006DDC File Offset: 0x00004FDC
		public unsafe int _pathLengthConstraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509BasicConstraintsExtension.NativeFieldInfoPtr__pathLengthConstraint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509BasicConstraintsExtension.NativeFieldInfoPtr__pathLengthConstraint)) = value;
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000D30 RID: 3376 RVA: 0x0004D500 File Offset: 0x0004B700
		// (set) Token: 0x06000D31 RID: 3377 RVA: 0x00006DF7 File Offset: 0x00004FF7
		public unsafe AsnDecodeStatus _status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509BasicConstraintsExtension.NativeFieldInfoPtr__status);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509BasicConstraintsExtension.NativeFieldInfoPtr__status)) = value;
			}
		}

		// Token: 0x04000AD8 RID: 2776
		private static readonly IntPtr NativeFieldInfoPtr_oid;

		// Token: 0x04000AD9 RID: 2777
		private static readonly IntPtr NativeFieldInfoPtr_friendlyName;

		// Token: 0x04000ADA RID: 2778
		private static readonly IntPtr NativeFieldInfoPtr__certificateAuthority;

		// Token: 0x04000ADB RID: 2779
		private static readonly IntPtr NativeFieldInfoPtr__hasPathLengthConstraint;

		// Token: 0x04000ADC RID: 2780
		private static readonly IntPtr NativeFieldInfoPtr__pathLengthConstraint;

		// Token: 0x04000ADD RID: 2781
		private static readonly IntPtr NativeFieldInfoPtr__status;

		// Token: 0x04000ADE RID: 2782
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000ADF RID: 2783
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0;

		// Token: 0x04000AE0 RID: 2784
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Int32_Boolean_0;

		// Token: 0x04000AE1 RID: 2785
		private static readonly IntPtr NativeMethodInfoPtr_get_CertificateAuthority_Public_get_Boolean_0;

		// Token: 0x04000AE2 RID: 2786
		private static readonly IntPtr NativeMethodInfoPtr_get_HasPathLengthConstraint_Public_get_Boolean_0;

		// Token: 0x04000AE3 RID: 2787
		private static readonly IntPtr NativeMethodInfoPtr_get_PathLengthConstraint_Public_get_Int32_0;

		// Token: 0x04000AE4 RID: 2788
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0;

		// Token: 0x04000AE5 RID: 2789
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000AE6 RID: 2790
		private static readonly IntPtr NativeMethodInfoPtr_Encode_Internal_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000AE7 RID: 2791
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0;
	}
}
