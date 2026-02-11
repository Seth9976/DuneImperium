using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.TextCore.Text;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements
{
	// Token: 0x020001DA RID: 474
	public static class TextUtilities : Object
	{
		// Token: 0x060024F0 RID: 9456 RVA: 0x000A5224 File Offset: 0x000A3424
		// Note: this type is marked as 'beforefieldinit'.
		static TextUtilities()
		{
			Il2CppClassPointerStore<TextUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TextUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextUtilities>.NativeClassPtr);
			TextUtilities.NativeMethodInfoPtr_MeasureVisualElementTextSize_Internal_Static_Vector2_TextElement_String_Single_MeasureMode_Single_MeasureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextUtilities>.NativeClassPtr, 100668881);
			TextUtilities.NativeMethodInfoPtr_GetFontAsset_Internal_Static_FontAsset_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextUtilities>.NativeClassPtr, 100668882);
			TextUtilities.NativeMethodInfoPtr_IsFontAssigned_Internal_Static_Boolean_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextUtilities>.NativeClassPtr, 100668883);
			TextUtilities.NativeMethodInfoPtr_GetTextSettingsFrom_Internal_Static_PanelTextSettings_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextUtilities>.NativeClassPtr, 100668884);
			TextUtilities.NativeMethodInfoPtr_ConvertPixelUnitsToTextCoreRelativeUnits_Internal_Static_Single_VisualElement_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextUtilities>.NativeClassPtr, 100668885);
			TextUtilities.NativeMethodInfoPtr_GetTextCoreSettingsForElement_Internal_Static_TextCoreSettings_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextUtilities>.NativeClassPtr, 100668886);
		}

		// Token: 0x060024F1 RID: 9457 RVA: 0x000A52CC File Offset: 0x000A34CC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 339312, RefRangeEnd = 339317, XrefRangeStart = 339291, XrefRangeEnd = 339312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 MeasureVisualElementTextSize(TextElement te, string textToMeasure, float width, VisualElement.MeasureMode widthMode, float height, VisualElement.MeasureMode heightMode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(te);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(textToMeasure);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref widthMode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref heightMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextUtilities.NativeMethodInfoPtr_MeasureVisualElementTextSize_Internal_Static_Vector2_TextElement_String_Single_MeasureMode_Single_MeasureMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024F2 RID: 9458 RVA: 0x000A5358 File Offset: 0x000A3558
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 339354, RefRangeEnd = 339356, XrefRangeStart = 339317, XrefRangeEnd = 339354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FontAsset GetFontAsset(VisualElement ve)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextUtilities.NativeMethodInfoPtr_GetFontAsset_Internal_Static_FontAsset_VisualElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FontAsset>(intPtr3) : null;
			}
		}

		// Token: 0x060024F3 RID: 9459 RVA: 0x000A539C File Offset: 0x000A359C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 339362, RefRangeEnd = 339365, XrefRangeStart = 339356, XrefRangeEnd = 339362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsFontAssigned(VisualElement ve)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextUtilities.NativeMethodInfoPtr_IsFontAssigned_Internal_Static_Boolean_VisualElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060024F4 RID: 9460 RVA: 0x000A53E0 File Offset: 0x000A35E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 339373, RefRangeEnd = 339374, XrefRangeStart = 339365, XrefRangeEnd = 339373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PanelTextSettings GetTextSettingsFrom(VisualElement ve)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextUtilities.NativeMethodInfoPtr_GetTextSettingsFrom_Internal_Static_PanelTextSettings_VisualElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PanelTextSettings>(intPtr3) : null;
			}
		}

		// Token: 0x060024F5 RID: 9461 RVA: 0x000A5424 File Offset: 0x000A3624
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 339379, RefRangeEnd = 339380, XrefRangeStart = 339374, XrefRangeEnd = 339379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ConvertPixelUnitsToTextCoreRelativeUnits(VisualElement ve, FontAsset fontAsset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextUtilities.NativeMethodInfoPtr_ConvertPixelUnitsToTextCoreRelativeUnits_Internal_Static_Single_VisualElement_FontAsset_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024F6 RID: 9462 RVA: 0x000A5478 File Offset: 0x000A3678
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 339414, RefRangeEnd = 339417, XrefRangeStart = 339380, XrefRangeEnd = 339414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.UIElements.UIR.TextCoreSettings GetTextCoreSettingsForElement(VisualElement ve)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextUtilities.NativeMethodInfoPtr_GetTextCoreSettingsForElement_Internal_Static_TextCoreSettings_VisualElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060024F7 RID: 9463 RVA: 0x0000F320 File Offset: 0x0000D520
		public TextUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060024F8 RID: 9464 RVA: 0x000A54BC File Offset: 0x000A36BC
		public unsafe static Font GetFont(VisualElement ve)
		{
			ComputedStyle computedStyle = *ve.computedStyle;
			FontDefinition fontDefinition = computedStyle.unityFontDefinition;
			bool flag = fontDefinition.font != null;
			Font font;
			if (flag)
			{
				fontDefinition = computedStyle.unityFontDefinition;
				font = fontDefinition.font;
			}
			else
			{
				bool flag2 = computedStyle.unityFont != null;
				if (flag2)
				{
					font = computedStyle.unityFont;
				}
				else
				{
					fontDefinition = computedStyle.unityFontDefinition;
					FontAsset fontAsset = fontDefinition.fontAsset;
					font = ((fontAsset != null) ? fontAsset.sourceFontFile : null);
				}
			}
			return font;
		}

		// Token: 0x04001A8D RID: 6797
		private static readonly IntPtr NativeMethodInfoPtr_MeasureVisualElementTextSize_Internal_Static_Vector2_TextElement_String_Single_MeasureMode_Single_MeasureMode_0;

		// Token: 0x04001A8E RID: 6798
		private static readonly IntPtr NativeMethodInfoPtr_GetFontAsset_Internal_Static_FontAsset_VisualElement_0;

		// Token: 0x04001A8F RID: 6799
		private static readonly IntPtr NativeMethodInfoPtr_IsFontAssigned_Internal_Static_Boolean_VisualElement_0;

		// Token: 0x04001A90 RID: 6800
		private static readonly IntPtr NativeMethodInfoPtr_GetTextSettingsFrom_Internal_Static_PanelTextSettings_VisualElement_0;

		// Token: 0x04001A91 RID: 6801
		private static readonly IntPtr NativeMethodInfoPtr_ConvertPixelUnitsToTextCoreRelativeUnits_Internal_Static_Single_VisualElement_FontAsset_0;

		// Token: 0x04001A92 RID: 6802
		private static readonly IntPtr NativeMethodInfoPtr_GetTextCoreSettingsForElement_Internal_Static_TextCoreSettings_VisualElement_0;
	}
}
