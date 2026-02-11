using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	// Token: 0x0200003B RID: 59
	public class IResourceProvider : Il2CppObjectBase
	{
		// Token: 0x06000319 RID: 793 RVA: 0x00010CC8 File Offset: 0x0000EEC8
		// Note: this type is marked as 'beforefieldinit'.
		static IResourceProvider()
		{
			Il2CppClassPointerStore<IResourceProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.ResourceProviders", "IResourceProvider");
			IResourceProvider.NativeMethodInfoPtr_get_ProviderId_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IResourceProvider>.NativeClassPtr, 100663803);
			IResourceProvider.NativeMethodInfoPtr_GetDefaultType_Public_Abstract_Virtual_New_Type_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IResourceProvider>.NativeClassPtr, 100663804);
			IResourceProvider.NativeMethodInfoPtr_CanProvide_Public_Abstract_Virtual_New_Boolean_Type_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IResourceProvider>.NativeClassPtr, 100663805);
			IResourceProvider.NativeMethodInfoPtr_Provide_Public_Abstract_Virtual_New_Void_ProvideHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IResourceProvider>.NativeClassPtr, 100663806);
			IResourceProvider.NativeMethodInfoPtr_Release_Public_Abstract_Virtual_New_Void_IResourceLocation_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IResourceProvider>.NativeClassPtr, 100663807);
			IResourceProvider.NativeMethodInfoPtr_get_BehaviourFlags_Public_Abstract_Virtual_New_get_ProviderBehaviourFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IResourceProvider>.NativeClassPtr, 100663808);
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600031A RID: 794 RVA: 0x00010D68 File Offset: 0x0000EF68
		public unsafe virtual string ProviderId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IResourceProvider.NativeMethodInfoPtr_get_ProviderId_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00010DAC File Offset: 0x0000EFAC
		[CallerCount(0)]
		public unsafe virtual Type GetDefaultType(IResourceLocation location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IResourceProvider.NativeMethodInfoPtr_GetDefaultType_Public_Abstract_Virtual_New_Type_IResourceLocation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00010E08 File Offset: 0x0000F008
		[CallerCount(0)]
		public unsafe virtual bool CanProvide(Type type, IResourceLocation location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(location);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IResourceProvider.NativeMethodInfoPtr_CanProvide_Public_Abstract_Virtual_New_Boolean_Type_IResourceLocation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00010E74 File Offset: 0x0000F074
		[CallerCount(0)]
		public unsafe virtual void Provide(ProvideHandle provideHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(provideHandle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IResourceProvider.NativeMethodInfoPtr_Provide_Public_Abstract_Virtual_New_Void_ProvideHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00010EC8 File Offset: 0x0000F0C8
		[CallerCount(0)]
		public unsafe virtual void Release(IResourceLocation location, Object asset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IResourceProvider.NativeMethodInfoPtr_Release_Public_Abstract_Virtual_New_Void_IResourceLocation_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600031F RID: 799 RVA: 0x00010F28 File Offset: 0x0000F128
		public unsafe virtual ProviderBehaviourFlags BehaviourFlags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IResourceProvider.NativeMethodInfoPtr_get_BehaviourFlags_Public_Abstract_Virtual_New_get_ProviderBehaviourFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00003411 File Offset: 0x00001611
		public IResourceProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr_get_ProviderId_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultType_Public_Abstract_Virtual_New_Type_IResourceLocation_0;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeMethodInfoPtr_CanProvide_Public_Abstract_Virtual_New_Boolean_Type_IResourceLocation_0;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeMethodInfoPtr_Provide_Public_Abstract_Virtual_New_Void_ProvideHandle_0;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Abstract_Virtual_New_Void_IResourceLocation_Object_0;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeMethodInfoPtr_get_BehaviourFlags_Public_Abstract_Virtual_New_get_ProviderBehaviourFlags_0;
	}
}
