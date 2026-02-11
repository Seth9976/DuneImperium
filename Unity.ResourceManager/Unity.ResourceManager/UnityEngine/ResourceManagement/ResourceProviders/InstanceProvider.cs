using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	// Token: 0x02000038 RID: 56
	public class InstanceProvider : Object
	{
		// Token: 0x060002FC RID: 764 RVA: 0x00010508 File Offset: 0x0000E708
		// Note: this type is marked as 'beforefieldinit'.
		static InstanceProvider()
		{
			Il2CppClassPointerStore<InstanceProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.ResourceProviders", "InstanceProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstanceProvider>.NativeClassPtr);
			InstanceProvider.NativeFieldInfoPtr_m_InstanceObjectToPrefabHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceProvider>.NativeClassPtr, "m_InstanceObjectToPrefabHandle");
			InstanceProvider.NativeMethodInfoPtr_ProvideInstance_Public_Virtual_Final_New_GameObject_ResourceManager_AsyncOperationHandle_1_GameObject_InstantiationParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceProvider>.NativeClassPtr, 100663787);
			InstanceProvider.NativeMethodInfoPtr_ReleaseInstance_Public_Virtual_Final_New_Void_ResourceManager_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceProvider>.NativeClassPtr, 100663788);
			InstanceProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceProvider>.NativeClassPtr, 100663789);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00010588 File Offset: 0x0000E788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140432, XrefRangeEnd = 1140441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GameObject ProvideInstance(ResourceManager resourceManager, AsyncOperationHandle<GameObject> prefabHandle, InstantiationParameters instantiateParameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resourceManager);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(prefabHandle));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(instantiateParameters));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceProvider.NativeMethodInfoPtr_ProvideInstance_Public_Virtual_Final_New_GameObject_ResourceManager_AsyncOperationHandle_1_GameObject_InstantiationParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00010608 File Offset: 0x0000E808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140441, XrefRangeEnd = 1140473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReleaseInstance(ResourceManager resourceManager, GameObject instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resourceManager);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceProvider.NativeMethodInfoPtr_ReleaseInstance_Public_Virtual_Final_New_Void_ResourceManager_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0001065C File Offset: 0x0000E85C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140473, XrefRangeEnd = 1140481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InstanceProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstanceProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00003375 File Offset: 0x00001575
		public InstanceProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000301 RID: 769 RVA: 0x00010698 File Offset: 0x0000E898
		// (set) Token: 0x06000302 RID: 770 RVA: 0x0000337E File Offset: 0x0000157E
		public unsafe Dictionary<GameObject, AsyncOperationHandle<GameObject>> m_InstanceObjectToPrefabHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstanceProvider.NativeFieldInfoPtr_m_InstanceObjectToPrefabHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<GameObject, AsyncOperationHandle<GameObject>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstanceProvider.NativeFieldInfoPtr_m_InstanceObjectToPrefabHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeFieldInfoPtr_m_InstanceObjectToPrefabHandle;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeMethodInfoPtr_ProvideInstance_Public_Virtual_Final_New_GameObject_ResourceManager_AsyncOperationHandle_1_GameObject_InstantiationParameters_0;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseInstance_Public_Virtual_Final_New_Void_ResourceManager_GameObject_0;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
