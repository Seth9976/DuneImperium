using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.UI;

namespace dwd.canis.lib.canis.dbg_client.input
{
	// Token: 0x02000057 RID: 87
	public class PaginatedToggleGroup : ToggleGroup
	{
		// Token: 0x06000358 RID: 856 RVA: 0x00028304 File Offset: 0x00026504
		// Note: this type is marked as 'beforefieldinit'.
		static PaginatedToggleGroup()
		{
			Il2CppClassPointerStore<PaginatedToggleGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.lib.canis.dbg_client.input", "PaginatedToggleGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PaginatedToggleGroup>.NativeClassPtr);
			PaginatedToggleGroup.NativeMethodInfoPtr_Event_PaginateUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaginatedToggleGroup>.NativeClassPtr, 100663822);
			PaginatedToggleGroup.NativeMethodInfoPtr_Event_PaginateDown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaginatedToggleGroup>.NativeClassPtr, 100663823);
			PaginatedToggleGroup.NativeMethodInfoPtr_Event_ResetPagination_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaginatedToggleGroup>.NativeClassPtr, 100663824);
			PaginatedToggleGroup.NativeMethodInfoPtr_CanPaginateUp_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaginatedToggleGroup>.NativeClassPtr, 100663825);
			PaginatedToggleGroup.NativeMethodInfoPtr_Paginate_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaginatedToggleGroup>.NativeClassPtr, 100663826);
			PaginatedToggleGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaginatedToggleGroup>.NativeClassPtr, 100663827);
		}

		// Token: 0x06000359 RID: 857 RVA: 0x000283AC File Offset: 0x000265AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499733, XrefRangeEnd = 499734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_PaginateUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PaginatedToggleGroup.NativeMethodInfoPtr_Event_PaginateUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600035A RID: 858 RVA: 0x000283E0 File Offset: 0x000265E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499734, XrefRangeEnd = 499735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_PaginateDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PaginatedToggleGroup.NativeMethodInfoPtr_Event_PaginateDown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00028414 File Offset: 0x00026614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499735, XrefRangeEnd = 499740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ResetPagination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PaginatedToggleGroup.NativeMethodInfoPtr_Event_ResetPagination_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00028448 File Offset: 0x00026648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499740, XrefRangeEnd = 499762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanPaginateUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PaginatedToggleGroup.NativeMethodInfoPtr_CanPaginateUp_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00028484 File Offset: 0x00026684
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 499786, RefRangeEnd = 499788, XrefRangeStart = 499762, XrefRangeEnd = 499786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Paginate(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PaginatedToggleGroup.NativeMethodInfoPtr_Paginate_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600035E RID: 862 RVA: 0x000284C4 File Offset: 0x000266C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499788, XrefRangeEnd = 499789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PaginatedToggleGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PaginatedToggleGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PaginatedToggleGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0000376C File Offset: 0x0000196C
		public PaginatedToggleGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeMethodInfoPtr_Event_PaginateUp_Public_Void_0;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeMethodInfoPtr_Event_PaginateDown_Public_Void_0;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeMethodInfoPtr_Event_ResetPagination_Public_Void_0;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeMethodInfoPtr_CanPaginateUp_Public_Boolean_0;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeMethodInfoPtr_Paginate_Private_Void_Int32_0;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002E9 RID: 745
		[ObfuscatedName("dwd.canis.lib.canis.dbg_client.input.PaginatedToggleGroup+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06002329 RID: 9001 RVA: 0x00091A98 File Offset: 0x0008FC98
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PaginatedToggleGroup.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PaginatedToggleGroup>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PaginatedToggleGroup.__c>.NativeClassPtr);
				PaginatedToggleGroup.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaginatedToggleGroup.__c>.NativeClassPtr, "<>9");
				PaginatedToggleGroup.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaginatedToggleGroup.__c>.NativeClassPtr, "<>9__3_0");
				PaginatedToggleGroup.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaginatedToggleGroup.__c>.NativeClassPtr, "<>9__4_0");
				PaginatedToggleGroup.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaginatedToggleGroup.__c>.NativeClassPtr, 100663829);
				PaginatedToggleGroup.__c.NativeMethodInfoPtr__CanPaginateUp_b__3_0_Internal_Boolean_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaginatedToggleGroup.__c>.NativeClassPtr, 100663830);
				PaginatedToggleGroup.__c.NativeMethodInfoPtr__Paginate_b__4_0_Internal_Boolean_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaginatedToggleGroup.__c>.NativeClassPtr, 100663831);
			}

			// Token: 0x0600232A RID: 9002 RVA: 0x00091B3C File Offset: 0x0008FD3C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PaginatedToggleGroup.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PaginatedToggleGroup.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600232B RID: 9003 RVA: 0x00091B78 File Offset: 0x0008FD78
			[CallerCount(0)]
			public unsafe bool _CanPaginateUp_b__3_0(Toggle x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PaginatedToggleGroup.__c.NativeMethodInfoPtr__CanPaginateUp_b__3_0_Internal_Boolean_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600232C RID: 9004 RVA: 0x00091BC8 File Offset: 0x0008FDC8
			[CallerCount(0)]
			public unsafe bool _Paginate_b__4_0(Toggle x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PaginatedToggleGroup.__c.NativeMethodInfoPtr__Paginate_b__4_0_Internal_Boolean_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600232D RID: 9005 RVA: 0x0001251B File Offset: 0x0001071B
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000985 RID: 2437
			// (get) Token: 0x0600232E RID: 9006 RVA: 0x00091C18 File Offset: 0x0008FE18
			// (set) Token: 0x0600232F RID: 9007 RVA: 0x00012524 File Offset: 0x00010724
			public unsafe static PaginatedToggleGroup.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PaginatedToggleGroup.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PaginatedToggleGroup.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PaginatedToggleGroup.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000986 RID: 2438
			// (get) Token: 0x06002330 RID: 9008 RVA: 0x00091C40 File Offset: 0x0008FE40
			// (set) Token: 0x06002331 RID: 9009 RVA: 0x00012536 File Offset: 0x00010736
			public unsafe static Predicate<Toggle> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PaginatedToggleGroup.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Toggle>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PaginatedToggleGroup.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000987 RID: 2439
			// (get) Token: 0x06002332 RID: 9010 RVA: 0x00091C68 File Offset: 0x0008FE68
			// (set) Token: 0x06002333 RID: 9011 RVA: 0x00012548 File Offset: 0x00010748
			public unsafe static Predicate<Toggle> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PaginatedToggleGroup.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Toggle>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PaginatedToggleGroup.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400161A RID: 5658
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400161B RID: 5659
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x0400161C RID: 5660
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x0400161D RID: 5661
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400161E RID: 5662
			private static readonly IntPtr NativeMethodInfoPtr__CanPaginateUp_b__3_0_Internal_Boolean_Toggle_0;

			// Token: 0x0400161F RID: 5663
			private static readonly IntPtr NativeMethodInfoPtr__Paginate_b__4_0_Internal_Boolean_Toggle_0;
		}
	}
}
