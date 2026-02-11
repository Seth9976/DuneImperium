using System;
using dwd.core.settings.config;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace lotus.src.cheats
{
	// Token: 0x020000F9 RID: 249
	public class LogAutoOpenWithConfig : LogAutoOpen
	{
		// Token: 0x06000C06 RID: 3078 RVA: 0x00037470 File Offset: 0x00035670
		// Note: this type is marked as 'beforefieldinit'.
		static LogAutoOpenWithConfig()
		{
			Il2CppClassPointerStore<LogAutoOpenWithConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus.src.cheats", "LogAutoOpenWithConfig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogAutoOpenWithConfig>.NativeClassPtr);
			LogAutoOpenWithConfig.NativeFieldInfoPtr_disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogAutoOpenWithConfig>.NativeClassPtr, "disabled");
			LogAutoOpenWithConfig.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogAutoOpenWithConfig>.NativeClassPtr, 100665213);
			LogAutoOpenWithConfig.NativeMethodInfoPtr_get_shouldOpen_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogAutoOpenWithConfig>.NativeClassPtr, 100665214);
			LogAutoOpenWithConfig.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogAutoOpenWithConfig>.NativeClassPtr, 100665215);
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x000374F0 File Offset: 0x000356F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995213, XrefRangeEnd = 995221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogAutoOpenWithConfig.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000C08 RID: 3080 RVA: 0x00037524 File Offset: 0x00035724
		public unsafe override bool shouldOpen
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995221, XrefRangeEnd = 995224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LogAutoOpenWithConfig.NativeMethodInfoPtr_get_shouldOpen_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x0003756C File Offset: 0x0003576C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995224, XrefRangeEnd = 995225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LogAutoOpenWithConfig()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogAutoOpenWithConfig>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogAutoOpenWithConfig.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x000078E3 File Offset: 0x00005AE3
		public LogAutoOpenWithConfig(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000C0B RID: 3083 RVA: 0x000375A8 File Offset: 0x000357A8
		// (set) Token: 0x06000C0C RID: 3084 RVA: 0x000078EC File Offset: 0x00005AEC
		public unsafe ConfigSetting<bool> disabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogAutoOpenWithConfig.NativeFieldInfoPtr_disabled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigSetting<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogAutoOpenWithConfig.NativeFieldInfoPtr_disabled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000768 RID: 1896
		private static readonly IntPtr NativeFieldInfoPtr_disabled;

		// Token: 0x04000769 RID: 1897
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400076A RID: 1898
		private static readonly IntPtr NativeMethodInfoPtr_get_shouldOpen_Protected_Virtual_get_Boolean_0;

		// Token: 0x0400076B RID: 1899
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
