using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions.staged
{
	// Token: 0x0200020A RID: 522
	public class IStagedAction : Il2CppObjectBase
	{
		// Token: 0x06001617 RID: 5655 RVA: 0x000720FC File Offset: 0x000702FC
		// Note: this type is marked as 'beforefieldinit'.
		static IStagedAction()
		{
			Il2CppClassPointerStore<IStagedAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.staged", "IStagedAction");
			IStagedAction.NativeMethodInfoPtr_get_Committed_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedAction>.NativeClassPtr, 100668316);
			IStagedAction.NativeMethodInfoPtr_set_Committed_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedAction>.NativeClassPtr, 100668317);
			IStagedAction.NativeMethodInfoPtr_Stage_Public_Abstract_Virtual_New_IEnumerable_1_Staging_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedAction>.NativeClassPtr, 100668318);
			IStagedAction.NativeMethodInfoPtr_Rollback_Public_Abstract_Virtual_New_IEnumerable_1_Staging_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedAction>.NativeClassPtr, 100668319);
			IStagedAction.NativeMethodInfoPtr_Commit_Public_Abstract_Virtual_New_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedAction>.NativeClassPtr, 100668320);
			IStagedAction.NativeMethodInfoPtr_MakeSerializedStagedAction_Public_Abstract_Virtual_New_SerializedStagedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStagedAction>.NativeClassPtr, 100668321);
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06001618 RID: 5656 RVA: 0x0007219C File Offset: 0x0007039C
		// (set) Token: 0x06001619 RID: 5657 RVA: 0x000721E4 File Offset: 0x000703E4
		public unsafe virtual bool Committed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStagedAction.NativeMethodInfoPtr_get_Committed_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStagedAction.NativeMethodInfoPtr_set_Committed_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x00072230 File Offset: 0x00070430
		[CallerCount(0)]
		public unsafe virtual IEnumerable<Staging> Stage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStagedAction.NativeMethodInfoPtr_Stage_Public_Abstract_Virtual_New_IEnumerable_1_Staging_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Staging>>(intPtr3) : null;
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x0007227C File Offset: 0x0007047C
		[CallerCount(0)]
		public unsafe virtual IEnumerable<Staging> Rollback()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStagedAction.NativeMethodInfoPtr_Rollback_Public_Abstract_Virtual_New_IEnumerable_1_Staging_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Staging>>(intPtr3) : null;
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x000722C8 File Offset: 0x000704C8
		[CallerCount(0)]
		public unsafe virtual IEnumerable<Action> Commit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStagedAction.NativeMethodInfoPtr_Commit_Public_Abstract_Virtual_New_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x00072314 File Offset: 0x00070514
		[CallerCount(0)]
		public unsafe virtual SerializedStagedAction MakeSerializedStagedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStagedAction.NativeMethodInfoPtr_MakeSerializedStagedAction_Public_Abstract_Virtual_New_SerializedStagedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedStagedAction>(intPtr3) : null;
			}
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x0000AB08 File Offset: 0x00008D08
		public IStagedAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E38 RID: 3640
		private static readonly IntPtr NativeMethodInfoPtr_get_Committed_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000E39 RID: 3641
		private static readonly IntPtr NativeMethodInfoPtr_set_Committed_Public_Abstract_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04000E3A RID: 3642
		private static readonly IntPtr NativeMethodInfoPtr_Stage_Public_Abstract_Virtual_New_IEnumerable_1_Staging_0;

		// Token: 0x04000E3B RID: 3643
		private static readonly IntPtr NativeMethodInfoPtr_Rollback_Public_Abstract_Virtual_New_IEnumerable_1_Staging_0;

		// Token: 0x04000E3C RID: 3644
		private static readonly IntPtr NativeMethodInfoPtr_Commit_Public_Abstract_Virtual_New_IEnumerable_1_Action_0;

		// Token: 0x04000E3D RID: 3645
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedStagedAction_Public_Abstract_Virtual_New_SerializedStagedAction_Match_0;
	}
}
