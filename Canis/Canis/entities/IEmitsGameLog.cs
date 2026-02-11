using System;
using Canis.gameLogs;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.entities
{
	// Token: 0x020000DF RID: 223
	public class IEmitsGameLog : Il2CppObjectBase
	{
		// Token: 0x06000A37 RID: 2615 RVA: 0x00005CA1 File Offset: 0x00003EA1
		// Note: this type is marked as 'beforefieldinit'.
		static IEmitsGameLog()
		{
			Il2CppClassPointerStore<IEmitsGameLog>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "IEmitsGameLog");
			IEmitsGameLog.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Abstract_Virtual_New_GameLogBuilder_IHasGameLogs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEmitsGameLog>.NativeClassPtr, 100665451);
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00044C60 File Offset: 0x00042E60
		[CallerCount(0)]
		public unsafe virtual GameLogBuilder MakeGameLogBuilder(IHasGameLogs hasGameLogs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasGameLogs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEmitsGameLog.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Abstract_Virtual_New_GameLogBuilder_IHasGameLogs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x00005CD0 File Offset: 0x00003ED0
		public IEmitsGameLog(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006F8 RID: 1784
		private static readonly IntPtr NativeMethodInfoPtr_MakeGameLogBuilder_Public_Abstract_Virtual_New_GameLogBuilder_IHasGameLogs_0;
	}
}
