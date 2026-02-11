using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Steamworks
{
	// Token: 0x0200001C RID: 28
	public class ISteamMatchmakingRulesResponse : SteamInterface
	{
		// Token: 0x06000407 RID: 1031 RVA: 0x00027594 File Offset: 0x00025794
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamMatchmakingRulesResponse()
		{
			Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "ISteamMatchmakingRulesResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr);
			ISteamMatchmakingRulesResponse.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, 100664274);
			ISteamMatchmakingRulesResponse.NativeMethodInfoPtr__RulesResponded_Private_Static_Void_IntPtr_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, 100664275);
			ISteamMatchmakingRulesResponse.NativeMethodInfoPtr_RulesResponded_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, 100664276);
			ISteamMatchmakingRulesResponse.NativeMethodInfoPtr__RulesFailedToRespond_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, 100664277);
			ISteamMatchmakingRulesResponse.NativeMethodInfoPtr_RulesFailedToRespond_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, 100664278);
			ISteamMatchmakingRulesResponse.NativeMethodInfoPtr__RulesRefreshComplete_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, 100664279);
			ISteamMatchmakingRulesResponse.NativeMethodInfoPtr_RulesRefreshComplete_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, 100664280);
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00027650 File Offset: 0x00025850
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 930944, RefRangeEnd = 930966, XrefRangeStart = 930944, XrefRangeEnd = 930966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamMatchmakingRulesResponse(bool IsGameServer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref IsGameServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00027698 File Offset: 0x00025898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933554, XrefRangeEnd = 933559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _RulesResponded(IntPtr self, string pchRule, string pchValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchRule);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.NativeMethodInfoPtr__RulesResponded_Private_Static_Void_IntPtr_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x000276F0 File Offset: 0x000258F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933559, XrefRangeEnd = 933564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RulesResponded(string pchRule, string pchValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchRule);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.NativeMethodInfoPtr_RulesResponded_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00027744 File Offset: 0x00025944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933564, XrefRangeEnd = 933566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _RulesFailedToRespond(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.NativeMethodInfoPtr__RulesFailedToRespond_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00027778 File Offset: 0x00025978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933566, XrefRangeEnd = 933568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RulesFailedToRespond()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.NativeMethodInfoPtr_RulesFailedToRespond_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x000277AC File Offset: 0x000259AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933568, XrefRangeEnd = 933570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _RulesRefreshComplete(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.NativeMethodInfoPtr__RulesRefreshComplete_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x000277E0 File Offset: 0x000259E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933570, XrefRangeEnd = 933572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RulesRefreshComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.NativeMethodInfoPtr_RulesRefreshComplete_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x0000235A File Offset: 0x0000055A
		public ISteamMatchmakingRulesResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000498 RID: 1176
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x04000499 RID: 1177
		private static readonly IntPtr NativeMethodInfoPtr__RulesResponded_Private_Static_Void_IntPtr_String_String_0;

		// Token: 0x0400049A RID: 1178
		private static readonly IntPtr NativeMethodInfoPtr_RulesResponded_Internal_Void_String_String_0;

		// Token: 0x0400049B RID: 1179
		private static readonly IntPtr NativeMethodInfoPtr__RulesFailedToRespond_Private_Static_Void_IntPtr_0;

		// Token: 0x0400049C RID: 1180
		private static readonly IntPtr NativeMethodInfoPtr_RulesFailedToRespond_Internal_Void_0;

		// Token: 0x0400049D RID: 1181
		private static readonly IntPtr NativeMethodInfoPtr__RulesRefreshComplete_Private_Static_Void_IntPtr_0;

		// Token: 0x0400049E RID: 1182
		private static readonly IntPtr NativeMethodInfoPtr_RulesRefreshComplete_Internal_Void_0;
	}
}
