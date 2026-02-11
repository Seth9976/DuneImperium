using System;
using System.Runtime.InteropServices;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace dwd.core.input.context
{
	// Token: 0x02000080 RID: 128
	public class UntilGlobalInputAction : Command
	{
		// Token: 0x0600055D RID: 1373 RVA: 0x00017D90 File Offset: 0x00015F90
		// Note: this type is marked as 'beforefieldinit'.
		static UntilGlobalInputAction()
		{
			Il2CppClassPointerStore<UntilGlobalInputAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.context", "UntilGlobalInputAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UntilGlobalInputAction>.NativeClassPtr);
			UntilGlobalInputAction.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UntilGlobalInputAction>.NativeClassPtr, "action");
			UntilGlobalInputAction.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UntilGlobalInputAction>.NativeClassPtr, "evt");
			UntilGlobalInputAction.NativeFieldInfoPtr_fired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UntilGlobalInputAction>.NativeClassPtr, "fired");
			UntilGlobalInputAction.NativeFieldInfoPtr_inputDispatcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UntilGlobalInputAction>.NativeClassPtr, "inputDispatcher");
			UntilGlobalInputAction.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UntilGlobalInputAction>.NativeClassPtr, 100663960);
			UntilGlobalInputAction.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UntilGlobalInputAction>.NativeClassPtr, 100663961);
			UntilGlobalInputAction.NativeMethodInfoPtr_Interrupted_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UntilGlobalInputAction>.NativeClassPtr, 100663962);
			UntilGlobalInputAction.NativeMethodInfoPtr_cleanup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UntilGlobalInputAction>.NativeClassPtr, 100663963);
			UntilGlobalInputAction.NativeMethodInfoPtr__execute_b__5_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UntilGlobalInputAction>.NativeClassPtr, 100663964);
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00017E74 File Offset: 0x00016074
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1124310, RefRangeEnd = 1124311, XrefRangeStart = 1124293, XrefRangeEnd = 1124310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UntilGlobalInputAction(string inputID, [Optional] Il2CppStringArray inputIDs)
		{
			if (inputIDs == null)
			{
				inputIDs = new Il2CppStringArray(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UntilGlobalInputAction>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inputIDs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UntilGlobalInputAction.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00017EE0 File Offset: 0x000160E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124311, XrefRangeEnd = 1124316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UntilGlobalInputAction.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00017F2C File Offset: 0x0001612C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124316, XrefRangeEnd = 1124317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Interrupted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UntilGlobalInputAction.NativeMethodInfoPtr_Interrupted_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00017F60 File Offset: 0x00016160
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1124324, RefRangeEnd = 1124325, XrefRangeStart = 1124317, XrefRangeEnd = 1124324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UntilGlobalInputAction.NativeMethodInfoPtr_cleanup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00017F94 File Offset: 0x00016194
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 468865, RefRangeEnd = 468871, XrefRangeStart = 468865, XrefRangeEnd = 468871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _execute_b__5_0(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UntilGlobalInputAction.NativeMethodInfoPtr__execute_b__5_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00004F57 File Offset: 0x00003157
		public UntilGlobalInputAction(string inputID, params string[] inputIDs)
			: this(inputID, new Il2CppStringArray(inputIDs))
		{
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00004F66 File Offset: 0x00003166
		public UntilGlobalInputAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x00017FD4 File Offset: 0x000161D4
		// (set) Token: 0x06000566 RID: 1382 RVA: 0x00004F6F File Offset: 0x0000316F
		public unsafe InputAction action
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UntilGlobalInputAction.NativeFieldInfoPtr_action);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UntilGlobalInputAction.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000567 RID: 1383 RVA: 0x00018004 File Offset: 0x00016204
		// (set) Token: 0x06000568 RID: 1384 RVA: 0x00004F8E File Offset: 0x0000318E
		public unsafe UnityEventFloat evt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UntilGlobalInputAction.NativeFieldInfoPtr_evt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEventFloat>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UntilGlobalInputAction.NativeFieldInfoPtr_evt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x00018034 File Offset: 0x00016234
		// (set) Token: 0x0600056A RID: 1386 RVA: 0x00004FAD File Offset: 0x000031AD
		public unsafe bool fired
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UntilGlobalInputAction.NativeFieldInfoPtr_fired);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UntilGlobalInputAction.NativeFieldInfoPtr_fired)) = value;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x0001805C File Offset: 0x0001625C
		// (set) Token: 0x0600056C RID: 1388 RVA: 0x00004FC8 File Offset: 0x000031C8
		public unsafe GlobalInputDispatcher inputDispatcher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UntilGlobalInputAction.NativeFieldInfoPtr_inputDispatcher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GlobalInputDispatcher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UntilGlobalInputAction.NativeFieldInfoPtr_inputDispatcher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeFieldInfoPtr_action;

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeFieldInfoPtr_evt;

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeFieldInfoPtr_fired;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeFieldInfoPtr_inputDispatcher;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStringArray_0;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeMethodInfoPtr_Interrupted_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeMethodInfoPtr_cleanup_Private_Void_0;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeMethodInfoPtr__execute_b__5_0_Private_Void_Single_0;

		// Token: 0x020000D6 RID: 214
		[ObfuscatedName("dwd.core.input.context.UntilGlobalInputAction+<execute>d__5")]
		public sealed class _execute_d__5 : Object
		{
			// Token: 0x06000983 RID: 2435 RVA: 0x00025860 File Offset: 0x00023A60
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__5()
			{
				Il2CppClassPointerStore<UntilGlobalInputAction._execute_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UntilGlobalInputAction>.NativeClassPtr, "<execute>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UntilGlobalInputAction._execute_d__5>.NativeClassPtr);
				UntilGlobalInputAction._execute_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UntilGlobalInputAction._execute_d__5>.NativeClassPtr, "<>1__state");
				UntilGlobalInputAction._execute_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UntilGlobalInputAction._execute_d__5>.NativeClassPtr, "<>2__current");
				UntilGlobalInputAction._execute_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UntilGlobalInputAction._execute_d__5>.NativeClassPtr, "<>4__this");
				UntilGlobalInputAction._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UntilGlobalInputAction._execute_d__5>.NativeClassPtr, 100663965);
				UntilGlobalInputAction._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UntilGlobalInputAction._execute_d__5>.NativeClassPtr, 100663966);
				UntilGlobalInputAction._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UntilGlobalInputAction._execute_d__5>.NativeClassPtr, 100663967);
				UntilGlobalInputAction._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UntilGlobalInputAction._execute_d__5>.NativeClassPtr, 100663968);
				UntilGlobalInputAction._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UntilGlobalInputAction._execute_d__5>.NativeClassPtr, 100663969);
				UntilGlobalInputAction._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UntilGlobalInputAction._execute_d__5>.NativeClassPtr, 100663970);
			}

			// Token: 0x06000984 RID: 2436 RVA: 0x00025940 File Offset: 0x00023B40
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UntilGlobalInputAction._execute_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UntilGlobalInputAction._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000985 RID: 2437 RVA: 0x00025988 File Offset: 0x00023B88
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UntilGlobalInputAction._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000986 RID: 2438 RVA: 0x000259BC File Offset: 0x00023BBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124261, XrefRangeEnd = 1124288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UntilGlobalInputAction._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170002C7 RID: 711
			// (get) Token: 0x06000987 RID: 2439 RVA: 0x000259F8 File Offset: 0x00023BF8
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UntilGlobalInputAction._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000988 RID: 2440 RVA: 0x00025A38 File Offset: 0x00023C38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124288, XrefRangeEnd = 1124293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UntilGlobalInputAction._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170002C8 RID: 712
			// (get) Token: 0x06000989 RID: 2441 RVA: 0x00025A6C File Offset: 0x00023C6C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UntilGlobalInputAction._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600098A RID: 2442 RVA: 0x00006F37 File Offset: 0x00005137
			public _execute_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170002C4 RID: 708
			// (get) Token: 0x0600098B RID: 2443 RVA: 0x00025AAC File Offset: 0x00023CAC
			// (set) Token: 0x0600098C RID: 2444 RVA: 0x00006F40 File Offset: 0x00005140
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UntilGlobalInputAction._execute_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UntilGlobalInputAction._execute_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170002C5 RID: 709
			// (get) Token: 0x0600098D RID: 2445 RVA: 0x00025AD4 File Offset: 0x00023CD4
			// (set) Token: 0x0600098E RID: 2446 RVA: 0x00006F5B File Offset: 0x0000515B
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UntilGlobalInputAction._execute_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UntilGlobalInputAction._execute_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002C6 RID: 710
			// (get) Token: 0x0600098F RID: 2447 RVA: 0x00025B04 File Offset: 0x00023D04
			// (set) Token: 0x06000990 RID: 2448 RVA: 0x00006F7A File Offset: 0x0000517A
			public unsafe UntilGlobalInputAction __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UntilGlobalInputAction._execute_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UntilGlobalInputAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UntilGlobalInputAction._execute_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005E2 RID: 1506
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040005E3 RID: 1507
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040005E4 RID: 1508
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040005E5 RID: 1509
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040005E6 RID: 1510
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040005E7 RID: 1511
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040005E8 RID: 1512
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040005E9 RID: 1513
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040005EA RID: 1514
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
