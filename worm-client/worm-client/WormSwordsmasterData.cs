using System;
using Canis.attributes;
using dwd.core.data.composition;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x02000019 RID: 25
public class WormSwordsmasterData : VersionedDataComponent
{
	// Token: 0x060000F4 RID: 244 RVA: 0x0001BB1C File Offset: 0x00019D1C
	// Note: this type is marked as 'beforefieldinit'.
	static WormSwordsmasterData()
	{
		Il2CppClassPointerStore<WormSwordsmasterData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "WormSwordsmasterData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSwordsmasterData>.NativeClassPtr);
		WormSwordsmasterData.NativeFieldInfoPtr_swordsmasterAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSwordsmasterData>.NativeClassPtr, "swordsmasterAttribute");
		WormSwordsmasterData.NativeMethodInfoPtr_get_Swordsmaster_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSwordsmasterData>.NativeClassPtr, 100663438);
		WormSwordsmasterData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSwordsmasterData>.NativeClassPtr, 100663439);
		WormSwordsmasterData.NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSwordsmasterData>.NativeClassPtr, 100663440);
	}

	// Token: 0x17000044 RID: 68
	// (get) Token: 0x060000F5 RID: 245 RVA: 0x0001BB9C File Offset: 0x00019D9C
	public unsafe bool Swordsmaster
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687694, XrefRangeEnd = 687698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSwordsmasterData.NativeMethodInfoPtr_get_Swordsmaster_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000045 RID: 69
	// (get) Token: 0x060000F6 RID: 246 RVA: 0x0001BBD8 File Offset: 0x00019DD8
	public unsafe override ulong Version
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687698, XrefRangeEnd = 687702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSwordsmasterData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060000F7 RID: 247 RVA: 0x0001BC20 File Offset: 0x00019E20
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 687709, RefRangeEnd = 687710, XrefRangeStart = 687702, XrefRangeEnd = 687709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WormSwordsmasterData(EntityComponent entityComponent)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSwordsmasterData>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityComponent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSwordsmasterData.NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060000F8 RID: 248 RVA: 0x0000277D File Offset: 0x0000097D
	public WormSwordsmasterData(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000043 RID: 67
	// (get) Token: 0x060000F9 RID: 249 RVA: 0x0001BC6C File Offset: 0x00019E6C
	// (set) Token: 0x060000FA RID: 250 RVA: 0x00002786 File Offset: 0x00000986
	public unsafe IAttribute<Nullable<bool>> swordsmasterAttribute
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSwordsmasterData.NativeFieldInfoPtr_swordsmasterAttribute);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<bool>>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSwordsmasterData.NativeFieldInfoPtr_swordsmasterAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000092 RID: 146
	private static readonly IntPtr NativeFieldInfoPtr_swordsmasterAttribute;

	// Token: 0x04000093 RID: 147
	private static readonly IntPtr NativeMethodInfoPtr_get_Swordsmaster_Public_get_Boolean_0;

	// Token: 0x04000094 RID: 148
	private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

	// Token: 0x04000095 RID: 149
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_0;
}
