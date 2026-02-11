using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.match.data
{
	// Token: 0x02000190 RID: 400
	public class WormInfluenceDeltaData : DataComponent
	{
		// Token: 0x060011EC RID: 4588 RVA: 0x0004E31C File Offset: 0x0004C51C
		// Note: this type is marked as 'beforefieldinit'.
		static WormInfluenceDeltaData()
		{
			Il2CppClassPointerStore<WormInfluenceDeltaData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormInfluenceDeltaData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormInfluenceDeltaData>.NativeClassPtr);
			WormInfluenceDeltaData.NativeFieldInfoPtr__InfluenceDelta_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormInfluenceDeltaData>.NativeClassPtr, "<InfluenceDelta>k__BackingField");
			WormInfluenceDeltaData.NativeMethodInfoPtr_get_InfluenceDelta_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormInfluenceDeltaData>.NativeClassPtr, 100665756);
			WormInfluenceDeltaData.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormInfluenceDeltaData>.NativeClassPtr, 100665757);
			WormInfluenceDeltaData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormInfluenceDeltaData>.NativeClassPtr, 100665758);
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x060011ED RID: 4589 RVA: 0x0004E39C File Offset: 0x0004C59C
		public unsafe int InfluenceDelta
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormInfluenceDeltaData.NativeMethodInfoPtr_get_InfluenceDelta_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x0004E3D8 File Offset: 0x0004C5D8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 504768, RefRangeEnd = 504775, XrefRangeStart = 504768, XrefRangeEnd = 504775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormInfluenceDeltaData(int delta)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormInfluenceDeltaData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delta;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormInfluenceDeltaData.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x0004E420 File Offset: 0x0004C620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711626, XrefRangeEnd = 711634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormInfluenceDeltaData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x0000B5D1 File Offset: 0x000097D1
		public WormInfluenceDeltaData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x060011F1 RID: 4593 RVA: 0x0004E464 File Offset: 0x0004C664
		// (set) Token: 0x060011F2 RID: 4594 RVA: 0x0000B5DA File Offset: 0x000097DA
		public unsafe int _InfluenceDelta_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormInfluenceDeltaData.NativeFieldInfoPtr__InfluenceDelta_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormInfluenceDeltaData.NativeFieldInfoPtr__InfluenceDelta_k__BackingField)) = value;
			}
		}

		// Token: 0x04000A57 RID: 2647
		private static readonly IntPtr NativeFieldInfoPtr__InfluenceDelta_k__BackingField;

		// Token: 0x04000A58 RID: 2648
		private static readonly IntPtr NativeMethodInfoPtr_get_InfluenceDelta_Public_get_Int32_0;

		// Token: 0x04000A59 RID: 2649
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000A5A RID: 2650
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
