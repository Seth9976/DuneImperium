using System;
using Canis.utils.ids;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Networking.selection.targetinformation;
using Networking.selection.targetresponse;

namespace tc.selection
{
	// Token: 0x0200002D RID: 45
	public class EntityGroupingTargetNode : TargetInfoNode
	{
		// Token: 0x0600019D RID: 413 RVA: 0x000159DC File Offset: 0x00013BDC
		// Note: this type is marked as 'beforefieldinit'.
		static EntityGroupingTargetNode()
		{
			Il2CppClassPointerStore<EntityGroupingTargetNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "tc.selection", "EntityGroupingTargetNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityGroupingTargetNode>.NativeClassPtr);
			EntityGroupingTargetNode.NativeFieldInfoPtr_Groups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityGroupingTargetNode>.NativeClassPtr, "Groups");
			EntityGroupingTargetNode.NativeFieldInfoPtr_Selections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityGroupingTargetNode>.NativeClassPtr, "Selections");
			EntityGroupingTargetNode.NativeFieldInfoPtr_groups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityGroupingTargetNode>.NativeClassPtr, "groups");
			EntityGroupingTargetNode.NativeFieldInfoPtr_selections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityGroupingTargetNode>.NativeClassPtr, "selections");
			EntityGroupingTargetNode.NativeFieldInfoPtr_targetInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityGroupingTargetNode>.NativeClassPtr, "targetInfo");
			EntityGroupingTargetNode.NativeMethodInfoPtr_get_MinimumToSelect_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityGroupingTargetNode>.NativeClassPtr, 100663591);
			EntityGroupingTargetNode.NativeMethodInfoPtr_get_NumberToSelect_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityGroupingTargetNode>.NativeClassPtr, 100663592);
			EntityGroupingTargetNode.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_EntityGroupingTargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityGroupingTargetNode>.NativeClassPtr, 100663593);
			EntityGroupingTargetNode.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_EntityGroupingTargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityGroupingTargetNode>.NativeClassPtr, 100663594);
			EntityGroupingTargetNode.NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityGroupingTargetNode>.NativeClassPtr, 100663595);
			EntityGroupingTargetNode.NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityGroupingTargetNode>.NativeClassPtr, 100663596);
			EntityGroupingTargetNode.NativeMethodInfoPtr_get_satisfied_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityGroupingTargetNode>.NativeClassPtr, 100663597);
			EntityGroupingTargetNode.NativeMethodInfoPtr_Select_Public_Void_Grouping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityGroupingTargetNode>.NativeClassPtr, 100663598);
			EntityGroupingTargetNode.NativeMethodInfoPtr_Unselect_Public_Void_Grouping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityGroupingTargetNode>.NativeClassPtr, 100663599);
			EntityGroupingTargetNode.NativeMethodInfoPtr_Select_Public_Void_Grouping_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityGroupingTargetNode>.NativeClassPtr, 100663600);
			EntityGroupingTargetNode.NativeMethodInfoPtr_Unselect_Public_Void_Grouping_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityGroupingTargetNode>.NativeClassPtr, 100663601);
			EntityGroupingTargetNode.NativeMethodInfoPtr_getResponse_Protected_Virtual_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityGroupingTargetNode>.NativeClassPtr, 100663602);
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600019E RID: 414 RVA: 0x00015B60 File Offset: 0x00013D60
		public unsafe int MinimumToSelect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityGroupingTargetNode.NativeMethodInfoPtr_get_MinimumToSelect_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00015B9C File Offset: 0x00013D9C
		public unsafe int NumberToSelect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityGroupingTargetNode.NativeMethodInfoPtr_get_NumberToSelect_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00015BD8 File Offset: 0x00013DD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 984003, RefRangeEnd = 984004, XrefRangeStart = 983966, XrefRangeEnd = 984003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityGroupingTargetNode(ISelectionNodeFactory factory, EntityGroupingTargetInformation info, bool mayCancel, ISelectionRoot root, ISelectionNode parent, IEnumerable<TargetInformation> subsequent, string kind)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityGroupingTargetNode>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityGroupingTargetNode.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_EntityGroupingTargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00015C90 File Offset: 0x00013E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984004, XrefRangeEnd = 984041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityGroupingTargetNode(ISelectionNodeFactory factory, EntityGroupingTargetInformation info, bool mayCancel, ISelectionRoot root, ISelectionNode parent, IEnumerable<TargetInformation> subsequent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityGroupingTargetNode>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityGroupingTargetNode.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_EntityGroupingTargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x00015D34 File Offset: 0x00013F34
		public unsafe override bool HasClearableState
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984041, XrefRangeEnd = 984059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityGroupingTargetNode.NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00015D7C File Offset: 0x00013F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984059, XrefRangeEnd = 984062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityGroupingTargetNode.NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00015DB8 File Offset: 0x00013FB8
		public unsafe override bool satisfied
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984062, XrefRangeEnd = 984095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityGroupingTargetNode.NativeMethodInfoPtr_get_satisfied_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00015E00 File Offset: 0x00014000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984095, XrefRangeEnd = 984127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Select(EntityGroupingTargetInformation.Grouping grouping)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(grouping);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityGroupingTargetNode.NativeMethodInfoPtr_Select_Public_Void_Grouping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00015E44 File Offset: 0x00014044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984127, XrefRangeEnd = 984146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unselect(EntityGroupingTargetInformation.Grouping grouping)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(grouping);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityGroupingTargetNode.NativeMethodInfoPtr_Unselect_Public_Void_Grouping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00015E88 File Offset: 0x00014088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984146, XrefRangeEnd = 984166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Select(EntityGroupingTargetInformation.Grouping grouping, EntityID entityID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(grouping);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entityID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityGroupingTargetNode.NativeMethodInfoPtr_Select_Public_Void_Grouping_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00015EDC File Offset: 0x000140DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984166, XrefRangeEnd = 984194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unselect(EntityGroupingTargetInformation.Grouping grouping, EntityID entityID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(grouping);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entityID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityGroupingTargetNode.NativeMethodInfoPtr_Unselect_Public_Void_Grouping_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00015F30 File Offset: 0x00014130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984194, XrefRangeEnd = 984216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override TargetResponse getResponse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityGroupingTargetNode.NativeMethodInfoPtr_getResponse_Protected_Virtual_TargetResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetResponse>(intPtr3) : null;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002C0D File Offset: 0x00000E0D
		public EntityGroupingTargetNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001AB RID: 427 RVA: 0x00015F7C File Offset: 0x0001417C
		// (set) Token: 0x060001AC RID: 428 RVA: 0x00002C16 File Offset: 0x00000E16
		public unsafe ReadOnlyCollection<EntityGroupingTargetInformation.Grouping> Groups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityGroupingTargetNode.NativeFieldInfoPtr_Groups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<EntityGroupingTargetInformation.Grouping>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityGroupingTargetNode.NativeFieldInfoPtr_Groups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001AD RID: 429 RVA: 0x00015FAC File Offset: 0x000141AC
		// (set) Token: 0x060001AE RID: 430 RVA: 0x00002C35 File Offset: 0x00000E35
		public unsafe ReadOnlyCollection<List<EntityID>> Selections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityGroupingTargetNode.NativeFieldInfoPtr_Selections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<List<EntityID>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityGroupingTargetNode.NativeFieldInfoPtr_Selections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00015FDC File Offset: 0x000141DC
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x00002C54 File Offset: 0x00000E54
		public unsafe Il2CppReferenceArray<EntityGroupingTargetInformation.Grouping> groups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityGroupingTargetNode.NativeFieldInfoPtr_groups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EntityGroupingTargetInformation.Grouping>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityGroupingTargetNode.NativeFieldInfoPtr_groups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x0001600C File Offset: 0x0001420C
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x00002C73 File Offset: 0x00000E73
		public unsafe Il2CppReferenceArray<List<EntityID>> selections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityGroupingTargetNode.NativeFieldInfoPtr_selections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<List<EntityID>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityGroupingTargetNode.NativeFieldInfoPtr_selections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x0001603C File Offset: 0x0001423C
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x00002C92 File Offset: 0x00000E92
		public new unsafe EntityGroupingTargetInformation targetInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityGroupingTargetNode.NativeFieldInfoPtr_targetInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityGroupingTargetInformation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityGroupingTargetNode.NativeFieldInfoPtr_targetInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeFieldInfoPtr_Groups;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeFieldInfoPtr_Selections;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeFieldInfoPtr_groups;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeFieldInfoPtr_selections;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeFieldInfoPtr_targetInfo;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr_get_MinimumToSelect_Public_get_Int32_0;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr_get_NumberToSelect_Public_get_Int32_0;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_EntityGroupingTargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_String_0;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_EntityGroupingTargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeMethodInfoPtr_get_satisfied_Protected_Virtual_get_Boolean_0;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Void_Grouping_0;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr_Unselect_Public_Void_Grouping_0;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Void_Grouping_EntityID_0;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeMethodInfoPtr_Unselect_Public_Void_Grouping_EntityID_0;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeMethodInfoPtr_getResponse_Protected_Virtual_TargetResponse_0;

		// Token: 0x020001A4 RID: 420
		[ObfuscatedName("tc.selection.EntityGroupingTargetNode+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600148E RID: 5262 RVA: 0x000506AC File Offset: 0x0004E8AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<EntityGroupingTargetNode.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityGroupingTargetNode>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityGroupingTargetNode.__c>.NativeClassPtr);
				EntityGroupingTargetNode.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityGroupingTargetNode.__c>.NativeClassPtr, "<>9");
				EntityGroupingTargetNode.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityGroupingTargetNode.__c>.NativeClassPtr, "<>9__12_0");
				EntityGroupingTargetNode.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityGroupingTargetNode.__c>.NativeClassPtr, "<>9__15_0");
				EntityGroupingTargetNode.__c.NativeFieldInfoPtr___9__15_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityGroupingTargetNode.__c>.NativeClassPtr, "<>9__15_1");
				EntityGroupingTargetNode.__c.NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityGroupingTargetNode.__c>.NativeClassPtr, "<>9__20_0");
				EntityGroupingTargetNode.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityGroupingTargetNode.__c>.NativeClassPtr, 100663604);
				EntityGroupingTargetNode.__c.NativeMethodInfoPtr__get_HasClearableState_b__12_0_Internal_Boolean_List_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityGroupingTargetNode.__c>.NativeClassPtr, 100663605);
				EntityGroupingTargetNode.__c.NativeMethodInfoPtr__get_satisfied_b__15_0_Internal_Boolean_List_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityGroupingTargetNode.__c>.NativeClassPtr, 100663606);
				EntityGroupingTargetNode.__c.NativeMethodInfoPtr__get_satisfied_b__15_1_Internal_Boolean_List_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityGroupingTargetNode.__c>.NativeClassPtr, 100663607);
				EntityGroupingTargetNode.__c.NativeMethodInfoPtr__getResponse_b__20_0_Internal_IEnumerable_1_EntityID_List_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityGroupingTargetNode.__c>.NativeClassPtr, 100663608);
			}

			// Token: 0x0600148F RID: 5263 RVA: 0x000507A0 File Offset: 0x0004E9A0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityGroupingTargetNode.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityGroupingTargetNode.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001490 RID: 5264 RVA: 0x000507DC File Offset: 0x0004E9DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983957, XrefRangeEnd = 983960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_HasClearableState_b__12_0(List<EntityID> groupSelection)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(groupSelection);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityGroupingTargetNode.__c.NativeMethodInfoPtr__get_HasClearableState_b__12_0_Internal_Boolean_List_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001491 RID: 5265 RVA: 0x0005082C File Offset: 0x0004EA2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983960, XrefRangeEnd = 983963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_satisfied_b__15_0(List<EntityID> selectionGroup)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectionGroup);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityGroupingTargetNode.__c.NativeMethodInfoPtr__get_satisfied_b__15_0_Internal_Boolean_List_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001492 RID: 5266 RVA: 0x0005087C File Offset: 0x0004EA7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983963, XrefRangeEnd = 983966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_satisfied_b__15_1(List<EntityID> selectionGroup)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectionGroup);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityGroupingTargetNode.__c.NativeMethodInfoPtr__get_satisfied_b__15_1_Internal_Boolean_List_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001493 RID: 5267 RVA: 0x000508CC File Offset: 0x0004EACC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<EntityID> _getResponse_b__20_0(List<EntityID> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityGroupingTargetNode.__c.NativeMethodInfoPtr__getResponse_b__20_0_Internal_IEnumerable_1_EntityID_List_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<EntityID>>(intPtr3) : null;
				}
			}

			// Token: 0x06001494 RID: 5268 RVA: 0x0000BA60 File Offset: 0x00009C60
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005DC RID: 1500
			// (get) Token: 0x06001495 RID: 5269 RVA: 0x0005091C File Offset: 0x0004EB1C
			// (set) Token: 0x06001496 RID: 5270 RVA: 0x0000BA69 File Offset: 0x00009C69
			public unsafe static EntityGroupingTargetNode.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EntityGroupingTargetNode.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityGroupingTargetNode.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EntityGroupingTargetNode.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005DD RID: 1501
			// (get) Token: 0x06001497 RID: 5271 RVA: 0x00050944 File Offset: 0x0004EB44
			// (set) Token: 0x06001498 RID: 5272 RVA: 0x0000BA7B File Offset: 0x00009C7B
			public unsafe static Func<List<EntityID>, bool> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EntityGroupingTargetNode.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<List<EntityID>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EntityGroupingTargetNode.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005DE RID: 1502
			// (get) Token: 0x06001499 RID: 5273 RVA: 0x0005096C File Offset: 0x0004EB6C
			// (set) Token: 0x0600149A RID: 5274 RVA: 0x0000BA8D File Offset: 0x00009C8D
			public unsafe static Func<List<EntityID>, bool> __9__15_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EntityGroupingTargetNode.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<List<EntityID>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EntityGroupingTargetNode.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005DF RID: 1503
			// (get) Token: 0x0600149B RID: 5275 RVA: 0x00050994 File Offset: 0x0004EB94
			// (set) Token: 0x0600149C RID: 5276 RVA: 0x0000BA9F File Offset: 0x00009C9F
			public unsafe static Func<List<EntityID>, bool> __9__15_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EntityGroupingTargetNode.__c.NativeFieldInfoPtr___9__15_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<List<EntityID>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EntityGroupingTargetNode.__c.NativeFieldInfoPtr___9__15_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005E0 RID: 1504
			// (get) Token: 0x0600149D RID: 5277 RVA: 0x000509BC File Offset: 0x0004EBBC
			// (set) Token: 0x0600149E RID: 5278 RVA: 0x0000BAB1 File Offset: 0x00009CB1
			public unsafe static Func<List<EntityID>, IEnumerable<EntityID>> __9__20_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EntityGroupingTargetNode.__c.NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<List<EntityID>, IEnumerable<EntityID>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EntityGroupingTargetNode.__c.NativeFieldInfoPtr___9__20_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C78 RID: 3192
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000C79 RID: 3193
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x04000C7A RID: 3194
			private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x04000C7B RID: 3195
			private static readonly IntPtr NativeFieldInfoPtr___9__15_1;

			// Token: 0x04000C7C RID: 3196
			private static readonly IntPtr NativeFieldInfoPtr___9__20_0;

			// Token: 0x04000C7D RID: 3197
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000C7E RID: 3198
			private static readonly IntPtr NativeMethodInfoPtr__get_HasClearableState_b__12_0_Internal_Boolean_List_1_EntityID_0;

			// Token: 0x04000C7F RID: 3199
			private static readonly IntPtr NativeMethodInfoPtr__get_satisfied_b__15_0_Internal_Boolean_List_1_EntityID_0;

			// Token: 0x04000C80 RID: 3200
			private static readonly IntPtr NativeMethodInfoPtr__get_satisfied_b__15_1_Internal_Boolean_List_1_EntityID_0;

			// Token: 0x04000C81 RID: 3201
			private static readonly IntPtr NativeMethodInfoPtr__getResponse_b__20_0_Internal_IEnumerable_1_EntityID_List_1_EntityID_0;
		}

		// Token: 0x020001A5 RID: 421
		[ObfuscatedName("tc.selection.EntityGroupingTargetNode+<>c__DisplayClass16_0")]
		public sealed class __c__DisplayClass16_0 : Object
		{
			// Token: 0x0600149F RID: 5279 RVA: 0x000509E4 File Offset: 0x0004EBE4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_0()
			{
				Il2CppClassPointerStore<EntityGroupingTargetNode.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityGroupingTargetNode>.NativeClassPtr, "<>c__DisplayClass16_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityGroupingTargetNode.__c__DisplayClass16_0>.NativeClassPtr);
				EntityGroupingTargetNode.__c__DisplayClass16_0.NativeFieldInfoPtr_grouping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityGroupingTargetNode.__c__DisplayClass16_0>.NativeClassPtr, "grouping");
				EntityGroupingTargetNode.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityGroupingTargetNode.__c__DisplayClass16_0>.NativeClassPtr, 100663609);
				EntityGroupingTargetNode.__c__DisplayClass16_0.NativeMethodInfoPtr__Select_b__0_Internal_Boolean_Grouping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityGroupingTargetNode.__c__DisplayClass16_0>.NativeClassPtr, 100663610);
			}

			// Token: 0x060014A0 RID: 5280 RVA: 0x00050A4C File Offset: 0x0004EC4C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityGroupingTargetNode.__c__DisplayClass16_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityGroupingTargetNode.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060014A1 RID: 5281 RVA: 0x00050A88 File Offset: 0x0004EC88
			[CallerCount(0)]
			public unsafe bool _Select_b__0(EntityGroupingTargetInformation.Grouping group)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityGroupingTargetNode.__c__DisplayClass16_0.NativeMethodInfoPtr__Select_b__0_Internal_Boolean_Grouping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060014A2 RID: 5282 RVA: 0x0000BAC3 File Offset: 0x00009CC3
			public __c__DisplayClass16_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005E1 RID: 1505
			// (get) Token: 0x060014A3 RID: 5283 RVA: 0x00050AD8 File Offset: 0x0004ECD8
			// (set) Token: 0x060014A4 RID: 5284 RVA: 0x0000BACC File Offset: 0x00009CCC
			public unsafe EntityGroupingTargetInformation.Grouping grouping
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityGroupingTargetNode.__c__DisplayClass16_0.NativeFieldInfoPtr_grouping);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityGroupingTargetInformation.Grouping>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityGroupingTargetNode.__c__DisplayClass16_0.NativeFieldInfoPtr_grouping), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C82 RID: 3202
			private static readonly IntPtr NativeFieldInfoPtr_grouping;

			// Token: 0x04000C83 RID: 3203
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000C84 RID: 3204
			private static readonly IntPtr NativeMethodInfoPtr__Select_b__0_Internal_Boolean_Grouping_0;
		}

		// Token: 0x020001A6 RID: 422
		[ObfuscatedName("tc.selection.EntityGroupingTargetNode+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Object
		{
			// Token: 0x060014A5 RID: 5285 RVA: 0x00050B08 File Offset: 0x0004ED08
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<EntityGroupingTargetNode.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityGroupingTargetNode>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityGroupingTargetNode.__c__DisplayClass17_0>.NativeClassPtr);
				EntityGroupingTargetNode.__c__DisplayClass17_0.NativeFieldInfoPtr_grouping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityGroupingTargetNode.__c__DisplayClass17_0>.NativeClassPtr, "grouping");
				EntityGroupingTargetNode.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityGroupingTargetNode.__c__DisplayClass17_0>.NativeClassPtr, 100663611);
				EntityGroupingTargetNode.__c__DisplayClass17_0.NativeMethodInfoPtr__Unselect_b__0_Internal_Boolean_Grouping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityGroupingTargetNode.__c__DisplayClass17_0>.NativeClassPtr, 100663612);
			}

			// Token: 0x060014A6 RID: 5286 RVA: 0x00050B70 File Offset: 0x0004ED70
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityGroupingTargetNode.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityGroupingTargetNode.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060014A7 RID: 5287 RVA: 0x00050BAC File Offset: 0x0004EDAC
			[CallerCount(0)]
			public unsafe bool _Unselect_b__0(EntityGroupingTargetInformation.Grouping group)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityGroupingTargetNode.__c__DisplayClass17_0.NativeMethodInfoPtr__Unselect_b__0_Internal_Boolean_Grouping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060014A8 RID: 5288 RVA: 0x0000BAEB File Offset: 0x00009CEB
			public __c__DisplayClass17_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005E2 RID: 1506
			// (get) Token: 0x060014A9 RID: 5289 RVA: 0x00050BFC File Offset: 0x0004EDFC
			// (set) Token: 0x060014AA RID: 5290 RVA: 0x0000BAF4 File Offset: 0x00009CF4
			public unsafe EntityGroupingTargetInformation.Grouping grouping
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityGroupingTargetNode.__c__DisplayClass17_0.NativeFieldInfoPtr_grouping);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityGroupingTargetInformation.Grouping>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityGroupingTargetNode.__c__DisplayClass17_0.NativeFieldInfoPtr_grouping), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C85 RID: 3205
			private static readonly IntPtr NativeFieldInfoPtr_grouping;

			// Token: 0x04000C86 RID: 3206
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000C87 RID: 3207
			private static readonly IntPtr NativeMethodInfoPtr__Unselect_b__0_Internal_Boolean_Grouping_0;
		}

		// Token: 0x020001A7 RID: 423
		[ObfuscatedName("tc.selection.EntityGroupingTargetNode+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Object
		{
			// Token: 0x060014AB RID: 5291 RVA: 0x00050C2C File Offset: 0x0004EE2C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<EntityGroupingTargetNode.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityGroupingTargetNode>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityGroupingTargetNode.__c__DisplayClass18_0>.NativeClassPtr);
				EntityGroupingTargetNode.__c__DisplayClass18_0.NativeFieldInfoPtr_grouping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityGroupingTargetNode.__c__DisplayClass18_0>.NativeClassPtr, "grouping");
				EntityGroupingTargetNode.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityGroupingTargetNode.__c__DisplayClass18_0>.NativeClassPtr, 100663613);
				EntityGroupingTargetNode.__c__DisplayClass18_0.NativeMethodInfoPtr__Select_b__0_Internal_Boolean_Grouping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityGroupingTargetNode.__c__DisplayClass18_0>.NativeClassPtr, 100663614);
			}

			// Token: 0x060014AC RID: 5292 RVA: 0x00050C94 File Offset: 0x0004EE94
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityGroupingTargetNode.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityGroupingTargetNode.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060014AD RID: 5293 RVA: 0x00050CD0 File Offset: 0x0004EED0
			[CallerCount(0)]
			public unsafe bool _Select_b__0(EntityGroupingTargetInformation.Grouping group)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityGroupingTargetNode.__c__DisplayClass18_0.NativeMethodInfoPtr__Select_b__0_Internal_Boolean_Grouping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060014AE RID: 5294 RVA: 0x0000BB13 File Offset: 0x00009D13
			public __c__DisplayClass18_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005E3 RID: 1507
			// (get) Token: 0x060014AF RID: 5295 RVA: 0x00050D20 File Offset: 0x0004EF20
			// (set) Token: 0x060014B0 RID: 5296 RVA: 0x0000BB1C File Offset: 0x00009D1C
			public unsafe EntityGroupingTargetInformation.Grouping grouping
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityGroupingTargetNode.__c__DisplayClass18_0.NativeFieldInfoPtr_grouping);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityGroupingTargetInformation.Grouping>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityGroupingTargetNode.__c__DisplayClass18_0.NativeFieldInfoPtr_grouping), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C88 RID: 3208
			private static readonly IntPtr NativeFieldInfoPtr_grouping;

			// Token: 0x04000C89 RID: 3209
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000C8A RID: 3210
			private static readonly IntPtr NativeMethodInfoPtr__Select_b__0_Internal_Boolean_Grouping_0;
		}

		// Token: 0x020001A8 RID: 424
		[ObfuscatedName("tc.selection.EntityGroupingTargetNode+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : Object
		{
			// Token: 0x060014B1 RID: 5297 RVA: 0x00050D50 File Offset: 0x0004EF50
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<EntityGroupingTargetNode.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityGroupingTargetNode>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityGroupingTargetNode.__c__DisplayClass19_0>.NativeClassPtr);
				EntityGroupingTargetNode.__c__DisplayClass19_0.NativeFieldInfoPtr_grouping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityGroupingTargetNode.__c__DisplayClass19_0>.NativeClassPtr, "grouping");
				EntityGroupingTargetNode.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityGroupingTargetNode.__c__DisplayClass19_0>.NativeClassPtr, 100663615);
				EntityGroupingTargetNode.__c__DisplayClass19_0.NativeMethodInfoPtr__Unselect_b__0_Internal_Boolean_Grouping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityGroupingTargetNode.__c__DisplayClass19_0>.NativeClassPtr, 100663616);
			}

			// Token: 0x060014B2 RID: 5298 RVA: 0x00050DB8 File Offset: 0x0004EFB8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityGroupingTargetNode.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityGroupingTargetNode.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060014B3 RID: 5299 RVA: 0x00050DF4 File Offset: 0x0004EFF4
			[CallerCount(0)]
			public unsafe bool _Unselect_b__0(EntityGroupingTargetInformation.Grouping group)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityGroupingTargetNode.__c__DisplayClass19_0.NativeMethodInfoPtr__Unselect_b__0_Internal_Boolean_Grouping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060014B4 RID: 5300 RVA: 0x0000BB3B File Offset: 0x00009D3B
			public __c__DisplayClass19_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005E4 RID: 1508
			// (get) Token: 0x060014B5 RID: 5301 RVA: 0x00050E44 File Offset: 0x0004F044
			// (set) Token: 0x060014B6 RID: 5302 RVA: 0x0000BB44 File Offset: 0x00009D44
			public unsafe EntityGroupingTargetInformation.Grouping grouping
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityGroupingTargetNode.__c__DisplayClass19_0.NativeFieldInfoPtr_grouping);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityGroupingTargetInformation.Grouping>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityGroupingTargetNode.__c__DisplayClass19_0.NativeFieldInfoPtr_grouping), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C8B RID: 3211
			private static readonly IntPtr NativeFieldInfoPtr_grouping;

			// Token: 0x04000C8C RID: 3212
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000C8D RID: 3213
			private static readonly IntPtr NativeMethodInfoPtr__Unselect_b__0_Internal_Boolean_Grouping_0;
		}
	}
}
