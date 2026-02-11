using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x0200028B RID: 651
	public static class StyleSelectorHelper : Object
	{
		// Token: 0x060030C4 RID: 12484 RVA: 0x000CF06C File Offset: 0x000CD26C
		// Note: this type is marked as 'beforefieldinit'.
		static StyleSelectorHelper()
		{
			Il2CppClassPointerStore<StyleSelectorHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.StyleSheets", "StyleSelectorHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleSelectorHelper>.NativeClassPtr);
			StyleSelectorHelper.NativeMethodInfoPtr_MatchesSelector_Public_Static_MatchResultInfo_VisualElement_StyleSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSelectorHelper>.NativeClassPtr, 100670372);
			StyleSelectorHelper.NativeMethodInfoPtr_MatchRightToLeft_Public_Static_Boolean_VisualElement_StyleComplexSelector_Action_2_VisualElement_MatchResultInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSelectorHelper>.NativeClassPtr, 100670373);
			StyleSelectorHelper.NativeMethodInfoPtr_FastLookup_Private_Static_Void_IDictionary_2_String_StyleComplexSelector_List_1_SelectorMatchRecord_StyleMatchingContext_String_byref_SelectorMatchRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSelectorHelper>.NativeClassPtr, 100670374);
			StyleSelectorHelper.NativeMethodInfoPtr_FindMatches_Public_Static_Void_StyleMatchingContext_List_1_SelectorMatchRecord_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSelectorHelper>.NativeClassPtr, 100670375);
		}

		// Token: 0x060030C5 RID: 12485 RVA: 0x000CF0EC File Offset: 0x000CD2EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 358495, RefRangeEnd = 358497, XrefRangeStart = 358472, XrefRangeEnd = 358495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MatchResultInfo MatchesSelector(VisualElement element, StyleSelector selector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSelectorHelper.NativeMethodInfoPtr_MatchesSelector_Public_Static_MatchResultInfo_VisualElement_StyleSelector_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060030C6 RID: 12486 RVA: 0x000CF140 File Offset: 0x000CD340
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358510, RefRangeEnd = 358511, XrefRangeStart = 358497, XrefRangeEnd = 358510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MatchRightToLeft(VisualElement element, StyleComplexSelector complexSelector, Action<VisualElement, MatchResultInfo> processResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(complexSelector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(processResult);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSelectorHelper.NativeMethodInfoPtr_MatchRightToLeft_Public_Static_Boolean_VisualElement_StyleComplexSelector_Action_2_VisualElement_MatchResultInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060030C7 RID: 12487 RVA: 0x000CF1A8 File Offset: 0x000CD3A8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 358535, RefRangeEnd = 358539, XrefRangeStart = 358511, XrefRangeEnd = 358535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FastLookup(IDictionary<string, StyleComplexSelector> table, List<SelectorMatchRecord> matchedSelectors, StyleMatchingContext context, string input, ref SelectorMatchRecord record)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(matchedSelectors);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(input);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(record);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSelectorHelper.NativeMethodInfoPtr_FastLookup_Private_Static_Void_IDictionary_2_String_StyleComplexSelector_List_1_SelectorMatchRecord_StyleMatchingContext_String_byref_SelectorMatchRecord_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030C8 RID: 12488 RVA: 0x000CF228 File Offset: 0x000CD428
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358599, RefRangeEnd = 358600, XrefRangeStart = 358539, XrefRangeEnd = 358599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FindMatches(StyleMatchingContext context, List<SelectorMatchRecord> matchedSelectors, int parentSheetIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(matchedSelectors);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parentSheetIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSelectorHelper.NativeMethodInfoPtr_FindMatches_Public_Static_Void_StyleMatchingContext_List_1_SelectorMatchRecord_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030C9 RID: 12489 RVA: 0x00013EFD File Offset: 0x000120FD
		public StyleSelectorHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060030CA RID: 12490 RVA: 0x000CF280 File Offset: 0x000CD480
		public static void FindMatches(StyleMatchingContext context, List<SelectorMatchRecord> matchedSelectors)
		{
			VisualElement currentElement = context.currentElement;
			int num = context.styleSheetCount - 1;
			bool flag = currentElement.styleSheetList != null;
			if (flag)
			{
				int num2 = currentElement.styleSheetList.Count;
				for (int i = 0; i < currentElement.styleSheetList.Count; i++)
				{
					StyleSheet styleSheet = currentElement.styleSheetList[i];
					bool flag2 = styleSheet.flattenedRecursiveImports != null;
					if (flag2)
					{
						num2 += styleSheet.flattenedRecursiveImports.Count;
					}
				}
				num -= num2;
			}
			StyleSelectorHelper.FindMatches(context, matchedSelectors, num);
		}

		// Token: 0x0400239B RID: 9115
		private static readonly IntPtr NativeMethodInfoPtr_MatchesSelector_Public_Static_MatchResultInfo_VisualElement_StyleSelector_0;

		// Token: 0x0400239C RID: 9116
		private static readonly IntPtr NativeMethodInfoPtr_MatchRightToLeft_Public_Static_Boolean_VisualElement_StyleComplexSelector_Action_2_VisualElement_MatchResultInfo_0;

		// Token: 0x0400239D RID: 9117
		private static readonly IntPtr NativeMethodInfoPtr_FastLookup_Private_Static_Void_IDictionary_2_String_StyleComplexSelector_List_1_SelectorMatchRecord_StyleMatchingContext_String_byref_SelectorMatchRecord_0;

		// Token: 0x0400239E RID: 9118
		private static readonly IntPtr NativeMethodInfoPtr_FindMatches_Public_Static_Void_StyleMatchingContext_List_1_SelectorMatchRecord_Int32_0;
	}
}
