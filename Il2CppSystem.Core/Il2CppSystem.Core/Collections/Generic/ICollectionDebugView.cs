using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x02000132 RID: 306
	public sealed class ICollectionDebugView<T> : Object
	{
		// Token: 0x06001223 RID: 4643 RVA: 0x0005E908 File Offset: 0x0005CB08
		// Note: this type is marked as 'beforefieldinit'.
		static ICollectionDebugView()
		{
			Il2CppClassPointerStore<ICollectionDebugView<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Collections.Generic", "ICollectionDebugView`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ICollectionDebugView<T>>.NativeClassPtr);
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x000077EA File Offset: 0x000059EA
		public ICollectionDebugView(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
