using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	// Token: 0x02000190 RID: 400
	public class StyleValueCollection : Object
	{
		// Token: 0x0600213C RID: 8508 RVA: 0x000960D8 File Offset: 0x000942D8
		// Note: this type is marked as 'beforefieldinit'.
		static StyleValueCollection()
		{
			Il2CppClassPointerStore<StyleValueCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleValueCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleValueCollection>.NativeClassPtr);
			StyleValueCollection.NativeFieldInfoPtr_m_Values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleValueCollection>.NativeClassPtr, "m_Values");
			StyleValueCollection.NativeMethodInfoPtr_GetStyleLength_Public_StyleLength_StylePropertyId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValueCollection>.NativeClassPtr, 100668192);
			StyleValueCollection.NativeMethodInfoPtr_GetStyleFloat_Public_StyleFloat_StylePropertyId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValueCollection>.NativeClassPtr, 100668193);
			StyleValueCollection.NativeMethodInfoPtr_GetStyleInt_Public_StyleInt_StylePropertyId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValueCollection>.NativeClassPtr, 100668194);
			StyleValueCollection.NativeMethodInfoPtr_TryGetStyleValue_Public_Boolean_StylePropertyId_byref_StyleValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValueCollection>.NativeClassPtr, 100668195);
			StyleValueCollection.NativeMethodInfoPtr_SetStyleValue_Public_Void_StyleValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValueCollection>.NativeClassPtr, 100668196);
			StyleValueCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValueCollection>.NativeClassPtr, 100668197);
		}

		// Token: 0x0600213D RID: 8509 RVA: 0x00096194 File Offset: 0x00094394
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 334204, RefRangeEnd = 334206, XrefRangeStart = 334203, XrefRangeEnd = 334204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleLength GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValueCollection.NativeMethodInfoPtr_GetStyleLength_Public_StyleLength_StylePropertyId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600213E RID: 8510 RVA: 0x000961E0 File Offset: 0x000943E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 334208, RefRangeEnd = 334209, XrefRangeStart = 334206, XrefRangeEnd = 334208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleFloat GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValueCollection.NativeMethodInfoPtr_GetStyleFloat_Public_StyleFloat_StylePropertyId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600213F RID: 8511 RVA: 0x0009622C File Offset: 0x0009442C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 334210, RefRangeEnd = 334211, XrefRangeStart = 334209, XrefRangeEnd = 334210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleInt GetStyleInt(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValueCollection.NativeMethodInfoPtr_GetStyleInt_Public_StyleInt_StylePropertyId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002140 RID: 8512 RVA: 0x00096278 File Offset: 0x00094478
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 334227, RefRangeEnd = 334239, XrefRangeStart = 334211, XrefRangeEnd = 334227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, ref UnityEngine.UIElements.StyleSheets.StyleValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValueCollection.NativeMethodInfoPtr_TryGetStyleValue_Public_Boolean_StylePropertyId_byref_StyleValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002141 RID: 8513 RVA: 0x000962D0 File Offset: 0x000944D0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 334249, RefRangeEnd = 334261, XrefRangeStart = 334239, XrefRangeEnd = 334249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStyleValue(UnityEngine.UIElements.StyleSheets.StyleValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValueCollection.NativeMethodInfoPtr_SetStyleValue_Public_Void_StyleValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002142 RID: 8514 RVA: 0x00096310 File Offset: 0x00094510
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 334269, RefRangeEnd = 334279, XrefRangeStart = 334261, XrefRangeEnd = 334269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleValueCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleValueCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValueCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002143 RID: 8515 RVA: 0x0000E023 File Offset: 0x0000C223
		public StyleValueCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06002144 RID: 8516 RVA: 0x0009634C File Offset: 0x0009454C
		// (set) Token: 0x06002145 RID: 8517 RVA: 0x0000E02C File Offset: 0x0000C22C
		public unsafe List<UnityEngine.UIElements.StyleSheets.StyleValue> m_Values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleValueCollection.NativeFieldInfoPtr_m_Values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UnityEngine.UIElements.StyleSheets.StyleValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleValueCollection.NativeFieldInfoPtr_m_Values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06002146 RID: 8518 RVA: 0x0009637C File Offset: 0x0009457C
		public StyleColor GetStyleColor(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			UnityEngine.UIElements.StyleSheets.StyleValue styleValue = default(UnityEngine.UIElements.StyleSheets.StyleValue);
			bool flag = this.TryGetStyleValue(id, ref styleValue);
			StyleColor styleColor;
			if (flag)
			{
				styleColor = new StyleColor(styleValue.color, styleValue.keyword);
			}
			else
			{
				styleColor = StyleKeyword.Null;
			}
			return styleColor;
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x000963C0 File Offset: 0x000945C0
		public StyleBackground GetStyleBackground(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			UnityEngine.UIElements.StyleSheets.StyleValue styleValue = default(UnityEngine.UIElements.StyleSheets.StyleValue);
			bool flag = this.TryGetStyleValue(id, ref styleValue);
			if (flag)
			{
				Texture2D texture2D = (styleValue.resource.IsAllocated ? styleValue.resource.Target.TryCast<Texture2D>() : null);
				bool flag2 = texture2D != null;
				if (flag2)
				{
					return new StyleBackground(texture2D, styleValue.keyword);
				}
				Sprite sprite = (styleValue.resource.IsAllocated ? styleValue.resource.Target.TryCast<Sprite>() : null);
				bool flag3 = sprite != null;
				if (flag3)
				{
					return new StyleBackground(sprite, styleValue.keyword);
				}
				VectorImage vectorImage = (styleValue.resource.IsAllocated ? styleValue.resource.Target.TryCast<VectorImage>() : null);
				bool flag4 = vectorImage != null;
				if (flag4)
				{
					return new StyleBackground(vectorImage, styleValue.keyword);
				}
			}
			return StyleKeyword.Null;
		}

		// Token: 0x06002148 RID: 8520 RVA: 0x000964BC File Offset: 0x000946BC
		public StyleBackgroundPosition GetStyleBackgroundPosition(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			UnityEngine.UIElements.StyleSheets.StyleValue styleValue = default(UnityEngine.UIElements.StyleSheets.StyleValue);
			bool flag = this.TryGetStyleValue(id, ref styleValue);
			StyleBackgroundPosition styleBackgroundPosition;
			if (flag)
			{
				styleBackgroundPosition = new StyleBackgroundPosition(styleValue.position);
			}
			else
			{
				styleBackgroundPosition = StyleKeyword.Null;
			}
			return styleBackgroundPosition;
		}

		// Token: 0x06002149 RID: 8521 RVA: 0x000964F8 File Offset: 0x000946F8
		public StyleBackgroundRepeat GetStyleBackgroundRepeat(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			UnityEngine.UIElements.StyleSheets.StyleValue styleValue = default(UnityEngine.UIElements.StyleSheets.StyleValue);
			bool flag = this.TryGetStyleValue(id, ref styleValue);
			StyleBackgroundRepeat styleBackgroundRepeat;
			if (flag)
			{
				styleBackgroundRepeat = new StyleBackgroundRepeat(styleValue.repeat);
			}
			else
			{
				styleBackgroundRepeat = StyleKeyword.Null;
			}
			return styleBackgroundRepeat;
		}

		// Token: 0x0600214A RID: 8522 RVA: 0x00096534 File Offset: 0x00094734
		public StyleFont GetStyleFont(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			UnityEngine.UIElements.StyleSheets.StyleValue styleValue = default(UnityEngine.UIElements.StyleSheets.StyleValue);
			bool flag = this.TryGetStyleValue(id, ref styleValue);
			StyleFont styleFont;
			if (flag)
			{
				Font font = (styleValue.resource.IsAllocated ? styleValue.resource.Target.TryCast<Font>() : null);
				styleFont = new StyleFont(font, styleValue.keyword);
			}
			else
			{
				styleFont = StyleKeyword.Null;
			}
			return styleFont;
		}

		// Token: 0x0600214B RID: 8523 RVA: 0x00096594 File Offset: 0x00094794
		public StyleFontDefinition GetStyleFontDefinition(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			UnityEngine.UIElements.StyleSheets.StyleValue styleValue = default(UnityEngine.UIElements.StyleSheets.StyleValue);
			bool flag = this.TryGetStyleValue(id, ref styleValue);
			StyleFontDefinition styleFontDefinition;
			if (flag)
			{
				Object @object = (styleValue.resource.IsAllocated ? styleValue.resource.Target : null);
				styleFontDefinition = new StyleFontDefinition(@object, styleValue.keyword);
			}
			else
			{
				styleFontDefinition = StyleKeyword.Null;
			}
			return styleFontDefinition;
		}

		// Token: 0x04001746 RID: 5958
		private static readonly IntPtr NativeFieldInfoPtr_m_Values;

		// Token: 0x04001747 RID: 5959
		private static readonly IntPtr NativeMethodInfoPtr_GetStyleLength_Public_StyleLength_StylePropertyId_0;

		// Token: 0x04001748 RID: 5960
		private static readonly IntPtr NativeMethodInfoPtr_GetStyleFloat_Public_StyleFloat_StylePropertyId_0;

		// Token: 0x04001749 RID: 5961
		private static readonly IntPtr NativeMethodInfoPtr_GetStyleInt_Public_StyleInt_StylePropertyId_0;

		// Token: 0x0400174A RID: 5962
		private static readonly IntPtr NativeMethodInfoPtr_TryGetStyleValue_Public_Boolean_StylePropertyId_byref_StyleValue_0;

		// Token: 0x0400174B RID: 5963
		private static readonly IntPtr NativeMethodInfoPtr_SetStyleValue_Public_Void_StyleValue_0;

		// Token: 0x0400174C RID: 5964
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
