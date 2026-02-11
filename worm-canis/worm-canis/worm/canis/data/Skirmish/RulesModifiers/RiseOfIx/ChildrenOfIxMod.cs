using System;
using Canis;
using canis.archetypes;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using worm.canis.match;

namespace worm.canis.data.Skirmish.RulesModifiers.RiseOfIx
{
	// Token: 0x020000A3 RID: 163
	public class ChildrenOfIxMod : RulesModifier
	{
		// Token: 0x06000CA0 RID: 3232 RVA: 0x0009363C File Offset: 0x0009183C
		// Note: this type is marked as 'beforefieldinit'.
		static ChildrenOfIxMod()
		{
			Il2CppClassPointerStore<ChildrenOfIxMod>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.Skirmish.RulesModifiers.RiseOfIx", "ChildrenOfIxMod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChildrenOfIxMod>.NativeClassPtr);
			ChildrenOfIxMod.NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChildrenOfIxMod>.NativeClassPtr, 100665704);
			ChildrenOfIxMod.NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChildrenOfIxMod>.NativeClassPtr, 100665705);
			ChildrenOfIxMod.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChildrenOfIxMod>.NativeClassPtr, 100665706);
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x000936A8 File Offset: 0x000918A8
		public unsafe override int RuleID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChildrenOfIxMod.NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x000936F0 File Offset: 0x000918F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74454, XrefRangeEnd = 74511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChildrenOfIxMod.NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormMatchInitData>(intPtr3) : null;
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x00093760 File Offset: 0x00091960
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChildrenOfIxMod()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChildrenOfIxMod>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChildrenOfIxMod.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x00006EF5 File Offset: 0x000050F5
		public ChildrenOfIxMod(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007F8 RID: 2040
		private static readonly IntPtr NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0;

		// Token: 0x040007F9 RID: 2041
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0;

		// Token: 0x040007FA RID: 2042
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200061F RID: 1567
		[ObfuscatedName("worm.canis.data.Skirmish.RulesModifiers.RiseOfIx.ChildrenOfIxMod+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06004E84 RID: 20100 RVA: 0x001A2BFC File Offset: 0x001A0DFC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ChildrenOfIxMod.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChildrenOfIxMod>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChildrenOfIxMod.__c>.NativeClassPtr);
				ChildrenOfIxMod.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChildrenOfIxMod.__c>.NativeClassPtr, "<>9");
				ChildrenOfIxMod.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChildrenOfIxMod.__c>.NativeClassPtr, "<>9__2_0");
				ChildrenOfIxMod.__c.NativeFieldInfoPtr___9__2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChildrenOfIxMod.__c>.NativeClassPtr, "<>9__2_1");
				ChildrenOfIxMod.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChildrenOfIxMod.__c>.NativeClassPtr, 100665708);
				ChildrenOfIxMod.__c.NativeMethodInfoPtr__Apply_b__2_0_Internal_Boolean_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChildrenOfIxMod.__c>.NativeClassPtr, 100665709);
				ChildrenOfIxMod.__c.NativeMethodInfoPtr__Apply_b__2_1_Internal_ArchetypeID_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChildrenOfIxMod.__c>.NativeClassPtr, 100665710);
			}

			// Token: 0x06004E85 RID: 20101 RVA: 0x001A2CA0 File Offset: 0x001A0EA0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChildrenOfIxMod.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChildrenOfIxMod.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E86 RID: 20102 RVA: 0x001A2CDC File Offset: 0x001A0EDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74446, XrefRangeEnd = 74453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Apply_b__2_0(Archetype _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChildrenOfIxMod.__c.NativeMethodInfoPtr__Apply_b__2_0_Internal_Boolean_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004E87 RID: 20103 RVA: 0x001A2D2C File Offset: 0x001A0F2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74453, XrefRangeEnd = 74454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArchetypeID _Apply_b__2_1(Archetype _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChildrenOfIxMod.__c.NativeMethodInfoPtr__Apply_b__2_1_Internal_ArchetypeID_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
				}
			}

			// Token: 0x06004E88 RID: 20104 RVA: 0x0001B1E6 File Offset: 0x000193E6
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001352 RID: 4946
			// (get) Token: 0x06004E89 RID: 20105 RVA: 0x001A2D7C File Offset: 0x001A0F7C
			// (set) Token: 0x06004E8A RID: 20106 RVA: 0x0001B1EF File Offset: 0x000193EF
			public unsafe static ChildrenOfIxMod.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ChildrenOfIxMod.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChildrenOfIxMod.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ChildrenOfIxMod.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001353 RID: 4947
			// (get) Token: 0x06004E8B RID: 20107 RVA: 0x001A2DA4 File Offset: 0x001A0FA4
			// (set) Token: 0x06004E8C RID: 20108 RVA: 0x0001B201 File Offset: 0x00019401
			public unsafe static Func<Archetype, bool> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ChildrenOfIxMod.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Archetype, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ChildrenOfIxMod.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001354 RID: 4948
			// (get) Token: 0x06004E8D RID: 20109 RVA: 0x001A2DCC File Offset: 0x001A0FCC
			// (set) Token: 0x06004E8E RID: 20110 RVA: 0x0001B213 File Offset: 0x00019413
			public unsafe static Func<Archetype, ArchetypeID> __9__2_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ChildrenOfIxMod.__c.NativeFieldInfoPtr___9__2_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Archetype, ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ChildrenOfIxMod.__c.NativeFieldInfoPtr___9__2_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003381 RID: 13185
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003382 RID: 13186
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04003383 RID: 13187
			private static readonly IntPtr NativeFieldInfoPtr___9__2_1;

			// Token: 0x04003384 RID: 13188
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003385 RID: 13189
			private static readonly IntPtr NativeMethodInfoPtr__Apply_b__2_0_Internal_Boolean_Archetype_0;

			// Token: 0x04003386 RID: 13190
			private static readonly IntPtr NativeMethodInfoPtr__Apply_b__2_1_Internal_ArchetypeID_Archetype_0;
		}
	}
}
