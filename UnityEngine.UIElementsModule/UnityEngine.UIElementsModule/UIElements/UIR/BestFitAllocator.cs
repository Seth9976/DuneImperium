using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x0200024B RID: 587
	public class BestFitAllocator : Object
	{
		// Token: 0x06002B98 RID: 11160 RVA: 0x000BC9FC File Offset: 0x000BABFC
		// Note: this type is marked as 'beforefieldinit'.
		static BestFitAllocator()
		{
			Il2CppClassPointerStore<BestFitAllocator>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "BestFitAllocator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BestFitAllocator>.NativeClassPtr);
			BestFitAllocator.NativeFieldInfoPtr__totalSize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BestFitAllocator>.NativeClassPtr, "<totalSize>k__BackingField");
			BestFitAllocator.NativeFieldInfoPtr_m_FirstBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BestFitAllocator>.NativeClassPtr, "m_FirstBlock");
			BestFitAllocator.NativeFieldInfoPtr_m_FirstAvailableBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BestFitAllocator>.NativeClassPtr, "m_FirstAvailableBlock");
			BestFitAllocator.NativeFieldInfoPtr_m_BlockPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BestFitAllocator>.NativeClassPtr, "m_BlockPool");
			BestFitAllocator.NativeFieldInfoPtr_m_HighWatermark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BestFitAllocator>.NativeClassPtr, "m_HighWatermark");
			BestFitAllocator.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BestFitAllocator>.NativeClassPtr, 100669774);
			BestFitAllocator.NativeMethodInfoPtr_get_totalSize_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BestFitAllocator>.NativeClassPtr, 100669775);
			BestFitAllocator.NativeMethodInfoPtr_get_highWatermark_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BestFitAllocator>.NativeClassPtr, 100669776);
			BestFitAllocator.NativeMethodInfoPtr_Allocate_Public_Alloc_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BestFitAllocator>.NativeClassPtr, 100669777);
			BestFitAllocator.NativeMethodInfoPtr_Free_Public_Void_Alloc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BestFitAllocator>.NativeClassPtr, 100669778);
			BestFitAllocator.NativeMethodInfoPtr_CoalesceBlockWithPrevious_Private_Block_Block_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BestFitAllocator>.NativeClassPtr, 100669779);
			BestFitAllocator.NativeMethodInfoPtr_BestFitFindAvailableBlock_Private_Block_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BestFitAllocator>.NativeClassPtr, 100669780);
			BestFitAllocator.NativeMethodInfoPtr_SplitBlock_Private_Void_Block_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BestFitAllocator>.NativeClassPtr, 100669781);
		}

		// Token: 0x06002B99 RID: 11161 RVA: 0x000BCB30 File Offset: 0x000BAD30
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 349519, RefRangeEnd = 349526, XrefRangeStart = 349494, XrefRangeEnd = 349519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BestFitAllocator(uint size)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BestFitAllocator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BestFitAllocator.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D90 RID: 3472
		// (get) Token: 0x06002B9A RID: 11162 RVA: 0x000BCB78 File Offset: 0x000BAD78
		public unsafe uint totalSize
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BestFitAllocator.NativeMethodInfoPtr_get_totalSize_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x06002B9B RID: 11163 RVA: 0x000BCBB4 File Offset: 0x000BADB4
		public unsafe uint highWatermark
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BestFitAllocator.NativeMethodInfoPtr_get_highWatermark_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B9C RID: 11164 RVA: 0x000BCBF0 File Offset: 0x000BADF0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 349556, RefRangeEnd = 349562, XrefRangeStart = 349526, XrefRangeEnd = 349556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Alloc Allocate(uint size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BestFitAllocator.NativeMethodInfoPtr_Allocate_Public_Alloc_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Alloc(intPtr);
			}
		}

		// Token: 0x06002B9D RID: 11165 RVA: 0x000BCC34 File Offset: 0x000BAE34
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 349585, RefRangeEnd = 349594, XrefRangeStart = 349562, XrefRangeEnd = 349585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Free(Alloc alloc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(alloc));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BestFitAllocator.NativeMethodInfoPtr_Free_Public_Void_Alloc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B9E RID: 11166 RVA: 0x000BCC7C File Offset: 0x000BAE7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 349606, RefRangeEnd = 349608, XrefRangeStart = 349594, XrefRangeEnd = 349606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BestFitAllocator.Block CoalesceBlockWithPrevious(BestFitAllocator.Block block)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(block);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BestFitAllocator.NativeMethodInfoPtr_CoalesceBlockWithPrevious_Private_Block_Block_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BestFitAllocator.Block>(intPtr3) : null;
			}
		}

		// Token: 0x06002B9F RID: 11167 RVA: 0x000BCCCC File Offset: 0x000BAECC
		[CallerCount(0)]
		public unsafe BestFitAllocator.Block BestFitFindAvailableBlock(uint size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BestFitAllocator.NativeMethodInfoPtr_BestFitFindAvailableBlock_Private_Block_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BestFitAllocator.Block>(intPtr3) : null;
			}
		}

		// Token: 0x06002BA0 RID: 11168 RVA: 0x000BCD18 File Offset: 0x000BAF18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349608, XrefRangeEnd = 349623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SplitBlock(BestFitAllocator.Block block, uint size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(block);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BestFitAllocator.NativeMethodInfoPtr_SplitBlock_Private_Void_Block_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BA1 RID: 11169 RVA: 0x000119F6 File Offset: 0x0000FBF6
		public BestFitAllocator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D8B RID: 3467
		// (get) Token: 0x06002BA2 RID: 11170 RVA: 0x000BCD68 File Offset: 0x000BAF68
		// (set) Token: 0x06002BA3 RID: 11171 RVA: 0x000119FF File Offset: 0x0000FBFF
		public unsafe uint _totalSize_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.NativeFieldInfoPtr__totalSize_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.NativeFieldInfoPtr__totalSize_k__BackingField)) = value;
			}
		}

		// Token: 0x17000D8C RID: 3468
		// (get) Token: 0x06002BA4 RID: 11172 RVA: 0x000BCD90 File Offset: 0x000BAF90
		// (set) Token: 0x06002BA5 RID: 11173 RVA: 0x00011A1A File Offset: 0x0000FC1A
		public unsafe BestFitAllocator.Block m_FirstBlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.NativeFieldInfoPtr_m_FirstBlock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BestFitAllocator.Block>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.NativeFieldInfoPtr_m_FirstBlock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D8D RID: 3469
		// (get) Token: 0x06002BA6 RID: 11174 RVA: 0x000BCDC0 File Offset: 0x000BAFC0
		// (set) Token: 0x06002BA7 RID: 11175 RVA: 0x00011A39 File Offset: 0x0000FC39
		public unsafe BestFitAllocator.Block m_FirstAvailableBlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.NativeFieldInfoPtr_m_FirstAvailableBlock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BestFitAllocator.Block>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.NativeFieldInfoPtr_m_FirstAvailableBlock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D8E RID: 3470
		// (get) Token: 0x06002BA8 RID: 11176 RVA: 0x000BCDF0 File Offset: 0x000BAFF0
		// (set) Token: 0x06002BA9 RID: 11177 RVA: 0x00011A58 File Offset: 0x0000FC58
		public unsafe BestFitAllocator.BlockPool m_BlockPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.NativeFieldInfoPtr_m_BlockPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BestFitAllocator.BlockPool>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.NativeFieldInfoPtr_m_BlockPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x06002BAA RID: 11178 RVA: 0x000BCE20 File Offset: 0x000BB020
		// (set) Token: 0x06002BAB RID: 11179 RVA: 0x00011A77 File Offset: 0x0000FC77
		public unsafe uint m_HighWatermark
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.NativeFieldInfoPtr_m_HighWatermark);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.NativeFieldInfoPtr_m_HighWatermark)) = value;
			}
		}

		// Token: 0x04001F08 RID: 7944
		private static readonly IntPtr NativeFieldInfoPtr__totalSize_k__BackingField;

		// Token: 0x04001F09 RID: 7945
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstBlock;

		// Token: 0x04001F0A RID: 7946
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstAvailableBlock;

		// Token: 0x04001F0B RID: 7947
		private static readonly IntPtr NativeFieldInfoPtr_m_BlockPool;

		// Token: 0x04001F0C RID: 7948
		private static readonly IntPtr NativeFieldInfoPtr_m_HighWatermark;

		// Token: 0x04001F0D RID: 7949
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04001F0E RID: 7950
		private static readonly IntPtr NativeMethodInfoPtr_get_totalSize_Public_get_UInt32_0;

		// Token: 0x04001F0F RID: 7951
		private static readonly IntPtr NativeMethodInfoPtr_get_highWatermark_Public_get_UInt32_0;

		// Token: 0x04001F10 RID: 7952
		private static readonly IntPtr NativeMethodInfoPtr_Allocate_Public_Alloc_UInt32_0;

		// Token: 0x04001F11 RID: 7953
		private static readonly IntPtr NativeMethodInfoPtr_Free_Public_Void_Alloc_0;

		// Token: 0x04001F12 RID: 7954
		private static readonly IntPtr NativeMethodInfoPtr_CoalesceBlockWithPrevious_Private_Block_Block_0;

		// Token: 0x04001F13 RID: 7955
		private static readonly IntPtr NativeMethodInfoPtr_BestFitFindAvailableBlock_Private_Block_UInt32_0;

		// Token: 0x04001F14 RID: 7956
		private static readonly IntPtr NativeMethodInfoPtr_SplitBlock_Private_Void_Block_UInt32_0;

		// Token: 0x0200054C RID: 1356
		public class BlockPool : LinkedPool<BestFitAllocator.Block>
		{
			// Token: 0x06004134 RID: 16692 RVA: 0x00101A24 File Offset: 0x000FFC24
			// Note: this type is marked as 'beforefieldinit'.
			static BlockPool()
			{
				Il2CppClassPointerStore<BestFitAllocator.BlockPool>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BestFitAllocator>.NativeClassPtr, "BlockPool");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BestFitAllocator.BlockPool>.NativeClassPtr);
				BestFitAllocator.BlockPool.NativeMethodInfoPtr_CreateBlock_Private_Static_Block_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BestFitAllocator.BlockPool>.NativeClassPtr, 100669782);
				BestFitAllocator.BlockPool.NativeMethodInfoPtr_ResetBlock_Private_Static_Void_Block_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BestFitAllocator.BlockPool>.NativeClassPtr, 100669783);
				BestFitAllocator.BlockPool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BestFitAllocator.BlockPool>.NativeClassPtr, 100669784);
			}

			// Token: 0x06004135 RID: 16693 RVA: 0x00101A8C File Offset: 0x000FFC8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349470, XrefRangeEnd = 349476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static BestFitAllocator.Block CreateBlock()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BestFitAllocator.BlockPool.NativeMethodInfoPtr_CreateBlock_Private_Static_Block_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BestFitAllocator.Block>(intPtr3) : null;
			}

			// Token: 0x06004136 RID: 16694 RVA: 0x00101AC0 File Offset: 0x000FFCC0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void ResetBlock(BestFitAllocator.Block block)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(block);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BestFitAllocator.BlockPool.NativeMethodInfoPtr_ResetBlock_Private_Static_Void_Block_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004137 RID: 16695 RVA: 0x00101AF8 File Offset: 0x000FFCF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349476, XrefRangeEnd = 349491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BlockPool()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BestFitAllocator.BlockPool>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BestFitAllocator.BlockPool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004138 RID: 16696 RVA: 0x0001B92B File Offset: 0x00019B2B
			public BlockPool(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002DDF RID: 11743
			private static readonly IntPtr NativeMethodInfoPtr_CreateBlock_Private_Static_Block_0;

			// Token: 0x04002DE0 RID: 11744
			private static readonly IntPtr NativeMethodInfoPtr_ResetBlock_Private_Static_Void_Block_0;

			// Token: 0x04002DE1 RID: 11745
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200054D RID: 1357
		public class Block : LinkedPoolItem<BestFitAllocator.Block>
		{
			// Token: 0x06004139 RID: 16697 RVA: 0x00101B34 File Offset: 0x000FFD34
			// Note: this type is marked as 'beforefieldinit'.
			static Block()
			{
				Il2CppClassPointerStore<BestFitAllocator.Block>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BestFitAllocator>.NativeClassPtr, "Block");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BestFitAllocator.Block>.NativeClassPtr);
				BestFitAllocator.Block.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BestFitAllocator.Block>.NativeClassPtr, "start");
				BestFitAllocator.Block.NativeFieldInfoPtr_end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BestFitAllocator.Block>.NativeClassPtr, "end");
				BestFitAllocator.Block.NativeFieldInfoPtr_prev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BestFitAllocator.Block>.NativeClassPtr, "prev");
				BestFitAllocator.Block.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BestFitAllocator.Block>.NativeClassPtr, "next");
				BestFitAllocator.Block.NativeFieldInfoPtr_prevAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BestFitAllocator.Block>.NativeClassPtr, "prevAvailable");
				BestFitAllocator.Block.NativeFieldInfoPtr_nextAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BestFitAllocator.Block>.NativeClassPtr, "nextAvailable");
				BestFitAllocator.Block.NativeFieldInfoPtr_allocated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BestFitAllocator.Block>.NativeClassPtr, "allocated");
				BestFitAllocator.Block.NativeMethodInfoPtr_get_size_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BestFitAllocator.Block>.NativeClassPtr, 100669785);
				BestFitAllocator.Block.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BestFitAllocator.Block>.NativeClassPtr, 100669786);
			}

			// Token: 0x1700138E RID: 5006
			// (get) Token: 0x0600413A RID: 16698 RVA: 0x00101C14 File Offset: 0x000FFE14
			public unsafe uint size
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BestFitAllocator.Block.NativeMethodInfoPtr_get_size_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600413B RID: 16699 RVA: 0x00101C50 File Offset: 0x000FFE50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349491, XrefRangeEnd = 349494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Block()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BestFitAllocator.Block>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BestFitAllocator.Block.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600413C RID: 16700 RVA: 0x0001B934 File Offset: 0x00019B34
			public Block(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001387 RID: 4999
			// (get) Token: 0x0600413D RID: 16701 RVA: 0x00101C8C File Offset: 0x000FFE8C
			// (set) Token: 0x0600413E RID: 16702 RVA: 0x0001B93D File Offset: 0x00019B3D
			public unsafe uint start
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.Block.NativeFieldInfoPtr_start);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.Block.NativeFieldInfoPtr_start)) = value;
				}
			}

			// Token: 0x17001388 RID: 5000
			// (get) Token: 0x0600413F RID: 16703 RVA: 0x00101CB4 File Offset: 0x000FFEB4
			// (set) Token: 0x06004140 RID: 16704 RVA: 0x0001B958 File Offset: 0x00019B58
			public unsafe uint end
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.Block.NativeFieldInfoPtr_end);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.Block.NativeFieldInfoPtr_end)) = value;
				}
			}

			// Token: 0x17001389 RID: 5001
			// (get) Token: 0x06004141 RID: 16705 RVA: 0x00101CDC File Offset: 0x000FFEDC
			// (set) Token: 0x06004142 RID: 16706 RVA: 0x0001B973 File Offset: 0x00019B73
			public unsafe BestFitAllocator.Block prev
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.Block.NativeFieldInfoPtr_prev);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BestFitAllocator.Block>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.Block.NativeFieldInfoPtr_prev), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700138A RID: 5002
			// (get) Token: 0x06004143 RID: 16707 RVA: 0x00101D0C File Offset: 0x000FFF0C
			// (set) Token: 0x06004144 RID: 16708 RVA: 0x0001B992 File Offset: 0x00019B92
			public unsafe BestFitAllocator.Block next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.Block.NativeFieldInfoPtr_next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BestFitAllocator.Block>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.Block.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700138B RID: 5003
			// (get) Token: 0x06004145 RID: 16709 RVA: 0x00101D3C File Offset: 0x000FFF3C
			// (set) Token: 0x06004146 RID: 16710 RVA: 0x0001B9B1 File Offset: 0x00019BB1
			public unsafe BestFitAllocator.Block prevAvailable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.Block.NativeFieldInfoPtr_prevAvailable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BestFitAllocator.Block>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.Block.NativeFieldInfoPtr_prevAvailable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700138C RID: 5004
			// (get) Token: 0x06004147 RID: 16711 RVA: 0x00101D6C File Offset: 0x000FFF6C
			// (set) Token: 0x06004148 RID: 16712 RVA: 0x0001B9D0 File Offset: 0x00019BD0
			public unsafe BestFitAllocator.Block nextAvailable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.Block.NativeFieldInfoPtr_nextAvailable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BestFitAllocator.Block>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.Block.NativeFieldInfoPtr_nextAvailable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700138D RID: 5005
			// (get) Token: 0x06004149 RID: 16713 RVA: 0x00101D9C File Offset: 0x000FFF9C
			// (set) Token: 0x0600414A RID: 16714 RVA: 0x0001B9EF File Offset: 0x00019BEF
			public unsafe bool allocated
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.Block.NativeFieldInfoPtr_allocated);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BestFitAllocator.Block.NativeFieldInfoPtr_allocated)) = value;
				}
			}

			// Token: 0x04002DE2 RID: 11746
			private static readonly IntPtr NativeFieldInfoPtr_start;

			// Token: 0x04002DE3 RID: 11747
			private static readonly IntPtr NativeFieldInfoPtr_end;

			// Token: 0x04002DE4 RID: 11748
			private static readonly IntPtr NativeFieldInfoPtr_prev;

			// Token: 0x04002DE5 RID: 11749
			private static readonly IntPtr NativeFieldInfoPtr_next;

			// Token: 0x04002DE6 RID: 11750
			private static readonly IntPtr NativeFieldInfoPtr_prevAvailable;

			// Token: 0x04002DE7 RID: 11751
			private static readonly IntPtr NativeFieldInfoPtr_nextAvailable;

			// Token: 0x04002DE8 RID: 11752
			private static readonly IntPtr NativeFieldInfoPtr_allocated;

			// Token: 0x04002DE9 RID: 11753
			private static readonly IntPtr NativeMethodInfoPtr_get_size_Public_get_UInt32_0;

			// Token: 0x04002DEA RID: 11754
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
