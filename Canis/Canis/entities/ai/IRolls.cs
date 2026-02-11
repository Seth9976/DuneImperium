using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.entities.ai
{
	// Token: 0x0200010B RID: 267
	public class IRolls<T> : Il2CppObjectBase
	{
		// Token: 0x06000C17 RID: 3095 RVA: 0x0004D598 File Offset: 0x0004B798
		// Note: this type is marked as 'beforefieldinit'.
		static IRolls()
		{
			Il2CppClassPointerStore<IRolls<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities.ai", "IRolls`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IRolls<T>.NativeMethodInfoPtr_Roll_Public_Abstract_Virtual_New_IEnumerable_1_T_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRolls<T>>.NativeClassPtr, 100665910);
			IRolls<T>.NativeMethodInfoPtr_All_Public_Abstract_Virtual_New_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRolls<T>>.NativeClassPtr, 100665911);
			IRolls<T>.NativeMethodInfoPtr_Filtered_Public_Abstract_Virtual_New_IRolls_1_T_Func_2_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRolls<T>>.NativeClassPtr, 100665912);
			IRolls<T>.NativeMethodInfoPtr_Scaled_Public_Abstract_Virtual_New_IRolls_1_T_Func_2_T_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRolls<T>>.NativeClassPtr, 100665913);
			IRolls<T>.NativeMethodInfoPtr_Rekeyed_Public_Abstract_Virtual_New_IRolls_1_T_Func_2_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRolls<T>>.NativeClassPtr, 100665914);
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x0004D660 File Offset: 0x0004B860
		[CallerCount(0)]
		public unsafe virtual IEnumerable<T> Roll(Random random)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(random);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRolls<T>.NativeMethodInfoPtr_Roll_Public_Abstract_Virtual_New_IEnumerable_1_T_Random_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x0004D6BC File Offset: 0x0004B8BC
		[CallerCount(0)]
		public unsafe virtual IEnumerable<T> All()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRolls<T>.NativeMethodInfoPtr_All_Public_Abstract_Virtual_New_IEnumerable_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x0004D708 File Offset: 0x0004B908
		[CallerCount(0)]
		public unsafe virtual IRolls<T> Filtered(Func<T, bool> predicate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRolls<T>.NativeMethodInfoPtr_Filtered_Public_Abstract_Virtual_New_IRolls_1_T_Func_2_T_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRolls<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x0004D764 File Offset: 0x0004B964
		[CallerCount(0)]
		public unsafe virtual IRolls<T> Scaled(Func<T, double> scaling)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scaling);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRolls<T>.NativeMethodInfoPtr_Scaled_Public_Abstract_Virtual_New_IRolls_1_T_Func_2_T_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRolls<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x0004D7C0 File Offset: 0x0004B9C0
		[CallerCount(0)]
		public unsafe virtual IRolls<T> Rekeyed(Func<T, T> rekeyer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rekeyer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRolls<T>.NativeMethodInfoPtr_Rekeyed_Public_Abstract_Virtual_New_IRolls_1_T_Func_2_T_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRolls<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x000064C3 File Offset: 0x000046C3
		public IRolls(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400084E RID: 2126
		private static readonly IntPtr NativeMethodInfoPtr_Roll_Public_Abstract_Virtual_New_IEnumerable_1_T_Random_0;

		// Token: 0x0400084F RID: 2127
		private static readonly IntPtr NativeMethodInfoPtr_All_Public_Abstract_Virtual_New_IEnumerable_1_T_0;

		// Token: 0x04000850 RID: 2128
		private static readonly IntPtr NativeMethodInfoPtr_Filtered_Public_Abstract_Virtual_New_IRolls_1_T_Func_2_T_Boolean_0;

		// Token: 0x04000851 RID: 2129
		private static readonly IntPtr NativeMethodInfoPtr_Scaled_Public_Abstract_Virtual_New_IRolls_1_T_Func_2_T_Double_0;

		// Token: 0x04000852 RID: 2130
		private static readonly IntPtr NativeMethodInfoPtr_Rekeyed_Public_Abstract_Virtual_New_IRolls_1_T_Func_2_T_T_0;
	}
}
