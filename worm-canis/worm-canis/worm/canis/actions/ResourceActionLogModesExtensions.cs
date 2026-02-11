using System;
using Canis.actions;
using Canis.attributes;
using Canis.gameLogs;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace worm.canis.actions
{
	// Token: 0x0200025D RID: 605
	public static class ResourceActionLogModesExtensions : Object
	{
		// Token: 0x060019E9 RID: 6633 RVA: 0x000BD9EC File Offset: 0x000BBBEC
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceActionLogModesExtensions()
		{
			Il2CppClassPointerStore<ResourceActionLogModesExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "ResourceActionLogModesExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceActionLogModesExtensions>.NativeClassPtr);
			ResourceActionLogModesExtensions.NativeMethodInfoPtr_GetResourceSortOrder_Private_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceActionLogModesExtensions>.NativeClassPtr, 100668066);
			ResourceActionLogModesExtensions.NativeMethodInfoPtr_Log_Public_Static_IEnumerable_1_Action_ActionLogModes_GameLogBuilder_WormMatch_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceActionLogModesExtensions>.NativeClassPtr, 100668067);
		}

		// Token: 0x060019EA RID: 6634 RVA: 0x000BDA44 File Offset: 0x000BBC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138910, XrefRangeEnd = 138940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetResourceSortOrder(string resourceStr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(resourceStr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceActionLogModesExtensions.NativeMethodInfoPtr_GetResourceSortOrder_Private_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019EB RID: 6635 RVA: 0x000BDA88 File Offset: 0x000BBC88
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 138947, RefRangeEnd = 138971, XrefRangeStart = 138940, XrefRangeEnd = 138947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Canis.actions.Action> Log(this ActionLogModes behavior, GameLogBuilder logBuilder, WormMatch wormMatch, int gameLogID = -1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref behavior;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(logBuilder);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gameLogID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceActionLogModesExtensions.NativeMethodInfoPtr_Log_Public_Static_IEnumerable_1_Action_ActionLogModes_GameLogBuilder_WormMatch_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060019EC RID: 6636 RVA: 0x0000B288 File Offset: 0x00009488
		public ResourceActionLogModesExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001002 RID: 4098
		private static readonly IntPtr NativeMethodInfoPtr_GetResourceSortOrder_Private_Static_Int32_String_0;

		// Token: 0x04001003 RID: 4099
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_IEnumerable_1_Action_ActionLogModes_GameLogBuilder_WormMatch_Int32_0;

		// Token: 0x02000694 RID: 1684
		[ObfuscatedName("worm.canis.actions.ResourceActionLogModesExtensions+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060057D5 RID: 22485 RVA: 0x001C054C File Offset: 0x001BE74C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ResourceActionLogModesExtensions.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResourceActionLogModesExtensions>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceActionLogModesExtensions.__c>.NativeClassPtr);
				ResourceActionLogModesExtensions.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceActionLogModesExtensions.__c>.NativeClassPtr, "<>9");
				ResourceActionLogModesExtensions.__c.NativeFieldInfoPtr___9__1_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceActionLogModesExtensions.__c>.NativeClassPtr, "<>9__1_1");
				ResourceActionLogModesExtensions.__c.NativeFieldInfoPtr___9__1_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceActionLogModesExtensions.__c>.NativeClassPtr, "<>9__1_2");
				ResourceActionLogModesExtensions.__c.NativeFieldInfoPtr___9__1_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceActionLogModesExtensions.__c>.NativeClassPtr, "<>9__1_4");
				ResourceActionLogModesExtensions.__c.NativeFieldInfoPtr___9__1_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceActionLogModesExtensions.__c>.NativeClassPtr, "<>9__1_3");
				ResourceActionLogModesExtensions.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceActionLogModesExtensions.__c>.NativeClassPtr, 100668069);
				ResourceActionLogModesExtensions.__c.NativeMethodInfoPtr__Log_b__1_1_Internal_Boolean_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceActionLogModesExtensions.__c>.NativeClassPtr, 100668070);
				ResourceActionLogModesExtensions.__c.NativeMethodInfoPtr__Log_b__1_2_Internal_Boolean_GameLogListItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceActionLogModesExtensions.__c>.NativeClassPtr, 100668071);
				ResourceActionLogModesExtensions.__c.NativeMethodInfoPtr__Log_b__1_4_Internal_Boolean_GameLogListItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceActionLogModesExtensions.__c>.NativeClassPtr, 100668072);
				ResourceActionLogModesExtensions.__c.NativeMethodInfoPtr__Log_b__1_3_Internal_Boolean_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceActionLogModesExtensions.__c>.NativeClassPtr, 100668073);
			}

			// Token: 0x060057D6 RID: 22486 RVA: 0x001C0640 File Offset: 0x001BE840
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceActionLogModesExtensions.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceActionLogModesExtensions.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060057D7 RID: 22487 RVA: 0x001C067C File Offset: 0x001BE87C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138675, XrefRangeEnd = 138682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Log_b__1_1(SerializedGameLog _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceActionLogModesExtensions.__c.NativeMethodInfoPtr__Log_b__1_1_Internal_Boolean_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060057D8 RID: 22488 RVA: 0x001C06CC File Offset: 0x001BE8CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138682, XrefRangeEnd = 138693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Log_b__1_2(GameLogListItem _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceActionLogModesExtensions.__c.NativeMethodInfoPtr__Log_b__1_2_Internal_Boolean_GameLogListItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060057D9 RID: 22489 RVA: 0x001C071C File Offset: 0x001BE91C
			[CallerCount(0)]
			public unsafe bool _Log_b__1_4(GameLogListItem _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceActionLogModesExtensions.__c.NativeMethodInfoPtr__Log_b__1_4_Internal_Boolean_GameLogListItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060057DA RID: 22490 RVA: 0x001C076C File Offset: 0x001BE96C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138693, XrefRangeEnd = 138701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Log_b__1_3(IAttribute _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceActionLogModesExtensions.__c.NativeMethodInfoPtr__Log_b__1_3_Internal_Boolean_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060057DB RID: 22491 RVA: 0x0001FD97 File Offset: 0x0001DF97
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001662 RID: 5730
			// (get) Token: 0x060057DC RID: 22492 RVA: 0x001C07BC File Offset: 0x001BE9BC
			// (set) Token: 0x060057DD RID: 22493 RVA: 0x0001FDA0 File Offset: 0x0001DFA0
			public unsafe static ResourceActionLogModesExtensions.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResourceActionLogModesExtensions.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceActionLogModesExtensions.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResourceActionLogModesExtensions.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001663 RID: 5731
			// (get) Token: 0x060057DE RID: 22494 RVA: 0x001C07E4 File Offset: 0x001BE9E4
			// (set) Token: 0x060057DF RID: 22495 RVA: 0x0001FDB2 File Offset: 0x0001DFB2
			public unsafe static Func<SerializedGameLog, bool> __9__1_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResourceActionLogModesExtensions.__c.NativeFieldInfoPtr___9__1_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SerializedGameLog, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResourceActionLogModesExtensions.__c.NativeFieldInfoPtr___9__1_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001664 RID: 5732
			// (get) Token: 0x060057E0 RID: 22496 RVA: 0x001C080C File Offset: 0x001BEA0C
			// (set) Token: 0x060057E1 RID: 22497 RVA: 0x0001FDC4 File Offset: 0x0001DFC4
			public unsafe static Func<GameLogListItem, bool> __9__1_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResourceActionLogModesExtensions.__c.NativeFieldInfoPtr___9__1_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GameLogListItem, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResourceActionLogModesExtensions.__c.NativeFieldInfoPtr___9__1_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001665 RID: 5733
			// (get) Token: 0x060057E2 RID: 22498 RVA: 0x001C0834 File Offset: 0x001BEA34
			// (set) Token: 0x060057E3 RID: 22499 RVA: 0x0001FDD6 File Offset: 0x0001DFD6
			public unsafe static Func<GameLogListItem, bool> __9__1_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResourceActionLogModesExtensions.__c.NativeFieldInfoPtr___9__1_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GameLogListItem, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResourceActionLogModesExtensions.__c.NativeFieldInfoPtr___9__1_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001666 RID: 5734
			// (get) Token: 0x060057E4 RID: 22500 RVA: 0x001C085C File Offset: 0x001BEA5C
			// (set) Token: 0x060057E5 RID: 22501 RVA: 0x0001FDE8 File Offset: 0x0001DFE8
			public unsafe static Func<IAttribute, bool> __9__1_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResourceActionLogModesExtensions.__c.NativeFieldInfoPtr___9__1_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IAttribute, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResourceActionLogModesExtensions.__c.NativeFieldInfoPtr___9__1_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400394A RID: 14666
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400394B RID: 14667
			private static readonly IntPtr NativeFieldInfoPtr___9__1_1;

			// Token: 0x0400394C RID: 14668
			private static readonly IntPtr NativeFieldInfoPtr___9__1_2;

			// Token: 0x0400394D RID: 14669
			private static readonly IntPtr NativeFieldInfoPtr___9__1_4;

			// Token: 0x0400394E RID: 14670
			private static readonly IntPtr NativeFieldInfoPtr___9__1_3;

			// Token: 0x0400394F RID: 14671
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003950 RID: 14672
			private static readonly IntPtr NativeMethodInfoPtr__Log_b__1_1_Internal_Boolean_SerializedGameLog_0;

			// Token: 0x04003951 RID: 14673
			private static readonly IntPtr NativeMethodInfoPtr__Log_b__1_2_Internal_Boolean_GameLogListItem_0;

			// Token: 0x04003952 RID: 14674
			private static readonly IntPtr NativeMethodInfoPtr__Log_b__1_4_Internal_Boolean_GameLogListItem_0;

			// Token: 0x04003953 RID: 14675
			private static readonly IntPtr NativeMethodInfoPtr__Log_b__1_3_Internal_Boolean_IAttribute_0;
		}

		// Token: 0x02000695 RID: 1685
		[ObfuscatedName("worm.canis.actions.ResourceActionLogModesExtensions+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x060057E6 RID: 22502 RVA: 0x001C0884 File Offset: 0x001BEA84
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<ResourceActionLogModesExtensions.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResourceActionLogModesExtensions>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceActionLogModesExtensions.__c__DisplayClass1_0>.NativeClassPtr);
				ResourceActionLogModesExtensions.__c__DisplayClass1_0.NativeFieldInfoPtr_logBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceActionLogModesExtensions.__c__DisplayClass1_0>.NativeClassPtr, "logBuilder");
				ResourceActionLogModesExtensions.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceActionLogModesExtensions.__c__DisplayClass1_0>.NativeClassPtr, 100668074);
				ResourceActionLogModesExtensions.__c__DisplayClass1_0.NativeMethodInfoPtr__Log_b__0_Internal_SerializedGameLog_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceActionLogModesExtensions.__c__DisplayClass1_0>.NativeClassPtr, 100668075);
			}

			// Token: 0x060057E7 RID: 22503 RVA: 0x001C08EC File Offset: 0x001BEAEC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceActionLogModesExtensions.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceActionLogModesExtensions.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060057E8 RID: 22504 RVA: 0x001C0928 File Offset: 0x001BEB28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138701, XrefRangeEnd = 138853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SerializedGameLog _Log_b__0(SerializedGameLog existingLog)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(existingLog);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceActionLogModesExtensions.__c__DisplayClass1_0.NativeMethodInfoPtr__Log_b__0_Internal_SerializedGameLog_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedGameLog>(intPtr3) : null;
				}
			}

			// Token: 0x060057E9 RID: 22505 RVA: 0x0001FDFA File Offset: 0x0001DFFA
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001667 RID: 5735
			// (get) Token: 0x060057EA RID: 22506 RVA: 0x001C0978 File Offset: 0x001BEB78
			// (set) Token: 0x060057EB RID: 22507 RVA: 0x0001FE03 File Offset: 0x0001E003
			public unsafe GameLogBuilder logBuilder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActionLogModesExtensions.__c__DisplayClass1_0.NativeFieldInfoPtr_logBuilder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActionLogModesExtensions.__c__DisplayClass1_0.NativeFieldInfoPtr_logBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003954 RID: 14676
			private static readonly IntPtr NativeFieldInfoPtr_logBuilder;

			// Token: 0x04003955 RID: 14677
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003956 RID: 14678
			private static readonly IntPtr NativeMethodInfoPtr__Log_b__0_Internal_SerializedGameLog_SerializedGameLog_0;
		}

		// Token: 0x02000696 RID: 1686
		[ObfuscatedName("worm.canis.actions.ResourceActionLogModesExtensions+<Log>d__1")]
		public sealed class _Log_d__1 : Object
		{
			// Token: 0x060057EC RID: 22508 RVA: 0x001C09A8 File Offset: 0x001BEBA8
			// Note: this type is marked as 'beforefieldinit'.
			static _Log_d__1()
			{
				Il2CppClassPointerStore<ResourceActionLogModesExtensions._Log_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResourceActionLogModesExtensions>.NativeClassPtr, "<Log>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceActionLogModesExtensions._Log_d__1>.NativeClassPtr);
				ResourceActionLogModesExtensions._Log_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceActionLogModesExtensions._Log_d__1>.NativeClassPtr, "<>1__state");
				ResourceActionLogModesExtensions._Log_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceActionLogModesExtensions._Log_d__1>.NativeClassPtr, "<>2__current");
				ResourceActionLogModesExtensions._Log_d__1.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceActionLogModesExtensions._Log_d__1>.NativeClassPtr, "<>l__initialThreadId");
				ResourceActionLogModesExtensions._Log_d__1.NativeFieldInfoPtr_logBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceActionLogModesExtensions._Log_d__1>.NativeClassPtr, "logBuilder");
				ResourceActionLogModesExtensions._Log_d__1.NativeFieldInfoPtr___3__logBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceActionLogModesExtensions._Log_d__1>.NativeClassPtr, "<>3__logBuilder");
				ResourceActionLogModesExtensions._Log_d__1.NativeFieldInfoPtr_behavior = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceActionLogModesExtensions._Log_d__1>.NativeClassPtr, "behavior");
				ResourceActionLogModesExtensions._Log_d__1.NativeFieldInfoPtr___3__behavior = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceActionLogModesExtensions._Log_d__1>.NativeClassPtr, "<>3__behavior");
				ResourceActionLogModesExtensions._Log_d__1.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceActionLogModesExtensions._Log_d__1>.NativeClassPtr, "wormMatch");
				ResourceActionLogModesExtensions._Log_d__1.NativeFieldInfoPtr___3__wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceActionLogModesExtensions._Log_d__1>.NativeClassPtr, "<>3__wormMatch");
				ResourceActionLogModesExtensions._Log_d__1.NativeFieldInfoPtr_gameLogID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceActionLogModesExtensions._Log_d__1>.NativeClassPtr, "gameLogID");
				ResourceActionLogModesExtensions._Log_d__1.NativeFieldInfoPtr___3__gameLogID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceActionLogModesExtensions._Log_d__1>.NativeClassPtr, "<>3__gameLogID");
				ResourceActionLogModesExtensions._Log_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceActionLogModesExtensions._Log_d__1>.NativeClassPtr, 100668076);
				ResourceActionLogModesExtensions._Log_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceActionLogModesExtensions._Log_d__1>.NativeClassPtr, 100668077);
				ResourceActionLogModesExtensions._Log_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceActionLogModesExtensions._Log_d__1>.NativeClassPtr, 100668078);
				ResourceActionLogModesExtensions._Log_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceActionLogModesExtensions._Log_d__1>.NativeClassPtr, 100668079);
				ResourceActionLogModesExtensions._Log_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceActionLogModesExtensions._Log_d__1>.NativeClassPtr, 100668080);
				ResourceActionLogModesExtensions._Log_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceActionLogModesExtensions._Log_d__1>.NativeClassPtr, 100668081);
				ResourceActionLogModesExtensions._Log_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceActionLogModesExtensions._Log_d__1>.NativeClassPtr, 100668082);
				ResourceActionLogModesExtensions._Log_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceActionLogModesExtensions._Log_d__1>.NativeClassPtr, 100668083);
			}

			// Token: 0x060057ED RID: 22509 RVA: 0x001C0B50 File Offset: 0x001BED50
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Log_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceActionLogModesExtensions._Log_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceActionLogModesExtensions._Log_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060057EE RID: 22510 RVA: 0x001C0B98 File Offset: 0x001BED98
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceActionLogModesExtensions._Log_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060057EF RID: 22511 RVA: 0x001C0BCC File Offset: 0x001BEDCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138853, XrefRangeEnd = 138896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceActionLogModesExtensions._Log_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001673 RID: 5747
			// (get) Token: 0x060057F0 RID: 22512 RVA: 0x001C0C08 File Offset: 0x001BEE08
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceActionLogModesExtensions._Log_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060057F1 RID: 22513 RVA: 0x001C0C48 File Offset: 0x001BEE48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138896, XrefRangeEnd = 138901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceActionLogModesExtensions._Log_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001674 RID: 5748
			// (get) Token: 0x060057F2 RID: 22514 RVA: 0x001C0C7C File Offset: 0x001BEE7C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceActionLogModesExtensions._Log_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060057F3 RID: 22515 RVA: 0x001C0CBC File Offset: 0x001BEEBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138901, XrefRangeEnd = 138910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceActionLogModesExtensions._Log_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060057F4 RID: 22516 RVA: 0x001C0CFC File Offset: 0x001BEEFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceActionLogModesExtensions._Log_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060057F5 RID: 22517 RVA: 0x0001FE22 File Offset: 0x0001E022
			public _Log_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001668 RID: 5736
			// (get) Token: 0x060057F6 RID: 22518 RVA: 0x001C0D3C File Offset: 0x001BEF3C
			// (set) Token: 0x060057F7 RID: 22519 RVA: 0x0001FE2B File Offset: 0x0001E02B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActionLogModesExtensions._Log_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActionLogModesExtensions._Log_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001669 RID: 5737
			// (get) Token: 0x060057F8 RID: 22520 RVA: 0x001C0D64 File Offset: 0x001BEF64
			// (set) Token: 0x060057F9 RID: 22521 RVA: 0x0001FE46 File Offset: 0x0001E046
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActionLogModesExtensions._Log_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActionLogModesExtensions._Log_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700166A RID: 5738
			// (get) Token: 0x060057FA RID: 22522 RVA: 0x001C0D94 File Offset: 0x001BEF94
			// (set) Token: 0x060057FB RID: 22523 RVA: 0x0001FE65 File Offset: 0x0001E065
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActionLogModesExtensions._Log_d__1.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActionLogModesExtensions._Log_d__1.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700166B RID: 5739
			// (get) Token: 0x060057FC RID: 22524 RVA: 0x001C0DBC File Offset: 0x001BEFBC
			// (set) Token: 0x060057FD RID: 22525 RVA: 0x0001FE80 File Offset: 0x0001E080
			public unsafe GameLogBuilder logBuilder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActionLogModesExtensions._Log_d__1.NativeFieldInfoPtr_logBuilder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActionLogModesExtensions._Log_d__1.NativeFieldInfoPtr_logBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700166C RID: 5740
			// (get) Token: 0x060057FE RID: 22526 RVA: 0x001C0DEC File Offset: 0x001BEFEC
			// (set) Token: 0x060057FF RID: 22527 RVA: 0x0001FE9F File Offset: 0x0001E09F
			public unsafe GameLogBuilder __3__logBuilder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActionLogModesExtensions._Log_d__1.NativeFieldInfoPtr___3__logBuilder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActionLogModesExtensions._Log_d__1.NativeFieldInfoPtr___3__logBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700166D RID: 5741
			// (get) Token: 0x06005800 RID: 22528 RVA: 0x001C0E1C File Offset: 0x001BF01C
			// (set) Token: 0x06005801 RID: 22529 RVA: 0x0001FEBE File Offset: 0x0001E0BE
			public unsafe ActionLogModes behavior
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActionLogModesExtensions._Log_d__1.NativeFieldInfoPtr_behavior);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActionLogModesExtensions._Log_d__1.NativeFieldInfoPtr_behavior)) = value;
				}
			}

			// Token: 0x1700166E RID: 5742
			// (get) Token: 0x06005802 RID: 22530 RVA: 0x001C0E44 File Offset: 0x001BF044
			// (set) Token: 0x06005803 RID: 22531 RVA: 0x0001FED9 File Offset: 0x0001E0D9
			public unsafe ActionLogModes __3__behavior
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActionLogModesExtensions._Log_d__1.NativeFieldInfoPtr___3__behavior);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActionLogModesExtensions._Log_d__1.NativeFieldInfoPtr___3__behavior)) = value;
				}
			}

			// Token: 0x1700166F RID: 5743
			// (get) Token: 0x06005804 RID: 22532 RVA: 0x001C0E6C File Offset: 0x001BF06C
			// (set) Token: 0x06005805 RID: 22533 RVA: 0x0001FEF4 File Offset: 0x0001E0F4
			public unsafe WormMatch wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActionLogModesExtensions._Log_d__1.NativeFieldInfoPtr_wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActionLogModesExtensions._Log_d__1.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001670 RID: 5744
			// (get) Token: 0x06005806 RID: 22534 RVA: 0x001C0E9C File Offset: 0x001BF09C
			// (set) Token: 0x06005807 RID: 22535 RVA: 0x0001FF13 File Offset: 0x0001E113
			public unsafe WormMatch __3__wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActionLogModesExtensions._Log_d__1.NativeFieldInfoPtr___3__wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActionLogModesExtensions._Log_d__1.NativeFieldInfoPtr___3__wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001671 RID: 5745
			// (get) Token: 0x06005808 RID: 22536 RVA: 0x001C0ECC File Offset: 0x001BF0CC
			// (set) Token: 0x06005809 RID: 22537 RVA: 0x0001FF32 File Offset: 0x0001E132
			public unsafe int gameLogID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActionLogModesExtensions._Log_d__1.NativeFieldInfoPtr_gameLogID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActionLogModesExtensions._Log_d__1.NativeFieldInfoPtr_gameLogID)) = value;
				}
			}

			// Token: 0x17001672 RID: 5746
			// (get) Token: 0x0600580A RID: 22538 RVA: 0x001C0EF4 File Offset: 0x001BF0F4
			// (set) Token: 0x0600580B RID: 22539 RVA: 0x0001FF4D File Offset: 0x0001E14D
			public unsafe int __3__gameLogID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActionLogModesExtensions._Log_d__1.NativeFieldInfoPtr___3__gameLogID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceActionLogModesExtensions._Log_d__1.NativeFieldInfoPtr___3__gameLogID)) = value;
				}
			}

			// Token: 0x04003957 RID: 14679
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003958 RID: 14680
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003959 RID: 14681
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400395A RID: 14682
			private static readonly IntPtr NativeFieldInfoPtr_logBuilder;

			// Token: 0x0400395B RID: 14683
			private static readonly IntPtr NativeFieldInfoPtr___3__logBuilder;

			// Token: 0x0400395C RID: 14684
			private static readonly IntPtr NativeFieldInfoPtr_behavior;

			// Token: 0x0400395D RID: 14685
			private static readonly IntPtr NativeFieldInfoPtr___3__behavior;

			// Token: 0x0400395E RID: 14686
			private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

			// Token: 0x0400395F RID: 14687
			private static readonly IntPtr NativeFieldInfoPtr___3__wormMatch;

			// Token: 0x04003960 RID: 14688
			private static readonly IntPtr NativeFieldInfoPtr_gameLogID;

			// Token: 0x04003961 RID: 14689
			private static readonly IntPtr NativeFieldInfoPtr___3__gameLogID;

			// Token: 0x04003962 RID: 14690
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003963 RID: 14691
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003964 RID: 14692
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003965 RID: 14693
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003966 RID: 14694
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003967 RID: 14695
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003968 RID: 14696
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003969 RID: 14697
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
