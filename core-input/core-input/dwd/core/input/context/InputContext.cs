using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using lib.canis.src.util;
using UnityEngine;
using UnityEngine.UI;

namespace dwd.core.input.context
{
	// Token: 0x0200007A RID: 122
	public class InputContext : global::Il2CppSystem.Object
	{
		// Token: 0x060004D9 RID: 1241 RVA: 0x0001612C File Offset: 0x0001432C
		// Note: this type is marked as 'beforefieldinit'.
		static InputContext()
		{
			Il2CppClassPointerStore<InputContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.context", "InputContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputContext>.NativeClassPtr);
			InputContext.NativeFieldInfoPtr_AvailableSelectables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputContext>.NativeClassPtr, "AvailableSelectables");
			InputContext.NativeFieldInfoPtr_SuppressGlobalInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputContext>.NativeClassPtr, "SuppressGlobalInput");
			InputContext.NativeFieldInfoPtr_Layer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputContext>.NativeClassPtr, "Layer");
			InputContext.NativeFieldInfoPtr_initialSelectionPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputContext>.NativeClassPtr, "initialSelectionPriority");
			InputContext.NativeFieldInfoPtr_inputActionLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputContext>.NativeClassPtr, "inputActionLookup");
			InputContext.NativeFieldInfoPtr_contextCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputContext>.NativeClassPtr, "contextCamera");
			InputContext.NativeFieldInfoPtr_cachedSelectionPriorities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputContext>.NativeClassPtr, "cachedSelectionPriorities");
			InputContext.NativeFieldInfoPtr_lastSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputContext>.NativeClassPtr, "lastSelection");
			InputContext.NativeFieldInfoPtr__LastSelectionChangedTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputContext>.NativeClassPtr, "<LastSelectionChangedTime>k__BackingField");
			InputContext.NativeFieldInfoPtr__Version_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputContext>.NativeClassPtr, "<Version>k__BackingField");
			InputContext.NativeMethodInfoPtr_get_LastSelection_Public_get_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContext>.NativeClassPtr, 100663884);
			InputContext.NativeMethodInfoPtr_set_LastSelection_Private_set_Void_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContext>.NativeClassPtr, 100663885);
			InputContext.NativeMethodInfoPtr_get_LastSelectionChangedTime_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContext>.NativeClassPtr, 100663886);
			InputContext.NativeMethodInfoPtr_set_LastSelectionChangedTime_Private_set_Void_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContext>.NativeClassPtr, 100663887);
			InputContext.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContext>.NativeClassPtr, 100663888);
			InputContext.NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContext>.NativeClassPtr, 100663889);
			InputContext.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Selectable_IEnumerable_1_Selectable_IEnumerable_1_InputAction_Boolean_Int32_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContext>.NativeClassPtr, 100663890);
			InputContext.NativeMethodInfoPtr_UpdateAvailableSelectables_Public_Void_IEnumerable_1_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContext>.NativeClassPtr, 100663891);
			InputContext.NativeMethodInfoPtr_GetInitialSelection_Public_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContext>.NativeClassPtr, 100663892);
			InputContext.NativeMethodInfoPtr_GetPrioritizedSelectable_Public_Selectable_IEnumerable_1_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContext>.NativeClassPtr, 100663893);
			InputContext.NativeMethodInfoPtr_ExportInputActions_Public_Void_byref_Dictionary_2_String_List_1_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContext>.NativeClassPtr, 100663894);
			InputContext.NativeMethodInfoPtr_addActionForInputId_Private_Void_String_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContext>.NativeClassPtr, 100663895);
			InputContext.NativeMethodInfoPtr_removeActionForInputId_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContext>.NativeClassPtr, 100663896);
			InputContext.NativeMethodInfoPtr_TrySetLastSelected_Public_Boolean_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContext>.NativeClassPtr, 100663897);
			InputContext.NativeMethodInfoPtr_ClearLastSelected_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContext>.NativeClassPtr, 100663898);
			InputContext.NativeMethodInfoPtr_GetBlockingInputContext_Public_Static_InputContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContext>.NativeClassPtr, 100663899);
			InputContext.NativeMethodInfoPtr_isSelectableValidForInitialSelection_Private_Static_Boolean_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContext>.NativeClassPtr, 100663900);
			InputContext.NativeMethodInfoPtr_SetAxialNavigationCamera_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContext>.NativeClassPtr, 100663901);
			InputContext.NativeMethodInfoPtr_AddInputAction_Public_Void_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContext>.NativeClassPtr, 100663902);
			InputContext.NativeMethodInfoPtr_RemoveInputAction_Public_Void_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContext>.NativeClassPtr, 100663903);
			InputContext.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContext>.NativeClassPtr, 100663904);
			InputContext.NativeMethodInfoPtr_dwd_core_IInputActionExecutor_ExportInputActions_Private_Virtual_Final_New_Void_byref_Dictionary_2_String_List_1_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContext>.NativeClassPtr, 100663905);
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x000163DC File Offset: 0x000145DC
		// (set) Token: 0x060004DB RID: 1243 RVA: 0x0001641C File Offset: 0x0001461C
		public unsafe Selectable LastSelection
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputContext.NativeMethodInfoPtr_get_LastSelection_Public_get_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1123447, RefRangeEnd = 1123449, XrefRangeStart = 1123438, XrefRangeEnd = 1123447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputContext.NativeMethodInfoPtr_set_LastSelection_Private_set_Void_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x00016460 File Offset: 0x00014660
		// (set) Token: 0x060004DD RID: 1245 RVA: 0x0001649C File Offset: 0x0001469C
		public unsafe DateTime LastSelectionChangedTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputContext.NativeMethodInfoPtr_get_LastSelectionChangedTime_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputContext.NativeMethodInfoPtr_set_LastSelectionChangedTime_Private_set_Void_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x000164DC File Offset: 0x000146DC
		// (set) Token: 0x060004DF RID: 1247 RVA: 0x00016518 File Offset: 0x00014718
		public unsafe virtual ulong Version
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputContext.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputContext.NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00016558 File Offset: 0x00014758
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1123544, RefRangeEnd = 1123550, XrefRangeStart = 1123449, XrefRangeEnd = 1123544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputContext(IEnumerable<Selectable> availableSelectables, IEnumerable<Selectable> initialSelectionPriority, IEnumerable<InputAction> inputActions, bool suppressGlobalInput = false, int layer = 0, Camera pCam = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputContext>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(availableSelectables);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(initialSelectionPriority);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inputActions);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suppressGlobalInput;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pCam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputContext.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Selectable_IEnumerable_1_Selectable_IEnumerable_1_InputAction_Boolean_Int32_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x000165F8 File Offset: 0x000147F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1123582, RefRangeEnd = 1123584, XrefRangeStart = 1123550, XrefRangeEnd = 1123582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAvailableSelectables(IEnumerable<Selectable> availableSelectables)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(availableSelectables);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputContext.NativeMethodInfoPtr_UpdateAvailableSelectables_Public_Void_IEnumerable_1_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x0001663C File Offset: 0x0001483C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1123624, RefRangeEnd = 1123629, XrefRangeStart = 1123584, XrefRangeEnd = 1123624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Selectable GetInitialSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputContext.NativeMethodInfoPtr_GetInitialSelection_Public_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x0001667C File Offset: 0x0001487C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1123671, RefRangeEnd = 1123674, XrefRangeStart = 1123629, XrefRangeEnd = 1123671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Selectable GetPrioritizedSelectable(IEnumerable<Selectable> selectables)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectables);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputContext.NativeMethodInfoPtr_GetPrioritizedSelectable_Public_Selectable_IEnumerable_1_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
			}
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x000166CC File Offset: 0x000148CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1123720, RefRangeEnd = 1123723, XrefRangeStart = 1123674, XrefRangeEnd = 1123720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExportInputActions([In] ref Dictionary<string, List<InputAction>> actionLookup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(actionLookup);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(InputContext.NativeMethodInfoPtr_ExportInputActions_Public_Void_byref_Dictionary_2_String_List_1_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				actionLookup = ((intPtr4 == 0) ? null : new Dictionary<string, List<InputAction>>(intPtr4));
			}
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00016724 File Offset: 0x00014924
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1123729, RefRangeEnd = 1123733, XrefRangeStart = 1123723, XrefRangeEnd = 1123729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void addActionForInputId(string inputId, InputAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputContext.NativeMethodInfoPtr_addActionForInputId_Private_Void_String_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00016778 File Offset: 0x00014978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123733, XrefRangeEnd = 1123743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void removeActionForInputId(string inputId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputContext.NativeMethodInfoPtr_removeActionForInputId_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x000167BC File Offset: 0x000149BC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1123746, RefRangeEnd = 1123750, XrefRangeStart = 1123743, XrefRangeEnd = 1123746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrySetLastSelected(Selectable selectable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputContext.NativeMethodInfoPtr_TrySetLastSelected_Public_Boolean_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x0001680C File Offset: 0x00014A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123750, XrefRangeEnd = 1123751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearLastSelected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputContext.NativeMethodInfoPtr_ClearLastSelected_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00016840 File Offset: 0x00014A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123751, XrefRangeEnd = 1123763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputContext GetBlockingInputContext()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputContext.NativeMethodInfoPtr_GetBlockingInputContext_Public_Static_InputContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputContext>(intPtr3) : null;
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00016874 File Offset: 0x00014A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123763, XrefRangeEnd = 1123768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool isSelectableValidForInitialSelection(Selectable selectable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputContext.NativeMethodInfoPtr_isSelectableValidForInitialSelection_Private_Static_Boolean_Selectable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x000168B8 File Offset: 0x00014AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123768, XrefRangeEnd = 1123772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAxialNavigationCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputContext.NativeMethodInfoPtr_SetAxialNavigationCamera_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x000168EC File Offset: 0x00014AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123772, XrefRangeEnd = 1123773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddInputAction(InputAction inputAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputContext.NativeMethodInfoPtr_AddInputAction_Public_Void_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x00016930 File Offset: 0x00014B30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1123783, RefRangeEnd = 1123785, XrefRangeStart = 1123773, XrefRangeEnd = 1123783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveInputAction(InputAction inputAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputContext.NativeMethodInfoPtr_RemoveInputAction_Public_Void_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00016974 File Offset: 0x00014B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123785, XrefRangeEnd = 1123828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputContext.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x000169B8 File Offset: 0x00014BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123828, XrefRangeEnd = 1123829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void dwd_core_IInputActionExecutor_ExportInputActions([In] ref Dictionary<string, List<InputAction>> actionLookup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(actionLookup);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(InputContext.NativeMethodInfoPtr_dwd_core_IInputActionExecutor_ExportInputActions_Private_Virtual_Final_New_Void_byref_Dictionary_2_String_List_1_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				actionLookup = ((intPtr4 == 0) ? null : new Dictionary<string, List<InputAction>>(intPtr4));
			}
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00004BA7 File Offset: 0x00002DA7
		public InputContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x00016A10 File Offset: 0x00014C10
		// (set) Token: 0x060004F2 RID: 1266 RVA: 0x00004BB0 File Offset: 0x00002DB0
		public unsafe ICollection<Selectable> AvailableSelectables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputContext.NativeFieldInfoPtr_AvailableSelectables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICollection<Selectable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputContext.NativeFieldInfoPtr_AvailableSelectables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x00016A40 File Offset: 0x00014C40
		// (set) Token: 0x060004F4 RID: 1268 RVA: 0x00004BCF File Offset: 0x00002DCF
		public unsafe bool SuppressGlobalInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputContext.NativeFieldInfoPtr_SuppressGlobalInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputContext.NativeFieldInfoPtr_SuppressGlobalInput)) = value;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x00016A68 File Offset: 0x00014C68
		// (set) Token: 0x060004F6 RID: 1270 RVA: 0x00004BEA File Offset: 0x00002DEA
		public unsafe int Layer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputContext.NativeFieldInfoPtr_Layer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputContext.NativeFieldInfoPtr_Layer)) = value;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x00016A90 File Offset: 0x00014C90
		// (set) Token: 0x060004F8 RID: 1272 RVA: 0x00004C05 File Offset: 0x00002E05
		public unsafe IReadOnlyCollection<Selectable> initialSelectionPriority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputContext.NativeFieldInfoPtr_initialSelectionPriority);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyCollection<Selectable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputContext.NativeFieldInfoPtr_initialSelectionPriority), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x00016AC0 File Offset: 0x00014CC0
		// (set) Token: 0x060004FA RID: 1274 RVA: 0x00004C24 File Offset: 0x00002E24
		public unsafe Dictionary<string, InputAction> inputActionLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputContext.NativeFieldInfoPtr_inputActionLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, InputAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputContext.NativeFieldInfoPtr_inputActionLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x00016AF0 File Offset: 0x00014CF0
		// (set) Token: 0x060004FC RID: 1276 RVA: 0x00004C43 File Offset: 0x00002E43
		public unsafe Camera contextCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputContext.NativeFieldInfoPtr_contextCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputContext.NativeFieldInfoPtr_contextCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x00016B20 File Offset: 0x00014D20
		// (set) Token: 0x060004FE RID: 1278 RVA: 0x00004C62 File Offset: 0x00002E62
		public unsafe Dictionary<Selectable, Il2CppReferenceArray<InitialSelectionPriority>> cachedSelectionPriorities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputContext.NativeFieldInfoPtr_cachedSelectionPriorities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Selectable, Il2CppReferenceArray<InitialSelectionPriority>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputContext.NativeFieldInfoPtr_cachedSelectionPriorities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x00016B50 File Offset: 0x00014D50
		// (set) Token: 0x06000500 RID: 1280 RVA: 0x00004C81 File Offset: 0x00002E81
		public unsafe Selectable lastSelection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputContext.NativeFieldInfoPtr_lastSelection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputContext.NativeFieldInfoPtr_lastSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000501 RID: 1281 RVA: 0x00016B80 File Offset: 0x00014D80
		// (set) Token: 0x06000502 RID: 1282 RVA: 0x00004CA0 File Offset: 0x00002EA0
		public unsafe DateTime _LastSelectionChangedTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputContext.NativeFieldInfoPtr__LastSelectionChangedTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputContext.NativeFieldInfoPtr__LastSelectionChangedTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x00016BA8 File Offset: 0x00014DA8
		// (set) Token: 0x06000504 RID: 1284 RVA: 0x00004CBB File Offset: 0x00002EBB
		public unsafe ulong _Version_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputContext.NativeFieldInfoPtr__Version_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputContext.NativeFieldInfoPtr__Version_k__BackingField)) = value;
			}
		}

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeFieldInfoPtr_AvailableSelectables;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeFieldInfoPtr_SuppressGlobalInput;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeFieldInfoPtr_Layer;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeFieldInfoPtr_initialSelectionPriority;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeFieldInfoPtr_inputActionLookup;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeFieldInfoPtr_contextCamera;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeFieldInfoPtr_cachedSelectionPriorities;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeFieldInfoPtr_lastSelection;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeFieldInfoPtr__LastSelectionChangedTime_k__BackingField;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeFieldInfoPtr__Version_k__BackingField;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeMethodInfoPtr_get_LastSelection_Public_get_Selectable_0;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeMethodInfoPtr_set_LastSelection_Private_set_Void_Selectable_0;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeMethodInfoPtr_get_LastSelectionChangedTime_Public_get_DateTime_0;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeMethodInfoPtr_set_LastSelectionChangedTime_Private_set_Void_DateTime_0;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Selectable_IEnumerable_1_Selectable_IEnumerable_1_InputAction_Boolean_Int32_Camera_0;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAvailableSelectables_Public_Void_IEnumerable_1_Selectable_0;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeMethodInfoPtr_GetInitialSelection_Public_Selectable_0;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeMethodInfoPtr_GetPrioritizedSelectable_Public_Selectable_IEnumerable_1_Selectable_0;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeMethodInfoPtr_ExportInputActions_Public_Void_byref_Dictionary_2_String_List_1_InputAction_0;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeMethodInfoPtr_addActionForInputId_Private_Void_String_InputAction_0;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeMethodInfoPtr_removeActionForInputId_Private_Void_String_0;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeMethodInfoPtr_TrySetLastSelected_Public_Boolean_Selectable_0;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeMethodInfoPtr_ClearLastSelected_Public_Void_0;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeMethodInfoPtr_GetBlockingInputContext_Public_Static_InputContext_0;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeMethodInfoPtr_isSelectableValidForInitialSelection_Private_Static_Boolean_Selectable_0;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeMethodInfoPtr_SetAxialNavigationCamera_Public_Void_0;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeMethodInfoPtr_AddInputAction_Public_Void_InputAction_0;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeMethodInfoPtr_RemoveInputAction_Public_Void_InputAction_0;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_IInputActionExecutor_ExportInputActions_Private_Virtual_Final_New_Void_byref_Dictionary_2_String_List_1_InputAction_0;

		// Token: 0x020000D2 RID: 210
		[ObfuscatedName("dwd.core.input.context.InputContext+<>O")]
		public static class __O : global::Il2CppSystem.Object
		{
			// Token: 0x06000958 RID: 2392 RVA: 0x00006DE5 File Offset: 0x00004FE5
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<InputContext.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputContext>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputContext.__O>.NativeClassPtr);
				InputContext.__O.NativeFieldInfoPtr__0___isSelectableValidForInitialSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputContext.__O>.NativeClassPtr, "<0>__isSelectableValidForInitialSelection");
			}

			// Token: 0x06000959 RID: 2393 RVA: 0x00006E19 File Offset: 0x00005019
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170002B6 RID: 694
			// (get) Token: 0x0600095A RID: 2394 RVA: 0x000250A0 File Offset: 0x000232A0
			// (set) Token: 0x0600095B RID: 2395 RVA: 0x00006E22 File Offset: 0x00005022
			public unsafe static Func<Selectable, bool> _0___isSelectableValidForInitialSelection
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InputContext.__O.NativeFieldInfoPtr__0___isSelectableValidForInitialSelection, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Selectable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InputContext.__O.NativeFieldInfoPtr__0___isSelectableValidForInitialSelection, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005C9 RID: 1481
			private static readonly IntPtr NativeFieldInfoPtr__0___isSelectableValidForInitialSelection;
		}

		// Token: 0x020000D3 RID: 211
		[ObfuscatedName("dwd.core.input.context.InputContext+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x0600095C RID: 2396 RVA: 0x000250C8 File Offset: 0x000232C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<InputContext.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputContext>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputContext.__c>.NativeClassPtr);
				InputContext.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputContext.__c>.NativeClassPtr, "<>9");
				InputContext.__c.NativeFieldInfoPtr___9__22_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputContext.__c>.NativeClassPtr, "<>9__22_0");
				InputContext.__c.NativeFieldInfoPtr___9__33_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputContext.__c>.NativeClassPtr, "<>9__33_0");
				InputContext.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContext.__c>.NativeClassPtr, 100663907);
				InputContext.__c.NativeMethodInfoPtr__GetPrioritizedSelectable_b__22_0_Internal_Int32_InitialSelectionPriority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContext.__c>.NativeClassPtr, 100663908);
				InputContext.__c.NativeMethodInfoPtr__ToString_b__33_0_Internal_String_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContext.__c>.NativeClassPtr, 100663909);
			}

			// Token: 0x0600095D RID: 2397 RVA: 0x0002516C File Offset: 0x0002336C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputContext.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputContext.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600095E RID: 2398 RVA: 0x000251A8 File Offset: 0x000233A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetPrioritizedSelectable_b__22_0(InitialSelectionPriority p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputContext.__c.NativeMethodInfoPtr__GetPrioritizedSelectable_b__22_0_Internal_Int32_InitialSelectionPriority_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600095F RID: 2399 RVA: 0x000251F8 File Offset: 0x000233F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123431, XrefRangeEnd = 1123438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ToString_b__33_0(Selectable selection)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(selection);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputContext.__c.NativeMethodInfoPtr__ToString_b__33_0_Internal_String_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000960 RID: 2400 RVA: 0x00006E34 File Offset: 0x00005034
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170002B7 RID: 695
			// (get) Token: 0x06000961 RID: 2401 RVA: 0x00025240 File Offset: 0x00023440
			// (set) Token: 0x06000962 RID: 2402 RVA: 0x00006E3D File Offset: 0x0000503D
			public unsafe static InputContext.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InputContext.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputContext.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InputContext.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002B8 RID: 696
			// (get) Token: 0x06000963 RID: 2403 RVA: 0x00025268 File Offset: 0x00023468
			// (set) Token: 0x06000964 RID: 2404 RVA: 0x00006E4F File Offset: 0x0000504F
			public unsafe static Func<InitialSelectionPriority, int> __9__22_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InputContext.__c.NativeFieldInfoPtr___9__22_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<InitialSelectionPriority, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InputContext.__c.NativeFieldInfoPtr___9__22_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002B9 RID: 697
			// (get) Token: 0x06000965 RID: 2405 RVA: 0x00025290 File Offset: 0x00023490
			// (set) Token: 0x06000966 RID: 2406 RVA: 0x00006E61 File Offset: 0x00005061
			public unsafe static Func<Selectable, string> __9__33_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InputContext.__c.NativeFieldInfoPtr___9__33_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Selectable, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InputContext.__c.NativeFieldInfoPtr___9__33_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005CA RID: 1482
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040005CB RID: 1483
			private static readonly IntPtr NativeFieldInfoPtr___9__22_0;

			// Token: 0x040005CC RID: 1484
			private static readonly IntPtr NativeFieldInfoPtr___9__33_0;

			// Token: 0x040005CD RID: 1485
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040005CE RID: 1486
			private static readonly IntPtr NativeMethodInfoPtr__GetPrioritizedSelectable_b__22_0_Internal_Int32_InitialSelectionPriority_0;

			// Token: 0x040005CF RID: 1487
			private static readonly IntPtr NativeMethodInfoPtr__ToString_b__33_0_Internal_String_Selectable_0;
		}
	}
}
