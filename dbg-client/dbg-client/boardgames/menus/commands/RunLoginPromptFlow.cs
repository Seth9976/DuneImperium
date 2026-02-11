using System;
using boardgames.menus.prompts;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using zen.src.menus.commands;

namespace boardgames.menus.commands
{
	// Token: 0x0200022D RID: 557
	public class RunLoginPromptFlow : Command
	{
		// Token: 0x06001952 RID: 6482 RVA: 0x0006FD44 File Offset: 0x0006DF44
		// Note: this type is marked as 'beforefieldinit'.
		static RunLoginPromptFlow()
		{
			Il2CppClassPointerStore<RunLoginPromptFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "RunLoginPromptFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunLoginPromptFlow>.NativeClassPtr);
			RunLoginPromptFlow.NativeFieldInfoPtr__Username_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunLoginPromptFlow>.NativeClassPtr, "<Username>k__BackingField");
			RunLoginPromptFlow.NativeFieldInfoPtr__Password_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunLoginPromptFlow>.NativeClassPtr, "<Password>k__BackingField");
			RunLoginPromptFlow.NativeFieldInfoPtr__Canceled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunLoginPromptFlow>.NativeClassPtr, "<Canceled>k__BackingField");
			RunLoginPromptFlow.NativeMethodInfoPtr_get_Username_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLoginPromptFlow>.NativeClassPtr, 100667204);
			RunLoginPromptFlow.NativeMethodInfoPtr_set_Username_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLoginPromptFlow>.NativeClassPtr, 100667205);
			RunLoginPromptFlow.NativeMethodInfoPtr_get_Password_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLoginPromptFlow>.NativeClassPtr, 100667206);
			RunLoginPromptFlow.NativeMethodInfoPtr_set_Password_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLoginPromptFlow>.NativeClassPtr, 100667207);
			RunLoginPromptFlow.NativeMethodInfoPtr_get_Canceled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLoginPromptFlow>.NativeClassPtr, 100667208);
			RunLoginPromptFlow.NativeMethodInfoPtr_set_Canceled_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLoginPromptFlow>.NativeClassPtr, 100667209);
			RunLoginPromptFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLoginPromptFlow>.NativeClassPtr, 100667210);
			RunLoginPromptFlow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLoginPromptFlow>.NativeClassPtr, 100667211);
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06001953 RID: 6483 RVA: 0x0006FE50 File Offset: 0x0006E050
		// (set) Token: 0x06001954 RID: 6484 RVA: 0x0006FE88 File Offset: 0x0006E088
		public unsafe string Username
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLoginPromptFlow.NativeMethodInfoPtr_get_Username_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLoginPromptFlow.NativeMethodInfoPtr_set_Username_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06001955 RID: 6485 RVA: 0x0006FECC File Offset: 0x0006E0CC
		// (set) Token: 0x06001956 RID: 6486 RVA: 0x0006FF04 File Offset: 0x0006E104
		public unsafe string Password
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLoginPromptFlow.NativeMethodInfoPtr_get_Password_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLoginPromptFlow.NativeMethodInfoPtr_set_Password_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06001957 RID: 6487 RVA: 0x0006FF48 File Offset: 0x0006E148
		// (set) Token: 0x06001958 RID: 6488 RVA: 0x0006FF84 File Offset: 0x0006E184
		public unsafe bool Canceled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLoginPromptFlow.NativeMethodInfoPtr_get_Canceled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLoginPromptFlow.NativeMethodInfoPtr_set_Canceled_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x0006FFC4 File Offset: 0x0006E1C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529177, XrefRangeEnd = 529182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunLoginPromptFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600195A RID: 6490 RVA: 0x00070010 File Offset: 0x0006E210
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 498694, RefRangeEnd = 498749, XrefRangeStart = 498694, XrefRangeEnd = 498749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunLoginPromptFlow()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunLoginPromptFlow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLoginPromptFlow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600195B RID: 6491 RVA: 0x0000DEF9 File Offset: 0x0000C0F9
		public RunLoginPromptFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x0600195C RID: 6492 RVA: 0x0007004C File Offset: 0x0006E24C
		// (set) Token: 0x0600195D RID: 6493 RVA: 0x0000DF02 File Offset: 0x0000C102
		public unsafe string _Username_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLoginPromptFlow.NativeFieldInfoPtr__Username_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLoginPromptFlow.NativeFieldInfoPtr__Username_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x0600195E RID: 6494 RVA: 0x00070074 File Offset: 0x0006E274
		// (set) Token: 0x0600195F RID: 6495 RVA: 0x0000DF21 File Offset: 0x0000C121
		public unsafe string _Password_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLoginPromptFlow.NativeFieldInfoPtr__Password_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLoginPromptFlow.NativeFieldInfoPtr__Password_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06001960 RID: 6496 RVA: 0x0007009C File Offset: 0x0006E29C
		// (set) Token: 0x06001961 RID: 6497 RVA: 0x0000DF40 File Offset: 0x0000C140
		public unsafe bool _Canceled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLoginPromptFlow.NativeFieldInfoPtr__Canceled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLoginPromptFlow.NativeFieldInfoPtr__Canceled_k__BackingField)) = value;
			}
		}

		// Token: 0x04000FCD RID: 4045
		private static readonly IntPtr NativeFieldInfoPtr__Username_k__BackingField;

		// Token: 0x04000FCE RID: 4046
		private static readonly IntPtr NativeFieldInfoPtr__Password_k__BackingField;

		// Token: 0x04000FCF RID: 4047
		private static readonly IntPtr NativeFieldInfoPtr__Canceled_k__BackingField;

		// Token: 0x04000FD0 RID: 4048
		private static readonly IntPtr NativeMethodInfoPtr_get_Username_Public_get_String_0;

		// Token: 0x04000FD1 RID: 4049
		private static readonly IntPtr NativeMethodInfoPtr_set_Username_Private_set_Void_String_0;

		// Token: 0x04000FD2 RID: 4050
		private static readonly IntPtr NativeMethodInfoPtr_get_Password_Public_get_String_0;

		// Token: 0x04000FD3 RID: 4051
		private static readonly IntPtr NativeMethodInfoPtr_set_Password_Private_set_Void_String_0;

		// Token: 0x04000FD4 RID: 4052
		private static readonly IntPtr NativeMethodInfoPtr_get_Canceled_Public_get_Boolean_0;

		// Token: 0x04000FD5 RID: 4053
		private static readonly IntPtr NativeMethodInfoPtr_set_Canceled_Private_set_Void_Boolean_0;

		// Token: 0x04000FD6 RID: 4054
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000FD7 RID: 4055
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200040E RID: 1038
		[ObfuscatedName("boardgames.menus.commands.RunLoginPromptFlow+<execute>d__12")]
		public sealed class _execute_d__12 : Object
		{
			// Token: 0x060030EB RID: 12523 RVA: 0x000BA898 File Offset: 0x000B8A98
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__12()
			{
				Il2CppClassPointerStore<RunLoginPromptFlow._execute_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunLoginPromptFlow>.NativeClassPtr, "<execute>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunLoginPromptFlow._execute_d__12>.NativeClassPtr);
				RunLoginPromptFlow._execute_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunLoginPromptFlow._execute_d__12>.NativeClassPtr, "<>1__state");
				RunLoginPromptFlow._execute_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunLoginPromptFlow._execute_d__12>.NativeClassPtr, "<>2__current");
				RunLoginPromptFlow._execute_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunLoginPromptFlow._execute_d__12>.NativeClassPtr, "<>4__this");
				RunLoginPromptFlow._execute_d__12.NativeFieldInfoPtr__resolved_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunLoginPromptFlow._execute_d__12>.NativeClassPtr, "<resolved>5__2");
				RunLoginPromptFlow._execute_d__12.NativeFieldInfoPtr__loginPrompt_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunLoginPromptFlow._execute_d__12>.NativeClassPtr, "<loginPrompt>5__3");
				RunLoginPromptFlow._execute_d__12.NativeFieldInfoPtr__forgotPasswordPrompt_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunLoginPromptFlow._execute_d__12>.NativeClassPtr, "<forgotPasswordPrompt>5__4");
				RunLoginPromptFlow._execute_d__12.NativeFieldInfoPtr__runCreateAccount_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunLoginPromptFlow._execute_d__12>.NativeClassPtr, "<runCreateAccount>5__5");
				RunLoginPromptFlow._execute_d__12.NativeFieldInfoPtr__resetPasswordCommand_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunLoginPromptFlow._execute_d__12>.NativeClassPtr, "<resetPasswordCommand>5__6");
				RunLoginPromptFlow._execute_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLoginPromptFlow._execute_d__12>.NativeClassPtr, 100667212);
				RunLoginPromptFlow._execute_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLoginPromptFlow._execute_d__12>.NativeClassPtr, 100667213);
				RunLoginPromptFlow._execute_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLoginPromptFlow._execute_d__12>.NativeClassPtr, 100667214);
				RunLoginPromptFlow._execute_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLoginPromptFlow._execute_d__12>.NativeClassPtr, 100667215);
				RunLoginPromptFlow._execute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLoginPromptFlow._execute_d__12>.NativeClassPtr, 100667216);
				RunLoginPromptFlow._execute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLoginPromptFlow._execute_d__12>.NativeClassPtr, 100667217);
			}

			// Token: 0x060030EC RID: 12524 RVA: 0x000BA9DC File Offset: 0x000B8BDC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunLoginPromptFlow._execute_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLoginPromptFlow._execute_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060030ED RID: 12525 RVA: 0x000BAA24 File Offset: 0x000B8C24
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLoginPromptFlow._execute_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060030EE RID: 12526 RVA: 0x000BAA58 File Offset: 0x000B8C58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529085, XrefRangeEnd = 529172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLoginPromptFlow._execute_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000E2E RID: 3630
			// (get) Token: 0x060030EF RID: 12527 RVA: 0x000BAA94 File Offset: 0x000B8C94
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLoginPromptFlow._execute_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060030F0 RID: 12528 RVA: 0x000BAAD4 File Offset: 0x000B8CD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529172, XrefRangeEnd = 529177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLoginPromptFlow._execute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000E2F RID: 3631
			// (get) Token: 0x060030F1 RID: 12529 RVA: 0x000BAB08 File Offset: 0x000B8D08
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLoginPromptFlow._execute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060030F2 RID: 12530 RVA: 0x0001948C File Offset: 0x0001768C
			public _execute_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E26 RID: 3622
			// (get) Token: 0x060030F3 RID: 12531 RVA: 0x000BAB48 File Offset: 0x000B8D48
			// (set) Token: 0x060030F4 RID: 12532 RVA: 0x00019495 File Offset: 0x00017695
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLoginPromptFlow._execute_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLoginPromptFlow._execute_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000E27 RID: 3623
			// (get) Token: 0x060030F5 RID: 12533 RVA: 0x000BAB70 File Offset: 0x000B8D70
			// (set) Token: 0x060030F6 RID: 12534 RVA: 0x000194B0 File Offset: 0x000176B0
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLoginPromptFlow._execute_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLoginPromptFlow._execute_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E28 RID: 3624
			// (get) Token: 0x060030F7 RID: 12535 RVA: 0x000BABA0 File Offset: 0x000B8DA0
			// (set) Token: 0x060030F8 RID: 12536 RVA: 0x000194CF File Offset: 0x000176CF
			public unsafe RunLoginPromptFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLoginPromptFlow._execute_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunLoginPromptFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLoginPromptFlow._execute_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E29 RID: 3625
			// (get) Token: 0x060030F9 RID: 12537 RVA: 0x000BABD0 File Offset: 0x000B8DD0
			// (set) Token: 0x060030FA RID: 12538 RVA: 0x000194EE File Offset: 0x000176EE
			public unsafe bool _resolved_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLoginPromptFlow._execute_d__12.NativeFieldInfoPtr__resolved_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLoginPromptFlow._execute_d__12.NativeFieldInfoPtr__resolved_5__2)) = value;
				}
			}

			// Token: 0x17000E2A RID: 3626
			// (get) Token: 0x060030FB RID: 12539 RVA: 0x000BABF8 File Offset: 0x000B8DF8
			// (set) Token: 0x060030FC RID: 12540 RVA: 0x00019509 File Offset: 0x00017709
			public unsafe LoginPrompt _loginPrompt_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLoginPromptFlow._execute_d__12.NativeFieldInfoPtr__loginPrompt_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoginPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLoginPromptFlow._execute_d__12.NativeFieldInfoPtr__loginPrompt_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E2B RID: 3627
			// (get) Token: 0x060030FD RID: 12541 RVA: 0x000BAC28 File Offset: 0x000B8E28
			// (set) Token: 0x060030FE RID: 12542 RVA: 0x00019528 File Offset: 0x00017728
			public unsafe ForgotPasswordPrompt _forgotPasswordPrompt_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLoginPromptFlow._execute_d__12.NativeFieldInfoPtr__forgotPasswordPrompt_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ForgotPasswordPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLoginPromptFlow._execute_d__12.NativeFieldInfoPtr__forgotPasswordPrompt_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E2C RID: 3628
			// (get) Token: 0x060030FF RID: 12543 RVA: 0x000BAC58 File Offset: 0x000B8E58
			// (set) Token: 0x06003100 RID: 12544 RVA: 0x00019547 File Offset: 0x00017747
			public unsafe RunCreateAccountPromptFlow _runCreateAccount_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLoginPromptFlow._execute_d__12.NativeFieldInfoPtr__runCreateAccount_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunCreateAccountPromptFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLoginPromptFlow._execute_d__12.NativeFieldInfoPtr__runCreateAccount_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E2D RID: 3629
			// (get) Token: 0x06003101 RID: 12545 RVA: 0x000BAC88 File Offset: 0x000B8E88
			// (set) Token: 0x06003102 RID: 12546 RVA: 0x00019566 File Offset: 0x00017766
			public unsafe ResetPasswordCommand _resetPasswordCommand_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLoginPromptFlow._execute_d__12.NativeFieldInfoPtr__resetPasswordCommand_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResetPasswordCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLoginPromptFlow._execute_d__12.NativeFieldInfoPtr__resetPasswordCommand_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001E3F RID: 7743
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001E40 RID: 7744
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001E41 RID: 7745
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001E42 RID: 7746
			private static readonly IntPtr NativeFieldInfoPtr__resolved_5__2;

			// Token: 0x04001E43 RID: 7747
			private static readonly IntPtr NativeFieldInfoPtr__loginPrompt_5__3;

			// Token: 0x04001E44 RID: 7748
			private static readonly IntPtr NativeFieldInfoPtr__forgotPasswordPrompt_5__4;

			// Token: 0x04001E45 RID: 7749
			private static readonly IntPtr NativeFieldInfoPtr__runCreateAccount_5__5;

			// Token: 0x04001E46 RID: 7750
			private static readonly IntPtr NativeFieldInfoPtr__resetPasswordCommand_5__6;

			// Token: 0x04001E47 RID: 7751
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001E48 RID: 7752
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001E49 RID: 7753
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001E4A RID: 7754
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001E4B RID: 7755
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001E4C RID: 7756
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
