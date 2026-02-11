using System;
using dwd.core.input.compositeModule.activation;
using dwd.core.input.compositeModule.inputDetection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames
{
	// Token: 0x020000FC RID: 252
	public class ActivateModuleOnControllerEnabledPref : ModuleActivator
	{
		// Token: 0x06000C16 RID: 3094 RVA: 0x000377F4 File Offset: 0x000359F4
		// Note: this type is marked as 'beforefieldinit'.
		static ActivateModuleOnControllerEnabledPref()
		{
			Il2CppClassPointerStore<ActivateModuleOnControllerEnabledPref>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames", "ActivateModuleOnControllerEnabledPref");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivateModuleOnControllerEnabledPref>.NativeClassPtr);
			ActivateModuleOnControllerEnabledPref.NativeMethodInfoPtr_shouldModuleActivate_Protected_Virtual_Boolean_InputDetector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateModuleOnControllerEnabledPref>.NativeClassPtr, 100665227);
			ActivateModuleOnControllerEnabledPref.NativeMethodInfoPtr_Activated_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateModuleOnControllerEnabledPref>.NativeClassPtr, 100665228);
			ActivateModuleOnControllerEnabledPref.NativeMethodInfoPtr_Deactivated_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateModuleOnControllerEnabledPref>.NativeClassPtr, 100665229);
			ActivateModuleOnControllerEnabledPref.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateModuleOnControllerEnabledPref>.NativeClassPtr, 100665230);
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x00037874 File Offset: 0x00035A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995336, XrefRangeEnd = 995343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool shouldModuleActivate(InputDetector inputDetector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDetector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActivateModuleOnControllerEnabledPref.NativeMethodInfoPtr_shouldModuleActivate_Protected_Virtual_Boolean_InputDetector_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x000378CC File Offset: 0x00035ACC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Activated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActivateModuleOnControllerEnabledPref.NativeMethodInfoPtr_Activated_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x00037908 File Offset: 0x00035B08
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Deactivated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActivateModuleOnControllerEnabledPref.NativeMethodInfoPtr_Deactivated_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x00037944 File Offset: 0x00035B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995343, XrefRangeEnd = 995344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActivateModuleOnControllerEnabledPref()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivateModuleOnControllerEnabledPref>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivateModuleOnControllerEnabledPref.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x0000791D File Offset: 0x00005B1D
		public ActivateModuleOnControllerEnabledPref(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000771 RID: 1905
		private static readonly IntPtr NativeMethodInfoPtr_shouldModuleActivate_Protected_Virtual_Boolean_InputDetector_0;

		// Token: 0x04000772 RID: 1906
		private static readonly IntPtr NativeMethodInfoPtr_Activated_Public_Virtual_Void_0;

		// Token: 0x04000773 RID: 1907
		private static readonly IntPtr NativeMethodInfoPtr_Deactivated_Public_Virtual_Void_0;

		// Token: 0x04000774 RID: 1908
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
