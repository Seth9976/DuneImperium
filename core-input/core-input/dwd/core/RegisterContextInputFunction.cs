using System;
using dwd.core.input.context;
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
	// Token: 0x02000026 RID: 38
	public class RegisterContextInputFunction : UIBehaviour
	{
		// Token: 0x06000121 RID: 289 RVA: 0x0000AAD4 File Offset: 0x00008CD4
		// Note: this type is marked as 'beforefieldinit'.
		static RegisterContextInputFunction()
		{
			Il2CppClassPointerStore<RegisterContextInputFunction>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core", "RegisterContextInputFunction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterContextInputFunction>.NativeClassPtr);
			RegisterContextInputFunction.NativeFieldInfoPtr_inputId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterContextInputFunction>.NativeClassPtr, "inputId");
			RegisterContextInputFunction.NativeFieldInfoPtr_inputPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterContextInputFunction>.NativeClassPtr, "inputPriority");
			RegisterContextInputFunction.NativeFieldInfoPtr_createInputContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterContextInputFunction>.NativeClassPtr, "createInputContext");
			RegisterContextInputFunction.NativeFieldInfoPtr_registeredContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterContextInputFunction>.NativeClassPtr, "registeredContext");
			RegisterContextInputFunction.NativeFieldInfoPtr_registerRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterContextInputFunction>.NativeClassPtr, "registerRoutine");
			RegisterContextInputFunction.NativeFieldInfoPtr_registeredAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterContextInputFunction>.NativeClassPtr, "registeredAction");
			RegisterContextInputFunction.NativeMethodInfoPtr_context_IRegisterInputActions_get_InputActions_Private_Virtual_Final_New_get_IEnumerable_1_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterContextInputFunction>.NativeClassPtr, 100663452);
			RegisterContextInputFunction.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterContextInputFunction>.NativeClassPtr, 100663453);
			RegisterContextInputFunction.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterContextInputFunction>.NativeClassPtr, 100663454);
			RegisterContextInputFunction.NativeMethodInfoPtr_register_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterContextInputFunction>.NativeClassPtr, 100663455);
			RegisterContextInputFunction.NativeMethodInfoPtr_unregister_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterContextInputFunction>.NativeClassPtr, 100663456);
			RegisterContextInputFunction.NativeMethodInfoPtr_execute_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterContextInputFunction>.NativeClassPtr, 100663457);
			RegisterContextInputFunction.NativeMethodInfoPtr_canExecuteFunction_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterContextInputFunction>.NativeClassPtr, 100663458);
			RegisterContextInputFunction.NativeMethodInfoPtr_onSuccess_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterContextInputFunction>.NativeClassPtr, 100663459);
			RegisterContextInputFunction.NativeMethodInfoPtr_onFailure_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterContextInputFunction>.NativeClassPtr, 100663460);
			RegisterContextInputFunction.NativeMethodInfoPtr_executeFunction_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterContextInputFunction>.NativeClassPtr, 100663461);
			RegisterContextInputFunction.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterContextInputFunction>.NativeClassPtr, 100663462);
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000122 RID: 290 RVA: 0x0000AC58 File Offset: 0x00008E58
		public unsafe virtual IEnumerable<InputAction> context.IRegisterInputActions.InputActions
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119969, XrefRangeEnd = 1119975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterContextInputFunction.NativeMethodInfoPtr_context_IRegisterInputActions_get_InputActions_Private_Virtual_Final_New_get_IEnumerable_1_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<InputAction>>(intPtr3) : null;
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000AC98 File Offset: 0x00008E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119975, XrefRangeEnd = 1119982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegisterContextInputFunction.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000ACD4 File Offset: 0x00008ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119982, XrefRangeEnd = 1119994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegisterContextInputFunction.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000AD10 File Offset: 0x00008F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119994, XrefRangeEnd = 1119999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator register()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterContextInputFunction.NativeMethodInfoPtr_register_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000AD50 File Offset: 0x00008F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119999, XrefRangeEnd = 1120009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void unregister()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterContextInputFunction.NativeMethodInfoPtr_unregister_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000AD84 File Offset: 0x00008F84
		[CallerCount(0)]
		public unsafe void execute(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterContextInputFunction.NativeMethodInfoPtr_execute_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000ADC4 File Offset: 0x00008FC4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool canExecuteFunction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegisterContextInputFunction.NativeMethodInfoPtr_canExecuteFunction_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000AE0C File Offset: 0x0000900C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void onSuccess()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegisterContextInputFunction.NativeMethodInfoPtr_onSuccess_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0000AE48 File Offset: 0x00009048
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void onFailure()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegisterContextInputFunction.NativeMethodInfoPtr_onFailure_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0000AE84 File Offset: 0x00009084
		[CallerCount(0)]
		public unsafe virtual void executeFunction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegisterContextInputFunction.NativeMethodInfoPtr_executeFunction_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0000AEC0 File Offset: 0x000090C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120009, XrefRangeEnd = 1120013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegisterContextInputFunction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisterContextInputFunction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterContextInputFunction.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000029ED File Offset: 0x00000BED
		public RegisterContextInputFunction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600012E RID: 302 RVA: 0x0000AEFC File Offset: 0x000090FC
		// (set) Token: 0x0600012F RID: 303 RVA: 0x000029F6 File Offset: 0x00000BF6
		public unsafe string inputId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterContextInputFunction.NativeFieldInfoPtr_inputId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterContextInputFunction.NativeFieldInfoPtr_inputId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000130 RID: 304 RVA: 0x0000AF24 File Offset: 0x00009124
		// (set) Token: 0x06000131 RID: 305 RVA: 0x00002A15 File Offset: 0x00000C15
		public unsafe int inputPriority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterContextInputFunction.NativeFieldInfoPtr_inputPriority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterContextInputFunction.NativeFieldInfoPtr_inputPriority)) = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000132 RID: 306 RVA: 0x0000AF4C File Offset: 0x0000914C
		// (set) Token: 0x06000133 RID: 307 RVA: 0x00002A30 File Offset: 0x00000C30
		public unsafe CreateInputContext createInputContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterContextInputFunction.NativeFieldInfoPtr_createInputContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreateInputContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterContextInputFunction.NativeFieldInfoPtr_createInputContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000134 RID: 308 RVA: 0x0000AF7C File Offset: 0x0000917C
		// (set) Token: 0x06000135 RID: 309 RVA: 0x00002A4F File Offset: 0x00000C4F
		public unsafe InputContext registeredContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterContextInputFunction.NativeFieldInfoPtr_registeredContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterContextInputFunction.NativeFieldInfoPtr_registeredContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000136 RID: 310 RVA: 0x0000AFAC File Offset: 0x000091AC
		// (set) Token: 0x06000137 RID: 311 RVA: 0x00002A6E File Offset: 0x00000C6E
		public unsafe Coroutine registerRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterContextInputFunction.NativeFieldInfoPtr_registerRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterContextInputFunction.NativeFieldInfoPtr_registerRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000138 RID: 312 RVA: 0x0000AFDC File Offset: 0x000091DC
		// (set) Token: 0x06000139 RID: 313 RVA: 0x00002A8D File Offset: 0x00000C8D
		public unsafe InputAction registeredAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterContextInputFunction.NativeFieldInfoPtr_registeredAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterContextInputFunction.NativeFieldInfoPtr_registeredAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeFieldInfoPtr_inputId;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeFieldInfoPtr_inputPriority;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeFieldInfoPtr_createInputContext;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeFieldInfoPtr_registeredContext;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeFieldInfoPtr_registerRoutine;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeFieldInfoPtr_registeredAction;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_context_IRegisterInputActions_get_InputActions_Private_Virtual_Final_New_get_IEnumerable_1_InputAction_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_register_Private_IEnumerator_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_unregister_Private_Void_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_execute_Private_Void_Single_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_canExecuteFunction_Protected_Virtual_New_Boolean_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_onSuccess_Protected_Virtual_New_Void_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_onFailure_Protected_Virtual_New_Void_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_executeFunction_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020000BC RID: 188
		[ObfuscatedName("dwd.core.RegisterContextInputFunction+<register>d__10")]
		public sealed class _register_d__10 : global::Il2CppSystem.Object
		{
			// Token: 0x06000879 RID: 2169 RVA: 0x00022528 File Offset: 0x00020728
			// Note: this type is marked as 'beforefieldinit'.
			static _register_d__10()
			{
				Il2CppClassPointerStore<RegisterContextInputFunction._register_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RegisterContextInputFunction>.NativeClassPtr, "<register>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterContextInputFunction._register_d__10>.NativeClassPtr);
				RegisterContextInputFunction._register_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterContextInputFunction._register_d__10>.NativeClassPtr, "<>1__state");
				RegisterContextInputFunction._register_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterContextInputFunction._register_d__10>.NativeClassPtr, "<>2__current");
				RegisterContextInputFunction._register_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterContextInputFunction._register_d__10>.NativeClassPtr, "<>4__this");
				RegisterContextInputFunction._register_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterContextInputFunction._register_d__10>.NativeClassPtr, 100663463);
				RegisterContextInputFunction._register_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterContextInputFunction._register_d__10>.NativeClassPtr, 100663464);
				RegisterContextInputFunction._register_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterContextInputFunction._register_d__10>.NativeClassPtr, 100663465);
				RegisterContextInputFunction._register_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterContextInputFunction._register_d__10>.NativeClassPtr, 100663466);
				RegisterContextInputFunction._register_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterContextInputFunction._register_d__10>.NativeClassPtr, 100663467);
				RegisterContextInputFunction._register_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterContextInputFunction._register_d__10>.NativeClassPtr, 100663468);
			}

			// Token: 0x0600087A RID: 2170 RVA: 0x00022608 File Offset: 0x00020808
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _register_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisterContextInputFunction._register_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterContextInputFunction._register_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600087B RID: 2171 RVA: 0x00022650 File Offset: 0x00020850
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterContextInputFunction._register_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600087C RID: 2172 RVA: 0x00022684 File Offset: 0x00020884
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119955, XrefRangeEnd = 1119964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterContextInputFunction._register_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000270 RID: 624
			// (get) Token: 0x0600087D RID: 2173 RVA: 0x000226C0 File Offset: 0x000208C0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterContextInputFunction._register_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600087E RID: 2174 RVA: 0x00022700 File Offset: 0x00020900
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119964, XrefRangeEnd = 1119969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterContextInputFunction._register_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000271 RID: 625
			// (get) Token: 0x0600087F RID: 2175 RVA: 0x00022734 File Offset: 0x00020934
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterContextInputFunction._register_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000880 RID: 2176 RVA: 0x00006727 File Offset: 0x00004927
			public _register_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700026D RID: 621
			// (get) Token: 0x06000881 RID: 2177 RVA: 0x00022774 File Offset: 0x00020974
			// (set) Token: 0x06000882 RID: 2178 RVA: 0x00006730 File Offset: 0x00004930
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterContextInputFunction._register_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterContextInputFunction._register_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700026E RID: 622
			// (get) Token: 0x06000883 RID: 2179 RVA: 0x0002279C File Offset: 0x0002099C
			// (set) Token: 0x06000884 RID: 2180 RVA: 0x0000674B File Offset: 0x0000494B
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterContextInputFunction._register_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterContextInputFunction._register_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700026F RID: 623
			// (get) Token: 0x06000885 RID: 2181 RVA: 0x000227CC File Offset: 0x000209CC
			// (set) Token: 0x06000886 RID: 2182 RVA: 0x0000676A File Offset: 0x0000496A
			public unsafe RegisterContextInputFunction __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterContextInputFunction._register_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegisterContextInputFunction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterContextInputFunction._register_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000533 RID: 1331
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000534 RID: 1332
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000535 RID: 1333
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000536 RID: 1334
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000537 RID: 1335
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000538 RID: 1336
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000539 RID: 1337
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400053A RID: 1338
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400053B RID: 1339
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
