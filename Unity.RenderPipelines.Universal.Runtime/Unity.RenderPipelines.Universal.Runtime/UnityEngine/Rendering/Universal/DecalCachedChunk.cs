using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Unity.Collections;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000073 RID: 115
	public class DecalCachedChunk : DecalChunk
	{
		// Token: 0x060009D4 RID: 2516 RVA: 0x00037344 File Offset: 0x00035544
		// Note: this type is marked as 'beforefieldinit'.
		static DecalCachedChunk()
		{
			Il2CppClassPointerStore<DecalCachedChunk>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DecalCachedChunk");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalCachedChunk>.NativeClassPtr);
			DecalCachedChunk.NativeFieldInfoPtr_propertyBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCachedChunk>.NativeClassPtr, "propertyBlock");
			DecalCachedChunk.NativeFieldInfoPtr_passIndexDBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCachedChunk>.NativeClassPtr, "passIndexDBuffer");
			DecalCachedChunk.NativeFieldInfoPtr_passIndexEmissive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCachedChunk>.NativeClassPtr, "passIndexEmissive");
			DecalCachedChunk.NativeFieldInfoPtr_passIndexScreenSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCachedChunk>.NativeClassPtr, "passIndexScreenSpace");
			DecalCachedChunk.NativeFieldInfoPtr_passIndexGBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCachedChunk>.NativeClassPtr, "passIndexGBuffer");
			DecalCachedChunk.NativeFieldInfoPtr_drawOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCachedChunk>.NativeClassPtr, "drawOrder");
			DecalCachedChunk.NativeFieldInfoPtr_isCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCachedChunk>.NativeClassPtr, "isCreated");
			DecalCachedChunk.NativeFieldInfoPtr_decalToWorlds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCachedChunk>.NativeClassPtr, "decalToWorlds");
			DecalCachedChunk.NativeFieldInfoPtr_normalToWorlds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCachedChunk>.NativeClassPtr, "normalToWorlds");
			DecalCachedChunk.NativeFieldInfoPtr_sizeOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCachedChunk>.NativeClassPtr, "sizeOffsets");
			DecalCachedChunk.NativeFieldInfoPtr_drawDistances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCachedChunk>.NativeClassPtr, "drawDistances");
			DecalCachedChunk.NativeFieldInfoPtr_angleFades = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCachedChunk>.NativeClassPtr, "angleFades");
			DecalCachedChunk.NativeFieldInfoPtr_uvScaleBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCachedChunk>.NativeClassPtr, "uvScaleBias");
			DecalCachedChunk.NativeFieldInfoPtr_layerMasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCachedChunk>.NativeClassPtr, "layerMasks");
			DecalCachedChunk.NativeFieldInfoPtr_sceneLayerMasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCachedChunk>.NativeClassPtr, "sceneLayerMasks");
			DecalCachedChunk.NativeFieldInfoPtr_fadeFactors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCachedChunk>.NativeClassPtr, "fadeFactors");
			DecalCachedChunk.NativeFieldInfoPtr_boundingSpheres = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCachedChunk>.NativeClassPtr, "boundingSpheres");
			DecalCachedChunk.NativeFieldInfoPtr_scaleModes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCachedChunk>.NativeClassPtr, "scaleModes");
			DecalCachedChunk.NativeFieldInfoPtr_renderingLayerMasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCachedChunk>.NativeClassPtr, "renderingLayerMasks");
			DecalCachedChunk.NativeFieldInfoPtr_positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCachedChunk>.NativeClassPtr, "positions");
			DecalCachedChunk.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCachedChunk>.NativeClassPtr, "rotation");
			DecalCachedChunk.NativeFieldInfoPtr_scales = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCachedChunk>.NativeClassPtr, "scales");
			DecalCachedChunk.NativeFieldInfoPtr_dirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCachedChunk>.NativeClassPtr, "dirty");
			DecalCachedChunk.NativeFieldInfoPtr_boundingSphereArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCachedChunk>.NativeClassPtr, "boundingSphereArray");
			DecalCachedChunk.NativeMethodInfoPtr_RemoveAtSwapBack_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalCachedChunk>.NativeClassPtr, 100664611);
			DecalCachedChunk.NativeMethodInfoPtr_SetCapacity_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalCachedChunk>.NativeClassPtr, 100664612);
			DecalCachedChunk.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalCachedChunk>.NativeClassPtr, 100664613);
			DecalCachedChunk.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalCachedChunk>.NativeClassPtr, 100664614);
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x000375A4 File Offset: 0x000357A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 607694, XrefRangeEnd = 607741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RemoveAtSwapBack(int entityIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref entityIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecalCachedChunk.NativeMethodInfoPtr_RemoveAtSwapBack_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x000375F0 File Offset: 0x000357F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 607741, XrefRangeEnd = 607788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetCapacity(int newCapacity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newCapacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecalCachedChunk.NativeMethodInfoPtr_SetCapacity_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x0003763C File Offset: 0x0003583C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 607788, XrefRangeEnd = 607832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecalCachedChunk.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x00037678 File Offset: 0x00035878
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecalCachedChunk()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalCachedChunk>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalCachedChunk.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x0000653D File Offset: 0x0000473D
		public DecalCachedChunk(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x060009DA RID: 2522 RVA: 0x000376B4 File Offset: 0x000358B4
		// (set) Token: 0x060009DB RID: 2523 RVA: 0x00006546 File Offset: 0x00004746
		public unsafe MaterialPropertyBlock propertyBlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_propertyBlock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaterialPropertyBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_propertyBlock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x060009DC RID: 2524 RVA: 0x000376E4 File Offset: 0x000358E4
		// (set) Token: 0x060009DD RID: 2525 RVA: 0x00006565 File Offset: 0x00004765
		public unsafe int passIndexDBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_passIndexDBuffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_passIndexDBuffer)) = value;
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x060009DE RID: 2526 RVA: 0x0003770C File Offset: 0x0003590C
		// (set) Token: 0x060009DF RID: 2527 RVA: 0x00006580 File Offset: 0x00004780
		public unsafe int passIndexEmissive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_passIndexEmissive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_passIndexEmissive)) = value;
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x060009E0 RID: 2528 RVA: 0x00037734 File Offset: 0x00035934
		// (set) Token: 0x060009E1 RID: 2529 RVA: 0x0000659B File Offset: 0x0000479B
		public unsafe int passIndexScreenSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_passIndexScreenSpace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_passIndexScreenSpace)) = value;
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x060009E2 RID: 2530 RVA: 0x0003775C File Offset: 0x0003595C
		// (set) Token: 0x060009E3 RID: 2531 RVA: 0x000065B6 File Offset: 0x000047B6
		public unsafe int passIndexGBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_passIndexGBuffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_passIndexGBuffer)) = value;
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x00037784 File Offset: 0x00035984
		// (set) Token: 0x060009E5 RID: 2533 RVA: 0x000065D1 File Offset: 0x000047D1
		public unsafe int drawOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_drawOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_drawOrder)) = value;
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x000377AC File Offset: 0x000359AC
		// (set) Token: 0x060009E7 RID: 2535 RVA: 0x000065EC File Offset: 0x000047EC
		public unsafe bool isCreated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_isCreated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_isCreated)) = value;
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x060009E8 RID: 2536 RVA: 0x000377D4 File Offset: 0x000359D4
		// (set) Token: 0x060009E9 RID: 2537 RVA: 0x00006607 File Offset: 0x00004807
		public NativeArray<float4x4> decalToWorlds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_decalToWorlds);
				return new NativeArray<float4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_decalToWorlds), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x060009EA RID: 2538 RVA: 0x00037804 File Offset: 0x00035A04
		// (set) Token: 0x060009EB RID: 2539 RVA: 0x00006635 File Offset: 0x00004835
		public NativeArray<float4x4> normalToWorlds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_normalToWorlds);
				return new NativeArray<float4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_normalToWorlds), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x060009EC RID: 2540 RVA: 0x00037834 File Offset: 0x00035A34
		// (set) Token: 0x060009ED RID: 2541 RVA: 0x00006663 File Offset: 0x00004863
		public NativeArray<float4x4> sizeOffsets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_sizeOffsets);
				return new NativeArray<float4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_sizeOffsets), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x00037864 File Offset: 0x00035A64
		// (set) Token: 0x060009EF RID: 2543 RVA: 0x00006691 File Offset: 0x00004891
		public NativeArray<float2> drawDistances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_drawDistances);
				return new NativeArray<float2>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float2>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_drawDistances), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float2>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x00037894 File Offset: 0x00035A94
		// (set) Token: 0x060009F1 RID: 2545 RVA: 0x000066BF File Offset: 0x000048BF
		public NativeArray<float2> angleFades
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_angleFades);
				return new NativeArray<float2>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float2>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_angleFades), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float2>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x000378C4 File Offset: 0x00035AC4
		// (set) Token: 0x060009F3 RID: 2547 RVA: 0x000066ED File Offset: 0x000048ED
		public NativeArray<float4> uvScaleBias
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_uvScaleBias);
				return new NativeArray<float4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float4>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_uvScaleBias), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float4>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x000378F4 File Offset: 0x00035AF4
		// (set) Token: 0x060009F5 RID: 2549 RVA: 0x0000671B File Offset: 0x0000491B
		public NativeArray<int> layerMasks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_layerMasks);
				return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_layerMasks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x060009F6 RID: 2550 RVA: 0x00037924 File Offset: 0x00035B24
		// (set) Token: 0x060009F7 RID: 2551 RVA: 0x00006749 File Offset: 0x00004949
		public NativeArray<ulong> sceneLayerMasks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_sceneLayerMasks);
				return new NativeArray<ulong>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<ulong>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_sceneLayerMasks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<ulong>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x060009F8 RID: 2552 RVA: 0x00037954 File Offset: 0x00035B54
		// (set) Token: 0x060009F9 RID: 2553 RVA: 0x00006777 File Offset: 0x00004977
		public NativeArray<float> fadeFactors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_fadeFactors);
				return new NativeArray<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_fadeFactors), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x060009FA RID: 2554 RVA: 0x00037984 File Offset: 0x00035B84
		// (set) Token: 0x060009FB RID: 2555 RVA: 0x000067A5 File Offset: 0x000049A5
		public NativeArray<BoundingSphere> boundingSpheres
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_boundingSpheres);
				return new NativeArray<BoundingSphere>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<BoundingSphere>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_boundingSpheres), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<BoundingSphere>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x000379B4 File Offset: 0x00035BB4
		// (set) Token: 0x060009FD RID: 2557 RVA: 0x000067D3 File Offset: 0x000049D3
		public NativeArray<DecalScaleMode> scaleModes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_scaleModes);
				return new NativeArray<DecalScaleMode>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<DecalScaleMode>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_scaleModes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<DecalScaleMode>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x000379E4 File Offset: 0x00035BE4
		// (set) Token: 0x060009FF RID: 2559 RVA: 0x00006801 File Offset: 0x00004A01
		public NativeArray<uint> renderingLayerMasks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_renderingLayerMasks);
				return new NativeArray<uint>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<uint>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_renderingLayerMasks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<uint>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000A00 RID: 2560 RVA: 0x00037A14 File Offset: 0x00035C14
		// (set) Token: 0x06000A01 RID: 2561 RVA: 0x0000682F File Offset: 0x00004A2F
		public NativeArray<float3> positions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_positions);
				return new NativeArray<float3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float3>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_positions), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float3>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x00037A44 File Offset: 0x00035C44
		// (set) Token: 0x06000A03 RID: 2563 RVA: 0x0000685D File Offset: 0x00004A5D
		public NativeArray<quaternion> rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_rotation);
				return new NativeArray<quaternion>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<quaternion>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_rotation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<quaternion>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x00037A74 File Offset: 0x00035C74
		// (set) Token: 0x06000A05 RID: 2565 RVA: 0x0000688B File Offset: 0x00004A8B
		public NativeArray<float3> scales
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_scales);
				return new NativeArray<float3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float3>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_scales), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float3>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x00037AA4 File Offset: 0x00035CA4
		// (set) Token: 0x06000A07 RID: 2567 RVA: 0x000068B9 File Offset: 0x00004AB9
		public NativeArray<bool> dirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_dirty);
				return new NativeArray<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_dirty), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x00037AD4 File Offset: 0x00035CD4
		// (set) Token: 0x06000A09 RID: 2569 RVA: 0x000068E7 File Offset: 0x00004AE7
		public unsafe Il2CppStructArray<BoundingSphere> boundingSphereArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_boundingSphereArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<BoundingSphere>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCachedChunk.NativeFieldInfoPtr_boundingSphereArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000759 RID: 1881
		private static readonly IntPtr NativeFieldInfoPtr_propertyBlock;

		// Token: 0x0400075A RID: 1882
		private static readonly IntPtr NativeFieldInfoPtr_passIndexDBuffer;

		// Token: 0x0400075B RID: 1883
		private static readonly IntPtr NativeFieldInfoPtr_passIndexEmissive;

		// Token: 0x0400075C RID: 1884
		private static readonly IntPtr NativeFieldInfoPtr_passIndexScreenSpace;

		// Token: 0x0400075D RID: 1885
		private static readonly IntPtr NativeFieldInfoPtr_passIndexGBuffer;

		// Token: 0x0400075E RID: 1886
		private static readonly IntPtr NativeFieldInfoPtr_drawOrder;

		// Token: 0x0400075F RID: 1887
		private static readonly IntPtr NativeFieldInfoPtr_isCreated;

		// Token: 0x04000760 RID: 1888
		private static readonly IntPtr NativeFieldInfoPtr_decalToWorlds;

		// Token: 0x04000761 RID: 1889
		private static readonly IntPtr NativeFieldInfoPtr_normalToWorlds;

		// Token: 0x04000762 RID: 1890
		private static readonly IntPtr NativeFieldInfoPtr_sizeOffsets;

		// Token: 0x04000763 RID: 1891
		private static readonly IntPtr NativeFieldInfoPtr_drawDistances;

		// Token: 0x04000764 RID: 1892
		private static readonly IntPtr NativeFieldInfoPtr_angleFades;

		// Token: 0x04000765 RID: 1893
		private static readonly IntPtr NativeFieldInfoPtr_uvScaleBias;

		// Token: 0x04000766 RID: 1894
		private static readonly IntPtr NativeFieldInfoPtr_layerMasks;

		// Token: 0x04000767 RID: 1895
		private static readonly IntPtr NativeFieldInfoPtr_sceneLayerMasks;

		// Token: 0x04000768 RID: 1896
		private static readonly IntPtr NativeFieldInfoPtr_fadeFactors;

		// Token: 0x04000769 RID: 1897
		private static readonly IntPtr NativeFieldInfoPtr_boundingSpheres;

		// Token: 0x0400076A RID: 1898
		private static readonly IntPtr NativeFieldInfoPtr_scaleModes;

		// Token: 0x0400076B RID: 1899
		private static readonly IntPtr NativeFieldInfoPtr_renderingLayerMasks;

		// Token: 0x0400076C RID: 1900
		private static readonly IntPtr NativeFieldInfoPtr_positions;

		// Token: 0x0400076D RID: 1901
		private static readonly IntPtr NativeFieldInfoPtr_rotation;

		// Token: 0x0400076E RID: 1902
		private static readonly IntPtr NativeFieldInfoPtr_scales;

		// Token: 0x0400076F RID: 1903
		private static readonly IntPtr NativeFieldInfoPtr_dirty;

		// Token: 0x04000770 RID: 1904
		private static readonly IntPtr NativeFieldInfoPtr_boundingSphereArray;

		// Token: 0x04000771 RID: 1905
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAtSwapBack_Public_Virtual_Void_Int32_0;

		// Token: 0x04000772 RID: 1906
		private static readonly IntPtr NativeMethodInfoPtr_SetCapacity_Public_Virtual_Void_Int32_0;

		// Token: 0x04000773 RID: 1907
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0;

		// Token: 0x04000774 RID: 1908
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
