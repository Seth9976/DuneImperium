using System;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using worm.canis.match;

namespace worm.canis.data.Skirmish.RulesModifiers.Immortality
{
	// Token: 0x020000B9 RID: 185
	public class FaceDancingInitiationMod : RulesModifier
	{
		// Token: 0x06000D1C RID: 3356 RVA: 0x000955CC File Offset: 0x000937CC
		// Note: this type is marked as 'beforefieldinit'.
		static FaceDancingInitiationMod()
		{
			Il2CppClassPointerStore<FaceDancingInitiationMod>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.Skirmish.RulesModifiers.Immortality", "FaceDancingInitiationMod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FaceDancingInitiationMod>.NativeClassPtr);
			FaceDancingInitiationMod.NativeFieldInfoPtr_RuleModID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceDancingInitiationMod>.NativeClassPtr, "RuleModID");
			FaceDancingInitiationMod.NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceDancingInitiationMod>.NativeClassPtr, 100665784);
			FaceDancingInitiationMod.NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceDancingInitiationMod>.NativeClassPtr, 100665785);
			FaceDancingInitiationMod.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceDancingInitiationMod>.NativeClassPtr, 100665786);
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000D1D RID: 3357 RVA: 0x0009564C File Offset: 0x0009384C
		public unsafe override int RuleID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FaceDancingInitiationMod.NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x00095694 File Offset: 0x00093894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75123, XrefRangeEnd = 75177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FaceDancingInitiationMod.NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormMatchInitData>(intPtr3) : null;
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x00095704 File Offset: 0x00093904
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FaceDancingInitiationMod()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FaceDancingInitiationMod>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceDancingInitiationMod.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x0000701D File Offset: 0x0000521D
		public FaceDancingInitiationMod(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000D21 RID: 3361 RVA: 0x00095740 File Offset: 0x00093940
		// (set) Token: 0x06000D22 RID: 3362 RVA: 0x00007026 File Offset: 0x00005226
		public unsafe static int RuleModID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FaceDancingInitiationMod.NativeFieldInfoPtr_RuleModID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FaceDancingInitiationMod.NativeFieldInfoPtr_RuleModID, (void*)(&value));
			}
		}

		// Token: 0x04000841 RID: 2113
		private static readonly IntPtr NativeFieldInfoPtr_RuleModID;

		// Token: 0x04000842 RID: 2114
		private static readonly IntPtr NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0;

		// Token: 0x04000843 RID: 2115
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0;

		// Token: 0x04000844 RID: 2116
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000623 RID: 1571
		[ObfuscatedName("worm.canis.data.Skirmish.RulesModifiers.Immortality.FaceDancingInitiationMod+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06004EAA RID: 20138 RVA: 0x001A329C File Offset: 0x001A149C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FaceDancingInitiationMod.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FaceDancingInitiationMod>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FaceDancingInitiationMod.__c>.NativeClassPtr);
				FaceDancingInitiationMod.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceDancingInitiationMod.__c>.NativeClassPtr, "<>9");
				FaceDancingInitiationMod.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceDancingInitiationMod.__c>.NativeClassPtr, "<>9__3_0");
				FaceDancingInitiationMod.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceDancingInitiationMod.__c>.NativeClassPtr, 100665788);
				FaceDancingInitiationMod.__c.NativeMethodInfoPtr__Apply_b__3_0_Internal_Boolean_WormPlayerMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceDancingInitiationMod.__c>.NativeClassPtr, 100665789);
			}

			// Token: 0x06004EAB RID: 20139 RVA: 0x001A3318 File Offset: 0x001A1518
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FaceDancingInitiationMod.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceDancingInitiationMod.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EAC RID: 20140 RVA: 0x001A3354 File Offset: 0x001A1554
			[CallerCount(0)]
			public unsafe bool _Apply_b__3_0(WormPlayerMatchInitData _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceDancingInitiationMod.__c.NativeMethodInfoPtr__Apply_b__3_0_Internal_Boolean_WormPlayerMatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004EAD RID: 20141 RVA: 0x0001B2BE File Offset: 0x000194BE
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700135C RID: 4956
			// (get) Token: 0x06004EAE RID: 20142 RVA: 0x001A33A4 File Offset: 0x001A15A4
			// (set) Token: 0x06004EAF RID: 20143 RVA: 0x0001B2C7 File Offset: 0x000194C7
			public unsafe static FaceDancingInitiationMod.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FaceDancingInitiationMod.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FaceDancingInitiationMod.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FaceDancingInitiationMod.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700135D RID: 4957
			// (get) Token: 0x06004EB0 RID: 20144 RVA: 0x001A33CC File Offset: 0x001A15CC
			// (set) Token: 0x06004EB1 RID: 20145 RVA: 0x0001B2D9 File Offset: 0x000194D9
			public unsafe static Func<WormPlayerMatchInitData, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FaceDancingInitiationMod.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayerMatchInitData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FaceDancingInitiationMod.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003395 RID: 13205
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003396 RID: 13206
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04003397 RID: 13207
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003398 RID: 13208
			private static readonly IntPtr NativeMethodInfoPtr__Apply_b__3_0_Internal_Boolean_WormPlayerMatchInitData_0;
		}
	}
}
