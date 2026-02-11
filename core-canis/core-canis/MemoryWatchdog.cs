using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000029 RID: 41
public sealed class MemoryWatchdog : MonoBehaviour
{
	// Token: 0x060003DF RID: 991 RVA: 0x00022B28 File Offset: 0x00020D28
	// Note: this type is marked as 'beforefieldinit'.
	static MemoryWatchdog()
	{
		Il2CppClassPointerStore<MemoryWatchdog>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "MemoryWatchdog");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoryWatchdog>.NativeClassPtr);
		MemoryWatchdog.NativeFieldInfoPtr_LOW_CPU_FREQUENCY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryWatchdog>.NativeClassPtr, "LOW_CPU_FREQUENCY");
		MemoryWatchdog.NativeFieldInfoPtr_MIN_CPU_FREQUENCY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryWatchdog>.NativeClassPtr, "MIN_CPU_FREQUENCY");
		MemoryWatchdog.NativeFieldInfoPtr_LOW_CORE_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryWatchdog>.NativeClassPtr, "LOW_CORE_COUNT");
		MemoryWatchdog.NativeFieldInfoPtr_lowMemoryMB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryWatchdog>.NativeClassPtr, "lowMemoryMB");
		MemoryWatchdog.NativeFieldInfoPtr_COMMAND_REGISTRY_PURGE_FREQUENCY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryWatchdog>.NativeClassPtr, "COMMAND_REGISTRY_PURGE_FREQUENCY");
		MemoryWatchdog.NativeFieldInfoPtr_forceMinSpec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryWatchdog>.NativeClassPtr, "forceMinSpec");
		MemoryWatchdog.NativeFieldInfoPtr_OnMemoryWarningResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryWatchdog>.NativeClassPtr, "OnMemoryWarningResolution");
		MemoryWatchdog.NativeFieldInfoPtr_OnPostMemoryWarning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryWatchdog>.NativeClassPtr, "OnPostMemoryWarning");
		MemoryWatchdog.NativeFieldInfoPtr_cleanupRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryWatchdog>.NativeClassPtr, "cleanupRunning");
		MemoryWatchdog.NativeFieldInfoPtr_memoryBefore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryWatchdog>.NativeClassPtr, "memoryBefore");
		MemoryWatchdog.NativeFieldInfoPtr_nextCommandRegistryPurge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryWatchdog>.NativeClassPtr, "nextCommandRegistryPurge");
		MemoryWatchdog.NativeMethodInfoPtr_add_OnMemoryWarningResolution_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryWatchdog>.NativeClassPtr, 100663850);
		MemoryWatchdog.NativeMethodInfoPtr_remove_OnMemoryWarningResolution_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryWatchdog>.NativeClassPtr, 100663851);
		MemoryWatchdog.NativeMethodInfoPtr_add_OnPostMemoryWarning_Public_add_Void_Action_1_MemoryCleanupEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryWatchdog>.NativeClassPtr, 100663852);
		MemoryWatchdog.NativeMethodInfoPtr_remove_OnPostMemoryWarning_Public_rem_Void_Action_1_MemoryCleanupEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryWatchdog>.NativeClassPtr, 100663853);
		MemoryWatchdog.NativeMethodInfoPtr_isMemoryMinSpecDevice_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryWatchdog>.NativeClassPtr, 100663854);
		MemoryWatchdog.NativeMethodInfoPtr_IsCpuMinSpecDevice_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryWatchdog>.NativeClassPtr, 100663855);
		MemoryWatchdog.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryWatchdog>.NativeClassPtr, 100663856);
		MemoryWatchdog.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryWatchdog>.NativeClassPtr, 100663857);
		MemoryWatchdog.NativeMethodInfoPtr_SystemMemoryWarning_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryWatchdog>.NativeClassPtr, 100663858);
		MemoryWatchdog.NativeMethodInfoPtr_resourcesUnloadComplete_Private_Void_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryWatchdog>.NativeClassPtr, 100663859);
		MemoryWatchdog.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryWatchdog>.NativeClassPtr, 100663860);
		MemoryWatchdog.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryWatchdog>.NativeClassPtr, 100663861);
	}

	// Token: 0x060003E0 RID: 992 RVA: 0x00022D24 File Offset: 0x00020F24
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855794, XrefRangeEnd = 855798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnMemoryWarningResolution(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryWatchdog.NativeMethodInfoPtr_add_OnMemoryWarningResolution_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060003E1 RID: 993 RVA: 0x00022D68 File Offset: 0x00020F68
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855798, XrefRangeEnd = 855802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnMemoryWarningResolution(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryWatchdog.NativeMethodInfoPtr_remove_OnMemoryWarningResolution_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060003E2 RID: 994 RVA: 0x00022DAC File Offset: 0x00020FAC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 855807, RefRangeEnd = 855808, XrefRangeStart = 855802, XrefRangeEnd = 855807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnPostMemoryWarning(Action<MemoryWatchdog.MemoryCleanupEvent> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryWatchdog.NativeMethodInfoPtr_add_OnPostMemoryWarning_Public_add_Void_Action_1_MemoryCleanupEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060003E3 RID: 995 RVA: 0x00022DF0 File Offset: 0x00020FF0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 855813, RefRangeEnd = 855814, XrefRangeStart = 855808, XrefRangeEnd = 855813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnPostMemoryWarning(Action<MemoryWatchdog.MemoryCleanupEvent> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryWatchdog.NativeMethodInfoPtr_remove_OnPostMemoryWarning_Public_rem_Void_Action_1_MemoryCleanupEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060003E4 RID: 996 RVA: 0x00022E34 File Offset: 0x00021034
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 855814, RefRangeEnd = 855816, XrefRangeStart = 855814, XrefRangeEnd = 855814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isMemoryMinSpecDevice()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryWatchdog.NativeMethodInfoPtr_isMemoryMinSpecDevice_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060003E5 RID: 997 RVA: 0x00022E70 File Offset: 0x00021070
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855816, XrefRangeEnd = 855820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsCpuMinSpecDevice()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryWatchdog.NativeMethodInfoPtr_IsCpuMinSpecDevice_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060003E6 RID: 998 RVA: 0x00022EAC File Offset: 0x000210AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855820, XrefRangeEnd = 855831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryWatchdog.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003E7 RID: 999 RVA: 0x00022EE0 File Offset: 0x000210E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855831, XrefRangeEnd = 855841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryWatchdog.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003E8 RID: 1000 RVA: 0x00022F14 File Offset: 0x00021114
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855841, XrefRangeEnd = 855871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SystemMemoryWarning()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryWatchdog.NativeMethodInfoPtr_SystemMemoryWarning_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003E9 RID: 1001 RVA: 0x00022F48 File Offset: 0x00021148
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855871, XrefRangeEnd = 855895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void resourcesUnloadComplete(AsyncOperation resourcesUnload)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(resourcesUnload);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryWatchdog.NativeMethodInfoPtr_resourcesUnloadComplete_Private_Void_AsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060003EA RID: 1002 RVA: 0x00022F8C File Offset: 0x0002118C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855895, XrefRangeEnd = 855901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryWatchdog.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003EB RID: 1003 RVA: 0x00022FC0 File Offset: 0x000211C0
	[CallerCount(311)]
	[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MemoryWatchdog()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemoryWatchdog>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryWatchdog.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003EC RID: 1004 RVA: 0x00003819 File Offset: 0x00001A19
	public MemoryWatchdog(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700013B RID: 315
	// (get) Token: 0x060003ED RID: 1005 RVA: 0x00022FFC File Offset: 0x000211FC
	// (set) Token: 0x060003EE RID: 1006 RVA: 0x00003822 File Offset: 0x00001A22
	public unsafe static int LOW_CPU_FREQUENCY
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(MemoryWatchdog.NativeFieldInfoPtr_LOW_CPU_FREQUENCY, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(MemoryWatchdog.NativeFieldInfoPtr_LOW_CPU_FREQUENCY, (void*)(&value));
		}
	}

	// Token: 0x1700013C RID: 316
	// (get) Token: 0x060003EF RID: 1007 RVA: 0x00023018 File Offset: 0x00021218
	// (set) Token: 0x060003F0 RID: 1008 RVA: 0x00003830 File Offset: 0x00001A30
	public unsafe static int MIN_CPU_FREQUENCY
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(MemoryWatchdog.NativeFieldInfoPtr_MIN_CPU_FREQUENCY, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(MemoryWatchdog.NativeFieldInfoPtr_MIN_CPU_FREQUENCY, (void*)(&value));
		}
	}

	// Token: 0x1700013D RID: 317
	// (get) Token: 0x060003F1 RID: 1009 RVA: 0x00023034 File Offset: 0x00021234
	// (set) Token: 0x060003F2 RID: 1010 RVA: 0x0000383E File Offset: 0x00001A3E
	public unsafe static int LOW_CORE_COUNT
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(MemoryWatchdog.NativeFieldInfoPtr_LOW_CORE_COUNT, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(MemoryWatchdog.NativeFieldInfoPtr_LOW_CORE_COUNT, (void*)(&value));
		}
	}

	// Token: 0x1700013E RID: 318
	// (get) Token: 0x060003F3 RID: 1011 RVA: 0x00023050 File Offset: 0x00021250
	// (set) Token: 0x060003F4 RID: 1012 RVA: 0x0000384C File Offset: 0x00001A4C
	public unsafe static int lowMemoryMB
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(MemoryWatchdog.NativeFieldInfoPtr_lowMemoryMB, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(MemoryWatchdog.NativeFieldInfoPtr_lowMemoryMB, (void*)(&value));
		}
	}

	// Token: 0x1700013F RID: 319
	// (get) Token: 0x060003F5 RID: 1013 RVA: 0x0002306C File Offset: 0x0002126C
	// (set) Token: 0x060003F6 RID: 1014 RVA: 0x0000385A File Offset: 0x00001A5A
	public unsafe static float COMMAND_REGISTRY_PURGE_FREQUENCY
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(MemoryWatchdog.NativeFieldInfoPtr_COMMAND_REGISTRY_PURGE_FREQUENCY, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(MemoryWatchdog.NativeFieldInfoPtr_COMMAND_REGISTRY_PURGE_FREQUENCY, (void*)(&value));
		}
	}

	// Token: 0x17000140 RID: 320
	// (get) Token: 0x060003F7 RID: 1015 RVA: 0x00023088 File Offset: 0x00021288
	// (set) Token: 0x060003F8 RID: 1016 RVA: 0x00003868 File Offset: 0x00001A68
	public unsafe bool forceMinSpec
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryWatchdog.NativeFieldInfoPtr_forceMinSpec);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryWatchdog.NativeFieldInfoPtr_forceMinSpec)) = value;
		}
	}

	// Token: 0x17000141 RID: 321
	// (get) Token: 0x060003F9 RID: 1017 RVA: 0x000230B0 File Offset: 0x000212B0
	// (set) Token: 0x060003FA RID: 1018 RVA: 0x00003883 File Offset: 0x00001A83
	public unsafe Action OnMemoryWarningResolution
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryWatchdog.NativeFieldInfoPtr_OnMemoryWarningResolution);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryWatchdog.NativeFieldInfoPtr_OnMemoryWarningResolution), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000142 RID: 322
	// (get) Token: 0x060003FB RID: 1019 RVA: 0x000230E0 File Offset: 0x000212E0
	// (set) Token: 0x060003FC RID: 1020 RVA: 0x000038A2 File Offset: 0x00001AA2
	public unsafe Action<MemoryWatchdog.MemoryCleanupEvent> OnPostMemoryWarning
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryWatchdog.NativeFieldInfoPtr_OnPostMemoryWarning);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<MemoryWatchdog.MemoryCleanupEvent>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryWatchdog.NativeFieldInfoPtr_OnPostMemoryWarning), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000143 RID: 323
	// (get) Token: 0x060003FD RID: 1021 RVA: 0x00023110 File Offset: 0x00021310
	// (set) Token: 0x060003FE RID: 1022 RVA: 0x000038C1 File Offset: 0x00001AC1
	public unsafe bool cleanupRunning
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryWatchdog.NativeFieldInfoPtr_cleanupRunning);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryWatchdog.NativeFieldInfoPtr_cleanupRunning)) = value;
		}
	}

	// Token: 0x17000144 RID: 324
	// (get) Token: 0x060003FF RID: 1023 RVA: 0x00023138 File Offset: 0x00021338
	// (set) Token: 0x06000400 RID: 1024 RVA: 0x000038DC File Offset: 0x00001ADC
	public unsafe ulong memoryBefore
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryWatchdog.NativeFieldInfoPtr_memoryBefore);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryWatchdog.NativeFieldInfoPtr_memoryBefore)) = value;
		}
	}

	// Token: 0x17000145 RID: 325
	// (get) Token: 0x06000401 RID: 1025 RVA: 0x00023160 File Offset: 0x00021360
	// (set) Token: 0x06000402 RID: 1026 RVA: 0x000038F7 File Offset: 0x00001AF7
	public unsafe float nextCommandRegistryPurge
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryWatchdog.NativeFieldInfoPtr_nextCommandRegistryPurge);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryWatchdog.NativeFieldInfoPtr_nextCommandRegistryPurge)) = value;
		}
	}

	// Token: 0x040002DA RID: 730
	private static readonly IntPtr NativeFieldInfoPtr_LOW_CPU_FREQUENCY;

	// Token: 0x040002DB RID: 731
	private static readonly IntPtr NativeFieldInfoPtr_MIN_CPU_FREQUENCY;

	// Token: 0x040002DC RID: 732
	private static readonly IntPtr NativeFieldInfoPtr_LOW_CORE_COUNT;

	// Token: 0x040002DD RID: 733
	private static readonly IntPtr NativeFieldInfoPtr_lowMemoryMB;

	// Token: 0x040002DE RID: 734
	private static readonly IntPtr NativeFieldInfoPtr_COMMAND_REGISTRY_PURGE_FREQUENCY;

	// Token: 0x040002DF RID: 735
	private static readonly IntPtr NativeFieldInfoPtr_forceMinSpec;

	// Token: 0x040002E0 RID: 736
	private static readonly IntPtr NativeFieldInfoPtr_OnMemoryWarningResolution;

	// Token: 0x040002E1 RID: 737
	private static readonly IntPtr NativeFieldInfoPtr_OnPostMemoryWarning;

	// Token: 0x040002E2 RID: 738
	private static readonly IntPtr NativeFieldInfoPtr_cleanupRunning;

	// Token: 0x040002E3 RID: 739
	private static readonly IntPtr NativeFieldInfoPtr_memoryBefore;

	// Token: 0x040002E4 RID: 740
	private static readonly IntPtr NativeFieldInfoPtr_nextCommandRegistryPurge;

	// Token: 0x040002E5 RID: 741
	private static readonly IntPtr NativeMethodInfoPtr_add_OnMemoryWarningResolution_Public_add_Void_Action_0;

	// Token: 0x040002E6 RID: 742
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnMemoryWarningResolution_Public_rem_Void_Action_0;

	// Token: 0x040002E7 RID: 743
	private static readonly IntPtr NativeMethodInfoPtr_add_OnPostMemoryWarning_Public_add_Void_Action_1_MemoryCleanupEvent_0;

	// Token: 0x040002E8 RID: 744
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnPostMemoryWarning_Public_rem_Void_Action_1_MemoryCleanupEvent_0;

	// Token: 0x040002E9 RID: 745
	private static readonly IntPtr NativeMethodInfoPtr_isMemoryMinSpecDevice_Public_Boolean_0;

	// Token: 0x040002EA RID: 746
	private static readonly IntPtr NativeMethodInfoPtr_IsCpuMinSpecDevice_Public_Boolean_0;

	// Token: 0x040002EB RID: 747
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x040002EC RID: 748
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x040002ED RID: 749
	private static readonly IntPtr NativeMethodInfoPtr_SystemMemoryWarning_Private_Void_0;

	// Token: 0x040002EE RID: 750
	private static readonly IntPtr NativeMethodInfoPtr_resourcesUnloadComplete_Private_Void_AsyncOperation_0;

	// Token: 0x040002EF RID: 751
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x040002F0 RID: 752
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000239 RID: 569
	[StructLayout(2)]
	public struct MemoryCleanupEvent
	{
		// Token: 0x06001E88 RID: 7816 RVA: 0x0008B810 File Offset: 0x00089A10
		// Note: this type is marked as 'beforefieldinit'.
		static MemoryCleanupEvent()
		{
			Il2CppClassPointerStore<MemoryWatchdog.MemoryCleanupEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MemoryWatchdog>.NativeClassPtr, "MemoryCleanupEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoryWatchdog.MemoryCleanupEvent>.NativeClassPtr);
			MemoryWatchdog.MemoryCleanupEvent.NativeFieldInfoPtr_MemoryBefore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryWatchdog.MemoryCleanupEvent>.NativeClassPtr, "MemoryBefore");
			MemoryWatchdog.MemoryCleanupEvent.NativeFieldInfoPtr_MemoryAfter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryWatchdog.MemoryCleanupEvent>.NativeClassPtr, "MemoryAfter");
			MemoryWatchdog.MemoryCleanupEvent.NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryWatchdog.MemoryCleanupEvent>.NativeClassPtr, 100663862);
		}

		// Token: 0x06001E89 RID: 7817 RVA: 0x0008B878 File Offset: 0x00089A78
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 636721, RefRangeEnd = 636742, XrefRangeStart = 636721, XrefRangeEnd = 636742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemoryCleanupEvent(ulong memoryBefore, ulong memoryAfter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref memoryBefore;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref memoryAfter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryWatchdog.MemoryCleanupEvent.NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E8A RID: 7818 RVA: 0x0000D15E File Offset: 0x0000B35E
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoryWatchdog.MemoryCleanupEvent>.NativeClassPtr, ref this));
		}

		// Token: 0x04001545 RID: 5445
		private static readonly IntPtr NativeFieldInfoPtr_MemoryBefore;

		// Token: 0x04001546 RID: 5446
		private static readonly IntPtr NativeFieldInfoPtr_MemoryAfter;

		// Token: 0x04001547 RID: 5447
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0;

		// Token: 0x04001548 RID: 5448
		[FieldOffset(0)]
		public readonly ulong MemoryBefore;

		// Token: 0x04001549 RID: 5449
		[FieldOffset(8)]
		public readonly ulong MemoryAfter;
	}
}
