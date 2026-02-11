using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine.UI;

namespace boardgames.ui
{
	// Token: 0x0200011E RID: 286
	public class DirtySelectableValidator : DirtyBehaviour
	{
		// Token: 0x06000ECA RID: 3786 RVA: 0x0003DF28 File Offset: 0x0003C128
		// Note: this type is marked as 'beforefieldinit'.
		static DirtySelectableValidator()
		{
			Il2CppClassPointerStore<DirtySelectableValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.ui", "DirtySelectableValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirtySelectableValidator>.NativeClassPtr);
			DirtySelectableValidator.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirtySelectableValidator>.NativeClassPtr, "type");
			DirtySelectableValidator.NativeFieldInfoPtr_validators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirtySelectableValidator>.NativeClassPtr, "validators");
			DirtySelectableValidator.NativeFieldInfoPtr_selectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirtySelectableValidator>.NativeClassPtr, "selectable");
			DirtySelectableValidator.NativeFieldInfoPtr_updateManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirtySelectableValidator>.NativeClassPtr, "updateManager");
			DirtySelectableValidator.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirtySelectableValidator>.NativeClassPtr, 100665406);
			DirtySelectableValidator.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirtySelectableValidator>.NativeClassPtr, 100665407);
			DirtySelectableValidator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirtySelectableValidator>.NativeClassPtr, 100665408);
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x0003DFE4 File Offset: 0x0003C1E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996779, XrefRangeEnd = 996793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirtySelectableValidator.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x0003E018 File Offset: 0x0003C218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996793, XrefRangeEnd = 996798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DirtySelectableValidator.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x0003E054 File Offset: 0x0003C254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996798, XrefRangeEnd = 996799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DirtySelectableValidator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DirtySelectableValidator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirtySelectableValidator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x00008EC9 File Offset: 0x000070C9
		public DirtySelectableValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000ECF RID: 3791 RVA: 0x0003E090 File Offset: 0x0003C290
		// (set) Token: 0x06000ED0 RID: 3792 RVA: 0x00008ED2 File Offset: 0x000070D2
		public unsafe DirtySelectableValidator.ActiveType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirtySelectableValidator.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirtySelectableValidator.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000ED1 RID: 3793 RVA: 0x0003E0B8 File Offset: 0x0003C2B8
		// (set) Token: 0x06000ED2 RID: 3794 RVA: 0x00008EED File Offset: 0x000070ED
		public unsafe Il2CppReferenceArray<IDirtyValidator> validators
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirtySelectableValidator.NativeFieldInfoPtr_validators);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IDirtyValidator>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirtySelectableValidator.NativeFieldInfoPtr_validators), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000ED3 RID: 3795 RVA: 0x0003E0E8 File Offset: 0x0003C2E8
		// (set) Token: 0x06000ED4 RID: 3796 RVA: 0x00008F0C File Offset: 0x0000710C
		public unsafe Selectable selectable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirtySelectableValidator.NativeFieldInfoPtr_selectable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirtySelectableValidator.NativeFieldInfoPtr_selectable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000ED5 RID: 3797 RVA: 0x0003E118 File Offset: 0x0003C318
		// (set) Token: 0x06000ED6 RID: 3798 RVA: 0x00008F2B File Offset: 0x0000712B
		public unsafe UpdateManager updateManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirtySelectableValidator.NativeFieldInfoPtr_updateManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirtySelectableValidator.NativeFieldInfoPtr_updateManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008EF RID: 2287
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x040008F0 RID: 2288
		private static readonly IntPtr NativeFieldInfoPtr_validators;

		// Token: 0x040008F1 RID: 2289
		private static readonly IntPtr NativeFieldInfoPtr_selectable;

		// Token: 0x040008F2 RID: 2290
		private static readonly IntPtr NativeFieldInfoPtr_updateManager;

		// Token: 0x040008F3 RID: 2291
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040008F4 RID: 2292
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x040008F5 RID: 2293
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200025B RID: 603
		public enum ActiveType
		{
			// Token: 0x040010DC RID: 4316
			Any,
			// Token: 0x040010DD RID: 4317
			All
		}
	}
}
