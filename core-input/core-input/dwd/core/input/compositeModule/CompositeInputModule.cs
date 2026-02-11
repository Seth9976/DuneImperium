using System;
using dwd.core.input.compositeModule.activation;
using dwd.core.input.compositeModule.eventDispatch;
using dwd.core.input.compositeModule.inputDetection;
using dwd.core.input.compositeModule.inputLocks;
using dwd.core.input.compositeModule.navigation;
using dwd.core.input.compositeModule.selectOnActivation;
using dwd.core.input.context;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace dwd.core.input.compositeModule
{
	// Token: 0x02000084 RID: 132
	public sealed class CompositeInputModule : BaseInputModule
	{
		// Token: 0x06000586 RID: 1414 RVA: 0x000185C4 File Offset: 0x000167C4
		// Note: this type is marked as 'beforefieldinit'.
		static CompositeInputModule()
		{
			Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.compositeModule", "CompositeInputModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr);
			CompositeInputModule.NativeFieldInfoPtr_activationStrategy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, "activationStrategy");
			CompositeInputModule.NativeFieldInfoPtr_initialSelectionStrategy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, "initialSelectionStrategy");
			CompositeInputModule.NativeFieldInfoPtr_navigationStrategy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, "navigationStrategy");
			CompositeInputModule.NativeFieldInfoPtr_eventDispatchStrategy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, "eventDispatchStrategy");
			CompositeInputModule.NativeFieldInfoPtr_allowPersistentSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, "allowPersistentSelection");
			CompositeInputModule.NativeFieldInfoPtr_persistenceIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, "persistenceIdentifier");
			CompositeInputModule.NativeFieldInfoPtr_typeIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, "typeIdentifier");
			CompositeInputModule.NativeFieldInfoPtr_inputDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, "inputDetector");
			CompositeInputModule.NativeFieldInfoPtr_moduleActivator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, "moduleActivator");
			CompositeInputModule.NativeFieldInfoPtr_onActivationSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, "onActivationSelector");
			CompositeInputModule.NativeFieldInfoPtr_selectionNavigator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, "selectionNavigator");
			CompositeInputModule.NativeFieldInfoPtr_eventDispatcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, "eventDispatcher");
			CompositeInputModule.NativeFieldInfoPtr_globalInputDispatcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, "globalInputDispatcher");
			CompositeInputModule.NativeFieldInfoPtr_contextManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, "contextManager");
			CompositeInputModule.NativeFieldInfoPtr_selectedGameObjectLastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, "selectedGameObjectLastFrame");
			CompositeInputModule.NativeFieldInfoPtr_currentSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, "currentSelection");
			CompositeInputModule.NativeFieldInfoPtr_pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, "pointer");
			CompositeInputModule.NativeFieldInfoPtr_lastSelectedGameObjectWhileActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, "lastSelectedGameObjectWhileActive");
			CompositeInputModule.NativeFieldInfoPtr_persistedIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, "persistedIdentifier");
			CompositeInputModule.NativeFieldInfoPtr_sortedInputActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, "sortedInputActions");
			CompositeInputModule.NativeFieldInfoPtr_inputProcessingLocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, "inputProcessingLocks");
			CompositeInputModule.NativeMethodInfoPtr_get_AllowPersistentSelection_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, 100663982);
			CompositeInputModule.NativeMethodInfoPtr_get_TypeIdentifier_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, 100663983);
			CompositeInputModule.NativeMethodInfoPtr_get_InputDetector_Public_get_InputDetector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, 100663984);
			CompositeInputModule.NativeMethodInfoPtr_get_activeContext_Private_get_InputContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, 100663985);
			CompositeInputModule.NativeMethodInfoPtr_get_InputLocked_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, 100663986);
			CompositeInputModule.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, 100663987);
			CompositeInputModule.NativeMethodInfoPtr_initializeStrategyFromComponents_Private_Void_byref_TStrategy_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, 100663988);
			CompositeInputModule.NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, 100663989);
			CompositeInputModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, 100663990);
			CompositeInputModule.NativeMethodInfoPtr_DeactivateModule_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, 100663991);
			CompositeInputModule.NativeMethodInfoPtr_UpdateModule_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, 100663992);
			CompositeInputModule.NativeMethodInfoPtr_Process_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, 100663993);
			CompositeInputModule.NativeMethodInfoPtr_RegisterInputProcessingLock_Public_Void_ILockInputProcessing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, 100663994);
			CompositeInputModule.NativeMethodInfoPtr_UnregisterInputProcessingLock_Public_Void_ILockInputProcessing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, 100663995);
			CompositeInputModule.NativeMethodInfoPtr_sendUpdateEventToSelectedObject_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, 100663996);
			CompositeInputModule.NativeMethodInfoPtr_processNavigation_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, 100663997);
			CompositeInputModule.NativeMethodInfoPtr_processEventDispatch_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, 100663998);
			CompositeInputModule.NativeMethodInfoPtr_executeInputActions_Private_Void_Dictionary_2_String_List_1_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, 100663999);
			CompositeInputModule.NativeMethodInfoPtr_ExecuteInput_Public_Void_Dictionary_2_String_List_1_InputAction_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, 100664000);
			CompositeInputModule.NativeMethodInfoPtr_clearNonPersistentSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, 100664001);
			CompositeInputModule.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, 100664002);
			CompositeInputModule.NativeMethodInfoPtr_IsPointerOverGameObject_Public_Virtual_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, 100664003);
			CompositeInputModule.NativeMethodInfoPtr_PointerForIndex_Public_PointerEventData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, 100664004);
			CompositeInputModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, 100664005);
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x00018978 File Offset: 0x00016B78
		public unsafe bool AllowPersistentSelection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeInputModule.NativeMethodInfoPtr_get_AllowPersistentSelection_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x000189B4 File Offset: 0x00016BB4
		public unsafe string TypeIdentifier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeInputModule.NativeMethodInfoPtr_get_TypeIdentifier_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x000189EC File Offset: 0x00016BEC
		public unsafe InputDetector InputDetector
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeInputModule.NativeMethodInfoPtr_get_InputDetector_Public_get_InputDetector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputDetector>(intPtr3) : null;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x00018A2C File Offset: 0x00016C2C
		public unsafe InputContext activeContext
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 1124402, RefRangeEnd = 1124413, XrefRangeStart = 1124397, XrefRangeEnd = 1124402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeInputModule.NativeMethodInfoPtr_get_activeContext_Private_get_InputContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputContext>(intPtr3) : null;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x00018A6C File Offset: 0x00016C6C
		public unsafe bool InputLocked
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1124426, RefRangeEnd = 1124427, XrefRangeStart = 1124413, XrefRangeEnd = 1124426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeInputModule.NativeMethodInfoPtr_get_InputLocked_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00018AA8 File Offset: 0x00016CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124427, XrefRangeEnd = 1124472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeInputModule.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00018ADC File Offset: 0x00016CDC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1124485, RefRangeEnd = 1124489, XrefRangeStart = 1124472, XrefRangeEnd = 1124485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void initializeStrategyFromComponents<TStrategy>(out TStrategy strategy, string strategyName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr2;
				if (!typeof(TStrategy).IsValueType)
				{
					intPtr = 0;
					intPtr2 = &intPtr;
				}
				else
				{
					intPtr2 = ref strategy;
				}
				ptr2 = intPtr2;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strategyName);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(CompositeInputModule.MethodInfoStoreGeneric_initializeStrategyFromComponents_Private_Void_byref_TStrategy_String_0<TStrategy>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(TStrategy).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				strategy = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TStrategy>(intPtr5, false, false));
			}
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00018B6C File Offset: 0x00016D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124489, XrefRangeEnd = 1124506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldActivateModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeInputModule.NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00018BA8 File Offset: 0x00016DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124506, XrefRangeEnd = 1124524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActivateModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeInputModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00018BDC File Offset: 0x00016DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124524, XrefRangeEnd = 1124538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DeactivateModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeInputModule.NativeMethodInfoPtr_DeactivateModule_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00018C10 File Offset: 0x00016E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124538, XrefRangeEnd = 1124562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeInputModule.NativeMethodInfoPtr_UpdateModule_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x00018C44 File Offset: 0x00016E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124562, XrefRangeEnd = 1124655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Process()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeInputModule.NativeMethodInfoPtr_Process_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00018C78 File Offset: 0x00016E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124655, XrefRangeEnd = 1124664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterInputProcessingLock(ILockInputProcessing inputProcessingLock)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputProcessingLock);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeInputModule.NativeMethodInfoPtr_RegisterInputProcessingLock_Public_Void_ILockInputProcessing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00018CBC File Offset: 0x00016EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124664, XrefRangeEnd = 1124673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterInputProcessingLock(ILockInputProcessing inputProcessingLock)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputProcessingLock);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeInputModule.NativeMethodInfoPtr_UnregisterInputProcessingLock_Public_Void_ILockInputProcessing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00018D00 File Offset: 0x00016F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124673, XrefRangeEnd = 1124687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void sendUpdateEventToSelectedObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeInputModule.NativeMethodInfoPtr_sendUpdateEventToSelectedObject_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00018D34 File Offset: 0x00016F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124687, XrefRangeEnd = 1124700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool processNavigation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeInputModule.NativeMethodInfoPtr_processNavigation_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00018D70 File Offset: 0x00016F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124700, XrefRangeEnd = 1124705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool processEventDispatch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeInputModule.NativeMethodInfoPtr_processEventDispatch_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00018DAC File Offset: 0x00016FAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1124748, RefRangeEnd = 1124749, XrefRangeStart = 1124705, XrefRangeEnd = 1124748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void executeInputActions(Dictionary<string, List<InputAction>> inputActionLookup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputActionLookup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeInputModule.NativeMethodInfoPtr_executeInputActions_Private_Void_Dictionary_2_String_List_1_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00018DF0 File Offset: 0x00016FF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1124765, RefRangeEnd = 1124767, XrefRangeStart = 1124749, XrefRangeEnd = 1124765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteInput(Dictionary<string, List<InputAction>> inputActionLookup, string inputId, float value = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputActionLookup);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(inputId);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeInputModule.NativeMethodInfoPtr_ExecuteInput_Public_Void_Dictionary_2_String_List_1_InputAction_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00018E54 File Offset: 0x00017054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124767, XrefRangeEnd = 1124784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void clearNonPersistentSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeInputModule.NativeMethodInfoPtr_clearNonPersistentSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00018E88 File Offset: 0x00017088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124784, XrefRangeEnd = 1124829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeInputModule.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00018EC0 File Offset: 0x000170C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124829, XrefRangeEnd = 1124833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsPointerOverGameObject(int pointerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeInputModule.NativeMethodInfoPtr_IsPointerOverGameObject_Public_Virtual_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00018F0C File Offset: 0x0001710C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1124837, RefRangeEnd = 1124838, XrefRangeStart = 1124833, XrefRangeEnd = 1124837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerEventData PointerForIndex(int pointerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeInputModule.NativeMethodInfoPtr_PointerForIndex_Public_PointerEventData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr3) : null;
			}
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00018F58 File Offset: 0x00017158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124838, XrefRangeEnd = 1124866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompositeInputModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeInputModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x0000507E File Offset: 0x0000327E
		public CompositeInputModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060005A0 RID: 1440 RVA: 0x00018F94 File Offset: 0x00017194
		// (set) Token: 0x060005A1 RID: 1441 RVA: 0x00005087 File Offset: 0x00003287
		public unsafe string activationStrategy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_activationStrategy);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_activationStrategy), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x00018FBC File Offset: 0x000171BC
		// (set) Token: 0x060005A3 RID: 1443 RVA: 0x000050A6 File Offset: 0x000032A6
		public unsafe string initialSelectionStrategy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_initialSelectionStrategy);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_initialSelectionStrategy), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x00018FE4 File Offset: 0x000171E4
		// (set) Token: 0x060005A5 RID: 1445 RVA: 0x000050C5 File Offset: 0x000032C5
		public unsafe string navigationStrategy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_navigationStrategy);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_navigationStrategy), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x0001900C File Offset: 0x0001720C
		// (set) Token: 0x060005A7 RID: 1447 RVA: 0x000050E4 File Offset: 0x000032E4
		public unsafe string eventDispatchStrategy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_eventDispatchStrategy);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_eventDispatchStrategy), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x00019034 File Offset: 0x00017234
		// (set) Token: 0x060005A9 RID: 1449 RVA: 0x00005103 File Offset: 0x00003303
		public unsafe bool allowPersistentSelection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_allowPersistentSelection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_allowPersistentSelection)) = value;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x0001905C File Offset: 0x0001725C
		// (set) Token: 0x060005AB RID: 1451 RVA: 0x0000511E File Offset: 0x0000331E
		public unsafe string persistenceIdentifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_persistenceIdentifier);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_persistenceIdentifier), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x00019084 File Offset: 0x00017284
		// (set) Token: 0x060005AD RID: 1453 RVA: 0x0000513D File Offset: 0x0000333D
		public unsafe string typeIdentifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_typeIdentifier);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_typeIdentifier), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x000190AC File Offset: 0x000172AC
		// (set) Token: 0x060005AF RID: 1455 RVA: 0x0000515C File Offset: 0x0000335C
		public unsafe InputDetector inputDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_inputDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_inputDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x000190DC File Offset: 0x000172DC
		// (set) Token: 0x060005B1 RID: 1457 RVA: 0x0000517B File Offset: 0x0000337B
		public unsafe IModuleActivationStrategy moduleActivator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_moduleActivator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IModuleActivationStrategy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_moduleActivator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060005B2 RID: 1458 RVA: 0x0001910C File Offset: 0x0001730C
		// (set) Token: 0x060005B3 RID: 1459 RVA: 0x0000519A File Offset: 0x0000339A
		public unsafe ISelectOnActivationStrategy onActivationSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_onActivationSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISelectOnActivationStrategy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_onActivationSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x0001913C File Offset: 0x0001733C
		// (set) Token: 0x060005B5 RID: 1461 RVA: 0x000051B9 File Offset: 0x000033B9
		public unsafe ISelectionNavigationStrategy selectionNavigator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_selectionNavigator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISelectionNavigationStrategy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_selectionNavigator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060005B6 RID: 1462 RVA: 0x0001916C File Offset: 0x0001736C
		// (set) Token: 0x060005B7 RID: 1463 RVA: 0x000051D8 File Offset: 0x000033D8
		public unsafe IEventDispatchStrategy eventDispatcher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_eventDispatcher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEventDispatchStrategy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_eventDispatcher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x0001919C File Offset: 0x0001739C
		// (set) Token: 0x060005B9 RID: 1465 RVA: 0x000051F7 File Offset: 0x000033F7
		public unsafe GlobalInputDispatcher globalInputDispatcher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_globalInputDispatcher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GlobalInputDispatcher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_globalInputDispatcher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060005BA RID: 1466 RVA: 0x000191CC File Offset: 0x000173CC
		// (set) Token: 0x060005BB RID: 1467 RVA: 0x00005216 File Offset: 0x00003416
		public unsafe InputContextManager contextManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_contextManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputContextManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_contextManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060005BC RID: 1468 RVA: 0x000191FC File Offset: 0x000173FC
		// (set) Token: 0x060005BD RID: 1469 RVA: 0x00005235 File Offset: 0x00003435
		public unsafe GameObject selectedGameObjectLastFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_selectedGameObjectLastFrame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_selectedGameObjectLastFrame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060005BE RID: 1470 RVA: 0x0001922C File Offset: 0x0001742C
		// (set) Token: 0x060005BF RID: 1471 RVA: 0x00005254 File Offset: 0x00003454
		public unsafe Selectable currentSelection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_currentSelection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_currentSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x0001925C File Offset: 0x0001745C
		// (set) Token: 0x060005C1 RID: 1473 RVA: 0x00005273 File Offset: 0x00003473
		public unsafe PointerEventDispatcher pointer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_pointer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerEventDispatcher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_pointer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060005C2 RID: 1474 RVA: 0x0001928C File Offset: 0x0001748C
		// (set) Token: 0x060005C3 RID: 1475 RVA: 0x00005292 File Offset: 0x00003492
		public unsafe GameObject lastSelectedGameObjectWhileActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_lastSelectedGameObjectWhileActive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_lastSelectedGameObjectWhileActive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060005C4 RID: 1476 RVA: 0x000192BC File Offset: 0x000174BC
		// (set) Token: 0x060005C5 RID: 1477 RVA: 0x000052B1 File Offset: 0x000034B1
		public unsafe static string persistedIdentifier
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CompositeInputModule.NativeFieldInfoPtr_persistedIdentifier, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompositeInputModule.NativeFieldInfoPtr_persistedIdentifier, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060005C6 RID: 1478 RVA: 0x000192DC File Offset: 0x000174DC
		// (set) Token: 0x060005C7 RID: 1479 RVA: 0x000052C3 File Offset: 0x000034C3
		public unsafe Dictionary<string, List<InputAction>> sortedInputActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_sortedInputActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, List<InputAction>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_sortedInputActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060005C8 RID: 1480 RVA: 0x0001930C File Offset: 0x0001750C
		// (set) Token: 0x060005C9 RID: 1481 RVA: 0x000052E2 File Offset: 0x000034E2
		public unsafe HashSet<ILockInputProcessing> inputProcessingLocks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_inputProcessingLocks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<ILockInputProcessing>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.NativeFieldInfoPtr_inputProcessingLocks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeFieldInfoPtr_activationStrategy;

		// Token: 0x04000355 RID: 853
		private static readonly IntPtr NativeFieldInfoPtr_initialSelectionStrategy;

		// Token: 0x04000356 RID: 854
		private static readonly IntPtr NativeFieldInfoPtr_navigationStrategy;

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeFieldInfoPtr_eventDispatchStrategy;

		// Token: 0x04000358 RID: 856
		private static readonly IntPtr NativeFieldInfoPtr_allowPersistentSelection;

		// Token: 0x04000359 RID: 857
		private static readonly IntPtr NativeFieldInfoPtr_persistenceIdentifier;

		// Token: 0x0400035A RID: 858
		private static readonly IntPtr NativeFieldInfoPtr_typeIdentifier;

		// Token: 0x0400035B RID: 859
		private static readonly IntPtr NativeFieldInfoPtr_inputDetector;

		// Token: 0x0400035C RID: 860
		private static readonly IntPtr NativeFieldInfoPtr_moduleActivator;

		// Token: 0x0400035D RID: 861
		private static readonly IntPtr NativeFieldInfoPtr_onActivationSelector;

		// Token: 0x0400035E RID: 862
		private static readonly IntPtr NativeFieldInfoPtr_selectionNavigator;

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeFieldInfoPtr_eventDispatcher;

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeFieldInfoPtr_globalInputDispatcher;

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeFieldInfoPtr_contextManager;

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeFieldInfoPtr_selectedGameObjectLastFrame;

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeFieldInfoPtr_currentSelection;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeFieldInfoPtr_pointer;

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeFieldInfoPtr_lastSelectedGameObjectWhileActive;

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeFieldInfoPtr_persistedIdentifier;

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeFieldInfoPtr_sortedInputActions;

		// Token: 0x04000368 RID: 872
		private static readonly IntPtr NativeFieldInfoPtr_inputProcessingLocks;

		// Token: 0x04000369 RID: 873
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowPersistentSelection_Public_get_Boolean_0;

		// Token: 0x0400036A RID: 874
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeIdentifier_Public_get_String_0;

		// Token: 0x0400036B RID: 875
		private static readonly IntPtr NativeMethodInfoPtr_get_InputDetector_Public_get_InputDetector_0;

		// Token: 0x0400036C RID: 876
		private static readonly IntPtr NativeMethodInfoPtr_get_activeContext_Private_get_InputContext_0;

		// Token: 0x0400036D RID: 877
		private static readonly IntPtr NativeMethodInfoPtr_get_InputLocked_Private_get_Boolean_0;

		// Token: 0x0400036E RID: 878
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400036F RID: 879
		private static readonly IntPtr NativeMethodInfoPtr_initializeStrategyFromComponents_Private_Void_byref_TStrategy_String_0;

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_Boolean_0;

		// Token: 0x04000371 RID: 881
		private static readonly IntPtr NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_0;

		// Token: 0x04000372 RID: 882
		private static readonly IntPtr NativeMethodInfoPtr_DeactivateModule_Public_Virtual_Void_0;

		// Token: 0x04000373 RID: 883
		private static readonly IntPtr NativeMethodInfoPtr_UpdateModule_Public_Virtual_Void_0;

		// Token: 0x04000374 RID: 884
		private static readonly IntPtr NativeMethodInfoPtr_Process_Public_Virtual_Void_0;

		// Token: 0x04000375 RID: 885
		private static readonly IntPtr NativeMethodInfoPtr_RegisterInputProcessingLock_Public_Void_ILockInputProcessing_0;

		// Token: 0x04000376 RID: 886
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterInputProcessingLock_Public_Void_ILockInputProcessing_0;

		// Token: 0x04000377 RID: 887
		private static readonly IntPtr NativeMethodInfoPtr_sendUpdateEventToSelectedObject_Private_Void_0;

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeMethodInfoPtr_processNavigation_Private_Boolean_0;

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeMethodInfoPtr_processEventDispatch_Private_Boolean_0;

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeMethodInfoPtr_executeInputActions_Private_Void_Dictionary_2_String_List_1_InputAction_0;

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteInput_Public_Void_Dictionary_2_String_List_1_InputAction_String_Single_0;

		// Token: 0x0400037C RID: 892
		private static readonly IntPtr NativeMethodInfoPtr_clearNonPersistentSelection_Private_Void_0;

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeMethodInfoPtr_IsPointerOverGameObject_Public_Virtual_Boolean_Int32_0;

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeMethodInfoPtr_PointerForIndex_Public_PointerEventData_Int32_0;

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000D7 RID: 215
		[ObfuscatedName("dwd.core.input.compositeModule.CompositeInputModule+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06000991 RID: 2449 RVA: 0x00025B34 File Offset: 0x00023D34
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CompositeInputModule.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompositeInputModule.__c>.NativeClassPtr);
				CompositeInputModule.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeInputModule.__c>.NativeClassPtr, "<>9");
				CompositeInputModule.__c.NativeFieldInfoPtr___9__37_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeInputModule.__c>.NativeClassPtr, "<>9__37_0");
				CompositeInputModule.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeInputModule.__c>.NativeClassPtr, 100664008);
				CompositeInputModule.__c.NativeMethodInfoPtr__Process_b__37_0_Internal_Boolean_List_1_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeInputModule.__c>.NativeClassPtr, 100664009);
			}

			// Token: 0x06000992 RID: 2450 RVA: 0x00025BB0 File Offset: 0x00023DB0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompositeInputModule.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeInputModule.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000993 RID: 2451 RVA: 0x00025BEC File Offset: 0x00023DEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124391, XrefRangeEnd = 1124392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Process_b__37_0(List<InputAction> list)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeInputModule.__c.NativeMethodInfoPtr__Process_b__37_0_Internal_Boolean_List_1_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000994 RID: 2452 RVA: 0x00006F99 File Offset: 0x00005199
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170002C9 RID: 713
			// (get) Token: 0x06000995 RID: 2453 RVA: 0x00025C3C File Offset: 0x00023E3C
			// (set) Token: 0x06000996 RID: 2454 RVA: 0x00006FA2 File Offset: 0x000051A2
			public unsafe static CompositeInputModule.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CompositeInputModule.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompositeInputModule.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CompositeInputModule.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002CA RID: 714
			// (get) Token: 0x06000997 RID: 2455 RVA: 0x00025C64 File Offset: 0x00023E64
			// (set) Token: 0x06000998 RID: 2456 RVA: 0x00006FB4 File Offset: 0x000051B4
			public unsafe static Predicate<List<InputAction>> __9__37_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CompositeInputModule.__c.NativeFieldInfoPtr___9__37_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<List<InputAction>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CompositeInputModule.__c.NativeFieldInfoPtr___9__37_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005EB RID: 1515
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040005EC RID: 1516
			private static readonly IntPtr NativeFieldInfoPtr___9__37_0;

			// Token: 0x040005ED RID: 1517
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040005EE RID: 1518
			private static readonly IntPtr NativeMethodInfoPtr__Process_b__37_0_Internal_Boolean_List_1_InputAction_0;
		}

		// Token: 0x020000D8 RID: 216
		[ObfuscatedName("dwd.core.input.compositeModule.CompositeInputModule+<>c__DisplayClass32_0`1")]
		public sealed class __c__DisplayClass32_0<TStrategy> : global::Il2CppSystem.Object
		{
			// Token: 0x06000999 RID: 2457 RVA: 0x00025C8C File Offset: 0x00023E8C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass32_0()
			{
				Il2CppClassPointerStore<CompositeInputModule.__c__DisplayClass32_0<TStrategy>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr, "<>c__DisplayClass32_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TStrategy>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompositeInputModule.__c__DisplayClass32_0<TStrategy>>.NativeClassPtr);
				CompositeInputModule.__c__DisplayClass32_0<TStrategy>.NativeFieldInfoPtr_strategyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeInputModule.__c__DisplayClass32_0<TStrategy>>.NativeClassPtr, "strategyName");
				CompositeInputModule.__c__DisplayClass32_0<TStrategy>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeInputModule.__c__DisplayClass32_0<TStrategy>>.NativeClassPtr, 100664010);
				CompositeInputModule.__c__DisplayClass32_0<TStrategy>.NativeMethodInfoPtr__initializeStrategyFromComponents_b__0_Internal_Boolean_TStrategy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeInputModule.__c__DisplayClass32_0<TStrategy>>.NativeClassPtr, 100664011);
			}

			// Token: 0x0600099A RID: 2458 RVA: 0x00025D30 File Offset: 0x00023F30
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass32_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompositeInputModule.__c__DisplayClass32_0<TStrategy>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeInputModule.__c__DisplayClass32_0<TStrategy>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600099B RID: 2459 RVA: 0x00025D6C File Offset: 0x00023F6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124392, XrefRangeEnd = 1124397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _initializeStrategyFromComponents_b__0(TStrategy strategyComponent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TStrategy).IsValueType)
					{
						TStrategy tstrategy = strategyComponent;
						intPtr = ((tstrategy is string) ? IL2CPP.ManagedStringToIl2Cpp(tstrategy as string) : IL2CPP.Il2CppObjectBaseToPtr(tstrategy as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref strategyComponent;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CompositeInputModule.__c__DisplayClass32_0<TStrategy>.NativeMethodInfoPtr__initializeStrategyFromComponents_b__0_Internal_Boolean_TStrategy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x0600099C RID: 2460 RVA: 0x00006FC6 File Offset: 0x000051C6
			public __c__DisplayClass32_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170002CB RID: 715
			// (get) Token: 0x0600099D RID: 2461 RVA: 0x00025DF0 File Offset: 0x00023FF0
			// (set) Token: 0x0600099E RID: 2462 RVA: 0x00006FCF File Offset: 0x000051CF
			public unsafe string strategyName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.__c__DisplayClass32_0<TStrategy>.NativeFieldInfoPtr_strategyName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeInputModule.__c__DisplayClass32_0<TStrategy>.NativeFieldInfoPtr_strategyName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040005EF RID: 1519
			private static readonly IntPtr NativeFieldInfoPtr_strategyName;

			// Token: 0x040005F0 RID: 1520
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040005F1 RID: 1521
			private static readonly IntPtr NativeMethodInfoPtr__initializeStrategyFromComponents_b__0_Internal_Boolean_TStrategy_0;
		}

		// Token: 0x020000D9 RID: 217
		private sealed class MethodInfoStoreGeneric_initializeStrategyFromComponents_Private_Void_byref_TStrategy_String_0<TStrategy>
		{
			// Token: 0x040005F2 RID: 1522
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CompositeInputModule.NativeMethodInfoPtr_initializeStrategyFromComponents_Private_Void_byref_TStrategy_String_0, Il2CppClassPointerStore<CompositeInputModule>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TStrategy>.NativeClassPtr)) }))));
		}
	}
}
