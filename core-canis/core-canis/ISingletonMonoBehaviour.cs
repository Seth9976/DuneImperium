using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

// Token: 0x02000017 RID: 23
public class ISingletonMonoBehaviour : Il2CppObjectBase
{
	// Token: 0x060002B3 RID: 691 RVA: 0x0000321D File Offset: 0x0000141D
	// Note: this type is marked as 'beforefieldinit'.
	static ISingletonMonoBehaviour()
	{
		Il2CppClassPointerStore<ISingletonMonoBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "ISingletonMonoBehaviour");
		ISingletonMonoBehaviour.NativeMethodInfoPtr_get_isSingletonObject_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISingletonMonoBehaviour>.NativeClassPtr, 100663662);
	}

	// Token: 0x170000DA RID: 218
	// (get) Token: 0x060002B4 RID: 692 RVA: 0x0001D2B4 File Offset: 0x0001B4B4
	public unsafe virtual bool isSingletonObject
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISingletonMonoBehaviour.NativeMethodInfoPtr_get_isSingletonObject_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060002B5 RID: 693 RVA: 0x0000324C File Offset: 0x0000144C
	public ISingletonMonoBehaviour(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x040001F9 RID: 505
	private static readonly IntPtr NativeMethodInfoPtr_get_isSingletonObject_Public_Abstract_Virtual_New_get_Boolean_0;
}
