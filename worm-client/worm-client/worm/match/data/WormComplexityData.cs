using System;
using Canis.attributes;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace worm.match.data
{
	// Token: 0x02000184 RID: 388
	public class WormComplexityData : DataComponent
	{
		// Token: 0x06001182 RID: 4482 RVA: 0x0004CE44 File Offset: 0x0004B044
		// Note: this type is marked as 'beforefieldinit'.
		static WormComplexityData()
		{
			Il2CppClassPointerStore<WormComplexityData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormComplexityData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormComplexityData>.NativeClassPtr);
			WormComplexityData.NativeFieldInfoPtr_complexityAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormComplexityData>.NativeClassPtr, "complexityAttribute");
			WormComplexityData.NativeMethodInfoPtr_get_Complexity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormComplexityData>.NativeClassPtr, 100665717);
			WormComplexityData.NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormComplexityData>.NativeClassPtr, 100665718);
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06001183 RID: 4483 RVA: 0x0004CEB0 File Offset: 0x0004B0B0
		public unsafe int Complexity
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 711319, RefRangeEnd = 711323, XrefRangeStart = 711315, XrefRangeEnd = 711319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormComplexityData.NativeMethodInfoPtr_get_Complexity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x0004CEEC File Offset: 0x0004B0EC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 711330, RefRangeEnd = 711334, XrefRangeStart = 711323, XrefRangeEnd = 711330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormComplexityData(AttributeDataComponent attributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormComplexityData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormComplexityData.NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x0000B2C0 File Offset: 0x000094C0
		public WormComplexityData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06001186 RID: 4486 RVA: 0x0004CF38 File Offset: 0x0004B138
		// (set) Token: 0x06001187 RID: 4487 RVA: 0x0000B2C9 File Offset: 0x000094C9
		public unsafe IAttribute<Nullable<int>> complexityAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormComplexityData.NativeFieldInfoPtr_complexityAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormComplexityData.NativeFieldInfoPtr_complexityAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A1C RID: 2588
		private static readonly IntPtr NativeFieldInfoPtr_complexityAttribute;

		// Token: 0x04000A1D RID: 2589
		private static readonly IntPtr NativeMethodInfoPtr_get_Complexity_Public_get_Int32_0;

		// Token: 0x04000A1E RID: 2590
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AttributeDataComponent_0;
	}
}
