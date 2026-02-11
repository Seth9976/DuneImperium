using System;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.match.data
{
	// Token: 0x02000197 RID: 407
	public class WormPlayedSpaceData : VersionedDataComponent
	{
		// Token: 0x06001238 RID: 4664 RVA: 0x0004F2BC File Offset: 0x0004D4BC
		// Note: this type is marked as 'beforefieldinit'.
		static WormPlayedSpaceData()
		{
			Il2CppClassPointerStore<WormPlayedSpaceData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormPlayedSpaceData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayedSpaceData>.NativeClassPtr);
			WormPlayedSpaceData.NativeFieldInfoPtr_playedSpaceAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayedSpaceData>.NativeClassPtr, "playedSpaceAttribute");
			WormPlayedSpaceData.NativeMethodInfoPtr_get_PlayedSpaceID_Public_get_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayedSpaceData>.NativeClassPtr, 100665784);
			WormPlayedSpaceData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayedSpaceData>.NativeClassPtr, 100665785);
			WormPlayedSpaceData.NativeMethodInfoPtr__ctor_Public_Void_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayedSpaceData>.NativeClassPtr, 100665786);
			WormPlayedSpaceData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayedSpaceData>.NativeClassPtr, 100665787);
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06001239 RID: 4665 RVA: 0x0004F350 File Offset: 0x0004D550
		public unsafe ArchetypeID PlayedSpaceID
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 711805, RefRangeEnd = 711807, XrefRangeStart = 711798, XrefRangeEnd = 711805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayedSpaceData.NativeMethodInfoPtr_get_PlayedSpaceID_Public_get_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x0600123A RID: 4666 RVA: 0x0004F390 File Offset: 0x0004D590
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711807, XrefRangeEnd = 711811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPlayedSpaceData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x0004F3D8 File Offset: 0x0004D5D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 711821, RefRangeEnd = 711825, XrefRangeStart = 711811, XrefRangeEnd = 711821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayedSpaceData(IHasAttributes attributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayedSpaceData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayedSpaceData.NativeMethodInfoPtr__ctor_Public_Void_IHasAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x0004F424 File Offset: 0x0004D624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711825, XrefRangeEnd = 711838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPlayedSpaceData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x0000B813 File Offset: 0x00009A13
		public WormPlayedSpaceData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x0600123E RID: 4670 RVA: 0x0004F468 File Offset: 0x0004D668
		// (set) Token: 0x0600123F RID: 4671 RVA: 0x0000B81C File Offset: 0x00009A1C
		public unsafe IAttribute<ArchetypeID> playedSpaceAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayedSpaceData.NativeFieldInfoPtr_playedSpaceAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayedSpaceData.NativeFieldInfoPtr_playedSpaceAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A84 RID: 2692
		private static readonly IntPtr NativeFieldInfoPtr_playedSpaceAttribute;

		// Token: 0x04000A85 RID: 2693
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayedSpaceID_Public_get_ArchetypeID_0;

		// Token: 0x04000A86 RID: 2694
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x04000A87 RID: 2695
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IHasAttributes_0;

		// Token: 0x04000A88 RID: 2696
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
