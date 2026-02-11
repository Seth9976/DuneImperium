using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.match.selection
{
	// Token: 0x02000135 RID: 309
	public class IEntityListSelection : Il2CppObjectBase
	{
		// Token: 0x0600117F RID: 4479 RVA: 0x000595F0 File Offset: 0x000577F0
		// Note: this type is marked as 'beforefieldinit'.
		static IEntityListSelection()
		{
			Il2CppClassPointerStore<IEntityListSelection>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection", "IEntityListSelection");
			IEntityListSelection.NativeMethodInfoPtr_get_AvailableSelections_Public_Abstract_Virtual_New_get_IList_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEntityListSelection>.NativeClassPtr, 100665858);
			IEntityListSelection.NativeMethodInfoPtr_get_PreviousSelections_Public_Abstract_Virtual_New_get_IList_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEntityListSelection>.NativeClassPtr, 100665859);
			IEntityListSelection.NativeMethodInfoPtr_get_ForcedSelections_Public_Abstract_Virtual_New_get_IList_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEntityListSelection>.NativeClassPtr, 100665860);
			IEntityListSelection.NativeMethodInfoPtr_Select_Public_Abstract_Virtual_New_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEntityListSelection>.NativeClassPtr, 100665861);
			IEntityListSelection.NativeMethodInfoPtr_Unselect_Public_Abstract_Virtual_New_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEntityListSelection>.NativeClassPtr, 100665862);
			IEntityListSelection.NativeMethodInfoPtr_get_MaxToSelect_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEntityListSelection>.NativeClassPtr, 100665863);
			IEntityListSelection.NativeMethodInfoPtr_get_MinToSelect_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEntityListSelection>.NativeClassPtr, 100665864);
			IEntityListSelection.NativeMethodInfoPtr_PeekNode_Public_Abstract_Virtual_New_ISelectionNode_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEntityListSelection>.NativeClassPtr, 100665865);
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06001180 RID: 4480 RVA: 0x000596B8 File Offset: 0x000578B8
		public unsafe virtual IList<EntityID> AvailableSelections
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEntityListSelection.NativeMethodInfoPtr_get_AvailableSelections_Public_Abstract_Virtual_New_get_IList_1_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06001181 RID: 4481 RVA: 0x00059704 File Offset: 0x00057904
		public unsafe virtual IList<EntityID> PreviousSelections
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEntityListSelection.NativeMethodInfoPtr_get_PreviousSelections_Public_Abstract_Virtual_New_get_IList_1_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06001182 RID: 4482 RVA: 0x00059750 File Offset: 0x00057950
		public unsafe virtual IList<EntityID> ForcedSelections
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEntityListSelection.NativeMethodInfoPtr_get_ForcedSelections_Public_Abstract_Virtual_New_get_IList_1_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x0005979C File Offset: 0x0005799C
		[CallerCount(0)]
		public unsafe virtual void Select(EntityID entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEntityListSelection.NativeMethodInfoPtr_Select_Public_Abstract_Virtual_New_Void_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x000597EC File Offset: 0x000579EC
		[CallerCount(0)]
		public unsafe virtual void Unselect(EntityID entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEntityListSelection.NativeMethodInfoPtr_Unselect_Public_Abstract_Virtual_New_Void_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06001185 RID: 4485 RVA: 0x0005983C File Offset: 0x00057A3C
		public unsafe virtual int MaxToSelect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEntityListSelection.NativeMethodInfoPtr_get_MaxToSelect_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06001186 RID: 4486 RVA: 0x00059884 File Offset: 0x00057A84
		public unsafe virtual int MinToSelect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEntityListSelection.NativeMethodInfoPtr_get_MinToSelect_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x000598CC File Offset: 0x00057ACC
		[CallerCount(0)]
		public unsafe virtual ISelectionNode PeekNode(EntityID entityID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEntityListSelection.NativeMethodInfoPtr_PeekNode_Public_Abstract_Virtual_New_ISelectionNode_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
			}
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x00008109 File Offset: 0x00006309
		public IEntityListSelection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C71 RID: 3185
		private static readonly IntPtr NativeMethodInfoPtr_get_AvailableSelections_Public_Abstract_Virtual_New_get_IList_1_EntityID_0;

		// Token: 0x04000C72 RID: 3186
		private static readonly IntPtr NativeMethodInfoPtr_get_PreviousSelections_Public_Abstract_Virtual_New_get_IList_1_EntityID_0;

		// Token: 0x04000C73 RID: 3187
		private static readonly IntPtr NativeMethodInfoPtr_get_ForcedSelections_Public_Abstract_Virtual_New_get_IList_1_EntityID_0;

		// Token: 0x04000C74 RID: 3188
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Abstract_Virtual_New_Void_EntityID_0;

		// Token: 0x04000C75 RID: 3189
		private static readonly IntPtr NativeMethodInfoPtr_Unselect_Public_Abstract_Virtual_New_Void_EntityID_0;

		// Token: 0x04000C76 RID: 3190
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxToSelect_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000C77 RID: 3191
		private static readonly IntPtr NativeMethodInfoPtr_get_MinToSelect_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000C78 RID: 3192
		private static readonly IntPtr NativeMethodInfoPtr_PeekNode_Public_Abstract_Virtual_New_ISelectionNode_EntityID_0;
	}
}
