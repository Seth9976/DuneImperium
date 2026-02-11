using System;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;

namespace boardgames.match.validators
{
	// Token: 0x0200024F RID: 591
	public class AvailableSelectionValidator : MonoBehaviour
	{
		// Token: 0x06001AE5 RID: 6885 RVA: 0x00075320 File Offset: 0x00073520
		// Note: this type is marked as 'beforefieldinit'.
		static AvailableSelectionValidator()
		{
			Il2CppClassPointerStore<AvailableSelectionValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.validators", "AvailableSelectionValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvailableSelectionValidator>.NativeClassPtr);
			AvailableSelectionValidator.NativeFieldInfoPtr__Valid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvailableSelectionValidator>.NativeClassPtr, "<Valid>k__BackingField");
			AvailableSelectionValidator.NativeFieldInfoPtr_selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvailableSelectionValidator>.NativeClassPtr, "selection");
			AvailableSelectionValidator.NativeFieldInfoPtr_cachedSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvailableSelectionValidator>.NativeClassPtr, "cachedSelection");
			AvailableSelectionValidator.NativeFieldInfoPtr_entityView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvailableSelectionValidator>.NativeClassPtr, "entityView");
			AvailableSelectionValidator.NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvailableSelectionValidator>.NativeClassPtr, 100667588);
			AvailableSelectionValidator.NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvailableSelectionValidator>.NativeClassPtr, 100667589);
			AvailableSelectionValidator.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvailableSelectionValidator>.NativeClassPtr, 100667590);
			AvailableSelectionValidator.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvailableSelectionValidator>.NativeClassPtr, 100667591);
			AvailableSelectionValidator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvailableSelectionValidator>.NativeClassPtr, 100667592);
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06001AE6 RID: 6886 RVA: 0x00075404 File Offset: 0x00073604
		// (set) Token: 0x06001AE7 RID: 6887 RVA: 0x00075440 File Offset: 0x00073640
		public unsafe virtual bool Valid
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvailableSelectionValidator.NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvailableSelectionValidator.NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001AE8 RID: 6888 RVA: 0x00075480 File Offset: 0x00073680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532848, XrefRangeEnd = 532866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvailableSelectionValidator.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x000754B4 File Offset: 0x000736B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532866, XrefRangeEnd = 532878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvailableSelectionValidator.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AEA RID: 6890 RVA: 0x000754E8 File Offset: 0x000736E8
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvailableSelectionValidator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvailableSelectionValidator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvailableSelectionValidator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AEB RID: 6891 RVA: 0x0000EAFF File Offset: 0x0000CCFF
		public AvailableSelectionValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x06001AEC RID: 6892 RVA: 0x00075524 File Offset: 0x00073724
		// (set) Token: 0x06001AED RID: 6893 RVA: 0x0000EB08 File Offset: 0x0000CD08
		public unsafe bool _Valid_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvailableSelectionValidator.NativeFieldInfoPtr__Valid_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvailableSelectionValidator.NativeFieldInfoPtr__Valid_k__BackingField)) = value;
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x06001AEE RID: 6894 RVA: 0x0007554C File Offset: 0x0007374C
		// (set) Token: 0x06001AEF RID: 6895 RVA: 0x0000EB23 File Offset: 0x0000CD23
		public unsafe Selection selection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvailableSelectionValidator.NativeFieldInfoPtr_selection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvailableSelectionValidator.NativeFieldInfoPtr_selection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x06001AF0 RID: 6896 RVA: 0x0007557C File Offset: 0x0007377C
		// (set) Token: 0x06001AF1 RID: 6897 RVA: 0x0000EB42 File Offset: 0x0000CD42
		public unsafe ISelectionNode cachedSelection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvailableSelectionValidator.NativeFieldInfoPtr_cachedSelection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvailableSelectionValidator.NativeFieldInfoPtr_cachedSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06001AF2 RID: 6898 RVA: 0x000755AC File Offset: 0x000737AC
		// (set) Token: 0x06001AF3 RID: 6899 RVA: 0x0000EB61 File Offset: 0x0000CD61
		public unsafe EntityView entityView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvailableSelectionValidator.NativeFieldInfoPtr_entityView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvailableSelectionValidator.NativeFieldInfoPtr_entityView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010CA RID: 4298
		private static readonly IntPtr NativeFieldInfoPtr__Valid_k__BackingField;

		// Token: 0x040010CB RID: 4299
		private static readonly IntPtr NativeFieldInfoPtr_selection;

		// Token: 0x040010CC RID: 4300
		private static readonly IntPtr NativeFieldInfoPtr_cachedSelection;

		// Token: 0x040010CD RID: 4301
		private static readonly IntPtr NativeFieldInfoPtr_entityView;

		// Token: 0x040010CE RID: 4302
		private static readonly IntPtr NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040010CF RID: 4303
		private static readonly IntPtr NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x040010D0 RID: 4304
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040010D1 RID: 4305
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x040010D2 RID: 4306
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
