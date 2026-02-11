using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.messages
{
	// Token: 0x02000027 RID: 39
	public class IPBMGameEnded : Il2CppObjectBase
	{
		// Token: 0x06000148 RID: 328 RVA: 0x00002DDC File Offset: 0x00000FDC
		// Note: this type is marked as 'beforefieldinit'.
		static IPBMGameEnded()
		{
			Il2CppClassPointerStore<IPBMGameEnded>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages", "IPBMGameEnded");
			IPBMGameEnded.NativeMethodInfoPtr_GetGameID_Public_Abstract_Virtual_New_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPBMGameEnded>.NativeClassPtr, 100663362);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x000094BC File Offset: 0x000076BC
		[CallerCount(0)]
		public unsafe virtual GameID GetGameID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPBMGameEnded.NativeMethodInfoPtr_GetGameID_Public_Abstract_Virtual_New_GameID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr3) : null;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00002E0B File Offset: 0x0000100B
		public IPBMGameEnded(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_GetGameID_Public_Abstract_Virtual_New_GameID_0;
	}
}
