using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020004E5 RID: 1253
	public class IEnumerable<T> : Il2CppObjectBase
	{
		// Token: 0x06004D92 RID: 19858 RVA: 0x00167CD8 File Offset: 0x00165ED8
		// Note: this type is marked as 'beforefieldinit'.
		static IEnumerable()
		{
			Il2CppClassPointerStore<IEnumerable<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "IEnumerable`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IEnumerable<T>.NativeMethodInfoPtr_GetEnumerator_Public_Abstract_Virtual_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEnumerable<T>>.NativeClassPtr, 100674952);
		}

		// Token: 0x06004D93 RID: 19859 RVA: 0x00167D50 File Offset: 0x00165F50
		[CallerCount(0)]
		public unsafe virtual IEnumerator<T> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEnumerable<T>.NativeMethodInfoPtr_GetEnumerator_Public_Abstract_Virtual_New_IEnumerator_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
		}

		// Token: 0x06004D94 RID: 19860 RVA: 0x0001C17C File Offset: 0x0001A37C
		public IEnumerable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003F76 RID: 16246
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Abstract_Virtual_New_IEnumerator_1_T_0;
	}
}
