using System;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.match.data
{
	// Token: 0x02000181 RID: 385
	public class WormChosenEntityData : VersionedDataComponent
	{
		// Token: 0x06001168 RID: 4456 RVA: 0x0004C808 File Offset: 0x0004AA08
		// Note: this type is marked as 'beforefieldinit'.
		static WormChosenEntityData()
		{
			Il2CppClassPointerStore<WormChosenEntityData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormChosenEntityData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormChosenEntityData>.NativeClassPtr);
			WormChosenEntityData.NativeFieldInfoPtr_entityAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChosenEntityData>.NativeClassPtr, "entityAttribute");
			WormChosenEntityData.NativeMethodInfoPtr_get_EntityID_Public_get_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChosenEntityData>.NativeClassPtr, 100665703);
			WormChosenEntityData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChosenEntityData>.NativeClassPtr, 100665704);
			WormChosenEntityData.NativeMethodInfoPtr__ctor_Public_Void_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChosenEntityData>.NativeClassPtr, 100665705);
			WormChosenEntityData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChosenEntityData>.NativeClassPtr, 100665706);
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06001169 RID: 4457 RVA: 0x0004C89C File Offset: 0x0004AA9C
		public unsafe EntityID EntityID
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 711122, RefRangeEnd = 711124, XrefRangeStart = 711115, XrefRangeEnd = 711122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChosenEntityData.NativeMethodInfoPtr_get_EntityID_Public_get_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x0600116A RID: 4458 RVA: 0x0004C8DC File Offset: 0x0004AADC
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711124, XrefRangeEnd = 711128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormChosenEntityData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x0004C924 File Offset: 0x0004AB24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 711140, RefRangeEnd = 711141, XrefRangeStart = 711128, XrefRangeEnd = 711140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormChosenEntityData(IHasAttributes attributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormChosenEntityData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChosenEntityData.NativeMethodInfoPtr__ctor_Public_Void_IHasAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x0004C970 File Offset: 0x0004AB70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711141, XrefRangeEnd = 711154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormChosenEntityData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x0000B248 File Offset: 0x00009448
		public WormChosenEntityData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x0600116E RID: 4462 RVA: 0x0004C9B4 File Offset: 0x0004ABB4
		// (set) Token: 0x0600116F RID: 4463 RVA: 0x0000B251 File Offset: 0x00009451
		public unsafe IAttribute<EntityID> entityAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChosenEntityData.NativeFieldInfoPtr_entityAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChosenEntityData.NativeFieldInfoPtr_entityAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A0B RID: 2571
		private static readonly IntPtr NativeFieldInfoPtr_entityAttribute;

		// Token: 0x04000A0C RID: 2572
		private static readonly IntPtr NativeMethodInfoPtr_get_EntityID_Public_get_EntityID_0;

		// Token: 0x04000A0D RID: 2573
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x04000A0E RID: 2574
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IHasAttributes_0;

		// Token: 0x04000A0F RID: 2575
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
