using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.match.data
{
	// Token: 0x02000189 RID: 393
	public class WormDisabledData : VersionedDataComponent
	{
		// Token: 0x060011A5 RID: 4517 RVA: 0x0004D514 File Offset: 0x0004B714
		// Note: this type is marked as 'beforefieldinit'.
		static WormDisabledData()
		{
			Il2CppClassPointerStore<WormDisabledData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormDisabledData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormDisabledData>.NativeClassPtr);
			WormDisabledData.NativeFieldInfoPtr_isDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDisabledData>.NativeClassPtr, "isDisabled");
			WormDisabledData.NativeMethodInfoPtr_get_IsDisabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDisabledData>.NativeClassPtr, 100665728);
			WormDisabledData.NativeMethodInfoPtr_set_IsDisabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDisabledData>.NativeClassPtr, 100665729);
			WormDisabledData.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDisabledData>.NativeClassPtr, 100665730);
			WormDisabledData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDisabledData>.NativeClassPtr, 100665731);
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x060011A6 RID: 4518 RVA: 0x0004D5A8 File Offset: 0x0004B7A8
		// (set) Token: 0x060011A7 RID: 4519 RVA: 0x0004D5E4 File Offset: 0x0004B7E4
		public unsafe bool IsDisabled
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDisabledData.NativeMethodInfoPtr_get_IsDisabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711381, XrefRangeEnd = 711382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDisabledData.NativeMethodInfoPtr_set_IsDisabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x0004D624 File Offset: 0x0004B824
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 711383, RefRangeEnd = 711386, XrefRangeStart = 711382, XrefRangeEnd = 711383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormDisabledData(bool disabled)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormDisabledData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDisabledData.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x0004D66C File Offset: 0x0004B86C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711386, XrefRangeEnd = 711394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormDisabledData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x0000B3C2 File Offset: 0x000095C2
		public WormDisabledData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x060011AB RID: 4523 RVA: 0x0004D6B0 File Offset: 0x0004B8B0
		// (set) Token: 0x060011AC RID: 4524 RVA: 0x0000B3CB File Offset: 0x000095CB
		public unsafe bool isDisabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDisabledData.NativeFieldInfoPtr_isDisabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDisabledData.NativeFieldInfoPtr_isDisabled)) = value;
			}
		}

		// Token: 0x04000A2E RID: 2606
		private static readonly IntPtr NativeFieldInfoPtr_isDisabled;

		// Token: 0x04000A2F RID: 2607
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDisabled_Public_get_Boolean_0;

		// Token: 0x04000A30 RID: 2608
		private static readonly IntPtr NativeMethodInfoPtr_set_IsDisabled_Public_set_Void_Boolean_0;

		// Token: 0x04000A31 RID: 2609
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000A32 RID: 2610
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
