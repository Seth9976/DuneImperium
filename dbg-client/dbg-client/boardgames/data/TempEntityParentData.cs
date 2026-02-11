using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.data
{
	// Token: 0x02000197 RID: 407
	public class TempEntityParentData : DataComponent
	{
		// Token: 0x06001217 RID: 4631 RVA: 0x00057350 File Offset: 0x00055550
		// Note: this type is marked as 'beforefieldinit'.
		static TempEntityParentData()
		{
			Il2CppClassPointerStore<TempEntityParentData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.data", "TempEntityParentData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TempEntityParentData>.NativeClassPtr);
			TempEntityParentData.NativeFieldInfoPtr__ParentEntityName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TempEntityParentData>.NativeClassPtr, "<ParentEntityName>k__BackingField");
			TempEntityParentData.NativeMethodInfoPtr_get_ParentEntityName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempEntityParentData>.NativeClassPtr, 100665829);
			TempEntityParentData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempEntityParentData>.NativeClassPtr, 100665830);
			TempEntityParentData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempEntityParentData>.NativeClassPtr, 100665831);
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06001218 RID: 4632 RVA: 0x000573D0 File Offset: 0x000555D0
		public unsafe string ParentEntityName
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempEntityParentData.NativeMethodInfoPtr_get_ParentEntityName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x00057408 File Offset: 0x00055608
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 495240, RefRangeEnd = 495283, XrefRangeStart = 495240, XrefRangeEnd = 495283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TempEntityParentData(string parentName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TempEntityParentData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(parentName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempEntityParentData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x00057454 File Offset: 0x00055654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515735, XrefRangeEnd = 515738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TempEntityParentData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x0000AA3C File Offset: 0x00008C3C
		public TempEntityParentData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x0600121C RID: 4636 RVA: 0x00057498 File Offset: 0x00055698
		// (set) Token: 0x0600121D RID: 4637 RVA: 0x0000AA45 File Offset: 0x00008C45
		public unsafe string _ParentEntityName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TempEntityParentData.NativeFieldInfoPtr__ParentEntityName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TempEntityParentData.NativeFieldInfoPtr__ParentEntityName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000B14 RID: 2836
		private static readonly IntPtr NativeFieldInfoPtr__ParentEntityName_k__BackingField;

		// Token: 0x04000B15 RID: 2837
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentEntityName_Public_get_String_0;

		// Token: 0x04000B16 RID: 2838
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000B17 RID: 2839
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
