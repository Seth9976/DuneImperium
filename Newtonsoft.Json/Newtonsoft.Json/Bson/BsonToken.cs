using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000105 RID: 261
	public class BsonToken : Object
	{
		// Token: 0x060015B2 RID: 5554 RVA: 0x000759F0 File Offset: 0x00073BF0
		// Note: this type is marked as 'beforefieldinit'.
		static BsonToken()
		{
			Il2CppClassPointerStore<BsonToken>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Bson", "BsonToken");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BsonToken>.NativeClassPtr);
			BsonToken.NativeFieldInfoPtr__Parent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonToken>.NativeClassPtr, "<Parent>k__BackingField");
			BsonToken.NativeFieldInfoPtr__CalculatedSize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonToken>.NativeClassPtr, "<CalculatedSize>k__BackingField");
			BsonToken.NativeMethodInfoPtr_get_Type_Public_Abstract_Virtual_New_get_BsonType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonToken>.NativeClassPtr, 100667392);
			BsonToken.NativeMethodInfoPtr_get_Parent_Public_get_BsonToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonToken>.NativeClassPtr, 100667393);
			BsonToken.NativeMethodInfoPtr_set_Parent_Public_set_Void_BsonToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonToken>.NativeClassPtr, 100667394);
			BsonToken.NativeMethodInfoPtr_get_CalculatedSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonToken>.NativeClassPtr, 100667395);
			BsonToken.NativeMethodInfoPtr_set_CalculatedSize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonToken>.NativeClassPtr, 100667396);
			BsonToken.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonToken>.NativeClassPtr, 100667397);
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x060015B3 RID: 5555 RVA: 0x00075AC0 File Offset: 0x00073CC0
		public unsafe virtual BsonType Type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BsonToken.NativeMethodInfoPtr_get_Type_Public_Abstract_Virtual_New_get_BsonType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x060015B4 RID: 5556 RVA: 0x00075B08 File Offset: 0x00073D08
		// (set) Token: 0x060015B5 RID: 5557 RVA: 0x00075B48 File Offset: 0x00073D48
		public unsafe BsonToken Parent
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonToken.NativeMethodInfoPtr_get_Parent_Public_get_BsonToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BsonToken>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonToken.NativeMethodInfoPtr_set_Parent_Public_set_Void_BsonToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x060015B6 RID: 5558 RVA: 0x00075B8C File Offset: 0x00073D8C
		// (set) Token: 0x060015B7 RID: 5559 RVA: 0x00075BC8 File Offset: 0x00073DC8
		public unsafe int CalculatedSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonToken.NativeMethodInfoPtr_get_CalculatedSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 311421, RefRangeEnd = 311423, XrefRangeStart = 311421, XrefRangeEnd = 311423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonToken.NativeMethodInfoPtr_set_CalculatedSize_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x00075C08 File Offset: 0x00073E08
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BsonToken()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BsonToken>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonToken.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x0000881E File Offset: 0x00006A1E
		public BsonToken(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x060015BA RID: 5562 RVA: 0x00075C44 File Offset: 0x00073E44
		// (set) Token: 0x060015BB RID: 5563 RVA: 0x00008827 File Offset: 0x00006A27
		public unsafe BsonToken _Parent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonToken.NativeFieldInfoPtr__Parent_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BsonToken>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonToken.NativeFieldInfoPtr__Parent_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x060015BC RID: 5564 RVA: 0x00075C74 File Offset: 0x00073E74
		// (set) Token: 0x060015BD RID: 5565 RVA: 0x00008846 File Offset: 0x00006A46
		public unsafe int _CalculatedSize_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonToken.NativeFieldInfoPtr__CalculatedSize_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonToken.NativeFieldInfoPtr__CalculatedSize_k__BackingField)) = value;
			}
		}

		// Token: 0x04001186 RID: 4486
		private static readonly IntPtr NativeFieldInfoPtr__Parent_k__BackingField;

		// Token: 0x04001187 RID: 4487
		private static readonly IntPtr NativeFieldInfoPtr__CalculatedSize_k__BackingField;

		// Token: 0x04001188 RID: 4488
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Abstract_Virtual_New_get_BsonType_0;

		// Token: 0x04001189 RID: 4489
		private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Public_get_BsonToken_0;

		// Token: 0x0400118A RID: 4490
		private static readonly IntPtr NativeMethodInfoPtr_set_Parent_Public_set_Void_BsonToken_0;

		// Token: 0x0400118B RID: 4491
		private static readonly IntPtr NativeMethodInfoPtr_get_CalculatedSize_Public_get_Int32_0;

		// Token: 0x0400118C RID: 4492
		private static readonly IntPtr NativeMethodInfoPtr_set_CalculatedSize_Public_set_Void_Int32_0;

		// Token: 0x0400118D RID: 4493
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
