using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020004DF RID: 1247
	public sealed class ICollectionDebugView<T> : Object
	{
		// Token: 0x06004D7D RID: 19837 RVA: 0x001673CC File Offset: 0x001655CC
		// Note: this type is marked as 'beforefieldinit'.
		static ICollectionDebugView()
		{
			Il2CppClassPointerStore<ICollectionDebugView<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "ICollectionDebugView`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ICollectionDebugView<T>>.NativeClassPtr);
		}

		// Token: 0x06004D7E RID: 19838 RVA: 0x0001C146 File Offset: 0x0001A346
		public ICollectionDebugView(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
