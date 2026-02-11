using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace dwd.core.loader
{
	// Token: 0x0200017C RID: 380
	public class ISyncLoadAssetSource : Il2CppObjectBase
	{
		// Token: 0x060015AF RID: 5551 RVA: 0x0006AC68 File Offset: 0x00068E68
		// Note: this type is marked as 'beforefieldinit'.
		static ISyncLoadAssetSource()
		{
			Il2CppClassPointerStore<ISyncLoadAssetSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader", "ISyncLoadAssetSource");
			ISyncLoadAssetSource.NativeMethodInfoPtr_LoadSync_Public_Abstract_Virtual_New_T_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISyncLoadAssetSource>.NativeClassPtr, 100666576);
			ISyncLoadAssetSource.NativeMethodInfoPtr_LoadAndInstantiateSync_Public_Abstract_Virtual_New_T_String_Transform_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISyncLoadAssetSource>.NativeClassPtr, 100666577);
			ISyncLoadAssetSource.NativeMethodInfoPtr_LoadSprite_Public_Abstract_Virtual_New_Sprite_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISyncLoadAssetSource>.NativeClassPtr, 100666578);
		}

		// Token: 0x060015B0 RID: 5552 RVA: 0x0006ACCC File Offset: 0x00068ECC
		[CallerCount(0)]
		public unsafe virtual T LoadSync<T>(string asset, global::Il2CppSystem.Object context) where T : global::UnityEngine.Object
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISyncLoadAssetSource.MethodInfoStoreGeneric_LoadSync_Public_Abstract_Virtual_New_T_String_Object_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x0006AD34 File Offset: 0x00068F34
		[CallerCount(0)]
		public unsafe virtual T LoadAndInstantiateSync<T>(string asset, Transform parent, bool worldPositionStays, global::Il2CppSystem.Object context) where T : global::UnityEngine.Object
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISyncLoadAssetSource.MethodInfoStoreGeneric_LoadAndInstantiateSync_Public_Abstract_Virtual_New_T_String_Transform_Boolean_Object_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x0006ADBC File Offset: 0x00068FBC
		[CallerCount(0)]
		public unsafe virtual Sprite LoadSprite(string asset, string crop, global::Il2CppSystem.Object context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISyncLoadAssetSource.NativeMethodInfoPtr_LoadSprite_Public_Abstract_Virtual_New_Sprite_String_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x00009897 File Offset: 0x00007A97
		public ISyncLoadAssetSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F66 RID: 3942
		private static readonly IntPtr NativeMethodInfoPtr_LoadSync_Public_Abstract_Virtual_New_T_String_Object_0;

		// Token: 0x04000F67 RID: 3943
		private static readonly IntPtr NativeMethodInfoPtr_LoadAndInstantiateSync_Public_Abstract_Virtual_New_T_String_Transform_Boolean_Object_0;

		// Token: 0x04000F68 RID: 3944
		private static readonly IntPtr NativeMethodInfoPtr_LoadSprite_Public_Abstract_Virtual_New_Sprite_String_String_Object_0;

		// Token: 0x020002FB RID: 763
		private sealed class MethodInfoStoreGeneric_LoadSync_Public_Abstract_Virtual_New_T_String_Object_0<T>
		{
			// Token: 0x0400182D RID: 6189
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ISyncLoadAssetSource.NativeMethodInfoPtr_LoadSync_Public_Abstract_Virtual_New_T_String_Object_0, Il2CppClassPointerStore<ISyncLoadAssetSource>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020002FC RID: 764
		private sealed class MethodInfoStoreGeneric_LoadAndInstantiateSync_Public_Abstract_Virtual_New_T_String_Transform_Boolean_Object_0<T>
		{
			// Token: 0x0400182E RID: 6190
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ISyncLoadAssetSource.NativeMethodInfoPtr_LoadAndInstantiateSync_Public_Abstract_Virtual_New_T_String_Transform_Boolean_Object_0, Il2CppClassPointerStore<ISyncLoadAssetSource>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
