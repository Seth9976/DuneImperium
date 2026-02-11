using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Unity.Collections;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000076 RID: 118
	public class DecalCulledChunk : DecalChunk
	{
		// Token: 0x06000A1E RID: 2590 RVA: 0x00037EE4 File Offset: 0x000360E4
		// Note: this type is marked as 'beforefieldinit'.
		static DecalCulledChunk()
		{
			Il2CppClassPointerStore<DecalCulledChunk>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DecalCulledChunk");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalCulledChunk>.NativeClassPtr);
			DecalCulledChunk.NativeFieldInfoPtr_cameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCulledChunk>.NativeClassPtr, "cameraPosition");
			DecalCulledChunk.NativeFieldInfoPtr_sceneCullingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCulledChunk>.NativeClassPtr, "sceneCullingMask");
			DecalCulledChunk.NativeFieldInfoPtr_cullingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCulledChunk>.NativeClassPtr, "cullingMask");
			DecalCulledChunk.NativeFieldInfoPtr_cullingGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCulledChunk>.NativeClassPtr, "cullingGroups");
			DecalCulledChunk.NativeFieldInfoPtr_visibleDecalIndexArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCulledChunk>.NativeClassPtr, "visibleDecalIndexArray");
			DecalCulledChunk.NativeFieldInfoPtr_visibleDecalIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCulledChunk>.NativeClassPtr, "visibleDecalIndices");
			DecalCulledChunk.NativeFieldInfoPtr_visibleDecalCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCulledChunk>.NativeClassPtr, "visibleDecalCount");
			DecalCulledChunk.NativeMethodInfoPtr_RemoveAtSwapBack_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalCulledChunk>.NativeClassPtr, 100664625);
			DecalCulledChunk.NativeMethodInfoPtr_SetCapacity_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalCulledChunk>.NativeClassPtr, 100664626);
			DecalCulledChunk.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalCulledChunk>.NativeClassPtr, 100664627);
			DecalCulledChunk.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalCulledChunk>.NativeClassPtr, 100664628);
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x00037FF0 File Offset: 0x000361F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 607969, XrefRangeEnd = 607975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RemoveAtSwapBack(int entityIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref entityIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecalCulledChunk.NativeMethodInfoPtr_RemoveAtSwapBack_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x0003803C File Offset: 0x0003623C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 607975, XrefRangeEnd = 607986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetCapacity(int newCapacity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newCapacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecalCulledChunk.NativeMethodInfoPtr_SetCapacity_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x00038088 File Offset: 0x00036288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 607986, XrefRangeEnd = 607992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecalCulledChunk.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x000380C4 File Offset: 0x000362C4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecalCulledChunk()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalCulledChunk>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalCulledChunk.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x000069B3 File Offset: 0x00004BB3
		public DecalCulledChunk(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x00038100 File Offset: 0x00036300
		// (set) Token: 0x06000A25 RID: 2597 RVA: 0x000069BC File Offset: 0x00004BBC
		public unsafe Vector3 cameraPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCulledChunk.NativeFieldInfoPtr_cameraPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCulledChunk.NativeFieldInfoPtr_cameraPosition)) = value;
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x00038128 File Offset: 0x00036328
		// (set) Token: 0x06000A27 RID: 2599 RVA: 0x000069D7 File Offset: 0x00004BD7
		public unsafe ulong sceneCullingMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCulledChunk.NativeFieldInfoPtr_sceneCullingMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCulledChunk.NativeFieldInfoPtr_sceneCullingMask)) = value;
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x00038150 File Offset: 0x00036350
		// (set) Token: 0x06000A29 RID: 2601 RVA: 0x000069F2 File Offset: 0x00004BF2
		public unsafe int cullingMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCulledChunk.NativeFieldInfoPtr_cullingMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCulledChunk.NativeFieldInfoPtr_cullingMask)) = value;
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x00038178 File Offset: 0x00036378
		// (set) Token: 0x06000A2B RID: 2603 RVA: 0x00006A0D File Offset: 0x00004C0D
		public unsafe CullingGroup cullingGroups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCulledChunk.NativeFieldInfoPtr_cullingGroups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CullingGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCulledChunk.NativeFieldInfoPtr_cullingGroups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x000381A8 File Offset: 0x000363A8
		// (set) Token: 0x06000A2D RID: 2605 RVA: 0x00006A2C File Offset: 0x00004C2C
		public unsafe Il2CppStructArray<int> visibleDecalIndexArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCulledChunk.NativeFieldInfoPtr_visibleDecalIndexArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCulledChunk.NativeFieldInfoPtr_visibleDecalIndexArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000A2E RID: 2606 RVA: 0x000381D8 File Offset: 0x000363D8
		// (set) Token: 0x06000A2F RID: 2607 RVA: 0x00006A4B File Offset: 0x00004C4B
		public NativeArray<int> visibleDecalIndices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCulledChunk.NativeFieldInfoPtr_visibleDecalIndices);
				return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCulledChunk.NativeFieldInfoPtr_visibleDecalIndices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000A30 RID: 2608 RVA: 0x00038208 File Offset: 0x00036408
		// (set) Token: 0x06000A31 RID: 2609 RVA: 0x00006A79 File Offset: 0x00004C79
		public unsafe int visibleDecalCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCulledChunk.NativeFieldInfoPtr_visibleDecalCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCulledChunk.NativeFieldInfoPtr_visibleDecalCount)) = value;
			}
		}

		// Token: 0x04000780 RID: 1920
		private static readonly IntPtr NativeFieldInfoPtr_cameraPosition;

		// Token: 0x04000781 RID: 1921
		private static readonly IntPtr NativeFieldInfoPtr_sceneCullingMask;

		// Token: 0x04000782 RID: 1922
		private static readonly IntPtr NativeFieldInfoPtr_cullingMask;

		// Token: 0x04000783 RID: 1923
		private static readonly IntPtr NativeFieldInfoPtr_cullingGroups;

		// Token: 0x04000784 RID: 1924
		private static readonly IntPtr NativeFieldInfoPtr_visibleDecalIndexArray;

		// Token: 0x04000785 RID: 1925
		private static readonly IntPtr NativeFieldInfoPtr_visibleDecalIndices;

		// Token: 0x04000786 RID: 1926
		private static readonly IntPtr NativeFieldInfoPtr_visibleDecalCount;

		// Token: 0x04000787 RID: 1927
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAtSwapBack_Public_Virtual_Void_Int32_0;

		// Token: 0x04000788 RID: 1928
		private static readonly IntPtr NativeMethodInfoPtr_SetCapacity_Public_Virtual_Void_Int32_0;

		// Token: 0x04000789 RID: 1929
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0;

		// Token: 0x0400078A RID: 1930
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
