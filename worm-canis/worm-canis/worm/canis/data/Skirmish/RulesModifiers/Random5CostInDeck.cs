using System;
using Canis;
using canis.archetypes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using worm.canis.match;

namespace worm.canis.data.Skirmish.RulesModifiers
{
	// Token: 0x02000092 RID: 146
	public class Random5CostInDeck : RulesModifier
	{
		// Token: 0x06000C48 RID: 3144 RVA: 0x00091F10 File Offset: 0x00090110
		// Note: this type is marked as 'beforefieldinit'.
		static Random5CostInDeck()
		{
			Il2CppClassPointerStore<Random5CostInDeck>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.Skirmish.RulesModifiers", "Random5CostInDeck");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Random5CostInDeck>.NativeClassPtr);
			Random5CostInDeck.NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random5CostInDeck>.NativeClassPtr, 100665635);
			Random5CostInDeck.NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random5CostInDeck>.NativeClassPtr, 100665636);
			Random5CostInDeck.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random5CostInDeck>.NativeClassPtr, 100665637);
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000C49 RID: 3145 RVA: 0x00091F7C File Offset: 0x0009017C
		public unsafe override int RuleID
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Random5CostInDeck.NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x00091FC4 File Offset: 0x000901C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73976, XrefRangeEnd = 74029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WormMatchInitData Apply(WormMatchInitData wormMatchInitData, CanisRandom random)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatchInitData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(random);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Random5CostInDeck.NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormMatchInitData>(intPtr3) : null;
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x00092034 File Offset: 0x00090234
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Random5CostInDeck()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Random5CostInDeck>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random5CostInDeck.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x00006E3C File Offset: 0x0000503C
		public Random5CostInDeck(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007C4 RID: 1988
		private static readonly IntPtr NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0;

		// Token: 0x040007C5 RID: 1989
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0;

		// Token: 0x040007C6 RID: 1990
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200061B RID: 1563
		[ObfuscatedName("worm.canis.data.Skirmish.RulesModifiers.Random5CostInDeck+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06004E57 RID: 20055 RVA: 0x001A23A0 File Offset: 0x001A05A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Random5CostInDeck.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Random5CostInDeck>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Random5CostInDeck.__c>.NativeClassPtr);
				Random5CostInDeck.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Random5CostInDeck.__c>.NativeClassPtr, "<>9");
				Random5CostInDeck.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Random5CostInDeck.__c>.NativeClassPtr, "<>9__2_0");
				Random5CostInDeck.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random5CostInDeck.__c>.NativeClassPtr, 100665639);
				Random5CostInDeck.__c.NativeMethodInfoPtr__Apply_b__2_0_Internal_Boolean_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random5CostInDeck.__c>.NativeClassPtr, 100665640);
			}

			// Token: 0x06004E58 RID: 20056 RVA: 0x001A241C File Offset: 0x001A061C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Random5CostInDeck.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random5CostInDeck.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E59 RID: 20057 RVA: 0x001A2458 File Offset: 0x001A0658
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73951, XrefRangeEnd = 73976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Apply_b__2_0(Archetype _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random5CostInDeck.__c.NativeMethodInfoPtr__Apply_b__2_0_Internal_Boolean_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004E5A RID: 20058 RVA: 0x0001B0C3 File Offset: 0x000192C3
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001345 RID: 4933
			// (get) Token: 0x06004E5B RID: 20059 RVA: 0x001A24A8 File Offset: 0x001A06A8
			// (set) Token: 0x06004E5C RID: 20060 RVA: 0x0001B0CC File Offset: 0x000192CC
			public unsafe static Random5CostInDeck.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Random5CostInDeck.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Random5CostInDeck.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Random5CostInDeck.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001346 RID: 4934
			// (get) Token: 0x06004E5D RID: 20061 RVA: 0x001A24D0 File Offset: 0x001A06D0
			// (set) Token: 0x06004E5E RID: 20062 RVA: 0x0001B0DE File Offset: 0x000192DE
			public unsafe static Func<Archetype, bool> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Random5CostInDeck.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Archetype, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Random5CostInDeck.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003367 RID: 13159
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003368 RID: 13160
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04003369 RID: 13161
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400336A RID: 13162
			private static readonly IntPtr NativeMethodInfoPtr__Apply_b__2_0_Internal_Boolean_Archetype_0;
		}
	}
}
