using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace analytics
{
	// Token: 0x02000009 RID: 9
	public class DefaultAnalyticsManager : Object
	{
		// Token: 0x0600002B RID: 43 RVA: 0x00002B90 File Offset: 0x00000D90
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultAnalyticsManager()
		{
			Il2CppClassPointerStore<DefaultAnalyticsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("analytics.dll", "analytics", "DefaultAnalyticsManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultAnalyticsManager>.NativeClassPtr);
			DefaultAnalyticsManager.NativeMethodInfoPtr_logAnalyticsMessage_Public_Virtual_Final_New_Void_IAnalyticsMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultAnalyticsManager>.NativeClassPtr, 100663319);
			DefaultAnalyticsManager.NativeMethodInfoPtr_Enabled_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultAnalyticsManager>.NativeClassPtr, 100663320);
			DefaultAnalyticsManager.NativeMethodInfoPtr_URL_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultAnalyticsManager>.NativeClassPtr, 100663321);
			DefaultAnalyticsManager.NativeMethodInfoPtr_game_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultAnalyticsManager>.NativeClassPtr, 100663322);
			DefaultAnalyticsManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultAnalyticsManager>.NativeClassPtr, 100663323);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002C24 File Offset: 0x00000E24
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void logAnalyticsMessage(IAnalyticsMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultAnalyticsManager.NativeMethodInfoPtr_logAnalyticsMessage_Public_Virtual_Final_New_Void_IAnalyticsMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002C68 File Offset: 0x00000E68
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Enabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultAnalyticsManager.NativeMethodInfoPtr_Enabled_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002CA4 File Offset: 0x00000EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273447, XrefRangeEnd = 1273449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string URL()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultAnalyticsManager.NativeMethodInfoPtr_URL_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002CDC File Offset: 0x00000EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273449, XrefRangeEnd = 1273451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string game()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultAnalyticsManager.NativeMethodInfoPtr_game_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002D14 File Offset: 0x00000F14
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultAnalyticsManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultAnalyticsManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultAnalyticsManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002152 File Offset: 0x00000352
		public DefaultAnalyticsManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_logAnalyticsMessage_Public_Virtual_Final_New_Void_IAnalyticsMessage_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_Enabled_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_URL_Public_Virtual_Final_New_String_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_game_Public_Virtual_Final_New_String_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
