using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000104 RID: 260
	public static class PlatformAutoDetect : Object
	{
		// Token: 0x060015B3 RID: 5555 RVA: 0x0005D7C8 File Offset: 0x0005B9C8
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformAutoDetect()
		{
			Il2CppClassPointerStore<PlatformAutoDetect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "PlatformAutoDetect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformAutoDetect>.NativeClassPtr);
			PlatformAutoDetect.NativeFieldInfoPtr__isXRMobile_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformAutoDetect>.NativeClassPtr, "<isXRMobile>k__BackingField");
			PlatformAutoDetect.NativeFieldInfoPtr__isShaderAPIMobileDefined_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformAutoDetect>.NativeClassPtr, "<isShaderAPIMobileDefined>k__BackingField");
			PlatformAutoDetect.NativeFieldInfoPtr__isSwitch_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformAutoDetect>.NativeClassPtr, "<isSwitch>k__BackingField");
			PlatformAutoDetect.NativeFieldInfoPtr_isRunningOnPowerVRGPU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformAutoDetect>.NativeClassPtr, "isRunningOnPowerVRGPU");
			PlatformAutoDetect.NativeMethodInfoPtr_Initialize_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAutoDetect>.NativeClassPtr, 100665796);
			PlatformAutoDetect.NativeMethodInfoPtr_get_isXRMobile_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAutoDetect>.NativeClassPtr, 100665797);
			PlatformAutoDetect.NativeMethodInfoPtr_set_isXRMobile_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAutoDetect>.NativeClassPtr, 100665798);
			PlatformAutoDetect.NativeMethodInfoPtr_get_isShaderAPIMobileDefined_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAutoDetect>.NativeClassPtr, 100665799);
			PlatformAutoDetect.NativeMethodInfoPtr_set_isShaderAPIMobileDefined_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAutoDetect>.NativeClassPtr, 100665800);
			PlatformAutoDetect.NativeMethodInfoPtr_get_isSwitch_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAutoDetect>.NativeClassPtr, 100665801);
			PlatformAutoDetect.NativeMethodInfoPtr_set_isSwitch_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAutoDetect>.NativeClassPtr, 100665802);
			PlatformAutoDetect.NativeMethodInfoPtr_ShAutoDetect_Internal_Static_ShEvalMode_ShEvalMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAutoDetect>.NativeClassPtr, 100665803);
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x0005D8E8 File Offset: 0x0005BAE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 622729, RefRangeEnd = 622730, XrefRangeStart = 622709, XrefRangeEnd = 622729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAutoDetect.NativeMethodInfoPtr_Initialize_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x060015B5 RID: 5557 RVA: 0x0005D910 File Offset: 0x0005BB10
		// (set) Token: 0x060015B6 RID: 5558 RVA: 0x0005D940 File Offset: 0x0005BB40
		public unsafe static bool isXRMobile
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 622730, XrefRangeEnd = 622734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAutoDetect.NativeMethodInfoPtr_get_isXRMobile_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 622734, XrefRangeEnd = 622738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAutoDetect.NativeMethodInfoPtr_set_isXRMobile_Private_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x060015B7 RID: 5559 RVA: 0x0005D974 File Offset: 0x0005BB74
		// (set) Token: 0x060015B8 RID: 5560 RVA: 0x0005D9A4 File Offset: 0x0005BBA4
		public unsafe static bool isShaderAPIMobileDefined
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 622738, XrefRangeEnd = 622742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAutoDetect.NativeMethodInfoPtr_get_isShaderAPIMobileDefined_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 622742, XrefRangeEnd = 622746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAutoDetect.NativeMethodInfoPtr_set_isShaderAPIMobileDefined_Private_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x060015B9 RID: 5561 RVA: 0x0005D9D8 File Offset: 0x0005BBD8
		// (set) Token: 0x060015BA RID: 5562 RVA: 0x0005DA08 File Offset: 0x0005BC08
		public unsafe static bool isSwitch
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 622746, XrefRangeEnd = 622750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAutoDetect.NativeMethodInfoPtr_get_isSwitch_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 622750, XrefRangeEnd = 622754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAutoDetect.NativeMethodInfoPtr_set_isSwitch_Private_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x0005DA3C File Offset: 0x0005BC3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 622755, RefRangeEnd = 622756, XrefRangeStart = 622754, XrefRangeEnd = 622755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ShEvalMode ShAutoDetect(ShEvalMode mode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAutoDetect.NativeMethodInfoPtr_ShAutoDetect_Internal_Static_ShEvalMode_ShEvalMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x0000CB3B File Offset: 0x0000AD3B
		public PlatformAutoDetect(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x060015BD RID: 5565 RVA: 0x0005DA7C File Offset: 0x0005BC7C
		// (set) Token: 0x060015BE RID: 5566 RVA: 0x0000CB44 File Offset: 0x0000AD44
		public unsafe static bool _isXRMobile_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(PlatformAutoDetect.NativeFieldInfoPtr__isXRMobile_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformAutoDetect.NativeFieldInfoPtr__isXRMobile_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x060015BF RID: 5567 RVA: 0x0005DA98 File Offset: 0x0005BC98
		// (set) Token: 0x060015C0 RID: 5568 RVA: 0x0000CB52 File Offset: 0x0000AD52
		public unsafe static bool _isShaderAPIMobileDefined_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(PlatformAutoDetect.NativeFieldInfoPtr__isShaderAPIMobileDefined_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformAutoDetect.NativeFieldInfoPtr__isShaderAPIMobileDefined_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x060015C1 RID: 5569 RVA: 0x0005DAB4 File Offset: 0x0005BCB4
		// (set) Token: 0x060015C2 RID: 5570 RVA: 0x0000CB60 File Offset: 0x0000AD60
		public unsafe static bool _isSwitch_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(PlatformAutoDetect.NativeFieldInfoPtr__isSwitch_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformAutoDetect.NativeFieldInfoPtr__isSwitch_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x060015C3 RID: 5571 RVA: 0x0005DAD0 File Offset: 0x0005BCD0
		// (set) Token: 0x060015C4 RID: 5572 RVA: 0x0000CB6E File Offset: 0x0000AD6E
		public unsafe static bool isRunningOnPowerVRGPU
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(PlatformAutoDetect.NativeFieldInfoPtr_isRunningOnPowerVRGPU, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformAutoDetect.NativeFieldInfoPtr_isRunningOnPowerVRGPU, (void*)(&value));
			}
		}

		// Token: 0x04000FC7 RID: 4039
		private static readonly IntPtr NativeFieldInfoPtr__isXRMobile_k__BackingField;

		// Token: 0x04000FC8 RID: 4040
		private static readonly IntPtr NativeFieldInfoPtr__isShaderAPIMobileDefined_k__BackingField;

		// Token: 0x04000FC9 RID: 4041
		private static readonly IntPtr NativeFieldInfoPtr__isSwitch_k__BackingField;

		// Token: 0x04000FCA RID: 4042
		private static readonly IntPtr NativeFieldInfoPtr_isRunningOnPowerVRGPU;

		// Token: 0x04000FCB RID: 4043
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Static_Void_0;

		// Token: 0x04000FCC RID: 4044
		private static readonly IntPtr NativeMethodInfoPtr_get_isXRMobile_Internal_Static_get_Boolean_0;

		// Token: 0x04000FCD RID: 4045
		private static readonly IntPtr NativeMethodInfoPtr_set_isXRMobile_Private_Static_set_Void_Boolean_0;

		// Token: 0x04000FCE RID: 4046
		private static readonly IntPtr NativeMethodInfoPtr_get_isShaderAPIMobileDefined_Internal_Static_get_Boolean_0;

		// Token: 0x04000FCF RID: 4047
		private static readonly IntPtr NativeMethodInfoPtr_set_isShaderAPIMobileDefined_Private_Static_set_Void_Boolean_0;

		// Token: 0x04000FD0 RID: 4048
		private static readonly IntPtr NativeMethodInfoPtr_get_isSwitch_Internal_Static_get_Boolean_0;

		// Token: 0x04000FD1 RID: 4049
		private static readonly IntPtr NativeMethodInfoPtr_set_isSwitch_Private_Static_set_Void_Boolean_0;

		// Token: 0x04000FD2 RID: 4050
		private static readonly IntPtr NativeMethodInfoPtr_ShAutoDetect_Internal_Static_ShEvalMode_ShEvalMode_0;
	}
}
