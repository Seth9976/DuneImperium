using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x02000003 RID: 3
public class OpenLinkBehaviour : MonoBehaviour
{
	// Token: 0x0600000E RID: 14 RVA: 0x00002C1C File Offset: 0x00000E1C
	// Note: this type is marked as 'beforefieldinit'.
	static OpenLinkBehaviour()
	{
		Il2CppClassPointerStore<OpenLinkBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("UniversalDeepLinking.dll", "", "OpenLinkBehaviour");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OpenLinkBehaviour>.NativeClassPtr);
		OpenLinkBehaviour.NativeFieldInfoPtr_Url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenLinkBehaviour>.NativeClassPtr, "Url");
		OpenLinkBehaviour.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpenLinkBehaviour>.NativeClassPtr, 100663302);
		OpenLinkBehaviour.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpenLinkBehaviour>.NativeClassPtr, 100663303);
		OpenLinkBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpenLinkBehaviour>.NativeClassPtr, 100663304);
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002C9C File Offset: 0x00000E9C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240053, XrefRangeEnd = 1240064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpenLinkBehaviour.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00002CD0 File Offset: 0x00000ED0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240064, XrefRangeEnd = 1240068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Open()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpenLinkBehaviour.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002D04 File Offset: 0x00000F04
	[CallerCount(311)]
	[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OpenLinkBehaviour()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OpenLinkBehaviour>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpenLinkBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000012 RID: 18 RVA: 0x000020B6 File Offset: 0x000002B6
	public OpenLinkBehaviour(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000013 RID: 19 RVA: 0x00002D40 File Offset: 0x00000F40
	// (set) Token: 0x06000014 RID: 20 RVA: 0x000020BF File Offset: 0x000002BF
	public unsafe string Url
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpenLinkBehaviour.NativeFieldInfoPtr_Url);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpenLinkBehaviour.NativeFieldInfoPtr_Url), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000009 RID: 9
	private static readonly IntPtr NativeFieldInfoPtr_Url;

	// Token: 0x0400000A RID: 10
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x0400000B RID: 11
	private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

	// Token: 0x0400000C RID: 12
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
