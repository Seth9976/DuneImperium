using System;
using Canis.utils.ids;
using dwd.core.session;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Networking.selection.messages;
using Networking.selection.targetinformation;

namespace dwd.core.match.selection
{
	// Token: 0x0200013F RID: 319
	public class ISelectionNodeFactory : Il2CppObjectBase
	{
		// Token: 0x060011BB RID: 4539 RVA: 0x0005A5E4 File Offset: 0x000587E4
		// Note: this type is marked as 'beforefieldinit'.
		static ISelectionNodeFactory()
		{
			Il2CppClassPointerStore<ISelectionNodeFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection", "ISelectionNodeFactory");
			ISelectionNodeFactory.NativeMethodInfoPtr_GetSelection_Public_Abstract_Virtual_New_ISelectionRoot_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectionNodeFactory>.NativeClassPtr, 100665898);
			ISelectionNodeFactory.NativeMethodInfoPtr_GetSelection_Public_Abstract_Virtual_New_TargetInfoNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectionNodeFactory>.NativeClassPtr, 100665899);
			ISelectionNodeFactory.NativeMethodInfoPtr_GetSelection_Public_Abstract_Virtual_New_IActionSelection_Dictionary_2_SelectableAction_Il2CppReferenceArray_1_TargetInformation_ISelectionRoot_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectionNodeFactory>.NativeClassPtr, 100665900);
			ISelectionNodeFactory.NativeMethodInfoPtr_GetSelection_Public_Abstract_Virtual_New_MultipleTargetInformationNode_MultipleTargetInformation_EntityID_ISelectionRoot_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectionNodeFactory>.NativeClassPtr, 100665901);
			ISelectionNodeFactory.NativeMethodInfoPtr_get_SessionWriter_Public_Abstract_Virtual_New_get_IAccountSessionWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectionNodeFactory>.NativeClassPtr, 100665902);
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x0005A670 File Offset: 0x00058870
		[CallerCount(0)]
		public unsafe virtual ISelectionRoot GetSelection(SelectionMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectionNodeFactory.NativeMethodInfoPtr_GetSelection_Public_Abstract_Virtual_New_ISelectionRoot_SelectionMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionRoot>(intPtr3) : null;
			}
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x0005A6CC File Offset: 0x000588CC
		[CallerCount(0)]
		public unsafe virtual TargetInfoNode GetSelection(TargetInformation info, bool mayCancel, ISelectionRoot root, ISelectionNode parent, IEnumerable<TargetInformation> susequent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mayCancel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(susequent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectionNodeFactory.NativeMethodInfoPtr_GetSelection_Public_Abstract_Virtual_New_TargetInfoNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetInfoNode>(intPtr3) : null;
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x0005A770 File Offset: 0x00058970
		[CallerCount(0)]
		public unsafe virtual IActionSelection GetSelection(Dictionary<SelectableAction, Il2CppReferenceArray<TargetInformation>> actions, ISelectionRoot root, ISelectionNode parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(actions);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectionNodeFactory.NativeMethodInfoPtr_GetSelection_Public_Abstract_Virtual_New_IActionSelection_Dictionary_2_SelectableAction_Il2CppReferenceArray_1_TargetInformation_ISelectionRoot_ISelectionNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IActionSelection>(intPtr3) : null;
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x0005A7F0 File Offset: 0x000589F0
		[CallerCount(0)]
		public unsafe virtual MultipleTargetInformationNode GetSelection(MultipleTargetInformation info, EntityID source, ISelectionRoot root, ISelectionNode parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectionNodeFactory.NativeMethodInfoPtr_GetSelection_Public_Abstract_Virtual_New_MultipleTargetInformationNode_MultipleTargetInformation_EntityID_ISelectionRoot_ISelectionNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MultipleTargetInformationNode>(intPtr3) : null;
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x060011C0 RID: 4544 RVA: 0x0005A884 File Offset: 0x00058A84
		public unsafe virtual IAccountSessionWriter SessionWriter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectionNodeFactory.NativeMethodInfoPtr_get_SessionWriter_Public_Abstract_Virtual_New_get_IAccountSessionWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAccountSessionWriter>(intPtr3) : null;
			}
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x000081C1 File Offset: 0x000063C1
		public ISelectionNodeFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C99 RID: 3225
		private static readonly IntPtr NativeMethodInfoPtr_GetSelection_Public_Abstract_Virtual_New_ISelectionRoot_SelectionMessage_0;

		// Token: 0x04000C9A RID: 3226
		private static readonly IntPtr NativeMethodInfoPtr_GetSelection_Public_Abstract_Virtual_New_TargetInfoNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0;

		// Token: 0x04000C9B RID: 3227
		private static readonly IntPtr NativeMethodInfoPtr_GetSelection_Public_Abstract_Virtual_New_IActionSelection_Dictionary_2_SelectableAction_Il2CppReferenceArray_1_TargetInformation_ISelectionRoot_ISelectionNode_0;

		// Token: 0x04000C9C RID: 3228
		private static readonly IntPtr NativeMethodInfoPtr_GetSelection_Public_Abstract_Virtual_New_MultipleTargetInformationNode_MultipleTargetInformation_EntityID_ISelectionRoot_ISelectionNode_0;

		// Token: 0x04000C9D RID: 3229
		private static readonly IntPtr NativeMethodInfoPtr_get_SessionWriter_Public_Abstract_Virtual_New_get_IAccountSessionWriter_0;
	}
}
