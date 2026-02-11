using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.gameLogs
{
	// Token: 0x020000A8 RID: 168
	public class IHasGameLogManager : Il2CppObjectBase
	{
		// Token: 0x060007FF RID: 2047 RVA: 0x000051F3 File Offset: 0x000033F3
		// Note: this type is marked as 'beforefieldinit'.
		static IHasGameLogManager()
		{
			Il2CppClassPointerStore<IHasGameLogManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.gameLogs", "IHasGameLogManager");
			IHasGameLogManager.NativeMethodInfoPtr_get_GameLogManager_Public_Abstract_Virtual_New_get_GameLogManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasGameLogManager>.NativeClassPtr, 100664930);
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x00039C74 File Offset: 0x00037E74
		public unsafe virtual GameLogManager GameLogManager
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasGameLogManager.NativeMethodInfoPtr_get_GameLogManager_Public_Abstract_Virtual_New_get_GameLogManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogManager>(intPtr3) : null;
			}
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00005222 File Offset: 0x00003422
		public IHasGameLogManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400057A RID: 1402
		private static readonly IntPtr NativeMethodInfoPtr_get_GameLogManager_Public_Abstract_Virtual_New_get_GameLogManager_0;
	}
}
