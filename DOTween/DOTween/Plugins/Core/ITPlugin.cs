using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace DG.Tweening.Plugins.Core
{
	// Token: 0x0200003A RID: 58
	public class ITPlugin<T1, T2, TPlugOptions, TPlugin> : Il2CppObjectBase
	{
		// Token: 0x06000386 RID: 902 RVA: 0x00017064 File Offset: 0x00015264
		// Note: this type is marked as 'beforefieldinit'.
		static ITPlugin()
		{
			Il2CppClassPointerStore<ITPlugin<T1, T2, TPlugOptions, TPlugin>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Core", "ITPlugin`4"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugOptions>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugin>.NativeClassPtr))
			})).TypeHandle.value);
		}

		// Token: 0x06000387 RID: 903 RVA: 0x000030B5 File Offset: 0x000012B5
		public ITPlugin(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
