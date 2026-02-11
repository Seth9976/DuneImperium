using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x020000A3 RID: 163
	public class Slicer : Object
	{
		// Token: 0x06000DC0 RID: 3520 RVA: 0x0003FC58 File Offset: 0x0003DE58
		// Note: this type is marked as 'beforefieldinit'.
		static Slicer()
		{
			Il2CppClassPointerStore<Slicer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "Slicer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Slicer>.NativeClassPtr);
			Slicer.NativeFieldInfoPtr__Position_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Slicer>.NativeClassPtr, "<Position>k__BackingField");
			Slicer.NativeFieldInfoPtr__SlicerId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Slicer>.NativeClassPtr, "<SlicerId>k__BackingField");
			Slicer.NativeFieldInfoPtr__Spec_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Slicer>.NativeClassPtr, "<Spec>k__BackingField");
			Slicer.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Slicer>.NativeClassPtr, "<ETag>k__BackingField");
			Slicer.NativeMethodInfoPtr_get_Position_Public_Virtual_New_get_EmbeddedObjectPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slicer>.NativeClassPtr, 100665199);
			Slicer.NativeMethodInfoPtr_set_Position_Public_Virtual_New_set_Void_EmbeddedObjectPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slicer>.NativeClassPtr, 100665200);
			Slicer.NativeMethodInfoPtr_get_SlicerId_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slicer>.NativeClassPtr, 100665201);
			Slicer.NativeMethodInfoPtr_set_SlicerId_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slicer>.NativeClassPtr, 100665202);
			Slicer.NativeMethodInfoPtr_get_Spec_Public_Virtual_New_get_SlicerSpec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slicer>.NativeClassPtr, 100665203);
			Slicer.NativeMethodInfoPtr_set_Spec_Public_Virtual_New_set_Void_SlicerSpec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slicer>.NativeClassPtr, 100665204);
			Slicer.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slicer>.NativeClassPtr, 100665205);
			Slicer.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slicer>.NativeClassPtr, 100665206);
			Slicer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slicer>.NativeClassPtr, 100665207);
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06000DC1 RID: 3521 RVA: 0x0003FD8C File Offset: 0x0003DF8C
		// (set) Token: 0x06000DC2 RID: 3522 RVA: 0x0003FDD8 File Offset: 0x0003DFD8
		public unsafe virtual EmbeddedObjectPosition Position
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Slicer.NativeMethodInfoPtr_get_Position_Public_Virtual_New_get_EmbeddedObjectPosition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EmbeddedObjectPosition>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Slicer.NativeMethodInfoPtr_set_Position_Public_Virtual_New_set_Void_EmbeddedObjectPosition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06000DC3 RID: 3523 RVA: 0x0003FE28 File Offset: 0x0003E028
		// (set) Token: 0x06000DC4 RID: 3524 RVA: 0x0003FE6C File Offset: 0x0003E06C
		public unsafe virtual Nullable<int> SlicerId
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Slicer.NativeMethodInfoPtr_get_SlicerId_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Slicer.NativeMethodInfoPtr_set_SlicerId_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06000DC5 RID: 3525 RVA: 0x0003FEC0 File Offset: 0x0003E0C0
		// (set) Token: 0x06000DC6 RID: 3526 RVA: 0x0003FF0C File Offset: 0x0003E10C
		public unsafe virtual SlicerSpec Spec
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Slicer.NativeMethodInfoPtr_get_Spec_Public_Virtual_New_get_SlicerSpec_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SlicerSpec>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Slicer.NativeMethodInfoPtr_set_Spec_Public_Virtual_New_set_Void_SlicerSpec_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06000DC7 RID: 3527 RVA: 0x0003FF5C File Offset: 0x0003E15C
		// (set) Token: 0x06000DC8 RID: 3528 RVA: 0x0003FFA0 File Offset: 0x0003E1A0
		public unsafe virtual string ETag
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Slicer.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Slicer.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x0003FFF0 File Offset: 0x0003E1F0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Slicer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Slicer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Slicer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x000089BE File Offset: 0x00006BBE
		public Slicer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06000DCB RID: 3531 RVA: 0x0004002C File Offset: 0x0003E22C
		// (set) Token: 0x06000DCC RID: 3532 RVA: 0x000089C7 File Offset: 0x00006BC7
		public unsafe EmbeddedObjectPosition _Position_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slicer.NativeFieldInfoPtr__Position_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EmbeddedObjectPosition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slicer.NativeFieldInfoPtr__Position_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06000DCD RID: 3533 RVA: 0x0004005C File Offset: 0x0003E25C
		// (set) Token: 0x06000DCE RID: 3534 RVA: 0x000089E6 File Offset: 0x00006BE6
		public Nullable<int> _SlicerId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slicer.NativeFieldInfoPtr__SlicerId_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slicer.NativeFieldInfoPtr__SlicerId_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06000DCF RID: 3535 RVA: 0x0004008C File Offset: 0x0003E28C
		// (set) Token: 0x06000DD0 RID: 3536 RVA: 0x00008A14 File Offset: 0x00006C14
		public unsafe SlicerSpec _Spec_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slicer.NativeFieldInfoPtr__Spec_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SlicerSpec>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slicer.NativeFieldInfoPtr__Spec_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x000400BC File Offset: 0x0003E2BC
		// (set) Token: 0x06000DD2 RID: 3538 RVA: 0x00008A33 File Offset: 0x00006C33
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slicer.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slicer.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000987 RID: 2439
		private static readonly IntPtr NativeFieldInfoPtr__Position_k__BackingField;

		// Token: 0x04000988 RID: 2440
		private static readonly IntPtr NativeFieldInfoPtr__SlicerId_k__BackingField;

		// Token: 0x04000989 RID: 2441
		private static readonly IntPtr NativeFieldInfoPtr__Spec_k__BackingField;

		// Token: 0x0400098A RID: 2442
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x0400098B RID: 2443
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Virtual_New_get_EmbeddedObjectPosition_0;

		// Token: 0x0400098C RID: 2444
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_Virtual_New_set_Void_EmbeddedObjectPosition_0;

		// Token: 0x0400098D RID: 2445
		private static readonly IntPtr NativeMethodInfoPtr_get_SlicerId_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x0400098E RID: 2446
		private static readonly IntPtr NativeMethodInfoPtr_set_SlicerId_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x0400098F RID: 2447
		private static readonly IntPtr NativeMethodInfoPtr_get_Spec_Public_Virtual_New_get_SlicerSpec_0;

		// Token: 0x04000990 RID: 2448
		private static readonly IntPtr NativeMethodInfoPtr_set_Spec_Public_Virtual_New_set_Void_SlicerSpec_0;

		// Token: 0x04000991 RID: 2449
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000992 RID: 2450
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000993 RID: 2451
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
