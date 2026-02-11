using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Unity.Collections;
using UnityEngine.Jobs;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000070 RID: 112
	public class DecalEntityChunk : DecalChunk
	{
		// Token: 0x06000990 RID: 2448 RVA: 0x0003665C File Offset: 0x0003485C
		// Note: this type is marked as 'beforefieldinit'.
		static DecalEntityChunk()
		{
			Il2CppClassPointerStore<DecalEntityChunk>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DecalEntityChunk");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalEntityChunk>.NativeClassPtr);
			DecalEntityChunk.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalEntityChunk>.NativeClassPtr, "material");
			DecalEntityChunk.NativeFieldInfoPtr_decalEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalEntityChunk>.NativeClassPtr, "decalEntities");
			DecalEntityChunk.NativeFieldInfoPtr_decalProjectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalEntityChunk>.NativeClassPtr, "decalProjectors");
			DecalEntityChunk.NativeFieldInfoPtr_transformAccessArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalEntityChunk>.NativeClassPtr, "transformAccessArray");
			DecalEntityChunk.NativeMethodInfoPtr_Push_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalEntityChunk>.NativeClassPtr, 100664588);
			DecalEntityChunk.NativeMethodInfoPtr_RemoveAtSwapBack_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalEntityChunk>.NativeClassPtr, 100664589);
			DecalEntityChunk.NativeMethodInfoPtr_SetCapacity_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalEntityChunk>.NativeClassPtr, 100664590);
			DecalEntityChunk.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalEntityChunk>.NativeClassPtr, 100664591);
			DecalEntityChunk.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalEntityChunk>.NativeClassPtr, 100664592);
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x00036740 File Offset: 0x00034940
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 334680, RefRangeEnd = 334682, XrefRangeStart = 334680, XrefRangeEnd = 334682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Push()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecalEntityChunk.NativeMethodInfoPtr_Push_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x0003677C File Offset: 0x0003497C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 607105, XrefRangeEnd = 607112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RemoveAtSwapBack(int entityIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref entityIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecalEntityChunk.NativeMethodInfoPtr_RemoveAtSwapBack_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x000367C8 File Offset: 0x000349C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 607112, XrefRangeEnd = 607125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetCapacity(int newCapacity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newCapacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecalEntityChunk.NativeMethodInfoPtr_SetCapacity_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x00036814 File Offset: 0x00034A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 607125, XrefRangeEnd = 607130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecalEntityChunk.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x00036850 File Offset: 0x00034A50
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecalEntityChunk()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalEntityChunk>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalEntityChunk.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x00006290 File Offset: 0x00004490
		public DecalEntityChunk(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000997 RID: 2455 RVA: 0x0003688C File Offset: 0x00034A8C
		// (set) Token: 0x06000998 RID: 2456 RVA: 0x00006299 File Offset: 0x00004499
		public unsafe Material material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityChunk.NativeFieldInfoPtr_material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityChunk.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000999 RID: 2457 RVA: 0x000368BC File Offset: 0x00034ABC
		// (set) Token: 0x0600099A RID: 2458 RVA: 0x000062B8 File Offset: 0x000044B8
		public NativeArray<DecalEntity> decalEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityChunk.NativeFieldInfoPtr_decalEntities);
				return new NativeArray<DecalEntity>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<DecalEntity>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityChunk.NativeFieldInfoPtr_decalEntities), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<DecalEntity>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x0600099B RID: 2459 RVA: 0x000368EC File Offset: 0x00034AEC
		// (set) Token: 0x0600099C RID: 2460 RVA: 0x000062E6 File Offset: 0x000044E6
		public unsafe Il2CppReferenceArray<DecalProjector> decalProjectors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityChunk.NativeFieldInfoPtr_decalProjectors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DecalProjector>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityChunk.NativeFieldInfoPtr_decalProjectors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x0003691C File Offset: 0x00034B1C
		// (set) Token: 0x0600099E RID: 2462 RVA: 0x00006305 File Offset: 0x00004505
		public unsafe TransformAccessArray transformAccessArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityChunk.NativeFieldInfoPtr_transformAccessArray);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityChunk.NativeFieldInfoPtr_transformAccessArray)) = value;
			}
		}

		// Token: 0x04000730 RID: 1840
		private static readonly IntPtr NativeFieldInfoPtr_material;

		// Token: 0x04000731 RID: 1841
		private static readonly IntPtr NativeFieldInfoPtr_decalEntities;

		// Token: 0x04000732 RID: 1842
		private static readonly IntPtr NativeFieldInfoPtr_decalProjectors;

		// Token: 0x04000733 RID: 1843
		private static readonly IntPtr NativeFieldInfoPtr_transformAccessArray;

		// Token: 0x04000734 RID: 1844
		private static readonly IntPtr NativeMethodInfoPtr_Push_Public_Virtual_Void_0;

		// Token: 0x04000735 RID: 1845
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAtSwapBack_Public_Virtual_Void_Int32_0;

		// Token: 0x04000736 RID: 1846
		private static readonly IntPtr NativeMethodInfoPtr_SetCapacity_Public_Virtual_Void_Int32_0;

		// Token: 0x04000737 RID: 1847
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0;

		// Token: 0x04000738 RID: 1848
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
