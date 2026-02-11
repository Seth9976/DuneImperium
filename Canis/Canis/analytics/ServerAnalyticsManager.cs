using System;
using analytics;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.analytics
{
	// Token: 0x02000163 RID: 355
	public class ServerAnalyticsManager : Object
	{
		// Token: 0x06000FFD RID: 4093 RVA: 0x0005A588 File Offset: 0x00058788
		// Note: this type is marked as 'beforefieldinit'.
		static ServerAnalyticsManager()
		{
			Il2CppClassPointerStore<ServerAnalyticsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.analytics", "ServerAnalyticsManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerAnalyticsManager>.NativeClassPtr);
			ServerAnalyticsManager.NativeFieldInfoPtr_analyticsURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerAnalyticsManager>.NativeClassPtr, "analyticsURL");
			ServerAnalyticsManager.NativeFieldInfoPtr__game = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerAnalyticsManager>.NativeClassPtr, "_game");
			ServerAnalyticsManager.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerAnalyticsManager>.NativeClassPtr, 100666560);
			ServerAnalyticsManager.NativeMethodInfoPtr_logAnalyticsMessage_Public_Virtual_Final_New_Void_IAnalyticsMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerAnalyticsManager>.NativeClassPtr, 100666561);
			ServerAnalyticsManager.NativeMethodInfoPtr_Enabled_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerAnalyticsManager>.NativeClassPtr, 100666562);
			ServerAnalyticsManager.NativeMethodInfoPtr_URL_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerAnalyticsManager>.NativeClassPtr, 100666563);
			ServerAnalyticsManager.NativeMethodInfoPtr_game_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerAnalyticsManager>.NativeClassPtr, 100666564);
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x0005A644 File Offset: 0x00058844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 578795, XrefRangeEnd = 578802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServerAnalyticsManager(string au, string game)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerAnalyticsManager>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(au);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(game);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerAnalyticsManager.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x0005A6A4 File Offset: 0x000588A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 578802, XrefRangeEnd = 578863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void logAnalyticsMessage(IAnalyticsMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerAnalyticsManager.NativeMethodInfoPtr_logAnalyticsMessage_Public_Virtual_Final_New_Void_IAnalyticsMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x0005A6E8 File Offset: 0x000588E8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Enabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerAnalyticsManager.NativeMethodInfoPtr_Enabled_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x0005A724 File Offset: 0x00058924
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string URL()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerAnalyticsManager.NativeMethodInfoPtr_URL_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x0005A75C File Offset: 0x0005895C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string game()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerAnalyticsManager.NativeMethodInfoPtr_game_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x0000827D File Offset: 0x0000647D
		public ServerAnalyticsManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06001004 RID: 4100 RVA: 0x0005A794 File Offset: 0x00058994
		// (set) Token: 0x06001005 RID: 4101 RVA: 0x00008286 File Offset: 0x00006486
		public unsafe string analyticsURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerAnalyticsManager.NativeFieldInfoPtr_analyticsURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerAnalyticsManager.NativeFieldInfoPtr_analyticsURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06001006 RID: 4102 RVA: 0x0005A7BC File Offset: 0x000589BC
		// (set) Token: 0x06001007 RID: 4103 RVA: 0x000082A5 File Offset: 0x000064A5
		public unsafe string _game
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerAnalyticsManager.NativeFieldInfoPtr__game);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerAnalyticsManager.NativeFieldInfoPtr__game), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000A92 RID: 2706
		private static readonly IntPtr NativeFieldInfoPtr_analyticsURL;

		// Token: 0x04000A93 RID: 2707
		private static readonly IntPtr NativeFieldInfoPtr__game;

		// Token: 0x04000A94 RID: 2708
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04000A95 RID: 2709
		private static readonly IntPtr NativeMethodInfoPtr_logAnalyticsMessage_Public_Virtual_Final_New_Void_IAnalyticsMessage_0;

		// Token: 0x04000A96 RID: 2710
		private static readonly IntPtr NativeMethodInfoPtr_Enabled_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x04000A97 RID: 2711
		private static readonly IntPtr NativeMethodInfoPtr_URL_Public_Virtual_Final_New_String_0;

		// Token: 0x04000A98 RID: 2712
		private static readonly IntPtr NativeMethodInfoPtr_game_Public_Virtual_Final_New_String_0;
	}
}
