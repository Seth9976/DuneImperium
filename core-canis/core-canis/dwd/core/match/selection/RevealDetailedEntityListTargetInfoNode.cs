using System;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Networking.selection.targetinformation;

namespace dwd.core.match.selection
{
	// Token: 0x02000155 RID: 341
	public class RevealDetailedEntityListTargetInfoNode : EntityListTargetNode
	{
		// Token: 0x060013FA RID: 5114 RVA: 0x00064794 File Offset: 0x00062994
		// Note: this type is marked as 'beforefieldinit'.
		static RevealDetailedEntityListTargetInfoNode()
		{
			Il2CppClassPointerStore<RevealDetailedEntityListTargetInfoNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection", "RevealDetailedEntityListTargetInfoNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RevealDetailedEntityListTargetInfoNode>.NativeClassPtr);
			RevealDetailedEntityListTargetInfoNode.NativeFieldInfoPtr_targetInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealDetailedEntityListTargetInfoNode>.NativeClassPtr, "targetInfo");
			RevealDetailedEntityListTargetInfoNode.NativeFieldInfoPtr__revealedEntitiesDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealDetailedEntityListTargetInfoNode>.NativeClassPtr, "_revealedEntitiesDict");
			RevealDetailedEntityListTargetInfoNode.NativeMethodInfoPtr_CanCancelReveal_Private_Static_Boolean_RevealDetailedEntityListTargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealDetailedEntityListTargetInfoNode>.NativeClassPtr, 100666330);
			RevealDetailedEntityListTargetInfoNode.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_RevealDetailedEntityListTargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealDetailedEntityListTargetInfoNode>.NativeClassPtr, 100666331);
			RevealDetailedEntityListTargetInfoNode.NativeMethodInfoPtr_get_RevealedEntities_Public_Virtual_Final_New_get_IList_1_SerializedEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealDetailedEntityListTargetInfoNode>.NativeClassPtr, 100666332);
			RevealDetailedEntityListTargetInfoNode.NativeMethodInfoPtr_get_ValidTargetCounts_Public_Virtual_Final_New_get_IDictionary_2_EntityID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealDetailedEntityListTargetInfoNode>.NativeClassPtr, 100666333);
			RevealDetailedEntityListTargetInfoNode.NativeMethodInfoPtr_get_RevealedEntitiesByID_Public_Virtual_Final_New_get_IDictionary_2_EntityID_SerializedEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealDetailedEntityListTargetInfoNode>.NativeClassPtr, 100666334);
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x00064850 File Offset: 0x00062A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874505, XrefRangeEnd = 874512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanCancelReveal(RevealDetailedEntityListTargetInformation info)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealDetailedEntityListTargetInfoNode.NativeMethodInfoPtr_CanCancelReveal_Private_Static_Boolean_RevealDetailedEntityListTargetInformation_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x00064894 File Offset: 0x00062A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874512, XrefRangeEnd = 874527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RevealDetailedEntityListTargetInfoNode(ISelectionNodeFactory factory, RevealDetailedEntityListTargetInformation info, bool mayCancel, ISelectionRoot root, ISelectionNode parent, IEnumerable<TargetInformation> subsequent, string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RevealDetailedEntityListTargetInfoNode>.NativeClassPtr))
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
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealDetailedEntityListTargetInfoNode.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_RevealDetailedEntityListTargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x060013FD RID: 5117 RVA: 0x0006494C File Offset: 0x00062B4C
		public unsafe virtual IList<SerializedEntity> RevealedEntities
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealDetailedEntityListTargetInfoNode.NativeMethodInfoPtr_get_RevealedEntities_Public_Virtual_Final_New_get_IList_1_SerializedEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<SerializedEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x060013FE RID: 5118 RVA: 0x0006498C File Offset: 0x00062B8C
		public unsafe virtual IDictionary<EntityID, int> ValidTargetCounts
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealDetailedEntityListTargetInfoNode.NativeMethodInfoPtr_get_ValidTargetCounts_Public_Virtual_Final_New_get_IDictionary_2_EntityID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<EntityID, int>>(intPtr3) : null;
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x060013FF RID: 5119 RVA: 0x000649CC File Offset: 0x00062BCC
		public unsafe virtual IDictionary<EntityID, SerializedEntity> RevealedEntitiesByID
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874527, XrefRangeEnd = 874539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealDetailedEntityListTargetInfoNode.NativeMethodInfoPtr_get_RevealedEntitiesByID_Public_Virtual_Final_New_get_IDictionary_2_EntityID_SerializedEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<EntityID, SerializedEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x00008CFD File Offset: 0x00006EFD
		public RevealDetailedEntityListTargetInfoNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06001401 RID: 5121 RVA: 0x00064A0C File Offset: 0x00062C0C
		// (set) Token: 0x06001402 RID: 5122 RVA: 0x00008D06 File Offset: 0x00006F06
		public new unsafe RevealDetailedEntityListTargetInformation targetInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealDetailedEntityListTargetInfoNode.NativeFieldInfoPtr_targetInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RevealDetailedEntityListTargetInformation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealDetailedEntityListTargetInfoNode.NativeFieldInfoPtr_targetInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06001403 RID: 5123 RVA: 0x00064A3C File Offset: 0x00062C3C
		// (set) Token: 0x06001404 RID: 5124 RVA: 0x00008D25 File Offset: 0x00006F25
		public unsafe IDictionary<EntityID, SerializedEntity> _revealedEntitiesDict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealDetailedEntityListTargetInfoNode.NativeFieldInfoPtr__revealedEntitiesDict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary<EntityID, SerializedEntity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealDetailedEntityListTargetInfoNode.NativeFieldInfoPtr__revealedEntitiesDict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E55 RID: 3669
		private static readonly IntPtr NativeFieldInfoPtr_targetInfo;

		// Token: 0x04000E56 RID: 3670
		private static readonly IntPtr NativeFieldInfoPtr__revealedEntitiesDict;

		// Token: 0x04000E57 RID: 3671
		private static readonly IntPtr NativeMethodInfoPtr_CanCancelReveal_Private_Static_Boolean_RevealDetailedEntityListTargetInformation_0;

		// Token: 0x04000E58 RID: 3672
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_RevealDetailedEntityListTargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_String_0;

		// Token: 0x04000E59 RID: 3673
		private static readonly IntPtr NativeMethodInfoPtr_get_RevealedEntities_Public_Virtual_Final_New_get_IList_1_SerializedEntity_0;

		// Token: 0x04000E5A RID: 3674
		private static readonly IntPtr NativeMethodInfoPtr_get_ValidTargetCounts_Public_Virtual_Final_New_get_IDictionary_2_EntityID_Int32_0;

		// Token: 0x04000E5B RID: 3675
		private static readonly IntPtr NativeMethodInfoPtr_get_RevealedEntitiesByID_Public_Virtual_Final_New_get_IDictionary_2_EntityID_SerializedEntity_0;
	}
}
