using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Events;
using UnityEngine.UI;

namespace dwd.core
{
	// Token: 0x02000028 RID: 40
	public class TryClickButtonOnInput : RegisterGlobalInputFunction
	{
		// Token: 0x0600014E RID: 334 RVA: 0x0000B4D0 File Offset: 0x000096D0
		// Note: this type is marked as 'beforefieldinit'.
		static TryClickButtonOnInput()
		{
			Il2CppClassPointerStore<TryClickButtonOnInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core", "TryClickButtonOnInput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TryClickButtonOnInput>.NativeClassPtr);
			TryClickButtonOnInput.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TryClickButtonOnInput>.NativeClassPtr, "button");
			TryClickButtonOnInput.NativeFieldInfoPtr_ignoreInteractable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TryClickButtonOnInput>.NativeClassPtr, "ignoreInteractable");
			TryClickButtonOnInput.NativeFieldInfoPtr_checkIfValidSelectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TryClickButtonOnInput>.NativeClassPtr, "checkIfValidSelectable");
			TryClickButtonOnInput.NativeFieldInfoPtr_onSuccessEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TryClickButtonOnInput>.NativeClassPtr, "onSuccessEvent");
			TryClickButtonOnInput.NativeFieldInfoPtr_onFailureEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TryClickButtonOnInput>.NativeClassPtr, "onFailureEvent");
			TryClickButtonOnInput.NativeMethodInfoPtr_canExecuteFunction_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TryClickButtonOnInput>.NativeClassPtr, 100663487);
			TryClickButtonOnInput.NativeMethodInfoPtr_onSuccess_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TryClickButtonOnInput>.NativeClassPtr, 100663488);
			TryClickButtonOnInput.NativeMethodInfoPtr_onFailure_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TryClickButtonOnInput>.NativeClassPtr, 100663489);
			TryClickButtonOnInput.NativeMethodInfoPtr_executeFunction_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TryClickButtonOnInput>.NativeClassPtr, 100663490);
			TryClickButtonOnInput.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TryClickButtonOnInput>.NativeClassPtr, 100663491);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000B5C8 File Offset: 0x000097C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120083, XrefRangeEnd = 1120088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool canExecuteFunction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TryClickButtonOnInput.NativeMethodInfoPtr_canExecuteFunction_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000B610 File Offset: 0x00009810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120088, XrefRangeEnd = 1120089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void onSuccess()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TryClickButtonOnInput.NativeMethodInfoPtr_onSuccess_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000B64C File Offset: 0x0000984C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120089, XrefRangeEnd = 1120090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void onFailure()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TryClickButtonOnInput.NativeMethodInfoPtr_onFailure_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000B688 File Offset: 0x00009888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120090, XrefRangeEnd = 1120092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void executeFunction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TryClickButtonOnInput.NativeMethodInfoPtr_executeFunction_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000B6C4 File Offset: 0x000098C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TryClickButtonOnInput()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TryClickButtonOnInput>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TryClickButtonOnInput.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002B12 File Offset: 0x00000D12
		public TryClickButtonOnInput(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000155 RID: 341 RVA: 0x0000B700 File Offset: 0x00009900
		// (set) Token: 0x06000156 RID: 342 RVA: 0x00002B1B File Offset: 0x00000D1B
		public unsafe Button button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryClickButtonOnInput.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryClickButtonOnInput.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000157 RID: 343 RVA: 0x0000B730 File Offset: 0x00009930
		// (set) Token: 0x06000158 RID: 344 RVA: 0x00002B3A File Offset: 0x00000D3A
		public unsafe bool ignoreInteractable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryClickButtonOnInput.NativeFieldInfoPtr_ignoreInteractable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryClickButtonOnInput.NativeFieldInfoPtr_ignoreInteractable)) = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000159 RID: 345 RVA: 0x0000B758 File Offset: 0x00009958
		// (set) Token: 0x0600015A RID: 346 RVA: 0x00002B55 File Offset: 0x00000D55
		public unsafe bool checkIfValidSelectable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryClickButtonOnInput.NativeFieldInfoPtr_checkIfValidSelectable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryClickButtonOnInput.NativeFieldInfoPtr_checkIfValidSelectable)) = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600015B RID: 347 RVA: 0x0000B780 File Offset: 0x00009980
		// (set) Token: 0x0600015C RID: 348 RVA: 0x00002B70 File Offset: 0x00000D70
		public unsafe UnityEvent onSuccessEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryClickButtonOnInput.NativeFieldInfoPtr_onSuccessEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryClickButtonOnInput.NativeFieldInfoPtr_onSuccessEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600015D RID: 349 RVA: 0x0000B7B0 File Offset: 0x000099B0
		// (set) Token: 0x0600015E RID: 350 RVA: 0x00002B8F File Offset: 0x00000D8F
		public unsafe UnityEvent onFailureEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryClickButtonOnInput.NativeFieldInfoPtr_onFailureEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryClickButtonOnInput.NativeFieldInfoPtr_onFailureEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeFieldInfoPtr_ignoreInteractable;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeFieldInfoPtr_checkIfValidSelectable;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeFieldInfoPtr_onSuccessEvent;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeFieldInfoPtr_onFailureEvent;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr_canExecuteFunction_Protected_Virtual_Boolean_0;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_onSuccess_Protected_Virtual_Void_0;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_onFailure_Protected_Virtual_Void_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_executeFunction_Protected_Virtual_Void_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
