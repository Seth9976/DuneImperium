using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace DG.Tweening.Plugins.Options
{
	// Token: 0x0200002E RID: 46
	public class IPlugOptions : Il2CppObjectBase
	{
		// Token: 0x06000334 RID: 820 RVA: 0x00002CF8 File Offset: 0x00000EF8
		// Note: this type is marked as 'beforefieldinit'.
		static IPlugOptions()
		{
			Il2CppClassPointerStore<IPlugOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Options", "IPlugOptions");
			IPlugOptions.NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlugOptions>.NativeClassPtr, 100664083);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x000165CC File Offset: 0x000147CC
		[CallerCount(0)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlugOptions.NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00002D27 File Offset: 0x00000F27
		public IPlugOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0;
	}
}
