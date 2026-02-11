using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.menus.prompts.behaviours
{
	// Token: 0x02000204 RID: 516
	public class ConfigureGameOption : MonoBehaviour
	{
		// Token: 0x060017B4 RID: 6068 RVA: 0x0006A8C0 File Offset: 0x00068AC0
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigureGameOption()
		{
			Il2CppClassPointerStore<ConfigureGameOption>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts.behaviours", "ConfigureGameOption");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigureGameOption>.NativeClassPtr);
			ConfigureGameOption.NativeFieldInfoPtr_option = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureGameOption>.NativeClassPtr, "option");
			ConfigureGameOption.NativeMethodInfoPtr_get_Option_Public_get_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOption>.NativeClassPtr, 100666758);
			ConfigureGameOption.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOption>.NativeClassPtr, 100666759);
			ConfigureGameOption.NativeMethodInfoPtr_start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOption>.NativeClassPtr, 100666760);
			ConfigureGameOption.NativeMethodInfoPtr_GetGameOption_Public_Virtual_Final_New_Option_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOption>.NativeClassPtr, 100666761);
			ConfigureGameOption.NativeMethodInfoPtr_Event_Increment_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOption>.NativeClassPtr, 100666762);
			ConfigureGameOption.NativeMethodInfoPtr_GetGameOptionOnThis_Public_Virtual_Final_New_Option_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOption>.NativeClassPtr, 100666763);
			ConfigureGameOption.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOption>.NativeClassPtr, 100666764);
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x060017B5 RID: 6069 RVA: 0x0006A990 File Offset: 0x00068B90
		public unsafe IConfigureGameOptions.Option Option
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameOption.NativeMethodInfoPtr_get_Option_Public_get_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConfigureGameOptions.Option>(intPtr3) : null;
			}
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x0006A9D0 File Offset: 0x00068BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525415, XrefRangeEnd = 525417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameOption.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x0006AA04 File Offset: 0x00068C04
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigureGameOption.NativeMethodInfoPtr_start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x0006AA40 File Offset: 0x00068C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525417, XrefRangeEnd = 525425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IConfigureGameOptions.Option GetGameOption(string optionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(optionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameOption.NativeMethodInfoPtr_GetGameOption_Public_Virtual_Final_New_Option_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConfigureGameOptions.Option>(intPtr3) : null;
			}
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x0006AA90 File Offset: 0x00068C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525425, XrefRangeEnd = 525426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Increment(int direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref direction;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameOption.NativeMethodInfoPtr_Event_Increment_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x0006AAD0 File Offset: 0x00068CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525426, XrefRangeEnd = 525427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IConfigureGameOptions.Option GetGameOptionOnThis(string optionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(optionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameOption.NativeMethodInfoPtr_GetGameOptionOnThis_Public_Virtual_Final_New_Option_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConfigureGameOptions.Option>(intPtr3) : null;
			}
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x0006AB20 File Offset: 0x00068D20
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigureGameOption()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigureGameOption>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameOption.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x0000D301 File Offset: 0x0000B501
		public ConfigureGameOption(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x060017BD RID: 6077 RVA: 0x0006AB5C File Offset: 0x00068D5C
		// (set) Token: 0x060017BE RID: 6078 RVA: 0x0000D30A File Offset: 0x0000B50A
		public unsafe IConfigureGameOptions.Option option
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOption.NativeFieldInfoPtr_option);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IConfigureGameOptions.Option>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOption.NativeFieldInfoPtr_option), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EDA RID: 3802
		private static readonly IntPtr NativeFieldInfoPtr_option;

		// Token: 0x04000EDB RID: 3803
		private static readonly IntPtr NativeMethodInfoPtr_get_Option_Public_get_Option_0;

		// Token: 0x04000EDC RID: 3804
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000EDD RID: 3805
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_New_Void_0;

		// Token: 0x04000EDE RID: 3806
		private static readonly IntPtr NativeMethodInfoPtr_GetGameOption_Public_Virtual_Final_New_Option_String_0;

		// Token: 0x04000EDF RID: 3807
		private static readonly IntPtr NativeMethodInfoPtr_Event_Increment_Public_Void_Int32_0;

		// Token: 0x04000EE0 RID: 3808
		private static readonly IntPtr NativeMethodInfoPtr_GetGameOptionOnThis_Public_Virtual_Final_New_Option_String_0;

		// Token: 0x04000EE1 RID: 3809
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
