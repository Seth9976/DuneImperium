using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Btls
{
	// Token: 0x0200002C RID: 44
	public static class MonoBtlsError : Object
	{
		// Token: 0x060002AF RID: 687 RVA: 0x000254F4 File Offset: 0x000236F4
		// Note: this type is marked as 'beforefieldinit'.
		static MonoBtlsError()
		{
			Il2CppClassPointerStore<MonoBtlsError>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "MonoBtlsError");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsError>.NativeClassPtr);
			MonoBtlsError.NativeMethodInfoPtr_mono_btls_error_clear_error_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsError>.NativeClassPtr, 100663760);
			MonoBtlsError.NativeMethodInfoPtr_mono_btls_error_get_error_line_Private_Static_Int32_byref_IntPtr_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsError>.NativeClassPtr, 100663761);
			MonoBtlsError.NativeMethodInfoPtr_mono_btls_error_get_error_string_n_Private_Static_Void_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsError>.NativeClassPtr, 100663762);
			MonoBtlsError.NativeMethodInfoPtr_mono_btls_error_get_reason_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsError>.NativeClassPtr, 100663763);
			MonoBtlsError.NativeMethodInfoPtr_ClearError_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsError>.NativeClassPtr, 100663764);
			MonoBtlsError.NativeMethodInfoPtr_GetErrorString_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsError>.NativeClassPtr, 100663765);
			MonoBtlsError.NativeMethodInfoPtr_GetError_Public_Static_Int32_byref_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsError>.NativeClassPtr, 100663766);
			MonoBtlsError.NativeMethodInfoPtr_GetErrorReason_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsError>.NativeClassPtr, 100663767);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x000255C4 File Offset: 0x000237C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 429959, RefRangeEnd = 429961, XrefRangeStart = 429957, XrefRangeEnd = 429959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void mono_btls_error_clear_error()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsError.NativeMethodInfoPtr_mono_btls_error_clear_error_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x000255EC File Offset: 0x000237EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429961, XrefRangeEnd = 429963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_error_get_error_line(out IntPtr file, out int line)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &file;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &line;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsError.NativeMethodInfoPtr_mono_btls_error_get_error_line_Private_Static_Int32_byref_IntPtr_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00025638 File Offset: 0x00023838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429963, XrefRangeEnd = 429965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void mono_btls_error_get_error_string_n(int error, IntPtr buf, int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref error;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buf;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsError.NativeMethodInfoPtr_mono_btls_error_get_error_string_n_Private_Static_Void_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00025688 File Offset: 0x00023888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429965, XrefRangeEnd = 429967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_error_get_reason(int error)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref error;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsError.NativeMethodInfoPtr_mono_btls_error_get_reason_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x000256C8 File Offset: 0x000238C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 429959, RefRangeEnd = 429961, XrefRangeStart = 429959, XrefRangeEnd = 429961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearError()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsError.NativeMethodInfoPtr_ClearError_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x000256F0 File Offset: 0x000238F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429984, RefRangeEnd = 429985, XrefRangeStart = 429967, XrefRangeEnd = 429984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetErrorString(int error)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref error;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsError.NativeMethodInfoPtr_GetErrorString_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00025728 File Offset: 0x00023928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429985, XrefRangeEnd = 429994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetError(out string file, out int line)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &line;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MonoBtlsError.NativeMethodInfoPtr_GetError_Public_Static_Int32_byref_String_byref_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			file = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00025780 File Offset: 0x00023980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetErrorReason(int error)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref error;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsError.NativeMethodInfoPtr_GetErrorReason_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000301B File Offset: 0x0000121B
		public MonoBtlsError(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_error_clear_error_Private_Static_Void_0;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_error_get_error_line_Private_Static_Int32_byref_IntPtr_byref_Int32_0;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_error_get_error_string_n_Private_Static_Void_Int32_IntPtr_Int32_0;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_error_get_reason_Private_Static_Int32_Int32_0;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeMethodInfoPtr_ClearError_Public_Static_Void_0;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeMethodInfoPtr_GetErrorString_Public_Static_String_Int32_0;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeMethodInfoPtr_GetError_Public_Static_Int32_byref_String_byref_Int32_0;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeMethodInfoPtr_GetErrorReason_Public_Static_Int32_Int32_0;
	}
}
