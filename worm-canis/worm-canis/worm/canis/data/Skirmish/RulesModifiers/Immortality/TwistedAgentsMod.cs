using System;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using worm.canis.match;

namespace worm.canis.data.Skirmish.RulesModifiers.Immortality
{
	// Token: 0x020000C1 RID: 193
	public class TwistedAgentsMod : RulesModifier
	{
		// Token: 0x06000D54 RID: 3412 RVA: 0x0009624C File Offset: 0x0009444C
		// Note: this type is marked as 'beforefieldinit'.
		static TwistedAgentsMod()
		{
			Il2CppClassPointerStore<TwistedAgentsMod>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.Skirmish.RulesModifiers.Immortality", "TwistedAgentsMod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TwistedAgentsMod>.NativeClassPtr);
			TwistedAgentsMod.NativeFieldInfoPtr_RuleModID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwistedAgentsMod>.NativeClassPtr, "RuleModID");
			TwistedAgentsMod.NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwistedAgentsMod>.NativeClassPtr, 100665814);
			TwistedAgentsMod.NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwistedAgentsMod>.NativeClassPtr, 100665815);
			TwistedAgentsMod.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwistedAgentsMod>.NativeClassPtr, 100665816);
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000D55 RID: 3413 RVA: 0x000962CC File Offset: 0x000944CC
		public unsafe override int RuleID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TwistedAgentsMod.NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x00096314 File Offset: 0x00094514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75444, XrefRangeEnd = 75494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TwistedAgentsMod.NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormMatchInitData>(intPtr3) : null;
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x00096384 File Offset: 0x00094584
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TwistedAgentsMod()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TwistedAgentsMod>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwistedAgentsMod.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x000070D5 File Offset: 0x000052D5
		public TwistedAgentsMod(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000D59 RID: 3417 RVA: 0x000963C0 File Offset: 0x000945C0
		// (set) Token: 0x06000D5A RID: 3418 RVA: 0x000070DE File Offset: 0x000052DE
		public unsafe static int RuleModID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TwistedAgentsMod.NativeFieldInfoPtr_RuleModID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TwistedAgentsMod.NativeFieldInfoPtr_RuleModID, (void*)(&value));
			}
		}

		// Token: 0x04000861 RID: 2145
		private static readonly IntPtr NativeFieldInfoPtr_RuleModID;

		// Token: 0x04000862 RID: 2146
		private static readonly IntPtr NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0;

		// Token: 0x04000863 RID: 2147
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0;

		// Token: 0x04000864 RID: 2148
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000625 RID: 1573
		[ObfuscatedName("worm.canis.data.Skirmish.RulesModifiers.Immortality.TwistedAgentsMod+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06004EBA RID: 20154 RVA: 0x001A354C File Offset: 0x001A174C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TwistedAgentsMod.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TwistedAgentsMod>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TwistedAgentsMod.__c>.NativeClassPtr);
				TwistedAgentsMod.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwistedAgentsMod.__c>.NativeClassPtr, "<>9");
				TwistedAgentsMod.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwistedAgentsMod.__c>.NativeClassPtr, "<>9__3_0");
				TwistedAgentsMod.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwistedAgentsMod.__c>.NativeClassPtr, 100665818);
				TwistedAgentsMod.__c.NativeMethodInfoPtr__Apply_b__3_0_Internal_Boolean_WormPlayerMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwistedAgentsMod.__c>.NativeClassPtr, 100665819);
			}

			// Token: 0x06004EBB RID: 20155 RVA: 0x001A35C8 File Offset: 0x001A17C8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TwistedAgentsMod.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwistedAgentsMod.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EBC RID: 20156 RVA: 0x001A3604 File Offset: 0x001A1804
			[CallerCount(0)]
			public unsafe bool _Apply_b__3_0(WormPlayerMatchInitData _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwistedAgentsMod.__c.NativeMethodInfoPtr__Apply_b__3_0_Internal_Boolean_WormPlayerMatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004EBD RID: 20157 RVA: 0x0001B318 File Offset: 0x00019518
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001360 RID: 4960
			// (get) Token: 0x06004EBE RID: 20158 RVA: 0x001A3654 File Offset: 0x001A1854
			// (set) Token: 0x06004EBF RID: 20159 RVA: 0x0001B321 File Offset: 0x00019521
			public unsafe static TwistedAgentsMod.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TwistedAgentsMod.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TwistedAgentsMod.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TwistedAgentsMod.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001361 RID: 4961
			// (get) Token: 0x06004EC0 RID: 20160 RVA: 0x001A367C File Offset: 0x001A187C
			// (set) Token: 0x06004EC1 RID: 20161 RVA: 0x0001B333 File Offset: 0x00019533
			public unsafe static Func<WormPlayerMatchInitData, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TwistedAgentsMod.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayerMatchInitData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TwistedAgentsMod.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400339D RID: 13213
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400339E RID: 13214
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x0400339F RID: 13215
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040033A0 RID: 13216
			private static readonly IntPtr NativeMethodInfoPtr__Apply_b__3_0_Internal_Boolean_WormPlayerMatchInitData_0;
		}
	}
}
