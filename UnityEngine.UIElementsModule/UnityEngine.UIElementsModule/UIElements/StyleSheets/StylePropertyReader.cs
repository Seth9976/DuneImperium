using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x02000288 RID: 648
	public class StylePropertyReader : Object
	{
		// Token: 0x06003063 RID: 12387 RVA: 0x000CD498 File Offset: 0x000CB698
		// Note: this type is marked as 'beforefieldinit'.
		static StylePropertyReader()
		{
			Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.StyleSheets", "StylePropertyReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr);
			StylePropertyReader.NativeFieldInfoPtr_getCursorIdFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, "getCursorIdFunc");
			StylePropertyReader.NativeFieldInfoPtr_m_Values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, "m_Values");
			StylePropertyReader.NativeFieldInfoPtr_m_ValueCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, "m_ValueCount");
			StylePropertyReader.NativeFieldInfoPtr_m_Resolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, "m_Resolver");
			StylePropertyReader.NativeFieldInfoPtr_m_Sheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, "m_Sheet");
			StylePropertyReader.NativeFieldInfoPtr_m_Properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, "m_Properties");
			StylePropertyReader.NativeFieldInfoPtr_m_PropertyIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, "m_PropertyIds");
			StylePropertyReader.NativeFieldInfoPtr_m_CurrentValueIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, "m_CurrentValueIndex");
			StylePropertyReader.NativeFieldInfoPtr_m_CurrentPropertyIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, "m_CurrentPropertyIndex");
			StylePropertyReader.NativeFieldInfoPtr__property_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, "<property>k__BackingField");
			StylePropertyReader.NativeFieldInfoPtr__propertyId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, "<propertyId>k__BackingField");
			StylePropertyReader.NativeFieldInfoPtr__valueCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, "<valueCount>k__BackingField");
			StylePropertyReader.NativeFieldInfoPtr__dpiScaling_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, "<dpiScaling>k__BackingField");
			StylePropertyReader.NativeMethodInfoPtr_get_property_Public_get_StyleProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670313);
			StylePropertyReader.NativeMethodInfoPtr_set_property_Private_set_Void_StyleProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670314);
			StylePropertyReader.NativeMethodInfoPtr_get_propertyId_Public_get_StylePropertyId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670315);
			StylePropertyReader.NativeMethodInfoPtr_set_propertyId_Private_set_Void_StylePropertyId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670316);
			StylePropertyReader.NativeMethodInfoPtr_get_valueCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670317);
			StylePropertyReader.NativeMethodInfoPtr_set_valueCount_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670318);
			StylePropertyReader.NativeMethodInfoPtr_get_dpiScaling_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670319);
			StylePropertyReader.NativeMethodInfoPtr_set_dpiScaling_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670320);
			StylePropertyReader.NativeMethodInfoPtr_SetContext_Public_Void_StyleSheet_StyleComplexSelector_StyleVariableContext_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670321);
			StylePropertyReader.NativeMethodInfoPtr_SetInlineContext_Public_Void_StyleSheet_Il2CppReferenceArray_1_StyleProperty_Il2CppStructArray_1_StylePropertyId_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670322);
			StylePropertyReader.NativeMethodInfoPtr_MoveNextProperty_Public_StylePropertyId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670323);
			StylePropertyReader.NativeMethodInfoPtr_GetValue_Public_StylePropertyValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670324);
			StylePropertyReader.NativeMethodInfoPtr_GetValueType_Public_StyleValueType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670325);
			StylePropertyReader.NativeMethodInfoPtr_IsValueType_Public_Boolean_Int32_StyleValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670326);
			StylePropertyReader.NativeMethodInfoPtr_IsKeyword_Public_Boolean_Int32_StyleValueKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670327);
			StylePropertyReader.NativeMethodInfoPtr_ReadAsString_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670328);
			StylePropertyReader.NativeMethodInfoPtr_ReadLength_Public_Length_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670329);
			StylePropertyReader.NativeMethodInfoPtr_ReadTimeValue_Public_TimeValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670330);
			StylePropertyReader.NativeMethodInfoPtr_ReadTranslate_Public_Translate_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670331);
			StylePropertyReader.NativeMethodInfoPtr_ReadTransformOrigin_Public_TransformOrigin_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670332);
			StylePropertyReader.NativeMethodInfoPtr_ReadRotate_Public_Rotate_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670333);
			StylePropertyReader.NativeMethodInfoPtr_ReadScale_Public_Scale_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670334);
			StylePropertyReader.NativeMethodInfoPtr_ReadFloat_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670335);
			StylePropertyReader.NativeMethodInfoPtr_ReadInt_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670336);
			StylePropertyReader.NativeMethodInfoPtr_ReadColor_Public_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670337);
			StylePropertyReader.NativeMethodInfoPtr_ReadEnum_Public_Int32_StyleEnumType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670338);
			StylePropertyReader.NativeMethodInfoPtr_ReadFontDefinition_Public_FontDefinition_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670339);
			StylePropertyReader.NativeMethodInfoPtr_ReadFont_Public_Font_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670340);
			StylePropertyReader.NativeMethodInfoPtr_ReadBackground_Public_Background_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670341);
			StylePropertyReader.NativeMethodInfoPtr_ReadCursor_Public_Cursor_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670342);
			StylePropertyReader.NativeMethodInfoPtr_ReadTextShadow_Public_TextShadow_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670343);
			StylePropertyReader.NativeMethodInfoPtr_ReadBackgroundPositionX_Public_BackgroundPosition_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670344);
			StylePropertyReader.NativeMethodInfoPtr_ReadBackgroundPositionY_Public_BackgroundPosition_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670345);
			StylePropertyReader.NativeMethodInfoPtr_ReadBackgroundPosition_Private_BackgroundPosition_Int32_BackgroundPositionKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670346);
			StylePropertyReader.NativeMethodInfoPtr_ReadBackgroundRepeat_Public_BackgroundRepeat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670347);
			StylePropertyReader.NativeMethodInfoPtr_ReadBackgroundSize_Public_BackgroundSize_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670348);
			StylePropertyReader.NativeMethodInfoPtr_ReadListEasingFunction_Public_Void_List_1_EasingFunction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670349);
			StylePropertyReader.NativeMethodInfoPtr_ReadListTimeValue_Public_Void_List_1_TimeValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670350);
			StylePropertyReader.NativeMethodInfoPtr_ReadListStylePropertyName_Public_Void_List_1_StylePropertyName_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670351);
			StylePropertyReader.NativeMethodInfoPtr_LoadProperties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670352);
			StylePropertyReader.NativeMethodInfoPtr_SetCurrentProperty_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670353);
			StylePropertyReader.NativeMethodInfoPtr_ReadTransformOrigin_Public_Static_TransformOrigin_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670354);
			StylePropertyReader.NativeMethodInfoPtr_ReadTransformOriginEnum_Private_Static_Length_StylePropertyValue_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670355);
			StylePropertyReader.NativeMethodInfoPtr_ReadTranslate_Public_Static_Translate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670356);
			StylePropertyReader.NativeMethodInfoPtr_ReadScale_Public_Static_Scale_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670357);
			StylePropertyReader.NativeMethodInfoPtr_ReadRotate_Public_Static_Rotate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue_StylePropertyValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670358);
			StylePropertyReader.NativeMethodInfoPtr_TryReadEnum_Private_Static_Boolean_StyleEnumType_StylePropertyValue_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670359);
			StylePropertyReader.NativeMethodInfoPtr_ReadEnum_Private_Static_Int32_StyleEnumType_StylePropertyValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670360);
			StylePropertyReader.NativeMethodInfoPtr_ReadAngle_Public_Static_Angle_StylePropertyValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670361);
			StylePropertyReader.NativeMethodInfoPtr_ReadBackgroundPosition_Public_Static_BackgroundPosition_Int32_StylePropertyValue_StylePropertyValue_BackgroundPositionKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670362);
			StylePropertyReader.NativeMethodInfoPtr_ReadBackgroundRepeat_Public_Static_BackgroundRepeat_Int32_StylePropertyValue_StylePropertyValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670363);
			StylePropertyReader.NativeMethodInfoPtr_ReadBackgroundSize_Public_Static_BackgroundSize_Int32_StylePropertyValue_StylePropertyValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670364);
			StylePropertyReader.NativeMethodInfoPtr_TryGetImageSourceFromValue_Internal_Static_Boolean_StylePropertyValue_Single_byref_ImageSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670365);
			StylePropertyReader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, 100670366);
		}

		// Token: 0x17000F55 RID: 3925
		// (get) Token: 0x06003064 RID: 12388 RVA: 0x000CDA04 File Offset: 0x000CBC04
		// (set) Token: 0x06003065 RID: 12389 RVA: 0x000CDA44 File Offset: 0x000CBC44
		public unsafe StyleProperty property
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_get_property_Public_get_StyleProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StyleProperty>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_set_property_Private_set_Void_StyleProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F56 RID: 3926
		// (get) Token: 0x06003066 RID: 12390 RVA: 0x000CDA88 File Offset: 0x000CBC88
		// (set) Token: 0x06003067 RID: 12391 RVA: 0x000CDAC4 File Offset: 0x000CBCC4
		public unsafe StylePropertyId propertyId
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 318242, RefRangeEnd = 318245, XrefRangeStart = 318242, XrefRangeEnd = 318245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_get_propertyId_Public_get_StylePropertyId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_set_propertyId_Private_set_Void_StylePropertyId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F57 RID: 3927
		// (get) Token: 0x06003068 RID: 12392 RVA: 0x000CDB04 File Offset: 0x000CBD04
		// (set) Token: 0x06003069 RID: 12393 RVA: 0x000CDB40 File Offset: 0x000CBD40
		public unsafe int valueCount
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 357464, RefRangeEnd = 357469, XrefRangeStart = 357464, XrefRangeEnd = 357464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_get_valueCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_set_valueCount_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F58 RID: 3928
		// (get) Token: 0x0600306A RID: 12394 RVA: 0x000CDB80 File Offset: 0x000CBD80
		// (set) Token: 0x0600306B RID: 12395 RVA: 0x000CDBBC File Offset: 0x000CBDBC
		public unsafe float dpiScaling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_get_dpiScaling_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 357469, RefRangeEnd = 357470, XrefRangeStart = 357469, XrefRangeEnd = 357469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_set_dpiScaling_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600306C RID: 12396 RVA: 0x000CDBFC File Offset: 0x000CBDFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 357481, RefRangeEnd = 357482, XrefRangeStart = 357470, XrefRangeEnd = 357481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetContext(StyleSheet sheet, StyleComplexSelector selector, StyleVariableContext varContext, float dpiScaling = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sheet);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(varContext);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dpiScaling;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_SetContext_Public_Void_StyleSheet_StyleComplexSelector_StyleVariableContext_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600306D RID: 12397 RVA: 0x000CDC70 File Offset: 0x000CBE70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 357486, RefRangeEnd = 357487, XrefRangeStart = 357482, XrefRangeEnd = 357486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInlineContext(StyleSheet sheet, Il2CppReferenceArray<StyleProperty> properties, Il2CppStructArray<StylePropertyId> propertyIds, float dpiScaling = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sheet);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(propertyIds);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dpiScaling;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_SetInlineContext_Public_Void_StyleSheet_Il2CppReferenceArray_1_StyleProperty_Il2CppStructArray_1_StylePropertyId_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600306E RID: 12398 RVA: 0x000CDCE4 File Offset: 0x000CBEE4
		[CallerCount(89)]
		[CachedScanResults(RefRangeStart = 357488, RefRangeEnd = 357577, XrefRangeStart = 357487, XrefRangeEnd = 357488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StylePropertyId MoveNextProperty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_MoveNextProperty_Public_StylePropertyId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600306F RID: 12399 RVA: 0x000CDD20 File Offset: 0x000CBF20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 357580, RefRangeEnd = 357583, XrefRangeStart = 357577, XrefRangeEnd = 357580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StylePropertyValue GetValue(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_GetValue_Public_StylePropertyValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new StylePropertyValue(intPtr);
			}
		}

		// Token: 0x06003070 RID: 12400 RVA: 0x000CDD64 File Offset: 0x000CBF64
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 357587, RefRangeEnd = 357592, XrefRangeStart = 357583, XrefRangeEnd = 357587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleValueType GetValueType(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_GetValueType_Public_StyleValueType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003071 RID: 12401 RVA: 0x000CDDB0 File Offset: 0x000CBFB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357592, XrefRangeEnd = 357596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValueType(int index, StyleValueType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_IsValueType_Public_Boolean_Int32_StyleValueType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003072 RID: 12402 RVA: 0x000CDE08 File Offset: 0x000CC008
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 357600, RefRangeEnd = 357604, XrefRangeStart = 357596, XrefRangeEnd = 357600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsKeyword(int index, StyleValueKeyword keyword)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyword;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_IsKeyword_Public_Boolean_Int32_StyleValueKeyword_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003073 RID: 12403 RVA: 0x000CDE60 File Offset: 0x000CC060
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 357609, RefRangeEnd = 357610, XrefRangeStart = 357604, XrefRangeEnd = 357609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadAsString(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_ReadAsString_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003074 RID: 12404 RVA: 0x000CDEA4 File Offset: 0x000CC0A4
		[CallerCount(75)]
		[CachedScanResults(RefRangeStart = 357616, RefRangeEnd = 357691, XrefRangeStart = 357610, XrefRangeEnd = 357616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Length ReadLength(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_ReadLength_Public_Length_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003075 RID: 12405 RVA: 0x000CDEF0 File Offset: 0x000CC0F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 357696, RefRangeEnd = 357697, XrefRangeStart = 357691, XrefRangeEnd = 357696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeValue ReadTimeValue(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_ReadTimeValue_Public_TimeValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003076 RID: 12406 RVA: 0x000CDF3C File Offset: 0x000CC13C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 357707, RefRangeEnd = 357708, XrefRangeStart = 357697, XrefRangeEnd = 357707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Translate ReadTranslate(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_ReadTranslate_Public_Translate_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003077 RID: 12407 RVA: 0x000CDF88 File Offset: 0x000CC188
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 357718, RefRangeEnd = 357719, XrefRangeStart = 357708, XrefRangeEnd = 357718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransformOrigin ReadTransformOrigin(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_ReadTransformOrigin_Public_TransformOrigin_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003078 RID: 12408 RVA: 0x000CDFD4 File Offset: 0x000CC1D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 357745, RefRangeEnd = 357746, XrefRangeStart = 357719, XrefRangeEnd = 357745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rotate ReadRotate(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_ReadRotate_Public_Rotate_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003079 RID: 12409 RVA: 0x000CE020 File Offset: 0x000CC220
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 357756, RefRangeEnd = 357757, XrefRangeStart = 357746, XrefRangeEnd = 357756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Scale ReadScale(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_ReadScale_Public_Scale_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600307A RID: 12410 RVA: 0x000CE06C File Offset: 0x000CC26C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 357762, RefRangeEnd = 357774, XrefRangeStart = 357757, XrefRangeEnd = 357762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ReadFloat(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_ReadFloat_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600307B RID: 12411 RVA: 0x000CE0B8 File Offset: 0x000CC2B8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 357778, RefRangeEnd = 357782, XrefRangeStart = 357774, XrefRangeEnd = 357778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadInt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_ReadInt_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600307C RID: 12412 RVA: 0x000CE104 File Offset: 0x000CC304
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 357794, RefRangeEnd = 357821, XrefRangeStart = 357782, XrefRangeEnd = 357794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color ReadColor(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_ReadColor_Public_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600307D RID: 12413 RVA: 0x000CE150 File Offset: 0x000CC350
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 357833, RefRangeEnd = 357860, XrefRangeStart = 357821, XrefRangeEnd = 357833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadEnum(StyleEnumType enumType, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enumType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_ReadEnum_Public_Int32_StyleEnumType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600307E RID: 12414 RVA: 0x000CE1A8 File Offset: 0x000CC3A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 357940, RefRangeEnd = 357941, XrefRangeStart = 357860, XrefRangeEnd = 357940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FontDefinition ReadFontDefinition(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_ReadFontDefinition_Public_FontDefinition_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new FontDefinition(intPtr);
			}
		}

		// Token: 0x0600307F RID: 12415 RVA: 0x000CE1EC File Offset: 0x000CC3EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 357988, RefRangeEnd = 357989, XrefRangeStart = 357941, XrefRangeEnd = 357988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Font ReadFont(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_ReadFont_Public_Font_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Font>(intPtr3) : null;
			}
		}

		// Token: 0x06003080 RID: 12416 RVA: 0x000CE238 File Offset: 0x000CC438
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358026, RefRangeEnd = 358027, XrefRangeStart = 357989, XrefRangeEnd = 358026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Background ReadBackground(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_ReadBackground_Public_Background_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Background(intPtr);
			}
		}

		// Token: 0x06003081 RID: 12417 RVA: 0x000CE27C File Offset: 0x000CC47C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358066, RefRangeEnd = 358067, XrefRangeStart = 358027, XrefRangeEnd = 358066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cursor ReadCursor(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_ReadCursor_Public_Cursor_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Cursor(intPtr);
			}
		}

		// Token: 0x06003082 RID: 12418 RVA: 0x000CE2C0 File Offset: 0x000CC4C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358090, RefRangeEnd = 358091, XrefRangeStart = 358067, XrefRangeEnd = 358090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextShadow ReadTextShadow(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_ReadTextShadow_Public_TextShadow_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003083 RID: 12419 RVA: 0x000CE30C File Offset: 0x000CC50C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358092, RefRangeEnd = 358093, XrefRangeStart = 358091, XrefRangeEnd = 358092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BackgroundPosition ReadBackgroundPositionX(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_ReadBackgroundPositionX_Public_BackgroundPosition_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003084 RID: 12420 RVA: 0x000CE358 File Offset: 0x000CC558
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358094, RefRangeEnd = 358095, XrefRangeStart = 358093, XrefRangeEnd = 358094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BackgroundPosition ReadBackgroundPositionY(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_ReadBackgroundPositionY_Public_BackgroundPosition_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003085 RID: 12421 RVA: 0x000CE3A4 File Offset: 0x000CC5A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 358102, RefRangeEnd = 358104, XrefRangeStart = 358095, XrefRangeEnd = 358102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BackgroundPosition ReadBackgroundPosition(int index, BackgroundPositionKeyword keyword)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyword;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_ReadBackgroundPosition_Private_BackgroundPosition_Int32_BackgroundPositionKeyword_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003086 RID: 12422 RVA: 0x000CE3FC File Offset: 0x000CC5FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358125, RefRangeEnd = 358126, XrefRangeStart = 358104, XrefRangeEnd = 358125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BackgroundRepeat ReadBackgroundRepeat(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_ReadBackgroundRepeat_Public_BackgroundRepeat_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003087 RID: 12423 RVA: 0x000CE448 File Offset: 0x000CC648
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358133, RefRangeEnd = 358134, XrefRangeStart = 358126, XrefRangeEnd = 358133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BackgroundSize ReadBackgroundSize(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_ReadBackgroundSize_Public_BackgroundSize_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003088 RID: 12424 RVA: 0x000CE494 File Offset: 0x000CC694
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358152, RefRangeEnd = 358153, XrefRangeStart = 358134, XrefRangeEnd = 358152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadListEasingFunction(List<EasingFunction> list, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_ReadListEasingFunction_Public_Void_List_1_EasingFunction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003089 RID: 12425 RVA: 0x000CE4E4 File Offset: 0x000CC6E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358166, RefRangeEnd = 358167, XrefRangeStart = 358153, XrefRangeEnd = 358166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadListTimeValue(List<TimeValue> list, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_ReadListTimeValue_Public_Void_List_1_TimeValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600308A RID: 12426 RVA: 0x000CE534 File Offset: 0x000CC734
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358182, RefRangeEnd = 358183, XrefRangeStart = 358167, XrefRangeEnd = 358182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadListStylePropertyName(List<StylePropertyName> list, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_ReadListStylePropertyName_Public_Void_List_1_StylePropertyName_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600308B RID: 12427 RVA: 0x000CE584 File Offset: 0x000CC784
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 358217, RefRangeEnd = 358219, XrefRangeStart = 358183, XrefRangeEnd = 358217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_LoadProperties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600308C RID: 12428 RVA: 0x000CE5B8 File Offset: 0x000CC7B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 358221, RefRangeEnd = 358223, XrefRangeStart = 358219, XrefRangeEnd = 358221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCurrentProperty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_SetCurrentProperty_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600308D RID: 12429 RVA: 0x000CE5EC File Offset: 0x000CC7EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358247, RefRangeEnd = 358248, XrefRangeStart = 358223, XrefRangeEnd = 358247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TransformOrigin ReadTransformOrigin(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue zVvalue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref valCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(val1));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(val2));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(zVvalue));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_ReadTransformOrigin_Public_Static_TransformOrigin_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600308E RID: 12430 RVA: 0x000CE670 File Offset: 0x000CC870
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 358253, RefRangeEnd = 358255, XrefRangeStart = 358248, XrefRangeEnd = 358253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Length ReadTransformOriginEnum(StylePropertyValue value, out bool isVertical, out bool isHorizontal)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isVertical;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isHorizontal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_ReadTransformOriginEnum_Private_Static_Length_StylePropertyValue_byref_Boolean_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600308F RID: 12431 RVA: 0x000CE6D4 File Offset: 0x000CC8D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358277, RefRangeEnd = 358278, XrefRangeStart = 358255, XrefRangeEnd = 358277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Translate ReadTranslate(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref valCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(val1));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(val2));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(val3));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_ReadTranslate_Public_Static_Translate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003090 RID: 12432 RVA: 0x000CE758 File Offset: 0x000CC958
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358297, RefRangeEnd = 358298, XrefRangeStart = 358278, XrefRangeEnd = 358297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Scale ReadScale(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref valCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(val1));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(val2));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(val3));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_ReadScale_Public_Static_Scale_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003091 RID: 12433 RVA: 0x000CE7DC File Offset: 0x000CC9DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358298, XrefRangeEnd = 358315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rotate ReadRotate(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3, StylePropertyValue val4)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref valCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(val1));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(val2));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(val3));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(val4));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_ReadRotate_Public_Static_Rotate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue_StylePropertyValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003092 RID: 12434 RVA: 0x000CE878 File Offset: 0x000CCA78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358315, XrefRangeEnd = 358324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryReadEnum(StyleEnumType enumType, StylePropertyValue value, out int intValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enumType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &intValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_TryReadEnum_Private_Static_Boolean_StyleEnumType_StylePropertyValue_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003093 RID: 12435 RVA: 0x000CE8DC File Offset: 0x000CCADC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 358333, RefRangeEnd = 358342, XrefRangeStart = 358324, XrefRangeEnd = 358333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ReadEnum(StyleEnumType enumType, StylePropertyValue value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enumType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_ReadEnum_Private_Static_Int32_StyleEnumType_StylePropertyValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003094 RID: 12436 RVA: 0x000CE930 File Offset: 0x000CCB30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358342, XrefRangeEnd = 358345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Angle ReadAngle(StylePropertyValue value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_ReadAngle_Public_Static_Angle_StylePropertyValue_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003095 RID: 12437 RVA: 0x000CE978 File Offset: 0x000CCB78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358364, RefRangeEnd = 358365, XrefRangeStart = 358345, XrefRangeEnd = 358364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BackgroundPosition ReadBackgroundPosition(int valCount, StylePropertyValue val1, StylePropertyValue val2, BackgroundPositionKeyword keyword)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref valCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(val1));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(val2));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyword;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_ReadBackgroundPosition_Public_Static_BackgroundPosition_Int32_StylePropertyValue_StylePropertyValue_BackgroundPositionKeyword_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003096 RID: 12438 RVA: 0x000CE9F4 File Offset: 0x000CCBF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358365, XrefRangeEnd = 358367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BackgroundRepeat ReadBackgroundRepeat(int valCount, StylePropertyValue val1, StylePropertyValue val2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref valCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(val1));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(val2));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_ReadBackgroundRepeat_Public_Static_BackgroundRepeat_Int32_StylePropertyValue_StylePropertyValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003097 RID: 12439 RVA: 0x000CEA60 File Offset: 0x000CCC60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358393, RefRangeEnd = 358394, XrefRangeStart = 358367, XrefRangeEnd = 358393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BackgroundSize ReadBackgroundSize(int valCount, StylePropertyValue val1, StylePropertyValue val2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref valCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(val1));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(val2));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_ReadBackgroundSize_Public_Static_BackgroundSize_Int32_StylePropertyValue_StylePropertyValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003098 RID: 12440 RVA: 0x000CEACC File Offset: 0x000CCCCC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 358437, RefRangeEnd = 358442, XrefRangeStart = 358394, XrefRangeEnd = 358437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetImageSourceFromValue(StylePropertyValue propertyValue, float dpiScaling, out ImageSource source)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(propertyValue));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dpiScaling;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr_TryGetImageSourceFromValue_Internal_Static_Boolean_StylePropertyValue_Single_byref_ImageSource_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			source = ((intPtr4 == 0) ? null : new ImageSource(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06003099 RID: 12441 RVA: 0x000CEB44 File Offset: 0x000CCD44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358462, RefRangeEnd = 358463, XrefRangeStart = 358442, XrefRangeEnd = 358462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StylePropertyReader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600309A RID: 12442 RVA: 0x00013CEF File Offset: 0x00011EEF
		public StylePropertyReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F48 RID: 3912
		// (get) Token: 0x0600309B RID: 12443 RVA: 0x000CEB80 File Offset: 0x000CCD80
		// (set) Token: 0x0600309C RID: 12444 RVA: 0x00013CF8 File Offset: 0x00011EF8
		public unsafe static StylePropertyReader.GetCursorIdFunction getCursorIdFunc
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StylePropertyReader.NativeFieldInfoPtr_getCursorIdFunc, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StylePropertyReader.GetCursorIdFunction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StylePropertyReader.NativeFieldInfoPtr_getCursorIdFunc, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F49 RID: 3913
		// (get) Token: 0x0600309D RID: 12445 RVA: 0x000CEBA8 File Offset: 0x000CCDA8
		// (set) Token: 0x0600309E RID: 12446 RVA: 0x00013D0A File Offset: 0x00011F0A
		public unsafe List<StylePropertyValue> m_Values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr_m_Values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StylePropertyValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr_m_Values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F4A RID: 3914
		// (get) Token: 0x0600309F RID: 12447 RVA: 0x000CEBD8 File Offset: 0x000CCDD8
		// (set) Token: 0x060030A0 RID: 12448 RVA: 0x00013D29 File Offset: 0x00011F29
		public unsafe List<int> m_ValueCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr_m_ValueCount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr_m_ValueCount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x060030A1 RID: 12449 RVA: 0x000CEC08 File Offset: 0x000CCE08
		// (set) Token: 0x060030A2 RID: 12450 RVA: 0x00013D48 File Offset: 0x00011F48
		public unsafe StyleVariableResolver m_Resolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr_m_Resolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleVariableResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr_m_Resolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F4C RID: 3916
		// (get) Token: 0x060030A3 RID: 12451 RVA: 0x000CEC38 File Offset: 0x000CCE38
		// (set) Token: 0x060030A4 RID: 12452 RVA: 0x00013D67 File Offset: 0x00011F67
		public unsafe StyleSheet m_Sheet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr_m_Sheet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleSheet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr_m_Sheet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F4D RID: 3917
		// (get) Token: 0x060030A5 RID: 12453 RVA: 0x000CEC68 File Offset: 0x000CCE68
		// (set) Token: 0x060030A6 RID: 12454 RVA: 0x00013D86 File Offset: 0x00011F86
		public unsafe Il2CppReferenceArray<StyleProperty> m_Properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr_m_Properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StyleProperty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr_m_Properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F4E RID: 3918
		// (get) Token: 0x060030A7 RID: 12455 RVA: 0x000CEC98 File Offset: 0x000CCE98
		// (set) Token: 0x060030A8 RID: 12456 RVA: 0x00013DA5 File Offset: 0x00011FA5
		public unsafe Il2CppStructArray<StylePropertyId> m_PropertyIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr_m_PropertyIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<StylePropertyId>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr_m_PropertyIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F4F RID: 3919
		// (get) Token: 0x060030A9 RID: 12457 RVA: 0x000CECC8 File Offset: 0x000CCEC8
		// (set) Token: 0x060030AA RID: 12458 RVA: 0x00013DC4 File Offset: 0x00011FC4
		public unsafe int m_CurrentValueIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr_m_CurrentValueIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr_m_CurrentValueIndex)) = value;
			}
		}

		// Token: 0x17000F50 RID: 3920
		// (get) Token: 0x060030AB RID: 12459 RVA: 0x000CECF0 File Offset: 0x000CCEF0
		// (set) Token: 0x060030AC RID: 12460 RVA: 0x00013DDF File Offset: 0x00011FDF
		public unsafe int m_CurrentPropertyIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr_m_CurrentPropertyIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr_m_CurrentPropertyIndex)) = value;
			}
		}

		// Token: 0x17000F51 RID: 3921
		// (get) Token: 0x060030AD RID: 12461 RVA: 0x000CED18 File Offset: 0x000CCF18
		// (set) Token: 0x060030AE RID: 12462 RVA: 0x00013DFA File Offset: 0x00011FFA
		public unsafe StyleProperty _property_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr__property_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleProperty>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr__property_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F52 RID: 3922
		// (get) Token: 0x060030AF RID: 12463 RVA: 0x000CED48 File Offset: 0x000CCF48
		// (set) Token: 0x060030B0 RID: 12464 RVA: 0x00013E19 File Offset: 0x00012019
		public unsafe StylePropertyId _propertyId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr__propertyId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr__propertyId_k__BackingField)) = value;
			}
		}

		// Token: 0x17000F53 RID: 3923
		// (get) Token: 0x060030B1 RID: 12465 RVA: 0x000CED70 File Offset: 0x000CCF70
		// (set) Token: 0x060030B2 RID: 12466 RVA: 0x00013E34 File Offset: 0x00012034
		public unsafe int _valueCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr__valueCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr__valueCount_k__BackingField)) = value;
			}
		}

		// Token: 0x17000F54 RID: 3924
		// (get) Token: 0x060030B3 RID: 12467 RVA: 0x000CED98 File Offset: 0x000CCF98
		// (set) Token: 0x060030B4 RID: 12468 RVA: 0x00013E4F File Offset: 0x0001204F
		public unsafe float _dpiScaling_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr__dpiScaling_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyReader.NativeFieldInfoPtr__dpiScaling_k__BackingField)) = value;
			}
		}

		// Token: 0x060030B5 RID: 12469 RVA: 0x00013E6A File Offset: 0x0001206A
		public void ReadListString(List<string> list, int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0400234C RID: 9036
		private static readonly IntPtr NativeFieldInfoPtr_getCursorIdFunc;

		// Token: 0x0400234D RID: 9037
		private static readonly IntPtr NativeFieldInfoPtr_m_Values;

		// Token: 0x0400234E RID: 9038
		private static readonly IntPtr NativeFieldInfoPtr_m_ValueCount;

		// Token: 0x0400234F RID: 9039
		private static readonly IntPtr NativeFieldInfoPtr_m_Resolver;

		// Token: 0x04002350 RID: 9040
		private static readonly IntPtr NativeFieldInfoPtr_m_Sheet;

		// Token: 0x04002351 RID: 9041
		private static readonly IntPtr NativeFieldInfoPtr_m_Properties;

		// Token: 0x04002352 RID: 9042
		private static readonly IntPtr NativeFieldInfoPtr_m_PropertyIds;

		// Token: 0x04002353 RID: 9043
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentValueIndex;

		// Token: 0x04002354 RID: 9044
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentPropertyIndex;

		// Token: 0x04002355 RID: 9045
		private static readonly IntPtr NativeFieldInfoPtr__property_k__BackingField;

		// Token: 0x04002356 RID: 9046
		private static readonly IntPtr NativeFieldInfoPtr__propertyId_k__BackingField;

		// Token: 0x04002357 RID: 9047
		private static readonly IntPtr NativeFieldInfoPtr__valueCount_k__BackingField;

		// Token: 0x04002358 RID: 9048
		private static readonly IntPtr NativeFieldInfoPtr__dpiScaling_k__BackingField;

		// Token: 0x04002359 RID: 9049
		private static readonly IntPtr NativeMethodInfoPtr_get_property_Public_get_StyleProperty_0;

		// Token: 0x0400235A RID: 9050
		private static readonly IntPtr NativeMethodInfoPtr_set_property_Private_set_Void_StyleProperty_0;

		// Token: 0x0400235B RID: 9051
		private static readonly IntPtr NativeMethodInfoPtr_get_propertyId_Public_get_StylePropertyId_0;

		// Token: 0x0400235C RID: 9052
		private static readonly IntPtr NativeMethodInfoPtr_set_propertyId_Private_set_Void_StylePropertyId_0;

		// Token: 0x0400235D RID: 9053
		private static readonly IntPtr NativeMethodInfoPtr_get_valueCount_Public_get_Int32_0;

		// Token: 0x0400235E RID: 9054
		private static readonly IntPtr NativeMethodInfoPtr_set_valueCount_Private_set_Void_Int32_0;

		// Token: 0x0400235F RID: 9055
		private static readonly IntPtr NativeMethodInfoPtr_get_dpiScaling_Public_get_Single_0;

		// Token: 0x04002360 RID: 9056
		private static readonly IntPtr NativeMethodInfoPtr_set_dpiScaling_Private_set_Void_Single_0;

		// Token: 0x04002361 RID: 9057
		private static readonly IntPtr NativeMethodInfoPtr_SetContext_Public_Void_StyleSheet_StyleComplexSelector_StyleVariableContext_Single_0;

		// Token: 0x04002362 RID: 9058
		private static readonly IntPtr NativeMethodInfoPtr_SetInlineContext_Public_Void_StyleSheet_Il2CppReferenceArray_1_StyleProperty_Il2CppStructArray_1_StylePropertyId_Single_0;

		// Token: 0x04002363 RID: 9059
		private static readonly IntPtr NativeMethodInfoPtr_MoveNextProperty_Public_StylePropertyId_0;

		// Token: 0x04002364 RID: 9060
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_StylePropertyValue_Int32_0;

		// Token: 0x04002365 RID: 9061
		private static readonly IntPtr NativeMethodInfoPtr_GetValueType_Public_StyleValueType_Int32_0;

		// Token: 0x04002366 RID: 9062
		private static readonly IntPtr NativeMethodInfoPtr_IsValueType_Public_Boolean_Int32_StyleValueType_0;

		// Token: 0x04002367 RID: 9063
		private static readonly IntPtr NativeMethodInfoPtr_IsKeyword_Public_Boolean_Int32_StyleValueKeyword_0;

		// Token: 0x04002368 RID: 9064
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsString_Public_String_Int32_0;

		// Token: 0x04002369 RID: 9065
		private static readonly IntPtr NativeMethodInfoPtr_ReadLength_Public_Length_Int32_0;

		// Token: 0x0400236A RID: 9066
		private static readonly IntPtr NativeMethodInfoPtr_ReadTimeValue_Public_TimeValue_Int32_0;

		// Token: 0x0400236B RID: 9067
		private static readonly IntPtr NativeMethodInfoPtr_ReadTranslate_Public_Translate_Int32_0;

		// Token: 0x0400236C RID: 9068
		private static readonly IntPtr NativeMethodInfoPtr_ReadTransformOrigin_Public_TransformOrigin_Int32_0;

		// Token: 0x0400236D RID: 9069
		private static readonly IntPtr NativeMethodInfoPtr_ReadRotate_Public_Rotate_Int32_0;

		// Token: 0x0400236E RID: 9070
		private static readonly IntPtr NativeMethodInfoPtr_ReadScale_Public_Scale_Int32_0;

		// Token: 0x0400236F RID: 9071
		private static readonly IntPtr NativeMethodInfoPtr_ReadFloat_Public_Single_Int32_0;

		// Token: 0x04002370 RID: 9072
		private static readonly IntPtr NativeMethodInfoPtr_ReadInt_Public_Int32_Int32_0;

		// Token: 0x04002371 RID: 9073
		private static readonly IntPtr NativeMethodInfoPtr_ReadColor_Public_Color_Int32_0;

		// Token: 0x04002372 RID: 9074
		private static readonly IntPtr NativeMethodInfoPtr_ReadEnum_Public_Int32_StyleEnumType_Int32_0;

		// Token: 0x04002373 RID: 9075
		private static readonly IntPtr NativeMethodInfoPtr_ReadFontDefinition_Public_FontDefinition_Int32_0;

		// Token: 0x04002374 RID: 9076
		private static readonly IntPtr NativeMethodInfoPtr_ReadFont_Public_Font_Int32_0;

		// Token: 0x04002375 RID: 9077
		private static readonly IntPtr NativeMethodInfoPtr_ReadBackground_Public_Background_Int32_0;

		// Token: 0x04002376 RID: 9078
		private static readonly IntPtr NativeMethodInfoPtr_ReadCursor_Public_Cursor_Int32_0;

		// Token: 0x04002377 RID: 9079
		private static readonly IntPtr NativeMethodInfoPtr_ReadTextShadow_Public_TextShadow_Int32_0;

		// Token: 0x04002378 RID: 9080
		private static readonly IntPtr NativeMethodInfoPtr_ReadBackgroundPositionX_Public_BackgroundPosition_Int32_0;

		// Token: 0x04002379 RID: 9081
		private static readonly IntPtr NativeMethodInfoPtr_ReadBackgroundPositionY_Public_BackgroundPosition_Int32_0;

		// Token: 0x0400237A RID: 9082
		private static readonly IntPtr NativeMethodInfoPtr_ReadBackgroundPosition_Private_BackgroundPosition_Int32_BackgroundPositionKeyword_0;

		// Token: 0x0400237B RID: 9083
		private static readonly IntPtr NativeMethodInfoPtr_ReadBackgroundRepeat_Public_BackgroundRepeat_Int32_0;

		// Token: 0x0400237C RID: 9084
		private static readonly IntPtr NativeMethodInfoPtr_ReadBackgroundSize_Public_BackgroundSize_Int32_0;

		// Token: 0x0400237D RID: 9085
		private static readonly IntPtr NativeMethodInfoPtr_ReadListEasingFunction_Public_Void_List_1_EasingFunction_Int32_0;

		// Token: 0x0400237E RID: 9086
		private static readonly IntPtr NativeMethodInfoPtr_ReadListTimeValue_Public_Void_List_1_TimeValue_Int32_0;

		// Token: 0x0400237F RID: 9087
		private static readonly IntPtr NativeMethodInfoPtr_ReadListStylePropertyName_Public_Void_List_1_StylePropertyName_Int32_0;

		// Token: 0x04002380 RID: 9088
		private static readonly IntPtr NativeMethodInfoPtr_LoadProperties_Private_Void_0;

		// Token: 0x04002381 RID: 9089
		private static readonly IntPtr NativeMethodInfoPtr_SetCurrentProperty_Private_Void_0;

		// Token: 0x04002382 RID: 9090
		private static readonly IntPtr NativeMethodInfoPtr_ReadTransformOrigin_Public_Static_TransformOrigin_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue_0;

		// Token: 0x04002383 RID: 9091
		private static readonly IntPtr NativeMethodInfoPtr_ReadTransformOriginEnum_Private_Static_Length_StylePropertyValue_byref_Boolean_byref_Boolean_0;

		// Token: 0x04002384 RID: 9092
		private static readonly IntPtr NativeMethodInfoPtr_ReadTranslate_Public_Static_Translate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue_0;

		// Token: 0x04002385 RID: 9093
		private static readonly IntPtr NativeMethodInfoPtr_ReadScale_Public_Static_Scale_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue_0;

		// Token: 0x04002386 RID: 9094
		private static readonly IntPtr NativeMethodInfoPtr_ReadRotate_Public_Static_Rotate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue_StylePropertyValue_0;

		// Token: 0x04002387 RID: 9095
		private static readonly IntPtr NativeMethodInfoPtr_TryReadEnum_Private_Static_Boolean_StyleEnumType_StylePropertyValue_byref_Int32_0;

		// Token: 0x04002388 RID: 9096
		private static readonly IntPtr NativeMethodInfoPtr_ReadEnum_Private_Static_Int32_StyleEnumType_StylePropertyValue_0;

		// Token: 0x04002389 RID: 9097
		private static readonly IntPtr NativeMethodInfoPtr_ReadAngle_Public_Static_Angle_StylePropertyValue_0;

		// Token: 0x0400238A RID: 9098
		private static readonly IntPtr NativeMethodInfoPtr_ReadBackgroundPosition_Public_Static_BackgroundPosition_Int32_StylePropertyValue_StylePropertyValue_BackgroundPositionKeyword_0;

		// Token: 0x0400238B RID: 9099
		private static readonly IntPtr NativeMethodInfoPtr_ReadBackgroundRepeat_Public_Static_BackgroundRepeat_Int32_StylePropertyValue_StylePropertyValue_0;

		// Token: 0x0400238C RID: 9100
		private static readonly IntPtr NativeMethodInfoPtr_ReadBackgroundSize_Public_Static_BackgroundSize_Int32_StylePropertyValue_StylePropertyValue_0;

		// Token: 0x0400238D RID: 9101
		private static readonly IntPtr NativeMethodInfoPtr_TryGetImageSourceFromValue_Internal_Static_Boolean_StylePropertyValue_Single_byref_ImageSource_0;

		// Token: 0x0400238E RID: 9102
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000566 RID: 1382
		public sealed class GetCursorIdFunction : MulticastDelegate
		{
			// Token: 0x0600423D RID: 16957 RVA: 0x0001C4AD File Offset: 0x0001A6AD
			// Note: this type is marked as 'beforefieldinit'.
			static GetCursorIdFunction()
			{
				Il2CppClassPointerStore<StylePropertyReader.GetCursorIdFunction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StylePropertyReader>.NativeClassPtr, "GetCursorIdFunction");
				StylePropertyReader.GetCursorIdFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader.GetCursorIdFunction>.NativeClassPtr, 100670367);
				StylePropertyReader.GetCursorIdFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_StyleSheet_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyReader.GetCursorIdFunction>.NativeClassPtr, 100670368);
			}

			// Token: 0x0600423E RID: 16958 RVA: 0x00104218 File Offset: 0x00102418
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357455, XrefRangeEnd = 357464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GetCursorIdFunction(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyReader.GetCursorIdFunction>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.GetCursorIdFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600423F RID: 16959 RVA: 0x00104274 File Offset: 0x00102474
			[CallerCount(0)]
			public unsafe int Invoke(StyleSheet sheet, StyleValueHandle handle)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sheet);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyReader.GetCursorIdFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_StyleSheet_StyleValueHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004240 RID: 16960 RVA: 0x0001C4EB File Offset: 0x0001A6EB
			public GetCursorIdFunction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004241 RID: 16961 RVA: 0x0001C4F4 File Offset: 0x0001A6F4
			public static implicit operator StylePropertyReader.GetCursorIdFunction(Func<StyleSheet, StyleValueHandle, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<StylePropertyReader.GetCursorIdFunction>(A_0);
			}

			// Token: 0x06004242 RID: 16962 RVA: 0x0001C4FC File Offset: 0x0001A6FC
			public static StylePropertyReader.GetCursorIdFunction operator +(StylePropertyReader.GetCursorIdFunction A_0, StylePropertyReader.GetCursorIdFunction A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<StylePropertyReader.GetCursorIdFunction>();
			}

			// Token: 0x06004243 RID: 16963 RVA: 0x0001C50A File Offset: 0x0001A70A
			public static StylePropertyReader.GetCursorIdFunction operator -(StylePropertyReader.GetCursorIdFunction A_0, StylePropertyReader.GetCursorIdFunction A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<StylePropertyReader.GetCursorIdFunction>();
				}
				return delegate2;
			}

			// Token: 0x04002E73 RID: 11891
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002E74 RID: 11892
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_StyleSheet_StyleValueHandle_0;
		}
	}
}
