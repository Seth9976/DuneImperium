using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lib.canis.src.input.context;
using UnityEngine;

namespace dwd.core.input.context
{
	// Token: 0x0200007D RID: 125
	public class RegisterCreateInputContextActions : MonoBehaviour
	{
		// Token: 0x06000530 RID: 1328 RVA: 0x00017514 File Offset: 0x00015714
		// Note: this type is marked as 'beforefieldinit'.
		static RegisterCreateInputContextActions()
		{
			Il2CppClassPointerStore<RegisterCreateInputContextActions>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.context", "RegisterCreateInputContextActions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterCreateInputContextActions>.NativeClassPtr);
			RegisterCreateInputContextActions.NativeFieldInfoPtr_inputContextID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterCreateInputContextActions>.NativeClassPtr, "inputContextID");
			RegisterCreateInputContextActions.NativeFieldInfoPtr_inputContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterCreateInputContextActions>.NativeClassPtr, "inputContext");
			RegisterCreateInputContextActions.NativeFieldInfoPtr_inputActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterCreateInputContextActions>.NativeClassPtr, "inputActions");
			RegisterCreateInputContextActions.NativeFieldInfoPtr_currentInputContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterCreateInputContextActions>.NativeClassPtr, "currentInputContext");
			RegisterCreateInputContextActions.NativeFieldInfoPtr_registrar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterCreateInputContextActions>.NativeClassPtr, "registrar");
			RegisterCreateInputContextActions.NativeFieldInfoPtr_registerRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterCreateInputContextActions>.NativeClassPtr, "registerRoutine");
			RegisterCreateInputContextActions.NativeFieldInfoPtr_registeredInputContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterCreateInputContextActions>.NativeClassPtr, "registeredInputContext");
			RegisterCreateInputContextActions.NativeMethodInfoPtr_get_InputActions_Public_Virtual_Final_New_get_IEnumerable_1_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterCreateInputContextActions>.NativeClassPtr, 100663937);
			RegisterCreateInputContextActions.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterCreateInputContextActions>.NativeClassPtr, 100663938);
			RegisterCreateInputContextActions.NativeMethodInfoPtr_register_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterCreateInputContextActions>.NativeClassPtr, 100663939);
			RegisterCreateInputContextActions.NativeMethodInfoPtr_AddInputActions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterCreateInputContextActions>.NativeClassPtr, 100663940);
			RegisterCreateInputContextActions.NativeMethodInfoPtr_RemoveInputActions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterCreateInputContextActions>.NativeClassPtr, 100663941);
			RegisterCreateInputContextActions.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterCreateInputContextActions>.NativeClassPtr, 100663942);
			RegisterCreateInputContextActions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterCreateInputContextActions>.NativeClassPtr, 100663943);
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x0001765C File Offset: 0x0001585C
		public unsafe virtual IEnumerable<InputAction> InputActions
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterCreateInputContextActions.NativeMethodInfoPtr_get_InputActions_Public_Virtual_Final_New_get_IEnumerable_1_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<InputAction>>(intPtr3) : null;
			}
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x0001769C File Offset: 0x0001589C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124133, XrefRangeEnd = 1124140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterCreateInputContextActions.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x000176D0 File Offset: 0x000158D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124140, XrefRangeEnd = 1124145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator register()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterCreateInputContextActions.NativeMethodInfoPtr_register_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00017710 File Offset: 0x00015910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124145, XrefRangeEnd = 1124150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddInputActions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterCreateInputContextActions.NativeMethodInfoPtr_AddInputActions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00017744 File Offset: 0x00015944
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1124162, RefRangeEnd = 1124165, XrefRangeStart = 1124150, XrefRangeEnd = 1124162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveInputActions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterCreateInputContextActions.NativeMethodInfoPtr_RemoveInputActions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00017778 File Offset: 0x00015978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124165, XrefRangeEnd = 1124184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterCreateInputContextActions.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x000177AC File Offset: 0x000159AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124184, XrefRangeEnd = 1124192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegisterCreateInputContextActions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisterCreateInputContextActions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterCreateInputContextActions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00004DEF File Offset: 0x00002FEF
		public RegisterCreateInputContextActions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x000177E8 File Offset: 0x000159E8
		// (set) Token: 0x0600053A RID: 1338 RVA: 0x00004DF8 File Offset: 0x00002FF8
		public unsafe string inputContextID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterCreateInputContextActions.NativeFieldInfoPtr_inputContextID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterCreateInputContextActions.NativeFieldInfoPtr_inputContextID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x00017810 File Offset: 0x00015A10
		// (set) Token: 0x0600053C RID: 1340 RVA: 0x00004E17 File Offset: 0x00003017
		public unsafe CreateInputContext inputContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterCreateInputContextActions.NativeFieldInfoPtr_inputContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreateInputContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterCreateInputContextActions.NativeFieldInfoPtr_inputContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x00017840 File Offset: 0x00015A40
		// (set) Token: 0x0600053E RID: 1342 RVA: 0x00004E36 File Offset: 0x00003036
		public unsafe Il2CppReferenceArray<InputAction> inputActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterCreateInputContextActions.NativeFieldInfoPtr_inputActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InputAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterCreateInputContextActions.NativeFieldInfoPtr_inputActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x00017870 File Offset: 0x00015A70
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x00004E55 File Offset: 0x00003055
		public unsafe CreateInputContext currentInputContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterCreateInputContextActions.NativeFieldInfoPtr_currentInputContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreateInputContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterCreateInputContextActions.NativeFieldInfoPtr_currentInputContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x000178A0 File Offset: 0x00015AA0
		// (set) Token: 0x06000542 RID: 1346 RVA: 0x00004E74 File Offset: 0x00003074
		public unsafe MultiHeirarchicalInputContextRegistrar registrar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterCreateInputContextActions.NativeFieldInfoPtr_registrar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiHeirarchicalInputContextRegistrar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterCreateInputContextActions.NativeFieldInfoPtr_registrar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x000178D0 File Offset: 0x00015AD0
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x00004E93 File Offset: 0x00003093
		public unsafe Coroutine registerRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterCreateInputContextActions.NativeFieldInfoPtr_registerRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterCreateInputContextActions.NativeFieldInfoPtr_registerRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x00017900 File Offset: 0x00015B00
		// (set) Token: 0x06000546 RID: 1350 RVA: 0x00004EB2 File Offset: 0x000030B2
		public unsafe InputContext registeredInputContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterCreateInputContextActions.NativeFieldInfoPtr_registeredInputContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterCreateInputContextActions.NativeFieldInfoPtr_registeredInputContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeFieldInfoPtr_inputContextID;

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeFieldInfoPtr_inputContext;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeFieldInfoPtr_inputActions;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeFieldInfoPtr_currentInputContext;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeFieldInfoPtr_registrar;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeFieldInfoPtr_registerRoutine;

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeFieldInfoPtr_registeredInputContext;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeMethodInfoPtr_get_InputActions_Public_Virtual_Final_New_get_IEnumerable_1_InputAction_0;

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeMethodInfoPtr_register_Private_IEnumerator_0;

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeMethodInfoPtr_AddInputActions_Private_Void_0;

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeMethodInfoPtr_RemoveInputActions_Private_Void_0;

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000D5 RID: 213
		[ObfuscatedName("dwd.core.input.context.RegisterCreateInputContextActions+<register>d__10")]
		public sealed class _register_d__10 : global::Il2CppSystem.Object
		{
			// Token: 0x06000975 RID: 2421 RVA: 0x0002558C File Offset: 0x0002378C
			// Note: this type is marked as 'beforefieldinit'.
			static _register_d__10()
			{
				Il2CppClassPointerStore<RegisterCreateInputContextActions._register_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RegisterCreateInputContextActions>.NativeClassPtr, "<register>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterCreateInputContextActions._register_d__10>.NativeClassPtr);
				RegisterCreateInputContextActions._register_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterCreateInputContextActions._register_d__10>.NativeClassPtr, "<>1__state");
				RegisterCreateInputContextActions._register_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterCreateInputContextActions._register_d__10>.NativeClassPtr, "<>2__current");
				RegisterCreateInputContextActions._register_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterCreateInputContextActions._register_d__10>.NativeClassPtr, "<>4__this");
				RegisterCreateInputContextActions._register_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterCreateInputContextActions._register_d__10>.NativeClassPtr, 100663944);
				RegisterCreateInputContextActions._register_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterCreateInputContextActions._register_d__10>.NativeClassPtr, 100663945);
				RegisterCreateInputContextActions._register_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterCreateInputContextActions._register_d__10>.NativeClassPtr, 100663946);
				RegisterCreateInputContextActions._register_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterCreateInputContextActions._register_d__10>.NativeClassPtr, 100663947);
				RegisterCreateInputContextActions._register_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterCreateInputContextActions._register_d__10>.NativeClassPtr, 100663948);
				RegisterCreateInputContextActions._register_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterCreateInputContextActions._register_d__10>.NativeClassPtr, 100663949);
			}

			// Token: 0x06000976 RID: 2422 RVA: 0x0002566C File Offset: 0x0002386C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _register_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisterCreateInputContextActions._register_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterCreateInputContextActions._register_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000977 RID: 2423 RVA: 0x000256B4 File Offset: 0x000238B4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterCreateInputContextActions._register_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000978 RID: 2424 RVA: 0x000256E8 File Offset: 0x000238E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124088, XrefRangeEnd = 1124128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterCreateInputContextActions._register_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170002C2 RID: 706
			// (get) Token: 0x06000979 RID: 2425 RVA: 0x00025724 File Offset: 0x00023924
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterCreateInputContextActions._register_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600097A RID: 2426 RVA: 0x00025764 File Offset: 0x00023964
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124128, XrefRangeEnd = 1124133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterCreateInputContextActions._register_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170002C3 RID: 707
			// (get) Token: 0x0600097B RID: 2427 RVA: 0x00025798 File Offset: 0x00023998
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterCreateInputContextActions._register_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600097C RID: 2428 RVA: 0x00006ED5 File Offset: 0x000050D5
			public _register_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170002BF RID: 703
			// (get) Token: 0x0600097D RID: 2429 RVA: 0x000257D8 File Offset: 0x000239D8
			// (set) Token: 0x0600097E RID: 2430 RVA: 0x00006EDE File Offset: 0x000050DE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterCreateInputContextActions._register_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterCreateInputContextActions._register_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170002C0 RID: 704
			// (get) Token: 0x0600097F RID: 2431 RVA: 0x00025800 File Offset: 0x00023A00
			// (set) Token: 0x06000980 RID: 2432 RVA: 0x00006EF9 File Offset: 0x000050F9
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterCreateInputContextActions._register_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterCreateInputContextActions._register_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002C1 RID: 705
			// (get) Token: 0x06000981 RID: 2433 RVA: 0x00025830 File Offset: 0x00023A30
			// (set) Token: 0x06000982 RID: 2434 RVA: 0x00006F18 File Offset: 0x00005118
			public unsafe RegisterCreateInputContextActions __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterCreateInputContextActions._register_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegisterCreateInputContextActions>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterCreateInputContextActions._register_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005D9 RID: 1497
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040005DA RID: 1498
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040005DB RID: 1499
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040005DC RID: 1500
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040005DD RID: 1501
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040005DE RID: 1502
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040005DF RID: 1503
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040005E0 RID: 1504
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040005E1 RID: 1505
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
