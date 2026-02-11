using System;
using Canis.utils.ids;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace worm.match.dataRenderers
{
	// Token: 0x0200015F RID: 351
	public class WormShowOfStrengthConditionalIconRenderer : WormConditionalIconRenderer
	{
		// Token: 0x06000FB0 RID: 4016 RVA: 0x0004735C File Offset: 0x0004555C
		// Note: this type is marked as 'beforefieldinit'.
		static WormShowOfStrengthConditionalIconRenderer()
		{
			Il2CppClassPointerStore<WormShowOfStrengthConditionalIconRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormShowOfStrengthConditionalIconRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShowOfStrengthConditionalIconRenderer>.NativeClassPtr);
			WormShowOfStrengthConditionalIconRenderer.NativeFieldInfoPtr_deployAreas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowOfStrengthConditionalIconRenderer>.NativeClassPtr, "deployAreas");
			WormShowOfStrengthConditionalIconRenderer.NativeMethodInfoPtr_get_Initialized_Protected_Virtual_Final_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowOfStrengthConditionalIconRenderer>.NativeClassPtr, 100665420);
			WormShowOfStrengthConditionalIconRenderer.NativeMethodInfoPtr_get_currentModelVersion_Protected_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowOfStrengthConditionalIconRenderer>.NativeClassPtr, 100665421);
			WormShowOfStrengthConditionalIconRenderer.NativeMethodInfoPtr_init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowOfStrengthConditionalIconRenderer>.NativeClassPtr, 100665422);
			WormShowOfStrengthConditionalIconRenderer.NativeMethodInfoPtr_ShowIconsOnTurn_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowOfStrengthConditionalIconRenderer>.NativeClassPtr, 100665423);
			WormShowOfStrengthConditionalIconRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowOfStrengthConditionalIconRenderer>.NativeClassPtr, 100665424);
			WormShowOfStrengthConditionalIconRenderer.NativeMethodInfoPtr_Method_Internal_Static_Int32_IEnumerable_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowOfStrengthConditionalIconRenderer>.NativeClassPtr, 100665425);
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000FB1 RID: 4017 RVA: 0x00047418 File Offset: 0x00045618
		public unsafe override bool Initialized
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708124, XrefRangeEnd = 708125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowOfStrengthConditionalIconRenderer.NativeMethodInfoPtr_get_Initialized_Protected_Virtual_Final_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000FB2 RID: 4018 RVA: 0x00047454 File Offset: 0x00045654
		public unsafe override ulong currentModelVersion
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708125, XrefRangeEnd = 708132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormShowOfStrengthConditionalIconRenderer.NativeMethodInfoPtr_get_currentModelVersion_Protected_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x0004749C File Offset: 0x0004569C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708132, XrefRangeEnd = 708140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormShowOfStrengthConditionalIconRenderer.NativeMethodInfoPtr_init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x000474D8 File Offset: 0x000456D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708140, XrefRangeEnd = 708162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShowIconsOnTurn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormShowOfStrengthConditionalIconRenderer.NativeMethodInfoPtr_ShowIconsOnTurn_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x00047520 File Offset: 0x00045720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708162, XrefRangeEnd = 708163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormShowOfStrengthConditionalIconRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShowOfStrengthConditionalIconRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowOfStrengthConditionalIconRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x0004755C File Offset: 0x0004575C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 708181, RefRangeEnd = 708182, XrefRangeStart = 708163, XrefRangeEnd = 708181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Method_Internal_Static_Int32_IEnumerable_1_EntityComponent_0(IEnumerable<EntityComponent> children)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(children);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowOfStrengthConditionalIconRenderer.NativeMethodInfoPtr_Method_Internal_Static_Int32_IEnumerable_1_EntityComponent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x0000A442 File Offset: 0x00008642
		public WormShowOfStrengthConditionalIconRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000FB8 RID: 4024 RVA: 0x000475A0 File Offset: 0x000457A0
		// (set) Token: 0x06000FB9 RID: 4025 RVA: 0x0000A44B File Offset: 0x0000864B
		public unsafe Dictionary<AccountID, ReadOnlyVersionedList<EntityComponent>> deployAreas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowOfStrengthConditionalIconRenderer.NativeFieldInfoPtr_deployAreas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AccountID, ReadOnlyVersionedList<EntityComponent>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowOfStrengthConditionalIconRenderer.NativeFieldInfoPtr_deployAreas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000907 RID: 2311
		private static readonly IntPtr NativeFieldInfoPtr_deployAreas;

		// Token: 0x04000908 RID: 2312
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Protected_Virtual_Final_get_Boolean_0;

		// Token: 0x04000909 RID: 2313
		private static readonly IntPtr NativeMethodInfoPtr_get_currentModelVersion_Protected_Virtual_get_UInt64_0;

		// Token: 0x0400090A RID: 2314
		private static readonly IntPtr NativeMethodInfoPtr_init_Protected_Virtual_Void_0;

		// Token: 0x0400090B RID: 2315
		private static readonly IntPtr NativeMethodInfoPtr_ShowIconsOnTurn_Protected_Virtual_Boolean_0;

		// Token: 0x0400090C RID: 2316
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400090D RID: 2317
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Int32_IEnumerable_1_EntityComponent_0;

		// Token: 0x020003A3 RID: 931
		[ObfuscatedName("worm.match.dataRenderers.WormShowOfStrengthConditionalIconRenderer+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06002586 RID: 9606 RVA: 0x00089740 File Offset: 0x00087940
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormShowOfStrengthConditionalIconRenderer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormShowOfStrengthConditionalIconRenderer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShowOfStrengthConditionalIconRenderer.__c>.NativeClassPtr);
				WormShowOfStrengthConditionalIconRenderer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowOfStrengthConditionalIconRenderer.__c>.NativeClassPtr, "<>9");
				WormShowOfStrengthConditionalIconRenderer.__c.NativeFieldInfoPtr___9__6_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowOfStrengthConditionalIconRenderer.__c>.NativeClassPtr, "<>9__6_2");
				WormShowOfStrengthConditionalIconRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowOfStrengthConditionalIconRenderer.__c>.NativeClassPtr, 100665427);
				WormShowOfStrengthConditionalIconRenderer.__c.NativeMethodInfoPtr__ShowIconsOnTurn_b__6_2_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowOfStrengthConditionalIconRenderer.__c>.NativeClassPtr, 100665428);
			}

			// Token: 0x06002587 RID: 9607 RVA: 0x000897BC File Offset: 0x000879BC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShowOfStrengthConditionalIconRenderer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowOfStrengthConditionalIconRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002588 RID: 9608 RVA: 0x000897F8 File Offset: 0x000879F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708117, XrefRangeEnd = 708124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ShowIconsOnTurn_b__6_2(EntityComponent e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowOfStrengthConditionalIconRenderer.__c.NativeMethodInfoPtr__ShowIconsOnTurn_b__6_2_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002589 RID: 9609 RVA: 0x00014E3F File Offset: 0x0001303F
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A76 RID: 2678
			// (get) Token: 0x0600258A RID: 9610 RVA: 0x00089848 File Offset: 0x00087A48
			// (set) Token: 0x0600258B RID: 9611 RVA: 0x00014E48 File Offset: 0x00013048
			public unsafe static WormShowOfStrengthConditionalIconRenderer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormShowOfStrengthConditionalIconRenderer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormShowOfStrengthConditionalIconRenderer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormShowOfStrengthConditionalIconRenderer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A77 RID: 2679
			// (get) Token: 0x0600258C RID: 9612 RVA: 0x00089870 File Offset: 0x00087A70
			// (set) Token: 0x0600258D RID: 9613 RVA: 0x00014E5A File Offset: 0x0001305A
			public unsafe static Func<EntityComponent, bool> __9__6_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormShowOfStrengthConditionalIconRenderer.__c.NativeFieldInfoPtr___9__6_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormShowOfStrengthConditionalIconRenderer.__c.NativeFieldInfoPtr___9__6_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400158A RID: 5514
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400158B RID: 5515
			private static readonly IntPtr NativeFieldInfoPtr___9__6_2;

			// Token: 0x0400158C RID: 5516
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400158D RID: 5517
			private static readonly IntPtr NativeMethodInfoPtr__ShowIconsOnTurn_b__6_2_Internal_Boolean_EntityComponent_0;
		}

		// Token: 0x020003A4 RID: 932
		[ObfuscatedName("worm.match.dataRenderers.WormShowOfStrengthConditionalIconRenderer+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x0600258E RID: 9614 RVA: 0x00089898 File Offset: 0x00087A98
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<WormShowOfStrengthConditionalIconRenderer.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormShowOfStrengthConditionalIconRenderer>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShowOfStrengthConditionalIconRenderer.__c__DisplayClass6_0>.NativeClassPtr);
				WormShowOfStrengthConditionalIconRenderer.__c__DisplayClass6_0.NativeFieldInfoPtr_localPlayerDeploy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowOfStrengthConditionalIconRenderer.__c__DisplayClass6_0>.NativeClassPtr, "localPlayerDeploy");
				WormShowOfStrengthConditionalIconRenderer.__c__DisplayClass6_0.NativeFieldInfoPtr_localPlayerTroops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowOfStrengthConditionalIconRenderer.__c__DisplayClass6_0>.NativeClassPtr, "localPlayerTroops");
				WormShowOfStrengthConditionalIconRenderer.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowOfStrengthConditionalIconRenderer.__c__DisplayClass6_0>.NativeClassPtr, 100665429);
				WormShowOfStrengthConditionalIconRenderer.__c__DisplayClass6_0.NativeMethodInfoPtr__ShowIconsOnTurn_b__0_Internal_Boolean_ReadOnlyVersionedList_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowOfStrengthConditionalIconRenderer.__c__DisplayClass6_0>.NativeClassPtr, 100665430);
			}

			// Token: 0x0600258F RID: 9615 RVA: 0x00089914 File Offset: 0x00087B14
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShowOfStrengthConditionalIconRenderer.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowOfStrengthConditionalIconRenderer.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002590 RID: 9616 RVA: 0x00089950 File Offset: 0x00087B50
			[CallerCount(0)]
			public unsafe bool _ShowIconsOnTurn_b__0(ReadOnlyVersionedList<EntityComponent> d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowOfStrengthConditionalIconRenderer.__c__DisplayClass6_0.NativeMethodInfoPtr__ShowIconsOnTurn_b__0_Internal_Boolean_ReadOnlyVersionedList_1_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002591 RID: 9617 RVA: 0x00014E6C File Offset: 0x0001306C
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A78 RID: 2680
			// (get) Token: 0x06002592 RID: 9618 RVA: 0x000899A0 File Offset: 0x00087BA0
			// (set) Token: 0x06002593 RID: 9619 RVA: 0x00014E75 File Offset: 0x00013075
			public unsafe ReadOnlyVersionedList<EntityComponent> localPlayerDeploy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowOfStrengthConditionalIconRenderer.__c__DisplayClass6_0.NativeFieldInfoPtr_localPlayerDeploy);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyVersionedList<EntityComponent>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowOfStrengthConditionalIconRenderer.__c__DisplayClass6_0.NativeFieldInfoPtr_localPlayerDeploy), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A79 RID: 2681
			// (get) Token: 0x06002594 RID: 9620 RVA: 0x000899D0 File Offset: 0x00087BD0
			// (set) Token: 0x06002595 RID: 9621 RVA: 0x00014E94 File Offset: 0x00013094
			public unsafe int localPlayerTroops
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowOfStrengthConditionalIconRenderer.__c__DisplayClass6_0.NativeFieldInfoPtr_localPlayerTroops);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowOfStrengthConditionalIconRenderer.__c__DisplayClass6_0.NativeFieldInfoPtr_localPlayerTroops)) = value;
				}
			}

			// Token: 0x0400158E RID: 5518
			private static readonly IntPtr NativeFieldInfoPtr_localPlayerDeploy;

			// Token: 0x0400158F RID: 5519
			private static readonly IntPtr NativeFieldInfoPtr_localPlayerTroops;

			// Token: 0x04001590 RID: 5520
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001591 RID: 5521
			private static readonly IntPtr NativeMethodInfoPtr__ShowIconsOnTurn_b__0_Internal_Boolean_ReadOnlyVersionedList_1_EntityComponent_0;
		}
	}
}
