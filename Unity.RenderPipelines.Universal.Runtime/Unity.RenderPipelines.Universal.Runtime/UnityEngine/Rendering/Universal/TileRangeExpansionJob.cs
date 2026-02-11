using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000DE RID: 222
	public sealed class TileRangeExpansionJob : ValueType
	{
		// Token: 0x060010F8 RID: 4344 RVA: 0x000507C0 File Offset: 0x0004E9C0
		// Note: this type is marked as 'beforefieldinit'.
		static TileRangeExpansionJob()
		{
			Il2CppClassPointerStore<TileRangeExpansionJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "TileRangeExpansionJob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileRangeExpansionJob>.NativeClassPtr);
			TileRangeExpansionJob.NativeFieldInfoPtr_tileRanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileRangeExpansionJob>.NativeClassPtr, "tileRanges");
			TileRangeExpansionJob.NativeFieldInfoPtr_tileMasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileRangeExpansionJob>.NativeClassPtr, "tileMasks");
			TileRangeExpansionJob.NativeFieldInfoPtr_rangesPerItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileRangeExpansionJob>.NativeClassPtr, "rangesPerItem");
			TileRangeExpansionJob.NativeFieldInfoPtr_itemsPerTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileRangeExpansionJob>.NativeClassPtr, "itemsPerTile");
			TileRangeExpansionJob.NativeFieldInfoPtr_wordsPerTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileRangeExpansionJob>.NativeClassPtr, "wordsPerTile");
			TileRangeExpansionJob.NativeFieldInfoPtr_tileResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileRangeExpansionJob>.NativeClassPtr, "tileResolution");
			TileRangeExpansionJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileRangeExpansionJob>.NativeClassPtr, 100665475);
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x0005087C File Offset: 0x0004EA7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 617965, XrefRangeEnd = 617979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute(int jobIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref jobIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileRangeExpansionJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x0000A15F File Offset: 0x0000835F
		public TileRangeExpansionJob(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x0000A168 File Offset: 0x00008368
		public TileRangeExpansionJob()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileRangeExpansionJob>.NativeClassPtr))
		{
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x060010FC RID: 4348 RVA: 0x000508C0 File Offset: 0x0004EAC0
		// (set) Token: 0x060010FD RID: 4349 RVA: 0x0000A17A File Offset: 0x0000837A
		public NativeArray<InclusiveRange> tileRanges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileRangeExpansionJob.NativeFieldInfoPtr_tileRanges);
				return new NativeArray<InclusiveRange>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<InclusiveRange>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileRangeExpansionJob.NativeFieldInfoPtr_tileRanges), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<InclusiveRange>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x060010FE RID: 4350 RVA: 0x000508F0 File Offset: 0x0004EAF0
		// (set) Token: 0x060010FF RID: 4351 RVA: 0x0000A1A8 File Offset: 0x000083A8
		public NativeArray<uint> tileMasks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileRangeExpansionJob.NativeFieldInfoPtr_tileMasks);
				return new NativeArray<uint>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<uint>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileRangeExpansionJob.NativeFieldInfoPtr_tileMasks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<uint>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06001100 RID: 4352 RVA: 0x00050920 File Offset: 0x0004EB20
		// (set) Token: 0x06001101 RID: 4353 RVA: 0x0000A1D6 File Offset: 0x000083D6
		public unsafe int rangesPerItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileRangeExpansionJob.NativeFieldInfoPtr_rangesPerItem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileRangeExpansionJob.NativeFieldInfoPtr_rangesPerItem)) = value;
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06001102 RID: 4354 RVA: 0x00050948 File Offset: 0x0004EB48
		// (set) Token: 0x06001103 RID: 4355 RVA: 0x0000A1F1 File Offset: 0x000083F1
		public unsafe int itemsPerTile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileRangeExpansionJob.NativeFieldInfoPtr_itemsPerTile);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileRangeExpansionJob.NativeFieldInfoPtr_itemsPerTile)) = value;
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001104 RID: 4356 RVA: 0x00050970 File Offset: 0x0004EB70
		// (set) Token: 0x06001105 RID: 4357 RVA: 0x0000A20C File Offset: 0x0000840C
		public unsafe int wordsPerTile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileRangeExpansionJob.NativeFieldInfoPtr_wordsPerTile);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileRangeExpansionJob.NativeFieldInfoPtr_wordsPerTile)) = value;
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06001106 RID: 4358 RVA: 0x00050998 File Offset: 0x0004EB98
		// (set) Token: 0x06001107 RID: 4359 RVA: 0x0000A227 File Offset: 0x00008427
		public unsafe int2 tileResolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileRangeExpansionJob.NativeFieldInfoPtr_tileResolution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileRangeExpansionJob.NativeFieldInfoPtr_tileResolution)) = value;
			}
		}

		// Token: 0x04000C71 RID: 3185
		private static readonly IntPtr NativeFieldInfoPtr_tileRanges;

		// Token: 0x04000C72 RID: 3186
		private static readonly IntPtr NativeFieldInfoPtr_tileMasks;

		// Token: 0x04000C73 RID: 3187
		private static readonly IntPtr NativeFieldInfoPtr_rangesPerItem;

		// Token: 0x04000C74 RID: 3188
		private static readonly IntPtr NativeFieldInfoPtr_itemsPerTile;

		// Token: 0x04000C75 RID: 3189
		private static readonly IntPtr NativeFieldInfoPtr_wordsPerTile;

		// Token: 0x04000C76 RID: 3190
		private static readonly IntPtr NativeFieldInfoPtr_tileResolution;

		// Token: 0x04000C77 RID: 3191
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;
	}
}
