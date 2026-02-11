using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal.UTess
{
	// Token: 0x02000137 RID: 311
	public class ICondition2<T, U> : Il2CppObjectBase
	{
		// Token: 0x06001A8F RID: 6799 RVA: 0x0006F528 File Offset: 0x0006D728
		// Note: this type is marked as 'beforefieldinit'.
		static ICondition2()
		{
			Il2CppClassPointerStore<ICondition2<T, U>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.UTess", "ICondition2`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			})).TypeHandle.value);
			ICondition2<T, U>.NativeMethodInfoPtr_Test_Public_Abstract_Virtual_New_Boolean_T_U_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICondition2<T, U>>.NativeClassPtr, 100666413);
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x0006F5B0 File Offset: 0x0006D7B0
		[CallerCount(0)]
		public unsafe virtual bool Test(T x, U y, ref float t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = x;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref x;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(U).IsValueType)
			{
				U u = y;
				intPtr2 = ((u is string) ? IL2CPP.ManagedStringToIl2Cpp(u as string) : IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref y;
			}
			ptr3 = intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICondition2<T, U>.NativeMethodInfoPtr_Test_Public_Abstract_Virtual_New_Boolean_T_U_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x0000F00C File Offset: 0x0000D20C
		public ICondition2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400133F RID: 4927
		private static readonly IntPtr NativeMethodInfoPtr_Test_Public_Abstract_Virtual_New_Boolean_T_U_byref_Single_0;
	}
}
