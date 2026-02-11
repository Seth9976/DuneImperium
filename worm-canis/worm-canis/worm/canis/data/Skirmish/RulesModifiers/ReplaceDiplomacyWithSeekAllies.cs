using System;
using Canis;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using worm.canis.match;

namespace worm.canis.data.Skirmish.RulesModifiers
{
	// Token: 0x02000097 RID: 151
	public class ReplaceDiplomacyWithSeekAllies : RulesModifier
	{
		// Token: 0x06000C61 RID: 3169 RVA: 0x000925F0 File Offset: 0x000907F0
		// Note: this type is marked as 'beforefieldinit'.
		static ReplaceDiplomacyWithSeekAllies()
		{
			Il2CppClassPointerStore<ReplaceDiplomacyWithSeekAllies>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.Skirmish.RulesModifiers", "ReplaceDiplomacyWithSeekAllies");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplaceDiplomacyWithSeekAllies>.NativeClassPtr);
			ReplaceDiplomacyWithSeekAllies.NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceDiplomacyWithSeekAllies>.NativeClassPtr, 100665653);
			ReplaceDiplomacyWithSeekAllies.NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceDiplomacyWithSeekAllies>.NativeClassPtr, 100665654);
			ReplaceDiplomacyWithSeekAllies.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceDiplomacyWithSeekAllies>.NativeClassPtr, 100665655);
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000C62 RID: 3170 RVA: 0x0009265C File Offset: 0x0009085C
		public unsafe override int RuleID
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 40756, RefRangeEnd = 40759, XrefRangeStart = 40756, XrefRangeEnd = 40759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReplaceDiplomacyWithSeekAllies.NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x000926A4 File Offset: 0x000908A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74101, XrefRangeEnd = 74152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReplaceDiplomacyWithSeekAllies.NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormMatchInitData>(intPtr3) : null;
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x00092714 File Offset: 0x00090914
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReplaceDiplomacyWithSeekAllies()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReplaceDiplomacyWithSeekAllies>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplaceDiplomacyWithSeekAllies.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x00006E69 File Offset: 0x00005069
		public ReplaceDiplomacyWithSeekAllies(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007D3 RID: 2003
		private static readonly IntPtr NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0;

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0;

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200061C RID: 1564
		[ObfuscatedName("worm.canis.data.Skirmish.RulesModifiers.ReplaceDiplomacyWithSeekAllies+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06004E5F RID: 20063 RVA: 0x001A24F8 File Offset: 0x001A06F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ReplaceDiplomacyWithSeekAllies.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplaceDiplomacyWithSeekAllies>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplaceDiplomacyWithSeekAllies.__c>.NativeClassPtr);
				ReplaceDiplomacyWithSeekAllies.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceDiplomacyWithSeekAllies.__c>.NativeClassPtr, "<>9");
				ReplaceDiplomacyWithSeekAllies.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceDiplomacyWithSeekAllies.__c>.NativeClassPtr, "<>9__2_0");
				ReplaceDiplomacyWithSeekAllies.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceDiplomacyWithSeekAllies.__c>.NativeClassPtr, 100665657);
				ReplaceDiplomacyWithSeekAllies.__c.NativeMethodInfoPtr__Apply_b__2_0_Internal_Boolean_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceDiplomacyWithSeekAllies.__c>.NativeClassPtr, 100665658);
			}

			// Token: 0x06004E60 RID: 20064 RVA: 0x001A2574 File Offset: 0x001A0774
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReplaceDiplomacyWithSeekAllies.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplaceDiplomacyWithSeekAllies.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E61 RID: 20065 RVA: 0x001A25B0 File Offset: 0x001A07B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74093, XrefRangeEnd = 74101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Apply_b__2_0(ArchetypeID id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplaceDiplomacyWithSeekAllies.__c.NativeMethodInfoPtr__Apply_b__2_0_Internal_Boolean_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004E62 RID: 20066 RVA: 0x0001B0F0 File Offset: 0x000192F0
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001347 RID: 4935
			// (get) Token: 0x06004E63 RID: 20067 RVA: 0x001A2600 File Offset: 0x001A0800
			// (set) Token: 0x06004E64 RID: 20068 RVA: 0x0001B0F9 File Offset: 0x000192F9
			public unsafe static ReplaceDiplomacyWithSeekAllies.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReplaceDiplomacyWithSeekAllies.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReplaceDiplomacyWithSeekAllies.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReplaceDiplomacyWithSeekAllies.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001348 RID: 4936
			// (get) Token: 0x06004E65 RID: 20069 RVA: 0x001A2628 File Offset: 0x001A0828
			// (set) Token: 0x06004E66 RID: 20070 RVA: 0x0001B10B File Offset: 0x0001930B
			public unsafe static Func<ArchetypeID, bool> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReplaceDiplomacyWithSeekAllies.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ArchetypeID, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReplaceDiplomacyWithSeekAllies.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400336B RID: 13163
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400336C RID: 13164
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x0400336D RID: 13165
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400336E RID: 13166
			private static readonly IntPtr NativeMethodInfoPtr__Apply_b__2_0_Internal_Boolean_ArchetypeID_0;
		}
	}
}
