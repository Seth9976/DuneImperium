using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.Properties
{
	// Token: 0x02000008 RID: 8
	public class IProperty<TContainer> : Il2CppObjectBase
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00003B94 File Offset: 0x00001D94
		// Note: this type is marked as 'beforefieldinit'.
		static IProperty()
		{
			Il2CppClassPointerStore<IProperty<TContainer>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties", "IProperty`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TContainer>.NativeClassPtr)) })).TypeHandle.value);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002167 File Offset: 0x00000367
		public IProperty(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
