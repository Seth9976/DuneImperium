using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.core.input.context
{
	// Token: 0x0200007E RID: 126
	public sealed class RegisterGlobalInputActions : MonoBehaviour
	{
		// Token: 0x06000547 RID: 1351 RVA: 0x00017930 File Offset: 0x00015B30
		// Note: this type is marked as 'beforefieldinit'.
		static RegisterGlobalInputActions()
		{
			Il2CppClassPointerStore<RegisterGlobalInputActions>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.context", "RegisterGlobalInputActions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterGlobalInputActions>.NativeClassPtr);
			RegisterGlobalInputActions.NativeFieldInfoPtr_inputActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterGlobalInputActions>.NativeClassPtr, "inputActions");
			RegisterGlobalInputActions.NativeFieldInfoPtr_updatedAfterEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterGlobalInputActions>.NativeClassPtr, "updatedAfterEnable");
			RegisterGlobalInputActions.NativeFieldInfoPtr_registered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterGlobalInputActions>.NativeClassPtr, "registered");
			RegisterGlobalInputActions.NativeMethodInfoPtr_get_InputActions_Public_Virtual_Final_New_get_IEnumerable_1_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterGlobalInputActions>.NativeClassPtr, 100663950);
			RegisterGlobalInputActions.NativeMethodInfoPtr_context_IRegisterInputActions_get_IsGlobal_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterGlobalInputActions>.NativeClassPtr, 100663951);
			RegisterGlobalInputActions.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterGlobalInputActions>.NativeClassPtr, 100663952);
			RegisterGlobalInputActions.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterGlobalInputActions>.NativeClassPtr, 100663953);
			RegisterGlobalInputActions.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterGlobalInputActions>.NativeClassPtr, 100663954);
			RegisterGlobalInputActions.NativeMethodInfoPtr_registerActions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterGlobalInputActions>.NativeClassPtr, 100663955);
			RegisterGlobalInputActions.NativeMethodInfoPtr_unregisterActions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterGlobalInputActions>.NativeClassPtr, 100663956);
			RegisterGlobalInputActions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterGlobalInputActions>.NativeClassPtr, 100663957);
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000548 RID: 1352 RVA: 0x00017A3C File Offset: 0x00015C3C
		public unsafe IEnumerable<InputAction> InputActions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterGlobalInputActions.NativeMethodInfoPtr_get_InputActions_Public_Virtual_Final_New_get_IEnumerable_1_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<InputAction>>(intPtr3) : null;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x00017A7C File Offset: 0x00015C7C
		public unsafe bool context.IRegisterInputActions.IsGlobal
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterGlobalInputActions.NativeMethodInfoPtr_context_IRegisterInputActions_get_IsGlobal_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00017AB8 File Offset: 0x00015CB8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1124192, RefRangeEnd = 1124195, XrefRangeStart = 1124192, XrefRangeEnd = 1124192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterGlobalInputActions.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00017AEC File Offset: 0x00015CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124195, XrefRangeEnd = 1124204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterGlobalInputActions.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00017B20 File Offset: 0x00015D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124204, XrefRangeEnd = 1124223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterGlobalInputActions.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00017B54 File Offset: 0x00015D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124223, XrefRangeEnd = 1124232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void registerActions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterGlobalInputActions.NativeMethodInfoPtr_registerActions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00017B88 File Offset: 0x00015D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124232, XrefRangeEnd = 1124251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void unregisterActions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterGlobalInputActions.NativeMethodInfoPtr_unregisterActions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00017BBC File Offset: 0x00015DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124251, XrefRangeEnd = 1124256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegisterGlobalInputActions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisterGlobalInputActions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterGlobalInputActions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00004ED1 File Offset: 0x000030D1
		public RegisterGlobalInputActions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x00017BF8 File Offset: 0x00015DF8
		// (set) Token: 0x06000552 RID: 1362 RVA: 0x00004EDA File Offset: 0x000030DA
		public unsafe Il2CppReferenceArray<InputAction> inputActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterGlobalInputActions.NativeFieldInfoPtr_inputActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InputAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterGlobalInputActions.NativeFieldInfoPtr_inputActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x00017C28 File Offset: 0x00015E28
		// (set) Token: 0x06000554 RID: 1364 RVA: 0x00004EF9 File Offset: 0x000030F9
		public unsafe bool updatedAfterEnable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterGlobalInputActions.NativeFieldInfoPtr_updatedAfterEnable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterGlobalInputActions.NativeFieldInfoPtr_updatedAfterEnable)) = value;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x00017C50 File Offset: 0x00015E50
		// (set) Token: 0x06000556 RID: 1366 RVA: 0x00004F14 File Offset: 0x00003114
		public unsafe bool registered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterGlobalInputActions.NativeFieldInfoPtr_registered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterGlobalInputActions.NativeFieldInfoPtr_registered)) = value;
			}
		}

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeFieldInfoPtr_inputActions;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeFieldInfoPtr_updatedAfterEnable;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeFieldInfoPtr_registered;

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeMethodInfoPtr_get_InputActions_Public_Virtual_Final_New_get_IEnumerable_1_InputAction_0;

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeMethodInfoPtr_context_IRegisterInputActions_get_IsGlobal_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeMethodInfoPtr_registerActions_Private_Void_0;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeMethodInfoPtr_unregisterActions_Private_Void_0;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
