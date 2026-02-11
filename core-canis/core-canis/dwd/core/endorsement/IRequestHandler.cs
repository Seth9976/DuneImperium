using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace dwd.core.endorsement
{
	// Token: 0x020001B9 RID: 441
	public class IRequestHandler<T> : Il2CppObjectBase where T : Request
	{
		// Token: 0x06001893 RID: 6291 RVA: 0x00075DC0 File Offset: 0x00073FC0
		// Note: this type is marked as 'beforefieldinit'.
		static IRequestHandler()
		{
			Il2CppClassPointerStore<IRequestHandler<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.endorsement", "IRequestHandler`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IRequestHandler<T>.NativeMethodInfoPtr_Handle_Public_Abstract_Virtual_New_IEnumerator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRequestHandler<T>>.NativeClassPtr, 100667217);
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x00075E38 File Offset: 0x00074038
		[CallerCount(0)]
		public unsafe virtual IEnumerator Handle(T request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = request;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref request;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRequestHandler<T>.NativeMethodInfoPtr_Handle_Public_Abstract_Virtual_New_IEnumerator_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr4) : null;
			}
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x0000AD16 File Offset: 0x00008F16
		public IRequestHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001154 RID: 4436
		private static readonly IntPtr NativeMethodInfoPtr_Handle_Public_Abstract_Virtual_New_IEnumerator_T_0;
	}
}
