using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Localization.SmartFormat.Core.Parsing
{
	// Token: 0x02000078 RID: 120
	public class Format : FormatItem
	{
		// Token: 0x0600057C RID: 1404 RVA: 0x0001E0F4 File Offset: 0x0001C2F4
		// Note: this type is marked as 'beforefieldinit'.
		static Format()
		{
			Il2CppClassPointerStore<Format>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Core.Parsing", "Format");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Format>.NativeClassPtr);
			Format.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Format>.NativeClassPtr, "parent");
			Format.NativeFieldInfoPtr__Items_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Format>.NativeClassPtr, "<Items>k__BackingField");
			Format.NativeFieldInfoPtr__HasNested_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Format>.NativeClassPtr, "<HasNested>k__BackingField");
			Format.NativeFieldInfoPtr_m_Splits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Format>.NativeClassPtr, "m_Splits");
			Format.NativeFieldInfoPtr_splitCacheChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Format>.NativeClassPtr, "splitCacheChar");
			Format.NativeFieldInfoPtr_splitCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Format>.NativeClassPtr, "splitCache");
			Format.NativeMethodInfoPtr_ReleaseToPool_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Format>.NativeClassPtr, 100664319);
			Format.NativeMethodInfoPtr_get_Items_Public_get_List_1_FormatItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Format>.NativeClassPtr, 100664320);
			Format.NativeMethodInfoPtr_get_HasNested_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Format>.NativeClassPtr, 100664321);
			Format.NativeMethodInfoPtr_set_HasNested_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Format>.NativeClassPtr, 100664322);
			Format.NativeMethodInfoPtr_Substring_Public_Format_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Format>.NativeClassPtr, 100664323);
			Format.NativeMethodInfoPtr_Substring_Public_Format_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Format>.NativeClassPtr, 100664324);
			Format.NativeMethodInfoPtr_IndexOf_Public_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Format>.NativeClassPtr, 100664325);
			Format.NativeMethodInfoPtr_IndexOf_Public_Int32_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Format>.NativeClassPtr, 100664326);
			Format.NativeMethodInfoPtr_FindAll_Private_List_1_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Format>.NativeClassPtr, 100664327);
			Format.NativeMethodInfoPtr_FindAll_Private_List_1_Int32_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Format>.NativeClassPtr, 100664328);
			Format.NativeMethodInfoPtr_Split_Public_IList_1_Format_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Format>.NativeClassPtr, 100664329);
			Format.NativeMethodInfoPtr_Split_Public_IList_1_Format_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Format>.NativeClassPtr, 100664330);
			Format.NativeMethodInfoPtr_GetLiteralText_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Format>.NativeClassPtr, 100664331);
			Format.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Format>.NativeClassPtr, 100664332);
			Format.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Format>.NativeClassPtr, 100664333);
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x0001E2C8 File Offset: 0x0001C4C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1073359, RefRangeEnd = 1073360, XrefRangeStart = 1073317, XrefRangeEnd = 1073359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseToPool()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Format.NativeMethodInfoPtr_ReleaseToPool_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600057E RID: 1406 RVA: 0x0001E2FC File Offset: 0x0001C4FC
		public unsafe List<FormatItem> Items
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Format.NativeMethodInfoPtr_get_Items_Public_get_List_1_FormatItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<FormatItem>>(intPtr3) : null;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x0001E33C File Offset: 0x0001C53C
		// (set) Token: 0x06000580 RID: 1408 RVA: 0x0001E378 File Offset: 0x0001C578
		public unsafe bool HasNested
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Format.NativeMethodInfoPtr_get_HasNested_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Format.NativeMethodInfoPtr_set_HasNested_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x0001E3B8 File Offset: 0x0001C5B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073360, XrefRangeEnd = 1073361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Format Substring(int startIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Format.NativeMethodInfoPtr_Substring_Public_Format_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Format>(intPtr3) : null;
			}
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x0001E404 File Offset: 0x0001C604
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1073369, RefRangeEnd = 1073375, XrefRangeStart = 1073361, XrefRangeEnd = 1073369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Format Substring(int startIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Format.NativeMethodInfoPtr_Substring_Public_Format_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Format>(intPtr3) : null;
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0001E460 File Offset: 0x0001C660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073375, XrefRangeEnd = 1073376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(char search)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref search;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Format.NativeMethodInfoPtr_IndexOf_Public_Int32_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x0001E4AC File Offset: 0x0001C6AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1073389, RefRangeEnd = 1073391, XrefRangeStart = 1073376, XrefRangeEnd = 1073389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(char search, int startIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref search;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Format.NativeMethodInfoPtr_IndexOf_Public_Int32_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x0001E504 File Offset: 0x0001C704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073391, XrefRangeEnd = 1073392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<int> FindAll(char search)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref search;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Format.NativeMethodInfoPtr_FindAll_Private_List_1_Int32_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x0001E550 File Offset: 0x0001C750
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1073402, RefRangeEnd = 1073404, XrefRangeStart = 1073392, XrefRangeEnd = 1073402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<int> FindAll(char search, int maxCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref search;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Format.NativeMethodInfoPtr_FindAll_Private_List_1_Int32_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x0001E5AC File Offset: 0x0001C7AC
		[CallerCount(0)]
		public unsafe IList<Format> Split(char search)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref search;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Format.NativeMethodInfoPtr_Split_Public_IList_1_Format_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<Format>>(intPtr3) : null;
			}
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x0001E5F8 File Offset: 0x0001C7F8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1073412, RefRangeEnd = 1073422, XrefRangeStart = 1073404, XrefRangeEnd = 1073412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IList<Format> Split(char search, int maxCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref search;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Format.NativeMethodInfoPtr_Split_Public_IList_1_Format_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<Format>>(intPtr3) : null;
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x0001E654 File Offset: 0x0001C854
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1073450, RefRangeEnd = 1073454, XrefRangeStart = 1073422, XrefRangeEnd = 1073450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLiteralText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Format.NativeMethodInfoPtr_GetLiteralText_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0001E68C File Offset: 0x0001C88C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073454, XrefRangeEnd = 1073481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Format.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x0001E6D0 File Offset: 0x0001C8D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1073496, RefRangeEnd = 1073497, XrefRangeStart = 1073481, XrefRangeEnd = 1073496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Format()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Format>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Format.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00004176 File Offset: 0x00002376
		public Format(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x0001E70C File Offset: 0x0001C90C
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x0000417F File Offset: 0x0000237F
		public unsafe Placeholder parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Format.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Placeholder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Format.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x0001E73C File Offset: 0x0001C93C
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x0000419E File Offset: 0x0000239E
		public unsafe List<FormatItem> _Items_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Format.NativeFieldInfoPtr__Items_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FormatItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Format.NativeFieldInfoPtr__Items_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x0001E76C File Offset: 0x0001C96C
		// (set) Token: 0x06000592 RID: 1426 RVA: 0x000041BD File Offset: 0x000023BD
		public unsafe bool _HasNested_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Format.NativeFieldInfoPtr__HasNested_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Format.NativeFieldInfoPtr__HasNested_k__BackingField)) = value;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x0001E794 File Offset: 0x0001C994
		// (set) Token: 0x06000594 RID: 1428 RVA: 0x000041D8 File Offset: 0x000023D8
		public unsafe List<Format.SplitList> m_Splits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Format.NativeFieldInfoPtr_m_Splits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Format.SplitList>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Format.NativeFieldInfoPtr_m_Splits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x0001E7C4 File Offset: 0x0001C9C4
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x000041F7 File Offset: 0x000023F7
		public unsafe char splitCacheChar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Format.NativeFieldInfoPtr_splitCacheChar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Format.NativeFieldInfoPtr_splitCacheChar)) = value;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x0001E7EC File Offset: 0x0001C9EC
		// (set) Token: 0x06000598 RID: 1432 RVA: 0x00004212 File Offset: 0x00002412
		public unsafe IList<Format> splitCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Format.NativeFieldInfoPtr_splitCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<Format>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Format.NativeFieldInfoPtr_splitCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeFieldInfoPtr__Items_k__BackingField;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeFieldInfoPtr__HasNested_k__BackingField;

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeFieldInfoPtr_m_Splits;

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeFieldInfoPtr_splitCacheChar;

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeFieldInfoPtr_splitCache;

		// Token: 0x040003EB RID: 1003
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseToPool_Public_Void_0;

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeMethodInfoPtr_get_Items_Public_get_List_1_FormatItem_0;

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeMethodInfoPtr_get_HasNested_Public_get_Boolean_0;

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeMethodInfoPtr_set_HasNested_Public_set_Void_Boolean_0;

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeMethodInfoPtr_Substring_Public_Format_Int32_0;

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeMethodInfoPtr_Substring_Public_Format_Int32_Int32_0;

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_Char_0;

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_Char_Int32_0;

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeMethodInfoPtr_FindAll_Private_List_1_Int32_Char_0;

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeMethodInfoPtr_FindAll_Private_List_1_Int32_Char_Int32_0;

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeMethodInfoPtr_Split_Public_IList_1_Format_Char_0;

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeMethodInfoPtr_Split_Public_IList_1_Format_Char_Int32_0;

		// Token: 0x040003F7 RID: 1015
		private static readonly IntPtr NativeMethodInfoPtr_GetLiteralText_Public_String_0;

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040003F9 RID: 1017
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200014D RID: 333
		public class SplitList : Object
		{
			// Token: 0x06000EB3 RID: 3763 RVA: 0x0003F6BC File Offset: 0x0003D8BC
			// Note: this type is marked as 'beforefieldinit'.
			static SplitList()
			{
				Il2CppClassPointerStore<Format.SplitList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Format>.NativeClassPtr, "SplitList");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Format.SplitList>.NativeClassPtr);
				Format.SplitList.NativeFieldInfoPtr_m_Format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Format.SplitList>.NativeClassPtr, "m_Format");
				Format.SplitList.NativeFieldInfoPtr_m_Splits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Format.SplitList>.NativeClassPtr, "m_Splits");
				Format.SplitList.NativeFieldInfoPtr_m_FormatCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Format.SplitList>.NativeClassPtr, "m_FormatCache");
				Format.SplitList.NativeMethodInfoPtr_Init_Public_Void_Format_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Format.SplitList>.NativeClassPtr, 100664334);
				Format.SplitList.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Format_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Format.SplitList>.NativeClassPtr, 100664335);
				Format.SplitList.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int32_Format_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Format.SplitList>.NativeClassPtr, 100664336);
				Format.SplitList.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_Format_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Format.SplitList>.NativeClassPtr, 100664337);
				Format.SplitList.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Format.SplitList>.NativeClassPtr, 100664338);
				Format.SplitList.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Format.SplitList>.NativeClassPtr, 100664339);
				Format.SplitList.NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_Format_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Format.SplitList>.NativeClassPtr, 100664340);
				Format.SplitList.NativeMethodInfoPtr_Insert_Public_Virtual_Final_New_Void_Int32_Format_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Format.SplitList>.NativeClassPtr, 100664341);
				Format.SplitList.NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Format.SplitList>.NativeClassPtr, 100664342);
				Format.SplitList.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Format_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Format.SplitList>.NativeClassPtr, 100664343);
				Format.SplitList.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Format.SplitList>.NativeClassPtr, 100664344);
				Format.SplitList.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Format_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Format.SplitList>.NativeClassPtr, 100664345);
				Format.SplitList.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_Format_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Format.SplitList>.NativeClassPtr, 100664346);
				Format.SplitList.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_Format_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Format.SplitList>.NativeClassPtr, 100664347);
				Format.SplitList.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Format.SplitList>.NativeClassPtr, 100664348);
				Format.SplitList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Format.SplitList>.NativeClassPtr, 100664349);
			}

			// Token: 0x06000EB4 RID: 3764 RVA: 0x0003F864 File Offset: 0x0003DA64
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1073215, RefRangeEnd = 1073216, XrefRangeStart = 1073206, XrefRangeEnd = 1073215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Init(Format format, List<int> splits)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(format);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(splits);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Format.SplitList.NativeMethodInfoPtr_Init_Public_Void_Format_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170003FA RID: 1018
			public unsafe virtual Format this[int index]
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 1073232, RefRangeEnd = 1073234, XrefRangeStart = 1073216, XrefRangeEnd = 1073232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Format.SplitList.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Format_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Format>(intPtr3) : null;
					}
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073234, XrefRangeEnd = 1073239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Format.SplitList.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int32_Format_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000EB7 RID: 3767 RVA: 0x0003F954 File Offset: 0x0003DB54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073239, XrefRangeEnd = 1073245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void CopyTo(Il2CppReferenceArray<Format> array, int arrayIndex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Format.SplitList.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_Format_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170003FB RID: 1019
			// (get) Token: 0x06000EB8 RID: 3768 RVA: 0x0003F9A4 File Offset: 0x0003DBA4
			public unsafe virtual int Count
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073245, XrefRangeEnd = 1073246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Format.SplitList.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170003FC RID: 1020
			// (get) Token: 0x06000EB9 RID: 3769 RVA: 0x0003F9E0 File Offset: 0x0003DBE0
			public unsafe virtual bool IsReadOnly
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Format.SplitList.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000EBA RID: 3770 RVA: 0x0003FA1C File Offset: 0x0003DC1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073246, XrefRangeEnd = 1073251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int IndexOf(Format item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Format.SplitList.NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_Format_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000EBB RID: 3771 RVA: 0x0003FA6C File Offset: 0x0003DC6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073251, XrefRangeEnd = 1073256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Insert(int index, Format item)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Format.SplitList.NativeMethodInfoPtr_Insert_Public_Virtual_Final_New_Void_Int32_Format_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000EBC RID: 3772 RVA: 0x0003FABC File Offset: 0x0003DCBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073256, XrefRangeEnd = 1073261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void RemoveAt(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Format.SplitList.NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000EBD RID: 3773 RVA: 0x0003FAFC File Offset: 0x0003DCFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073261, XrefRangeEnd = 1073266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Add(Format item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Format.SplitList.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Format_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000EBE RID: 3774 RVA: 0x0003FB40 File Offset: 0x0003DD40
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1073287, RefRangeEnd = 1073288, XrefRangeStart = 1073266, XrefRangeEnd = 1073287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Format.SplitList.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000EBF RID: 3775 RVA: 0x0003FB74 File Offset: 0x0003DD74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073288, XrefRangeEnd = 1073293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool Contains(Format item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Format.SplitList.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Format_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000EC0 RID: 3776 RVA: 0x0003FBC4 File Offset: 0x0003DDC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073293, XrefRangeEnd = 1073298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool Remove(Format item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Format.SplitList.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_Format_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000EC1 RID: 3777 RVA: 0x0003FC14 File Offset: 0x0003DE14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073298, XrefRangeEnd = 1073303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator<Format> GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Format.SplitList.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_Format_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Format>>(intPtr3) : null;
			}

			// Token: 0x06000EC2 RID: 3778 RVA: 0x0003FC54 File Offset: 0x0003DE54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073303, XrefRangeEnd = 1073308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Format.SplitList.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06000EC3 RID: 3779 RVA: 0x0003FC94 File Offset: 0x0003DE94
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1073316, RefRangeEnd = 1073317, XrefRangeStart = 1073308, XrefRangeEnd = 1073316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SplitList()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Format.SplitList>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Format.SplitList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000EC4 RID: 3780 RVA: 0x000082E0 File Offset: 0x000064E0
			public SplitList(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003F7 RID: 1015
			// (get) Token: 0x06000EC5 RID: 3781 RVA: 0x0003FCD0 File Offset: 0x0003DED0
			// (set) Token: 0x06000EC6 RID: 3782 RVA: 0x000082E9 File Offset: 0x000064E9
			public unsafe Format m_Format
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Format.SplitList.NativeFieldInfoPtr_m_Format);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Format>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Format.SplitList.NativeFieldInfoPtr_m_Format), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003F8 RID: 1016
			// (get) Token: 0x06000EC7 RID: 3783 RVA: 0x0003FD00 File Offset: 0x0003DF00
			// (set) Token: 0x06000EC8 RID: 3784 RVA: 0x00008308 File Offset: 0x00006508
			public unsafe List<int> m_Splits
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Format.SplitList.NativeFieldInfoPtr_m_Splits);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Format.SplitList.NativeFieldInfoPtr_m_Splits), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003F9 RID: 1017
			// (get) Token: 0x06000EC9 RID: 3785 RVA: 0x0003FD30 File Offset: 0x0003DF30
			// (set) Token: 0x06000ECA RID: 3786 RVA: 0x00008327 File Offset: 0x00006527
			public unsafe List<Format> m_FormatCache
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Format.SplitList.NativeFieldInfoPtr_m_FormatCache);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Format>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Format.SplitList.NativeFieldInfoPtr_m_FormatCache), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000A18 RID: 2584
			private static readonly IntPtr NativeFieldInfoPtr_m_Format;

			// Token: 0x04000A19 RID: 2585
			private static readonly IntPtr NativeFieldInfoPtr_m_Splits;

			// Token: 0x04000A1A RID: 2586
			private static readonly IntPtr NativeFieldInfoPtr_m_FormatCache;

			// Token: 0x04000A1B RID: 2587
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_Format_List_1_Int32_0;

			// Token: 0x04000A1C RID: 2588
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Format_Int32_0;

			// Token: 0x04000A1D RID: 2589
			private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int32_Format_0;

			// Token: 0x04000A1E RID: 2590
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_Format_Int32_0;

			// Token: 0x04000A1F RID: 2591
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04000A20 RID: 2592
			private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04000A21 RID: 2593
			private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_Format_0;

			// Token: 0x04000A22 RID: 2594
			private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Virtual_Final_New_Void_Int32_Format_0;

			// Token: 0x04000A23 RID: 2595
			private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0;

			// Token: 0x04000A24 RID: 2596
			private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Format_0;

			// Token: 0x04000A25 RID: 2597
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

			// Token: 0x04000A26 RID: 2598
			private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Format_0;

			// Token: 0x04000A27 RID: 2599
			private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_Format_0;

			// Token: 0x04000A28 RID: 2600
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_Format_0;

			// Token: 0x04000A29 RID: 2601
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x04000A2A RID: 2602
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
