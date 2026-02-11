using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace dwd.core.Unity.DWD
{
	// Token: 0x0200009E RID: 158
	public static class DWDApplication : global::Il2CppSystem.Object
	{
		// Token: 0x06000AB5 RID: 2741 RVA: 0x0003C3CC File Offset: 0x0003A5CC
		// Note: this type is marked as 'beforefieldinit'.
		static DWDApplication()
		{
			Il2CppClassPointerStore<DWDApplication>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.Unity.DWD", "DWDApplication");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DWDApplication>.NativeClassPtr);
			DWDApplication.NativeMethodInfoPtr_get_persistentDataPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDApplication>.NativeClassPtr, 100664781);
			DWDApplication.NativeMethodInfoPtr_get_isConsolePlatform_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDApplication>.NativeClassPtr, 100664782);
			DWDApplication.NativeMethodInfoPtr_get_internetReachability_Public_Static_get_NetworkReachability_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDApplication>.NativeClassPtr, 100664783);
			DWDApplication.NativeMethodInfoPtr_get_NetworkAvailable_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDApplication>.NativeClassPtr, 100664784);
			DWDApplication.NativeMethodInfoPtr_get_dataPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDApplication>.NativeClassPtr, 100664785);
			DWDApplication.NativeMethodInfoPtr_get_streamingAssetsPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDApplication>.NativeClassPtr, 100664786);
			DWDApplication.NativeMethodInfoPtr_get_isEditor_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDApplication>.NativeClassPtr, 100664787);
			DWDApplication.NativeMethodInfoPtr_get_isMobilePlatform_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDApplication>.NativeClassPtr, 100664788);
			DWDApplication.NativeMethodInfoPtr_get_isDesktop_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDApplication>.NativeClassPtr, 100664789);
			DWDApplication.NativeMethodInfoPtr_IsXbox_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDApplication>.NativeClassPtr, 100664790);
			DWDApplication.NativeMethodInfoPtr_get_platform_Public_Static_get_RuntimePlatform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDApplication>.NativeClassPtr, 100664791);
			DWDApplication.NativeMethodInfoPtr_get_productName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDApplication>.NativeClassPtr, 100664792);
			DWDApplication.NativeMethodInfoPtr_add_logMessageReceivedThreaded_Public_Static_add_Void_LogCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDApplication>.NativeClassPtr, 100664793);
			DWDApplication.NativeMethodInfoPtr_remove_logMessageReceivedThreaded_Public_Static_rem_Void_LogCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDApplication>.NativeClassPtr, 100664794);
			DWDApplication.NativeMethodInfoPtr_get_identifier_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDApplication>.NativeClassPtr, 100664795);
			DWDApplication.NativeMethodInfoPtr_IsStandalonePlayer_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDApplication>.NativeClassPtr, 100664796);
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x0003C53C File Offset: 0x0003A73C
		public unsafe static string persistentDataPath
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 862986, RefRangeEnd = 863005, XrefRangeStart = 862982, XrefRangeEnd = 862986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDApplication.NativeMethodInfoPtr_get_persistentDataPath_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x0003C568 File Offset: 0x0003A768
		public unsafe static bool isConsolePlatform
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 863012, RefRangeEnd = 863014, XrefRangeStart = 863005, XrefRangeEnd = 863012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDApplication.NativeMethodInfoPtr_get_isConsolePlatform_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000AB8 RID: 2744 RVA: 0x0003C598 File Offset: 0x0003A798
		public unsafe static NetworkReachability internetReachability
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 863018, RefRangeEnd = 863019, XrefRangeStart = 863014, XrefRangeEnd = 863018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDApplication.NativeMethodInfoPtr_get_internetReachability_Public_Static_get_NetworkReachability_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x0003C5C8 File Offset: 0x0003A7C8
		public unsafe static bool NetworkAvailable
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 863023, RefRangeEnd = 863026, XrefRangeStart = 863019, XrefRangeEnd = 863023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDApplication.NativeMethodInfoPtr_get_NetworkAvailable_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000ABA RID: 2746 RVA: 0x0003C5F8 File Offset: 0x0003A7F8
		public unsafe static string dataPath
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 863030, RefRangeEnd = 863035, XrefRangeStart = 863026, XrefRangeEnd = 863030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDApplication.NativeMethodInfoPtr_get_dataPath_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x0003C624 File Offset: 0x0003A824
		public unsafe static string streamingAssetsPath
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 863039, RefRangeEnd = 863040, XrefRangeStart = 863035, XrefRangeEnd = 863039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDApplication.NativeMethodInfoPtr_get_streamingAssetsPath_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x0003C650 File Offset: 0x0003A850
		public unsafe static bool isEditor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 863044, RefRangeEnd = 863045, XrefRangeStart = 863040, XrefRangeEnd = 863044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDApplication.NativeMethodInfoPtr_get_isEditor_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000ABD RID: 2749 RVA: 0x0003C680 File Offset: 0x0003A880
		public unsafe static bool isMobilePlatform
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 863046, RefRangeEnd = 863050, XrefRangeStart = 863045, XrefRangeEnd = 863046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDApplication.NativeMethodInfoPtr_get_isMobilePlatform_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x0003C6B0 File Offset: 0x0003A8B0
		public unsafe static bool isDesktop
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 863060, RefRangeEnd = 863061, XrefRangeStart = 863050, XrefRangeEnd = 863060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDApplication.NativeMethodInfoPtr_get_isDesktop_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x0003C6E0 File Offset: 0x0003A8E0
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 863068, RefRangeEnd = 863087, XrefRangeStart = 863061, XrefRangeEnd = 863068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsXbox()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDApplication.NativeMethodInfoPtr_IsXbox_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x0003C710 File Offset: 0x0003A910
		public unsafe static RuntimePlatform platform
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 863091, RefRangeEnd = 863096, XrefRangeStart = 863087, XrefRangeEnd = 863091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDApplication.NativeMethodInfoPtr_get_platform_Public_Static_get_RuntimePlatform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x0003C740 File Offset: 0x0003A940
		public unsafe static string productName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863096, XrefRangeEnd = 863100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDApplication.NativeMethodInfoPtr_get_productName_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x0003C76C File Offset: 0x0003A96C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 863104, RefRangeEnd = 863105, XrefRangeStart = 863100, XrefRangeEnd = 863104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_logMessageReceivedThreaded(Application.LogCallback value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDApplication.NativeMethodInfoPtr_add_logMessageReceivedThreaded_Public_Static_add_Void_LogCallback_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x0003C7A4 File Offset: 0x0003A9A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 863109, RefRangeEnd = 863110, XrefRangeStart = 863105, XrefRangeEnd = 863109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_logMessageReceivedThreaded(Application.LogCallback value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDApplication.NativeMethodInfoPtr_remove_logMessageReceivedThreaded_Public_Static_rem_Void_LogCallback_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x0003C7DC File Offset: 0x0003A9DC
		public unsafe static string identifier
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863110, XrefRangeEnd = 863114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDApplication.NativeMethodInfoPtr_get_identifier_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x0003C808 File Offset: 0x0003AA08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 863124, RefRangeEnd = 863126, XrefRangeStart = 863114, XrefRangeEnd = 863124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsStandalonePlayer()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDApplication.NativeMethodInfoPtr_IsStandalonePlayer_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x00005D12 File Offset: 0x00003F12
		public DWDApplication(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007D1 RID: 2001
		private static readonly IntPtr NativeMethodInfoPtr_get_persistentDataPath_Public_Static_get_String_0;

		// Token: 0x040007D2 RID: 2002
		private static readonly IntPtr NativeMethodInfoPtr_get_isConsolePlatform_Public_Static_get_Boolean_0;

		// Token: 0x040007D3 RID: 2003
		private static readonly IntPtr NativeMethodInfoPtr_get_internetReachability_Public_Static_get_NetworkReachability_0;

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkAvailable_Public_Static_get_Boolean_0;

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeMethodInfoPtr_get_dataPath_Public_Static_get_String_0;

		// Token: 0x040007D6 RID: 2006
		private static readonly IntPtr NativeMethodInfoPtr_get_streamingAssetsPath_Public_Static_get_String_0;

		// Token: 0x040007D7 RID: 2007
		private static readonly IntPtr NativeMethodInfoPtr_get_isEditor_Public_Static_get_Boolean_0;

		// Token: 0x040007D8 RID: 2008
		private static readonly IntPtr NativeMethodInfoPtr_get_isMobilePlatform_Public_Static_get_Boolean_0;

		// Token: 0x040007D9 RID: 2009
		private static readonly IntPtr NativeMethodInfoPtr_get_isDesktop_Public_Static_get_Boolean_0;

		// Token: 0x040007DA RID: 2010
		private static readonly IntPtr NativeMethodInfoPtr_IsXbox_Public_Static_Boolean_0;

		// Token: 0x040007DB RID: 2011
		private static readonly IntPtr NativeMethodInfoPtr_get_platform_Public_Static_get_RuntimePlatform_0;

		// Token: 0x040007DC RID: 2012
		private static readonly IntPtr NativeMethodInfoPtr_get_productName_Public_Static_get_String_0;

		// Token: 0x040007DD RID: 2013
		private static readonly IntPtr NativeMethodInfoPtr_add_logMessageReceivedThreaded_Public_Static_add_Void_LogCallback_0;

		// Token: 0x040007DE RID: 2014
		private static readonly IntPtr NativeMethodInfoPtr_remove_logMessageReceivedThreaded_Public_Static_rem_Void_LogCallback_0;

		// Token: 0x040007DF RID: 2015
		private static readonly IntPtr NativeMethodInfoPtr_get_identifier_Public_Static_get_String_0;

		// Token: 0x040007E0 RID: 2016
		private static readonly IntPtr NativeMethodInfoPtr_IsStandalonePlayer_Public_Static_Boolean_0;
	}
}
