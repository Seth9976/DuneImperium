using System;
using boardgames.match.commands;
using boardgames.notifications;
using Canis.messages;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.menus.commands
{
	// Token: 0x02000237 RID: 567
	public class RunTurnReadyNotificationFlow : Command
	{
		// Token: 0x060019B1 RID: 6577 RVA: 0x000711E8 File Offset: 0x0006F3E8
		// Note: this type is marked as 'beforefieldinit'.
		static RunTurnReadyNotificationFlow()
		{
			Il2CppClassPointerStore<RunTurnReadyNotificationFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "RunTurnReadyNotificationFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTurnReadyNotificationFlow>.NativeClassPtr);
			RunTurnReadyNotificationFlow.NativeFieldInfoPtr_turnReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTurnReadyNotificationFlow>.NativeClassPtr, "turnReady");
			RunTurnReadyNotificationFlow.NativeFieldInfoPtr__YourTurnNotificationBody_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTurnReadyNotificationFlow>.NativeClassPtr, "<YourTurnNotificationBody>k__BackingField");
			RunTurnReadyNotificationFlow.NativeFieldInfoPtr__LiveGameReady_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTurnReadyNotificationFlow>.NativeClassPtr, "<LiveGameReady>k__BackingField");
			RunTurnReadyNotificationFlow.NativeFieldInfoPtr__YourTurnNotificationHeader_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTurnReadyNotificationFlow>.NativeClassPtr, "<YourTurnNotificationHeader>k__BackingField");
			RunTurnReadyNotificationFlow.NativeMethodInfoPtr_get_YourTurnNotificationBody_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTurnReadyNotificationFlow>.NativeClassPtr, 100667340);
			RunTurnReadyNotificationFlow.NativeMethodInfoPtr_set_YourTurnNotificationBody_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTurnReadyNotificationFlow>.NativeClassPtr, 100667341);
			RunTurnReadyNotificationFlow.NativeMethodInfoPtr_get_LiveGameReady_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTurnReadyNotificationFlow>.NativeClassPtr, 100667342);
			RunTurnReadyNotificationFlow.NativeMethodInfoPtr_set_LiveGameReady_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTurnReadyNotificationFlow>.NativeClassPtr, 100667343);
			RunTurnReadyNotificationFlow.NativeMethodInfoPtr_get_YourTurnNotificationHeader_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTurnReadyNotificationFlow>.NativeClassPtr, 100667344);
			RunTurnReadyNotificationFlow.NativeMethodInfoPtr_set_YourTurnNotificationHeader_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTurnReadyNotificationFlow>.NativeClassPtr, 100667345);
			RunTurnReadyNotificationFlow.NativeMethodInfoPtr__ctor_Public_Void_PBMTurnReady_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTurnReadyNotificationFlow>.NativeClassPtr, 100667346);
			RunTurnReadyNotificationFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTurnReadyNotificationFlow>.NativeClassPtr, 100667347);
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x060019B2 RID: 6578 RVA: 0x00071308 File Offset: 0x0006F508
		// (set) Token: 0x060019B3 RID: 6579 RVA: 0x00071340 File Offset: 0x0006F540
		public unsafe string YourTurnNotificationBody
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTurnReadyNotificationFlow.NativeMethodInfoPtr_get_YourTurnNotificationBody_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTurnReadyNotificationFlow.NativeMethodInfoPtr_set_YourTurnNotificationBody_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x060019B4 RID: 6580 RVA: 0x00071384 File Offset: 0x0006F584
		// (set) Token: 0x060019B5 RID: 6581 RVA: 0x000713BC File Offset: 0x0006F5BC
		public unsafe string LiveGameReady
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTurnReadyNotificationFlow.NativeMethodInfoPtr_get_LiveGameReady_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTurnReadyNotificationFlow.NativeMethodInfoPtr_set_LiveGameReady_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x060019B6 RID: 6582 RVA: 0x00071400 File Offset: 0x0006F600
		// (set) Token: 0x060019B7 RID: 6583 RVA: 0x00071438 File Offset: 0x0006F638
		public unsafe string YourTurnNotificationHeader
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTurnReadyNotificationFlow.NativeMethodInfoPtr_get_YourTurnNotificationHeader_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTurnReadyNotificationFlow.NativeMethodInfoPtr_set_YourTurnNotificationHeader_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x0007147C File Offset: 0x0006F67C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 530632, RefRangeEnd = 530633, XrefRangeStart = 530618, XrefRangeEnd = 530632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunTurnReadyNotificationFlow(PBMTurnReady turnReady)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTurnReadyNotificationFlow>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(turnReady);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTurnReadyNotificationFlow.NativeMethodInfoPtr__ctor_Public_Void_PBMTurnReady_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019B9 RID: 6585 RVA: 0x000714C8 File Offset: 0x0006F6C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 530633, XrefRangeEnd = 530638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunTurnReadyNotificationFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060019BA RID: 6586 RVA: 0x0000E15D File Offset: 0x0000C35D
		public RunTurnReadyNotificationFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x060019BB RID: 6587 RVA: 0x00071514 File Offset: 0x0006F714
		// (set) Token: 0x060019BC RID: 6588 RVA: 0x0000E166 File Offset: 0x0000C366
		public unsafe PBMTurnReady turnReady
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTurnReadyNotificationFlow.NativeFieldInfoPtr_turnReady);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PBMTurnReady>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTurnReadyNotificationFlow.NativeFieldInfoPtr_turnReady), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x060019BD RID: 6589 RVA: 0x00071544 File Offset: 0x0006F744
		// (set) Token: 0x060019BE RID: 6590 RVA: 0x0000E185 File Offset: 0x0000C385
		public unsafe string _YourTurnNotificationBody_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTurnReadyNotificationFlow.NativeFieldInfoPtr__YourTurnNotificationBody_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTurnReadyNotificationFlow.NativeFieldInfoPtr__YourTurnNotificationBody_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x060019BF RID: 6591 RVA: 0x0007156C File Offset: 0x0006F76C
		// (set) Token: 0x060019C0 RID: 6592 RVA: 0x0000E1A4 File Offset: 0x0000C3A4
		public unsafe string _LiveGameReady_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTurnReadyNotificationFlow.NativeFieldInfoPtr__LiveGameReady_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTurnReadyNotificationFlow.NativeFieldInfoPtr__LiveGameReady_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x060019C1 RID: 6593 RVA: 0x00071594 File Offset: 0x0006F794
		// (set) Token: 0x060019C2 RID: 6594 RVA: 0x0000E1C3 File Offset: 0x0000C3C3
		public unsafe string _YourTurnNotificationHeader_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTurnReadyNotificationFlow.NativeFieldInfoPtr__YourTurnNotificationHeader_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTurnReadyNotificationFlow.NativeFieldInfoPtr__YourTurnNotificationHeader_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001007 RID: 4103
		private static readonly IntPtr NativeFieldInfoPtr_turnReady;

		// Token: 0x04001008 RID: 4104
		private static readonly IntPtr NativeFieldInfoPtr__YourTurnNotificationBody_k__BackingField;

		// Token: 0x04001009 RID: 4105
		private static readonly IntPtr NativeFieldInfoPtr__LiveGameReady_k__BackingField;

		// Token: 0x0400100A RID: 4106
		private static readonly IntPtr NativeFieldInfoPtr__YourTurnNotificationHeader_k__BackingField;

		// Token: 0x0400100B RID: 4107
		private static readonly IntPtr NativeMethodInfoPtr_get_YourTurnNotificationBody_Public_get_String_0;

		// Token: 0x0400100C RID: 4108
		private static readonly IntPtr NativeMethodInfoPtr_set_YourTurnNotificationBody_Public_set_Void_String_0;

		// Token: 0x0400100D RID: 4109
		private static readonly IntPtr NativeMethodInfoPtr_get_LiveGameReady_Public_get_String_0;

		// Token: 0x0400100E RID: 4110
		private static readonly IntPtr NativeMethodInfoPtr_set_LiveGameReady_Public_set_Void_String_0;

		// Token: 0x0400100F RID: 4111
		private static readonly IntPtr NativeMethodInfoPtr_get_YourTurnNotificationHeader_Public_get_String_0;

		// Token: 0x04001010 RID: 4112
		private static readonly IntPtr NativeMethodInfoPtr_set_YourTurnNotificationHeader_Public_set_Void_String_0;

		// Token: 0x04001011 RID: 4113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PBMTurnReady_0;

		// Token: 0x04001012 RID: 4114
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x02000422 RID: 1058
		[ObfuscatedName("boardgames.menus.commands.RunTurnReadyNotificationFlow+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003209 RID: 12809 RVA: 0x000BDC9C File Offset: 0x000BBE9C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RunTurnReadyNotificationFlow.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunTurnReadyNotificationFlow>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTurnReadyNotificationFlow.__c>.NativeClassPtr);
				RunTurnReadyNotificationFlow.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTurnReadyNotificationFlow.__c>.NativeClassPtr, "<>9");
				RunTurnReadyNotificationFlow.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTurnReadyNotificationFlow.__c>.NativeClassPtr, "<>9__14_0");
				RunTurnReadyNotificationFlow.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTurnReadyNotificationFlow.__c>.NativeClassPtr, 100667349);
				RunTurnReadyNotificationFlow.__c.NativeMethodInfoPtr__execute_b__14_0_Internal_String_AccountIDUsernameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTurnReadyNotificationFlow.__c>.NativeClassPtr, 100667350);
			}

			// Token: 0x0600320A RID: 12810 RVA: 0x000BDD18 File Offset: 0x000BBF18
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTurnReadyNotificationFlow.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTurnReadyNotificationFlow.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600320B RID: 12811 RVA: 0x000BDD54 File Offset: 0x000BBF54
			[CallerCount(0)]
			public unsafe string _execute_b__14_0(AccountIDUsernameMetadata slot)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTurnReadyNotificationFlow.__c.NativeMethodInfoPtr__execute_b__14_0_Internal_String_AccountIDUsernameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600320C RID: 12812 RVA: 0x00019DC5 File Offset: 0x00017FC5
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E8C RID: 3724
			// (get) Token: 0x0600320D RID: 12813 RVA: 0x000BDD9C File Offset: 0x000BBF9C
			// (set) Token: 0x0600320E RID: 12814 RVA: 0x00019DCE File Offset: 0x00017FCE
			public unsafe static RunTurnReadyNotificationFlow.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTurnReadyNotificationFlow.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunTurnReadyNotificationFlow.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTurnReadyNotificationFlow.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E8D RID: 3725
			// (get) Token: 0x0600320F RID: 12815 RVA: 0x000BDDC4 File Offset: 0x000BBFC4
			// (set) Token: 0x06003210 RID: 12816 RVA: 0x00019DE0 File Offset: 0x00017FE0
			public unsafe static Func<AccountIDUsernameMetadata, string> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTurnReadyNotificationFlow.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AccountIDUsernameMetadata, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTurnReadyNotificationFlow.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001EE7 RID: 7911
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001EE8 RID: 7912
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x04001EE9 RID: 7913
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001EEA RID: 7914
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__14_0_Internal_String_AccountIDUsernameMetadata_0;
		}

		// Token: 0x02000423 RID: 1059
		[ObfuscatedName("boardgames.menus.commands.RunTurnReadyNotificationFlow+<execute>d__14")]
		public sealed class _execute_d__14 : Object
		{
			// Token: 0x06003211 RID: 12817 RVA: 0x000BDDEC File Offset: 0x000BBFEC
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__14()
			{
				Il2CppClassPointerStore<RunTurnReadyNotificationFlow._execute_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunTurnReadyNotificationFlow>.NativeClassPtr, "<execute>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTurnReadyNotificationFlow._execute_d__14>.NativeClassPtr);
				RunTurnReadyNotificationFlow._execute_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTurnReadyNotificationFlow._execute_d__14>.NativeClassPtr, "<>1__state");
				RunTurnReadyNotificationFlow._execute_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTurnReadyNotificationFlow._execute_d__14>.NativeClassPtr, "<>2__current");
				RunTurnReadyNotificationFlow._execute_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTurnReadyNotificationFlow._execute_d__14>.NativeClassPtr, "<>4__this");
				RunTurnReadyNotificationFlow._execute_d__14.NativeFieldInfoPtr__checkActive_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTurnReadyNotificationFlow._execute_d__14>.NativeClassPtr, "<checkActive>5__2");
				RunTurnReadyNotificationFlow._execute_d__14.NativeFieldInfoPtr__notifications_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTurnReadyNotificationFlow._execute_d__14>.NativeClassPtr, "<notifications>5__3");
				RunTurnReadyNotificationFlow._execute_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTurnReadyNotificationFlow._execute_d__14>.NativeClassPtr, 100667351);
				RunTurnReadyNotificationFlow._execute_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTurnReadyNotificationFlow._execute_d__14>.NativeClassPtr, 100667352);
				RunTurnReadyNotificationFlow._execute_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTurnReadyNotificationFlow._execute_d__14>.NativeClassPtr, 100667353);
				RunTurnReadyNotificationFlow._execute_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTurnReadyNotificationFlow._execute_d__14>.NativeClassPtr, 100667354);
				RunTurnReadyNotificationFlow._execute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTurnReadyNotificationFlow._execute_d__14>.NativeClassPtr, 100667355);
				RunTurnReadyNotificationFlow._execute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTurnReadyNotificationFlow._execute_d__14>.NativeClassPtr, 100667356);
			}

			// Token: 0x06003212 RID: 12818 RVA: 0x000BDEF4 File Offset: 0x000BC0F4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTurnReadyNotificationFlow._execute_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTurnReadyNotificationFlow._execute_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003213 RID: 12819 RVA: 0x000BDF3C File Offset: 0x000BC13C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTurnReadyNotificationFlow._execute_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003214 RID: 12820 RVA: 0x000BDF70 File Offset: 0x000BC170
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 530441, XrefRangeEnd = 530613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTurnReadyNotificationFlow._execute_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000E93 RID: 3731
			// (get) Token: 0x06003215 RID: 12821 RVA: 0x000BDFAC File Offset: 0x000BC1AC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTurnReadyNotificationFlow._execute_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003216 RID: 12822 RVA: 0x000BDFEC File Offset: 0x000BC1EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 530613, XrefRangeEnd = 530618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTurnReadyNotificationFlow._execute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000E94 RID: 3732
			// (get) Token: 0x06003217 RID: 12823 RVA: 0x000BE020 File Offset: 0x000BC220
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTurnReadyNotificationFlow._execute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003218 RID: 12824 RVA: 0x00019DF2 File Offset: 0x00017FF2
			public _execute_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E8E RID: 3726
			// (get) Token: 0x06003219 RID: 12825 RVA: 0x000BE060 File Offset: 0x000BC260
			// (set) Token: 0x0600321A RID: 12826 RVA: 0x00019DFB File Offset: 0x00017FFB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTurnReadyNotificationFlow._execute_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTurnReadyNotificationFlow._execute_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000E8F RID: 3727
			// (get) Token: 0x0600321B RID: 12827 RVA: 0x000BE088 File Offset: 0x000BC288
			// (set) Token: 0x0600321C RID: 12828 RVA: 0x00019E16 File Offset: 0x00018016
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTurnReadyNotificationFlow._execute_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTurnReadyNotificationFlow._execute_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E90 RID: 3728
			// (get) Token: 0x0600321D RID: 12829 RVA: 0x000BE0B8 File Offset: 0x000BC2B8
			// (set) Token: 0x0600321E RID: 12830 RVA: 0x00019E35 File Offset: 0x00018035
			public unsafe RunTurnReadyNotificationFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTurnReadyNotificationFlow._execute_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunTurnReadyNotificationFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTurnReadyNotificationFlow._execute_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E91 RID: 3729
			// (get) Token: 0x0600321F RID: 12831 RVA: 0x000BE0E8 File Offset: 0x000BC2E8
			// (set) Token: 0x06003220 RID: 12832 RVA: 0x00019E54 File Offset: 0x00018054
			public unsafe CheckActiveInGame _checkActive_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTurnReadyNotificationFlow._execute_d__14.NativeFieldInfoPtr__checkActive_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CheckActiveInGame>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTurnReadyNotificationFlow._execute_d__14.NativeFieldInfoPtr__checkActive_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E92 RID: 3730
			// (get) Token: 0x06003221 RID: 12833 RVA: 0x000BE118 File Offset: 0x000BC318
			// (set) Token: 0x06003222 RID: 12834 RVA: 0x00019E73 File Offset: 0x00018073
			public unsafe DBGNotifications _notifications_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTurnReadyNotificationFlow._execute_d__14.NativeFieldInfoPtr__notifications_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGNotifications>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTurnReadyNotificationFlow._execute_d__14.NativeFieldInfoPtr__notifications_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001EEB RID: 7915
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001EEC RID: 7916
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001EED RID: 7917
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001EEE RID: 7918
			private static readonly IntPtr NativeFieldInfoPtr__checkActive_5__2;

			// Token: 0x04001EEF RID: 7919
			private static readonly IntPtr NativeFieldInfoPtr__notifications_5__3;

			// Token: 0x04001EF0 RID: 7920
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001EF1 RID: 7921
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001EF2 RID: 7922
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001EF3 RID: 7923
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001EF4 RID: 7924
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001EF5 RID: 7925
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
