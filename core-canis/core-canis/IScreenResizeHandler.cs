using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

// Token: 0x0200005C RID: 92
public class IScreenResizeHandler : Il2CppObjectBase
{
	// Token: 0x060006BB RID: 1723 RVA: 0x0002EF20 File Offset: 0x0002D120
	// Note: this type is marked as 'beforefieldinit'.
	static IScreenResizeHandler()
	{
		Il2CppClassPointerStore<IScreenResizeHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "IScreenResizeHandler");
		IScreenResizeHandler.NativeMethodInfoPtr_PreScreenResize_Public_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IScreenResizeHandler>.NativeClassPtr, 100664320);
		IScreenResizeHandler.NativeMethodInfoPtr_PostScreenResize_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IScreenResizeHandler>.NativeClassPtr, 100664321);
	}

	// Token: 0x060006BC RID: 1724 RVA: 0x0002EF70 File Offset: 0x0002D170
	[CallerCount(0)]
	public unsafe virtual IEnumerator PreScreenResize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IScreenResizeHandler.NativeMethodInfoPtr_PreScreenResize_Public_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x060006BD RID: 1725 RVA: 0x0002EFBC File Offset: 0x0002D1BC
	[CallerCount(0)]
	public unsafe virtual void PostScreenResize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IScreenResizeHandler.NativeMethodInfoPtr_PostScreenResize_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060006BE RID: 1726 RVA: 0x0000430E File Offset: 0x0000250E
	public IScreenResizeHandler(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x0400050E RID: 1294
	private static readonly IntPtr NativeMethodInfoPtr_PreScreenResize_Public_Abstract_Virtual_New_IEnumerator_0;

	// Token: 0x0400050F RID: 1295
	private static readonly IntPtr NativeMethodInfoPtr_PostScreenResize_Public_Abstract_Virtual_New_Void_0;
}
