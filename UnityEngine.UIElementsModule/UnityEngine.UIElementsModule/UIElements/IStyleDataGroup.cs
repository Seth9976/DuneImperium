using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000189 RID: 393
	public class IStyleDataGroup<T> : Il2CppObjectBase
	{
		// Token: 0x060020A6 RID: 8358 RVA: 0x00094380 File Offset: 0x00092580
		// Note: this type is marked as 'beforefieldinit'.
		static IStyleDataGroup()
		{
			Il2CppClassPointerStore<IStyleDataGroup<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IStyleDataGroup`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IStyleDataGroup<T>.NativeMethodInfoPtr_Copy_Public_Abstract_Virtual_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStyleDataGroup<T>>.NativeClassPtr, 100668154);
			IStyleDataGroup<T>.NativeMethodInfoPtr_CopyFrom_Public_Abstract_Virtual_New_Void_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStyleDataGroup<T>>.NativeClassPtr, 100668155);
		}

		// Token: 0x060020A7 RID: 8359 RVA: 0x0009440C File Offset: 0x0009260C
		[CallerCount(0)]
		public unsafe virtual T Copy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStyleDataGroup<T>.NativeMethodInfoPtr_Copy_Public_Abstract_Virtual_New_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060020A8 RID: 8360 RVA: 0x00094450 File Offset: 0x00092650
		[CallerCount(0)]
		public unsafe virtual void CopyFrom(ref T other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(other);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStyleDataGroup<T>.NativeMethodInfoPtr_CopyFrom_Public_Abstract_Virtual_New_Void_byref_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				other = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			}
		}

		// Token: 0x060020A9 RID: 8361 RVA: 0x0000DA99 File Offset: 0x0000BC99
		public IStyleDataGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040016AA RID: 5802
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Abstract_Virtual_New_T_0;

		// Token: 0x040016AB RID: 5803
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Abstract_Virtual_New_Void_byref_T_0;
	}
}
