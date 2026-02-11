using System;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using worm.canis.match;

namespace worm.canis.data.Skirmish.RulesModifiers.Immortality
{
	// Token: 0x020000B8 RID: 184
	public class ExpendableArmyMod : RulesModifier
	{
		// Token: 0x06000D15 RID: 3349 RVA: 0x0009543C File Offset: 0x0009363C
		// Note: this type is marked as 'beforefieldinit'.
		static ExpendableArmyMod()
		{
			Il2CppClassPointerStore<ExpendableArmyMod>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.Skirmish.RulesModifiers.Immortality", "ExpendableArmyMod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpendableArmyMod>.NativeClassPtr);
			ExpendableArmyMod.NativeFieldInfoPtr_RuleModID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpendableArmyMod>.NativeClassPtr, "RuleModID");
			ExpendableArmyMod.NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpendableArmyMod>.NativeClassPtr, 100665778);
			ExpendableArmyMod.NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpendableArmyMod>.NativeClassPtr, 100665779);
			ExpendableArmyMod.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpendableArmyMod>.NativeClassPtr, 100665780);
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000D16 RID: 3350 RVA: 0x000954BC File Offset: 0x000936BC
		public unsafe override int RuleID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpendableArmyMod.NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x00095504 File Offset: 0x00093704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75072, XrefRangeEnd = 75123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpendableArmyMod.NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormMatchInitData>(intPtr3) : null;
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x00095574 File Offset: 0x00093774
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExpendableArmyMod()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpendableArmyMod>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpendableArmyMod.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x00007006 File Offset: 0x00005206
		public ExpendableArmyMod(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000D1A RID: 3354 RVA: 0x000955B0 File Offset: 0x000937B0
		// (set) Token: 0x06000D1B RID: 3355 RVA: 0x0000700F File Offset: 0x0000520F
		public unsafe static int RuleModID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ExpendableArmyMod.NativeFieldInfoPtr_RuleModID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExpendableArmyMod.NativeFieldInfoPtr_RuleModID, (void*)(&value));
			}
		}

		// Token: 0x0400083D RID: 2109
		private static readonly IntPtr NativeFieldInfoPtr_RuleModID;

		// Token: 0x0400083E RID: 2110
		private static readonly IntPtr NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0;

		// Token: 0x0400083F RID: 2111
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0;

		// Token: 0x04000840 RID: 2112
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000622 RID: 1570
		[ObfuscatedName("worm.canis.data.Skirmish.RulesModifiers.Immortality.ExpendableArmyMod+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06004EA2 RID: 20130 RVA: 0x001A3144 File Offset: 0x001A1344
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ExpendableArmyMod.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExpendableArmyMod>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpendableArmyMod.__c>.NativeClassPtr);
				ExpendableArmyMod.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpendableArmyMod.__c>.NativeClassPtr, "<>9");
				ExpendableArmyMod.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpendableArmyMod.__c>.NativeClassPtr, "<>9__3_0");
				ExpendableArmyMod.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpendableArmyMod.__c>.NativeClassPtr, 100665782);
				ExpendableArmyMod.__c.NativeMethodInfoPtr__Apply_b__3_0_Internal_Boolean_WormPlayerMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpendableArmyMod.__c>.NativeClassPtr, 100665783);
			}

			// Token: 0x06004EA3 RID: 20131 RVA: 0x001A31C0 File Offset: 0x001A13C0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpendableArmyMod.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpendableArmyMod.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EA4 RID: 20132 RVA: 0x001A31FC File Offset: 0x001A13FC
			[CallerCount(0)]
			public unsafe bool _Apply_b__3_0(WormPlayerMatchInitData _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpendableArmyMod.__c.NativeMethodInfoPtr__Apply_b__3_0_Internal_Boolean_WormPlayerMatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004EA5 RID: 20133 RVA: 0x0001B291 File Offset: 0x00019491
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700135A RID: 4954
			// (get) Token: 0x06004EA6 RID: 20134 RVA: 0x001A324C File Offset: 0x001A144C
			// (set) Token: 0x06004EA7 RID: 20135 RVA: 0x0001B29A File Offset: 0x0001949A
			public unsafe static ExpendableArmyMod.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ExpendableArmyMod.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExpendableArmyMod.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ExpendableArmyMod.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700135B RID: 4955
			// (get) Token: 0x06004EA8 RID: 20136 RVA: 0x001A3274 File Offset: 0x001A1474
			// (set) Token: 0x06004EA9 RID: 20137 RVA: 0x0001B2AC File Offset: 0x000194AC
			public unsafe static Func<WormPlayerMatchInitData, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ExpendableArmyMod.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayerMatchInitData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ExpendableArmyMod.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003391 RID: 13201
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003392 RID: 13202
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04003393 RID: 13203
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003394 RID: 13204
			private static readonly IntPtr NativeMethodInfoPtr__Apply_b__3_0_Internal_Boolean_WormPlayerMatchInitData_0;
		}
	}
}
