using System;
using boardgames.menus.prompts;
using dwd.core.commands;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.SceneManagement;

namespace dwd.core.ui.prompt.commands
{
	// Token: 0x02000030 RID: 48
	public class LoadPromptVignette : Command
	{
		// Token: 0x060001CD RID: 461 RVA: 0x00009B90 File Offset: 0x00007D90
		// Note: this type is marked as 'beforefieldinit'.
		static LoadPromptVignette()
		{
			Il2CppClassPointerStore<LoadPromptVignette>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.commands", "LoadPromptVignette");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadPromptVignette>.NativeClassPtr);
			LoadPromptVignette.NativeFieldInfoPtr_newVignette = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadPromptVignette>.NativeClassPtr, "newVignette");
			LoadPromptVignette.NativeFieldInfoPtr_oldVignette = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadPromptVignette>.NativeClassPtr, "oldVignette");
			LoadPromptVignette.NativeFieldInfoPtr_prompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadPromptVignette>.NativeClassPtr, "prompt");
			LoadPromptVignette.NativeMethodInfoPtr__ctor_Public_Void_IVignetteScenePrompt_IPrompt_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPromptVignette>.NativeClassPtr, 100663500);
			LoadPromptVignette.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPromptVignette>.NativeClassPtr, 100663501);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00009C24 File Offset: 0x00007E24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1214216, RefRangeEnd = 1214217, XrefRangeStart = 1214212, XrefRangeEnd = 1214216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadPromptVignette(IVignetteScenePrompt newVignette, IPrompt prompt, string oldVignette)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadPromptVignette>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newVignette);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prompt);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(oldVignette);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadPromptVignette.NativeMethodInfoPtr__ctor_Public_Void_IVignetteScenePrompt_IPrompt_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00009C94 File Offset: 0x00007E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214217, XrefRangeEnd = 1214222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadPromptVignette.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00002E61 File Offset: 0x00001061
		public LoadPromptVignette(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x00009CE0 File Offset: 0x00007EE0
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x00002E6A File Offset: 0x0000106A
		public unsafe IVignetteScenePrompt newVignette
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadPromptVignette.NativeFieldInfoPtr_newVignette);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IVignetteScenePrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadPromptVignette.NativeFieldInfoPtr_newVignette), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x00009D10 File Offset: 0x00007F10
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x00002E89 File Offset: 0x00001089
		public unsafe string oldVignette
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadPromptVignette.NativeFieldInfoPtr_oldVignette);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadPromptVignette.NativeFieldInfoPtr_oldVignette), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00009D38 File Offset: 0x00007F38
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x00002EA8 File Offset: 0x000010A8
		public unsafe IPrompt prompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadPromptVignette.NativeFieldInfoPtr_prompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadPromptVignette.NativeFieldInfoPtr_prompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeFieldInfoPtr_newVignette;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeFieldInfoPtr_oldVignette;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeFieldInfoPtr_prompt;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IVignetteScenePrompt_IPrompt_String_0;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x02000056 RID: 86
		[ObfuscatedName("dwd.core.ui.prompt.commands.LoadPromptVignette+<execute>d__4")]
		public sealed class _execute_d__4 : Object
		{
			// Token: 0x06000354 RID: 852 RVA: 0x0000E8DC File Offset: 0x0000CADC
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__4()
			{
				Il2CppClassPointerStore<LoadPromptVignette._execute_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadPromptVignette>.NativeClassPtr, "<execute>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadPromptVignette._execute_d__4>.NativeClassPtr);
				LoadPromptVignette._execute_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadPromptVignette._execute_d__4>.NativeClassPtr, "<>1__state");
				LoadPromptVignette._execute_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadPromptVignette._execute_d__4>.NativeClassPtr, "<>2__current");
				LoadPromptVignette._execute_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadPromptVignette._execute_d__4>.NativeClassPtr, "<>4__this");
				LoadPromptVignette._execute_d__4.NativeFieldInfoPtr__spin_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadPromptVignette._execute_d__4>.NativeClassPtr, "<spin>5__2");
				LoadPromptVignette._execute_d__4.NativeFieldInfoPtr__spinner_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadPromptVignette._execute_d__4>.NativeClassPtr, "<spinner>5__3");
				LoadPromptVignette._execute_d__4.NativeFieldInfoPtr__oldScene_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadPromptVignette._execute_d__4>.NativeClassPtr, "<oldScene>5__4");
				LoadPromptVignette._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPromptVignette._execute_d__4>.NativeClassPtr, 100663502);
				LoadPromptVignette._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPromptVignette._execute_d__4>.NativeClassPtr, 100663503);
				LoadPromptVignette._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPromptVignette._execute_d__4>.NativeClassPtr, 100663504);
				LoadPromptVignette._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPromptVignette._execute_d__4>.NativeClassPtr, 100663505);
				LoadPromptVignette._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPromptVignette._execute_d__4>.NativeClassPtr, 100663506);
				LoadPromptVignette._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadPromptVignette._execute_d__4>.NativeClassPtr, 100663507);
			}

			// Token: 0x06000355 RID: 853 RVA: 0x0000E9F8 File Offset: 0x0000CBF8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadPromptVignette._execute_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadPromptVignette._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000356 RID: 854 RVA: 0x0000EA40 File Offset: 0x0000CC40
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadPromptVignette._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000357 RID: 855 RVA: 0x0000EA74 File Offset: 0x0000CC74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214156, XrefRangeEnd = 1214207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadPromptVignette._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000119 RID: 281
			// (get) Token: 0x06000358 RID: 856 RVA: 0x0000EAB0 File Offset: 0x0000CCB0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadPromptVignette._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000359 RID: 857 RVA: 0x0000EAF0 File Offset: 0x0000CCF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214207, XrefRangeEnd = 1214212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadPromptVignette._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700011A RID: 282
			// (get) Token: 0x0600035A RID: 858 RVA: 0x0000EB24 File Offset: 0x0000CD24
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadPromptVignette._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600035B RID: 859 RVA: 0x00003AD0 File Offset: 0x00001CD0
			public _execute_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000113 RID: 275
			// (get) Token: 0x0600035C RID: 860 RVA: 0x0000EB64 File Offset: 0x0000CD64
			// (set) Token: 0x0600035D RID: 861 RVA: 0x00003AD9 File Offset: 0x00001CD9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadPromptVignette._execute_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadPromptVignette._execute_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000114 RID: 276
			// (get) Token: 0x0600035E RID: 862 RVA: 0x0000EB8C File Offset: 0x0000CD8C
			// (set) Token: 0x0600035F RID: 863 RVA: 0x00003AF4 File Offset: 0x00001CF4
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadPromptVignette._execute_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadPromptVignette._execute_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000115 RID: 277
			// (get) Token: 0x06000360 RID: 864 RVA: 0x0000EBBC File Offset: 0x0000CDBC
			// (set) Token: 0x06000361 RID: 865 RVA: 0x00003B13 File Offset: 0x00001D13
			public unsafe LoadPromptVignette __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadPromptVignette._execute_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadPromptVignette>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadPromptVignette._execute_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000116 RID: 278
			// (get) Token: 0x06000362 RID: 866 RVA: 0x0000EBEC File Offset: 0x0000CDEC
			// (set) Token: 0x06000363 RID: 867 RVA: 0x00003B32 File Offset: 0x00001D32
			public unsafe Command _spin_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadPromptVignette._execute_d__4.NativeFieldInfoPtr__spin_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadPromptVignette._execute_d__4.NativeFieldInfoPtr__spin_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000117 RID: 279
			// (get) Token: 0x06000364 RID: 868 RVA: 0x0000EC1C File Offset: 0x0000CE1C
			// (set) Token: 0x06000365 RID: 869 RVA: 0x00003B51 File Offset: 0x00001D51
			public unsafe FlavoredSpinner _spinner_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadPromptVignette._execute_d__4.NativeFieldInfoPtr__spinner_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlavoredSpinner>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadPromptVignette._execute_d__4.NativeFieldInfoPtr__spinner_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000118 RID: 280
			// (get) Token: 0x06000366 RID: 870 RVA: 0x0000EC4C File Offset: 0x0000CE4C
			// (set) Token: 0x06000367 RID: 871 RVA: 0x00003B70 File Offset: 0x00001D70
			public unsafe Scene _oldScene_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadPromptVignette._execute_d__4.NativeFieldInfoPtr__oldScene_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadPromptVignette._execute_d__4.NativeFieldInfoPtr__oldScene_5__4)) = value;
				}
			}

			// Token: 0x040001E1 RID: 481
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040001E2 RID: 482
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040001E3 RID: 483
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040001E4 RID: 484
			private static readonly IntPtr NativeFieldInfoPtr__spin_5__2;

			// Token: 0x040001E5 RID: 485
			private static readonly IntPtr NativeFieldInfoPtr__spinner_5__3;

			// Token: 0x040001E6 RID: 486
			private static readonly IntPtr NativeFieldInfoPtr__oldScene_5__4;

			// Token: 0x040001E7 RID: 487
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040001E8 RID: 488
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001E9 RID: 489
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040001EA RID: 490
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040001EB RID: 491
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001EC RID: 492
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
