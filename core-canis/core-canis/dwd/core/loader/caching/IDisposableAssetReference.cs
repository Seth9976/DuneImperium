using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.loader.caching
{
	// Token: 0x0200018C RID: 396
	public class IDisposableAssetReference : Il2CppObjectBase
	{
		// Token: 0x06001650 RID: 5712 RVA: 0x00009C16 File Offset: 0x00007E16
		// Note: this type is marked as 'beforefieldinit'.
		static IDisposableAssetReference()
		{
			Il2CppClassPointerStore<IDisposableAssetReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader.caching", "IDisposableAssetReference");
			IDisposableAssetReference.NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDisposableAssetReference>.NativeClassPtr, 100666712);
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x0006D8C4 File Offset: 0x0006BAC4
		[CallerCount(0)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDisposableAssetReference.NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x00009C45 File Offset: 0x00007E45
		public IDisposableAssetReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FD4 RID: 4052
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_0;
	}
}
