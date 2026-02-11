using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x02000047 RID: 71
public class IGameObject : Il2CppObjectBase
{
	// Token: 0x06000589 RID: 1417 RVA: 0x00029770 File Offset: 0x00027970
	// Note: this type is marked as 'beforefieldinit'.
	static IGameObject()
	{
		Il2CppClassPointerStore<IGameObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "IGameObject");
		IGameObject.NativeMethodInfoPtr_get_gameObject_Public_Abstract_Virtual_New_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGameObject>.NativeClassPtr, 100664114);
		IGameObject.NativeMethodInfoPtr_get_transform_Public_Abstract_Virtual_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGameObject>.NativeClassPtr, 100664115);
	}

	// Token: 0x1700019D RID: 413
	// (get) Token: 0x0600058A RID: 1418 RVA: 0x000297C0 File Offset: 0x000279C0
	public unsafe virtual GameObject gameObject
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGameObject.NativeMethodInfoPtr_get_gameObject_Public_Abstract_Virtual_New_get_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}
	}

	// Token: 0x1700019E RID: 414
	// (get) Token: 0x0600058B RID: 1419 RVA: 0x0002980C File Offset: 0x00027A0C
	public unsafe virtual Transform transform
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGameObject.NativeMethodInfoPtr_get_transform_Public_Abstract_Virtual_New_get_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}
	}

	// Token: 0x0600058C RID: 1420 RVA: 0x00003F73 File Offset: 0x00002173
	public IGameObject(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x0400041B RID: 1051
	private static readonly IntPtr NativeMethodInfoPtr_get_gameObject_Public_Abstract_Virtual_New_get_GameObject_0;

	// Token: 0x0400041C RID: 1052
	private static readonly IntPtr NativeMethodInfoPtr_get_transform_Public_Abstract_Virtual_New_get_Transform_0;
}
