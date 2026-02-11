using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace dwd.core
{
	// Token: 0x02000027 RID: 39
	public class RegisterGlobalInputFunction : UIBehaviour
	{
		// Token: 0x0600013A RID: 314 RVA: 0x0000B00C File Offset: 0x0000920C
		// Note: this type is marked as 'beforefieldinit'.
		static RegisterGlobalInputFunction()
		{
			Il2CppClassPointerStore<RegisterGlobalInputFunction>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core", "RegisterGlobalInputFunction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterGlobalInputFunction>.NativeClassPtr);
			RegisterGlobalInputFunction.NativeFieldInfoPtr_inputId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterGlobalInputFunction>.NativeClassPtr, "inputId");
			RegisterGlobalInputFunction.NativeFieldInfoPtr_registerRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterGlobalInputFunction>.NativeClassPtr, "registerRoutine");
			RegisterGlobalInputFunction.NativeFieldInfoPtr_registeredAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterGlobalInputFunction>.NativeClassPtr, "registeredAction");
			RegisterGlobalInputFunction.NativeMethodInfoPtr_context_IRegisterInputActions_get_InputActions_Private_Virtual_Final_New_get_IEnumerable_1_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterGlobalInputFunction>.NativeClassPtr, 100663469);
			RegisterGlobalInputFunction.NativeMethodInfoPtr_context_IRegisterInputActions_get_IsGlobal_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterGlobalInputFunction>.NativeClassPtr, 100663470);
			RegisterGlobalInputFunction.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterGlobalInputFunction>.NativeClassPtr, 100663471);
			RegisterGlobalInputFunction.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterGlobalInputFunction>.NativeClassPtr, 100663472);
			RegisterGlobalInputFunction.NativeMethodInfoPtr_register_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterGlobalInputFunction>.NativeClassPtr, 100663473);
			RegisterGlobalInputFunction.NativeMethodInfoPtr_unregister_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterGlobalInputFunction>.NativeClassPtr, 100663474);
			RegisterGlobalInputFunction.NativeMethodInfoPtr_execute_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterGlobalInputFunction>.NativeClassPtr, 100663475);
			RegisterGlobalInputFunction.NativeMethodInfoPtr_canExecuteFunction_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterGlobalInputFunction>.NativeClassPtr, 100663476);
			RegisterGlobalInputFunction.NativeMethodInfoPtr_onSuccess_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterGlobalInputFunction>.NativeClassPtr, 100663477);
			RegisterGlobalInputFunction.NativeMethodInfoPtr_onFailure_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterGlobalInputFunction>.NativeClassPtr, 100663478);
			RegisterGlobalInputFunction.NativeMethodInfoPtr_executeFunction_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterGlobalInputFunction>.NativeClassPtr, 100663479);
			RegisterGlobalInputFunction.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterGlobalInputFunction>.NativeClassPtr, 100663480);
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600013B RID: 315 RVA: 0x0000B168 File Offset: 0x00009368
		public unsafe virtual IEnumerable<InputAction> context.IRegisterInputActions.InputActions
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120027, XrefRangeEnd = 1120033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterGlobalInputFunction.NativeMethodInfoPtr_context_IRegisterInputActions_get_InputActions_Private_Virtual_Final_New_get_IEnumerable_1_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<InputAction>>(intPtr3) : null;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600013C RID: 316 RVA: 0x0000B1A8 File Offset: 0x000093A8
		public unsafe virtual bool context.IRegisterInputActions.IsGlobal
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterGlobalInputFunction.NativeMethodInfoPtr_context_IRegisterInputActions_get_IsGlobal_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0000B1E4 File Offset: 0x000093E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120033, XrefRangeEnd = 1120040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegisterGlobalInputFunction.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0000B220 File Offset: 0x00009420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120040, XrefRangeEnd = 1120058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegisterGlobalInputFunction.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0000B25C File Offset: 0x0000945C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120058, XrefRangeEnd = 1120063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator register()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterGlobalInputFunction.NativeMethodInfoPtr_register_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0000B29C File Offset: 0x0000949C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120063, XrefRangeEnd = 1120079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void unregister()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterGlobalInputFunction.NativeMethodInfoPtr_unregister_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0000B2D0 File Offset: 0x000094D0
		[CallerCount(0)]
		public unsafe void execute(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterGlobalInputFunction.NativeMethodInfoPtr_execute_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000B310 File Offset: 0x00009510
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool canExecuteFunction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegisterGlobalInputFunction.NativeMethodInfoPtr_canExecuteFunction_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000B358 File Offset: 0x00009558
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void onSuccess()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegisterGlobalInputFunction.NativeMethodInfoPtr_onSuccess_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0000B394 File Offset: 0x00009594
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void onFailure()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegisterGlobalInputFunction.NativeMethodInfoPtr_onFailure_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0000B3D0 File Offset: 0x000095D0
		[CallerCount(0)]
		public unsafe virtual void executeFunction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegisterGlobalInputFunction.NativeMethodInfoPtr_executeFunction_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0000B40C File Offset: 0x0000960C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120079, XrefRangeEnd = 1120083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegisterGlobalInputFunction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisterGlobalInputFunction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterGlobalInputFunction.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00002AAC File Offset: 0x00000CAC
		public RegisterGlobalInputFunction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000148 RID: 328 RVA: 0x0000B448 File Offset: 0x00009648
		// (set) Token: 0x06000149 RID: 329 RVA: 0x00002AB5 File Offset: 0x00000CB5
		public unsafe string inputId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterGlobalInputFunction.NativeFieldInfoPtr_inputId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterGlobalInputFunction.NativeFieldInfoPtr_inputId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600014A RID: 330 RVA: 0x0000B470 File Offset: 0x00009670
		// (set) Token: 0x0600014B RID: 331 RVA: 0x00002AD4 File Offset: 0x00000CD4
		public unsafe Coroutine registerRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterGlobalInputFunction.NativeFieldInfoPtr_registerRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterGlobalInputFunction.NativeFieldInfoPtr_registerRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600014C RID: 332 RVA: 0x0000B4A0 File Offset: 0x000096A0
		// (set) Token: 0x0600014D RID: 333 RVA: 0x00002AF3 File Offset: 0x00000CF3
		public unsafe InputAction registeredAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterGlobalInputFunction.NativeFieldInfoPtr_registeredAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterGlobalInputFunction.NativeFieldInfoPtr_registeredAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeFieldInfoPtr_inputId;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeFieldInfoPtr_registerRoutine;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeFieldInfoPtr_registeredAction;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_context_IRegisterInputActions_get_InputActions_Private_Virtual_Final_New_get_IEnumerable_1_InputAction_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_context_IRegisterInputActions_get_IsGlobal_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_register_Private_IEnumerator_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_unregister_Private_Void_0;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr_execute_Private_Void_Single_0;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr_canExecuteFunction_Protected_Virtual_New_Boolean_0;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeMethodInfoPtr_onSuccess_Protected_Virtual_New_Void_0;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeMethodInfoPtr_onFailure_Protected_Virtual_New_Void_0;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr_executeFunction_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020000BD RID: 189
		[ObfuscatedName("dwd.core.RegisterGlobalInputFunction+<register>d__9")]
		public sealed class _register_d__9 : global::Il2CppSystem.Object
		{
			// Token: 0x06000887 RID: 2183 RVA: 0x000227FC File Offset: 0x000209FC
			// Note: this type is marked as 'beforefieldinit'.
			static _register_d__9()
			{
				Il2CppClassPointerStore<RegisterGlobalInputFunction._register_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RegisterGlobalInputFunction>.NativeClassPtr, "<register>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterGlobalInputFunction._register_d__9>.NativeClassPtr);
				RegisterGlobalInputFunction._register_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterGlobalInputFunction._register_d__9>.NativeClassPtr, "<>1__state");
				RegisterGlobalInputFunction._register_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterGlobalInputFunction._register_d__9>.NativeClassPtr, "<>2__current");
				RegisterGlobalInputFunction._register_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterGlobalInputFunction._register_d__9>.NativeClassPtr, "<>4__this");
				RegisterGlobalInputFunction._register_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterGlobalInputFunction._register_d__9>.NativeClassPtr, 100663481);
				RegisterGlobalInputFunction._register_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterGlobalInputFunction._register_d__9>.NativeClassPtr, 100663482);
				RegisterGlobalInputFunction._register_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterGlobalInputFunction._register_d__9>.NativeClassPtr, 100663483);
				RegisterGlobalInputFunction._register_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterGlobalInputFunction._register_d__9>.NativeClassPtr, 100663484);
				RegisterGlobalInputFunction._register_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterGlobalInputFunction._register_d__9>.NativeClassPtr, 100663485);
				RegisterGlobalInputFunction._register_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterGlobalInputFunction._register_d__9>.NativeClassPtr, 100663486);
			}

			// Token: 0x06000888 RID: 2184 RVA: 0x000228DC File Offset: 0x00020ADC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _register_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisterGlobalInputFunction._register_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterGlobalInputFunction._register_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000889 RID: 2185 RVA: 0x00022924 File Offset: 0x00020B24
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterGlobalInputFunction._register_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600088A RID: 2186 RVA: 0x00022958 File Offset: 0x00020B58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120013, XrefRangeEnd = 1120022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterGlobalInputFunction._register_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000275 RID: 629
			// (get) Token: 0x0600088B RID: 2187 RVA: 0x00022994 File Offset: 0x00020B94
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterGlobalInputFunction._register_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600088C RID: 2188 RVA: 0x000229D4 File Offset: 0x00020BD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120022, XrefRangeEnd = 1120027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterGlobalInputFunction._register_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000276 RID: 630
			// (get) Token: 0x0600088D RID: 2189 RVA: 0x00022A08 File Offset: 0x00020C08
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterGlobalInputFunction._register_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600088E RID: 2190 RVA: 0x00006789 File Offset: 0x00004989
			public _register_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000272 RID: 626
			// (get) Token: 0x0600088F RID: 2191 RVA: 0x00022A48 File Offset: 0x00020C48
			// (set) Token: 0x06000890 RID: 2192 RVA: 0x00006792 File Offset: 0x00004992
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterGlobalInputFunction._register_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterGlobalInputFunction._register_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000273 RID: 627
			// (get) Token: 0x06000891 RID: 2193 RVA: 0x00022A70 File Offset: 0x00020C70
			// (set) Token: 0x06000892 RID: 2194 RVA: 0x000067AD File Offset: 0x000049AD
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterGlobalInputFunction._register_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterGlobalInputFunction._register_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000274 RID: 628
			// (get) Token: 0x06000893 RID: 2195 RVA: 0x00022AA0 File Offset: 0x00020CA0
			// (set) Token: 0x06000894 RID: 2196 RVA: 0x000067CC File Offset: 0x000049CC
			public unsafe RegisterGlobalInputFunction __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterGlobalInputFunction._register_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegisterGlobalInputFunction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterGlobalInputFunction._register_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400053C RID: 1340
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400053D RID: 1341
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400053E RID: 1342
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400053F RID: 1343
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000540 RID: 1344
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000541 RID: 1345
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000542 RID: 1346
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000543 RID: 1347
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000544 RID: 1348
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
