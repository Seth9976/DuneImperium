using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace zen.match
{
	// Token: 0x02000043 RID: 67
	public class IPauseCommandQueue : Il2CppObjectBase
	{
		// Token: 0x060002AB RID: 683 RVA: 0x00003286 File Offset: 0x00001486
		// Note: this type is marked as 'beforefieldinit'.
		static IPauseCommandQueue()
		{
			Il2CppClassPointerStore<IPauseCommandQueue>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.match", "IPauseCommandQueue");
			IPauseCommandQueue.NativeMethodInfoPtr_get_PauseDequeue_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPauseCommandQueue>.NativeClassPtr, 100663774);
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060002AC RID: 684 RVA: 0x000199DC File Offset: 0x00017BDC
		public unsafe virtual bool PauseDequeue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPauseCommandQueue.NativeMethodInfoPtr_get_PauseDequeue_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002AD RID: 685 RVA: 0x000032B5 File Offset: 0x000014B5
		public IPauseCommandQueue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeMethodInfoPtr_get_PauseDequeue_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
