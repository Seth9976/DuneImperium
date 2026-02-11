using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x02000023 RID: 35
public class IVersionedList<T> : Il2CppObjectBase
{
	// Token: 0x06000326 RID: 806 RVA: 0x0001ECC4 File Offset: 0x0001CEC4
	// Note: this type is marked as 'beforefieldinit'.
	static IVersionedList()
	{
		Il2CppClassPointerStore<IVersionedList<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "", "IVersionedList`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		IVersionedList<T>.NativeMethodInfoPtr_get_AsReadOnly_Public_Abstract_Virtual_New_get_ReadOnlyVersionedList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVersionedList<T>>.NativeClassPtr, 100663712);
		IVersionedList<T>.NativeMethodInfoPtr_MarkDirty_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVersionedList<T>>.NativeClassPtr, 100663713);
	}

	// Token: 0x170000FD RID: 253
	// (get) Token: 0x06000327 RID: 807 RVA: 0x0001ED50 File Offset: 0x0001CF50
	public unsafe virtual ReadOnlyVersionedList<T> AsReadOnly
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVersionedList<T>.NativeMethodInfoPtr_get_AsReadOnly_Public_Abstract_Virtual_New_get_ReadOnlyVersionedList_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyVersionedList<T>>(intPtr3) : null;
		}
	}

	// Token: 0x06000328 RID: 808 RVA: 0x0001ED9C File Offset: 0x0001CF9C
	[CallerCount(0)]
	public unsafe virtual void MarkDirty()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVersionedList<T>.NativeMethodInfoPtr_MarkDirty_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000329 RID: 809 RVA: 0x000035A5 File Offset: 0x000017A5
	public IVersionedList(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x0400023F RID: 575
	private static readonly IntPtr NativeMethodInfoPtr_get_AsReadOnly_Public_Abstract_Virtual_New_get_ReadOnlyVersionedList_1_T_0;

	// Token: 0x04000240 RID: 576
	private static readonly IntPtr NativeMethodInfoPtr_MarkDirty_Public_Abstract_Virtual_New_Void_0;
}
