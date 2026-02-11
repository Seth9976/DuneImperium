using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UI
{
	// Token: 0x02000018 RID: 24
	public class IMaskable : Il2CppObjectBase
	{
		// Token: 0x0600026C RID: 620 RVA: 0x00002D53 File Offset: 0x00000F53
		// Note: this type is marked as 'beforefieldinit'.
		static IMaskable()
		{
			Il2CppClassPointerStore<IMaskable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "IMaskable");
			IMaskable.NativeMethodInfoPtr_RecalculateMasking_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMaskable>.NativeClassPtr, 100663690);
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00010840 File Offset: 0x0000EA40
		[CallerCount(0)]
		public unsafe virtual void RecalculateMasking()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMaskable.NativeMethodInfoPtr_RecalculateMasking_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00002D82 File Offset: 0x00000F82
		public IMaskable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateMasking_Public_Abstract_Virtual_New_Void_0;
	}
}
