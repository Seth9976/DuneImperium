using System;
using boardgames.data;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

// Token: 0x02000014 RID: 20
public class WormRivalsSerializedMatchComponent : SerializedMatchComponent
{
	// Token: 0x060000AD RID: 173 RVA: 0x0001AC48 File Offset: 0x00018E48
	// Note: this type is marked as 'beforefieldinit'.
	static WormRivalsSerializedMatchComponent()
	{
		Il2CppClassPointerStore<WormRivalsSerializedMatchComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "WormRivalsSerializedMatchComponent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormRivalsSerializedMatchComponent>.NativeClassPtr);
		WormRivalsSerializedMatchComponent.NativeMethodInfoPtr__ctor_Public_Void_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRivalsSerializedMatchComponent>.NativeClassPtr, 100663403);
		WormRivalsSerializedMatchComponent.NativeMethodInfoPtr_get_IsClientConfigurable_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRivalsSerializedMatchComponent>.NativeClassPtr, 100663404);
	}

	// Token: 0x060000AE RID: 174 RVA: 0x0001ACA0 File Offset: 0x00018EA0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687504, XrefRangeEnd = 687505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WormRivalsSerializedMatchComponent(MatchInitData matchInitData)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormRivalsSerializedMatchComponent>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchInitData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRivalsSerializedMatchComponent.NativeMethodInfoPtr__ctor_Public_Void_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x060000AF RID: 175 RVA: 0x0001ACEC File Offset: 0x00018EEC
	public unsafe override bool IsClientConfigurable
	{
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormRivalsSerializedMatchComponent.NativeMethodInfoPtr_get_IsClientConfigurable_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x00002574 File Offset: 0x00000774
	public WormRivalsSerializedMatchComponent(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000065 RID: 101
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MatchInitData_0;

	// Token: 0x04000066 RID: 102
	private static readonly IntPtr NativeMethodInfoPtr_get_IsClientConfigurable_Public_Virtual_get_Boolean_0;
}
