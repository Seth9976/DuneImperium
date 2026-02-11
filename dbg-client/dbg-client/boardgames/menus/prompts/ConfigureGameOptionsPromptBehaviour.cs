using System;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace boardgames.menus.prompts
{
	// Token: 0x020001C8 RID: 456
	public class ConfigureGameOptionsPromptBehaviour<T> : PromptBehaviour<T> where T : class
	{
		// Token: 0x060014A0 RID: 5280 RVA: 0x00060374 File Offset: 0x0005E574
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigureGameOptionsPromptBehaviour()
		{
			Il2CppClassPointerStore<ConfigureGameOptionsPromptBehaviour<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "ConfigureGameOptionsPromptBehaviour`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigureGameOptionsPromptBehaviour<T>>.NativeClassPtr);
			ConfigureGameOptionsPromptBehaviour<T>.NativeFieldInfoPtr_gameOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureGameOptionsPromptBehaviour<T>>.NativeClassPtr, "gameOptions");
			ConfigureGameOptionsPromptBehaviour<T>.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionsPromptBehaviour<T>>.NativeClassPtr, 100666319);
			ConfigureGameOptionsPromptBehaviour<T>.NativeMethodInfoPtr_GetGameOption_Public_Virtual_Final_New_Option_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionsPromptBehaviour<T>>.NativeClassPtr, 100666320);
			ConfigureGameOptionsPromptBehaviour<T>.NativeMethodInfoPtr_GetGameOptionOnThis_Public_Virtual_Final_New_Option_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionsPromptBehaviour<T>>.NativeClassPtr, 100666321);
			ConfigureGameOptionsPromptBehaviour<T>.NativeMethodInfoPtr_SelectOption_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionsPromptBehaviour<T>>.NativeClassPtr, 100666322);
			ConfigureGameOptionsPromptBehaviour<T>.NativeMethodInfoPtr_SelectOptionByValue_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionsPromptBehaviour<T>>.NativeClassPtr, 100666323);
			ConfigureGameOptionsPromptBehaviour<T>.NativeMethodInfoPtr_GetOptionSelected_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionsPromptBehaviour<T>>.NativeClassPtr, 100666324);
			ConfigureGameOptionsPromptBehaviour<T>.NativeMethodInfoPtr_GetOptionValueSelected_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionsPromptBehaviour<T>>.NativeClassPtr, 100666325);
			ConfigureGameOptionsPromptBehaviour<T>.NativeMethodInfoPtr_GetOptionNameLocalizedText_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionsPromptBehaviour<T>>.NativeClassPtr, 100666326);
			ConfigureGameOptionsPromptBehaviour<T>.NativeMethodInfoPtr_GetOptionSelectedLocalizedText_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionsPromptBehaviour<T>>.NativeClassPtr, 100666327);
			ConfigureGameOptionsPromptBehaviour<T>.NativeMethodInfoPtr_GetOptionLocKey_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionsPromptBehaviour<T>>.NativeClassPtr, 100666328);
			ConfigureGameOptionsPromptBehaviour<T>.NativeMethodInfoPtr_IncrementOption_Public_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionsPromptBehaviour<T>>.NativeClassPtr, 100666329);
			ConfigureGameOptionsPromptBehaviour<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionsPromptBehaviour<T>>.NativeClassPtr, 100666330);
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x000604E4 File Offset: 0x0005E6E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 520861, RefRangeEnd = 520864, XrefRangeStart = 520859, XrefRangeEnd = 520861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigureGameOptionsPromptBehaviour<T>.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014A2 RID: 5282 RVA: 0x00060520 File Offset: 0x0005E720
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 520882, RefRangeEnd = 520895, XrefRangeStart = 520864, XrefRangeEnd = 520882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IConfigureGameOptions.Option GetGameOption(string optionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(optionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameOptionsPromptBehaviour<T>.NativeMethodInfoPtr_GetGameOption_Public_Virtual_Final_New_Option_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConfigureGameOptions.Option>(intPtr3) : null;
			}
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x00060570 File Offset: 0x0005E770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520895, XrefRangeEnd = 520907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IConfigureGameOptions.Option GetGameOptionOnThis(string optionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(optionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameOptionsPromptBehaviour<T>.NativeMethodInfoPtr_GetGameOptionOnThis_Public_Virtual_Final_New_Option_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConfigureGameOptions.Option>(intPtr3) : null;
			}
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x000605C0 File Offset: 0x0005E7C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520907, XrefRangeEnd = 520923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectOption(string optionName, string newOptionValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(optionName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newOptionValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameOptionsPromptBehaviour<T>.NativeMethodInfoPtr_SelectOption_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x00060614 File Offset: 0x0005E814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520923, XrefRangeEnd = 520925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectOptionByValue(string optionName, int newOptionValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(optionName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newOptionValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameOptionsPromptBehaviour<T>.NativeMethodInfoPtr_SelectOptionByValue_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x00060664 File Offset: 0x0005E864
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 520928, RefRangeEnd = 520929, XrefRangeStart = 520925, XrefRangeEnd = 520928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetOptionSelected(string optionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(optionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameOptionsPromptBehaviour<T>.NativeMethodInfoPtr_GetOptionSelected_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x000606AC File Offset: 0x0005E8AC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 520930, RefRangeEnd = 520936, XrefRangeStart = 520929, XrefRangeEnd = 520930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetOptionValueSelected(string optionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(optionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameOptionsPromptBehaviour<T>.NativeMethodInfoPtr_GetOptionValueSelected_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x000606FC File Offset: 0x0005E8FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520936, XrefRangeEnd = 520943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetOptionNameLocalizedText(string optionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(optionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameOptionsPromptBehaviour<T>.NativeMethodInfoPtr_GetOptionNameLocalizedText_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x00060744 File Offset: 0x0005E944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520943, XrefRangeEnd = 520951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetOptionSelectedLocalizedText(string optionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(optionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameOptionsPromptBehaviour<T>.NativeMethodInfoPtr_GetOptionSelectedLocalizedText_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x0006078C File Offset: 0x0005E98C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520951, XrefRangeEnd = 520954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetOptionLocKey(string optionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(optionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameOptionsPromptBehaviour<T>.NativeMethodInfoPtr_GetOptionLocKey_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x000607D4 File Offset: 0x0005E9D4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 520956, RefRangeEnd = 520961, XrefRangeStart = 520954, XrefRangeEnd = 520956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IncrementOption(string optionName, int change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(optionName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameOptionsPromptBehaviour<T>.NativeMethodInfoPtr_IncrementOption_Public_Int32_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x00060830 File Offset: 0x0005EA30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 520966, RefRangeEnd = 520968, XrefRangeStart = 520961, XrefRangeEnd = 520966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigureGameOptionsPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigureGameOptionsPromptBehaviour<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameOptionsPromptBehaviour<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x0000BB4A File Offset: 0x00009D4A
		public ConfigureGameOptionsPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x060014AE RID: 5294 RVA: 0x0006086C File Offset: 0x0005EA6C
		// (set) Token: 0x060014AF RID: 5295 RVA: 0x0000BB53 File Offset: 0x00009D53
		public unsafe Il2CppReferenceArray<IConfigureGameOptions.Option> gameOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOptionsPromptBehaviour<T>.NativeFieldInfoPtr_gameOptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IConfigureGameOptions.Option>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOptionsPromptBehaviour<T>.NativeFieldInfoPtr_gameOptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CC2 RID: 3266
		private static readonly IntPtr NativeFieldInfoPtr_gameOptions;

		// Token: 0x04000CC3 RID: 3267
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04000CC4 RID: 3268
		private static readonly IntPtr NativeMethodInfoPtr_GetGameOption_Public_Virtual_Final_New_Option_String_0;

		// Token: 0x04000CC5 RID: 3269
		private static readonly IntPtr NativeMethodInfoPtr_GetGameOptionOnThis_Public_Virtual_Final_New_Option_String_0;

		// Token: 0x04000CC6 RID: 3270
		private static readonly IntPtr NativeMethodInfoPtr_SelectOption_Public_Void_String_String_0;

		// Token: 0x04000CC7 RID: 3271
		private static readonly IntPtr NativeMethodInfoPtr_SelectOptionByValue_Public_Void_String_Int32_0;

		// Token: 0x04000CC8 RID: 3272
		private static readonly IntPtr NativeMethodInfoPtr_GetOptionSelected_Public_String_String_0;

		// Token: 0x04000CC9 RID: 3273
		private static readonly IntPtr NativeMethodInfoPtr_GetOptionValueSelected_Public_Int32_String_0;

		// Token: 0x04000CCA RID: 3274
		private static readonly IntPtr NativeMethodInfoPtr_GetOptionNameLocalizedText_Public_String_String_0;

		// Token: 0x04000CCB RID: 3275
		private static readonly IntPtr NativeMethodInfoPtr_GetOptionSelectedLocalizedText_Public_String_String_0;

		// Token: 0x04000CCC RID: 3276
		private static readonly IntPtr NativeMethodInfoPtr_GetOptionLocKey_Public_String_String_0;

		// Token: 0x04000CCD RID: 3277
		private static readonly IntPtr NativeMethodInfoPtr_IncrementOption_Public_Int32_String_Int32_0;

		// Token: 0x04000CCE RID: 3278
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003B4 RID: 948
		[ObfuscatedName("boardgames.menus.prompts.ConfigureGameOptionsPromptBehaviour`1+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06002C4E RID: 11342 RVA: 0x000ACEA8 File Offset: 0x000AB0A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<ConfigureGameOptionsPromptBehaviour<T>.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigureGameOptionsPromptBehaviour<T>>.NativeClassPtr, "<>c__DisplayClass3_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigureGameOptionsPromptBehaviour<T>.__c__DisplayClass3_0>.NativeClassPtr);
				ConfigureGameOptionsPromptBehaviour<T>.__c__DisplayClass3_0.NativeFieldInfoPtr_optionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureGameOptionsPromptBehaviour<T>.__c__DisplayClass3_0>.NativeClassPtr, "optionName");
				ConfigureGameOptionsPromptBehaviour<T>.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionsPromptBehaviour<T>.__c__DisplayClass3_0>.NativeClassPtr, 100666331);
				ConfigureGameOptionsPromptBehaviour<T>.__c__DisplayClass3_0.NativeMethodInfoPtr__GetGameOptionOnThis_b__0_Internal_Boolean_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionsPromptBehaviour<T>.__c__DisplayClass3_0>.NativeClassPtr, 100666332);
			}

			// Token: 0x06002C4F RID: 11343 RVA: 0x000ACF4C File Offset: 0x000AB14C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigureGameOptionsPromptBehaviour<T>.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameOptionsPromptBehaviour<T>.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C50 RID: 11344 RVA: 0x000ACF88 File Offset: 0x000AB188
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520857, XrefRangeEnd = 520859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetGameOptionOnThis_b__0(IConfigureGameOptions.Option option)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameOptionsPromptBehaviour<T>.__c__DisplayClass3_0.NativeMethodInfoPtr__GetGameOptionOnThis_b__0_Internal_Boolean_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002C51 RID: 11345 RVA: 0x00016ECE File Offset: 0x000150CE
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C92 RID: 3218
			// (get) Token: 0x06002C52 RID: 11346 RVA: 0x000ACFD8 File Offset: 0x000AB1D8
			// (set) Token: 0x06002C53 RID: 11347 RVA: 0x00016ED7 File Offset: 0x000150D7
			public unsafe string optionName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOptionsPromptBehaviour<T>.__c__DisplayClass3_0.NativeFieldInfoPtr_optionName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOptionsPromptBehaviour<T>.__c__DisplayClass3_0.NativeFieldInfoPtr_optionName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04001B8C RID: 7052
			private static readonly IntPtr NativeFieldInfoPtr_optionName;

			// Token: 0x04001B8D RID: 7053
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001B8E RID: 7054
			private static readonly IntPtr NativeMethodInfoPtr__GetGameOptionOnThis_b__0_Internal_Boolean_Option_0;
		}

		// Token: 0x020003B5 RID: 949
		[ObfuscatedName("boardgames.menus.prompts.ConfigureGameOptionsPromptBehaviour`1+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x06002C54 RID: 11348 RVA: 0x000AD000 File Offset: 0x000AB200
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<ConfigureGameOptionsPromptBehaviour<T>.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigureGameOptionsPromptBehaviour<T>>.NativeClassPtr, "<>c__DisplayClass4_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigureGameOptionsPromptBehaviour<T>.__c__DisplayClass4_0>.NativeClassPtr);
				ConfigureGameOptionsPromptBehaviour<T>.__c__DisplayClass4_0.NativeFieldInfoPtr_newOptionValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureGameOptionsPromptBehaviour<T>.__c__DisplayClass4_0>.NativeClassPtr, "newOptionValue");
				ConfigureGameOptionsPromptBehaviour<T>.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionsPromptBehaviour<T>.__c__DisplayClass4_0>.NativeClassPtr, 100666333);
				ConfigureGameOptionsPromptBehaviour<T>.__c__DisplayClass4_0.NativeMethodInfoPtr__SelectOption_b__0_Internal_Boolean_Choice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGameOptionsPromptBehaviour<T>.__c__DisplayClass4_0>.NativeClassPtr, 100666334);
			}

			// Token: 0x06002C55 RID: 11349 RVA: 0x000AD0A4 File Offset: 0x000AB2A4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigureGameOptionsPromptBehaviour<T>.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameOptionsPromptBehaviour<T>.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C56 RID: 11350 RVA: 0x000AD0E0 File Offset: 0x000AB2E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SelectOption_b__0(IConfigureGameOptions.Option.Choice choice)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(choice);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGameOptionsPromptBehaviour<T>.__c__DisplayClass4_0.NativeMethodInfoPtr__SelectOption_b__0_Internal_Boolean_Choice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002C57 RID: 11351 RVA: 0x00016EF6 File Offset: 0x000150F6
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C93 RID: 3219
			// (get) Token: 0x06002C58 RID: 11352 RVA: 0x000AD130 File Offset: 0x000AB330
			// (set) Token: 0x06002C59 RID: 11353 RVA: 0x00016EFF File Offset: 0x000150FF
			public unsafe string newOptionValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOptionsPromptBehaviour<T>.__c__DisplayClass4_0.NativeFieldInfoPtr_newOptionValue);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGameOptionsPromptBehaviour<T>.__c__DisplayClass4_0.NativeFieldInfoPtr_newOptionValue), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04001B8F RID: 7055
			private static readonly IntPtr NativeFieldInfoPtr_newOptionValue;

			// Token: 0x04001B90 RID: 7056
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001B91 RID: 7057
			private static readonly IntPtr NativeMethodInfoPtr__SelectOption_b__0_Internal_Boolean_Choice_0;
		}
	}
}
