using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200011B RID: 283
	public sealed class SequenceNode : InteriorNode
	{
		// Token: 0x060018FA RID: 6394 RVA: 0x00080584 File Offset: 0x0007E784
		// Note: this type is marked as 'beforefieldinit'.
		static SequenceNode()
		{
			Il2CppClassPointerStore<SequenceNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SequenceNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceNode>.NativeClassPtr);
			SequenceNode.NativeMethodInfoPtr_ConstructPos_Public_Virtual_Void_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNode>.NativeClassPtr, 100667151);
			SequenceNode.NativeMethodInfoPtr_get_IsNullable_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNode>.NativeClassPtr, 100667152);
			SequenceNode.NativeMethodInfoPtr_ExpandTree_Public_Virtual_Void_InteriorNode_SymbolsDictionary_Positions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNode>.NativeClassPtr, 100667153);
			SequenceNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNode>.NativeClassPtr, 100667154);
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x00080604 File Offset: 0x0007E804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392329, XrefRangeEnd = 392381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ConstructPos(BitSet firstpos, BitSet lastpos, Il2CppReferenceArray<BitSet> followpos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(firstpos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lastpos);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(followpos);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceNode.NativeMethodInfoPtr_ConstructPos_Public_Virtual_Void_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x060018FC RID: 6396 RVA: 0x0008066C File Offset: 0x0007E86C
		public unsafe override bool IsNullable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392381, XrefRangeEnd = 392390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceNode.NativeMethodInfoPtr_get_IsNullable_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x000806A8 File Offset: 0x0007E8A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392390, XrefRangeEnd = 392391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(symbols);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(positions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceNode.NativeMethodInfoPtr_ExpandTree_Public_Virtual_Void_InteriorNode_SymbolsDictionary_Positions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x00080710 File Offset: 0x0007E910
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceNode()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceNode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x0000AB05 File Offset: 0x00008D05
		public SequenceNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001378 RID: 4984
		private static readonly IntPtr NativeMethodInfoPtr_ConstructPos_Public_Virtual_Void_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0;

		// Token: 0x04001379 RID: 4985
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNullable_Public_Virtual_get_Boolean_0;

		// Token: 0x0400137A RID: 4986
		private static readonly IntPtr NativeMethodInfoPtr_ExpandTree_Public_Virtual_Void_InteriorNode_SymbolsDictionary_Positions_0;

		// Token: 0x0400137B RID: 4987
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000256 RID: 598
		public sealed class SequenceConstructPosContext : ValueType
		{
			// Token: 0x06003150 RID: 12624 RVA: 0x000DCAD4 File Offset: 0x000DACD4
			// Note: this type is marked as 'beforefieldinit'.
			static SequenceConstructPosContext()
			{
				Il2CppClassPointerStore<SequenceNode.SequenceConstructPosContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceNode>.NativeClassPtr, "SequenceConstructPosContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceNode.SequenceConstructPosContext>.NativeClassPtr);
				SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_this_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceNode.SequenceConstructPosContext>.NativeClassPtr, "this_");
				SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_firstpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceNode.SequenceConstructPosContext>.NativeClassPtr, "firstpos");
				SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_lastpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceNode.SequenceConstructPosContext>.NativeClassPtr, "lastpos");
				SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_lastposLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceNode.SequenceConstructPosContext>.NativeClassPtr, "lastposLeft");
				SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_firstposRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceNode.SequenceConstructPosContext>.NativeClassPtr, "firstposRight");
				SequenceNode.SequenceConstructPosContext.NativeMethodInfoPtr__ctor_Public_Void_SequenceNode_BitSet_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNode.SequenceConstructPosContext>.NativeClassPtr, 100667155);
			}

			// Token: 0x06003151 RID: 12625 RVA: 0x000DCB78 File Offset: 0x000DAD78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392324, XrefRangeEnd = 392329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SequenceConstructPosContext(SequenceNode node, BitSet firstpos, BitSet lastpos)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceNode.SequenceConstructPosContext>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(firstpos);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lastpos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceNode.SequenceConstructPosContext.NativeMethodInfoPtr__ctor_Public_Void_SequenceNode_BitSet_BitSet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003152 RID: 12626 RVA: 0x00014DC4 File Offset: 0x00012FC4
			public SequenceConstructPosContext(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003153 RID: 12627 RVA: 0x00014DCD File Offset: 0x00012FCD
			public SequenceConstructPosContext()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceNode.SequenceConstructPosContext>.NativeClassPtr))
			{
			}

			// Token: 0x1700109C RID: 4252
			// (get) Token: 0x06003154 RID: 12628 RVA: 0x000DCBEC File Offset: 0x000DADEC
			// (set) Token: 0x06003155 RID: 12629 RVA: 0x00014DDF File Offset: 0x00012FDF
			public unsafe SequenceNode this_
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_this_);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_this_), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700109D RID: 4253
			// (get) Token: 0x06003156 RID: 12630 RVA: 0x000DCC1C File Offset: 0x000DAE1C
			// (set) Token: 0x06003157 RID: 12631 RVA: 0x00014DFE File Offset: 0x00012FFE
			public unsafe BitSet firstpos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_firstpos);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BitSet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_firstpos), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700109E RID: 4254
			// (get) Token: 0x06003158 RID: 12632 RVA: 0x000DCC4C File Offset: 0x000DAE4C
			// (set) Token: 0x06003159 RID: 12633 RVA: 0x00014E1D File Offset: 0x0001301D
			public unsafe BitSet lastpos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_lastpos);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BitSet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_lastpos), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700109F RID: 4255
			// (get) Token: 0x0600315A RID: 12634 RVA: 0x000DCC7C File Offset: 0x000DAE7C
			// (set) Token: 0x0600315B RID: 12635 RVA: 0x00014E3C File Offset: 0x0001303C
			public unsafe BitSet lastposLeft
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_lastposLeft);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BitSet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_lastposLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010A0 RID: 4256
			// (get) Token: 0x0600315C RID: 12636 RVA: 0x000DCCAC File Offset: 0x000DAEAC
			// (set) Token: 0x0600315D RID: 12637 RVA: 0x00014E5B File Offset: 0x0001305B
			public unsafe BitSet firstposRight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_firstposRight);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BitSet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_firstposRight), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400262B RID: 9771
			private static readonly IntPtr NativeFieldInfoPtr_this_;

			// Token: 0x0400262C RID: 9772
			private static readonly IntPtr NativeFieldInfoPtr_firstpos;

			// Token: 0x0400262D RID: 9773
			private static readonly IntPtr NativeFieldInfoPtr_lastpos;

			// Token: 0x0400262E RID: 9774
			private static readonly IntPtr NativeFieldInfoPtr_lastposLeft;

			// Token: 0x0400262F RID: 9775
			private static readonly IntPtr NativeFieldInfoPtr_firstposRight;

			// Token: 0x04002630 RID: 9776
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceNode_BitSet_BitSet_0;
		}
	}
}
