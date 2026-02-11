using System;
using Canis.attributes;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using worm.canis.actions.phases;

namespace worm.match.data
{
	// Token: 0x0200019E RID: 414
	public class WormRoundPhaseData : VersionedDataComponent
	{
		// Token: 0x06001270 RID: 4720 RVA: 0x0004FEBC File Offset: 0x0004E0BC
		// Note: this type is marked as 'beforefieldinit'.
		static WormRoundPhaseData()
		{
			Il2CppClassPointerStore<WormRoundPhaseData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormRoundPhaseData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormRoundPhaseData>.NativeClassPtr);
			WormRoundPhaseData.NativeFieldInfoPtr_roundPhaseAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRoundPhaseData>.NativeClassPtr, "roundPhaseAttribute");
			WormRoundPhaseData.NativeMethodInfoPtr_get_RoundPhase_Public_get_RoundState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRoundPhaseData>.NativeClassPtr, 100665813);
			WormRoundPhaseData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRoundPhaseData>.NativeClassPtr, 100665814);
			WormRoundPhaseData.NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRoundPhaseData>.NativeClassPtr, 100665815);
			WormRoundPhaseData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRoundPhaseData>.NativeClassPtr, 100665816);
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06001271 RID: 4721 RVA: 0x0004FF50 File Offset: 0x0004E150
		public unsafe RoundState RoundPhase
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 712096, RefRangeEnd = 712099, XrefRangeStart = 712090, XrefRangeEnd = 712096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRoundPhaseData.NativeMethodInfoPtr_get_RoundPhase_Public_get_RoundState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06001272 RID: 4722 RVA: 0x0004FF8C File Offset: 0x0004E18C
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712099, XrefRangeEnd = 712103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormRoundPhaseData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x0004FFD4 File Offset: 0x0004E1D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 712113, RefRangeEnd = 712115, XrefRangeStart = 712103, XrefRangeEnd = 712113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormRoundPhaseData(AttributeDataComponent attributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormRoundPhaseData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRoundPhaseData.NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x00050020 File Offset: 0x0004E220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712115, XrefRangeEnd = 712130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormRoundPhaseData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x0000B97B File Offset: 0x00009B7B
		public WormRoundPhaseData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06001276 RID: 4726 RVA: 0x00050064 File Offset: 0x0004E264
		// (set) Token: 0x06001277 RID: 4727 RVA: 0x0000B984 File Offset: 0x00009B84
		public unsafe IAttribute<Nullable<RoundState>> roundPhaseAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRoundPhaseData.NativeFieldInfoPtr_roundPhaseAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<RoundState>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRoundPhaseData.NativeFieldInfoPtr_roundPhaseAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AAC RID: 2732
		private static readonly IntPtr NativeFieldInfoPtr_roundPhaseAttribute;

		// Token: 0x04000AAD RID: 2733
		private static readonly IntPtr NativeMethodInfoPtr_get_RoundPhase_Public_get_RoundState_0;

		// Token: 0x04000AAE RID: 2734
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x04000AAF RID: 2735
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0;

		// Token: 0x04000AB0 RID: 2736
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
