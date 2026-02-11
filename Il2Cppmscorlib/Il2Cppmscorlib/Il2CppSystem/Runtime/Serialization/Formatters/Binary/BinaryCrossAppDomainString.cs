using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000356 RID: 854
	public sealed class BinaryCrossAppDomainString : Object
	{
		// Token: 0x0600331E RID: 13086 RVA: 0x0010138C File Offset: 0x000FF58C
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryCrossAppDomainString()
		{
			Il2CppClassPointerStore<BinaryCrossAppDomainString>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryCrossAppDomainString");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryCrossAppDomainString>.NativeClassPtr);
			BinaryCrossAppDomainString.NativeFieldInfoPtr_objectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryCrossAppDomainString>.NativeClassPtr, "objectId");
			BinaryCrossAppDomainString.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryCrossAppDomainString>.NativeClassPtr, "value");
			BinaryCrossAppDomainString.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryCrossAppDomainString>.NativeClassPtr, 100671260);
			BinaryCrossAppDomainString.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryCrossAppDomainString>.NativeClassPtr, 100671261);
			BinaryCrossAppDomainString.NativeMethodInfoPtr_Dump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryCrossAppDomainString>.NativeClassPtr, 100671262);
		}

		// Token: 0x0600331F RID: 13087 RVA: 0x00101420 File Offset: 0x000FF620
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryCrossAppDomainString()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryCrossAppDomainString>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryCrossAppDomainString.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003320 RID: 13088 RVA: 0x0010145C File Offset: 0x000FF65C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1387217, RefRangeEnd = 1387220, XrefRangeStart = 1387217, XrefRangeEnd = 1387220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Read(__BinaryParser input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryCrossAppDomainString.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003321 RID: 13089 RVA: 0x001014A0 File Offset: 0x000FF6A0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryCrossAppDomainString.NativeMethodInfoPtr_Dump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003322 RID: 13090 RVA: 0x00011CEF File Offset: 0x0000FEEF
		public BinaryCrossAppDomainString(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x06003323 RID: 13091 RVA: 0x001014D4 File Offset: 0x000FF6D4
		// (set) Token: 0x06003324 RID: 13092 RVA: 0x00011CF8 File Offset: 0x0000FEF8
		public unsafe int objectId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryCrossAppDomainString.NativeFieldInfoPtr_objectId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryCrossAppDomainString.NativeFieldInfoPtr_objectId)) = value;
			}
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x06003325 RID: 13093 RVA: 0x001014FC File Offset: 0x000FF6FC
		// (set) Token: 0x06003326 RID: 13094 RVA: 0x00011D13 File Offset: 0x0000FF13
		public unsafe int value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryCrossAppDomainString.NativeFieldInfoPtr_value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryCrossAppDomainString.NativeFieldInfoPtr_value)) = value;
			}
		}

		// Token: 0x04002A45 RID: 10821
		private static readonly IntPtr NativeFieldInfoPtr_objectId;

		// Token: 0x04002A46 RID: 10822
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04002A47 RID: 10823
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002A48 RID: 10824
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0;

		// Token: 0x04002A49 RID: 10825
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Public_Void_0;
	}
}
