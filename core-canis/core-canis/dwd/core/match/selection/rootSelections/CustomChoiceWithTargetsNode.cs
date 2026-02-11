using System;
using Canis.messages;
using Canis.utils.ids;
using dwd.core.data.readonlyWrappers;
using dwd.core.match.selection.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.selection.targetinformation;

namespace dwd.core.match.selection.rootSelections
{
	// Token: 0x02000159 RID: 345
	public class CustomChoiceWithTargetsNode : RootSelection
	{
		// Token: 0x06001437 RID: 5175 RVA: 0x000658C4 File Offset: 0x00063AC4
		// Note: this type is marked as 'beforefieldinit'.
		static CustomChoiceWithTargetsNode()
		{
			Il2CppClassPointerStore<CustomChoiceWithTargetsNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection.rootSelections", "CustomChoiceWithTargetsNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomChoiceWithTargetsNode>.NativeClassPtr);
			CustomChoiceWithTargetsNode.NativeFieldInfoPtr__ChoiceKind_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceWithTargetsNode>.NativeClassPtr, "<ChoiceKind>k__BackingField");
			CustomChoiceWithTargetsNode.NativeFieldInfoPtr__SourceEntity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceWithTargetsNode>.NativeClassPtr, "<SourceEntity>k__BackingField");
			CustomChoiceWithTargetsNode.NativeFieldInfoPtr__SelectedNumber_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceWithTargetsNode>.NativeClassPtr, "<SelectedNumber>k__BackingField");
			CustomChoiceWithTargetsNode.NativeFieldInfoPtr_gameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceWithTargetsNode>.NativeClassPtr, "gameID");
			CustomChoiceWithTargetsNode.NativeFieldInfoPtr_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceWithTargetsNode>.NativeClassPtr, "counter");
			CustomChoiceWithTargetsNode.NativeFieldInfoPtr_forced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceWithTargetsNode>.NativeClassPtr, "forced");
			CustomChoiceWithTargetsNode.NativeFieldInfoPtr_ignoreFirst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceWithTargetsNode>.NativeClassPtr, "ignoreFirst");
			CustomChoiceWithTargetsNode.NativeFieldInfoPtr_choices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceWithTargetsNode>.NativeClassPtr, "choices");
			CustomChoiceWithTargetsNode.NativeFieldInfoPtr_choiceTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceWithTargetsNode>.NativeClassPtr, "choiceTargets");
			CustomChoiceWithTargetsNode.NativeFieldInfoPtr_choicePreferences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceWithTargetsNode>.NativeClassPtr, "choicePreferences");
			CustomChoiceWithTargetsNode.NativeMethodInfoPtr_get_ChoiceKind_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceWithTargetsNode>.NativeClassPtr, 100666368);
			CustomChoiceWithTargetsNode.NativeMethodInfoPtr_get_Choices_Public_Virtual_Final_New_get_IReadOnlyList_1_SerializedEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceWithTargetsNode>.NativeClassPtr, 100666369);
			CustomChoiceWithTargetsNode.NativeMethodInfoPtr_get_ChoicePreferences_Public_Virtual_Final_New_get_IReadOnlyList_1_TargetPreference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceWithTargetsNode>.NativeClassPtr, 100666370);
			CustomChoiceWithTargetsNode.NativeMethodInfoPtr_get_SourceEntity_Public_Virtual_Final_New_get_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceWithTargetsNode>.NativeClassPtr, 100666371);
			CustomChoiceWithTargetsNode.NativeMethodInfoPtr_get_SelectedNumber_Public_Virtual_Final_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceWithTargetsNode>.NativeClassPtr, 100666372);
			CustomChoiceWithTargetsNode.NativeMethodInfoPtr_set_SelectedNumber_Private_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceWithTargetsNode>.NativeClassPtr, 100666373);
			CustomChoiceWithTargetsNode.NativeMethodInfoPtr_get_MayAdvance_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceWithTargetsNode>.NativeClassPtr, 100666374);
			CustomChoiceWithTargetsNode.NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceWithTargetsNode>.NativeClassPtr, 100666375);
			CustomChoiceWithTargetsNode.NativeMethodInfoPtr_get_Forced_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceWithTargetsNode>.NativeClassPtr, 100666376);
			CustomChoiceWithTargetsNode.NativeMethodInfoPtr__ctor_Public_Void_CustomChoiceWithTargetsRequired_ISelectionNodeFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceWithTargetsNode>.NativeClassPtr, 100666377);
			CustomChoiceWithTargetsNode.NativeMethodInfoPtr_NodeToAdvanceTo_Public_Virtual_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceWithTargetsNode>.NativeClassPtr, 100666378);
			CustomChoiceWithTargetsNode.NativeMethodInfoPtr_enter_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceWithTargetsNode>.NativeClassPtr, 100666379);
			CustomChoiceWithTargetsNode.NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceWithTargetsNode>.NativeClassPtr, 100666380);
			CustomChoiceWithTargetsNode.NativeMethodInfoPtr_getResponseMessage_Protected_Virtual_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceWithTargetsNode>.NativeClassPtr, 100666381);
			CustomChoiceWithTargetsNode.NativeMethodInfoPtr_dwd_core_match_selection_ISingleIntegerChoice_Select_Private_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceWithTargetsNode>.NativeClassPtr, 100666382);
			CustomChoiceWithTargetsNode.NativeMethodInfoPtr_Unselect_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceWithTargetsNode>.NativeClassPtr, 100666383);
			CustomChoiceWithTargetsNode.NativeMethodInfoPtr_dwd_core_match_selection_ISingleIntegerChoice_PeekNode_Private_Virtual_Final_New_ISelectionNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceWithTargetsNode>.NativeClassPtr, 100666384);
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06001438 RID: 5176 RVA: 0x00065B10 File Offset: 0x00063D10
		public unsafe virtual string ChoiceKind
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceWithTargetsNode.NativeMethodInfoPtr_get_ChoiceKind_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06001439 RID: 5177 RVA: 0x00065B48 File Offset: 0x00063D48
		public unsafe virtual IReadOnlyList<SerializedEntity> Choices
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceWithTargetsNode.NativeMethodInfoPtr_get_Choices_Public_Virtual_Final_New_get_IReadOnlyList_1_SerializedEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<SerializedEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x0600143A RID: 5178 RVA: 0x00065B88 File Offset: 0x00063D88
		public unsafe virtual IReadOnlyList<TargetPreference> ChoicePreferences
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceWithTargetsNode.NativeMethodInfoPtr_get_ChoicePreferences_Public_Virtual_Final_New_get_IReadOnlyList_1_TargetPreference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<TargetPreference>>(intPtr3) : null;
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x0600143B RID: 5179 RVA: 0x00065BC8 File Offset: 0x00063DC8
		public unsafe virtual EntityID SourceEntity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceWithTargetsNode.NativeMethodInfoPtr_get_SourceEntity_Public_Virtual_Final_New_get_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x0600143C RID: 5180 RVA: 0x00065C08 File Offset: 0x00063E08
		// (set) Token: 0x0600143D RID: 5181 RVA: 0x00065C40 File Offset: 0x00063E40
		public unsafe virtual Nullable<int> SelectedNumber
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceWithTargetsNode.NativeMethodInfoPtr_get_SelectedNumber_Public_Virtual_Final_New_get_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceWithTargetsNode.NativeMethodInfoPtr_set_SelectedNumber_Private_set_Void_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x0600143E RID: 5182 RVA: 0x00065C88 File Offset: 0x00063E88
		public unsafe override bool MayAdvance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874622, XrefRangeEnd = 874623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomChoiceWithTargetsNode.NativeMethodInfoPtr_get_MayAdvance_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x0600143F RID: 5183 RVA: 0x00065CD0 File Offset: 0x00063ED0
		public unsafe override bool HasClearableState
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874623, XrefRangeEnd = 874624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomChoiceWithTargetsNode.NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06001440 RID: 5184 RVA: 0x00065D18 File Offset: 0x00063F18
		public unsafe virtual bool Forced
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceWithTargetsNode.NativeMethodInfoPtr_get_Forced_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x00065D54 File Offset: 0x00063F54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 874712, RefRangeEnd = 874713, XrefRangeStart = 874624, XrefRangeEnd = 874712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomChoiceWithTargetsNode(CustomChoiceWithTargetsRequired message, ISelectionNodeFactory factory)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomChoiceWithTargetsNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(factory);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceWithTargetsNode.NativeMethodInfoPtr__ctor_Public_Void_CustomChoiceWithTargetsRequired_ISelectionNodeFactory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x00065DB4 File Offset: 0x00063FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874713, XrefRangeEnd = 874720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ISelectionNode NodeToAdvanceTo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomChoiceWithTargetsNode.NativeMethodInfoPtr_NodeToAdvanceTo_Public_Virtual_ISelectionNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x00065E00 File Offset: 0x00064000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874720, XrefRangeEnd = 874727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void enter(bool fromCancel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromCancel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomChoiceWithTargetsNode.NativeMethodInfoPtr_enter_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x00065E4C File Offset: 0x0006404C
		[CallerCount(0)]
		public unsafe override void ClearState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomChoiceWithTargetsNode.NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x00065E88 File Offset: 0x00064088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874727, XrefRangeEnd = 874748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object getResponseMessage(bool cancelled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cancelled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomChoiceWithTargetsNode.NativeMethodInfoPtr_getResponseMessage_Protected_Virtual_Object_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x00065EE0 File Offset: 0x000640E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874748, XrefRangeEnd = 874751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void dwd_core_match_selection_ISingleIntegerChoice_Select(int selection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref selection;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceWithTargetsNode.NativeMethodInfoPtr_dwd_core_match_selection_ISingleIntegerChoice_Select_Private_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x00065F20 File Offset: 0x00064120
		[CallerCount(0)]
		public unsafe virtual void Unselect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceWithTargetsNode.NativeMethodInfoPtr_Unselect_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x00065F54 File Offset: 0x00064154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874751, XrefRangeEnd = 874755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISelectionNode dwd_core_match_selection_ISingleIntegerChoice_PeekNode(int number)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref number;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceWithTargetsNode.NativeMethodInfoPtr_dwd_core_match_selection_ISingleIntegerChoice_PeekNode_Private_Virtual_Final_New_ISelectionNode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
			}
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x00008E43 File Offset: 0x00007043
		public CustomChoiceWithTargetsNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x0600144A RID: 5194 RVA: 0x00065FA0 File Offset: 0x000641A0
		// (set) Token: 0x0600144B RID: 5195 RVA: 0x00008E4C File Offset: 0x0000704C
		public unsafe string _ChoiceKind_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargetsNode.NativeFieldInfoPtr__ChoiceKind_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargetsNode.NativeFieldInfoPtr__ChoiceKind_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x0600144C RID: 5196 RVA: 0x00065FC8 File Offset: 0x000641C8
		// (set) Token: 0x0600144D RID: 5197 RVA: 0x00008E6B File Offset: 0x0000706B
		public unsafe EntityID _SourceEntity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargetsNode.NativeFieldInfoPtr__SourceEntity_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargetsNode.NativeFieldInfoPtr__SourceEntity_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x0600144E RID: 5198 RVA: 0x00065FF8 File Offset: 0x000641F8
		// (set) Token: 0x0600144F RID: 5199 RVA: 0x00008E8A File Offset: 0x0000708A
		public Nullable<int> _SelectedNumber_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargetsNode.NativeFieldInfoPtr__SelectedNumber_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargetsNode.NativeFieldInfoPtr__SelectedNumber_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06001450 RID: 5200 RVA: 0x00066028 File Offset: 0x00064228
		// (set) Token: 0x06001451 RID: 5201 RVA: 0x00008EB8 File Offset: 0x000070B8
		public unsafe GameID gameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargetsNode.NativeFieldInfoPtr_gameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargetsNode.NativeFieldInfoPtr_gameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06001452 RID: 5202 RVA: 0x00066058 File Offset: 0x00064258
		// (set) Token: 0x06001453 RID: 5203 RVA: 0x00008ED7 File Offset: 0x000070D7
		public unsafe int counter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargetsNode.NativeFieldInfoPtr_counter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargetsNode.NativeFieldInfoPtr_counter)) = value;
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001454 RID: 5204 RVA: 0x00066080 File Offset: 0x00064280
		// (set) Token: 0x06001455 RID: 5205 RVA: 0x00008EF2 File Offset: 0x000070F2
		public unsafe bool forced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargetsNode.NativeFieldInfoPtr_forced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargetsNode.NativeFieldInfoPtr_forced)) = value;
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06001456 RID: 5206 RVA: 0x000660A8 File Offset: 0x000642A8
		// (set) Token: 0x06001457 RID: 5207 RVA: 0x00008F0D File Offset: 0x0000710D
		public unsafe bool ignoreFirst
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargetsNode.NativeFieldInfoPtr_ignoreFirst);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargetsNode.NativeFieldInfoPtr_ignoreFirst)) = value;
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06001458 RID: 5208 RVA: 0x000660D0 File Offset: 0x000642D0
		// (set) Token: 0x06001459 RID: 5209 RVA: 0x00008F28 File Offset: 0x00007128
		public unsafe ReadOnlyList<SerializedEntity> choices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargetsNode.NativeFieldInfoPtr_choices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyList<SerializedEntity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargetsNode.NativeFieldInfoPtr_choices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x0600145A RID: 5210 RVA: 0x00066100 File Offset: 0x00064300
		// (set) Token: 0x0600145B RID: 5211 RVA: 0x00008F47 File Offset: 0x00007147
		public unsafe ReadOnlyList<TargetInfoNode> choiceTargets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargetsNode.NativeFieldInfoPtr_choiceTargets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyList<TargetInfoNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargetsNode.NativeFieldInfoPtr_choiceTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x0600145C RID: 5212 RVA: 0x00066130 File Offset: 0x00064330
		// (set) Token: 0x0600145D RID: 5213 RVA: 0x00008F66 File Offset: 0x00007166
		public unsafe ReadOnlyList<TargetPreference> choicePreferences
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargetsNode.NativeFieldInfoPtr_choicePreferences);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyList<TargetPreference>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargetsNode.NativeFieldInfoPtr_choicePreferences), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E81 RID: 3713
		private static readonly IntPtr NativeFieldInfoPtr__ChoiceKind_k__BackingField;

		// Token: 0x04000E82 RID: 3714
		private static readonly IntPtr NativeFieldInfoPtr__SourceEntity_k__BackingField;

		// Token: 0x04000E83 RID: 3715
		private static readonly IntPtr NativeFieldInfoPtr__SelectedNumber_k__BackingField;

		// Token: 0x04000E84 RID: 3716
		private static readonly IntPtr NativeFieldInfoPtr_gameID;

		// Token: 0x04000E85 RID: 3717
		private static readonly IntPtr NativeFieldInfoPtr_counter;

		// Token: 0x04000E86 RID: 3718
		private static readonly IntPtr NativeFieldInfoPtr_forced;

		// Token: 0x04000E87 RID: 3719
		private static readonly IntPtr NativeFieldInfoPtr_ignoreFirst;

		// Token: 0x04000E88 RID: 3720
		private static readonly IntPtr NativeFieldInfoPtr_choices;

		// Token: 0x04000E89 RID: 3721
		private static readonly IntPtr NativeFieldInfoPtr_choiceTargets;

		// Token: 0x04000E8A RID: 3722
		private static readonly IntPtr NativeFieldInfoPtr_choicePreferences;

		// Token: 0x04000E8B RID: 3723
		private static readonly IntPtr NativeMethodInfoPtr_get_ChoiceKind_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000E8C RID: 3724
		private static readonly IntPtr NativeMethodInfoPtr_get_Choices_Public_Virtual_Final_New_get_IReadOnlyList_1_SerializedEntity_0;

		// Token: 0x04000E8D RID: 3725
		private static readonly IntPtr NativeMethodInfoPtr_get_ChoicePreferences_Public_Virtual_Final_New_get_IReadOnlyList_1_TargetPreference_0;

		// Token: 0x04000E8E RID: 3726
		private static readonly IntPtr NativeMethodInfoPtr_get_SourceEntity_Public_Virtual_Final_New_get_EntityID_0;

		// Token: 0x04000E8F RID: 3727
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedNumber_Public_Virtual_Final_New_get_Nullable_1_Int32_0;

		// Token: 0x04000E90 RID: 3728
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedNumber_Private_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000E91 RID: 3729
		private static readonly IntPtr NativeMethodInfoPtr_get_MayAdvance_Public_Virtual_get_Boolean_0;

		// Token: 0x04000E92 RID: 3730
		private static readonly IntPtr NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0;

		// Token: 0x04000E93 RID: 3731
		private static readonly IntPtr NativeMethodInfoPtr_get_Forced_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000E94 RID: 3732
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CustomChoiceWithTargetsRequired_ISelectionNodeFactory_0;

		// Token: 0x04000E95 RID: 3733
		private static readonly IntPtr NativeMethodInfoPtr_NodeToAdvanceTo_Public_Virtual_ISelectionNode_0;

		// Token: 0x04000E96 RID: 3734
		private static readonly IntPtr NativeMethodInfoPtr_enter_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04000E97 RID: 3735
		private static readonly IntPtr NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0;

		// Token: 0x04000E98 RID: 3736
		private static readonly IntPtr NativeMethodInfoPtr_getResponseMessage_Protected_Virtual_Object_Boolean_0;

		// Token: 0x04000E99 RID: 3737
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_match_selection_ISingleIntegerChoice_Select_Private_Virtual_Final_New_Void_Int32_0;

		// Token: 0x04000E9A RID: 3738
		private static readonly IntPtr NativeMethodInfoPtr_Unselect_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000E9B RID: 3739
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_match_selection_ISingleIntegerChoice_PeekNode_Private_Virtual_Final_New_ISelectionNode_Int32_0;
	}
}
