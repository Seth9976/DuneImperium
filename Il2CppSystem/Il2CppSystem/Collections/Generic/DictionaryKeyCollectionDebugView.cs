using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x02000169 RID: 361
	public sealed class DictionaryKeyCollectionDebugView<TKey, TValue> : Object
	{
		// Token: 0x060015D2 RID: 5586 RVA: 0x00070EF4 File Offset: 0x0006F0F4
		// Note: this type is marked as 'beforefieldinit'.
		static DictionaryKeyCollectionDebugView()
		{
			Il2CppClassPointerStore<DictionaryKeyCollectionDebugView<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Generic", "DictionaryKeyCollectionDebugView`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DictionaryKeyCollectionDebugView<TKey, TValue>>.NativeClassPtr);
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x0000993D File Offset: 0x00007B3D
		public DictionaryKeyCollectionDebugView(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
