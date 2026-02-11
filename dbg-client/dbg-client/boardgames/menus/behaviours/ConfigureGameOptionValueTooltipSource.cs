using System;
using boardgames.menus.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.menus.behaviours
{
	// Token: 0x020001B6 RID: 438
	public class ConfigureGameOptionValueTooltipSource : MonoBehaviour
	{
		// Token: 0x060013C0 RID: 5056 RVA: 0x0005D840 File Offset: 0x0005BA40
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigureGameOptionValueTooltipSource()
		{
			Il2CppClassPointerStore<ConfigureGameOptionValueTooltipSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.behaviours", "ConfigureGameOptionValueTooltipSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigureGameOptionValueTooltipSource>.NativeClassPtr);
			ConfigureGameOptionValueTooltipSource.NativeFieldInfoPtr_optionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureGameOptionValueTooltipSource>.NativeClassPtr, "optionName");
			ConfigureGameOptionValueTooltipSource.NativeFieldInfoPtr_locKeyFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureGameOptionValueTooltipSource>.NativeClassPtr, "locKeyFormat");
			ConfigureGameOptionValueTooltipSource.NativeFieldInfoPtr_option = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureGameOptionValueTooltipSource>.NativeClassPtr, "option");
			ConfigureGameOptionValueTooltipSource.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionValueTooltipSource>.NativeClassPtr, 100666214);
			ConfigureGameOptionValueTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionValueTooltipSource>.NativeClassPtr, 100666215);
			ConfigureGameOptionValueTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Protected_Virtual_New_String_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionValueTooltipSource>.NativeClassPtr, 100666216);
			ConfigureGameOptionValueTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionValueTooltipSource>.NativeClassPtr, 100666217);
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x0005D8FC File Offset: 0x0005BAFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519729, XrefRangeEnd = 519743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameOptionValueTooltipSource.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x0005D930 File Offset: 0x0005BB30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519743, XrefRangeEnd = 519745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetLocalizedTooltip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameOptionValueTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x0005D968 File Offset: 0x0005BB68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 519752, RefRangeEnd = 519753, XrefRangeStart = 519745, XrefRangeEnd = 519752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetLocalizedTooltip(IConfigureGameOptions.Option gameOption)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameOption);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigureGameOptionValueTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Protected_Virtual_New_String_Option_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x0005D9BC File Offset: 0x0005BBBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 519761, RefRangeEnd = 519762, XrefRangeStart = 519753, XrefRangeEnd = 519761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigureGameOptionValueTooltipSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigureGameOptionValueTooltipSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameOptionValueTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x0000B450 File Offset: 0x00009650
		public ConfigureGameOptionValueTooltipSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x060013C6 RID: 5062 RVA: 0x0005D9F8 File Offset: 0x0005BBF8
		// (set) Token: 0x060013C7 RID: 5063 RVA: 0x0000B459 File Offset: 0x00009659
		public unsafe string optionName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOptionValueTooltipSource.NativeFieldInfoPtr_optionName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOptionValueTooltipSource.NativeFieldInfoPtr_optionName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x060013C8 RID: 5064 RVA: 0x0005DA20 File Offset: 0x0005BC20
		// (set) Token: 0x060013C9 RID: 5065 RVA: 0x0000B478 File Offset: 0x00009678
		public unsafe string locKeyFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOptionValueTooltipSource.NativeFieldInfoPtr_locKeyFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOptionValueTooltipSource.NativeFieldInfoPtr_locKeyFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x060013CA RID: 5066 RVA: 0x0005DA48 File Offset: 0x0005BC48
		// (set) Token: 0x060013CB RID: 5067 RVA: 0x0000B497 File Offset: 0x00009697
		public unsafe IConfigureGameOptions.Option option
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOptionValueTooltipSource.NativeFieldInfoPtr_option);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IConfigureGameOptions.Option>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOptionValueTooltipSource.NativeFieldInfoPtr_option), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C32 RID: 3122
		private static readonly IntPtr NativeFieldInfoPtr_optionName;

		// Token: 0x04000C33 RID: 3123
		private static readonly IntPtr NativeFieldInfoPtr_locKeyFormat;

		// Token: 0x04000C34 RID: 3124
		private static readonly IntPtr NativeFieldInfoPtr_option;

		// Token: 0x04000C35 RID: 3125
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000C36 RID: 3126
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0;

		// Token: 0x04000C37 RID: 3127
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedTooltip_Protected_Virtual_New_String_Option_0;

		// Token: 0x04000C38 RID: 3128
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
