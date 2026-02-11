using System;
using dwd.core.data.composition;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.data
{
	// Token: 0x02000196 RID: 406
	public class TempEntityChildData : DataComponent
	{
		// Token: 0x06001210 RID: 4624 RVA: 0x000571D0 File Offset: 0x000553D0
		// Note: this type is marked as 'beforefieldinit'.
		static TempEntityChildData()
		{
			Il2CppClassPointerStore<TempEntityChildData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.data", "TempEntityChildData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TempEntityChildData>.NativeClassPtr);
			TempEntityChildData.NativeFieldInfoPtr__Children_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TempEntityChildData>.NativeClassPtr, "<Children>k__BackingField");
			TempEntityChildData.NativeMethodInfoPtr_get_Children_Public_get_ReadOnlyVersionedList_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempEntityChildData>.NativeClassPtr, 100665826);
			TempEntityChildData.NativeMethodInfoPtr__ctor_Public_Void_ReadOnlyVersionedList_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempEntityChildData>.NativeClassPtr, 100665827);
			TempEntityChildData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempEntityChildData>.NativeClassPtr, 100665828);
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06001211 RID: 4625 RVA: 0x00057250 File Offset: 0x00055450
		public unsafe ReadOnlyVersionedList<EntityComponent> Children
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempEntityChildData.NativeMethodInfoPtr_get_Children_Public_get_ReadOnlyVersionedList_1_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyVersionedList<EntityComponent>>(intPtr3) : null;
			}
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x00057290 File Offset: 0x00055490
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 495240, RefRangeEnd = 495283, XrefRangeStart = 495240, XrefRangeEnd = 495283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TempEntityChildData(ReadOnlyVersionedList<EntityComponent> children)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TempEntityChildData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(children);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempEntityChildData.NativeMethodInfoPtr__ctor_Public_Void_ReadOnlyVersionedList_1_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x000572DC File Offset: 0x000554DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515726, XrefRangeEnd = 515735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TempEntityChildData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x0000AA14 File Offset: 0x00008C14
		public TempEntityChildData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06001215 RID: 4629 RVA: 0x00057320 File Offset: 0x00055520
		// (set) Token: 0x06001216 RID: 4630 RVA: 0x0000AA1D File Offset: 0x00008C1D
		public unsafe ReadOnlyVersionedList<EntityComponent> _Children_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TempEntityChildData.NativeFieldInfoPtr__Children_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyVersionedList<EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TempEntityChildData.NativeFieldInfoPtr__Children_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B10 RID: 2832
		private static readonly IntPtr NativeFieldInfoPtr__Children_k__BackingField;

		// Token: 0x04000B11 RID: 2833
		private static readonly IntPtr NativeMethodInfoPtr_get_Children_Public_get_ReadOnlyVersionedList_1_EntityComponent_0;

		// Token: 0x04000B12 RID: 2834
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ReadOnlyVersionedList_1_EntityComponent_0;

		// Token: 0x04000B13 RID: 2835
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
