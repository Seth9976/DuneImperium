using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000109 RID: 265
	public class BsonValue : BsonToken
	{
		// Token: 0x060015DA RID: 5594 RVA: 0x00076288 File Offset: 0x00074488
		// Note: this type is marked as 'beforefieldinit'.
		static BsonValue()
		{
			Il2CppClassPointerStore<BsonValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Bson", "BsonValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BsonValue>.NativeClassPtr);
			BsonValue.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonValue>.NativeClassPtr, "_value");
			BsonValue.NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonValue>.NativeClassPtr, "_type");
			BsonValue.NativeMethodInfoPtr__ctor_Public_Void_Object_BsonType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonValue>.NativeClassPtr, 100667411);
			BsonValue.NativeMethodInfoPtr_get_Value_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonValue>.NativeClassPtr, 100667412);
			BsonValue.NativeMethodInfoPtr_get_Type_Public_Virtual_get_BsonType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonValue>.NativeClassPtr, 100667413);
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x0007631C File Offset: 0x0007451C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767124, XrefRangeEnd = 767126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BsonValue(Object value, BsonType type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BsonValue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonValue.NativeMethodInfoPtr__ctor_Public_Void_Object_BsonType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x060015DC RID: 5596 RVA: 0x00076378 File Offset: 0x00074578
		public unsafe Object Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonValue.NativeMethodInfoPtr_get_Value_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x060015DD RID: 5597 RVA: 0x000763B8 File Offset: 0x000745B8
		public unsafe override BsonType Type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BsonValue.NativeMethodInfoPtr_get_Type_Public_Virtual_get_BsonType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x000088F9 File Offset: 0x00006AF9
		public BsonValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x060015DF RID: 5599 RVA: 0x00076400 File Offset: 0x00074600
		// (set) Token: 0x060015E0 RID: 5600 RVA: 0x00008902 File Offset: 0x00006B02
		public unsafe Object _value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonValue.NativeFieldInfoPtr__value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonValue.NativeFieldInfoPtr__value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x060015E1 RID: 5601 RVA: 0x00076430 File Offset: 0x00074630
		// (set) Token: 0x060015E2 RID: 5602 RVA: 0x00008921 File Offset: 0x00006B21
		public unsafe BsonType _type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonValue.NativeFieldInfoPtr__type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonValue.NativeFieldInfoPtr__type)) = value;
			}
		}

		// Token: 0x0400119F RID: 4511
		private static readonly IntPtr NativeFieldInfoPtr__value;

		// Token: 0x040011A0 RID: 4512
		private static readonly IntPtr NativeFieldInfoPtr__type;

		// Token: 0x040011A1 RID: 4513
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_BsonType_0;

		// Token: 0x040011A2 RID: 4514
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Object_0;

		// Token: 0x040011A3 RID: 4515
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_get_BsonType_0;
	}
}
