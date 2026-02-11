using System;
using Canis.utils.ids;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using lotus;

namespace worm
{
	// Token: 0x02000044 RID: 68
	public class WormBoardEntityView : EntityView
	{
		// Token: 0x060002E7 RID: 743 RVA: 0x00021C68 File Offset: 0x0001FE68
		// Note: this type is marked as 'beforefieldinit'.
		static WormBoardEntityView()
		{
			Il2CppClassPointerStore<WormBoardEntityView>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm", "WormBoardEntityView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormBoardEntityView>.NativeClassPtr);
			WormBoardEntityView.NativeFieldInfoPtr_spaceViews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBoardEntityView>.NativeClassPtr, "spaceViews");
			WormBoardEntityView.NativeFieldInfoPtr_ixSpaceViews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBoardEntityView>.NativeClassPtr, "ixSpaceViews");
			WormBoardEntityView.NativeMethodInfoPtr_Event_InitIxBoard_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoardEntityView>.NativeClassPtr, 100663767);
			WormBoardEntityView.NativeMethodInfoPtr_Event_InitBaseBoard_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoardEntityView>.NativeClassPtr, 100663768);
			WormBoardEntityView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoardEntityView>.NativeClassPtr, 100663769);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00021CFC File Offset: 0x0001FEFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690866, XrefRangeEnd = 690884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_InitIxBoard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoardEntityView.NativeMethodInfoPtr_Event_InitIxBoard_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00021D30 File Offset: 0x0001FF30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690884, XrefRangeEnd = 690902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_InitBaseBoard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoardEntityView.NativeMethodInfoPtr_Event_InitBaseBoard_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00021D64 File Offset: 0x0001FF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690902, XrefRangeEnd = 690910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormBoardEntityView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormBoardEntityView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoardEntityView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00003569 File Offset: 0x00001769
		public WormBoardEntityView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060002EC RID: 748 RVA: 0x00021DA0 File Offset: 0x0001FFA0
		// (set) Token: 0x060002ED RID: 749 RVA: 0x00003572 File Offset: 0x00001772
		public unsafe Il2CppReferenceArray<WormBoardEntityView.ViewArchetypePair> spaceViews
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoardEntityView.NativeFieldInfoPtr_spaceViews);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WormBoardEntityView.ViewArchetypePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoardEntityView.NativeFieldInfoPtr_spaceViews), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060002EE RID: 750 RVA: 0x00021DD0 File Offset: 0x0001FFD0
		// (set) Token: 0x060002EF RID: 751 RVA: 0x00003591 File Offset: 0x00001791
		public unsafe Il2CppReferenceArray<WormBoardEntityView.ViewArchetypePair> ixSpaceViews
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoardEntityView.NativeFieldInfoPtr_ixSpaceViews);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WormBoardEntityView.ViewArchetypePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoardEntityView.NativeFieldInfoPtr_ixSpaceViews), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeFieldInfoPtr_spaceViews;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeFieldInfoPtr_ixSpaceViews;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeMethodInfoPtr_Event_InitIxBoard_Public_Void_0;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeMethodInfoPtr_Event_InitBaseBoard_Public_Void_0;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002DD RID: 733
		[Serializable]
		public class ViewArchetypePair : Object
		{
			// Token: 0x06001DDE RID: 7646 RVA: 0x00073AD0 File Offset: 0x00071CD0
			// Note: this type is marked as 'beforefieldinit'.
			static ViewArchetypePair()
			{
				Il2CppClassPointerStore<WormBoardEntityView.ViewArchetypePair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormBoardEntityView>.NativeClassPtr, "ViewArchetypePair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormBoardEntityView.ViewArchetypePair>.NativeClassPtr);
				WormBoardEntityView.ViewArchetypePair.NativeFieldInfoPtr_View = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBoardEntityView.ViewArchetypePair>.NativeClassPtr, "View");
				WormBoardEntityView.ViewArchetypePair.NativeFieldInfoPtr_ArchetypeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBoardEntityView.ViewArchetypePair>.NativeClassPtr, "ArchetypeID");
				WormBoardEntityView.ViewArchetypePair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoardEntityView.ViewArchetypePair>.NativeClassPtr, 100663770);
			}

			// Token: 0x06001DDF RID: 7647 RVA: 0x00073B38 File Offset: 0x00071D38
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ViewArchetypePair()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormBoardEntityView.ViewArchetypePair>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoardEntityView.ViewArchetypePair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DE0 RID: 7648 RVA: 0x00011052 File Offset: 0x0000F252
			public ViewArchetypePair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000832 RID: 2098
			// (get) Token: 0x06001DE1 RID: 7649 RVA: 0x00073B74 File Offset: 0x00071D74
			// (set) Token: 0x06001DE2 RID: 7650 RVA: 0x0001105B File Offset: 0x0000F25B
			public unsafe EntityView View
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoardEntityView.ViewArchetypePair.NativeFieldInfoPtr_View);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoardEntityView.ViewArchetypePair.NativeFieldInfoPtr_View), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000833 RID: 2099
			// (get) Token: 0x06001DE3 RID: 7651 RVA: 0x00073BA4 File Offset: 0x00071DA4
			// (set) Token: 0x06001DE4 RID: 7652 RVA: 0x0001107A File Offset: 0x0000F27A
			public unsafe ArchetypeID ArchetypeID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoardEntityView.ViewArchetypePair.NativeFieldInfoPtr_ArchetypeID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoardEntityView.ViewArchetypePair.NativeFieldInfoPtr_ArchetypeID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001153 RID: 4435
			private static readonly IntPtr NativeFieldInfoPtr_View;

			// Token: 0x04001154 RID: 4436
			private static readonly IntPtr NativeFieldInfoPtr_ArchetypeID;

			// Token: 0x04001155 RID: 4437
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002DE RID: 734
		[ObfuscatedName("worm.WormBoardEntityView+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06001DE5 RID: 7653 RVA: 0x00073BD4 File Offset: 0x00071DD4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<WormBoardEntityView.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormBoardEntityView>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormBoardEntityView.__c__DisplayClass3_0>.NativeClassPtr);
				WormBoardEntityView.__c__DisplayClass3_0.NativeFieldInfoPtr_pair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBoardEntityView.__c__DisplayClass3_0>.NativeClassPtr, "pair");
				WormBoardEntityView.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoardEntityView.__c__DisplayClass3_0>.NativeClassPtr, 100663771);
				WormBoardEntityView.__c__DisplayClass3_0.NativeMethodInfoPtr__Event_InitIxBoard_b__0_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoardEntityView.__c__DisplayClass3_0>.NativeClassPtr, 100663772);
			}

			// Token: 0x06001DE6 RID: 7654 RVA: 0x00073C3C File Offset: 0x00071E3C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormBoardEntityView.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoardEntityView.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DE7 RID: 7655 RVA: 0x00073C78 File Offset: 0x00071E78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690836, XrefRangeEnd = 690851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Event_InitIxBoard_b__0(EntityComponent c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoardEntityView.__c__DisplayClass3_0.NativeMethodInfoPtr__Event_InitIxBoard_b__0_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001DE8 RID: 7656 RVA: 0x00011099 File Offset: 0x0000F299
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000834 RID: 2100
			// (get) Token: 0x06001DE9 RID: 7657 RVA: 0x00073CC8 File Offset: 0x00071EC8
			// (set) Token: 0x06001DEA RID: 7658 RVA: 0x000110A2 File Offset: 0x0000F2A2
			public unsafe WormBoardEntityView.ViewArchetypePair pair
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoardEntityView.__c__DisplayClass3_0.NativeFieldInfoPtr_pair);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormBoardEntityView.ViewArchetypePair>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoardEntityView.__c__DisplayClass3_0.NativeFieldInfoPtr_pair), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001156 RID: 4438
			private static readonly IntPtr NativeFieldInfoPtr_pair;

			// Token: 0x04001157 RID: 4439
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001158 RID: 4440
			private static readonly IntPtr NativeMethodInfoPtr__Event_InitIxBoard_b__0_Internal_Boolean_EntityComponent_0;
		}

		// Token: 0x020002DF RID: 735
		[ObfuscatedName("worm.WormBoardEntityView+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x06001DEB RID: 7659 RVA: 0x00073CF8 File Offset: 0x00071EF8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<WormBoardEntityView.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormBoardEntityView>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormBoardEntityView.__c__DisplayClass4_0>.NativeClassPtr);
				WormBoardEntityView.__c__DisplayClass4_0.NativeFieldInfoPtr_pair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBoardEntityView.__c__DisplayClass4_0>.NativeClassPtr, "pair");
				WormBoardEntityView.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoardEntityView.__c__DisplayClass4_0>.NativeClassPtr, 100663773);
				WormBoardEntityView.__c__DisplayClass4_0.NativeMethodInfoPtr__Event_InitBaseBoard_b__0_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoardEntityView.__c__DisplayClass4_0>.NativeClassPtr, 100663774);
			}

			// Token: 0x06001DEC RID: 7660 RVA: 0x00073D60 File Offset: 0x00071F60
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormBoardEntityView.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoardEntityView.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DED RID: 7661 RVA: 0x00073D9C File Offset: 0x00071F9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690851, XrefRangeEnd = 690866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Event_InitBaseBoard_b__0(EntityComponent c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoardEntityView.__c__DisplayClass4_0.NativeMethodInfoPtr__Event_InitBaseBoard_b__0_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001DEE RID: 7662 RVA: 0x000110C1 File Offset: 0x0000F2C1
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000835 RID: 2101
			// (get) Token: 0x06001DEF RID: 7663 RVA: 0x00073DEC File Offset: 0x00071FEC
			// (set) Token: 0x06001DF0 RID: 7664 RVA: 0x000110CA File Offset: 0x0000F2CA
			public unsafe WormBoardEntityView.ViewArchetypePair pair
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoardEntityView.__c__DisplayClass4_0.NativeFieldInfoPtr_pair);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormBoardEntityView.ViewArchetypePair>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBoardEntityView.__c__DisplayClass4_0.NativeFieldInfoPtr_pair), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001159 RID: 4441
			private static readonly IntPtr NativeFieldInfoPtr_pair;

			// Token: 0x0400115A RID: 4442
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400115B RID: 4443
			private static readonly IntPtr NativeMethodInfoPtr__Event_InitBaseBoard_b__0_Internal_Boolean_EntityComponent_0;
		}
	}
}
