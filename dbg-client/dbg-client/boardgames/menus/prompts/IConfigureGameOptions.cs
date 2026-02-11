using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace boardgames.menus.prompts
{
	// Token: 0x020001D2 RID: 466
	public class IConfigureGameOptions : Il2CppObjectBase
	{
		// Token: 0x06001553 RID: 5459 RVA: 0x00062A48 File Offset: 0x00060C48
		// Note: this type is marked as 'beforefieldinit'.
		static IConfigureGameOptions()
		{
			Il2CppClassPointerStore<IConfigureGameOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "IConfigureGameOptions");
			IConfigureGameOptions.NativeFieldInfoPtr_INVALID_OPTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IConfigureGameOptions>.NativeClassPtr, "INVALID_OPTION");
			IConfigureGameOptions.NativeMethodInfoPtr_GetGameOption_Public_Abstract_Virtual_New_Option_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigureGameOptions>.NativeClassPtr, 100666428);
			IConfigureGameOptions.NativeMethodInfoPtr_GetGameOptionOnThis_Public_Abstract_Virtual_New_Option_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigureGameOptions>.NativeClassPtr, 100666429);
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x00062AAC File Offset: 0x00060CAC
		[CallerCount(0)]
		public unsafe virtual IConfigureGameOptions.Option GetGameOption(string optionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(optionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigureGameOptions.NativeMethodInfoPtr_GetGameOption_Public_Abstract_Virtual_New_Option_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConfigureGameOptions.Option>(intPtr3) : null;
			}
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x00062B08 File Offset: 0x00060D08
		[CallerCount(0)]
		public unsafe virtual IConfigureGameOptions.Option GetGameOptionOnThis(string optionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(optionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigureGameOptions.NativeMethodInfoPtr_GetGameOptionOnThis_Public_Abstract_Virtual_New_Option_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConfigureGameOptions.Option>(intPtr3) : null;
			}
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x0000C093 File Offset: 0x0000A293
		public IConfigureGameOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06001557 RID: 5463 RVA: 0x00062B64 File Offset: 0x00060D64
		// (set) Token: 0x06001558 RID: 5464 RVA: 0x0000C09C File Offset: 0x0000A29C
		public unsafe static int INVALID_OPTION
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(IConfigureGameOptions.NativeFieldInfoPtr_INVALID_OPTION, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IConfigureGameOptions.NativeFieldInfoPtr_INVALID_OPTION, (void*)(&value));
			}
		}

		// Token: 0x04000D38 RID: 3384
		private static readonly IntPtr NativeFieldInfoPtr_INVALID_OPTION;

		// Token: 0x04000D39 RID: 3385
		private static readonly IntPtr NativeMethodInfoPtr_GetGameOption_Public_Abstract_Virtual_New_Option_String_0;

		// Token: 0x04000D3A RID: 3386
		private static readonly IntPtr NativeMethodInfoPtr_GetGameOptionOnThis_Public_Abstract_Virtual_New_Option_String_0;

		// Token: 0x020003C1 RID: 961
		[Serializable]
		public class Option : Object
		{
			// Token: 0x06002CBE RID: 11454 RVA: 0x000AE270 File Offset: 0x000AC470
			// Note: this type is marked as 'beforefieldinit'.
			static Option()
			{
				Il2CppClassPointerStore<IConfigureGameOptions.Option>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IConfigureGameOptions>.NativeClassPtr, "Option");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IConfigureGameOptions.Option>.NativeClassPtr);
				IConfigureGameOptions.Option.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IConfigureGameOptions.Option>.NativeClassPtr, "name");
				IConfigureGameOptions.Option.NativeFieldInfoPtr_optionNameLocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IConfigureGameOptions.Option>.NativeClassPtr, "optionNameLocKey");
				IConfigureGameOptions.Option.NativeFieldInfoPtr_possibleChoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IConfigureGameOptions.Option>.NativeClassPtr, "possibleChoices");
				IConfigureGameOptions.Option.NativeFieldInfoPtr_optionPrefName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IConfigureGameOptions.Option>.NativeClassPtr, "optionPrefName");
				IConfigureGameOptions.Option.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IConfigureGameOptions.Option>.NativeClassPtr, "value");
				IConfigureGameOptions.Option.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IConfigureGameOptions.Option>.NativeClassPtr, "version");
				IConfigureGameOptions.Option.NativeFieldInfoPtr_lastValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IConfigureGameOptions.Option>.NativeClassPtr, "lastValue");
				IConfigureGameOptions.Option.NativeFieldInfoPtr_hasLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IConfigureGameOptions.Option>.NativeClassPtr, "hasLoaded");
				IConfigureGameOptions.Option.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigureGameOptions.Option>.NativeClassPtr, 100666430);
				IConfigureGameOptions.Option.NativeMethodInfoPtr_get_Selected_Public_get_Choice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigureGameOptions.Option>.NativeClassPtr, 100666431);
				IConfigureGameOptions.Option.NativeMethodInfoPtr_SetValue_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigureGameOptions.Option>.NativeClassPtr, 100666432);
				IConfigureGameOptions.Option.NativeMethodInfoPtr_Increment_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigureGameOptions.Option>.NativeClassPtr, 100666433);
				IConfigureGameOptions.Option.NativeMethodInfoPtr_LoadFromPref_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigureGameOptions.Option>.NativeClassPtr, 100666434);
				IConfigureGameOptions.Option.NativeMethodInfoPtr_SaveToPref_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigureGameOptions.Option>.NativeClassPtr, 100666435);
				IConfigureGameOptions.Option.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigureGameOptions.Option>.NativeClassPtr, 100666436);
			}

			// Token: 0x17000CB8 RID: 3256
			// (get) Token: 0x06002CBF RID: 11455 RVA: 0x000AE3C8 File Offset: 0x000AC5C8
			public unsafe virtual ulong Version
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IConfigureGameOptions.Option.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000CB9 RID: 3257
			// (get) Token: 0x06002CC0 RID: 11456 RVA: 0x000AE404 File Offset: 0x000AC604
			public unsafe IConfigureGameOptions.Option.Choice Selected
			{
				[CallerCount(8)]
				[CachedScanResults(RefRangeStart = 522222, RefRangeEnd = 522230, XrefRangeStart = 522222, XrefRangeEnd = 522222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IConfigureGameOptions.Option.NativeMethodInfoPtr_get_Selected_Public_get_Choice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConfigureGameOptions.Option.Choice>(intPtr3) : null;
				}
			}

			// Token: 0x06002CC1 RID: 11457 RVA: 0x000AE444 File Offset: 0x000AC644
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 522231, RefRangeEnd = 522237, XrefRangeStart = 522230, XrefRangeEnd = 522231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetValue(int newValue)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref newValue;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IConfigureGameOptions.Option.NativeMethodInfoPtr_SetValue_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002CC2 RID: 11458 RVA: 0x000AE484 File Offset: 0x000AC684
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 522238, RefRangeEnd = 522239, XrefRangeStart = 522237, XrefRangeEnd = 522238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Increment(int change)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref change;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IConfigureGameOptions.Option.NativeMethodInfoPtr_Increment_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002CC3 RID: 11459 RVA: 0x000AE4C4 File Offset: 0x000AC6C4
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 522257, RefRangeEnd = 522261, XrefRangeStart = 522239, XrefRangeEnd = 522257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool LoadFromPref()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IConfigureGameOptions.Option.NativeMethodInfoPtr_LoadFromPref_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002CC4 RID: 11460 RVA: 0x000AE500 File Offset: 0x000AC700
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 522279, RefRangeEnd = 522283, XrefRangeStart = 522261, XrefRangeEnd = 522279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SaveToPref()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IConfigureGameOptions.Option.NativeMethodInfoPtr_SaveToPref_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002CC5 RID: 11461 RVA: 0x000AE534 File Offset: 0x000AC734
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522283, XrefRangeEnd = 522295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Option()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IConfigureGameOptions.Option>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IConfigureGameOptions.Option.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002CC6 RID: 11462 RVA: 0x00017289 File Offset: 0x00015489
			public Option(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CB0 RID: 3248
			// (get) Token: 0x06002CC7 RID: 11463 RVA: 0x000AE570 File Offset: 0x000AC770
			// (set) Token: 0x06002CC8 RID: 11464 RVA: 0x00017292 File Offset: 0x00015492
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IConfigureGameOptions.Option.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IConfigureGameOptions.Option.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000CB1 RID: 3249
			// (get) Token: 0x06002CC9 RID: 11465 RVA: 0x000AE598 File Offset: 0x000AC798
			// (set) Token: 0x06002CCA RID: 11466 RVA: 0x000172B1 File Offset: 0x000154B1
			public unsafe string optionNameLocKey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IConfigureGameOptions.Option.NativeFieldInfoPtr_optionNameLocKey);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IConfigureGameOptions.Option.NativeFieldInfoPtr_optionNameLocKey), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000CB2 RID: 3250
			// (get) Token: 0x06002CCB RID: 11467 RVA: 0x000AE5C0 File Offset: 0x000AC7C0
			// (set) Token: 0x06002CCC RID: 11468 RVA: 0x000172D0 File Offset: 0x000154D0
			public unsafe Il2CppReferenceArray<IConfigureGameOptions.Option.Choice> possibleChoices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IConfigureGameOptions.Option.NativeFieldInfoPtr_possibleChoices);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IConfigureGameOptions.Option.Choice>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IConfigureGameOptions.Option.NativeFieldInfoPtr_possibleChoices), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CB3 RID: 3251
			// (get) Token: 0x06002CCD RID: 11469 RVA: 0x000AE5F0 File Offset: 0x000AC7F0
			// (set) Token: 0x06002CCE RID: 11470 RVA: 0x000172EF File Offset: 0x000154EF
			public unsafe string optionPrefName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IConfigureGameOptions.Option.NativeFieldInfoPtr_optionPrefName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IConfigureGameOptions.Option.NativeFieldInfoPtr_optionPrefName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000CB4 RID: 3252
			// (get) Token: 0x06002CCF RID: 11471 RVA: 0x000AE618 File Offset: 0x000AC818
			// (set) Token: 0x06002CD0 RID: 11472 RVA: 0x0001730E File Offset: 0x0001550E
			public unsafe int value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IConfigureGameOptions.Option.NativeFieldInfoPtr_value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IConfigureGameOptions.Option.NativeFieldInfoPtr_value)) = value;
				}
			}

			// Token: 0x17000CB5 RID: 3253
			// (get) Token: 0x06002CD1 RID: 11473 RVA: 0x000AE640 File Offset: 0x000AC840
			// (set) Token: 0x06002CD2 RID: 11474 RVA: 0x00017329 File Offset: 0x00015529
			public unsafe ulong version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IConfigureGameOptions.Option.NativeFieldInfoPtr_version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IConfigureGameOptions.Option.NativeFieldInfoPtr_version)) = value;
				}
			}

			// Token: 0x17000CB6 RID: 3254
			// (get) Token: 0x06002CD3 RID: 11475 RVA: 0x000AE668 File Offset: 0x000AC868
			// (set) Token: 0x06002CD4 RID: 11476 RVA: 0x00017344 File Offset: 0x00015544
			public unsafe int lastValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IConfigureGameOptions.Option.NativeFieldInfoPtr_lastValue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IConfigureGameOptions.Option.NativeFieldInfoPtr_lastValue)) = value;
				}
			}

			// Token: 0x17000CB7 RID: 3255
			// (get) Token: 0x06002CD5 RID: 11477 RVA: 0x000AE690 File Offset: 0x000AC890
			// (set) Token: 0x06002CD6 RID: 11478 RVA: 0x0001735F File Offset: 0x0001555F
			public unsafe bool hasLoaded
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IConfigureGameOptions.Option.NativeFieldInfoPtr_hasLoaded);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IConfigureGameOptions.Option.NativeFieldInfoPtr_hasLoaded)) = value;
				}
			}

			// Token: 0x04001BC6 RID: 7110
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04001BC7 RID: 7111
			private static readonly IntPtr NativeFieldInfoPtr_optionNameLocKey;

			// Token: 0x04001BC8 RID: 7112
			private static readonly IntPtr NativeFieldInfoPtr_possibleChoices;

			// Token: 0x04001BC9 RID: 7113
			private static readonly IntPtr NativeFieldInfoPtr_optionPrefName;

			// Token: 0x04001BCA RID: 7114
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04001BCB RID: 7115
			private static readonly IntPtr NativeFieldInfoPtr_version;

			// Token: 0x04001BCC RID: 7116
			private static readonly IntPtr NativeFieldInfoPtr_lastValue;

			// Token: 0x04001BCD RID: 7117
			private static readonly IntPtr NativeFieldInfoPtr_hasLoaded;

			// Token: 0x04001BCE RID: 7118
			private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

			// Token: 0x04001BCF RID: 7119
			private static readonly IntPtr NativeMethodInfoPtr_get_Selected_Public_get_Choice_0;

			// Token: 0x04001BD0 RID: 7120
			private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Int32_0;

			// Token: 0x04001BD1 RID: 7121
			private static readonly IntPtr NativeMethodInfoPtr_Increment_Public_Void_Int32_0;

			// Token: 0x04001BD2 RID: 7122
			private static readonly IntPtr NativeMethodInfoPtr_LoadFromPref_Public_Boolean_0;

			// Token: 0x04001BD3 RID: 7123
			private static readonly IntPtr NativeMethodInfoPtr_SaveToPref_Public_Void_0;

			// Token: 0x04001BD4 RID: 7124
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x020004AB RID: 1195
			[Serializable]
			public class Choice : Object
			{
				// Token: 0x06003898 RID: 14488 RVA: 0x000D16A4 File Offset: 0x000CF8A4
				// Note: this type is marked as 'beforefieldinit'.
				static Choice()
				{
					Il2CppClassPointerStore<IConfigureGameOptions.Option.Choice>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IConfigureGameOptions.Option>.NativeClassPtr, "Choice");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IConfigureGameOptions.Option.Choice>.NativeClassPtr);
					IConfigureGameOptions.Option.Choice.NativeFieldInfoPtr_choiceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IConfigureGameOptions.Option.Choice>.NativeClassPtr, "choiceName");
					IConfigureGameOptions.Option.Choice.NativeFieldInfoPtr_choiceLocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IConfigureGameOptions.Option.Choice>.NativeClassPtr, "choiceLocKey");
					IConfigureGameOptions.Option.Choice.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigureGameOptions.Option.Choice>.NativeClassPtr, 100666437);
				}

				// Token: 0x06003899 RID: 14489 RVA: 0x000D170C File Offset: 0x000CF90C
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 522220, RefRangeEnd = 522222, XrefRangeStart = 522214, XrefRangeEnd = 522220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Choice()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IConfigureGameOptions.Option.Choice>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IConfigureGameOptions.Option.Choice.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600389A RID: 14490 RVA: 0x0001D1FC File Offset: 0x0001B3FC
				public Choice(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170010BB RID: 4283
				// (get) Token: 0x0600389B RID: 14491 RVA: 0x000D1748 File Offset: 0x000CF948
				// (set) Token: 0x0600389C RID: 14492 RVA: 0x0001D205 File Offset: 0x0001B405
				public unsafe string choiceName
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IConfigureGameOptions.Option.Choice.NativeFieldInfoPtr_choiceName);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IConfigureGameOptions.Option.Choice.NativeFieldInfoPtr_choiceName), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x170010BC RID: 4284
				// (get) Token: 0x0600389D RID: 14493 RVA: 0x000D1770 File Offset: 0x000CF970
				// (set) Token: 0x0600389E RID: 14494 RVA: 0x0001D224 File Offset: 0x0001B424
				public unsafe string choiceLocKey
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IConfigureGameOptions.Option.Choice.NativeFieldInfoPtr_choiceLocKey);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IConfigureGameOptions.Option.Choice.NativeFieldInfoPtr_choiceLocKey), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x040022C3 RID: 8899
				private static readonly IntPtr NativeFieldInfoPtr_choiceName;

				// Token: 0x040022C4 RID: 8900
				private static readonly IntPtr NativeFieldInfoPtr_choiceLocKey;

				// Token: 0x040022C5 RID: 8901
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
			}
		}
	}
}
