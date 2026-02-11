using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

// Token: 0x02000026 RID: 38
public class IVersionedMap<K, V> : Il2CppObjectBase
{
	// Token: 0x06000378 RID: 888 RVA: 0x000207E8 File Offset: 0x0001E9E8
	// Note: this type is marked as 'beforefieldinit'.
	static IVersionedMap()
	{
		Il2CppClassPointerStore<IVersionedMap<K, V>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "", "IVersionedMap`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<K>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr))
		})).TypeHandle.value);
	}

	// Token: 0x06000379 RID: 889 RVA: 0x00003672 File Offset: 0x00001872
	public IVersionedMap(IntPtr pointer)
		: base(pointer)
	{
	}
}
