using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x0200010B RID: 267
	public class BsonString : BsonValue
	{
		// Token: 0x060015EA RID: 5610 RVA: 0x0007655C File Offset: 0x0007475C
		// Note: this type is marked as 'beforefieldinit'.
		static BsonString()
		{
			Il2CppClassPointerStore<BsonString>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Bson", "BsonString");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BsonString>.NativeClassPtr);
			BsonString.NativeFieldInfoPtr__ByteCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonString>.NativeClassPtr, "<ByteCount>k__BackingField");
			BsonString.NativeFieldInfoPtr__IncludeLength_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonString>.NativeClassPtr, "<IncludeLength>k__BackingField");
			BsonString.NativeMethodInfoPtr_get_ByteCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonString>.NativeClassPtr, 100667416);
			BsonString.NativeMethodInfoPtr_set_ByteCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonString>.NativeClassPtr, 100667417);
			BsonString.NativeMethodInfoPtr_get_IncludeLength_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonString>.NativeClassPtr, 100667418);
			BsonString.NativeMethodInfoPtr__ctor_Public_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonString>.NativeClassPtr, 100667419);
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x060015EB RID: 5611 RVA: 0x00076604 File Offset: 0x00074804
		// (set) Token: 0x060015EC RID: 5612 RVA: 0x00076640 File Offset: 0x00074840
		public unsafe int ByteCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonString.NativeMethodInfoPtr_get_ByteCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137951, RefRangeEnd = 137952, XrefRangeStart = 137951, XrefRangeEnd = 137952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonString.NativeMethodInfoPtr_set_ByteCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x060015ED RID: 5613 RVA: 0x00076680 File Offset: 0x00074880
		public unsafe bool IncludeLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonString.NativeMethodInfoPtr_get_IncludeLength_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x000766BC File Offset: 0x000748BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767131, XrefRangeEnd = 767133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BsonString(Object value, bool includeLength)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BsonString>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonString.NativeMethodInfoPtr__ctor_Public_Void_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x00008969 File Offset: 0x00006B69
		public BsonString(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x060015F0 RID: 5616 RVA: 0x00076718 File Offset: 0x00074918
		// (set) Token: 0x060015F1 RID: 5617 RVA: 0x00008972 File Offset: 0x00006B72
		public unsafe int _ByteCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonString.NativeFieldInfoPtr__ByteCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonString.NativeFieldInfoPtr__ByteCount_k__BackingField)) = value;
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x060015F2 RID: 5618 RVA: 0x00076740 File Offset: 0x00074940
		// (set) Token: 0x060015F3 RID: 5619 RVA: 0x0000898D File Offset: 0x00006B8D
		public unsafe bool _IncludeLength_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonString.NativeFieldInfoPtr__IncludeLength_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonString.NativeFieldInfoPtr__IncludeLength_k__BackingField)) = value;
			}
		}

		// Token: 0x040011A7 RID: 4519
		private static readonly IntPtr NativeFieldInfoPtr__ByteCount_k__BackingField;

		// Token: 0x040011A8 RID: 4520
		private static readonly IntPtr NativeFieldInfoPtr__IncludeLength_k__BackingField;

		// Token: 0x040011A9 RID: 4521
		private static readonly IntPtr NativeMethodInfoPtr_get_ByteCount_Public_get_Int32_0;

		// Token: 0x040011AA RID: 4522
		private static readonly IntPtr NativeMethodInfoPtr_set_ByteCount_Public_set_Void_Int32_0;

		// Token: 0x040011AB RID: 4523
		private static readonly IntPtr NativeMethodInfoPtr_get_IncludeLength_Public_get_Boolean_0;

		// Token: 0x040011AC RID: 4524
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_Boolean_0;
	}
}
