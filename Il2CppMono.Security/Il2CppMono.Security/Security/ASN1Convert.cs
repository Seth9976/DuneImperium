using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security
{
	// Token: 0x02000004 RID: 4
	public static class ASN1Convert : Object
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00005010 File Offset: 0x00003210
		// Note: this type is marked as 'beforefieldinit'.
		static ASN1Convert()
		{
			Il2CppClassPointerStore<ASN1Convert>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security", "ASN1Convert");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ASN1Convert>.NativeClassPtr);
			ASN1Convert.NativeMethodInfoPtr_FromInt32_Public_Static_ASN1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1Convert>.NativeClassPtr, 100663316);
			ASN1Convert.NativeMethodInfoPtr_FromOid_Public_Static_ASN1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1Convert>.NativeClassPtr, 100663317);
			ASN1Convert.NativeMethodInfoPtr_FromUnsignedBigInteger_Public_Static_ASN1_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1Convert>.NativeClassPtr, 100663318);
			ASN1Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1Convert>.NativeClassPtr, 100663319);
			ASN1Convert.NativeMethodInfoPtr_ToOid_Public_Static_String_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1Convert>.NativeClassPtr, 100663320);
			ASN1Convert.NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1Convert>.NativeClassPtr, 100663321);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000050B8 File Offset: 0x000032B8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1144495, RefRangeEnd = 1144501, XrefRangeStart = 1144456, XrefRangeEnd = 1144495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ASN1 FromInt32(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1Convert.NativeMethodInfoPtr_FromInt32_Public_Static_ASN1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr3) : null;
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000050F8 File Offset: 0x000032F8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1144509, RefRangeEnd = 1144517, XrefRangeStart = 1144501, XrefRangeEnd = 1144509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ASN1 FromOid(string oid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1Convert.NativeMethodInfoPtr_FromOid_Public_Static_ASN1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr3) : null;
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000513C File Offset: 0x0000333C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1144526, RefRangeEnd = 1144536, XrefRangeStart = 1144517, XrefRangeEnd = 1144526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ASN1 FromUnsignedBigInteger(Il2CppStructArray<byte> big)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(big);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1Convert.NativeMethodInfoPtr_FromUnsignedBigInteger_Public_Static_ASN1_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr3) : null;
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00005180 File Offset: 0x00003380
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1144542, RefRangeEnd = 1144546, XrefRangeStart = 1144536, XrefRangeEnd = 1144542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(ASN1 asn1)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asn1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_ASN1_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000051C4 File Offset: 0x000033C4
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 1144571, RefRangeEnd = 1144593, XrefRangeStart = 1144546, XrefRangeEnd = 1144571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToOid(ASN1 asn1)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asn1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1Convert.NativeMethodInfoPtr_ToOid_Public_Static_String_ASN1_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00005200 File Offset: 0x00003400
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1144613, RefRangeEnd = 1144620, XrefRangeStart = 1144593, XrefRangeEnd = 1144613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ToDateTime(ASN1 time)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(time);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1Convert.NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_ASN1_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000020C9 File Offset: 0x000002C9
		public ASN1Convert(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_FromInt32_Public_Static_ASN1_Int32_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_FromOid_Public_Static_ASN1_String_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_FromUnsignedBigInteger_Public_Static_ASN1_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_ASN1_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_ToOid_Public_Static_String_ASN1_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_ASN1_0;
	}
}
