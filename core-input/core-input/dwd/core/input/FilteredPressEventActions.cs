using System;
using dwd.core.conditions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.input
{
	// Token: 0x02000042 RID: 66
	public class FilteredPressEventActions : UnityEventConditions<Press, PressFilter, PressUnityEvent>
	{
		// Token: 0x060001F2 RID: 498 RVA: 0x0000CF14 File Offset: 0x0000B114
		// Note: this type is marked as 'beforefieldinit'.
		static FilteredPressEventActions()
		{
			Il2CppClassPointerStore<FilteredPressEventActions>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input", "FilteredPressEventActions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilteredPressEventActions>.NativeClassPtr);
			FilteredPressEventActions.NativeFieldInfoPtr_handlePressEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilteredPressEventActions>.NativeClassPtr, "handlePressEnd");
			FilteredPressEventActions.NativeFieldInfoPtr_handlePressStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilteredPressEventActions>.NativeClassPtr, "handlePressStart");
			FilteredPressEventActions.NativeFieldInfoPtr_inputManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilteredPressEventActions>.NativeClassPtr, "inputManager");
			FilteredPressEventActions.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteredPressEventActions>.NativeClassPtr, 100663554);
			FilteredPressEventActions.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteredPressEventActions>.NativeClassPtr, 100663555);
			FilteredPressEventActions.NativeMethodInfoPtr_CheckPress_Private_Void_PressEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteredPressEventActions>.NativeClassPtr, 100663556);
			FilteredPressEventActions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteredPressEventActions>.NativeClassPtr, 100663557);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000CFD0 File Offset: 0x0000B1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120368, XrefRangeEnd = 1120389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilteredPressEventActions.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000D004 File Offset: 0x0000B204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120389, XrefRangeEnd = 1120402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilteredPressEventActions.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0000D038 File Offset: 0x0000B238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120402, XrefRangeEnd = 1120412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckPress(PressEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilteredPressEventActions.NativeMethodInfoPtr_CheckPress_Private_Void_PressEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000D07C File Offset: 0x0000B27C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120412, XrefRangeEnd = 1120415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FilteredPressEventActions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilteredPressEventActions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilteredPressEventActions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x000032A4 File Offset: 0x000014A4
		public FilteredPressEventActions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x0000D0B8 File Offset: 0x0000B2B8
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x000032AD File Offset: 0x000014AD
		public unsafe bool handlePressEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilteredPressEventActions.NativeFieldInfoPtr_handlePressEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilteredPressEventActions.NativeFieldInfoPtr_handlePressEnd)) = value;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001FA RID: 506 RVA: 0x0000D0E0 File Offset: 0x0000B2E0
		// (set) Token: 0x060001FB RID: 507 RVA: 0x000032C8 File Offset: 0x000014C8
		public unsafe bool handlePressStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilteredPressEventActions.NativeFieldInfoPtr_handlePressStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilteredPressEventActions.NativeFieldInfoPtr_handlePressStart)) = value;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001FC RID: 508 RVA: 0x0000D108 File Offset: 0x0000B308
		// (set) Token: 0x060001FD RID: 509 RVA: 0x000032E3 File Offset: 0x000014E3
		public unsafe InputManager inputManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilteredPressEventActions.NativeFieldInfoPtr_inputManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilteredPressEventActions.NativeFieldInfoPtr_inputManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeFieldInfoPtr_handlePressEnd;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeFieldInfoPtr_handlePressStart;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeFieldInfoPtr_inputManager;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_CheckPress_Private_Void_PressEvent_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
