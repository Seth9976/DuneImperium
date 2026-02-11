using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.StyleSheets.Syntax
{
	// Token: 0x0200029D RID: 669
	public sealed class StyleSyntaxToken : ValueType
	{
		// Token: 0x06003165 RID: 12645 RVA: 0x000D1934 File Offset: 0x000CFB34
		// Note: this type is marked as 'beforefieldinit'.
		static StyleSyntaxToken()
		{
			Il2CppClassPointerStore<StyleSyntaxToken>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.StyleSheets.Syntax", "StyleSyntaxToken");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleSyntaxToken>.NativeClassPtr);
			StyleSyntaxToken.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSyntaxToken>.NativeClassPtr, "type");
			StyleSyntaxToken.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSyntaxToken>.NativeClassPtr, "text");
			StyleSyntaxToken.NativeFieldInfoPtr_number = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSyntaxToken>.NativeClassPtr, "number");
			StyleSyntaxToken.NativeMethodInfoPtr__ctor_Public_Void_StyleSyntaxTokenType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSyntaxToken>.NativeClassPtr, 100670466);
			StyleSyntaxToken.NativeMethodInfoPtr__ctor_Public_Void_StyleSyntaxTokenType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSyntaxToken>.NativeClassPtr, 100670467);
			StyleSyntaxToken.NativeMethodInfoPtr__ctor_Public_Void_StyleSyntaxTokenType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSyntaxToken>.NativeClassPtr, 100670468);
		}

		// Token: 0x06003166 RID: 12646 RVA: 0x000D19DC File Offset: 0x000CFBDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359256, XrefRangeEnd = 359257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleSyntaxToken(StyleSyntaxTokenType t)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleSyntaxToken>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSyntaxToken.NativeMethodInfoPtr__ctor_Public_Void_StyleSyntaxTokenType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003167 RID: 12647 RVA: 0x000D1A28 File Offset: 0x000CFC28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359257, XrefRangeEnd = 359258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleSyntaxToken(StyleSyntaxTokenType type, string text)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleSyntaxToken>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSyntaxToken.NativeMethodInfoPtr__ctor_Public_Void_StyleSyntaxTokenType_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003168 RID: 12648 RVA: 0x000D1A88 File Offset: 0x000CFC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359258, XrefRangeEnd = 359259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleSyntaxToken(StyleSyntaxTokenType type, int number)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleSyntaxToken>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref number;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSyntaxToken.NativeMethodInfoPtr__ctor_Public_Void_StyleSyntaxTokenType_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003169 RID: 12649 RVA: 0x00014211 File Offset: 0x00012411
		public StyleSyntaxToken(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600316A RID: 12650 RVA: 0x0001421A File Offset: 0x0001241A
		public StyleSyntaxToken()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleSyntaxToken>.NativeClassPtr))
		{
		}

		// Token: 0x17000F7F RID: 3967
		// (get) Token: 0x0600316B RID: 12651 RVA: 0x000D1AE4 File Offset: 0x000CFCE4
		// (set) Token: 0x0600316C RID: 12652 RVA: 0x0001422C File Offset: 0x0001242C
		public unsafe StyleSyntaxTokenType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSyntaxToken.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSyntaxToken.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x17000F80 RID: 3968
		// (get) Token: 0x0600316D RID: 12653 RVA: 0x000D1B0C File Offset: 0x000CFD0C
		// (set) Token: 0x0600316E RID: 12654 RVA: 0x00014247 File Offset: 0x00012447
		public unsafe string text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSyntaxToken.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSyntaxToken.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F81 RID: 3969
		// (get) Token: 0x0600316F RID: 12655 RVA: 0x000D1B34 File Offset: 0x000CFD34
		// (set) Token: 0x06003170 RID: 12656 RVA: 0x00014266 File Offset: 0x00012466
		public unsafe int number
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSyntaxToken.NativeFieldInfoPtr_number);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSyntaxToken.NativeFieldInfoPtr_number)) = value;
			}
		}

		// Token: 0x0400245A RID: 9306
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x0400245B RID: 9307
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x0400245C RID: 9308
		private static readonly IntPtr NativeFieldInfoPtr_number;

		// Token: 0x0400245D RID: 9309
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StyleSyntaxTokenType_0;

		// Token: 0x0400245E RID: 9310
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StyleSyntaxTokenType_String_0;

		// Token: 0x0400245F RID: 9311
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StyleSyntaxTokenType_Int32_0;
	}
}
