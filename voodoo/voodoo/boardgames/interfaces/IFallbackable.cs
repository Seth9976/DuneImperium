using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine;

namespace boardgames.interfaces
{
	// Token: 0x020000AB RID: 171
	public class IFallbackable<T> : Il2CppObjectBase where T : MonoBehaviour
	{
		// Token: 0x060009B3 RID: 2483 RVA: 0x00029BEC File Offset: 0x00027DEC
		// Note: this type is marked as 'beforefieldinit'.
		static IFallbackable()
		{
			Il2CppClassPointerStore<IFallbackable<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("voodoo.dll", "boardgames.interfaces", "IFallbackable`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IFallbackable<T>.NativeMethodInfoPtr_AddFallback_Public_Abstract_Virtual_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFallbackable<T>>.NativeClassPtr, 100664695);
			IFallbackable<T>.NativeMethodInfoPtr_RemoveFallback_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFallbackable<T>>.NativeClassPtr, 100664696);
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x00029C78 File Offset: 0x00027E78
		[CallerCount(0)]
		public unsafe virtual void AddFallback(T fallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = fallback;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref fallback;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFallbackable<T>.NativeMethodInfoPtr_AddFallback_Public_Abstract_Virtual_New_Void_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x00029CFC File Offset: 0x00027EFC
		[CallerCount(0)]
		public unsafe virtual void RemoveFallback()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFallbackable<T>.NativeMethodInfoPtr_RemoveFallback_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x00006B49 File Offset: 0x00004D49
		public IFallbackable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400060D RID: 1549
		private static readonly IntPtr NativeMethodInfoPtr_AddFallback_Public_Abstract_Virtual_New_Void_T_0;

		// Token: 0x0400060E RID: 1550
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFallback_Public_Abstract_Virtual_New_Void_0;
	}
}
