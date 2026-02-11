using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x0200010C RID: 268
	public class BsonBinary : BsonValue
	{
		// Token: 0x060015F4 RID: 5620 RVA: 0x00076768 File Offset: 0x00074968
		// Note: this type is marked as 'beforefieldinit'.
		static BsonBinary()
		{
			Il2CppClassPointerStore<BsonBinary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Bson", "BsonBinary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BsonBinary>.NativeClassPtr);
			BsonBinary.NativeFieldInfoPtr__BinaryType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonBinary>.NativeClassPtr, "<BinaryType>k__BackingField");
			BsonBinary.NativeMethodInfoPtr_get_BinaryType_Public_get_BsonBinaryType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonBinary>.NativeClassPtr, 100667420);
			BsonBinary.NativeMethodInfoPtr_set_BinaryType_Public_set_Void_BsonBinaryType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonBinary>.NativeClassPtr, 100667421);
			BsonBinary.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_BsonBinaryType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonBinary>.NativeClassPtr, 100667422);
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x060015F5 RID: 5621 RVA: 0x000767E8 File Offset: 0x000749E8
		// (set) Token: 0x060015F6 RID: 5622 RVA: 0x00076824 File Offset: 0x00074A24
		public unsafe BsonBinaryType BinaryType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonBinary.NativeMethodInfoPtr_get_BinaryType_Public_get_BsonBinaryType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonBinary.NativeMethodInfoPtr_set_BinaryType_Public_set_Void_BsonBinaryType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x00076864 File Offset: 0x00074A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767133, XrefRangeEnd = 767135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BsonBinary(Il2CppStructArray<byte> value, BsonBinaryType binaryType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BsonBinary>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref binaryType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonBinary.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_BsonBinaryType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x000089A8 File Offset: 0x00006BA8
		public BsonBinary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x060015F9 RID: 5625 RVA: 0x000768C0 File Offset: 0x00074AC0
		// (set) Token: 0x060015FA RID: 5626 RVA: 0x000089B1 File Offset: 0x00006BB1
		public unsafe BsonBinaryType _BinaryType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonBinary.NativeFieldInfoPtr__BinaryType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonBinary.NativeFieldInfoPtr__BinaryType_k__BackingField)) = value;
			}
		}

		// Token: 0x040011AD RID: 4525
		private static readonly IntPtr NativeFieldInfoPtr__BinaryType_k__BackingField;

		// Token: 0x040011AE RID: 4526
		private static readonly IntPtr NativeMethodInfoPtr_get_BinaryType_Public_get_BsonBinaryType_0;

		// Token: 0x040011AF RID: 4527
		private static readonly IntPtr NativeMethodInfoPtr_set_BinaryType_Public_set_Void_BsonBinaryType_0;

		// Token: 0x040011B0 RID: 4528
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_BsonBinaryType_0;
	}
}
