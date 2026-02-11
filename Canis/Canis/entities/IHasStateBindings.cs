using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Canis.entities
{
	// Token: 0x020000C1 RID: 193
	public class IHasStateBindings<T> : Il2CppObjectBase
	{
		// Token: 0x060008DD RID: 2269 RVA: 0x0003DD74 File Offset: 0x0003BF74
		// Note: this type is marked as 'beforefieldinit'.
		static IHasStateBindings()
		{
			Il2CppClassPointerStore<IHasStateBindings<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "IHasStateBindings`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IHasStateBindings<T>.NativeMethodInfoPtr_AddBinding_Public_Abstract_Virtual_New_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasStateBindings<T>>.NativeClassPtr, 100665125);
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x0003DDEC File Offset: 0x0003BFEC
		[CallerCount(0)]
		public unsafe virtual void AddBinding(int state, T behavior)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = behavior;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref behavior;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasStateBindings<T>.NativeMethodInfoPtr_AddBinding_Public_Abstract_Virtual_New_Void_Int32_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x000056D2 File Offset: 0x000038D2
		public IHasStateBindings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000609 RID: 1545
		private static readonly IntPtr NativeMethodInfoPtr_AddBinding_Public_Abstract_Virtual_New_Void_Int32_T_0;
	}
}
