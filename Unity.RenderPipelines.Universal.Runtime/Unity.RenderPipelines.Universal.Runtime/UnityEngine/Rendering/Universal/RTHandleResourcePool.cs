using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000CE RID: 206
	public class RTHandleResourcePool : Object
	{
		// Token: 0x06001025 RID: 4133 RVA: 0x0004D0E8 File Offset: 0x0004B2E8
		// Note: this type is marked as 'beforefieldinit'.
		static RTHandleResourcePool()
		{
			Il2CppClassPointerStore<RTHandleResourcePool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "RTHandleResourcePool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTHandleResourcePool>.NativeClassPtr);
			RTHandleResourcePool.NativeFieldInfoPtr_m_ResourcePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandleResourcePool>.NativeClassPtr, "m_ResourcePool");
			RTHandleResourcePool.NativeFieldInfoPtr_m_RemoveList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandleResourcePool>.NativeClassPtr, "m_RemoveList");
			RTHandleResourcePool.NativeFieldInfoPtr_s_CurrentStaleResourceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandleResourcePool>.NativeClassPtr, "s_CurrentStaleResourceCount");
			RTHandleResourcePool.NativeFieldInfoPtr_s_StaleResourceLifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandleResourcePool>.NativeClassPtr, "s_StaleResourceLifetime");
			RTHandleResourcePool.NativeFieldInfoPtr_s_StaleResourceMaxCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandleResourcePool>.NativeClassPtr, "s_StaleResourceMaxCapacity");
			RTHandleResourcePool.NativeMethodInfoPtr_get_staleResourceCapacity_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleResourcePool>.NativeClassPtr, 100665338);
			RTHandleResourcePool.NativeMethodInfoPtr_set_staleResourceCapacity_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleResourcePool>.NativeClassPtr, 100665339);
			RTHandleResourcePool.NativeMethodInfoPtr_AddResourceToPool_Internal_Boolean_byref_TextureDesc_RTHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleResourcePool>.NativeClassPtr, 100665340);
			RTHandleResourcePool.NativeMethodInfoPtr_TryGetResource_Internal_Boolean_byref_TextureDesc_byref_RTHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleResourcePool>.NativeClassPtr, 100665341);
			RTHandleResourcePool.NativeMethodInfoPtr_Cleanup_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleResourcePool>.NativeClassPtr, 100665342);
			RTHandleResourcePool.NativeMethodInfoPtr_ShouldReleaseResource_Protected_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleResourcePool>.NativeClassPtr, 100665343);
			RTHandleResourcePool.NativeMethodInfoPtr_PurgeUnusedResources_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleResourcePool>.NativeClassPtr, 100665344);
			RTHandleResourcePool.NativeMethodInfoPtr_LogDebugInfo_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleResourcePool>.NativeClassPtr, 100665345);
			RTHandleResourcePool.NativeMethodInfoPtr_GetHashCodeWithNameHash_Internal_Int32_byref_TextureDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleResourcePool>.NativeClassPtr, 100665346);
			RTHandleResourcePool.NativeMethodInfoPtr_CreateTextureDesc_Internal_Static_TextureDesc_RenderTextureDescriptor_TextureSizeMode_Int32_Single_FilterMode_TextureWrapMode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleResourcePool>.NativeClassPtr, 100665347);
			RTHandleResourcePool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleResourcePool>.NativeClassPtr, 100665348);
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06001026 RID: 4134 RVA: 0x0004D258 File Offset: 0x0004B458
		// (set) Token: 0x06001027 RID: 4135 RVA: 0x0004D294 File Offset: 0x0004B494
		public unsafe int staleResourceCapacity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 616697, XrefRangeEnd = 616701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleResourcePool.NativeMethodInfoPtr_get_staleResourceCapacity_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 616701, XrefRangeEnd = 616708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleResourcePool.NativeMethodInfoPtr_set_staleResourceCapacity_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x0004D2D4 File Offset: 0x0004B4D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 616738, RefRangeEnd = 616739, XrefRangeStart = 616708, XrefRangeEnd = 616738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddResourceToPool([In] ref TextureDesc texDesc, RTHandle resource, int currentFrameIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(texDesc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resource);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentFrameIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleResourcePool.NativeMethodInfoPtr_AddResourceToPool_Internal_Boolean_byref_TextureDesc_RTHandle_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x0004D344 File Offset: 0x0004B544
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 616760, RefRangeEnd = 616763, XrefRangeStart = 616739, XrefRangeEnd = 616760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetResource([In] ref TextureDesc texDesc, out RTHandle resource, bool usepool = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(texDesc);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usepool;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RTHandleResourcePool.NativeMethodInfoPtr_TryGetResource_Internal_Boolean_byref_TextureDesc_byref_RTHandle_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			resource = ((intPtr4 == 0) ? null : new RTHandle(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x0004D3C4 File Offset: 0x0004B5C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 616803, RefRangeEnd = 616806, XrefRangeStart = 616763, XrefRangeEnd = 616803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleResourcePool.NativeMethodInfoPtr_Cleanup_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x0004D3F8 File Offset: 0x0004B5F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 616810, RefRangeEnd = 616811, XrefRangeStart = 616806, XrefRangeEnd = 616810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShouldReleaseResource(int lastUsedFrameIndex, int currentFrameIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lastUsedFrameIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentFrameIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleResourcePool.NativeMethodInfoPtr_ShouldReleaseResource_Protected_Static_Boolean_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x0004D444 File Offset: 0x0004B644
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 616869, RefRangeEnd = 616870, XrefRangeStart = 616811, XrefRangeEnd = 616869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PurgeUnusedResources(int currentFrameIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref currentFrameIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleResourcePool.NativeMethodInfoPtr_PurgeUnusedResources_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x0004D484 File Offset: 0x0004B684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 616870, XrefRangeEnd = 616945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogDebugInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleResourcePool.NativeMethodInfoPtr_LogDebugInfo_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x0004D4B8 File Offset: 0x0004B6B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 616946, RefRangeEnd = 616948, XrefRangeStart = 616945, XrefRangeEnd = 616946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetHashCodeWithNameHash([In] ref TextureDesc texDesc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(texDesc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleResourcePool.NativeMethodInfoPtr_GetHashCodeWithNameHash_Internal_Int32_byref_TextureDesc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x0004D508 File Offset: 0x0004B708
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 616957, RefRangeEnd = 616964, XrefRangeStart = 616948, XrefRangeEnd = 616957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TextureDesc CreateTextureDesc(RenderTextureDescriptor desc, TextureSizeMode textureSizeMode = TextureSizeMode.Explicit, int anisoLevel = 1, float mipMapBias = 0f, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Clamp, string name = "")
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref desc;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureSizeMode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anisoLevel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipMapBias;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filterMode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wrapMode;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleResourcePool.NativeMethodInfoPtr_CreateTextureDesc_Internal_Static_TextureDesc_RenderTextureDescriptor_TextureSizeMode_Int32_Single_FilterMode_TextureWrapMode_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new TextureDesc(intPtr);
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x0004D59C File Offset: 0x0004B79C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 616979, RefRangeEnd = 616980, XrefRangeStart = 616964, XrefRangeEnd = 616979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTHandleResourcePool()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTHandleResourcePool>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleResourcePool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x00009CD1 File Offset: 0x00007ED1
		public RTHandleResourcePool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06001032 RID: 4146 RVA: 0x0004D5D8 File Offset: 0x0004B7D8
		// (set) Token: 0x06001033 RID: 4147 RVA: 0x00009CDA File Offset: 0x00007EDA
		public unsafe Dictionary<int, SortedList<int, ValueTuple<RTHandle, int>>> m_ResourcePool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandleResourcePool.NativeFieldInfoPtr_m_ResourcePool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, SortedList<int, ValueTuple<RTHandle, int>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandleResourcePool.NativeFieldInfoPtr_m_ResourcePool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06001034 RID: 4148 RVA: 0x0004D608 File Offset: 0x0004B808
		// (set) Token: 0x06001035 RID: 4149 RVA: 0x00009CF9 File Offset: 0x00007EF9
		public unsafe List<int> m_RemoveList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandleResourcePool.NativeFieldInfoPtr_m_RemoveList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandleResourcePool.NativeFieldInfoPtr_m_RemoveList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06001036 RID: 4150 RVA: 0x0004D638 File Offset: 0x0004B838
		// (set) Token: 0x06001037 RID: 4151 RVA: 0x00009D18 File Offset: 0x00007F18
		public unsafe static int s_CurrentStaleResourceCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RTHandleResourcePool.NativeFieldInfoPtr_s_CurrentStaleResourceCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RTHandleResourcePool.NativeFieldInfoPtr_s_CurrentStaleResourceCount, (void*)(&value));
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001038 RID: 4152 RVA: 0x0004D654 File Offset: 0x0004B854
		// (set) Token: 0x06001039 RID: 4153 RVA: 0x00009D26 File Offset: 0x00007F26
		public unsafe static int s_StaleResourceLifetime
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RTHandleResourcePool.NativeFieldInfoPtr_s_StaleResourceLifetime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RTHandleResourcePool.NativeFieldInfoPtr_s_StaleResourceLifetime, (void*)(&value));
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x0600103A RID: 4154 RVA: 0x0004D670 File Offset: 0x0004B870
		// (set) Token: 0x0600103B RID: 4155 RVA: 0x00009D34 File Offset: 0x00007F34
		public unsafe static int s_StaleResourceMaxCapacity
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RTHandleResourcePool.NativeFieldInfoPtr_s_StaleResourceMaxCapacity, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RTHandleResourcePool.NativeFieldInfoPtr_s_StaleResourceMaxCapacity, (void*)(&value));
			}
		}

		// Token: 0x04000BB7 RID: 2999
		private static readonly IntPtr NativeFieldInfoPtr_m_ResourcePool;

		// Token: 0x04000BB8 RID: 3000
		private static readonly IntPtr NativeFieldInfoPtr_m_RemoveList;

		// Token: 0x04000BB9 RID: 3001
		private static readonly IntPtr NativeFieldInfoPtr_s_CurrentStaleResourceCount;

		// Token: 0x04000BBA RID: 3002
		private static readonly IntPtr NativeFieldInfoPtr_s_StaleResourceLifetime;

		// Token: 0x04000BBB RID: 3003
		private static readonly IntPtr NativeFieldInfoPtr_s_StaleResourceMaxCapacity;

		// Token: 0x04000BBC RID: 3004
		private static readonly IntPtr NativeMethodInfoPtr_get_staleResourceCapacity_Internal_get_Int32_0;

		// Token: 0x04000BBD RID: 3005
		private static readonly IntPtr NativeMethodInfoPtr_set_staleResourceCapacity_Internal_set_Void_Int32_0;

		// Token: 0x04000BBE RID: 3006
		private static readonly IntPtr NativeMethodInfoPtr_AddResourceToPool_Internal_Boolean_byref_TextureDesc_RTHandle_Int32_0;

		// Token: 0x04000BBF RID: 3007
		private static readonly IntPtr NativeMethodInfoPtr_TryGetResource_Internal_Boolean_byref_TextureDesc_byref_RTHandle_Boolean_0;

		// Token: 0x04000BC0 RID: 3008
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Internal_Void_0;

		// Token: 0x04000BC1 RID: 3009
		private static readonly IntPtr NativeMethodInfoPtr_ShouldReleaseResource_Protected_Static_Boolean_Int32_Int32_0;

		// Token: 0x04000BC2 RID: 3010
		private static readonly IntPtr NativeMethodInfoPtr_PurgeUnusedResources_Internal_Void_Int32_0;

		// Token: 0x04000BC3 RID: 3011
		private static readonly IntPtr NativeMethodInfoPtr_LogDebugInfo_Internal_Void_0;

		// Token: 0x04000BC4 RID: 3012
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCodeWithNameHash_Internal_Int32_byref_TextureDesc_0;

		// Token: 0x04000BC5 RID: 3013
		private static readonly IntPtr NativeMethodInfoPtr_CreateTextureDesc_Internal_Static_TextureDesc_RenderTextureDescriptor_TextureSizeMode_Int32_Single_FilterMode_TextureWrapMode_String_0;

		// Token: 0x04000BC6 RID: 3014
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
