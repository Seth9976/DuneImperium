using System;
using Canis.utils.ids;
using dwd.core.match;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;
using worm.match.prompts.prompts;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000E2 RID: 226
	public class WormSelectLeaderPromptBehaviour : PromptBehaviour<WormSelectEntityPrompt>
	{
		// Token: 0x060009F4 RID: 2548 RVA: 0x00036734 File Offset: 0x00034934
		// Note: this type is marked as 'beforefieldinit'.
		static WormSelectLeaderPromptBehaviour()
		{
			Il2CppClassPointerStore<WormSelectLeaderPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormSelectLeaderPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSelectLeaderPromptBehaviour>.NativeClassPtr);
			WormSelectLeaderPromptBehaviour.NativeFieldInfoPtr_onLeaderSelectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectLeaderPromptBehaviour>.NativeClassPtr, "onLeaderSelectable");
			WormSelectLeaderPromptBehaviour.NativeFieldInfoPtr_onLeaderSelectablePlaySound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectLeaderPromptBehaviour>.NativeClassPtr, "onLeaderSelectablePlaySound");
			WormSelectLeaderPromptBehaviour.NativeFieldInfoPtr_leaderSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectLeaderPromptBehaviour>.NativeClassPtr, "leaderSelection");
			WormSelectLeaderPromptBehaviour.NativeFieldInfoPtr_playedSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectLeaderPromptBehaviour>.NativeClassPtr, "playedSound");
			WormSelectLeaderPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectLeaderPromptBehaviour>.NativeClassPtr, 100664664);
			WormSelectLeaderPromptBehaviour.NativeMethodInfoPtr_Event_Confirm_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectLeaderPromptBehaviour>.NativeClassPtr, 100664665);
			WormSelectLeaderPromptBehaviour.NativeMethodInfoPtr_GetLeaderSelection_Private_List_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectLeaderPromptBehaviour>.NativeClassPtr, 100664666);
			WormSelectLeaderPromptBehaviour.NativeMethodInfoPtr_OnLeaderChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectLeaderPromptBehaviour>.NativeClassPtr, 100664667);
			WormSelectLeaderPromptBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectLeaderPromptBehaviour>.NativeClassPtr, 100664668);
			WormSelectLeaderPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectLeaderPromptBehaviour>.NativeClassPtr, 100664669);
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x0003682C File Offset: 0x00034A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700917, XrefRangeEnd = 700937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSelectLeaderPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x00036868 File Offset: 0x00034A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700937, XrefRangeEnd = 700945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Confirm()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectLeaderPromptBehaviour.NativeMethodInfoPtr_Event_Confirm_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x0003689C File Offset: 0x00034A9C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 700985, RefRangeEnd = 700988, XrefRangeStart = 700945, XrefRangeEnd = 700985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<EntityID> GetLeaderSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectLeaderPromptBehaviour.NativeMethodInfoPtr_GetLeaderSelection_Private_List_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<EntityID>>(intPtr3) : null;
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x000368DC File Offset: 0x00034ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700988, XrefRangeEnd = 700994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLeaderChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectLeaderPromptBehaviour.NativeMethodInfoPtr_OnLeaderChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x00036910 File Offset: 0x00034B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700994, XrefRangeEnd = 701002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectLeaderPromptBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x00036944 File Offset: 0x00034B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701002, XrefRangeEnd = 701017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSelectLeaderPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSelectLeaderPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectLeaderPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x000072F8 File Offset: 0x000054F8
		public WormSelectLeaderPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x00036980 File Offset: 0x00034B80
		// (set) Token: 0x060009FD RID: 2557 RVA: 0x00007301 File Offset: 0x00005501
		public unsafe UnityEvent<bool> onLeaderSelectable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectLeaderPromptBehaviour.NativeFieldInfoPtr_onLeaderSelectable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectLeaderPromptBehaviour.NativeFieldInfoPtr_onLeaderSelectable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x000369B0 File Offset: 0x00034BB0
		// (set) Token: 0x060009FF RID: 2559 RVA: 0x00007320 File Offset: 0x00005520
		public unsafe UnityEvent onLeaderSelectablePlaySound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectLeaderPromptBehaviour.NativeFieldInfoPtr_onLeaderSelectablePlaySound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectLeaderPromptBehaviour.NativeFieldInfoPtr_onLeaderSelectablePlaySound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000A00 RID: 2560 RVA: 0x000369E0 File Offset: 0x00034BE0
		// (set) Token: 0x06000A01 RID: 2561 RVA: 0x0000733F File Offset: 0x0000553F
		public unsafe WormLeaderSelectionDisplayPromptBehaviour leaderSelection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectLeaderPromptBehaviour.NativeFieldInfoPtr_leaderSelection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormLeaderSelectionDisplayPromptBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectLeaderPromptBehaviour.NativeFieldInfoPtr_leaderSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x00036A10 File Offset: 0x00034C10
		// (set) Token: 0x06000A03 RID: 2563 RVA: 0x0000735E File Offset: 0x0000555E
		public unsafe bool playedSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectLeaderPromptBehaviour.NativeFieldInfoPtr_playedSound);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectLeaderPromptBehaviour.NativeFieldInfoPtr_playedSound)) = value;
			}
		}

		// Token: 0x040005BF RID: 1471
		private static readonly IntPtr NativeFieldInfoPtr_onLeaderSelectable;

		// Token: 0x040005C0 RID: 1472
		private static readonly IntPtr NativeFieldInfoPtr_onLeaderSelectablePlaySound;

		// Token: 0x040005C1 RID: 1473
		private static readonly IntPtr NativeFieldInfoPtr_leaderSelection;

		// Token: 0x040005C2 RID: 1474
		private static readonly IntPtr NativeFieldInfoPtr_playedSound;

		// Token: 0x040005C3 RID: 1475
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x040005C4 RID: 1476
		private static readonly IntPtr NativeMethodInfoPtr_Event_Confirm_Public_Void_0;

		// Token: 0x040005C5 RID: 1477
		private static readonly IntPtr NativeMethodInfoPtr_GetLeaderSelection_Private_List_1_EntityID_0;

		// Token: 0x040005C6 RID: 1478
		private static readonly IntPtr NativeMethodInfoPtr_OnLeaderChanged_Private_Void_0;

		// Token: 0x040005C7 RID: 1479
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040005C8 RID: 1480
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000345 RID: 837
		[ObfuscatedName("worm.match.prompts.behaviours.WormSelectLeaderPromptBehaviour+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060021DE RID: 8670 RVA: 0x0007F2D0 File Offset: 0x0007D4D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormSelectLeaderPromptBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormSelectLeaderPromptBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSelectLeaderPromptBehaviour.__c>.NativeClassPtr);
				WormSelectLeaderPromptBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectLeaderPromptBehaviour.__c>.NativeClassPtr, "<>9");
				WormSelectLeaderPromptBehaviour.__c.NativeFieldInfoPtr___9__6_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectLeaderPromptBehaviour.__c>.NativeClassPtr, "<>9__6_1");
				WormSelectLeaderPromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectLeaderPromptBehaviour.__c>.NativeClassPtr, 100664671);
				WormSelectLeaderPromptBehaviour.__c.NativeMethodInfoPtr__GetLeaderSelection_b__6_1_Internal_EntityID_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectLeaderPromptBehaviour.__c>.NativeClassPtr, 100664672);
			}

			// Token: 0x060021DF RID: 8671 RVA: 0x0007F34C File Offset: 0x0007D54C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSelectLeaderPromptBehaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectLeaderPromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021E0 RID: 8672 RVA: 0x0007F388 File Offset: 0x0007D588
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700905, XrefRangeEnd = 700910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EntityID _GetLeaderSelection_b__6_1(EntityComponent c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectLeaderPromptBehaviour.__c.NativeMethodInfoPtr__GetLeaderSelection_b__6_1_Internal_EntityID_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x060021E1 RID: 8673 RVA: 0x00012FEB File Offset: 0x000111EB
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000957 RID: 2391
			// (get) Token: 0x060021E2 RID: 8674 RVA: 0x0007F3D8 File Offset: 0x0007D5D8
			// (set) Token: 0x060021E3 RID: 8675 RVA: 0x00012FF4 File Offset: 0x000111F4
			public unsafe static WormSelectLeaderPromptBehaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormSelectLeaderPromptBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSelectLeaderPromptBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormSelectLeaderPromptBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000958 RID: 2392
			// (get) Token: 0x060021E4 RID: 8676 RVA: 0x0007F400 File Offset: 0x0007D600
			// (set) Token: 0x060021E5 RID: 8677 RVA: 0x00013006 File Offset: 0x00011206
			public unsafe static Func<EntityComponent, EntityID> __9__6_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormSelectLeaderPromptBehaviour.__c.NativeFieldInfoPtr___9__6_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormSelectLeaderPromptBehaviour.__c.NativeFieldInfoPtr___9__6_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001384 RID: 4996
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001385 RID: 4997
			private static readonly IntPtr NativeFieldInfoPtr___9__6_1;

			// Token: 0x04001386 RID: 4998
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001387 RID: 4999
			private static readonly IntPtr NativeMethodInfoPtr__GetLeaderSelection_b__6_1_Internal_EntityID_EntityComponent_0;
		}

		// Token: 0x02000346 RID: 838
		[ObfuscatedName("worm.match.prompts.behaviours.WormSelectLeaderPromptBehaviour+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x060021E6 RID: 8678 RVA: 0x0007F428 File Offset: 0x0007D628
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<WormSelectLeaderPromptBehaviour.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormSelectLeaderPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSelectLeaderPromptBehaviour.__c__DisplayClass6_0>.NativeClassPtr);
				WormSelectLeaderPromptBehaviour.__c__DisplayClass6_0.NativeFieldInfoPtr_selectedLeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectLeaderPromptBehaviour.__c__DisplayClass6_0>.NativeClassPtr, "selectedLeader");
				WormSelectLeaderPromptBehaviour.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectLeaderPromptBehaviour.__c__DisplayClass6_0>.NativeClassPtr, 100664673);
				WormSelectLeaderPromptBehaviour.__c__DisplayClass6_0.NativeMethodInfoPtr__GetLeaderSelection_b__0_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectLeaderPromptBehaviour.__c__DisplayClass6_0>.NativeClassPtr, 100664674);
			}

			// Token: 0x060021E7 RID: 8679 RVA: 0x0007F490 File Offset: 0x0007D690
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSelectLeaderPromptBehaviour.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectLeaderPromptBehaviour.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021E8 RID: 8680 RVA: 0x0007F4CC File Offset: 0x0007D6CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700910, XrefRangeEnd = 700917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetLeaderSelection_b__0(EntityComponent c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectLeaderPromptBehaviour.__c__DisplayClass6_0.NativeMethodInfoPtr__GetLeaderSelection_b__0_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060021E9 RID: 8681 RVA: 0x00013018 File Offset: 0x00011218
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000959 RID: 2393
			// (get) Token: 0x060021EA RID: 8682 RVA: 0x0007F51C File Offset: 0x0007D71C
			// (set) Token: 0x060021EB RID: 8683 RVA: 0x00013021 File Offset: 0x00011221
			public unsafe ArchetypeID selectedLeader
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectLeaderPromptBehaviour.__c__DisplayClass6_0.NativeFieldInfoPtr_selectedLeader);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectLeaderPromptBehaviour.__c__DisplayClass6_0.NativeFieldInfoPtr_selectedLeader), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001388 RID: 5000
			private static readonly IntPtr NativeFieldInfoPtr_selectedLeader;

			// Token: 0x04001389 RID: 5001
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400138A RID: 5002
			private static readonly IntPtr NativeMethodInfoPtr__GetLeaderSelection_b__0_Internal_Boolean_EntityComponent_0;
		}
	}
}
