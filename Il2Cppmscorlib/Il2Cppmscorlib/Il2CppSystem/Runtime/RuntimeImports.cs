using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime
{
	// Token: 0x0200028D RID: 653
	public static class RuntimeImports : Object
	{
		// Token: 0x06002A0B RID: 10763 RVA: 0x000E01B0 File Offset: 0x000DE3B0
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeImports()
		{
			Il2CppClassPointerStore<RuntimeImports>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime", "RuntimeImports");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeImports>.NativeClassPtr);
			RuntimeImports.NativeMethodInfoPtr_RhZeroMemory_Internal_Static_Void_byref_Byte_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeImports>.NativeClassPtr, 100670155);
			RuntimeImports.NativeMethodInfoPtr_ZeroMemory_Private_Static_Void_ptr_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeImports>.NativeClassPtr, 100670156);
			RuntimeImports.NativeMethodInfoPtr_Memmove_Internal_Static_Void_ptr_Byte_ptr_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeImports>.NativeClassPtr, 100670157);
			RuntimeImports.NativeMethodInfoPtr_Memmove_wbarrier_Internal_Static_Void_ptr_Byte_ptr_Byte_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeImports>.NativeClassPtr, 100670158);
			RuntimeImports.NativeMethodInfoPtr__ecvt_s_Internal_Static_Void_ptr_Byte_Int32_Double_Int32_ptr_Int32_ptr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeImports>.NativeClassPtr, 100670159);
		}

		// Token: 0x06002A0C RID: 10764 RVA: 0x000E0244 File Offset: 0x000DE444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376767, XrefRangeEnd = 1376768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RhZeroMemory(ref byte b, ulong byteLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &b;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeImports.NativeMethodInfoPtr_RhZeroMemory_Internal_Static_Void_byref_Byte_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A0D RID: 10765 RVA: 0x000E0284 File Offset: 0x000DE484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ZeroMemory(void* p, uint byteLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = p;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeImports.NativeMethodInfoPtr_ZeroMemory_Private_Static_Void_ptr_Void_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A0E RID: 10766 RVA: 0x000E02C4 File Offset: 0x000DE4C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1376769, RefRangeEnd = 1376772, XrefRangeStart = 1376768, XrefRangeEnd = 1376769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Memmove(byte* dest, byte* src, uint len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = src;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeImports.NativeMethodInfoPtr_Memmove_Internal_Static_Void_ptr_Byte_ptr_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A0F RID: 10767 RVA: 0x000E0310 File Offset: 0x000DE510
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1376773, RefRangeEnd = 1376774, XrefRangeStart = 1376772, XrefRangeEnd = 1376773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Memmove_wbarrier(byte* dest, byte* src, uint len, IntPtr type_handle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = src;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type_handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeImports.NativeMethodInfoPtr_Memmove_wbarrier_Internal_Static_Void_ptr_Byte_ptr_Byte_UInt32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A10 RID: 10768 RVA: 0x000E036C File Offset: 0x000DE56C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1376775, RefRangeEnd = 1376776, XrefRangeStart = 1376774, XrefRangeEnd = 1376775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _ecvt_s(byte* buffer, int sizeInBytes, double value, int count, int* dec, int* sign)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeInBytes;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = dec;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = sign;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeImports.NativeMethodInfoPtr__ecvt_s_Internal_Static_Void_ptr_Byte_Int32_Double_Int32_ptr_Int32_ptr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A11 RID: 10769 RVA: 0x0000DF46 File Offset: 0x0000C146
		public RuntimeImports(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040023D3 RID: 9171
		private static readonly IntPtr NativeMethodInfoPtr_RhZeroMemory_Internal_Static_Void_byref_Byte_UInt64_0;

		// Token: 0x040023D4 RID: 9172
		private static readonly IntPtr NativeMethodInfoPtr_ZeroMemory_Private_Static_Void_ptr_Void_UInt32_0;

		// Token: 0x040023D5 RID: 9173
		private static readonly IntPtr NativeMethodInfoPtr_Memmove_Internal_Static_Void_ptr_Byte_ptr_Byte_UInt32_0;

		// Token: 0x040023D6 RID: 9174
		private static readonly IntPtr NativeMethodInfoPtr_Memmove_wbarrier_Internal_Static_Void_ptr_Byte_ptr_Byte_UInt32_IntPtr_0;

		// Token: 0x040023D7 RID: 9175
		private static readonly IntPtr NativeMethodInfoPtr__ecvt_s_Internal_Static_Void_ptr_Byte_Int32_Double_Int32_ptr_Int32_ptr_Int32_0;
	}
}
