using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.data
{
	// Token: 0x020001C7 RID: 455
	public class IHasProgress : Il2CppObjectBase
	{
		// Token: 0x0600195A RID: 6490 RVA: 0x0000B1F7 File Offset: 0x000093F7
		// Note: this type is marked as 'beforefieldinit'.
		static IHasProgress()
		{
			Il2CppClassPointerStore<IHasProgress>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.data", "IHasProgress");
			IHasProgress.NativeMethodInfoPtr_GetPercent_Public_Abstract_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasProgress>.NativeClassPtr, 100667329);
		}

		// Token: 0x0600195B RID: 6491 RVA: 0x000789F0 File Offset: 0x00076BF0
		[CallerCount(0)]
		public unsafe virtual float GetPercent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasProgress.NativeMethodInfoPtr_GetPercent_Public_Abstract_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600195C RID: 6492 RVA: 0x0000B226 File Offset: 0x00009426
		public IHasProgress(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040011D4 RID: 4564
		private static readonly IntPtr NativeMethodInfoPtr_GetPercent_Public_Abstract_Virtual_New_Single_0;
	}
}
