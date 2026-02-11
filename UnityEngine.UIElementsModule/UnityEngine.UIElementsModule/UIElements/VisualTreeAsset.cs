using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.UIElements
{
	// Token: 0x02000216 RID: 534
	[Serializable]
	public class VisualTreeAsset : ScriptableObject
	{
		// Token: 0x06002892 RID: 10386 RVA: 0x000B1F48 File Offset: 0x000B0148
		// Note: this type is marked as 'beforefieldinit'.
		static VisualTreeAsset()
		{
			Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "VisualTreeAsset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr);
			VisualTreeAsset.NativeFieldInfoPtr_LinkedVEAInTemplatePropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, "LinkedVEAInTemplatePropertyName");
			VisualTreeAsset.NativeFieldInfoPtr_m_ImportedWithErrors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, "m_ImportedWithErrors");
			VisualTreeAsset.NativeFieldInfoPtr_m_ImportedWithWarnings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, "m_ImportedWithWarnings");
			VisualTreeAsset.NativeFieldInfoPtr_s_TemporarySlotInsertionPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, "s_TemporarySlotInsertionPoints");
			VisualTreeAsset.NativeFieldInfoPtr_m_Usings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, "m_Usings");
			VisualTreeAsset.NativeFieldInfoPtr_inlineSheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, "inlineSheet");
			VisualTreeAsset.NativeFieldInfoPtr_m_VisualElementAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, "m_VisualElementAssets");
			VisualTreeAsset.NativeFieldInfoPtr_m_TemplateAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, "m_TemplateAssets");
			VisualTreeAsset.NativeFieldInfoPtr_m_UxmlObjectEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, "m_UxmlObjectEntries");
			VisualTreeAsset.NativeFieldInfoPtr_m_UxmlObjectIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, "m_UxmlObjectIds");
			VisualTreeAsset.NativeFieldInfoPtr_m_AssetEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, "m_AssetEntries");
			VisualTreeAsset.NativeFieldInfoPtr_m_Slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, "m_Slots");
			VisualTreeAsset.NativeFieldInfoPtr_m_ContentContainerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, "m_ContentContainerId");
			VisualTreeAsset.NativeFieldInfoPtr_m_ContentHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, "m_ContentHash");
			VisualTreeAsset.NativeMethodInfoPtr_get_importedWithErrors_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669374);
			VisualTreeAsset.NativeMethodInfoPtr_set_importedWithErrors_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669375);
			VisualTreeAsset.NativeMethodInfoPtr_get_importedWithWarnings_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669376);
			VisualTreeAsset.NativeMethodInfoPtr_set_importedWithWarnings_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669377);
			VisualTreeAsset.NativeMethodInfoPtr_GetNextChildSerialNumber_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669378);
			VisualTreeAsset.NativeMethodInfoPtr_get_templateDependencies_Public_get_IEnumerable_1_VisualTreeAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669379);
			VisualTreeAsset.NativeMethodInfoPtr_get_stylesheets_Public_get_IEnumerable_1_StyleSheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669380);
			VisualTreeAsset.NativeMethodInfoPtr_get_visualElementAssets_Internal_get_List_1_VisualElementAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669381);
			VisualTreeAsset.NativeMethodInfoPtr_set_visualElementAssets_Internal_set_Void_List_1_VisualElementAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669382);
			VisualTreeAsset.NativeMethodInfoPtr_get_templateAssets_Internal_get_List_1_TemplateAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669383);
			VisualTreeAsset.NativeMethodInfoPtr_set_templateAssets_Internal_set_Void_List_1_TemplateAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669384);
			VisualTreeAsset.NativeMethodInfoPtr_get_uxmlObjectEntries_Internal_get_List_1_UxmlObjectEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669385);
			VisualTreeAsset.NativeMethodInfoPtr_get_uxmlObjectIds_Internal_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669386);
			VisualTreeAsset.NativeMethodInfoPtr_RegisterUxmlObject_Internal_Void_UxmlObjectAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669387);
			VisualTreeAsset.NativeMethodInfoPtr_GetUxmlObjects_Internal_List_1_T_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669388);
			VisualTreeAsset.NativeMethodInfoPtr_AssetEntryExists_Internal_Boolean_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669389);
			VisualTreeAsset.NativeMethodInfoPtr_RegisterAssetEntry_Internal_Void_String_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669390);
			VisualTreeAsset.NativeMethodInfoPtr_GetAsset_Internal_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669391);
			VisualTreeAsset.NativeMethodInfoPtr_GetUxmlObjectEntry_Internal_UxmlObjectEntry_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669392);
			VisualTreeAsset.NativeMethodInfoPtr_GetUxmlObjectFactory_Private_IBaseUxmlObjectFactory_UxmlObjectAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669393);
			VisualTreeAsset.NativeMethodInfoPtr_get_slots_Internal_get_List_1_SlotDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669394);
			VisualTreeAsset.NativeMethodInfoPtr_set_slots_Internal_set_Void_List_1_SlotDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669395);
			VisualTreeAsset.NativeMethodInfoPtr_get_contentContainerId_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669396);
			VisualTreeAsset.NativeMethodInfoPtr_set_contentContainerId_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669397);
			VisualTreeAsset.NativeMethodInfoPtr_Instantiate_Public_TemplateContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669398);
			VisualTreeAsset.NativeMethodInfoPtr_Instantiate_Public_TemplateContainer_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669399);
			VisualTreeAsset.NativeMethodInfoPtr_CloneTree_Public_TemplateContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669400);
			VisualTreeAsset.NativeMethodInfoPtr_CloneTree_Public_TemplateContainer_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669401);
			VisualTreeAsset.NativeMethodInfoPtr_CloneTree_Public_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669402);
			VisualTreeAsset.NativeMethodInfoPtr_CloneTree_Public_Void_VisualElement_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669403);
			VisualTreeAsset.NativeMethodInfoPtr_CloneTree_Internal_Void_VisualElement_Dictionary_2_String_VisualElement_List_1_AttributeOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669404);
			VisualTreeAsset.NativeMethodInfoPtr_CloneSetupRecursively_Private_VisualElement_VisualElementAsset_Dictionary_2_Int32_List_1_VisualElementAsset_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669405);
			VisualTreeAsset.NativeMethodInfoPtr_CompareForOrder_Private_Static_Int32_VisualElementAsset_VisualElementAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669406);
			VisualTreeAsset.NativeMethodInfoPtr_TryGetSlotInsertionPoint_Internal_Boolean_Int32_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669407);
			VisualTreeAsset.NativeMethodInfoPtr_ResolveTemplate_Internal_VisualTreeAsset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669408);
			VisualTreeAsset.NativeMethodInfoPtr_Create_Internal_Static_VisualElement_VisualElementAsset_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669409);
			VisualTreeAsset.NativeMethodInfoPtr_AssignClassListFromAssetToElement_Private_Static_Void_VisualElementAsset_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669410);
			VisualTreeAsset.NativeMethodInfoPtr_AssignStyleSheetFromAssetToElement_Private_Static_Void_VisualElementAsset_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669411);
			VisualTreeAsset.NativeMethodInfoPtr_get_contentHash_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669412);
			VisualTreeAsset.NativeMethodInfoPtr_set_contentHash_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669413);
			VisualTreeAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669414);
			VisualTreeAsset.NativeMethodInfoPtr_Method_Internal_Static_VisualElement_byref___c__DisplayClass65_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, 100669416);
		}

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x06002893 RID: 10387 RVA: 0x000B23D8 File Offset: 0x000B05D8
		// (set) Token: 0x06002894 RID: 10388 RVA: 0x000B2414 File Offset: 0x000B0614
		public unsafe bool importedWithErrors
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_get_importedWithErrors_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_set_importedWithErrors_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x06002895 RID: 10389 RVA: 0x000B2454 File Offset: 0x000B0654
		// (set) Token: 0x06002896 RID: 10390 RVA: 0x000B2490 File Offset: 0x000B0690
		public unsafe bool importedWithWarnings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_get_importedWithWarnings_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_set_importedWithWarnings_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002897 RID: 10391 RVA: 0x000B24D0 File Offset: 0x000B06D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345253, XrefRangeEnd = 345258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetNextChildSerialNumber()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_GetNextChildSerialNumber_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x06002898 RID: 10392 RVA: 0x000B250C File Offset: 0x000B070C
		public unsafe IEnumerable<VisualTreeAsset> templateDependencies
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345258, XrefRangeEnd = 345264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_get_templateDependencies_Public_get_IEnumerable_1_VisualTreeAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<VisualTreeAsset>>(intPtr3) : null;
			}
		}

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x06002899 RID: 10393 RVA: 0x000B254C File Offset: 0x000B074C
		public unsafe IEnumerable<StyleSheet> stylesheets
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345264, XrefRangeEnd = 345270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_get_stylesheets_Public_get_IEnumerable_1_StyleSheet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<StyleSheet>>(intPtr3) : null;
			}
		}

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x0600289A RID: 10394 RVA: 0x000B258C File Offset: 0x000B078C
		// (set) Token: 0x0600289B RID: 10395 RVA: 0x000B25CC File Offset: 0x000B07CC
		public unsafe List<VisualElementAsset> visualElementAssets
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_get_visualElementAssets_Internal_get_List_1_VisualElementAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<VisualElementAsset>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345270, XrefRangeEnd = 345271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_set_visualElementAssets_Internal_set_Void_List_1_VisualElementAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x0600289C RID: 10396 RVA: 0x000B2610 File Offset: 0x000B0810
		// (set) Token: 0x0600289D RID: 10397 RVA: 0x000B2650 File Offset: 0x000B0850
		public unsafe List<TemplateAsset> templateAssets
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 285338, RefRangeEnd = 285365, XrefRangeStart = 285338, XrefRangeEnd = 285365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_get_templateAssets_Internal_get_List_1_TemplateAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TemplateAsset>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_set_templateAssets_Internal_set_Void_List_1_TemplateAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x0600289E RID: 10398 RVA: 0x000B2694 File Offset: 0x000B0894
		public unsafe List<VisualTreeAsset.UxmlObjectEntry> uxmlObjectEntries
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_get_uxmlObjectEntries_Internal_get_List_1_UxmlObjectEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<VisualTreeAsset.UxmlObjectEntry>>(intPtr3) : null;
			}
		}

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x0600289F RID: 10399 RVA: 0x000B26D4 File Offset: 0x000B08D4
		public unsafe List<int> uxmlObjectIds
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_get_uxmlObjectIds_Internal_get_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}
		}

		// Token: 0x060028A0 RID: 10400 RVA: 0x000B2714 File Offset: 0x000B0914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345271, XrefRangeEnd = 345304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterUxmlObject(UxmlObjectAsset uxmlObjectAsset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uxmlObjectAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_RegisterUxmlObject_Internal_Void_UxmlObjectAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028A1 RID: 10401 RVA: 0x000B2758 File Offset: 0x000B0958
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 345335, RefRangeEnd = 345337, XrefRangeStart = 345304, XrefRangeEnd = 345335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<T> GetUxmlObjects<T>(IUxmlAttributes asset, CreationContext cc) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cc));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.MethodInfoStoreGeneric_GetUxmlObjects_Internal_List_1_T_IUxmlAttributes_CreationContext_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
		}

		// Token: 0x060028A2 RID: 10402 RVA: 0x000B27C0 File Offset: 0x000B09C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345337, XrefRangeEnd = 345359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AssetEntryExists(string path, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_AssetEntryExists_Internal_Boolean_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028A3 RID: 10403 RVA: 0x000B2820 File Offset: 0x000B0A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345359, XrefRangeEnd = 345373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterAssetEntry(string path, Type type, Object asset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_RegisterAssetEntry_Internal_Void_String_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028A4 RID: 10404 RVA: 0x000B2888 File Offset: 0x000B0A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345373, XrefRangeEnd = 345401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetAsset<T>(string path) where T : Object
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.MethodInfoStoreGeneric_GetAsset_Internal_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060028A5 RID: 10405 RVA: 0x000B28D4 File Offset: 0x000B0AD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 345417, RefRangeEnd = 345419, XrefRangeStart = 345401, XrefRangeEnd = 345417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisualTreeAsset.UxmlObjectEntry GetUxmlObjectEntry(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_GetUxmlObjectEntry_Internal_UxmlObjectEntry_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new VisualTreeAsset.UxmlObjectEntry(intPtr);
			}
		}

		// Token: 0x060028A6 RID: 10406 RVA: 0x000B2918 File Offset: 0x000B0B18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 345474, RefRangeEnd = 345475, XrefRangeStart = 345419, XrefRangeEnd = 345474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IBaseUxmlObjectFactory GetUxmlObjectFactory(UxmlObjectAsset uxmlObjectAsset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uxmlObjectAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_GetUxmlObjectFactory_Private_IBaseUxmlObjectFactory_UxmlObjectAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IBaseUxmlObjectFactory>(intPtr3) : null;
			}
		}

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x060028A7 RID: 10407 RVA: 0x000B2968 File Offset: 0x000B0B68
		// (set) Token: 0x060028A8 RID: 10408 RVA: 0x000B29A8 File Offset: 0x000B0BA8
		public unsafe List<VisualTreeAsset.SlotDefinition> slots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_get_slots_Internal_get_List_1_SlotDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<VisualTreeAsset.SlotDefinition>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_set_slots_Internal_set_Void_List_1_SlotDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x060028A9 RID: 10409 RVA: 0x000B29EC File Offset: 0x000B0BEC
		// (set) Token: 0x060028AA RID: 10410 RVA: 0x000B2A28 File Offset: 0x000B0C28
		public unsafe int contentContainerId
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 330123, RefRangeEnd = 330145, XrefRangeStart = 330123, XrefRangeEnd = 330145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_get_contentContainerId_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 312518, RefRangeEnd = 312534, XrefRangeStart = 312518, XrefRangeEnd = 312534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_set_contentContainerId_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060028AB RID: 10411 RVA: 0x000B2A68 File Offset: 0x000B0C68
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 345493, RefRangeEnd = 345497, XrefRangeStart = 345475, XrefRangeEnd = 345493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TemplateContainer Instantiate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_Instantiate_Public_TemplateContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TemplateContainer>(intPtr3) : null;
		}

		// Token: 0x060028AC RID: 10412 RVA: 0x000B2AA8 File Offset: 0x000B0CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345497, XrefRangeEnd = 345499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TemplateContainer Instantiate(string bindingPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(bindingPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_Instantiate_Public_TemplateContainer_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TemplateContainer>(intPtr3) : null;
			}
		}

		// Token: 0x060028AD RID: 10413 RVA: 0x000B2AF8 File Offset: 0x000B0CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345499, XrefRangeEnd = 345500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TemplateContainer CloneTree()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_CloneTree_Public_TemplateContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TemplateContainer>(intPtr3) : null;
		}

		// Token: 0x060028AE RID: 10414 RVA: 0x000B2B38 File Offset: 0x000B0D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TemplateContainer CloneTree(string bindingPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(bindingPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_CloneTree_Public_TemplateContainer_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TemplateContainer>(intPtr3) : null;
			}
		}

		// Token: 0x060028AF RID: 10415 RVA: 0x000B2B88 File Offset: 0x000B0D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345500, XrefRangeEnd = 345501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloneTree(VisualElement target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_CloneTree_Public_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028B0 RID: 10416 RVA: 0x000B2BCC File Offset: 0x000B0DCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 345511, RefRangeEnd = 345512, XrefRangeStart = 345501, XrefRangeEnd = 345511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloneTree(VisualElement target, out int firstElementIndex, out int elementAddedCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &firstElementIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &elementAddedCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_CloneTree_Public_Void_VisualElement_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028B1 RID: 10417 RVA: 0x000B2C2C File Offset: 0x000B0E2C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 345607, RefRangeEnd = 345610, XrefRangeStart = 345512, XrefRangeEnd = 345607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloneTree(VisualElement target, Dictionary<string, VisualElement> slotInsertionPoints, List<TemplateAsset.AttributeOverride> attributeOverrides)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(slotInsertionPoints);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeOverrides);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_CloneTree_Internal_Void_VisualElement_Dictionary_2_String_VisualElement_List_1_AttributeOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028B2 RID: 10418 RVA: 0x000B2C94 File Offset: 0x000B0E94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 345774, RefRangeEnd = 345776, XrefRangeStart = 345610, XrefRangeEnd = 345774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisualElement CloneSetupRecursively(VisualElementAsset root, Dictionary<int, List<VisualElementAsset>> idToChildren, CreationContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(idToChildren);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_CloneSetupRecursively_Private_VisualElement_VisualElementAsset_Dictionary_2_Int32_List_1_VisualElementAsset_CreationContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
		}

		// Token: 0x060028B3 RID: 10419 RVA: 0x000B2D10 File Offset: 0x000B0F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345776, XrefRangeEnd = 345777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompareForOrder(VisualElementAsset a, VisualElementAsset b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_CompareForOrder_Private_Static_Int32_VisualElementAsset_VisualElementAsset_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028B4 RID: 10420 RVA: 0x000B2D64 File Offset: 0x000B0F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345777, XrefRangeEnd = 345785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetSlotInsertionPoint(int insertionPointId, out string slotName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref insertionPointId;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_TryGetSlotInsertionPoint_Internal_Boolean_Int32_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			slotName = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060028B5 RID: 10421 RVA: 0x000B2DC8 File Offset: 0x000B0FC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 345828, RefRangeEnd = 345831, XrefRangeStart = 345785, XrefRangeEnd = 345828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisualTreeAsset ResolveTemplate(string templateName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(templateName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_ResolveTemplate_Internal_VisualTreeAsset_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualTreeAsset>(intPtr3) : null;
			}
		}

		// Token: 0x060028B6 RID: 10422 RVA: 0x000B2E18 File Offset: 0x000B1018
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 345927, RefRangeEnd = 345928, XrefRangeStart = 345831, XrefRangeEnd = 345927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VisualElement Create(VisualElementAsset asset, CreationContext ctx)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_Create_Internal_Static_VisualElement_VisualElementAsset_CreationContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
		}

		// Token: 0x060028B7 RID: 10423 RVA: 0x000B2E74 File Offset: 0x000B1074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345928, XrefRangeEnd = 345930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AssignClassListFromAssetToElement(VisualElementAsset asset, VisualElement element)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(element);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_AssignClassListFromAssetToElement_Private_Static_Void_VisualElementAsset_VisualElement_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028B8 RID: 10424 RVA: 0x000B2EBC File Offset: 0x000B10BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 345978, RefRangeEnd = 345980, XrefRangeStart = 345930, XrefRangeEnd = 345978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AssignStyleSheetFromAssetToElement(VisualElementAsset asset, VisualElement element)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(element);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_AssignStyleSheetFromAssetToElement_Private_Static_Void_VisualElementAsset_VisualElement_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x060028B9 RID: 10425 RVA: 0x000B2F04 File Offset: 0x000B1104
		// (set) Token: 0x060028BA RID: 10426 RVA: 0x000B2F40 File Offset: 0x000B1140
		public unsafe int contentHash
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 345980, RefRangeEnd = 345981, XrefRangeStart = 345980, XrefRangeEnd = 345980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_get_contentHash_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 345981, RefRangeEnd = 345986, XrefRangeStart = 345981, XrefRangeEnd = 345981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_set_contentHash_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060028BB RID: 10427 RVA: 0x000B2F80 File Offset: 0x000B1180
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 338035, RefRangeEnd = 338045, XrefRangeStart = 338035, XrefRangeEnd = 338045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisualTreeAsset()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028BC RID: 10428 RVA: 0x000B2FBC File Offset: 0x000B11BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 346004, RefRangeEnd = 346006, XrefRangeStart = 345986, XrefRangeEnd = 346004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VisualElement Method_Internal_Static_VisualElement_byref___c__DisplayClass65_0_0(ref VisualTreeAsset.__c__DisplayClass65_0 A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.NativeMethodInfoPtr_Method_Internal_Static_VisualElement_byref___c__DisplayClass65_0_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x060028BD RID: 10429 RVA: 0x0001060F File Offset: 0x0000E80F
		public VisualTreeAsset(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x060028BE RID: 10430 RVA: 0x000B3004 File Offset: 0x000B1204
		// (set) Token: 0x060028BF RID: 10431 RVA: 0x00010618 File Offset: 0x0000E818
		public unsafe static string LinkedVEAInTemplatePropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VisualTreeAsset.NativeFieldInfoPtr_LinkedVEAInTemplatePropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualTreeAsset.NativeFieldInfoPtr_LinkedVEAInTemplatePropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x060028C0 RID: 10432 RVA: 0x000B3024 File Offset: 0x000B1224
		// (set) Token: 0x060028C1 RID: 10433 RVA: 0x0001062A File Offset: 0x0000E82A
		public unsafe bool m_ImportedWithErrors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.NativeFieldInfoPtr_m_ImportedWithErrors);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.NativeFieldInfoPtr_m_ImportedWithErrors)) = value;
			}
		}

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x060028C2 RID: 10434 RVA: 0x000B304C File Offset: 0x000B124C
		// (set) Token: 0x060028C3 RID: 10435 RVA: 0x00010645 File Offset: 0x0000E845
		public unsafe bool m_ImportedWithWarnings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.NativeFieldInfoPtr_m_ImportedWithWarnings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.NativeFieldInfoPtr_m_ImportedWithWarnings)) = value;
			}
		}

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x060028C4 RID: 10436 RVA: 0x000B3074 File Offset: 0x000B1274
		// (set) Token: 0x060028C5 RID: 10437 RVA: 0x00010660 File Offset: 0x0000E860
		public unsafe static Dictionary<string, VisualElement> s_TemporarySlotInsertionPoints
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VisualTreeAsset.NativeFieldInfoPtr_s_TemporarySlotInsertionPoints, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, VisualElement>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualTreeAsset.NativeFieldInfoPtr_s_TemporarySlotInsertionPoints, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x060028C6 RID: 10438 RVA: 0x000B309C File Offset: 0x000B129C
		// (set) Token: 0x060028C7 RID: 10439 RVA: 0x00010672 File Offset: 0x0000E872
		public unsafe List<VisualTreeAsset.UsingEntry> m_Usings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.NativeFieldInfoPtr_m_Usings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VisualTreeAsset.UsingEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.NativeFieldInfoPtr_m_Usings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x060028C8 RID: 10440 RVA: 0x000B30CC File Offset: 0x000B12CC
		// (set) Token: 0x060028C9 RID: 10441 RVA: 0x00010691 File Offset: 0x0000E891
		public unsafe StyleSheet inlineSheet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.NativeFieldInfoPtr_inlineSheet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleSheet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.NativeFieldInfoPtr_inlineSheet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x060028CA RID: 10442 RVA: 0x000B30FC File Offset: 0x000B12FC
		// (set) Token: 0x060028CB RID: 10443 RVA: 0x000106B0 File Offset: 0x0000E8B0
		public unsafe List<VisualElementAsset> m_VisualElementAssets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.NativeFieldInfoPtr_m_VisualElementAssets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VisualElementAsset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.NativeFieldInfoPtr_m_VisualElementAssets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x060028CC RID: 10444 RVA: 0x000B312C File Offset: 0x000B132C
		// (set) Token: 0x060028CD RID: 10445 RVA: 0x000106CF File Offset: 0x0000E8CF
		public unsafe List<TemplateAsset> m_TemplateAssets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.NativeFieldInfoPtr_m_TemplateAssets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TemplateAsset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.NativeFieldInfoPtr_m_TemplateAssets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x060028CE RID: 10446 RVA: 0x000B315C File Offset: 0x000B135C
		// (set) Token: 0x060028CF RID: 10447 RVA: 0x000106EE File Offset: 0x0000E8EE
		public unsafe List<VisualTreeAsset.UxmlObjectEntry> m_UxmlObjectEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.NativeFieldInfoPtr_m_UxmlObjectEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VisualTreeAsset.UxmlObjectEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.NativeFieldInfoPtr_m_UxmlObjectEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x060028D0 RID: 10448 RVA: 0x000B318C File Offset: 0x000B138C
		// (set) Token: 0x060028D1 RID: 10449 RVA: 0x0001070D File Offset: 0x0000E90D
		public unsafe List<int> m_UxmlObjectIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.NativeFieldInfoPtr_m_UxmlObjectIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.NativeFieldInfoPtr_m_UxmlObjectIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x060028D2 RID: 10450 RVA: 0x000B31BC File Offset: 0x000B13BC
		// (set) Token: 0x060028D3 RID: 10451 RVA: 0x0001072C File Offset: 0x0000E92C
		public unsafe List<VisualTreeAsset.AssetEntry> m_AssetEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.NativeFieldInfoPtr_m_AssetEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VisualTreeAsset.AssetEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.NativeFieldInfoPtr_m_AssetEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x060028D4 RID: 10452 RVA: 0x000B31EC File Offset: 0x000B13EC
		// (set) Token: 0x060028D5 RID: 10453 RVA: 0x0001074B File Offset: 0x0000E94B
		public unsafe List<VisualTreeAsset.SlotDefinition> m_Slots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.NativeFieldInfoPtr_m_Slots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VisualTreeAsset.SlotDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.NativeFieldInfoPtr_m_Slots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x060028D6 RID: 10454 RVA: 0x000B321C File Offset: 0x000B141C
		// (set) Token: 0x060028D7 RID: 10455 RVA: 0x0001076A File Offset: 0x0000E96A
		public unsafe int m_ContentContainerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.NativeFieldInfoPtr_m_ContentContainerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.NativeFieldInfoPtr_m_ContentContainerId)) = value;
			}
		}

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x060028D8 RID: 10456 RVA: 0x000B3244 File Offset: 0x000B1444
		// (set) Token: 0x060028D9 RID: 10457 RVA: 0x00010785 File Offset: 0x0000E985
		public unsafe int m_ContentHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.NativeFieldInfoPtr_m_ContentHash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.NativeFieldInfoPtr_m_ContentHash)) = value;
			}
		}

		// Token: 0x04001CA4 RID: 7332
		private static readonly IntPtr NativeFieldInfoPtr_LinkedVEAInTemplatePropertyName;

		// Token: 0x04001CA5 RID: 7333
		private static readonly IntPtr NativeFieldInfoPtr_m_ImportedWithErrors;

		// Token: 0x04001CA6 RID: 7334
		private static readonly IntPtr NativeFieldInfoPtr_m_ImportedWithWarnings;

		// Token: 0x04001CA7 RID: 7335
		private static readonly IntPtr NativeFieldInfoPtr_s_TemporarySlotInsertionPoints;

		// Token: 0x04001CA8 RID: 7336
		private static readonly IntPtr NativeFieldInfoPtr_m_Usings;

		// Token: 0x04001CA9 RID: 7337
		private static readonly IntPtr NativeFieldInfoPtr_inlineSheet;

		// Token: 0x04001CAA RID: 7338
		private static readonly IntPtr NativeFieldInfoPtr_m_VisualElementAssets;

		// Token: 0x04001CAB RID: 7339
		private static readonly IntPtr NativeFieldInfoPtr_m_TemplateAssets;

		// Token: 0x04001CAC RID: 7340
		private static readonly IntPtr NativeFieldInfoPtr_m_UxmlObjectEntries;

		// Token: 0x04001CAD RID: 7341
		private static readonly IntPtr NativeFieldInfoPtr_m_UxmlObjectIds;

		// Token: 0x04001CAE RID: 7342
		private static readonly IntPtr NativeFieldInfoPtr_m_AssetEntries;

		// Token: 0x04001CAF RID: 7343
		private static readonly IntPtr NativeFieldInfoPtr_m_Slots;

		// Token: 0x04001CB0 RID: 7344
		private static readonly IntPtr NativeFieldInfoPtr_m_ContentContainerId;

		// Token: 0x04001CB1 RID: 7345
		private static readonly IntPtr NativeFieldInfoPtr_m_ContentHash;

		// Token: 0x04001CB2 RID: 7346
		private static readonly IntPtr NativeMethodInfoPtr_get_importedWithErrors_Public_get_Boolean_0;

		// Token: 0x04001CB3 RID: 7347
		private static readonly IntPtr NativeMethodInfoPtr_set_importedWithErrors_Internal_set_Void_Boolean_0;

		// Token: 0x04001CB4 RID: 7348
		private static readonly IntPtr NativeMethodInfoPtr_get_importedWithWarnings_Public_get_Boolean_0;

		// Token: 0x04001CB5 RID: 7349
		private static readonly IntPtr NativeMethodInfoPtr_set_importedWithWarnings_Internal_set_Void_Boolean_0;

		// Token: 0x04001CB6 RID: 7350
		private static readonly IntPtr NativeMethodInfoPtr_GetNextChildSerialNumber_Internal_Int32_0;

		// Token: 0x04001CB7 RID: 7351
		private static readonly IntPtr NativeMethodInfoPtr_get_templateDependencies_Public_get_IEnumerable_1_VisualTreeAsset_0;

		// Token: 0x04001CB8 RID: 7352
		private static readonly IntPtr NativeMethodInfoPtr_get_stylesheets_Public_get_IEnumerable_1_StyleSheet_0;

		// Token: 0x04001CB9 RID: 7353
		private static readonly IntPtr NativeMethodInfoPtr_get_visualElementAssets_Internal_get_List_1_VisualElementAsset_0;

		// Token: 0x04001CBA RID: 7354
		private static readonly IntPtr NativeMethodInfoPtr_set_visualElementAssets_Internal_set_Void_List_1_VisualElementAsset_0;

		// Token: 0x04001CBB RID: 7355
		private static readonly IntPtr NativeMethodInfoPtr_get_templateAssets_Internal_get_List_1_TemplateAsset_0;

		// Token: 0x04001CBC RID: 7356
		private static readonly IntPtr NativeMethodInfoPtr_set_templateAssets_Internal_set_Void_List_1_TemplateAsset_0;

		// Token: 0x04001CBD RID: 7357
		private static readonly IntPtr NativeMethodInfoPtr_get_uxmlObjectEntries_Internal_get_List_1_UxmlObjectEntry_0;

		// Token: 0x04001CBE RID: 7358
		private static readonly IntPtr NativeMethodInfoPtr_get_uxmlObjectIds_Internal_get_List_1_Int32_0;

		// Token: 0x04001CBF RID: 7359
		private static readonly IntPtr NativeMethodInfoPtr_RegisterUxmlObject_Internal_Void_UxmlObjectAsset_0;

		// Token: 0x04001CC0 RID: 7360
		private static readonly IntPtr NativeMethodInfoPtr_GetUxmlObjects_Internal_List_1_T_IUxmlAttributes_CreationContext_0;

		// Token: 0x04001CC1 RID: 7361
		private static readonly IntPtr NativeMethodInfoPtr_AssetEntryExists_Internal_Boolean_String_Type_0;

		// Token: 0x04001CC2 RID: 7362
		private static readonly IntPtr NativeMethodInfoPtr_RegisterAssetEntry_Internal_Void_String_Type_Object_0;

		// Token: 0x04001CC3 RID: 7363
		private static readonly IntPtr NativeMethodInfoPtr_GetAsset_Internal_T_String_0;

		// Token: 0x04001CC4 RID: 7364
		private static readonly IntPtr NativeMethodInfoPtr_GetUxmlObjectEntry_Internal_UxmlObjectEntry_Int32_0;

		// Token: 0x04001CC5 RID: 7365
		private static readonly IntPtr NativeMethodInfoPtr_GetUxmlObjectFactory_Private_IBaseUxmlObjectFactory_UxmlObjectAsset_0;

		// Token: 0x04001CC6 RID: 7366
		private static readonly IntPtr NativeMethodInfoPtr_get_slots_Internal_get_List_1_SlotDefinition_0;

		// Token: 0x04001CC7 RID: 7367
		private static readonly IntPtr NativeMethodInfoPtr_set_slots_Internal_set_Void_List_1_SlotDefinition_0;

		// Token: 0x04001CC8 RID: 7368
		private static readonly IntPtr NativeMethodInfoPtr_get_contentContainerId_Internal_get_Int32_0;

		// Token: 0x04001CC9 RID: 7369
		private static readonly IntPtr NativeMethodInfoPtr_set_contentContainerId_Internal_set_Void_Int32_0;

		// Token: 0x04001CCA RID: 7370
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_TemplateContainer_0;

		// Token: 0x04001CCB RID: 7371
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_TemplateContainer_String_0;

		// Token: 0x04001CCC RID: 7372
		private static readonly IntPtr NativeMethodInfoPtr_CloneTree_Public_TemplateContainer_0;

		// Token: 0x04001CCD RID: 7373
		private static readonly IntPtr NativeMethodInfoPtr_CloneTree_Public_TemplateContainer_String_0;

		// Token: 0x04001CCE RID: 7374
		private static readonly IntPtr NativeMethodInfoPtr_CloneTree_Public_Void_VisualElement_0;

		// Token: 0x04001CCF RID: 7375
		private static readonly IntPtr NativeMethodInfoPtr_CloneTree_Public_Void_VisualElement_byref_Int32_byref_Int32_0;

		// Token: 0x04001CD0 RID: 7376
		private static readonly IntPtr NativeMethodInfoPtr_CloneTree_Internal_Void_VisualElement_Dictionary_2_String_VisualElement_List_1_AttributeOverride_0;

		// Token: 0x04001CD1 RID: 7377
		private static readonly IntPtr NativeMethodInfoPtr_CloneSetupRecursively_Private_VisualElement_VisualElementAsset_Dictionary_2_Int32_List_1_VisualElementAsset_CreationContext_0;

		// Token: 0x04001CD2 RID: 7378
		private static readonly IntPtr NativeMethodInfoPtr_CompareForOrder_Private_Static_Int32_VisualElementAsset_VisualElementAsset_0;

		// Token: 0x04001CD3 RID: 7379
		private static readonly IntPtr NativeMethodInfoPtr_TryGetSlotInsertionPoint_Internal_Boolean_Int32_byref_String_0;

		// Token: 0x04001CD4 RID: 7380
		private static readonly IntPtr NativeMethodInfoPtr_ResolveTemplate_Internal_VisualTreeAsset_String_0;

		// Token: 0x04001CD5 RID: 7381
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_VisualElement_VisualElementAsset_CreationContext_0;

		// Token: 0x04001CD6 RID: 7382
		private static readonly IntPtr NativeMethodInfoPtr_AssignClassListFromAssetToElement_Private_Static_Void_VisualElementAsset_VisualElement_0;

		// Token: 0x04001CD7 RID: 7383
		private static readonly IntPtr NativeMethodInfoPtr_AssignStyleSheetFromAssetToElement_Private_Static_Void_VisualElementAsset_VisualElement_0;

		// Token: 0x04001CD8 RID: 7384
		private static readonly IntPtr NativeMethodInfoPtr_get_contentHash_Public_get_Int32_0;

		// Token: 0x04001CD9 RID: 7385
		private static readonly IntPtr NativeMethodInfoPtr_set_contentHash_Public_set_Void_Int32_0;

		// Token: 0x04001CDA RID: 7386
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001CDB RID: 7387
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_VisualElement_byref___c__DisplayClass65_0_0;

		// Token: 0x0200051B RID: 1307
		[Serializable]
		public sealed class UsingEntry : ValueType
		{
			// Token: 0x06004002 RID: 16386 RVA: 0x000FE950 File Offset: 0x000FCB50
			// Note: this type is marked as 'beforefieldinit'.
			static UsingEntry()
			{
				Il2CppClassPointerStore<VisualTreeAsset.UsingEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, "UsingEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualTreeAsset.UsingEntry>.NativeClassPtr);
				VisualTreeAsset.UsingEntry.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset.UsingEntry>.NativeClassPtr, "comparer");
				VisualTreeAsset.UsingEntry.NativeFieldInfoPtr_alias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset.UsingEntry>.NativeClassPtr, "alias");
				VisualTreeAsset.UsingEntry.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset.UsingEntry>.NativeClassPtr, "path");
				VisualTreeAsset.UsingEntry.NativeFieldInfoPtr_asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset.UsingEntry>.NativeClassPtr, "asset");
				VisualTreeAsset.UsingEntry.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset.UsingEntry>.NativeClassPtr, 100669417);
			}

			// Token: 0x06004003 RID: 16387 RVA: 0x000FE9E0 File Offset: 0x000FCBE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 344930, XrefRangeEnd = 344933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UsingEntry(string alias, string path)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualTreeAsset.UsingEntry>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(alias);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.UsingEntry.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004004 RID: 16388 RVA: 0x0001AD2F File Offset: 0x00018F2F
			public UsingEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004005 RID: 16389 RVA: 0x0001AD38 File Offset: 0x00018F38
			public UsingEntry()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualTreeAsset.UsingEntry>.NativeClassPtr))
			{
			}

			// Token: 0x17001329 RID: 4905
			// (get) Token: 0x06004006 RID: 16390 RVA: 0x000FEA44 File Offset: 0x000FCC44
			// (set) Token: 0x06004007 RID: 16391 RVA: 0x0001AD4A File Offset: 0x00018F4A
			public unsafe static IComparer<VisualTreeAsset.UsingEntry> comparer
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VisualTreeAsset.UsingEntry.NativeFieldInfoPtr_comparer, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IComparer<VisualTreeAsset.UsingEntry>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VisualTreeAsset.UsingEntry.NativeFieldInfoPtr_comparer, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700132A RID: 4906
			// (get) Token: 0x06004008 RID: 16392 RVA: 0x000FEA6C File Offset: 0x000FCC6C
			// (set) Token: 0x06004009 RID: 16393 RVA: 0x0001AD5C File Offset: 0x00018F5C
			public unsafe string alias
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.UsingEntry.NativeFieldInfoPtr_alias);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.UsingEntry.NativeFieldInfoPtr_alias), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700132B RID: 4907
			// (get) Token: 0x0600400A RID: 16394 RVA: 0x000FEA94 File Offset: 0x000FCC94
			// (set) Token: 0x0600400B RID: 16395 RVA: 0x0001AD7B File Offset: 0x00018F7B
			public unsafe string path
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.UsingEntry.NativeFieldInfoPtr_path);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.UsingEntry.NativeFieldInfoPtr_path), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700132C RID: 4908
			// (get) Token: 0x0600400C RID: 16396 RVA: 0x000FEABC File Offset: 0x000FCCBC
			// (set) Token: 0x0600400D RID: 16397 RVA: 0x0001AD9A File Offset: 0x00018F9A
			public unsafe VisualTreeAsset asset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.UsingEntry.NativeFieldInfoPtr_asset);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualTreeAsset>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.UsingEntry.NativeFieldInfoPtr_asset), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D26 RID: 11558
			private static readonly IntPtr NativeFieldInfoPtr_comparer;

			// Token: 0x04002D27 RID: 11559
			private static readonly IntPtr NativeFieldInfoPtr_alias;

			// Token: 0x04002D28 RID: 11560
			private static readonly IntPtr NativeFieldInfoPtr_path;

			// Token: 0x04002D29 RID: 11561
			private static readonly IntPtr NativeFieldInfoPtr_asset;

			// Token: 0x04002D2A RID: 11562
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;
		}

		// Token: 0x0200051C RID: 1308
		public class UsingEntryComparer : Object
		{
			// Token: 0x0600400E RID: 16398 RVA: 0x000FEAEC File Offset: 0x000FCCEC
			// Note: this type is marked as 'beforefieldinit'.
			static UsingEntryComparer()
			{
				Il2CppClassPointerStore<VisualTreeAsset.UsingEntryComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, "UsingEntryComparer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualTreeAsset.UsingEntryComparer>.NativeClassPtr);
				VisualTreeAsset.UsingEntryComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_UsingEntry_UsingEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset.UsingEntryComparer>.NativeClassPtr, 100669419);
				VisualTreeAsset.UsingEntryComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset.UsingEntryComparer>.NativeClassPtr, 100669420);
			}

			// Token: 0x0600400F RID: 16399 RVA: 0x000FEB40 File Offset: 0x000FCD40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 344933, XrefRangeEnd = 344942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int Compare(VisualTreeAsset.UsingEntry x, VisualTreeAsset.UsingEntry y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.UsingEntryComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_UsingEntry_UsingEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004010 RID: 16400 RVA: 0x000FEBAC File Offset: 0x000FCDAC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UsingEntryComparer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualTreeAsset.UsingEntryComparer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.UsingEntryComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004011 RID: 16401 RVA: 0x0001ADB9 File Offset: 0x00018FB9
			public UsingEntryComparer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002D2B RID: 11563
			private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_UsingEntry_UsingEntry_0;

			// Token: 0x04002D2C RID: 11564
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200051D RID: 1309
		[Serializable]
		public sealed class SlotDefinition : ValueType
		{
			// Token: 0x06004012 RID: 16402 RVA: 0x000FEBE8 File Offset: 0x000FCDE8
			// Note: this type is marked as 'beforefieldinit'.
			static SlotDefinition()
			{
				Il2CppClassPointerStore<VisualTreeAsset.SlotDefinition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, "SlotDefinition");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualTreeAsset.SlotDefinition>.NativeClassPtr);
				VisualTreeAsset.SlotDefinition.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset.SlotDefinition>.NativeClassPtr, "name");
				VisualTreeAsset.SlotDefinition.NativeFieldInfoPtr_insertionPointId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset.SlotDefinition>.NativeClassPtr, "insertionPointId");
			}

			// Token: 0x06004013 RID: 16403 RVA: 0x0001ADC2 File Offset: 0x00018FC2
			public SlotDefinition(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004014 RID: 16404 RVA: 0x0001ADCB File Offset: 0x00018FCB
			public SlotDefinition()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualTreeAsset.SlotDefinition>.NativeClassPtr))
			{
			}

			// Token: 0x1700132D RID: 4909
			// (get) Token: 0x06004015 RID: 16405 RVA: 0x000FEC3C File Offset: 0x000FCE3C
			// (set) Token: 0x06004016 RID: 16406 RVA: 0x0001ADDD File Offset: 0x00018FDD
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.SlotDefinition.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.SlotDefinition.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700132E RID: 4910
			// (get) Token: 0x06004017 RID: 16407 RVA: 0x000FEC64 File Offset: 0x000FCE64
			// (set) Token: 0x06004018 RID: 16408 RVA: 0x0001ADFC File Offset: 0x00018FFC
			public unsafe int insertionPointId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.SlotDefinition.NativeFieldInfoPtr_insertionPointId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.SlotDefinition.NativeFieldInfoPtr_insertionPointId)) = value;
				}
			}

			// Token: 0x04002D2D RID: 11565
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04002D2E RID: 11566
			private static readonly IntPtr NativeFieldInfoPtr_insertionPointId;
		}

		// Token: 0x0200051E RID: 1310
		[Serializable]
		public sealed class SlotUsageEntry : ValueType
		{
			// Token: 0x06004019 RID: 16409 RVA: 0x000FEC8C File Offset: 0x000FCE8C
			// Note: this type is marked as 'beforefieldinit'.
			static SlotUsageEntry()
			{
				Il2CppClassPointerStore<VisualTreeAsset.SlotUsageEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, "SlotUsageEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualTreeAsset.SlotUsageEntry>.NativeClassPtr);
				VisualTreeAsset.SlotUsageEntry.NativeFieldInfoPtr_slotName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset.SlotUsageEntry>.NativeClassPtr, "slotName");
				VisualTreeAsset.SlotUsageEntry.NativeFieldInfoPtr_assetId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset.SlotUsageEntry>.NativeClassPtr, "assetId");
			}

			// Token: 0x0600401A RID: 16410 RVA: 0x0001AE17 File Offset: 0x00019017
			public SlotUsageEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600401B RID: 16411 RVA: 0x0001AE20 File Offset: 0x00019020
			public SlotUsageEntry()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualTreeAsset.SlotUsageEntry>.NativeClassPtr))
			{
			}

			// Token: 0x1700132F RID: 4911
			// (get) Token: 0x0600401C RID: 16412 RVA: 0x000FECE0 File Offset: 0x000FCEE0
			// (set) Token: 0x0600401D RID: 16413 RVA: 0x0001AE32 File Offset: 0x00019032
			public unsafe string slotName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.SlotUsageEntry.NativeFieldInfoPtr_slotName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.SlotUsageEntry.NativeFieldInfoPtr_slotName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001330 RID: 4912
			// (get) Token: 0x0600401E RID: 16414 RVA: 0x000FED08 File Offset: 0x000FCF08
			// (set) Token: 0x0600401F RID: 16415 RVA: 0x0001AE51 File Offset: 0x00019051
			public unsafe int assetId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.SlotUsageEntry.NativeFieldInfoPtr_assetId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.SlotUsageEntry.NativeFieldInfoPtr_assetId)) = value;
				}
			}

			// Token: 0x04002D2F RID: 11567
			private static readonly IntPtr NativeFieldInfoPtr_slotName;

			// Token: 0x04002D30 RID: 11568
			private static readonly IntPtr NativeFieldInfoPtr_assetId;
		}

		// Token: 0x0200051F RID: 1311
		[Serializable]
		public sealed class UxmlObjectEntry : ValueType
		{
			// Token: 0x06004020 RID: 16416 RVA: 0x000FED30 File Offset: 0x000FCF30
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlObjectEntry()
			{
				Il2CppClassPointerStore<VisualTreeAsset.UxmlObjectEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, "UxmlObjectEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualTreeAsset.UxmlObjectEntry>.NativeClassPtr);
				VisualTreeAsset.UxmlObjectEntry.NativeFieldInfoPtr_parentId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset.UxmlObjectEntry>.NativeClassPtr, "parentId");
				VisualTreeAsset.UxmlObjectEntry.NativeFieldInfoPtr_uxmlObjectAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset.UxmlObjectEntry>.NativeClassPtr, "uxmlObjectAssets");
				VisualTreeAsset.UxmlObjectEntry.NativeMethodInfoPtr__ctor_Public_Void_Int32_List_1_UxmlObjectAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset.UxmlObjectEntry>.NativeClassPtr, 100669421);
			}

			// Token: 0x06004021 RID: 16417 RVA: 0x000FED98 File Offset: 0x000FCF98
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 344943, RefRangeEnd = 345022, XrefRangeStart = 344942, XrefRangeEnd = 344943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlObjectEntry(int parentId, List<UxmlObjectAsset> uxmlObjectAssets)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualTreeAsset.UxmlObjectEntry>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref parentId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uxmlObjectAssets);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.UxmlObjectEntry.NativeMethodInfoPtr__ctor_Public_Void_Int32_List_1_UxmlObjectAsset_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004022 RID: 16418 RVA: 0x0001AE6C File Offset: 0x0001906C
			public UxmlObjectEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004023 RID: 16419 RVA: 0x0001AE75 File Offset: 0x00019075
			public UxmlObjectEntry()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualTreeAsset.UxmlObjectEntry>.NativeClassPtr))
			{
			}

			// Token: 0x17001331 RID: 4913
			// (get) Token: 0x06004024 RID: 16420 RVA: 0x000FEDF8 File Offset: 0x000FCFF8
			// (set) Token: 0x06004025 RID: 16421 RVA: 0x0001AE87 File Offset: 0x00019087
			public unsafe int parentId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.UxmlObjectEntry.NativeFieldInfoPtr_parentId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.UxmlObjectEntry.NativeFieldInfoPtr_parentId)) = value;
				}
			}

			// Token: 0x17001332 RID: 4914
			// (get) Token: 0x06004026 RID: 16422 RVA: 0x000FEE20 File Offset: 0x000FD020
			// (set) Token: 0x06004027 RID: 16423 RVA: 0x0001AEA2 File Offset: 0x000190A2
			public unsafe List<UxmlObjectAsset> uxmlObjectAssets
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.UxmlObjectEntry.NativeFieldInfoPtr_uxmlObjectAssets);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UxmlObjectAsset>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.UxmlObjectEntry.NativeFieldInfoPtr_uxmlObjectAssets), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D31 RID: 11569
			private static readonly IntPtr NativeFieldInfoPtr_parentId;

			// Token: 0x04002D32 RID: 11570
			private static readonly IntPtr NativeFieldInfoPtr_uxmlObjectAssets;

			// Token: 0x04002D33 RID: 11571
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_List_1_UxmlObjectAsset_0;
		}

		// Token: 0x02000520 RID: 1312
		[Serializable]
		public sealed class AssetEntry : ValueType
		{
			// Token: 0x06004028 RID: 16424 RVA: 0x000FEE50 File Offset: 0x000FD050
			// Note: this type is marked as 'beforefieldinit'.
			static AssetEntry()
			{
				Il2CppClassPointerStore<VisualTreeAsset.AssetEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, "AssetEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualTreeAsset.AssetEntry>.NativeClassPtr);
				VisualTreeAsset.AssetEntry.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset.AssetEntry>.NativeClassPtr, "path");
				VisualTreeAsset.AssetEntry.NativeFieldInfoPtr_typeFullName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset.AssetEntry>.NativeClassPtr, "typeFullName");
				VisualTreeAsset.AssetEntry.NativeFieldInfoPtr_asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset.AssetEntry>.NativeClassPtr, "asset");
				VisualTreeAsset.AssetEntry.NativeFieldInfoPtr_m_CachedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset.AssetEntry>.NativeClassPtr, "m_CachedType");
				VisualTreeAsset.AssetEntry.NativeMethodInfoPtr_get_type_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset.AssetEntry>.NativeClassPtr, 100669422);
				VisualTreeAsset.AssetEntry.NativeMethodInfoPtr__ctor_Public_Void_String_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset.AssetEntry>.NativeClassPtr, 100669423);
			}

			// Token: 0x17001337 RID: 4919
			// (get) Token: 0x06004029 RID: 16425 RVA: 0x000FEEF4 File Offset: 0x000FD0F4
			public unsafe Type type
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 345031, RefRangeEnd = 345033, XrefRangeStart = 345022, XrefRangeEnd = 345031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.AssetEntry.NativeMethodInfoPtr_get_type_Public_get_Type_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
				}
			}

			// Token: 0x0600402A RID: 16426 RVA: 0x000FEF38 File Offset: 0x000FD138
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345033, XrefRangeEnd = 345038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AssetEntry(string path, Type type, Object asset)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualTreeAsset.AssetEntry>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.AssetEntry.NativeMethodInfoPtr__ctor_Public_Void_String_Type_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600402B RID: 16427 RVA: 0x0001AEC1 File Offset: 0x000190C1
			public AssetEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600402C RID: 16428 RVA: 0x0001AECA File Offset: 0x000190CA
			public AssetEntry()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualTreeAsset.AssetEntry>.NativeClassPtr))
			{
			}

			// Token: 0x17001333 RID: 4915
			// (get) Token: 0x0600402D RID: 16429 RVA: 0x000FEFAC File Offset: 0x000FD1AC
			// (set) Token: 0x0600402E RID: 16430 RVA: 0x0001AEDC File Offset: 0x000190DC
			public unsafe string path
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.AssetEntry.NativeFieldInfoPtr_path);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.AssetEntry.NativeFieldInfoPtr_path), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001334 RID: 4916
			// (get) Token: 0x0600402F RID: 16431 RVA: 0x000FEFD4 File Offset: 0x000FD1D4
			// (set) Token: 0x06004030 RID: 16432 RVA: 0x0001AEFB File Offset: 0x000190FB
			public unsafe string typeFullName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.AssetEntry.NativeFieldInfoPtr_typeFullName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.AssetEntry.NativeFieldInfoPtr_typeFullName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001335 RID: 4917
			// (get) Token: 0x06004031 RID: 16433 RVA: 0x000FEFFC File Offset: 0x000FD1FC
			// (set) Token: 0x06004032 RID: 16434 RVA: 0x0001AF1A File Offset: 0x0001911A
			public unsafe Object asset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.AssetEntry.NativeFieldInfoPtr_asset);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.AssetEntry.NativeFieldInfoPtr_asset), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001336 RID: 4918
			// (get) Token: 0x06004033 RID: 16435 RVA: 0x000FF02C File Offset: 0x000FD22C
			// (set) Token: 0x06004034 RID: 16436 RVA: 0x0001AF39 File Offset: 0x00019139
			public unsafe Type m_CachedType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.AssetEntry.NativeFieldInfoPtr_m_CachedType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.AssetEntry.NativeFieldInfoPtr_m_CachedType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D34 RID: 11572
			private static readonly IntPtr NativeFieldInfoPtr_path;

			// Token: 0x04002D35 RID: 11573
			private static readonly IntPtr NativeFieldInfoPtr_typeFullName;

			// Token: 0x04002D36 RID: 11574
			private static readonly IntPtr NativeFieldInfoPtr_asset;

			// Token: 0x04002D37 RID: 11575
			private static readonly IntPtr NativeFieldInfoPtr_m_CachedType;

			// Token: 0x04002D38 RID: 11576
			private static readonly IntPtr NativeMethodInfoPtr_get_type_Public_get_Type_0;

			// Token: 0x04002D39 RID: 11577
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Type_Object_0;
		}

		// Token: 0x02000521 RID: 1313
		[ObfuscatedName("UnityEngine.UIElements.VisualTreeAsset+<>c__DisplayClass61_0")]
		public sealed class __c__DisplayClass61_0 : Object
		{
			// Token: 0x06004035 RID: 16437 RVA: 0x000FF05C File Offset: 0x000FD25C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass61_0()
			{
				Il2CppClassPointerStore<VisualTreeAsset.__c__DisplayClass61_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, "<>c__DisplayClass61_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualTreeAsset.__c__DisplayClass61_0>.NativeClassPtr);
				VisualTreeAsset.__c__DisplayClass61_0.NativeFieldInfoPtr_childVea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset.__c__DisplayClass61_0>.NativeClassPtr, "childVea");
				VisualTreeAsset.__c__DisplayClass61_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset.__c__DisplayClass61_0>.NativeClassPtr, 100669424);
				VisualTreeAsset.__c__DisplayClass61_0.NativeMethodInfoPtr__CloneSetupRecursively_b__0_Internal_Boolean_SlotUsageEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset.__c__DisplayClass61_0>.NativeClassPtr, 100669425);
			}

			// Token: 0x06004036 RID: 16438 RVA: 0x000FF0C4 File Offset: 0x000FD2C4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass61_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualTreeAsset.__c__DisplayClass61_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.__c__DisplayClass61_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004037 RID: 16439 RVA: 0x000FF100 File Offset: 0x000FD300
			[CallerCount(0)]
			public unsafe bool _CloneSetupRecursively_b__0(VisualTreeAsset.SlotUsageEntry u)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(u));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset.__c__DisplayClass61_0.NativeMethodInfoPtr__CloneSetupRecursively_b__0_Internal_Boolean_SlotUsageEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004038 RID: 16440 RVA: 0x0001AF58 File Offset: 0x00019158
			public __c__DisplayClass61_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001338 RID: 4920
			// (get) Token: 0x06004039 RID: 16441 RVA: 0x000FF154 File Offset: 0x000FD354
			// (set) Token: 0x0600403A RID: 16442 RVA: 0x0001AF61 File Offset: 0x00019161
			public unsafe VisualElementAsset childVea
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.__c__DisplayClass61_0.NativeFieldInfoPtr_childVea);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElementAsset>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.__c__DisplayClass61_0.NativeFieldInfoPtr_childVea), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D3A RID: 11578
			private static readonly IntPtr NativeFieldInfoPtr_childVea;

			// Token: 0x04002D3B RID: 11579
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D3C RID: 11580
			private static readonly IntPtr NativeMethodInfoPtr__CloneSetupRecursively_b__0_Internal_Boolean_SlotUsageEntry_0;
		}

		// Token: 0x02000522 RID: 1314
		[ObfuscatedName("UnityEngine.UIElements.VisualTreeAsset+<>c__DisplayClass65_0")]
		public sealed class __c__DisplayClass65_0 : ValueType
		{
			// Token: 0x0600403B RID: 16443 RVA: 0x0001AF80 File Offset: 0x00019180
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass65_0()
			{
				Il2CppClassPointerStore<VisualTreeAsset.__c__DisplayClass65_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, "<>c__DisplayClass65_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualTreeAsset.__c__DisplayClass65_0>.NativeClassPtr);
				VisualTreeAsset.__c__DisplayClass65_0.NativeFieldInfoPtr_asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset.__c__DisplayClass65_0>.NativeClassPtr, "asset");
			}

			// Token: 0x0600403C RID: 16444 RVA: 0x0001AFB4 File Offset: 0x000191B4
			public __c__DisplayClass65_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600403D RID: 16445 RVA: 0x0001AFBD File Offset: 0x000191BD
			public __c__DisplayClass65_0()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualTreeAsset.__c__DisplayClass65_0>.NativeClassPtr))
			{
			}

			// Token: 0x17001339 RID: 4921
			// (get) Token: 0x0600403E RID: 16446 RVA: 0x000FF184 File Offset: 0x000FD384
			// (set) Token: 0x0600403F RID: 16447 RVA: 0x0001AFCF File Offset: 0x000191CF
			public unsafe VisualElementAsset asset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.__c__DisplayClass65_0.NativeFieldInfoPtr_asset);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElementAsset>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset.__c__DisplayClass65_0.NativeFieldInfoPtr_asset), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D3D RID: 11581
			private static readonly IntPtr NativeFieldInfoPtr_asset;
		}

		// Token: 0x02000523 RID: 1315
		[ObfuscatedName("UnityEngine.UIElements.VisualTreeAsset+<get_stylesheets>d__23")]
		public sealed class _get_stylesheets_d__23 : Object
		{
			// Token: 0x06004040 RID: 16448 RVA: 0x000FF1B4 File Offset: 0x000FD3B4
			// Note: this type is marked as 'beforefieldinit'.
			static _get_stylesheets_d__23()
			{
				Il2CppClassPointerStore<VisualTreeAsset._get_stylesheets_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, "<get_stylesheets>d__23");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualTreeAsset._get_stylesheets_d__23>.NativeClassPtr);
				VisualTreeAsset._get_stylesheets_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset._get_stylesheets_d__23>.NativeClassPtr, "<>1__state");
				VisualTreeAsset._get_stylesheets_d__23.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset._get_stylesheets_d__23>.NativeClassPtr, "<>2__current");
				VisualTreeAsset._get_stylesheets_d__23.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset._get_stylesheets_d__23>.NativeClassPtr, "<>l__initialThreadId");
				VisualTreeAsset._get_stylesheets_d__23.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset._get_stylesheets_d__23>.NativeClassPtr, "<>4__this");
				VisualTreeAsset._get_stylesheets_d__23.NativeFieldInfoPtr__sent_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset._get_stylesheets_d__23>.NativeClassPtr, "<sent>5__1");
				VisualTreeAsset._get_stylesheets_d__23.NativeFieldInfoPtr___s__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset._get_stylesheets_d__23>.NativeClassPtr, "<>s__2");
				VisualTreeAsset._get_stylesheets_d__23.NativeFieldInfoPtr__vea_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset._get_stylesheets_d__23>.NativeClassPtr, "<vea>5__3");
				VisualTreeAsset._get_stylesheets_d__23.NativeFieldInfoPtr___s__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset._get_stylesheets_d__23>.NativeClassPtr, "<>s__4");
				VisualTreeAsset._get_stylesheets_d__23.NativeFieldInfoPtr__stylesheet_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset._get_stylesheets_d__23>.NativeClassPtr, "<stylesheet>5__5");
				VisualTreeAsset._get_stylesheets_d__23.NativeFieldInfoPtr___s__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset._get_stylesheets_d__23>.NativeClassPtr, "<>s__6");
				VisualTreeAsset._get_stylesheets_d__23.NativeFieldInfoPtr__stylesheetPath_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset._get_stylesheets_d__23>.NativeClassPtr, "<stylesheetPath>5__7");
				VisualTreeAsset._get_stylesheets_d__23.NativeFieldInfoPtr__stylesheet_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset._get_stylesheets_d__23>.NativeClassPtr, "<stylesheet>5__8");
				VisualTreeAsset._get_stylesheets_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset._get_stylesheets_d__23>.NativeClassPtr, 100669426);
				VisualTreeAsset._get_stylesheets_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset._get_stylesheets_d__23>.NativeClassPtr, 100669427);
				VisualTreeAsset._get_stylesheets_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset._get_stylesheets_d__23>.NativeClassPtr, 100669428);
				VisualTreeAsset._get_stylesheets_d__23.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset._get_stylesheets_d__23>.NativeClassPtr, 100669429);
				VisualTreeAsset._get_stylesheets_d__23.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset._get_stylesheets_d__23>.NativeClassPtr, 100669430);
				VisualTreeAsset._get_stylesheets_d__23.NativeMethodInfoPtr___m__Finally3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset._get_stylesheets_d__23>.NativeClassPtr, 100669431);
				VisualTreeAsset._get_stylesheets_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_UIElements_StyleSheet__get_Current_Private_Virtual_Final_New_get_StyleSheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset._get_stylesheets_d__23>.NativeClassPtr, 100669432);
				VisualTreeAsset._get_stylesheets_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset._get_stylesheets_d__23>.NativeClassPtr, 100669433);
				VisualTreeAsset._get_stylesheets_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset._get_stylesheets_d__23>.NativeClassPtr, 100669434);
				VisualTreeAsset._get_stylesheets_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_UIElements_StyleSheet__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_StyleSheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset._get_stylesheets_d__23>.NativeClassPtr, 100669435);
				VisualTreeAsset._get_stylesheets_d__23.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset._get_stylesheets_d__23>.NativeClassPtr, 100669436);
			}

			// Token: 0x06004041 RID: 16449 RVA: 0x000FF3AC File Offset: 0x000FD5AC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_stylesheets_d__23(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualTreeAsset._get_stylesheets_d__23>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset._get_stylesheets_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004042 RID: 16450 RVA: 0x000FF3F4 File Offset: 0x000FD5F4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 345056, RefRangeEnd = 345057, XrefRangeStart = 345038, XrefRangeEnd = 345056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset._get_stylesheets_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004043 RID: 16451 RVA: 0x000FF428 File Offset: 0x000FD628
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345057, XrefRangeEnd = 345151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset._get_stylesheets_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004044 RID: 16452 RVA: 0x000FF464 File Offset: 0x000FD664
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345151, XrefRangeEnd = 345154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset._get_stylesheets_d__23.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004045 RID: 16453 RVA: 0x000FF498 File Offset: 0x000FD698
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345154, XrefRangeEnd = 345157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset._get_stylesheets_d__23.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004046 RID: 16454 RVA: 0x000FF4CC File Offset: 0x000FD6CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345157, XrefRangeEnd = 345160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset._get_stylesheets_d__23.NativeMethodInfoPtr___m__Finally3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001346 RID: 4934
			// (get) Token: 0x06004047 RID: 16455 RVA: 0x000FF500 File Offset: 0x000FD700
			public unsafe StyleSheet System.Collections.Generic.IEnumerator<UnityEngine.UIElements.StyleSheet>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset._get_stylesheets_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_UIElements_StyleSheet__get_Current_Private_Virtual_Final_New_get_StyleSheet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<StyleSheet>(intPtr3) : null;
				}
			}

			// Token: 0x06004048 RID: 16456 RVA: 0x000FF540 File Offset: 0x000FD740
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345160, XrefRangeEnd = 345165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset._get_stylesheets_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001347 RID: 4935
			// (get) Token: 0x06004049 RID: 16457 RVA: 0x000FF574 File Offset: 0x000FD774
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset._get_stylesheets_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600404A RID: 16458 RVA: 0x000FF5B4 File Offset: 0x000FD7B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345165, XrefRangeEnd = 345167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<StyleSheet> System_Collections_Generic_IEnumerable_UnityEngine_UIElements_StyleSheet__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset._get_stylesheets_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_UIElements_StyleSheet__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_StyleSheet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<StyleSheet>>(intPtr3) : null;
			}

			// Token: 0x0600404B RID: 16459 RVA: 0x000FF5F4 File Offset: 0x000FD7F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset._get_stylesheets_d__23.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600404C RID: 16460 RVA: 0x0001AFEE File Offset: 0x000191EE
			public _get_stylesheets_d__23(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700133A RID: 4922
			// (get) Token: 0x0600404D RID: 16461 RVA: 0x000FF634 File Offset: 0x000FD834
			// (set) Token: 0x0600404E RID: 16462 RVA: 0x0001AFF7 File Offset: 0x000191F7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_stylesheets_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_stylesheets_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700133B RID: 4923
			// (get) Token: 0x0600404F RID: 16463 RVA: 0x000FF65C File Offset: 0x000FD85C
			// (set) Token: 0x06004050 RID: 16464 RVA: 0x0001B012 File Offset: 0x00019212
			public unsafe StyleSheet __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_stylesheets_d__23.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleSheet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_stylesheets_d__23.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700133C RID: 4924
			// (get) Token: 0x06004051 RID: 16465 RVA: 0x000FF68C File Offset: 0x000FD88C
			// (set) Token: 0x06004052 RID: 16466 RVA: 0x0001B031 File Offset: 0x00019231
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_stylesheets_d__23.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_stylesheets_d__23.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700133D RID: 4925
			// (get) Token: 0x06004053 RID: 16467 RVA: 0x000FF6B4 File Offset: 0x000FD8B4
			// (set) Token: 0x06004054 RID: 16468 RVA: 0x0001B04C File Offset: 0x0001924C
			public unsafe VisualTreeAsset __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_stylesheets_d__23.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualTreeAsset>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_stylesheets_d__23.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700133E RID: 4926
			// (get) Token: 0x06004055 RID: 16469 RVA: 0x000FF6E4 File Offset: 0x000FD8E4
			// (set) Token: 0x06004056 RID: 16470 RVA: 0x0001B06B File Offset: 0x0001926B
			public unsafe HashSet<StyleSheet> _sent_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_stylesheets_d__23.NativeFieldInfoPtr__sent_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<StyleSheet>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_stylesheets_d__23.NativeFieldInfoPtr__sent_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700133F RID: 4927
			// (get) Token: 0x06004057 RID: 16471 RVA: 0x000FF714 File Offset: 0x000FD914
			// (set) Token: 0x06004058 RID: 16472 RVA: 0x0001B08A File Offset: 0x0001928A
			public List<VisualElementAsset>.Enumerator __s__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_stylesheets_d__23.NativeFieldInfoPtr___s__2);
					return new List<VisualElementAsset>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<VisualElementAsset>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_stylesheets_d__23.NativeFieldInfoPtr___s__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<VisualElementAsset>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001340 RID: 4928
			// (get) Token: 0x06004059 RID: 16473 RVA: 0x000FF744 File Offset: 0x000FD944
			// (set) Token: 0x0600405A RID: 16474 RVA: 0x0001B0B8 File Offset: 0x000192B8
			public unsafe VisualElementAsset _vea_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_stylesheets_d__23.NativeFieldInfoPtr__vea_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElementAsset>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_stylesheets_d__23.NativeFieldInfoPtr__vea_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001341 RID: 4929
			// (get) Token: 0x0600405B RID: 16475 RVA: 0x000FF774 File Offset: 0x000FD974
			// (set) Token: 0x0600405C RID: 16476 RVA: 0x0001B0D7 File Offset: 0x000192D7
			public List<StyleSheet>.Enumerator __s__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_stylesheets_d__23.NativeFieldInfoPtr___s__4);
					return new List<StyleSheet>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<StyleSheet>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_stylesheets_d__23.NativeFieldInfoPtr___s__4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<StyleSheet>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001342 RID: 4930
			// (get) Token: 0x0600405D RID: 16477 RVA: 0x000FF7A4 File Offset: 0x000FD9A4
			// (set) Token: 0x0600405E RID: 16478 RVA: 0x0001B105 File Offset: 0x00019305
			public unsafe StyleSheet _stylesheet_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_stylesheets_d__23.NativeFieldInfoPtr__stylesheet_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleSheet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_stylesheets_d__23.NativeFieldInfoPtr__stylesheet_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001343 RID: 4931
			// (get) Token: 0x0600405F RID: 16479 RVA: 0x000FF7D4 File Offset: 0x000FD9D4
			// (set) Token: 0x06004060 RID: 16480 RVA: 0x0001B124 File Offset: 0x00019324
			public List<string>.Enumerator __s__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_stylesheets_d__23.NativeFieldInfoPtr___s__6);
					return new List<string>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<string>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_stylesheets_d__23.NativeFieldInfoPtr___s__6), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<string>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001344 RID: 4932
			// (get) Token: 0x06004061 RID: 16481 RVA: 0x000FF804 File Offset: 0x000FDA04
			// (set) Token: 0x06004062 RID: 16482 RVA: 0x0001B152 File Offset: 0x00019352
			public unsafe string _stylesheetPath_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_stylesheets_d__23.NativeFieldInfoPtr__stylesheetPath_5__7);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_stylesheets_d__23.NativeFieldInfoPtr__stylesheetPath_5__7), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001345 RID: 4933
			// (get) Token: 0x06004063 RID: 16483 RVA: 0x000FF82C File Offset: 0x000FDA2C
			// (set) Token: 0x06004064 RID: 16484 RVA: 0x0001B171 File Offset: 0x00019371
			public unsafe StyleSheet _stylesheet_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_stylesheets_d__23.NativeFieldInfoPtr__stylesheet_5__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleSheet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_stylesheets_d__23.NativeFieldInfoPtr__stylesheet_5__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D3E RID: 11582
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002D3F RID: 11583
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002D40 RID: 11584
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002D41 RID: 11585
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002D42 RID: 11586
			private static readonly IntPtr NativeFieldInfoPtr__sent_5__1;

			// Token: 0x04002D43 RID: 11587
			private static readonly IntPtr NativeFieldInfoPtr___s__2;

			// Token: 0x04002D44 RID: 11588
			private static readonly IntPtr NativeFieldInfoPtr__vea_5__3;

			// Token: 0x04002D45 RID: 11589
			private static readonly IntPtr NativeFieldInfoPtr___s__4;

			// Token: 0x04002D46 RID: 11590
			private static readonly IntPtr NativeFieldInfoPtr__stylesheet_5__5;

			// Token: 0x04002D47 RID: 11591
			private static readonly IntPtr NativeFieldInfoPtr___s__6;

			// Token: 0x04002D48 RID: 11592
			private static readonly IntPtr NativeFieldInfoPtr__stylesheetPath_5__7;

			// Token: 0x04002D49 RID: 11593
			private static readonly IntPtr NativeFieldInfoPtr__stylesheet_5__8;

			// Token: 0x04002D4A RID: 11594
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002D4B RID: 11595
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002D4C RID: 11596
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002D4D RID: 11597
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04002D4E RID: 11598
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04002D4F RID: 11599
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally3_Private_Void_0;

			// Token: 0x04002D50 RID: 11600
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_UIElements_StyleSheet__get_Current_Private_Virtual_Final_New_get_StyleSheet_0;

			// Token: 0x04002D51 RID: 11601
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002D52 RID: 11602
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002D53 RID: 11603
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_UIElements_StyleSheet__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_StyleSheet_0;

			// Token: 0x04002D54 RID: 11604
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000524 RID: 1316
		[ObfuscatedName("UnityEngine.UIElements.VisualTreeAsset+<get_templateDependencies>d__19")]
		public sealed class _get_templateDependencies_d__19 : Object
		{
			// Token: 0x06004065 RID: 16485 RVA: 0x000FF85C File Offset: 0x000FDA5C
			// Note: this type is marked as 'beforefieldinit'.
			static _get_templateDependencies_d__19()
			{
				Il2CppClassPointerStore<VisualTreeAsset._get_templateDependencies_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr, "<get_templateDependencies>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualTreeAsset._get_templateDependencies_d__19>.NativeClassPtr);
				VisualTreeAsset._get_templateDependencies_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset._get_templateDependencies_d__19>.NativeClassPtr, "<>1__state");
				VisualTreeAsset._get_templateDependencies_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset._get_templateDependencies_d__19>.NativeClassPtr, "<>2__current");
				VisualTreeAsset._get_templateDependencies_d__19.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset._get_templateDependencies_d__19>.NativeClassPtr, "<>l__initialThreadId");
				VisualTreeAsset._get_templateDependencies_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset._get_templateDependencies_d__19>.NativeClassPtr, "<>4__this");
				VisualTreeAsset._get_templateDependencies_d__19.NativeFieldInfoPtr__sent_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset._get_templateDependencies_d__19>.NativeClassPtr, "<sent>5__1");
				VisualTreeAsset._get_templateDependencies_d__19.NativeFieldInfoPtr___s__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset._get_templateDependencies_d__19>.NativeClassPtr, "<>s__2");
				VisualTreeAsset._get_templateDependencies_d__19.NativeFieldInfoPtr__entry_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset._get_templateDependencies_d__19>.NativeClassPtr, "<entry>5__3");
				VisualTreeAsset._get_templateDependencies_d__19.NativeFieldInfoPtr__vta_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeAsset._get_templateDependencies_d__19>.NativeClassPtr, "<vta>5__4");
				VisualTreeAsset._get_templateDependencies_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset._get_templateDependencies_d__19>.NativeClassPtr, 100669437);
				VisualTreeAsset._get_templateDependencies_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset._get_templateDependencies_d__19>.NativeClassPtr, 100669438);
				VisualTreeAsset._get_templateDependencies_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset._get_templateDependencies_d__19>.NativeClassPtr, 100669439);
				VisualTreeAsset._get_templateDependencies_d__19.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset._get_templateDependencies_d__19>.NativeClassPtr, 100669440);
				VisualTreeAsset._get_templateDependencies_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_UIElements_VisualTreeAsset__get_Current_Private_Virtual_Final_New_get_VisualTreeAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset._get_templateDependencies_d__19>.NativeClassPtr, 100669441);
				VisualTreeAsset._get_templateDependencies_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset._get_templateDependencies_d__19>.NativeClassPtr, 100669442);
				VisualTreeAsset._get_templateDependencies_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset._get_templateDependencies_d__19>.NativeClassPtr, 100669443);
				VisualTreeAsset._get_templateDependencies_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_UIElements_VisualTreeAsset__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_VisualTreeAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset._get_templateDependencies_d__19>.NativeClassPtr, 100669444);
				VisualTreeAsset._get_templateDependencies_d__19.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeAsset._get_templateDependencies_d__19>.NativeClassPtr, 100669445);
			}

			// Token: 0x06004066 RID: 16486 RVA: 0x000FF9DC File Offset: 0x000FDBDC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_templateDependencies_d__19(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualTreeAsset._get_templateDependencies_d__19>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset._get_templateDependencies_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004067 RID: 16487 RVA: 0x000FFA24 File Offset: 0x000FDC24
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 345172, RefRangeEnd = 345173, XrefRangeStart = 345167, XrefRangeEnd = 345172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset._get_templateDependencies_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004068 RID: 16488 RVA: 0x000FFA58 File Offset: 0x000FDC58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345173, XrefRangeEnd = 345243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset._get_templateDependencies_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004069 RID: 16489 RVA: 0x000FFA94 File Offset: 0x000FDC94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345243, XrefRangeEnd = 345246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset._get_templateDependencies_d__19.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001350 RID: 4944
			// (get) Token: 0x0600406A RID: 16490 RVA: 0x000FFAC8 File Offset: 0x000FDCC8
			public unsafe VisualTreeAsset System.Collections.Generic.IEnumerator<UnityEngine.UIElements.VisualTreeAsset>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset._get_templateDependencies_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_UIElements_VisualTreeAsset__get_Current_Private_Virtual_Final_New_get_VisualTreeAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualTreeAsset>(intPtr3) : null;
				}
			}

			// Token: 0x0600406B RID: 16491 RVA: 0x000FFB08 File Offset: 0x000FDD08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345246, XrefRangeEnd = 345251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset._get_templateDependencies_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001351 RID: 4945
			// (get) Token: 0x0600406C RID: 16492 RVA: 0x000FFB3C File Offset: 0x000FDD3C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset._get_templateDependencies_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600406D RID: 16493 RVA: 0x000FFB7C File Offset: 0x000FDD7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345251, XrefRangeEnd = 345253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<VisualTreeAsset> System_Collections_Generic_IEnumerable_UnityEngine_UIElements_VisualTreeAsset__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset._get_templateDependencies_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_UIElements_VisualTreeAsset__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_VisualTreeAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<VisualTreeAsset>>(intPtr3) : null;
			}

			// Token: 0x0600406E RID: 16494 RVA: 0x000FFBBC File Offset: 0x000FDDBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeAsset._get_templateDependencies_d__19.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600406F RID: 16495 RVA: 0x0001B190 File Offset: 0x00019390
			public _get_templateDependencies_d__19(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001348 RID: 4936
			// (get) Token: 0x06004070 RID: 16496 RVA: 0x000FFBFC File Offset: 0x000FDDFC
			// (set) Token: 0x06004071 RID: 16497 RVA: 0x0001B199 File Offset: 0x00019399
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_templateDependencies_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_templateDependencies_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001349 RID: 4937
			// (get) Token: 0x06004072 RID: 16498 RVA: 0x000FFC24 File Offset: 0x000FDE24
			// (set) Token: 0x06004073 RID: 16499 RVA: 0x0001B1B4 File Offset: 0x000193B4
			public unsafe VisualTreeAsset __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_templateDependencies_d__19.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualTreeAsset>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_templateDependencies_d__19.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700134A RID: 4938
			// (get) Token: 0x06004074 RID: 16500 RVA: 0x000FFC54 File Offset: 0x000FDE54
			// (set) Token: 0x06004075 RID: 16501 RVA: 0x0001B1D3 File Offset: 0x000193D3
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_templateDependencies_d__19.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_templateDependencies_d__19.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700134B RID: 4939
			// (get) Token: 0x06004076 RID: 16502 RVA: 0x000FFC7C File Offset: 0x000FDE7C
			// (set) Token: 0x06004077 RID: 16503 RVA: 0x0001B1EE File Offset: 0x000193EE
			public unsafe VisualTreeAsset __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_templateDependencies_d__19.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualTreeAsset>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_templateDependencies_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700134C RID: 4940
			// (get) Token: 0x06004078 RID: 16504 RVA: 0x000FFCAC File Offset: 0x000FDEAC
			// (set) Token: 0x06004079 RID: 16505 RVA: 0x0001B20D File Offset: 0x0001940D
			public unsafe HashSet<VisualTreeAsset> _sent_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_templateDependencies_d__19.NativeFieldInfoPtr__sent_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<VisualTreeAsset>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_templateDependencies_d__19.NativeFieldInfoPtr__sent_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700134D RID: 4941
			// (get) Token: 0x0600407A RID: 16506 RVA: 0x000FFCDC File Offset: 0x000FDEDC
			// (set) Token: 0x0600407B RID: 16507 RVA: 0x0001B22C File Offset: 0x0001942C
			public List<VisualTreeAsset.UsingEntry>.Enumerator __s__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_templateDependencies_d__19.NativeFieldInfoPtr___s__2);
					return new List<VisualTreeAsset.UsingEntry>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<VisualTreeAsset.UsingEntry>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_templateDependencies_d__19.NativeFieldInfoPtr___s__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<VisualTreeAsset.UsingEntry>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700134E RID: 4942
			// (get) Token: 0x0600407C RID: 16508 RVA: 0x000FFD0C File Offset: 0x000FDF0C
			// (set) Token: 0x0600407D RID: 16509 RVA: 0x0001B25A File Offset: 0x0001945A
			public VisualTreeAsset.UsingEntry _entry_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_templateDependencies_d__19.NativeFieldInfoPtr__entry_5__3);
					return new VisualTreeAsset.UsingEntry(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VisualTreeAsset.UsingEntry>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_templateDependencies_d__19.NativeFieldInfoPtr__entry_5__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VisualTreeAsset.UsingEntry>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700134F RID: 4943
			// (get) Token: 0x0600407E RID: 16510 RVA: 0x000FFD3C File Offset: 0x000FDF3C
			// (set) Token: 0x0600407F RID: 16511 RVA: 0x0001B288 File Offset: 0x00019488
			public unsafe VisualTreeAsset _vta_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_templateDependencies_d__19.NativeFieldInfoPtr__vta_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualTreeAsset>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeAsset._get_templateDependencies_d__19.NativeFieldInfoPtr__vta_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D55 RID: 11605
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002D56 RID: 11606
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002D57 RID: 11607
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002D58 RID: 11608
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002D59 RID: 11609
			private static readonly IntPtr NativeFieldInfoPtr__sent_5__1;

			// Token: 0x04002D5A RID: 11610
			private static readonly IntPtr NativeFieldInfoPtr___s__2;

			// Token: 0x04002D5B RID: 11611
			private static readonly IntPtr NativeFieldInfoPtr__entry_5__3;

			// Token: 0x04002D5C RID: 11612
			private static readonly IntPtr NativeFieldInfoPtr__vta_5__4;

			// Token: 0x04002D5D RID: 11613
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002D5E RID: 11614
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002D5F RID: 11615
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002D60 RID: 11616
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04002D61 RID: 11617
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_UIElements_VisualTreeAsset__get_Current_Private_Virtual_Final_New_get_VisualTreeAsset_0;

			// Token: 0x04002D62 RID: 11618
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002D63 RID: 11619
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002D64 RID: 11620
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_UIElements_VisualTreeAsset__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_VisualTreeAsset_0;

			// Token: 0x04002D65 RID: 11621
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000525 RID: 1317
		private sealed class MethodInfoStoreGeneric_GetUxmlObjects_Internal_List_1_T_IUxmlAttributes_CreationContext_0<T>
		{
			// Token: 0x04002D66 RID: 11622
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(VisualTreeAsset.NativeMethodInfoPtr_GetUxmlObjects_Internal_List_1_T_IUxmlAttributes_CreationContext_0, Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000526 RID: 1318
		private sealed class MethodInfoStoreGeneric_GetAsset_Internal_T_String_0<T>
		{
			// Token: 0x04002D67 RID: 11623
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(VisualTreeAsset.NativeMethodInfoPtr_GetAsset_Internal_T_String_0, Il2CppClassPointerStore<VisualTreeAsset>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000527 RID: 1319
		public sealed class <>c__DisplayClass61_0
		{
		}

		// Token: 0x02000528 RID: 1320
		public sealed class <get_stylesheets>d__23
		{
		}

		// Token: 0x02000529 RID: 1321
		public sealed class <get_templateDependencies>d__19
		{
		}
	}
}
