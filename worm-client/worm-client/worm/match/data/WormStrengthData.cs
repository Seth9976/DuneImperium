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
	// Token: 0x020001A2 RID: 418
	public class WormStrengthData : VersionedDataComponent
	{
		// Token: 0x06001297 RID: 4759 RVA: 0x000507B8 File Offset: 0x0004E9B8
		// Note: this type is marked as 'beforefieldinit'.
		static WormStrengthData()
		{
			Il2CppClassPointerStore<WormStrengthData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormStrengthData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormStrengthData>.NativeClassPtr);
			WormStrengthData.NativeFieldInfoPtr_strengthAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormStrengthData>.NativeClassPtr, "strengthAttribute");
			WormStrengthData.NativeMethodInfoPtr_get_Strength_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStrengthData>.NativeClassPtr, 100665832);
			WormStrengthData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStrengthData>.NativeClassPtr, 100665833);
			WormStrengthData.NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStrengthData>.NativeClassPtr, 100665834);
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06001298 RID: 4760 RVA: 0x00050838 File Offset: 0x0004EA38
		public unsafe int Strength
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 712239, RefRangeEnd = 712242, XrefRangeStart = 712235, XrefRangeEnd = 712239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormStrengthData.NativeMethodInfoPtr_get_Strength_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06001299 RID: 4761 RVA: 0x00050874 File Offset: 0x0004EA74
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712242, XrefRangeEnd = 712246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormStrengthData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x000508BC File Offset: 0x0004EABC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 712253, RefRangeEnd = 712254, XrefRangeStart = 712246, XrefRangeEnd = 712253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormStrengthData(EntityComponent entityComponent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormStrengthData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityComponent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormStrengthData.NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x0000BA55 File Offset: 0x00009C55
		public WormStrengthData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x0600129C RID: 4764 RVA: 0x00050908 File Offset: 0x0004EB08
		// (set) Token: 0x0600129D RID: 4765 RVA: 0x0000BA5E File Offset: 0x00009C5E
		public unsafe IAttribute<Nullable<int>> strengthAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStrengthData.NativeFieldInfoPtr_strengthAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStrengthData.NativeFieldInfoPtr_strengthAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AC5 RID: 2757
		private static readonly IntPtr NativeFieldInfoPtr_strengthAttribute;

		// Token: 0x04000AC6 RID: 2758
		private static readonly IntPtr NativeMethodInfoPtr_get_Strength_Public_get_Int32_0;

		// Token: 0x04000AC7 RID: 2759
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x04000AC8 RID: 2760
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_0;
	}
}
