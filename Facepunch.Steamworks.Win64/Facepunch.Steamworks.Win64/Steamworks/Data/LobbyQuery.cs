using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;

namespace Steamworks.Data
{
	// Token: 0x02000204 RID: 516
	public sealed class LobbyQuery : ValueType
	{
		// Token: 0x060019C2 RID: 6594 RVA: 0x0007C77C File Offset: 0x0007A97C
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyQuery()
		{
			Il2CppClassPointerStore<LobbyQuery>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "LobbyQuery");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyQuery>.NativeClassPtr);
			LobbyQuery.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyQuery>.NativeClassPtr, "distance");
			LobbyQuery.NativeFieldInfoPtr_stringFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyQuery>.NativeClassPtr, "stringFilters");
			LobbyQuery.NativeFieldInfoPtr_numericalFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyQuery>.NativeClassPtr, "numericalFilters");
			LobbyQuery.NativeFieldInfoPtr_nearValFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyQuery>.NativeClassPtr, "nearValFilters");
			LobbyQuery.NativeFieldInfoPtr_slotsAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyQuery>.NativeClassPtr, "slotsAvailable");
			LobbyQuery.NativeFieldInfoPtr_maxResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyQuery>.NativeClassPtr, "maxResults");
			LobbyQuery.NativeMethodInfoPtr_FilterDistanceClose_Public_LobbyQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyQuery>.NativeClassPtr, 100668015);
			LobbyQuery.NativeMethodInfoPtr_FilterDistanceFar_Public_LobbyQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyQuery>.NativeClassPtr, 100668016);
			LobbyQuery.NativeMethodInfoPtr_FilterDistanceWorldwide_Public_LobbyQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyQuery>.NativeClassPtr, 100668017);
			LobbyQuery.NativeMethodInfoPtr_WithKeyValue_Public_LobbyQuery_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyQuery>.NativeClassPtr, 100668018);
			LobbyQuery.NativeMethodInfoPtr_WithLower_Public_LobbyQuery_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyQuery>.NativeClassPtr, 100668019);
			LobbyQuery.NativeMethodInfoPtr_WithHigher_Public_LobbyQuery_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyQuery>.NativeClassPtr, 100668020);
			LobbyQuery.NativeMethodInfoPtr_WithEqual_Public_LobbyQuery_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyQuery>.NativeClassPtr, 100668021);
			LobbyQuery.NativeMethodInfoPtr_WithNotEqual_Public_LobbyQuery_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyQuery>.NativeClassPtr, 100668022);
			LobbyQuery.NativeMethodInfoPtr_AddNumericalFilter_Internal_Void_String_Int32_LobbyComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyQuery>.NativeClassPtr, 100668023);
			LobbyQuery.NativeMethodInfoPtr_OrderByNear_Public_LobbyQuery_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyQuery>.NativeClassPtr, 100668024);
			LobbyQuery.NativeMethodInfoPtr_WithSlotsAvailable_Public_LobbyQuery_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyQuery>.NativeClassPtr, 100668025);
			LobbyQuery.NativeMethodInfoPtr_WithMaxResults_Public_LobbyQuery_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyQuery>.NativeClassPtr, 100668026);
			LobbyQuery.NativeMethodInfoPtr_ApplyFilters_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyQuery>.NativeClassPtr, 100668027);
			LobbyQuery.NativeMethodInfoPtr_RequestAsync_Public_Task_1_Il2CppStructArray_1_Lobby_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyQuery>.NativeClassPtr, 100668028);
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x0007C93C File Offset: 0x0007AB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952618, XrefRangeEnd = 952621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbyQuery FilterDistanceClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyQuery.NativeMethodInfoPtr_FilterDistanceClose_Public_LobbyQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new LobbyQuery(intPtr);
		}

		// Token: 0x060019C4 RID: 6596 RVA: 0x0007C978 File Offset: 0x0007AB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952621, XrefRangeEnd = 952624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbyQuery FilterDistanceFar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyQuery.NativeMethodInfoPtr_FilterDistanceFar_Public_LobbyQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new LobbyQuery(intPtr);
		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x0007C9B4 File Offset: 0x0007ABB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952624, XrefRangeEnd = 952627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbyQuery FilterDistanceWorldwide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyQuery.NativeMethodInfoPtr_FilterDistanceWorldwide_Public_LobbyQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new LobbyQuery(intPtr);
		}

		// Token: 0x060019C6 RID: 6598 RVA: 0x0007C9F0 File Offset: 0x0007ABF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952627, XrefRangeEnd = 952639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbyQuery WithKeyValue(string key, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyQuery.NativeMethodInfoPtr_WithKeyValue_Public_LobbyQuery_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new LobbyQuery(intPtr);
		}

		// Token: 0x060019C7 RID: 6599 RVA: 0x0007CA50 File Offset: 0x0007AC50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952639, XrefRangeEnd = 952640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbyQuery WithLower(string key, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyQuery.NativeMethodInfoPtr_WithLower_Public_LobbyQuery_String_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new LobbyQuery(intPtr);
		}

		// Token: 0x060019C8 RID: 6600 RVA: 0x0007CAAC File Offset: 0x0007ACAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952640, XrefRangeEnd = 952641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbyQuery WithHigher(string key, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyQuery.NativeMethodInfoPtr_WithHigher_Public_LobbyQuery_String_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new LobbyQuery(intPtr);
		}

		// Token: 0x060019C9 RID: 6601 RVA: 0x0007CB08 File Offset: 0x0007AD08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952641, XrefRangeEnd = 952642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbyQuery WithEqual(string key, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyQuery.NativeMethodInfoPtr_WithEqual_Public_LobbyQuery_String_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new LobbyQuery(intPtr);
		}

		// Token: 0x060019CA RID: 6602 RVA: 0x0007CB64 File Offset: 0x0007AD64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952642, XrefRangeEnd = 952643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbyQuery WithNotEqual(string key, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyQuery.NativeMethodInfoPtr_WithNotEqual_Public_LobbyQuery_String_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new LobbyQuery(intPtr);
		}

		// Token: 0x060019CB RID: 6603 RVA: 0x0007CBC0 File Offset: 0x0007ADC0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 952656, RefRangeEnd = 952660, XrefRangeStart = 952643, XrefRangeEnd = 952656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddNumericalFilter(string key, int value, LobbyComparison compare)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref compare;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyQuery.NativeMethodInfoPtr_AddNumericalFilter_Internal_Void_String_Int32_LobbyComparison_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019CC RID: 6604 RVA: 0x0007CC24 File Offset: 0x0007AE24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952660, XrefRangeEnd = 952672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbyQuery OrderByNear(string key, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyQuery.NativeMethodInfoPtr_OrderByNear_Public_LobbyQuery_String_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new LobbyQuery(intPtr);
		}

		// Token: 0x060019CD RID: 6605 RVA: 0x0007CC80 File Offset: 0x0007AE80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952672, XrefRangeEnd = 952675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbyQuery WithSlotsAvailable(int minSlots)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minSlots;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyQuery.NativeMethodInfoPtr_WithSlotsAvailable_Public_LobbyQuery_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new LobbyQuery(intPtr);
			}
		}

		// Token: 0x060019CE RID: 6606 RVA: 0x0007CCCC File Offset: 0x0007AECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952675, XrefRangeEnd = 952678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbyQuery WithMaxResults(int max)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref max;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyQuery.NativeMethodInfoPtr_WithMaxResults_Public_LobbyQuery_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new LobbyQuery(intPtr);
			}
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x0007CD18 File Offset: 0x0007AF18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 952746, RefRangeEnd = 952747, XrefRangeStart = 952678, XrefRangeEnd = 952746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyFilters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyQuery.NativeMethodInfoPtr_ApplyFilters_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x0007CD50 File Offset: 0x0007AF50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952747, XrefRangeEnd = 952761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Il2CppStructArray<Lobby>> RequestAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyQuery.NativeMethodInfoPtr_RequestAsync_Public_Task_1_Il2CppStructArray_1_Lobby_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Il2CppStructArray<Lobby>>>(intPtr3) : null;
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x000085A2 File Offset: 0x000067A2
		public LobbyQuery(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x000085AB File Offset: 0x000067AB
		public LobbyQuery()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyQuery>.NativeClassPtr))
		{
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x060019D3 RID: 6611 RVA: 0x0007CD94 File Offset: 0x0007AF94
		// (set) Token: 0x060019D4 RID: 6612 RVA: 0x000085BD File Offset: 0x000067BD
		public Nullable<LobbyDistanceFilter> distance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyQuery.NativeFieldInfoPtr_distance);
				return new Nullable<LobbyDistanceFilter>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<LobbyDistanceFilter>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyQuery.NativeFieldInfoPtr_distance), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<LobbyDistanceFilter>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x060019D5 RID: 6613 RVA: 0x0007CDC4 File Offset: 0x0007AFC4
		// (set) Token: 0x060019D6 RID: 6614 RVA: 0x000085EB File Offset: 0x000067EB
		public unsafe Dictionary<string, string> stringFilters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyQuery.NativeFieldInfoPtr_stringFilters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyQuery.NativeFieldInfoPtr_stringFilters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x060019D7 RID: 6615 RVA: 0x0007CDF4 File Offset: 0x0007AFF4
		// (set) Token: 0x060019D8 RID: 6616 RVA: 0x0000860A File Offset: 0x0000680A
		public unsafe List<NumericalFilter> numericalFilters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyQuery.NativeFieldInfoPtr_numericalFilters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NumericalFilter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyQuery.NativeFieldInfoPtr_numericalFilters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x060019D9 RID: 6617 RVA: 0x0007CE24 File Offset: 0x0007B024
		// (set) Token: 0x060019DA RID: 6618 RVA: 0x00008629 File Offset: 0x00006829
		public unsafe Dictionary<string, int> nearValFilters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyQuery.NativeFieldInfoPtr_nearValFilters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyQuery.NativeFieldInfoPtr_nearValFilters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x060019DB RID: 6619 RVA: 0x0007CE54 File Offset: 0x0007B054
		// (set) Token: 0x060019DC RID: 6620 RVA: 0x00008648 File Offset: 0x00006848
		public Nullable<int> slotsAvailable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyQuery.NativeFieldInfoPtr_slotsAvailable);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyQuery.NativeFieldInfoPtr_slotsAvailable), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x060019DD RID: 6621 RVA: 0x0007CE84 File Offset: 0x0007B084
		// (set) Token: 0x060019DE RID: 6622 RVA: 0x00008676 File Offset: 0x00006876
		public Nullable<int> maxResults
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyQuery.NativeFieldInfoPtr_maxResults);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyQuery.NativeFieldInfoPtr_maxResults), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04001EFB RID: 7931
		private static readonly IntPtr NativeFieldInfoPtr_distance;

		// Token: 0x04001EFC RID: 7932
		private static readonly IntPtr NativeFieldInfoPtr_stringFilters;

		// Token: 0x04001EFD RID: 7933
		private static readonly IntPtr NativeFieldInfoPtr_numericalFilters;

		// Token: 0x04001EFE RID: 7934
		private static readonly IntPtr NativeFieldInfoPtr_nearValFilters;

		// Token: 0x04001EFF RID: 7935
		private static readonly IntPtr NativeFieldInfoPtr_slotsAvailable;

		// Token: 0x04001F00 RID: 7936
		private static readonly IntPtr NativeFieldInfoPtr_maxResults;

		// Token: 0x04001F01 RID: 7937
		private static readonly IntPtr NativeMethodInfoPtr_FilterDistanceClose_Public_LobbyQuery_0;

		// Token: 0x04001F02 RID: 7938
		private static readonly IntPtr NativeMethodInfoPtr_FilterDistanceFar_Public_LobbyQuery_0;

		// Token: 0x04001F03 RID: 7939
		private static readonly IntPtr NativeMethodInfoPtr_FilterDistanceWorldwide_Public_LobbyQuery_0;

		// Token: 0x04001F04 RID: 7940
		private static readonly IntPtr NativeMethodInfoPtr_WithKeyValue_Public_LobbyQuery_String_String_0;

		// Token: 0x04001F05 RID: 7941
		private static readonly IntPtr NativeMethodInfoPtr_WithLower_Public_LobbyQuery_String_Int32_0;

		// Token: 0x04001F06 RID: 7942
		private static readonly IntPtr NativeMethodInfoPtr_WithHigher_Public_LobbyQuery_String_Int32_0;

		// Token: 0x04001F07 RID: 7943
		private static readonly IntPtr NativeMethodInfoPtr_WithEqual_Public_LobbyQuery_String_Int32_0;

		// Token: 0x04001F08 RID: 7944
		private static readonly IntPtr NativeMethodInfoPtr_WithNotEqual_Public_LobbyQuery_String_Int32_0;

		// Token: 0x04001F09 RID: 7945
		private static readonly IntPtr NativeMethodInfoPtr_AddNumericalFilter_Internal_Void_String_Int32_LobbyComparison_0;

		// Token: 0x04001F0A RID: 7946
		private static readonly IntPtr NativeMethodInfoPtr_OrderByNear_Public_LobbyQuery_String_Int32_0;

		// Token: 0x04001F0B RID: 7947
		private static readonly IntPtr NativeMethodInfoPtr_WithSlotsAvailable_Public_LobbyQuery_Int32_0;

		// Token: 0x04001F0C RID: 7948
		private static readonly IntPtr NativeMethodInfoPtr_WithMaxResults_Public_LobbyQuery_Int32_0;

		// Token: 0x04001F0D RID: 7949
		private static readonly IntPtr NativeMethodInfoPtr_ApplyFilters_Private_Void_0;

		// Token: 0x04001F0E RID: 7950
		private static readonly IntPtr NativeMethodInfoPtr_RequestAsync_Public_Task_1_Il2CppStructArray_1_Lobby_0;

		// Token: 0x020002AE RID: 686
		[ObfuscatedName("Steamworks.Data.LobbyQuery+<RequestAsync>d__19")]
		public sealed class _RequestAsync_d__19 : ValueType
		{
			// Token: 0x060022EC RID: 8940 RVA: 0x00094CB4 File Offset: 0x00092EB4
			// Note: this type is marked as 'beforefieldinit'.
			static _RequestAsync_d__19()
			{
				Il2CppClassPointerStore<LobbyQuery._RequestAsync_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyQuery>.NativeClassPtr, "<RequestAsync>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyQuery._RequestAsync_d__19>.NativeClassPtr);
				LobbyQuery._RequestAsync_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyQuery._RequestAsync_d__19>.NativeClassPtr, "<>1__state");
				LobbyQuery._RequestAsync_d__19.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyQuery._RequestAsync_d__19>.NativeClassPtr, "<>t__builder");
				LobbyQuery._RequestAsync_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyQuery._RequestAsync_d__19>.NativeClassPtr, "<>4__this");
				LobbyQuery._RequestAsync_d__19.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyQuery._RequestAsync_d__19>.NativeClassPtr, "<>u__1");
				LobbyQuery._RequestAsync_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyQuery._RequestAsync_d__19>.NativeClassPtr, 100668029);
				LobbyQuery._RequestAsync_d__19.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyQuery._RequestAsync_d__19>.NativeClassPtr, 100668030);
			}

			// Token: 0x060022ED RID: 8941 RVA: 0x00094D58 File Offset: 0x00092F58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952577, XrefRangeEnd = 952612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyQuery._RequestAsync_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022EE RID: 8942 RVA: 0x00094D90 File Offset: 0x00092F90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952612, XrefRangeEnd = 952618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyQuery._RequestAsync_d__19.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060022EF RID: 8943 RVA: 0x0000E6DF File Offset: 0x0000C8DF
			public _RequestAsync_d__19(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060022F0 RID: 8944 RVA: 0x0000E6E8 File Offset: 0x0000C8E8
			public _RequestAsync_d__19()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyQuery._RequestAsync_d__19>.NativeClassPtr))
			{
			}

			// Token: 0x17000931 RID: 2353
			// (get) Token: 0x060022F1 RID: 8945 RVA: 0x00094DD8 File Offset: 0x00092FD8
			// (set) Token: 0x060022F2 RID: 8946 RVA: 0x0000E6FA File Offset: 0x0000C8FA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyQuery._RequestAsync_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyQuery._RequestAsync_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000932 RID: 2354
			// (get) Token: 0x060022F3 RID: 8947 RVA: 0x00094E00 File Offset: 0x00093000
			// (set) Token: 0x060022F4 RID: 8948 RVA: 0x0000E715 File Offset: 0x0000C915
			public AsyncTaskMethodBuilder<Il2CppStructArray<Lobby>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyQuery._RequestAsync_d__19.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Il2CppStructArray<Lobby>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppStructArray<Lobby>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyQuery._RequestAsync_d__19.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppStructArray<Lobby>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000933 RID: 2355
			// (get) Token: 0x060022F5 RID: 8949 RVA: 0x00094E30 File Offset: 0x00093030
			// (set) Token: 0x060022F6 RID: 8950 RVA: 0x0000E743 File Offset: 0x0000C943
			public LobbyQuery __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyQuery._RequestAsync_d__19.NativeFieldInfoPtr___4__this);
					return new LobbyQuery(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LobbyQuery>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyQuery._RequestAsync_d__19.NativeFieldInfoPtr___4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LobbyQuery>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000934 RID: 2356
			// (get) Token: 0x060022F7 RID: 8951 RVA: 0x00094E60 File Offset: 0x00093060
			// (set) Token: 0x060022F8 RID: 8952 RVA: 0x0000E771 File Offset: 0x0000C971
			public CallResult<LobbyMatchList_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyQuery._RequestAsync_d__19.NativeFieldInfoPtr___u__1);
					return new CallResult<LobbyMatchList_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<LobbyMatchList_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyQuery._RequestAsync_d__19.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<LobbyMatchList_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002420 RID: 9248
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002421 RID: 9249
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002422 RID: 9250
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002423 RID: 9251
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002424 RID: 9252
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002425 RID: 9253
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
