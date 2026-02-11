using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.direBytes.data
{
	// Token: 0x02000025 RID: 37
	public class DireByteTypeData : DataComponent
	{
		// Token: 0x060001B0 RID: 432 RVA: 0x0000832C File Offset: 0x0000652C
		// Note: this type is marked as 'beforefieldinit'.
		static DireByteTypeData()
		{
			Il2CppClassPointerStore<DireByteTypeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("direbytes.dll", "dwd.core.direBytes.data", "DireByteTypeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DireByteTypeData>.NativeClassPtr);
			DireByteTypeData.NativeFieldInfoPtr__DireByteType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTypeData>.NativeClassPtr, "<DireByteType>k__BackingField");
			DireByteTypeData.NativeMethodInfoPtr_get_DireByteType_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteTypeData>.NativeClassPtr, 100663459);
			DireByteTypeData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteTypeData>.NativeClassPtr, 100663460);
			DireByteTypeData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteTypeData>.NativeClassPtr, 100663461);
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x000083AC File Offset: 0x000065AC
		public unsafe string DireByteType
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireByteTypeData.NativeMethodInfoPtr_get_DireByteType_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x000083E4 File Offset: 0x000065E4
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 495240, RefRangeEnd = 495283, XrefRangeStart = 495240, XrefRangeEnd = 495283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DireByteTypeData(string type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DireByteTypeData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireByteTypeData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00008430 File Offset: 0x00006630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235178, XrefRangeEnd = 1235184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DireByteTypeData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00002F15 File Offset: 0x00001115
		public DireByteTypeData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x00008474 File Offset: 0x00006674
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x00002F1E File Offset: 0x0000111E
		public unsafe string _DireByteType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTypeData.NativeFieldInfoPtr__DireByteType_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTypeData.NativeFieldInfoPtr__DireByteType_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeFieldInfoPtr__DireByteType_k__BackingField;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr_get_DireByteType_Public_get_String_0;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
