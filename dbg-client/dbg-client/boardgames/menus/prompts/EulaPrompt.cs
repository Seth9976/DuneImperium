using System;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace boardgames.menus.prompts
{
	// Token: 0x020001ED RID: 493
	public class EulaPrompt : BasePrompt
	{
		// Token: 0x0600170D RID: 5901 RVA: 0x0006852C File Offset: 0x0006672C
		// Note: this type is marked as 'beforefieldinit'.
		static EulaPrompt()
		{
			Il2CppClassPointerStore<EulaPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "EulaPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EulaPrompt>.NativeClassPtr);
			EulaPrompt.NativeFieldInfoPtr__ActionRequired_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EulaPrompt>.NativeClassPtr, "<ActionRequired>k__BackingField");
			EulaPrompt.NativeFieldInfoPtr__Result_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EulaPrompt>.NativeClassPtr, "<Result>k__BackingField");
			EulaPrompt.NativeMethodInfoPtr_get_ActionRequired_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EulaPrompt>.NativeClassPtr, 100666677);
			EulaPrompt.NativeMethodInfoPtr_set_ActionRequired_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EulaPrompt>.NativeClassPtr, 100666678);
			EulaPrompt.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EulaPrompt>.NativeClassPtr, 100666679);
			EulaPrompt.NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_ValueTuple_2_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EulaPrompt>.NativeClassPtr, 100666680);
			EulaPrompt.NativeMethodInfoPtr_set_Result_Private_set_Void_ValueTuple_2_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EulaPrompt>.NativeClassPtr, 100666681);
			EulaPrompt.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_ValueTuple_2_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EulaPrompt>.NativeClassPtr, 100666682);
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x0600170E RID: 5902 RVA: 0x000685FC File Offset: 0x000667FC
		// (set) Token: 0x0600170F RID: 5903 RVA: 0x00068638 File Offset: 0x00066838
		public unsafe bool ActionRequired
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EulaPrompt.NativeMethodInfoPtr_get_ActionRequired_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EulaPrompt.NativeMethodInfoPtr_set_ActionRequired_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001710 RID: 5904 RVA: 0x00068678 File Offset: 0x00066878
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 525129, RefRangeEnd = 525130, XrefRangeStart = 525128, XrefRangeEnd = 525129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EulaPrompt(bool actionRequired)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EulaPrompt>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actionRequired;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EulaPrompt.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06001711 RID: 5905 RVA: 0x000686C0 File Offset: 0x000668C0
		// (set) Token: 0x06001712 RID: 5906 RVA: 0x000686F8 File Offset: 0x000668F8
		public unsafe virtual ValueTuple<bool, bool> Result
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EulaPrompt.NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_ValueTuple_2_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<bool, bool>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EulaPrompt.NativeMethodInfoPtr_set_Result_Private_set_Void_ValueTuple_2_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x00068740 File Offset: 0x00066940
		[CallerCount(0)]
		public unsafe virtual void Resolve(ValueTuple<bool, bool> eulaResponse)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(eulaResponse));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EulaPrompt.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_ValueTuple_2_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x0000CEB3 File Offset: 0x0000B0B3
		public EulaPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06001715 RID: 5909 RVA: 0x00068788 File Offset: 0x00066988
		// (set) Token: 0x06001716 RID: 5910 RVA: 0x0000CEBC File Offset: 0x0000B0BC
		public unsafe bool _ActionRequired_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EulaPrompt.NativeFieldInfoPtr__ActionRequired_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EulaPrompt.NativeFieldInfoPtr__ActionRequired_k__BackingField)) = value;
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06001717 RID: 5911 RVA: 0x000687B0 File Offset: 0x000669B0
		// (set) Token: 0x06001718 RID: 5912 RVA: 0x0000CED7 File Offset: 0x0000B0D7
		public ValueTuple<bool, bool> _Result_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EulaPrompt.NativeFieldInfoPtr__Result_k__BackingField);
				return new ValueTuple<bool, bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<bool, bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EulaPrompt.NativeFieldInfoPtr__Result_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<bool, bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000E59 RID: 3673
		private static readonly IntPtr NativeFieldInfoPtr__ActionRequired_k__BackingField;

		// Token: 0x04000E5A RID: 3674
		private static readonly IntPtr NativeFieldInfoPtr__Result_k__BackingField;

		// Token: 0x04000E5B RID: 3675
		private static readonly IntPtr NativeMethodInfoPtr_get_ActionRequired_Public_get_Boolean_0;

		// Token: 0x04000E5C RID: 3676
		private static readonly IntPtr NativeMethodInfoPtr_set_ActionRequired_Private_set_Void_Boolean_0;

		// Token: 0x04000E5D RID: 3677
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000E5E RID: 3678
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_ValueTuple_2_Boolean_Boolean_0;

		// Token: 0x04000E5F RID: 3679
		private static readonly IntPtr NativeMethodInfoPtr_set_Result_Private_set_Void_ValueTuple_2_Boolean_Boolean_0;

		// Token: 0x04000E60 RID: 3680
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_ValueTuple_2_Boolean_Boolean_0;
	}
}
