using System;
using Canis.attributes;
using Canis.utils.ids;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Networking.selection.targetinformation
{
	// Token: 0x0200007B RID: 123
	public class TargetInformation : Object
	{
		// Token: 0x06000411 RID: 1041 RVA: 0x00010CD4 File Offset: 0x0000EED4
		// Note: this type is marked as 'beforefieldinit'.
		static TargetInformation()
		{
			Il2CppClassPointerStore<TargetInformation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.targetinformation", "TargetInformation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetInformation>.NativeClassPtr);
			TargetInformation.NativeFieldInfoPtr_Selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInformation>.NativeClassPtr, "Selected");
			TargetInformation.NativeFieldInfoPtr_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInformation>.NativeClassPtr, "AccountID");
			TargetInformation.NativeFieldInfoPtr_OverrideKind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInformation>.NativeClassPtr, "OverrideKind");
			TargetInformation.NativeFieldInfoPtr_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInformation>.NativeClassPtr, "Attributes");
			TargetInformation.NativeFieldInfoPtr_TargetPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetInformation>.NativeClassPtr, "TargetPrompt");
			TargetInformation.NativeMethodInfoPtr_get_ForcedSelection_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInformation>.NativeClassPtr, 100663559);
			TargetInformation.NativeMethodInfoPtr_GetKind_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInformation>.NativeClassPtr, 100663560);
			TargetInformation.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInformation>.NativeClassPtr, 100663561);
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x00010DA4 File Offset: 0x0000EFA4
		public unsafe virtual bool ForcedSelection
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TargetInformation.NativeMethodInfoPtr_get_ForcedSelection_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00010DEC File Offset: 0x0000EFEC
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1194478, RefRangeEnd = 1194491, XrefRangeStart = 1194477, XrefRangeEnd = 1194478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetKind()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetInformation.NativeMethodInfoPtr_GetKind_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00010E24 File Offset: 0x0000F024
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 487155, RefRangeEnd = 487190, XrefRangeStart = 487155, XrefRangeEnd = 487190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetInformation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetInformation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetInformation.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00004807 File Offset: 0x00002A07
		public TargetInformation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x00010E60 File Offset: 0x0000F060
		// (set) Token: 0x06000417 RID: 1047 RVA: 0x00004810 File Offset: 0x00002A10
		public unsafe bool Selected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetInformation.NativeFieldInfoPtr_Selected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetInformation.NativeFieldInfoPtr_Selected)) = value;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x00010E88 File Offset: 0x0000F088
		// (set) Token: 0x06000419 RID: 1049 RVA: 0x0000482B File Offset: 0x00002A2B
		public unsafe AccountID AccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetInformation.NativeFieldInfoPtr_AccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetInformation.NativeFieldInfoPtr_AccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x00010EB8 File Offset: 0x0000F0B8
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x0000484A File Offset: 0x00002A4A
		public unsafe string OverrideKind
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetInformation.NativeFieldInfoPtr_OverrideKind);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetInformation.NativeFieldInfoPtr_OverrideKind), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x00010EE0 File Offset: 0x0000F0E0
		// (set) Token: 0x0600041D RID: 1053 RVA: 0x00004869 File Offset: 0x00002A69
		public unsafe ReadOnlyAttributes Attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetInformation.NativeFieldInfoPtr_Attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetInformation.NativeFieldInfoPtr_Attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x00010F10 File Offset: 0x0000F110
		// (set) Token: 0x0600041F RID: 1055 RVA: 0x00004888 File Offset: 0x00002A88
		public unsafe LocalizableTextVariables TargetPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetInformation.NativeFieldInfoPtr_TargetPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetInformation.NativeFieldInfoPtr_TargetPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeFieldInfoPtr_Selected;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeFieldInfoPtr_AccountID;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeFieldInfoPtr_OverrideKind;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeFieldInfoPtr_Attributes;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeFieldInfoPtr_TargetPrompt;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeMethodInfoPtr_get_ForcedSelection_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeMethodInfoPtr_GetKind_Public_String_0;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
