using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.messages
{
	// Token: 0x02000025 RID: 37
	public class IGameMessage : Il2CppObjectBase
	{
		// Token: 0x06000131 RID: 305 RVA: 0x00002CA7 File Offset: 0x00000EA7
		// Note: this type is marked as 'beforefieldinit'.
		static IGameMessage()
		{
			Il2CppClassPointerStore<IGameMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages", "IGameMessage");
			IGameMessage.NativeMethodInfoPtr_get_GameID_Public_Abstract_Virtual_New_get_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGameMessage>.NativeClassPtr, 100663359);
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00009188 File Offset: 0x00007388
		public unsafe virtual GameID GameID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGameMessage.NativeMethodInfoPtr_get_GameID_Public_Abstract_Virtual_New_get_GameID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr3) : null;
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00002CD6 File Offset: 0x00000ED6
		public IGameMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_get_GameID_Public_Abstract_Virtual_New_get_GameID_0;
	}
}
