using System;
using Canis.entities;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using lib.canis.worm_canis.data.Skirmish.ScoringMethods;
using worm.canis.entities;

namespace worm.canis.data.Skirmish.ScoringMethods
{
	// Token: 0x0200005E RID: 94
	public class NamedCharacterScoringMethod : SkirmishScoringMethod
	{
		// Token: 0x06000B26 RID: 2854 RVA: 0x0008CCE0 File Offset: 0x0008AEE0
		// Note: this type is marked as 'beforefieldinit'.
		static NamedCharacterScoringMethod()
		{
			Il2CppClassPointerStore<NamedCharacterScoringMethod>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.Skirmish.ScoringMethods", "NamedCharacterScoringMethod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NamedCharacterScoringMethod>.NativeClassPtr);
			NamedCharacterScoringMethod.NativeMethodInfoPtr_get_MethodID_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamedCharacterScoringMethod>.NativeClassPtr, 100665441);
			NamedCharacterScoringMethod.NativeMethodInfoPtr_get_PromptKey_Public_Virtual_get_LocalizableTextVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamedCharacterScoringMethod>.NativeClassPtr, 100665442);
			NamedCharacterScoringMethod.NativeMethodInfoPtr_Compute_Public_Virtual_SkirmishScoreItem_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamedCharacterScoringMethod>.NativeClassPtr, 100665443);
			NamedCharacterScoringMethod.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamedCharacterScoringMethod>.NativeClassPtr, 100665444);
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x0008CD60 File Offset: 0x0008AF60
		public unsafe override int MethodID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NamedCharacterScoringMethod.NativeMethodInfoPtr_get_MethodID_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000B28 RID: 2856 RVA: 0x0008CDA8 File Offset: 0x0008AFA8
		public unsafe override LocalizableTextVariables PromptKey
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72804, XrefRangeEnd = 72810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NamedCharacterScoringMethod.NativeMethodInfoPtr_get_PromptKey_Public_Virtual_get_LocalizableTextVariables_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr3) : null;
			}
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x0008CDF4 File Offset: 0x0008AFF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72810, XrefRangeEnd = 72841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SkirmishScoreItem Compute(WormMatch wormMatch, WormPlayer wormPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wormPlayer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NamedCharacterScoringMethod.NativeMethodInfoPtr_Compute_Public_Virtual_SkirmishScoreItem_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkirmishScoreItem>(intPtr3) : null;
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x0008CE64 File Offset: 0x0008B064
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NamedCharacterScoringMethod()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NamedCharacterScoringMethod>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamedCharacterScoringMethod.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00006C5A File Offset: 0x00004E5A
		public NamedCharacterScoringMethod(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400070B RID: 1803
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodID_Public_Virtual_get_Int32_0;

		// Token: 0x0400070C RID: 1804
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptKey_Public_Virtual_get_LocalizableTextVariables_0;

		// Token: 0x0400070D RID: 1805
		private static readonly IntPtr NativeMethodInfoPtr_Compute_Public_Virtual_SkirmishScoreItem_WormMatch_WormPlayer_0;

		// Token: 0x0400070E RID: 1806
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000617 RID: 1559
		[ObfuscatedName("worm.canis.data.Skirmish.ScoringMethods.NamedCharacterScoringMethod+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06004E3B RID: 20027 RVA: 0x001A1EA0 File Offset: 0x001A00A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NamedCharacterScoringMethod.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NamedCharacterScoringMethod>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NamedCharacterScoringMethod.__c>.NativeClassPtr);
				NamedCharacterScoringMethod.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamedCharacterScoringMethod.__c>.NativeClassPtr, "<>9");
				NamedCharacterScoringMethod.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamedCharacterScoringMethod.__c>.NativeClassPtr, "<>9__4_0");
				NamedCharacterScoringMethod.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamedCharacterScoringMethod.__c>.NativeClassPtr, 100665446);
				NamedCharacterScoringMethod.__c.NativeMethodInfoPtr__Compute_b__4_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamedCharacterScoringMethod.__c>.NativeClassPtr, 100665447);
			}

			// Token: 0x06004E3C RID: 20028 RVA: 0x001A1F1C File Offset: 0x001A011C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NamedCharacterScoringMethod.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamedCharacterScoringMethod.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E3D RID: 20029 RVA: 0x001A1F58 File Offset: 0x001A0158
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72799, XrefRangeEnd = 72804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Compute_b__4_0(Entity card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamedCharacterScoringMethod.__c.NativeMethodInfoPtr__Compute_b__4_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004E3E RID: 20030 RVA: 0x0001B019 File Offset: 0x00019219
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700133F RID: 4927
			// (get) Token: 0x06004E3F RID: 20031 RVA: 0x001A1FA8 File Offset: 0x001A01A8
			// (set) Token: 0x06004E40 RID: 20032 RVA: 0x0001B022 File Offset: 0x00019222
			public unsafe static NamedCharacterScoringMethod.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NamedCharacterScoringMethod.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NamedCharacterScoringMethod.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NamedCharacterScoringMethod.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001340 RID: 4928
			// (get) Token: 0x06004E41 RID: 20033 RVA: 0x001A1FD0 File Offset: 0x001A01D0
			// (set) Token: 0x06004E42 RID: 20034 RVA: 0x0001B034 File Offset: 0x00019234
			public unsafe static Func<Entity, bool> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NamedCharacterScoringMethod.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NamedCharacterScoringMethod.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003359 RID: 13145
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400335A RID: 13146
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x0400335B RID: 13147
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400335C RID: 13148
			private static readonly IntPtr NativeMethodInfoPtr__Compute_b__4_0_Internal_Boolean_Entity_0;
		}
	}
}
