using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace dwd.core.ui.prompt.commands
{
	// Token: 0x0200002F RID: 47
	public class DisplayScopedModalPrompt<TScopes, TPrompt> : Command
	{
		// Token: 0x060001C5 RID: 453 RVA: 0x00009808 File Offset: 0x00007A08
		// Note: this type is marked as 'beforefieldinit'.
		static DisplayScopedModalPrompt()
		{
			Il2CppClassPointerStore<DisplayScopedModalPrompt<TScopes, TPrompt>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.commands", "DisplayScopedModalPrompt`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TScopes>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPrompt>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisplayScopedModalPrompt<TScopes, TPrompt>>.NativeClassPtr);
			DisplayScopedModalPrompt<TScopes, TPrompt>.NativeFieldInfoPtr_Scope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayScopedModalPrompt<TScopes, TPrompt>>.NativeClassPtr, "Scope");
			DisplayScopedModalPrompt<TScopes, TPrompt>.NativeFieldInfoPtr_Prompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayScopedModalPrompt<TScopes, TPrompt>>.NativeClassPtr, "Prompt");
			DisplayScopedModalPrompt<TScopes, TPrompt>.NativeMethodInfoPtr__ctor_Public_Void_TScopes_TPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayScopedModalPrompt<TScopes, TPrompt>>.NativeClassPtr, 100663492);
			DisplayScopedModalPrompt<TScopes, TPrompt>.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayScopedModalPrompt<TScopes, TPrompt>>.NativeClassPtr, 100663493);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000098D8 File Offset: 0x00007AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214149, XrefRangeEnd = 1214156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DisplayScopedModalPrompt(TScopes scope, TPrompt prompt)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisplayScopedModalPrompt<TScopes, TPrompt>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TScopes).IsValueType)
				{
					TScopes tscopes = scope;
					intPtr = ((tscopes is string) ? IL2CPP.ManagedStringToIl2Cpp(tscopes as string) : IL2CPP.Il2CppObjectBaseToPtr(tscopes as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref scope;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(TPrompt).IsValueType)
			{
				TPrompt tprompt = prompt;
				intPtr2 = ((tprompt is string) ? IL2CPP.ManagedStringToIl2Cpp(tprompt as string) : IL2CPP.Il2CppObjectBaseToPtr(tprompt as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref prompt;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DisplayScopedModalPrompt<TScopes, TPrompt>.NativeMethodInfoPtr__ctor_Public_Void_TScopes_TPrompt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x000099A4 File Offset: 0x00007BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DisplayScopedModalPrompt<TScopes, TPrompt>.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00002E58 File Offset: 0x00001058
		public DisplayScopedModalPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x000099F0 File Offset: 0x00007BF0
		// (set) Token: 0x060001CA RID: 458 RVA: 0x00009A18 File Offset: 0x00007C18
		public unsafe TScopes Scope
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayScopedModalPrompt<TScopes, TPrompt>.NativeFieldInfoPtr_Scope);
				return IL2CPP.PointerToValueGeneric<TScopes>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayScopedModalPrompt<TScopes, TPrompt>.NativeFieldInfoPtr_Scope);
				Type typeFromHandle = typeof(TScopes);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001CB RID: 459 RVA: 0x00009AC0 File Offset: 0x00007CC0
		// (set) Token: 0x060001CC RID: 460 RVA: 0x00009AE8 File Offset: 0x00007CE8
		public unsafe TPrompt Prompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayScopedModalPrompt<TScopes, TPrompt>.NativeFieldInfoPtr_Prompt);
				return IL2CPP.PointerToValueGeneric<TPrompt>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayScopedModalPrompt<TScopes, TPrompt>.NativeFieldInfoPtr_Prompt);
				Type typeFromHandle = typeof(TPrompt);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeFieldInfoPtr_Scope;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeFieldInfoPtr_Prompt;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TScopes_TPrompt_0;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x02000055 RID: 85
		[ObfuscatedName("dwd.core.ui.prompt.commands.DisplayScopedModalPrompt`2+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x06000346 RID: 838 RVA: 0x0000E5BC File Offset: 0x0000C7BC
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<DisplayScopedModalPrompt<TScopes, TPrompt>._execute_d__3>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DisplayScopedModalPrompt<TScopes, TPrompt>>.NativeClassPtr, "<execute>d__3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TScopes>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPrompt>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisplayScopedModalPrompt<TScopes, TPrompt>._execute_d__3>.NativeClassPtr);
				DisplayScopedModalPrompt<TScopes, TPrompt>._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayScopedModalPrompt<TScopes, TPrompt>._execute_d__3>.NativeClassPtr, "<>1__state");
				DisplayScopedModalPrompt<TScopes, TPrompt>._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayScopedModalPrompt<TScopes, TPrompt>._execute_d__3>.NativeClassPtr, "<>2__current");
				DisplayScopedModalPrompt<TScopes, TPrompt>._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayScopedModalPrompt<TScopes, TPrompt>._execute_d__3>.NativeClassPtr, "<>4__this");
				DisplayScopedModalPrompt<TScopes, TPrompt>._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayScopedModalPrompt<TScopes, TPrompt>._execute_d__3>.NativeClassPtr, 100663494);
				DisplayScopedModalPrompt<TScopes, TPrompt>._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayScopedModalPrompt<TScopes, TPrompt>._execute_d__3>.NativeClassPtr, 100663495);
				DisplayScopedModalPrompt<TScopes, TPrompt>._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayScopedModalPrompt<TScopes, TPrompt>._execute_d__3>.NativeClassPtr, 100663496);
				DisplayScopedModalPrompt<TScopes, TPrompt>._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayScopedModalPrompt<TScopes, TPrompt>._execute_d__3>.NativeClassPtr, 100663497);
				DisplayScopedModalPrompt<TScopes, TPrompt>._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayScopedModalPrompt<TScopes, TPrompt>._execute_d__3>.NativeClassPtr, 100663498);
				DisplayScopedModalPrompt<TScopes, TPrompt>._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayScopedModalPrompt<TScopes, TPrompt>._execute_d__3>.NativeClassPtr, 100663499);
			}

			// Token: 0x06000347 RID: 839 RVA: 0x0000E6E8 File Offset: 0x0000C8E8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisplayScopedModalPrompt<TScopes, TPrompt>._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayScopedModalPrompt<TScopes, TPrompt>._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000348 RID: 840 RVA: 0x0000E730 File Offset: 0x0000C930
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayScopedModalPrompt<TScopes, TPrompt>._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000349 RID: 841 RVA: 0x0000E764 File Offset: 0x0000C964
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214128, XrefRangeEnd = 1214149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayScopedModalPrompt<TScopes, TPrompt>._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000111 RID: 273
			// (get) Token: 0x0600034A RID: 842 RVA: 0x0000E7A0 File Offset: 0x0000C9A0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayScopedModalPrompt<TScopes, TPrompt>._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600034B RID: 843 RVA: 0x0000E7E0 File Offset: 0x0000C9E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayScopedModalPrompt<TScopes, TPrompt>._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000112 RID: 274
			// (get) Token: 0x0600034C RID: 844 RVA: 0x0000E814 File Offset: 0x0000CA14
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayScopedModalPrompt<TScopes, TPrompt>._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600034D RID: 845 RVA: 0x00003A6E File Offset: 0x00001C6E
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700010E RID: 270
			// (get) Token: 0x0600034E RID: 846 RVA: 0x0000E854 File Offset: 0x0000CA54
			// (set) Token: 0x0600034F RID: 847 RVA: 0x00003A77 File Offset: 0x00001C77
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayScopedModalPrompt<TScopes, TPrompt>._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayScopedModalPrompt<TScopes, TPrompt>._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700010F RID: 271
			// (get) Token: 0x06000350 RID: 848 RVA: 0x0000E87C File Offset: 0x0000CA7C
			// (set) Token: 0x06000351 RID: 849 RVA: 0x00003A92 File Offset: 0x00001C92
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayScopedModalPrompt<TScopes, TPrompt>._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayScopedModalPrompt<TScopes, TPrompt>._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000110 RID: 272
			// (get) Token: 0x06000352 RID: 850 RVA: 0x0000E8AC File Offset: 0x0000CAAC
			// (set) Token: 0x06000353 RID: 851 RVA: 0x00003AB1 File Offset: 0x00001CB1
			public unsafe DisplayScopedModalPrompt<TScopes, TPrompt> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayScopedModalPrompt<TScopes, TPrompt>._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DisplayScopedModalPrompt<TScopes, TPrompt>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayScopedModalPrompt<TScopes, TPrompt>._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001D8 RID: 472
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040001D9 RID: 473
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040001DA RID: 474
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040001DB RID: 475
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040001DC RID: 476
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001DD RID: 477
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040001DE RID: 478
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040001DF RID: 479
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001E0 RID: 480
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
