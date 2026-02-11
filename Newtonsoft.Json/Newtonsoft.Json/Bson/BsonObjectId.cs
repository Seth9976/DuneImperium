using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000103 RID: 259
	public class BsonObjectId : Object
	{
		// Token: 0x0600156B RID: 5483 RVA: 0x000749DC File Offset: 0x00072BDC
		// Note: this type is marked as 'beforefieldinit'.
		static BsonObjectId()
		{
			Il2CppClassPointerStore<BsonObjectId>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Bson", "BsonObjectId");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BsonObjectId>.NativeClassPtr);
			BsonObjectId.NativeFieldInfoPtr__Value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonObjectId>.NativeClassPtr, "<Value>k__BackingField");
			BsonObjectId.NativeMethodInfoPtr_get_Value_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonObjectId>.NativeClassPtr, 100667355);
			BsonObjectId.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonObjectId>.NativeClassPtr, 100667356);
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x0600156C RID: 5484 RVA: 0x00074A48 File Offset: 0x00072C48
		public unsafe Il2CppStructArray<byte> Value
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonObjectId.NativeMethodInfoPtr_get_Value_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x00074A88 File Offset: 0x00072C88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 766883, RefRangeEnd = 766884, XrefRangeStart = 766870, XrefRangeEnd = 766883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BsonObjectId(Il2CppStructArray<byte> value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BsonObjectId>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonObjectId.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x00008675 File Offset: 0x00006875
		public BsonObjectId(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x0600156F RID: 5487 RVA: 0x00074AD4 File Offset: 0x00072CD4
		// (set) Token: 0x06001570 RID: 5488 RVA: 0x0000867E File Offset: 0x0000687E
		public unsafe Il2CppStructArray<byte> _Value_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonObjectId.NativeFieldInfoPtr__Value_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonObjectId.NativeFieldInfoPtr__Value_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001153 RID: 4435
		private static readonly IntPtr NativeFieldInfoPtr__Value_k__BackingField;

		// Token: 0x04001154 RID: 4436
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001155 RID: 4437
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;
	}
}
