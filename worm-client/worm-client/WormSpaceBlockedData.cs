using System;
using Canis.attributes;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x02000018 RID: 24
public class WormSpaceBlockedData : VersionedDataComponent
{
	// Token: 0x060000EC RID: 236 RVA: 0x0001B944 File Offset: 0x00019B44
	// Note: this type is marked as 'beforefieldinit'.
	static WormSpaceBlockedData()
	{
		Il2CppClassPointerStore<WormSpaceBlockedData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "WormSpaceBlockedData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSpaceBlockedData>.NativeClassPtr);
		WormSpaceBlockedData.NativeFieldInfoPtr_blockedAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSpaceBlockedData>.NativeClassPtr, "blockedAttribute");
		WormSpaceBlockedData.NativeMethodInfoPtr_get_Blocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpaceBlockedData>.NativeClassPtr, 100663434);
		WormSpaceBlockedData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpaceBlockedData>.NativeClassPtr, 100663435);
		WormSpaceBlockedData.NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpaceBlockedData>.NativeClassPtr, 100663436);
		WormSpaceBlockedData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSpaceBlockedData>.NativeClassPtr, 100663437);
	}

	// Token: 0x17000041 RID: 65
	// (get) Token: 0x060000ED RID: 237 RVA: 0x0001B9D8 File Offset: 0x00019BD8
	public unsafe bool Blocked
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 687670, RefRangeEnd = 687671, XrefRangeStart = 687666, XrefRangeEnd = 687670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpaceBlockedData.NativeMethodInfoPtr_get_Blocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000042 RID: 66
	// (get) Token: 0x060000EE RID: 238 RVA: 0x0001BA14 File Offset: 0x00019C14
	public unsafe override ulong Version
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687671, XrefRangeEnd = 687674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSpaceBlockedData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060000EF RID: 239 RVA: 0x0001BA5C File Offset: 0x00019C5C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 687681, RefRangeEnd = 687682, XrefRangeStart = 687674, XrefRangeEnd = 687681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WormSpaceBlockedData(AttributeDataComponent attributes)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSpaceBlockedData>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSpaceBlockedData.NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x0001BAA8 File Offset: 0x00019CA8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687682, XrefRangeEnd = 687694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSpaceBlockedData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x060000F1 RID: 241 RVA: 0x00002755 File Offset: 0x00000955
	public WormSpaceBlockedData(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000040 RID: 64
	// (get) Token: 0x060000F2 RID: 242 RVA: 0x0001BAEC File Offset: 0x00019CEC
	// (set) Token: 0x060000F3 RID: 243 RVA: 0x0000275E File Offset: 0x0000095E
	public unsafe IAttribute<Nullable<bool>> blockedAttribute
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpaceBlockedData.NativeFieldInfoPtr_blockedAttribute);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<bool>>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSpaceBlockedData.NativeFieldInfoPtr_blockedAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400008D RID: 141
	private static readonly IntPtr NativeFieldInfoPtr_blockedAttribute;

	// Token: 0x0400008E RID: 142
	private static readonly IntPtr NativeMethodInfoPtr_get_Blocked_Public_get_Boolean_0;

	// Token: 0x0400008F RID: 143
	private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

	// Token: 0x04000090 RID: 144
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0;

	// Token: 0x04000091 RID: 145
	private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
}
