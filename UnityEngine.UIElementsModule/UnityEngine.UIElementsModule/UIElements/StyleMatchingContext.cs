using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	// Token: 0x0200023A RID: 570
	public class StyleMatchingContext : Object
	{
		// Token: 0x06002A19 RID: 10777 RVA: 0x000B7754 File Offset: 0x000B5954
		// Note: this type is marked as 'beforefieldinit'.
		static StyleMatchingContext()
		{
			Il2CppClassPointerStore<StyleMatchingContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleMatchingContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleMatchingContext>.NativeClassPtr);
			StyleMatchingContext.NativeFieldInfoPtr_m_StyleSheetStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleMatchingContext>.NativeClassPtr, "m_StyleSheetStack");
			StyleMatchingContext.NativeFieldInfoPtr_variableContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleMatchingContext>.NativeClassPtr, "variableContext");
			StyleMatchingContext.NativeFieldInfoPtr_currentElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleMatchingContext>.NativeClassPtr, "currentElement");
			StyleMatchingContext.NativeFieldInfoPtr_processResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleMatchingContext>.NativeClassPtr, "processResult");
			StyleMatchingContext.NativeFieldInfoPtr_ancestorFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleMatchingContext>.NativeClassPtr, "ancestorFilter");
			StyleMatchingContext.NativeMethodInfoPtr_get_styleSheetCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleMatchingContext>.NativeClassPtr, 100669595);
			StyleMatchingContext.NativeMethodInfoPtr__ctor_Public_Void_Action_2_VisualElement_MatchResultInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleMatchingContext>.NativeClassPtr, 100669596);
			StyleMatchingContext.NativeMethodInfoPtr_AddStyleSheet_Public_Void_StyleSheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleMatchingContext>.NativeClassPtr, 100669597);
			StyleMatchingContext.NativeMethodInfoPtr_RemoveStyleSheetRange_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleMatchingContext>.NativeClassPtr, 100669598);
			StyleMatchingContext.NativeMethodInfoPtr_GetStyleSheetAt_Public_StyleSheet_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleMatchingContext>.NativeClassPtr, 100669599);
		}

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x06002A1A RID: 10778 RVA: 0x000B784C File Offset: 0x000B5A4C
		public unsafe int styleSheetCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 347127, RefRangeEnd = 347128, XrefRangeStart = 347126, XrefRangeEnd = 347127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleMatchingContext.NativeMethodInfoPtr_get_styleSheetCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A1B RID: 10779 RVA: 0x000B7888 File Offset: 0x000B5A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347128, XrefRangeEnd = 347148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleMatchingContext(Action<VisualElement, UnityEngine.UIElements.StyleSheets.MatchResultInfo> processResult)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleMatchingContext>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(processResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleMatchingContext.NativeMethodInfoPtr__ctor_Public_Void_Action_2_VisualElement_MatchResultInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A1C RID: 10780 RVA: 0x000B78D4 File Offset: 0x000B5AD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 347155, RefRangeEnd = 347157, XrefRangeStart = 347148, XrefRangeEnd = 347155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddStyleSheet(StyleSheet sheet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sheet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleMatchingContext.NativeMethodInfoPtr_AddStyleSheet_Public_Void_StyleSheet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A1D RID: 10781 RVA: 0x000B7918 File Offset: 0x000B5B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347157, XrefRangeEnd = 347161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveStyleSheetRange(int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleMatchingContext.NativeMethodInfoPtr_RemoveStyleSheetRange_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A1E RID: 10782 RVA: 0x000B7964 File Offset: 0x000B5B64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 347165, RefRangeEnd = 347166, XrefRangeStart = 347161, XrefRangeEnd = 347165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleSheet GetStyleSheetAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleMatchingContext.NativeMethodInfoPtr_GetStyleSheetAt_Public_StyleSheet_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StyleSheet>(intPtr3) : null;
			}
		}

		// Token: 0x06002A1F RID: 10783 RVA: 0x00010F37 File Offset: 0x0000F137
		public StyleMatchingContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x06002A20 RID: 10784 RVA: 0x000B79B0 File Offset: 0x000B5BB0
		// (set) Token: 0x06002A21 RID: 10785 RVA: 0x00010F40 File Offset: 0x0000F140
		public unsafe List<StyleSheet> m_StyleSheetStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleMatchingContext.NativeFieldInfoPtr_m_StyleSheetStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StyleSheet>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleMatchingContext.NativeFieldInfoPtr_m_StyleSheetStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x06002A22 RID: 10786 RVA: 0x000B79E0 File Offset: 0x000B5BE0
		// (set) Token: 0x06002A23 RID: 10787 RVA: 0x00010F5F File Offset: 0x0000F15F
		public unsafe StyleVariableContext variableContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleMatchingContext.NativeFieldInfoPtr_variableContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleVariableContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleMatchingContext.NativeFieldInfoPtr_variableContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x06002A24 RID: 10788 RVA: 0x000B7A10 File Offset: 0x000B5C10
		// (set) Token: 0x06002A25 RID: 10789 RVA: 0x00010F7E File Offset: 0x0000F17E
		public unsafe VisualElement currentElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleMatchingContext.NativeFieldInfoPtr_currentElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleMatchingContext.NativeFieldInfoPtr_currentElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x06002A26 RID: 10790 RVA: 0x000B7A40 File Offset: 0x000B5C40
		// (set) Token: 0x06002A27 RID: 10791 RVA: 0x00010F9D File Offset: 0x0000F19D
		public unsafe Action<VisualElement, UnityEngine.UIElements.StyleSheets.MatchResultInfo> processResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleMatchingContext.NativeFieldInfoPtr_processResult);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<VisualElement, UnityEngine.UIElements.StyleSheets.MatchResultInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleMatchingContext.NativeFieldInfoPtr_processResult), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x06002A28 RID: 10792 RVA: 0x000B7A70 File Offset: 0x000B5C70
		// (set) Token: 0x06002A29 RID: 10793 RVA: 0x00010FBC File Offset: 0x0000F1BC
		public unsafe AncestorFilter ancestorFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleMatchingContext.NativeFieldInfoPtr_ancestorFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AncestorFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleMatchingContext.NativeFieldInfoPtr_ancestorFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001DEF RID: 7663
		private static readonly IntPtr NativeFieldInfoPtr_m_StyleSheetStack;

		// Token: 0x04001DF0 RID: 7664
		private static readonly IntPtr NativeFieldInfoPtr_variableContext;

		// Token: 0x04001DF1 RID: 7665
		private static readonly IntPtr NativeFieldInfoPtr_currentElement;

		// Token: 0x04001DF2 RID: 7666
		private static readonly IntPtr NativeFieldInfoPtr_processResult;

		// Token: 0x04001DF3 RID: 7667
		private static readonly IntPtr NativeFieldInfoPtr_ancestorFilter;

		// Token: 0x04001DF4 RID: 7668
		private static readonly IntPtr NativeMethodInfoPtr_get_styleSheetCount_Public_get_Int32_0;

		// Token: 0x04001DF5 RID: 7669
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_2_VisualElement_MatchResultInfo_0;

		// Token: 0x04001DF6 RID: 7670
		private static readonly IntPtr NativeMethodInfoPtr_AddStyleSheet_Public_Void_StyleSheet_0;

		// Token: 0x04001DF7 RID: 7671
		private static readonly IntPtr NativeMethodInfoPtr_RemoveStyleSheetRange_Public_Void_Int32_Int32_0;

		// Token: 0x04001DF8 RID: 7672
		private static readonly IntPtr NativeMethodInfoPtr_GetStyleSheetAt_Public_StyleSheet_Int32_0;
	}
}
