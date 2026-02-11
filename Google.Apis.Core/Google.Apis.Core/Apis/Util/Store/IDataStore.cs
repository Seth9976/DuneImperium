using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Util.Store
{
	// Token: 0x02000010 RID: 16
	public class IDataStore : Il2CppObjectBase
	{
		// Token: 0x06000073 RID: 115 RVA: 0x00005D20 File Offset: 0x00003F20
		// Note: this type is marked as 'beforefieldinit'.
		static IDataStore()
		{
			Il2CppClassPointerStore<IDataStore>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Util.Store", "IDataStore");
			IDataStore.NativeMethodInfoPtr_StoreAsync_Public_Abstract_Virtual_New_Task_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDataStore>.NativeClassPtr, 100663358);
			IDataStore.NativeMethodInfoPtr_DeleteAsync_Public_Abstract_Virtual_New_Task_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDataStore>.NativeClassPtr, 100663359);
			IDataStore.NativeMethodInfoPtr_GetAsync_Public_Abstract_Virtual_New_Task_1_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDataStore>.NativeClassPtr, 100663360);
			IDataStore.NativeMethodInfoPtr_ClearAsync_Public_Abstract_Virtual_New_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDataStore>.NativeClassPtr, 100663361);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00005D98 File Offset: 0x00003F98
		[CallerCount(0)]
		public unsafe virtual Task StoreAsync<T>(string key, T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDataStore.MethodInfoStoreGeneric_StoreAsync_Public_Abstract_Virtual_New_Task_String_T_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<Task>(intPtr4) : null;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00005E3C File Offset: 0x0000403C
		[CallerCount(0)]
		public unsafe virtual Task DeleteAsync<T>(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDataStore.MethodInfoStoreGeneric_DeleteAsync_Public_Abstract_Virtual_New_Task_String_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00005E98 File Offset: 0x00004098
		[CallerCount(0)]
		public unsafe virtual Task<T> GetAsync<T>(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDataStore.MethodInfoStoreGeneric_GetAsync_Public_Abstract_Virtual_New_Task_1_T_String_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00005EF4 File Offset: 0x000040F4
		[CallerCount(0)]
		public unsafe virtual Task ClearAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDataStore.NativeMethodInfoPtr_ClearAsync_Public_Abstract_Virtual_New_Task_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002275 File Offset: 0x00000475
		public IDataStore(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_StoreAsync_Public_Abstract_Virtual_New_Task_String_T_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_DeleteAsync_Public_Abstract_Virtual_New_Task_String_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_GetAsync_Public_Abstract_Virtual_New_Task_1_T_String_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_ClearAsync_Public_Abstract_Virtual_New_Task_0;

		// Token: 0x02000046 RID: 70
		private sealed class MethodInfoStoreGeneric_StoreAsync_Public_Abstract_Virtual_New_Task_String_T_0<T>
		{
			// Token: 0x040001D6 RID: 470
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IDataStore.NativeMethodInfoPtr_StoreAsync_Public_Abstract_Virtual_New_Task_String_T_0, Il2CppClassPointerStore<IDataStore>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000047 RID: 71
		private sealed class MethodInfoStoreGeneric_DeleteAsync_Public_Abstract_Virtual_New_Task_String_0<T>
		{
			// Token: 0x040001D7 RID: 471
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IDataStore.NativeMethodInfoPtr_DeleteAsync_Public_Abstract_Virtual_New_Task_String_0, Il2CppClassPointerStore<IDataStore>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000048 RID: 72
		private sealed class MethodInfoStoreGeneric_GetAsync_Public_Abstract_Virtual_New_Task_1_T_String_0<T>
		{
			// Token: 0x040001D8 RID: 472
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IDataStore.NativeMethodInfoPtr_GetAsync_Public_Abstract_Virtual_New_Task_1_T_String_0, Il2CppClassPointerStore<IDataStore>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
