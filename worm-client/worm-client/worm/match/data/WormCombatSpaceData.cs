using System;
using Canis.attributes;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace worm.match.data
{
	// Token: 0x02000183 RID: 387
	public class WormCombatSpaceData : VersionedDataComponent
	{
		// Token: 0x0600117A RID: 4474 RVA: 0x0004CC6C File Offset: 0x0004AE6C
		// Note: this type is marked as 'beforefieldinit'.
		static WormCombatSpaceData()
		{
			Il2CppClassPointerStore<WormCombatSpaceData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormCombatSpaceData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormCombatSpaceData>.NativeClassPtr);
			WormCombatSpaceData.NativeFieldInfoPtr_combatSpaceAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCombatSpaceData>.NativeClassPtr, "combatSpaceAttribute");
			WormCombatSpaceData.NativeMethodInfoPtr_get_IsCombatSpace_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCombatSpaceData>.NativeClassPtr, 100665713);
			WormCombatSpaceData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCombatSpaceData>.NativeClassPtr, 100665714);
			WormCombatSpaceData.NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCombatSpaceData>.NativeClassPtr, 100665715);
			WormCombatSpaceData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCombatSpaceData>.NativeClassPtr, 100665716);
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x0600117B RID: 4475 RVA: 0x0004CD00 File Offset: 0x0004AF00
		public unsafe bool IsCombatSpace
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 711288, RefRangeEnd = 711289, XrefRangeStart = 711282, XrefRangeEnd = 711288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCombatSpaceData.NativeMethodInfoPtr_get_IsCombatSpace_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x0600117C RID: 4476 RVA: 0x0004CD3C File Offset: 0x0004AF3C
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711289, XrefRangeEnd = 711293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormCombatSpaceData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x0004CD84 File Offset: 0x0004AF84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 711300, RefRangeEnd = 711301, XrefRangeStart = 711293, XrefRangeEnd = 711300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormCombatSpaceData(AttributeDataComponent attributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormCombatSpaceData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCombatSpaceData.NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x0004CDD0 File Offset: 0x0004AFD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711301, XrefRangeEnd = 711315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormCombatSpaceData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x0000B298 File Offset: 0x00009498
		public WormCombatSpaceData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06001180 RID: 4480 RVA: 0x0004CE14 File Offset: 0x0004B014
		// (set) Token: 0x06001181 RID: 4481 RVA: 0x0000B2A1 File Offset: 0x000094A1
		public unsafe IAttribute<Nullable<bool>> combatSpaceAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCombatSpaceData.NativeFieldInfoPtr_combatSpaceAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCombatSpaceData.NativeFieldInfoPtr_combatSpaceAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A17 RID: 2583
		private static readonly IntPtr NativeFieldInfoPtr_combatSpaceAttribute;

		// Token: 0x04000A18 RID: 2584
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCombatSpace_Public_get_Boolean_0;

		// Token: 0x04000A19 RID: 2585
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x04000A1A RID: 2586
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0;

		// Token: 0x04000A1B RID: 2587
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
