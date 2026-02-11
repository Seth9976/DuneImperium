using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200035E RID: 862
	public sealed class ObjectNull : Object
	{
		// Token: 0x06003394 RID: 13204 RVA: 0x00102A84 File Offset: 0x00100C84
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectNull()
		{
			Il2CppClassPointerStore<ObjectNull>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "ObjectNull");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectNull>.NativeClassPtr);
			ObjectNull.NativeFieldInfoPtr_nullCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectNull>.NativeClassPtr, "nullCount");
			ObjectNull.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNull>.NativeClassPtr, 100671298);
			ObjectNull.NativeMethodInfoPtr_SetNullCount_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNull>.NativeClassPtr, 100671299);
			ObjectNull.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNull>.NativeClassPtr, 100671300);
			ObjectNull.NativeMethodInfoPtr_Read_Public_Void___BinaryParser_BinaryHeaderEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNull>.NativeClassPtr, 100671301);
			ObjectNull.NativeMethodInfoPtr_Dump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNull>.NativeClassPtr, 100671302);
		}

		// Token: 0x06003395 RID: 13205 RVA: 0x00102B2C File Offset: 0x00100D2C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectNull()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectNull>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectNull.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003396 RID: 13206 RVA: 0x00102B68 File Offset: 0x00100D68
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNullCount(int nullCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nullCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectNull.NativeMethodInfoPtr_SetNullCount_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003397 RID: 13207 RVA: 0x00102BA8 File Offset: 0x00100DA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1387393, RefRangeEnd = 1387395, XrefRangeStart = 1387392, XrefRangeEnd = 1387393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(__BinaryWriter sout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sout);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectNull.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003398 RID: 13208 RVA: 0x00102BEC File Offset: 0x00100DEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1387396, RefRangeEnd = 1387397, XrefRangeStart = 1387395, XrefRangeEnd = 1387396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Read(__BinaryParser input, BinaryHeaderEnum binaryHeaderEnum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref binaryHeaderEnum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectNull.NativeMethodInfoPtr_Read_Public_Void___BinaryParser_BinaryHeaderEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003399 RID: 13209 RVA: 0x00102C3C File Offset: 0x00100E3C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectNull.NativeMethodInfoPtr_Dump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600339A RID: 13210 RVA: 0x000120C7 File Offset: 0x000102C7
		public ObjectNull(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x0600339B RID: 13211 RVA: 0x00102C70 File Offset: 0x00100E70
		// (set) Token: 0x0600339C RID: 13212 RVA: 0x000120D0 File Offset: 0x000102D0
		public unsafe int nullCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectNull.NativeFieldInfoPtr_nullCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectNull.NativeFieldInfoPtr_nullCount)) = value;
			}
		}

		// Token: 0x04002A8B RID: 10891
		private static readonly IntPtr NativeFieldInfoPtr_nullCount;

		// Token: 0x04002A8C RID: 10892
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002A8D RID: 10893
		private static readonly IntPtr NativeMethodInfoPtr_SetNullCount_Internal_Void_Int32_0;

		// Token: 0x04002A8E RID: 10894
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0;

		// Token: 0x04002A8F RID: 10895
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void___BinaryParser_BinaryHeaderEnum_0;

		// Token: 0x04002A90 RID: 10896
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Public_Void_0;
	}
}
