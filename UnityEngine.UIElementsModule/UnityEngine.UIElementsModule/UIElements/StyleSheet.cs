using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	// Token: 0x020001CA RID: 458
	[Serializable]
	public class StyleSheet : ScriptableObject
	{
		// Token: 0x060023C7 RID: 9159 RVA: 0x000A0F18 File Offset: 0x0009F118
		// Note: this type is marked as 'beforefieldinit'.
		static StyleSheet()
		{
			Il2CppClassPointerStore<StyleSheet>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleSheet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr);
			StyleSheet.NativeFieldInfoPtr_m_ImportedWithErrors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, "m_ImportedWithErrors");
			StyleSheet.NativeFieldInfoPtr_m_ImportedWithWarnings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, "m_ImportedWithWarnings");
			StyleSheet.NativeFieldInfoPtr_m_Rules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, "m_Rules");
			StyleSheet.NativeFieldInfoPtr_m_ComplexSelectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, "m_ComplexSelectors");
			StyleSheet.NativeFieldInfoPtr_floats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, "floats");
			StyleSheet.NativeFieldInfoPtr_dimensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, "dimensions");
			StyleSheet.NativeFieldInfoPtr_colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, "colors");
			StyleSheet.NativeFieldInfoPtr_strings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, "strings");
			StyleSheet.NativeFieldInfoPtr_assets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, "assets");
			StyleSheet.NativeFieldInfoPtr_imports = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, "imports");
			StyleSheet.NativeFieldInfoPtr_m_FlattenedImportedStyleSheets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, "m_FlattenedImportedStyleSheets");
			StyleSheet.NativeFieldInfoPtr_m_ContentHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, "m_ContentHash");
			StyleSheet.NativeFieldInfoPtr_scalableImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, "scalableImages");
			StyleSheet.NativeFieldInfoPtr_orderedNameSelectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, "orderedNameSelectors");
			StyleSheet.NativeFieldInfoPtr_orderedTypeSelectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, "orderedTypeSelectors");
			StyleSheet.NativeFieldInfoPtr_orderedClassSelectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, "orderedClassSelectors");
			StyleSheet.NativeFieldInfoPtr_m_IsDefaultStyleSheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, "m_IsDefaultStyleSheet");
			StyleSheet.NativeFieldInfoPtr_kCustomPropertyMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, "kCustomPropertyMarker");
			StyleSheet.NativeMethodInfoPtr_get_importedWithErrors_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668734);
			StyleSheet.NativeMethodInfoPtr_set_importedWithErrors_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668735);
			StyleSheet.NativeMethodInfoPtr_get_importedWithWarnings_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668736);
			StyleSheet.NativeMethodInfoPtr_set_importedWithWarnings_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668737);
			StyleSheet.NativeMethodInfoPtr_get_rules_Internal_get_Il2CppReferenceArray_1_StyleRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668738);
			StyleSheet.NativeMethodInfoPtr_set_rules_Internal_set_Void_Il2CppReferenceArray_1_StyleRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668739);
			StyleSheet.NativeMethodInfoPtr_get_complexSelectors_Internal_get_Il2CppReferenceArray_1_StyleComplexSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668740);
			StyleSheet.NativeMethodInfoPtr_set_complexSelectors_Internal_set_Void_Il2CppReferenceArray_1_StyleComplexSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668741);
			StyleSheet.NativeMethodInfoPtr_get_flattenedRecursiveImports_Internal_get_List_1_StyleSheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668742);
			StyleSheet.NativeMethodInfoPtr_get_contentHash_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668743);
			StyleSheet.NativeMethodInfoPtr_set_contentHash_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668744);
			StyleSheet.NativeMethodInfoPtr_get_isDefaultStyleSheet_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668745);
			StyleSheet.NativeMethodInfoPtr_set_isDefaultStyleSheet_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668746);
			StyleSheet.NativeMethodInfoPtr_TryCheckAccess_Private_Boolean_Il2CppArrayBase_1_T_StyleValueType_StyleValueHandle_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668747);
			StyleSheet.NativeMethodInfoPtr_CheckAccess_Private_T_Il2CppArrayBase_1_T_StyleValueType_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668748);
			StyleSheet.NativeMethodInfoPtr_OnEnable_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668749);
			StyleSheet.NativeMethodInfoPtr_FlattenImportedStyleSheetsRecursive_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668750);
			StyleSheet.NativeMethodInfoPtr_FlattenImportedStyleSheetsRecursive_Private_Void_StyleSheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668751);
			StyleSheet.NativeMethodInfoPtr_SetupReferences_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668752);
			StyleSheet.NativeMethodInfoPtr_ReadKeyword_Internal_StyleValueKeyword_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668753);
			StyleSheet.NativeMethodInfoPtr_ReadFloat_Internal_Single_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668754);
			StyleSheet.NativeMethodInfoPtr_TryReadFloat_Internal_Boolean_StyleValueHandle_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668755);
			StyleSheet.NativeMethodInfoPtr_ReadDimension_Internal_Dimension_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668756);
			StyleSheet.NativeMethodInfoPtr_TryReadDimension_Internal_Boolean_StyleValueHandle_byref_Dimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668757);
			StyleSheet.NativeMethodInfoPtr_ReadColor_Internal_Color_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668758);
			StyleSheet.NativeMethodInfoPtr_TryReadColor_Internal_Boolean_StyleValueHandle_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668759);
			StyleSheet.NativeMethodInfoPtr_ReadString_Internal_String_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668760);
			StyleSheet.NativeMethodInfoPtr_TryReadString_Internal_Boolean_StyleValueHandle_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668761);
			StyleSheet.NativeMethodInfoPtr_ReadEnum_Internal_String_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668762);
			StyleSheet.NativeMethodInfoPtr_TryReadEnum_Internal_Boolean_StyleValueHandle_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668763);
			StyleSheet.NativeMethodInfoPtr_ReadVariable_Internal_String_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668764);
			StyleSheet.NativeMethodInfoPtr_TryReadVariable_Internal_Boolean_StyleValueHandle_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668765);
			StyleSheet.NativeMethodInfoPtr_ReadResourcePath_Internal_String_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668766);
			StyleSheet.NativeMethodInfoPtr_TryReadResourcePath_Internal_Boolean_StyleValueHandle_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668767);
			StyleSheet.NativeMethodInfoPtr_ReadAssetReference_Internal_Object_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668768);
			StyleSheet.NativeMethodInfoPtr_ReadMissingAssetReferenceUrl_Internal_String_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668769);
			StyleSheet.NativeMethodInfoPtr_TryReadAssetReference_Internal_Boolean_StyleValueHandle_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668770);
			StyleSheet.NativeMethodInfoPtr_ReadFunction_Internal_StyleValueFunction_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668771);
			StyleSheet.NativeMethodInfoPtr_ReadFunctionName_Internal_String_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668772);
			StyleSheet.NativeMethodInfoPtr_ReadScalableImage_Internal_ScalableImage_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668773);
			StyleSheet.NativeMethodInfoPtr_CustomStartsWith_Private_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668774);
			StyleSheet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100668775);
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x060023C8 RID: 9160 RVA: 0x000A13F8 File Offset: 0x0009F5F8
		// (set) Token: 0x060023C9 RID: 9161 RVA: 0x000A1434 File Offset: 0x0009F634
		public unsafe bool importedWithErrors
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_get_importedWithErrors_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_set_importedWithErrors_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x060023CA RID: 9162 RVA: 0x000A1474 File Offset: 0x0009F674
		// (set) Token: 0x060023CB RID: 9163 RVA: 0x000A14B0 File Offset: 0x0009F6B0
		public unsafe bool importedWithWarnings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_get_importedWithWarnings_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_set_importedWithWarnings_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x060023CC RID: 9164 RVA: 0x000A14F0 File Offset: 0x0009F6F0
		// (set) Token: 0x060023CD RID: 9165 RVA: 0x000A1530 File Offset: 0x0009F730
		public unsafe Il2CppReferenceArray<StyleRule> rules
		{
			[CallerCount(35)]
			[CachedScanResults(RefRangeStart = 337628, RefRangeEnd = 337663, XrefRangeStart = 337628, XrefRangeEnd = 337663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_get_rules_Internal_get_Il2CppReferenceArray_1_StyleRule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StyleRule>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337724, XrefRangeEnd = 337726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_set_rules_Internal_set_Void_Il2CppReferenceArray_1_StyleRule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x060023CE RID: 9166 RVA: 0x000A1574 File Offset: 0x0009F774
		// (set) Token: 0x060023CF RID: 9167 RVA: 0x000A15B4 File Offset: 0x0009F7B4
		public unsafe Il2CppReferenceArray<StyleComplexSelector> complexSelectors
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 318860, RefRangeEnd = 318862, XrefRangeStart = 318860, XrefRangeEnd = 318862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_get_complexSelectors_Internal_get_Il2CppReferenceArray_1_StyleComplexSelector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StyleComplexSelector>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337726, XrefRangeEnd = 337728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_set_complexSelectors_Internal_set_Void_Il2CppReferenceArray_1_StyleComplexSelector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x060023D0 RID: 9168 RVA: 0x000A15F8 File Offset: 0x0009F7F8
		public unsafe List<StyleSheet> flattenedRecursiveImports
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 337728, RefRangeEnd = 337731, XrefRangeStart = 337728, XrefRangeEnd = 337728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_get_flattenedRecursiveImports_Internal_get_List_1_StyleSheet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<StyleSheet>>(intPtr3) : null;
			}
		}

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x060023D1 RID: 9169 RVA: 0x000A1638 File Offset: 0x0009F838
		// (set) Token: 0x060023D2 RID: 9170 RVA: 0x000A1674 File Offset: 0x0009F874
		public unsafe int contentHash
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 337731, RefRangeEnd = 337738, XrefRangeStart = 337731, XrefRangeEnd = 337731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_get_contentHash_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 337738, RefRangeEnd = 337747, XrefRangeStart = 337738, XrefRangeEnd = 337738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_set_contentHash_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x060023D3 RID: 9171 RVA: 0x000A16B4 File Offset: 0x0009F8B4
		// (set) Token: 0x060023D4 RID: 9172 RVA: 0x000A16F0 File Offset: 0x0009F8F0
		public unsafe bool isDefaultStyleSheet
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 337747, RefRangeEnd = 337749, XrefRangeStart = 337747, XrefRangeEnd = 337747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_get_isDefaultStyleSheet_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 337764, RefRangeEnd = 337768, XrefRangeStart = 337749, XrefRangeEnd = 337764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_set_isDefaultStyleSheet_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x000A1730 File Offset: 0x0009F930
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337789, RefRangeEnd = 337790, XrefRangeStart = 337768, XrefRangeEnd = 337789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryCheckAccess<T>(Il2CppArrayBase<T> list, StyleValueType type, StyleValueHandle handle, out T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handle;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(StyleSheet.MethodInfoStoreGeneric_TryCheckAccess_Private_Boolean_Il2CppArrayBase_1_T_StyleValueType_StyleValueHandle_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060023D6 RID: 9174 RVA: 0x000A17EC File Offset: 0x0009F9EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337817, RefRangeEnd = 337818, XrefRangeStart = 337790, XrefRangeEnd = 337817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T CheckAccess<T>(Il2CppArrayBase<T> list, StyleValueType type, StyleValueHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.MethodInfoStoreGeneric_CheckAccess_Private_T_Il2CppArrayBase_1_T_StyleValueType_StyleValueHandle_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060023D7 RID: 9175 RVA: 0x000A1854 File Offset: 0x0009FA54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337818, XrefRangeEnd = 337819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StyleSheet.NativeMethodInfoPtr_OnEnable_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023D8 RID: 9176 RVA: 0x000A1890 File Offset: 0x0009FA90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337819, XrefRangeEnd = 337827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FlattenImportedStyleSheetsRecursive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_FlattenImportedStyleSheetsRecursive_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023D9 RID: 9177 RVA: 0x000A18C4 File Offset: 0x0009FAC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 337837, RefRangeEnd = 337839, XrefRangeStart = 337827, XrefRangeEnd = 337837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FlattenImportedStyleSheetsRecursive(StyleSheet sheet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sheet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_FlattenImportedStyleSheetsRecursive_Private_Void_StyleSheet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060023DA RID: 9178 RVA: 0x000A1908 File Offset: 0x0009FB08
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 337908, RefRangeEnd = 337912, XrefRangeStart = 337839, XrefRangeEnd = 337908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupReferences()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_SetupReferences_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023DB RID: 9179 RVA: 0x000A193C File Offset: 0x0009FB3C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 293297, RefRangeEnd = 293302, XrefRangeStart = 293297, XrefRangeEnd = 293302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleValueKeyword ReadKeyword(StyleValueHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_ReadKeyword_Internal_StyleValueKeyword_StyleValueHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060023DC RID: 9180 RVA: 0x000A1988 File Offset: 0x0009FB88
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 337916, RefRangeEnd = 337924, XrefRangeStart = 337912, XrefRangeEnd = 337916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ReadFloat(StyleValueHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_ReadFloat_Internal_Single_StyleValueHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060023DD RID: 9181 RVA: 0x000A19D4 File Offset: 0x0009FBD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337924, XrefRangeEnd = 337930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryReadFloat(StyleValueHandle handle, out float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_TryReadFloat_Internal_Boolean_StyleValueHandle_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023DE RID: 9182 RVA: 0x000A1A2C File Offset: 0x0009FC2C
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 337934, RefRangeEnd = 337957, XrefRangeStart = 337930, XrefRangeEnd = 337934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEngine.UIElements.StyleSheets.Dimension ReadDimension(StyleValueHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_ReadDimension_Internal_Dimension_StyleValueHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060023DF RID: 9183 RVA: 0x000A1A78 File Offset: 0x0009FC78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337964, RefRangeEnd = 337965, XrefRangeStart = 337957, XrefRangeEnd = 337964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryReadDimension(StyleValueHandle handle, out UnityEngine.UIElements.StyleSheets.Dimension value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_TryReadDimension_Internal_Boolean_StyleValueHandle_byref_Dimension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023E0 RID: 9184 RVA: 0x000A1AD0 File Offset: 0x0009FCD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337968, RefRangeEnd = 337969, XrefRangeStart = 337965, XrefRangeEnd = 337968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color ReadColor(StyleValueHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_ReadColor_Internal_Color_StyleValueHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060023E1 RID: 9185 RVA: 0x000A1B1C File Offset: 0x0009FD1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337972, RefRangeEnd = 337973, XrefRangeStart = 337969, XrefRangeEnd = 337972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryReadColor(StyleValueHandle handle, out Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_TryReadColor_Internal_Boolean_StyleValueHandle_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023E2 RID: 9186 RVA: 0x000A1B74 File Offset: 0x0009FD74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337973, XrefRangeEnd = 337976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadString(StyleValueHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_ReadString_Internal_String_StyleValueHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060023E3 RID: 9187 RVA: 0x000A1BB8 File Offset: 0x0009FDB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337976, XrefRangeEnd = 337979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryReadString(StyleValueHandle handle, out string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_TryReadString_Internal_Boolean_StyleValueHandle_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			value = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060023E4 RID: 9188 RVA: 0x000A1C1C File Offset: 0x0009FE1C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 337982, RefRangeEnd = 337987, XrefRangeStart = 337979, XrefRangeEnd = 337982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadEnum(StyleValueHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_ReadEnum_Internal_String_StyleValueHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060023E5 RID: 9189 RVA: 0x000A1C60 File Offset: 0x0009FE60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337987, XrefRangeEnd = 337990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryReadEnum(StyleValueHandle handle, out string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_TryReadEnum_Internal_Boolean_StyleValueHandle_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			value = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060023E6 RID: 9190 RVA: 0x000A1CC4 File Offset: 0x0009FEC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337990, XrefRangeEnd = 337993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadVariable(StyleValueHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_ReadVariable_Internal_String_StyleValueHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060023E7 RID: 9191 RVA: 0x000A1D08 File Offset: 0x0009FF08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337993, XrefRangeEnd = 337996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryReadVariable(StyleValueHandle handle, out string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_TryReadVariable_Internal_Boolean_StyleValueHandle_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			value = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060023E8 RID: 9192 RVA: 0x000A1D6C File Offset: 0x0009FF6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 337999, RefRangeEnd = 338001, XrefRangeStart = 337996, XrefRangeEnd = 337999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadResourcePath(StyleValueHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_ReadResourcePath_Internal_String_StyleValueHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060023E9 RID: 9193 RVA: 0x000A1DB0 File Offset: 0x0009FFB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338001, XrefRangeEnd = 338004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryReadResourcePath(StyleValueHandle handle, out string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_TryReadResourcePath_Internal_Boolean_StyleValueHandle_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			value = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060023EA RID: 9194 RVA: 0x000A1E14 File Offset: 0x000A0014
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 338007, RefRangeEnd = 338010, XrefRangeStart = 338004, XrefRangeEnd = 338007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ReadAssetReference(StyleValueHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_ReadAssetReference_Internal_Object_StyleValueHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060023EB RID: 9195 RVA: 0x000A1E60 File Offset: 0x000A0060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338010, XrefRangeEnd = 338013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadMissingAssetReferenceUrl(StyleValueHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_ReadMissingAssetReferenceUrl_Internal_String_StyleValueHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060023EC RID: 9196 RVA: 0x000A1EA4 File Offset: 0x000A00A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338013, XrefRangeEnd = 338016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryReadAssetReference(StyleValueHandle handle, out Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_TryReadAssetReference_Internal_Boolean_StyleValueHandle_byref_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060023ED RID: 9197 RVA: 0x000A1F10 File Offset: 0x000A0110
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 293297, RefRangeEnd = 293302, XrefRangeStart = 293297, XrefRangeEnd = 293302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleValueFunction ReadFunction(StyleValueHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_ReadFunction_Internal_StyleValueFunction_StyleValueHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060023EE RID: 9198 RVA: 0x000A1F5C File Offset: 0x000A015C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338016, XrefRangeEnd = 338025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadFunctionName(StyleValueHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_ReadFunctionName_Internal_String_StyleValueHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060023EF RID: 9199 RVA: 0x000A1FA0 File Offset: 0x000A01A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338028, RefRangeEnd = 338029, XrefRangeStart = 338025, XrefRangeEnd = 338028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEngine.UIElements.StyleSheets.ScalableImage ReadScalableImage(StyleValueHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_ReadScalableImage_Internal_ScalableImage_StyleValueHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new UnityEngine.UIElements.StyleSheets.ScalableImage(intPtr);
			}
		}

		// Token: 0x060023F0 RID: 9200 RVA: 0x000A1FE4 File Offset: 0x000A01E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338033, RefRangeEnd = 338034, XrefRangeStart = 338029, XrefRangeEnd = 338033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CustomStartsWith(string originalString, string pattern)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(originalString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_CustomStartsWith_Private_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023F1 RID: 9201 RVA: 0x000A2038 File Offset: 0x000A0238
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 338035, RefRangeEnd = 338045, XrefRangeStart = 338034, XrefRangeEnd = 338035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleSheet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023F2 RID: 9202 RVA: 0x0000EAF6 File Offset: 0x0000CCF6
		public StyleSheet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x060023F3 RID: 9203 RVA: 0x000A2074 File Offset: 0x000A0274
		// (set) Token: 0x060023F4 RID: 9204 RVA: 0x0000EAFF File Offset: 0x0000CCFF
		public unsafe bool m_ImportedWithErrors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_m_ImportedWithErrors);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_m_ImportedWithErrors)) = value;
			}
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x060023F5 RID: 9205 RVA: 0x000A209C File Offset: 0x000A029C
		// (set) Token: 0x060023F6 RID: 9206 RVA: 0x0000EB1A File Offset: 0x0000CD1A
		public unsafe bool m_ImportedWithWarnings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_m_ImportedWithWarnings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_m_ImportedWithWarnings)) = value;
			}
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x060023F7 RID: 9207 RVA: 0x000A20C4 File Offset: 0x000A02C4
		// (set) Token: 0x060023F8 RID: 9208 RVA: 0x0000EB35 File Offset: 0x0000CD35
		public unsafe Il2CppReferenceArray<StyleRule> m_Rules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_m_Rules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StyleRule>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_m_Rules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x060023F9 RID: 9209 RVA: 0x000A20F4 File Offset: 0x000A02F4
		// (set) Token: 0x060023FA RID: 9210 RVA: 0x0000EB54 File Offset: 0x0000CD54
		public unsafe Il2CppReferenceArray<StyleComplexSelector> m_ComplexSelectors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_m_ComplexSelectors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StyleComplexSelector>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_m_ComplexSelectors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x060023FB RID: 9211 RVA: 0x000A2124 File Offset: 0x000A0324
		// (set) Token: 0x060023FC RID: 9212 RVA: 0x0000EB73 File Offset: 0x0000CD73
		public unsafe Il2CppStructArray<float> floats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_floats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_floats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x060023FD RID: 9213 RVA: 0x000A2154 File Offset: 0x000A0354
		// (set) Token: 0x060023FE RID: 9214 RVA: 0x0000EB92 File Offset: 0x0000CD92
		public unsafe Il2CppStructArray<UnityEngine.UIElements.StyleSheets.Dimension> dimensions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_dimensions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<UnityEngine.UIElements.StyleSheets.Dimension>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_dimensions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x060023FF RID: 9215 RVA: 0x000A2184 File Offset: 0x000A0384
		// (set) Token: 0x06002400 RID: 9216 RVA: 0x0000EBB1 File Offset: 0x0000CDB1
		public unsafe Il2CppStructArray<Color> colors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_colors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_colors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x06002401 RID: 9217 RVA: 0x000A21B4 File Offset: 0x000A03B4
		// (set) Token: 0x06002402 RID: 9218 RVA: 0x0000EBD0 File Offset: 0x0000CDD0
		public unsafe Il2CppStringArray strings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_strings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_strings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x06002403 RID: 9219 RVA: 0x000A21E4 File Offset: 0x000A03E4
		// (set) Token: 0x06002404 RID: 9220 RVA: 0x0000EBEF File Offset: 0x0000CDEF
		public unsafe Il2CppReferenceArray<Object> assets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_assets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_assets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x06002405 RID: 9221 RVA: 0x000A2214 File Offset: 0x000A0414
		// (set) Token: 0x06002406 RID: 9222 RVA: 0x0000EC0E File Offset: 0x0000CE0E
		public unsafe Il2CppReferenceArray<StyleSheet.ImportStruct> imports
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_imports);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StyleSheet.ImportStruct>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_imports), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x06002407 RID: 9223 RVA: 0x000A2244 File Offset: 0x000A0444
		// (set) Token: 0x06002408 RID: 9224 RVA: 0x0000EC2D File Offset: 0x0000CE2D
		public unsafe List<StyleSheet> m_FlattenedImportedStyleSheets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_m_FlattenedImportedStyleSheets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StyleSheet>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_m_FlattenedImportedStyleSheets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x06002409 RID: 9225 RVA: 0x000A2274 File Offset: 0x000A0474
		// (set) Token: 0x0600240A RID: 9226 RVA: 0x0000EC4C File Offset: 0x0000CE4C
		public unsafe int m_ContentHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_m_ContentHash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_m_ContentHash)) = value;
			}
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x0600240B RID: 9227 RVA: 0x000A229C File Offset: 0x000A049C
		// (set) Token: 0x0600240C RID: 9228 RVA: 0x0000EC67 File Offset: 0x0000CE67
		public unsafe Il2CppReferenceArray<UnityEngine.UIElements.StyleSheets.ScalableImage> scalableImages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_scalableImages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UnityEngine.UIElements.StyleSheets.ScalableImage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_scalableImages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x0600240D RID: 9229 RVA: 0x000A22CC File Offset: 0x000A04CC
		// (set) Token: 0x0600240E RID: 9230 RVA: 0x0000EC86 File Offset: 0x0000CE86
		public unsafe Dictionary<string, StyleComplexSelector> orderedNameSelectors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_orderedNameSelectors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, StyleComplexSelector>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_orderedNameSelectors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x0600240F RID: 9231 RVA: 0x000A22FC File Offset: 0x000A04FC
		// (set) Token: 0x06002410 RID: 9232 RVA: 0x0000ECA5 File Offset: 0x0000CEA5
		public unsafe Dictionary<string, StyleComplexSelector> orderedTypeSelectors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_orderedTypeSelectors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, StyleComplexSelector>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_orderedTypeSelectors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x06002411 RID: 9233 RVA: 0x000A232C File Offset: 0x000A052C
		// (set) Token: 0x06002412 RID: 9234 RVA: 0x0000ECC4 File Offset: 0x0000CEC4
		public unsafe Dictionary<string, StyleComplexSelector> orderedClassSelectors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_orderedClassSelectors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, StyleComplexSelector>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_orderedClassSelectors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x06002413 RID: 9235 RVA: 0x000A235C File Offset: 0x000A055C
		// (set) Token: 0x06002414 RID: 9236 RVA: 0x0000ECE3 File Offset: 0x0000CEE3
		public unsafe bool m_IsDefaultStyleSheet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_m_IsDefaultStyleSheet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_m_IsDefaultStyleSheet)) = value;
			}
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x06002415 RID: 9237 RVA: 0x000A2384 File Offset: 0x000A0584
		// (set) Token: 0x06002416 RID: 9238 RVA: 0x0000ECFE File Offset: 0x0000CEFE
		public unsafe static string kCustomPropertyMarker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StyleSheet.NativeFieldInfoPtr_kCustomPropertyMarker, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StyleSheet.NativeFieldInfoPtr_kCustomPropertyMarker, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040019A0 RID: 6560
		private static readonly IntPtr NativeFieldInfoPtr_m_ImportedWithErrors;

		// Token: 0x040019A1 RID: 6561
		private static readonly IntPtr NativeFieldInfoPtr_m_ImportedWithWarnings;

		// Token: 0x040019A2 RID: 6562
		private static readonly IntPtr NativeFieldInfoPtr_m_Rules;

		// Token: 0x040019A3 RID: 6563
		private static readonly IntPtr NativeFieldInfoPtr_m_ComplexSelectors;

		// Token: 0x040019A4 RID: 6564
		private static readonly IntPtr NativeFieldInfoPtr_floats;

		// Token: 0x040019A5 RID: 6565
		private static readonly IntPtr NativeFieldInfoPtr_dimensions;

		// Token: 0x040019A6 RID: 6566
		private static readonly IntPtr NativeFieldInfoPtr_colors;

		// Token: 0x040019A7 RID: 6567
		private static readonly IntPtr NativeFieldInfoPtr_strings;

		// Token: 0x040019A8 RID: 6568
		private static readonly IntPtr NativeFieldInfoPtr_assets;

		// Token: 0x040019A9 RID: 6569
		private static readonly IntPtr NativeFieldInfoPtr_imports;

		// Token: 0x040019AA RID: 6570
		private static readonly IntPtr NativeFieldInfoPtr_m_FlattenedImportedStyleSheets;

		// Token: 0x040019AB RID: 6571
		private static readonly IntPtr NativeFieldInfoPtr_m_ContentHash;

		// Token: 0x040019AC RID: 6572
		private static readonly IntPtr NativeFieldInfoPtr_scalableImages;

		// Token: 0x040019AD RID: 6573
		private static readonly IntPtr NativeFieldInfoPtr_orderedNameSelectors;

		// Token: 0x040019AE RID: 6574
		private static readonly IntPtr NativeFieldInfoPtr_orderedTypeSelectors;

		// Token: 0x040019AF RID: 6575
		private static readonly IntPtr NativeFieldInfoPtr_orderedClassSelectors;

		// Token: 0x040019B0 RID: 6576
		private static readonly IntPtr NativeFieldInfoPtr_m_IsDefaultStyleSheet;

		// Token: 0x040019B1 RID: 6577
		private static readonly IntPtr NativeFieldInfoPtr_kCustomPropertyMarker;

		// Token: 0x040019B2 RID: 6578
		private static readonly IntPtr NativeMethodInfoPtr_get_importedWithErrors_Public_get_Boolean_0;

		// Token: 0x040019B3 RID: 6579
		private static readonly IntPtr NativeMethodInfoPtr_set_importedWithErrors_Internal_set_Void_Boolean_0;

		// Token: 0x040019B4 RID: 6580
		private static readonly IntPtr NativeMethodInfoPtr_get_importedWithWarnings_Public_get_Boolean_0;

		// Token: 0x040019B5 RID: 6581
		private static readonly IntPtr NativeMethodInfoPtr_set_importedWithWarnings_Internal_set_Void_Boolean_0;

		// Token: 0x040019B6 RID: 6582
		private static readonly IntPtr NativeMethodInfoPtr_get_rules_Internal_get_Il2CppReferenceArray_1_StyleRule_0;

		// Token: 0x040019B7 RID: 6583
		private static readonly IntPtr NativeMethodInfoPtr_set_rules_Internal_set_Void_Il2CppReferenceArray_1_StyleRule_0;

		// Token: 0x040019B8 RID: 6584
		private static readonly IntPtr NativeMethodInfoPtr_get_complexSelectors_Internal_get_Il2CppReferenceArray_1_StyleComplexSelector_0;

		// Token: 0x040019B9 RID: 6585
		private static readonly IntPtr NativeMethodInfoPtr_set_complexSelectors_Internal_set_Void_Il2CppReferenceArray_1_StyleComplexSelector_0;

		// Token: 0x040019BA RID: 6586
		private static readonly IntPtr NativeMethodInfoPtr_get_flattenedRecursiveImports_Internal_get_List_1_StyleSheet_0;

		// Token: 0x040019BB RID: 6587
		private static readonly IntPtr NativeMethodInfoPtr_get_contentHash_Public_get_Int32_0;

		// Token: 0x040019BC RID: 6588
		private static readonly IntPtr NativeMethodInfoPtr_set_contentHash_Public_set_Void_Int32_0;

		// Token: 0x040019BD RID: 6589
		private static readonly IntPtr NativeMethodInfoPtr_get_isDefaultStyleSheet_Internal_get_Boolean_0;

		// Token: 0x040019BE RID: 6590
		private static readonly IntPtr NativeMethodInfoPtr_set_isDefaultStyleSheet_Internal_set_Void_Boolean_0;

		// Token: 0x040019BF RID: 6591
		private static readonly IntPtr NativeMethodInfoPtr_TryCheckAccess_Private_Boolean_Il2CppArrayBase_1_T_StyleValueType_StyleValueHandle_byref_T_0;

		// Token: 0x040019C0 RID: 6592
		private static readonly IntPtr NativeMethodInfoPtr_CheckAccess_Private_T_Il2CppArrayBase_1_T_StyleValueType_StyleValueHandle_0;

		// Token: 0x040019C1 RID: 6593
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Internal_Virtual_New_Void_0;

		// Token: 0x040019C2 RID: 6594
		private static readonly IntPtr NativeMethodInfoPtr_FlattenImportedStyleSheetsRecursive_Internal_Void_0;

		// Token: 0x040019C3 RID: 6595
		private static readonly IntPtr NativeMethodInfoPtr_FlattenImportedStyleSheetsRecursive_Private_Void_StyleSheet_0;

		// Token: 0x040019C4 RID: 6596
		private static readonly IntPtr NativeMethodInfoPtr_SetupReferences_Private_Void_0;

		// Token: 0x040019C5 RID: 6597
		private static readonly IntPtr NativeMethodInfoPtr_ReadKeyword_Internal_StyleValueKeyword_StyleValueHandle_0;

		// Token: 0x040019C6 RID: 6598
		private static readonly IntPtr NativeMethodInfoPtr_ReadFloat_Internal_Single_StyleValueHandle_0;

		// Token: 0x040019C7 RID: 6599
		private static readonly IntPtr NativeMethodInfoPtr_TryReadFloat_Internal_Boolean_StyleValueHandle_byref_Single_0;

		// Token: 0x040019C8 RID: 6600
		private static readonly IntPtr NativeMethodInfoPtr_ReadDimension_Internal_Dimension_StyleValueHandle_0;

		// Token: 0x040019C9 RID: 6601
		private static readonly IntPtr NativeMethodInfoPtr_TryReadDimension_Internal_Boolean_StyleValueHandle_byref_Dimension_0;

		// Token: 0x040019CA RID: 6602
		private static readonly IntPtr NativeMethodInfoPtr_ReadColor_Internal_Color_StyleValueHandle_0;

		// Token: 0x040019CB RID: 6603
		private static readonly IntPtr NativeMethodInfoPtr_TryReadColor_Internal_Boolean_StyleValueHandle_byref_Color_0;

		// Token: 0x040019CC RID: 6604
		private static readonly IntPtr NativeMethodInfoPtr_ReadString_Internal_String_StyleValueHandle_0;

		// Token: 0x040019CD RID: 6605
		private static readonly IntPtr NativeMethodInfoPtr_TryReadString_Internal_Boolean_StyleValueHandle_byref_String_0;

		// Token: 0x040019CE RID: 6606
		private static readonly IntPtr NativeMethodInfoPtr_ReadEnum_Internal_String_StyleValueHandle_0;

		// Token: 0x040019CF RID: 6607
		private static readonly IntPtr NativeMethodInfoPtr_TryReadEnum_Internal_Boolean_StyleValueHandle_byref_String_0;

		// Token: 0x040019D0 RID: 6608
		private static readonly IntPtr NativeMethodInfoPtr_ReadVariable_Internal_String_StyleValueHandle_0;

		// Token: 0x040019D1 RID: 6609
		private static readonly IntPtr NativeMethodInfoPtr_TryReadVariable_Internal_Boolean_StyleValueHandle_byref_String_0;

		// Token: 0x040019D2 RID: 6610
		private static readonly IntPtr NativeMethodInfoPtr_ReadResourcePath_Internal_String_StyleValueHandle_0;

		// Token: 0x040019D3 RID: 6611
		private static readonly IntPtr NativeMethodInfoPtr_TryReadResourcePath_Internal_Boolean_StyleValueHandle_byref_String_0;

		// Token: 0x040019D4 RID: 6612
		private static readonly IntPtr NativeMethodInfoPtr_ReadAssetReference_Internal_Object_StyleValueHandle_0;

		// Token: 0x040019D5 RID: 6613
		private static readonly IntPtr NativeMethodInfoPtr_ReadMissingAssetReferenceUrl_Internal_String_StyleValueHandle_0;

		// Token: 0x040019D6 RID: 6614
		private static readonly IntPtr NativeMethodInfoPtr_TryReadAssetReference_Internal_Boolean_StyleValueHandle_byref_Object_0;

		// Token: 0x040019D7 RID: 6615
		private static readonly IntPtr NativeMethodInfoPtr_ReadFunction_Internal_StyleValueFunction_StyleValueHandle_0;

		// Token: 0x040019D8 RID: 6616
		private static readonly IntPtr NativeMethodInfoPtr_ReadFunctionName_Internal_String_StyleValueHandle_0;

		// Token: 0x040019D9 RID: 6617
		private static readonly IntPtr NativeMethodInfoPtr_ReadScalableImage_Internal_ScalableImage_StyleValueHandle_0;

		// Token: 0x040019DA RID: 6618
		private static readonly IntPtr NativeMethodInfoPtr_CustomStartsWith_Private_Static_Boolean_String_String_0;

		// Token: 0x040019DB RID: 6619
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020004E0 RID: 1248
		[Serializable]
		public sealed class ImportStruct : ValueType
		{
			// Token: 0x06003F13 RID: 16147 RVA: 0x000FBA40 File Offset: 0x000F9C40
			// Note: this type is marked as 'beforefieldinit'.
			static ImportStruct()
			{
				Il2CppClassPointerStore<StyleSheet.ImportStruct>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, "ImportStruct");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleSheet.ImportStruct>.NativeClassPtr);
				StyleSheet.ImportStruct.NativeFieldInfoPtr_styleSheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheet.ImportStruct>.NativeClassPtr, "styleSheet");
				StyleSheet.ImportStruct.NativeFieldInfoPtr_mediaQueries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheet.ImportStruct>.NativeClassPtr, "mediaQueries");
			}

			// Token: 0x06003F14 RID: 16148 RVA: 0x0001A6C0 File Offset: 0x000188C0
			public ImportStruct(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003F15 RID: 16149 RVA: 0x0001A6C9 File Offset: 0x000188C9
			public ImportStruct()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleSheet.ImportStruct>.NativeClassPtr))
			{
			}

			// Token: 0x170012F4 RID: 4852
			// (get) Token: 0x06003F16 RID: 16150 RVA: 0x000FBA94 File Offset: 0x000F9C94
			// (set) Token: 0x06003F17 RID: 16151 RVA: 0x0001A6DB File Offset: 0x000188DB
			public unsafe StyleSheet styleSheet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.ImportStruct.NativeFieldInfoPtr_styleSheet);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleSheet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.ImportStruct.NativeFieldInfoPtr_styleSheet), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012F5 RID: 4853
			// (get) Token: 0x06003F18 RID: 16152 RVA: 0x000FBAC4 File Offset: 0x000F9CC4
			// (set) Token: 0x06003F19 RID: 16153 RVA: 0x0001A6FA File Offset: 0x000188FA
			public unsafe Il2CppStringArray mediaQueries
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.ImportStruct.NativeFieldInfoPtr_mediaQueries);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.ImportStruct.NativeFieldInfoPtr_mediaQueries), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C9B RID: 11419
			private static readonly IntPtr NativeFieldInfoPtr_styleSheet;

			// Token: 0x04002C9C RID: 11420
			private static readonly IntPtr NativeFieldInfoPtr_mediaQueries;
		}

		// Token: 0x020004E1 RID: 1249
		private sealed class MethodInfoStoreGeneric_TryCheckAccess_Private_Boolean_Il2CppArrayBase_1_T_StyleValueType_StyleValueHandle_byref_T_0<T>
		{
			// Token: 0x04002C9D RID: 11421
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(StyleSheet.NativeMethodInfoPtr_TryCheckAccess_Private_Boolean_Il2CppArrayBase_1_T_StyleValueType_StyleValueHandle_byref_T_0, Il2CppClassPointerStore<StyleSheet>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020004E2 RID: 1250
		private sealed class MethodInfoStoreGeneric_CheckAccess_Private_T_Il2CppArrayBase_1_T_StyleValueType_StyleValueHandle_0<T>
		{
			// Token: 0x04002C9E RID: 11422
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(StyleSheet.NativeMethodInfoPtr_CheckAccess_Private_T_Il2CppArrayBase_1_T_StyleValueType_StyleValueHandle_0, Il2CppClassPointerStore<StyleSheet>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
