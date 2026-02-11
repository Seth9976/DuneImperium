using System;
using Canis.attributes;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using worm.canis.data.enums;

namespace worm.match.data
{
	// Token: 0x02000182 RID: 386
	public class WormColorData : VersionedDataComponent
	{
		// Token: 0x06001170 RID: 4464 RVA: 0x0004C9E4 File Offset: 0x0004ABE4
		// Note: this type is marked as 'beforefieldinit'.
		static WormColorData()
		{
			Il2CppClassPointerStore<WormColorData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormColorData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormColorData>.NativeClassPtr);
			WormColorData.NativeFieldInfoPtr_colorAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormColorData>.NativeClassPtr, "colorAttribute");
			WormColorData.NativeMethodInfoPtr_get_Color_Public_get_PieceColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormColorData>.NativeClassPtr, 100665707);
			WormColorData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormColorData>.NativeClassPtr, 100665708);
			WormColorData.NativeMethodInfoPtr__ctor_Public_Void_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormColorData>.NativeClassPtr, 100665709);
			WormColorData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormColorData>.NativeClassPtr, 100665710);
			WormColorData.NativeMethodInfoPtr_Set_Public_Boolean_PieceColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormColorData>.NativeClassPtr, 100665711);
			WormColorData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormColorData>.NativeClassPtr, 100665712);
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06001171 RID: 4465 RVA: 0x0004CAA0 File Offset: 0x0004ACA0
		public unsafe PieceColor Color
		{
			[CallerCount(45)]
			[CachedScanResults(RefRangeStart = 711160, RefRangeEnd = 711205, XrefRangeStart = 711154, XrefRangeEnd = 711160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormColorData.NativeMethodInfoPtr_get_Color_Public_get_PieceColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06001172 RID: 4466 RVA: 0x0004CADC File Offset: 0x0004ACDC
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711205, XrefRangeEnd = 711209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormColorData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x0004CB24 File Offset: 0x0004AD24
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 711221, RefRangeEnd = 711232, XrefRangeStart = 711209, XrefRangeEnd = 711221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormColorData(IHasAttributes attributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormColorData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormColorData.NativeMethodInfoPtr__ctor_Public_Void_IHasAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x0004CB70 File Offset: 0x0004AD70
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 711242, RefRangeEnd = 711245, XrefRangeStart = 711232, XrefRangeEnd = 711242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormColorData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormColorData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormColorData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x0004CBAC File Offset: 0x0004ADAC
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 711260, RefRangeEnd = 711273, XrefRangeStart = 711245, XrefRangeEnd = 711260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Set(PieceColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormColorData.NativeMethodInfoPtr_Set_Public_Boolean_PieceColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x0004CBF8 File Offset: 0x0004ADF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711273, XrefRangeEnd = 711282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormColorData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x0000B270 File Offset: 0x00009470
		public WormColorData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06001178 RID: 4472 RVA: 0x0004CC3C File Offset: 0x0004AE3C
		// (set) Token: 0x06001179 RID: 4473 RVA: 0x0000B279 File Offset: 0x00009479
		public unsafe IAttribute<Nullable<PieceColor>> colorAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormColorData.NativeFieldInfoPtr_colorAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<PieceColor>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormColorData.NativeFieldInfoPtr_colorAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A10 RID: 2576
		private static readonly IntPtr NativeFieldInfoPtr_colorAttribute;

		// Token: 0x04000A11 RID: 2577
		private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_get_PieceColor_0;

		// Token: 0x04000A12 RID: 2578
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x04000A13 RID: 2579
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IHasAttributes_0;

		// Token: 0x04000A14 RID: 2580
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000A15 RID: 2581
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Boolean_PieceColor_0;

		// Token: 0x04000A16 RID: 2582
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
