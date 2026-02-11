using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements.StyleSheets.Syntax
{
	// Token: 0x0200029B RID: 667
	public class StyleSyntaxParser : Object
	{
		// Token: 0x0600314B RID: 12619 RVA: 0x000D1204 File Offset: 0x000CF404
		// Note: this type is marked as 'beforefieldinit'.
		static StyleSyntaxParser()
		{
			Il2CppClassPointerStore<StyleSyntaxParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.StyleSheets.Syntax", "StyleSyntaxParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleSyntaxParser>.NativeClassPtr);
			StyleSyntaxParser.NativeFieldInfoPtr_m_ProcessExpressionList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSyntaxParser>.NativeClassPtr, "m_ProcessExpressionList");
			StyleSyntaxParser.NativeFieldInfoPtr_m_ExpressionStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSyntaxParser>.NativeClassPtr, "m_ExpressionStack");
			StyleSyntaxParser.NativeFieldInfoPtr_m_CombinatorStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSyntaxParser>.NativeClassPtr, "m_CombinatorStack");
			StyleSyntaxParser.NativeFieldInfoPtr_m_ParsedExpressionCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSyntaxParser>.NativeClassPtr, "m_ParsedExpressionCache");
			StyleSyntaxParser.NativeMethodInfoPtr_Parse_Public_Expression_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSyntaxParser>.NativeClassPtr, 100670450);
			StyleSyntaxParser.NativeMethodInfoPtr_ParseExpression_Private_Expression_StyleSyntaxTokenizer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSyntaxParser>.NativeClassPtr, 100670451);
			StyleSyntaxParser.NativeMethodInfoPtr_ProcessCombinatorStack_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSyntaxParser>.NativeClassPtr, 100670452);
			StyleSyntaxParser.NativeMethodInfoPtr_ParseTerm_Private_Expression_StyleSyntaxTokenizer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSyntaxParser>.NativeClassPtr, 100670453);
			StyleSyntaxParser.NativeMethodInfoPtr_ParseCombinatorType_Private_ExpressionCombinator_StyleSyntaxTokenizer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSyntaxParser>.NativeClassPtr, 100670454);
			StyleSyntaxParser.NativeMethodInfoPtr_ParseGroup_Private_Expression_StyleSyntaxTokenizer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSyntaxParser>.NativeClassPtr, 100670455);
			StyleSyntaxParser.NativeMethodInfoPtr_ParseDataType_Private_Expression_StyleSyntaxTokenizer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSyntaxParser>.NativeClassPtr, 100670456);
			StyleSyntaxParser.NativeMethodInfoPtr_ParseNonTerminalValue_Private_Expression_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSyntaxParser>.NativeClassPtr, 100670457);
			StyleSyntaxParser.NativeMethodInfoPtr_ParseProperty_Private_Expression_StyleSyntaxTokenizer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSyntaxParser>.NativeClassPtr, 100670458);
			StyleSyntaxParser.NativeMethodInfoPtr_ParseMultiplier_Private_Void_StyleSyntaxTokenizer_byref_ExpressionMultiplier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSyntaxParser>.NativeClassPtr, 100670459);
			StyleSyntaxParser.NativeMethodInfoPtr_ParseRanges_Private_Void_StyleSyntaxTokenizer_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSyntaxParser>.NativeClassPtr, 100670460);
			StyleSyntaxParser.NativeMethodInfoPtr_EatSpace_Private_Static_Void_StyleSyntaxTokenizer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSyntaxParser>.NativeClassPtr, 100670461);
			StyleSyntaxParser.NativeMethodInfoPtr_IsExpressionEnd_Private_Static_Boolean_StyleSyntaxToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSyntaxParser>.NativeClassPtr, 100670462);
			StyleSyntaxParser.NativeMethodInfoPtr_IsCombinator_Private_Static_Boolean_StyleSyntaxToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSyntaxParser>.NativeClassPtr, 100670463);
			StyleSyntaxParser.NativeMethodInfoPtr_IsMultiplier_Private_Static_Boolean_StyleSyntaxToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSyntaxParser>.NativeClassPtr, 100670464);
			StyleSyntaxParser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSyntaxParser>.NativeClassPtr, 100670465);
		}

		// Token: 0x0600314C RID: 12620 RVA: 0x000D13C4 File Offset: 0x000CF5C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 358962, RefRangeEnd = 358966, XrefRangeStart = 358938, XrefRangeEnd = 358962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Expression Parse(string syntax)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(syntax);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSyntaxParser.NativeMethodInfoPtr_Parse_Public_Expression_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x0600314D RID: 12621 RVA: 0x000D1414 File Offset: 0x000CF614
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 359004, RefRangeEnd = 359006, XrefRangeStart = 358966, XrefRangeEnd = 359004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Expression ParseExpression(StyleSyntaxTokenizer tokenizer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokenizer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSyntaxParser.NativeMethodInfoPtr_ParseExpression_Private_Expression_StyleSyntaxTokenizer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x0600314E RID: 12622 RVA: 0x000D1464 File Offset: 0x000CF664
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 359052, RefRangeEnd = 359054, XrefRangeStart = 359006, XrefRangeEnd = 359052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessCombinatorStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSyntaxParser.NativeMethodInfoPtr_ProcessCombinatorStack_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600314F RID: 12623 RVA: 0x000D1498 File Offset: 0x000CF698
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359065, RefRangeEnd = 359066, XrefRangeStart = 359054, XrefRangeEnd = 359065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Expression ParseTerm(StyleSyntaxTokenizer tokenizer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokenizer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSyntaxParser.NativeMethodInfoPtr_ParseTerm_Private_Expression_StyleSyntaxTokenizer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06003150 RID: 12624 RVA: 0x000D14E8 File Offset: 0x000CF6E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359083, RefRangeEnd = 359084, XrefRangeStart = 359066, XrefRangeEnd = 359083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExpressionCombinator ParseCombinatorType(StyleSyntaxTokenizer tokenizer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokenizer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSyntaxParser.NativeMethodInfoPtr_ParseCombinatorType_Private_ExpressionCombinator_StyleSyntaxTokenizer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003151 RID: 12625 RVA: 0x000D1538 File Offset: 0x000CF738
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359105, RefRangeEnd = 359106, XrefRangeStart = 359084, XrefRangeEnd = 359105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Expression ParseGroup(StyleSyntaxTokenizer tokenizer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokenizer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSyntaxParser.NativeMethodInfoPtr_ParseGroup_Private_Expression_StyleSyntaxTokenizer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06003152 RID: 12626 RVA: 0x000D1588 File Offset: 0x000CF788
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359160, RefRangeEnd = 359161, XrefRangeStart = 359106, XrefRangeEnd = 359160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Expression ParseDataType(StyleSyntaxTokenizer tokenizer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokenizer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSyntaxParser.NativeMethodInfoPtr_ParseDataType_Private_Expression_StyleSyntaxTokenizer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06003153 RID: 12627 RVA: 0x000D15D8 File Offset: 0x000CF7D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359161, XrefRangeEnd = 359180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Expression ParseNonTerminalValue(string syntax)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(syntax);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSyntaxParser.NativeMethodInfoPtr_ParseNonTerminalValue_Private_Expression_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06003154 RID: 12628 RVA: 0x000D1628 File Offset: 0x000CF828
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359205, RefRangeEnd = 359206, XrefRangeStart = 359180, XrefRangeEnd = 359205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Expression ParseProperty(StyleSyntaxTokenizer tokenizer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokenizer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSyntaxParser.NativeMethodInfoPtr_ParseProperty_Private_Expression_StyleSyntaxTokenizer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06003155 RID: 12629 RVA: 0x000D1678 File Offset: 0x000CF878
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 359218, RefRangeEnd = 359220, XrefRangeStart = 359206, XrefRangeEnd = 359218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseMultiplier(StyleSyntaxTokenizer tokenizer, ref ExpressionMultiplier multiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokenizer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &multiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSyntaxParser.NativeMethodInfoPtr_ParseMultiplier_Private_Void_StyleSyntaxTokenizer_byref_ExpressionMultiplier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003156 RID: 12630 RVA: 0x000D16C8 File Offset: 0x000CF8C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359220, XrefRangeEnd = 359225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseRanges(StyleSyntaxTokenizer tokenizer, out int min, out int max)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokenizer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSyntaxParser.NativeMethodInfoPtr_ParseRanges_Private_Void_StyleSyntaxTokenizer_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003157 RID: 12631 RVA: 0x000D1728 File Offset: 0x000CF928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359225, XrefRangeEnd = 359227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EatSpace(StyleSyntaxTokenizer tokenizer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokenizer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSyntaxParser.NativeMethodInfoPtr_EatSpace_Private_Static_Void_StyleSyntaxTokenizer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003158 RID: 12632 RVA: 0x000D1760 File Offset: 0x000CF960
		[CallerCount(0)]
		public unsafe static bool IsExpressionEnd(StyleSyntaxToken token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(token));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSyntaxParser.NativeMethodInfoPtr_IsExpressionEnd_Private_Static_Boolean_StyleSyntaxToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003159 RID: 12633 RVA: 0x000D17A8 File Offset: 0x000CF9A8
		[CallerCount(0)]
		public unsafe static bool IsCombinator(StyleSyntaxToken token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(token));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSyntaxParser.NativeMethodInfoPtr_IsCombinator_Private_Static_Boolean_StyleSyntaxToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600315A RID: 12634 RVA: 0x000D17F0 File Offset: 0x000CF9F0
		[CallerCount(0)]
		public unsafe static bool IsMultiplier(StyleSyntaxToken token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(token));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSyntaxParser.NativeMethodInfoPtr_IsMultiplier_Private_Static_Boolean_StyleSyntaxToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600315B RID: 12635 RVA: 0x000D1838 File Offset: 0x000CFA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359227, XrefRangeEnd = 359256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleSyntaxParser()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleSyntaxParser>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSyntaxParser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600315C RID: 12636 RVA: 0x0001418C File Offset: 0x0001238C
		public StyleSyntaxParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F7B RID: 3963
		// (get) Token: 0x0600315D RID: 12637 RVA: 0x000D1874 File Offset: 0x000CFA74
		// (set) Token: 0x0600315E RID: 12638 RVA: 0x00014195 File Offset: 0x00012395
		public unsafe List<Expression> m_ProcessExpressionList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSyntaxParser.NativeFieldInfoPtr_m_ProcessExpressionList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Expression>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSyntaxParser.NativeFieldInfoPtr_m_ProcessExpressionList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F7C RID: 3964
		// (get) Token: 0x0600315F RID: 12639 RVA: 0x000D18A4 File Offset: 0x000CFAA4
		// (set) Token: 0x06003160 RID: 12640 RVA: 0x000141B4 File Offset: 0x000123B4
		public unsafe Stack<Expression> m_ExpressionStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSyntaxParser.NativeFieldInfoPtr_m_ExpressionStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<Expression>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSyntaxParser.NativeFieldInfoPtr_m_ExpressionStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F7D RID: 3965
		// (get) Token: 0x06003161 RID: 12641 RVA: 0x000D18D4 File Offset: 0x000CFAD4
		// (set) Token: 0x06003162 RID: 12642 RVA: 0x000141D3 File Offset: 0x000123D3
		public unsafe Stack<ExpressionCombinator> m_CombinatorStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSyntaxParser.NativeFieldInfoPtr_m_CombinatorStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<ExpressionCombinator>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSyntaxParser.NativeFieldInfoPtr_m_CombinatorStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F7E RID: 3966
		// (get) Token: 0x06003163 RID: 12643 RVA: 0x000D1904 File Offset: 0x000CFB04
		// (set) Token: 0x06003164 RID: 12644 RVA: 0x000141F2 File Offset: 0x000123F2
		public unsafe Dictionary<string, Expression> m_ParsedExpressionCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSyntaxParser.NativeFieldInfoPtr_m_ParsedExpressionCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Expression>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSyntaxParser.NativeFieldInfoPtr_m_ParsedExpressionCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002430 RID: 9264
		private static readonly IntPtr NativeFieldInfoPtr_m_ProcessExpressionList;

		// Token: 0x04002431 RID: 9265
		private static readonly IntPtr NativeFieldInfoPtr_m_ExpressionStack;

		// Token: 0x04002432 RID: 9266
		private static readonly IntPtr NativeFieldInfoPtr_m_CombinatorStack;

		// Token: 0x04002433 RID: 9267
		private static readonly IntPtr NativeFieldInfoPtr_m_ParsedExpressionCache;

		// Token: 0x04002434 RID: 9268
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Expression_String_0;

		// Token: 0x04002435 RID: 9269
		private static readonly IntPtr NativeMethodInfoPtr_ParseExpression_Private_Expression_StyleSyntaxTokenizer_0;

		// Token: 0x04002436 RID: 9270
		private static readonly IntPtr NativeMethodInfoPtr_ProcessCombinatorStack_Private_Void_0;

		// Token: 0x04002437 RID: 9271
		private static readonly IntPtr NativeMethodInfoPtr_ParseTerm_Private_Expression_StyleSyntaxTokenizer_0;

		// Token: 0x04002438 RID: 9272
		private static readonly IntPtr NativeMethodInfoPtr_ParseCombinatorType_Private_ExpressionCombinator_StyleSyntaxTokenizer_0;

		// Token: 0x04002439 RID: 9273
		private static readonly IntPtr NativeMethodInfoPtr_ParseGroup_Private_Expression_StyleSyntaxTokenizer_0;

		// Token: 0x0400243A RID: 9274
		private static readonly IntPtr NativeMethodInfoPtr_ParseDataType_Private_Expression_StyleSyntaxTokenizer_0;

		// Token: 0x0400243B RID: 9275
		private static readonly IntPtr NativeMethodInfoPtr_ParseNonTerminalValue_Private_Expression_String_0;

		// Token: 0x0400243C RID: 9276
		private static readonly IntPtr NativeMethodInfoPtr_ParseProperty_Private_Expression_StyleSyntaxTokenizer_0;

		// Token: 0x0400243D RID: 9277
		private static readonly IntPtr NativeMethodInfoPtr_ParseMultiplier_Private_Void_StyleSyntaxTokenizer_byref_ExpressionMultiplier_0;

		// Token: 0x0400243E RID: 9278
		private static readonly IntPtr NativeMethodInfoPtr_ParseRanges_Private_Void_StyleSyntaxTokenizer_byref_Int32_byref_Int32_0;

		// Token: 0x0400243F RID: 9279
		private static readonly IntPtr NativeMethodInfoPtr_EatSpace_Private_Static_Void_StyleSyntaxTokenizer_0;

		// Token: 0x04002440 RID: 9280
		private static readonly IntPtr NativeMethodInfoPtr_IsExpressionEnd_Private_Static_Boolean_StyleSyntaxToken_0;

		// Token: 0x04002441 RID: 9281
		private static readonly IntPtr NativeMethodInfoPtr_IsCombinator_Private_Static_Boolean_StyleSyntaxToken_0;

		// Token: 0x04002442 RID: 9282
		private static readonly IntPtr NativeMethodInfoPtr_IsMultiplier_Private_Static_Boolean_StyleSyntaxToken_0;

		// Token: 0x04002443 RID: 9283
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
