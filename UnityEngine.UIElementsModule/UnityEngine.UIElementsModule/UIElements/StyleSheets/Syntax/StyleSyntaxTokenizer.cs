using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements.StyleSheets.Syntax
{
	// Token: 0x0200029E RID: 670
	public class StyleSyntaxTokenizer : Object
	{
		// Token: 0x06003171 RID: 12657 RVA: 0x000D1B5C File Offset: 0x000CFD5C
		// Note: this type is marked as 'beforefieldinit'.
		static StyleSyntaxTokenizer()
		{
			Il2CppClassPointerStore<StyleSyntaxTokenizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.StyleSheets.Syntax", "StyleSyntaxTokenizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleSyntaxTokenizer>.NativeClassPtr);
			StyleSyntaxTokenizer.NativeFieldInfoPtr_m_Tokens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSyntaxTokenizer>.NativeClassPtr, "m_Tokens");
			StyleSyntaxTokenizer.NativeFieldInfoPtr_m_CurrentTokenIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSyntaxTokenizer>.NativeClassPtr, "m_CurrentTokenIndex");
			StyleSyntaxTokenizer.NativeMethodInfoPtr_get_current_Public_get_StyleSyntaxToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSyntaxTokenizer>.NativeClassPtr, 100670469);
			StyleSyntaxTokenizer.NativeMethodInfoPtr_MoveNext_Public_StyleSyntaxToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSyntaxTokenizer>.NativeClassPtr, 100670470);
			StyleSyntaxTokenizer.NativeMethodInfoPtr_PeekNext_Public_StyleSyntaxToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSyntaxTokenizer>.NativeClassPtr, 100670471);
			StyleSyntaxTokenizer.NativeMethodInfoPtr_Tokenize_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSyntaxTokenizer>.NativeClassPtr, 100670472);
			StyleSyntaxTokenizer.NativeMethodInfoPtr_IsNextCharacter_Private_Static_Boolean_String_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSyntaxTokenizer>.NativeClassPtr, 100670473);
			StyleSyntaxTokenizer.NativeMethodInfoPtr_IsNextLetterOrDash_Private_Static_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSyntaxTokenizer>.NativeClassPtr, 100670474);
			StyleSyntaxTokenizer.NativeMethodInfoPtr_IsNextNumber_Private_Static_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSyntaxTokenizer>.NativeClassPtr, 100670475);
			StyleSyntaxTokenizer.NativeMethodInfoPtr_GlobCharacter_Private_Static_Int32_String_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSyntaxTokenizer>.NativeClassPtr, 100670476);
			StyleSyntaxTokenizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSyntaxTokenizer>.NativeClassPtr, 100670477);
		}

		// Token: 0x17000F84 RID: 3972
		// (get) Token: 0x06003172 RID: 12658 RVA: 0x000D1C68 File Offset: 0x000CFE68
		public unsafe StyleSyntaxToken current
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 359265, RefRangeEnd = 359281, XrefRangeStart = 359259, XrefRangeEnd = 359265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSyntaxTokenizer.NativeMethodInfoPtr_get_current_Public_get_StyleSyntaxToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new StyleSyntaxToken(intPtr);
			}
		}

		// Token: 0x06003173 RID: 12659 RVA: 0x000D1CA0 File Offset: 0x000CFEA0
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 359284, RefRangeEnd = 359306, XrefRangeStart = 359281, XrefRangeEnd = 359284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleSyntaxToken MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSyntaxTokenizer.NativeMethodInfoPtr_MoveNext_Public_StyleSyntaxToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new StyleSyntaxToken(intPtr);
		}

		// Token: 0x06003174 RID: 12660 RVA: 0x000D1CD8 File Offset: 0x000CFED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359306, XrefRangeEnd = 359312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleSyntaxToken PeekNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSyntaxTokenizer.NativeMethodInfoPtr_PeekNext_Public_StyleSyntaxToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new StyleSyntaxToken(intPtr);
		}

		// Token: 0x06003175 RID: 12661 RVA: 0x000D1D10 File Offset: 0x000CFF10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359415, RefRangeEnd = 359416, XrefRangeStart = 359312, XrefRangeEnd = 359415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Tokenize(string syntax)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(syntax);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSyntaxTokenizer.NativeMethodInfoPtr_Tokenize_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003176 RID: 12662 RVA: 0x000D1D54 File Offset: 0x000CFF54
		[CallerCount(0)]
		public unsafe static bool IsNextCharacter(string s, int index, char c)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSyntaxTokenizer.NativeMethodInfoPtr_IsNextCharacter_Private_Static_Boolean_String_Int32_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003177 RID: 12663 RVA: 0x000D1DB4 File Offset: 0x000CFFB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 359417, RefRangeEnd = 359419, XrefRangeStart = 359416, XrefRangeEnd = 359417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNextLetterOrDash(string s, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSyntaxTokenizer.NativeMethodInfoPtr_IsNextLetterOrDash_Private_Static_Boolean_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003178 RID: 12664 RVA: 0x000D1E04 File Offset: 0x000D0004
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 359420, RefRangeEnd = 359422, XrefRangeStart = 359419, XrefRangeEnd = 359420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNextNumber(string s, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSyntaxTokenizer.NativeMethodInfoPtr_IsNextNumber_Private_Static_Boolean_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003179 RID: 12665 RVA: 0x000D1E54 File Offset: 0x000D0054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359422, XrefRangeEnd = 359424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GlobCharacter(string s, int index, char c)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSyntaxTokenizer.NativeMethodInfoPtr_GlobCharacter_Private_Static_Int32_String_Int32_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600317A RID: 12666 RVA: 0x000D1EB4 File Offset: 0x000D00B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359424, XrefRangeEnd = 359432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleSyntaxTokenizer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleSyntaxTokenizer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSyntaxTokenizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600317B RID: 12667 RVA: 0x00014281 File Offset: 0x00012481
		public StyleSyntaxTokenizer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F82 RID: 3970
		// (get) Token: 0x0600317C RID: 12668 RVA: 0x000D1EF0 File Offset: 0x000D00F0
		// (set) Token: 0x0600317D RID: 12669 RVA: 0x0001428A File Offset: 0x0001248A
		public unsafe List<StyleSyntaxToken> m_Tokens
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSyntaxTokenizer.NativeFieldInfoPtr_m_Tokens);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StyleSyntaxToken>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSyntaxTokenizer.NativeFieldInfoPtr_m_Tokens), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F83 RID: 3971
		// (get) Token: 0x0600317E RID: 12670 RVA: 0x000D1F20 File Offset: 0x000D0120
		// (set) Token: 0x0600317F RID: 12671 RVA: 0x000142A9 File Offset: 0x000124A9
		public unsafe int m_CurrentTokenIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSyntaxTokenizer.NativeFieldInfoPtr_m_CurrentTokenIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSyntaxTokenizer.NativeFieldInfoPtr_m_CurrentTokenIndex)) = value;
			}
		}

		// Token: 0x04002460 RID: 9312
		private static readonly IntPtr NativeFieldInfoPtr_m_Tokens;

		// Token: 0x04002461 RID: 9313
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentTokenIndex;

		// Token: 0x04002462 RID: 9314
		private static readonly IntPtr NativeMethodInfoPtr_get_current_Public_get_StyleSyntaxToken_0;

		// Token: 0x04002463 RID: 9315
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_StyleSyntaxToken_0;

		// Token: 0x04002464 RID: 9316
		private static readonly IntPtr NativeMethodInfoPtr_PeekNext_Public_StyleSyntaxToken_0;

		// Token: 0x04002465 RID: 9317
		private static readonly IntPtr NativeMethodInfoPtr_Tokenize_Public_Void_String_0;

		// Token: 0x04002466 RID: 9318
		private static readonly IntPtr NativeMethodInfoPtr_IsNextCharacter_Private_Static_Boolean_String_Int32_Char_0;

		// Token: 0x04002467 RID: 9319
		private static readonly IntPtr NativeMethodInfoPtr_IsNextLetterOrDash_Private_Static_Boolean_String_Int32_0;

		// Token: 0x04002468 RID: 9320
		private static readonly IntPtr NativeMethodInfoPtr_IsNextNumber_Private_Static_Boolean_String_Int32_0;

		// Token: 0x04002469 RID: 9321
		private static readonly IntPtr NativeMethodInfoPtr_GlobCharacter_Private_Static_Int32_String_Int32_Char_0;

		// Token: 0x0400246A RID: 9322
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
