using System;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using worm.canis.match;

namespace worm.canis.data.Skirmish.RulesModifiers.Immortality
{
	// Token: 0x020000C2 RID: 194
	public class UndiplomaticExperimentsMod : RulesModifier
	{
		// Token: 0x06000D5B RID: 3419 RVA: 0x000963DC File Offset: 0x000945DC
		// Note: this type is marked as 'beforefieldinit'.
		static UndiplomaticExperimentsMod()
		{
			Il2CppClassPointerStore<UndiplomaticExperimentsMod>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.Skirmish.RulesModifiers.Immortality", "UndiplomaticExperimentsMod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UndiplomaticExperimentsMod>.NativeClassPtr);
			UndiplomaticExperimentsMod.NativeFieldInfoPtr_RuleModID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndiplomaticExperimentsMod>.NativeClassPtr, "RuleModID");
			UndiplomaticExperimentsMod.NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndiplomaticExperimentsMod>.NativeClassPtr, 100665820);
			UndiplomaticExperimentsMod.NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndiplomaticExperimentsMod>.NativeClassPtr, 100665821);
			UndiplomaticExperimentsMod.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndiplomaticExperimentsMod>.NativeClassPtr, 100665822);
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000D5C RID: 3420 RVA: 0x0009645C File Offset: 0x0009465C
		public unsafe override int RuleID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UndiplomaticExperimentsMod.NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x000964A4 File Offset: 0x000946A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75494, XrefRangeEnd = 75548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UndiplomaticExperimentsMod.NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormMatchInitData>(intPtr3) : null;
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x00096514 File Offset: 0x00094714
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UndiplomaticExperimentsMod()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UndiplomaticExperimentsMod>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndiplomaticExperimentsMod.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x000070EC File Offset: 0x000052EC
		public UndiplomaticExperimentsMod(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000D60 RID: 3424 RVA: 0x00096550 File Offset: 0x00094750
		// (set) Token: 0x06000D61 RID: 3425 RVA: 0x000070F5 File Offset: 0x000052F5
		public unsafe static int RuleModID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UndiplomaticExperimentsMod.NativeFieldInfoPtr_RuleModID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UndiplomaticExperimentsMod.NativeFieldInfoPtr_RuleModID, (void*)(&value));
			}
		}

		// Token: 0x04000865 RID: 2149
		private static readonly IntPtr NativeFieldInfoPtr_RuleModID;

		// Token: 0x04000866 RID: 2150
		private static readonly IntPtr NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0;

		// Token: 0x04000867 RID: 2151
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0;

		// Token: 0x04000868 RID: 2152
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000626 RID: 1574
		[ObfuscatedName("worm.canis.data.Skirmish.RulesModifiers.Immortality.UndiplomaticExperimentsMod+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06004EC2 RID: 20162 RVA: 0x001A36A4 File Offset: 0x001A18A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UndiplomaticExperimentsMod.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UndiplomaticExperimentsMod>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UndiplomaticExperimentsMod.__c>.NativeClassPtr);
				UndiplomaticExperimentsMod.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndiplomaticExperimentsMod.__c>.NativeClassPtr, "<>9");
				UndiplomaticExperimentsMod.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndiplomaticExperimentsMod.__c>.NativeClassPtr, "<>9__3_0");
				UndiplomaticExperimentsMod.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndiplomaticExperimentsMod.__c>.NativeClassPtr, 100665824);
				UndiplomaticExperimentsMod.__c.NativeMethodInfoPtr__Apply_b__3_0_Internal_Boolean_WormPlayerMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndiplomaticExperimentsMod.__c>.NativeClassPtr, 100665825);
			}

			// Token: 0x06004EC3 RID: 20163 RVA: 0x001A3720 File Offset: 0x001A1920
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UndiplomaticExperimentsMod.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndiplomaticExperimentsMod.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EC4 RID: 20164 RVA: 0x001A375C File Offset: 0x001A195C
			[CallerCount(0)]
			public unsafe bool _Apply_b__3_0(WormPlayerMatchInitData _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndiplomaticExperimentsMod.__c.NativeMethodInfoPtr__Apply_b__3_0_Internal_Boolean_WormPlayerMatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004EC5 RID: 20165 RVA: 0x0001B345 File Offset: 0x00019545
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001362 RID: 4962
			// (get) Token: 0x06004EC6 RID: 20166 RVA: 0x001A37AC File Offset: 0x001A19AC
			// (set) Token: 0x06004EC7 RID: 20167 RVA: 0x0001B34E File Offset: 0x0001954E
			public unsafe static UndiplomaticExperimentsMod.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UndiplomaticExperimentsMod.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndiplomaticExperimentsMod.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UndiplomaticExperimentsMod.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001363 RID: 4963
			// (get) Token: 0x06004EC8 RID: 20168 RVA: 0x001A37D4 File Offset: 0x001A19D4
			// (set) Token: 0x06004EC9 RID: 20169 RVA: 0x0001B360 File Offset: 0x00019560
			public unsafe static Func<WormPlayerMatchInitData, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UndiplomaticExperimentsMod.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayerMatchInitData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UndiplomaticExperimentsMod.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040033A1 RID: 13217
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040033A2 RID: 13218
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x040033A3 RID: 13219
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040033A4 RID: 13220
			private static readonly IntPtr NativeMethodInfoPtr__Apply_b__3_0_Internal_Boolean_WormPlayerMatchInitData_0;
		}
	}
}
