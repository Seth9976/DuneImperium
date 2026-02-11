using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace dwd.core.input.context
{
	// Token: 0x0200007C RID: 124
	public sealed class RegisterContextInputActions : UIBehaviour
	{
		// Token: 0x06000520 RID: 1312 RVA: 0x0001720C File Offset: 0x0001540C
		// Note: this type is marked as 'beforefieldinit'.
		static RegisterContextInputActions()
		{
			Il2CppClassPointerStore<RegisterContextInputActions>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.context", "RegisterContextInputActions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterContextInputActions>.NativeClassPtr);
			RegisterContextInputActions.NativeFieldInfoPtr_inputActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterContextInputActions>.NativeClassPtr, "inputActions");
			RegisterContextInputActions.NativeFieldInfoPtr_updatedAfterEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterContextInputActions>.NativeClassPtr, "updatedAfterEnable");
			RegisterContextInputActions.NativeFieldInfoPtr_registeredContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterContextInputActions>.NativeClassPtr, "registeredContext");
			RegisterContextInputActions.NativeFieldInfoPtr_registerRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterContextInputActions>.NativeClassPtr, "registerRoutine");
			RegisterContextInputActions.NativeMethodInfoPtr_get_InputActions_Public_Virtual_Final_New_get_IEnumerable_1_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterContextInputActions>.NativeClassPtr, 100663925);
			RegisterContextInputActions.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterContextInputActions>.NativeClassPtr, 100663926);
			RegisterContextInputActions.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterContextInputActions>.NativeClassPtr, 100663927);
			RegisterContextInputActions.NativeMethodInfoPtr_registerActions_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterContextInputActions>.NativeClassPtr, 100663928);
			RegisterContextInputActions.NativeMethodInfoPtr_unregisterActions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterContextInputActions>.NativeClassPtr, 100663929);
			RegisterContextInputActions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterContextInputActions>.NativeClassPtr, 100663930);
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x00017304 File Offset: 0x00015504
		public unsafe IEnumerable<InputAction> InputActions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterContextInputActions.NativeMethodInfoPtr_get_InputActions_Public_Virtual_Final_New_get_IEnumerable_1_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<InputAction>>(intPtr3) : null;
			}
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00017344 File Offset: 0x00015544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124029, XrefRangeEnd = 1124036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterContextInputActions.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00017378 File Offset: 0x00015578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124036, XrefRangeEnd = 1124058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterContextInputActions.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x000173AC File Offset: 0x000155AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124058, XrefRangeEnd = 1124063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator registerActions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterContextInputActions.NativeMethodInfoPtr_registerActions_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x000173EC File Offset: 0x000155EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124063, XrefRangeEnd = 1124083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void unregisterActions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterContextInputActions.NativeMethodInfoPtr_unregisterActions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00017420 File Offset: 0x00015620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124083, XrefRangeEnd = 1124088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegisterContextInputActions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisterContextInputActions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterContextInputActions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00004D6E File Offset: 0x00002F6E
		public RegisterContextInputActions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x0001745C File Offset: 0x0001565C
		// (set) Token: 0x06000529 RID: 1321 RVA: 0x00004D77 File Offset: 0x00002F77
		public unsafe Il2CppReferenceArray<InputAction> inputActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterContextInputActions.NativeFieldInfoPtr_inputActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InputAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterContextInputActions.NativeFieldInfoPtr_inputActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x0001748C File Offset: 0x0001568C
		// (set) Token: 0x0600052B RID: 1323 RVA: 0x00004D96 File Offset: 0x00002F96
		public unsafe bool updatedAfterEnable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterContextInputActions.NativeFieldInfoPtr_updatedAfterEnable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterContextInputActions.NativeFieldInfoPtr_updatedAfterEnable)) = value;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x000174B4 File Offset: 0x000156B4
		// (set) Token: 0x0600052D RID: 1325 RVA: 0x00004DB1 File Offset: 0x00002FB1
		public unsafe InputContext registeredContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterContextInputActions.NativeFieldInfoPtr_registeredContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterContextInputActions.NativeFieldInfoPtr_registeredContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x000174E4 File Offset: 0x000156E4
		// (set) Token: 0x0600052F RID: 1327 RVA: 0x00004DD0 File Offset: 0x00002FD0
		public unsafe Coroutine registerRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterContextInputActions.NativeFieldInfoPtr_registerRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterContextInputActions.NativeFieldInfoPtr_registerRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeFieldInfoPtr_inputActions;

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeFieldInfoPtr_updatedAfterEnable;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeFieldInfoPtr_registeredContext;

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeFieldInfoPtr_registerRoutine;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeMethodInfoPtr_get_InputActions_Public_Virtual_Final_New_get_IEnumerable_1_InputAction_0;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeMethodInfoPtr_registerActions_Public_IEnumerator_0;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeMethodInfoPtr_unregisterActions_Private_Void_0;

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000D4 RID: 212
		[ObfuscatedName("dwd.core.input.context.RegisterContextInputActions+<registerActions>d__8")]
		public sealed class _registerActions_d__8 : global::Il2CppSystem.Object
		{
			// Token: 0x06000967 RID: 2407 RVA: 0x000252B8 File Offset: 0x000234B8
			// Note: this type is marked as 'beforefieldinit'.
			static _registerActions_d__8()
			{
				Il2CppClassPointerStore<RegisterContextInputActions._registerActions_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RegisterContextInputActions>.NativeClassPtr, "<registerActions>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterContextInputActions._registerActions_d__8>.NativeClassPtr);
				RegisterContextInputActions._registerActions_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterContextInputActions._registerActions_d__8>.NativeClassPtr, "<>1__state");
				RegisterContextInputActions._registerActions_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterContextInputActions._registerActions_d__8>.NativeClassPtr, "<>2__current");
				RegisterContextInputActions._registerActions_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterContextInputActions._registerActions_d__8>.NativeClassPtr, "<>4__this");
				RegisterContextInputActions._registerActions_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterContextInputActions._registerActions_d__8>.NativeClassPtr, 100663931);
				RegisterContextInputActions._registerActions_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterContextInputActions._registerActions_d__8>.NativeClassPtr, 100663932);
				RegisterContextInputActions._registerActions_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterContextInputActions._registerActions_d__8>.NativeClassPtr, 100663933);
				RegisterContextInputActions._registerActions_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterContextInputActions._registerActions_d__8>.NativeClassPtr, 100663934);
				RegisterContextInputActions._registerActions_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterContextInputActions._registerActions_d__8>.NativeClassPtr, 100663935);
				RegisterContextInputActions._registerActions_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterContextInputActions._registerActions_d__8>.NativeClassPtr, 100663936);
			}

			// Token: 0x06000968 RID: 2408 RVA: 0x00025398 File Offset: 0x00023598
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _registerActions_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisterContextInputActions._registerActions_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterContextInputActions._registerActions_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000969 RID: 2409 RVA: 0x000253E0 File Offset: 0x000235E0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterContextInputActions._registerActions_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600096A RID: 2410 RVA: 0x00025414 File Offset: 0x00023614
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124021, XrefRangeEnd = 1124024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterContextInputActions._registerActions_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170002BD RID: 701
			// (get) Token: 0x0600096B RID: 2411 RVA: 0x00025450 File Offset: 0x00023650
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterContextInputActions._registerActions_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600096C RID: 2412 RVA: 0x00025490 File Offset: 0x00023690
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124024, XrefRangeEnd = 1124029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterContextInputActions._registerActions_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170002BE RID: 702
			// (get) Token: 0x0600096D RID: 2413 RVA: 0x000254C4 File Offset: 0x000236C4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterContextInputActions._registerActions_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600096E RID: 2414 RVA: 0x00006E73 File Offset: 0x00005073
			public _registerActions_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170002BA RID: 698
			// (get) Token: 0x0600096F RID: 2415 RVA: 0x00025504 File Offset: 0x00023704
			// (set) Token: 0x06000970 RID: 2416 RVA: 0x00006E7C File Offset: 0x0000507C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterContextInputActions._registerActions_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterContextInputActions._registerActions_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170002BB RID: 699
			// (get) Token: 0x06000971 RID: 2417 RVA: 0x0002552C File Offset: 0x0002372C
			// (set) Token: 0x06000972 RID: 2418 RVA: 0x00006E97 File Offset: 0x00005097
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterContextInputActions._registerActions_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterContextInputActions._registerActions_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002BC RID: 700
			// (get) Token: 0x06000973 RID: 2419 RVA: 0x0002555C File Offset: 0x0002375C
			// (set) Token: 0x06000974 RID: 2420 RVA: 0x00006EB6 File Offset: 0x000050B6
			public unsafe RegisterContextInputActions __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterContextInputActions._registerActions_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegisterContextInputActions>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterContextInputActions._registerActions_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005D0 RID: 1488
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040005D1 RID: 1489
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040005D2 RID: 1490
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040005D3 RID: 1491
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040005D4 RID: 1492
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040005D5 RID: 1493
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040005D6 RID: 1494
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040005D7 RID: 1495
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040005D8 RID: 1496
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
