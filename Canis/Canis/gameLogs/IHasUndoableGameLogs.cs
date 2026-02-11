using System;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.gameLogs
{
	// Token: 0x020000A5 RID: 165
	public class IHasUndoableGameLogs : Il2CppObjectBase
	{
		// Token: 0x060007F6 RID: 2038 RVA: 0x000051A9 File Offset: 0x000033A9
		// Note: this type is marked as 'beforefieldinit'.
		static IHasUndoableGameLogs()
		{
			Il2CppClassPointerStore<IHasUndoableGameLogs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.gameLogs", "IHasUndoableGameLogs");
			IHasUndoableGameLogs.NativeMethodInfoPtr_get_GameLogUndoNode_Public_Abstract_Virtual_New_get_UndoNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasUndoableGameLogs>.NativeClassPtr, 100664927);
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x000399F0 File Offset: 0x00037BF0
		public unsafe virtual UndoNode GameLogUndoNode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasUndoableGameLogs.NativeMethodInfoPtr_get_GameLogUndoNode_Public_Abstract_Virtual_New_get_UndoNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr3) : null;
			}
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x000051D8 File Offset: 0x000033D8
		public IHasUndoableGameLogs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000577 RID: 1399
		private static readonly IntPtr NativeMethodInfoPtr_get_GameLogUndoNode_Public_Abstract_Virtual_New_get_UndoNode_0;
	}
}
