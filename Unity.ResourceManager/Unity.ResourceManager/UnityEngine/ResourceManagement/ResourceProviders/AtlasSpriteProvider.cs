using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	// Token: 0x02000032 RID: 50
	public class AtlasSpriteProvider : ResourceProviderBase
	{
		// Token: 0x060002CD RID: 717 RVA: 0x0000F950 File Offset: 0x0000DB50
		// Note: this type is marked as 'beforefieldinit'.
		static AtlasSpriteProvider()
		{
			Il2CppClassPointerStore<AtlasSpriteProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.ResourceProviders", "AtlasSpriteProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AtlasSpriteProvider>.NativeClassPtr);
			AtlasSpriteProvider.NativeMethodInfoPtr_Provide_Public_Virtual_Void_ProvideHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasSpriteProvider>.NativeClassPtr, 100663743);
			AtlasSpriteProvider.NativeMethodInfoPtr_Release_Public_Virtual_Void_IResourceLocation_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasSpriteProvider>.NativeClassPtr, 100663744);
			AtlasSpriteProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasSpriteProvider>.NativeClassPtr, 100663745);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0000F9BC File Offset: 0x0000DBBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139883, XrefRangeEnd = 1139934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Provide(ProvideHandle providerInterface)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(providerInterface));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AtlasSpriteProvider.NativeMethodInfoPtr_Provide_Public_Virtual_Void_ProvideHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0000FA10 File Offset: 0x0000DC10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139934, XrefRangeEnd = 1139940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Release(IResourceLocation location, Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AtlasSpriteProvider.NativeMethodInfoPtr_Release_Public_Virtual_Void_IResourceLocation_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0000FA70 File Offset: 0x0000DC70
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AtlasSpriteProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AtlasSpriteProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtlasSpriteProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00003287 File Offset: 0x00001487
		public AtlasSpriteProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeMethodInfoPtr_Provide_Public_Virtual_Void_ProvideHandle_0;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Virtual_Void_IResourceLocation_Object_0;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
