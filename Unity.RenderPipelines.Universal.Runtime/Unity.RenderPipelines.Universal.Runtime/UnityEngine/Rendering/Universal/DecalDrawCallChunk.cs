using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Collections;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200006B RID: 107
	public class DecalDrawCallChunk : DecalChunk
	{
		// Token: 0x06000944 RID: 2372 RVA: 0x000353E8 File Offset: 0x000335E8
		// Note: this type is marked as 'beforefieldinit'.
		static DecalDrawCallChunk()
		{
			Il2CppClassPointerStore<DecalDrawCallChunk>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DecalDrawCallChunk");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalDrawCallChunk>.NativeClassPtr);
			DecalDrawCallChunk.NativeFieldInfoPtr_decalToWorlds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalDrawCallChunk>.NativeClassPtr, "decalToWorlds");
			DecalDrawCallChunk.NativeFieldInfoPtr_normalToDecals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalDrawCallChunk>.NativeClassPtr, "normalToDecals");
			DecalDrawCallChunk.NativeFieldInfoPtr_renderingLayerMasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalDrawCallChunk>.NativeClassPtr, "renderingLayerMasks");
			DecalDrawCallChunk.NativeFieldInfoPtr_subCalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalDrawCallChunk>.NativeClassPtr, "subCalls");
			DecalDrawCallChunk.NativeFieldInfoPtr_subCallCounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalDrawCallChunk>.NativeClassPtr, "subCallCounts");
			DecalDrawCallChunk.NativeMethodInfoPtr_set_subCallCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalDrawCallChunk>.NativeClassPtr, 100664554);
			DecalDrawCallChunk.NativeMethodInfoPtr_get_subCallCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalDrawCallChunk>.NativeClassPtr, 100664555);
			DecalDrawCallChunk.NativeMethodInfoPtr_RemoveAtSwapBack_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalDrawCallChunk>.NativeClassPtr, 100664556);
			DecalDrawCallChunk.NativeMethodInfoPtr_SetCapacity_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalDrawCallChunk>.NativeClassPtr, 100664557);
			DecalDrawCallChunk.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalDrawCallChunk>.NativeClassPtr, 100664558);
			DecalDrawCallChunk.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalDrawCallChunk>.NativeClassPtr, 100664559);
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000946 RID: 2374 RVA: 0x00035534 File Offset: 0x00033734
		// (set) Token: 0x06000945 RID: 2373 RVA: 0x000354F4 File Offset: 0x000336F4
		public unsafe int subCallCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalDrawCallChunk.NativeMethodInfoPtr_get_subCallCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalDrawCallChunk.NativeMethodInfoPtr_set_subCallCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00035570 File Offset: 0x00033770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606762, XrefRangeEnd = 606773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RemoveAtSwapBack(int entityIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref entityIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecalDrawCallChunk.NativeMethodInfoPtr_RemoveAtSwapBack_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x000355BC File Offset: 0x000337BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606773, XrefRangeEnd = 606784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetCapacity(int newCapacity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newCapacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecalDrawCallChunk.NativeMethodInfoPtr_SetCapacity_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00035608 File Offset: 0x00033808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606784, XrefRangeEnd = 606798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecalDrawCallChunk.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00035644 File Offset: 0x00033844
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecalDrawCallChunk()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalDrawCallChunk>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalDrawCallChunk.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00006015 File Offset: 0x00004215
		public DecalDrawCallChunk(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x0600094C RID: 2380 RVA: 0x00035680 File Offset: 0x00033880
		// (set) Token: 0x0600094D RID: 2381 RVA: 0x0000601E File Offset: 0x0000421E
		public NativeArray<float4x4> decalToWorlds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalDrawCallChunk.NativeFieldInfoPtr_decalToWorlds);
				return new NativeArray<float4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalDrawCallChunk.NativeFieldInfoPtr_decalToWorlds), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x0600094E RID: 2382 RVA: 0x000356B0 File Offset: 0x000338B0
		// (set) Token: 0x0600094F RID: 2383 RVA: 0x0000604C File Offset: 0x0000424C
		public NativeArray<float4x4> normalToDecals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalDrawCallChunk.NativeFieldInfoPtr_normalToDecals);
				return new NativeArray<float4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalDrawCallChunk.NativeFieldInfoPtr_normalToDecals), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000950 RID: 2384 RVA: 0x000356E0 File Offset: 0x000338E0
		// (set) Token: 0x06000951 RID: 2385 RVA: 0x0000607A File Offset: 0x0000427A
		public NativeArray<float> renderingLayerMasks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalDrawCallChunk.NativeFieldInfoPtr_renderingLayerMasks);
				return new NativeArray<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalDrawCallChunk.NativeFieldInfoPtr_renderingLayerMasks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000952 RID: 2386 RVA: 0x00035710 File Offset: 0x00033910
		// (set) Token: 0x06000953 RID: 2387 RVA: 0x000060A8 File Offset: 0x000042A8
		public NativeArray<DecalSubDrawCall> subCalls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalDrawCallChunk.NativeFieldInfoPtr_subCalls);
				return new NativeArray<DecalSubDrawCall>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<DecalSubDrawCall>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalDrawCallChunk.NativeFieldInfoPtr_subCalls), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<DecalSubDrawCall>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000954 RID: 2388 RVA: 0x00035740 File Offset: 0x00033940
		// (set) Token: 0x06000955 RID: 2389 RVA: 0x000060D6 File Offset: 0x000042D6
		public NativeArray<int> subCallCounts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalDrawCallChunk.NativeFieldInfoPtr_subCallCounts);
				return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalDrawCallChunk.NativeFieldInfoPtr_subCallCounts), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040006FB RID: 1787
		private static readonly IntPtr NativeFieldInfoPtr_decalToWorlds;

		// Token: 0x040006FC RID: 1788
		private static readonly IntPtr NativeFieldInfoPtr_normalToDecals;

		// Token: 0x040006FD RID: 1789
		private static readonly IntPtr NativeFieldInfoPtr_renderingLayerMasks;

		// Token: 0x040006FE RID: 1790
		private static readonly IntPtr NativeFieldInfoPtr_subCalls;

		// Token: 0x040006FF RID: 1791
		private static readonly IntPtr NativeFieldInfoPtr_subCallCounts;

		// Token: 0x04000700 RID: 1792
		private static readonly IntPtr NativeMethodInfoPtr_set_subCallCount_Public_set_Void_Int32_0;

		// Token: 0x04000701 RID: 1793
		private static readonly IntPtr NativeMethodInfoPtr_get_subCallCount_Public_get_Int32_0;

		// Token: 0x04000702 RID: 1794
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAtSwapBack_Public_Virtual_Void_Int32_0;

		// Token: 0x04000703 RID: 1795
		private static readonly IntPtr NativeMethodInfoPtr_SetCapacity_Public_Virtual_Void_Int32_0;

		// Token: 0x04000704 RID: 1796
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0;

		// Token: 0x04000705 RID: 1797
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
