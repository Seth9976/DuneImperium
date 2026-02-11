using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.IO.Enumeration
{
	// Token: 0x02000554 RID: 1364
	public static class FileSystemName : Object
	{
		// Token: 0x06005446 RID: 21574 RVA: 0x001882E4 File Offset: 0x001864E4
		// Note: this type is marked as 'beforefieldinit'.
		static FileSystemName()
		{
			Il2CppClassPointerStore<FileSystemName>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO.Enumeration", "FileSystemName");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileSystemName>.NativeClassPtr);
			FileSystemName.NativeFieldInfoPtr_s_wildcardChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemName>.NativeClassPtr, "s_wildcardChars");
			FileSystemName.NativeFieldInfoPtr_s_simpleWildcardChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemName>.NativeClassPtr, "s_simpleWildcardChars");
			FileSystemName.NativeMethodInfoPtr_TranslateWin32Expression_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemName>.NativeClassPtr, 100676250);
			FileSystemName.NativeMethodInfoPtr_MatchesWin32Expression_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemName>.NativeClassPtr, 100676251);
			FileSystemName.NativeMethodInfoPtr_MatchesSimpleExpression_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemName>.NativeClassPtr, 100676252);
			FileSystemName.NativeMethodInfoPtr_MatchPattern_Private_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemName>.NativeClassPtr, 100676253);
		}

		// Token: 0x06005447 RID: 21575 RVA: 0x0018838C File Offset: 0x0018658C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1435278, RefRangeEnd = 1435279, XrefRangeStart = 1435244, XrefRangeEnd = 1435278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string TranslateWin32Expression(string expression)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(expression);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemName.NativeMethodInfoPtr_TranslateWin32Expression_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06005448 RID: 21576 RVA: 0x001883C8 File Offset: 0x001865C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1435279, XrefRangeEnd = 1435283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MatchesWin32Expression(ReadOnlySpan<char> expression, ReadOnlySpan<char> name, bool ignoreCase = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(expression));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(name));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemName.NativeMethodInfoPtr_MatchesWin32Expression_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005449 RID: 21577 RVA: 0x00188434 File Offset: 0x00186634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1435283, XrefRangeEnd = 1435287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MatchesSimpleExpression(ReadOnlySpan<char> expression, ReadOnlySpan<char> name, bool ignoreCase = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(expression));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(name));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemName.NativeMethodInfoPtr_MatchesSimpleExpression_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600544A RID: 21578 RVA: 0x001884A0 File Offset: 0x001866A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1435354, RefRangeEnd = 1435357, XrefRangeStart = 1435287, XrefRangeEnd = 1435354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MatchPattern(ReadOnlySpan<char> expression, ReadOnlySpan<char> name, bool ignoreCase, bool useExtendedWildcards)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(expression));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(name));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useExtendedWildcards;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemName.NativeMethodInfoPtr_MatchPattern_Private_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600544B RID: 21579 RVA: 0x0001DDAE File Offset: 0x0001BFAE
		public FileSystemName(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001567 RID: 5479
		// (get) Token: 0x0600544C RID: 21580 RVA: 0x0018851C File Offset: 0x0018671C
		// (set) Token: 0x0600544D RID: 21581 RVA: 0x0001DDB7 File Offset: 0x0001BFB7
		public unsafe static Il2CppStructArray<char> s_wildcardChars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FileSystemName.NativeFieldInfoPtr_s_wildcardChars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FileSystemName.NativeFieldInfoPtr_s_wildcardChars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001568 RID: 5480
		// (get) Token: 0x0600544E RID: 21582 RVA: 0x00188544 File Offset: 0x00186744
		// (set) Token: 0x0600544F RID: 21583 RVA: 0x0001DDC9 File Offset: 0x0001BFC9
		public unsafe static Il2CppStructArray<char> s_simpleWildcardChars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FileSystemName.NativeFieldInfoPtr_s_simpleWildcardChars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FileSystemName.NativeFieldInfoPtr_s_simpleWildcardChars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040044E6 RID: 17638
		private static readonly IntPtr NativeFieldInfoPtr_s_wildcardChars;

		// Token: 0x040044E7 RID: 17639
		private static readonly IntPtr NativeFieldInfoPtr_s_simpleWildcardChars;

		// Token: 0x040044E8 RID: 17640
		private static readonly IntPtr NativeMethodInfoPtr_TranslateWin32Expression_Public_Static_String_String_0;

		// Token: 0x040044E9 RID: 17641
		private static readonly IntPtr NativeMethodInfoPtr_MatchesWin32Expression_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_Boolean_0;

		// Token: 0x040044EA RID: 17642
		private static readonly IntPtr NativeMethodInfoPtr_MatchesSimpleExpression_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_Boolean_0;

		// Token: 0x040044EB RID: 17643
		private static readonly IntPtr NativeMethodInfoPtr_MatchPattern_Private_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_Boolean_Boolean_0;
	}
}
