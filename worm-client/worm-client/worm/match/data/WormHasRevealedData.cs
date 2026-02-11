using System;
using Canis.attributes;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace worm.match.data
{
	// Token: 0x0200018E RID: 398
	public class WormHasRevealedData : VersionedDataComponent
	{
		// Token: 0x060011DB RID: 4571 RVA: 0x0004DF80 File Offset: 0x0004C180
		// Note: this type is marked as 'beforefieldinit'.
		static WormHasRevealedData()
		{
			Il2CppClassPointerStore<WormHasRevealedData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormHasRevealedData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormHasRevealedData>.NativeClassPtr);
			WormHasRevealedData.NativeFieldInfoPtr_hasRevealedAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHasRevealedData>.NativeClassPtr, "hasRevealedAttribute");
			WormHasRevealedData.NativeFieldInfoPtr_isHagalAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHasRevealedData>.NativeClassPtr, "isHagalAttribute");
			WormHasRevealedData.NativeMethodInfoPtr_get_HasRevealed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHasRevealedData>.NativeClassPtr, 100665749);
			WormHasRevealedData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHasRevealedData>.NativeClassPtr, 100665750);
			WormHasRevealedData.NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHasRevealedData>.NativeClassPtr, 100665751);
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x060011DC RID: 4572 RVA: 0x0004E014 File Offset: 0x0004C214
		public unsafe bool HasRevealed
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 711573, RefRangeEnd = 711574, XrefRangeStart = 711569, XrefRangeEnd = 711573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHasRevealedData.NativeMethodInfoPtr_get_HasRevealed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x060011DD RID: 4573 RVA: 0x0004E050 File Offset: 0x0004C250
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711574, XrefRangeEnd = 711579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormHasRevealedData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x0004E098 File Offset: 0x0004C298
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 711588, RefRangeEnd = 711589, XrefRangeStart = 711579, XrefRangeEnd = 711588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormHasRevealedData(AttributeDataComponent entityComponent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormHasRevealedData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityComponent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHasRevealedData.NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x0000B562 File Offset: 0x00009762
		public WormHasRevealedData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x060011E0 RID: 4576 RVA: 0x0004E0E4 File Offset: 0x0004C2E4
		// (set) Token: 0x060011E1 RID: 4577 RVA: 0x0000B56B File Offset: 0x0000976B
		public unsafe IAttribute<Nullable<bool>> hasRevealedAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHasRevealedData.NativeFieldInfoPtr_hasRevealedAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHasRevealedData.NativeFieldInfoPtr_hasRevealedAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x060011E2 RID: 4578 RVA: 0x0004E114 File Offset: 0x0004C314
		// (set) Token: 0x060011E3 RID: 4579 RVA: 0x0000B58A File Offset: 0x0000978A
		public unsafe IAttribute<Nullable<bool>> isHagalAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHasRevealedData.NativeFieldInfoPtr_isHagalAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHasRevealedData.NativeFieldInfoPtr_isHagalAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A4D RID: 2637
		private static readonly IntPtr NativeFieldInfoPtr_hasRevealedAttribute;

		// Token: 0x04000A4E RID: 2638
		private static readonly IntPtr NativeFieldInfoPtr_isHagalAttribute;

		// Token: 0x04000A4F RID: 2639
		private static readonly IntPtr NativeMethodInfoPtr_get_HasRevealed_Public_get_Boolean_0;

		// Token: 0x04000A50 RID: 2640
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x04000A51 RID: 2641
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0;
	}
}
