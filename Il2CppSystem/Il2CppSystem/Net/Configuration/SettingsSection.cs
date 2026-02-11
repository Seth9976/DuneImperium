using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x02000278 RID: 632
	public sealed class SettingsSection : ConfigurationSection
	{
		// Token: 0x06002979 RID: 10617 RVA: 0x000BBF24 File Offset: 0x000BA124
		// Note: this type is marked as 'beforefieldinit'.
		static SettingsSection()
		{
			Il2CppClassPointerStore<SettingsSection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "SettingsSection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsSection>.NativeClassPtr);
			SettingsSection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSection>.NativeClassPtr, 100669459);
			SettingsSection.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSection>.NativeClassPtr, 100669460);
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x000BBF7C File Offset: 0x000BA17C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494234, XrefRangeEnd = 494237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SettingsSection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsSection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsSection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x0600297B RID: 10619 RVA: 0x000BBFB8 File Offset: 0x000BA1B8
		public unsafe override ConfigurationPropertyCollection Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494237, XrefRangeEnd = 494240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsSection.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x0600297C RID: 10620 RVA: 0x00011D51 File Offset: 0x0000FF51
		public SettingsSection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040020DE RID: 8414
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040020DF RID: 8415
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0;
	}
}
