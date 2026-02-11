using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000DE RID: 222
	public sealed class X509KeyUsageExtension : X509Extension
	{
		// Token: 0x06000EC6 RID: 3782 RVA: 0x00053E3C File Offset: 0x0005203C
		// Note: this type is marked as 'beforefieldinit'.
		static X509KeyUsageExtension()
		{
			Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509KeyUsageExtension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr);
			X509KeyUsageExtension.NativeFieldInfoPtr_oid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, "oid");
			X509KeyUsageExtension.NativeFieldInfoPtr_friendlyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, "friendlyName");
			X509KeyUsageExtension.NativeFieldInfoPtr_all = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, "all");
			X509KeyUsageExtension.NativeFieldInfoPtr__keyUsages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, "_keyUsages");
			X509KeyUsageExtension.NativeFieldInfoPtr__status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, "_status");
			X509KeyUsageExtension.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, 100665447);
			X509KeyUsageExtension.NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, 100665448);
			X509KeyUsageExtension.NativeMethodInfoPtr__ctor_Public_Void_X509KeyUsageFlags_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, 100665449);
			X509KeyUsageExtension.NativeMethodInfoPtr_get_KeyUsages_Public_get_X509KeyUsageFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, 100665450);
			X509KeyUsageExtension.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, 100665451);
			X509KeyUsageExtension.NativeMethodInfoPtr_GetValidFlags_Internal_X509KeyUsageFlags_X509KeyUsageFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, 100665452);
			X509KeyUsageExtension.NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, 100665453);
			X509KeyUsageExtension.NativeMethodInfoPtr_Encode_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, 100665454);
			X509KeyUsageExtension.NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, 100665455);
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x00053F84 File Offset: 0x00052184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 455653, XrefRangeEnd = 455665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509KeyUsageExtension()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509KeyUsageExtension.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x00053FC0 File Offset: 0x000521C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 455665, XrefRangeEnd = 455679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509KeyUsageExtension(AsnEncodedData encodedKeyUsage, bool critical)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(encodedKeyUsage);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref critical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509KeyUsageExtension.NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x0005401C File Offset: 0x0005221C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 455679, XrefRangeEnd = 455693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509KeyUsageExtension(X509KeyUsageFlags keyUsages, bool critical)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyUsages;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref critical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509KeyUsageExtension.NativeMethodInfoPtr__ctor_Public_Void_X509KeyUsageFlags_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000ECA RID: 3786 RVA: 0x00054074 File Offset: 0x00052274
		public unsafe X509KeyUsageFlags KeyUsages
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 455693, RefRangeEnd = 455698, XrefRangeStart = 455693, XrefRangeEnd = 455693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509KeyUsageExtension.NativeMethodInfoPtr_get_KeyUsages_Public_get_X509KeyUsageFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x000540B0 File Offset: 0x000522B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 455698, XrefRangeEnd = 455718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyFrom(AsnEncodedData asnEncodedData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asnEncodedData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509KeyUsageExtension.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x000540F4 File Offset: 0x000522F4
		[CallerCount(0)]
		public unsafe X509KeyUsageFlags GetValidFlags(X509KeyUsageFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509KeyUsageExtension.NativeMethodInfoPtr_GetValidFlags_Internal_X509KeyUsageFlags_X509KeyUsageFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x00054140 File Offset: 0x00052340
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 455726, RefRangeEnd = 455729, XrefRangeStart = 455718, XrefRangeEnd = 455726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsnDecodeStatus Decode(Il2CppStructArray<byte> extension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extension);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509KeyUsageExtension.NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x00054190 File Offset: 0x00052390
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 455743, RefRangeEnd = 455744, XrefRangeStart = 455729, XrefRangeEnd = 455743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> Encode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509KeyUsageExtension.NativeMethodInfoPtr_Encode_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x000541D0 File Offset: 0x000523D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 455744, XrefRangeEnd = 455825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(bool multiLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509KeyUsageExtension.NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x00007562 File Offset: 0x00005762
		public X509KeyUsageExtension(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000ED1 RID: 3793 RVA: 0x00054214 File Offset: 0x00052414
		// (set) Token: 0x06000ED2 RID: 3794 RVA: 0x0000756B File Offset: 0x0000576B
		public unsafe static string oid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509KeyUsageExtension.NativeFieldInfoPtr_oid, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509KeyUsageExtension.NativeFieldInfoPtr_oid, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000ED3 RID: 3795 RVA: 0x00054234 File Offset: 0x00052434
		// (set) Token: 0x06000ED4 RID: 3796 RVA: 0x0000757D File Offset: 0x0000577D
		public unsafe static string friendlyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509KeyUsageExtension.NativeFieldInfoPtr_friendlyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509KeyUsageExtension.NativeFieldInfoPtr_friendlyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000ED5 RID: 3797 RVA: 0x00054254 File Offset: 0x00052454
		// (set) Token: 0x06000ED6 RID: 3798 RVA: 0x0000758F File Offset: 0x0000578F
		public unsafe static X509KeyUsageFlags all
		{
			get
			{
				X509KeyUsageFlags x509KeyUsageFlags;
				IL2CPP.il2cpp_field_static_get_value(X509KeyUsageExtension.NativeFieldInfoPtr_all, (void*)(&x509KeyUsageFlags));
				return x509KeyUsageFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509KeyUsageExtension.NativeFieldInfoPtr_all, (void*)(&value));
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000ED7 RID: 3799 RVA: 0x00054270 File Offset: 0x00052470
		// (set) Token: 0x06000ED8 RID: 3800 RVA: 0x0000759D File Offset: 0x0000579D
		public unsafe X509KeyUsageFlags _keyUsages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509KeyUsageExtension.NativeFieldInfoPtr__keyUsages);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509KeyUsageExtension.NativeFieldInfoPtr__keyUsages)) = value;
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000ED9 RID: 3801 RVA: 0x00054298 File Offset: 0x00052498
		// (set) Token: 0x06000EDA RID: 3802 RVA: 0x000075B8 File Offset: 0x000057B8
		public unsafe AsnDecodeStatus _status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509KeyUsageExtension.NativeFieldInfoPtr__status);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509KeyUsageExtension.NativeFieldInfoPtr__status)) = value;
			}
		}

		// Token: 0x04000C18 RID: 3096
		private static readonly IntPtr NativeFieldInfoPtr_oid;

		// Token: 0x04000C19 RID: 3097
		private static readonly IntPtr NativeFieldInfoPtr_friendlyName;

		// Token: 0x04000C1A RID: 3098
		private static readonly IntPtr NativeFieldInfoPtr_all;

		// Token: 0x04000C1B RID: 3099
		private static readonly IntPtr NativeFieldInfoPtr__keyUsages;

		// Token: 0x04000C1C RID: 3100
		private static readonly IntPtr NativeFieldInfoPtr__status;

		// Token: 0x04000C1D RID: 3101
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C1E RID: 3102
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0;

		// Token: 0x04000C1F RID: 3103
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_X509KeyUsageFlags_Boolean_0;

		// Token: 0x04000C20 RID: 3104
		private static readonly IntPtr NativeMethodInfoPtr_get_KeyUsages_Public_get_X509KeyUsageFlags_0;

		// Token: 0x04000C21 RID: 3105
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0;

		// Token: 0x04000C22 RID: 3106
		private static readonly IntPtr NativeMethodInfoPtr_GetValidFlags_Internal_X509KeyUsageFlags_X509KeyUsageFlags_0;

		// Token: 0x04000C23 RID: 3107
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000C24 RID: 3108
		private static readonly IntPtr NativeMethodInfoPtr_Encode_Internal_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000C25 RID: 3109
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0;
	}
}
