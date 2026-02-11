using System;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using worm.canis.match;

namespace worm.canis.data.Skirmish.RulesModifiers.Immortality
{
	// Token: 0x020000BD RID: 189
	public class GeneticResearchMod : RulesModifier
	{
		// Token: 0x06000D38 RID: 3384 RVA: 0x00095C0C File Offset: 0x00093E0C
		// Note: this type is marked as 'beforefieldinit'.
		static GeneticResearchMod()
		{
			Il2CppClassPointerStore<GeneticResearchMod>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.Skirmish.RulesModifiers.Immortality", "GeneticResearchMod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneticResearchMod>.NativeClassPtr);
			GeneticResearchMod.NativeFieldInfoPtr_RuleModID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneticResearchMod>.NativeClassPtr, "RuleModID");
			GeneticResearchMod.NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneticResearchMod>.NativeClassPtr, 100665799);
			GeneticResearchMod.NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneticResearchMod>.NativeClassPtr, 100665800);
			GeneticResearchMod.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneticResearchMod>.NativeClassPtr, 100665801);
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000D39 RID: 3385 RVA: 0x00095C8C File Offset: 0x00093E8C
		public unsafe override int RuleID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GeneticResearchMod.NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x00095CD4 File Offset: 0x00093ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75264, XrefRangeEnd = 75349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GeneticResearchMod.NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormMatchInitData>(intPtr3) : null;
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x00095D44 File Offset: 0x00093F44
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GeneticResearchMod()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeneticResearchMod>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneticResearchMod.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x00007079 File Offset: 0x00005279
		public GeneticResearchMod(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06000D3D RID: 3389 RVA: 0x00095D80 File Offset: 0x00093F80
		// (set) Token: 0x06000D3E RID: 3390 RVA: 0x00007082 File Offset: 0x00005282
		public unsafe static int RuleModID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GeneticResearchMod.NativeFieldInfoPtr_RuleModID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GeneticResearchMod.NativeFieldInfoPtr_RuleModID, (void*)(&value));
			}
		}

		// Token: 0x04000851 RID: 2129
		private static readonly IntPtr NativeFieldInfoPtr_RuleModID;

		// Token: 0x04000852 RID: 2130
		private static readonly IntPtr NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0;

		// Token: 0x04000853 RID: 2131
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0;

		// Token: 0x04000854 RID: 2132
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000624 RID: 1572
		[ObfuscatedName("worm.canis.data.Skirmish.RulesModifiers.Immortality.GeneticResearchMod+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06004EB2 RID: 20146 RVA: 0x001A33F4 File Offset: 0x001A15F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GeneticResearchMod.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GeneticResearchMod>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneticResearchMod.__c>.NativeClassPtr);
				GeneticResearchMod.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneticResearchMod.__c>.NativeClassPtr, "<>9");
				GeneticResearchMod.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneticResearchMod.__c>.NativeClassPtr, "<>9__3_0");
				GeneticResearchMod.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneticResearchMod.__c>.NativeClassPtr, 100665803);
				GeneticResearchMod.__c.NativeMethodInfoPtr__Apply_b__3_0_Internal_Boolean_WormPlayerMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneticResearchMod.__c>.NativeClassPtr, 100665804);
			}

			// Token: 0x06004EB3 RID: 20147 RVA: 0x001A3470 File Offset: 0x001A1670
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeneticResearchMod.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneticResearchMod.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EB4 RID: 20148 RVA: 0x001A34AC File Offset: 0x001A16AC
			[CallerCount(0)]
			public unsafe bool _Apply_b__3_0(WormPlayerMatchInitData _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneticResearchMod.__c.NativeMethodInfoPtr__Apply_b__3_0_Internal_Boolean_WormPlayerMatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004EB5 RID: 20149 RVA: 0x0001B2EB File Offset: 0x000194EB
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700135E RID: 4958
			// (get) Token: 0x06004EB6 RID: 20150 RVA: 0x001A34FC File Offset: 0x001A16FC
			// (set) Token: 0x06004EB7 RID: 20151 RVA: 0x0001B2F4 File Offset: 0x000194F4
			public unsafe static GeneticResearchMod.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GeneticResearchMod.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GeneticResearchMod.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GeneticResearchMod.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700135F RID: 4959
			// (get) Token: 0x06004EB8 RID: 20152 RVA: 0x001A3524 File Offset: 0x001A1724
			// (set) Token: 0x06004EB9 RID: 20153 RVA: 0x0001B306 File Offset: 0x00019506
			public unsafe static Func<WormPlayerMatchInitData, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GeneticResearchMod.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayerMatchInitData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GeneticResearchMod.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003399 RID: 13209
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400339A RID: 13210
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x0400339B RID: 13211
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400339C RID: 13212
			private static readonly IntPtr NativeMethodInfoPtr__Apply_b__3_0_Internal_Boolean_WormPlayerMatchInitData_0;
		}
	}
}
