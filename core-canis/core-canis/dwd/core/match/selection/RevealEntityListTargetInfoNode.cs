using System;
using Canis.attributes;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Networking.selection.targetinformation;

namespace dwd.core.match.selection
{
	// Token: 0x02000156 RID: 342
	public class RevealEntityListTargetInfoNode : EntityListTargetNode
	{
		// Token: 0x06001405 RID: 5125 RVA: 0x00064A6C File Offset: 0x00062C6C
		// Note: this type is marked as 'beforefieldinit'.
		static RevealEntityListTargetInfoNode()
		{
			Il2CppClassPointerStore<RevealEntityListTargetInfoNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection", "RevealEntityListTargetInfoNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RevealEntityListTargetInfoNode>.NativeClassPtr);
			RevealEntityListTargetInfoNode.NativeFieldInfoPtr_targetInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealEntityListTargetInfoNode>.NativeClassPtr, "targetInfo");
			RevealEntityListTargetInfoNode.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_RevealEntityListTargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealEntityListTargetInfoNode>.NativeClassPtr, 100666335);
			RevealEntityListTargetInfoNode.NativeMethodInfoPtr_get_RevealedEntities_Public_Virtual_Final_New_get_IDictionary_2_EntityID_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealEntityListTargetInfoNode>.NativeClassPtr, 100666336);
			RevealEntityListTargetInfoNode.NativeMethodInfoPtr_get_AllTargets_Public_Virtual_Final_New_get_IList_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealEntityListTargetInfoNode>.NativeClassPtr, 100666337);
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x00064AEC File Offset: 0x00062CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874539, XrefRangeEnd = 874544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RevealEntityListTargetInfoNode(ISelectionNodeFactory factory, RevealEntityListTargetInformation info, bool mayCancel, ISelectionRoot root, ISelectionNode parent, IEnumerable<TargetInformation> subsequent, string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RevealEntityListTargetInfoNode>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealEntityListTargetInfoNode.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_RevealEntityListTargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06001407 RID: 5127 RVA: 0x00064BA4 File Offset: 0x00062DA4
		public unsafe virtual IDictionary<EntityID, ReadOnlyAttributes> RevealedEntities
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealEntityListTargetInfoNode.NativeMethodInfoPtr_get_RevealedEntities_Public_Virtual_Final_New_get_IDictionary_2_EntityID_ReadOnlyAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<EntityID, ReadOnlyAttributes>>(intPtr3) : null;
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06001408 RID: 5128 RVA: 0x00064BE4 File Offset: 0x00062DE4
		public unsafe virtual IList<EntityID> AllTargets
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealEntityListTargetInfoNode.NativeMethodInfoPtr_get_AllTargets_Public_Virtual_Final_New_get_IList_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x00008D44 File Offset: 0x00006F44
		public RevealEntityListTargetInfoNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x0600140A RID: 5130 RVA: 0x00064C24 File Offset: 0x00062E24
		// (set) Token: 0x0600140B RID: 5131 RVA: 0x00008D4D File Offset: 0x00006F4D
		public new unsafe RevealEntityListTargetInformation targetInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealEntityListTargetInfoNode.NativeFieldInfoPtr_targetInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RevealEntityListTargetInformation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealEntityListTargetInfoNode.NativeFieldInfoPtr_targetInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E5C RID: 3676
		private static readonly IntPtr NativeFieldInfoPtr_targetInfo;

		// Token: 0x04000E5D RID: 3677
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_RevealEntityListTargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_String_0;

		// Token: 0x04000E5E RID: 3678
		private static readonly IntPtr NativeMethodInfoPtr_get_RevealedEntities_Public_Virtual_Final_New_get_IDictionary_2_EntityID_ReadOnlyAttributes_0;

		// Token: 0x04000E5F RID: 3679
		private static readonly IntPtr NativeMethodInfoPtr_get_AllTargets_Public_Virtual_Final_New_get_IList_1_EntityID_0;
	}
}
