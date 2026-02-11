using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000031 RID: 49
	public static class LayerUtility : Object
	{
		// Token: 0x0600039B RID: 923 RVA: 0x00022820 File Offset: 0x00020A20
		// Note: this type is marked as 'beforefieldinit'.
		static LayerUtility()
		{
			Il2CppClassPointerStore<LayerUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "LayerUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayerUtility>.NativeClassPtr);
			LayerUtility.NativeFieldInfoPtr_s_LayerBatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayerUtility>.NativeClassPtr, "s_LayerBatches");
			LayerUtility.NativeFieldInfoPtr__maxTextureCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayerUtility>.NativeClassPtr, "<maxTextureCount>k__BackingField");
			LayerUtility.NativeMethodInfoPtr_get_maxTextureCount_Public_Static_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerUtility>.NativeClassPtr, 100663753);
			LayerUtility.NativeMethodInfoPtr_set_maxTextureCount_Private_Static_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerUtility>.NativeClassPtr, 100663754);
			LayerUtility.NativeMethodInfoPtr_InitializeBudget_Public_Static_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerUtility>.NativeClassPtr, 100663755);
			LayerUtility.NativeMethodInfoPtr_CanBatchLightsInLayer_Private_Static_Boolean_Int32_Int32_Il2CppStructArray_1_SortingLayer_ILight2DCullResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerUtility>.NativeClassPtr, 100663756);
			LayerUtility.NativeMethodInfoPtr_CanBatchCameraSortingLayer_Private_Static_Boolean_Int32_Il2CppStructArray_1_SortingLayer_Renderer2DData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerUtility>.NativeClassPtr, 100663757);
			LayerUtility.NativeMethodInfoPtr_FindUpperBoundInBatch_Private_Static_Int32_Int32_Il2CppStructArray_1_SortingLayer_Renderer2DData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerUtility>.NativeClassPtr, 100663758);
			LayerUtility.NativeMethodInfoPtr_InitializeBatchInfos_Private_Static_Void_Il2CppStructArray_1_SortingLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerUtility>.NativeClassPtr, 100663759);
			LayerUtility.NativeMethodInfoPtr_CalculateBatches_Public_Static_Il2CppStructArray_1_LayerBatch_Renderer2DData_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerUtility>.NativeClassPtr, 100663760);
			LayerUtility.NativeMethodInfoPtr_GetFilterSettings_Public_Static_Void_Renderer2DData_byref_LayerBatch_byref_FilteringSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerUtility>.NativeClassPtr, 100663761);
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600039C RID: 924 RVA: 0x0002292C File Offset: 0x00020B2C
		// (set) Token: 0x0600039D RID: 925 RVA: 0x0002295C File Offset: 0x00020B5C
		public unsafe static uint maxTextureCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 600870, XrefRangeEnd = 600872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerUtility.NativeMethodInfoPtr_get_maxTextureCount_Public_Static_get_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 600872, XrefRangeEnd = 600874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerUtility.NativeMethodInfoPtr_set_maxTextureCount_Private_Static_set_Void_UInt32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00022990 File Offset: 0x00020B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 600874, XrefRangeEnd = 600876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeBudget(uint maxTextureCount)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxTextureCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerUtility.NativeMethodInfoPtr_InitializeBudget_Public_Static_Void_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600039F RID: 927 RVA: 0x000229C4 File Offset: 0x00020BC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 600925, RefRangeEnd = 600927, XrefRangeStart = 600876, XrefRangeEnd = 600925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanBatchLightsInLayer(int layerIndex1, int layerIndex2, Il2CppStructArray<SortingLayer> sortingLayers, ILight2DCullResult lightCullResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layerIndex1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerIndex2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sortingLayers);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lightCullResult);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerUtility.NativeMethodInfoPtr_CanBatchLightsInLayer_Private_Static_Boolean_Int32_Int32_Il2CppStructArray_1_SortingLayer_ILight2DCullResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00022A34 File Offset: 0x00020C34
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 600928, RefRangeEnd = 600932, XrefRangeStart = 600927, XrefRangeEnd = 600928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanBatchCameraSortingLayer(int startLayerIndex, Il2CppStructArray<SortingLayer> sortingLayers, Renderer2DData rendererData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startLayerIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sortingLayers);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rendererData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerUtility.NativeMethodInfoPtr_CanBatchCameraSortingLayer_Private_Static_Boolean_Int32_Il2CppStructArray_1_SortingLayer_Renderer2DData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00022A98 File Offset: 0x00020C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 600932, XrefRangeEnd = 600936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindUpperBoundInBatch(int startLayerIndex, Il2CppStructArray<SortingLayer> sortingLayers, Renderer2DData rendererData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startLayerIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sortingLayers);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rendererData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerUtility.NativeMethodInfoPtr_FindUpperBoundInBatch_Private_Static_Int32_Int32_Il2CppStructArray_1_SortingLayer_Renderer2DData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00022AFC File Offset: 0x00020CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 600936, XrefRangeEnd = 600948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeBatchInfos(Il2CppStructArray<SortingLayer> cachedSortingLayers)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cachedSortingLayers);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerUtility.NativeMethodInfoPtr_InitializeBatchInfos_Private_Static_Void_Il2CppStructArray_1_SortingLayer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00022B34 File Offset: 0x00020D34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 600986, RefRangeEnd = 600987, XrefRangeStart = 600948, XrefRangeEnd = 600986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<LayerBatch> CalculateBatches(Renderer2DData rendererData, out int batchCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rendererData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &batchCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerUtility.NativeMethodInfoPtr_CalculateBatches_Public_Static_Il2CppStructArray_1_LayerBatch_Renderer2DData_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<LayerBatch>>(intPtr3) : null;
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00022B88 File Offset: 0x00020D88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 600998, RefRangeEnd = 600999, XrefRangeStart = 600987, XrefRangeEnd = 600998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetFilterSettings(Renderer2DData rendererData, ref LayerBatch layerBatch, out FilteringSettings filterSettings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rendererData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &layerBatch;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &filterSettings;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerUtility.NativeMethodInfoPtr_GetFilterSettings_Public_Static_Void_Renderer2DData_byref_LayerBatch_byref_FilteringSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x000038B4 File Offset: 0x00001AB4
		public LayerUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x00022BDC File Offset: 0x00020DDC
		// (set) Token: 0x060003A7 RID: 935 RVA: 0x000038BD File Offset: 0x00001ABD
		public unsafe static Il2CppStructArray<LayerBatch> s_LayerBatches
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LayerUtility.NativeFieldInfoPtr_s_LayerBatches, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<LayerBatch>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LayerUtility.NativeFieldInfoPtr_s_LayerBatches, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x00022C04 File Offset: 0x00020E04
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x000038CF File Offset: 0x00001ACF
		public unsafe static uint _maxTextureCount_k__BackingField
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(LayerUtility.NativeFieldInfoPtr__maxTextureCount_k__BackingField, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LayerUtility.NativeFieldInfoPtr__maxTextureCount_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeFieldInfoPtr_s_LayerBatches;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeFieldInfoPtr__maxTextureCount_k__BackingField;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeMethodInfoPtr_get_maxTextureCount_Public_Static_get_UInt32_0;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeMethodInfoPtr_set_maxTextureCount_Private_Static_set_Void_UInt32_0;

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeMethodInfoPtr_InitializeBudget_Public_Static_Void_UInt32_0;

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeMethodInfoPtr_CanBatchLightsInLayer_Private_Static_Boolean_Int32_Int32_Il2CppStructArray_1_SortingLayer_ILight2DCullResult_0;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeMethodInfoPtr_CanBatchCameraSortingLayer_Private_Static_Boolean_Int32_Il2CppStructArray_1_SortingLayer_Renderer2DData_0;

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeMethodInfoPtr_FindUpperBoundInBatch_Private_Static_Int32_Int32_Il2CppStructArray_1_SortingLayer_Renderer2DData_0;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeMethodInfoPtr_InitializeBatchInfos_Private_Static_Void_Il2CppStructArray_1_SortingLayer_0;

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeMethodInfoPtr_CalculateBatches_Public_Static_Il2CppStructArray_1_LayerBatch_Renderer2DData_byref_Int32_0;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeMethodInfoPtr_GetFilterSettings_Public_Static_Void_Renderer2DData_byref_LayerBatch_byref_FilteringSettings_0;
	}
}
