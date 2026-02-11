using System;
using Canis.attributes;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace worm.match.data
{
	// Token: 0x02000194 RID: 404
	public class WormMentatControllerData : DataComponent
	{
		// Token: 0x0600121F RID: 4639 RVA: 0x0004ED3C File Offset: 0x0004CF3C
		// Note: this type is marked as 'beforefieldinit'.
		static WormMentatControllerData()
		{
			Il2CppClassPointerStore<WormMentatControllerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormMentatControllerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormMentatControllerData>.NativeClassPtr);
			WormMentatControllerData.NativeFieldInfoPtr_mentatControllerAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMentatControllerData>.NativeClassPtr, "mentatControllerAttribute");
			WormMentatControllerData.NativeMethodInfoPtr__ctor_Public_Void_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMentatControllerData>.NativeClassPtr, 100665773);
			WormMentatControllerData.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMentatControllerData>.NativeClassPtr, 100665774);
			WormMentatControllerData.NativeMethodInfoPtr_get_MentatControllerThisRound_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMentatControllerData>.NativeClassPtr, 100665775);
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x0004EDBC File Offset: 0x0004CFBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 711743, RefRangeEnd = 711744, XrefRangeStart = 711733, XrefRangeEnd = 711743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormMentatControllerData(IHasAttributes attributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormMentatControllerData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMentatControllerData.NativeMethodInfoPtr__ctor_Public_Void_IHasAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06001221 RID: 4641 RVA: 0x0004EE08 File Offset: 0x0004D008
		public unsafe virtual ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711744, XrefRangeEnd = 711748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMentatControllerData.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06001222 RID: 4642 RVA: 0x0004EE44 File Offset: 0x0004D044
		public unsafe bool MentatControllerThisRound
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 711752, RefRangeEnd = 711753, XrefRangeStart = 711748, XrefRangeEnd = 711752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMentatControllerData.NativeMethodInfoPtr_get_MentatControllerThisRound_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x0000B77C File Offset: 0x0000997C
		public WormMentatControllerData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06001224 RID: 4644 RVA: 0x0004EE80 File Offset: 0x0004D080
		// (set) Token: 0x06001225 RID: 4645 RVA: 0x0000B785 File Offset: 0x00009985
		public unsafe IAttribute<Nullable<bool>> mentatControllerAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMentatControllerData.NativeFieldInfoPtr_mentatControllerAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMentatControllerData.NativeFieldInfoPtr_mentatControllerAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A75 RID: 2677
		private static readonly IntPtr NativeFieldInfoPtr_mentatControllerAttribute;

		// Token: 0x04000A76 RID: 2678
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IHasAttributes_0;

		// Token: 0x04000A77 RID: 2679
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x04000A78 RID: 2680
		private static readonly IntPtr NativeMethodInfoPtr_get_MentatControllerThisRound_Public_get_Boolean_0;
	}
}
