using System;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Networking.selection.targetinformation
{
	// Token: 0x02000065 RID: 101
	public class ArchetypeCustomChoiceTargetInformation : TargetInformation
	{
		// Token: 0x06000349 RID: 841 RVA: 0x0000E610 File Offset: 0x0000C810
		// Note: this type is marked as 'beforefieldinit'.
		static ArchetypeCustomChoiceTargetInformation()
		{
			Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInformation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.targetinformation", "ArchetypeCustomChoiceTargetInformation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInformation>.NativeClassPtr);
			ArchetypeCustomChoiceTargetInformation.NativeFieldInfoPtr_Choices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInformation>.NativeClassPtr, "Choices");
			ArchetypeCustomChoiceTargetInformation.NativeFieldInfoPtr_NumberToSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInformation>.NativeClassPtr, "NumberToSelect");
			ArchetypeCustomChoiceTargetInformation.NativeFieldInfoPtr_Forced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInformation>.NativeClassPtr, "Forced");
			ArchetypeCustomChoiceTargetInformation.NativeFieldInfoPtr_MinimumToSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInformation>.NativeClassPtr, "MinimumToSelect");
			ArchetypeCustomChoiceTargetInformation.NativeMethodInfoPtr_get_ForcedSelection_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInformation>.NativeClassPtr, 100663473);
			ArchetypeCustomChoiceTargetInformation.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInformation>.NativeClassPtr, 100663474);
			ArchetypeCustomChoiceTargetInformation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInformation>.NativeClassPtr, 100663475);
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600034A RID: 842 RVA: 0x0000E6CC File Offset: 0x0000C8CC
		public unsafe override bool ForcedSelection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArchetypeCustomChoiceTargetInformation.NativeMethodInfoPtr_get_ForcedSelection_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0000E714 File Offset: 0x0000C914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194144, XrefRangeEnd = 1194150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArchetypeCustomChoiceTargetInformation.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0000E758 File Offset: 0x0000C958
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 487155, RefRangeEnd = 487190, XrefRangeStart = 487155, XrefRangeEnd = 487190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArchetypeCustomChoiceTargetInformation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArchetypeCustomChoiceTargetInformation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeCustomChoiceTargetInformation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00004209 File Offset: 0x00002409
		public ArchetypeCustomChoiceTargetInformation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600034E RID: 846 RVA: 0x0000E794 File Offset: 0x0000C994
		// (set) Token: 0x0600034F RID: 847 RVA: 0x00004212 File Offset: 0x00002412
		public unsafe Il2CppReferenceArray<SerializableAttributes> Choices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoiceTargetInformation.NativeFieldInfoPtr_Choices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SerializableAttributes>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoiceTargetInformation.NativeFieldInfoPtr_Choices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000350 RID: 848 RVA: 0x0000E7C4 File Offset: 0x0000C9C4
		// (set) Token: 0x06000351 RID: 849 RVA: 0x00004231 File Offset: 0x00002431
		public unsafe int NumberToSelect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoiceTargetInformation.NativeFieldInfoPtr_NumberToSelect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoiceTargetInformation.NativeFieldInfoPtr_NumberToSelect)) = value;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000352 RID: 850 RVA: 0x0000E7EC File Offset: 0x0000C9EC
		// (set) Token: 0x06000353 RID: 851 RVA: 0x0000424C File Offset: 0x0000244C
		public unsafe bool Forced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoiceTargetInformation.NativeFieldInfoPtr_Forced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoiceTargetInformation.NativeFieldInfoPtr_Forced)) = value;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000354 RID: 852 RVA: 0x0000E814 File Offset: 0x0000CA14
		// (set) Token: 0x06000355 RID: 853 RVA: 0x00004267 File Offset: 0x00002467
		public unsafe int MinimumToSelect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoiceTargetInformation.NativeFieldInfoPtr_MinimumToSelect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoiceTargetInformation.NativeFieldInfoPtr_MinimumToSelect)) = value;
			}
		}

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeFieldInfoPtr_Choices;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeFieldInfoPtr_NumberToSelect;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeFieldInfoPtr_Forced;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeFieldInfoPtr_MinimumToSelect;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeMethodInfoPtr_get_ForcedSelection_Public_Virtual_get_Boolean_0;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
