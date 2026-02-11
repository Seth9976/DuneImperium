using System;
using Canis.attributes;
using dwd.core.data.composition;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace worm.match.data
{
	// Token: 0x0200017D RID: 381
	public class WormBonusSpiceData : VersionedDataComponent
	{
		// Token: 0x0600111E RID: 4382 RVA: 0x0004B8FC File Offset: 0x00049AFC
		// Note: this type is marked as 'beforefieldinit'.
		static WormBonusSpiceData()
		{
			Il2CppClassPointerStore<WormBonusSpiceData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormBonusSpiceData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormBonusSpiceData>.NativeClassPtr);
			WormBonusSpiceData.NativeFieldInfoPtr_bonusSpiceAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBonusSpiceData>.NativeClassPtr, "bonusSpiceAttribute");
			WormBonusSpiceData.NativeMethodInfoPtr_get_BonusSpice_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBonusSpiceData>.NativeClassPtr, 100665672);
			WormBonusSpiceData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBonusSpiceData>.NativeClassPtr, 100665673);
			WormBonusSpiceData.NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBonusSpiceData>.NativeClassPtr, 100665674);
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x0600111F RID: 4383 RVA: 0x0004B97C File Offset: 0x00049B7C
		public unsafe int BonusSpice
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 710870, RefRangeEnd = 710876, XrefRangeStart = 710866, XrefRangeEnd = 710870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBonusSpiceData.NativeMethodInfoPtr_get_BonusSpice_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06001120 RID: 4384 RVA: 0x0004B9B8 File Offset: 0x00049BB8
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710876, XrefRangeEnd = 710880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormBonusSpiceData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x0004BA00 File Offset: 0x00049C00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 710887, RefRangeEnd = 710888, XrefRangeStart = 710880, XrefRangeEnd = 710887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormBonusSpiceData(EntityComponent entityComponent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormBonusSpiceData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityComponent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBonusSpiceData.NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x0000AFBC File Offset: 0x000091BC
		public WormBonusSpiceData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06001123 RID: 4387 RVA: 0x0004BA4C File Offset: 0x00049C4C
		// (set) Token: 0x06001124 RID: 4388 RVA: 0x0000AFC5 File Offset: 0x000091C5
		public unsafe IAttribute<Nullable<int>> bonusSpiceAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBonusSpiceData.NativeFieldInfoPtr_bonusSpiceAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBonusSpiceData.NativeFieldInfoPtr_bonusSpiceAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009DD RID: 2525
		private static readonly IntPtr NativeFieldInfoPtr_bonusSpiceAttribute;

		// Token: 0x040009DE RID: 2526
		private static readonly IntPtr NativeMethodInfoPtr_get_BonusSpice_Public_get_Int32_0;

		// Token: 0x040009DF RID: 2527
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x040009E0 RID: 2528
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_0;
	}
}
