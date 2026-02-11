using System;
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
	// Token: 0x0200022E RID: 558
	public class RunMatchFoundFlow : Command
	{
		// Token: 0x06001962 RID: 6498 RVA: 0x000700C4 File Offset: 0x0006E2C4
		// Note: this type is marked as 'beforefieldinit'.
		static RunMatchFoundFlow()
		{
			Il2CppClassPointerStore<RunMatchFoundFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "RunMatchFoundFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunMatchFoundFlow>.NativeClassPtr);
			RunMatchFoundFlow.NativeFieldInfoPtr_matchFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunMatchFoundFlow>.NativeClassPtr, "matchFound");
			RunMatchFoundFlow.NativeMethodInfoPtr__ctor_Public_Void_PBMMatchFound_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunMatchFoundFlow>.NativeClassPtr, 100667218);
			RunMatchFoundFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunMatchFoundFlow>.NativeClassPtr, 100667219);
			RunMatchFoundFlow.NativeMethodInfoPtr_liveTitleLoc_Protected_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunMatchFoundFlow>.NativeClassPtr, 100667220);
			RunMatchFoundFlow.NativeMethodInfoPtr_liveBodyLoc_Protected_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunMatchFoundFlow>.NativeClassPtr, 100667221);
			RunMatchFoundFlow.NativeMethodInfoPtr_casualTitleLoc_Protected_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunMatchFoundFlow>.NativeClassPtr, 100667222);
			RunMatchFoundFlow.NativeMethodInfoPtr_casualBodyLoc_Protected_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunMatchFoundFlow>.NativeClassPtr, 100667223);
			RunMatchFoundFlow.NativeMethodInfoPtr_friendTitleLoc_Protected_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunMatchFoundFlow>.NativeClassPtr, 100667224);
			RunMatchFoundFlow.NativeMethodInfoPtr_friendBodyLoc_Protected_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunMatchFoundFlow>.NativeClassPtr, 100667225);
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x000701A8 File Offset: 0x0006E3A8
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 495009, RefRangeEnd = 495046, XrefRangeStart = 495009, XrefRangeEnd = 495046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunMatchFoundFlow(PBMMatchFound matchFound)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunMatchFoundFlow>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchFound);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunMatchFoundFlow.NativeMethodInfoPtr__ctor_Public_Void_PBMMatchFound_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001964 RID: 6500 RVA: 0x000701F4 File Offset: 0x0006E3F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529256, XrefRangeEnd = 529261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunMatchFoundFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001965 RID: 6501 RVA: 0x00070240 File Offset: 0x0006E440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529261, XrefRangeEnd = 529267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string liveTitleLoc()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunMatchFoundFlow.NativeMethodInfoPtr_liveTitleLoc_Protected_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001966 RID: 6502 RVA: 0x00070284 File Offset: 0x0006E484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529267, XrefRangeEnd = 529273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string liveBodyLoc()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunMatchFoundFlow.NativeMethodInfoPtr_liveBodyLoc_Protected_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001967 RID: 6503 RVA: 0x000702C8 File Offset: 0x0006E4C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529273, XrefRangeEnd = 529279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string casualTitleLoc()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunMatchFoundFlow.NativeMethodInfoPtr_casualTitleLoc_Protected_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001968 RID: 6504 RVA: 0x0007030C File Offset: 0x0006E50C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529279, XrefRangeEnd = 529359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string casualBodyLoc()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunMatchFoundFlow.NativeMethodInfoPtr_casualBodyLoc_Protected_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x00070350 File Offset: 0x0006E550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529359, XrefRangeEnd = 529365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string friendTitleLoc()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunMatchFoundFlow.NativeMethodInfoPtr_friendTitleLoc_Protected_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600196A RID: 6506 RVA: 0x00070394 File Offset: 0x0006E594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529365, XrefRangeEnd = 529393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string friendBodyLoc()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunMatchFoundFlow.NativeMethodInfoPtr_friendBodyLoc_Protected_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x0000DF5B File Offset: 0x0000C15B
		public RunMatchFoundFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x0600196C RID: 6508 RVA: 0x000703D8 File Offset: 0x0006E5D8
		// (set) Token: 0x0600196D RID: 6509 RVA: 0x0000DF64 File Offset: 0x0000C164
		public unsafe PBMMatchFound matchFound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunMatchFoundFlow.NativeFieldInfoPtr_matchFound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PBMMatchFound>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunMatchFoundFlow.NativeFieldInfoPtr_matchFound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FD8 RID: 4056
		private static readonly IntPtr NativeFieldInfoPtr_matchFound;

		// Token: 0x04000FD9 RID: 4057
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PBMMatchFound_0;

		// Token: 0x04000FDA RID: 4058
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000FDB RID: 4059
		private static readonly IntPtr NativeMethodInfoPtr_liveTitleLoc_Protected_Virtual_New_String_0;

		// Token: 0x04000FDC RID: 4060
		private static readonly IntPtr NativeMethodInfoPtr_liveBodyLoc_Protected_Virtual_New_String_0;

		// Token: 0x04000FDD RID: 4061
		private static readonly IntPtr NativeMethodInfoPtr_casualTitleLoc_Protected_Virtual_New_String_0;

		// Token: 0x04000FDE RID: 4062
		private static readonly IntPtr NativeMethodInfoPtr_casualBodyLoc_Protected_Virtual_New_String_0;

		// Token: 0x04000FDF RID: 4063
		private static readonly IntPtr NativeMethodInfoPtr_friendTitleLoc_Protected_Virtual_New_String_0;

		// Token: 0x04000FE0 RID: 4064
		private static readonly IntPtr NativeMethodInfoPtr_friendBodyLoc_Protected_Virtual_New_String_0;

		// Token: 0x0200040F RID: 1039
		[ObfuscatedName("boardgames.menus.commands.RunMatchFoundFlow+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003103 RID: 12547 RVA: 0x000BACB8 File Offset: 0x000B8EB8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RunMatchFoundFlow.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunMatchFoundFlow>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunMatchFoundFlow.__c>.NativeClassPtr);
				RunMatchFoundFlow.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunMatchFoundFlow.__c>.NativeClassPtr, "<>9");
				RunMatchFoundFlow.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunMatchFoundFlow.__c>.NativeClassPtr, "<>9__6_0");
				RunMatchFoundFlow.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunMatchFoundFlow.__c>.NativeClassPtr, "<>9__8_0");
				RunMatchFoundFlow.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunMatchFoundFlow.__c>.NativeClassPtr, 100667227);
				RunMatchFoundFlow.__c.NativeMethodInfoPtr__casualBodyLoc_b__6_0_Internal_String_AccountIDUsernameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunMatchFoundFlow.__c>.NativeClassPtr, 100667228);
				RunMatchFoundFlow.__c.NativeMethodInfoPtr__friendBodyLoc_b__8_0_Internal_Object_AccountIDUsernameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunMatchFoundFlow.__c>.NativeClassPtr, 100667229);
			}

			// Token: 0x06003104 RID: 12548 RVA: 0x000BAD5C File Offset: 0x000B8F5C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunMatchFoundFlow.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunMatchFoundFlow.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003105 RID: 12549 RVA: 0x000BAD98 File Offset: 0x000B8F98
			[CallerCount(0)]
			public unsafe string _casualBodyLoc_b__6_0(AccountIDUsernameMetadata slot)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunMatchFoundFlow.__c.NativeMethodInfoPtr__casualBodyLoc_b__6_0_Internal_String_AccountIDUsernameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06003106 RID: 12550 RVA: 0x000BADE0 File Offset: 0x000B8FE0
			[CallerCount(0)]
			public unsafe Object _friendBodyLoc_b__8_0(AccountIDUsernameMetadata slot)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunMatchFoundFlow.__c.NativeMethodInfoPtr__friendBodyLoc_b__8_0_Internal_Object_AccountIDUsernameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003107 RID: 12551 RVA: 0x00019585 File Offset: 0x00017785
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E30 RID: 3632
			// (get) Token: 0x06003108 RID: 12552 RVA: 0x000BAE30 File Offset: 0x000B9030
			// (set) Token: 0x06003109 RID: 12553 RVA: 0x0001958E File Offset: 0x0001778E
			public unsafe static RunMatchFoundFlow.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunMatchFoundFlow.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunMatchFoundFlow.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunMatchFoundFlow.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E31 RID: 3633
			// (get) Token: 0x0600310A RID: 12554 RVA: 0x000BAE58 File Offset: 0x000B9058
			// (set) Token: 0x0600310B RID: 12555 RVA: 0x000195A0 File Offset: 0x000177A0
			public unsafe static Func<AccountIDUsernameMetadata, string> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunMatchFoundFlow.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AccountIDUsernameMetadata, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunMatchFoundFlow.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E32 RID: 3634
			// (get) Token: 0x0600310C RID: 12556 RVA: 0x000BAE80 File Offset: 0x000B9080
			// (set) Token: 0x0600310D RID: 12557 RVA: 0x000195B2 File Offset: 0x000177B2
			public unsafe static Func<AccountIDUsernameMetadata, Object> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunMatchFoundFlow.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AccountIDUsernameMetadata, Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunMatchFoundFlow.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001E4D RID: 7757
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001E4E RID: 7758
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04001E4F RID: 7759
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04001E50 RID: 7760
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001E51 RID: 7761
			private static readonly IntPtr NativeMethodInfoPtr__casualBodyLoc_b__6_0_Internal_String_AccountIDUsernameMetadata_0;

			// Token: 0x04001E52 RID: 7762
			private static readonly IntPtr NativeMethodInfoPtr__friendBodyLoc_b__8_0_Internal_Object_AccountIDUsernameMetadata_0;
		}

		// Token: 0x02000410 RID: 1040
		[ObfuscatedName("boardgames.menus.commands.RunMatchFoundFlow+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x0600310E RID: 12558 RVA: 0x000BAEA8 File Offset: 0x000B90A8
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<RunMatchFoundFlow._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunMatchFoundFlow>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunMatchFoundFlow._execute_d__2>.NativeClassPtr);
				RunMatchFoundFlow._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunMatchFoundFlow._execute_d__2>.NativeClassPtr, "<>1__state");
				RunMatchFoundFlow._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunMatchFoundFlow._execute_d__2>.NativeClassPtr, "<>2__current");
				RunMatchFoundFlow._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunMatchFoundFlow._execute_d__2>.NativeClassPtr, "<>4__this");
				RunMatchFoundFlow._execute_d__2.NativeFieldInfoPtr__notifications_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunMatchFoundFlow._execute_d__2>.NativeClassPtr, "<notifications>5__2");
				RunMatchFoundFlow._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunMatchFoundFlow._execute_d__2>.NativeClassPtr, 100667230);
				RunMatchFoundFlow._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunMatchFoundFlow._execute_d__2>.NativeClassPtr, 100667231);
				RunMatchFoundFlow._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunMatchFoundFlow._execute_d__2>.NativeClassPtr, 100667232);
				RunMatchFoundFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunMatchFoundFlow._execute_d__2>.NativeClassPtr, 100667233);
				RunMatchFoundFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunMatchFoundFlow._execute_d__2>.NativeClassPtr, 100667234);
				RunMatchFoundFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunMatchFoundFlow._execute_d__2>.NativeClassPtr, 100667235);
			}

			// Token: 0x0600310F RID: 12559 RVA: 0x000BAF9C File Offset: 0x000B919C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunMatchFoundFlow._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunMatchFoundFlow._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003110 RID: 12560 RVA: 0x000BAFE4 File Offset: 0x000B91E4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunMatchFoundFlow._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003111 RID: 12561 RVA: 0x000BB018 File Offset: 0x000B9218
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529182, XrefRangeEnd = 529251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunMatchFoundFlow._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000E37 RID: 3639
			// (get) Token: 0x06003112 RID: 12562 RVA: 0x000BB054 File Offset: 0x000B9254
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunMatchFoundFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003113 RID: 12563 RVA: 0x000BB094 File Offset: 0x000B9294
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529251, XrefRangeEnd = 529256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunMatchFoundFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000E38 RID: 3640
			// (get) Token: 0x06003114 RID: 12564 RVA: 0x000BB0C8 File Offset: 0x000B92C8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunMatchFoundFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003115 RID: 12565 RVA: 0x000195C4 File Offset: 0x000177C4
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E33 RID: 3635
			// (get) Token: 0x06003116 RID: 12566 RVA: 0x000BB108 File Offset: 0x000B9308
			// (set) Token: 0x06003117 RID: 12567 RVA: 0x000195CD File Offset: 0x000177CD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunMatchFoundFlow._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunMatchFoundFlow._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000E34 RID: 3636
			// (get) Token: 0x06003118 RID: 12568 RVA: 0x000BB130 File Offset: 0x000B9330
			// (set) Token: 0x06003119 RID: 12569 RVA: 0x000195E8 File Offset: 0x000177E8
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunMatchFoundFlow._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunMatchFoundFlow._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E35 RID: 3637
			// (get) Token: 0x0600311A RID: 12570 RVA: 0x000BB160 File Offset: 0x000B9360
			// (set) Token: 0x0600311B RID: 12571 RVA: 0x00019607 File Offset: 0x00017807
			public unsafe RunMatchFoundFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunMatchFoundFlow._execute_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunMatchFoundFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunMatchFoundFlow._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E36 RID: 3638
			// (get) Token: 0x0600311C RID: 12572 RVA: 0x000BB190 File Offset: 0x000B9390
			// (set) Token: 0x0600311D RID: 12573 RVA: 0x00019626 File Offset: 0x00017826
			public unsafe DBGNotifications _notifications_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunMatchFoundFlow._execute_d__2.NativeFieldInfoPtr__notifications_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGNotifications>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunMatchFoundFlow._execute_d__2.NativeFieldInfoPtr__notifications_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001E53 RID: 7763
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001E54 RID: 7764
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001E55 RID: 7765
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001E56 RID: 7766
			private static readonly IntPtr NativeFieldInfoPtr__notifications_5__2;

			// Token: 0x04001E57 RID: 7767
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001E58 RID: 7768
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001E59 RID: 7769
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001E5A RID: 7770
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001E5B RID: 7771
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001E5C RID: 7772
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
