using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Pool
{
	// Token: 0x020001D2 RID: 466
	public class IObjectPool<T> : Il2CppObjectBase where T : class
	{
		// Token: 0x0600210E RID: 8462 RVA: 0x00091D00 File Offset: 0x0008FF00
		// Note: this type is marked as 'beforefieldinit'.
		static IObjectPool()
		{
			Il2CppClassPointerStore<IObjectPool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Pool", "IObjectPool`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IObjectPool<T>.NativeMethodInfoPtr_Release_Public_Abstract_Virtual_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectPool<T>>.NativeClassPtr, 100667761);
		}

		// Token: 0x0600210F RID: 8463 RVA: 0x00091D78 File Offset: 0x0008FF78
		[CallerCount(0)]
		public unsafe virtual void Release(T element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = element;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref element;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IObjectPool<T>.NativeMethodInfoPtr_Release_Public_Abstract_Virtual_New_Void_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06002110 RID: 8464 RVA: 0x0000CA07 File Offset: 0x0000AC07
		public IObjectPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001C40 RID: 7232
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Abstract_Virtual_New_Void_T_0;
	}
}
