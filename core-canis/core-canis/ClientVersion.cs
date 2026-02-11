using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

// Token: 0x0200003C RID: 60
public static class ClientVersion : Object
{
	// Token: 0x060004CC RID: 1228 RVA: 0x00026690 File Offset: 0x00024890
	// Note: this type is marked as 'beforefieldinit'.
	static ClientVersion()
	{
		Il2CppClassPointerStore<ClientVersion>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "ClientVersion");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientVersion>.NativeClassPtr);
		ClientVersion.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientVersion>.NativeClassPtr, "version");
		ClientVersion.NativeFieldInfoPtr_defaultHeaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientVersion>.NativeClassPtr, "defaultHeaders");
		ClientVersion.NativeMethodInfoPtr_get_Version_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientVersion>.NativeClassPtr, 100663994);
		ClientVersion.NativeMethodInfoPtr_set_Version_Public_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientVersion>.NativeClassPtr, 100663995);
		ClientVersion.NativeMethodInfoPtr_set_Client_Public_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientVersion>.NativeClassPtr, 100663996);
		ClientVersion.NativeMethodInfoPtr_get_Client_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientVersion>.NativeClassPtr, 100663997);
		ClientVersion.NativeMethodInfoPtr_AddClientVersionPlatformInfo_Public_Static_Dictionary_2_String_String_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientVersion>.NativeClassPtr, 100663998);
	}

	// Token: 0x1700016B RID: 363
	// (get) Token: 0x060004CD RID: 1229 RVA: 0x0002674C File Offset: 0x0002494C
	// (set) Token: 0x060004CE RID: 1230 RVA: 0x00026778 File Offset: 0x00024978
	public unsafe static string Version
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857225, XrefRangeEnd = 857229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientVersion.NativeMethodInfoPtr_get_Version_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 857242, RefRangeEnd = 857243, XrefRangeStart = 857229, XrefRangeEnd = 857242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientVersion.NativeMethodInfoPtr_set_Version_Public_Static_set_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x1700016C RID: 364
	// (get) Token: 0x060004D0 RID: 1232 RVA: 0x000267E8 File Offset: 0x000249E8
	// (set) Token: 0x060004CF RID: 1231 RVA: 0x000267B0 File Offset: 0x000249B0
	public unsafe static string Client
	{
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 857264, RefRangeEnd = 857290, XrefRangeStart = 857254, XrefRangeEnd = 857264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientVersion.NativeMethodInfoPtr_get_Client_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 857253, RefRangeEnd = 857254, XrefRangeStart = 857243, XrefRangeEnd = 857253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientVersion.NativeMethodInfoPtr_set_Client_Public_Static_set_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x060004D1 RID: 1233 RVA: 0x00026814 File Offset: 0x00024A14
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 857313, RefRangeEnd = 857318, XrefRangeStart = 857290, XrefRangeEnd = 857313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Dictionary<string, string> AddClientVersionPlatformInfo(this Dictionary<string, string> dict)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dict);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientVersion.NativeMethodInfoPtr_AddClientVersionPlatformInfo_Public_Static_Dictionary_2_String_String_Dictionary_2_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
		}
	}

	// Token: 0x060004D2 RID: 1234 RVA: 0x00003C72 File Offset: 0x00001E72
	public ClientVersion(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000169 RID: 361
	// (get) Token: 0x060004D3 RID: 1235 RVA: 0x00026858 File Offset: 0x00024A58
	// (set) Token: 0x060004D4 RID: 1236 RVA: 0x00003C7B File Offset: 0x00001E7B
	public unsafe static string version
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(ClientVersion.NativeFieldInfoPtr_version, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(ClientVersion.NativeFieldInfoPtr_version, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700016A RID: 362
	// (get) Token: 0x060004D5 RID: 1237 RVA: 0x00026878 File Offset: 0x00024A78
	// (set) Token: 0x060004D6 RID: 1238 RVA: 0x00003C8D File Offset: 0x00001E8D
	public unsafe static Dictionary<string, string> defaultHeaders
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(ClientVersion.NativeFieldInfoPtr_defaultHeaders, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(ClientVersion.NativeFieldInfoPtr_defaultHeaders, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400037F RID: 895
	private static readonly IntPtr NativeFieldInfoPtr_version;

	// Token: 0x04000380 RID: 896
	private static readonly IntPtr NativeFieldInfoPtr_defaultHeaders;

	// Token: 0x04000381 RID: 897
	private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Static_get_String_0;

	// Token: 0x04000382 RID: 898
	private static readonly IntPtr NativeMethodInfoPtr_set_Version_Public_Static_set_Void_String_0;

	// Token: 0x04000383 RID: 899
	private static readonly IntPtr NativeMethodInfoPtr_set_Client_Public_Static_set_Void_String_0;

	// Token: 0x04000384 RID: 900
	private static readonly IntPtr NativeMethodInfoPtr_get_Client_Public_Static_get_String_0;

	// Token: 0x04000385 RID: 901
	private static readonly IntPtr NativeMethodInfoPtr_AddClientVersionPlatformInfo_Public_Static_Dictionary_2_String_String_Dictionary_2_String_String_0;
}
