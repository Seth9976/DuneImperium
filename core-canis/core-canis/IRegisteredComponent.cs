using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x02000013 RID: 19
public class IRegisteredComponent : Il2CppObjectBase
{
	// Token: 0x06000289 RID: 649 RVA: 0x00003142 File Offset: 0x00001342
	// Note: this type is marked as 'beforefieldinit'.
	static IRegisteredComponent()
	{
		Il2CppClassPointerStore<IRegisteredComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "IRegisteredComponent");
		IRegisteredComponent.NativeMethodInfoPtr_GetRegisteredComponentBaseClassType_Public_Abstract_Virtual_New_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRegisteredComponent>.NativeClassPtr, 100663641);
	}

	// Token: 0x0600028A RID: 650 RVA: 0x0001C9B4 File Offset: 0x0001ABB4
	[CallerCount(0)]
	public unsafe virtual Type GetRegisteredComponentBaseClassType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRegisteredComponent.NativeMethodInfoPtr_GetRegisteredComponentBaseClassType_Public_Abstract_Virtual_New_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
	}

	// Token: 0x0600028B RID: 651 RVA: 0x00003171 File Offset: 0x00001371
	public IRegisteredComponent(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x040001DF RID: 479
	private static readonly IntPtr NativeMethodInfoPtr_GetRegisteredComponentBaseClassType_Public_Abstract_Virtual_New_Type_0;
}
