using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.Properties
{
	// Token: 0x02000014 RID: 20
	public class IPropertyBag<TContainer> : Il2CppObjectBase
	{
		// Token: 0x06000095 RID: 149 RVA: 0x00005464 File Offset: 0x00003664
		// Note: this type is marked as 'beforefieldinit'.
		static IPropertyBag()
		{
			Il2CppClassPointerStore<IPropertyBag<TContainer>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties", "IPropertyBag`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TContainer>.NativeClassPtr)) })).TypeHandle.value);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000024DB File Offset: 0x000006DB
		public IPropertyBag(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
