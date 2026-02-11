using System;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using worm.canis.match;

namespace worm.canis.data.Skirmish.RulesModifiers.Immortality
{
	// Token: 0x020000B6 RID: 182
	public class DuelingLabsMod : RulesModifier
	{
		// Token: 0x06000D07 RID: 3335 RVA: 0x0009511C File Offset: 0x0009331C
		// Note: this type is marked as 'beforefieldinit'.
		static DuelingLabsMod()
		{
			Il2CppClassPointerStore<DuelingLabsMod>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.Skirmish.RulesModifiers.Immortality", "DuelingLabsMod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DuelingLabsMod>.NativeClassPtr);
			DuelingLabsMod.NativeFieldInfoPtr_RuleModID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelingLabsMod>.NativeClassPtr, "RuleModID");
			DuelingLabsMod.NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelingLabsMod>.NativeClassPtr, 100665768);
			DuelingLabsMod.NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelingLabsMod>.NativeClassPtr, 100665769);
			DuelingLabsMod.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelingLabsMod>.NativeClassPtr, 100665770);
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000D08 RID: 3336 RVA: 0x0009519C File Offset: 0x0009339C
		public unsafe override int RuleID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DuelingLabsMod.NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x000951E4 File Offset: 0x000933E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74970, XrefRangeEnd = 75056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DuelingLabsMod.NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormMatchInitData>(intPtr3) : null;
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x00095254 File Offset: 0x00093454
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DuelingLabsMod()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DuelingLabsMod>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DuelingLabsMod.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x00006FD8 File Offset: 0x000051D8
		public DuelingLabsMod(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000D0C RID: 3340 RVA: 0x00095290 File Offset: 0x00093490
		// (set) Token: 0x06000D0D RID: 3341 RVA: 0x00006FE1 File Offset: 0x000051E1
		public unsafe static int RuleModID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DuelingLabsMod.NativeFieldInfoPtr_RuleModID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DuelingLabsMod.NativeFieldInfoPtr_RuleModID, (void*)(&value));
			}
		}

		// Token: 0x04000835 RID: 2101
		private static readonly IntPtr NativeFieldInfoPtr_RuleModID;

		// Token: 0x04000836 RID: 2102
		private static readonly IntPtr NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0;

		// Token: 0x04000837 RID: 2103
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0;

		// Token: 0x04000838 RID: 2104
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000621 RID: 1569
		[ObfuscatedName("worm.canis.data.Skirmish.RulesModifiers.Immortality.DuelingLabsMod+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06004E97 RID: 20119 RVA: 0x001A2F4C File Offset: 0x001A114C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DuelingLabsMod.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DuelingLabsMod>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DuelingLabsMod.__c>.NativeClassPtr);
				DuelingLabsMod.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelingLabsMod.__c>.NativeClassPtr, "<>9");
				DuelingLabsMod.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelingLabsMod.__c>.NativeClassPtr, "<>9__3_0");
				DuelingLabsMod.__c.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelingLabsMod.__c>.NativeClassPtr, "<>9__3_1");
				DuelingLabsMod.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelingLabsMod.__c>.NativeClassPtr, 100665772);
				DuelingLabsMod.__c.NativeMethodInfoPtr__Apply_b__3_0_Internal_Boolean_WormPlayerMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelingLabsMod.__c>.NativeClassPtr, 100665773);
				DuelingLabsMod.__c.NativeMethodInfoPtr__Apply_b__3_1_Internal_Boolean_WormPlayerMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelingLabsMod.__c>.NativeClassPtr, 100665774);
			}

			// Token: 0x06004E98 RID: 20120 RVA: 0x001A2FF0 File Offset: 0x001A11F0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DuelingLabsMod.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DuelingLabsMod.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E99 RID: 20121 RVA: 0x001A302C File Offset: 0x001A122C
			[CallerCount(0)]
			public unsafe bool _Apply_b__3_0(WormPlayerMatchInitData _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DuelingLabsMod.__c.NativeMethodInfoPtr__Apply_b__3_0_Internal_Boolean_WormPlayerMatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004E9A RID: 20122 RVA: 0x001A307C File Offset: 0x001A127C
			[CallerCount(0)]
			public unsafe bool _Apply_b__3_1(WormPlayerMatchInitData _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DuelingLabsMod.__c.NativeMethodInfoPtr__Apply_b__3_1_Internal_Boolean_WormPlayerMatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004E9B RID: 20123 RVA: 0x0001B252 File Offset: 0x00019452
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001357 RID: 4951
			// (get) Token: 0x06004E9C RID: 20124 RVA: 0x001A30CC File Offset: 0x001A12CC
			// (set) Token: 0x06004E9D RID: 20125 RVA: 0x0001B25B File Offset: 0x0001945B
			public unsafe static DuelingLabsMod.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DuelingLabsMod.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DuelingLabsMod.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DuelingLabsMod.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001358 RID: 4952
			// (get) Token: 0x06004E9E RID: 20126 RVA: 0x001A30F4 File Offset: 0x001A12F4
			// (set) Token: 0x06004E9F RID: 20127 RVA: 0x0001B26D File Offset: 0x0001946D
			public unsafe static Func<WormPlayerMatchInitData, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DuelingLabsMod.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayerMatchInitData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DuelingLabsMod.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001359 RID: 4953
			// (get) Token: 0x06004EA0 RID: 20128 RVA: 0x001A311C File Offset: 0x001A131C
			// (set) Token: 0x06004EA1 RID: 20129 RVA: 0x0001B27F File Offset: 0x0001947F
			public unsafe static Func<WormPlayerMatchInitData, bool> __9__3_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DuelingLabsMod.__c.NativeFieldInfoPtr___9__3_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayerMatchInitData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DuelingLabsMod.__c.NativeFieldInfoPtr___9__3_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400338B RID: 13195
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400338C RID: 13196
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x0400338D RID: 13197
			private static readonly IntPtr NativeFieldInfoPtr___9__3_1;

			// Token: 0x0400338E RID: 13198
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400338F RID: 13199
			private static readonly IntPtr NativeMethodInfoPtr__Apply_b__3_0_Internal_Boolean_WormPlayerMatchInitData_0;

			// Token: 0x04003390 RID: 13200
			private static readonly IntPtr NativeMethodInfoPtr__Apply_b__3_1_Internal_Boolean_WormPlayerMatchInitData_0;
		}
	}
}
