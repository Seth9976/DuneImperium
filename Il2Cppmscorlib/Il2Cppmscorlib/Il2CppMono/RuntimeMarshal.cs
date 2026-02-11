using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono
{
	// Token: 0x02000010 RID: 16
	public static class RuntimeMarshal : Object
	{
		// Token: 0x0600004D RID: 77 RVA: 0x00026638 File Offset: 0x00024838
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeMarshal()
		{
			Il2CppClassPointerStore<RuntimeMarshal>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono", "RuntimeMarshal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeMarshal>.NativeClassPtr);
			RuntimeMarshal.NativeMethodInfoPtr_PtrToUtf8String_Internal_Static_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeMarshal>.NativeClassPtr, 100663412);
			RuntimeMarshal.NativeMethodInfoPtr_MarshalString_Internal_Static_SafeStringMarshal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeMarshal>.NativeClassPtr, 100663413);
			RuntimeMarshal.NativeMethodInfoPtr_DecodeBlobSize_Private_Static_Int32_IntPtr_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeMarshal>.NativeClassPtr, 100663414);
			RuntimeMarshal.NativeMethodInfoPtr_DecodeBlobArray_Internal_Static_Il2CppStructArray_1_Byte_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeMarshal>.NativeClassPtr, 100663415);
			RuntimeMarshal.NativeMethodInfoPtr_AsciHexDigitValue_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeMarshal>.NativeClassPtr, 100663416);
			RuntimeMarshal.NativeMethodInfoPtr_FreeAssemblyName_Internal_Static_Void_byref_MonoAssemblyName_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeMarshal>.NativeClassPtr, 100663417);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000266E0 File Offset: 0x000248E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1275992, RefRangeEnd = 1275994, XrefRangeStart = 1275986, XrefRangeEnd = 1275992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string PtrToUtf8String(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeMarshal.NativeMethodInfoPtr_PtrToUtf8String_Internal_Static_String_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00026718 File Offset: 0x00024918
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1275995, RefRangeEnd = 1275997, XrefRangeStart = 1275994, XrefRangeEnd = 1275995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SafeStringMarshal MarshalString(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeMarshal.NativeMethodInfoPtr_MarshalString_Internal_Static_SafeStringMarshal_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new SafeStringMarshal(intPtr);
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00026754 File Offset: 0x00024954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275997, XrefRangeEnd = 1276001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DecodeBlobSize(IntPtr in_ptr, out IntPtr out_ptr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref in_ptr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &out_ptr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeMarshal.NativeMethodInfoPtr_DecodeBlobSize_Private_Static_Int32_IntPtr_byref_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000267A0 File Offset: 0x000249A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1276012, RefRangeEnd = 1276013, XrefRangeStart = 1276001, XrefRangeEnd = 1276012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> DecodeBlobArray(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeMarshal.NativeMethodInfoPtr_DecodeBlobArray_Internal_Static_Il2CppStructArray_1_Byte_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000267E0 File Offset: 0x000249E0
		[CallerCount(0)]
		public unsafe static int AsciHexDigitValue(int c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeMarshal.NativeMethodInfoPtr_AsciHexDigitValue_Internal_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00026820 File Offset: 0x00024A20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1276014, RefRangeEnd = 1276016, XrefRangeStart = 1276013, XrefRangeEnd = 1276014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FreeAssemblyName(ref MonoAssemblyName name, bool freeStruct)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref freeStruct;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeMarshal.NativeMethodInfoPtr_FreeAssemblyName_Internal_Static_Void_byref_MonoAssemblyName_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000220B File Offset: 0x0000040B
		public RuntimeMarshal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_PtrToUtf8String_Internal_Static_String_IntPtr_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_MarshalString_Internal_Static_SafeStringMarshal_String_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_DecodeBlobSize_Private_Static_Int32_IntPtr_byref_IntPtr_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_DecodeBlobArray_Internal_Static_Il2CppStructArray_1_Byte_IntPtr_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_AsciHexDigitValue_Internal_Static_Int32_Int32_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_FreeAssemblyName_Internal_Static_Void_byref_MonoAssemblyName_Boolean_0;
	}
}
