using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000108 RID: 264
	public class BsonEmpty : BsonToken
	{
		// Token: 0x060015D0 RID: 5584 RVA: 0x000760EC File Offset: 0x000742EC
		// Note: this type is marked as 'beforefieldinit'.
		static BsonEmpty()
		{
			Il2CppClassPointerStore<BsonEmpty>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Bson", "BsonEmpty");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BsonEmpty>.NativeClassPtr);
			BsonEmpty.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonEmpty>.NativeClassPtr, "Null");
			BsonEmpty.NativeFieldInfoPtr_Undefined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonEmpty>.NativeClassPtr, "Undefined");
			BsonEmpty.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonEmpty>.NativeClassPtr, "<Type>k__BackingField");
			BsonEmpty.NativeMethodInfoPtr__ctor_Private_Void_BsonType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonEmpty>.NativeClassPtr, 100667408);
			BsonEmpty.NativeMethodInfoPtr_get_Type_Public_Virtual_get_BsonType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonEmpty>.NativeClassPtr, 100667409);
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x00076180 File Offset: 0x00074380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767123, XrefRangeEnd = 767124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BsonEmpty(BsonType type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BsonEmpty>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonEmpty.NativeMethodInfoPtr__ctor_Private_Void_BsonType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x060015D2 RID: 5586 RVA: 0x000761C8 File Offset: 0x000743C8
		public unsafe override BsonType Type
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BsonEmpty.NativeMethodInfoPtr_get_Type_Public_Virtual_get_BsonType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x000088B1 File Offset: 0x00006AB1
		public BsonEmpty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x060015D4 RID: 5588 RVA: 0x00076210 File Offset: 0x00074410
		// (set) Token: 0x060015D5 RID: 5589 RVA: 0x000088BA File Offset: 0x00006ABA
		public unsafe static BsonToken Null
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BsonEmpty.NativeFieldInfoPtr_Null, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BsonToken>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BsonEmpty.NativeFieldInfoPtr_Null, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x060015D6 RID: 5590 RVA: 0x00076238 File Offset: 0x00074438
		// (set) Token: 0x060015D7 RID: 5591 RVA: 0x000088CC File Offset: 0x00006ACC
		public unsafe static BsonToken Undefined
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BsonEmpty.NativeFieldInfoPtr_Undefined, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BsonToken>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BsonEmpty.NativeFieldInfoPtr_Undefined, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x060015D8 RID: 5592 RVA: 0x00076260 File Offset: 0x00074460
		// (set) Token: 0x060015D9 RID: 5593 RVA: 0x000088DE File Offset: 0x00006ADE
		public unsafe BsonType _Type_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonEmpty.NativeFieldInfoPtr__Type_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonEmpty.NativeFieldInfoPtr__Type_k__BackingField)) = value;
			}
		}

		// Token: 0x0400119A RID: 4506
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x0400119B RID: 4507
		private static readonly IntPtr NativeFieldInfoPtr_Undefined;

		// Token: 0x0400119C RID: 4508
		private static readonly IntPtr NativeFieldInfoPtr__Type_k__BackingField;

		// Token: 0x0400119D RID: 4509
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_BsonType_0;

		// Token: 0x0400119E RID: 4510
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_get_BsonType_0;
	}
}
