using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Localization.Settings
{
	// Token: 0x02000098 RID: 152
	public class IReset : Il2CppObjectBase
	{
		// Token: 0x06000762 RID: 1890 RVA: 0x00004D62 File Offset: 0x00002F62
		// Note: this type is marked as 'beforefieldinit'.
		static IReset()
		{
			Il2CppClassPointerStore<IReset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Settings", "IReset");
			IReset.NativeMethodInfoPtr_ResetState_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IReset>.NativeClassPtr, 100664625);
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x00025D30 File Offset: 0x00023F30
		[CallerCount(0)]
		public unsafe virtual void ResetState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IReset.NativeMethodInfoPtr_ResetState_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x00004D91 File Offset: 0x00002F91
		public IReset(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000544 RID: 1348
		private static readonly IntPtr NativeMethodInfoPtr_ResetState_Public_Abstract_Virtual_New_Void_0;
	}
}
