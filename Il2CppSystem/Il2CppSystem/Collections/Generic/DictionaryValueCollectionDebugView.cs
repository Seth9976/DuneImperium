using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x0200016A RID: 362
	public sealed class DictionaryValueCollectionDebugView<TKey, TValue> : Object
	{
		// Token: 0x060015D4 RID: 5588 RVA: 0x00070F74 File Offset: 0x0006F174
		// Note: this type is marked as 'beforefieldinit'.
		static DictionaryValueCollectionDebugView()
		{
			Il2CppClassPointerStore<DictionaryValueCollectionDebugView<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Generic", "DictionaryValueCollectionDebugView`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DictionaryValueCollectionDebugView<TKey, TValue>>.NativeClassPtr);
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x00009946 File Offset: 0x00007B46
		public DictionaryValueCollectionDebugView(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
