using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.match.selection
{
	// Token: 0x02000140 RID: 320
	public class ISelectionRoot : Il2CppObjectBase
	{
		// Token: 0x060011C2 RID: 4546 RVA: 0x0005A8D0 File Offset: 0x00058AD0
		// Note: this type is marked as 'beforefieldinit'.
		static ISelectionRoot()
		{
			Il2CppClassPointerStore<ISelectionRoot>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection", "ISelectionRoot");
			ISelectionRoot.NativeMethodInfoPtr_get_Current_Public_Abstract_Virtual_New_get_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectionRoot>.NativeClassPtr, 100665903);
			ISelectionRoot.NativeMethodInfoPtr_Advance_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectionRoot>.NativeClassPtr, 100665904);
			ISelectionRoot.NativeMethodInfoPtr_Cancel_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectionRoot>.NativeClassPtr, 100665905);
			ISelectionRoot.NativeMethodInfoPtr_add_OnChoiceEntered_Public_Abstract_Virtual_New_add_Void_Action_1_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectionRoot>.NativeClassPtr, 100665906);
			ISelectionRoot.NativeMethodInfoPtr_remove_OnChoiceEntered_Public_Abstract_Virtual_New_rem_Void_Action_1_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectionRoot>.NativeClassPtr, 100665907);
			ISelectionRoot.NativeMethodInfoPtr_add_OnSelectionSent_Public_Abstract_Virtual_New_add_Void_Action_1_ISelectionRoot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectionRoot>.NativeClassPtr, 100665908);
			ISelectionRoot.NativeMethodInfoPtr_remove_OnSelectionSent_Public_Abstract_Virtual_New_rem_Void_Action_1_ISelectionRoot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectionRoot>.NativeClassPtr, 100665909);
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x060011C3 RID: 4547 RVA: 0x0005A984 File Offset: 0x00058B84
		public unsafe virtual ISelectionNode Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectionRoot.NativeMethodInfoPtr_get_Current_Public_Abstract_Virtual_New_get_ISelectionNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
			}
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x0005A9D0 File Offset: 0x00058BD0
		[CallerCount(0)]
		public unsafe virtual void Advance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectionRoot.NativeMethodInfoPtr_Advance_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x0005AA0C File Offset: 0x00058C0C
		[CallerCount(0)]
		public unsafe virtual void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectionRoot.NativeMethodInfoPtr_Cancel_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x0005AA48 File Offset: 0x00058C48
		[CallerCount(0)]
		public unsafe virtual void add_OnChoiceEntered(Action<ISelectionNode> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectionRoot.NativeMethodInfoPtr_add_OnChoiceEntered_Public_Abstract_Virtual_New_add_Void_Action_1_ISelectionNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x0005AA98 File Offset: 0x00058C98
		[CallerCount(0)]
		public unsafe virtual void remove_OnChoiceEntered(Action<ISelectionNode> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectionRoot.NativeMethodInfoPtr_remove_OnChoiceEntered_Public_Abstract_Virtual_New_rem_Void_Action_1_ISelectionNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x0005AAE8 File Offset: 0x00058CE8
		[CallerCount(0)]
		public unsafe virtual void add_OnSelectionSent(Action<ISelectionRoot> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectionRoot.NativeMethodInfoPtr_add_OnSelectionSent_Public_Abstract_Virtual_New_add_Void_Action_1_ISelectionRoot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x0005AB38 File Offset: 0x00058D38
		[CallerCount(0)]
		public unsafe virtual void remove_OnSelectionSent(Action<ISelectionRoot> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectionRoot.NativeMethodInfoPtr_remove_OnSelectionSent_Public_Abstract_Virtual_New_rem_Void_Action_1_ISelectionRoot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x000081CA File Offset: 0x000063CA
		public ISelectionRoot(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C9E RID: 3230
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Abstract_Virtual_New_get_ISelectionNode_0;

		// Token: 0x04000C9F RID: 3231
		private static readonly IntPtr NativeMethodInfoPtr_Advance_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000CA0 RID: 3232
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000CA1 RID: 3233
		private static readonly IntPtr NativeMethodInfoPtr_add_OnChoiceEntered_Public_Abstract_Virtual_New_add_Void_Action_1_ISelectionNode_0;

		// Token: 0x04000CA2 RID: 3234
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnChoiceEntered_Public_Abstract_Virtual_New_rem_Void_Action_1_ISelectionNode_0;

		// Token: 0x04000CA3 RID: 3235
		private static readonly IntPtr NativeMethodInfoPtr_add_OnSelectionSent_Public_Abstract_Virtual_New_add_Void_Action_1_ISelectionRoot_0;

		// Token: 0x04000CA4 RID: 3236
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnSelectionSent_Public_Abstract_Virtual_New_rem_Void_Action_1_ISelectionRoot_0;
	}
}
