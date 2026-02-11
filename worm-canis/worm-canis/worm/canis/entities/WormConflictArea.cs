using System;
using Canis;
using Canis.entities;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace worm.canis.entities
{
	// Token: 0x02000024 RID: 36
	public class WormConflictArea : WormPlayArea
	{
		// Token: 0x06000331 RID: 817 RVA: 0x000757E0 File Offset: 0x000739E0
		// Note: this type is marked as 'beforefieldinit'.
		static WormConflictArea()
		{
			Il2CppClassPointerStore<WormConflictArea>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.entities", "WormConflictArea");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictArea>.NativeClassPtr);
			WormConflictArea.NativeMethodInfoPtr_get_Garrisons_Public_get_IEnumerable_1_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictArea>.NativeClassPtr, 100663976);
			WormConflictArea.NativeMethodInfoPtr_get_Deployed_Public_get_IEnumerable_1_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictArea>.NativeClassPtr, 100663977);
			WormConflictArea.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictArea>.NativeClassPtr, 100663978);
			WormConflictArea.NativeMethodInfoPtr_Initialize_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictArea>.NativeClassPtr, 100663979);
			WormConflictArea.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictArea>.NativeClassPtr, 100663980);
			WormConflictArea.NativeMethodInfoPtr_GetPlayerGarrison_Public_WormPlayArea_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictArea>.NativeClassPtr, 100663981);
			WormConflictArea.NativeMethodInfoPtr_GetPlayerDeployed_Public_WormPlayArea_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictArea>.NativeClassPtr, 100663982);
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000332 RID: 818 RVA: 0x0007589C File Offset: 0x00073A9C
		public unsafe IEnumerable<WormPlayArea> Garrisons
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35244, RefRangeEnd = 35245, XrefRangeStart = 35223, XrefRangeEnd = 35244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictArea.NativeMethodInfoPtr_get_Garrisons_Public_get_IEnumerable_1_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormPlayArea>>(intPtr3) : null;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000333 RID: 819 RVA: 0x000758DC File Offset: 0x00073ADC
		public unsafe IEnumerable<WormPlayArea> Deployed
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 35266, RefRangeEnd = 35277, XrefRangeStart = 35245, XrefRangeEnd = 35266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictArea.NativeMethodInfoPtr_get_Deployed_Public_get_IEnumerable_1_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormPlayArea>>(intPtr3) : null;
			}
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0007591C File Offset: 0x00073B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35277, XrefRangeEnd = 35296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormConflictArea(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictArea>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictArea.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00075968 File Offset: 0x00073B68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35386, RefRangeEnd = 35387, XrefRangeStart = 35296, XrefRangeEnd = 35386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(WormMatch m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictArea.NativeMethodInfoPtr_Initialize_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000336 RID: 822 RVA: 0x000759AC File Offset: 0x00073BAC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 35396, RefRangeEnd = 35408, XrefRangeStart = 35387, XrefRangeEnd = 35396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormConflictArea(SerializedEntity se, Match m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictArea>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictArea.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00075A1C File Offset: 0x00073C1C
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 35444, RefRangeEnd = 35488, XrefRangeStart = 35408, XrefRangeEnd = 35444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayArea GetPlayerGarrison(WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictArea.NativeMethodInfoPtr_GetPlayerGarrison_Public_WormPlayArea_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr3) : null;
			}
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00075A6C File Offset: 0x00073C6C
		[CallerCount(62)]
		[CachedScanResults(RefRangeStart = 35524, RefRangeEnd = 35586, XrefRangeStart = 35488, XrefRangeEnd = 35524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayArea GetPlayerDeployed(WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictArea.NativeMethodInfoPtr_GetPlayerDeployed_Public_WormPlayArea_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr3) : null;
			}
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00003678 File Offset: 0x00001878
		public WormConflictArea(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeMethodInfoPtr_get_Garrisons_Public_get_IEnumerable_1_WormPlayArea_0;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeMethodInfoPtr_get_Deployed_Public_get_IEnumerable_1_WormPlayArea_0;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_WormMatch_0;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerGarrison_Public_WormPlayArea_WormPlayer_0;

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerDeployed_Public_WormPlayArea_WormPlayer_0;

		// Token: 0x02000590 RID: 1424
		[ObfuscatedName("worm.canis.entities.WormConflictArea+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06004440 RID: 17472 RVA: 0x00181AFC File Offset: 0x0017FCFC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormConflictArea.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormConflictArea>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictArea.__c>.NativeClassPtr);
				WormConflictArea.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictArea.__c>.NativeClassPtr, "<>9");
				WormConflictArea.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictArea.__c>.NativeClassPtr, "<>9__1_0");
				WormConflictArea.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictArea.__c>.NativeClassPtr, "<>9__3_0");
				WormConflictArea.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictArea.__c>.NativeClassPtr, 100663984);
				WormConflictArea.__c.NativeMethodInfoPtr__get_Garrisons_b__1_0_Internal_Boolean_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictArea.__c>.NativeClassPtr, 100663985);
				WormConflictArea.__c.NativeMethodInfoPtr__get_Deployed_b__3_0_Internal_Boolean_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictArea.__c>.NativeClassPtr, 100663986);
			}

			// Token: 0x06004441 RID: 17473 RVA: 0x00181BA0 File Offset: 0x0017FDA0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictArea.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictArea.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004442 RID: 17474 RVA: 0x00181BDC File Offset: 0x0017FDDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35213, XrefRangeEnd = 35218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_Garrisons_b__1_0(WormPlayArea _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictArea.__c.NativeMethodInfoPtr__get_Garrisons_b__1_0_Internal_Boolean_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004443 RID: 17475 RVA: 0x00181C2C File Offset: 0x0017FE2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35218, XrefRangeEnd = 35223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_Deployed_b__3_0(WormPlayArea _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictArea.__c.NativeMethodInfoPtr__get_Deployed_b__3_0_Internal_Boolean_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004444 RID: 17476 RVA: 0x00016743 File Offset: 0x00014943
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001034 RID: 4148
			// (get) Token: 0x06004445 RID: 17477 RVA: 0x00181C7C File Offset: 0x0017FE7C
			// (set) Token: 0x06004446 RID: 17478 RVA: 0x0001674C File Offset: 0x0001494C
			public unsafe static WormConflictArea.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormConflictArea.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormConflictArea.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormConflictArea.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001035 RID: 4149
			// (get) Token: 0x06004447 RID: 17479 RVA: 0x00181CA4 File Offset: 0x0017FEA4
			// (set) Token: 0x06004448 RID: 17480 RVA: 0x0001675E File Offset: 0x0001495E
			public unsafe static Func<WormPlayArea, bool> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormConflictArea.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayArea, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormConflictArea.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001036 RID: 4150
			// (get) Token: 0x06004449 RID: 17481 RVA: 0x00181CCC File Offset: 0x0017FECC
			// (set) Token: 0x0600444A RID: 17482 RVA: 0x00016770 File Offset: 0x00014970
			public unsafe static Func<WormPlayArea, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormConflictArea.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayArea, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormConflictArea.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D15 RID: 11541
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002D16 RID: 11542
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04002D17 RID: 11543
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04002D18 RID: 11544
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D19 RID: 11545
			private static readonly IntPtr NativeMethodInfoPtr__get_Garrisons_b__1_0_Internal_Boolean_WormPlayArea_0;

			// Token: 0x04002D1A RID: 11546
			private static readonly IntPtr NativeMethodInfoPtr__get_Deployed_b__3_0_Internal_Boolean_WormPlayArea_0;
		}

		// Token: 0x02000591 RID: 1425
		[ObfuscatedName("worm.canis.entities.WormConflictArea+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x0600444B RID: 17483 RVA: 0x00181CF4 File Offset: 0x0017FEF4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<WormConflictArea.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormConflictArea>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictArea.__c__DisplayClass7_0>.NativeClassPtr);
				WormConflictArea.__c__DisplayClass7_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictArea.__c__DisplayClass7_0>.NativeClassPtr, "player");
				WormConflictArea.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictArea.__c__DisplayClass7_0>.NativeClassPtr, 100663987);
				WormConflictArea.__c__DisplayClass7_0.NativeMethodInfoPtr__GetPlayerGarrison_b__0_Internal_Boolean_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictArea.__c__DisplayClass7_0>.NativeClassPtr, 100663988);
			}

			// Token: 0x0600444C RID: 17484 RVA: 0x00181D5C File Offset: 0x0017FF5C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictArea.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictArea.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600444D RID: 17485 RVA: 0x00181D98 File Offset: 0x0017FF98
			[CallerCount(0)]
			public unsafe bool _GetPlayerGarrison_b__0(WormPlayArea garrison)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(garrison);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictArea.__c__DisplayClass7_0.NativeMethodInfoPtr__GetPlayerGarrison_b__0_Internal_Boolean_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600444E RID: 17486 RVA: 0x00016782 File Offset: 0x00014982
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001037 RID: 4151
			// (get) Token: 0x0600444F RID: 17487 RVA: 0x00181DE8 File Offset: 0x0017FFE8
			// (set) Token: 0x06004450 RID: 17488 RVA: 0x0001678B File Offset: 0x0001498B
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictArea.__c__DisplayClass7_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictArea.__c__DisplayClass7_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D1B RID: 11547
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04002D1C RID: 11548
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D1D RID: 11549
			private static readonly IntPtr NativeMethodInfoPtr__GetPlayerGarrison_b__0_Internal_Boolean_WormPlayArea_0;
		}

		// Token: 0x02000592 RID: 1426
		[ObfuscatedName("worm.canis.entities.WormConflictArea+<>c__DisplayClass8_0")]
		public new sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x06004451 RID: 17489 RVA: 0x00181E18 File Offset: 0x00180018
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<WormConflictArea.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormConflictArea>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictArea.__c__DisplayClass8_0>.NativeClassPtr);
				WormConflictArea.__c__DisplayClass8_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictArea.__c__DisplayClass8_0>.NativeClassPtr, "player");
				WormConflictArea.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictArea.__c__DisplayClass8_0>.NativeClassPtr, 100663989);
				WormConflictArea.__c__DisplayClass8_0.NativeMethodInfoPtr__GetPlayerDeployed_b__0_Internal_Boolean_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictArea.__c__DisplayClass8_0>.NativeClassPtr, 100663990);
			}

			// Token: 0x06004452 RID: 17490 RVA: 0x00181E80 File Offset: 0x00180080
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictArea.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictArea.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004453 RID: 17491 RVA: 0x00181EBC File Offset: 0x001800BC
			[CallerCount(0)]
			public unsafe bool _GetPlayerDeployed_b__0(WormPlayArea deployed)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(deployed);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictArea.__c__DisplayClass8_0.NativeMethodInfoPtr__GetPlayerDeployed_b__0_Internal_Boolean_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004454 RID: 17492 RVA: 0x000167AA File Offset: 0x000149AA
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001038 RID: 4152
			// (get) Token: 0x06004455 RID: 17493 RVA: 0x00181F0C File Offset: 0x0018010C
			// (set) Token: 0x06004456 RID: 17494 RVA: 0x000167B3 File Offset: 0x000149B3
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictArea.__c__DisplayClass8_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictArea.__c__DisplayClass8_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D1E RID: 11550
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04002D1F RID: 11551
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D20 RID: 11552
			private static readonly IntPtr NativeMethodInfoPtr__GetPlayerDeployed_b__0_Internal_Boolean_WormPlayArea_0;
		}
	}
}
