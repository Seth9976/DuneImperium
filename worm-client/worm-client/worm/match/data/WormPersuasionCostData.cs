using System;
using Canis.attributes;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace worm.match.data
{
	// Token: 0x02000195 RID: 405
	public class WormPersuasionCostData : WormCostData
	{
		// Token: 0x06001226 RID: 4646 RVA: 0x0004EEB0 File Offset: 0x0004D0B0
		// Note: this type is marked as 'beforefieldinit'.
		static WormPersuasionCostData()
		{
			Il2CppClassPointerStore<WormPersuasionCostData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormPersuasionCostData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPersuasionCostData>.NativeClassPtr);
			WormPersuasionCostData.NativeMethodInfoPtr_get_Definition_Public_Virtual_get_AttributeDefinition_1_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPersuasionCostData>.NativeClassPtr, 100665776);
			WormPersuasionCostData.NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPersuasionCostData>.NativeClassPtr, 100665777);
			WormPersuasionCostData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPersuasionCostData>.NativeClassPtr, 100665778);
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06001227 RID: 4647 RVA: 0x0004EF1C File Offset: 0x0004D11C
		public unsafe override AttributeDefinition<Nullable<int>> Definition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711753, XrefRangeEnd = 711757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPersuasionCostData.NativeMethodInfoPtr_get_Definition_Public_Virtual_get_AttributeDefinition_1_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr3) : null;
			}
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x0004EF68 File Offset: 0x0004D168
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 711377, RefRangeEnd = 711381, XrefRangeStart = 711377, XrefRangeEnd = 711381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPersuasionCostData(AttributeDataComponent attributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPersuasionCostData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPersuasionCostData.NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x0004EFB4 File Offset: 0x0004D1B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711757, XrefRangeEnd = 711765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPersuasionCostData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x0000B7A4 File Offset: 0x000099A4
		public WormPersuasionCostData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A79 RID: 2681
		private static readonly IntPtr NativeMethodInfoPtr_get_Definition_Public_Virtual_get_AttributeDefinition_1_Nullable_1_Int32_0;

		// Token: 0x04000A7A RID: 2682
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0;

		// Token: 0x04000A7B RID: 2683
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
