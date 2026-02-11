using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization
{
	// Token: 0x02000010 RID: 16
	public class LocalizedAssetBase : LocalizedReference
	{
		// Token: 0x0600008A RID: 138 RVA: 0x0000AEB0 File Offset: 0x000090B0
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizedAssetBase()
		{
			Il2CppClassPointerStore<LocalizedAssetBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization", "LocalizedAssetBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedAssetBase>.NativeClassPtr);
			LocalizedAssetBase.NativeMethodInfoPtr_LoadAssetAsObjectAsync_Public_Abstract_Virtual_New_AsyncOperationHandle_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAssetBase>.NativeClassPtr, 100663390);
			LocalizedAssetBase.NativeMethodInfoPtr_LoadAssetAsync_Public_Abstract_Virtual_New_AsyncOperationHandle_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAssetBase>.NativeClassPtr, 100663391);
			LocalizedAssetBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAssetBase>.NativeClassPtr, 100663392);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000AF1C File Offset: 0x0000911C
		[CallerCount(0)]
		public unsafe virtual AsyncOperationHandle<Object> LoadAssetAsObjectAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedAssetBase.NativeMethodInfoPtr_LoadAssetAsObjectAsync_Public_Abstract_Virtual_New_AsyncOperationHandle_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<Object>(intPtr);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000AF60 File Offset: 0x00009160
		[CallerCount(0)]
		public unsafe virtual AsyncOperationHandle<TObject> LoadAssetAsync<TObject>() where TObject : Object
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedAssetBase.MethodInfoStoreGeneric_LoadAssetAsync_Public_Abstract_Virtual_New_AsyncOperationHandle_1_TObject_0<TObject>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<TObject>(intPtr);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000AFA4 File Offset: 0x000091A4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizedAssetBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedAssetBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAssetBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000244F File Offset: 0x0000064F
		public LocalizedAssetBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetAsObjectAsync_Public_Abstract_Virtual_New_AsyncOperationHandle_1_Object_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetAsync_Public_Abstract_Virtual_New_AsyncOperationHandle_1_TObject_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0200010F RID: 271
		private sealed class MethodInfoStoreGeneric_LoadAssetAsync_Public_Abstract_Virtual_New_AsyncOperationHandle_1_TObject_0<TObject>
		{
			// Token: 0x040008D0 RID: 2256
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LocalizedAssetBase.NativeMethodInfoPtr_LoadAssetAsync_Public_Abstract_Virtual_New_AsyncOperationHandle_1_TObject_0, Il2CppClassPointerStore<LocalizedAssetBase>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}
	}
}
