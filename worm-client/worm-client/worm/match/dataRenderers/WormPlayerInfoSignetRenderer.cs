using System;
using Canis.utils.ids;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using lotus;
using UnityEngine;

namespace worm.match.dataRenderers
{
	// Token: 0x0200014D RID: 333
	public class WormPlayerInfoSignetRenderer : Observer
	{
		// Token: 0x06000EEA RID: 3818 RVA: 0x00044F68 File Offset: 0x00043168
		// Note: this type is marked as 'beforefieldinit'.
		static WormPlayerInfoSignetRenderer()
		{
			Il2CppClassPointerStore<WormPlayerInfoSignetRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormPlayerInfoSignetRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerInfoSignetRenderer>.NativeClassPtr);
			WormPlayerInfoSignetRenderer.NativeFieldInfoPtr_abilityIDDisplayPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInfoSignetRenderer>.NativeClassPtr, "abilityIDDisplayPairs");
			WormPlayerInfoSignetRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInfoSignetRenderer>.NativeClassPtr, 100665305);
			WormPlayerInfoSignetRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInfoSignetRenderer>.NativeClassPtr, 100665306);
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x00044FD4 File Offset: 0x000431D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707099, XrefRangeEnd = 707177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPlayerInfoSignetRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x00045010 File Offset: 0x00043210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707177, XrefRangeEnd = 707185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayerInfoSignetRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerInfoSignetRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerInfoSignetRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x00009D9A File Offset: 0x00007F9A
		public WormPlayerInfoSignetRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000EEE RID: 3822 RVA: 0x0004504C File Offset: 0x0004324C
		// (set) Token: 0x06000EEF RID: 3823 RVA: 0x00009DA3 File Offset: 0x00007FA3
		public unsafe Il2CppReferenceArray<WormPlayerInfoSignetRenderer.AbilityIDDisplayPair> abilityIDDisplayPairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoSignetRenderer.NativeFieldInfoPtr_abilityIDDisplayPairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WormPlayerInfoSignetRenderer.AbilityIDDisplayPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoSignetRenderer.NativeFieldInfoPtr_abilityIDDisplayPairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000897 RID: 2199
		private static readonly IntPtr NativeFieldInfoPtr_abilityIDDisplayPairs;

		// Token: 0x04000898 RID: 2200
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x04000899 RID: 2201
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000396 RID: 918
		[Serializable]
		public sealed class AbilityIDDisplayPair : ValueType
		{
			// Token: 0x060024EA RID: 9450 RVA: 0x00087AC0 File Offset: 0x00085CC0
			// Note: this type is marked as 'beforefieldinit'.
			static AbilityIDDisplayPair()
			{
				Il2CppClassPointerStore<WormPlayerInfoSignetRenderer.AbilityIDDisplayPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayerInfoSignetRenderer>.NativeClassPtr, "AbilityIDDisplayPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerInfoSignetRenderer.AbilityIDDisplayPair>.NativeClassPtr);
				WormPlayerInfoSignetRenderer.AbilityIDDisplayPair.NativeFieldInfoPtr_abilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInfoSignetRenderer.AbilityIDDisplayPair>.NativeClassPtr, "abilityID");
				WormPlayerInfoSignetRenderer.AbilityIDDisplayPair.NativeFieldInfoPtr_display = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInfoSignetRenderer.AbilityIDDisplayPair>.NativeClassPtr, "display");
			}

			// Token: 0x060024EB RID: 9451 RVA: 0x0001494F File Offset: 0x00012B4F
			public AbilityIDDisplayPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060024EC RID: 9452 RVA: 0x00014958 File Offset: 0x00012B58
			public AbilityIDDisplayPair()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerInfoSignetRenderer.AbilityIDDisplayPair>.NativeClassPtr))
			{
			}

			// Token: 0x17000A41 RID: 2625
			// (get) Token: 0x060024ED RID: 9453 RVA: 0x00087B14 File Offset: 0x00085D14
			// (set) Token: 0x060024EE RID: 9454 RVA: 0x0001496A File Offset: 0x00012B6A
			public unsafe AbilityID abilityID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoSignetRenderer.AbilityIDDisplayPair.NativeFieldInfoPtr_abilityID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoSignetRenderer.AbilityIDDisplayPair.NativeFieldInfoPtr_abilityID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A42 RID: 2626
			// (get) Token: 0x060024EF RID: 9455 RVA: 0x00087B44 File Offset: 0x00085D44
			// (set) Token: 0x060024F0 RID: 9456 RVA: 0x00014989 File Offset: 0x00012B89
			public unsafe GameObject display
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoSignetRenderer.AbilityIDDisplayPair.NativeFieldInfoPtr_display);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoSignetRenderer.AbilityIDDisplayPair.NativeFieldInfoPtr_display), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001530 RID: 5424
			private static readonly IntPtr NativeFieldInfoPtr_abilityID;

			// Token: 0x04001531 RID: 5425
			private static readonly IntPtr NativeFieldInfoPtr_display;
		}

		// Token: 0x02000397 RID: 919
		[ObfuscatedName("worm.match.dataRenderers.WormPlayerInfoSignetRenderer+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x060024F1 RID: 9457 RVA: 0x00087B74 File Offset: 0x00085D74
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormPlayerInfoSignetRenderer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayerInfoSignetRenderer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerInfoSignetRenderer.__c>.NativeClassPtr);
				WormPlayerInfoSignetRenderer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInfoSignetRenderer.__c>.NativeClassPtr, "<>9");
				WormPlayerInfoSignetRenderer.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInfoSignetRenderer.__c>.NativeClassPtr, "<>9__2_0");
				WormPlayerInfoSignetRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInfoSignetRenderer.__c>.NativeClassPtr, 100665308);
				WormPlayerInfoSignetRenderer.__c.NativeMethodInfoPtr__DirtyUpdate_b__2_0_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInfoSignetRenderer.__c>.NativeClassPtr, 100665309);
			}

			// Token: 0x060024F2 RID: 9458 RVA: 0x00087BF0 File Offset: 0x00085DF0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerInfoSignetRenderer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerInfoSignetRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060024F3 RID: 9459 RVA: 0x00087C2C File Offset: 0x00085E2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707088, XrefRangeEnd = 707095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DirtyUpdate_b__2_0(EntityComponent child)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerInfoSignetRenderer.__c.NativeMethodInfoPtr__DirtyUpdate_b__2_0_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060024F4 RID: 9460 RVA: 0x000149A8 File Offset: 0x00012BA8
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A43 RID: 2627
			// (get) Token: 0x060024F5 RID: 9461 RVA: 0x00087C7C File Offset: 0x00085E7C
			// (set) Token: 0x060024F6 RID: 9462 RVA: 0x000149B1 File Offset: 0x00012BB1
			public unsafe static WormPlayerInfoSignetRenderer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayerInfoSignetRenderer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayerInfoSignetRenderer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayerInfoSignetRenderer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A44 RID: 2628
			// (get) Token: 0x060024F7 RID: 9463 RVA: 0x00087CA4 File Offset: 0x00085EA4
			// (set) Token: 0x060024F8 RID: 9464 RVA: 0x000149C3 File Offset: 0x00012BC3
			public unsafe static Func<EntityComponent, bool> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayerInfoSignetRenderer.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayerInfoSignetRenderer.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001532 RID: 5426
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001533 RID: 5427
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04001534 RID: 5428
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001535 RID: 5429
			private static readonly IntPtr NativeMethodInfoPtr__DirtyUpdate_b__2_0_Internal_Boolean_EntityComponent_0;
		}

		// Token: 0x02000398 RID: 920
		[ObfuscatedName("worm.match.dataRenderers.WormPlayerInfoSignetRenderer+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060024F9 RID: 9465 RVA: 0x00087CCC File Offset: 0x00085ECC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<WormPlayerInfoSignetRenderer.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayerInfoSignetRenderer>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerInfoSignetRenderer.__c__DisplayClass2_0>.NativeClassPtr);
				WormPlayerInfoSignetRenderer.__c__DisplayClass2_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInfoSignetRenderer.__c__DisplayClass2_0>.NativeClassPtr, "id");
				WormPlayerInfoSignetRenderer.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInfoSignetRenderer.__c__DisplayClass2_0>.NativeClassPtr, 100665310);
				WormPlayerInfoSignetRenderer.__c__DisplayClass2_0.NativeMethodInfoPtr__DirtyUpdate_b__1_Internal_Boolean_AbilityIDDisplayPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInfoSignetRenderer.__c__DisplayClass2_0>.NativeClassPtr, 100665311);
			}

			// Token: 0x060024FA RID: 9466 RVA: 0x00087D34 File Offset: 0x00085F34
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerInfoSignetRenderer.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerInfoSignetRenderer.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060024FB RID: 9467 RVA: 0x00087D70 File Offset: 0x00085F70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707095, XrefRangeEnd = 707099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DirtyUpdate_b__1(WormPlayerInfoSignetRenderer.AbilityIDDisplayPair pair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerInfoSignetRenderer.__c__DisplayClass2_0.NativeMethodInfoPtr__DirtyUpdate_b__1_Internal_Boolean_AbilityIDDisplayPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060024FC RID: 9468 RVA: 0x000149D5 File Offset: 0x00012BD5
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A45 RID: 2629
			// (get) Token: 0x060024FD RID: 9469 RVA: 0x00087DC4 File Offset: 0x00085FC4
			// (set) Token: 0x060024FE RID: 9470 RVA: 0x000149DE File Offset: 0x00012BDE
			public unsafe AbilityID id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoSignetRenderer.__c__DisplayClass2_0.NativeFieldInfoPtr_id);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoSignetRenderer.__c__DisplayClass2_0.NativeFieldInfoPtr_id), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001536 RID: 5430
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04001537 RID: 5431
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001538 RID: 5432
			private static readonly IntPtr NativeMethodInfoPtr__DirtyUpdate_b__1_Internal_Boolean_AbilityIDDisplayPair_0;
		}
	}
}
