using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Il2CppSystem.Threading.Tasks;
using UnityEngine;

namespace dwd.core.loader
{
	// Token: 0x0200017D RID: 381
	public class IAsyncLoadAssetSource : Il2CppObjectBase
	{
		// Token: 0x060015B4 RID: 5556 RVA: 0x0006AE3C File Offset: 0x0006903C
		// Note: this type is marked as 'beforefieldinit'.
		static IAsyncLoadAssetSource()
		{
			Il2CppClassPointerStore<IAsyncLoadAssetSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader", "IAsyncLoadAssetSource");
			IAsyncLoadAssetSource.NativeMethodInfoPtr_LoadAsync_Public_Abstract_Virtual_New_Task_1_T_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncLoadAssetSource>.NativeClassPtr, 100666579);
			IAsyncLoadAssetSource.NativeMethodInfoPtr_LoadAndInstantiateAsync_Public_Abstract_Virtual_New_Task_1_T_String_Transform_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncLoadAssetSource>.NativeClassPtr, 100666580);
			IAsyncLoadAssetSource.NativeMethodInfoPtr_LoadSpriteAsync_Public_Abstract_Virtual_New_Task_1_Sprite_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncLoadAssetSource>.NativeClassPtr, 100666581);
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x0006AEA0 File Offset: 0x000690A0
		[CallerCount(0)]
		public unsafe virtual Task<T> LoadAsync<T>(string asset, global::Il2CppSystem.Object context) where T : global::UnityEngine.Object
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(asset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncLoadAssetSource.MethodInfoStoreGeneric_LoadAsync_Public_Abstract_Virtual_New_Task_1_T_String_Object_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<T>>(intPtr3) : null;
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x0006AF10 File Offset: 0x00069110
		[CallerCount(0)]
		public unsafe virtual Task<T> LoadAndInstantiateAsync<T>(string asset, Transform parent, bool worldPositionStays, global::Il2CppSystem.Object context) where T : global::UnityEngine.Object
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(asset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPositionStays;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncLoadAssetSource.MethodInfoStoreGeneric_LoadAndInstantiateAsync_Public_Abstract_Virtual_New_Task_1_T_String_Transform_Boolean_Object_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<T>>(intPtr3) : null;
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x0006AFA0 File Offset: 0x000691A0
		[CallerCount(0)]
		public unsafe virtual Task<Sprite> LoadSpriteAsync(string asset, string crop, global::Il2CppSystem.Object context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(asset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(crop);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncLoadAssetSource.NativeMethodInfoPtr_LoadSpriteAsync_Public_Abstract_Virtual_New_Task_1_Sprite_String_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Sprite>>(intPtr3) : null;
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x000098A0 File Offset: 0x00007AA0
		public IAsyncLoadAssetSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F69 RID: 3945
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsync_Public_Abstract_Virtual_New_Task_1_T_String_Object_0;

		// Token: 0x04000F6A RID: 3946
		private static readonly IntPtr NativeMethodInfoPtr_LoadAndInstantiateAsync_Public_Abstract_Virtual_New_Task_1_T_String_Transform_Boolean_Object_0;

		// Token: 0x04000F6B RID: 3947
		private static readonly IntPtr NativeMethodInfoPtr_LoadSpriteAsync_Public_Abstract_Virtual_New_Task_1_Sprite_String_String_Object_0;

		// Token: 0x020002FD RID: 765
		private sealed class MethodInfoStoreGeneric_LoadAsync_Public_Abstract_Virtual_New_Task_1_T_String_Object_0<T>
		{
			// Token: 0x0400182F RID: 6191
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IAsyncLoadAssetSource.NativeMethodInfoPtr_LoadAsync_Public_Abstract_Virtual_New_Task_1_T_String_Object_0, Il2CppClassPointerStore<IAsyncLoadAssetSource>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020002FE RID: 766
		private sealed class MethodInfoStoreGeneric_LoadAndInstantiateAsync_Public_Abstract_Virtual_New_Task_1_T_String_Transform_Boolean_Object_0<T>
		{
			// Token: 0x04001830 RID: 6192
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IAsyncLoadAssetSource.NativeMethodInfoPtr_LoadAndInstantiateAsync_Public_Abstract_Virtual_New_Task_1_T_String_Transform_Boolean_Object_0, Il2CppClassPointerStore<IAsyncLoadAssetSource>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
