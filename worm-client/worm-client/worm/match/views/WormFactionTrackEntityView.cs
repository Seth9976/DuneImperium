using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;

namespace worm.match.views
{
	// Token: 0x020000AB RID: 171
	public class WormFactionTrackEntityView : ContainerView
	{
		// Token: 0x0600069C RID: 1692 RVA: 0x0002CC54 File Offset: 0x0002AE54
		// Note: this type is marked as 'beforefieldinit'.
		static WormFactionTrackEntityView()
		{
			Il2CppClassPointerStore<WormFactionTrackEntityView>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.views", "WormFactionTrackEntityView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormFactionTrackEntityView>.NativeClassPtr);
			WormFactionTrackEntityView.NativeFieldInfoPtr_spaceViews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrackEntityView>.NativeClassPtr, "spaceViews");
			WormFactionTrackEntityView.NativeFieldInfoPtr_factionTokenContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrackEntityView>.NativeClassPtr, "factionTokenContainer");
			WormFactionTrackEntityView.NativeMethodInfoPtr_createView_Protected_Virtual_UnitView_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrackEntityView>.NativeClassPtr, 100664225);
			WormFactionTrackEntityView.NativeMethodInfoPtr_ContainerForViewAndSlot_Public_Virtual_Transform_UnitView_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrackEntityView>.NativeClassPtr, 100664226);
			WormFactionTrackEntityView.NativeMethodInfoPtr_entitiesToCreateOnInit_Protected_Virtual_IReadOnlyList_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrackEntityView>.NativeClassPtr, 100664227);
			WormFactionTrackEntityView.NativeMethodInfoPtr_AddView_Public_Virtual_Void_UnitView_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrackEntityView>.NativeClassPtr, 100664228);
			WormFactionTrackEntityView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrackEntityView>.NativeClassPtr, 100664229);
			WormFactionTrackEntityView.NativeMethodInfoPtr__entitiesToCreateOnInit_b__4_0_Private_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrackEntityView>.NativeClassPtr, 100664230);
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x0002CD24 File Offset: 0x0002AF24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696633, XrefRangeEnd = 696665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override UnitView createView(EntityComponent e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormFactionTrackEntityView.NativeMethodInfoPtr_createView_Protected_Virtual_UnitView_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnitView>(intPtr3) : null;
			}
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x0002CD80 File Offset: 0x0002AF80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696665, XrefRangeEnd = 696671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Transform ContainerForViewAndSlot(UnitView view, int slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormFactionTrackEntityView.NativeMethodInfoPtr_ContainerForViewAndSlot_Public_Virtual_Transform_UnitView_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x0002CDEC File Offset: 0x0002AFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696671, XrefRangeEnd = 696684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IReadOnlyList<EntityComponent> entitiesToCreateOnInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormFactionTrackEntityView.NativeMethodInfoPtr_entitiesToCreateOnInit_Protected_Virtual_IReadOnlyList_1_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<EntityComponent>>(intPtr3) : null;
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x0002CE38 File Offset: 0x0002B038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696684, XrefRangeEnd = 696690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AddView(UnitView view, int slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormFactionTrackEntityView.NativeMethodInfoPtr_AddView_Public_Virtual_Void_UnitView_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x0002CE94 File Offset: 0x0002B094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696690, XrefRangeEnd = 696698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormFactionTrackEntityView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormFactionTrackEntityView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTrackEntityView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x0002CED0 File Offset: 0x0002B0D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696698, XrefRangeEnd = 696701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _entitiesToCreateOnInit_b__4_0(EntityComponent child)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTrackEntityView.NativeMethodInfoPtr__entitiesToCreateOnInit_b__4_0_Private_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x0000550A File Offset: 0x0000370A
		public WormFactionTrackEntityView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060006A4 RID: 1700 RVA: 0x0002CF20 File Offset: 0x0002B120
		// (set) Token: 0x060006A5 RID: 1701 RVA: 0x00005513 File Offset: 0x00003713
		public unsafe List<ContainerView> spaceViews
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrackEntityView.NativeFieldInfoPtr_spaceViews);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ContainerView>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrackEntityView.NativeFieldInfoPtr_spaceViews), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060006A6 RID: 1702 RVA: 0x0002CF50 File Offset: 0x0002B150
		// (set) Token: 0x060006A7 RID: 1703 RVA: 0x00005532 File Offset: 0x00003732
		public unsafe Transform factionTokenContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrackEntityView.NativeFieldInfoPtr_factionTokenContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrackEntityView.NativeFieldInfoPtr_factionTokenContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeFieldInfoPtr_spaceViews;

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeFieldInfoPtr_factionTokenContainer;

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeMethodInfoPtr_createView_Protected_Virtual_UnitView_EntityComponent_0;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeMethodInfoPtr_ContainerForViewAndSlot_Public_Virtual_Transform_UnitView_Int32_0;

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeMethodInfoPtr_entitiesToCreateOnInit_Protected_Virtual_IReadOnlyList_1_EntityComponent_0;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeMethodInfoPtr_AddView_Public_Virtual_Void_UnitView_Int32_0;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeMethodInfoPtr__entitiesToCreateOnInit_b__4_0_Private_Boolean_EntityComponent_0;

		// Token: 0x02000311 RID: 785
		[ObfuscatedName("worm.match.views.WormFactionTrackEntityView+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06001FA3 RID: 8099 RVA: 0x00078CB8 File Offset: 0x00076EB8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormFactionTrackEntityView.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormFactionTrackEntityView>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormFactionTrackEntityView.__c>.NativeClassPtr);
				WormFactionTrackEntityView.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrackEntityView.__c>.NativeClassPtr, "<>9");
				WormFactionTrackEntityView.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrackEntityView.__c>.NativeClassPtr, "<>9__2_0");
				WormFactionTrackEntityView.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrackEntityView.__c>.NativeClassPtr, 100664232);
				WormFactionTrackEntityView.__c.NativeMethodInfoPtr__createView_b__2_0_Internal_Boolean_ContainerView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrackEntityView.__c>.NativeClassPtr, 100664233);
			}

			// Token: 0x06001FA4 RID: 8100 RVA: 0x00078D34 File Offset: 0x00076F34
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormFactionTrackEntityView.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTrackEntityView.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FA5 RID: 8101 RVA: 0x00078D70 File Offset: 0x00076F70
			[CallerCount(0)]
			public unsafe bool _createView_b__2_0(ContainerView view)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTrackEntityView.__c.NativeMethodInfoPtr__createView_b__2_0_Internal_Boolean_ContainerView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001FA6 RID: 8102 RVA: 0x00011D4B File Offset: 0x0000FF4B
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008A8 RID: 2216
			// (get) Token: 0x06001FA7 RID: 8103 RVA: 0x00078DC0 File Offset: 0x00076FC0
			// (set) Token: 0x06001FA8 RID: 8104 RVA: 0x00011D54 File Offset: 0x0000FF54
			public unsafe static WormFactionTrackEntityView.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormFactionTrackEntityView.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormFactionTrackEntityView.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormFactionTrackEntityView.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008A9 RID: 2217
			// (get) Token: 0x06001FA9 RID: 8105 RVA: 0x00078DE8 File Offset: 0x00076FE8
			// (set) Token: 0x06001FAA RID: 8106 RVA: 0x00011D66 File Offset: 0x0000FF66
			public unsafe static Func<ContainerView, bool> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormFactionTrackEntityView.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ContainerView, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormFactionTrackEntityView.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001247 RID: 4679
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001248 RID: 4680
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04001249 RID: 4681
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400124A RID: 4682
			private static readonly IntPtr NativeMethodInfoPtr__createView_b__2_0_Internal_Boolean_ContainerView_0;
		}
	}
}
