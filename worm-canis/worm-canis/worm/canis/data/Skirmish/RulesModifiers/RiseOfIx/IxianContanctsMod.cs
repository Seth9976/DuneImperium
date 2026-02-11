using System;
using Canis;
using canis.archetypes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using worm.canis.match;

namespace worm.canis.data.Skirmish.RulesModifiers.RiseOfIx
{
	// Token: 0x020000AB RID: 171
	public class IxianContanctsMod : RulesModifier
	{
		// Token: 0x06000CCA RID: 3274 RVA: 0x0009416C File Offset: 0x0009236C
		// Note: this type is marked as 'beforefieldinit'.
		static IxianContanctsMod()
		{
			Il2CppClassPointerStore<IxianContanctsMod>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.Skirmish.RulesModifiers.RiseOfIx", "IxianContanctsMod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IxianContanctsMod>.NativeClassPtr);
			IxianContanctsMod.NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IxianContanctsMod>.NativeClassPtr, 100665732);
			IxianContanctsMod.NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IxianContanctsMod>.NativeClassPtr, 100665733);
			IxianContanctsMod.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IxianContanctsMod>.NativeClassPtr, 100665734);
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000CCB RID: 3275 RVA: 0x000941D8 File Offset: 0x000923D8
		public unsafe override int RuleID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IxianContanctsMod.NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x00094220 File Offset: 0x00092420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74658, XrefRangeEnd = 74711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IxianContanctsMod.NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormMatchInitData>(intPtr3) : null;
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x00094290 File Offset: 0x00092490
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IxianContanctsMod()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IxianContanctsMod>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IxianContanctsMod.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x00006F4B File Offset: 0x0000514B
		public IxianContanctsMod(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000811 RID: 2065
		private static readonly IntPtr NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0;

		// Token: 0x04000812 RID: 2066
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0;

		// Token: 0x04000813 RID: 2067
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000620 RID: 1568
		[ObfuscatedName("worm.canis.data.Skirmish.RulesModifiers.RiseOfIx.IxianContanctsMod+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06004E8F RID: 20111 RVA: 0x001A2DF4 File Offset: 0x001A0FF4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<IxianContanctsMod.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IxianContanctsMod>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IxianContanctsMod.__c>.NativeClassPtr);
				IxianContanctsMod.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IxianContanctsMod.__c>.NativeClassPtr, "<>9");
				IxianContanctsMod.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IxianContanctsMod.__c>.NativeClassPtr, "<>9__2_0");
				IxianContanctsMod.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IxianContanctsMod.__c>.NativeClassPtr, 100665736);
				IxianContanctsMod.__c.NativeMethodInfoPtr__Apply_b__2_0_Internal_Boolean_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IxianContanctsMod.__c>.NativeClassPtr, 100665737);
			}

			// Token: 0x06004E90 RID: 20112 RVA: 0x001A2E70 File Offset: 0x001A1070
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IxianContanctsMod.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IxianContanctsMod.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E91 RID: 20113 RVA: 0x001A2EAC File Offset: 0x001A10AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74651, XrefRangeEnd = 74658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Apply_b__2_0(Archetype _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IxianContanctsMod.__c.NativeMethodInfoPtr__Apply_b__2_0_Internal_Boolean_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004E92 RID: 20114 RVA: 0x0001B225 File Offset: 0x00019425
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001355 RID: 4949
			// (get) Token: 0x06004E93 RID: 20115 RVA: 0x001A2EFC File Offset: 0x001A10FC
			// (set) Token: 0x06004E94 RID: 20116 RVA: 0x0001B22E File Offset: 0x0001942E
			public unsafe static IxianContanctsMod.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IxianContanctsMod.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IxianContanctsMod.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IxianContanctsMod.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001356 RID: 4950
			// (get) Token: 0x06004E95 RID: 20117 RVA: 0x001A2F24 File Offset: 0x001A1124
			// (set) Token: 0x06004E96 RID: 20118 RVA: 0x0001B240 File Offset: 0x00019440
			public unsafe static Func<Archetype, bool> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IxianContanctsMod.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Archetype, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IxianContanctsMod.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003387 RID: 13191
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003388 RID: 13192
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04003389 RID: 13193
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400338A RID: 13194
			private static readonly IntPtr NativeMethodInfoPtr__Apply_b__2_0_Internal_Boolean_Archetype_0;
		}
	}
}
