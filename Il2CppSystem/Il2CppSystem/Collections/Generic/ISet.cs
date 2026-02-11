using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x02000174 RID: 372
	public class ISet<T> : Il2CppObjectBase
	{
		// Token: 0x060016EC RID: 5868 RVA: 0x000764E0 File Offset: 0x000746E0
		// Note: this type is marked as 'beforefieldinit'.
		static ISet()
		{
			Il2CppClassPointerStore<ISet<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Generic", "ISet`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x00009DEE File Offset: 0x00007FEE
		public ISet(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
