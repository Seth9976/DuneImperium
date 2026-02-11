using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000469 RID: 1129
	public static class CharUnicodeInfo : Object
	{
		// Token: 0x06004379 RID: 17273 RVA: 0x0013DF18 File Offset: 0x0013C118
		// Note: this type is marked as 'beforefieldinit'.
		static CharUnicodeInfo()
		{
			Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "CharUnicodeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr);
			CharUnicodeInfo.NativeMethodInfoPtr_InternalConvertToUtf32_Internal_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100673261);
			CharUnicodeInfo.NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100673262);
			CharUnicodeInfo.NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100673263);
			CharUnicodeInfo.NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100673264);
			CharUnicodeInfo.NativeMethodInfoPtr_InternalGetCategoryValue_Internal_Static_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100673265);
			CharUnicodeInfo.NativeMethodInfoPtr_InternalGetUnicodeCategory_Internal_Static_UnicodeCategory_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100673266);
			CharUnicodeInfo.NativeMethodInfoPtr_IsWhiteSpace_Internal_Static_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100673267);
			CharUnicodeInfo.NativeMethodInfoPtr_IsWhiteSpace_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100673268);
			CharUnicodeInfo.NativeMethodInfoPtr_get_CategoryLevel1Index_Private_Static_get_ReadOnlySpan_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100673269);
			CharUnicodeInfo.NativeMethodInfoPtr_get_CategoryLevel2Index_Private_Static_get_ReadOnlySpan_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100673270);
			CharUnicodeInfo.NativeMethodInfoPtr_get_CategoryLevel3Index_Private_Static_get_ReadOnlySpan_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100673271);
			CharUnicodeInfo.NativeMethodInfoPtr_get_CategoriesValue_Private_Static_get_ReadOnlySpan_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100673272);
		}

		// Token: 0x0600437A RID: 17274 RVA: 0x0013E038 File Offset: 0x0013C238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406420, XrefRangeEnd = 1406422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int InternalConvertToUtf32(string s, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUnicodeInfo.NativeMethodInfoPtr_InternalConvertToUtf32_Internal_Static_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600437B RID: 17275 RVA: 0x0013E088 File Offset: 0x0013C288
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1406423, RefRangeEnd = 1406435, XrefRangeStart = 1406422, XrefRangeEnd = 1406423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnicodeCategory GetUnicodeCategory(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUnicodeInfo.NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600437C RID: 17276 RVA: 0x0013E0C8 File Offset: 0x0013C2C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1406452, RefRangeEnd = 1406453, XrefRangeStart = 1406435, XrefRangeEnd = 1406452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnicodeCategory GetUnicodeCategory(string s, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUnicodeInfo.NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600437D RID: 17277 RVA: 0x0013E118 File Offset: 0x0013C318
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1406467, RefRangeEnd = 1406473, XrefRangeStart = 1406453, XrefRangeEnd = 1406467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnicodeCategory GetUnicodeCategory(int codePoint)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref codePoint;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUnicodeInfo.NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600437E RID: 17278 RVA: 0x0013E158 File Offset: 0x0013C358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406473, XrefRangeEnd = 1406487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte InternalGetCategoryValue(int ch, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUnicodeInfo.NativeMethodInfoPtr_InternalGetCategoryValue_Internal_Static_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600437F RID: 17279 RVA: 0x0013E1A4 File Offset: 0x0013C3A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1406493, RefRangeEnd = 1406494, XrefRangeStart = 1406487, XrefRangeEnd = 1406493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnicodeCategory InternalGetUnicodeCategory(string value, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUnicodeInfo.NativeMethodInfoPtr_InternalGetUnicodeCategory_Internal_Static_UnicodeCategory_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004380 RID: 17280 RVA: 0x0013E1F4 File Offset: 0x0013C3F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1406499, RefRangeEnd = 1406500, XrefRangeStart = 1406494, XrefRangeEnd = 1406499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsWhiteSpace(string s, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUnicodeInfo.NativeMethodInfoPtr_IsWhiteSpace_Internal_Static_Boolean_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004381 RID: 17281 RVA: 0x0013E244 File Offset: 0x0013C444
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1406501, RefRangeEnd = 1406502, XrefRangeStart = 1406500, XrefRangeEnd = 1406501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsWhiteSpace(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUnicodeInfo.NativeMethodInfoPtr_IsWhiteSpace_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001087 RID: 4231
		// (get) Token: 0x06004382 RID: 17282 RVA: 0x0013E284 File Offset: 0x0013C484
		public unsafe static ReadOnlySpan<byte> CategoryLevel1Index
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406502, XrefRangeEnd = 1406505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUnicodeInfo.NativeMethodInfoPtr_get_CategoryLevel1Index_Private_Static_get_ReadOnlySpan_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ReadOnlySpan<byte>(intPtr);
			}
		}

		// Token: 0x17001088 RID: 4232
		// (get) Token: 0x06004383 RID: 17283 RVA: 0x0013E2B0 File Offset: 0x0013C4B0
		public unsafe static ReadOnlySpan<byte> CategoryLevel2Index
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406505, XrefRangeEnd = 1406508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUnicodeInfo.NativeMethodInfoPtr_get_CategoryLevel2Index_Private_Static_get_ReadOnlySpan_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ReadOnlySpan<byte>(intPtr);
			}
		}

		// Token: 0x17001089 RID: 4233
		// (get) Token: 0x06004384 RID: 17284 RVA: 0x0013E2DC File Offset: 0x0013C4DC
		public unsafe static ReadOnlySpan<byte> CategoryLevel3Index
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406508, XrefRangeEnd = 1406511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUnicodeInfo.NativeMethodInfoPtr_get_CategoryLevel3Index_Private_Static_get_ReadOnlySpan_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ReadOnlySpan<byte>(intPtr);
			}
		}

		// Token: 0x1700108A RID: 4234
		// (get) Token: 0x06004385 RID: 17285 RVA: 0x0013E308 File Offset: 0x0013C508
		public unsafe static ReadOnlySpan<byte> CategoriesValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406511, XrefRangeEnd = 1406514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUnicodeInfo.NativeMethodInfoPtr_get_CategoriesValue_Private_Static_get_ReadOnlySpan_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ReadOnlySpan<byte>(intPtr);
			}
		}

		// Token: 0x06004386 RID: 17286 RVA: 0x00018731 File Offset: 0x00016931
		public CharUnicodeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003782 RID: 14210
		private static readonly IntPtr NativeMethodInfoPtr_InternalConvertToUtf32_Internal_Static_Int32_String_Int32_0;

		// Token: 0x04003783 RID: 14211
		private static readonly IntPtr NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_Char_0;

		// Token: 0x04003784 RID: 14212
		private static readonly IntPtr NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_String_Int32_0;

		// Token: 0x04003785 RID: 14213
		private static readonly IntPtr NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_Int32_0;

		// Token: 0x04003786 RID: 14214
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetCategoryValue_Internal_Static_Byte_Int32_Int32_0;

		// Token: 0x04003787 RID: 14215
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetUnicodeCategory_Internal_Static_UnicodeCategory_String_Int32_0;

		// Token: 0x04003788 RID: 14216
		private static readonly IntPtr NativeMethodInfoPtr_IsWhiteSpace_Internal_Static_Boolean_String_Int32_0;

		// Token: 0x04003789 RID: 14217
		private static readonly IntPtr NativeMethodInfoPtr_IsWhiteSpace_Internal_Static_Boolean_Char_0;

		// Token: 0x0400378A RID: 14218
		private static readonly IntPtr NativeMethodInfoPtr_get_CategoryLevel1Index_Private_Static_get_ReadOnlySpan_1_Byte_0;

		// Token: 0x0400378B RID: 14219
		private static readonly IntPtr NativeMethodInfoPtr_get_CategoryLevel2Index_Private_Static_get_ReadOnlySpan_1_Byte_0;

		// Token: 0x0400378C RID: 14220
		private static readonly IntPtr NativeMethodInfoPtr_get_CategoryLevel3Index_Private_Static_get_ReadOnlySpan_1_Byte_0;

		// Token: 0x0400378D RID: 14221
		private static readonly IntPtr NativeMethodInfoPtr_get_CategoriesValue_Private_Static_get_ReadOnlySpan_1_Byte_0;
	}
}
