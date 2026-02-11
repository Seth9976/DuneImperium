using System;
using boardgames.menus.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.UI;

namespace boardgames.menus.behaviours
{
	// Token: 0x020001B4 RID: 436
	public class ConfigureGameOptionToggle : VersionedView<IConfigureGameOptions.Option>
	{
		// Token: 0x060013AE RID: 5038 RVA: 0x0005D500 File Offset: 0x0005B700
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigureGameOptionToggle()
		{
			Il2CppClassPointerStore<ConfigureGameOptionToggle>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.behaviours", "ConfigureGameOptionToggle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigureGameOptionToggle>.NativeClassPtr);
			ConfigureGameOptionToggle.NativeFieldInfoPtr_optionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureGameOptionToggle>.NativeClassPtr, "optionName");
			ConfigureGameOptionToggle.NativeFieldInfoPtr_toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureGameOptionToggle>.NativeClassPtr, "toggle");
			ConfigureGameOptionToggle.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionToggle>.NativeClassPtr, 100666206);
			ConfigureGameOptionToggle.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionToggle>.NativeClassPtr, 100666207);
			ConfigureGameOptionToggle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionToggle>.NativeClassPtr, 100666208);
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x0005D594 File Offset: 0x0005B794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519663, XrefRangeEnd = 519688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigureGameOptionToggle.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x0005D5D0 File Offset: 0x0005B7D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519688, XrefRangeEnd = 519690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigureGameOptionToggle.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x0005D60C File Offset: 0x0005B80C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519690, XrefRangeEnd = 519696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigureGameOptionToggle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigureGameOptionToggle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameOptionToggle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x0000B3C2 File Offset: 0x000095C2
		public ConfigureGameOptionToggle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x060013B3 RID: 5043 RVA: 0x0005D648 File Offset: 0x0005B848
		// (set) Token: 0x060013B4 RID: 5044 RVA: 0x0000B3CB File Offset: 0x000095CB
		public unsafe string optionName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOptionToggle.NativeFieldInfoPtr_optionName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOptionToggle.NativeFieldInfoPtr_optionName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x060013B5 RID: 5045 RVA: 0x0005D670 File Offset: 0x0005B870
		// (set) Token: 0x060013B6 RID: 5046 RVA: 0x0000B3EA File Offset: 0x000095EA
		public unsafe Toggle toggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOptionToggle.NativeFieldInfoPtr_toggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOptionToggle.NativeFieldInfoPtr_toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C28 RID: 3112
		private static readonly IntPtr NativeFieldInfoPtr_optionName;

		// Token: 0x04000C29 RID: 3113
		private static readonly IntPtr NativeFieldInfoPtr_toggle;

		// Token: 0x04000C2A RID: 3114
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000C2B RID: 3115
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000C2C RID: 3116
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003AB RID: 939
		[ObfuscatedName("boardgames.menus.behaviours.ConfigureGameOptionToggle+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x06002BFD RID: 11261 RVA: 0x000AC0C8 File Offset: 0x000AA2C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<ConfigureGameOptionToggle.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigureGameOptionToggle>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigureGameOptionToggle.__c__DisplayClass2_0>.NativeClassPtr);
				ConfigureGameOptionToggle.__c__DisplayClass2_0.NativeFieldInfoPtr_option = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureGameOptionToggle.__c__DisplayClass2_0>.NativeClassPtr, "option");
				ConfigureGameOptionToggle.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionToggle.__c__DisplayClass2_0>.NativeClassPtr, 100666209);
				ConfigureGameOptionToggle.__c__DisplayClass2_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionToggle.__c__DisplayClass2_0>.NativeClassPtr, 100666210);
			}

			// Token: 0x06002BFE RID: 11262 RVA: 0x000AC130 File Offset: 0x000AA330
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigureGameOptionToggle.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameOptionToggle.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002BFF RID: 11263 RVA: 0x000AC16C File Offset: 0x000AA36C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519661, XrefRangeEnd = 519663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0(bool isOn)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref isOn;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameOptionToggle.__c__DisplayClass2_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002C00 RID: 11264 RVA: 0x00016C14 File Offset: 0x00014E14
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C7A RID: 3194
			// (get) Token: 0x06002C01 RID: 11265 RVA: 0x000AC1AC File Offset: 0x000AA3AC
			// (set) Token: 0x06002C02 RID: 11266 RVA: 0x00016C1D File Offset: 0x00014E1D
			public unsafe IConfigureGameOptions.Option option
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOptionToggle.__c__DisplayClass2_0.NativeFieldInfoPtr_option);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IConfigureGameOptions.Option>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOptionToggle.__c__DisplayClass2_0.NativeFieldInfoPtr_option), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B61 RID: 7009
			private static readonly IntPtr NativeFieldInfoPtr_option;

			// Token: 0x04001B62 RID: 7010
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001B63 RID: 7011
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_Boolean_0;
		}
	}
}
