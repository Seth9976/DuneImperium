using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.Logging
{
	// Token: 0x02000011 RID: 17
	public class LoggerFactoryOptions : Object
	{
		// Token: 0x0600006E RID: 110 RVA: 0x00003FB4 File Offset: 0x000021B4
		// Note: this type is marked as 'beforefieldinit'.
		static LoggerFactoryOptions()
		{
			Il2CppClassPointerStore<LoggerFactoryOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.dll", "Microsoft.Extensions.Logging", "LoggerFactoryOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoggerFactoryOptions>.NativeClassPtr);
			LoggerFactoryOptions.NativeFieldInfoPtr__ActivityTrackingOptions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggerFactoryOptions>.NativeClassPtr, "<ActivityTrackingOptions>k__BackingField");
			LoggerFactoryOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerFactoryOptions>.NativeClassPtr, 100663344);
			LoggerFactoryOptions.NativeMethodInfoPtr_get_ActivityTrackingOptions_Public_get_ActivityTrackingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerFactoryOptions>.NativeClassPtr, 100663345);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00004020 File Offset: 0x00002220
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoggerFactoryOptions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoggerFactoryOptions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerFactoryOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000070 RID: 112 RVA: 0x0000405C File Offset: 0x0000225C
		public unsafe ActivityTrackingOptions ActivityTrackingOptions
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerFactoryOptions.NativeMethodInfoPtr_get_ActivityTrackingOptions_Public_get_ActivityTrackingOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000023DC File Offset: 0x000005DC
		public LoggerFactoryOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00004098 File Offset: 0x00002298
		// (set) Token: 0x06000073 RID: 115 RVA: 0x000023E5 File Offset: 0x000005E5
		public unsafe ActivityTrackingOptions _ActivityTrackingOptions_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFactoryOptions.NativeFieldInfoPtr__ActivityTrackingOptions_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFactoryOptions.NativeFieldInfoPtr__ActivityTrackingOptions_k__BackingField)) = value;
			}
		}

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeFieldInfoPtr__ActivityTrackingOptions_k__BackingField;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_get_ActivityTrackingOptions_Public_get_ActivityTrackingOptions_0;
	}
}
