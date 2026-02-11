using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x020000BC RID: 188
	public sealed class InventoryItem : ValueType
	{
		// Token: 0x06000C29 RID: 3113 RVA: 0x00051AC8 File Offset: 0x0004FCC8
		// Note: this type is marked as 'beforefieldinit'.
		static InventoryItem()
		{
			Il2CppClassPointerStore<InventoryItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "InventoryItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr);
			InventoryItem.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "_id");
			InventoryItem.NativeFieldInfoPtr__def = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "_def");
			InventoryItem.NativeFieldInfoPtr__flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "_flags");
			InventoryItem.NativeFieldInfoPtr__quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "_quantity");
			InventoryItem.NativeFieldInfoPtr__properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "_properties");
			InventoryItem.NativeMethodInfoPtr_get_Id_Public_get_InventoryItemId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, 100666316);
			InventoryItem.NativeMethodInfoPtr_get_DefId_Public_get_InventoryDefId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, 100666317);
			InventoryItem.NativeMethodInfoPtr_get_Quantity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, 100666318);
			InventoryItem.NativeMethodInfoPtr_get_Def_Public_get_InventoryDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, 100666319);
			InventoryItem.NativeMethodInfoPtr_get_Properties_Public_get_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, 100666320);
			InventoryItem.NativeMethodInfoPtr_get_IsNoTrade_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, 100666321);
			InventoryItem.NativeMethodInfoPtr_get_IsRemoved_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, 100666322);
			InventoryItem.NativeMethodInfoPtr_get_IsConsumed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, 100666323);
			InventoryItem.NativeMethodInfoPtr_ConsumeAsync_Public_Task_1_Nullable_1_InventoryResult_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, 100666324);
			InventoryItem.NativeMethodInfoPtr_SplitStackAsync_Public_Task_1_Nullable_1_InventoryResult_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, 100666325);
			InventoryItem.NativeMethodInfoPtr_AddAsync_Public_Task_1_Nullable_1_InventoryResult_InventoryItem_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, 100666326);
			InventoryItem.NativeMethodInfoPtr_From_Internal_Static_InventoryItem_SteamItemDetails_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, 100666327);
			InventoryItem.NativeMethodInfoPtr_GetProperties_Internal_Static_Dictionary_2_String_String_SteamInventoryResult_t_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, 100666328);
			InventoryItem.NativeMethodInfoPtr_get_Acquired_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, 100666329);
			InventoryItem.NativeMethodInfoPtr_get_Origin_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, 100666330);
			InventoryItem.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InventoryItem_InventoryItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, 100666331);
			InventoryItem.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InventoryItem_InventoryItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, 100666332);
			InventoryItem.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, 100666333);
			InventoryItem.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, 100666334);
			InventoryItem.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InventoryItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, 100666335);
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000C2A RID: 3114 RVA: 0x00051CEC File Offset: 0x0004FEEC
		public unsafe InventoryItemId Id
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryItem.NativeMethodInfoPtr_get_Id_Public_get_InventoryItemId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000C2B RID: 3115 RVA: 0x00051D30 File Offset: 0x0004FF30
		public unsafe InventoryDefId DefId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryItem.NativeMethodInfoPtr_get_DefId_Public_get_InventoryDefId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000C2C RID: 3116 RVA: 0x00051D74 File Offset: 0x0004FF74
		public unsafe int Quantity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryItem.NativeMethodInfoPtr_get_Quantity_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000C2D RID: 3117 RVA: 0x00051DB8 File Offset: 0x0004FFB8
		public unsafe InventoryDef Def
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946945, XrefRangeEnd = 946946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryItem.NativeMethodInfoPtr_get_Def_Public_get_InventoryDef_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InventoryDef>(intPtr3) : null;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000C2E RID: 3118 RVA: 0x00051DFC File Offset: 0x0004FFFC
		public unsafe Dictionary<string, string> Properties
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryItem.NativeMethodInfoPtr_get_Properties_Public_get_Dictionary_2_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000C2F RID: 3119 RVA: 0x00051E40 File Offset: 0x00050040
		public unsafe bool IsNoTrade
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryItem.NativeMethodInfoPtr_get_IsNoTrade_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000C30 RID: 3120 RVA: 0x00051E84 File Offset: 0x00050084
		public unsafe bool IsRemoved
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryItem.NativeMethodInfoPtr_get_IsRemoved_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000C31 RID: 3121 RVA: 0x00051EC8 File Offset: 0x000500C8
		public unsafe bool IsConsumed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryItem.NativeMethodInfoPtr_get_IsConsumed_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x00051F0C File Offset: 0x0005010C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946946, XrefRangeEnd = 946960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Nullable<InventoryResult>> ConsumeAsync(int amount = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryItem.NativeMethodInfoPtr_ConsumeAsync_Public_Task_1_Nullable_1_InventoryResult_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<InventoryResult>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x00051F60 File Offset: 0x00050160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946960, XrefRangeEnd = 946974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Nullable<InventoryResult>> SplitStackAsync(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref quantity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryItem.NativeMethodInfoPtr_SplitStackAsync_Public_Task_1_Nullable_1_InventoryResult_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<InventoryResult>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x00051FB4 File Offset: 0x000501B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946974, XrefRangeEnd = 946989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Nullable<InventoryResult>> AddAsync(InventoryItem add, int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(add));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryItem.NativeMethodInfoPtr_AddAsync_Public_Task_1_Nullable_1_InventoryResult_InventoryItem_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<InventoryResult>>>(intPtr3) : null;
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x0005201C File Offset: 0x0005021C
		[CallerCount(0)]
		public unsafe static InventoryItem From(SteamItemDetails_t details)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref details;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryItem.NativeMethodInfoPtr_From_Internal_Static_InventoryItem_SteamItemDetails_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new InventoryItem(intPtr);
			}
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x00052054 File Offset: 0x00050254
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 947007, RefRangeEnd = 947008, XrefRangeStart = 946989, XrefRangeEnd = 947007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<string, string> GetProperties(SteamInventoryResult_t result, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref result;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryItem.NativeMethodInfoPtr_GetProperties_Internal_Static_Dictionary_2_String_String_SteamInventoryResult_t_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000C37 RID: 3127 RVA: 0x000520A4 File Offset: 0x000502A4
		public unsafe DateTime Acquired
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947008, XrefRangeEnd = 947017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryItem.NativeMethodInfoPtr_get_Acquired_Public_get_DateTime_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000C38 RID: 3128 RVA: 0x000520E8 File Offset: 0x000502E8
		public unsafe string Origin
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947017, XrefRangeEnd = 947022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryItem.NativeMethodInfoPtr_get_Origin_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x00052124 File Offset: 0x00050324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947022, XrefRangeEnd = 947023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(InventoryItem a, InventoryItem b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(b));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryItem.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InventoryItem_InventoryItem_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x00052184 File Offset: 0x00050384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947023, XrefRangeEnd = 947024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(InventoryItem a, InventoryItem b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(b));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryItem.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InventoryItem_InventoryItem_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x000521E4 File Offset: 0x000503E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947024, XrefRangeEnd = 947030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryItem.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x00052238 File Offset: 0x00050438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryItem.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x0005227C File Offset: 0x0005047C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947030, XrefRangeEnd = 947031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(InventoryItem p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(p));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryItem.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InventoryItem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x00002F67 File Offset: 0x00001167
		public InventoryItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x00002F70 File Offset: 0x00001170
		public InventoryItem()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr))
		{
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000C40 RID: 3136 RVA: 0x000522D4 File Offset: 0x000504D4
		// (set) Token: 0x06000C41 RID: 3137 RVA: 0x00002F82 File Offset: 0x00001182
		public unsafe InventoryItemId _id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem.NativeFieldInfoPtr__id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem.NativeFieldInfoPtr__id)) = value;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000C42 RID: 3138 RVA: 0x000522FC File Offset: 0x000504FC
		// (set) Token: 0x06000C43 RID: 3139 RVA: 0x00002F9D File Offset: 0x0000119D
		public unsafe InventoryDefId _def
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem.NativeFieldInfoPtr__def);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem.NativeFieldInfoPtr__def)) = value;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000C44 RID: 3140 RVA: 0x00052324 File Offset: 0x00050524
		// (set) Token: 0x06000C45 RID: 3141 RVA: 0x00002FB8 File Offset: 0x000011B8
		public unsafe SteamItemFlags _flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem.NativeFieldInfoPtr__flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem.NativeFieldInfoPtr__flags)) = value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000C46 RID: 3142 RVA: 0x0005234C File Offset: 0x0005054C
		// (set) Token: 0x06000C47 RID: 3143 RVA: 0x00002FD3 File Offset: 0x000011D3
		public unsafe ushort _quantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem.NativeFieldInfoPtr__quantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem.NativeFieldInfoPtr__quantity)) = value;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000C48 RID: 3144 RVA: 0x00052374 File Offset: 0x00050574
		// (set) Token: 0x06000C49 RID: 3145 RVA: 0x00002FEE File Offset: 0x000011EE
		public unsafe Dictionary<string, string> _properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem.NativeFieldInfoPtr__properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem.NativeFieldInfoPtr__properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012D3 RID: 4819
		private static readonly IntPtr NativeFieldInfoPtr__id;

		// Token: 0x040012D4 RID: 4820
		private static readonly IntPtr NativeFieldInfoPtr__def;

		// Token: 0x040012D5 RID: 4821
		private static readonly IntPtr NativeFieldInfoPtr__flags;

		// Token: 0x040012D6 RID: 4822
		private static readonly IntPtr NativeFieldInfoPtr__quantity;

		// Token: 0x040012D7 RID: 4823
		private static readonly IntPtr NativeFieldInfoPtr__properties;

		// Token: 0x040012D8 RID: 4824
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_InventoryItemId_0;

		// Token: 0x040012D9 RID: 4825
		private static readonly IntPtr NativeMethodInfoPtr_get_DefId_Public_get_InventoryDefId_0;

		// Token: 0x040012DA RID: 4826
		private static readonly IntPtr NativeMethodInfoPtr_get_Quantity_Public_get_Int32_0;

		// Token: 0x040012DB RID: 4827
		private static readonly IntPtr NativeMethodInfoPtr_get_Def_Public_get_InventoryDef_0;

		// Token: 0x040012DC RID: 4828
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_get_Dictionary_2_String_String_0;

		// Token: 0x040012DD RID: 4829
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNoTrade_Public_get_Boolean_0;

		// Token: 0x040012DE RID: 4830
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRemoved_Public_get_Boolean_0;

		// Token: 0x040012DF RID: 4831
		private static readonly IntPtr NativeMethodInfoPtr_get_IsConsumed_Public_get_Boolean_0;

		// Token: 0x040012E0 RID: 4832
		private static readonly IntPtr NativeMethodInfoPtr_ConsumeAsync_Public_Task_1_Nullable_1_InventoryResult_Int32_0;

		// Token: 0x040012E1 RID: 4833
		private static readonly IntPtr NativeMethodInfoPtr_SplitStackAsync_Public_Task_1_Nullable_1_InventoryResult_Int32_0;

		// Token: 0x040012E2 RID: 4834
		private static readonly IntPtr NativeMethodInfoPtr_AddAsync_Public_Task_1_Nullable_1_InventoryResult_InventoryItem_Int32_0;

		// Token: 0x040012E3 RID: 4835
		private static readonly IntPtr NativeMethodInfoPtr_From_Internal_Static_InventoryItem_SteamItemDetails_t_0;

		// Token: 0x040012E4 RID: 4836
		private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Internal_Static_Dictionary_2_String_String_SteamInventoryResult_t_Int32_0;

		// Token: 0x040012E5 RID: 4837
		private static readonly IntPtr NativeMethodInfoPtr_get_Acquired_Public_get_DateTime_0;

		// Token: 0x040012E6 RID: 4838
		private static readonly IntPtr NativeMethodInfoPtr_get_Origin_Public_get_String_0;

		// Token: 0x040012E7 RID: 4839
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InventoryItem_InventoryItem_0;

		// Token: 0x040012E8 RID: 4840
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InventoryItem_InventoryItem_0;

		// Token: 0x040012E9 RID: 4841
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040012EA RID: 4842
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040012EB RID: 4843
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InventoryItem_0;

		// Token: 0x0200027A RID: 634
		public sealed class Amount : ValueType
		{
			// Token: 0x0600202A RID: 8234 RVA: 0x0008E564 File Offset: 0x0008C764
			// Note: this type is marked as 'beforefieldinit'.
			static Amount()
			{
				Il2CppClassPointerStore<InventoryItem.Amount>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "Amount");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryItem.Amount>.NativeClassPtr);
				InventoryItem.Amount.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem.Amount>.NativeClassPtr, "Item");
				InventoryItem.Amount.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem.Amount>.NativeClassPtr, "Quantity");
			}

			// Token: 0x0600202B RID: 8235 RVA: 0x0000C28B File Offset: 0x0000A48B
			public Amount(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600202C RID: 8236 RVA: 0x0000C294 File Offset: 0x0000A494
			public Amount()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryItem.Amount>.NativeClassPtr))
			{
			}

			// Token: 0x17000844 RID: 2116
			// (get) Token: 0x0600202D RID: 8237 RVA: 0x0008E5B8 File Offset: 0x0008C7B8
			// (set) Token: 0x0600202E RID: 8238 RVA: 0x0000C2A6 File Offset: 0x0000A4A6
			public InventoryItem Item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem.Amount.NativeFieldInfoPtr_Item);
					return new InventoryItem(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem.Amount.NativeFieldInfoPtr_Item), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000845 RID: 2117
			// (get) Token: 0x0600202F RID: 8239 RVA: 0x0008E5E8 File Offset: 0x0008C7E8
			// (set) Token: 0x06002030 RID: 8240 RVA: 0x0000C2D4 File Offset: 0x0000A4D4
			public unsafe int Quantity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem.Amount.NativeFieldInfoPtr_Quantity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem.Amount.NativeFieldInfoPtr_Quantity)) = value;
				}
			}

			// Token: 0x040022AA RID: 8874
			private static readonly IntPtr NativeFieldInfoPtr_Item;

			// Token: 0x040022AB RID: 8875
			private static readonly IntPtr NativeFieldInfoPtr_Quantity;
		}

		// Token: 0x0200027B RID: 635
		[ObfuscatedName("Steamworks.InventoryItem+<AddAsync>d__23")]
		public sealed class _AddAsync_d__23 : ValueType
		{
			// Token: 0x06002031 RID: 8241 RVA: 0x0008E610 File Offset: 0x0008C810
			// Note: this type is marked as 'beforefieldinit'.
			static _AddAsync_d__23()
			{
				Il2CppClassPointerStore<InventoryItem._AddAsync_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "<AddAsync>d__23");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryItem._AddAsync_d__23>.NativeClassPtr);
				InventoryItem._AddAsync_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem._AddAsync_d__23>.NativeClassPtr, "<>1__state");
				InventoryItem._AddAsync_d__23.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem._AddAsync_d__23>.NativeClassPtr, "<>t__builder");
				InventoryItem._AddAsync_d__23.NativeFieldInfoPtr_add = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem._AddAsync_d__23>.NativeClassPtr, "add");
				InventoryItem._AddAsync_d__23.NativeFieldInfoPtr_quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem._AddAsync_d__23>.NativeClassPtr, "quantity");
				InventoryItem._AddAsync_d__23.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem._AddAsync_d__23>.NativeClassPtr, "<>4__this");
				InventoryItem._AddAsync_d__23.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem._AddAsync_d__23>.NativeClassPtr, "<>u__1");
				InventoryItem._AddAsync_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItem._AddAsync_d__23>.NativeClassPtr, 100666336);
				InventoryItem._AddAsync_d__23.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItem._AddAsync_d__23>.NativeClassPtr, 100666337);
			}

			// Token: 0x06002032 RID: 8242 RVA: 0x0008E6DC File Offset: 0x0008C8DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946833, XrefRangeEnd = 946864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryItem._AddAsync_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002033 RID: 8243 RVA: 0x0008E714 File Offset: 0x0008C914
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946864, XrefRangeEnd = 946870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryItem._AddAsync_d__23.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002034 RID: 8244 RVA: 0x0000C2EF File Offset: 0x0000A4EF
			public _AddAsync_d__23(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002035 RID: 8245 RVA: 0x0000C2F8 File Offset: 0x0000A4F8
			public _AddAsync_d__23()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryItem._AddAsync_d__23>.NativeClassPtr))
			{
			}

			// Token: 0x17000846 RID: 2118
			// (get) Token: 0x06002036 RID: 8246 RVA: 0x0008E75C File Offset: 0x0008C95C
			// (set) Token: 0x06002037 RID: 8247 RVA: 0x0000C30A File Offset: 0x0000A50A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem._AddAsync_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem._AddAsync_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000847 RID: 2119
			// (get) Token: 0x06002038 RID: 8248 RVA: 0x0008E784 File Offset: 0x0008C984
			// (set) Token: 0x06002039 RID: 8249 RVA: 0x0000C325 File Offset: 0x0000A525
			public AsyncTaskMethodBuilder<Nullable<InventoryResult>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem._AddAsync_d__23.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<InventoryResult>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<InventoryResult>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem._AddAsync_d__23.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<InventoryResult>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000848 RID: 2120
			// (get) Token: 0x0600203A RID: 8250 RVA: 0x0008E7B4 File Offset: 0x0008C9B4
			// (set) Token: 0x0600203B RID: 8251 RVA: 0x0000C353 File Offset: 0x0000A553
			public InventoryItem add
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem._AddAsync_d__23.NativeFieldInfoPtr_add);
					return new InventoryItem(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem._AddAsync_d__23.NativeFieldInfoPtr_add), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000849 RID: 2121
			// (get) Token: 0x0600203C RID: 8252 RVA: 0x0008E7E4 File Offset: 0x0008C9E4
			// (set) Token: 0x0600203D RID: 8253 RVA: 0x0000C381 File Offset: 0x0000A581
			public unsafe int quantity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem._AddAsync_d__23.NativeFieldInfoPtr_quantity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem._AddAsync_d__23.NativeFieldInfoPtr_quantity)) = value;
				}
			}

			// Token: 0x1700084A RID: 2122
			// (get) Token: 0x0600203E RID: 8254 RVA: 0x0008E80C File Offset: 0x0008CA0C
			// (set) Token: 0x0600203F RID: 8255 RVA: 0x0000C39C File Offset: 0x0000A59C
			public InventoryItem __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem._AddAsync_d__23.NativeFieldInfoPtr___4__this);
					return new InventoryItem(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem._AddAsync_d__23.NativeFieldInfoPtr___4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700084B RID: 2123
			// (get) Token: 0x06002040 RID: 8256 RVA: 0x0008E83C File Offset: 0x0008CA3C
			// (set) Token: 0x06002041 RID: 8257 RVA: 0x0000C3CA File Offset: 0x0000A5CA
			public TaskAwaiter<Nullable<InventoryResult>> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem._AddAsync_d__23.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<Nullable<InventoryResult>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Nullable<InventoryResult>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem._AddAsync_d__23.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Nullable<InventoryResult>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040022AC RID: 8876
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040022AD RID: 8877
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040022AE RID: 8878
			private static readonly IntPtr NativeFieldInfoPtr_add;

			// Token: 0x040022AF RID: 8879
			private static readonly IntPtr NativeFieldInfoPtr_quantity;

			// Token: 0x040022B0 RID: 8880
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040022B1 RID: 8881
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040022B2 RID: 8882
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040022B3 RID: 8883
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200027C RID: 636
		[ObfuscatedName("Steamworks.InventoryItem+<ConsumeAsync>d__21")]
		public sealed class _ConsumeAsync_d__21 : ValueType
		{
			// Token: 0x06002042 RID: 8258 RVA: 0x0008E86C File Offset: 0x0008CA6C
			// Note: this type is marked as 'beforefieldinit'.
			static _ConsumeAsync_d__21()
			{
				Il2CppClassPointerStore<InventoryItem._ConsumeAsync_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "<ConsumeAsync>d__21");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryItem._ConsumeAsync_d__21>.NativeClassPtr);
				InventoryItem._ConsumeAsync_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem._ConsumeAsync_d__21>.NativeClassPtr, "<>1__state");
				InventoryItem._ConsumeAsync_d__21.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem._ConsumeAsync_d__21>.NativeClassPtr, "<>t__builder");
				InventoryItem._ConsumeAsync_d__21.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem._ConsumeAsync_d__21>.NativeClassPtr, "<>4__this");
				InventoryItem._ConsumeAsync_d__21.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem._ConsumeAsync_d__21>.NativeClassPtr, "amount");
				InventoryItem._ConsumeAsync_d__21.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem._ConsumeAsync_d__21>.NativeClassPtr, "<>u__1");
				InventoryItem._ConsumeAsync_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItem._ConsumeAsync_d__21>.NativeClassPtr, 100666338);
				InventoryItem._ConsumeAsync_d__21.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItem._ConsumeAsync_d__21>.NativeClassPtr, 100666339);
			}

			// Token: 0x06002043 RID: 8259 RVA: 0x0008E924 File Offset: 0x0008CB24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946870, XrefRangeEnd = 946901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryItem._ConsumeAsync_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002044 RID: 8260 RVA: 0x0008E95C File Offset: 0x0008CB5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946901, XrefRangeEnd = 946907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryItem._ConsumeAsync_d__21.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002045 RID: 8261 RVA: 0x0000C3F8 File Offset: 0x0000A5F8
			public _ConsumeAsync_d__21(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002046 RID: 8262 RVA: 0x0000C401 File Offset: 0x0000A601
			public _ConsumeAsync_d__21()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryItem._ConsumeAsync_d__21>.NativeClassPtr))
			{
			}

			// Token: 0x1700084C RID: 2124
			// (get) Token: 0x06002047 RID: 8263 RVA: 0x0008E9A4 File Offset: 0x0008CBA4
			// (set) Token: 0x06002048 RID: 8264 RVA: 0x0000C413 File Offset: 0x0000A613
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem._ConsumeAsync_d__21.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem._ConsumeAsync_d__21.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700084D RID: 2125
			// (get) Token: 0x06002049 RID: 8265 RVA: 0x0008E9CC File Offset: 0x0008CBCC
			// (set) Token: 0x0600204A RID: 8266 RVA: 0x0000C42E File Offset: 0x0000A62E
			public AsyncTaskMethodBuilder<Nullable<InventoryResult>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem._ConsumeAsync_d__21.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<InventoryResult>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<InventoryResult>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem._ConsumeAsync_d__21.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<InventoryResult>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700084E RID: 2126
			// (get) Token: 0x0600204B RID: 8267 RVA: 0x0008E9FC File Offset: 0x0008CBFC
			// (set) Token: 0x0600204C RID: 8268 RVA: 0x0000C45C File Offset: 0x0000A65C
			public InventoryItem __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem._ConsumeAsync_d__21.NativeFieldInfoPtr___4__this);
					return new InventoryItem(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem._ConsumeAsync_d__21.NativeFieldInfoPtr___4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700084F RID: 2127
			// (get) Token: 0x0600204D RID: 8269 RVA: 0x0008EA2C File Offset: 0x0008CC2C
			// (set) Token: 0x0600204E RID: 8270 RVA: 0x0000C48A File Offset: 0x0000A68A
			public unsafe int amount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem._ConsumeAsync_d__21.NativeFieldInfoPtr_amount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem._ConsumeAsync_d__21.NativeFieldInfoPtr_amount)) = value;
				}
			}

			// Token: 0x17000850 RID: 2128
			// (get) Token: 0x0600204F RID: 8271 RVA: 0x0008EA54 File Offset: 0x0008CC54
			// (set) Token: 0x06002050 RID: 8272 RVA: 0x0000C4A5 File Offset: 0x0000A6A5
			public TaskAwaiter<Nullable<InventoryResult>> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem._ConsumeAsync_d__21.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<Nullable<InventoryResult>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Nullable<InventoryResult>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem._ConsumeAsync_d__21.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Nullable<InventoryResult>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040022B4 RID: 8884
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040022B5 RID: 8885
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040022B6 RID: 8886
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040022B7 RID: 8887
			private static readonly IntPtr NativeFieldInfoPtr_amount;

			// Token: 0x040022B8 RID: 8888
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040022B9 RID: 8889
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040022BA RID: 8890
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200027D RID: 637
		[ObfuscatedName("Steamworks.InventoryItem+<SplitStackAsync>d__22")]
		public sealed class _SplitStackAsync_d__22 : ValueType
		{
			// Token: 0x06002051 RID: 8273 RVA: 0x0008EA84 File Offset: 0x0008CC84
			// Note: this type is marked as 'beforefieldinit'.
			static _SplitStackAsync_d__22()
			{
				Il2CppClassPointerStore<InventoryItem._SplitStackAsync_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "<SplitStackAsync>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryItem._SplitStackAsync_d__22>.NativeClassPtr);
				InventoryItem._SplitStackAsync_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem._SplitStackAsync_d__22>.NativeClassPtr, "<>1__state");
				InventoryItem._SplitStackAsync_d__22.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem._SplitStackAsync_d__22>.NativeClassPtr, "<>t__builder");
				InventoryItem._SplitStackAsync_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem._SplitStackAsync_d__22>.NativeClassPtr, "<>4__this");
				InventoryItem._SplitStackAsync_d__22.NativeFieldInfoPtr_quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem._SplitStackAsync_d__22>.NativeClassPtr, "quantity");
				InventoryItem._SplitStackAsync_d__22.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem._SplitStackAsync_d__22>.NativeClassPtr, "<>u__1");
				InventoryItem._SplitStackAsync_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItem._SplitStackAsync_d__22>.NativeClassPtr, 100666340);
				InventoryItem._SplitStackAsync_d__22.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItem._SplitStackAsync_d__22>.NativeClassPtr, 100666341);
			}

			// Token: 0x06002052 RID: 8274 RVA: 0x0008EB3C File Offset: 0x0008CD3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946907, XrefRangeEnd = 946939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryItem._SplitStackAsync_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002053 RID: 8275 RVA: 0x0008EB74 File Offset: 0x0008CD74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946939, XrefRangeEnd = 946945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryItem._SplitStackAsync_d__22.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002054 RID: 8276 RVA: 0x0000C4D3 File Offset: 0x0000A6D3
			public _SplitStackAsync_d__22(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002055 RID: 8277 RVA: 0x0000C4DC File Offset: 0x0000A6DC
			public _SplitStackAsync_d__22()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryItem._SplitStackAsync_d__22>.NativeClassPtr))
			{
			}

			// Token: 0x17000851 RID: 2129
			// (get) Token: 0x06002056 RID: 8278 RVA: 0x0008EBBC File Offset: 0x0008CDBC
			// (set) Token: 0x06002057 RID: 8279 RVA: 0x0000C4EE File Offset: 0x0000A6EE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem._SplitStackAsync_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem._SplitStackAsync_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000852 RID: 2130
			// (get) Token: 0x06002058 RID: 8280 RVA: 0x0008EBE4 File Offset: 0x0008CDE4
			// (set) Token: 0x06002059 RID: 8281 RVA: 0x0000C509 File Offset: 0x0000A709
			public AsyncTaskMethodBuilder<Nullable<InventoryResult>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem._SplitStackAsync_d__22.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<InventoryResult>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<InventoryResult>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem._SplitStackAsync_d__22.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<InventoryResult>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000853 RID: 2131
			// (get) Token: 0x0600205A RID: 8282 RVA: 0x0008EC14 File Offset: 0x0008CE14
			// (set) Token: 0x0600205B RID: 8283 RVA: 0x0000C537 File Offset: 0x0000A737
			public InventoryItem __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem._SplitStackAsync_d__22.NativeFieldInfoPtr___4__this);
					return new InventoryItem(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem._SplitStackAsync_d__22.NativeFieldInfoPtr___4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000854 RID: 2132
			// (get) Token: 0x0600205C RID: 8284 RVA: 0x0008EC44 File Offset: 0x0008CE44
			// (set) Token: 0x0600205D RID: 8285 RVA: 0x0000C565 File Offset: 0x0000A765
			public unsafe int quantity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem._SplitStackAsync_d__22.NativeFieldInfoPtr_quantity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem._SplitStackAsync_d__22.NativeFieldInfoPtr_quantity)) = value;
				}
			}

			// Token: 0x17000855 RID: 2133
			// (get) Token: 0x0600205E RID: 8286 RVA: 0x0008EC6C File Offset: 0x0008CE6C
			// (set) Token: 0x0600205F RID: 8287 RVA: 0x0000C580 File Offset: 0x0000A780
			public TaskAwaiter<Nullable<InventoryResult>> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem._SplitStackAsync_d__22.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<Nullable<InventoryResult>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Nullable<InventoryResult>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryItem._SplitStackAsync_d__22.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Nullable<InventoryResult>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040022BB RID: 8891
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040022BC RID: 8892
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040022BD RID: 8893
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040022BE RID: 8894
			private static readonly IntPtr NativeFieldInfoPtr_quantity;

			// Token: 0x040022BF RID: 8895
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040022C0 RID: 8896
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040022C1 RID: 8897
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
