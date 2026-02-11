using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.Localization.SmartFormat.PersistentVariables;

namespace UnityEngine.Localization.SmartFormat.GlobalVariables
{
	// Token: 0x0200005E RID: 94
	[Serializable]
	public class GlobalVariable<T> : Variable<T>
	{
		// Token: 0x0600049A RID: 1178 RVA: 0x0001AB74 File Offset: 0x00018D74
		// Note: this type is marked as 'beforefieldinit'.
		static GlobalVariable()
		{
			Il2CppClassPointerStore<GlobalVariable<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.GlobalVariables", "GlobalVariable`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalVariable<T>>.NativeClassPtr);
			GlobalVariable<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalVariable<T>>.NativeClassPtr, 100664164);
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0001ABF4 File Offset: 0x00018DF4
		[CallerCount(0)]
		public unsafe GlobalVariable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalVariable<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalVariable<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00003CA9 File Offset: 0x00001EA9
		public GlobalVariable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
