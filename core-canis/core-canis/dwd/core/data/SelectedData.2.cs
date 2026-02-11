using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.data
{
	// Token: 0x020001CC RID: 460
	public sealed class SelectedData : SelectedData<DataComposition>
	{
		// Token: 0x0600197E RID: 6526 RVA: 0x00079330 File Offset: 0x00077530
		// Note: this type is marked as 'beforefieldinit'.
		static SelectedData()
		{
			Il2CppClassPointerStore<SelectedData>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.data", "SelectedData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectedData>.NativeClassPtr);
			SelectedData.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedData>.NativeClassPtr, 100667348);
			SelectedData.NativeMethodInfoPtr_Clone_Public_Virtual_DataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedData>.NativeClassPtr, 100667349);
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x00079388 File Offset: 0x00077588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 881400, XrefRangeEnd = 881403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectedData(DataComposition initialSelection = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectedData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(initialSelection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedData.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x000793D4 File Offset: 0x000775D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 881403, XrefRangeEnd = 881410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DataComponent Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedData.NativeMethodInfoPtr_Clone_Public_Virtual_DataComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComponent>(intPtr3) : null;
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x0000B2B6 File Offset: 0x000094B6
		public SelectedData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040011E9 RID: 4585
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0;

		// Token: 0x040011EA RID: 4586
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_DataComponent_0;
	}
}
