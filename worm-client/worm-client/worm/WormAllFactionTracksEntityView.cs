using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using lotus;
using worm.canis.data.enums;

namespace worm
{
	// Token: 0x02000043 RID: 67
	public class WormAllFactionTracksEntityView : EntityView
	{
		// Token: 0x060002E0 RID: 736 RVA: 0x00021AD0 File Offset: 0x0001FCD0
		// Note: this type is marked as 'beforefieldinit'.
		static WormAllFactionTracksEntityView()
		{
			Il2CppClassPointerStore<WormAllFactionTracksEntityView>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm", "WormAllFactionTracksEntityView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAllFactionTracksEntityView>.NativeClassPtr);
			WormAllFactionTracksEntityView.NativeFieldInfoPtr_factionTrackViews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAllFactionTracksEntityView>.NativeClassPtr, "factionTrackViews");
			WormAllFactionTracksEntityView.NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityComponent_EntityView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAllFactionTracksEntityView>.NativeClassPtr, 100663759);
			WormAllFactionTracksEntityView.NativeMethodInfoPtr_getView_Public_EntityView_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAllFactionTracksEntityView>.NativeClassPtr, 100663760);
			WormAllFactionTracksEntityView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAllFactionTracksEntityView>.NativeClassPtr, 100663761);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00021B50 File Offset: 0x0001FD50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690775, XrefRangeEnd = 690816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init(EntityComponent ec, EntityView p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ec);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAllFactionTracksEntityView.NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityComponent_EntityView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00021BB0 File Offset: 0x0001FDB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 690829, RefRangeEnd = 690831, XrefRangeStart = 690816, XrefRangeEnd = 690829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityView getView(Factions faction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref faction;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAllFactionTracksEntityView.NativeMethodInfoPtr_getView_Public_EntityView_Factions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr3) : null;
			}
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00021BFC File Offset: 0x0001FDFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690831, XrefRangeEnd = 690836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAllFactionTracksEntityView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAllFactionTracksEntityView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAllFactionTracksEntityView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00003541 File Offset: 0x00001741
		public WormAllFactionTracksEntityView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x00021C38 File Offset: 0x0001FE38
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x0000354A File Offset: 0x0000174A
		public unsafe Il2CppReferenceArray<WormAllFactionTracksEntityView.ViewFactionPair> factionTrackViews
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAllFactionTracksEntityView.NativeFieldInfoPtr_factionTrackViews);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WormAllFactionTracksEntityView.ViewFactionPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAllFactionTracksEntityView.NativeFieldInfoPtr_factionTrackViews), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeFieldInfoPtr_factionTrackViews;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityComponent_EntityView_0;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeMethodInfoPtr_getView_Public_EntityView_Factions_0;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002DA RID: 730
		[Serializable]
		public class ViewFactionPair : Object
		{
			// Token: 0x06001DCB RID: 7627 RVA: 0x0007379C File Offset: 0x0007199C
			// Note: this type is marked as 'beforefieldinit'.
			static ViewFactionPair()
			{
				Il2CppClassPointerStore<WormAllFactionTracksEntityView.ViewFactionPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAllFactionTracksEntityView>.NativeClassPtr, "ViewFactionPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAllFactionTracksEntityView.ViewFactionPair>.NativeClassPtr);
				WormAllFactionTracksEntityView.ViewFactionPair.NativeFieldInfoPtr_faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAllFactionTracksEntityView.ViewFactionPair>.NativeClassPtr, "faction");
				WormAllFactionTracksEntityView.ViewFactionPair.NativeFieldInfoPtr_view = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAllFactionTracksEntityView.ViewFactionPair>.NativeClassPtr, "view");
				WormAllFactionTracksEntityView.ViewFactionPair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAllFactionTracksEntityView.ViewFactionPair>.NativeClassPtr, 100663762);
			}

			// Token: 0x06001DCC RID: 7628 RVA: 0x00073804 File Offset: 0x00071A04
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ViewFactionPair()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAllFactionTracksEntityView.ViewFactionPair>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAllFactionTracksEntityView.ViewFactionPair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DCD RID: 7629 RVA: 0x00010FC7 File Offset: 0x0000F1C7
			public ViewFactionPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700082E RID: 2094
			// (get) Token: 0x06001DCE RID: 7630 RVA: 0x00073840 File Offset: 0x00071A40
			// (set) Token: 0x06001DCF RID: 7631 RVA: 0x00010FD0 File Offset: 0x0000F1D0
			public unsafe Factions faction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAllFactionTracksEntityView.ViewFactionPair.NativeFieldInfoPtr_faction);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAllFactionTracksEntityView.ViewFactionPair.NativeFieldInfoPtr_faction)) = value;
				}
			}

			// Token: 0x1700082F RID: 2095
			// (get) Token: 0x06001DD0 RID: 7632 RVA: 0x00073868 File Offset: 0x00071A68
			// (set) Token: 0x06001DD1 RID: 7633 RVA: 0x00010FEB File Offset: 0x0000F1EB
			public unsafe EntityView view
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAllFactionTracksEntityView.ViewFactionPair.NativeFieldInfoPtr_view);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAllFactionTracksEntityView.ViewFactionPair.NativeFieldInfoPtr_view), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400114A RID: 4426
			private static readonly IntPtr NativeFieldInfoPtr_faction;

			// Token: 0x0400114B RID: 4427
			private static readonly IntPtr NativeFieldInfoPtr_view;

			// Token: 0x0400114C RID: 4428
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002DB RID: 731
		[ObfuscatedName("worm.WormAllFactionTracksEntityView+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x06001DD2 RID: 7634 RVA: 0x00073898 File Offset: 0x00071A98
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<WormAllFactionTracksEntityView.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAllFactionTracksEntityView>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAllFactionTracksEntityView.__c__DisplayClass2_0>.NativeClassPtr);
				WormAllFactionTracksEntityView.__c__DisplayClass2_0.NativeFieldInfoPtr_faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAllFactionTracksEntityView.__c__DisplayClass2_0>.NativeClassPtr, "faction");
				WormAllFactionTracksEntityView.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAllFactionTracksEntityView.__c__DisplayClass2_0>.NativeClassPtr, 100663763);
				WormAllFactionTracksEntityView.__c__DisplayClass2_0.NativeMethodInfoPtr__Init_b__0_Internal_Boolean_ViewFactionPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAllFactionTracksEntityView.__c__DisplayClass2_0>.NativeClassPtr, 100663764);
			}

			// Token: 0x06001DD3 RID: 7635 RVA: 0x00073900 File Offset: 0x00071B00
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAllFactionTracksEntityView.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAllFactionTracksEntityView.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DD4 RID: 7636 RVA: 0x0007393C File Offset: 0x00071B3C
			[CallerCount(0)]
			public unsafe bool _Init_b__0(WormAllFactionTracksEntityView.ViewFactionPair pair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(pair);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAllFactionTracksEntityView.__c__DisplayClass2_0.NativeMethodInfoPtr__Init_b__0_Internal_Boolean_ViewFactionPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001DD5 RID: 7637 RVA: 0x0001100A File Offset: 0x0000F20A
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000830 RID: 2096
			// (get) Token: 0x06001DD6 RID: 7638 RVA: 0x0007398C File Offset: 0x00071B8C
			// (set) Token: 0x06001DD7 RID: 7639 RVA: 0x00011013 File Offset: 0x0000F213
			public unsafe Factions faction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAllFactionTracksEntityView.__c__DisplayClass2_0.NativeFieldInfoPtr_faction);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAllFactionTracksEntityView.__c__DisplayClass2_0.NativeFieldInfoPtr_faction)) = value;
				}
			}

			// Token: 0x0400114D RID: 4429
			private static readonly IntPtr NativeFieldInfoPtr_faction;

			// Token: 0x0400114E RID: 4430
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400114F RID: 4431
			private static readonly IntPtr NativeMethodInfoPtr__Init_b__0_Internal_Boolean_ViewFactionPair_0;
		}

		// Token: 0x020002DC RID: 732
		[ObfuscatedName("worm.WormAllFactionTracksEntityView+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06001DD8 RID: 7640 RVA: 0x000739B4 File Offset: 0x00071BB4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<WormAllFactionTracksEntityView.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAllFactionTracksEntityView>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAllFactionTracksEntityView.__c__DisplayClass3_0>.NativeClassPtr);
				WormAllFactionTracksEntityView.__c__DisplayClass3_0.NativeFieldInfoPtr_faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAllFactionTracksEntityView.__c__DisplayClass3_0>.NativeClassPtr, "faction");
				WormAllFactionTracksEntityView.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAllFactionTracksEntityView.__c__DisplayClass3_0>.NativeClassPtr, 100663765);
				WormAllFactionTracksEntityView.__c__DisplayClass3_0.NativeMethodInfoPtr__getView_b__0_Internal_Boolean_ViewFactionPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAllFactionTracksEntityView.__c__DisplayClass3_0>.NativeClassPtr, 100663766);
			}

			// Token: 0x06001DD9 RID: 7641 RVA: 0x00073A1C File Offset: 0x00071C1C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAllFactionTracksEntityView.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAllFactionTracksEntityView.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DDA RID: 7642 RVA: 0x00073A58 File Offset: 0x00071C58
			[CallerCount(0)]
			public unsafe bool _getView_b__0(WormAllFactionTracksEntityView.ViewFactionPair v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAllFactionTracksEntityView.__c__DisplayClass3_0.NativeMethodInfoPtr__getView_b__0_Internal_Boolean_ViewFactionPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001DDB RID: 7643 RVA: 0x0001102E File Offset: 0x0000F22E
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000831 RID: 2097
			// (get) Token: 0x06001DDC RID: 7644 RVA: 0x00073AA8 File Offset: 0x00071CA8
			// (set) Token: 0x06001DDD RID: 7645 RVA: 0x00011037 File Offset: 0x0000F237
			public unsafe Factions faction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAllFactionTracksEntityView.__c__DisplayClass3_0.NativeFieldInfoPtr_faction);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAllFactionTracksEntityView.__c__DisplayClass3_0.NativeFieldInfoPtr_faction)) = value;
				}
			}

			// Token: 0x04001150 RID: 4432
			private static readonly IntPtr NativeFieldInfoPtr_faction;

			// Token: 0x04001151 RID: 4433
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001152 RID: 4434
			private static readonly IntPtr NativeMethodInfoPtr__getView_b__0_Internal_Boolean_ViewFactionPair_0;
		}
	}
}
