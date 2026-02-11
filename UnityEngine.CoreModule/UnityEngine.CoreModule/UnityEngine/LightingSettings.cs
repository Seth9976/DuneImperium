using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000088 RID: 136
	public sealed class LightingSettings : Object
	{
		// Token: 0x06000772 RID: 1906 RVA: 0x0002EEB0 File Offset: 0x0002D0B0
		// Note: this type is marked as 'beforefieldinit'.
		static LightingSettings()
		{
			Il2CppClassPointerStore<LightingSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LightingSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightingSettings>.NativeClassPtr);
			LightingSettings.NativeMethodInfoPtr_LightingSettingsDontStripMe_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingSettings>.NativeClassPtr, 100664229);
			LightingSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingSettings>.NativeClassPtr, 100664230);
			LightingSettings.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_LightingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingSettings>.NativeClassPtr, 100664231);
			LightingSettings.NativeMethodInfoPtr_get_bakedGI_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingSettings>.NativeClassPtr, 100664232);
			LightingSettings.NativeMethodInfoPtr_set_bakedGI_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingSettings>.NativeClassPtr, 100664233);
			LightingSettings.NativeMethodInfoPtr_get_realtimeGI_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingSettings>.NativeClassPtr, 100664234);
			LightingSettings.NativeMethodInfoPtr_set_realtimeGI_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingSettings>.NativeClassPtr, 100664235);
			LightingSettings.NativeMethodInfoPtr_get_realtimeEnvironmentLighting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingSettings>.NativeClassPtr, 100664236);
			LightingSettings.NativeMethodInfoPtr_set_realtimeEnvironmentLighting_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingSettings>.NativeClassPtr, 100664237);
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x0002EF94 File Offset: 0x0002D194
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LightingSettingsDontStripMe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightingSettings.NativeMethodInfoPtr_LightingSettingsDontStripMe_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x0002EFC8 File Offset: 0x0002D1C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649106, XrefRangeEnd = 649112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightingSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightingSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightingSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x0002F004 File Offset: 0x0002D204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649112, XrefRangeEnd = 649114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Create(LightingSettings self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightingSettings.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_LightingSettings_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x0002F03C File Offset: 0x0002D23C
		// (set) Token: 0x06000777 RID: 1911 RVA: 0x0002F078 File Offset: 0x0002D278
		public unsafe bool bakedGI
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649114, XrefRangeEnd = 649116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightingSettings.NativeMethodInfoPtr_get_bakedGI_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649116, XrefRangeEnd = 649118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightingSettings.NativeMethodInfoPtr_set_bakedGI_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x0002F0B8 File Offset: 0x0002D2B8
		// (set) Token: 0x06000779 RID: 1913 RVA: 0x0002F0F4 File Offset: 0x0002D2F4
		public unsafe bool realtimeGI
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649118, XrefRangeEnd = 649120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightingSettings.NativeMethodInfoPtr_get_realtimeGI_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649120, XrefRangeEnd = 649122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightingSettings.NativeMethodInfoPtr_set_realtimeGI_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x0002F134 File Offset: 0x0002D334
		// (set) Token: 0x0600077B RID: 1915 RVA: 0x0002F170 File Offset: 0x0002D370
		public unsafe bool realtimeEnvironmentLighting
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649122, XrefRangeEnd = 649124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightingSettings.NativeMethodInfoPtr_get_realtimeEnvironmentLighting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649124, XrefRangeEnd = 649126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightingSettings.NativeMethodInfoPtr_set_realtimeEnvironmentLighting_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00004CEC File Offset: 0x00002EEC
		public LightingSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000636 RID: 1590
		private static readonly IntPtr NativeMethodInfoPtr_LightingSettingsDontStripMe_Internal_Void_0;

		// Token: 0x04000637 RID: 1591
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000638 RID: 1592
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_LightingSettings_0;

		// Token: 0x04000639 RID: 1593
		private static readonly IntPtr NativeMethodInfoPtr_get_bakedGI_Public_get_Boolean_0;

		// Token: 0x0400063A RID: 1594
		private static readonly IntPtr NativeMethodInfoPtr_set_bakedGI_Public_set_Void_Boolean_0;

		// Token: 0x0400063B RID: 1595
		private static readonly IntPtr NativeMethodInfoPtr_get_realtimeGI_Public_get_Boolean_0;

		// Token: 0x0400063C RID: 1596
		private static readonly IntPtr NativeMethodInfoPtr_set_realtimeGI_Public_set_Void_Boolean_0;

		// Token: 0x0400063D RID: 1597
		private static readonly IntPtr NativeMethodInfoPtr_get_realtimeEnvironmentLighting_Public_get_Boolean_0;

		// Token: 0x0400063E RID: 1598
		private static readonly IntPtr NativeMethodInfoPtr_set_realtimeEnvironmentLighting_Public_set_Void_Boolean_0;
	}
}
