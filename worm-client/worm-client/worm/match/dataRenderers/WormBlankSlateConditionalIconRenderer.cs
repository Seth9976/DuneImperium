using System;
using Canis.utils.ids;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using lib.canis.boardgames.src.match;

namespace worm.match.dataRenderers
{
	// Token: 0x020000FB RID: 251
	public class WormBlankSlateConditionalIconRenderer : WormConditionalIconRenderer
	{
		// Token: 0x06000B38 RID: 2872 RVA: 0x0003A274 File Offset: 0x00038474
		// Note: this type is marked as 'beforefieldinit'.
		static WormBlankSlateConditionalIconRenderer()
		{
			Il2CppClassPointerStore<WormBlankSlateConditionalIconRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormBlankSlateConditionalIconRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormBlankSlateConditionalIconRenderer>.NativeClassPtr);
			WormBlankSlateConditionalIconRenderer.NativeFieldInfoPtr_archetypeProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBlankSlateConditionalIconRenderer>.NativeClassPtr, "archetypeProvider");
			WormBlankSlateConditionalIconRenderer.NativeMethodInfoPtr_get_Initialized_Protected_Virtual_Final_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBlankSlateConditionalIconRenderer>.NativeClassPtr, 100664855);
			WormBlankSlateConditionalIconRenderer.NativeMethodInfoPtr_init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBlankSlateConditionalIconRenderer>.NativeClassPtr, 100664856);
			WormBlankSlateConditionalIconRenderer.NativeMethodInfoPtr_ShowIconsOnTurn_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBlankSlateConditionalIconRenderer>.NativeClassPtr, 100664857);
			WormBlankSlateConditionalIconRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBlankSlateConditionalIconRenderer>.NativeClassPtr, 100664858);
			WormBlankSlateConditionalIconRenderer.NativeMethodInfoPtr__ShowIconsOnTurn_b__4_0_Private_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBlankSlateConditionalIconRenderer>.NativeClassPtr, 100664859);
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000B39 RID: 2873 RVA: 0x0003A31C File Offset: 0x0003851C
		public unsafe override bool Initialized
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 702967, RefRangeEnd = 702968, XrefRangeStart = 702967, XrefRangeEnd = 702967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBlankSlateConditionalIconRenderer.NativeMethodInfoPtr_get_Initialized_Protected_Virtual_Final_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x0003A358 File Offset: 0x00038558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702968, XrefRangeEnd = 702985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormBlankSlateConditionalIconRenderer.NativeMethodInfoPtr_init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x0003A394 File Offset: 0x00038594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702985, XrefRangeEnd = 703019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShowIconsOnTurn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormBlankSlateConditionalIconRenderer.NativeMethodInfoPtr_ShowIconsOnTurn_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x0003A3DC File Offset: 0x000385DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 703020, RefRangeEnd = 703021, XrefRangeStart = 703019, XrefRangeEnd = 703020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormBlankSlateConditionalIconRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormBlankSlateConditionalIconRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBlankSlateConditionalIconRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x0003A418 File Offset: 0x00038618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703021, XrefRangeEnd = 703023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _ShowIconsOnTurn_b__4_0(EntityID s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBlankSlateConditionalIconRenderer.NativeMethodInfoPtr__ShowIconsOnTurn_b__4_0_Private_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x00007E97 File Offset: 0x00006097
		public WormBlankSlateConditionalIconRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000B3F RID: 2879 RVA: 0x0003A468 File Offset: 0x00038668
		// (set) Token: 0x06000B40 RID: 2880 RVA: 0x00007EA0 File Offset: 0x000060A0
		public unsafe ArchetypeProvider archetypeProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBlankSlateConditionalIconRenderer.NativeFieldInfoPtr_archetypeProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBlankSlateConditionalIconRenderer.NativeFieldInfoPtr_archetypeProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400067B RID: 1659
		private static readonly IntPtr NativeFieldInfoPtr_archetypeProvider;

		// Token: 0x0400067C RID: 1660
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Protected_Virtual_Final_get_Boolean_0;

		// Token: 0x0400067D RID: 1661
		private static readonly IntPtr NativeMethodInfoPtr_init_Protected_Virtual_Void_0;

		// Token: 0x0400067E RID: 1662
		private static readonly IntPtr NativeMethodInfoPtr_ShowIconsOnTurn_Protected_Virtual_Boolean_0;

		// Token: 0x0400067F RID: 1663
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000680 RID: 1664
		private static readonly IntPtr NativeMethodInfoPtr__ShowIconsOnTurn_b__4_0_Private_Boolean_EntityID_0;

		// Token: 0x02000364 RID: 868
		[ObfuscatedName("worm.match.dataRenderers.WormBlankSlateConditionalIconRenderer+<>O")]
		public new static class __O : Object
		{
			// Token: 0x06002300 RID: 8960 RVA: 0x000138FF File Offset: 0x00011AFF
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<WormBlankSlateConditionalIconRenderer.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormBlankSlateConditionalIconRenderer>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormBlankSlateConditionalIconRenderer.__O>.NativeClassPtr);
				WormBlankSlateConditionalIconRenderer.__O.NativeFieldInfoPtr__0___IsGraft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBlankSlateConditionalIconRenderer.__O>.NativeClassPtr, "<0>__IsGraft");
			}

			// Token: 0x06002301 RID: 8961 RVA: 0x00013933 File Offset: 0x00011B33
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009A6 RID: 2470
			// (get) Token: 0x06002302 RID: 8962 RVA: 0x000826D4 File Offset: 0x000808D4
			// (set) Token: 0x06002303 RID: 8963 RVA: 0x0001393C File Offset: 0x00011B3C
			public unsafe static Func<EntityComponent, bool> _0___IsGraft
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormBlankSlateConditionalIconRenderer.__O.NativeFieldInfoPtr__0___IsGraft, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormBlankSlateConditionalIconRenderer.__O.NativeFieldInfoPtr__0___IsGraft, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400141F RID: 5151
			private static readonly IntPtr NativeFieldInfoPtr__0___IsGraft;
		}
	}
}
