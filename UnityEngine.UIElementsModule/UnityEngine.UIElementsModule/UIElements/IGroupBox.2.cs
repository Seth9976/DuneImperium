using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200013E RID: 318
	public class IGroupBox<T> : Il2CppObjectBase
	{
		// Token: 0x060017B3 RID: 6067 RVA: 0x00070E78 File Offset: 0x0006F078
		// Note: this type is marked as 'beforefieldinit'.
		static IGroupBox()
		{
			Il2CppClassPointerStore<IGroupBox<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IGroupBox`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		}

		// Token: 0x060017B4 RID: 6068 RVA: 0x0000AED3 File Offset: 0x000090D3
		public IGroupBox(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
