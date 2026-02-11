using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000075 RID: 117
	public sealed class CollectionDebuggerProxy<T> : Object
	{
		// Token: 0x0600072B RID: 1835 RVA: 0x0003815C File Offset: 0x0003635C
		// Note: this type is marked as 'beforefieldinit'.
		static CollectionDebuggerProxy()
		{
			Il2CppClassPointerStore<CollectionDebuggerProxy<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "CollectionDebuggerProxy`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectionDebuggerProxy<T>>.NativeClassPtr);
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x000044DD File Offset: 0x000026DD
		public CollectionDebuggerProxy(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
