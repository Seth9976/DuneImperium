using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.SmartFormat.Core.Extensions;
using UnityEngine.Localization.SmartFormat.PersistentVariables;
using UnityEngine.Localization.Tables;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization
{
	// Token: 0x02000014 RID: 20
	[Serializable]
	public class LocalizedString : LocalizedReference
	{
		// Token: 0x060000D5 RID: 213 RVA: 0x0000C220 File Offset: 0x0000A420
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizedString()
		{
			Il2CppClassPointerStore<LocalizedString>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization", "LocalizedString");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr);
			LocalizedString.NativeFieldInfoPtr_m_LocalVariables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, "m_LocalVariables");
			LocalizedString.NativeFieldInfoPtr_m_ChangeHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, "m_ChangeHandler");
			LocalizedString.NativeFieldInfoPtr_m_CurrentStringChangedValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, "m_CurrentStringChangedValue");
			LocalizedString.NativeFieldInfoPtr_m_VariableLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, "m_VariableLookup");
			LocalizedString.NativeFieldInfoPtr_m_UsedVariables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, "m_UsedVariables");
			LocalizedString.NativeFieldInfoPtr_m_OnVariableChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, "m_OnVariableChanged");
			LocalizedString.NativeFieldInfoPtr_m_SelectedLocaleChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, "m_SelectedLocaleChanged");
			LocalizedString.NativeFieldInfoPtr_m_AutomaticLoadingCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, "m_AutomaticLoadingCompleted");
			LocalizedString.NativeFieldInfoPtr_m_CompletedSourceValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, "m_CompletedSourceValue");
			LocalizedString.NativeFieldInfoPtr_m_WaitingForVariablesEndUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, "m_WaitingForVariablesEndUpdate");
			LocalizedString.NativeFieldInfoPtr_ValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, "ValueChanged");
			LocalizedString.NativeFieldInfoPtr__Arguments_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, "<Arguments>k__BackingField");
			LocalizedString.NativeFieldInfoPtr__CurrentLoadingOperationHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, "<CurrentLoadingOperationHandle>k__BackingField");
			LocalizedString.NativeMethodInfoPtr_add_ValueChanged_Public_Virtual_Final_New_add_Void_Action_1_IVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663450);
			LocalizedString.NativeMethodInfoPtr_remove_ValueChanged_Public_Virtual_Final_New_rem_Void_Action_1_IVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663451);
			LocalizedString.NativeMethodInfoPtr_get_ForceSynchronous_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663452);
			LocalizedString.NativeMethodInfoPtr_get_Arguments_Public_get_IList_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663453);
			LocalizedString.NativeMethodInfoPtr_set_Arguments_Public_set_Void_IList_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663454);
			LocalizedString.NativeMethodInfoPtr_get_CurrentLoadingOperationHandle_Public_get_AsyncOperationHandle_1_TableEntryResult_StringTable_StringTableEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663455);
			LocalizedString.NativeMethodInfoPtr_set_CurrentLoadingOperationHandle_Internal_set_Void_AsyncOperationHandle_1_TableEntryResult_StringTable_StringTableEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663456);
			LocalizedString.NativeMethodInfoPtr_add_StringChanged_Public_add_Void_ChangeHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663457);
			LocalizedString.NativeMethodInfoPtr_remove_StringChanged_Public_rem_Void_ChangeHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663458);
			LocalizedString.NativeMethodInfoPtr_get_HasChangeHandler_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663459);
			LocalizedString.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663460);
			LocalizedString.NativeMethodInfoPtr__ctor_Public_Void_TableReference_TableEntryReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663461);
			LocalizedString.NativeMethodInfoPtr_RefreshString_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663462);
			LocalizedString.NativeMethodInfoPtr_GetLocalizedStringAsync_Public_AsyncOperationHandle_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663463);
			LocalizedString.NativeMethodInfoPtr_GetLocalizedString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663464);
			LocalizedString.NativeMethodInfoPtr_GetLocalizedStringAsync_Public_AsyncOperationHandle_1_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663465);
			LocalizedString.NativeMethodInfoPtr_GetLocalizedString_Public_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663466);
			LocalizedString.NativeMethodInfoPtr_GetLocalizedString_Public_String_IList_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663467);
			LocalizedString.NativeMethodInfoPtr_GetLocalizedStringAsync_Public_AsyncOperationHandle_1_String_IList_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663468);
			LocalizedString.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663469);
			LocalizedString.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663470);
			LocalizedString.NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_1_IVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663471);
			LocalizedString.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663472);
			LocalizedString.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_IVariable_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663473);
			LocalizedString.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_String_IVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663474);
			LocalizedString.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_String_byref_IVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663475);
			LocalizedString.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_String_IVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663476);
			LocalizedString.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_KeyValuePair_2_String_IVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663477);
			LocalizedString.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663478);
			LocalizedString.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_KeyValuePair_2_String_IVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663479);
			LocalizedString.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663480);
			LocalizedString.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_KeyValuePair_2_String_IVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663481);
			LocalizedString.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_String_IVariable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663482);
			LocalizedString.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_IVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663483);
			LocalizedString.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663484);
			LocalizedString.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663485);
			LocalizedString.NativeMethodInfoPtr_GetSourceValue_Public_Virtual_Final_New_Object_ISelectorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663486);
			LocalizedString.NativeMethodInfoPtr_CompletedSourceValue_Private_Void_AsyncOperationHandle_1_TableEntryResult_StringTable_StringTableEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663487);
			LocalizedString.NativeMethodInfoPtr_ForceUpdate_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663488);
			LocalizedString.NativeMethodInfoPtr_UpdateVariableListeners_Private_Void_List_1_IVariableValueChanged_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663489);
			LocalizedString.NativeMethodInfoPtr_OnVariableChanged_Private_Void_IVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663490);
			LocalizedString.NativeMethodInfoPtr_OnVariablesSourceUpdateCompleted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663491);
			LocalizedString.NativeMethodInfoPtr_InvokeChangeHandler_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663492);
			LocalizedString.NativeMethodInfoPtr_HandleLocaleChange_Private_Void_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663493);
			LocalizedString.NativeMethodInfoPtr_AutomaticLoadingCompleted_Private_Void_AsyncOperationHandle_1_TableEntryResult_StringTable_StringTableEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663494);
			LocalizedString.NativeMethodInfoPtr_ClearLoadingOperation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663495);
			LocalizedString.NativeMethodInfoPtr_Reset_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663496);
			LocalizedString.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663497);
			LocalizedString.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663498);
			LocalizedString.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, 100663499);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000C73C File Offset: 0x0000A93C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065712, XrefRangeEnd = 1065717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_ValueChanged(Action<IVariable> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_add_ValueChanged_Public_Virtual_Final_New_add_Void_Action_1_IVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000C780 File Offset: 0x0000A980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065717, XrefRangeEnd = 1065722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_ValueChanged(Action<IVariable> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_remove_ValueChanged_Public_Virtual_Final_New_rem_Void_Action_1_IVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x0000C7C4 File Offset: 0x0000A9C4
		public unsafe override bool ForceSynchronous
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065722, XrefRangeEnd = 1065723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedString.NativeMethodInfoPtr_get_ForceSynchronous_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x0000C80C File Offset: 0x0000AA0C
		// (set) Token: 0x060000DA RID: 218 RVA: 0x0000C84C File Offset: 0x0000AA4C
		public unsafe IList<Object> Arguments
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_get_Arguments_Public_get_IList_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<Object>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_set_Arguments_Public_set_Void_IList_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000DB RID: 219 RVA: 0x0000C890 File Offset: 0x0000AA90
		// (set) Token: 0x060000DC RID: 220 RVA: 0x0000C8C8 File Offset: 0x0000AAC8
		public unsafe AsyncOperationHandle<LocalizedDatabase<StringTable, StringTableEntry>.TableEntryResult> CurrentLoadingOperationHandle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_get_CurrentLoadingOperationHandle_Public_get_AsyncOperationHandle_1_TableEntryResult_StringTable_StringTableEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<LocalizedDatabase<StringTable, StringTableEntry>.TableEntryResult>(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065723, XrefRangeEnd = 1065724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_set_CurrentLoadingOperationHandle_Internal_set_Void_AsyncOperationHandle_1_TableEntryResult_StringTable_StringTableEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000C910 File Offset: 0x0000AB10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1065735, RefRangeEnd = 1065737, XrefRangeStart = 1065724, XrefRangeEnd = 1065735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_StringChanged(LocalizedString.ChangeHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_add_StringChanged_Public_add_Void_ChangeHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000C954 File Offset: 0x0000AB54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1065743, RefRangeEnd = 1065745, XrefRangeStart = 1065737, XrefRangeEnd = 1065743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_StringChanged(LocalizedString.ChangeHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_remove_StringChanged_Public_rem_Void_ChangeHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000DF RID: 223 RVA: 0x0000C998 File Offset: 0x0000AB98
		public unsafe bool HasChangeHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065745, XrefRangeEnd = 1065746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_get_HasChangeHandler_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000C9D4 File Offset: 0x0000ABD4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1065795, RefRangeEnd = 1065807, XrefRangeStart = 1065746, XrefRangeEnd = 1065795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizedString()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000CA10 File Offset: 0x0000AC10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065807, XrefRangeEnd = 1065816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizedString(TableReference tableReference, TableEntryReference entryReference)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableReference));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(entryReference));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr__ctor_Public_Void_TableReference_TableEntryReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000CA78 File Offset: 0x0000AC78
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1065842, RefRangeEnd = 1065847, XrefRangeStart = 1065816, XrefRangeEnd = 1065842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RefreshString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_RefreshString_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000CAB4 File Offset: 0x0000ACB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1065848, RefRangeEnd = 1065849, XrefRangeStart = 1065847, XrefRangeEnd = 1065848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<string> GetLocalizedStringAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_GetLocalizedStringAsync_Public_AsyncOperationHandle_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<string>(intPtr);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000CAEC File Offset: 0x0000ACEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065849, XrefRangeEnd = 1065853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLocalizedString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_GetLocalizedString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000CB24 File Offset: 0x0000AD24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065853, XrefRangeEnd = 1065854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<string> GetLocalizedStringAsync([Optional] Il2CppReferenceArray<Object> arguments)
		{
			if (arguments == null)
			{
				arguments = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arguments);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_GetLocalizedStringAsync_Public_AsyncOperationHandle_1_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<string>(intPtr);
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000CB7C File Offset: 0x0000AD7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065854, XrefRangeEnd = 1065858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLocalizedString([Optional] Il2CppReferenceArray<Object> arguments)
		{
			if (arguments == null)
			{
				arguments = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arguments);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_GetLocalizedString_Public_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000CBD4 File Offset: 0x0000ADD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065858, XrefRangeEnd = 1065862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLocalizedString(IList<Object> arguments)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arguments);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_GetLocalizedString_Public_String_IList_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000CC1C File Offset: 0x0000AE1C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1065867, RefRangeEnd = 1065872, XrefRangeStart = 1065862, XrefRangeEnd = 1065867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<string> GetLocalizedStringAsync(IList<Object> arguments)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arguments);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_GetLocalizedStringAsync_Public_AsyncOperationHandle_1_String_IList_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<string>(intPtr);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x0000CC64 File Offset: 0x0000AE64
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065872, XrefRangeEnd = 1065876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000EA RID: 234 RVA: 0x0000CCA0 File Offset: 0x0000AEA0
		public unsafe virtual ICollection<string> Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065876, XrefRangeEnd = 1065880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<string>>(intPtr3) : null;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000EB RID: 235 RVA: 0x0000CCE0 File Offset: 0x0000AEE0
		public unsafe virtual ICollection<IVariable> Values
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065880, XrefRangeEnd = 1065905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_1_IVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<IVariable>>(intPtr3) : null;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000EC RID: 236 RVA: 0x0000CD20 File Offset: 0x0000AF20
		public unsafe virtual bool IsReadOnly
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000045 RID: 69
		public unsafe virtual IVariable this[string name]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065905, XrefRangeEnd = 1065908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_IVariable_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IVariable>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065908, XrefRangeEnd = 1065909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_String_IVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000CE00 File Offset: 0x0000B000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065909, XrefRangeEnd = 1065913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryGetValue(string name, out IVariable value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_String_byref_IVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : new IVariable(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000CE70 File Offset: 0x0000B070
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1065942, RefRangeEnd = 1065944, XrefRangeStart = 1065913, XrefRangeEnd = 1065942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(string name, IVariable variable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(variable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_String_IVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000CEC4 File Offset: 0x0000B0C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065944, XrefRangeEnd = 1065947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(KeyValuePair<string, IVariable> item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_KeyValuePair_2_String_IVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000CF0C File Offset: 0x0000B10C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065947, XrefRangeEnd = 1065952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Remove(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000CF5C File Offset: 0x0000B15C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065952, XrefRangeEnd = 1065958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Remove(KeyValuePair<string, IVariable> item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_KeyValuePair_2_String_IVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000CFB0 File Offset: 0x0000B1B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065958, XrefRangeEnd = 1065962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ContainsKey(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000D000 File Offset: 0x0000B200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065962, XrefRangeEnd = 1065968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Contains(KeyValuePair<string, IVariable> item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_KeyValuePair_2_String_IVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000D054 File Offset: 0x0000B254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065968, XrefRangeEnd = 1065988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Il2CppReferenceArray<KeyValuePair<string, IVariable>> array, int arrayIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_String_IVariable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000D0A4 File Offset: 0x0000B2A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065988, XrefRangeEnd = 1065993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<KeyValuePair<string, IVariable>> Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_IVariable_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_IVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<string, IVariable>>>(intPtr3) : null;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000D0E4 File Offset: 0x0000B2E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065993, XrefRangeEnd = 1065998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000D124 File Offset: 0x0000B324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065998, XrefRangeEnd = 1066003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000D158 File Offset: 0x0000B358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066003, XrefRangeEnd = 1066092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetSourceValue(ISelectorInfo selector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_GetSourceValue_Public_Virtual_Final_New_Object_ISelectorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000D1A8 File Offset: 0x0000B3A8
		[CallerCount(0)]
		public unsafe void CompletedSourceValue(AsyncOperationHandle<LocalizedDatabase<StringTable, StringTableEntry>.TableEntryResult> _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_CompletedSourceValue_Private_Void_AsyncOperationHandle_1_TableEntryResult_StringTable_StringTableEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000D1F0 File Offset: 0x0000B3F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066092, XrefRangeEnd = 1066094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ForceUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedString.NativeMethodInfoPtr_ForceUpdate_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000D22C File Offset: 0x0000B42C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1066132, RefRangeEnd = 1066134, XrefRangeStart = 1066094, XrefRangeEnd = 1066132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVariableListeners(List<IVariableValueChanged> variables)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(variables);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_UpdateVariableListeners_Private_Void_List_1_IVariableValueChanged_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000D270 File Offset: 0x0000B470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066134, XrefRangeEnd = 1066143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnVariableChanged(IVariable globalVariable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(globalVariable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_OnVariableChanged_Private_Void_IVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000D2B4 File Offset: 0x0000B4B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066143, XrefRangeEnd = 1066151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnVariablesSourceUpdateCompleted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_OnVariablesSourceUpdateCompleted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000D2E8 File Offset: 0x0000B4E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1066169, RefRangeEnd = 1066170, XrefRangeStart = 1066151, XrefRangeEnd = 1066169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeChangeHandler(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_InvokeChangeHandler_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000D32C File Offset: 0x0000B52C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1066186, RefRangeEnd = 1066187, XrefRangeStart = 1066170, XrefRangeEnd = 1066186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleLocaleChange(Locale locale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locale);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_HandleLocaleChange_Private_Void_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000D370 File Offset: 0x0000B570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066187, XrefRangeEnd = 1066191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AutomaticLoadingCompleted(AsyncOperationHandle<LocalizedDatabase<StringTable, StringTableEntry>.TableEntryResult> loadOperation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(loadOperation));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_AutomaticLoadingCompleted_Private_Void_AsyncOperationHandle_1_TableEntryResult_StringTable_StringTableEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000D3B8 File Offset: 0x0000B5B8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1066205, RefRangeEnd = 1066210, XrefRangeStart = 1066191, XrefRangeEnd = 1066205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearLoadingOperation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_ClearLoadingOperation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000D3EC File Offset: 0x0000B5EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066210, XrefRangeEnd = 1066211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedString.NativeMethodInfoPtr_Reset_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000D428 File Offset: 0x0000B628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066211, XrefRangeEnd = 1066232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedString.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000D464 File Offset: 0x0000B664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066232, XrefRangeEnd = 1066236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedString.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000D4A0 File Offset: 0x0000B6A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066236, XrefRangeEnd = 1066245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000025EC File Offset: 0x000007EC
		public AsyncOperationHandle<string> GetLocalizedStringAsync(params Object[] arguments)
		{
			return this.GetLocalizedStringAsync(new Il2CppReferenceArray<Object>(arguments));
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000025FA File Offset: 0x000007FA
		public string GetLocalizedString(params Object[] arguments)
		{
			return this.GetLocalizedString(new Il2CppReferenceArray<Object>(arguments));
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002608 File Offset: 0x00000808
		public LocalizedString(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600010B RID: 267 RVA: 0x0000D4D4 File Offset: 0x0000B6D4
		// (set) Token: 0x0600010C RID: 268 RVA: 0x00002611 File Offset: 0x00000811
		public unsafe List<VariableNameValuePair> m_LocalVariables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr_m_LocalVariables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VariableNameValuePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr_m_LocalVariables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600010D RID: 269 RVA: 0x0000D504 File Offset: 0x0000B704
		// (set) Token: 0x0600010E RID: 270 RVA: 0x00002630 File Offset: 0x00000830
		public CallbackArray<LocalizedString.ChangeHandler> m_ChangeHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr_m_ChangeHandler);
				return new CallbackArray<LocalizedString.ChangeHandler>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallbackArray<LocalizedString.ChangeHandler>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr_m_ChangeHandler), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallbackArray<LocalizedString.ChangeHandler>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600010F RID: 271 RVA: 0x0000D534 File Offset: 0x0000B734
		// (set) Token: 0x06000110 RID: 272 RVA: 0x0000265E File Offset: 0x0000085E
		public unsafe string m_CurrentStringChangedValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr_m_CurrentStringChangedValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr_m_CurrentStringChangedValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000111 RID: 273 RVA: 0x0000D55C File Offset: 0x0000B75C
		// (set) Token: 0x06000112 RID: 274 RVA: 0x0000267D File Offset: 0x0000087D
		public unsafe Dictionary<string, VariableNameValuePair> m_VariableLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr_m_VariableLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, VariableNameValuePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr_m_VariableLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000113 RID: 275 RVA: 0x0000D58C File Offset: 0x0000B78C
		// (set) Token: 0x06000114 RID: 276 RVA: 0x0000269C File Offset: 0x0000089C
		public unsafe List<IVariableValueChanged> m_UsedVariables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr_m_UsedVariables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IVariableValueChanged>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr_m_UsedVariables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000115 RID: 277 RVA: 0x0000D5BC File Offset: 0x0000B7BC
		// (set) Token: 0x06000116 RID: 278 RVA: 0x000026BB File Offset: 0x000008BB
		public unsafe Action<IVariable> m_OnVariableChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr_m_OnVariableChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IVariable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr_m_OnVariableChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000117 RID: 279 RVA: 0x0000D5EC File Offset: 0x0000B7EC
		// (set) Token: 0x06000118 RID: 280 RVA: 0x000026DA File Offset: 0x000008DA
		public unsafe Action<Locale> m_SelectedLocaleChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr_m_SelectedLocaleChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Locale>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr_m_SelectedLocaleChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000119 RID: 281 RVA: 0x0000D61C File Offset: 0x0000B81C
		// (set) Token: 0x0600011A RID: 282 RVA: 0x000026F9 File Offset: 0x000008F9
		public unsafe Action<AsyncOperationHandle<LocalizedDatabase<StringTable, StringTableEntry>.TableEntryResult>> m_AutomaticLoadingCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr_m_AutomaticLoadingCompleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle<LocalizedDatabase<StringTable, StringTableEntry>.TableEntryResult>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr_m_AutomaticLoadingCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600011B RID: 283 RVA: 0x0000D64C File Offset: 0x0000B84C
		// (set) Token: 0x0600011C RID: 284 RVA: 0x00002718 File Offset: 0x00000918
		public unsafe Action<AsyncOperationHandle<LocalizedDatabase<StringTable, StringTableEntry>.TableEntryResult>> m_CompletedSourceValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr_m_CompletedSourceValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle<LocalizedDatabase<StringTable, StringTableEntry>.TableEntryResult>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr_m_CompletedSourceValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600011D RID: 285 RVA: 0x0000D67C File Offset: 0x0000B87C
		// (set) Token: 0x0600011E RID: 286 RVA: 0x00002737 File Offset: 0x00000937
		public unsafe bool m_WaitingForVariablesEndUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr_m_WaitingForVariablesEndUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr_m_WaitingForVariablesEndUpdate)) = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600011F RID: 287 RVA: 0x0000D6A4 File Offset: 0x0000B8A4
		// (set) Token: 0x06000120 RID: 288 RVA: 0x00002752 File Offset: 0x00000952
		public unsafe Action<IVariable> ValueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr_ValueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IVariable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr_ValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000121 RID: 289 RVA: 0x0000D6D4 File Offset: 0x0000B8D4
		// (set) Token: 0x06000122 RID: 290 RVA: 0x00002771 File Offset: 0x00000971
		public unsafe IList<Object> _Arguments_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr__Arguments_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr__Arguments_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000123 RID: 291 RVA: 0x0000D704 File Offset: 0x0000B904
		// (set) Token: 0x06000124 RID: 292 RVA: 0x00002790 File Offset: 0x00000990
		public AsyncOperationHandle<LocalizedDatabase<StringTable, StringTableEntry>.TableEntryResult> _CurrentLoadingOperationHandle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr__CurrentLoadingOperationHandle_k__BackingField);
				return new AsyncOperationHandle<LocalizedDatabase<StringTable, StringTableEntry>.TableEntryResult>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<LocalizedDatabase<StringTable, StringTableEntry>.TableEntryResult>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.NativeFieldInfoPtr__CurrentLoadingOperationHandle_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<LocalizedDatabase<StringTable, StringTableEntry>.TableEntryResult>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeFieldInfoPtr_m_LocalVariables;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeFieldInfoPtr_m_ChangeHandler;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentStringChangedValue;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeFieldInfoPtr_m_VariableLookup;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeFieldInfoPtr_m_UsedVariables;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeFieldInfoPtr_m_OnVariableChanged;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectedLocaleChanged;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeFieldInfoPtr_m_AutomaticLoadingCompleted;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeFieldInfoPtr_m_CompletedSourceValue;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeFieldInfoPtr_m_WaitingForVariablesEndUpdate;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeFieldInfoPtr_ValueChanged;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeFieldInfoPtr__Arguments_k__BackingField;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeFieldInfoPtr__CurrentLoadingOperationHandle_k__BackingField;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_add_ValueChanged_Public_Virtual_Final_New_add_Void_Action_1_IVariable_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_remove_ValueChanged_Public_Virtual_Final_New_rem_Void_Action_1_IVariable_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_get_ForceSynchronous_Internal_Virtual_get_Boolean_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_get_Arguments_Public_get_IList_1_Object_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_set_Arguments_Public_set_Void_IList_1_Object_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentLoadingOperationHandle_Public_get_AsyncOperationHandle_1_TableEntryResult_StringTable_StringTableEntry_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentLoadingOperationHandle_Internal_set_Void_AsyncOperationHandle_1_TableEntryResult_StringTable_StringTableEntry_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_add_StringChanged_Public_add_Void_ChangeHandler_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_remove_StringChanged_Public_rem_Void_ChangeHandler_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChangeHandler_Public_get_Boolean_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TableReference_TableEntryReference_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_RefreshString_Public_Boolean_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedStringAsync_Public_AsyncOperationHandle_1_String_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedString_Public_String_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedStringAsync_Public_AsyncOperationHandle_1_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedString_Public_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedString_Public_String_IList_1_Object_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedStringAsync_Public_AsyncOperationHandle_1_String_IList_1_Object_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_1_String_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_1_IVariable_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_IVariable_String_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_String_IVariable_0;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_String_byref_IVariable_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_String_IVariable_0;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_KeyValuePair_2_String_IVariable_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_String_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_KeyValuePair_2_String_IVariable_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_String_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_KeyValuePair_2_String_IVariable_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_String_IVariable_Int32_0;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_IVariable_0;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeMethodInfoPtr_GetSourceValue_Public_Virtual_Final_New_Object_ISelectorInfo_0;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr_CompletedSourceValue_Private_Void_AsyncOperationHandle_1_TableEntryResult_StringTable_StringTableEntry_0;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr_ForceUpdate_FamOrAssem_Virtual_Void_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVariableListeners_Private_Void_List_1_IVariableValueChanged_0;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr_OnVariableChanged_Private_Void_IVariable_0;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr_OnVariablesSourceUpdateCompleted_Private_Void_0;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeMethodInfoPtr_InvokeChangeHandler_Private_Void_String_0;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeMethodInfoPtr_HandleLocaleChange_Private_Void_Locale_0;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr_AutomaticLoadingCompleted_Private_Void_AsyncOperationHandle_1_TableEntryResult_StringTable_StringTableEntry_0;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_ClearLoadingOperation_Private_Void_0;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Protected_Virtual_Void_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Void_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x02000113 RID: 275
		public sealed class ChangeHandler : MulticastDelegate
		{
			// Token: 0x06000CBA RID: 3258 RVA: 0x00039174 File Offset: 0x00037374
			// Note: this type is marked as 'beforefieldinit'.
			static ChangeHandler()
			{
				Il2CppClassPointerStore<LocalizedString.ChangeHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, "ChangeHandler");
				LocalizedString.ChangeHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString.ChangeHandler>.NativeClassPtr, 100663500);
				LocalizedString.ChangeHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString.ChangeHandler>.NativeClassPtr, 100663501);
				LocalizedString.ChangeHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString.ChangeHandler>.NativeClassPtr, 100663502);
				LocalizedString.ChangeHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString.ChangeHandler>.NativeClassPtr, 100663503);
			}

			// Token: 0x06000CBB RID: 3259 RVA: 0x000391E8 File Offset: 0x000373E8
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 408098, RefRangeEnd = 408114, XrefRangeStart = 408098, XrefRangeEnd = 408114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ChangeHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedString.ChangeHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.ChangeHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CBC RID: 3260 RVA: 0x00039244 File Offset: 0x00037444
			[CallerCount(0)]
			public unsafe void Invoke(string value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.ChangeHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000CBD RID: 3261 RVA: 0x00039288 File Offset: 0x00037488
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 479320, RefRangeEnd = 479322, XrefRangeStart = 479320, XrefRangeEnd = 479322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(string value, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.ChangeHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06000CBE RID: 3262 RVA: 0x000392FC File Offset: 0x000374FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.ChangeHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000CBF RID: 3263 RVA: 0x000075C7 File Offset: 0x000057C7
			public ChangeHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000CC0 RID: 3264 RVA: 0x000075D0 File Offset: 0x000057D0
			public static implicit operator LocalizedString.ChangeHandler(Action<string> A_0)
			{
				return DelegateSupport.ConvertDelegate<LocalizedString.ChangeHandler>(A_0);
			}

			// Token: 0x06000CC1 RID: 3265 RVA: 0x000075D8 File Offset: 0x000057D8
			public static LocalizedString.ChangeHandler operator +(LocalizedString.ChangeHandler A_0, LocalizedString.ChangeHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<LocalizedString.ChangeHandler>();
			}

			// Token: 0x06000CC2 RID: 3266 RVA: 0x000075E6 File Offset: 0x000057E6
			public static LocalizedString.ChangeHandler operator -(LocalizedString.ChangeHandler A_0, LocalizedString.ChangeHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<LocalizedString.ChangeHandler>();
				}
				return delegate2;
			}

			// Token: 0x040008DD RID: 2269
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040008DE RID: 2270
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0;

			// Token: 0x040008DF RID: 2271
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0;

			// Token: 0x040008E0 RID: 2272
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000114 RID: 276
		public sealed class StringTableEntryVariable : ValueType
		{
			// Token: 0x06000CC3 RID: 3267 RVA: 0x00039340 File Offset: 0x00037540
			// Note: this type is marked as 'beforefieldinit'.
			static StringTableEntryVariable()
			{
				Il2CppClassPointerStore<LocalizedString.StringTableEntryVariable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, "StringTableEntryVariable");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedString.StringTableEntryVariable>.NativeClassPtr);
				LocalizedString.StringTableEntryVariable.NativeFieldInfoPtr_m_Localized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedString.StringTableEntryVariable>.NativeClassPtr, "m_Localized");
				LocalizedString.StringTableEntryVariable.NativeFieldInfoPtr_m_StringTableEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedString.StringTableEntryVariable>.NativeClassPtr, "m_StringTableEntry");
				LocalizedString.StringTableEntryVariable.NativeMethodInfoPtr__ctor_Public_Void_String_StringTableEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString.StringTableEntryVariable>.NativeClassPtr, 100663504);
				LocalizedString.StringTableEntryVariable.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_String_byref_IVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString.StringTableEntryVariable>.NativeClassPtr, 100663505);
				LocalizedString.StringTableEntryVariable.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString.StringTableEntryVariable>.NativeClassPtr, 100663506);
			}

			// Token: 0x06000CC4 RID: 3268 RVA: 0x000393D0 File Offset: 0x000375D0
			[CallerCount(238)]
			[CachedScanResults(RefRangeStart = 342357, RefRangeEnd = 342595, XrefRangeStart = 342357, XrefRangeEnd = 342595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StringTableEntryVariable(string localized, StringTableEntry entry)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedString.StringTableEntryVariable>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(localized);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.StringTableEntryVariable.NativeMethodInfoPtr__ctor_Public_Void_String_StringTableEntry_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CC5 RID: 3269 RVA: 0x00039434 File Offset: 0x00037634
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065611, XrefRangeEnd = 1065630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool TryGetValue(string key, out IVariable value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LocalizedString.StringTableEntryVariable.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_String_byref_IVariable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				value = ((intPtr4 == 0) ? null : new IVariable(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x06000CC6 RID: 3270 RVA: 0x000394AC File Offset: 0x000376AC
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.StringTableEntryVariable.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06000CC7 RID: 3271 RVA: 0x000075F7 File Offset: 0x000057F7
			public StringTableEntryVariable(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000CC8 RID: 3272 RVA: 0x00007600 File Offset: 0x00005800
			public StringTableEntryVariable()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedString.StringTableEntryVariable>.NativeClassPtr))
			{
			}

			// Token: 0x17000374 RID: 884
			// (get) Token: 0x06000CC9 RID: 3273 RVA: 0x000394E8 File Offset: 0x000376E8
			// (set) Token: 0x06000CCA RID: 3274 RVA: 0x00007612 File Offset: 0x00005812
			public unsafe string m_Localized
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.StringTableEntryVariable.NativeFieldInfoPtr_m_Localized);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.StringTableEntryVariable.NativeFieldInfoPtr_m_Localized), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000375 RID: 885
			// (get) Token: 0x06000CCB RID: 3275 RVA: 0x00039510 File Offset: 0x00037710
			// (set) Token: 0x06000CCC RID: 3276 RVA: 0x00007631 File Offset: 0x00005831
			public unsafe StringTableEntry m_StringTableEntry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.StringTableEntryVariable.NativeFieldInfoPtr_m_StringTableEntry);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringTableEntry>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.StringTableEntryVariable.NativeFieldInfoPtr_m_StringTableEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040008E1 RID: 2273
			private static readonly IntPtr NativeFieldInfoPtr_m_Localized;

			// Token: 0x040008E2 RID: 2274
			private static readonly IntPtr NativeFieldInfoPtr_m_StringTableEntry;

			// Token: 0x040008E3 RID: 2275
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_StringTableEntry_0;

			// Token: 0x040008E4 RID: 2276
			private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_String_byref_IVariable_0;

			// Token: 0x040008E5 RID: 2277
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
		}

		// Token: 0x02000115 RID: 277
		public sealed class ChainedLocalVariablesGroup : ValueType
		{
			// Token: 0x06000CCD RID: 3277 RVA: 0x00039540 File Offset: 0x00037740
			// Note: this type is marked as 'beforefieldinit'.
			static ChainedLocalVariablesGroup()
			{
				Il2CppClassPointerStore<LocalizedString.ChainedLocalVariablesGroup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, "ChainedLocalVariablesGroup");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedString.ChainedLocalVariablesGroup>.NativeClassPtr);
				LocalizedString.ChainedLocalVariablesGroup.NativeFieldInfoPtr__ParentGroup_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedString.ChainedLocalVariablesGroup>.NativeClassPtr, "<ParentGroup>k__BackingField");
				LocalizedString.ChainedLocalVariablesGroup.NativeFieldInfoPtr__Group_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedString.ChainedLocalVariablesGroup>.NativeClassPtr, "<Group>k__BackingField");
				LocalizedString.ChainedLocalVariablesGroup.NativeMethodInfoPtr_get_ParentGroup_Private_get_IVariableGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString.ChainedLocalVariablesGroup>.NativeClassPtr, 100663507);
				LocalizedString.ChainedLocalVariablesGroup.NativeMethodInfoPtr_set_ParentGroup_Private_set_Void_IVariableGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString.ChainedLocalVariablesGroup>.NativeClassPtr, 100663508);
				LocalizedString.ChainedLocalVariablesGroup.NativeMethodInfoPtr_get_Group_Private_get_IVariableGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString.ChainedLocalVariablesGroup>.NativeClassPtr, 100663509);
				LocalizedString.ChainedLocalVariablesGroup.NativeMethodInfoPtr_set_Group_Private_set_Void_IVariableGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString.ChainedLocalVariablesGroup>.NativeClassPtr, 100663510);
				LocalizedString.ChainedLocalVariablesGroup.NativeMethodInfoPtr__ctor_Public_Void_IVariableGroup_IVariableGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString.ChainedLocalVariablesGroup>.NativeClassPtr, 100663511);
				LocalizedString.ChainedLocalVariablesGroup.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_String_byref_IVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString.ChainedLocalVariablesGroup>.NativeClassPtr, 100663512);
			}

			// Token: 0x17000378 RID: 888
			// (get) Token: 0x06000CCE RID: 3278 RVA: 0x0003960C File Offset: 0x0003780C
			// (set) Token: 0x06000CCF RID: 3279 RVA: 0x00039650 File Offset: 0x00037850
			public unsafe IVariableGroup ParentGroup
			{
				[CallerCount(99)]
				[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.ChainedLocalVariablesGroup.NativeMethodInfoPtr_get_ParentGroup_Private_get_IVariableGroup_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IVariableGroup>(intPtr3) : null;
				}
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.ChainedLocalVariablesGroup.NativeMethodInfoPtr_set_ParentGroup_Private_set_Void_IVariableGroup_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000379 RID: 889
			// (get) Token: 0x06000CD0 RID: 3280 RVA: 0x00039698 File Offset: 0x00037898
			// (set) Token: 0x06000CD1 RID: 3281 RVA: 0x000396DC File Offset: 0x000378DC
			public unsafe IVariableGroup Group
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.ChainedLocalVariablesGroup.NativeMethodInfoPtr_get_Group_Private_get_IVariableGroup_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IVariableGroup>(intPtr3) : null;
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 315685, RefRangeEnd = 315686, XrefRangeStart = 315685, XrefRangeEnd = 315686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.ChainedLocalVariablesGroup.NativeMethodInfoPtr_set_Group_Private_set_Void_IVariableGroup_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000CD2 RID: 3282 RVA: 0x00039724 File Offset: 0x00037924
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065630, XrefRangeEnd = 1065632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ChainedLocalVariablesGroup(IVariableGroup group, IVariableGroup parent)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedString.ChainedLocalVariablesGroup>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.ChainedLocalVariablesGroup.NativeMethodInfoPtr__ctor_Public_Void_IVariableGroup_IVariableGroup_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CD3 RID: 3283 RVA: 0x00039788 File Offset: 0x00037988
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065632, XrefRangeEnd = 1065638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool TryGetValue(string key, out IVariable value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LocalizedString.ChainedLocalVariablesGroup.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_String_byref_IVariable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				value = ((intPtr4 == 0) ? null : new IVariable(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x06000CD4 RID: 3284 RVA: 0x00007650 File Offset: 0x00005850
			public ChainedLocalVariablesGroup(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000CD5 RID: 3285 RVA: 0x00007659 File Offset: 0x00005859
			public ChainedLocalVariablesGroup()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedString.ChainedLocalVariablesGroup>.NativeClassPtr))
			{
			}

			// Token: 0x17000376 RID: 886
			// (get) Token: 0x06000CD6 RID: 3286 RVA: 0x00039800 File Offset: 0x00037A00
			// (set) Token: 0x06000CD7 RID: 3287 RVA: 0x0000766B File Offset: 0x0000586B
			public unsafe IVariableGroup _ParentGroup_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.ChainedLocalVariablesGroup.NativeFieldInfoPtr__ParentGroup_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IVariableGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.ChainedLocalVariablesGroup.NativeFieldInfoPtr__ParentGroup_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000377 RID: 887
			// (get) Token: 0x06000CD8 RID: 3288 RVA: 0x00039830 File Offset: 0x00037A30
			// (set) Token: 0x06000CD9 RID: 3289 RVA: 0x0000768A File Offset: 0x0000588A
			public unsafe IVariableGroup _Group_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.ChainedLocalVariablesGroup.NativeFieldInfoPtr__Group_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IVariableGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.ChainedLocalVariablesGroup.NativeFieldInfoPtr__Group_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040008E6 RID: 2278
			private static readonly IntPtr NativeFieldInfoPtr__ParentGroup_k__BackingField;

			// Token: 0x040008E7 RID: 2279
			private static readonly IntPtr NativeFieldInfoPtr__Group_k__BackingField;

			// Token: 0x040008E8 RID: 2280
			private static readonly IntPtr NativeMethodInfoPtr_get_ParentGroup_Private_get_IVariableGroup_0;

			// Token: 0x040008E9 RID: 2281
			private static readonly IntPtr NativeMethodInfoPtr_set_ParentGroup_Private_set_Void_IVariableGroup_0;

			// Token: 0x040008EA RID: 2282
			private static readonly IntPtr NativeMethodInfoPtr_get_Group_Private_get_IVariableGroup_0;

			// Token: 0x040008EB RID: 2283
			private static readonly IntPtr NativeMethodInfoPtr_set_Group_Private_set_Void_IVariableGroup_0;

			// Token: 0x040008EC RID: 2284
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IVariableGroup_IVariableGroup_0;

			// Token: 0x040008ED RID: 2285
			private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_String_byref_IVariable_0;
		}

		// Token: 0x02000116 RID: 278
		[ObfuscatedName("UnityEngine.Localization.LocalizedString+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000CDA RID: 3290 RVA: 0x00039860 File Offset: 0x00037A60
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LocalizedString.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedString.__c>.NativeClassPtr);
				LocalizedString.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedString.__c>.NativeClassPtr, "<>9");
				LocalizedString.__c.NativeFieldInfoPtr___9__43_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedString.__c>.NativeClassPtr, "<>9__43_0");
				LocalizedString.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString.__c>.NativeClassPtr, 100663514);
				LocalizedString.__c.NativeMethodInfoPtr__get_Values_b__43_0_Internal_IVariable_VariableNameValuePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString.__c>.NativeClassPtr, 100663515);
			}

			// Token: 0x06000CDB RID: 3291 RVA: 0x000398DC File Offset: 0x00037ADC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedString.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CDC RID: 3292 RVA: 0x00039918 File Offset: 0x00037B18
			[CallerCount(0)]
			public unsafe IVariable _get_Values_b__43_0(VariableNameValuePair s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.__c.NativeMethodInfoPtr__get_Values_b__43_0_Internal_IVariable_VariableNameValuePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IVariable>(intPtr3) : null;
				}
			}

			// Token: 0x06000CDD RID: 3293 RVA: 0x000076A9 File Offset: 0x000058A9
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700037A RID: 890
			// (get) Token: 0x06000CDE RID: 3294 RVA: 0x00039968 File Offset: 0x00037B68
			// (set) Token: 0x06000CDF RID: 3295 RVA: 0x000076B2 File Offset: 0x000058B2
			public unsafe static LocalizedString.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LocalizedString.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedString.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LocalizedString.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700037B RID: 891
			// (get) Token: 0x06000CE0 RID: 3296 RVA: 0x00039990 File Offset: 0x00037B90
			// (set) Token: 0x06000CE1 RID: 3297 RVA: 0x000076C4 File Offset: 0x000058C4
			public unsafe static Func<VariableNameValuePair, IVariable> __9__43_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LocalizedString.__c.NativeFieldInfoPtr___9__43_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<VariableNameValuePair, IVariable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LocalizedString.__c.NativeFieldInfoPtr___9__43_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040008EE RID: 2286
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040008EF RID: 2287
			private static readonly IntPtr NativeFieldInfoPtr___9__43_0;

			// Token: 0x040008F0 RID: 2288
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040008F1 RID: 2289
			private static readonly IntPtr NativeMethodInfoPtr__get_Values_b__43_0_Internal_IVariable_VariableNameValuePair_0;
		}

		// Token: 0x02000117 RID: 279
		[ObfuscatedName("UnityEngine.Localization.LocalizedString+<GetEnumerator>d__58")]
		public sealed class _GetEnumerator_d__58 : Object
		{
			// Token: 0x06000CE2 RID: 3298 RVA: 0x000399B8 File Offset: 0x00037BB8
			// Note: this type is marked as 'beforefieldinit'.
			static _GetEnumerator_d__58()
			{
				Il2CppClassPointerStore<LocalizedString._GetEnumerator_d__58>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, "<GetEnumerator>d__58");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedString._GetEnumerator_d__58>.NativeClassPtr);
				LocalizedString._GetEnumerator_d__58.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedString._GetEnumerator_d__58>.NativeClassPtr, "<>1__state");
				LocalizedString._GetEnumerator_d__58.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedString._GetEnumerator_d__58>.NativeClassPtr, "<>2__current");
				LocalizedString._GetEnumerator_d__58.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedString._GetEnumerator_d__58>.NativeClassPtr, "<>4__this");
				LocalizedString._GetEnumerator_d__58.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedString._GetEnumerator_d__58>.NativeClassPtr, "<>7__wrap1");
				LocalizedString._GetEnumerator_d__58.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString._GetEnumerator_d__58>.NativeClassPtr, 100663516);
				LocalizedString._GetEnumerator_d__58.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString._GetEnumerator_d__58>.NativeClassPtr, 100663517);
				LocalizedString._GetEnumerator_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString._GetEnumerator_d__58>.NativeClassPtr, 100663518);
				LocalizedString._GetEnumerator_d__58.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString._GetEnumerator_d__58>.NativeClassPtr, 100663519);
				LocalizedString._GetEnumerator_d__58.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString._GetEnumerator_d__58>.NativeClassPtr, 100663520);
				LocalizedString._GetEnumerator_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString._GetEnumerator_d__58>.NativeClassPtr, 100663521);
				LocalizedString._GetEnumerator_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString._GetEnumerator_d__58>.NativeClassPtr, 100663522);
			}

			// Token: 0x06000CE3 RID: 3299 RVA: 0x00039AC0 File Offset: 0x00037CC0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetEnumerator_d__58(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedString._GetEnumerator_d__58>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString._GetEnumerator_d__58.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000CE4 RID: 3300 RVA: 0x00039B08 File Offset: 0x00037D08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065638, XrefRangeEnd = 1065643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString._GetEnumerator_d__58.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CE5 RID: 3301 RVA: 0x00039B3C File Offset: 0x00037D3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065643, XrefRangeEnd = 1065667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString._GetEnumerator_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000CE6 RID: 3302 RVA: 0x00039B78 File Offset: 0x00037D78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065667, XrefRangeEnd = 1065670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString._GetEnumerator_d__58.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000380 RID: 896
			// (get) Token: 0x06000CE7 RID: 3303 RVA: 0x00039BAC File Offset: 0x00037DAC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString._GetEnumerator_d__58.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000CE8 RID: 3304 RVA: 0x00039BEC File Offset: 0x00037DEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065670, XrefRangeEnd = 1065675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString._GetEnumerator_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000381 RID: 897
			// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x00039C20 File Offset: 0x00037E20
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString._GetEnumerator_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000CEA RID: 3306 RVA: 0x000076D6 File Offset: 0x000058D6
			public _GetEnumerator_d__58(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700037C RID: 892
			// (get) Token: 0x06000CEB RID: 3307 RVA: 0x00039C60 File Offset: 0x00037E60
			// (set) Token: 0x06000CEC RID: 3308 RVA: 0x000076DF File Offset: 0x000058DF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString._GetEnumerator_d__58.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString._GetEnumerator_d__58.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700037D RID: 893
			// (get) Token: 0x06000CED RID: 3309 RVA: 0x00039C88 File Offset: 0x00037E88
			// (set) Token: 0x06000CEE RID: 3310 RVA: 0x000076FA File Offset: 0x000058FA
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString._GetEnumerator_d__58.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString._GetEnumerator_d__58.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700037E RID: 894
			// (get) Token: 0x06000CEF RID: 3311 RVA: 0x00039CB8 File Offset: 0x00037EB8
			// (set) Token: 0x06000CF0 RID: 3312 RVA: 0x00007719 File Offset: 0x00005919
			public unsafe LocalizedString __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString._GetEnumerator_d__58.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString._GetEnumerator_d__58.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700037F RID: 895
			// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x00039CE8 File Offset: 0x00037EE8
			// (set) Token: 0x06000CF2 RID: 3314 RVA: 0x00007738 File Offset: 0x00005938
			public Dictionary<string, VariableNameValuePair>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString._GetEnumerator_d__58.NativeFieldInfoPtr___7__wrap1);
					return new Dictionary<string, VariableNameValuePair>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Dictionary<string, VariableNameValuePair>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString._GetEnumerator_d__58.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Dictionary<string, VariableNameValuePair>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040008F2 RID: 2290
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040008F3 RID: 2291
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040008F4 RID: 2292
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040008F5 RID: 2293
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040008F6 RID: 2294
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040008F7 RID: 2295
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040008F8 RID: 2296
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040008F9 RID: 2297
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040008FA RID: 2298
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040008FB RID: 2299
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040008FC RID: 2300
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000118 RID: 280
		[ObfuscatedName("UnityEngine.Localization.LocalizedString+<System-Collections-Generic-IEnumerable<System-Collections-Generic-KeyValuePair<System-String,UnityEngine-Localization-SmartFormat-PersistentVariables-IVariable>>-GetEnumerator>d__57")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique : Object
		{
			// Token: 0x06000CF3 RID: 3315 RVA: 0x00039D18 File Offset: 0x00037F18
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique()
			{
				Il2CppClassPointerStore<LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, "<System-Collections-Generic-IEnumerable<System-Collections-Generic-KeyValuePair<System-String,UnityEngine-Localization-SmartFormat-PersistentVariables-IVariable>>-GetEnumerator>d__57");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique>.NativeClassPtr);
				LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique>.NativeClassPtr, "<>1__state");
				LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique>.NativeClassPtr, "<>2__current");
				LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique>.NativeClassPtr, "<>4__this");
				LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique>.NativeClassPtr, "<>7__wrap1");
				LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique>.NativeClassPtr, 100663523);
				LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique>.NativeClassPtr, 100663524);
				LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique>.NativeClassPtr, 100663525);
				LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique>.NativeClassPtr, 100663526);
				LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_IVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique>.NativeClassPtr, 100663527);
				LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique>.NativeClassPtr, 100663528);
				LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique>.NativeClassPtr, 100663529);
			}

			// Token: 0x06000CF4 RID: 3316 RVA: 0x00039E20 File Offset: 0x00038020
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000CF5 RID: 3317 RVA: 0x00039E68 File Offset: 0x00038068
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065675, XrefRangeEnd = 1065680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CF6 RID: 3318 RVA: 0x00039E9C File Offset: 0x0003809C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065680, XrefRangeEnd = 1065701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000CF7 RID: 3319 RVA: 0x00039ED8 File Offset: 0x000380D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065701, XrefRangeEnd = 1065704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000386 RID: 902
			// (get) Token: 0x06000CF8 RID: 3320 RVA: 0x00039F0C File Offset: 0x0003810C
			public unsafe KeyValuePair<string, IVariable> prop_KeyValuePair_2_String_IVariable_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_IVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new KeyValuePair<string, IVariable>(intPtr);
				}
			}

			// Token: 0x06000CF9 RID: 3321 RVA: 0x00039F44 File Offset: 0x00038144
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065704, XrefRangeEnd = 1065709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000387 RID: 903
			// (get) Token: 0x06000CFA RID: 3322 RVA: 0x00039F78 File Offset: 0x00038178
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065709, XrefRangeEnd = 1065712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000CFB RID: 3323 RVA: 0x00007766 File Offset: 0x00005966
			public ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000382 RID: 898
			// (get) Token: 0x06000CFC RID: 3324 RVA: 0x00039FB8 File Offset: 0x000381B8
			// (set) Token: 0x06000CFD RID: 3325 RVA: 0x0000776F File Offset: 0x0000596F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000383 RID: 899
			// (get) Token: 0x06000CFE RID: 3326 RVA: 0x00039FE0 File Offset: 0x000381E0
			// (set) Token: 0x06000CFF RID: 3327 RVA: 0x0000778A File Offset: 0x0000598A
			public KeyValuePair<string, IVariable> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique.NativeFieldInfoPtr___2__current);
					return new KeyValuePair<string, IVariable>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<string, IVariable>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<string, IVariable>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000384 RID: 900
			// (get) Token: 0x06000D00 RID: 3328 RVA: 0x0003A010 File Offset: 0x00038210
			// (set) Token: 0x06000D01 RID: 3329 RVA: 0x000077B8 File Offset: 0x000059B8
			public unsafe LocalizedString __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000385 RID: 901
			// (get) Token: 0x06000D02 RID: 3330 RVA: 0x0003A040 File Offset: 0x00038240
			// (set) Token: 0x06000D03 RID: 3331 RVA: 0x000077D7 File Offset: 0x000059D7
			public Dictionary<string, VariableNameValuePair>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique.NativeFieldInfoPtr___7__wrap1);
					return new Dictionary<string, VariableNameValuePair>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Dictionary<string, VariableNameValuePair>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedString.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVLoEnVa2StUnique.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Dictionary<string, VariableNameValuePair>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040008FD RID: 2301
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040008FE RID: 2302
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040008FF RID: 2303
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000900 RID: 2304
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04000901 RID: 2305
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000902 RID: 2306
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000903 RID: 2307
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000904 RID: 2308
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000905 RID: 2309
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_IVariable_0;

			// Token: 0x04000906 RID: 2310
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000907 RID: 2311
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
