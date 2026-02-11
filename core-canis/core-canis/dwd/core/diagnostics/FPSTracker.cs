using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dwd.core.diagnostics
{
	// Token: 0x020001BD RID: 445
	public sealed class FPSTracker : MonoBehaviour
	{
		// Token: 0x060018C7 RID: 6343 RVA: 0x00076AB0 File Offset: 0x00074CB0
		// Note: this type is marked as 'beforefieldinit'.
		static FPSTracker()
		{
			Il2CppClassPointerStore<FPSTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.diagnostics", "FPSTracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FPSTracker>.NativeClassPtr);
			FPSTracker.NativeFieldInfoPtr_elapsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSTracker>.NativeClassPtr, "elapsed");
			FPSTracker.NativeFieldInfoPtr_frameCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSTracker>.NativeClassPtr, "frameCount");
			FPSTracker.NativeFieldInfoPtr__CurrentFps_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSTracker>.NativeClassPtr, "<CurrentFps>k__BackingField");
			FPSTracker.NativeFieldInfoPtr__MinFps_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSTracker>.NativeClassPtr, "<MinFps>k__BackingField");
			FPSTracker.NativeFieldInfoPtr__MaxFps_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSTracker>.NativeClassPtr, "<MaxFps>k__BackingField");
			FPSTracker.NativeMethodInfoPtr_get_CurrentFps_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSTracker>.NativeClassPtr, 100667250);
			FPSTracker.NativeMethodInfoPtr_set_CurrentFps_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSTracker>.NativeClassPtr, 100667251);
			FPSTracker.NativeMethodInfoPtr_get_MinFps_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSTracker>.NativeClassPtr, 100667252);
			FPSTracker.NativeMethodInfoPtr_set_MinFps_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSTracker>.NativeClassPtr, 100667253);
			FPSTracker.NativeMethodInfoPtr_get_MaxFps_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSTracker>.NativeClassPtr, 100667254);
			FPSTracker.NativeMethodInfoPtr_set_MaxFps_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSTracker>.NativeClassPtr, 100667255);
			FPSTracker.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSTracker>.NativeClassPtr, 100667256);
			FPSTracker.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSTracker>.NativeClassPtr, 100667257);
			FPSTracker.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSTracker>.NativeClassPtr, 100667258);
			FPSTracker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSTracker>.NativeClassPtr, 100667259);
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x060018C8 RID: 6344 RVA: 0x00076C0C File Offset: 0x00074E0C
		// (set) Token: 0x060018C9 RID: 6345 RVA: 0x00076C48 File Offset: 0x00074E48
		public unsafe int CurrentFps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FPSTracker.NativeMethodInfoPtr_get_CurrentFps_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FPSTracker.NativeMethodInfoPtr_set_CurrentFps_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x060018CA RID: 6346 RVA: 0x00076C88 File Offset: 0x00074E88
		// (set) Token: 0x060018CB RID: 6347 RVA: 0x00076CC4 File Offset: 0x00074EC4
		public unsafe int MinFps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FPSTracker.NativeMethodInfoPtr_get_MinFps_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FPSTracker.NativeMethodInfoPtr_set_MinFps_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x060018CC RID: 6348 RVA: 0x00076D04 File Offset: 0x00074F04
		// (set) Token: 0x060018CD RID: 6349 RVA: 0x00076D40 File Offset: 0x00074F40
		public unsafe int MaxFps
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FPSTracker.NativeMethodInfoPtr_get_MaxFps_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137951, RefRangeEnd = 137952, XrefRangeStart = 137951, XrefRangeEnd = 137952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FPSTracker.NativeMethodInfoPtr_set_MaxFps_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x00076D80 File Offset: 0x00074F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880734, XrefRangeEnd = 880735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FPSTracker.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x00076DB4 File Offset: 0x00074FB4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 880740, RefRangeEnd = 880744, XrefRangeStart = 880735, XrefRangeEnd = 880740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FPSTracker.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x00076DE8 File Offset: 0x00074FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880744, XrefRangeEnd = 880749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FPSTracker.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D1 RID: 6353 RVA: 0x00076E1C File Offset: 0x0007501C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FPSTracker()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FPSTracker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FPSTracker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x0000AE30 File Offset: 0x00009030
		public FPSTracker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x060018D3 RID: 6355 RVA: 0x00076E58 File Offset: 0x00075058
		// (set) Token: 0x060018D4 RID: 6356 RVA: 0x0000AE39 File Offset: 0x00009039
		public unsafe float elapsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPSTracker.NativeFieldInfoPtr_elapsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPSTracker.NativeFieldInfoPtr_elapsed)) = value;
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x060018D5 RID: 6357 RVA: 0x00076E80 File Offset: 0x00075080
		// (set) Token: 0x060018D6 RID: 6358 RVA: 0x0000AE54 File Offset: 0x00009054
		public unsafe int frameCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPSTracker.NativeFieldInfoPtr_frameCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPSTracker.NativeFieldInfoPtr_frameCount)) = value;
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x060018D7 RID: 6359 RVA: 0x00076EA8 File Offset: 0x000750A8
		// (set) Token: 0x060018D8 RID: 6360 RVA: 0x0000AE6F File Offset: 0x0000906F
		public unsafe int _CurrentFps_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPSTracker.NativeFieldInfoPtr__CurrentFps_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPSTracker.NativeFieldInfoPtr__CurrentFps_k__BackingField)) = value;
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x060018D9 RID: 6361 RVA: 0x00076ED0 File Offset: 0x000750D0
		// (set) Token: 0x060018DA RID: 6362 RVA: 0x0000AE8A File Offset: 0x0000908A
		public unsafe int _MinFps_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPSTracker.NativeFieldInfoPtr__MinFps_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPSTracker.NativeFieldInfoPtr__MinFps_k__BackingField)) = value;
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x060018DB RID: 6363 RVA: 0x00076EF8 File Offset: 0x000750F8
		// (set) Token: 0x060018DC RID: 6364 RVA: 0x0000AEA5 File Offset: 0x000090A5
		public unsafe int _MaxFps_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPSTracker.NativeFieldInfoPtr__MaxFps_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPSTracker.NativeFieldInfoPtr__MaxFps_k__BackingField)) = value;
			}
		}

		// Token: 0x04001177 RID: 4471
		private static readonly IntPtr NativeFieldInfoPtr_elapsed;

		// Token: 0x04001178 RID: 4472
		private static readonly IntPtr NativeFieldInfoPtr_frameCount;

		// Token: 0x04001179 RID: 4473
		private static readonly IntPtr NativeFieldInfoPtr__CurrentFps_k__BackingField;

		// Token: 0x0400117A RID: 4474
		private static readonly IntPtr NativeFieldInfoPtr__MinFps_k__BackingField;

		// Token: 0x0400117B RID: 4475
		private static readonly IntPtr NativeFieldInfoPtr__MaxFps_k__BackingField;

		// Token: 0x0400117C RID: 4476
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentFps_Public_get_Int32_0;

		// Token: 0x0400117D RID: 4477
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentFps_Private_set_Void_Int32_0;

		// Token: 0x0400117E RID: 4478
		private static readonly IntPtr NativeMethodInfoPtr_get_MinFps_Public_get_Int32_0;

		// Token: 0x0400117F RID: 4479
		private static readonly IntPtr NativeMethodInfoPtr_set_MinFps_Private_set_Void_Int32_0;

		// Token: 0x04001180 RID: 4480
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxFps_Public_get_Int32_0;

		// Token: 0x04001181 RID: 4481
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxFps_Private_set_Void_Int32_0;

		// Token: 0x04001182 RID: 4482
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04001183 RID: 4483
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x04001184 RID: 4484
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001185 RID: 4485
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
