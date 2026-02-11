using System;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.selection.messages;
using Networking.selection.targetinformation;

namespace dwd.core.match.selection.messages
{
	// Token: 0x0200015B RID: 347
	public class CustomChoiceWithTargetsRequired : SelectionMessage
	{
		// Token: 0x06001474 RID: 5236 RVA: 0x00066730 File Offset: 0x00064930
		// Note: this type is marked as 'beforefieldinit'.
		static CustomChoiceWithTargetsRequired()
		{
			Il2CppClassPointerStore<CustomChoiceWithTargetsRequired>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection.messages", "CustomChoiceWithTargetsRequired");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomChoiceWithTargetsRequired>.NativeClassPtr);
			CustomChoiceWithTargetsRequired.NativeFieldInfoPtr_Forced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceWithTargetsRequired>.NativeClassPtr, "Forced");
			CustomChoiceWithTargetsRequired.NativeFieldInfoPtr_IgnoreFirst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceWithTargetsRequired>.NativeClassPtr, "IgnoreFirst");
			CustomChoiceWithTargetsRequired.NativeFieldInfoPtr_ChoiceKind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceWithTargetsRequired>.NativeClassPtr, "ChoiceKind");
			CustomChoiceWithTargetsRequired.NativeFieldInfoPtr_Choices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceWithTargetsRequired>.NativeClassPtr, "Choices");
			CustomChoiceWithTargetsRequired.NativeFieldInfoPtr_ChoiceTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceWithTargetsRequired>.NativeClassPtr, "ChoiceTargets");
			CustomChoiceWithTargetsRequired.NativeFieldInfoPtr_TargetPreferences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceWithTargetsRequired>.NativeClassPtr, "TargetPreferences");
			CustomChoiceWithTargetsRequired.NativeFieldInfoPtr_SourceEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceWithTargetsRequired>.NativeClassPtr, "SourceEntity");
			CustomChoiceWithTargetsRequired.NativeFieldInfoPtr_SelectionParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceWithTargetsRequired>.NativeClassPtr, "SelectionParams");
			CustomChoiceWithTargetsRequired.NativeMethodInfoPtr_Networking_selection_messages_ISelectionParams_get_Params_Private_Virtual_Final_New_get_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceWithTargetsRequired>.NativeClassPtr, 100666399);
			CustomChoiceWithTargetsRequired.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceWithTargetsRequired>.NativeClassPtr, 100666400);
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06001475 RID: 5237 RVA: 0x00066828 File Offset: 0x00064A28
		public unsafe virtual Dictionary<string, Object> Networking.selection.messages.ISelectionParams.Params
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceWithTargetsRequired.NativeMethodInfoPtr_Networking_selection_messages_ISelectionParams_get_Params_Private_Virtual_Final_New_get_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x00066868 File Offset: 0x00064A68
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 542958, RefRangeEnd = 542962, XrefRangeStart = 542958, XrefRangeEnd = 542962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomChoiceWithTargetsRequired()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomChoiceWithTargetsRequired>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceWithTargetsRequired.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x00008FF6 File Offset: 0x000071F6
		public CustomChoiceWithTargetsRequired(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06001478 RID: 5240 RVA: 0x000668A4 File Offset: 0x00064AA4
		// (set) Token: 0x06001479 RID: 5241 RVA: 0x00008FFF File Offset: 0x000071FF
		public unsafe bool Forced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargetsRequired.NativeFieldInfoPtr_Forced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargetsRequired.NativeFieldInfoPtr_Forced)) = value;
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x0600147A RID: 5242 RVA: 0x000668CC File Offset: 0x00064ACC
		// (set) Token: 0x0600147B RID: 5243 RVA: 0x0000901A File Offset: 0x0000721A
		public unsafe bool IgnoreFirst
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargetsRequired.NativeFieldInfoPtr_IgnoreFirst);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargetsRequired.NativeFieldInfoPtr_IgnoreFirst)) = value;
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x0600147C RID: 5244 RVA: 0x000668F4 File Offset: 0x00064AF4
		// (set) Token: 0x0600147D RID: 5245 RVA: 0x00009035 File Offset: 0x00007235
		public unsafe string ChoiceKind
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargetsRequired.NativeFieldInfoPtr_ChoiceKind);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargetsRequired.NativeFieldInfoPtr_ChoiceKind), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x0600147E RID: 5246 RVA: 0x0006691C File Offset: 0x00064B1C
		// (set) Token: 0x0600147F RID: 5247 RVA: 0x00009054 File Offset: 0x00007254
		public unsafe List<SerializedEntity> Choices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargetsRequired.NativeFieldInfoPtr_Choices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SerializedEntity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargetsRequired.NativeFieldInfoPtr_Choices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001480 RID: 5248 RVA: 0x0006694C File Offset: 0x00064B4C
		// (set) Token: 0x06001481 RID: 5249 RVA: 0x00009073 File Offset: 0x00007273
		public unsafe List<Il2CppReferenceArray<TargetInformation>> ChoiceTargets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargetsRequired.NativeFieldInfoPtr_ChoiceTargets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Il2CppReferenceArray<TargetInformation>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargetsRequired.NativeFieldInfoPtr_ChoiceTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06001482 RID: 5250 RVA: 0x0006697C File Offset: 0x00064B7C
		// (set) Token: 0x06001483 RID: 5251 RVA: 0x00009092 File Offset: 0x00007292
		public unsafe List<TargetPreference> TargetPreferences
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargetsRequired.NativeFieldInfoPtr_TargetPreferences);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TargetPreference>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargetsRequired.NativeFieldInfoPtr_TargetPreferences), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06001484 RID: 5252 RVA: 0x000669AC File Offset: 0x00064BAC
		// (set) Token: 0x06001485 RID: 5253 RVA: 0x000090B1 File Offset: 0x000072B1
		public unsafe EntityID SourceEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargetsRequired.NativeFieldInfoPtr_SourceEntity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargetsRequired.NativeFieldInfoPtr_SourceEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06001486 RID: 5254 RVA: 0x000669DC File Offset: 0x00064BDC
		// (set) Token: 0x06001487 RID: 5255 RVA: 0x000090D0 File Offset: 0x000072D0
		public unsafe Dictionary<string, Object> SelectionParams
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargetsRequired.NativeFieldInfoPtr_SelectionParams);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceWithTargetsRequired.NativeFieldInfoPtr_SelectionParams), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EAD RID: 3757
		private static readonly IntPtr NativeFieldInfoPtr_Forced;

		// Token: 0x04000EAE RID: 3758
		private static readonly IntPtr NativeFieldInfoPtr_IgnoreFirst;

		// Token: 0x04000EAF RID: 3759
		private static readonly IntPtr NativeFieldInfoPtr_ChoiceKind;

		// Token: 0x04000EB0 RID: 3760
		private static readonly IntPtr NativeFieldInfoPtr_Choices;

		// Token: 0x04000EB1 RID: 3761
		private static readonly IntPtr NativeFieldInfoPtr_ChoiceTargets;

		// Token: 0x04000EB2 RID: 3762
		private static readonly IntPtr NativeFieldInfoPtr_TargetPreferences;

		// Token: 0x04000EB3 RID: 3763
		private static readonly IntPtr NativeFieldInfoPtr_SourceEntity;

		// Token: 0x04000EB4 RID: 3764
		private static readonly IntPtr NativeFieldInfoPtr_SelectionParams;

		// Token: 0x04000EB5 RID: 3765
		private static readonly IntPtr NativeMethodInfoPtr_Networking_selection_messages_ISelectionParams_get_Params_Private_Virtual_Final_New_get_Dictionary_2_String_Object_0;

		// Token: 0x04000EB6 RID: 3766
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
