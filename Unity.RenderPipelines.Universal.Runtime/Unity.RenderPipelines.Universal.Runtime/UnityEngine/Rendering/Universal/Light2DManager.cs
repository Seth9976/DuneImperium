using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200002A RID: 42
	public static class Light2DManager : Object
	{
		// Token: 0x0600032E RID: 814 RVA: 0x00020ED0 File Offset: 0x0001F0D0
		// Note: this type is marked as 'beforefieldinit'.
		static Light2DManager()
		{
			Il2CppClassPointerStore<Light2DManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "Light2DManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Light2DManager>.NativeClassPtr);
			Light2DManager.NativeFieldInfoPtr_s_SortingLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2DManager>.NativeClassPtr, "s_SortingLayers");
			Light2DManager.NativeFieldInfoPtr__lights_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light2DManager>.NativeClassPtr, "<lights>k__BackingField");
			Light2DManager.NativeMethodInfoPtr_get_lights_Public_Static_get_List_1_Light2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2DManager>.NativeClassPtr, 100663702);
			Light2DManager.NativeMethodInfoPtr_Initialize_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2DManager>.NativeClassPtr, 100663703);
			Light2DManager.NativeMethodInfoPtr_Dispose_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2DManager>.NativeClassPtr, 100663704);
			Light2DManager.NativeMethodInfoPtr_RegisterLight_Public_Static_Void_Light2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2DManager>.NativeClassPtr, 100663705);
			Light2DManager.NativeMethodInfoPtr_DeregisterLight_Public_Static_Void_Light2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2DManager>.NativeClassPtr, 100663706);
			Light2DManager.NativeMethodInfoPtr_ErrorIfDuplicateGlobalLight_Public_Static_Void_Light2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2DManager>.NativeClassPtr, 100663707);
			Light2DManager.NativeMethodInfoPtr_GetGlobalColor_Public_Static_Boolean_Int32_Int32_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2DManager>.NativeClassPtr, 100663708);
			Light2DManager.NativeMethodInfoPtr_ContainsDuplicateGlobalLight_Private_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2DManager>.NativeClassPtr, 100663709);
			Light2DManager.NativeMethodInfoPtr_GetCachedSortingLayer_Public_Static_Il2CppStructArray_1_SortingLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light2DManager>.NativeClassPtr, 100663710);
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600032F RID: 815 RVA: 0x00020FDC File Offset: 0x0001F1DC
		public unsafe static List<Light2D> lights
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 599856, XrefRangeEnd = 599860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2DManager.NativeMethodInfoPtr_get_lights_Public_Static_get_List_1_Light2D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Light2D>>(intPtr3) : null;
			}
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00021010 File Offset: 0x0001F210
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2DManager.NativeMethodInfoPtr_Initialize_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00021038 File Offset: 0x0001F238
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Dispose()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2DManager.NativeMethodInfoPtr_Dispose_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00021060 File Offset: 0x0001F260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 599860, XrefRangeEnd = 599885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterLight(Light2D light)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(light);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2DManager.NativeMethodInfoPtr_RegisterLight_Public_Static_Void_Light2D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00021098 File Offset: 0x0001F298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 599885, XrefRangeEnd = 599896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeregisterLight(Light2D light)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(light);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2DManager.NativeMethodInfoPtr_DeregisterLight_Public_Static_Void_Light2D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000334 RID: 820 RVA: 0x000210D0 File Offset: 0x0001F2D0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 599912, RefRangeEnd = 599917, XrefRangeStart = 599896, XrefRangeEnd = 599912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ErrorIfDuplicateGlobalLight(Light2D light)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(light);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2DManager.NativeMethodInfoPtr_ErrorIfDuplicateGlobalLight_Public_Static_Void_Light2D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00021108 File Offset: 0x0001F308
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 599935, RefRangeEnd = 599936, XrefRangeStart = 599917, XrefRangeEnd = 599935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetGlobalColor(int sortingLayerIndex, int blendStyleIndex, out Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sortingLayerIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blendStyleIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2DManager.NativeMethodInfoPtr_GetGlobalColor_Public_Static_Boolean_Int32_Int32_byref_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00021164 File Offset: 0x0001F364
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 599955, RefRangeEnd = 599956, XrefRangeStart = 599936, XrefRangeEnd = 599955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ContainsDuplicateGlobalLight(int sortingLayerIndex, int blendStyleIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sortingLayerIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blendStyleIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2DManager.NativeMethodInfoPtr_ContainsDuplicateGlobalLight_Private_Static_Boolean_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x000211B0 File Offset: 0x0001F3B0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 599969, RefRangeEnd = 599974, XrefRangeStart = 599956, XrefRangeEnd = 599969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<SortingLayer> GetCachedSortingLayer()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light2DManager.NativeMethodInfoPtr_GetCachedSortingLayer_Public_Static_Il2CppStructArray_1_SortingLayer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<SortingLayer>>(intPtr3) : null;
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00003632 File Offset: 0x00001832
		public Light2DManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000339 RID: 825 RVA: 0x000211E4 File Offset: 0x0001F3E4
		// (set) Token: 0x0600033A RID: 826 RVA: 0x0000363B File Offset: 0x0000183B
		public unsafe static Il2CppStructArray<SortingLayer> s_SortingLayers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Light2DManager.NativeFieldInfoPtr_s_SortingLayers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<SortingLayer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Light2DManager.NativeFieldInfoPtr_s_SortingLayers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600033B RID: 827 RVA: 0x0002120C File Offset: 0x0001F40C
		// (set) Token: 0x0600033C RID: 828 RVA: 0x0000364D File Offset: 0x0000184D
		public unsafe static List<Light2D> _lights_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Light2DManager.NativeFieldInfoPtr__lights_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Light2D>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Light2DManager.NativeFieldInfoPtr__lights_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeFieldInfoPtr_s_SortingLayers;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeFieldInfoPtr__lights_k__BackingField;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeMethodInfoPtr_get_lights_Public_Static_get_List_1_Light2D_0;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Static_Void_0;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Internal_Static_Void_0;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeMethodInfoPtr_RegisterLight_Public_Static_Void_Light2D_0;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeMethodInfoPtr_DeregisterLight_Public_Static_Void_Light2D_0;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeMethodInfoPtr_ErrorIfDuplicateGlobalLight_Public_Static_Void_Light2D_0;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalColor_Public_Static_Boolean_Int32_Int32_byref_Color_0;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeMethodInfoPtr_ContainsDuplicateGlobalLight_Private_Static_Boolean_Int32_Int32_0;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeMethodInfoPtr_GetCachedSortingLayer_Public_Static_Il2CppStructArray_1_SortingLayer_0;
	}
}
