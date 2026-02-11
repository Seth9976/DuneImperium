using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.utils
{
	// Token: 0x02000009 RID: 9
	public class IVersionedSet<T> : Il2CppObjectBase
	{
		// Token: 0x06000022 RID: 34 RVA: 0x00004B20 File Offset: 0x00002D20
		// Note: this type is marked as 'beforefieldinit'.
		static IVersionedSet()
		{
			Il2CppClassPointerStore<IVersionedSet<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Utils.dll", "Canis.utils", "IVersionedSet`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IVersionedSet<T>.NativeMethodInfoPtr_GetEnumerator_Public_Abstract_Virtual_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVersionedSet<T>>.NativeClassPtr, 100663311);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00004B98 File Offset: 0x00002D98
		[CallerCount(0)]
		public unsafe virtual IEnumerator<T> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVersionedSet<T>.NativeMethodInfoPtr_GetEnumerator_Public_Abstract_Virtual_New_IEnumerator_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002178 File Offset: 0x00000378
		public IVersionedSet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Abstract_Virtual_New_IEnumerator_1_T_0;
	}
}
