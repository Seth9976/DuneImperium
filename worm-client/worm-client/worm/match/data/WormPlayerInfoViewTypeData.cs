using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.match.data
{
	// Token: 0x02000199 RID: 409
	public class WormPlayerInfoViewTypeData : DataComponent
	{
		// Token: 0x06001240 RID: 4672 RVA: 0x0004F498 File Offset: 0x0004D698
		// Note: this type is marked as 'beforefieldinit'.
		static WormPlayerInfoViewTypeData()
		{
			Il2CppClassPointerStore<WormPlayerInfoViewTypeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormPlayerInfoViewTypeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerInfoViewTypeData>.NativeClassPtr);
			WormPlayerInfoViewTypeData.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInfoViewTypeData>.NativeClassPtr, "<Type>k__BackingField");
			WormPlayerInfoViewTypeData.NativeMethodInfoPtr_get_Type_Public_get_WormPlayerInfoViewType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInfoViewTypeData>.NativeClassPtr, 100665788);
			WormPlayerInfoViewTypeData.NativeMethodInfoPtr__ctor_Public_Void_WormPlayerInfoViewType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInfoViewTypeData>.NativeClassPtr, 100665789);
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06001241 RID: 4673 RVA: 0x0004F504 File Offset: 0x0004D704
		public unsafe WormPlayerInfoViewType Type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerInfoViewTypeData.NativeMethodInfoPtr_get_Type_Public_get_WormPlayerInfoViewType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x0004F540 File Offset: 0x0004D740
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 504768, RefRangeEnd = 504775, XrefRangeStart = 504768, XrefRangeEnd = 504775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayerInfoViewTypeData(WormPlayerInfoViewType type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerInfoViewTypeData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerInfoViewTypeData.NativeMethodInfoPtr__ctor_Public_Void_WormPlayerInfoViewType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x0000B83B File Offset: 0x00009A3B
		public WormPlayerInfoViewTypeData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06001244 RID: 4676 RVA: 0x0004F588 File Offset: 0x0004D788
		// (set) Token: 0x06001245 RID: 4677 RVA: 0x0000B844 File Offset: 0x00009A44
		public unsafe WormPlayerInfoViewType _Type_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoViewTypeData.NativeFieldInfoPtr__Type_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoViewTypeData.NativeFieldInfoPtr__Type_k__BackingField)) = value;
			}
		}

		// Token: 0x04000A8F RID: 2703
		private static readonly IntPtr NativeFieldInfoPtr__Type_k__BackingField;

		// Token: 0x04000A90 RID: 2704
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_WormPlayerInfoViewType_0;

		// Token: 0x04000A91 RID: 2705
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormPlayerInfoViewType_0;
	}
}
