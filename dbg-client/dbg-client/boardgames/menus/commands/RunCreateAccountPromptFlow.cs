using System;
using boardgames.menus.prompts;
using dwd.core.account.registration;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.menus.commands
{
	// Token: 0x02000224 RID: 548
	public class RunCreateAccountPromptFlow : Command
	{
		// Token: 0x06001904 RID: 6404 RVA: 0x0006ECC8 File Offset: 0x0006CEC8
		// Note: this type is marked as 'beforefieldinit'.
		static RunCreateAccountPromptFlow()
		{
			Il2CppClassPointerStore<RunCreateAccountPromptFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "RunCreateAccountPromptFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunCreateAccountPromptFlow>.NativeClassPtr);
			RunCreateAccountPromptFlow.NativeFieldInfoPtr__Username_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCreateAccountPromptFlow>.NativeClassPtr, "<Username>k__BackingField");
			RunCreateAccountPromptFlow.NativeFieldInfoPtr__Password_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCreateAccountPromptFlow>.NativeClassPtr, "<Password>k__BackingField");
			RunCreateAccountPromptFlow.NativeFieldInfoPtr__Canceled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCreateAccountPromptFlow>.NativeClassPtr, "<Canceled>k__BackingField");
			RunCreateAccountPromptFlow.NativeMethodInfoPtr_get_Username_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCreateAccountPromptFlow>.NativeClassPtr, 100667103);
			RunCreateAccountPromptFlow.NativeMethodInfoPtr_set_Username_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCreateAccountPromptFlow>.NativeClassPtr, 100667104);
			RunCreateAccountPromptFlow.NativeMethodInfoPtr_get_Password_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCreateAccountPromptFlow>.NativeClassPtr, 100667105);
			RunCreateAccountPromptFlow.NativeMethodInfoPtr_set_Password_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCreateAccountPromptFlow>.NativeClassPtr, 100667106);
			RunCreateAccountPromptFlow.NativeMethodInfoPtr_get_Canceled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCreateAccountPromptFlow>.NativeClassPtr, 100667107);
			RunCreateAccountPromptFlow.NativeMethodInfoPtr_set_Canceled_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCreateAccountPromptFlow>.NativeClassPtr, 100667108);
			RunCreateAccountPromptFlow.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCreateAccountPromptFlow>.NativeClassPtr, 100667109);
			RunCreateAccountPromptFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCreateAccountPromptFlow>.NativeClassPtr, 100667110);
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06001905 RID: 6405 RVA: 0x0006EDD4 File Offset: 0x0006CFD4
		// (set) Token: 0x06001906 RID: 6406 RVA: 0x0006EE0C File Offset: 0x0006D00C
		public unsafe string Username
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCreateAccountPromptFlow.NativeMethodInfoPtr_get_Username_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCreateAccountPromptFlow.NativeMethodInfoPtr_set_Username_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06001907 RID: 6407 RVA: 0x0006EE50 File Offset: 0x0006D050
		// (set) Token: 0x06001908 RID: 6408 RVA: 0x0006EE88 File Offset: 0x0006D088
		public unsafe string Password
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCreateAccountPromptFlow.NativeMethodInfoPtr_get_Password_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCreateAccountPromptFlow.NativeMethodInfoPtr_set_Password_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06001909 RID: 6409 RVA: 0x0006EECC File Offset: 0x0006D0CC
		// (set) Token: 0x0600190A RID: 6410 RVA: 0x0006EF08 File Offset: 0x0006D108
		public unsafe bool Canceled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCreateAccountPromptFlow.NativeMethodInfoPtr_get_Canceled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCreateAccountPromptFlow.NativeMethodInfoPtr_set_Canceled_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x0006EF48 File Offset: 0x0006D148
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 495009, RefRangeEnd = 495046, XrefRangeStart = 495009, XrefRangeEnd = 495046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunCreateAccountPromptFlow(string defaultEmail)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunCreateAccountPromptFlow>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(defaultEmail);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCreateAccountPromptFlow.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x0006EF94 File Offset: 0x0006D194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528405, XrefRangeEnd = 528410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunCreateAccountPromptFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x0000DD02 File Offset: 0x0000BF02
		public RunCreateAccountPromptFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x0600190E RID: 6414 RVA: 0x0006EFE0 File Offset: 0x0006D1E0
		// (set) Token: 0x0600190F RID: 6415 RVA: 0x0000DD0B File Offset: 0x0000BF0B
		public unsafe string _Username_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCreateAccountPromptFlow.NativeFieldInfoPtr__Username_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCreateAccountPromptFlow.NativeFieldInfoPtr__Username_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06001910 RID: 6416 RVA: 0x0006F008 File Offset: 0x0006D208
		// (set) Token: 0x06001911 RID: 6417 RVA: 0x0000DD2A File Offset: 0x0000BF2A
		public unsafe string _Password_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCreateAccountPromptFlow.NativeFieldInfoPtr__Password_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCreateAccountPromptFlow.NativeFieldInfoPtr__Password_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06001912 RID: 6418 RVA: 0x0006F030 File Offset: 0x0006D230
		// (set) Token: 0x06001913 RID: 6419 RVA: 0x0000DD49 File Offset: 0x0000BF49
		public unsafe bool _Canceled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCreateAccountPromptFlow.NativeFieldInfoPtr__Canceled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCreateAccountPromptFlow.NativeFieldInfoPtr__Canceled_k__BackingField)) = value;
			}
		}

		// Token: 0x04000F9F RID: 3999
		private static readonly IntPtr NativeFieldInfoPtr__Username_k__BackingField;

		// Token: 0x04000FA0 RID: 4000
		private static readonly IntPtr NativeFieldInfoPtr__Password_k__BackingField;

		// Token: 0x04000FA1 RID: 4001
		private static readonly IntPtr NativeFieldInfoPtr__Canceled_k__BackingField;

		// Token: 0x04000FA2 RID: 4002
		private static readonly IntPtr NativeMethodInfoPtr_get_Username_Public_get_String_0;

		// Token: 0x04000FA3 RID: 4003
		private static readonly IntPtr NativeMethodInfoPtr_set_Username_Private_set_Void_String_0;

		// Token: 0x04000FA4 RID: 4004
		private static readonly IntPtr NativeMethodInfoPtr_get_Password_Public_get_String_0;

		// Token: 0x04000FA5 RID: 4005
		private static readonly IntPtr NativeMethodInfoPtr_set_Password_Private_set_Void_String_0;

		// Token: 0x04000FA6 RID: 4006
		private static readonly IntPtr NativeMethodInfoPtr_get_Canceled_Public_get_Boolean_0;

		// Token: 0x04000FA7 RID: 4007
		private static readonly IntPtr NativeMethodInfoPtr_set_Canceled_Private_set_Void_Boolean_0;

		// Token: 0x04000FA8 RID: 4008
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000FA9 RID: 4009
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x02000401 RID: 1025
		[ObfuscatedName("boardgames.menus.commands.RunCreateAccountPromptFlow+<execute>d__13")]
		public sealed class _execute_d__13 : Object
		{
			// Token: 0x06003022 RID: 12322 RVA: 0x000B833C File Offset: 0x000B653C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__13()
			{
				Il2CppClassPointerStore<RunCreateAccountPromptFlow._execute_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunCreateAccountPromptFlow>.NativeClassPtr, "<execute>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunCreateAccountPromptFlow._execute_d__13>.NativeClassPtr);
				RunCreateAccountPromptFlow._execute_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCreateAccountPromptFlow._execute_d__13>.NativeClassPtr, "<>1__state");
				RunCreateAccountPromptFlow._execute_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCreateAccountPromptFlow._execute_d__13>.NativeClassPtr, "<>2__current");
				RunCreateAccountPromptFlow._execute_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCreateAccountPromptFlow._execute_d__13>.NativeClassPtr, "<>4__this");
				RunCreateAccountPromptFlow._execute_d__13.NativeFieldInfoPtr__resolved_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCreateAccountPromptFlow._execute_d__13>.NativeClassPtr, "<resolved>5__2");
				RunCreateAccountPromptFlow._execute_d__13.NativeFieldInfoPtr__createAccount_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCreateAccountPromptFlow._execute_d__13>.NativeClassPtr, "<createAccount>5__3");
				RunCreateAccountPromptFlow._execute_d__13.NativeFieldInfoPtr__registerPlatformAccount_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCreateAccountPromptFlow._execute_d__13>.NativeClassPtr, "<registerPlatformAccount>5__4");
				RunCreateAccountPromptFlow._execute_d__13.NativeFieldInfoPtr__interruptableRegister_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCreateAccountPromptFlow._execute_d__13>.NativeClassPtr, "<interruptableRegister>5__5");
				RunCreateAccountPromptFlow._execute_d__13.NativeFieldInfoPtr__registerWithInterrupt_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCreateAccountPromptFlow._execute_d__13>.NativeClassPtr, "<registerWithInterrupt>5__6");
				RunCreateAccountPromptFlow._execute_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCreateAccountPromptFlow._execute_d__13>.NativeClassPtr, 100667111);
				RunCreateAccountPromptFlow._execute_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCreateAccountPromptFlow._execute_d__13>.NativeClassPtr, 100667112);
				RunCreateAccountPromptFlow._execute_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCreateAccountPromptFlow._execute_d__13>.NativeClassPtr, 100667113);
				RunCreateAccountPromptFlow._execute_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCreateAccountPromptFlow._execute_d__13>.NativeClassPtr, 100667114);
				RunCreateAccountPromptFlow._execute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCreateAccountPromptFlow._execute_d__13>.NativeClassPtr, 100667115);
				RunCreateAccountPromptFlow._execute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCreateAccountPromptFlow._execute_d__13>.NativeClassPtr, 100667116);
			}

			// Token: 0x06003023 RID: 12323 RVA: 0x000B8480 File Offset: 0x000B6680
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunCreateAccountPromptFlow._execute_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCreateAccountPromptFlow._execute_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003024 RID: 12324 RVA: 0x000B84C8 File Offset: 0x000B66C8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCreateAccountPromptFlow._execute_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003025 RID: 12325 RVA: 0x000B84FC File Offset: 0x000B66FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528252, XrefRangeEnd = 528400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCreateAccountPromptFlow._execute_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000DE4 RID: 3556
			// (get) Token: 0x06003026 RID: 12326 RVA: 0x000B8538 File Offset: 0x000B6738
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCreateAccountPromptFlow._execute_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003027 RID: 12327 RVA: 0x000B8578 File Offset: 0x000B6778
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528400, XrefRangeEnd = 528405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCreateAccountPromptFlow._execute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000DE5 RID: 3557
			// (get) Token: 0x06003028 RID: 12328 RVA: 0x000B85AC File Offset: 0x000B67AC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCreateAccountPromptFlow._execute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003029 RID: 12329 RVA: 0x00018DFA File Offset: 0x00016FFA
			public _execute_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DDC RID: 3548
			// (get) Token: 0x0600302A RID: 12330 RVA: 0x000B85EC File Offset: 0x000B67EC
			// (set) Token: 0x0600302B RID: 12331 RVA: 0x00018E03 File Offset: 0x00017003
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCreateAccountPromptFlow._execute_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCreateAccountPromptFlow._execute_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000DDD RID: 3549
			// (get) Token: 0x0600302C RID: 12332 RVA: 0x000B8614 File Offset: 0x000B6814
			// (set) Token: 0x0600302D RID: 12333 RVA: 0x00018E1E File Offset: 0x0001701E
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCreateAccountPromptFlow._execute_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCreateAccountPromptFlow._execute_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DDE RID: 3550
			// (get) Token: 0x0600302E RID: 12334 RVA: 0x000B8644 File Offset: 0x000B6844
			// (set) Token: 0x0600302F RID: 12335 RVA: 0x00018E3D File Offset: 0x0001703D
			public unsafe RunCreateAccountPromptFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCreateAccountPromptFlow._execute_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunCreateAccountPromptFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCreateAccountPromptFlow._execute_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DDF RID: 3551
			// (get) Token: 0x06003030 RID: 12336 RVA: 0x000B8674 File Offset: 0x000B6874
			// (set) Token: 0x06003031 RID: 12337 RVA: 0x00018E5C File Offset: 0x0001705C
			public unsafe bool _resolved_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCreateAccountPromptFlow._execute_d__13.NativeFieldInfoPtr__resolved_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCreateAccountPromptFlow._execute_d__13.NativeFieldInfoPtr__resolved_5__2)) = value;
				}
			}

			// Token: 0x17000DE0 RID: 3552
			// (get) Token: 0x06003032 RID: 12338 RVA: 0x000B869C File Offset: 0x000B689C
			// (set) Token: 0x06003033 RID: 12339 RVA: 0x00018E77 File Offset: 0x00017077
			public unsafe CreateAccountPrompt _createAccount_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCreateAccountPromptFlow._execute_d__13.NativeFieldInfoPtr__createAccount_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreateAccountPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCreateAccountPromptFlow._execute_d__13.NativeFieldInfoPtr__createAccount_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DE1 RID: 3553
			// (get) Token: 0x06003034 RID: 12340 RVA: 0x000B86CC File Offset: 0x000B68CC
			// (set) Token: 0x06003035 RID: 12341 RVA: 0x00018E96 File Offset: 0x00017096
			public unsafe RegisterNewPlatformAccount _registerPlatformAccount_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCreateAccountPromptFlow._execute_d__13.NativeFieldInfoPtr__registerPlatformAccount_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegisterNewPlatformAccount>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCreateAccountPromptFlow._execute_d__13.NativeFieldInfoPtr__registerPlatformAccount_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DE2 RID: 3554
			// (get) Token: 0x06003036 RID: 12342 RVA: 0x000B86FC File Offset: 0x000B68FC
			// (set) Token: 0x06003037 RID: 12343 RVA: 0x00018EB5 File Offset: 0x000170B5
			public unsafe InterruptableCommand _interruptableRegister_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCreateAccountPromptFlow._execute_d__13.NativeFieldInfoPtr__interruptableRegister_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InterruptableCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCreateAccountPromptFlow._execute_d__13.NativeFieldInfoPtr__interruptableRegister_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DE3 RID: 3555
			// (get) Token: 0x06003038 RID: 12344 RVA: 0x000B872C File Offset: 0x000B692C
			// (set) Token: 0x06003039 RID: 12345 RVA: 0x00018ED4 File Offset: 0x000170D4
			public unsafe IFailable _registerWithInterrupt_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCreateAccountPromptFlow._execute_d__13.NativeFieldInfoPtr__registerWithInterrupt_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCreateAccountPromptFlow._execute_d__13.NativeFieldInfoPtr__registerWithInterrupt_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001DC6 RID: 7622
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001DC7 RID: 7623
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001DC8 RID: 7624
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001DC9 RID: 7625
			private static readonly IntPtr NativeFieldInfoPtr__resolved_5__2;

			// Token: 0x04001DCA RID: 7626
			private static readonly IntPtr NativeFieldInfoPtr__createAccount_5__3;

			// Token: 0x04001DCB RID: 7627
			private static readonly IntPtr NativeFieldInfoPtr__registerPlatformAccount_5__4;

			// Token: 0x04001DCC RID: 7628
			private static readonly IntPtr NativeFieldInfoPtr__interruptableRegister_5__5;

			// Token: 0x04001DCD RID: 7629
			private static readonly IntPtr NativeFieldInfoPtr__registerWithInterrupt_5__6;

			// Token: 0x04001DCE RID: 7630
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001DCF RID: 7631
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001DD0 RID: 7632
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001DD1 RID: 7633
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001DD2 RID: 7634
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001DD3 RID: 7635
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
