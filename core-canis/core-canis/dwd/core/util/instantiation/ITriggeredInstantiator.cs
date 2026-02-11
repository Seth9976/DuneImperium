using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace dwd.core.util.instantiation
{
	// Token: 0x0200009D RID: 157
	public class ITriggeredInstantiator : Il2CppObjectBase
	{
		// Token: 0x06000AAE RID: 2734 RVA: 0x0003C1A4 File Offset: 0x0003A3A4
		// Note: this type is marked as 'beforefieldinit'.
		static ITriggeredInstantiator()
		{
			Il2CppClassPointerStore<ITriggeredInstantiator>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.util.instantiation", "ITriggeredInstantiator");
			ITriggeredInstantiator.NativeMethodInfoPtr_Instantiate_Public_Abstract_Virtual_New_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITriggeredInstantiator>.NativeClassPtr, 100664776);
			ITriggeredInstantiator.NativeMethodInfoPtr_Instantiate_Public_Abstract_Virtual_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITriggeredInstantiator>.NativeClassPtr, 100664777);
			ITriggeredInstantiator.NativeMethodInfoPtr_Instantiate_Public_Abstract_Virtual_New_Void_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITriggeredInstantiator>.NativeClassPtr, 100664778);
			ITriggeredInstantiator.NativeMethodInfoPtr_DestroyInstance_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITriggeredInstantiator>.NativeClassPtr, 100664779);
			ITriggeredInstantiator.NativeMethodInfoPtr_get_Instantiated_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITriggeredInstantiator>.NativeClassPtr, 100664780);
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x0003C230 File Offset: 0x0003A430
		[CallerCount(0)]
		public unsafe virtual GameObject Instantiate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITriggeredInstantiator.NativeMethodInfoPtr_Instantiate_Public_Abstract_Virtual_New_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x0003C27C File Offset: 0x0003A47C
		[CallerCount(0)]
		public unsafe virtual T Instantiate<T>() where T : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITriggeredInstantiator.MethodInfoStoreGeneric_Instantiate_Public_Abstract_Virtual_New_T_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x0003C2C0 File Offset: 0x0003A4C0
		[CallerCount(0)]
		public unsafe virtual void Instantiate<T>(out T component) where T : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				IntPtr intPtr2;
				if (!typeof(T).IsValueType)
				{
					intPtr = 0;
					intPtr2 = &intPtr;
				}
				else
				{
					intPtr2 = ref component;
				}
				ptr2 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITriggeredInstantiator.MethodInfoStoreGeneric_Instantiate_Public_Abstract_Virtual_New_Void_byref_T_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					component = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
			}
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x0003C348 File Offset: 0x0003A548
		[CallerCount(0)]
		public unsafe virtual void DestroyInstance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITriggeredInstantiator.NativeMethodInfoPtr_DestroyInstance_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x0003C384 File Offset: 0x0003A584
		public unsafe virtual bool Instantiated
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITriggeredInstantiator.NativeMethodInfoPtr_get_Instantiated_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00005D09 File Offset: 0x00003F09
		public ITriggeredInstantiator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007CC RID: 1996
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Abstract_Virtual_New_GameObject_0;

		// Token: 0x040007CD RID: 1997
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Abstract_Virtual_New_T_0;

		// Token: 0x040007CE RID: 1998
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Abstract_Virtual_New_Void_byref_T_0;

		// Token: 0x040007CF RID: 1999
		private static readonly IntPtr NativeMethodInfoPtr_DestroyInstance_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040007D0 RID: 2000
		private static readonly IntPtr NativeMethodInfoPtr_get_Instantiated_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x02000292 RID: 658
		private sealed class MethodInfoStoreGeneric_Instantiate_Public_Abstract_Virtual_New_T_0<T>
		{
			// Token: 0x0400160E RID: 5646
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ITriggeredInstantiator.NativeMethodInfoPtr_Instantiate_Public_Abstract_Virtual_New_T_0, Il2CppClassPointerStore<ITriggeredInstantiator>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000293 RID: 659
		private sealed class MethodInfoStoreGeneric_Instantiate_Public_Abstract_Virtual_New_Void_byref_T_0<T>
		{
			// Token: 0x0400160F RID: 5647
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ITriggeredInstantiator.NativeMethodInfoPtr_Instantiate_Public_Abstract_Virtual_New_Void_byref_T_0, Il2CppClassPointerStore<ITriggeredInstantiator>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
