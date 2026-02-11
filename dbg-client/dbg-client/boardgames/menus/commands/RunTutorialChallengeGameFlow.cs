using System;
using boardgames.menus.prompts;
using dwd.core.commands;
using dwd.core.data.composition;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.menus.commands
{
	// Token: 0x02000238 RID: 568
	public class RunTutorialChallengeGameFlow : Command
	{
		// Token: 0x060019C3 RID: 6595 RVA: 0x000715BC File Offset: 0x0006F7BC
		// Note: this type is marked as 'beforefieldinit'.
		static RunTutorialChallengeGameFlow()
		{
			Il2CppClassPointerStore<RunTutorialChallengeGameFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "RunTutorialChallengeGameFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTutorialChallengeGameFlow>.NativeClassPtr);
			RunTutorialChallengeGameFlow.NativeFieldInfoPtr_previousPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTutorialChallengeGameFlow>.NativeClassPtr, "previousPrompt");
			RunTutorialChallengeGameFlow.NativeMethodInfoPtr_SetPreviousPrompt_Public_Void_TutorialSelectPromptBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTutorialChallengeGameFlow>.NativeClassPtr, 100667357);
			RunTutorialChallengeGameFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTutorialChallengeGameFlow>.NativeClassPtr, 100667358);
			RunTutorialChallengeGameFlow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTutorialChallengeGameFlow>.NativeClassPtr, 100667359);
		}

		// Token: 0x060019C4 RID: 6596 RVA: 0x0007163C File Offset: 0x0006F83C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPreviousPrompt(TutorialSelectPromptBehaviour previousPrompt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(previousPrompt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTutorialChallengeGameFlow.NativeMethodInfoPtr_SetPreviousPrompt_Public_Void_TutorialSelectPromptBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x00071680 File Offset: 0x0006F880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 530789, XrefRangeEnd = 530794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunTutorialChallengeGameFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060019C6 RID: 6598 RVA: 0x000716CC File Offset: 0x0006F8CC
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 498694, RefRangeEnd = 498749, XrefRangeStart = 498694, XrefRangeEnd = 498749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunTutorialChallengeGameFlow()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTutorialChallengeGameFlow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTutorialChallengeGameFlow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019C7 RID: 6599 RVA: 0x0000E1E2 File Offset: 0x0000C3E2
		public RunTutorialChallengeGameFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x060019C8 RID: 6600 RVA: 0x00071708 File Offset: 0x0006F908
		// (set) Token: 0x060019C9 RID: 6601 RVA: 0x0000E1EB File Offset: 0x0000C3EB
		public unsafe TutorialSelectPromptBehaviour previousPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTutorialChallengeGameFlow.NativeFieldInfoPtr_previousPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialSelectPromptBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTutorialChallengeGameFlow.NativeFieldInfoPtr_previousPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001013 RID: 4115
		private static readonly IntPtr NativeFieldInfoPtr_previousPrompt;

		// Token: 0x04001014 RID: 4116
		private static readonly IntPtr NativeMethodInfoPtr_SetPreviousPrompt_Public_Void_TutorialSelectPromptBehaviour_0;

		// Token: 0x04001015 RID: 4117
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04001016 RID: 4118
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000424 RID: 1060
		public class TutorialToChallengeData : DataComponent
		{
			// Token: 0x06003223 RID: 12835 RVA: 0x00019E92 File Offset: 0x00018092
			// Note: this type is marked as 'beforefieldinit'.
			static TutorialToChallengeData()
			{
				Il2CppClassPointerStore<RunTutorialChallengeGameFlow.TutorialToChallengeData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunTutorialChallengeGameFlow>.NativeClassPtr, "TutorialToChallengeData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTutorialChallengeGameFlow.TutorialToChallengeData>.NativeClassPtr);
				RunTutorialChallengeGameFlow.TutorialToChallengeData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTutorialChallengeGameFlow.TutorialToChallengeData>.NativeClassPtr, 100667360);
			}

			// Token: 0x06003224 RID: 12836 RVA: 0x000BE148 File Offset: 0x000BC348
			[CallerCount(114)]
			[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530638, XrefRangeEnd = 530639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TutorialToChallengeData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTutorialChallengeGameFlow.TutorialToChallengeData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTutorialChallengeGameFlow.TutorialToChallengeData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003225 RID: 12837 RVA: 0x00019EC6 File Offset: 0x000180C6
			public TutorialToChallengeData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001EF6 RID: 7926
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000425 RID: 1061
		[ObfuscatedName("boardgames.menus.commands.RunTutorialChallengeGameFlow+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x06003226 RID: 12838 RVA: 0x000BE184 File Offset: 0x000BC384
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<RunTutorialChallengeGameFlow._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunTutorialChallengeGameFlow>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTutorialChallengeGameFlow._execute_d__3>.NativeClassPtr);
				RunTutorialChallengeGameFlow._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTutorialChallengeGameFlow._execute_d__3>.NativeClassPtr, "<>1__state");
				RunTutorialChallengeGameFlow._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTutorialChallengeGameFlow._execute_d__3>.NativeClassPtr, "<>2__current");
				RunTutorialChallengeGameFlow._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTutorialChallengeGameFlow._execute_d__3>.NativeClassPtr, "<>4__this");
				RunTutorialChallengeGameFlow._execute_d__3.NativeFieldInfoPtr__challengePrompt_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTutorialChallengeGameFlow._execute_d__3>.NativeClassPtr, "<challengePrompt>5__2");
				RunTutorialChallengeGameFlow._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTutorialChallengeGameFlow._execute_d__3>.NativeClassPtr, 100667361);
				RunTutorialChallengeGameFlow._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTutorialChallengeGameFlow._execute_d__3>.NativeClassPtr, 100667362);
				RunTutorialChallengeGameFlow._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTutorialChallengeGameFlow._execute_d__3>.NativeClassPtr, 100667363);
				RunTutorialChallengeGameFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTutorialChallengeGameFlow._execute_d__3>.NativeClassPtr, 100667364);
				RunTutorialChallengeGameFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTutorialChallengeGameFlow._execute_d__3>.NativeClassPtr, 100667365);
				RunTutorialChallengeGameFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTutorialChallengeGameFlow._execute_d__3>.NativeClassPtr, 100667366);
			}

			// Token: 0x06003227 RID: 12839 RVA: 0x000BE278 File Offset: 0x000BC478
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTutorialChallengeGameFlow._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTutorialChallengeGameFlow._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003228 RID: 12840 RVA: 0x000BE2C0 File Offset: 0x000BC4C0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTutorialChallengeGameFlow._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003229 RID: 12841 RVA: 0x000BE2F4 File Offset: 0x000BC4F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 530753, XrefRangeEnd = 530784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTutorialChallengeGameFlow._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000E99 RID: 3737
			// (get) Token: 0x0600322A RID: 12842 RVA: 0x000BE330 File Offset: 0x000BC530
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTutorialChallengeGameFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600322B RID: 12843 RVA: 0x000BE370 File Offset: 0x000BC570
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 530784, XrefRangeEnd = 530789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTutorialChallengeGameFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000E9A RID: 3738
			// (get) Token: 0x0600322C RID: 12844 RVA: 0x000BE3A4 File Offset: 0x000BC5A4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTutorialChallengeGameFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600322D RID: 12845 RVA: 0x00019ECF File Offset: 0x000180CF
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E95 RID: 3733
			// (get) Token: 0x0600322E RID: 12846 RVA: 0x000BE3E4 File Offset: 0x000BC5E4
			// (set) Token: 0x0600322F RID: 12847 RVA: 0x00019ED8 File Offset: 0x000180D8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTutorialChallengeGameFlow._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTutorialChallengeGameFlow._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000E96 RID: 3734
			// (get) Token: 0x06003230 RID: 12848 RVA: 0x000BE40C File Offset: 0x000BC60C
			// (set) Token: 0x06003231 RID: 12849 RVA: 0x00019EF3 File Offset: 0x000180F3
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTutorialChallengeGameFlow._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTutorialChallengeGameFlow._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E97 RID: 3735
			// (get) Token: 0x06003232 RID: 12850 RVA: 0x000BE43C File Offset: 0x000BC63C
			// (set) Token: 0x06003233 RID: 12851 RVA: 0x00019F12 File Offset: 0x00018112
			public unsafe RunTutorialChallengeGameFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTutorialChallengeGameFlow._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunTutorialChallengeGameFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTutorialChallengeGameFlow._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E98 RID: 3736
			// (get) Token: 0x06003234 RID: 12852 RVA: 0x000BE46C File Offset: 0x000BC66C
			// (set) Token: 0x06003235 RID: 12853 RVA: 0x00019F31 File Offset: 0x00018131
			public unsafe ConfirmOrDenyPrompt _challengePrompt_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTutorialChallengeGameFlow._execute_d__3.NativeFieldInfoPtr__challengePrompt_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmOrDenyPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTutorialChallengeGameFlow._execute_d__3.NativeFieldInfoPtr__challengePrompt_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001EF7 RID: 7927
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001EF8 RID: 7928
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001EF9 RID: 7929
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001EFA RID: 7930
			private static readonly IntPtr NativeFieldInfoPtr__challengePrompt_5__2;

			// Token: 0x04001EFB RID: 7931
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001EFC RID: 7932
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001EFD RID: 7933
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001EFE RID: 7934
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001EFF RID: 7935
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001F00 RID: 7936
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
