using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem
{
	// Token: 0x020000AC RID: 172
	public class IDisposable : Il2CppObjectBase
	{
		// Token: 0x06000B9D RID: 2973 RVA: 0x00004EF6 File Offset: 0x000030F6
		// Note: this type is marked as 'beforefieldinit'.
		static IDisposable()
		{
			Il2CppClassPointerStore<IDisposable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "IDisposable");
			IDisposable.NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDisposable>.NativeClassPtr, 100665319);
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x0005B774 File Offset: 0x00059974
		[CallerCount(0)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDisposable.NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x00004F25 File Offset: 0x00003125
		public IDisposable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000989 RID: 2441
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_0;
	}
}
