using System;
using dwd.core.commands;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace dwd.core.ui.prompt.commands
{
	// Token: 0x02000031 RID: 49
	public class ShowSpinnerWhile<T> : Command
	{
		// Token: 0x060001D7 RID: 471 RVA: 0x00009D68 File Offset: 0x00007F68
		// Note: this type is marked as 'beforefieldinit'.
		static ShowSpinnerWhile()
		{
			Il2CppClassPointerStore<ShowSpinnerWhile<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.commands", "ShowSpinnerWhile`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowSpinnerWhile<T>>.NativeClassPtr);
			ShowSpinnerWhile<T>.NativeFieldInfoPtr_Scope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowSpinnerWhile<T>>.NativeClassPtr, "Scope");
			ShowSpinnerWhile<T>.NativeFieldInfoPtr_Spinner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowSpinnerWhile<T>>.NativeClassPtr, "Spinner");
			ShowSpinnerWhile<T>.NativeFieldInfoPtr_WaitForDisplayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowSpinnerWhile<T>>.NativeClassPtr, "WaitForDisplayed");
			ShowSpinnerWhile<T>.NativeFieldInfoPtr_DisplayData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowSpinnerWhile<T>>.NativeClassPtr, "DisplayData");
			ShowSpinnerWhile<T>.NativeFieldInfoPtr_InnerEnumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowSpinnerWhile<T>>.NativeClassPtr, "InnerEnumerator");
			ShowSpinnerWhile<T>.NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowSpinnerWhile<T>>.NativeClassPtr, "status");
			ShowSpinnerWhile<T>.NativeMethodInfoPtr__ctor_Public_Void_T_ModalScope_Spinner_Boolean_ScopedPromptDisplayData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowSpinnerWhile<T>>.NativeClassPtr, 100663508);
			ShowSpinnerWhile<T>.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowSpinnerWhile<T>>.NativeClassPtr, 100663509);
			ShowSpinnerWhile<T>.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowSpinnerWhile<T>>.NativeClassPtr, 100663510);
			ShowSpinnerWhile<T>.NativeMethodInfoPtr__execute_b__6_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowSpinnerWhile<T>>.NativeClassPtr, 100663511);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00009E9C File Offset: 0x0000809C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1214240, RefRangeEnd = 1214242, XrefRangeStart = 1214226, XrefRangeEnd = 1214240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShowSpinnerWhile(T innerEnumerator, ModalScope scope, Spinner spinner = null, bool waitForDisplayed = false, ScopedPromptDisplayData displayData = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowSpinnerWhile<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = innerEnumerator;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref innerEnumerator;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scope);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spinner);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref waitForDisplayed;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(displayData);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ShowSpinnerWhile<T>.NativeMethodInfoPtr__ctor_Public_Void_T_ModalScope_Spinner_Boolean_ScopedPromptDisplayData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00009F64 File Offset: 0x00008164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShowSpinnerWhile<T>.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00009FB0 File Offset: 0x000081B0
		[CallerCount(0)]
		public unsafe virtual ErrorInfo Status()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowSpinnerWhile<T>.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ErrorInfo(intPtr);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00009FE8 File Offset: 0x000081E8
		[CallerCount(0)]
		public unsafe bool _execute_b__6_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowSpinnerWhile<T>.NativeMethodInfoPtr__execute_b__6_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00002EC7 File Offset: 0x000010C7
		public ShowSpinnerWhile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001DD RID: 477 RVA: 0x0000A024 File Offset: 0x00008224
		// (set) Token: 0x060001DE RID: 478 RVA: 0x00002ED0 File Offset: 0x000010D0
		public unsafe ModalScope Scope
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowSpinnerWhile<T>.NativeFieldInfoPtr_Scope);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModalScope>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowSpinnerWhile<T>.NativeFieldInfoPtr_Scope), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001DF RID: 479 RVA: 0x0000A054 File Offset: 0x00008254
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x00002EEF File Offset: 0x000010EF
		public unsafe Spinner Spinner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowSpinnerWhile<T>.NativeFieldInfoPtr_Spinner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spinner>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowSpinnerWhile<T>.NativeFieldInfoPtr_Spinner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x0000A084 File Offset: 0x00008284
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x00002F0E File Offset: 0x0000110E
		public unsafe bool WaitForDisplayed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowSpinnerWhile<T>.NativeFieldInfoPtr_WaitForDisplayed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowSpinnerWhile<T>.NativeFieldInfoPtr_WaitForDisplayed)) = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x0000A0AC File Offset: 0x000082AC
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x00002F29 File Offset: 0x00001129
		public unsafe ScopedPromptDisplayData DisplayData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowSpinnerWhile<T>.NativeFieldInfoPtr_DisplayData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScopedPromptDisplayData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowSpinnerWhile<T>.NativeFieldInfoPtr_DisplayData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x0000A0DC File Offset: 0x000082DC
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x0000A104 File Offset: 0x00008304
		public unsafe T InnerEnumerator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowSpinnerWhile<T>.NativeFieldInfoPtr_InnerEnumerator);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowSpinnerWhile<T>.NativeFieldInfoPtr_InnerEnumerator);
				Type typeFromHandle = typeof(T);
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

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x0000A1AC File Offset: 0x000083AC
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x00002F48 File Offset: 0x00001148
		public ErrorInfo status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowSpinnerWhile<T>.NativeFieldInfoPtr_status);
				return new ErrorInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowSpinnerWhile<T>.NativeFieldInfoPtr_status), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeFieldInfoPtr_Scope;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeFieldInfoPtr_Spinner;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeFieldInfoPtr_WaitForDisplayed;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeFieldInfoPtr_DisplayData;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeFieldInfoPtr_InnerEnumerator;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeFieldInfoPtr_status;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_ModalScope_Spinner_Boolean_ScopedPromptDisplayData_0;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr__execute_b__6_0_Private_Boolean_0;

		// Token: 0x02000057 RID: 87
		[ObfuscatedName("dwd.core.ui.prompt.commands.ShowSpinnerWhile`1+<execute>d__6")]
		public sealed class _execute_d__6 : Object
		{
			// Token: 0x06000368 RID: 872 RVA: 0x0000EC74 File Offset: 0x0000CE74
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__6()
			{
				Il2CppClassPointerStore<ShowSpinnerWhile<T>._execute_d__6>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowSpinnerWhile<T>>.NativeClassPtr, "<execute>d__6"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowSpinnerWhile<T>._execute_d__6>.NativeClassPtr);
				ShowSpinnerWhile<T>._execute_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowSpinnerWhile<T>._execute_d__6>.NativeClassPtr, "<>1__state");
				ShowSpinnerWhile<T>._execute_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowSpinnerWhile<T>._execute_d__6>.NativeClassPtr, "<>2__current");
				ShowSpinnerWhile<T>._execute_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowSpinnerWhile<T>._execute_d__6>.NativeClassPtr, "<>4__this");
				ShowSpinnerWhile<T>._execute_d__6.NativeFieldInfoPtr__spin_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowSpinnerWhile<T>._execute_d__6>.NativeClassPtr, "<spin>5__2");
				ShowSpinnerWhile<T>._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowSpinnerWhile<T>._execute_d__6>.NativeClassPtr, 100663512);
				ShowSpinnerWhile<T>._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowSpinnerWhile<T>._execute_d__6>.NativeClassPtr, 100663513);
				ShowSpinnerWhile<T>._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowSpinnerWhile<T>._execute_d__6>.NativeClassPtr, 100663514);
				ShowSpinnerWhile<T>._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowSpinnerWhile<T>._execute_d__6>.NativeClassPtr, 100663515);
				ShowSpinnerWhile<T>._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowSpinnerWhile<T>._execute_d__6>.NativeClassPtr, 100663516);
				ShowSpinnerWhile<T>._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowSpinnerWhile<T>._execute_d__6>.NativeClassPtr, 100663517);
			}

			// Token: 0x06000369 RID: 873 RVA: 0x0000EDA4 File Offset: 0x0000CFA4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowSpinnerWhile<T>._execute_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowSpinnerWhile<T>._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600036A RID: 874 RVA: 0x0000EDEC File Offset: 0x0000CFEC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowSpinnerWhile<T>._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600036B RID: 875 RVA: 0x0000EE20 File Offset: 0x0000D020
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214222, XrefRangeEnd = 1214226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowSpinnerWhile<T>._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700011F RID: 287
			// (get) Token: 0x0600036C RID: 876 RVA: 0x0000EE5C File Offset: 0x0000D05C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowSpinnerWhile<T>._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600036D RID: 877 RVA: 0x0000EE9C File Offset: 0x0000D09C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowSpinnerWhile<T>._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000120 RID: 288
			// (get) Token: 0x0600036E RID: 878 RVA: 0x0000EED0 File Offset: 0x0000D0D0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowSpinnerWhile<T>._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600036F RID: 879 RVA: 0x00003B8B File Offset: 0x00001D8B
			public _execute_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700011B RID: 283
			// (get) Token: 0x06000370 RID: 880 RVA: 0x0000EF10 File Offset: 0x0000D110
			// (set) Token: 0x06000371 RID: 881 RVA: 0x00003B94 File Offset: 0x00001D94
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowSpinnerWhile<T>._execute_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowSpinnerWhile<T>._execute_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700011C RID: 284
			// (get) Token: 0x06000372 RID: 882 RVA: 0x0000EF38 File Offset: 0x0000D138
			// (set) Token: 0x06000373 RID: 883 RVA: 0x00003BAF File Offset: 0x00001DAF
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowSpinnerWhile<T>._execute_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowSpinnerWhile<T>._execute_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700011D RID: 285
			// (get) Token: 0x06000374 RID: 884 RVA: 0x0000EF68 File Offset: 0x0000D168
			// (set) Token: 0x06000375 RID: 885 RVA: 0x00003BCE File Offset: 0x00001DCE
			public unsafe ShowSpinnerWhile<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowSpinnerWhile<T>._execute_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShowSpinnerWhile<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowSpinnerWhile<T>._execute_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700011E RID: 286
			// (get) Token: 0x06000376 RID: 886 RVA: 0x0000EF98 File Offset: 0x0000D198
			// (set) Token: 0x06000377 RID: 887 RVA: 0x00003BED File Offset: 0x00001DED
			public unsafe DisplayGenericPrompt _spin_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowSpinnerWhile<T>._execute_d__6.NativeFieldInfoPtr__spin_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DisplayGenericPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowSpinnerWhile<T>._execute_d__6.NativeFieldInfoPtr__spin_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001ED RID: 493
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040001EE RID: 494
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040001EF RID: 495
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040001F0 RID: 496
			private static readonly IntPtr NativeFieldInfoPtr__spin_5__2;

			// Token: 0x040001F1 RID: 497
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040001F2 RID: 498
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001F3 RID: 499
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040001F4 RID: 500
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040001F5 RID: 501
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001F6 RID: 502
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
