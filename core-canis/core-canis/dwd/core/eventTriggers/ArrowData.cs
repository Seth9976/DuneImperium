using System;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.eventTriggers
{
	// Token: 0x020001AA RID: 426
	public class ArrowData : Object
	{
		// Token: 0x06001825 RID: 6181 RVA: 0x00074770 File Offset: 0x00072970
		// Note: this type is marked as 'beforefieldinit'.
		static ArrowData()
		{
			Il2CppClassPointerStore<ArrowData>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.eventTriggers", "ArrowData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrowData>.NativeClassPtr);
			ArrowData.NativeFieldInfoPtr_ArrowID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrowData>.NativeClassPtr, "ArrowID");
			ArrowData.NativeFieldInfoPtr_Highlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrowData>.NativeClassPtr, "Highlight");
			ArrowData.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrowData>.NativeClassPtr, "Label");
			ArrowData.NativeFieldInfoPtr_Delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrowData>.NativeClassPtr, "Delay");
			ArrowData.NativeMethodInfoPtr__ctor_Public_Void_ArrowID_String_LocalizedString_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrowData>.NativeClassPtr, 100667154);
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x00074804 File Offset: 0x00072A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880250, XrefRangeEnd = 880259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrowData(ArrowID arrowID, string highlight, LocalizedString label, long milliseconds)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrowData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arrowID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(highlight);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(label);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref milliseconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrowData.NativeMethodInfoPtr__ctor_Public_Void_ArrowID_String_LocalizedString_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x0000A965 File Offset: 0x00008B65
		public ArrowData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06001828 RID: 6184 RVA: 0x00074884 File Offset: 0x00072A84
		// (set) Token: 0x06001829 RID: 6185 RVA: 0x0000A96E File Offset: 0x00008B6E
		public unsafe ArrowID ArrowID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrowData.NativeFieldInfoPtr_ArrowID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrowID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrowData.NativeFieldInfoPtr_ArrowID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x0600182A RID: 6186 RVA: 0x000748B4 File Offset: 0x00072AB4
		// (set) Token: 0x0600182B RID: 6187 RVA: 0x0000A98D File Offset: 0x00008B8D
		public unsafe string Highlight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrowData.NativeFieldInfoPtr_Highlight);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrowData.NativeFieldInfoPtr_Highlight), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x0600182C RID: 6188 RVA: 0x000748DC File Offset: 0x00072ADC
		// (set) Token: 0x0600182D RID: 6189 RVA: 0x0000A9AC File Offset: 0x00008BAC
		public unsafe LocalizedString Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrowData.NativeFieldInfoPtr_Label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrowData.NativeFieldInfoPtr_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x0600182E RID: 6190 RVA: 0x0007490C File Offset: 0x00072B0C
		// (set) Token: 0x0600182F RID: 6191 RVA: 0x0000A9CB File Offset: 0x00008BCB
		public unsafe float Delay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrowData.NativeFieldInfoPtr_Delay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrowData.NativeFieldInfoPtr_Delay)) = value;
			}
		}

		// Token: 0x04001119 RID: 4377
		private static readonly IntPtr NativeFieldInfoPtr_ArrowID;

		// Token: 0x0400111A RID: 4378
		private static readonly IntPtr NativeFieldInfoPtr_Highlight;

		// Token: 0x0400111B RID: 4379
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x0400111C RID: 4380
		private static readonly IntPtr NativeFieldInfoPtr_Delay;

		// Token: 0x0400111D RID: 4381
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ArrowID_String_LocalizedString_Int64_0;
	}
}
