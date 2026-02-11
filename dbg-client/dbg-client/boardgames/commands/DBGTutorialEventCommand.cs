using System;
using boardgames.match.tutorial;
using Canis.attributes;
using Canis.networking;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.data.composition;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace boardgames.commands
{
	// Token: 0x0200019D RID: 413
	public class DBGTutorialEventCommand : Command
	{
		// Token: 0x06001240 RID: 4672 RVA: 0x00057C2C File Offset: 0x00055E2C
		// Note: this type is marked as 'beforefieldinit'.
		static DBGTutorialEventCommand()
		{
			Il2CppClassPointerStore<DBGTutorialEventCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.commands", "DBGTutorialEventCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGTutorialEventCommand>.NativeClassPtr);
			DBGTutorialEventCommand.NativeFieldInfoPtr_tutorialEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand>.NativeClassPtr, "tutorialEffects");
			DBGTutorialEventCommand.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand>.NativeClassPtr, "message");
			DBGTutorialEventCommand.NativeFieldInfoPtr_currentAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand>.NativeClassPtr, "currentAction");
			DBGTutorialEventCommand.NativeMethodInfoPtr_get_CurrentAction_Public_get_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand>.NativeClassPtr, 100665873);
			DBGTutorialEventCommand.NativeMethodInfoPtr__ctor_Public_Void_TutorialEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand>.NativeClassPtr, 100665874);
			DBGTutorialEventCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand>.NativeClassPtr, 100665875);
			DBGTutorialEventCommand.NativeMethodInfoPtr_PreHandleAction_Protected_Virtual_New_ValueTuple_2_Boolean_Boolean_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand>.NativeClassPtr, 100665876);
			DBGTutorialEventCommand.NativeMethodInfoPtr_HandleTutorialAction_Public_Virtual_New_IEnumerator_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand>.NativeClassPtr, 100665877);
			DBGTutorialEventCommand.NativeMethodInfoPtr_HandleAttributes_Public_Virtual_Final_New_Void_String_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand>.NativeClassPtr, 100665878);
			DBGTutorialEventCommand.NativeMethodInfoPtr_HandleTutorialDialogEvent_Protected_Virtual_New_IEnumerator_Nullable_1_Int32_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand>.NativeClassPtr, 100665879);
			DBGTutorialEventCommand.NativeMethodInfoPtr_ConstructPromptData_Protected_Virtual_New_DataComposition_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand>.NativeClassPtr, 100665880);
			DBGTutorialEventCommand.NativeMethodInfoPtr_HandleTutorialCameraMoveEvent_Protected_Virtual_New_IEnumerator_Nullable_1_Int32_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand>.NativeClassPtr, 100665881);
			DBGTutorialEventCommand.NativeMethodInfoPtr_HandleInvokeTutorialEvent_Protected_Virtual_New_Void_Nullable_1_Int32_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand>.NativeClassPtr, 100665882);
			DBGTutorialEventCommand.NativeMethodInfoPtr_HandleEndOfTutorialPrompt_Protected_IEnumerator_Nullable_1_Int32_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand>.NativeClassPtr, 100665883);
			DBGTutorialEventCommand.NativeMethodInfoPtr_handleGameSpecificEndofTutorial_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand>.NativeClassPtr, 100665884);
			DBGTutorialEventCommand.NativeMethodInfoPtr_HandleTutorialCallToActionEvent_Protected_Virtual_New_IEnumerator_Nullable_1_Int32_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand>.NativeClassPtr, 100665885);
			DBGTutorialEventCommand.NativeMethodInfoPtr_HandleTutorialHideEvent_Protected_Virtual_New_IEnumerator_Nullable_1_Int32_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand>.NativeClassPtr, 100665886);
			DBGTutorialEventCommand.NativeMethodInfoPtr_HandleTutorialFocusEvent_Protected_Virtual_New_IEnumerator_Nullable_1_Int32_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand>.NativeClassPtr, 100665887);
			DBGTutorialEventCommand.NativeMethodInfoPtr_HandleTutorialShowHintEvent_Protected_Virtual_New_IEnumerator_Nullable_1_Int32_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand>.NativeClassPtr, 100665888);
			DBGTutorialEventCommand.NativeMethodInfoPtr_HandleTutorialVisualHighlightEvent_Protected_Virtual_New_IEnumerator_Nullable_1_Int32_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand>.NativeClassPtr, 100665889);
			DBGTutorialEventCommand.NativeMethodInfoPtr_AddVisualHighlightFXData_Protected_Virtual_New_Void_MutableAttributes_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand>.NativeClassPtr, 100665890);
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06001241 RID: 4673 RVA: 0x00057E00 File Offset: 0x00056000
		public unsafe MutableAttributes CurrentAction
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand.NativeMethodInfoPtr_get_CurrentAction_Public_get_MutableAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MutableAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x00057E40 File Offset: 0x00056040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516636, XrefRangeEnd = 516642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGTutorialEventCommand(TutorialEvent message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGTutorialEventCommand>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand.NativeMethodInfoPtr__ctor_Public_Void_TutorialEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x00057E8C File Offset: 0x0005608C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516642, XrefRangeEnd = 516647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGTutorialEventCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x00057ED8 File Offset: 0x000560D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516647, XrefRangeEnd = 516671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ValueTuple<bool, bool> PreHandleAction(MutableAttributes action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGTutorialEventCommand.NativeMethodInfoPtr_PreHandleAction_Protected_Virtual_New_ValueTuple_2_Boolean_Boolean_MutableAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<bool, bool>(intPtr);
			}
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x00057F2C File Offset: 0x0005612C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516671, XrefRangeEnd = 516677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator HandleTutorialAction(MutableAttributes action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGTutorialEventCommand.NativeMethodInfoPtr_HandleTutorialAction_Public_Virtual_New_IEnumerator_MutableAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x00057F88 File Offset: 0x00056188
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HandleAttributes(string sequenceName, IHasAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sequenceName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand.NativeMethodInfoPtr_HandleAttributes_Public_Virtual_Final_New_Void_String_IHasAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x00057FDC File Offset: 0x000561DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516677, XrefRangeEnd = 516683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator HandleTutorialDialogEvent(Nullable<int> tutorialID, MutableAttributes action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tutorialID));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGTutorialEventCommand.NativeMethodInfoPtr_HandleTutorialDialogEvent_Protected_Virtual_New_IEnumerator_Nullable_1_Int32_MutableAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x00058050 File Offset: 0x00056250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516683, XrefRangeEnd = 516774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DataComposition ConstructPromptData(MutableAttributes action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGTutorialEventCommand.NativeMethodInfoPtr_ConstructPromptData_Protected_Virtual_New_DataComposition_MutableAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
			}
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x000580AC File Offset: 0x000562AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516774, XrefRangeEnd = 516780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator HandleTutorialCameraMoveEvent(Nullable<int> tutorialID, MutableAttributes action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tutorialID));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGTutorialEventCommand.NativeMethodInfoPtr_HandleTutorialCameraMoveEvent_Protected_Virtual_New_IEnumerator_Nullable_1_Int32_MutableAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x00058120 File Offset: 0x00056320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516780, XrefRangeEnd = 516802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HandleInvokeTutorialEvent(Nullable<int> tutorialID, MutableAttributes action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tutorialID));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGTutorialEventCommand.NativeMethodInfoPtr_HandleInvokeTutorialEvent_Protected_Virtual_New_Void_Nullable_1_Int32_MutableAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x00058184 File Offset: 0x00056384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516802, XrefRangeEnd = 516808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator HandleEndOfTutorialPrompt(Nullable<int> tutorialID, MutableAttributes action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tutorialID));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand.NativeMethodInfoPtr_HandleEndOfTutorialPrompt_Protected_IEnumerator_Nullable_1_Int32_MutableAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x000581EC File Offset: 0x000563EC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void handleGameSpecificEndofTutorial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGTutorialEventCommand.NativeMethodInfoPtr_handleGameSpecificEndofTutorial_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x00058228 File Offset: 0x00056428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516808, XrefRangeEnd = 516814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator HandleTutorialCallToActionEvent(Nullable<int> tutorialID, MutableAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tutorialID));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGTutorialEventCommand.NativeMethodInfoPtr_HandleTutorialCallToActionEvent_Protected_Virtual_New_IEnumerator_Nullable_1_Int32_MutableAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x0005829C File Offset: 0x0005649C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516814, XrefRangeEnd = 516819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator HandleTutorialHideEvent(Nullable<int> tutorialID, MutableAttributes action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tutorialID));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGTutorialEventCommand.NativeMethodInfoPtr_HandleTutorialHideEvent_Protected_Virtual_New_IEnumerator_Nullable_1_Int32_MutableAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x00058310 File Offset: 0x00056510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516819, XrefRangeEnd = 516825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator HandleTutorialFocusEvent(Nullable<int> tutorialID, MutableAttributes action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tutorialID));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGTutorialEventCommand.NativeMethodInfoPtr_HandleTutorialFocusEvent_Protected_Virtual_New_IEnumerator_Nullable_1_Int32_MutableAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x00058384 File Offset: 0x00056584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516825, XrefRangeEnd = 516831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator HandleTutorialShowHintEvent(Nullable<int> tutorialID, MutableAttributes action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tutorialID));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGTutorialEventCommand.NativeMethodInfoPtr_HandleTutorialShowHintEvent_Protected_Virtual_New_IEnumerator_Nullable_1_Int32_MutableAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x000583F8 File Offset: 0x000565F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516831, XrefRangeEnd = 516837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator HandleTutorialVisualHighlightEvent(Nullable<int> tutorialID, MutableAttributes action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tutorialID));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGTutorialEventCommand.NativeMethodInfoPtr_HandleTutorialVisualHighlightEvent_Protected_Virtual_New_IEnumerator_Nullable_1_Int32_MutableAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x0005846C File Offset: 0x0005666C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddVisualHighlightFXData(MutableAttributes action, EntityComponent fxData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fxData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGTutorialEventCommand.NativeMethodInfoPtr_AddVisualHighlightFXData_Protected_Virtual_New_Void_MutableAttributes_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x0000AB09 File Offset: 0x00008D09
		public DBGTutorialEventCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06001254 RID: 4692 RVA: 0x000584CC File Offset: 0x000566CC
		// (set) Token: 0x06001255 RID: 4693 RVA: 0x0000AB12 File Offset: 0x00008D12
		public unsafe TutorialEffects tutorialEffects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand.NativeFieldInfoPtr_tutorialEffects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialEffects>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand.NativeFieldInfoPtr_tutorialEffects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06001256 RID: 4694 RVA: 0x000584FC File Offset: 0x000566FC
		// (set) Token: 0x06001257 RID: 4695 RVA: 0x0000AB31 File Offset: 0x00008D31
		public unsafe TutorialEvent message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand.NativeFieldInfoPtr_message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06001258 RID: 4696 RVA: 0x0005852C File Offset: 0x0005672C
		// (set) Token: 0x06001259 RID: 4697 RVA: 0x0000AB50 File Offset: 0x00008D50
		public unsafe MutableAttributes currentAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand.NativeFieldInfoPtr_currentAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MutableAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand.NativeFieldInfoPtr_currentAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B2C RID: 2860
		private static readonly IntPtr NativeFieldInfoPtr_tutorialEffects;

		// Token: 0x04000B2D RID: 2861
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x04000B2E RID: 2862
		private static readonly IntPtr NativeFieldInfoPtr_currentAction;

		// Token: 0x04000B2F RID: 2863
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentAction_Public_get_MutableAttributes_0;

		// Token: 0x04000B30 RID: 2864
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TutorialEvent_0;

		// Token: 0x04000B31 RID: 2865
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000B32 RID: 2866
		private static readonly IntPtr NativeMethodInfoPtr_PreHandleAction_Protected_Virtual_New_ValueTuple_2_Boolean_Boolean_MutableAttributes_0;

		// Token: 0x04000B33 RID: 2867
		private static readonly IntPtr NativeMethodInfoPtr_HandleTutorialAction_Public_Virtual_New_IEnumerator_MutableAttributes_0;

		// Token: 0x04000B34 RID: 2868
		private static readonly IntPtr NativeMethodInfoPtr_HandleAttributes_Public_Virtual_Final_New_Void_String_IHasAttributes_0;

		// Token: 0x04000B35 RID: 2869
		private static readonly IntPtr NativeMethodInfoPtr_HandleTutorialDialogEvent_Protected_Virtual_New_IEnumerator_Nullable_1_Int32_MutableAttributes_0;

		// Token: 0x04000B36 RID: 2870
		private static readonly IntPtr NativeMethodInfoPtr_ConstructPromptData_Protected_Virtual_New_DataComposition_MutableAttributes_0;

		// Token: 0x04000B37 RID: 2871
		private static readonly IntPtr NativeMethodInfoPtr_HandleTutorialCameraMoveEvent_Protected_Virtual_New_IEnumerator_Nullable_1_Int32_MutableAttributes_0;

		// Token: 0x04000B38 RID: 2872
		private static readonly IntPtr NativeMethodInfoPtr_HandleInvokeTutorialEvent_Protected_Virtual_New_Void_Nullable_1_Int32_MutableAttributes_0;

		// Token: 0x04000B39 RID: 2873
		private static readonly IntPtr NativeMethodInfoPtr_HandleEndOfTutorialPrompt_Protected_IEnumerator_Nullable_1_Int32_MutableAttributes_0;

		// Token: 0x04000B3A RID: 2874
		private static readonly IntPtr NativeMethodInfoPtr_handleGameSpecificEndofTutorial_Protected_Virtual_New_Void_0;

		// Token: 0x04000B3B RID: 2875
		private static readonly IntPtr NativeMethodInfoPtr_HandleTutorialCallToActionEvent_Protected_Virtual_New_IEnumerator_Nullable_1_Int32_MutableAttributes_0;

		// Token: 0x04000B3C RID: 2876
		private static readonly IntPtr NativeMethodInfoPtr_HandleTutorialHideEvent_Protected_Virtual_New_IEnumerator_Nullable_1_Int32_MutableAttributes_0;

		// Token: 0x04000B3D RID: 2877
		private static readonly IntPtr NativeMethodInfoPtr_HandleTutorialFocusEvent_Protected_Virtual_New_IEnumerator_Nullable_1_Int32_MutableAttributes_0;

		// Token: 0x04000B3E RID: 2878
		private static readonly IntPtr NativeMethodInfoPtr_HandleTutorialShowHintEvent_Protected_Virtual_New_IEnumerator_Nullable_1_Int32_MutableAttributes_0;

		// Token: 0x04000B3F RID: 2879
		private static readonly IntPtr NativeMethodInfoPtr_HandleTutorialVisualHighlightEvent_Protected_Virtual_New_IEnumerator_Nullable_1_Int32_MutableAttributes_0;

		// Token: 0x04000B40 RID: 2880
		private static readonly IntPtr NativeMethodInfoPtr_AddVisualHighlightFXData_Protected_Virtual_New_Void_MutableAttributes_EntityComponent_0;

		// Token: 0x02000384 RID: 900
		[ObfuscatedName("boardgames.commands.DBGTutorialEventCommand+<HandleEndOfTutorialPrompt>d__14")]
		public sealed class _HandleEndOfTutorialPrompt_d__14 : Object
		{
			// Token: 0x06002A24 RID: 10788 RVA: 0x000A68C0 File Offset: 0x000A4AC0
			// Note: this type is marked as 'beforefieldinit'.
			static _HandleEndOfTutorialPrompt_d__14()
			{
				Il2CppClassPointerStore<DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGTutorialEventCommand>.NativeClassPtr, "<HandleEndOfTutorialPrompt>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14>.NativeClassPtr);
				DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14>.NativeClassPtr, "<>1__state");
				DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14>.NativeClassPtr, "<>2__current");
				DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14>.NativeClassPtr, "action");
				DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14>.NativeClassPtr, "<>4__this");
				DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14.NativeFieldInfoPtr_tutorialID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14>.NativeClassPtr, "tutorialID");
				DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14>.NativeClassPtr, 100665891);
				DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14>.NativeClassPtr, 100665892);
				DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14>.NativeClassPtr, 100665893);
				DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14>.NativeClassPtr, 100665894);
				DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14>.NativeClassPtr, 100665895);
				DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14>.NativeClassPtr, 100665896);
			}

			// Token: 0x06002A25 RID: 10789 RVA: 0x000A69C8 File Offset: 0x000A4BC8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _HandleEndOfTutorialPrompt_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002A26 RID: 10790 RVA: 0x000A6A10 File Offset: 0x000A4C10
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A27 RID: 10791 RVA: 0x000A6A44 File Offset: 0x000A4C44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516069, XrefRangeEnd = 516126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000BDD RID: 3037
			// (get) Token: 0x06002A28 RID: 10792 RVA: 0x000A6A80 File Offset: 0x000A4C80
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A29 RID: 10793 RVA: 0x000A6AC0 File Offset: 0x000A4CC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516126, XrefRangeEnd = 516131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BDE RID: 3038
			// (get) Token: 0x06002A2A RID: 10794 RVA: 0x000A6AF4 File Offset: 0x000A4CF4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A2B RID: 10795 RVA: 0x00015B6C File Offset: 0x00013D6C
			public _HandleEndOfTutorialPrompt_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BD8 RID: 3032
			// (get) Token: 0x06002A2C RID: 10796 RVA: 0x000A6B34 File Offset: 0x000A4D34
			// (set) Token: 0x06002A2D RID: 10797 RVA: 0x00015B75 File Offset: 0x00013D75
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000BD9 RID: 3033
			// (get) Token: 0x06002A2E RID: 10798 RVA: 0x000A6B5C File Offset: 0x000A4D5C
			// (set) Token: 0x06002A2F RID: 10799 RVA: 0x00015B90 File Offset: 0x00013D90
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BDA RID: 3034
			// (get) Token: 0x06002A30 RID: 10800 RVA: 0x000A6B8C File Offset: 0x000A4D8C
			// (set) Token: 0x06002A31 RID: 10801 RVA: 0x00015BAF File Offset: 0x00013DAF
			public unsafe MutableAttributes action
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14.NativeFieldInfoPtr_action);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MutableAttributes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BDB RID: 3035
			// (get) Token: 0x06002A32 RID: 10802 RVA: 0x000A6BBC File Offset: 0x000A4DBC
			// (set) Token: 0x06002A33 RID: 10803 RVA: 0x00015BCE File Offset: 0x00013DCE
			public unsafe DBGTutorialEventCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGTutorialEventCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BDC RID: 3036
			// (get) Token: 0x06002A34 RID: 10804 RVA: 0x000A6BEC File Offset: 0x000A4DEC
			// (set) Token: 0x06002A35 RID: 10805 RVA: 0x00015BED File Offset: 0x00013DED
			public Nullable<int> tutorialID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14.NativeFieldInfoPtr_tutorialID);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleEndOfTutorialPrompt_d__14.NativeFieldInfoPtr_tutorialID), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001A4B RID: 6731
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001A4C RID: 6732
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001A4D RID: 6733
			private static readonly IntPtr NativeFieldInfoPtr_action;

			// Token: 0x04001A4E RID: 6734
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001A4F RID: 6735
			private static readonly IntPtr NativeFieldInfoPtr_tutorialID;

			// Token: 0x04001A50 RID: 6736
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001A51 RID: 6737
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A52 RID: 6738
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001A53 RID: 6739
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001A54 RID: 6740
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A55 RID: 6741
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000385 RID: 901
		[ObfuscatedName("boardgames.commands.DBGTutorialEventCommand+<HandleTutorialAction>d__8")]
		public sealed class _HandleTutorialAction_d__8 : Object
		{
			// Token: 0x06002A36 RID: 10806 RVA: 0x000A6C1C File Offset: 0x000A4E1C
			// Note: this type is marked as 'beforefieldinit'.
			static _HandleTutorialAction_d__8()
			{
				Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialAction_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGTutorialEventCommand>.NativeClassPtr, "<HandleTutorialAction>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialAction_d__8>.NativeClassPtr);
				DBGTutorialEventCommand._HandleTutorialAction_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialAction_d__8>.NativeClassPtr, "<>1__state");
				DBGTutorialEventCommand._HandleTutorialAction_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialAction_d__8>.NativeClassPtr, "<>2__current");
				DBGTutorialEventCommand._HandleTutorialAction_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialAction_d__8>.NativeClassPtr, "<>4__this");
				DBGTutorialEventCommand._HandleTutorialAction_d__8.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialAction_d__8>.NativeClassPtr, "action");
				DBGTutorialEventCommand._HandleTutorialAction_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialAction_d__8>.NativeClassPtr, 100665897);
				DBGTutorialEventCommand._HandleTutorialAction_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialAction_d__8>.NativeClassPtr, 100665898);
				DBGTutorialEventCommand._HandleTutorialAction_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialAction_d__8>.NativeClassPtr, 100665899);
				DBGTutorialEventCommand._HandleTutorialAction_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialAction_d__8>.NativeClassPtr, 100665900);
				DBGTutorialEventCommand._HandleTutorialAction_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialAction_d__8>.NativeClassPtr, 100665901);
				DBGTutorialEventCommand._HandleTutorialAction_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialAction_d__8>.NativeClassPtr, 100665902);
			}

			// Token: 0x06002A37 RID: 10807 RVA: 0x000A6D10 File Offset: 0x000A4F10
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _HandleTutorialAction_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialAction_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialAction_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002A38 RID: 10808 RVA: 0x000A6D58 File Offset: 0x000A4F58
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialAction_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A39 RID: 10809 RVA: 0x000A6D8C File Offset: 0x000A4F8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516131, XrefRangeEnd = 516220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialAction_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000BE3 RID: 3043
			// (get) Token: 0x06002A3A RID: 10810 RVA: 0x000A6DC8 File Offset: 0x000A4FC8
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialAction_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A3B RID: 10811 RVA: 0x000A6E08 File Offset: 0x000A5008
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516220, XrefRangeEnd = 516225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialAction_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BE4 RID: 3044
			// (get) Token: 0x06002A3C RID: 10812 RVA: 0x000A6E3C File Offset: 0x000A503C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialAction_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A3D RID: 10813 RVA: 0x00015C1B File Offset: 0x00013E1B
			public _HandleTutorialAction_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BDF RID: 3039
			// (get) Token: 0x06002A3E RID: 10814 RVA: 0x000A6E7C File Offset: 0x000A507C
			// (set) Token: 0x06002A3F RID: 10815 RVA: 0x00015C24 File Offset: 0x00013E24
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialAction_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialAction_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000BE0 RID: 3040
			// (get) Token: 0x06002A40 RID: 10816 RVA: 0x000A6EA4 File Offset: 0x000A50A4
			// (set) Token: 0x06002A41 RID: 10817 RVA: 0x00015C3F File Offset: 0x00013E3F
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialAction_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialAction_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BE1 RID: 3041
			// (get) Token: 0x06002A42 RID: 10818 RVA: 0x000A6ED4 File Offset: 0x000A50D4
			// (set) Token: 0x06002A43 RID: 10819 RVA: 0x00015C5E File Offset: 0x00013E5E
			public unsafe DBGTutorialEventCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialAction_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGTutorialEventCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialAction_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BE2 RID: 3042
			// (get) Token: 0x06002A44 RID: 10820 RVA: 0x000A6F04 File Offset: 0x000A5104
			// (set) Token: 0x06002A45 RID: 10821 RVA: 0x00015C7D File Offset: 0x00013E7D
			public unsafe MutableAttributes action
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialAction_d__8.NativeFieldInfoPtr_action);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MutableAttributes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialAction_d__8.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A56 RID: 6742
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001A57 RID: 6743
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001A58 RID: 6744
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001A59 RID: 6745
			private static readonly IntPtr NativeFieldInfoPtr_action;

			// Token: 0x04001A5A RID: 6746
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001A5B RID: 6747
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A5C RID: 6748
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001A5D RID: 6749
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001A5E RID: 6750
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A5F RID: 6751
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000386 RID: 902
		[ObfuscatedName("boardgames.commands.DBGTutorialEventCommand+<HandleTutorialCallToActionEvent>d__16")]
		public sealed class _HandleTutorialCallToActionEvent_d__16 : Object
		{
			// Token: 0x06002A46 RID: 10822 RVA: 0x000A6F34 File Offset: 0x000A5134
			// Note: this type is marked as 'beforefieldinit'.
			static _HandleTutorialCallToActionEvent_d__16()
			{
				Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGTutorialEventCommand>.NativeClassPtr, "<HandleTutorialCallToActionEvent>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16>.NativeClassPtr);
				DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16>.NativeClassPtr, "<>1__state");
				DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16>.NativeClassPtr, "<>2__current");
				DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16>.NativeClassPtr, "attributes");
				DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16>.NativeClassPtr, "<>4__this");
				DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16.NativeFieldInfoPtr_tutorialID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16>.NativeClassPtr, "tutorialID");
				DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16>.NativeClassPtr, 100665903);
				DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16>.NativeClassPtr, 100665904);
				DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16>.NativeClassPtr, 100665905);
				DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16>.NativeClassPtr, 100665906);
				DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16>.NativeClassPtr, 100665907);
				DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16>.NativeClassPtr, 100665908);
			}

			// Token: 0x06002A47 RID: 10823 RVA: 0x000A703C File Offset: 0x000A523C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _HandleTutorialCallToActionEvent_d__16(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002A48 RID: 10824 RVA: 0x000A7084 File Offset: 0x000A5284
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A49 RID: 10825 RVA: 0x000A70B8 File Offset: 0x000A52B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516225, XrefRangeEnd = 516249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000BEA RID: 3050
			// (get) Token: 0x06002A4A RID: 10826 RVA: 0x000A70F4 File Offset: 0x000A52F4
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A4B RID: 10827 RVA: 0x000A7134 File Offset: 0x000A5334
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516249, XrefRangeEnd = 516254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BEB RID: 3051
			// (get) Token: 0x06002A4C RID: 10828 RVA: 0x000A7168 File Offset: 0x000A5368
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A4D RID: 10829 RVA: 0x00015C9C File Offset: 0x00013E9C
			public _HandleTutorialCallToActionEvent_d__16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BE5 RID: 3045
			// (get) Token: 0x06002A4E RID: 10830 RVA: 0x000A71A8 File Offset: 0x000A53A8
			// (set) Token: 0x06002A4F RID: 10831 RVA: 0x00015CA5 File Offset: 0x00013EA5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000BE6 RID: 3046
			// (get) Token: 0x06002A50 RID: 10832 RVA: 0x000A71D0 File Offset: 0x000A53D0
			// (set) Token: 0x06002A51 RID: 10833 RVA: 0x00015CC0 File Offset: 0x00013EC0
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BE7 RID: 3047
			// (get) Token: 0x06002A52 RID: 10834 RVA: 0x000A7200 File Offset: 0x000A5400
			// (set) Token: 0x06002A53 RID: 10835 RVA: 0x00015CDF File Offset: 0x00013EDF
			public unsafe MutableAttributes attributes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16.NativeFieldInfoPtr_attributes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MutableAttributes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BE8 RID: 3048
			// (get) Token: 0x06002A54 RID: 10836 RVA: 0x000A7230 File Offset: 0x000A5430
			// (set) Token: 0x06002A55 RID: 10837 RVA: 0x00015CFE File Offset: 0x00013EFE
			public unsafe DBGTutorialEventCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGTutorialEventCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BE9 RID: 3049
			// (get) Token: 0x06002A56 RID: 10838 RVA: 0x000A7260 File Offset: 0x000A5460
			// (set) Token: 0x06002A57 RID: 10839 RVA: 0x00015D1D File Offset: 0x00013F1D
			public Nullable<int> tutorialID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16.NativeFieldInfoPtr_tutorialID);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialCallToActionEvent_d__16.NativeFieldInfoPtr_tutorialID), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001A60 RID: 6752
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001A61 RID: 6753
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001A62 RID: 6754
			private static readonly IntPtr NativeFieldInfoPtr_attributes;

			// Token: 0x04001A63 RID: 6755
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001A64 RID: 6756
			private static readonly IntPtr NativeFieldInfoPtr_tutorialID;

			// Token: 0x04001A65 RID: 6757
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001A66 RID: 6758
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A67 RID: 6759
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001A68 RID: 6760
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001A69 RID: 6761
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A6A RID: 6762
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000387 RID: 903
		[ObfuscatedName("boardgames.commands.DBGTutorialEventCommand+<HandleTutorialCameraMoveEvent>d__12")]
		public sealed class _HandleTutorialCameraMoveEvent_d__12 : Object
		{
			// Token: 0x06002A58 RID: 10840 RVA: 0x000A7290 File Offset: 0x000A5490
			// Note: this type is marked as 'beforefieldinit'.
			static _HandleTutorialCameraMoveEvent_d__12()
			{
				Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGTutorialEventCommand>.NativeClassPtr, "<HandleTutorialCameraMoveEvent>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12>.NativeClassPtr);
				DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12>.NativeClassPtr, "<>1__state");
				DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12>.NativeClassPtr, "<>2__current");
				DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12>.NativeClassPtr, "action");
				DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12.NativeFieldInfoPtr_tutorialID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12>.NativeClassPtr, "tutorialID");
				DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12>.NativeClassPtr, "<>4__this");
				DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12>.NativeClassPtr, 100665909);
				DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12>.NativeClassPtr, 100665910);
				DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12>.NativeClassPtr, 100665911);
				DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12>.NativeClassPtr, 100665912);
				DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12>.NativeClassPtr, 100665913);
				DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12>.NativeClassPtr, 100665914);
			}

			// Token: 0x06002A59 RID: 10841 RVA: 0x000A7398 File Offset: 0x000A5598
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _HandleTutorialCameraMoveEvent_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002A5A RID: 10842 RVA: 0x000A73E0 File Offset: 0x000A55E0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A5B RID: 10843 RVA: 0x000A7414 File Offset: 0x000A5614
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516254, XrefRangeEnd = 516303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000BF1 RID: 3057
			// (get) Token: 0x06002A5C RID: 10844 RVA: 0x000A7450 File Offset: 0x000A5650
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A5D RID: 10845 RVA: 0x000A7490 File Offset: 0x000A5690
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516303, XrefRangeEnd = 516308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BF2 RID: 3058
			// (get) Token: 0x06002A5E RID: 10846 RVA: 0x000A74C4 File Offset: 0x000A56C4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A5F RID: 10847 RVA: 0x00015D4B File Offset: 0x00013F4B
			public _HandleTutorialCameraMoveEvent_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BEC RID: 3052
			// (get) Token: 0x06002A60 RID: 10848 RVA: 0x000A7504 File Offset: 0x000A5704
			// (set) Token: 0x06002A61 RID: 10849 RVA: 0x00015D54 File Offset: 0x00013F54
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000BED RID: 3053
			// (get) Token: 0x06002A62 RID: 10850 RVA: 0x000A752C File Offset: 0x000A572C
			// (set) Token: 0x06002A63 RID: 10851 RVA: 0x00015D6F File Offset: 0x00013F6F
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BEE RID: 3054
			// (get) Token: 0x06002A64 RID: 10852 RVA: 0x000A755C File Offset: 0x000A575C
			// (set) Token: 0x06002A65 RID: 10853 RVA: 0x00015D8E File Offset: 0x00013F8E
			public unsafe MutableAttributes action
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12.NativeFieldInfoPtr_action);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MutableAttributes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BEF RID: 3055
			// (get) Token: 0x06002A66 RID: 10854 RVA: 0x000A758C File Offset: 0x000A578C
			// (set) Token: 0x06002A67 RID: 10855 RVA: 0x00015DAD File Offset: 0x00013FAD
			public Nullable<int> tutorialID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12.NativeFieldInfoPtr_tutorialID);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12.NativeFieldInfoPtr_tutorialID), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000BF0 RID: 3056
			// (get) Token: 0x06002A68 RID: 10856 RVA: 0x000A75BC File Offset: 0x000A57BC
			// (set) Token: 0x06002A69 RID: 10857 RVA: 0x00015DDB File Offset: 0x00013FDB
			public unsafe DBGTutorialEventCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGTutorialEventCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialCameraMoveEvent_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A6B RID: 6763
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001A6C RID: 6764
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001A6D RID: 6765
			private static readonly IntPtr NativeFieldInfoPtr_action;

			// Token: 0x04001A6E RID: 6766
			private static readonly IntPtr NativeFieldInfoPtr_tutorialID;

			// Token: 0x04001A6F RID: 6767
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001A70 RID: 6768
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001A71 RID: 6769
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A72 RID: 6770
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001A73 RID: 6771
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001A74 RID: 6772
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A75 RID: 6773
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000388 RID: 904
		[ObfuscatedName("boardgames.commands.DBGTutorialEventCommand+<HandleTutorialDialogEvent>d__10")]
		public sealed class _HandleTutorialDialogEvent_d__10 : Object
		{
			// Token: 0x06002A6A RID: 10858 RVA: 0x000A75EC File Offset: 0x000A57EC
			// Note: this type is marked as 'beforefieldinit'.
			static _HandleTutorialDialogEvent_d__10()
			{
				Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGTutorialEventCommand>.NativeClassPtr, "<HandleTutorialDialogEvent>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10>.NativeClassPtr);
				DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10>.NativeClassPtr, "<>1__state");
				DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10>.NativeClassPtr, "<>2__current");
				DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10>.NativeClassPtr, "action");
				DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10>.NativeClassPtr, "<>4__this");
				DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10.NativeFieldInfoPtr_tutorialID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10>.NativeClassPtr, "tutorialID");
				DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10>.NativeClassPtr, 100665915);
				DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10>.NativeClassPtr, 100665916);
				DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10>.NativeClassPtr, 100665917);
				DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10>.NativeClassPtr, 100665918);
				DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10>.NativeClassPtr, 100665919);
				DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10>.NativeClassPtr, 100665920);
			}

			// Token: 0x06002A6B RID: 10859 RVA: 0x000A76F4 File Offset: 0x000A58F4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _HandleTutorialDialogEvent_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002A6C RID: 10860 RVA: 0x000A773C File Offset: 0x000A593C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A6D RID: 10861 RVA: 0x000A7770 File Offset: 0x000A5970
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516308, XrefRangeEnd = 516319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000BF8 RID: 3064
			// (get) Token: 0x06002A6E RID: 10862 RVA: 0x000A77AC File Offset: 0x000A59AC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A6F RID: 10863 RVA: 0x000A77EC File Offset: 0x000A59EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516319, XrefRangeEnd = 516324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BF9 RID: 3065
			// (get) Token: 0x06002A70 RID: 10864 RVA: 0x000A7820 File Offset: 0x000A5A20
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A71 RID: 10865 RVA: 0x00015DFA File Offset: 0x00013FFA
			public _HandleTutorialDialogEvent_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BF3 RID: 3059
			// (get) Token: 0x06002A72 RID: 10866 RVA: 0x000A7860 File Offset: 0x000A5A60
			// (set) Token: 0x06002A73 RID: 10867 RVA: 0x00015E03 File Offset: 0x00014003
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000BF4 RID: 3060
			// (get) Token: 0x06002A74 RID: 10868 RVA: 0x000A7888 File Offset: 0x000A5A88
			// (set) Token: 0x06002A75 RID: 10869 RVA: 0x00015E1E File Offset: 0x0001401E
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BF5 RID: 3061
			// (get) Token: 0x06002A76 RID: 10870 RVA: 0x000A78B8 File Offset: 0x000A5AB8
			// (set) Token: 0x06002A77 RID: 10871 RVA: 0x00015E3D File Offset: 0x0001403D
			public unsafe MutableAttributes action
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10.NativeFieldInfoPtr_action);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MutableAttributes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BF6 RID: 3062
			// (get) Token: 0x06002A78 RID: 10872 RVA: 0x000A78E8 File Offset: 0x000A5AE8
			// (set) Token: 0x06002A79 RID: 10873 RVA: 0x00015E5C File Offset: 0x0001405C
			public unsafe DBGTutorialEventCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGTutorialEventCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BF7 RID: 3063
			// (get) Token: 0x06002A7A RID: 10874 RVA: 0x000A7918 File Offset: 0x000A5B18
			// (set) Token: 0x06002A7B RID: 10875 RVA: 0x00015E7B File Offset: 0x0001407B
			public Nullable<int> tutorialID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10.NativeFieldInfoPtr_tutorialID);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialDialogEvent_d__10.NativeFieldInfoPtr_tutorialID), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001A76 RID: 6774
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001A77 RID: 6775
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001A78 RID: 6776
			private static readonly IntPtr NativeFieldInfoPtr_action;

			// Token: 0x04001A79 RID: 6777
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001A7A RID: 6778
			private static readonly IntPtr NativeFieldInfoPtr_tutorialID;

			// Token: 0x04001A7B RID: 6779
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001A7C RID: 6780
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A7D RID: 6781
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001A7E RID: 6782
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001A7F RID: 6783
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A80 RID: 6784
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000389 RID: 905
		[ObfuscatedName("boardgames.commands.DBGTutorialEventCommand+<HandleTutorialFocusEvent>d__18")]
		public sealed class _HandleTutorialFocusEvent_d__18 : Object
		{
			// Token: 0x06002A7C RID: 10876 RVA: 0x000A7948 File Offset: 0x000A5B48
			// Note: this type is marked as 'beforefieldinit'.
			static _HandleTutorialFocusEvent_d__18()
			{
				Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGTutorialEventCommand>.NativeClassPtr, "<HandleTutorialFocusEvent>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18>.NativeClassPtr);
				DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18>.NativeClassPtr, "<>1__state");
				DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18>.NativeClassPtr, "<>2__current");
				DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18>.NativeClassPtr, "action");
				DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18>.NativeClassPtr, "<>4__this");
				DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18.NativeFieldInfoPtr_tutorialID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18>.NativeClassPtr, "tutorialID");
				DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18>.NativeClassPtr, 100665921);
				DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18>.NativeClassPtr, 100665922);
				DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18>.NativeClassPtr, 100665923);
				DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18>.NativeClassPtr, 100665924);
				DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18>.NativeClassPtr, 100665925);
				DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18>.NativeClassPtr, 100665926);
			}

			// Token: 0x06002A7D RID: 10877 RVA: 0x000A7A50 File Offset: 0x000A5C50
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _HandleTutorialFocusEvent_d__18(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002A7E RID: 10878 RVA: 0x000A7A98 File Offset: 0x000A5C98
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A7F RID: 10879 RVA: 0x000A7ACC File Offset: 0x000A5CCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516324, XrefRangeEnd = 516336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000BFF RID: 3071
			// (get) Token: 0x06002A80 RID: 10880 RVA: 0x000A7B08 File Offset: 0x000A5D08
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A81 RID: 10881 RVA: 0x000A7B48 File Offset: 0x000A5D48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516336, XrefRangeEnd = 516341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C00 RID: 3072
			// (get) Token: 0x06002A82 RID: 10882 RVA: 0x000A7B7C File Offset: 0x000A5D7C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A83 RID: 10883 RVA: 0x00015EA9 File Offset: 0x000140A9
			public _HandleTutorialFocusEvent_d__18(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BFA RID: 3066
			// (get) Token: 0x06002A84 RID: 10884 RVA: 0x000A7BBC File Offset: 0x000A5DBC
			// (set) Token: 0x06002A85 RID: 10885 RVA: 0x00015EB2 File Offset: 0x000140B2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000BFB RID: 3067
			// (get) Token: 0x06002A86 RID: 10886 RVA: 0x000A7BE4 File Offset: 0x000A5DE4
			// (set) Token: 0x06002A87 RID: 10887 RVA: 0x00015ECD File Offset: 0x000140CD
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BFC RID: 3068
			// (get) Token: 0x06002A88 RID: 10888 RVA: 0x000A7C14 File Offset: 0x000A5E14
			// (set) Token: 0x06002A89 RID: 10889 RVA: 0x00015EEC File Offset: 0x000140EC
			public unsafe MutableAttributes action
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18.NativeFieldInfoPtr_action);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MutableAttributes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BFD RID: 3069
			// (get) Token: 0x06002A8A RID: 10890 RVA: 0x000A7C44 File Offset: 0x000A5E44
			// (set) Token: 0x06002A8B RID: 10891 RVA: 0x00015F0B File Offset: 0x0001410B
			public unsafe DBGTutorialEventCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGTutorialEventCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BFE RID: 3070
			// (get) Token: 0x06002A8C RID: 10892 RVA: 0x000A7C74 File Offset: 0x000A5E74
			// (set) Token: 0x06002A8D RID: 10893 RVA: 0x00015F2A File Offset: 0x0001412A
			public Nullable<int> tutorialID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18.NativeFieldInfoPtr_tutorialID);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialFocusEvent_d__18.NativeFieldInfoPtr_tutorialID), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001A81 RID: 6785
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001A82 RID: 6786
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001A83 RID: 6787
			private static readonly IntPtr NativeFieldInfoPtr_action;

			// Token: 0x04001A84 RID: 6788
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001A85 RID: 6789
			private static readonly IntPtr NativeFieldInfoPtr_tutorialID;

			// Token: 0x04001A86 RID: 6790
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001A87 RID: 6791
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A88 RID: 6792
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001A89 RID: 6793
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001A8A RID: 6794
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A8B RID: 6795
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200038A RID: 906
		[ObfuscatedName("boardgames.commands.DBGTutorialEventCommand+<HandleTutorialHideEvent>d__17")]
		public sealed class _HandleTutorialHideEvent_d__17 : Object
		{
			// Token: 0x06002A8E RID: 10894 RVA: 0x000A7CA4 File Offset: 0x000A5EA4
			// Note: this type is marked as 'beforefieldinit'.
			static _HandleTutorialHideEvent_d__17()
			{
				Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialHideEvent_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGTutorialEventCommand>.NativeClassPtr, "<HandleTutorialHideEvent>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialHideEvent_d__17>.NativeClassPtr);
				DBGTutorialEventCommand._HandleTutorialHideEvent_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialHideEvent_d__17>.NativeClassPtr, "<>1__state");
				DBGTutorialEventCommand._HandleTutorialHideEvent_d__17.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialHideEvent_d__17>.NativeClassPtr, "<>2__current");
				DBGTutorialEventCommand._HandleTutorialHideEvent_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialHideEvent_d__17>.NativeClassPtr, "<>4__this");
				DBGTutorialEventCommand._HandleTutorialHideEvent_d__17.NativeFieldInfoPtr_tutorialID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialHideEvent_d__17>.NativeClassPtr, "tutorialID");
				DBGTutorialEventCommand._HandleTutorialHideEvent_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialHideEvent_d__17>.NativeClassPtr, 100665927);
				DBGTutorialEventCommand._HandleTutorialHideEvent_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialHideEvent_d__17>.NativeClassPtr, 100665928);
				DBGTutorialEventCommand._HandleTutorialHideEvent_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialHideEvent_d__17>.NativeClassPtr, 100665929);
				DBGTutorialEventCommand._HandleTutorialHideEvent_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialHideEvent_d__17>.NativeClassPtr, 100665930);
				DBGTutorialEventCommand._HandleTutorialHideEvent_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialHideEvent_d__17>.NativeClassPtr, 100665931);
				DBGTutorialEventCommand._HandleTutorialHideEvent_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialHideEvent_d__17>.NativeClassPtr, 100665932);
			}

			// Token: 0x06002A8F RID: 10895 RVA: 0x000A7D98 File Offset: 0x000A5F98
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _HandleTutorialHideEvent_d__17(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialHideEvent_d__17>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialHideEvent_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002A90 RID: 10896 RVA: 0x000A7DE0 File Offset: 0x000A5FE0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialHideEvent_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A91 RID: 10897 RVA: 0x000A7E14 File Offset: 0x000A6014
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516341, XrefRangeEnd = 516345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialHideEvent_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000C05 RID: 3077
			// (get) Token: 0x06002A92 RID: 10898 RVA: 0x000A7E50 File Offset: 0x000A6050
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialHideEvent_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A93 RID: 10899 RVA: 0x000A7E90 File Offset: 0x000A6090
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516345, XrefRangeEnd = 516350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialHideEvent_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C06 RID: 3078
			// (get) Token: 0x06002A94 RID: 10900 RVA: 0x000A7EC4 File Offset: 0x000A60C4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialHideEvent_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A95 RID: 10901 RVA: 0x00015F58 File Offset: 0x00014158
			public _HandleTutorialHideEvent_d__17(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C01 RID: 3073
			// (get) Token: 0x06002A96 RID: 10902 RVA: 0x000A7F04 File Offset: 0x000A6104
			// (set) Token: 0x06002A97 RID: 10903 RVA: 0x00015F61 File Offset: 0x00014161
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialHideEvent_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialHideEvent_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000C02 RID: 3074
			// (get) Token: 0x06002A98 RID: 10904 RVA: 0x000A7F2C File Offset: 0x000A612C
			// (set) Token: 0x06002A99 RID: 10905 RVA: 0x00015F7C File Offset: 0x0001417C
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialHideEvent_d__17.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialHideEvent_d__17.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C03 RID: 3075
			// (get) Token: 0x06002A9A RID: 10906 RVA: 0x000A7F5C File Offset: 0x000A615C
			// (set) Token: 0x06002A9B RID: 10907 RVA: 0x00015F9B File Offset: 0x0001419B
			public unsafe DBGTutorialEventCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialHideEvent_d__17.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGTutorialEventCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialHideEvent_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C04 RID: 3076
			// (get) Token: 0x06002A9C RID: 10908 RVA: 0x000A7F8C File Offset: 0x000A618C
			// (set) Token: 0x06002A9D RID: 10909 RVA: 0x00015FBA File Offset: 0x000141BA
			public Nullable<int> tutorialID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialHideEvent_d__17.NativeFieldInfoPtr_tutorialID);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialHideEvent_d__17.NativeFieldInfoPtr_tutorialID), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001A8C RID: 6796
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001A8D RID: 6797
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001A8E RID: 6798
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001A8F RID: 6799
			private static readonly IntPtr NativeFieldInfoPtr_tutorialID;

			// Token: 0x04001A90 RID: 6800
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001A91 RID: 6801
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A92 RID: 6802
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001A93 RID: 6803
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001A94 RID: 6804
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A95 RID: 6805
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200038B RID: 907
		[ObfuscatedName("boardgames.commands.DBGTutorialEventCommand+<HandleTutorialShowHintEvent>d__19")]
		public sealed class _HandleTutorialShowHintEvent_d__19 : Object
		{
			// Token: 0x06002A9E RID: 10910 RVA: 0x000A7FBC File Offset: 0x000A61BC
			// Note: this type is marked as 'beforefieldinit'.
			static _HandleTutorialShowHintEvent_d__19()
			{
				Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGTutorialEventCommand>.NativeClassPtr, "<HandleTutorialShowHintEvent>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19>.NativeClassPtr);
				DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19>.NativeClassPtr, "<>1__state");
				DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19>.NativeClassPtr, "<>2__current");
				DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19>.NativeClassPtr, "action");
				DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19>.NativeClassPtr, "<>4__this");
				DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19.NativeFieldInfoPtr_tutorialID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19>.NativeClassPtr, "tutorialID");
				DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19.NativeFieldInfoPtr__vfxTags_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19>.NativeClassPtr, "<vfxTags>5__2");
				DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19>.NativeClassPtr, "<>7__wrap2");
				DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19>.NativeClassPtr, 100665933);
				DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19>.NativeClassPtr, 100665934);
				DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19>.NativeClassPtr, 100665935);
				DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19>.NativeClassPtr, 100665936);
				DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19>.NativeClassPtr, 100665937);
				DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19>.NativeClassPtr, 100665938);
				DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19>.NativeClassPtr, 100665939);
			}

			// Token: 0x06002A9F RID: 10911 RVA: 0x000A8100 File Offset: 0x000A6300
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _HandleTutorialShowHintEvent_d__19(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002AA0 RID: 10912 RVA: 0x000A8148 File Offset: 0x000A6348
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516350, XrefRangeEnd = 516355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002AA1 RID: 10913 RVA: 0x000A817C File Offset: 0x000A637C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516355, XrefRangeEnd = 516400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002AA2 RID: 10914 RVA: 0x000A81B8 File Offset: 0x000A63B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516400, XrefRangeEnd = 516403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C0E RID: 3086
			// (get) Token: 0x06002AA3 RID: 10915 RVA: 0x000A81EC File Offset: 0x000A63EC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002AA4 RID: 10916 RVA: 0x000A822C File Offset: 0x000A642C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516403, XrefRangeEnd = 516408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C0F RID: 3087
			// (get) Token: 0x06002AA5 RID: 10917 RVA: 0x000A8260 File Offset: 0x000A6460
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002AA6 RID: 10918 RVA: 0x00015FE8 File Offset: 0x000141E8
			public _HandleTutorialShowHintEvent_d__19(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C07 RID: 3079
			// (get) Token: 0x06002AA7 RID: 10919 RVA: 0x000A82A0 File Offset: 0x000A64A0
			// (set) Token: 0x06002AA8 RID: 10920 RVA: 0x00015FF1 File Offset: 0x000141F1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000C08 RID: 3080
			// (get) Token: 0x06002AA9 RID: 10921 RVA: 0x000A82C8 File Offset: 0x000A64C8
			// (set) Token: 0x06002AAA RID: 10922 RVA: 0x0001600C File Offset: 0x0001420C
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C09 RID: 3081
			// (get) Token: 0x06002AAB RID: 10923 RVA: 0x000A82F8 File Offset: 0x000A64F8
			// (set) Token: 0x06002AAC RID: 10924 RVA: 0x0001602B File Offset: 0x0001422B
			public unsafe MutableAttributes action
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19.NativeFieldInfoPtr_action);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MutableAttributes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C0A RID: 3082
			// (get) Token: 0x06002AAD RID: 10925 RVA: 0x000A8328 File Offset: 0x000A6528
			// (set) Token: 0x06002AAE RID: 10926 RVA: 0x0001604A File Offset: 0x0001424A
			public unsafe DBGTutorialEventCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGTutorialEventCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C0B RID: 3083
			// (get) Token: 0x06002AAF RID: 10927 RVA: 0x000A8358 File Offset: 0x000A6558
			// (set) Token: 0x06002AB0 RID: 10928 RVA: 0x00016069 File Offset: 0x00014269
			public Nullable<int> tutorialID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19.NativeFieldInfoPtr_tutorialID);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19.NativeFieldInfoPtr_tutorialID), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000C0C RID: 3084
			// (get) Token: 0x06002AB1 RID: 10929 RVA: 0x000A8388 File Offset: 0x000A6588
			// (set) Token: 0x06002AB2 RID: 10930 RVA: 0x00016097 File Offset: 0x00014297
			public unsafe List<string> _vfxTags_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19.NativeFieldInfoPtr__vfxTags_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19.NativeFieldInfoPtr__vfxTags_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C0D RID: 3085
			// (get) Token: 0x06002AB3 RID: 10931 RVA: 0x000A83B8 File Offset: 0x000A65B8
			// (set) Token: 0x06002AB4 RID: 10932 RVA: 0x000160B6 File Offset: 0x000142B6
			public List<EntityID>.Enumerator __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19.NativeFieldInfoPtr___7__wrap2);
					return new List<EntityID>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<EntityID>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialShowHintEvent_d__19.NativeFieldInfoPtr___7__wrap2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<EntityID>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001A96 RID: 6806
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001A97 RID: 6807
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001A98 RID: 6808
			private static readonly IntPtr NativeFieldInfoPtr_action;

			// Token: 0x04001A99 RID: 6809
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001A9A RID: 6810
			private static readonly IntPtr NativeFieldInfoPtr_tutorialID;

			// Token: 0x04001A9B RID: 6811
			private static readonly IntPtr NativeFieldInfoPtr__vfxTags_5__2;

			// Token: 0x04001A9C RID: 6812
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04001A9D RID: 6813
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001A9E RID: 6814
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A9F RID: 6815
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001AA0 RID: 6816
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001AA1 RID: 6817
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001AA2 RID: 6818
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001AA3 RID: 6819
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200038C RID: 908
		[ObfuscatedName("boardgames.commands.DBGTutorialEventCommand+<HandleTutorialVisualHighlightEvent>d__20")]
		public sealed class _HandleTutorialVisualHighlightEvent_d__20 : Object
		{
			// Token: 0x06002AB5 RID: 10933 RVA: 0x000A83E8 File Offset: 0x000A65E8
			// Note: this type is marked as 'beforefieldinit'.
			static _HandleTutorialVisualHighlightEvent_d__20()
			{
				Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGTutorialEventCommand>.NativeClassPtr, "<HandleTutorialVisualHighlightEvent>d__20");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20>.NativeClassPtr);
				DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20>.NativeClassPtr, "<>1__state");
				DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20>.NativeClassPtr, "<>2__current");
				DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeFieldInfoPtr_tutorialID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20>.NativeClassPtr, "tutorialID");
				DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20>.NativeClassPtr, "action");
				DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20>.NativeClassPtr, "<>4__this");
				DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeFieldInfoPtr__fxName_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20>.NativeClassPtr, "<fxName>5__2");
				DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeFieldInfoPtr__targetViewLayer_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20>.NativeClassPtr, "<targetViewLayer>5__3");
				DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeFieldInfoPtr__vfxTags_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20>.NativeClassPtr, "<vfxTags>5__4");
				DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeFieldInfoPtr__fxData_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20>.NativeClassPtr, "<fxData>5__5");
				DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeFieldInfoPtr___7__wrap5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20>.NativeClassPtr, "<>7__wrap5");
				DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20>.NativeClassPtr, 100665940);
				DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20>.NativeClassPtr, 100665941);
				DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20>.NativeClassPtr, 100665942);
				DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20>.NativeClassPtr, 100665943);
				DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20>.NativeClassPtr, 100665944);
				DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20>.NativeClassPtr, 100665945);
				DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20>.NativeClassPtr, 100665946);
			}

			// Token: 0x06002AB6 RID: 10934 RVA: 0x000A8568 File Offset: 0x000A6768
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _HandleTutorialVisualHighlightEvent_d__20(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002AB7 RID: 10935 RVA: 0x000A85B0 File Offset: 0x000A67B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516408, XrefRangeEnd = 516413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002AB8 RID: 10936 RVA: 0x000A85E4 File Offset: 0x000A67E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516413, XrefRangeEnd = 516565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002AB9 RID: 10937 RVA: 0x000A8620 File Offset: 0x000A6820
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 516568, RefRangeEnd = 516569, XrefRangeStart = 516565, XrefRangeEnd = 516568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C1A RID: 3098
			// (get) Token: 0x06002ABA RID: 10938 RVA: 0x000A8654 File Offset: 0x000A6854
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002ABB RID: 10939 RVA: 0x000A8694 File Offset: 0x000A6894
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516569, XrefRangeEnd = 516574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C1B RID: 3099
			// (get) Token: 0x06002ABC RID: 10940 RVA: 0x000A86C8 File Offset: 0x000A68C8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002ABD RID: 10941 RVA: 0x000160E4 File Offset: 0x000142E4
			public _HandleTutorialVisualHighlightEvent_d__20(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C10 RID: 3088
			// (get) Token: 0x06002ABE RID: 10942 RVA: 0x000A8708 File Offset: 0x000A6908
			// (set) Token: 0x06002ABF RID: 10943 RVA: 0x000160ED File Offset: 0x000142ED
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000C11 RID: 3089
			// (get) Token: 0x06002AC0 RID: 10944 RVA: 0x000A8730 File Offset: 0x000A6930
			// (set) Token: 0x06002AC1 RID: 10945 RVA: 0x00016108 File Offset: 0x00014308
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C12 RID: 3090
			// (get) Token: 0x06002AC2 RID: 10946 RVA: 0x000A8760 File Offset: 0x000A6960
			// (set) Token: 0x06002AC3 RID: 10947 RVA: 0x00016127 File Offset: 0x00014327
			public Nullable<int> tutorialID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeFieldInfoPtr_tutorialID);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeFieldInfoPtr_tutorialID), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000C13 RID: 3091
			// (get) Token: 0x06002AC4 RID: 10948 RVA: 0x000A8790 File Offset: 0x000A6990
			// (set) Token: 0x06002AC5 RID: 10949 RVA: 0x00016155 File Offset: 0x00014355
			public unsafe MutableAttributes action
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeFieldInfoPtr_action);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MutableAttributes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C14 RID: 3092
			// (get) Token: 0x06002AC6 RID: 10950 RVA: 0x000A87C0 File Offset: 0x000A69C0
			// (set) Token: 0x06002AC7 RID: 10951 RVA: 0x00016174 File Offset: 0x00014374
			public unsafe DBGTutorialEventCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGTutorialEventCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C15 RID: 3093
			// (get) Token: 0x06002AC8 RID: 10952 RVA: 0x000A87F0 File Offset: 0x000A69F0
			// (set) Token: 0x06002AC9 RID: 10953 RVA: 0x00016193 File Offset: 0x00014393
			public unsafe string _fxName_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeFieldInfoPtr__fxName_5__2);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeFieldInfoPtr__fxName_5__2), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000C16 RID: 3094
			// (get) Token: 0x06002ACA RID: 10954 RVA: 0x000A8818 File Offset: 0x000A6A18
			// (set) Token: 0x06002ACB RID: 10955 RVA: 0x000161B2 File Offset: 0x000143B2
			public unsafe int _targetViewLayer_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeFieldInfoPtr__targetViewLayer_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeFieldInfoPtr__targetViewLayer_5__3)) = value;
				}
			}

			// Token: 0x17000C17 RID: 3095
			// (get) Token: 0x06002ACC RID: 10956 RVA: 0x000A8840 File Offset: 0x000A6A40
			// (set) Token: 0x06002ACD RID: 10957 RVA: 0x000161CD File Offset: 0x000143CD
			public unsafe List<string> _vfxTags_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeFieldInfoPtr__vfxTags_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeFieldInfoPtr__vfxTags_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C18 RID: 3096
			// (get) Token: 0x06002ACE RID: 10958 RVA: 0x000A8870 File Offset: 0x000A6A70
			// (set) Token: 0x06002ACF RID: 10959 RVA: 0x000161EC File Offset: 0x000143EC
			public unsafe EntityComponent _fxData_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeFieldInfoPtr__fxData_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeFieldInfoPtr__fxData_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C19 RID: 3097
			// (get) Token: 0x06002AD0 RID: 10960 RVA: 0x000A88A0 File Offset: 0x000A6AA0
			// (set) Token: 0x06002AD1 RID: 10961 RVA: 0x0001620B File Offset: 0x0001440B
			public List<EntityID>.Enumerator __7__wrap5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeFieldInfoPtr___7__wrap5);
					return new List<EntityID>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<EntityID>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._HandleTutorialVisualHighlightEvent_d__20.NativeFieldInfoPtr___7__wrap5), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<EntityID>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001AA4 RID: 6820
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001AA5 RID: 6821
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001AA6 RID: 6822
			private static readonly IntPtr NativeFieldInfoPtr_tutorialID;

			// Token: 0x04001AA7 RID: 6823
			private static readonly IntPtr NativeFieldInfoPtr_action;

			// Token: 0x04001AA8 RID: 6824
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001AA9 RID: 6825
			private static readonly IntPtr NativeFieldInfoPtr__fxName_5__2;

			// Token: 0x04001AAA RID: 6826
			private static readonly IntPtr NativeFieldInfoPtr__targetViewLayer_5__3;

			// Token: 0x04001AAB RID: 6827
			private static readonly IntPtr NativeFieldInfoPtr__vfxTags_5__4;

			// Token: 0x04001AAC RID: 6828
			private static readonly IntPtr NativeFieldInfoPtr__fxData_5__5;

			// Token: 0x04001AAD RID: 6829
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap5;

			// Token: 0x04001AAE RID: 6830
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001AAF RID: 6831
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001AB0 RID: 6832
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001AB1 RID: 6833
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001AB2 RID: 6834
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001AB3 RID: 6835
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001AB4 RID: 6836
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200038D RID: 909
		[ObfuscatedName("boardgames.commands.DBGTutorialEventCommand+<execute>d__6")]
		public sealed class _execute_d__6 : Object
		{
			// Token: 0x06002AD2 RID: 10962 RVA: 0x000A88D0 File Offset: 0x000A6AD0
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__6()
			{
				Il2CppClassPointerStore<DBGTutorialEventCommand._execute_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGTutorialEventCommand>.NativeClassPtr, "<execute>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGTutorialEventCommand._execute_d__6>.NativeClassPtr);
				DBGTutorialEventCommand._execute_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._execute_d__6>.NativeClassPtr, "<>1__state");
				DBGTutorialEventCommand._execute_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._execute_d__6>.NativeClassPtr, "<>2__current");
				DBGTutorialEventCommand._execute_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._execute_d__6>.NativeClassPtr, "<>4__this");
				DBGTutorialEventCommand._execute_d__6.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTutorialEventCommand._execute_d__6>.NativeClassPtr, "<>7__wrap1");
				DBGTutorialEventCommand._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._execute_d__6>.NativeClassPtr, 100665947);
				DBGTutorialEventCommand._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._execute_d__6>.NativeClassPtr, 100665948);
				DBGTutorialEventCommand._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._execute_d__6>.NativeClassPtr, 100665949);
				DBGTutorialEventCommand._execute_d__6.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._execute_d__6>.NativeClassPtr, 100665950);
				DBGTutorialEventCommand._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._execute_d__6>.NativeClassPtr, 100665951);
				DBGTutorialEventCommand._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._execute_d__6>.NativeClassPtr, 100665952);
				DBGTutorialEventCommand._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTutorialEventCommand._execute_d__6>.NativeClassPtr, 100665953);
			}

			// Token: 0x06002AD3 RID: 10963 RVA: 0x000A89D8 File Offset: 0x000A6BD8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGTutorialEventCommand._execute_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002AD4 RID: 10964 RVA: 0x000A8A20 File Offset: 0x000A6C20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516574, XrefRangeEnd = 516579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002AD5 RID: 10965 RVA: 0x000A8A54 File Offset: 0x000A6C54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516579, XrefRangeEnd = 516628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002AD6 RID: 10966 RVA: 0x000A8A90 File Offset: 0x000A6C90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516628, XrefRangeEnd = 516631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._execute_d__6.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C20 RID: 3104
			// (get) Token: 0x06002AD7 RID: 10967 RVA: 0x000A8AC4 File Offset: 0x000A6CC4
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002AD8 RID: 10968 RVA: 0x000A8B04 File Offset: 0x000A6D04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516631, XrefRangeEnd = 516636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C21 RID: 3105
			// (get) Token: 0x06002AD9 RID: 10969 RVA: 0x000A8B38 File Offset: 0x000A6D38
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTutorialEventCommand._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002ADA RID: 10970 RVA: 0x00016239 File Offset: 0x00014439
			public _execute_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C1C RID: 3100
			// (get) Token: 0x06002ADB RID: 10971 RVA: 0x000A8B78 File Offset: 0x000A6D78
			// (set) Token: 0x06002ADC RID: 10972 RVA: 0x00016242 File Offset: 0x00014442
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._execute_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._execute_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000C1D RID: 3101
			// (get) Token: 0x06002ADD RID: 10973 RVA: 0x000A8BA0 File Offset: 0x000A6DA0
			// (set) Token: 0x06002ADE RID: 10974 RVA: 0x0001625D File Offset: 0x0001445D
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._execute_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._execute_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C1E RID: 3102
			// (get) Token: 0x06002ADF RID: 10975 RVA: 0x000A8BD0 File Offset: 0x000A6DD0
			// (set) Token: 0x06002AE0 RID: 10976 RVA: 0x0001627C File Offset: 0x0001447C
			public unsafe DBGTutorialEventCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._execute_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGTutorialEventCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._execute_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C1F RID: 3103
			// (get) Token: 0x06002AE1 RID: 10977 RVA: 0x000A8C00 File Offset: 0x000A6E00
			// (set) Token: 0x06002AE2 RID: 10978 RVA: 0x0001629B File Offset: 0x0001449B
			public List<MutableAttributes>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._execute_d__6.NativeFieldInfoPtr___7__wrap1);
					return new List<MutableAttributes>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<MutableAttributes>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTutorialEventCommand._execute_d__6.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<MutableAttributes>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001AB5 RID: 6837
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001AB6 RID: 6838
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001AB7 RID: 6839
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001AB8 RID: 6840
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001AB9 RID: 6841
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001ABA RID: 6842
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001ABB RID: 6843
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001ABC RID: 6844
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001ABD RID: 6845
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001ABE RID: 6846
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001ABF RID: 6847
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
