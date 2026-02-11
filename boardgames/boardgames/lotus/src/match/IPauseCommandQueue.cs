using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace lotus.src.match
{
	// Token: 0x020000F2 RID: 242
	public class IPauseCommandQueue : Il2CppObjectBase
	{
		// Token: 0x06000BA2 RID: 2978 RVA: 0x00007513 File Offset: 0x00005713
		// Note: this type is marked as 'beforefieldinit'.
		static IPauseCommandQueue()
		{
			Il2CppClassPointerStore<IPauseCommandQueue>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus.src.match", "IPauseCommandQueue");
			IPauseCommandQueue.NativeMethodInfoPtr_get_PauseDequeue_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPauseCommandQueue>.NativeClassPtr, 100665162);
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000BA3 RID: 2979 RVA: 0x000362E8 File Offset: 0x000344E8
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

		// Token: 0x06000BA4 RID: 2980 RVA: 0x00007542 File Offset: 0x00005742
		public IPauseCommandQueue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000730 RID: 1840
		private static readonly IntPtr NativeMethodInfoPtr_get_PauseDequeue_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
