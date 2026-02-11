using System;
using Canis.attributes;
using Canis.utils.ids;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x02000008 RID: 8
public class MultipleTargetInformation : Object
{
	// Token: 0x0600002D RID: 45 RVA: 0x00006894 File Offset: 0x00004A94
	// Note: this type is marked as 'beforefieldinit'.
	static MultipleTargetInformation()
	{
		Il2CppClassPointerStore<MultipleTargetInformation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "", "MultipleTargetInformation");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultipleTargetInformation>.NativeClassPtr);
		MultipleTargetInformation.NativeFieldInfoPtr_TargetPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleTargetInformation>.NativeClassPtr, "TargetPrompt");
		MultipleTargetInformation.NativeFieldInfoPtr_Targets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleTargetInformation>.NativeClassPtr, "Targets");
		MultipleTargetInformation.NativeFieldInfoPtr_NumberToSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleTargetInformation>.NativeClassPtr, "NumberToSelect");
		MultipleTargetInformation.NativeFieldInfoPtr_MinimumToSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleTargetInformation>.NativeClassPtr, "MinimumToSelect");
		MultipleTargetInformation.NativeFieldInfoPtr_MustBeSelectedAlone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleTargetInformation>.NativeClassPtr, "MustBeSelectedAlone");
		MultipleTargetInformation.NativeFieldInfoPtr_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleTargetInformation>.NativeClassPtr, "AccountID");
		MultipleTargetInformation.NativeFieldInfoPtr_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleTargetInformation>.NativeClassPtr, "Attributes");
		MultipleTargetInformation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleTargetInformation>.NativeClassPtr, 100663307);
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00006964 File Offset: 0x00004B64
	[CallerCount(2676)]
	[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MultipleTargetInformation()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultipleTargetInformation>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleTargetInformation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600002F RID: 47 RVA: 0x0000221B File Offset: 0x0000041B
	public MultipleTargetInformation(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x06000030 RID: 48 RVA: 0x000069A0 File Offset: 0x00004BA0
	// (set) Token: 0x06000031 RID: 49 RVA: 0x00002224 File Offset: 0x00000424
	public unsafe LocalizableTextVariables TargetPrompt
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleTargetInformation.NativeFieldInfoPtr_TargetPrompt);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleTargetInformation.NativeFieldInfoPtr_TargetPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x06000032 RID: 50 RVA: 0x000069D0 File Offset: 0x00004BD0
	// (set) Token: 0x06000033 RID: 51 RVA: 0x00002243 File Offset: 0x00000443
	public unsafe Il2CppReferenceArray<MultiTargetEntity> Targets
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleTargetInformation.NativeFieldInfoPtr_Targets);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MultiTargetEntity>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleTargetInformation.NativeFieldInfoPtr_Targets), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x06000034 RID: 52 RVA: 0x00006A00 File Offset: 0x00004C00
	// (set) Token: 0x06000035 RID: 53 RVA: 0x00002262 File Offset: 0x00000462
	public unsafe int NumberToSelect
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleTargetInformation.NativeFieldInfoPtr_NumberToSelect);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleTargetInformation.NativeFieldInfoPtr_NumberToSelect)) = value;
		}
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x06000036 RID: 54 RVA: 0x00006A28 File Offset: 0x00004C28
	// (set) Token: 0x06000037 RID: 55 RVA: 0x0000227D File Offset: 0x0000047D
	public unsafe int MinimumToSelect
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleTargetInformation.NativeFieldInfoPtr_MinimumToSelect);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleTargetInformation.NativeFieldInfoPtr_MinimumToSelect)) = value;
		}
	}

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x06000038 RID: 56 RVA: 0x00006A50 File Offset: 0x00004C50
	// (set) Token: 0x06000039 RID: 57 RVA: 0x00002298 File Offset: 0x00000498
	public unsafe bool MustBeSelectedAlone
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleTargetInformation.NativeFieldInfoPtr_MustBeSelectedAlone);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleTargetInformation.NativeFieldInfoPtr_MustBeSelectedAlone)) = value;
		}
	}

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x0600003A RID: 58 RVA: 0x00006A78 File Offset: 0x00004C78
	// (set) Token: 0x0600003B RID: 59 RVA: 0x000022B3 File Offset: 0x000004B3
	public unsafe AccountID AccountID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleTargetInformation.NativeFieldInfoPtr_AccountID);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleTargetInformation.NativeFieldInfoPtr_AccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x0600003C RID: 60 RVA: 0x00006AA8 File Offset: 0x00004CA8
	// (set) Token: 0x0600003D RID: 61 RVA: 0x000022D2 File Offset: 0x000004D2
	public unsafe ReadOnlyAttributes Attributes
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleTargetInformation.NativeFieldInfoPtr_Attributes);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleTargetInformation.NativeFieldInfoPtr_Attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000016 RID: 22
	private static readonly IntPtr NativeFieldInfoPtr_TargetPrompt;

	// Token: 0x04000017 RID: 23
	private static readonly IntPtr NativeFieldInfoPtr_Targets;

	// Token: 0x04000018 RID: 24
	private static readonly IntPtr NativeFieldInfoPtr_NumberToSelect;

	// Token: 0x04000019 RID: 25
	private static readonly IntPtr NativeFieldInfoPtr_MinimumToSelect;

	// Token: 0x0400001A RID: 26
	private static readonly IntPtr NativeFieldInfoPtr_MustBeSelectedAlone;

	// Token: 0x0400001B RID: 27
	private static readonly IntPtr NativeFieldInfoPtr_AccountID;

	// Token: 0x0400001C RID: 28
	private static readonly IntPtr NativeFieldInfoPtr_Attributes;

	// Token: 0x0400001D RID: 29
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
