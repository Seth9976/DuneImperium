using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020004FB RID: 1275
	public sealed class DictionaryDebugView<K, V> : Object
	{
		// Token: 0x06004EAB RID: 20139 RVA: 0x0016D388 File Offset: 0x0016B588
		// Note: this type is marked as 'beforefieldinit'.
		static DictionaryDebugView()
		{
			Il2CppClassPointerStore<DictionaryDebugView<K, V>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "DictionaryDebugView`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<K>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DictionaryDebugView<K, V>>.NativeClassPtr);
		}

		// Token: 0x06004EAC RID: 20140 RVA: 0x0001C672 File Offset: 0x0001A872
		public DictionaryDebugView(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
