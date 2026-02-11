using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.Properties
{
	// Token: 0x02000020 RID: 32
	public class IConstructor<T> : Il2CppObjectBase
	{
		// Token: 0x0600011F RID: 287 RVA: 0x000067E8 File Offset: 0x000049E8
		// Note: this type is marked as 'beforefieldinit'.
		static IConstructor()
		{
			Il2CppClassPointerStore<IConstructor<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties", "IConstructor`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IConstructor<T>.NativeMethodInfoPtr_Instantiate_Public_Abstract_Virtual_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConstructor<T>>.NativeClassPtr, 100663399);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00006860 File Offset: 0x00004A60
		[CallerCount(0)]
		public unsafe virtual T Instantiate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConstructor<T>.NativeMethodInfoPtr_Instantiate_Public_Abstract_Virtual_New_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00002878 File Offset: 0x00000A78
		public IConstructor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Abstract_Virtual_New_T_0;
	}
}
