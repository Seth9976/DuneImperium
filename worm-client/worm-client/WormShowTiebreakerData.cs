using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

// Token: 0x02000017 RID: 23
public class WormShowTiebreakerData : VersionedDataComponent
{
	// Token: 0x060000DD RID: 221 RVA: 0x0001B6AC File Offset: 0x000198AC
	// Note: this type is marked as 'beforefieldinit'.
	static WormShowTiebreakerData()
	{
		Il2CppClassPointerStore<WormShowTiebreakerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "WormShowTiebreakerData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShowTiebreakerData>.NativeClassPtr);
		WormShowTiebreakerData.NativeFieldInfoPtr_showSolari = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowTiebreakerData>.NativeClassPtr, "showSolari");
		WormShowTiebreakerData.NativeFieldInfoPtr_showSpice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowTiebreakerData>.NativeClassPtr, "showSpice");
		WormShowTiebreakerData.NativeFieldInfoPtr_showTroops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowTiebreakerData>.NativeClassPtr, "showTroops");
		WormShowTiebreakerData.NativeFieldInfoPtr_showWater = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowTiebreakerData>.NativeClassPtr, "showWater");
		WormShowTiebreakerData.NativeFieldInfoPtr_showChaumurky = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowTiebreakerData>.NativeClassPtr, "showChaumurky");
		WormShowTiebreakerData.NativeMethodInfoPtr_get_HasTieBreakers_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowTiebreakerData>.NativeClassPtr, 100663431);
		WormShowTiebreakerData.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowTiebreakerData>.NativeClassPtr, 100663432);
		WormShowTiebreakerData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowTiebreakerData>.NativeClassPtr, 100663433);
	}

	// Token: 0x1700003F RID: 63
	// (get) Token: 0x060000DE RID: 222 RVA: 0x0001B77C File Offset: 0x0001997C
	public unsafe bool HasTieBreakers
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 687635, RefRangeEnd = 687636, XrefRangeStart = 687635, XrefRangeEnd = 687635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowTiebreakerData.NativeMethodInfoPtr_get_HasTieBreakers_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060000DF RID: 223 RVA: 0x0001B7B8 File Offset: 0x000199B8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 687637, RefRangeEnd = 687638, XrefRangeStart = 687636, XrefRangeEnd = 687637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WormShowTiebreakerData(bool spice, bool solari, bool water, bool troops, bool chaumurky)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShowTiebreakerData>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref spice;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref solari;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref water;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref troops;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref chaumurky;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowTiebreakerData.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000E0 RID: 224 RVA: 0x0001B838 File Offset: 0x00019A38
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687638, XrefRangeEnd = 687666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormShowTiebreakerData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x060000E1 RID: 225 RVA: 0x000026C5 File Offset: 0x000008C5
	public WormShowTiebreakerData(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700003A RID: 58
	// (get) Token: 0x060000E2 RID: 226 RVA: 0x0001B87C File Offset: 0x00019A7C
	// (set) Token: 0x060000E3 RID: 227 RVA: 0x000026CE File Offset: 0x000008CE
	public unsafe bool showSolari
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowTiebreakerData.NativeFieldInfoPtr_showSolari);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowTiebreakerData.NativeFieldInfoPtr_showSolari)) = value;
		}
	}

	// Token: 0x1700003B RID: 59
	// (get) Token: 0x060000E4 RID: 228 RVA: 0x0001B8A4 File Offset: 0x00019AA4
	// (set) Token: 0x060000E5 RID: 229 RVA: 0x000026E9 File Offset: 0x000008E9
	public unsafe bool showSpice
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowTiebreakerData.NativeFieldInfoPtr_showSpice);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowTiebreakerData.NativeFieldInfoPtr_showSpice)) = value;
		}
	}

	// Token: 0x1700003C RID: 60
	// (get) Token: 0x060000E6 RID: 230 RVA: 0x0001B8CC File Offset: 0x00019ACC
	// (set) Token: 0x060000E7 RID: 231 RVA: 0x00002704 File Offset: 0x00000904
	public unsafe bool showTroops
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowTiebreakerData.NativeFieldInfoPtr_showTroops);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowTiebreakerData.NativeFieldInfoPtr_showTroops)) = value;
		}
	}

	// Token: 0x1700003D RID: 61
	// (get) Token: 0x060000E8 RID: 232 RVA: 0x0001B8F4 File Offset: 0x00019AF4
	// (set) Token: 0x060000E9 RID: 233 RVA: 0x0000271F File Offset: 0x0000091F
	public unsafe bool showWater
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowTiebreakerData.NativeFieldInfoPtr_showWater);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowTiebreakerData.NativeFieldInfoPtr_showWater)) = value;
		}
	}

	// Token: 0x1700003E RID: 62
	// (get) Token: 0x060000EA RID: 234 RVA: 0x0001B91C File Offset: 0x00019B1C
	// (set) Token: 0x060000EB RID: 235 RVA: 0x0000273A File Offset: 0x0000093A
	public unsafe bool showChaumurky
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowTiebreakerData.NativeFieldInfoPtr_showChaumurky);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowTiebreakerData.NativeFieldInfoPtr_showChaumurky)) = value;
		}
	}

	// Token: 0x04000085 RID: 133
	private static readonly IntPtr NativeFieldInfoPtr_showSolari;

	// Token: 0x04000086 RID: 134
	private static readonly IntPtr NativeFieldInfoPtr_showSpice;

	// Token: 0x04000087 RID: 135
	private static readonly IntPtr NativeFieldInfoPtr_showTroops;

	// Token: 0x04000088 RID: 136
	private static readonly IntPtr NativeFieldInfoPtr_showWater;

	// Token: 0x04000089 RID: 137
	private static readonly IntPtr NativeFieldInfoPtr_showChaumurky;

	// Token: 0x0400008A RID: 138
	private static readonly IntPtr NativeMethodInfoPtr_get_HasTieBreakers_Public_get_Boolean_0;

	// Token: 0x0400008B RID: 139
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_Boolean_Boolean_0;

	// Token: 0x0400008C RID: 140
	private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
}
