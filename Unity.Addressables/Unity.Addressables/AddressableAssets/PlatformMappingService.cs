using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.AddressableAssets
{
	// Token: 0x0200001A RID: 26
	public class PlatformMappingService : Object
	{
		// Token: 0x06000228 RID: 552 RVA: 0x0000EDC8 File Offset: 0x0000CFC8
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformMappingService()
		{
			Il2CppClassPointerStore<PlatformMappingService>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Addressables.dll", "UnityEngine.AddressableAssets", "PlatformMappingService");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformMappingService>.NativeClassPtr);
			PlatformMappingService.NativeFieldInfoPtr_s_RuntimeTargetMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformMappingService>.NativeClassPtr, "s_RuntimeTargetMapping");
			PlatformMappingService.NativeMethodInfoPtr_GetAddressablesPlatformInternal_Internal_Static_AddressablesPlatform_RuntimePlatform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformMappingService>.NativeClassPtr, 100663759);
			PlatformMappingService.NativeMethodInfoPtr_GetAddressablesPlatformPathInternal_Internal_Static_String_RuntimePlatform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformMappingService>.NativeClassPtr, 100663760);
			PlatformMappingService.NativeMethodInfoPtr_GetPlatform_Public_Static_AddressablesPlatform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformMappingService>.NativeClassPtr, 100663761);
			PlatformMappingService.NativeMethodInfoPtr_GetPlatformPathSubFolder_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformMappingService>.NativeClassPtr, 100663762);
			PlatformMappingService.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformMappingService>.NativeClassPtr, 100663763);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0000EE70 File Offset: 0x0000D070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162931, XrefRangeEnd = 1162939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AddressablesPlatform GetAddressablesPlatformInternal(RuntimePlatform platform)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref platform;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformMappingService.NativeMethodInfoPtr_GetAddressablesPlatformInternal_Internal_Static_AddressablesPlatform_RuntimePlatform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000EEB0 File Offset: 0x0000D0B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162939, XrefRangeEnd = 1162951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetAddressablesPlatformPathInternal(RuntimePlatform platform)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref platform;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformMappingService.NativeMethodInfoPtr_GetAddressablesPlatformPathInternal_Internal_Static_String_RuntimePlatform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000EEE8 File Offset: 0x0000D0E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162951, XrefRangeEnd = 1162966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AddressablesPlatform GetPlatform()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformMappingService.NativeMethodInfoPtr_GetPlatform_Public_Static_AddressablesPlatform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000EF18 File Offset: 0x0000D118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162966, XrefRangeEnd = 1162992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetPlatformPathSubFolder()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformMappingService.NativeMethodInfoPtr_GetPlatformPathSubFolder_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0000EF44 File Offset: 0x0000D144
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformMappingService()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformMappingService>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformMappingService.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x000029E2 File Offset: 0x00000BE2
		public PlatformMappingService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600022F RID: 559 RVA: 0x0000EF80 File Offset: 0x0000D180
		// (set) Token: 0x06000230 RID: 560 RVA: 0x000029EB File Offset: 0x00000BEB
		public unsafe static Dictionary<RuntimePlatform, AddressablesPlatform> s_RuntimeTargetMapping
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlatformMappingService.NativeFieldInfoPtr_s_RuntimeTargetMapping, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<RuntimePlatform, AddressablesPlatform>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformMappingService.NativeFieldInfoPtr_s_RuntimeTargetMapping, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeFieldInfoPtr_s_RuntimeTargetMapping;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeMethodInfoPtr_GetAddressablesPlatformInternal_Internal_Static_AddressablesPlatform_RuntimePlatform_0;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeMethodInfoPtr_GetAddressablesPlatformPathInternal_Internal_Static_String_RuntimePlatform_0;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeMethodInfoPtr_GetPlatform_Public_Static_AddressablesPlatform_0;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeMethodInfoPtr_GetPlatformPathSubFolder_Public_Static_String_0;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
