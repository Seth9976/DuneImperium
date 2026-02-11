using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Events;
using UnityEngine.UI;

namespace dwd.core
{
	// Token: 0x02000029 RID: 41
	public class TryFlipToggleOnInput : RegisterGlobalInputFunction
	{
		// Token: 0x0600015F RID: 351 RVA: 0x0000B7E0 File Offset: 0x000099E0
		// Note: this type is marked as 'beforefieldinit'.
		static TryFlipToggleOnInput()
		{
			Il2CppClassPointerStore<TryFlipToggleOnInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core", "TryFlipToggleOnInput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TryFlipToggleOnInput>.NativeClassPtr);
			TryFlipToggleOnInput.NativeFieldInfoPtr_toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TryFlipToggleOnInput>.NativeClassPtr, "toggle");
			TryFlipToggleOnInput.NativeFieldInfoPtr_onSuccessEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TryFlipToggleOnInput>.NativeClassPtr, "onSuccessEvent");
			TryFlipToggleOnInput.NativeFieldInfoPtr_onFailureEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TryFlipToggleOnInput>.NativeClassPtr, "onFailureEvent");
			TryFlipToggleOnInput.NativeMethodInfoPtr_canExecuteFunction_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TryFlipToggleOnInput>.NativeClassPtr, 100663492);
			TryFlipToggleOnInput.NativeMethodInfoPtr_onSuccess_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TryFlipToggleOnInput>.NativeClassPtr, 100663493);
			TryFlipToggleOnInput.NativeMethodInfoPtr_onFailure_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TryFlipToggleOnInput>.NativeClassPtr, 100663494);
			TryFlipToggleOnInput.NativeMethodInfoPtr_executeFunction_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TryFlipToggleOnInput>.NativeClassPtr, 100663495);
			TryFlipToggleOnInput.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TryFlipToggleOnInput>.NativeClassPtr, 100663496);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000B8B0 File Offset: 0x00009AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120092, XrefRangeEnd = 1120096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool canExecuteFunction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TryFlipToggleOnInput.NativeMethodInfoPtr_canExecuteFunction_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000B8F8 File Offset: 0x00009AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120096, XrefRangeEnd = 1120097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void onSuccess()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TryFlipToggleOnInput.NativeMethodInfoPtr_onSuccess_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000B934 File Offset: 0x00009B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void onFailure()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TryFlipToggleOnInput.NativeMethodInfoPtr_onFailure_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000B970 File Offset: 0x00009B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120097, XrefRangeEnd = 1120099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void executeFunction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TryFlipToggleOnInput.NativeMethodInfoPtr_executeFunction_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000B9AC File Offset: 0x00009BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TryFlipToggleOnInput()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TryFlipToggleOnInput>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TryFlipToggleOnInput.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002BAE File Offset: 0x00000DAE
		public TryFlipToggleOnInput(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000166 RID: 358 RVA: 0x0000B9E8 File Offset: 0x00009BE8
		// (set) Token: 0x06000167 RID: 359 RVA: 0x00002BB7 File Offset: 0x00000DB7
		public unsafe Toggle toggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryFlipToggleOnInput.NativeFieldInfoPtr_toggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryFlipToggleOnInput.NativeFieldInfoPtr_toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000168 RID: 360 RVA: 0x0000BA18 File Offset: 0x00009C18
		// (set) Token: 0x06000169 RID: 361 RVA: 0x00002BD6 File Offset: 0x00000DD6
		public unsafe UnityEvent onSuccessEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryFlipToggleOnInput.NativeFieldInfoPtr_onSuccessEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryFlipToggleOnInput.NativeFieldInfoPtr_onSuccessEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600016A RID: 362 RVA: 0x0000BA48 File Offset: 0x00009C48
		// (set) Token: 0x0600016B RID: 363 RVA: 0x00002BF5 File Offset: 0x00000DF5
		public unsafe UnityEvent onFailureEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryFlipToggleOnInput.NativeFieldInfoPtr_onFailureEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryFlipToggleOnInput.NativeFieldInfoPtr_onFailureEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeFieldInfoPtr_toggle;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeFieldInfoPtr_onSuccessEvent;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeFieldInfoPtr_onFailureEvent;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_canExecuteFunction_Protected_Virtual_Boolean_0;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_onSuccess_Protected_Virtual_Void_0;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr_onFailure_Protected_Virtual_Void_0;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeMethodInfoPtr_executeFunction_Protected_Virtual_Void_0;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
