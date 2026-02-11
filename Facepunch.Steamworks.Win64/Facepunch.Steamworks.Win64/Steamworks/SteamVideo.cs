using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Steamworks
{
	// Token: 0x020000B3 RID: 179
	public class SteamVideo : SteamClientClass<SteamVideo>
	{
		// Token: 0x06000BB0 RID: 2992 RVA: 0x0004F928 File Offset: 0x0004DB28
		// Note: this type is marked as 'beforefieldinit'.
		static SteamVideo()
		{
			Il2CppClassPointerStore<SteamVideo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "SteamVideo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamVideo>.NativeClassPtr);
			SteamVideo.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamVideo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamVideo>.NativeClassPtr, 100666174);
			SteamVideo.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamVideo>.NativeClassPtr, 100666175);
			SteamVideo.NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamVideo>.NativeClassPtr, 100666176);
			SteamVideo.NativeMethodInfoPtr_get_IsBroadcasting_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamVideo>.NativeClassPtr, 100666177);
			SteamVideo.NativeMethodInfoPtr_get_NumViewers_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamVideo>.NativeClassPtr, 100666178);
			SteamVideo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamVideo>.NativeClassPtr, 100666179);
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000BB1 RID: 2993 RVA: 0x0004F9D0 File Offset: 0x0004DBD0
		public unsafe static ISteamVideo Internal
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 946081, RefRangeEnd = 946083, XrefRangeStart = 946078, XrefRangeEnd = 946081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamVideo.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamVideo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISteamVideo>(intPtr3) : null;
			}
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x0004FA04 File Offset: 0x0004DC04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946083, XrefRangeEnd = 946087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeInterface(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref server;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamVideo.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x0004FA50 File Offset: 0x0004DC50
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InstallEvents()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamVideo.NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000BB4 RID: 2996 RVA: 0x0004FA78 File Offset: 0x0004DC78
		public unsafe static bool IsBroadcasting
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946087, XrefRangeEnd = 946089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamVideo.NativeMethodInfoPtr_get_IsBroadcasting_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x0004FAA8 File Offset: 0x0004DCA8
		public unsafe static int NumViewers
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946089, XrefRangeEnd = 946091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamVideo.NativeMethodInfoPtr_get_NumViewers_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x0004FAD8 File Offset: 0x0004DCD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946091, XrefRangeEnd = 946094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamVideo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamVideo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamVideo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x00002E7E File Offset: 0x0000107E
		public SteamVideo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001247 RID: 4679
		private static readonly IntPtr NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamVideo_0;

		// Token: 0x04001248 RID: 4680
		private static readonly IntPtr NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0;

		// Token: 0x04001249 RID: 4681
		private static readonly IntPtr NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_0;

		// Token: 0x0400124A RID: 4682
		private static readonly IntPtr NativeMethodInfoPtr_get_IsBroadcasting_Public_Static_get_Boolean_0;

		// Token: 0x0400124B RID: 4683
		private static readonly IntPtr NativeMethodInfoPtr_get_NumViewers_Public_Static_get_Int32_0;

		// Token: 0x0400124C RID: 4684
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
