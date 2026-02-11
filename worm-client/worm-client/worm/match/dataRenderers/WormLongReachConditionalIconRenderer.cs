using System;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using lib.canis.boardgames.src.match;

namespace worm.match.dataRenderers
{
	// Token: 0x02000144 RID: 324
	public class WormLongReachConditionalIconRenderer : WormConditionalIconRenderer
	{
		// Token: 0x06000E9C RID: 3740 RVA: 0x000440B0 File Offset: 0x000422B0
		// Note: this type is marked as 'beforefieldinit'.
		static WormLongReachConditionalIconRenderer()
		{
			Il2CppClassPointerStore<WormLongReachConditionalIconRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormLongReachConditionalIconRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormLongReachConditionalIconRenderer>.NativeClassPtr);
			WormLongReachConditionalIconRenderer.NativeFieldInfoPtr_archetypeProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLongReachConditionalIconRenderer>.NativeClassPtr, "archetypeProvider");
			WormLongReachConditionalIconRenderer.NativeMethodInfoPtr_get_Initialized_Protected_Virtual_Final_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLongReachConditionalIconRenderer>.NativeClassPtr, 100665267);
			WormLongReachConditionalIconRenderer.NativeMethodInfoPtr_init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLongReachConditionalIconRenderer>.NativeClassPtr, 100665268);
			WormLongReachConditionalIconRenderer.NativeMethodInfoPtr_ShowIconsOnTurn_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLongReachConditionalIconRenderer>.NativeClassPtr, 100665269);
			WormLongReachConditionalIconRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLongReachConditionalIconRenderer>.NativeClassPtr, 100665270);
			WormLongReachConditionalIconRenderer.NativeMethodInfoPtr__ShowIconsOnTurn_b__4_2_Private_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLongReachConditionalIconRenderer>.NativeClassPtr, 100665271);
			WormLongReachConditionalIconRenderer.NativeMethodInfoPtr_Method_Internal_Static_Boolean_IHasAttributes_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLongReachConditionalIconRenderer>.NativeClassPtr, 100665272);
			WormLongReachConditionalIconRenderer.NativeMethodInfoPtr_Method_Internal_Static_Boolean_IHasAttributes_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLongReachConditionalIconRenderer>.NativeClassPtr, 100665273);
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000E9D RID: 3741 RVA: 0x00044180 File Offset: 0x00042380
		public unsafe override bool Initialized
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 702967, RefRangeEnd = 702968, XrefRangeStart = 702967, XrefRangeEnd = 702968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLongReachConditionalIconRenderer.NativeMethodInfoPtr_get_Initialized_Protected_Virtual_Final_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x000441BC File Offset: 0x000423BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706743, XrefRangeEnd = 706747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormLongReachConditionalIconRenderer.NativeMethodInfoPtr_init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x000441F8 File Offset: 0x000423F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706747, XrefRangeEnd = 706801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShowIconsOnTurn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormLongReachConditionalIconRenderer.NativeMethodInfoPtr_ShowIconsOnTurn_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x00044240 File Offset: 0x00042440
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 703020, RefRangeEnd = 703021, XrefRangeStart = 703020, XrefRangeEnd = 703021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormLongReachConditionalIconRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormLongReachConditionalIconRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLongReachConditionalIconRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x0004427C File Offset: 0x0004247C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706801, XrefRangeEnd = 706834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _ShowIconsOnTurn_b__4_2(EntityID s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLongReachConditionalIconRenderer.NativeMethodInfoPtr__ShowIconsOnTurn_b__4_2_Private_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x000442CC File Offset: 0x000424CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706834, XrefRangeEnd = 706846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static bool Method_Internal_Static_Boolean_IHasAttributes_PDM_0(IHasAttributes attributes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLongReachConditionalIconRenderer.NativeMethodInfoPtr_Method_Internal_Static_Boolean_IHasAttributes_PDM_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x00044310 File Offset: 0x00042510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706846, XrefRangeEnd = 706847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Method_Internal_Static_Boolean_IHasAttributes_PDM_1(IHasAttributes attributes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLongReachConditionalIconRenderer.NativeMethodInfoPtr_Method_Internal_Static_Boolean_IHasAttributes_PDM_1, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x00009B6E File Offset: 0x00007D6E
		public WormLongReachConditionalIconRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000EA5 RID: 3749 RVA: 0x00044354 File Offset: 0x00042554
		// (set) Token: 0x06000EA6 RID: 3750 RVA: 0x00009B77 File Offset: 0x00007D77
		public unsafe ArchetypeProvider archetypeProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLongReachConditionalIconRenderer.NativeFieldInfoPtr_archetypeProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLongReachConditionalIconRenderer.NativeFieldInfoPtr_archetypeProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400086B RID: 2155
		private static readonly IntPtr NativeFieldInfoPtr_archetypeProvider;

		// Token: 0x0400086C RID: 2156
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Protected_Virtual_Final_get_Boolean_0;

		// Token: 0x0400086D RID: 2157
		private static readonly IntPtr NativeMethodInfoPtr_init_Protected_Virtual_Void_0;

		// Token: 0x0400086E RID: 2158
		private static readonly IntPtr NativeMethodInfoPtr_ShowIconsOnTurn_Protected_Virtual_Boolean_0;

		// Token: 0x0400086F RID: 2159
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000870 RID: 2160
		private static readonly IntPtr NativeMethodInfoPtr__ShowIconsOnTurn_b__4_2_Private_Boolean_EntityID_0;

		// Token: 0x04000871 RID: 2161
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Boolean_IHasAttributes_PDM_0;

		// Token: 0x04000872 RID: 2162
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Boolean_IHasAttributes_PDM_1;

		// Token: 0x02000392 RID: 914
		[ObfuscatedName("worm.match.dataRenderers.WormLongReachConditionalIconRenderer+<>O")]
		public new static class __O : Object
		{
			// Token: 0x060024C5 RID: 9413 RVA: 0x00087508 File Offset: 0x00085708
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<WormLongReachConditionalIconRenderer.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormLongReachConditionalIconRenderer>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormLongReachConditionalIconRenderer.__O>.NativeClassPtr);
				WormLongReachConditionalIconRenderer.__O.NativeFieldInfoPtr__0___IsBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLongReachConditionalIconRenderer.__O>.NativeClassPtr, "<0>__IsBG");
				WormLongReachConditionalIconRenderer.__O.NativeFieldInfoPtr__1___IsBGGraft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLongReachConditionalIconRenderer.__O>.NativeClassPtr, "<1>__IsBGGraft");
			}

			// Token: 0x060024C6 RID: 9414 RVA: 0x0001481F File Offset: 0x00012A1F
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A35 RID: 2613
			// (get) Token: 0x060024C7 RID: 9415 RVA: 0x0008755C File Offset: 0x0008575C
			// (set) Token: 0x060024C8 RID: 9416 RVA: 0x00014828 File Offset: 0x00012A28
			public unsafe static Func<EntityComponent, bool> _0___IsBG
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormLongReachConditionalIconRenderer.__O.NativeFieldInfoPtr__0___IsBG, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormLongReachConditionalIconRenderer.__O.NativeFieldInfoPtr__0___IsBG, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A36 RID: 2614
			// (get) Token: 0x060024C9 RID: 9417 RVA: 0x00087584 File Offset: 0x00085784
			// (set) Token: 0x060024CA RID: 9418 RVA: 0x0001483A File Offset: 0x00012A3A
			public unsafe static Func<EntityComponent, bool> _1___IsBGGraft
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormLongReachConditionalIconRenderer.__O.NativeFieldInfoPtr__1___IsBGGraft, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormLongReachConditionalIconRenderer.__O.NativeFieldInfoPtr__1___IsBGGraft, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400151E RID: 5406
			private static readonly IntPtr NativeFieldInfoPtr__0___IsBG;

			// Token: 0x0400151F RID: 5407
			private static readonly IntPtr NativeFieldInfoPtr__1___IsBGGraft;
		}
	}
}
