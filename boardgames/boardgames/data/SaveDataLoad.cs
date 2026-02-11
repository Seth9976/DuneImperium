using System;
using Canis;
using dwd.core;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace boardgames.data
{
	// Token: 0x02000146 RID: 326
	public class SaveDataLoad : Object
	{
		// Token: 0x060010AE RID: 4270 RVA: 0x000444BC File Offset: 0x000426BC
		// Note: this type is marked as 'beforefieldinit'.
		static SaveDataLoad()
		{
			Il2CppClassPointerStore<SaveDataLoad>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.data", "SaveDataLoad");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveDataLoad>.NativeClassPtr);
			SaveDataLoad.NativeFieldInfoPtr__Status_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveDataLoad>.NativeClassPtr, "<Status>k__BackingField");
			SaveDataLoad.NativeFieldInfoPtr__Completed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveDataLoad>.NativeClassPtr, "<Completed>k__BackingField");
			SaveDataLoad.NativeFieldInfoPtr__Result_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveDataLoad>.NativeClassPtr, "<Result>k__BackingField");
			SaveDataLoad.NativeMethodInfoPtr_get_Status_Private_get_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveDataLoad>.NativeClassPtr, 100665730);
			SaveDataLoad.NativeMethodInfoPtr_set_Status_Private_set_Void_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveDataLoad>.NativeClassPtr, 100665731);
			SaveDataLoad.NativeMethodInfoPtr_get_Completed_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveDataLoad>.NativeClassPtr, 100665732);
			SaveDataLoad.NativeMethodInfoPtr_get_Result_Public_get_SaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveDataLoad>.NativeClassPtr, 100665733);
			SaveDataLoad.NativeMethodInfoPtr_set_Result_Public_set_Void_SaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveDataLoad>.NativeClassPtr, 100665734);
			SaveDataLoad.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveDataLoad>.NativeClassPtr, 100665735);
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x060010AF RID: 4271 RVA: 0x000445A0 File Offset: 0x000427A0
		// (set) Token: 0x060010B0 RID: 4272 RVA: 0x000445D8 File Offset: 0x000427D8
		public unsafe ErrorInfo Status
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveDataLoad.NativeMethodInfoPtr_get_Status_Private_get_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ErrorInfo(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveDataLoad.NativeMethodInfoPtr_set_Status_Private_set_Void_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x060010B1 RID: 4273 RVA: 0x00044620 File Offset: 0x00042820
		public unsafe bool Completed
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveDataLoad.NativeMethodInfoPtr_get_Completed_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x060010B2 RID: 4274 RVA: 0x0004465C File Offset: 0x0004285C
		// (set) Token: 0x060010B3 RID: 4275 RVA: 0x0004469C File Offset: 0x0004289C
		public unsafe SaveData Result
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveDataLoad.NativeMethodInfoPtr_get_Result_Public_get_SaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SaveData>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveDataLoad.NativeMethodInfoPtr_set_Result_Public_set_Void_SaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x000446E0 File Offset: 0x000428E0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveDataLoad()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveDataLoad>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveDataLoad.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x00009BC3 File Offset: 0x00007DC3
		public SaveDataLoad(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x060010B6 RID: 4278 RVA: 0x0004471C File Offset: 0x0004291C
		// (set) Token: 0x060010B7 RID: 4279 RVA: 0x00009BCC File Offset: 0x00007DCC
		public ErrorInfo _Status_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveDataLoad.NativeFieldInfoPtr__Status_k__BackingField);
				return new ErrorInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveDataLoad.NativeFieldInfoPtr__Status_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x060010B8 RID: 4280 RVA: 0x0004474C File Offset: 0x0004294C
		// (set) Token: 0x060010B9 RID: 4281 RVA: 0x00009BFA File Offset: 0x00007DFA
		public unsafe bool _Completed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveDataLoad.NativeFieldInfoPtr__Completed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveDataLoad.NativeFieldInfoPtr__Completed_k__BackingField)) = value;
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x060010BA RID: 4282 RVA: 0x00044774 File Offset: 0x00042974
		// (set) Token: 0x060010BB RID: 4283 RVA: 0x00009C15 File Offset: 0x00007E15
		public unsafe SaveData _Result_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveDataLoad.NativeFieldInfoPtr__Result_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveDataLoad.NativeFieldInfoPtr__Result_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A29 RID: 2601
		private static readonly IntPtr NativeFieldInfoPtr__Status_k__BackingField;

		// Token: 0x04000A2A RID: 2602
		private static readonly IntPtr NativeFieldInfoPtr__Completed_k__BackingField;

		// Token: 0x04000A2B RID: 2603
		private static readonly IntPtr NativeFieldInfoPtr__Result_k__BackingField;

		// Token: 0x04000A2C RID: 2604
		private static readonly IntPtr NativeMethodInfoPtr_get_Status_Private_get_ErrorInfo_0;

		// Token: 0x04000A2D RID: 2605
		private static readonly IntPtr NativeMethodInfoPtr_set_Status_Private_set_Void_ErrorInfo_0;

		// Token: 0x04000A2E RID: 2606
		private static readonly IntPtr NativeMethodInfoPtr_get_Completed_Private_get_Boolean_0;

		// Token: 0x04000A2F RID: 2607
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_get_SaveData_0;

		// Token: 0x04000A30 RID: 2608
		private static readonly IntPtr NativeMethodInfoPtr_set_Result_Public_set_Void_SaveData_0;

		// Token: 0x04000A31 RID: 2609
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
