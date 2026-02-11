using System;
using dwd.core.commands;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace dwd.core.ui.prompt.commands
{
	// Token: 0x0200002D RID: 45
	public class DisplayGenericPrompt : Command
	{
		// Token: 0x060001B5 RID: 437 RVA: 0x000093E0 File Offset: 0x000075E0
		// Note: this type is marked as 'beforefieldinit'.
		static DisplayGenericPrompt()
		{
			Il2CppClassPointerStore<DisplayGenericPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.commands", "DisplayGenericPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisplayGenericPrompt>.NativeClassPtr);
			DisplayGenericPrompt.NativeFieldInfoPtr_Scope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayGenericPrompt>.NativeClassPtr, "Scope");
			DisplayGenericPrompt.NativeFieldInfoPtr_Prompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayGenericPrompt>.NativeClassPtr, "Prompt");
			DisplayGenericPrompt.NativeFieldInfoPtr_displayData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayGenericPrompt>.NativeClassPtr, "displayData");
			DisplayGenericPrompt.NativeMethodInfoPtr__ctor_Public_Void_ModalScope_IPrompt_ScopedPromptDisplayData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayGenericPrompt>.NativeClassPtr, 100663476);
			DisplayGenericPrompt.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayGenericPrompt>.NativeClassPtr, 100663477);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00009474 File Offset: 0x00007674
		[CallerCount(128)]
		[CachedScanResults(RefRangeStart = 998618, RefRangeEnd = 998746, XrefRangeStart = 998618, XrefRangeEnd = 998746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DisplayGenericPrompt(ModalScope scope, IPrompt prompt, ScopedPromptDisplayData displayData = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisplayGenericPrompt>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scope);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prompt);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(displayData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayGenericPrompt.NativeMethodInfoPtr__ctor_Public_Void_ModalScope_IPrompt_ScopedPromptDisplayData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000094E4 File Offset: 0x000076E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214109, XrefRangeEnd = 1214114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DisplayGenericPrompt.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002DE9 File Offset: 0x00000FE9
		public DisplayGenericPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x00009530 File Offset: 0x00007730
		// (set) Token: 0x060001BA RID: 442 RVA: 0x00002DF2 File Offset: 0x00000FF2
		public unsafe ModalScope Scope
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayGenericPrompt.NativeFieldInfoPtr_Scope);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModalScope>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayGenericPrompt.NativeFieldInfoPtr_Scope), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001BB RID: 443 RVA: 0x00009560 File Offset: 0x00007760
		// (set) Token: 0x060001BC RID: 444 RVA: 0x00002E11 File Offset: 0x00001011
		public unsafe IPrompt Prompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayGenericPrompt.NativeFieldInfoPtr_Prompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayGenericPrompt.NativeFieldInfoPtr_Prompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00009590 File Offset: 0x00007790
		// (set) Token: 0x060001BE RID: 446 RVA: 0x00002E30 File Offset: 0x00001030
		public unsafe ScopedPromptDisplayData displayData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayGenericPrompt.NativeFieldInfoPtr_displayData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScopedPromptDisplayData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayGenericPrompt.NativeFieldInfoPtr_displayData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeFieldInfoPtr_Scope;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeFieldInfoPtr_Prompt;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeFieldInfoPtr_displayData;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ModalScope_IPrompt_ScopedPromptDisplayData_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x02000053 RID: 83
		[ObfuscatedName("dwd.core.ui.prompt.commands.DisplayGenericPrompt+<execute>d__4")]
		public sealed class _execute_d__4 : Object
		{
			// Token: 0x06000328 RID: 808 RVA: 0x0000DF94 File Offset: 0x0000C194
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__4()
			{
				Il2CppClassPointerStore<DisplayGenericPrompt._execute_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DisplayGenericPrompt>.NativeClassPtr, "<execute>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisplayGenericPrompt._execute_d__4>.NativeClassPtr);
				DisplayGenericPrompt._execute_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayGenericPrompt._execute_d__4>.NativeClassPtr, "<>1__state");
				DisplayGenericPrompt._execute_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayGenericPrompt._execute_d__4>.NativeClassPtr, "<>2__current");
				DisplayGenericPrompt._execute_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayGenericPrompt._execute_d__4>.NativeClassPtr, "<>4__this");
				DisplayGenericPrompt._execute_d__4.NativeFieldInfoPtr__promptCommand_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayGenericPrompt._execute_d__4>.NativeClassPtr, "<promptCommand>5__2");
				DisplayGenericPrompt._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayGenericPrompt._execute_d__4>.NativeClassPtr, 100663478);
				DisplayGenericPrompt._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayGenericPrompt._execute_d__4>.NativeClassPtr, 100663479);
				DisplayGenericPrompt._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayGenericPrompt._execute_d__4>.NativeClassPtr, 100663480);
				DisplayGenericPrompt._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayGenericPrompt._execute_d__4>.NativeClassPtr, 100663481);
				DisplayGenericPrompt._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayGenericPrompt._execute_d__4>.NativeClassPtr, 100663482);
				DisplayGenericPrompt._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayGenericPrompt._execute_d__4>.NativeClassPtr, 100663483);
			}

			// Token: 0x06000329 RID: 809 RVA: 0x0000E088 File Offset: 0x0000C288
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisplayGenericPrompt._execute_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayGenericPrompt._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600032A RID: 810 RVA: 0x0000E0D0 File Offset: 0x0000C2D0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayGenericPrompt._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600032B RID: 811 RVA: 0x0000E104 File Offset: 0x0000C304
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214080, XrefRangeEnd = 1214104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayGenericPrompt._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000107 RID: 263
			// (get) Token: 0x0600032C RID: 812 RVA: 0x0000E140 File Offset: 0x0000C340
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayGenericPrompt._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600032D RID: 813 RVA: 0x0000E180 File Offset: 0x0000C380
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214104, XrefRangeEnd = 1214109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayGenericPrompt._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000108 RID: 264
			// (get) Token: 0x0600032E RID: 814 RVA: 0x0000E1B4 File Offset: 0x0000C3B4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayGenericPrompt._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600032F RID: 815 RVA: 0x0000398B File Offset: 0x00001B8B
			public _execute_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000103 RID: 259
			// (get) Token: 0x06000330 RID: 816 RVA: 0x0000E1F4 File Offset: 0x0000C3F4
			// (set) Token: 0x06000331 RID: 817 RVA: 0x00003994 File Offset: 0x00001B94
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayGenericPrompt._execute_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayGenericPrompt._execute_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000104 RID: 260
			// (get) Token: 0x06000332 RID: 818 RVA: 0x0000E21C File Offset: 0x0000C41C
			// (set) Token: 0x06000333 RID: 819 RVA: 0x000039AF File Offset: 0x00001BAF
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayGenericPrompt._execute_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayGenericPrompt._execute_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000105 RID: 261
			// (get) Token: 0x06000334 RID: 820 RVA: 0x0000E24C File Offset: 0x0000C44C
			// (set) Token: 0x06000335 RID: 821 RVA: 0x000039CE File Offset: 0x00001BCE
			public unsafe DisplayGenericPrompt __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayGenericPrompt._execute_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DisplayGenericPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayGenericPrompt._execute_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000106 RID: 262
			// (get) Token: 0x06000336 RID: 822 RVA: 0x0000E27C File Offset: 0x0000C47C
			// (set) Token: 0x06000337 RID: 823 RVA: 0x000039ED File Offset: 0x00001BED
			public unsafe IEnumerator _promptCommand_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayGenericPrompt._execute_d__4.NativeFieldInfoPtr__promptCommand_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayGenericPrompt._execute_d__4.NativeFieldInfoPtr__promptCommand_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001C5 RID: 453
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040001C6 RID: 454
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040001C7 RID: 455
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040001C8 RID: 456
			private static readonly IntPtr NativeFieldInfoPtr__promptCommand_5__2;

			// Token: 0x040001C9 RID: 457
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040001CA RID: 458
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001CB RID: 459
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040001CC RID: 460
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040001CD RID: 461
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001CE RID: 462
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
