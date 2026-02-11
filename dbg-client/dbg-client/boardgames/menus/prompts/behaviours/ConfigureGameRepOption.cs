using System;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.menus.prompts.behaviours
{
	// Token: 0x02000205 RID: 517
	public class ConfigureGameRepOption : ConfigureGameOption
	{
		// Token: 0x060017BF RID: 6079 RVA: 0x0006AB8C File Offset: 0x00068D8C
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigureGameRepOption()
		{
			Il2CppClassPointerStore<ConfigureGameRepOption>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts.behaviours", "ConfigureGameRepOption");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigureGameRepOption>.NativeClassPtr);
			ConfigureGameRepOption.NativeFieldInfoPtr_onShowRep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureGameRepOption>.NativeClassPtr, "onShowRep");
			ConfigureGameRepOption.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameRepOption>.NativeClassPtr, 100666765);
			ConfigureGameRepOption.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameRepOption>.NativeClassPtr, 100666766);
			ConfigureGameRepOption.NativeMethodInfoPtr_Method_Internal_Static_Choice_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameRepOption>.NativeClassPtr, 100666767);
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x0006AC0C File Offset: 0x00068E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525427, XrefRangeEnd = 525456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigureGameRepOption.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x0006AC48 File Offset: 0x00068E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525456, XrefRangeEnd = 525462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigureGameRepOption()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigureGameRepOption>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameRepOption.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x0006AC84 File Offset: 0x00068E84
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 525475, RefRangeEnd = 525478, XrefRangeStart = 525462, XrefRangeEnd = 525475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IConfigureGameOptions.Option.Choice Method_Internal_Static_Choice_Int32_0(int rep)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameRepOption.NativeMethodInfoPtr_Method_Internal_Static_Choice_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConfigureGameOptions.Option.Choice>(intPtr3) : null;
			}
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x0000D329 File Offset: 0x0000B529
		public ConfigureGameRepOption(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x060017C4 RID: 6084 RVA: 0x0006ACC4 File Offset: 0x00068EC4
		// (set) Token: 0x060017C5 RID: 6085 RVA: 0x0000D332 File Offset: 0x0000B532
		public unsafe BoolUnityEvents onShowRep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameRepOption.NativeFieldInfoPtr_onShowRep);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolUnityEvents>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameRepOption.NativeFieldInfoPtr_onShowRep), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EE2 RID: 3810
		private static readonly IntPtr NativeFieldInfoPtr_onShowRep;

		// Token: 0x04000EE3 RID: 3811
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x04000EE4 RID: 3812
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000EE5 RID: 3813
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Choice_Int32_0;
	}
}
