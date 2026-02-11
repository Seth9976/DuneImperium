using System;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.data.readonlyWrappers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.selection.targetinformation;
using Networking.selection.targetresponse;

namespace dwd.core.match.selection
{
	// Token: 0x0200014E RID: 334
	public class ArchetypeCustomChoiceTargetInfoNode : TargetInfoNode
	{
		// Token: 0x06001328 RID: 4904 RVA: 0x00060D5C File Offset: 0x0005EF5C
		// Note: this type is marked as 'beforefieldinit'.
		static ArchetypeCustomChoiceTargetInfoNode()
		{
			Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInfoNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection", "ArchetypeCustomChoiceTargetInfoNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInfoNode>.NativeClassPtr);
			ArchetypeCustomChoiceTargetInfoNode.NativeFieldInfoPtr_targetInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInfoNode>.NativeClassPtr, "targetInfo");
			ArchetypeCustomChoiceTargetInfoNode.NativeFieldInfoPtr_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInfoNode>.NativeClassPtr, "buttons");
			ArchetypeCustomChoiceTargetInfoNode.NativeFieldInfoPtr_selectedNumbers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInfoNode>.NativeClassPtr, "selectedNumbers");
			ArchetypeCustomChoiceTargetInfoNode.NativeMethodInfoPtr_get_Buttons_Public_Virtual_Final_New_get_IReadOnlyList_1_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInfoNode>.NativeClassPtr, 100666179);
			ArchetypeCustomChoiceTargetInfoNode.NativeMethodInfoPtr_get_SelectedNumbers_Public_Virtual_Final_New_get_IList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInfoNode>.NativeClassPtr, 100666180);
			ArchetypeCustomChoiceTargetInfoNode.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_ArchetypeCustomChoiceTargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInfoNode>.NativeClassPtr, 100666181);
			ArchetypeCustomChoiceTargetInfoNode.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_ArchetypeCustomChoiceTargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInfoNode>.NativeClassPtr, 100666182);
			ArchetypeCustomChoiceTargetInfoNode.NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInfoNode>.NativeClassPtr, 100666183);
			ArchetypeCustomChoiceTargetInfoNode.NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInfoNode>.NativeClassPtr, 100666184);
			ArchetypeCustomChoiceTargetInfoNode.NativeMethodInfoPtr_get_Forced_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInfoNode>.NativeClassPtr, 100666185);
			ArchetypeCustomChoiceTargetInfoNode.NativeMethodInfoPtr_get_satisfied_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInfoNode>.NativeClassPtr, 100666186);
			ArchetypeCustomChoiceTargetInfoNode.NativeMethodInfoPtr_getResponse_Protected_Virtual_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInfoNode>.NativeClassPtr, 100666187);
			ArchetypeCustomChoiceTargetInfoNode.NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInfoNode>.NativeClassPtr, 100666188);
			ArchetypeCustomChoiceTargetInfoNode.NativeMethodInfoPtr_Unselect_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInfoNode>.NativeClassPtr, 100666189);
			ArchetypeCustomChoiceTargetInfoNode.NativeMethodInfoPtr_get_SourceEntity_Public_Virtual_Final_New_get_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInfoNode>.NativeClassPtr, 100666190);
			ArchetypeCustomChoiceTargetInfoNode.NativeMethodInfoPtr_get_MaxToSelect_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInfoNode>.NativeClassPtr, 100666191);
			ArchetypeCustomChoiceTargetInfoNode.NativeMethodInfoPtr_get_MinToSelect_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInfoNode>.NativeClassPtr, 100666192);
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06001329 RID: 4905 RVA: 0x00060EE0 File Offset: 0x0005F0E0
		public unsafe virtual IReadOnlyList<ReadOnlyAttributes> Buttons
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeCustomChoiceTargetInfoNode.NativeMethodInfoPtr_get_Buttons_Public_Virtual_Final_New_get_IReadOnlyList_1_ReadOnlyAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<ReadOnlyAttributes>>(intPtr3) : null;
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x0600132A RID: 4906 RVA: 0x00060F20 File Offset: 0x0005F120
		public unsafe virtual IList<int> SelectedNumbers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeCustomChoiceTargetInfoNode.NativeMethodInfoPtr_get_SelectedNumbers_Public_Virtual_Final_New_get_IList_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<int>>(intPtr3) : null;
			}
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x00060F60 File Offset: 0x0005F160
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 873227, RefRangeEnd = 873228, XrefRangeStart = 873183, XrefRangeEnd = 873227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArchetypeCustomChoiceTargetInfoNode(ISelectionNodeFactory factory, ArchetypeCustomChoiceTargetInformation info, bool mayCancel, ISelectionRoot root, ISelectionNode parent, IEnumerable<TargetInformation> subsequent, string kind)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInfoNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(factory);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mayCancel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subsequent);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(kind);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeCustomChoiceTargetInfoNode.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_ArchetypeCustomChoiceTargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x00061018 File Offset: 0x0005F218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873228, XrefRangeEnd = 873274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArchetypeCustomChoiceTargetInfoNode(ISelectionNodeFactory factory, ArchetypeCustomChoiceTargetInformation info, bool mayCancel, ISelectionRoot root, ISelectionNode parent, IEnumerable<TargetInformation> subsequent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInfoNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(factory);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mayCancel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subsequent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeCustomChoiceTargetInfoNode.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_ArchetypeCustomChoiceTargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x0600132D RID: 4909 RVA: 0x000610BC File Offset: 0x0005F2BC
		public unsafe override bool HasClearableState
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873274, XrefRangeEnd = 873275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArchetypeCustomChoiceTargetInfoNode.NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x00061104 File Offset: 0x0005F304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873275, XrefRangeEnd = 873276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArchetypeCustomChoiceTargetInfoNode.NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x0600132F RID: 4911 RVA: 0x00061140 File Offset: 0x0005F340
		public unsafe virtual bool Forced
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeCustomChoiceTargetInfoNode.NativeMethodInfoPtr_get_Forced_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06001330 RID: 4912 RVA: 0x0006117C File Offset: 0x0005F37C
		public unsafe override bool satisfied
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873276, XrefRangeEnd = 873277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArchetypeCustomChoiceTargetInfoNode.NativeMethodInfoPtr_get_satisfied_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x000611C4 File Offset: 0x0005F3C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873277, XrefRangeEnd = 873281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override TargetResponse getResponse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArchetypeCustomChoiceTargetInfoNode.NativeMethodInfoPtr_getResponse_Protected_Virtual_TargetResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetResponse>(intPtr3) : null;
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x00061210 File Offset: 0x0005F410
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 873284, RefRangeEnd = 873286, XrefRangeStart = 873281, XrefRangeEnd = 873284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Select(int selection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref selection;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeCustomChoiceTargetInfoNode.NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x00061250 File Offset: 0x0005F450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873286, XrefRangeEnd = 873290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Unselect(int selection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref selection;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeCustomChoiceTargetInfoNode.NativeMethodInfoPtr_Unselect_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06001334 RID: 4916 RVA: 0x00061290 File Offset: 0x0005F490
		public unsafe virtual EntityID SourceEntity
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeCustomChoiceTargetInfoNode.NativeMethodInfoPtr_get_SourceEntity_Public_Virtual_Final_New_get_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06001335 RID: 4917 RVA: 0x000612D0 File Offset: 0x0005F4D0
		public unsafe virtual int MaxToSelect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeCustomChoiceTargetInfoNode.NativeMethodInfoPtr_get_MaxToSelect_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06001336 RID: 4918 RVA: 0x0006130C File Offset: 0x0005F50C
		public unsafe virtual int MinToSelect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeCustomChoiceTargetInfoNode.NativeMethodInfoPtr_get_MinToSelect_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x0000889F File Offset: 0x00006A9F
		public ArchetypeCustomChoiceTargetInfoNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06001338 RID: 4920 RVA: 0x00061348 File Offset: 0x0005F548
		// (set) Token: 0x06001339 RID: 4921 RVA: 0x000088A8 File Offset: 0x00006AA8
		public new unsafe ArchetypeCustomChoiceTargetInformation targetInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoiceTargetInfoNode.NativeFieldInfoPtr_targetInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeCustomChoiceTargetInformation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoiceTargetInfoNode.NativeFieldInfoPtr_targetInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x0600133A RID: 4922 RVA: 0x00061378 File Offset: 0x0005F578
		// (set) Token: 0x0600133B RID: 4923 RVA: 0x000088C7 File Offset: 0x00006AC7
		public unsafe ReadOnlyList<ReadOnlyAttributes> buttons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoiceTargetInfoNode.NativeFieldInfoPtr_buttons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyList<ReadOnlyAttributes>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoiceTargetInfoNode.NativeFieldInfoPtr_buttons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x0600133C RID: 4924 RVA: 0x000613A8 File Offset: 0x0005F5A8
		// (set) Token: 0x0600133D RID: 4925 RVA: 0x000088E6 File Offset: 0x00006AE6
		public unsafe List<int> selectedNumbers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoiceTargetInfoNode.NativeFieldInfoPtr_selectedNumbers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoiceTargetInfoNode.NativeFieldInfoPtr_selectedNumbers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DB4 RID: 3508
		private static readonly IntPtr NativeFieldInfoPtr_targetInfo;

		// Token: 0x04000DB5 RID: 3509
		private static readonly IntPtr NativeFieldInfoPtr_buttons;

		// Token: 0x04000DB6 RID: 3510
		private static readonly IntPtr NativeFieldInfoPtr_selectedNumbers;

		// Token: 0x04000DB7 RID: 3511
		private static readonly IntPtr NativeMethodInfoPtr_get_Buttons_Public_Virtual_Final_New_get_IReadOnlyList_1_ReadOnlyAttributes_0;

		// Token: 0x04000DB8 RID: 3512
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedNumbers_Public_Virtual_Final_New_get_IList_1_Int32_0;

		// Token: 0x04000DB9 RID: 3513
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_ArchetypeCustomChoiceTargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_String_0;

		// Token: 0x04000DBA RID: 3514
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_ArchetypeCustomChoiceTargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0;

		// Token: 0x04000DBB RID: 3515
		private static readonly IntPtr NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0;

		// Token: 0x04000DBC RID: 3516
		private static readonly IntPtr NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0;

		// Token: 0x04000DBD RID: 3517
		private static readonly IntPtr NativeMethodInfoPtr_get_Forced_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000DBE RID: 3518
		private static readonly IntPtr NativeMethodInfoPtr_get_satisfied_Protected_Virtual_get_Boolean_0;

		// Token: 0x04000DBF RID: 3519
		private static readonly IntPtr NativeMethodInfoPtr_getResponse_Protected_Virtual_TargetResponse_0;

		// Token: 0x04000DC0 RID: 3520
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_Int32_0;

		// Token: 0x04000DC1 RID: 3521
		private static readonly IntPtr NativeMethodInfoPtr_Unselect_Public_Virtual_Final_New_Void_Int32_0;

		// Token: 0x04000DC2 RID: 3522
		private static readonly IntPtr NativeMethodInfoPtr_get_SourceEntity_Public_Virtual_Final_New_get_EntityID_0;

		// Token: 0x04000DC3 RID: 3523
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxToSelect_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000DC4 RID: 3524
		private static readonly IntPtr NativeMethodInfoPtr_get_MinToSelect_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x020002DF RID: 735
		[ObfuscatedName("dwd.core.match.selection.ArchetypeCustomChoiceTargetInfoNode+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x060021F3 RID: 8691 RVA: 0x00097588 File Offset: 0x00095788
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInfoNode.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInfoNode>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInfoNode.__c>.NativeClassPtr);
				ArchetypeCustomChoiceTargetInfoNode.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInfoNode.__c>.NativeClassPtr, "<>9");
				ArchetypeCustomChoiceTargetInfoNode.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInfoNode.__c>.NativeClassPtr, "<>9__7_0");
				ArchetypeCustomChoiceTargetInfoNode.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInfoNode.__c>.NativeClassPtr, "<>9__8_0");
				ArchetypeCustomChoiceTargetInfoNode.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInfoNode.__c>.NativeClassPtr, 100666194);
				ArchetypeCustomChoiceTargetInfoNode.__c.NativeMethodInfoPtr___ctor_b__7_0_Internal_ReadOnlyAttributes_SerializableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInfoNode.__c>.NativeClassPtr, 100666195);
				ArchetypeCustomChoiceTargetInfoNode.__c.NativeMethodInfoPtr___ctor_b__8_0_Internal_ReadOnlyAttributes_SerializableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInfoNode.__c>.NativeClassPtr, 100666196);
			}

			// Token: 0x060021F4 RID: 8692 RVA: 0x0009762C File Offset: 0x0009582C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInfoNode.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeCustomChoiceTargetInfoNode.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021F5 RID: 8693 RVA: 0x00097668 File Offset: 0x00095868
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873182, XrefRangeEnd = 873183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadOnlyAttributes __ctor_b__7_0(SerializableAttributes choice)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(choice);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeCustomChoiceTargetInfoNode.__c.NativeMethodInfoPtr___ctor_b__7_0_Internal_ReadOnlyAttributes_SerializableAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr3) : null;
				}
			}

			// Token: 0x060021F6 RID: 8694 RVA: 0x000976B8 File Offset: 0x000958B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadOnlyAttributes __ctor_b__8_0(SerializableAttributes choice)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(choice);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeCustomChoiceTargetInfoNode.__c.NativeMethodInfoPtr___ctor_b__8_0_Internal_ReadOnlyAttributes_SerializableAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr3) : null;
				}
			}

			// Token: 0x060021F7 RID: 8695 RVA: 0x0000E8C7 File Offset: 0x0000CAC7
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000942 RID: 2370
			// (get) Token: 0x060021F8 RID: 8696 RVA: 0x00097708 File Offset: 0x00095908
			// (set) Token: 0x060021F9 RID: 8697 RVA: 0x0000E8D0 File Offset: 0x0000CAD0
			public unsafe static ArchetypeCustomChoiceTargetInfoNode.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ArchetypeCustomChoiceTargetInfoNode.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeCustomChoiceTargetInfoNode.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ArchetypeCustomChoiceTargetInfoNode.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000943 RID: 2371
			// (get) Token: 0x060021FA RID: 8698 RVA: 0x00097730 File Offset: 0x00095930
			// (set) Token: 0x060021FB RID: 8699 RVA: 0x0000E8E2 File Offset: 0x0000CAE2
			public unsafe static Func<SerializableAttributes, ReadOnlyAttributes> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ArchetypeCustomChoiceTargetInfoNode.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SerializableAttributes, ReadOnlyAttributes>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ArchetypeCustomChoiceTargetInfoNode.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000944 RID: 2372
			// (get) Token: 0x060021FC RID: 8700 RVA: 0x00097758 File Offset: 0x00095958
			// (set) Token: 0x060021FD RID: 8701 RVA: 0x0000E8F4 File Offset: 0x0000CAF4
			public unsafe static Func<SerializableAttributes, ReadOnlyAttributes> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ArchetypeCustomChoiceTargetInfoNode.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SerializableAttributes, ReadOnlyAttributes>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ArchetypeCustomChoiceTargetInfoNode.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001784 RID: 6020
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001785 RID: 6021
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04001786 RID: 6022
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04001787 RID: 6023
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001788 RID: 6024
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__7_0_Internal_ReadOnlyAttributes_SerializableAttributes_0;

			// Token: 0x04001789 RID: 6025
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__8_0_Internal_ReadOnlyAttributes_SerializableAttributes_0;
		}
	}
}
