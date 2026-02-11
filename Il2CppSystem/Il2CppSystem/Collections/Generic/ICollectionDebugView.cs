using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x02000167 RID: 359
	public sealed class ICollectionDebugView<T> : Object
	{
		// Token: 0x060015CE RID: 5582 RVA: 0x00070E08 File Offset: 0x0006F008
		// Note: this type is marked as 'beforefieldinit'.
		static ICollectionDebugView()
		{
			Il2CppClassPointerStore<ICollectionDebugView<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Generic", "ICollectionDebugView`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ICollectionDebugView<T>>.NativeClassPtr);
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x0000992B File Offset: 0x00007B2B
		public ICollectionDebugView(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
