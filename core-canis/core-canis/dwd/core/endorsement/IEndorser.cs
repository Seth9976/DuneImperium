using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace dwd.core.endorsement
{
	// Token: 0x020001B8 RID: 440
	public class IEndorser<T> : Il2CppObjectBase where T : Request
	{
		// Token: 0x06001890 RID: 6288 RVA: 0x00075CB4 File Offset: 0x00073EB4
		// Note: this type is marked as 'beforefieldinit'.
		static IEndorser()
		{
			Il2CppClassPointerStore<IEndorser<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.endorsement", "IEndorser`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IEndorser<T>.NativeMethodInfoPtr_Endorse_Public_Abstract_Virtual_New_Coroutine_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEndorser<T>>.NativeClassPtr, 100667216);
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x00075D2C File Offset: 0x00073F2C
		[CallerCount(0)]
		public unsafe virtual Coroutine Endorse(T request)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEndorser<T>.NativeMethodInfoPtr_Endorse_Public_Abstract_Virtual_New_Coroutine_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr4) : null;
			}
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x0000AD0D File Offset: 0x00008F0D
		public IEndorser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001153 RID: 4435
		private static readonly IntPtr NativeMethodInfoPtr_Endorse_Public_Abstract_Virtual_New_Coroutine_T_0;
	}
}
