using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020004FA RID: 1274
	public sealed class CollectionDebugView<T> : Object
	{
		// Token: 0x06004EA9 RID: 20137 RVA: 0x0016D31C File Offset: 0x0016B51C
		// Note: this type is marked as 'beforefieldinit'.
		static CollectionDebugView()
		{
			Il2CppClassPointerStore<CollectionDebugView<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "CollectionDebugView`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectionDebugView<T>>.NativeClassPtr);
		}

		// Token: 0x06004EAA RID: 20138 RVA: 0x0001C669 File Offset: 0x0001A869
		public CollectionDebugView(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
