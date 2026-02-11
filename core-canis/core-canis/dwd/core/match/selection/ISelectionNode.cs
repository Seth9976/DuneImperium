using System;
using Canis.attributes;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.match.selection
{
	// Token: 0x0200013E RID: 318
	public class ISelectionNode : Il2CppObjectBase
	{
		// Token: 0x060011AD RID: 4525 RVA: 0x0005A160 File Offset: 0x00058360
		// Note: this type is marked as 'beforefieldinit'.
		static ISelectionNode()
		{
			Il2CppClassPointerStore<ISelectionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection", "ISelectionNode");
			ISelectionNode.NativeMethodInfoPtr_get_Root_Public_Abstract_Virtual_New_get_ISelectionRoot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectionNode>.NativeClassPtr, 100665886);
			ISelectionNode.NativeMethodInfoPtr_get_Parent_Public_Abstract_Virtual_New_get_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectionNode>.NativeClassPtr, 100665887);
			ISelectionNode.NativeMethodInfoPtr_get_Children_Public_Abstract_Virtual_New_get_IEnumerable_1_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectionNode>.NativeClassPtr, 100665888);
			ISelectionNode.NativeMethodInfoPtr_get_MayAdvance_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectionNode>.NativeClassPtr, 100665889);
			ISelectionNode.NativeMethodInfoPtr_Enter_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectionNode>.NativeClassPtr, 100665890);
			ISelectionNode.NativeMethodInfoPtr_get_MayCancel_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectionNode>.NativeClassPtr, 100665891);
			ISelectionNode.NativeMethodInfoPtr_get_HasClearableState_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectionNode>.NativeClassPtr, 100665892);
			ISelectionNode.NativeMethodInfoPtr_ClearState_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectionNode>.NativeClassPtr, 100665893);
			ISelectionNode.NativeMethodInfoPtr_NodeToAdvanceTo_Public_Abstract_Virtual_New_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectionNode>.NativeClassPtr, 100665894);
			ISelectionNode.NativeMethodInfoPtr_get_Kind_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectionNode>.NativeClassPtr, 100665895);
			ISelectionNode.NativeMethodInfoPtr_get_Prompt_Public_Abstract_Virtual_New_get_LocalizableTextVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectionNode>.NativeClassPtr, 100665896);
			ISelectionNode.NativeMethodInfoPtr_get_Attributes_Public_Abstract_Virtual_New_get_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectionNode>.NativeClassPtr, 100665897);
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x060011AE RID: 4526 RVA: 0x0005A278 File Offset: 0x00058478
		public unsafe virtual ISelectionRoot Root
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectionNode.NativeMethodInfoPtr_get_Root_Public_Abstract_Virtual_New_get_ISelectionRoot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionRoot>(intPtr3) : null;
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x060011AF RID: 4527 RVA: 0x0005A2C4 File Offset: 0x000584C4
		public unsafe virtual ISelectionNode Parent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectionNode.NativeMethodInfoPtr_get_Parent_Public_Abstract_Virtual_New_get_ISelectionNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x060011B0 RID: 4528 RVA: 0x0005A310 File Offset: 0x00058510
		public unsafe virtual IEnumerable<ISelectionNode> Children
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectionNode.NativeMethodInfoPtr_get_Children_Public_Abstract_Virtual_New_get_IEnumerable_1_ISelectionNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ISelectionNode>>(intPtr3) : null;
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x060011B1 RID: 4529 RVA: 0x0005A35C File Offset: 0x0005855C
		public unsafe virtual bool MayAdvance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectionNode.NativeMethodInfoPtr_get_MayAdvance_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x0005A3A4 File Offset: 0x000585A4
		[CallerCount(0)]
		public unsafe virtual void Enter(bool fromCancel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromCancel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectionNode.NativeMethodInfoPtr_Enter_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x060011B3 RID: 4531 RVA: 0x0005A3F0 File Offset: 0x000585F0
		public unsafe virtual bool MayCancel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectionNode.NativeMethodInfoPtr_get_MayCancel_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x060011B4 RID: 4532 RVA: 0x0005A438 File Offset: 0x00058638
		public unsafe virtual bool HasClearableState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectionNode.NativeMethodInfoPtr_get_HasClearableState_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x0005A480 File Offset: 0x00058680
		[CallerCount(0)]
		public unsafe virtual void ClearState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectionNode.NativeMethodInfoPtr_ClearState_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x0005A4BC File Offset: 0x000586BC
		[CallerCount(0)]
		public unsafe virtual ISelectionNode NodeToAdvanceTo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectionNode.NativeMethodInfoPtr_NodeToAdvanceTo_Public_Abstract_Virtual_New_ISelectionNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x060011B7 RID: 4535 RVA: 0x0005A508 File Offset: 0x00058708
		public unsafe virtual string Kind
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectionNode.NativeMethodInfoPtr_get_Kind_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x060011B8 RID: 4536 RVA: 0x0005A54C File Offset: 0x0005874C
		public unsafe virtual LocalizableTextVariables Prompt
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectionNode.NativeMethodInfoPtr_get_Prompt_Public_Abstract_Virtual_New_get_LocalizableTextVariables_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr3) : null;
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x060011B9 RID: 4537 RVA: 0x0005A598 File Offset: 0x00058798
		public unsafe virtual ReadOnlyAttributes Attributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectionNode.NativeMethodInfoPtr_get_Attributes_Public_Abstract_Virtual_New_get_ReadOnlyAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x000081B8 File Offset: 0x000063B8
		public ISelectionNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C8D RID: 3213
		private static readonly IntPtr NativeMethodInfoPtr_get_Root_Public_Abstract_Virtual_New_get_ISelectionRoot_0;

		// Token: 0x04000C8E RID: 3214
		private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Public_Abstract_Virtual_New_get_ISelectionNode_0;

		// Token: 0x04000C8F RID: 3215
		private static readonly IntPtr NativeMethodInfoPtr_get_Children_Public_Abstract_Virtual_New_get_IEnumerable_1_ISelectionNode_0;

		// Token: 0x04000C90 RID: 3216
		private static readonly IntPtr NativeMethodInfoPtr_get_MayAdvance_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000C91 RID: 3217
		private static readonly IntPtr NativeMethodInfoPtr_Enter_Public_Abstract_Virtual_New_Void_Boolean_0;

		// Token: 0x04000C92 RID: 3218
		private static readonly IntPtr NativeMethodInfoPtr_get_MayCancel_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000C93 RID: 3219
		private static readonly IntPtr NativeMethodInfoPtr_get_HasClearableState_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000C94 RID: 3220
		private static readonly IntPtr NativeMethodInfoPtr_ClearState_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000C95 RID: 3221
		private static readonly IntPtr NativeMethodInfoPtr_NodeToAdvanceTo_Public_Abstract_Virtual_New_ISelectionNode_0;

		// Token: 0x04000C96 RID: 3222
		private static readonly IntPtr NativeMethodInfoPtr_get_Kind_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000C97 RID: 3223
		private static readonly IntPtr NativeMethodInfoPtr_get_Prompt_Public_Abstract_Virtual_New_get_LocalizableTextVariables_0;

		// Token: 0x04000C98 RID: 3224
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_Abstract_Virtual_New_get_ReadOnlyAttributes_0;
	}
}
