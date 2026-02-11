using System;
using dwd.core.data.composition;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace boardgames.menus.prompts
{
	// Token: 0x020001E5 RID: 485
	public class ConfigurePlayerPrompt : ResolvablePrompt<ValueTuple<string, string>>
	{
		// Token: 0x060016BE RID: 5822 RVA: 0x00067250 File Offset: 0x00065450
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigurePlayerPrompt()
		{
			Il2CppClassPointerStore<ConfigurePlayerPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "ConfigurePlayerPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurePlayerPrompt>.NativeClassPtr);
			ConfigurePlayerPrompt.NativeFieldInfoPtr__Canceled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurePlayerPrompt>.NativeClassPtr, "<Canceled>k__BackingField");
			ConfigurePlayerPrompt.NativeFieldInfoPtr__PromptData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurePlayerPrompt>.NativeClassPtr, "<PromptData>k__BackingField");
			ConfigurePlayerPrompt.NativeFieldInfoPtr__ChosenColor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurePlayerPrompt>.NativeClassPtr, "<ChosenColor>k__BackingField");
			ConfigurePlayerPrompt.NativeFieldInfoPtr__ChosenAvatar_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurePlayerPrompt>.NativeClassPtr, "<ChosenAvatar>k__BackingField");
			ConfigurePlayerPrompt.NativeMethodInfoPtr_get_Canceled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurePlayerPrompt>.NativeClassPtr, 100666628);
			ConfigurePlayerPrompt.NativeMethodInfoPtr_set_Canceled_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurePlayerPrompt>.NativeClassPtr, 100666629);
			ConfigurePlayerPrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurePlayerPrompt>.NativeClassPtr, 100666630);
			ConfigurePlayerPrompt.NativeMethodInfoPtr_set_PromptData_Private_set_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurePlayerPrompt>.NativeClassPtr, 100666631);
			ConfigurePlayerPrompt.NativeMethodInfoPtr_get_ChosenColor_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurePlayerPrompt>.NativeClassPtr, 100666632);
			ConfigurePlayerPrompt.NativeMethodInfoPtr_set_ChosenColor_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurePlayerPrompt>.NativeClassPtr, 100666633);
			ConfigurePlayerPrompt.NativeMethodInfoPtr_get_ChosenAvatar_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurePlayerPrompt>.NativeClassPtr, 100666634);
			ConfigurePlayerPrompt.NativeMethodInfoPtr_set_ChosenAvatar_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurePlayerPrompt>.NativeClassPtr, 100666635);
			ConfigurePlayerPrompt.NativeMethodInfoPtr__ctor_Public_Void_List_1_String_List_1_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurePlayerPrompt>.NativeClassPtr, 100666636);
			ConfigurePlayerPrompt.NativeMethodInfoPtr_ChooseColor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurePlayerPrompt>.NativeClassPtr, 100666637);
			ConfigurePlayerPrompt.NativeMethodInfoPtr_ChooseAvatar_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurePlayerPrompt>.NativeClassPtr, 100666638);
			ConfigurePlayerPrompt.NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurePlayerPrompt>.NativeClassPtr, 100666639);
			ConfigurePlayerPrompt.NativeMethodInfoPtr_UpdateValidData_Public_Void_List_1_String_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurePlayerPrompt>.NativeClassPtr, 100666640);
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x060016BF RID: 5823 RVA: 0x000673D4 File Offset: 0x000655D4
		// (set) Token: 0x060016C0 RID: 5824 RVA: 0x00067410 File Offset: 0x00065610
		public unsafe bool Canceled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurePlayerPrompt.NativeMethodInfoPtr_get_Canceled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurePlayerPrompt.NativeMethodInfoPtr_set_Canceled_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x060016C1 RID: 5825 RVA: 0x00067450 File Offset: 0x00065650
		// (set) Token: 0x060016C2 RID: 5826 RVA: 0x00067490 File Offset: 0x00065690
		public unsafe virtual DataComposition PromptData
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurePlayerPrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurePlayerPrompt.NativeMethodInfoPtr_set_PromptData_Private_set_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x060016C3 RID: 5827 RVA: 0x000674D4 File Offset: 0x000656D4
		// (set) Token: 0x060016C4 RID: 5828 RVA: 0x0006750C File Offset: 0x0006570C
		public unsafe string ChosenColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurePlayerPrompt.NativeMethodInfoPtr_get_ChosenColor_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurePlayerPrompt.NativeMethodInfoPtr_set_ChosenColor_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x060016C5 RID: 5829 RVA: 0x00067550 File Offset: 0x00065750
		// (set) Token: 0x060016C6 RID: 5830 RVA: 0x00067588 File Offset: 0x00065788
		public unsafe string ChosenAvatar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurePlayerPrompt.NativeMethodInfoPtr_get_ChosenAvatar_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurePlayerPrompt.NativeMethodInfoPtr_set_ChosenAvatar_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x000675CC File Offset: 0x000657CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 524926, RefRangeEnd = 524927, XrefRangeStart = 524884, XrefRangeEnd = 524926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigurePlayerPrompt(List<string> validColors, List<string> validAvatars, string initialColor, string initialAvatar)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigurePlayerPrompt>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(validColors);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(validAvatars);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(initialColor);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(initialAvatar);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurePlayerPrompt.NativeMethodInfoPtr__ctor_Public_Void_List_1_String_List_1_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x00067650 File Offset: 0x00065850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524927, XrefRangeEnd = 524933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChooseColor(string color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurePlayerPrompt.NativeMethodInfoPtr_ChooseColor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x00067694 File Offset: 0x00065894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524933, XrefRangeEnd = 524939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChooseAvatar(string avatar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(avatar);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurePlayerPrompt.NativeMethodInfoPtr_ChooseAvatar_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x000676D8 File Offset: 0x000658D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524939, XrefRangeEnd = 524945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurePlayerPrompt.NativeMethodInfoPtr_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x0006770C File Offset: 0x0006590C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 524954, RefRangeEnd = 524955, XrefRangeStart = 524945, XrefRangeEnd = 524954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateValidData(List<string> validColors, List<string> validAvatars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(validColors);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(validAvatars);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurePlayerPrompt.NativeMethodInfoPtr_UpdateValidData_Public_Void_List_1_String_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x0000CCE1 File Offset: 0x0000AEE1
		public ConfigurePlayerPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x060016CD RID: 5837 RVA: 0x00067760 File Offset: 0x00065960
		// (set) Token: 0x060016CE RID: 5838 RVA: 0x0000CCEA File Offset: 0x0000AEEA
		public unsafe bool _Canceled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurePlayerPrompt.NativeFieldInfoPtr__Canceled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurePlayerPrompt.NativeFieldInfoPtr__Canceled_k__BackingField)) = value;
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x060016CF RID: 5839 RVA: 0x00067788 File Offset: 0x00065988
		// (set) Token: 0x060016D0 RID: 5840 RVA: 0x0000CD05 File Offset: 0x0000AF05
		public unsafe DataComposition _PromptData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurePlayerPrompt.NativeFieldInfoPtr__PromptData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurePlayerPrompt.NativeFieldInfoPtr__PromptData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x060016D1 RID: 5841 RVA: 0x000677B8 File Offset: 0x000659B8
		// (set) Token: 0x060016D2 RID: 5842 RVA: 0x0000CD24 File Offset: 0x0000AF24
		public unsafe string _ChosenColor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurePlayerPrompt.NativeFieldInfoPtr__ChosenColor_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurePlayerPrompt.NativeFieldInfoPtr__ChosenColor_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x060016D3 RID: 5843 RVA: 0x000677E0 File Offset: 0x000659E0
		// (set) Token: 0x060016D4 RID: 5844 RVA: 0x0000CD43 File Offset: 0x0000AF43
		public unsafe string _ChosenAvatar_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurePlayerPrompt.NativeFieldInfoPtr__ChosenAvatar_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurePlayerPrompt.NativeFieldInfoPtr__ChosenAvatar_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000E20 RID: 3616
		private static readonly IntPtr NativeFieldInfoPtr__Canceled_k__BackingField;

		// Token: 0x04000E21 RID: 3617
		private static readonly IntPtr NativeFieldInfoPtr__PromptData_k__BackingField;

		// Token: 0x04000E22 RID: 3618
		private static readonly IntPtr NativeFieldInfoPtr__ChosenColor_k__BackingField;

		// Token: 0x04000E23 RID: 3619
		private static readonly IntPtr NativeFieldInfoPtr__ChosenAvatar_k__BackingField;

		// Token: 0x04000E24 RID: 3620
		private static readonly IntPtr NativeMethodInfoPtr_get_Canceled_Public_get_Boolean_0;

		// Token: 0x04000E25 RID: 3621
		private static readonly IntPtr NativeMethodInfoPtr_set_Canceled_Private_set_Void_Boolean_0;

		// Token: 0x04000E26 RID: 3622
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0;

		// Token: 0x04000E27 RID: 3623
		private static readonly IntPtr NativeMethodInfoPtr_set_PromptData_Private_set_Void_DataComposition_0;

		// Token: 0x04000E28 RID: 3624
		private static readonly IntPtr NativeMethodInfoPtr_get_ChosenColor_Public_get_String_0;

		// Token: 0x04000E29 RID: 3625
		private static readonly IntPtr NativeMethodInfoPtr_set_ChosenColor_Private_set_Void_String_0;

		// Token: 0x04000E2A RID: 3626
		private static readonly IntPtr NativeMethodInfoPtr_get_ChosenAvatar_Public_get_String_0;

		// Token: 0x04000E2B RID: 3627
		private static readonly IntPtr NativeMethodInfoPtr_set_ChosenAvatar_Private_set_Void_String_0;

		// Token: 0x04000E2C RID: 3628
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_String_List_1_String_String_String_0;

		// Token: 0x04000E2D RID: 3629
		private static readonly IntPtr NativeMethodInfoPtr_ChooseColor_Public_Void_String_0;

		// Token: 0x04000E2E RID: 3630
		private static readonly IntPtr NativeMethodInfoPtr_ChooseAvatar_Public_Void_String_0;

		// Token: 0x04000E2F RID: 3631
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;

		// Token: 0x04000E30 RID: 3632
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValidData_Public_Void_List_1_String_List_1_String_0;
	}
}
