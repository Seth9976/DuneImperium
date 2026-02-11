using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Concurrent
{
	// Token: 0x020004D6 RID: 1238
	public sealed class IProducerConsumerCollectionDebugView<T> : Object
	{
		// Token: 0x06004C86 RID: 19590 RVA: 0x00161D58 File Offset: 0x0015FF58
		// Note: this type is marked as 'beforefieldinit'.
		static IProducerConsumerCollectionDebugView()
		{
			Il2CppClassPointerStore<IProducerConsumerCollectionDebugView<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Concurrent", "IProducerConsumerCollectionDebugView`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IProducerConsumerCollectionDebugView<T>>.NativeClassPtr);
		}

		// Token: 0x06004C87 RID: 19591 RVA: 0x0001BE0A File Offset: 0x0001A00A
		public IProducerConsumerCollectionDebugView(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
