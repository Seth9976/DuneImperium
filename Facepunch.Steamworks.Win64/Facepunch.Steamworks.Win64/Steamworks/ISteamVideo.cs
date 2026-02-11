using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Steamworks
{
	// Token: 0x0200002F RID: 47
	public class ISteamVideo : SteamInterface
	{
		// Token: 0x060007D6 RID: 2006 RVA: 0x00040260 File Offset: 0x0003E460
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamVideo()
		{
			Il2CppClassPointerStore<ISteamVideo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "ISteamVideo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamVideo>.NativeClassPtr);
			ISteamVideo.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamVideo>.NativeClassPtr, 100665211);
			ISteamVideo.NativeMethodInfoPtr_SteamAPI_SteamVideo_v002_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamVideo>.NativeClassPtr, 100665212);
			ISteamVideo.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamVideo>.NativeClassPtr, 100665213);
			ISteamVideo.NativeMethodInfoPtr__GetVideoURL_Private_Static_Void_IntPtr_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamVideo>.NativeClassPtr, 100665214);
			ISteamVideo.NativeMethodInfoPtr_GetVideoURL_Internal_Void_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamVideo>.NativeClassPtr, 100665215);
			ISteamVideo.NativeMethodInfoPtr__IsBroadcasting_Private_Static_Boolean_IntPtr_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamVideo>.NativeClassPtr, 100665216);
			ISteamVideo.NativeMethodInfoPtr_IsBroadcasting_Internal_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamVideo>.NativeClassPtr, 100665217);
			ISteamVideo.NativeMethodInfoPtr__GetOPFSettings_Private_Static_Void_IntPtr_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamVideo>.NativeClassPtr, 100665218);
			ISteamVideo.NativeMethodInfoPtr_GetOPFSettings_Internal_Void_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamVideo>.NativeClassPtr, 100665219);
			ISteamVideo.NativeMethodInfoPtr__GetOPFStringForApp_Private_Static_Boolean_IntPtr_AppId_IntPtr_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamVideo>.NativeClassPtr, 100665220);
			ISteamVideo.NativeMethodInfoPtr_GetOPFStringForApp_Internal_Boolean_AppId_byref_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamVideo>.NativeClassPtr, 100665221);
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x0004036C File Offset: 0x0003E56C
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 930944, RefRangeEnd = 930966, XrefRangeStart = 930944, XrefRangeEnd = 930966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamVideo(bool IsGameServer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamVideo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref IsGameServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamVideo.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x000403B4 File Offset: 0x0003E5B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936659, XrefRangeEnd = 936661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SteamAPI_SteamVideo_v002()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamVideo.NativeMethodInfoPtr_SteamAPI_SteamVideo_v002_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x000403E4 File Offset: 0x0003E5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IntPtr GetUserInterfacePointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamVideo.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x0004042C File Offset: 0x0003E62C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936661, XrefRangeEnd = 936663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _GetVideoURL(IntPtr self, AppId unVideoAppID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unVideoAppID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamVideo.NativeMethodInfoPtr__GetVideoURL_Private_Static_Void_IntPtr_AppId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x0004046C File Offset: 0x0003E66C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936663, XrefRangeEnd = 936665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetVideoURL(AppId unVideoAppID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unVideoAppID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamVideo.NativeMethodInfoPtr_GetVideoURL_Internal_Void_AppId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x000404AC File Offset: 0x0003E6AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936665, XrefRangeEnd = 936667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _IsBroadcasting(IntPtr self, ref int pnNumViewers)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnNumViewers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamVideo.NativeMethodInfoPtr__IsBroadcasting_Private_Static_Boolean_IntPtr_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x000404F8 File Offset: 0x0003E6F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 936669, RefRangeEnd = 936671, XrefRangeStart = 936667, XrefRangeEnd = 936669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsBroadcasting(ref int pnNumViewers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pnNumViewers;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamVideo.NativeMethodInfoPtr_IsBroadcasting_Internal_Boolean_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00040544 File Offset: 0x0003E744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936671, XrefRangeEnd = 936673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _GetOPFSettings(IntPtr self, AppId unVideoAppID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unVideoAppID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamVideo.NativeMethodInfoPtr__GetOPFSettings_Private_Static_Void_IntPtr_AppId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00040584 File Offset: 0x0003E784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936673, XrefRangeEnd = 936675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetOPFSettings(AppId unVideoAppID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unVideoAppID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamVideo.NativeMethodInfoPtr_GetOPFSettings_Internal_Void_AppId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x000405C4 File Offset: 0x0003E7C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936675, XrefRangeEnd = 936677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetOPFStringForApp(IntPtr self, AppId unVideoAppID, IntPtr pchBuffer, ref int pnBufferSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unVideoAppID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pchBuffer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnBufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamVideo.NativeMethodInfoPtr__GetOPFStringForApp_Private_Static_Boolean_IntPtr_AppId_IntPtr_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x0004062C File Offset: 0x0003E82C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936677, XrefRangeEnd = 936699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetOPFStringForApp(AppId unVideoAppID, out string pchBuffer, ref int pnBufferSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unVideoAppID;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnBufferSize;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamVideo.NativeMethodInfoPtr_GetOPFStringForApp_Internal_Boolean_AppId_byref_String_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchBuffer = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x00002405 File Offset: 0x00000605
		public ISteamVideo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000841 RID: 2113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x04000842 RID: 2114
		private static readonly IntPtr NativeMethodInfoPtr_SteamAPI_SteamVideo_v002_Internal_Static_IntPtr_0;

		// Token: 0x04000843 RID: 2115
		private static readonly IntPtr NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0;

		// Token: 0x04000844 RID: 2116
		private static readonly IntPtr NativeMethodInfoPtr__GetVideoURL_Private_Static_Void_IntPtr_AppId_0;

		// Token: 0x04000845 RID: 2117
		private static readonly IntPtr NativeMethodInfoPtr_GetVideoURL_Internal_Void_AppId_0;

		// Token: 0x04000846 RID: 2118
		private static readonly IntPtr NativeMethodInfoPtr__IsBroadcasting_Private_Static_Boolean_IntPtr_byref_Int32_0;

		// Token: 0x04000847 RID: 2119
		private static readonly IntPtr NativeMethodInfoPtr_IsBroadcasting_Internal_Boolean_byref_Int32_0;

		// Token: 0x04000848 RID: 2120
		private static readonly IntPtr NativeMethodInfoPtr__GetOPFSettings_Private_Static_Void_IntPtr_AppId_0;

		// Token: 0x04000849 RID: 2121
		private static readonly IntPtr NativeMethodInfoPtr_GetOPFSettings_Internal_Void_AppId_0;

		// Token: 0x0400084A RID: 2122
		private static readonly IntPtr NativeMethodInfoPtr__GetOPFStringForApp_Private_Static_Boolean_IntPtr_AppId_IntPtr_byref_Int32_0;

		// Token: 0x0400084B RID: 2123
		private static readonly IntPtr NativeMethodInfoPtr_GetOPFStringForApp_Internal_Boolean_AppId_byref_String_byref_Int32_0;
	}
}
