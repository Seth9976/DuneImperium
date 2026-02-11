using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.IO;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text.RegularExpressions;

namespace Il2CppMono.Options
{
	// Token: 0x02000011 RID: 17
	public class OptionSet : KeyedCollection<string, Option>
	{
		// Token: 0x060000D0 RID: 208 RVA: 0x00007D88 File Offset: 0x00005F88
		// Note: this type is marked as 'beforefieldinit'.
		static OptionSet()
		{
			Il2CppClassPointerStore<OptionSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "Mono.Options", "OptionSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionSet>.NativeClassPtr);
			OptionSet.NativeFieldInfoPtr_localizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, "localizer");
			OptionSet.NativeFieldInfoPtr_sources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, "sources");
			OptionSet.NativeFieldInfoPtr_roSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, "roSources");
			OptionSet.NativeFieldInfoPtr_ValueOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, "ValueOption");
			OptionSet.NativeFieldInfoPtr_OptionWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, "OptionWidth");
			OptionSet.NativeFieldInfoPtr_Description_FirstWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, "Description_FirstWidth");
			OptionSet.NativeFieldInfoPtr_Description_RemWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, "Description_RemWidth");
			OptionSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663447);
			OptionSet.NativeMethodInfoPtr__ctor_Public_Void_Converter_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663448);
			OptionSet.NativeMethodInfoPtr_get_MessageLocalizer_Public_get_Converter_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663449);
			OptionSet.NativeMethodInfoPtr_get_ArgumentSources_Public_get_ReadOnlyCollection_1_ArgumentSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663450);
			OptionSet.NativeMethodInfoPtr_GetKeyForItem_Protected_Virtual_String_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663451);
			OptionSet.NativeMethodInfoPtr_GetOptionForName_Protected_Option_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663452);
			OptionSet.NativeMethodInfoPtr_InsertItem_Protected_Virtual_Void_Int32_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663453);
			OptionSet.NativeMethodInfoPtr_RemoveItem_Protected_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663454);
			OptionSet.NativeMethodInfoPtr_SetItem_Protected_Virtual_Void_Int32_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663455);
			OptionSet.NativeMethodInfoPtr_AddImpl_Private_Void_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663456);
			OptionSet.NativeMethodInfoPtr_Add_Public_OptionSet_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663457);
			OptionSet.NativeMethodInfoPtr_Add_Public_OptionSet_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663458);
			OptionSet.NativeMethodInfoPtr_Add_Public_OptionSet_String_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663459);
			OptionSet.NativeMethodInfoPtr_Add_Public_OptionSet_String_String_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663460);
			OptionSet.NativeMethodInfoPtr_Add_Public_OptionSet_String_String_Action_1_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663461);
			OptionSet.NativeMethodInfoPtr_Add_Public_OptionSet_String_OptionAction_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663462);
			OptionSet.NativeMethodInfoPtr_Add_Public_OptionSet_String_String_OptionAction_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663463);
			OptionSet.NativeMethodInfoPtr_Add_Public_OptionSet_String_String_OptionAction_2_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663464);
			OptionSet.NativeMethodInfoPtr_Add_Public_OptionSet_String_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663465);
			OptionSet.NativeMethodInfoPtr_Add_Public_OptionSet_String_String_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663466);
			OptionSet.NativeMethodInfoPtr_Add_Public_OptionSet_String_OptionAction_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663467);
			OptionSet.NativeMethodInfoPtr_Add_Public_OptionSet_String_String_OptionAction_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663468);
			OptionSet.NativeMethodInfoPtr_Add_Public_OptionSet_ArgumentSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663469);
			OptionSet.NativeMethodInfoPtr_CreateOptionContext_Protected_Virtual_New_OptionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663470);
			OptionSet.NativeMethodInfoPtr_Parse_Public_List_1_String_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663471);
			OptionSet.NativeMethodInfoPtr_AddSource_Private_Boolean_ArgumentEnumerator_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663472);
			OptionSet.NativeMethodInfoPtr_Unprocessed_Private_Static_Boolean_ICollection_1_String_Option_OptionContext_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663473);
			OptionSet.NativeMethodInfoPtr_GetOptionParts_Protected_Boolean_String_byref_String_byref_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663474);
			OptionSet.NativeMethodInfoPtr_Parse_Protected_Virtual_New_Boolean_String_OptionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663475);
			OptionSet.NativeMethodInfoPtr_ParseValue_Private_Void_String_OptionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663476);
			OptionSet.NativeMethodInfoPtr_ParseBool_Private_Boolean_String_String_OptionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663477);
			OptionSet.NativeMethodInfoPtr_ParseBundledValue_Private_Boolean_String_String_OptionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663478);
			OptionSet.NativeMethodInfoPtr_Invoke_Private_Static_Void_OptionContext_String_String_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663479);
			OptionSet.NativeMethodInfoPtr_WriteOptionDescriptions_Public_Void_TextWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663480);
			OptionSet.NativeMethodInfoPtr_WriteDescription_Private_Void_TextWriter_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663481);
			OptionSet.NativeMethodInfoPtr_WriteOptionPrototype_Private_Boolean_TextWriter_Option_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663482);
			OptionSet.NativeMethodInfoPtr_GetNextOptionIndex_Private_Static_Int32_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663483);
			OptionSet.NativeMethodInfoPtr_Write_Private_Static_Void_TextWriter_byref_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663484);
			OptionSet.NativeMethodInfoPtr_GetArgumentName_Private_Static_String_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663485);
			OptionSet.NativeMethodInfoPtr_GetDescription_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663486);
			OptionSet.NativeMethodInfoPtr_GetLines_Private_Static_IEnumerable_1_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, 100663487);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00008178 File Offset: 0x00006378
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1166488, RefRangeEnd = 1166490, XrefRangeStart = 1166448, XrefRangeEnd = 1166488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionSet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionSet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000081B4 File Offset: 0x000063B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166490, XrefRangeEnd = 1166515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionSet(Converter<string, string> localizer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionSet>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(localizer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.NativeMethodInfoPtr__ctor_Public_Void_Converter_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00008200 File Offset: 0x00006400
		public unsafe Converter<string, string> MessageLocalizer
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.NativeMethodInfoPtr_get_MessageLocalizer_Public_get_Converter_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Converter<string, string>>(intPtr3) : null;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00008240 File Offset: 0x00006440
		public unsafe ReadOnlyCollection<ArgumentSource> ArgumentSources
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.NativeMethodInfoPtr_get_ArgumentSources_Public_get_ReadOnlyCollection_1_ArgumentSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<ArgumentSource>>(intPtr3) : null;
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00008280 File Offset: 0x00006480
		[CallerCount(0)]
		public unsafe override string GetKeyForItem(Option item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionSet.NativeMethodInfoPtr_GetKeyForItem_Protected_Virtual_String_Option_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000082D4 File Offset: 0x000064D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166515, XrefRangeEnd = 1166519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Option GetOptionForName(string option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(option);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.NativeMethodInfoPtr_GetOptionForName_Protected_Option_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Option>(intPtr3) : null;
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00008324 File Offset: 0x00006524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166519, XrefRangeEnd = 1166523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InsertItem(int index, Option item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionSet.NativeMethodInfoPtr_InsertItem_Protected_Virtual_Void_Int32_Option_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00008380 File Offset: 0x00006580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166523, XrefRangeEnd = 1166537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RemoveItem(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionSet.NativeMethodInfoPtr_RemoveItem_Protected_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000083CC File Offset: 0x000065CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166537, XrefRangeEnd = 1166541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetItem(int index, Option item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionSet.NativeMethodInfoPtr_SetItem_Protected_Virtual_Void_Int32_Option_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00008428 File Offset: 0x00006628
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1166575, RefRangeEnd = 1166577, XrefRangeStart = 1166541, XrefRangeEnd = 1166575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddImpl(Option option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.NativeMethodInfoPtr_AddImpl_Private_Void_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000846C File Offset: 0x0000666C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166577, XrefRangeEnd = 1166590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionSet Add(string header)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(header);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.NativeMethodInfoPtr_Add_Public_OptionSet_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<OptionSet>(intPtr3) : null;
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000084BC File Offset: 0x000066BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1166593, RefRangeEnd = 1166595, XrefRangeStart = 1166590, XrefRangeEnd = 1166593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe OptionSet Add(Option option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.NativeMethodInfoPtr_Add_Public_OptionSet_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<OptionSet>(intPtr3) : null;
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000850C File Offset: 0x0000670C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166595, XrefRangeEnd = 1166596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionSet Add(string prototype, Action<string> action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prototype);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.NativeMethodInfoPtr_Add_Public_OptionSet_String_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OptionSet>(intPtr3) : null;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00008570 File Offset: 0x00006770
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1166597, RefRangeEnd = 1166598, XrefRangeStart = 1166596, XrefRangeEnd = 1166597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionSet Add(string prototype, string description, Action<string> action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prototype);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.NativeMethodInfoPtr_Add_Public_OptionSet_String_String_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OptionSet>(intPtr3) : null;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000085E4 File Offset: 0x000067E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1166620, RefRangeEnd = 1166623, XrefRangeStart = 1166598, XrefRangeEnd = 1166620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionSet Add(string prototype, string description, Action<string> action, bool hidden)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prototype);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hidden;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.NativeMethodInfoPtr_Add_Public_OptionSet_String_String_Action_1_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OptionSet>(intPtr3) : null;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00008668 File Offset: 0x00006868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166623, XrefRangeEnd = 1166624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionSet Add(string prototype, OptionAction<string, string> action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prototype);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.NativeMethodInfoPtr_Add_Public_OptionSet_String_OptionAction_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OptionSet>(intPtr3) : null;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000086CC File Offset: 0x000068CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166624, XrefRangeEnd = 1166625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionSet Add(string prototype, string description, OptionAction<string, string> action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prototype);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.NativeMethodInfoPtr_Add_Public_OptionSet_String_String_OptionAction_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OptionSet>(intPtr3) : null;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00008740 File Offset: 0x00006940
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1166647, RefRangeEnd = 1166649, XrefRangeStart = 1166625, XrefRangeEnd = 1166647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionSet Add(string prototype, string description, OptionAction<string, string> action, bool hidden)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prototype);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hidden;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.NativeMethodInfoPtr_Add_Public_OptionSet_String_String_OptionAction_2_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OptionSet>(intPtr3) : null;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000087C4 File Offset: 0x000069C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166649, XrefRangeEnd = 1166650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionSet Add<T>(string prototype, Action<T> action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prototype);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.MethodInfoStoreGeneric_Add_Public_OptionSet_String_Action_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OptionSet>(intPtr3) : null;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00008828 File Offset: 0x00006A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166650, XrefRangeEnd = 1166654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionSet Add<T>(string prototype, string description, Action<T> action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prototype);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.MethodInfoStoreGeneric_Add_Public_OptionSet_String_String_Action_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OptionSet>(intPtr3) : null;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000889C File Offset: 0x00006A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionSet Add<TKey, TValue>(string prototype, OptionAction<TKey, TValue> action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prototype);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.MethodInfoStoreGeneric_Add_Public_OptionSet_String_OptionAction_2_TKey_TValue_0<TKey, TValue>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OptionSet>(intPtr3) : null;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00008900 File Offset: 0x00006B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionSet Add<TKey, TValue>(string prototype, string description, OptionAction<TKey, TValue> action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prototype);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.MethodInfoStoreGeneric_Add_Public_OptionSet_String_String_OptionAction_2_TKey_TValue_0<TKey, TValue>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OptionSet>(intPtr3) : null;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00008974 File Offset: 0x00006B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166654, XrefRangeEnd = 1166657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionSet Add(ArgumentSource source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.NativeMethodInfoPtr_Add_Public_OptionSet_ArgumentSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<OptionSet>(intPtr3) : null;
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000089C4 File Offset: 0x00006BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166657, XrefRangeEnd = 1166675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual OptionContext CreateOptionContext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionSet.NativeMethodInfoPtr_CreateOptionContext_Protected_Virtual_New_OptionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OptionContext>(intPtr3) : null;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00008A10 File Offset: 0x00006C10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1166748, RefRangeEnd = 1166750, XrefRangeStart = 1166675, XrefRangeEnd = 1166748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<string> Parse(IEnumerable<string> arguments)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arguments);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.NativeMethodInfoPtr_Parse_Public_List_1_String_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00008A60 File Offset: 0x00006C60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1166766, RefRangeEnd = 1166767, XrefRangeStart = 1166750, XrefRangeEnd = 1166766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddSource(OptionSet.ArgumentEnumerator ae, string argument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ae);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(argument);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.NativeMethodInfoPtr_AddSource_Private_Boolean_ArgumentEnumerator_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00008AC0 File Offset: 0x00006CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166767, XrefRangeEnd = 1166771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Unprocessed(ICollection<string> extra, Option def, OptionContext c, string argument)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extra);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(def);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(argument);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.NativeMethodInfoPtr_Unprocessed_Private_Static_Boolean_ICollection_1_String_Option_OptionContext_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00008B38 File Offset: 0x00006D38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1166803, RefRangeEnd = 1166804, XrefRangeStart = 1166771, XrefRangeEnd = 1166803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetOptionParts(string argument, out string flag, out string name, out string sep, out string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(argument);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4 = 0;
			ptr5 = &intPtr4;
			IntPtr intPtr6;
			IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(OptionSet.NativeMethodInfoPtr_GetOptionParts_Protected_Boolean_String_byref_String_byref_String_byref_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr6);
			Il2CppException.RaiseExceptionIfNecessary(intPtr6);
			flag = IL2CPP.Il2CppStringToManaged(intPtr);
			name = IL2CPP.Il2CppStringToManaged(intPtr2);
			sep = IL2CPP.Il2CppStringToManaged(intPtr3);
			value = IL2CPP.Il2CppStringToManaged(intPtr4);
			return *IL2CPP.il2cpp_object_unbox(intPtr5);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00008BF4 File Offset: 0x00006DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166804, XrefRangeEnd = 1166841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Parse(string argument, OptionContext c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(argument);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionSet.NativeMethodInfoPtr_Parse_Protected_Virtual_New_Boolean_String_OptionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00008C60 File Offset: 0x00006E60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1166857, RefRangeEnd = 1166859, XrefRangeStart = 1166841, XrefRangeEnd = 1166857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseValue(string option, OptionContext c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(option);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.NativeMethodInfoPtr_ParseValue_Private_Void_String_OptionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00008CB4 File Offset: 0x00006EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166859, XrefRangeEnd = 1166873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseBool(string option, string n, OptionContext c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(option);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(n);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.NativeMethodInfoPtr_ParseBool_Private_Boolean_String_String_OptionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00008D28 File Offset: 0x00006F28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1166900, RefRangeEnd = 1166901, XrefRangeStart = 1166873, XrefRangeEnd = 1166900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseBundledValue(string f, string n, OptionContext c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(f);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(n);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.NativeMethodInfoPtr_ParseBundledValue_Private_Boolean_String_String_OptionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00008D9C File Offset: 0x00006F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166901, XrefRangeEnd = 1166906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Invoke(OptionContext c, string name, string value, Option option)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.NativeMethodInfoPtr_Invoke_Private_Static_Void_OptionContext_String_String_Option_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00008E08 File Offset: 0x00007008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166906, XrefRangeEnd = 1166959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteOptionDescriptions(TextWriter o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.NativeMethodInfoPtr_WriteOptionDescriptions_Public_Void_TextWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00008E4C File Offset: 0x0000704C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1166988, RefRangeEnd = 1166991, XrefRangeStart = 1166959, XrefRangeEnd = 1166988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteDescription(TextWriter o, string value, string prefix, int firstWidth, int remWidth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref firstWidth;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref remWidth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.NativeMethodInfoPtr_WriteDescription_Private_Void_TextWriter_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00008ED0 File Offset: 0x000070D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1167027, RefRangeEnd = 1167028, XrefRangeStart = 1166991, XrefRangeEnd = 1167027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WriteOptionPrototype(TextWriter o, Option p, ref int written)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &written;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.NativeMethodInfoPtr_WriteOptionPrototype_Private_Boolean_TextWriter_Option_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00008F40 File Offset: 0x00007140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167028, XrefRangeEnd = 1167032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetNextOptionIndex(Il2CppStringArray names, int i)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(names);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.NativeMethodInfoPtr_GetNextOptionIndex_Private_Static_Int32_Il2CppStringArray_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00008F90 File Offset: 0x00007190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167032, XrefRangeEnd = 1167033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write(TextWriter o, ref int n, string s)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &n;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.NativeMethodInfoPtr_Write_Private_Static_Void_TextWriter_byref_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00008FE8 File Offset: 0x000071E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1167057, RefRangeEnd = 1167059, XrefRangeStart = 1167033, XrefRangeEnd = 1167057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetArgumentName(int index, int maxIndex, string description)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.NativeMethodInfoPtr_GetArgumentName_Private_Static_String_Int32_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00009040 File Offset: 0x00007240
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1167081, RefRangeEnd = 1167082, XrefRangeStart = 1167059, XrefRangeEnd = 1167081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDescription(string description)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(description);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.NativeMethodInfoPtr_GetDescription_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000907C File Offset: 0x0000727C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167082, XrefRangeEnd = 1167092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<string> GetLines(string description, int firstWidth, int remWidth)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(description);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref firstWidth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref remWidth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.NativeMethodInfoPtr_GetLines_Private_Static_IEnumerable_1_String_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002499 File Offset: 0x00000699
		public OptionSet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000FB RID: 251 RVA: 0x000090DC File Offset: 0x000072DC
		// (set) Token: 0x060000FC RID: 252 RVA: 0x000024A2 File Offset: 0x000006A2
		public unsafe Converter<string, string> localizer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionSet.NativeFieldInfoPtr_localizer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Converter<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionSet.NativeFieldInfoPtr_localizer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000FD RID: 253 RVA: 0x0000910C File Offset: 0x0000730C
		// (set) Token: 0x060000FE RID: 254 RVA: 0x000024C1 File Offset: 0x000006C1
		public unsafe List<ArgumentSource> sources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionSet.NativeFieldInfoPtr_sources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArgumentSource>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionSet.NativeFieldInfoPtr_sources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000FF RID: 255 RVA: 0x0000913C File Offset: 0x0000733C
		// (set) Token: 0x06000100 RID: 256 RVA: 0x000024E0 File Offset: 0x000006E0
		public unsafe ReadOnlyCollection<ArgumentSource> roSources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionSet.NativeFieldInfoPtr_roSources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<ArgumentSource>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionSet.NativeFieldInfoPtr_roSources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000101 RID: 257 RVA: 0x0000916C File Offset: 0x0000736C
		// (set) Token: 0x06000102 RID: 258 RVA: 0x000024FF File Offset: 0x000006FF
		public unsafe Regex ValueOption
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionSet.NativeFieldInfoPtr_ValueOption);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionSet.NativeFieldInfoPtr_ValueOption), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000103 RID: 259 RVA: 0x0000919C File Offset: 0x0000739C
		// (set) Token: 0x06000104 RID: 260 RVA: 0x0000251E File Offset: 0x0000071E
		public unsafe static int OptionWidth
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(OptionSet.NativeFieldInfoPtr_OptionWidth, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OptionSet.NativeFieldInfoPtr_OptionWidth, (void*)(&value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000105 RID: 261 RVA: 0x000091B8 File Offset: 0x000073B8
		// (set) Token: 0x06000106 RID: 262 RVA: 0x0000252C File Offset: 0x0000072C
		public unsafe static int Description_FirstWidth
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(OptionSet.NativeFieldInfoPtr_Description_FirstWidth, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OptionSet.NativeFieldInfoPtr_Description_FirstWidth, (void*)(&value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000107 RID: 263 RVA: 0x000091D4 File Offset: 0x000073D4
		// (set) Token: 0x06000108 RID: 264 RVA: 0x0000253A File Offset: 0x0000073A
		public unsafe static int Description_RemWidth
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(OptionSet.NativeFieldInfoPtr_Description_RemWidth, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OptionSet.NativeFieldInfoPtr_Description_RemWidth, (void*)(&value));
			}
		}

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeFieldInfoPtr_localizer;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeFieldInfoPtr_sources;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeFieldInfoPtr_roSources;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeFieldInfoPtr_ValueOption;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeFieldInfoPtr_OptionWidth;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeFieldInfoPtr_Description_FirstWidth;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeFieldInfoPtr_Description_RemWidth;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Converter_2_String_String_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_get_MessageLocalizer_Public_get_Converter_2_String_String_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_get_ArgumentSources_Public_get_ReadOnlyCollection_1_ArgumentSource_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyForItem_Protected_Virtual_String_Option_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_GetOptionForName_Protected_Option_String_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_InsertItem_Protected_Virtual_Void_Int32_Option_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItem_Protected_Virtual_Void_Int32_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_SetItem_Protected_Virtual_Void_Int32_Option_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_AddImpl_Private_Void_Option_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_OptionSet_String_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_OptionSet_Option_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_OptionSet_String_Action_1_String_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_OptionSet_String_String_Action_1_String_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_OptionSet_String_String_Action_1_String_Boolean_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_OptionSet_String_OptionAction_2_String_String_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_OptionSet_String_String_OptionAction_2_String_String_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_OptionSet_String_String_OptionAction_2_String_String_Boolean_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_OptionSet_String_Action_1_T_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_OptionSet_String_String_Action_1_T_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_OptionSet_String_OptionAction_2_TKey_TValue_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_OptionSet_String_String_OptionAction_2_TKey_TValue_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_OptionSet_ArgumentSource_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_CreateOptionContext_Protected_Virtual_New_OptionContext_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_List_1_String_IEnumerable_1_String_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_AddSource_Private_Boolean_ArgumentEnumerator_String_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_Unprocessed_Private_Static_Boolean_ICollection_1_String_Option_OptionContext_String_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_GetOptionParts_Protected_Boolean_String_byref_String_byref_String_byref_String_byref_String_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Protected_Virtual_New_Boolean_String_OptionContext_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_ParseValue_Private_Void_String_OptionContext_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_ParseBool_Private_Boolean_String_String_OptionContext_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_ParseBundledValue_Private_Boolean_String_String_OptionContext_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Private_Static_Void_OptionContext_String_String_Option_0;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_WriteOptionDescriptions_Public_Void_TextWriter_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_WriteDescription_Private_Void_TextWriter_String_String_Int32_Int32_0;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_WriteOptionPrototype_Private_Boolean_TextWriter_Option_byref_Int32_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_GetNextOptionIndex_Private_Static_Int32_Il2CppStringArray_Int32_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_Write_Private_Static_Void_TextWriter_byref_Int32_String_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_GetArgumentName_Private_Static_String_Int32_Int32_String_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_GetDescription_Private_Static_String_String_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_GetLines_Private_Static_IEnumerable_1_String_String_Int32_Int32_0;

		// Token: 0x02000061 RID: 97
		public sealed class Category : Option
		{
			// Token: 0x06000407 RID: 1031 RVA: 0x00012504 File Offset: 0x00010704
			// Note: this type is marked as 'beforefieldinit'.
			static Category()
			{
				Il2CppClassPointerStore<OptionSet.Category>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, "Category");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionSet.Category>.NativeClassPtr);
				OptionSet.Category.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet.Category>.NativeClassPtr, 100663488);
				OptionSet.Category.NativeMethodInfoPtr_OnParseComplete_Protected_Virtual_Void_OptionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet.Category>.NativeClassPtr, 100663489);
			}

			// Token: 0x06000408 RID: 1032 RVA: 0x00012558 File Offset: 0x00010758
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166289, XrefRangeEnd = 1166296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Category(string description)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionSet.Category>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(description);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.Category.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000409 RID: 1033 RVA: 0x000125A4 File Offset: 0x000107A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166296, XrefRangeEnd = 1166302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void OnParseComplete(OptionContext c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.Category.NativeMethodInfoPtr_OnParseComplete_Protected_Virtual_Void_OptionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600040A RID: 1034 RVA: 0x00003FEB File Offset: 0x000021EB
			public Category(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400028B RID: 651
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

			// Token: 0x0400028C RID: 652
			private static readonly IntPtr NativeMethodInfoPtr_OnParseComplete_Protected_Virtual_Void_OptionContext_0;
		}

		// Token: 0x02000062 RID: 98
		public sealed class ActionOption : Option
		{
			// Token: 0x0600040B RID: 1035 RVA: 0x000125E8 File Offset: 0x000107E8
			// Note: this type is marked as 'beforefieldinit'.
			static ActionOption()
			{
				Il2CppClassPointerStore<OptionSet.ActionOption>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, "ActionOption");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionSet.ActionOption>.NativeClassPtr);
				OptionSet.ActionOption.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionSet.ActionOption>.NativeClassPtr, "action");
				OptionSet.ActionOption.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_Action_1_OptionValueCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet.ActionOption>.NativeClassPtr, 100663490);
				OptionSet.ActionOption.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_Action_1_OptionValueCollection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet.ActionOption>.NativeClassPtr, 100663491);
				OptionSet.ActionOption.NativeMethodInfoPtr_OnParseComplete_Protected_Virtual_Void_OptionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet.ActionOption>.NativeClassPtr, 100663492);
			}

			// Token: 0x0600040C RID: 1036 RVA: 0x00012664 File Offset: 0x00010864
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166302, XrefRangeEnd = 1166313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ActionOption(string prototype, string description, int count, Action<OptionValueCollection> action)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionSet.ActionOption>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prototype);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.ActionOption.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_Action_1_OptionValueCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600040D RID: 1037 RVA: 0x000126E4 File Offset: 0x000108E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166313, XrefRangeEnd = 1166324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ActionOption(string prototype, string description, int count, Action<OptionValueCollection> action, bool hidden)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionSet.ActionOption>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prototype);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hidden;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.ActionOption.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_Action_1_OptionValueCollection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600040E RID: 1038 RVA: 0x00012770 File Offset: 0x00010970
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166324, XrefRangeEnd = 1166325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void OnParseComplete(OptionContext c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.ActionOption.NativeMethodInfoPtr_OnParseComplete_Protected_Virtual_Void_OptionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600040F RID: 1039 RVA: 0x00003FF4 File Offset: 0x000021F4
			public ActionOption(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000112 RID: 274
			// (get) Token: 0x06000410 RID: 1040 RVA: 0x000127B4 File Offset: 0x000109B4
			// (set) Token: 0x06000411 RID: 1041 RVA: 0x00003FFD File Offset: 0x000021FD
			public unsafe Action<OptionValueCollection> action
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionSet.ActionOption.NativeFieldInfoPtr_action);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<OptionValueCollection>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionSet.ActionOption.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400028D RID: 653
			private static readonly IntPtr NativeFieldInfoPtr_action;

			// Token: 0x0400028E RID: 654
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_Action_1_OptionValueCollection_0;

			// Token: 0x0400028F RID: 655
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_Action_1_OptionValueCollection_Boolean_0;

			// Token: 0x04000290 RID: 656
			private static readonly IntPtr NativeMethodInfoPtr_OnParseComplete_Protected_Virtual_Void_OptionContext_0;
		}

		// Token: 0x02000063 RID: 99
		public sealed class ActionOption<T> : Option
		{
			// Token: 0x06000412 RID: 1042 RVA: 0x000127E4 File Offset: 0x000109E4
			// Note: this type is marked as 'beforefieldinit'.
			static ActionOption()
			{
				Il2CppClassPointerStore<OptionSet.ActionOption<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, "ActionOption`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionSet.ActionOption<T>>.NativeClassPtr);
				OptionSet.ActionOption<T>.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionSet.ActionOption<T>>.NativeClassPtr, "action");
				OptionSet.ActionOption<T>.NativeMethodInfoPtr__ctor_Public_Void_String_String_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet.ActionOption<T>>.NativeClassPtr, 100663493);
				OptionSet.ActionOption<T>.NativeMethodInfoPtr_OnParseComplete_Protected_Virtual_Void_OptionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet.ActionOption<T>>.NativeClassPtr, 100663494);
			}

			// Token: 0x06000413 RID: 1043 RVA: 0x00012888 File Offset: 0x00010A88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166325, XrefRangeEnd = 1166335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ActionOption(string prototype, string description, Action<T> action)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionSet.ActionOption<T>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prototype);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.ActionOption<T>.NativeMethodInfoPtr__ctor_Public_Void_String_String_Action_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000414 RID: 1044 RVA: 0x000128F8 File Offset: 0x00010AF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166335, XrefRangeEnd = 1166340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void OnParseComplete(OptionContext c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.ActionOption<T>.NativeMethodInfoPtr_OnParseComplete_Protected_Virtual_Void_OptionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000415 RID: 1045 RVA: 0x0000401C File Offset: 0x0000221C
			public ActionOption(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000113 RID: 275
			// (get) Token: 0x06000416 RID: 1046 RVA: 0x0001293C File Offset: 0x00010B3C
			// (set) Token: 0x06000417 RID: 1047 RVA: 0x00004025 File Offset: 0x00002225
			public unsafe Action<T> action
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionSet.ActionOption<T>.NativeFieldInfoPtr_action);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionSet.ActionOption<T>.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000291 RID: 657
			private static readonly IntPtr NativeFieldInfoPtr_action;

			// Token: 0x04000292 RID: 658
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Action_1_T_0;

			// Token: 0x04000293 RID: 659
			private static readonly IntPtr NativeMethodInfoPtr_OnParseComplete_Protected_Virtual_Void_OptionContext_0;
		}

		// Token: 0x02000064 RID: 100
		public sealed class ActionOption<TKey, TValue> : Option
		{
			// Token: 0x06000418 RID: 1048 RVA: 0x0001296C File Offset: 0x00010B6C
			// Note: this type is marked as 'beforefieldinit'.
			static ActionOption()
			{
				Il2CppClassPointerStore<OptionSet.ActionOption<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, "ActionOption`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionSet.ActionOption<TKey, TValue>>.NativeClassPtr);
				OptionSet.ActionOption<TKey, TValue>.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionSet.ActionOption<TKey, TValue>>.NativeClassPtr, "action");
				OptionSet.ActionOption<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_String_String_OptionAction_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet.ActionOption<TKey, TValue>>.NativeClassPtr, 100663495);
				OptionSet.ActionOption<TKey, TValue>.NativeMethodInfoPtr_OnParseComplete_Protected_Virtual_Void_OptionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet.ActionOption<TKey, TValue>>.NativeClassPtr, 100663496);
			}

			// Token: 0x06000419 RID: 1049 RVA: 0x00012A20 File Offset: 0x00010C20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166340, XrefRangeEnd = 1166350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ActionOption(string prototype, string description, OptionAction<TKey, TValue> action)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionSet.ActionOption<TKey, TValue>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prototype);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.ActionOption<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_String_String_OptionAction_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600041A RID: 1050 RVA: 0x00012A90 File Offset: 0x00010C90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166350, XrefRangeEnd = 1166357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void OnParseComplete(OptionContext c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.ActionOption<TKey, TValue>.NativeMethodInfoPtr_OnParseComplete_Protected_Virtual_Void_OptionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600041B RID: 1051 RVA: 0x00004044 File Offset: 0x00002244
			public ActionOption(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000114 RID: 276
			// (get) Token: 0x0600041C RID: 1052 RVA: 0x00012AD4 File Offset: 0x00010CD4
			// (set) Token: 0x0600041D RID: 1053 RVA: 0x0000404D File Offset: 0x0000224D
			public unsafe OptionAction<TKey, TValue> action
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionSet.ActionOption<TKey, TValue>.NativeFieldInfoPtr_action);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptionAction<TKey, TValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionSet.ActionOption<TKey, TValue>.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000294 RID: 660
			private static readonly IntPtr NativeFieldInfoPtr_action;

			// Token: 0x04000295 RID: 661
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_OptionAction_2_TKey_TValue_0;

			// Token: 0x04000296 RID: 662
			private static readonly IntPtr NativeMethodInfoPtr_OnParseComplete_Protected_Virtual_Void_OptionContext_0;
		}

		// Token: 0x02000065 RID: 101
		public class ArgumentEnumerator : Object
		{
			// Token: 0x0600041E RID: 1054 RVA: 0x00012B04 File Offset: 0x00010D04
			// Note: this type is marked as 'beforefieldinit'.
			static ArgumentEnumerator()
			{
				Il2CppClassPointerStore<OptionSet.ArgumentEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, "ArgumentEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionSet.ArgumentEnumerator>.NativeClassPtr);
				OptionSet.ArgumentEnumerator.NativeFieldInfoPtr_sources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionSet.ArgumentEnumerator>.NativeClassPtr, "sources");
				OptionSet.ArgumentEnumerator.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet.ArgumentEnumerator>.NativeClassPtr, 100663497);
				OptionSet.ArgumentEnumerator.NativeMethodInfoPtr_Add_Public_Void_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet.ArgumentEnumerator>.NativeClassPtr, 100663498);
				OptionSet.ArgumentEnumerator.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet.ArgumentEnumerator>.NativeClassPtr, 100663499);
				OptionSet.ArgumentEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet.ArgumentEnumerator>.NativeClassPtr, 100663500);
			}

			// Token: 0x0600041F RID: 1055 RVA: 0x00012B94 File Offset: 0x00010D94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166384, XrefRangeEnd = 1166401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArgumentEnumerator(IEnumerable<string> arguments)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionSet.ArgumentEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(arguments);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.ArgumentEnumerator.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000420 RID: 1056 RVA: 0x00012BE0 File Offset: 0x00010DE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166401, XrefRangeEnd = 1166410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Add(IEnumerable<string> arguments)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(arguments);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.ArgumentEnumerator.NativeMethodInfoPtr_Add_Public_Void_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000421 RID: 1057 RVA: 0x00012C24 File Offset: 0x00010E24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166410, XrefRangeEnd = 1166415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator<string> GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.ArgumentEnumerator.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<string>>(intPtr3) : null;
			}

			// Token: 0x06000422 RID: 1058 RVA: 0x00012C64 File Offset: 0x00010E64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.ArgumentEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06000423 RID: 1059 RVA: 0x0000406C File Offset: 0x0000226C
			public ArgumentEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000115 RID: 277
			// (get) Token: 0x06000424 RID: 1060 RVA: 0x00012CA4 File Offset: 0x00010EA4
			// (set) Token: 0x06000425 RID: 1061 RVA: 0x00004075 File Offset: 0x00002275
			public unsafe List<IEnumerator<string>> sources
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionSet.ArgumentEnumerator.NativeFieldInfoPtr_sources);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IEnumerator<string>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionSet.ArgumentEnumerator.NativeFieldInfoPtr_sources), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000297 RID: 663
			private static readonly IntPtr NativeFieldInfoPtr_sources;

			// Token: 0x04000298 RID: 664
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_String_0;

			// Token: 0x04000299 RID: 665
			private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_IEnumerable_1_String_0;

			// Token: 0x0400029A RID: 666
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_String_0;

			// Token: 0x0400029B RID: 667
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x02000088 RID: 136
			[ObfuscatedName("Mono.Options.OptionSet+ArgumentEnumerator+<GetEnumerator>d__3")]
			public sealed class _GetEnumerator_d__3 : Object
			{
				// Token: 0x060004FE RID: 1278 RVA: 0x00015664 File Offset: 0x00013864
				// Note: this type is marked as 'beforefieldinit'.
				static _GetEnumerator_d__3()
				{
					Il2CppClassPointerStore<OptionSet.ArgumentEnumerator._GetEnumerator_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionSet.ArgumentEnumerator>.NativeClassPtr, "<GetEnumerator>d__3");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionSet.ArgumentEnumerator._GetEnumerator_d__3>.NativeClassPtr);
					OptionSet.ArgumentEnumerator._GetEnumerator_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionSet.ArgumentEnumerator._GetEnumerator_d__3>.NativeClassPtr, "<>1__state");
					OptionSet.ArgumentEnumerator._GetEnumerator_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionSet.ArgumentEnumerator._GetEnumerator_d__3>.NativeClassPtr, "<>2__current");
					OptionSet.ArgumentEnumerator._GetEnumerator_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionSet.ArgumentEnumerator._GetEnumerator_d__3>.NativeClassPtr, "<>4__this");
					OptionSet.ArgumentEnumerator._GetEnumerator_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet.ArgumentEnumerator._GetEnumerator_d__3>.NativeClassPtr, 100663501);
					OptionSet.ArgumentEnumerator._GetEnumerator_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet.ArgumentEnumerator._GetEnumerator_d__3>.NativeClassPtr, 100663502);
					OptionSet.ArgumentEnumerator._GetEnumerator_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet.ArgumentEnumerator._GetEnumerator_d__3>.NativeClassPtr, 100663503);
					OptionSet.ArgumentEnumerator._GetEnumerator_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet.ArgumentEnumerator._GetEnumerator_d__3>.NativeClassPtr, 100663504);
					OptionSet.ArgumentEnumerator._GetEnumerator_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet.ArgumentEnumerator._GetEnumerator_d__3>.NativeClassPtr, 100663505);
					OptionSet.ArgumentEnumerator._GetEnumerator_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet.ArgumentEnumerator._GetEnumerator_d__3>.NativeClassPtr, 100663506);
				}

				// Token: 0x060004FF RID: 1279 RVA: 0x00015744 File Offset: 0x00013944
				[CallerCount(73)]
				[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe _GetEnumerator_d__3(int <>1__state)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionSet.ArgumentEnumerator._GetEnumerator_d__3>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref <>1__state;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.ArgumentEnumerator._GetEnumerator_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06000500 RID: 1280 RVA: 0x0001578C File Offset: 0x0001398C
				[CallerCount(21425)]
				[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.ArgumentEnumerator._GetEnumerator_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06000501 RID: 1281 RVA: 0x000157C0 File Offset: 0x000139C0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166357, XrefRangeEnd = 1166379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.ArgumentEnumerator._GetEnumerator_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17000157 RID: 343
				// (get) Token: 0x06000502 RID: 1282 RVA: 0x000157FC File Offset: 0x000139FC
				public unsafe string System.Collections.Generic.IEnumerator<System.String>.Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.ArgumentEnumerator._GetEnumerator_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x06000503 RID: 1283 RVA: 0x00015834 File Offset: 0x00013A34
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166379, XrefRangeEnd = 1166384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.ArgumentEnumerator._GetEnumerator_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17000158 RID: 344
				// (get) Token: 0x06000504 RID: 1284 RVA: 0x00015868 File Offset: 0x00013A68
				public unsafe Object System.Collections.IEnumerator.Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.ArgumentEnumerator._GetEnumerator_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x06000505 RID: 1285 RVA: 0x000046EF File Offset: 0x000028EF
				public _GetEnumerator_d__3(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000154 RID: 340
				// (get) Token: 0x06000506 RID: 1286 RVA: 0x000158A8 File Offset: 0x00013AA8
				// (set) Token: 0x06000507 RID: 1287 RVA: 0x000046F8 File Offset: 0x000028F8
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionSet.ArgumentEnumerator._GetEnumerator_d__3.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionSet.ArgumentEnumerator._GetEnumerator_d__3.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17000155 RID: 341
				// (get) Token: 0x06000508 RID: 1288 RVA: 0x000158D0 File Offset: 0x00013AD0
				// (set) Token: 0x06000509 RID: 1289 RVA: 0x00004713 File Offset: 0x00002913
				public unsafe string __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionSet.ArgumentEnumerator._GetEnumerator_d__3.NativeFieldInfoPtr___2__current);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionSet.ArgumentEnumerator._GetEnumerator_d__3.NativeFieldInfoPtr___2__current), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17000156 RID: 342
				// (get) Token: 0x0600050A RID: 1290 RVA: 0x000158F8 File Offset: 0x00013AF8
				// (set) Token: 0x0600050B RID: 1291 RVA: 0x00004732 File Offset: 0x00002932
				public unsafe OptionSet.ArgumentEnumerator __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionSet.ArgumentEnumerator._GetEnumerator_d__3.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptionSet.ArgumentEnumerator>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionSet.ArgumentEnumerator._GetEnumerator_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04000325 RID: 805
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04000326 RID: 806
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04000327 RID: 807
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04000328 RID: 808
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04000329 RID: 809
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400032A RID: 810
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400032B RID: 811
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0;

				// Token: 0x0400032C RID: 812
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400032D RID: 813
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000066 RID: 102
		[ObfuscatedName("Mono.Options.OptionSet+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000426 RID: 1062 RVA: 0x00012CD4 File Offset: 0x00010ED4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<OptionSet.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionSet.__c>.NativeClassPtr);
				OptionSet.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionSet.__c>.NativeClassPtr, "<>9");
				OptionSet.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionSet.__c>.NativeClassPtr, "<>9__0_0");
				OptionSet.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet.__c>.NativeClassPtr, 100663508);
				OptionSet.__c.NativeMethodInfoPtr___ctor_b__0_0_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet.__c>.NativeClassPtr, 100663509);
			}

			// Token: 0x06000427 RID: 1063 RVA: 0x00012D50 File Offset: 0x00010F50
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionSet.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000428 RID: 1064 RVA: 0x00012D8C File Offset: 0x00010F8C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string __ctor_b__0_0(string f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(f);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.__c.NativeMethodInfoPtr___ctor_b__0_0_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000429 RID: 1065 RVA: 0x00004094 File Offset: 0x00002294
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000116 RID: 278
			// (get) Token: 0x0600042A RID: 1066 RVA: 0x00012DD4 File Offset: 0x00010FD4
			// (set) Token: 0x0600042B RID: 1067 RVA: 0x0000409D File Offset: 0x0000229D
			public unsafe static OptionSet.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OptionSet.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptionSet.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OptionSet.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000117 RID: 279
			// (get) Token: 0x0600042C RID: 1068 RVA: 0x00012DFC File Offset: 0x00010FFC
			// (set) Token: 0x0600042D RID: 1069 RVA: 0x000040AF File Offset: 0x000022AF
			public unsafe static Converter<string, string> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OptionSet.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Converter<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OptionSet.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400029C RID: 668
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400029D RID: 669
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x0400029E RID: 670
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400029F RID: 671
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__0_0_Internal_String_String_0;
		}

		// Token: 0x02000067 RID: 103
		[ObfuscatedName("Mono.Options.OptionSet+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : Object
		{
			// Token: 0x0600042E RID: 1070 RVA: 0x00012E24 File Offset: 0x00011024
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<OptionSet.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionSet.__c__DisplayClass21_0>.NativeClassPtr);
				OptionSet.__c__DisplayClass21_0.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionSet.__c__DisplayClass21_0>.NativeClassPtr, "action");
				OptionSet.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet.__c__DisplayClass21_0>.NativeClassPtr, 100663510);
				OptionSet.__c__DisplayClass21_0.NativeMethodInfoPtr__Add_b__0_Internal_Void_OptionValueCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet.__c__DisplayClass21_0>.NativeClassPtr, 100663511);
			}

			// Token: 0x0600042F RID: 1071 RVA: 0x00012E8C File Offset: 0x0001108C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionSet.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000430 RID: 1072 RVA: 0x00012EC8 File Offset: 0x000110C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166415, XrefRangeEnd = 1166417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Add_b__0(OptionValueCollection v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.__c__DisplayClass21_0.NativeMethodInfoPtr__Add_b__0_Internal_Void_OptionValueCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000431 RID: 1073 RVA: 0x000040C1 File Offset: 0x000022C1
			public __c__DisplayClass21_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000118 RID: 280
			// (get) Token: 0x06000432 RID: 1074 RVA: 0x00012F0C File Offset: 0x0001110C
			// (set) Token: 0x06000433 RID: 1075 RVA: 0x000040CA File Offset: 0x000022CA
			public unsafe Action<string> action
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionSet.__c__DisplayClass21_0.NativeFieldInfoPtr_action);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionSet.__c__DisplayClass21_0.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002A0 RID: 672
			private static readonly IntPtr NativeFieldInfoPtr_action;

			// Token: 0x040002A1 RID: 673
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040002A2 RID: 674
			private static readonly IntPtr NativeMethodInfoPtr__Add_b__0_Internal_Void_OptionValueCollection_0;
		}

		// Token: 0x02000068 RID: 104
		[ObfuscatedName("Mono.Options.OptionSet+<>c__DisplayClass24_0")]
		public sealed class __c__DisplayClass24_0 : Object
		{
			// Token: 0x06000434 RID: 1076 RVA: 0x00012F3C File Offset: 0x0001113C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_0()
			{
				Il2CppClassPointerStore<OptionSet.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionSet>.NativeClassPtr, "<>c__DisplayClass24_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionSet.__c__DisplayClass24_0>.NativeClassPtr);
				OptionSet.__c__DisplayClass24_0.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionSet.__c__DisplayClass24_0>.NativeClassPtr, "action");
				OptionSet.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet.__c__DisplayClass24_0>.NativeClassPtr, 100663512);
				OptionSet.__c__DisplayClass24_0.NativeMethodInfoPtr__Add_b__0_Internal_Void_OptionValueCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSet.__c__DisplayClass24_0>.NativeClassPtr, 100663513);
			}

			// Token: 0x06000435 RID: 1077 RVA: 0x00012FA4 File Offset: 0x000111A4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionSet.__c__DisplayClass24_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000436 RID: 1078 RVA: 0x00012FE0 File Offset: 0x000111E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166417, XrefRangeEnd = 1166448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Add_b__0(OptionValueCollection v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSet.__c__DisplayClass24_0.NativeMethodInfoPtr__Add_b__0_Internal_Void_OptionValueCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000437 RID: 1079 RVA: 0x000040E9 File Offset: 0x000022E9
			public __c__DisplayClass24_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000119 RID: 281
			// (get) Token: 0x06000438 RID: 1080 RVA: 0x00013024 File Offset: 0x00011224
			// (set) Token: 0x06000439 RID: 1081 RVA: 0x000040F2 File Offset: 0x000022F2
			public unsafe OptionAction<string, string> action
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionSet.__c__DisplayClass24_0.NativeFieldInfoPtr_action);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptionAction<string, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionSet.__c__DisplayClass24_0.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002A3 RID: 675
			private static readonly IntPtr NativeFieldInfoPtr_action;

			// Token: 0x040002A4 RID: 676
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040002A5 RID: 677
			private static readonly IntPtr NativeMethodInfoPtr__Add_b__0_Internal_Void_OptionValueCollection_0;
		}

		// Token: 0x02000069 RID: 105
		private sealed class MethodInfoStoreGeneric_Add_Public_OptionSet_String_Action_1_T_0<T>
		{
			// Token: 0x040002A6 RID: 678
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(OptionSet.NativeMethodInfoPtr_Add_Public_OptionSet_String_Action_1_T_0, Il2CppClassPointerStore<OptionSet>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200006A RID: 106
		private sealed class MethodInfoStoreGeneric_Add_Public_OptionSet_String_String_Action_1_T_0<T>
		{
			// Token: 0x040002A7 RID: 679
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(OptionSet.NativeMethodInfoPtr_Add_Public_OptionSet_String_String_Action_1_T_0, Il2CppClassPointerStore<OptionSet>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200006B RID: 107
		private sealed class MethodInfoStoreGeneric_Add_Public_OptionSet_String_OptionAction_2_TKey_TValue_0<TKey, TValue>
		{
			// Token: 0x040002A8 RID: 680
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(OptionSet.NativeMethodInfoPtr_Add_Public_OptionSet_String_OptionAction_2_TKey_TValue_0, Il2CppClassPointerStore<OptionSet>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200006C RID: 108
		private sealed class MethodInfoStoreGeneric_Add_Public_OptionSet_String_String_OptionAction_2_TKey_TValue_0<TKey, TValue>
		{
			// Token: 0x040002A9 RID: 681
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(OptionSet.NativeMethodInfoPtr_Add_Public_OptionSet_String_String_OptionAction_2_TKey_TValue_0, Il2CppClassPointerStore<OptionSet>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}
	}
}
