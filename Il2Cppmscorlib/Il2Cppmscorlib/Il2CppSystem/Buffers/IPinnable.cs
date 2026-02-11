using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Buffers
{
	// Token: 0x02000513 RID: 1299
	public class IPinnable : Il2CppObjectBase
	{
		// Token: 0x06004F86 RID: 20358 RVA: 0x0001C871 File Offset: 0x0001AA71
		// Note: this type is marked as 'beforefieldinit'.
		static IPinnable()
		{
			Il2CppClassPointerStore<IPinnable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Buffers", "IPinnable");
			IPinnable.NativeMethodInfoPtr_Unpin_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPinnable>.NativeClassPtr, 100675295);
		}

		// Token: 0x06004F87 RID: 20359 RVA: 0x001724B4 File Offset: 0x001706B4
		[CallerCount(0)]
		public unsafe virtual void Unpin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPinnable.NativeMethodInfoPtr_Unpin_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F88 RID: 20360 RVA: 0x0001C8A0 File Offset: 0x0001AAA0
		public IPinnable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040040D7 RID: 16599
		private static readonly IntPtr NativeMethodInfoPtr_Unpin_Public_Abstract_Virtual_New_Void_0;
	}
}
