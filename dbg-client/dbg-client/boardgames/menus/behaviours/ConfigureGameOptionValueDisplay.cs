using System;
using boardgames.menus.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;

namespace boardgames.menus.behaviours
{
	// Token: 0x020001B5 RID: 437
	public class ConfigureGameOptionValueDisplay : VersionedView<IConfigureGameOptions.Option>
	{
		// Token: 0x060013B7 RID: 5047 RVA: 0x0005D6A0 File Offset: 0x0005B8A0
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigureGameOptionValueDisplay()
		{
			Il2CppClassPointerStore<ConfigureGameOptionValueDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.behaviours", "ConfigureGameOptionValueDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigureGameOptionValueDisplay>.NativeClassPtr);
			ConfigureGameOptionValueDisplay.NativeFieldInfoPtr_optionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureGameOptionValueDisplay>.NativeClassPtr, "optionName");
			ConfigureGameOptionValueDisplay.NativeFieldInfoPtr_display = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureGameOptionValueDisplay>.NativeClassPtr, "display");
			ConfigureGameOptionValueDisplay.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionValueDisplay>.NativeClassPtr, 100666211);
			ConfigureGameOptionValueDisplay.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionValueDisplay>.NativeClassPtr, 100666212);
			ConfigureGameOptionValueDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionValueDisplay>.NativeClassPtr, 100666213);
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x0005D734 File Offset: 0x0005B934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519696, XrefRangeEnd = 519717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigureGameOptionValueDisplay.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x0005D770 File Offset: 0x0005B970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519717, XrefRangeEnd = 519723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigureGameOptionValueDisplay.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x0005D7AC File Offset: 0x0005B9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519723, XrefRangeEnd = 519729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigureGameOptionValueDisplay()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigureGameOptionValueDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameOptionValueDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x0000B409 File Offset: 0x00009609
		public ConfigureGameOptionValueDisplay(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x060013BC RID: 5052 RVA: 0x0005D7E8 File Offset: 0x0005B9E8
		// (set) Token: 0x060013BD RID: 5053 RVA: 0x0000B412 File Offset: 0x00009612
		public unsafe string optionName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOptionValueDisplay.NativeFieldInfoPtr_optionName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOptionValueDisplay.NativeFieldInfoPtr_optionName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x060013BE RID: 5054 RVA: 0x0005D810 File Offset: 0x0005BA10
		// (set) Token: 0x060013BF RID: 5055 RVA: 0x0000B431 File Offset: 0x00009631
		public unsafe TMP_Text display
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOptionValueDisplay.NativeFieldInfoPtr_display);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOptionValueDisplay.NativeFieldInfoPtr_display), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C2D RID: 3117
		private static readonly IntPtr NativeFieldInfoPtr_optionName;

		// Token: 0x04000C2E RID: 3118
		private static readonly IntPtr NativeFieldInfoPtr_display;

		// Token: 0x04000C2F RID: 3119
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000C30 RID: 3120
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000C31 RID: 3121
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
