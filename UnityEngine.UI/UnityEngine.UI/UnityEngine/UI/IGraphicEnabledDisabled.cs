using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UI
{
	// Token: 0x02000015 RID: 21
	public class IGraphicEnabledDisabled : Il2CppObjectBase
	{
		// Token: 0x060001EF RID: 495 RVA: 0x00002B0D File Offset: 0x00000D0D
		// Note: this type is marked as 'beforefieldinit'.
		static IGraphicEnabledDisabled()
		{
			Il2CppClassPointerStore<IGraphicEnabledDisabled>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "IGraphicEnabledDisabled");
			IGraphicEnabledDisabled.NativeMethodInfoPtr_OnSiblingGraphicEnabledDisabled_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGraphicEnabledDisabled>.NativeClassPtr, 100663612);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000E874 File Offset: 0x0000CA74
		[CallerCount(0)]
		public unsafe virtual void OnSiblingGraphicEnabledDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGraphicEnabledDisabled.NativeMethodInfoPtr_OnSiblingGraphicEnabledDisabled_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00002B3C File Offset: 0x00000D3C
		public IGraphicEnabledDisabled(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeMethodInfoPtr_OnSiblingGraphicEnabledDisabled_Public_Abstract_Virtual_New_Void_0;
	}
}
