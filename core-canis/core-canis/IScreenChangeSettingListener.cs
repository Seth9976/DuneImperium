using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

// Token: 0x0200005B RID: 91
public class IScreenChangeSettingListener : Il2CppObjectBase
{
	// Token: 0x060006B8 RID: 1720 RVA: 0x000042D6 File Offset: 0x000024D6
	// Note: this type is marked as 'beforefieldinit'.
	static IScreenChangeSettingListener()
	{
		Il2CppClassPointerStore<IScreenChangeSettingListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "IScreenChangeSettingListener");
		IScreenChangeSettingListener.NativeMethodInfoPtr_Handle_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IScreenChangeSettingListener>.NativeClassPtr, 100664319);
	}

	// Token: 0x060006B9 RID: 1721 RVA: 0x0002EEE4 File Offset: 0x0002D0E4
	[CallerCount(0)]
	public unsafe virtual void Handle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IScreenChangeSettingListener.NativeMethodInfoPtr_Handle_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060006BA RID: 1722 RVA: 0x00004305 File Offset: 0x00002505
	public IScreenChangeSettingListener(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x0400050D RID: 1293
	private static readonly IntPtr NativeMethodInfoPtr_Handle_Public_Abstract_Virtual_New_Void_0;
}
