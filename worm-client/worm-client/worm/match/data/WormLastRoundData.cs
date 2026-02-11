using System;
using Canis.attributes;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace worm.match.data
{
	// Token: 0x02000191 RID: 401
	public class WormLastRoundData : VersionedDataComponent
	{
		// Token: 0x060011F3 RID: 4595 RVA: 0x0004E48C File Offset: 0x0004C68C
		// Note: this type is marked as 'beforefieldinit'.
		static WormLastRoundData()
		{
			Il2CppClassPointerStore<WormLastRoundData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormLastRoundData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormLastRoundData>.NativeClassPtr);
			WormLastRoundData.NativeFieldInfoPtr_endgameAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLastRoundData>.NativeClassPtr, "endgameAttribute");
			WormLastRoundData.NativeMethodInfoPtr__ctor_Public_Void_IHasAttributes_IEnumerable_1_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLastRoundData>.NativeClassPtr, 100665759);
			WormLastRoundData.NativeMethodInfoPtr_get_LastRound_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLastRoundData>.NativeClassPtr, 100665760);
			WormLastRoundData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLastRoundData>.NativeClassPtr, 100665761);
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x0004E50C File Offset: 0x0004C70C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711634, XrefRangeEnd = 711644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormLastRoundData(IHasAttributes playmat, IEnumerable<IHasAttributes> players)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormLastRoundData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(playmat);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(players);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLastRoundData.NativeMethodInfoPtr__ctor_Public_Void_IHasAttributes_IEnumerable_1_IHasAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x060011F5 RID: 4597 RVA: 0x0004E56C File Offset: 0x0004C76C
		public unsafe bool LastRound
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 711650, RefRangeEnd = 711651, XrefRangeStart = 711644, XrefRangeEnd = 711650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLastRoundData.NativeMethodInfoPtr_get_LastRound_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x060011F6 RID: 4598 RVA: 0x0004E5A8 File Offset: 0x0004C7A8
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711651, XrefRangeEnd = 711655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormLastRoundData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x0000B5F5 File Offset: 0x000097F5
		public WormLastRoundData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x060011F8 RID: 4600 RVA: 0x0004E5F0 File Offset: 0x0004C7F0
		// (set) Token: 0x060011F9 RID: 4601 RVA: 0x0000B5FE File Offset: 0x000097FE
		public unsafe IAttribute<Nullable<bool>> endgameAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLastRoundData.NativeFieldInfoPtr_endgameAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLastRoundData.NativeFieldInfoPtr_endgameAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A5B RID: 2651
		private static readonly IntPtr NativeFieldInfoPtr_endgameAttribute;

		// Token: 0x04000A5C RID: 2652
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IHasAttributes_IEnumerable_1_IHasAttributes_0;

		// Token: 0x04000A5D RID: 2653
		private static readonly IntPtr NativeMethodInfoPtr_get_LastRound_Public_get_Boolean_0;

		// Token: 0x04000A5E RID: 2654
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;
	}
}
