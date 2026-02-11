using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000081 RID: 129
	public class JsonContainerContract : JsonContract
	{
		// Token: 0x06000A8F RID: 2703 RVA: 0x00042F50 File Offset: 0x00041150
		// Note: this type is marked as 'beforefieldinit'.
		static JsonContainerContract()
		{
			Il2CppClassPointerStore<JsonContainerContract>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "JsonContainerContract");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonContainerContract>.NativeClassPtr);
			JsonContainerContract.NativeFieldInfoPtr__itemContract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContainerContract>.NativeClassPtr, "_itemContract");
			JsonContainerContract.NativeFieldInfoPtr__finalItemContract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContainerContract>.NativeClassPtr, "_finalItemContract");
			JsonContainerContract.NativeFieldInfoPtr__ItemConverter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContainerContract>.NativeClassPtr, "<ItemConverter>k__BackingField");
			JsonContainerContract.NativeFieldInfoPtr__ItemIsReference_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContainerContract>.NativeClassPtr, "<ItemIsReference>k__BackingField");
			JsonContainerContract.NativeFieldInfoPtr__ItemReferenceLoopHandling_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContainerContract>.NativeClassPtr, "<ItemReferenceLoopHandling>k__BackingField");
			JsonContainerContract.NativeFieldInfoPtr__ItemTypeNameHandling_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContainerContract>.NativeClassPtr, "<ItemTypeNameHandling>k__BackingField");
			JsonContainerContract.NativeMethodInfoPtr_get_ItemContract_Internal_get_JsonContract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContainerContract>.NativeClassPtr, 100665308);
			JsonContainerContract.NativeMethodInfoPtr_set_ItemContract_Internal_set_Void_JsonContract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContainerContract>.NativeClassPtr, 100665309);
			JsonContainerContract.NativeMethodInfoPtr_get_FinalItemContract_Internal_get_JsonContract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContainerContract>.NativeClassPtr, 100665310);
			JsonContainerContract.NativeMethodInfoPtr_get_ItemConverter_Public_get_JsonConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContainerContract>.NativeClassPtr, 100665311);
			JsonContainerContract.NativeMethodInfoPtr_set_ItemConverter_Public_set_Void_JsonConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContainerContract>.NativeClassPtr, 100665312);
			JsonContainerContract.NativeMethodInfoPtr_get_ItemIsReference_Public_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContainerContract>.NativeClassPtr, 100665313);
			JsonContainerContract.NativeMethodInfoPtr_set_ItemIsReference_Public_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContainerContract>.NativeClassPtr, 100665314);
			JsonContainerContract.NativeMethodInfoPtr_get_ItemReferenceLoopHandling_Public_get_Nullable_1_ReferenceLoopHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContainerContract>.NativeClassPtr, 100665315);
			JsonContainerContract.NativeMethodInfoPtr_set_ItemReferenceLoopHandling_Public_set_Void_Nullable_1_ReferenceLoopHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContainerContract>.NativeClassPtr, 100665316);
			JsonContainerContract.NativeMethodInfoPtr_get_ItemTypeNameHandling_Public_get_Nullable_1_TypeNameHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContainerContract>.NativeClassPtr, 100665317);
			JsonContainerContract.NativeMethodInfoPtr_set_ItemTypeNameHandling_Public_set_Void_Nullable_1_TypeNameHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContainerContract>.NativeClassPtr, 100665318);
			JsonContainerContract.NativeMethodInfoPtr__ctor_Internal_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContainerContract>.NativeClassPtr, 100665319);
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000A90 RID: 2704 RVA: 0x000430E8 File Offset: 0x000412E8
		// (set) Token: 0x06000A91 RID: 2705 RVA: 0x00043128 File Offset: 0x00041328
		public unsafe JsonContract ItemContract
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContainerContract.NativeMethodInfoPtr_get_ItemContract_Internal_get_JsonContract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonContract>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 749214, RefRangeEnd = 749218, XrefRangeStart = 749209, XrefRangeEnd = 749214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContainerContract.NativeMethodInfoPtr_set_ItemContract_Internal_set_Void_JsonContract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000A92 RID: 2706 RVA: 0x0004316C File Offset: 0x0004136C
		public unsafe JsonContract FinalItemContract
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContainerContract.NativeMethodInfoPtr_get_FinalItemContract_Internal_get_JsonContract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonContract>(intPtr3) : null;
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000A93 RID: 2707 RVA: 0x000431AC File Offset: 0x000413AC
		// (set) Token: 0x06000A94 RID: 2708 RVA: 0x000431EC File Offset: 0x000413EC
		public unsafe JsonConverter ItemConverter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContainerContract.NativeMethodInfoPtr_get_ItemConverter_Public_get_JsonConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonConverter>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContainerContract.NativeMethodInfoPtr_set_ItemConverter_Public_set_Void_JsonConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x00043230 File Offset: 0x00041430
		// (set) Token: 0x06000A96 RID: 2710 RVA: 0x00043268 File Offset: 0x00041468
		public unsafe Nullable<bool> ItemIsReference
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContainerContract.NativeMethodInfoPtr_get_ItemIsReference_Public_get_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContainerContract.NativeMethodInfoPtr_set_ItemIsReference_Public_set_Void_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x000432B0 File Offset: 0x000414B0
		// (set) Token: 0x06000A98 RID: 2712 RVA: 0x000432E8 File Offset: 0x000414E8
		public unsafe Nullable<ReferenceLoopHandling> ItemReferenceLoopHandling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContainerContract.NativeMethodInfoPtr_get_ItemReferenceLoopHandling_Public_get_Nullable_1_ReferenceLoopHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<ReferenceLoopHandling>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContainerContract.NativeMethodInfoPtr_set_ItemReferenceLoopHandling_Public_set_Void_Nullable_1_ReferenceLoopHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x00043330 File Offset: 0x00041530
		// (set) Token: 0x06000A9A RID: 2714 RVA: 0x00043368 File Offset: 0x00041568
		public unsafe Nullable<TypeNameHandling> ItemTypeNameHandling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContainerContract.NativeMethodInfoPtr_get_ItemTypeNameHandling_Public_get_Nullable_1_TypeNameHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<TypeNameHandling>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContainerContract.NativeMethodInfoPtr_set_ItemTypeNameHandling_Public_set_Void_Nullable_1_TypeNameHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x000433B0 File Offset: 0x000415B0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 749233, RefRangeEnd = 749241, XrefRangeStart = 749218, XrefRangeEnd = 749233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonContainerContract(Type underlyingType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonContainerContract>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(underlyingType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContainerContract.NativeMethodInfoPtr__ctor_Internal_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x00005413 File Offset: 0x00003613
		public JsonContainerContract(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x000433FC File Offset: 0x000415FC
		// (set) Token: 0x06000A9E RID: 2718 RVA: 0x0000541C File Offset: 0x0000361C
		public unsafe JsonContract _itemContract
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContainerContract.NativeFieldInfoPtr__itemContract);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonContract>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContainerContract.NativeFieldInfoPtr__itemContract), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x0004342C File Offset: 0x0004162C
		// (set) Token: 0x06000AA0 RID: 2720 RVA: 0x0000543B File Offset: 0x0000363B
		public unsafe JsonContract _finalItemContract
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContainerContract.NativeFieldInfoPtr__finalItemContract);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonContract>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContainerContract.NativeFieldInfoPtr__finalItemContract), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x0004345C File Offset: 0x0004165C
		// (set) Token: 0x06000AA2 RID: 2722 RVA: 0x0000545A File Offset: 0x0000365A
		public unsafe JsonConverter _ItemConverter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContainerContract.NativeFieldInfoPtr__ItemConverter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonConverter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContainerContract.NativeFieldInfoPtr__ItemConverter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x0004348C File Offset: 0x0004168C
		// (set) Token: 0x06000AA4 RID: 2724 RVA: 0x00005479 File Offset: 0x00003679
		public Nullable<bool> _ItemIsReference_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContainerContract.NativeFieldInfoPtr__ItemIsReference_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContainerContract.NativeFieldInfoPtr__ItemIsReference_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x000434BC File Offset: 0x000416BC
		// (set) Token: 0x06000AA6 RID: 2726 RVA: 0x000054A7 File Offset: 0x000036A7
		public Nullable<ReferenceLoopHandling> _ItemReferenceLoopHandling_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContainerContract.NativeFieldInfoPtr__ItemReferenceLoopHandling_k__BackingField);
				return new Nullable<ReferenceLoopHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<ReferenceLoopHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContainerContract.NativeFieldInfoPtr__ItemReferenceLoopHandling_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<ReferenceLoopHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x000434EC File Offset: 0x000416EC
		// (set) Token: 0x06000AA8 RID: 2728 RVA: 0x000054D5 File Offset: 0x000036D5
		public Nullable<TypeNameHandling> _ItemTypeNameHandling_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContainerContract.NativeFieldInfoPtr__ItemTypeNameHandling_k__BackingField);
				return new Nullable<TypeNameHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<TypeNameHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContainerContract.NativeFieldInfoPtr__ItemTypeNameHandling_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<TypeNameHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040008B6 RID: 2230
		private static readonly IntPtr NativeFieldInfoPtr__itemContract;

		// Token: 0x040008B7 RID: 2231
		private static readonly IntPtr NativeFieldInfoPtr__finalItemContract;

		// Token: 0x040008B8 RID: 2232
		private static readonly IntPtr NativeFieldInfoPtr__ItemConverter_k__BackingField;

		// Token: 0x040008B9 RID: 2233
		private static readonly IntPtr NativeFieldInfoPtr__ItemIsReference_k__BackingField;

		// Token: 0x040008BA RID: 2234
		private static readonly IntPtr NativeFieldInfoPtr__ItemReferenceLoopHandling_k__BackingField;

		// Token: 0x040008BB RID: 2235
		private static readonly IntPtr NativeFieldInfoPtr__ItemTypeNameHandling_k__BackingField;

		// Token: 0x040008BC RID: 2236
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemContract_Internal_get_JsonContract_0;

		// Token: 0x040008BD RID: 2237
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemContract_Internal_set_Void_JsonContract_0;

		// Token: 0x040008BE RID: 2238
		private static readonly IntPtr NativeMethodInfoPtr_get_FinalItemContract_Internal_get_JsonContract_0;

		// Token: 0x040008BF RID: 2239
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemConverter_Public_get_JsonConverter_0;

		// Token: 0x040008C0 RID: 2240
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemConverter_Public_set_Void_JsonConverter_0;

		// Token: 0x040008C1 RID: 2241
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemIsReference_Public_get_Nullable_1_Boolean_0;

		// Token: 0x040008C2 RID: 2242
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemIsReference_Public_set_Void_Nullable_1_Boolean_0;

		// Token: 0x040008C3 RID: 2243
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemReferenceLoopHandling_Public_get_Nullable_1_ReferenceLoopHandling_0;

		// Token: 0x040008C4 RID: 2244
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemReferenceLoopHandling_Public_set_Void_Nullable_1_ReferenceLoopHandling_0;

		// Token: 0x040008C5 RID: 2245
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemTypeNameHandling_Public_get_Nullable_1_TypeNameHandling_0;

		// Token: 0x040008C6 RID: 2246
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemTypeNameHandling_Public_set_Void_Nullable_1_TypeNameHandling_0;

		// Token: 0x040008C7 RID: 2247
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_0;
	}
}
