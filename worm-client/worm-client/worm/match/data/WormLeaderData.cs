using System;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.match.data
{
	// Token: 0x02000192 RID: 402
	public class WormLeaderData : VersionedDataComponent
	{
		// Token: 0x060011FA RID: 4602 RVA: 0x0004E620 File Offset: 0x0004C820
		// Note: this type is marked as 'beforefieldinit'.
		static WormLeaderData()
		{
			Il2CppClassPointerStore<WormLeaderData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormLeaderData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormLeaderData>.NativeClassPtr);
			WormLeaderData.NativeFieldInfoPtr_archetypeIDAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderData>.NativeClassPtr, "archetypeIDAttribute");
			WormLeaderData.NativeFieldInfoPtr_staticArchetypeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderData>.NativeClassPtr, "staticArchetypeID");
			WormLeaderData.NativeMethodInfoPtr_get_ArchetypeID_Public_get_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderData>.NativeClassPtr, 100665762);
			WormLeaderData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderData>.NativeClassPtr, 100665763);
			WormLeaderData.NativeMethodInfoPtr__ctor_Public_Void_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderData>.NativeClassPtr, 100665764);
			WormLeaderData.NativeMethodInfoPtr__ctor_Public_Void_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderData>.NativeClassPtr, 100665765);
			WormLeaderData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderData>.NativeClassPtr, 100665766);
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x060011FB RID: 4603 RVA: 0x0004E6DC File Offset: 0x0004C8DC
		public unsafe ArchetypeID ArchetypeID
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 711658, RefRangeEnd = 711661, XrefRangeStart = 711655, XrefRangeEnd = 711658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderData.NativeMethodInfoPtr_get_ArchetypeID_Public_get_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x060011FC RID: 4604 RVA: 0x0004E71C File Offset: 0x0004C91C
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711661, XrefRangeEnd = 711664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormLeaderData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x0004E764 File Offset: 0x0004C964
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 711674, RefRangeEnd = 711677, XrefRangeStart = 711664, XrefRangeEnd = 711674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormLeaderData(IHasAttributes attributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormLeaderData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderData.NativeMethodInfoPtr__ctor_Public_Void_IHasAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x0004E7B0 File Offset: 0x0004C9B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711677, XrefRangeEnd = 711679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormLeaderData(ArchetypeID archetypeID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormLeaderData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(archetypeID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderData.NativeMethodInfoPtr__ctor_Public_Void_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x0004E7FC File Offset: 0x0004C9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711679, XrefRangeEnd = 711687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormLeaderData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x0000B61D File Offset: 0x0000981D
		public WormLeaderData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06001201 RID: 4609 RVA: 0x0004E840 File Offset: 0x0004CA40
		// (set) Token: 0x06001202 RID: 4610 RVA: 0x0000B626 File Offset: 0x00009826
		public unsafe IAttribute<ArchetypeID> archetypeIDAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderData.NativeFieldInfoPtr_archetypeIDAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderData.NativeFieldInfoPtr_archetypeIDAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06001203 RID: 4611 RVA: 0x0004E870 File Offset: 0x0004CA70
		// (set) Token: 0x06001204 RID: 4612 RVA: 0x0000B645 File Offset: 0x00009845
		public unsafe ArchetypeID staticArchetypeID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderData.NativeFieldInfoPtr_staticArchetypeID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderData.NativeFieldInfoPtr_staticArchetypeID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A5F RID: 2655
		private static readonly IntPtr NativeFieldInfoPtr_archetypeIDAttribute;

		// Token: 0x04000A60 RID: 2656
		private static readonly IntPtr NativeFieldInfoPtr_staticArchetypeID;

		// Token: 0x04000A61 RID: 2657
		private static readonly IntPtr NativeMethodInfoPtr_get_ArchetypeID_Public_get_ArchetypeID_0;

		// Token: 0x04000A62 RID: 2658
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x04000A63 RID: 2659
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IHasAttributes_0;

		// Token: 0x04000A64 RID: 2660
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ArchetypeID_0;

		// Token: 0x04000A65 RID: 2661
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
