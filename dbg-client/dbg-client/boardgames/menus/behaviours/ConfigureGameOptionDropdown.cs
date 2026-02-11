using System;
using boardgames.menus.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;

namespace boardgames.menus.behaviours
{
	// Token: 0x020001B3 RID: 435
	public class ConfigureGameOptionDropdown : VersionedView<IConfigureGameOptions.Option>
	{
		// Token: 0x0600139B RID: 5019 RVA: 0x0005D0BC File Offset: 0x0005B2BC
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigureGameOptionDropdown()
		{
			Il2CppClassPointerStore<ConfigureGameOptionDropdown>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.behaviours", "ConfigureGameOptionDropdown");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigureGameOptionDropdown>.NativeClassPtr);
			ConfigureGameOptionDropdown.NativeFieldInfoPtr_optionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureGameOptionDropdown>.NativeClassPtr, "optionName");
			ConfigureGameOptionDropdown.NativeFieldInfoPtr_optionSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureGameOptionDropdown>.NativeClassPtr, "optionSprites");
			ConfigureGameOptionDropdown.NativeFieldInfoPtr_dropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureGameOptionDropdown>.NativeClassPtr, "dropdown");
			ConfigureGameOptionDropdown.NativeFieldInfoPtr__Choices_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureGameOptionDropdown>.NativeClassPtr, "<Choices>k__BackingField");
			ConfigureGameOptionDropdown.NativeMethodInfoPtr_get_OptionSprites_Protected_get_IReadOnlyList_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionDropdown>.NativeClassPtr, 100666194);
			ConfigureGameOptionDropdown.NativeMethodInfoPtr_get_Choices_Public_get_IReadOnlyList_1_Choice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionDropdown>.NativeClassPtr, 100666195);
			ConfigureGameOptionDropdown.NativeMethodInfoPtr_set_Choices_Private_set_Void_IReadOnlyList_1_Choice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionDropdown>.NativeClassPtr, 100666196);
			ConfigureGameOptionDropdown.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionDropdown>.NativeClassPtr, 100666197);
			ConfigureGameOptionDropdown.NativeMethodInfoPtr_ResetOptions_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionDropdown>.NativeClassPtr, 100666198);
			ConfigureGameOptionDropdown.NativeMethodInfoPtr_GetOptions_Protected_Virtual_New_IEnumerable_1_Choice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionDropdown>.NativeClassPtr, 100666199);
			ConfigureGameOptionDropdown.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionDropdown>.NativeClassPtr, 100666200);
			ConfigureGameOptionDropdown.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionDropdown>.NativeClassPtr, 100666201);
			ConfigureGameOptionDropdown.NativeMethodInfoPtr__GetOptions_b__12_0_Private_Choice_Choice_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionDropdown>.NativeClassPtr, 100666202);
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x0600139C RID: 5020 RVA: 0x0005D1F0 File Offset: 0x0005B3F0
		public unsafe IReadOnlyList<Sprite> OptionSprites
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameOptionDropdown.NativeMethodInfoPtr_get_OptionSprites_Protected_get_IReadOnlyList_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<Sprite>>(intPtr3) : null;
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x0600139D RID: 5021 RVA: 0x0005D230 File Offset: 0x0005B430
		// (set) Token: 0x0600139E RID: 5022 RVA: 0x0005D270 File Offset: 0x0005B470
		public unsafe IReadOnlyList<ConfigureGameOptionDropdown.Choice> Choices
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameOptionDropdown.NativeMethodInfoPtr_get_Choices_Public_get_IReadOnlyList_1_Choice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<ConfigureGameOptionDropdown.Choice>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameOptionDropdown.NativeMethodInfoPtr_set_Choices_Private_set_Void_IReadOnlyList_1_Choice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x0005D2B4 File Offset: 0x0005B4B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519538, XrefRangeEnd = 519569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigureGameOptionDropdown.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x0005D2F0 File Offset: 0x0005B4F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 519621, RefRangeEnd = 519623, XrefRangeStart = 519569, XrefRangeEnd = 519621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameOptionDropdown.NativeMethodInfoPtr_ResetOptions_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x0005D324 File Offset: 0x0005B524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519623, XrefRangeEnd = 519633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<ConfigureGameOptionDropdown.Choice> GetOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigureGameOptionDropdown.NativeMethodInfoPtr_GetOptions_Protected_Virtual_New_IEnumerable_1_Choice_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ConfigureGameOptionDropdown.Choice>>(intPtr3) : null;
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x0005D370 File Offset: 0x0005B570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519633, XrefRangeEnd = 519635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigureGameOptionDropdown.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x0005D3AC File Offset: 0x0005B5AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 519645, RefRangeEnd = 519646, XrefRangeStart = 519635, XrefRangeEnd = 519645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigureGameOptionDropdown()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigureGameOptionDropdown>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameOptionDropdown.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x0005D3E8 File Offset: 0x0005B5E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519646, XrefRangeEnd = 519661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigureGameOptionDropdown.Choice _GetOptions_b__12_0(IConfigureGameOptions.Option.Choice c, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameOptionDropdown.NativeMethodInfoPtr__GetOptions_b__12_0_Private_Choice_Choice_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigureGameOptionDropdown.Choice>(intPtr3) : null;
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x0000B33D File Offset: 0x0000953D
		public ConfigureGameOptionDropdown(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x060013A6 RID: 5030 RVA: 0x0005D448 File Offset: 0x0005B648
		// (set) Token: 0x060013A7 RID: 5031 RVA: 0x0000B346 File Offset: 0x00009546
		public unsafe string optionName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOptionDropdown.NativeFieldInfoPtr_optionName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOptionDropdown.NativeFieldInfoPtr_optionName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x060013A8 RID: 5032 RVA: 0x0005D470 File Offset: 0x0005B670
		// (set) Token: 0x060013A9 RID: 5033 RVA: 0x0000B365 File Offset: 0x00009565
		public unsafe Il2CppReferenceArray<Sprite> optionSprites
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOptionDropdown.NativeFieldInfoPtr_optionSprites);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOptionDropdown.NativeFieldInfoPtr_optionSprites), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x060013AA RID: 5034 RVA: 0x0005D4A0 File Offset: 0x0005B6A0
		// (set) Token: 0x060013AB RID: 5035 RVA: 0x0000B384 File Offset: 0x00009584
		public unsafe TMP_Dropdown dropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOptionDropdown.NativeFieldInfoPtr_dropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOptionDropdown.NativeFieldInfoPtr_dropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x060013AC RID: 5036 RVA: 0x0005D4D0 File Offset: 0x0005B6D0
		// (set) Token: 0x060013AD RID: 5037 RVA: 0x0000B3A3 File Offset: 0x000095A3
		public unsafe IReadOnlyList<ConfigureGameOptionDropdown.Choice> _Choices_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOptionDropdown.NativeFieldInfoPtr__Choices_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<ConfigureGameOptionDropdown.Choice>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOptionDropdown.NativeFieldInfoPtr__Choices_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C1B RID: 3099
		private static readonly IntPtr NativeFieldInfoPtr_optionName;

		// Token: 0x04000C1C RID: 3100
		private static readonly IntPtr NativeFieldInfoPtr_optionSprites;

		// Token: 0x04000C1D RID: 3101
		private static readonly IntPtr NativeFieldInfoPtr_dropdown;

		// Token: 0x04000C1E RID: 3102
		private static readonly IntPtr NativeFieldInfoPtr__Choices_k__BackingField;

		// Token: 0x04000C1F RID: 3103
		private static readonly IntPtr NativeMethodInfoPtr_get_OptionSprites_Protected_get_IReadOnlyList_1_Sprite_0;

		// Token: 0x04000C20 RID: 3104
		private static readonly IntPtr NativeMethodInfoPtr_get_Choices_Public_get_IReadOnlyList_1_Choice_0;

		// Token: 0x04000C21 RID: 3105
		private static readonly IntPtr NativeMethodInfoPtr_set_Choices_Private_set_Void_IReadOnlyList_1_Choice_0;

		// Token: 0x04000C22 RID: 3106
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000C23 RID: 3107
		private static readonly IntPtr NativeMethodInfoPtr_ResetOptions_Protected_Void_0;

		// Token: 0x04000C24 RID: 3108
		private static readonly IntPtr NativeMethodInfoPtr_GetOptions_Protected_Virtual_New_IEnumerable_1_Choice_0;

		// Token: 0x04000C25 RID: 3109
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000C26 RID: 3110
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C27 RID: 3111
		private static readonly IntPtr NativeMethodInfoPtr__GetOptions_b__12_0_Private_Choice_Choice_Int32_0;

		// Token: 0x020003A9 RID: 937
		public class Choice : IConfigureGameOptions.Option.Choice
		{
			// Token: 0x06002BEE RID: 11246 RVA: 0x000ABE44 File Offset: 0x000AA044
			// Note: this type is marked as 'beforefieldinit'.
			static Choice()
			{
				Il2CppClassPointerStore<ConfigureGameOptionDropdown.Choice>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigureGameOptionDropdown>.NativeClassPtr, "Choice");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigureGameOptionDropdown.Choice>.NativeClassPtr);
				ConfigureGameOptionDropdown.Choice.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureGameOptionDropdown.Choice>.NativeClassPtr, "index");
				ConfigureGameOptionDropdown.Choice.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureGameOptionDropdown.Choice>.NativeClassPtr, "sprite");
				ConfigureGameOptionDropdown.Choice.NativeMethodInfoPtr__ctor_Public_Void_Choice_Int32_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionDropdown.Choice>.NativeClassPtr, 100666203);
			}

			// Token: 0x06002BEF RID: 11247 RVA: 0x000ABEAC File Offset: 0x000AA0AC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 519531, RefRangeEnd = 519532, XrefRangeStart = 519526, XrefRangeEnd = 519531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Choice(IConfigureGameOptions.Option.Choice baseChoice, int index, Sprite sprite)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigureGameOptionDropdown.Choice>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseChoice);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sprite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameOptionDropdown.Choice.NativeMethodInfoPtr__ctor_Public_Void_Choice_Int32_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002BF0 RID: 11248 RVA: 0x00016B8A File Offset: 0x00014D8A
			public Choice(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C76 RID: 3190
			// (get) Token: 0x06002BF1 RID: 11249 RVA: 0x000ABF18 File Offset: 0x000AA118
			// (set) Token: 0x06002BF2 RID: 11250 RVA: 0x00016B93 File Offset: 0x00014D93
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOptionDropdown.Choice.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOptionDropdown.Choice.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x17000C77 RID: 3191
			// (get) Token: 0x06002BF3 RID: 11251 RVA: 0x000ABF40 File Offset: 0x000AA140
			// (set) Token: 0x06002BF4 RID: 11252 RVA: 0x00016BAE File Offset: 0x00014DAE
			public unsafe Sprite sprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOptionDropdown.Choice.NativeFieldInfoPtr_sprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOptionDropdown.Choice.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B5A RID: 7002
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04001B5B RID: 7003
			private static readonly IntPtr NativeFieldInfoPtr_sprite;

			// Token: 0x04001B5C RID: 7004
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Choice_Int32_Sprite_0;
		}

		// Token: 0x020003AA RID: 938
		[ObfuscatedName("boardgames.menus.behaviours.ConfigureGameOptionDropdown+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002BF5 RID: 11253 RVA: 0x000ABF70 File Offset: 0x000AA170
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<ConfigureGameOptionDropdown.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigureGameOptionDropdown>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigureGameOptionDropdown.__c__DisplayClass10_0>.NativeClassPtr);
				ConfigureGameOptionDropdown.__c__DisplayClass10_0.NativeFieldInfoPtr_option = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureGameOptionDropdown.__c__DisplayClass10_0>.NativeClassPtr, "option");
				ConfigureGameOptionDropdown.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureGameOptionDropdown.__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
				ConfigureGameOptionDropdown.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionDropdown.__c__DisplayClass10_0>.NativeClassPtr, 100666204);
				ConfigureGameOptionDropdown.__c__DisplayClass10_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionDropdown.__c__DisplayClass10_0>.NativeClassPtr, 100666205);
			}

			// Token: 0x06002BF6 RID: 11254 RVA: 0x000ABFEC File Offset: 0x000AA1EC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigureGameOptionDropdown.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameOptionDropdown.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002BF7 RID: 11255 RVA: 0x000AC028 File Offset: 0x000AA228
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519532, XrefRangeEnd = 519538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0(int v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameOptionDropdown.__c__DisplayClass10_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002BF8 RID: 11256 RVA: 0x00016BCD File Offset: 0x00014DCD
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C78 RID: 3192
			// (get) Token: 0x06002BF9 RID: 11257 RVA: 0x000AC068 File Offset: 0x000AA268
			// (set) Token: 0x06002BFA RID: 11258 RVA: 0x00016BD6 File Offset: 0x00014DD6
			public unsafe IConfigureGameOptions.Option option
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOptionDropdown.__c__DisplayClass10_0.NativeFieldInfoPtr_option);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IConfigureGameOptions.Option>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOptionDropdown.__c__DisplayClass10_0.NativeFieldInfoPtr_option), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C79 RID: 3193
			// (get) Token: 0x06002BFB RID: 11259 RVA: 0x000AC098 File Offset: 0x000AA298
			// (set) Token: 0x06002BFC RID: 11260 RVA: 0x00016BF5 File Offset: 0x00014DF5
			public unsafe ConfigureGameOptionDropdown __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOptionDropdown.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigureGameOptionDropdown>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOptionDropdown.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B5D RID: 7005
			private static readonly IntPtr NativeFieldInfoPtr_option;

			// Token: 0x04001B5E RID: 7006
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001B5F RID: 7007
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001B60 RID: 7008
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_Int32_0;
		}
	}
}
