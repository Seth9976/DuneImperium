using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Networking.selection.targetinformation
{
	// Token: 0x02000067 RID: 103
	public class CustomChoiceResultTargetInformation : TargetInformation
	{
		// Token: 0x0600035C RID: 860 RVA: 0x0000E958 File Offset: 0x0000CB58
		// Note: this type is marked as 'beforefieldinit'.
		static CustomChoiceResultTargetInformation()
		{
			Il2CppClassPointerStore<CustomChoiceResultTargetInformation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.targetinformation", "CustomChoiceResultTargetInformation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomChoiceResultTargetInformation>.NativeClassPtr);
			CustomChoiceResultTargetInformation.NativeFieldInfoPtr_ChoiceInformation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceResultTargetInformation>.NativeClassPtr, "ChoiceInformation");
			CustomChoiceResultTargetInformation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceResultTargetInformation>.NativeClassPtr, 100663480);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0000E9B0 File Offset: 0x0000CBB0
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 487155, RefRangeEnd = 487190, XrefRangeStart = 487155, XrefRangeEnd = 487190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomChoiceResultTargetInformation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomChoiceResultTargetInformation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceResultTargetInformation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600035E RID: 862 RVA: 0x000042AA File Offset: 0x000024AA
		public CustomChoiceResultTargetInformation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600035F RID: 863 RVA: 0x0000E9EC File Offset: 0x0000CBEC
		// (set) Token: 0x06000360 RID: 864 RVA: 0x000042B3 File Offset: 0x000024B3
		public unsafe Dictionary<int, TargetInformation> ChoiceInformation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceResultTargetInformation.NativeFieldInfoPtr_ChoiceInformation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, TargetInformation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceResultTargetInformation.NativeFieldInfoPtr_ChoiceInformation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeFieldInfoPtr_ChoiceInformation;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
