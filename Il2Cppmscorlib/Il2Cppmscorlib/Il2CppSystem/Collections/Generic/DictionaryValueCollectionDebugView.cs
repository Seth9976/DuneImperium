using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020004E4 RID: 1252
	public sealed class DictionaryValueCollectionDebugView<TKey, TValue> : Object
	{
		// Token: 0x06004D90 RID: 19856 RVA: 0x00167C58 File Offset: 0x00165E58
		// Note: this type is marked as 'beforefieldinit'.
		static DictionaryValueCollectionDebugView()
		{
			Il2CppClassPointerStore<DictionaryValueCollectionDebugView<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "DictionaryValueCollectionDebugView`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DictionaryValueCollectionDebugView<TKey, TValue>>.NativeClassPtr);
		}

		// Token: 0x06004D91 RID: 19857 RVA: 0x0001C173 File Offset: 0x0001A373
		public DictionaryValueCollectionDebugView(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
