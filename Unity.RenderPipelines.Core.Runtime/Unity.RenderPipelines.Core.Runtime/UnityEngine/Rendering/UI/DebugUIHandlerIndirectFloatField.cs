using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
	// Token: 0x0200012A RID: 298
	public class DebugUIHandlerIndirectFloatField : DebugUIHandlerWidget
	{
		// Token: 0x06001354 RID: 4948 RVA: 0x00056CD4 File Offset: 0x00054ED4
		// Note: this type is marked as 'beforefieldinit'.
		static DebugUIHandlerIndirectFloatField()
		{
			Il2CppClassPointerStore<DebugUIHandlerIndirectFloatField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.UI", "DebugUIHandlerIndirectFloatField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUIHandlerIndirectFloatField>.NativeClassPtr);
			DebugUIHandlerIndirectFloatField.NativeFieldInfoPtr_nameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerIndirectFloatField>.NativeClassPtr, "nameLabel");
			DebugUIHandlerIndirectFloatField.NativeFieldInfoPtr_valueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerIndirectFloatField>.NativeClassPtr, "valueLabel");
			DebugUIHandlerIndirectFloatField.NativeFieldInfoPtr_getter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerIndirectFloatField>.NativeClassPtr, "getter");
			DebugUIHandlerIndirectFloatField.NativeFieldInfoPtr_setter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerIndirectFloatField>.NativeClassPtr, "setter");
			DebugUIHandlerIndirectFloatField.NativeFieldInfoPtr_incStepGetter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerIndirectFloatField>.NativeClassPtr, "incStepGetter");
			DebugUIHandlerIndirectFloatField.NativeFieldInfoPtr_incStepMultGetter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerIndirectFloatField>.NativeClassPtr, "incStepMultGetter");
			DebugUIHandlerIndirectFloatField.NativeFieldInfoPtr_decimalsGetter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerIndirectFloatField>.NativeClassPtr, "decimalsGetter");
			DebugUIHandlerIndirectFloatField.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerIndirectFloatField>.NativeClassPtr, 100666111);
			DebugUIHandlerIndirectFloatField.NativeMethodInfoPtr_OnSelection_Public_Virtual_Boolean_Boolean_DebugUIHandlerWidget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerIndirectFloatField>.NativeClassPtr, 100666112);
			DebugUIHandlerIndirectFloatField.NativeMethodInfoPtr_OnDeselection_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerIndirectFloatField>.NativeClassPtr, 100666113);
			DebugUIHandlerIndirectFloatField.NativeMethodInfoPtr_OnIncrement_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerIndirectFloatField>.NativeClassPtr, 100666114);
			DebugUIHandlerIndirectFloatField.NativeMethodInfoPtr_OnDecrement_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerIndirectFloatField>.NativeClassPtr, 100666115);
			DebugUIHandlerIndirectFloatField.NativeMethodInfoPtr_ChangeValue_Private_Void_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerIndirectFloatField>.NativeClassPtr, 100666116);
			DebugUIHandlerIndirectFloatField.NativeMethodInfoPtr_UpdateValueLabel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerIndirectFloatField>.NativeClassPtr, 100666117);
			DebugUIHandlerIndirectFloatField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerIndirectFloatField>.NativeClassPtr, 100666118);
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x00056E30 File Offset: 0x00055030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980795, XrefRangeEnd = 980796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerIndirectFloatField.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x00056E64 File Offset: 0x00055064
		[CallerCount(0)]
		public unsafe override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromNext;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(previous);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerIndirectFloatField.NativeMethodInfoPtr_OnSelection_Public_Virtual_Boolean_Boolean_DebugUIHandlerWidget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x00056ECC File Offset: 0x000550CC
		[CallerCount(0)]
		public unsafe override void OnDeselection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerIndirectFloatField.NativeMethodInfoPtr_OnDeselection_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x00056F08 File Offset: 0x00055108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980796, XrefRangeEnd = 980797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnIncrement(bool fast)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fast;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerIndirectFloatField.NativeMethodInfoPtr_OnIncrement_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x00056F54 File Offset: 0x00055154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980797, XrefRangeEnd = 980798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDecrement(bool fast)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fast;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerIndirectFloatField.NativeMethodInfoPtr_OnDecrement_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x00056FA0 File Offset: 0x000551A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 980801, RefRangeEnd = 980803, XrefRangeStart = 980798, XrefRangeEnd = 980801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeValue(bool fast, float multiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fast;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerIndirectFloatField.NativeMethodInfoPtr_ChangeValue_Private_Void_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x00056FEC File Offset: 0x000551EC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 980812, RefRangeEnd = 980818, XrefRangeStart = 980803, XrefRangeEnd = 980812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateValueLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerIndirectFloatField.NativeMethodInfoPtr_UpdateValueLabel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x00057020 File Offset: 0x00055220
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 979810, RefRangeEnd = 979814, XrefRangeStart = 979810, XrefRangeEnd = 979814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugUIHandlerIndirectFloatField()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUIHandlerIndirectFloatField>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerIndirectFloatField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x00009D21 File Offset: 0x00007F21
		public DebugUIHandlerIndirectFloatField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x0600135E RID: 4958 RVA: 0x0005705C File Offset: 0x0005525C
		// (set) Token: 0x0600135F RID: 4959 RVA: 0x00009D2A File Offset: 0x00007F2A
		public unsafe Text nameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerIndirectFloatField.NativeFieldInfoPtr_nameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerIndirectFloatField.NativeFieldInfoPtr_nameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06001360 RID: 4960 RVA: 0x0005708C File Offset: 0x0005528C
		// (set) Token: 0x06001361 RID: 4961 RVA: 0x00009D49 File Offset: 0x00007F49
		public unsafe Text valueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerIndirectFloatField.NativeFieldInfoPtr_valueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerIndirectFloatField.NativeFieldInfoPtr_valueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06001362 RID: 4962 RVA: 0x000570BC File Offset: 0x000552BC
		// (set) Token: 0x06001363 RID: 4963 RVA: 0x00009D68 File Offset: 0x00007F68
		public unsafe Func<float> getter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerIndirectFloatField.NativeFieldInfoPtr_getter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerIndirectFloatField.NativeFieldInfoPtr_getter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06001364 RID: 4964 RVA: 0x000570EC File Offset: 0x000552EC
		// (set) Token: 0x06001365 RID: 4965 RVA: 0x00009D87 File Offset: 0x00007F87
		public unsafe Action<float> setter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerIndirectFloatField.NativeFieldInfoPtr_setter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerIndirectFloatField.NativeFieldInfoPtr_setter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06001366 RID: 4966 RVA: 0x0005711C File Offset: 0x0005531C
		// (set) Token: 0x06001367 RID: 4967 RVA: 0x00009DA6 File Offset: 0x00007FA6
		public unsafe Func<float> incStepGetter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerIndirectFloatField.NativeFieldInfoPtr_incStepGetter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerIndirectFloatField.NativeFieldInfoPtr_incStepGetter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06001368 RID: 4968 RVA: 0x0005714C File Offset: 0x0005534C
		// (set) Token: 0x06001369 RID: 4969 RVA: 0x00009DC5 File Offset: 0x00007FC5
		public unsafe Func<float> incStepMultGetter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerIndirectFloatField.NativeFieldInfoPtr_incStepMultGetter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerIndirectFloatField.NativeFieldInfoPtr_incStepMultGetter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x0600136A RID: 4970 RVA: 0x0005717C File Offset: 0x0005537C
		// (set) Token: 0x0600136B RID: 4971 RVA: 0x00009DE4 File Offset: 0x00007FE4
		public unsafe Func<float> decimalsGetter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerIndirectFloatField.NativeFieldInfoPtr_decimalsGetter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerIndirectFloatField.NativeFieldInfoPtr_decimalsGetter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E5D RID: 3677
		private static readonly IntPtr NativeFieldInfoPtr_nameLabel;

		// Token: 0x04000E5E RID: 3678
		private static readonly IntPtr NativeFieldInfoPtr_valueLabel;

		// Token: 0x04000E5F RID: 3679
		private static readonly IntPtr NativeFieldInfoPtr_getter;

		// Token: 0x04000E60 RID: 3680
		private static readonly IntPtr NativeFieldInfoPtr_setter;

		// Token: 0x04000E61 RID: 3681
		private static readonly IntPtr NativeFieldInfoPtr_incStepGetter;

		// Token: 0x04000E62 RID: 3682
		private static readonly IntPtr NativeFieldInfoPtr_incStepMultGetter;

		// Token: 0x04000E63 RID: 3683
		private static readonly IntPtr NativeFieldInfoPtr_decimalsGetter;

		// Token: 0x04000E64 RID: 3684
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

		// Token: 0x04000E65 RID: 3685
		private static readonly IntPtr NativeMethodInfoPtr_OnSelection_Public_Virtual_Boolean_Boolean_DebugUIHandlerWidget_0;

		// Token: 0x04000E66 RID: 3686
		private static readonly IntPtr NativeMethodInfoPtr_OnDeselection_Public_Virtual_Void_0;

		// Token: 0x04000E67 RID: 3687
		private static readonly IntPtr NativeMethodInfoPtr_OnIncrement_Public_Virtual_Void_Boolean_0;

		// Token: 0x04000E68 RID: 3688
		private static readonly IntPtr NativeMethodInfoPtr_OnDecrement_Public_Virtual_Void_Boolean_0;

		// Token: 0x04000E69 RID: 3689
		private static readonly IntPtr NativeMethodInfoPtr_ChangeValue_Private_Void_Boolean_Single_0;

		// Token: 0x04000E6A RID: 3690
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValueLabel_Private_Void_0;

		// Token: 0x04000E6B RID: 3691
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
