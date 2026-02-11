using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace JsonFx.Utils
{
	// Token: 0x02000003 RID: 3
	public static class CharUtility : Object
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00003D98 File Offset: 0x00001F98
		// Note: this type is marked as 'beforefieldinit'.
		static CharUtility()
		{
			Il2CppClassPointerStore<CharUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.Utils", "CharUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharUtility>.NativeClassPtr);
			CharUtility.NativeMethodInfoPtr_IsNullOrWhiteSpace_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUtility>.NativeClassPtr, 100663299);
			CharUtility.NativeMethodInfoPtr_IsWhiteSpace_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUtility>.NativeClassPtr, 100663300);
			CharUtility.NativeMethodInfoPtr_IsControl_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUtility>.NativeClassPtr, 100663301);
			CharUtility.NativeMethodInfoPtr_IsLetter_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUtility>.NativeClassPtr, 100663302);
			CharUtility.NativeMethodInfoPtr_IsDigit_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUtility>.NativeClassPtr, 100663303);
			CharUtility.NativeMethodInfoPtr_IsHexDigit_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUtility>.NativeClassPtr, 100663304);
			CharUtility.NativeMethodInfoPtr_GetHexDigit_Public_Static_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUtility>.NativeClassPtr, 100663305);
			CharUtility.NativeMethodInfoPtr_GetHexString_Public_Static_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUtility>.NativeClassPtr, 100663306);
			CharUtility.NativeMethodInfoPtr_ConvertToUtf32_Public_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUtility>.NativeClassPtr, 100663307);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00003E7C File Offset: 0x0000207C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189635, XrefRangeEnd = 1189636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNullOrWhiteSpace(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUtility.NativeMethodInfoPtr_IsNullOrWhiteSpace_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00003EC0 File Offset: 0x000020C0
		[CallerCount(0)]
		public unsafe static bool IsWhiteSpace(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUtility.NativeMethodInfoPtr_IsWhiteSpace_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00003F00 File Offset: 0x00002100
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsControl(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUtility.NativeMethodInfoPtr_IsControl_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00003F40 File Offset: 0x00002140
		[CallerCount(0)]
		public unsafe static bool IsLetter(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUtility.NativeMethodInfoPtr_IsLetter_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00003F80 File Offset: 0x00002180
		[CallerCount(0)]
		public unsafe static bool IsDigit(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUtility.NativeMethodInfoPtr_IsDigit_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00003FC0 File Offset: 0x000021C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 434841, RefRangeEnd = 434844, XrefRangeStart = 434841, XrefRangeEnd = 434844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsHexDigit(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUtility.NativeMethodInfoPtr_IsHexDigit_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00004000 File Offset: 0x00002200
		[CallerCount(0)]
		public unsafe static char GetHexDigit(int i)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUtility.NativeMethodInfoPtr_GetHexDigit_Public_Static_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00004040 File Offset: 0x00002240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189636, XrefRangeEnd = 1189642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetHexString(ulong i)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUtility.NativeMethodInfoPtr_GetHexString_Public_Static_String_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00004078 File Offset: 0x00002278
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1189650, RefRangeEnd = 1189651, XrefRangeStart = 1189642, XrefRangeEnd = 1189650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ConvertToUtf32(string value, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharUtility.NativeMethodInfoPtr_ConvertToUtf32_Public_Static_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002059 File Offset: 0x00000259
		public CharUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_IsNullOrWhiteSpace_Public_Static_Boolean_String_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_IsWhiteSpace_Public_Static_Boolean_Char_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_IsControl_Public_Static_Boolean_Char_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_IsLetter_Public_Static_Boolean_Char_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_IsDigit_Public_Static_Boolean_Char_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_IsHexDigit_Public_Static_Boolean_Char_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_GetHexDigit_Public_Static_Char_Int32_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_GetHexString_Public_Static_String_UInt64_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToUtf32_Public_Static_Int32_String_Int32_0;
	}
}
