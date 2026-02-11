using System;
using Canis.attributes;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace worm.match.data
{
	// Token: 0x02000188 RID: 392
	public class WormCostData : VersionedDataComponent
	{
		// Token: 0x0600119D RID: 4509 RVA: 0x0004D328 File Offset: 0x0004B528
		// Note: this type is marked as 'beforefieldinit'.
		static WormCostData()
		{
			Il2CppClassPointerStore<WormCostData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormCostData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormCostData>.NativeClassPtr);
			WormCostData.NativeFieldInfoPtr_costAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCostData>.NativeClassPtr, "costAttribute");
			WormCostData.NativeMethodInfoPtr_get_Cost_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCostData>.NativeClassPtr, 100665724);
			WormCostData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCostData>.NativeClassPtr, 100665725);
			WormCostData.NativeMethodInfoPtr_get_Definition_Public_Abstract_Virtual_New_get_AttributeDefinition_1_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCostData>.NativeClassPtr, 100665726);
			WormCostData.NativeMethodInfoPtr__ctor_Protected_Void_AttributeDataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCostData>.NativeClassPtr, 100665727);
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x0600119E RID: 4510 RVA: 0x0004D3BC File Offset: 0x0004B5BC
		public unsafe virtual int Cost
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711365, XrefRangeEnd = 711371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormCostData.NativeMethodInfoPtr_get_Cost_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x0600119F RID: 4511 RVA: 0x0004D404 File Offset: 0x0004B604
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711371, XrefRangeEnd = 711374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormCostData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x060011A0 RID: 4512 RVA: 0x0004D44C File Offset: 0x0004B64C
		public unsafe virtual AttributeDefinition<Nullable<int>> Definition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormCostData.NativeMethodInfoPtr_get_Definition_Public_Abstract_Virtual_New_get_AttributeDefinition_1_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr3) : null;
			}
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x0004D498 File Offset: 0x0004B698
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 711377, RefRangeEnd = 711381, XrefRangeStart = 711374, XrefRangeEnd = 711377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormCostData(AttributeDataComponent attributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormCostData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCostData.NativeMethodInfoPtr__ctor_Protected_Void_AttributeDataComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x0000B39A File Offset: 0x0000959A
		public WormCostData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x060011A3 RID: 4515 RVA: 0x0004D4E4 File Offset: 0x0004B6E4
		// (set) Token: 0x060011A4 RID: 4516 RVA: 0x0000B3A3 File Offset: 0x000095A3
		public unsafe IAttribute<Nullable<int>> costAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCostData.NativeFieldInfoPtr_costAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCostData.NativeFieldInfoPtr_costAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A29 RID: 2601
		private static readonly IntPtr NativeFieldInfoPtr_costAttribute;

		// Token: 0x04000A2A RID: 2602
		private static readonly IntPtr NativeMethodInfoPtr_get_Cost_Public_Virtual_New_get_Int32_0;

		// Token: 0x04000A2B RID: 2603
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x04000A2C RID: 2604
		private static readonly IntPtr NativeMethodInfoPtr_get_Definition_Public_Abstract_Virtual_New_get_AttributeDefinition_1_Nullable_1_Int32_0;

		// Token: 0x04000A2D RID: 2605
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_AttributeDataComponent_0;
	}
}
