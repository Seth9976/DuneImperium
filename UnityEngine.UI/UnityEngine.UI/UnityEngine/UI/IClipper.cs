using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UI
{
	// Token: 0x0200000B RID: 11
	public class IClipper : Il2CppObjectBase
	{
		// Token: 0x06000085 RID: 133 RVA: 0x000022F6 File Offset: 0x000004F6
		// Note: this type is marked as 'beforefieldinit'.
		static IClipper()
		{
			Il2CppClassPointerStore<IClipper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "IClipper");
			IClipper.NativeMethodInfoPtr_PerformClipping_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClipper>.NativeClassPtr, 100663378);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00009328 File Offset: 0x00007528
		[CallerCount(0)]
		public unsafe virtual void PerformClipping()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClipper.NativeMethodInfoPtr_PerformClipping_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002325 File Offset: 0x00000525
		public IClipper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_PerformClipping_Public_Abstract_Virtual_New_Void_0;
	}
}
