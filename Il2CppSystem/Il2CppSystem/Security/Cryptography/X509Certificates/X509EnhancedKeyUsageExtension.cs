using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000D9 RID: 217
	public sealed class X509EnhancedKeyUsageExtension : X509Extension
	{
		// Token: 0x06000E8F RID: 3727 RVA: 0x0005305C File Offset: 0x0005125C
		// Note: this type is marked as 'beforefieldinit'.
		static X509EnhancedKeyUsageExtension()
		{
			Il2CppClassPointerStore<X509EnhancedKeyUsageExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509EnhancedKeyUsageExtension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509EnhancedKeyUsageExtension>.NativeClassPtr);
			X509EnhancedKeyUsageExtension.NativeFieldInfoPtr__enhKeyUsage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509EnhancedKeyUsageExtension>.NativeClassPtr, "_enhKeyUsage");
			X509EnhancedKeyUsageExtension.NativeFieldInfoPtr__status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509EnhancedKeyUsageExtension>.NativeClassPtr, "_status");
			X509EnhancedKeyUsageExtension.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509EnhancedKeyUsageExtension>.NativeClassPtr, 100665413);
			X509EnhancedKeyUsageExtension.NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509EnhancedKeyUsageExtension>.NativeClassPtr, 100665414);
			X509EnhancedKeyUsageExtension.NativeMethodInfoPtr__ctor_Public_Void_OidCollection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509EnhancedKeyUsageExtension>.NativeClassPtr, 100665415);
			X509EnhancedKeyUsageExtension.NativeMethodInfoPtr_get_EnhancedKeyUsages_Public_get_OidCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509EnhancedKeyUsageExtension>.NativeClassPtr, 100665416);
			X509EnhancedKeyUsageExtension.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509EnhancedKeyUsageExtension>.NativeClassPtr, 100665417);
			X509EnhancedKeyUsageExtension.NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509EnhancedKeyUsageExtension>.NativeClassPtr, 100665418);
			X509EnhancedKeyUsageExtension.NativeMethodInfoPtr_Encode_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509EnhancedKeyUsageExtension>.NativeClassPtr, 100665419);
			X509EnhancedKeyUsageExtension.NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509EnhancedKeyUsageExtension>.NativeClassPtr, 100665420);
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x00053154 File Offset: 0x00051354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 455309, XrefRangeEnd = 455321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509EnhancedKeyUsageExtension()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509EnhancedKeyUsageExtension>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509EnhancedKeyUsageExtension.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x00053190 File Offset: 0x00051390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 455321, XrefRangeEnd = 455335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509EnhancedKeyUsageExtension(AsnEncodedData encodedEnhancedKeyUsages, bool critical)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509EnhancedKeyUsageExtension>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(encodedEnhancedKeyUsages);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref critical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509EnhancedKeyUsageExtension.NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x000531EC File Offset: 0x000513EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 455335, XrefRangeEnd = 455402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509EnhancedKeyUsageExtension(OidCollection enhancedKeyUsages, bool critical)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509EnhancedKeyUsageExtension>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enhancedKeyUsages);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref critical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509EnhancedKeyUsageExtension.NativeMethodInfoPtr__ctor_Public_Void_OidCollection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000E93 RID: 3731 RVA: 0x00053248 File Offset: 0x00051448
		public unsafe OidCollection EnhancedKeyUsages
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 455413, RefRangeEnd = 455414, XrefRangeStart = 455402, XrefRangeEnd = 455413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509EnhancedKeyUsageExtension.NativeMethodInfoPtr_get_EnhancedKeyUsages_Public_get_OidCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<OidCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x00053288 File Offset: 0x00051488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 455414, XrefRangeEnd = 455434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyFrom(AsnEncodedData asnEncodedData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asnEncodedData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509EnhancedKeyUsageExtension.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x000532CC File Offset: 0x000514CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 455453, RefRangeEnd = 455456, XrefRangeStart = 455434, XrefRangeEnd = 455453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsnDecodeStatus Decode(Il2CppStructArray<byte> extension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extension);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509EnhancedKeyUsageExtension.NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x0005331C File Offset: 0x0005151C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 455456, XrefRangeEnd = 455473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> Encode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509EnhancedKeyUsageExtension.NativeMethodInfoPtr_Encode_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x0005335C File Offset: 0x0005155C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 455473, XrefRangeEnd = 455507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(bool multiLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509EnhancedKeyUsageExtension.NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x00007490 File Offset: 0x00005690
		public X509EnhancedKeyUsageExtension(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000E99 RID: 3737 RVA: 0x000533A0 File Offset: 0x000515A0
		// (set) Token: 0x06000E9A RID: 3738 RVA: 0x00007499 File Offset: 0x00005699
		public unsafe OidCollection _enhKeyUsage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509EnhancedKeyUsageExtension.NativeFieldInfoPtr__enhKeyUsage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OidCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509EnhancedKeyUsageExtension.NativeFieldInfoPtr__enhKeyUsage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000E9B RID: 3739 RVA: 0x000533D0 File Offset: 0x000515D0
		// (set) Token: 0x06000E9C RID: 3740 RVA: 0x000074B8 File Offset: 0x000056B8
		public unsafe AsnDecodeStatus _status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509EnhancedKeyUsageExtension.NativeFieldInfoPtr__status);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509EnhancedKeyUsageExtension.NativeFieldInfoPtr__status)) = value;
			}
		}

		// Token: 0x04000BF1 RID: 3057
		private static readonly IntPtr NativeFieldInfoPtr__enhKeyUsage;

		// Token: 0x04000BF2 RID: 3058
		private static readonly IntPtr NativeFieldInfoPtr__status;

		// Token: 0x04000BF3 RID: 3059
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000BF4 RID: 3060
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0;

		// Token: 0x04000BF5 RID: 3061
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_OidCollection_Boolean_0;

		// Token: 0x04000BF6 RID: 3062
		private static readonly IntPtr NativeMethodInfoPtr_get_EnhancedKeyUsages_Public_get_OidCollection_0;

		// Token: 0x04000BF7 RID: 3063
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0;

		// Token: 0x04000BF8 RID: 3064
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000BF9 RID: 3065
		private static readonly IntPtr NativeMethodInfoPtr_Encode_Internal_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000BFA RID: 3066
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0;
	}
}
