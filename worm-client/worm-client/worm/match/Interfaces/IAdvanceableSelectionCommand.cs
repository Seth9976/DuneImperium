using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace worm.match.Interfaces
{
	// Token: 0x020000ED RID: 237
	public class IAdvanceableSelectionCommand : Il2CppObjectBase
	{
		// Token: 0x06000A8D RID: 2701 RVA: 0x00007831 File Offset: 0x00005A31
		// Note: this type is marked as 'beforefieldinit'.
		static IAdvanceableSelectionCommand()
		{
			Il2CppClassPointerStore<IAdvanceableSelectionCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.Interfaces", "IAdvanceableSelectionCommand");
			IAdvanceableSelectionCommand.NativeMethodInfoPtr_Advance_Public_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAdvanceableSelectionCommand>.NativeClassPtr, 100664745);
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x00038390 File Offset: 0x00036590
		[CallerCount(0)]
		public unsafe virtual IEnumerator Advance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAdvanceableSelectionCommand.NativeMethodInfoPtr_Advance_Public_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x00007860 File Offset: 0x00005A60
		public IAdvanceableSelectionCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000619 RID: 1561
		private static readonly IntPtr NativeMethodInfoPtr_Advance_Public_Abstract_Virtual_New_IEnumerator_0;
	}
}
