using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x02000002 RID: 2
public class IActivationFactory : Object
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	// Note: this type is marked as 'beforefieldinit'.
	static IActivationFactory()
	{
		Il2CppClassPointerStore<IActivationFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("__Generated.dll", "", "IActivationFactory");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IActivationFactory>.NativeClassPtr);
		IActivationFactory.NativeMethodInfoPtr_ActivateInstance_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IActivationFactory>.NativeClassPtr, 100663297);
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002184 File Offset: 0x00000384
	[CallerCount(0)]
	public unsafe override Object ActivateInstance()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IActivationFactory.NativeMethodInfoPtr_ActivateInstance_Public_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002089 File Offset: 0x00000289
	public IActivationFactory(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000001 RID: 1
	private static readonly IntPtr NativeMethodInfoPtr_ActivateInstance_Public_Virtual_Object_0;
}
