using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.input
{
	// Token: 0x0200003C RID: 60
	public class IHasPointerSounds : Il2CppObjectBase
	{
		// Token: 0x060001D5 RID: 469 RVA: 0x0000311C File Offset: 0x0000131C
		// Note: this type is marked as 'beforefieldinit'.
		static IHasPointerSounds()
		{
			Il2CppClassPointerStore<IHasPointerSounds>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input", "IHasPointerSounds");
			IHasPointerSounds.NativeMethodInfoPtr_OnSubmit_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasPointerSounds>.NativeClassPtr, 100663545);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0000CAF8 File Offset: 0x0000ACF8
		[CallerCount(0)]
		public unsafe virtual void OnSubmit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasPointerSounds.NativeMethodInfoPtr_OnSubmit_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0000314B File Offset: 0x0000134B
		public IHasPointerSounds(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Public_Abstract_Virtual_New_Void_0;
	}
}
