using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000029 RID: 41
	public class Light2DCullResult : Object
	{
		// Token: 0x06000322 RID: 802 RVA: 0x00020C0C File Offset: 0x0001EE0C
		// Note: this type is marked as 'beforefieldinit'.
		static Light2DCullResult()
		{
			Il2CppClassPointerStore<Light2DCullResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "Light2DCullResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Light2DCullResult>.NativeClassPtr);
			Light2DCullResult.NativeFieldInfoPtr_m_VisibleLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2DCullResult>.NativeClassPtr, "m_VisibleLights");
			Light2DCullResult.NativeFieldInfoPtr_m_VisibleShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2DCullResult>.NativeClassPtr, "m_VisibleShadows");
			Light2DCullResult.NativeMethodInfoPtr_get_visibleLights_Public_Virtual_Final_New_get_List_1_Light2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2DCullResult>.NativeClassPtr, 100663693);
			Light2DCullResult.NativeMethodInfoPtr_get_visibleShadows_Public_Virtual_Final_New_get_List_1_ShadowCasterGroup2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2DCullResult>.NativeClassPtr, 100663694);
			Light2DCullResult.NativeMethodInfoPtr_IsSceneLit_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2DCullResult>.NativeClassPtr, 100663695);
			Light2DCullResult.NativeMethodInfoPtr_GetLightStatsByLayer_Public_Virtual_Final_New_LightStats_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2DCullResult>.NativeClassPtr, 100663696);
			Light2DCullResult.NativeMethodInfoPtr_SetupCulling_Public_Void_byref_ScriptableCullingParameters_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2DCullResult>.NativeClassPtr, 100663697);
			Light2DCullResult.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2DCullResult>.NativeClassPtr, 100663698);
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000323 RID: 803 RVA: 0x00020CDC File Offset: 0x0001EEDC
		public unsafe virtual List<Light2D> visibleLights
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2DCullResult.NativeMethodInfoPtr_get_visibleLights_Public_Virtual_Final_New_get_List_1_Light2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Light2D>>(intPtr3) : null;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000324 RID: 804 RVA: 0x00020D1C File Offset: 0x0001EF1C
		public unsafe virtual List<ShadowCasterGroup2D> visibleShadows
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2DCullResult.NativeMethodInfoPtr_get_visibleShadows_Public_Virtual_Final_New_get_List_1_ShadowCasterGroup2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ShadowCasterGroup2D>>(intPtr3) : null;
			}
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00020D5C File Offset: 0x0001EF5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 599701, XrefRangeEnd = 599709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsSceneLit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2DCullResult.NativeMethodInfoPtr_IsSceneLit_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00020D98 File Offset: 0x0001EF98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 599709, XrefRangeEnd = 599724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual LightStats GetLightStatsByLayer(int layer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2DCullResult.NativeMethodInfoPtr_GetLightStatsByLayer_Public_Virtual_Final_New_LightStats_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00020DE4 File Offset: 0x0001EFE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 599840, RefRangeEnd = 599841, XrefRangeStart = 599724, XrefRangeEnd = 599840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupCulling(ref ScriptableCullingParameters cullingParameters, Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &cullingParameters;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2DCullResult.NativeMethodInfoPtr_SetupCulling_Public_Void_byref_ScriptableCullingParameters_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00020E34 File Offset: 0x0001F034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 599841, XrefRangeEnd = 599856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Light2DCullResult()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Light2DCullResult>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2DCullResult.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000329 RID: 809 RVA: 0x000035EB File Offset: 0x000017EB
		public Light2DCullResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600032A RID: 810 RVA: 0x00020E70 File Offset: 0x0001F070
		// (set) Token: 0x0600032B RID: 811 RVA: 0x000035F4 File Offset: 0x000017F4
		public unsafe List<Light2D> m_VisibleLights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2DCullResult.NativeFieldInfoPtr_m_VisibleLights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Light2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2DCullResult.NativeFieldInfoPtr_m_VisibleLights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600032C RID: 812 RVA: 0x00020EA0 File Offset: 0x0001F0A0
		// (set) Token: 0x0600032D RID: 813 RVA: 0x00003613 File Offset: 0x00001813
		public unsafe List<ShadowCasterGroup2D> m_VisibleShadows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2DCullResult.NativeFieldInfoPtr_m_VisibleShadows);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ShadowCasterGroup2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light2DCullResult.NativeFieldInfoPtr_m_VisibleShadows), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeFieldInfoPtr_m_VisibleLights;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeFieldInfoPtr_m_VisibleShadows;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeMethodInfoPtr_get_visibleLights_Public_Virtual_Final_New_get_List_1_Light2D_0;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeMethodInfoPtr_get_visibleShadows_Public_Virtual_Final_New_get_List_1_ShadowCasterGroup2D_0;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeMethodInfoPtr_IsSceneLit_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeMethodInfoPtr_GetLightStatsByLayer_Public_Virtual_Final_New_LightStats_Int32_0;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeMethodInfoPtr_SetupCulling_Public_Void_byref_ScriptableCullingParameters_Camera_0;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000159 RID: 345
		[ObfuscatedName("UnityEngine.Rendering.Universal.Light2DCullResult+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001B73 RID: 7027 RVA: 0x000724FC File Offset: 0x000706FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Light2DCullResult.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Light2DCullResult>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Light2DCullResult.__c>.NativeClassPtr);
				Light2DCullResult.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2DCullResult.__c>.NativeClassPtr, "<>9");
				Light2DCullResult.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2DCullResult.__c>.NativeClassPtr, "<>9__8_0");
				Light2DCullResult.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2DCullResult.__c>.NativeClassPtr, 100663700);
				Light2DCullResult.__c.NativeMethodInfoPtr__SetupCulling_b__8_0_Internal_Int32_Light2D_Light2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2DCullResult.__c>.NativeClassPtr, 100663701);
			}

			// Token: 0x06001B74 RID: 7028 RVA: 0x00072578 File Offset: 0x00070778
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Light2DCullResult.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2DCullResult.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B75 RID: 7029 RVA: 0x000725B4 File Offset: 0x000707B4
			[CallerCount(0)]
			public unsafe int _SetupCulling_b__8_0(Light2D l1, Light2D l2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(l1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(l2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2DCullResult.__c.NativeMethodInfoPtr__SetupCulling_b__8_0_Internal_Int32_Light2D_Light2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001B76 RID: 7030 RVA: 0x0000F89C File Offset: 0x0000DA9C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009E0 RID: 2528
			// (get) Token: 0x06001B77 RID: 7031 RVA: 0x00072614 File Offset: 0x00070814
			// (set) Token: 0x06001B78 RID: 7032 RVA: 0x0000F8A5 File Offset: 0x0000DAA5
			public unsafe static Light2DCullResult.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Light2DCullResult.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light2DCullResult.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Light2DCullResult.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009E1 RID: 2529
			// (get) Token: 0x06001B79 RID: 7033 RVA: 0x0007263C File Offset: 0x0007083C
			// (set) Token: 0x06001B7A RID: 7034 RVA: 0x0000F8B7 File Offset: 0x0000DAB7
			public unsafe static Comparison<Light2D> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Light2DCullResult.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<Light2D>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Light2DCullResult.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013FF RID: 5119
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001400 RID: 5120
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04001401 RID: 5121
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001402 RID: 5122
			private static readonly IntPtr NativeMethodInfoPtr__SetupCulling_b__8_0_Internal_Int32_Light2D_Light2D_0;
		}
	}
}
