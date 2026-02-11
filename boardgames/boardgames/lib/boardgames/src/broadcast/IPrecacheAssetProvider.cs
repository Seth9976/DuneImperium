using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace lib.boardgames.src.broadcast
{
	// Token: 0x02000041 RID: 65
	public class IPrecacheAssetProvider : Il2CppObjectBase
	{
		// Token: 0x0600029B RID: 667 RVA: 0x000196DC File Offset: 0x000178DC
		// Note: this type is marked as 'beforefieldinit'.
		static IPrecacheAssetProvider()
		{
			Il2CppClassPointerStore<IPrecacheAssetProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lib.boardgames.src.broadcast", "IPrecacheAssetProvider");
			IPrecacheAssetProvider.NativeMethodInfoPtr_IgnorePrecache_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPrecacheAssetProvider>.NativeClassPtr, 100663770);
			IPrecacheAssetProvider.NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPrecacheAssetProvider>.NativeClassPtr, 100663771);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0001972C File Offset: 0x0001792C
		[CallerCount(0)]
		public unsafe virtual void IgnorePrecache()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPrecacheAssetProvider.NativeMethodInfoPtr_IgnorePrecache_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00019768 File Offset: 0x00017968
		[CallerCount(0)]
		public unsafe virtual IEnumerator Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPrecacheAssetProvider.NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x000031F8 File Offset: 0x000013F8
		public IPrecacheAssetProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr_IgnorePrecache_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_IEnumerator_0;
	}
}
