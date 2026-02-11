using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace InControl
{
	// Token: 0x02000027 RID: 39
	[Serializable]
	public class InputControlMapping : Object
	{
		// Token: 0x06000290 RID: 656 RVA: 0x00011120 File Offset: 0x0000F320
		// Note: this type is marked as 'beforefieldinit'.
		static InputControlMapping()
		{
			Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "InputControlMapping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr);
			InputControlMapping.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, "name");
			InputControlMapping.NativeFieldInfoPtr_invert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, "invert");
			InputControlMapping.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, "scale");
			InputControlMapping.NativeFieldInfoPtr_raw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, "raw");
			InputControlMapping.NativeFieldInfoPtr_passive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, "passive");
			InputControlMapping.NativeFieldInfoPtr_ignoreInitialZeroValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, "ignoreInitialZeroValue");
			InputControlMapping.NativeFieldInfoPtr_sensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, "sensitivity");
			InputControlMapping.NativeFieldInfoPtr_lowerDeadZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, "lowerDeadZone");
			InputControlMapping.NativeFieldInfoPtr_upperDeadZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, "upperDeadZone");
			InputControlMapping.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, "source");
			InputControlMapping.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, "target");
			InputControlMapping.NativeFieldInfoPtr_sourceRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, "sourceRange");
			InputControlMapping.NativeFieldInfoPtr_targetRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, "targetRange");
			InputControlMapping.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, 100663653);
			InputControlMapping.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, 100663654);
			InputControlMapping.NativeMethodInfoPtr_get_Invert_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, 100663655);
			InputControlMapping.NativeMethodInfoPtr_set_Invert_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, 100663656);
			InputControlMapping.NativeMethodInfoPtr_get_Scale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, 100663657);
			InputControlMapping.NativeMethodInfoPtr_set_Scale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, 100663658);
			InputControlMapping.NativeMethodInfoPtr_get_Raw_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, 100663659);
			InputControlMapping.NativeMethodInfoPtr_set_Raw_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, 100663660);
			InputControlMapping.NativeMethodInfoPtr_get_Passive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, 100663661);
			InputControlMapping.NativeMethodInfoPtr_set_Passive_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, 100663662);
			InputControlMapping.NativeMethodInfoPtr_get_IgnoreInitialZeroValue_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, 100663663);
			InputControlMapping.NativeMethodInfoPtr_set_IgnoreInitialZeroValue_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, 100663664);
			InputControlMapping.NativeMethodInfoPtr_get_Sensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, 100663665);
			InputControlMapping.NativeMethodInfoPtr_set_Sensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, 100663666);
			InputControlMapping.NativeMethodInfoPtr_get_LowerDeadZone_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, 100663667);
			InputControlMapping.NativeMethodInfoPtr_set_LowerDeadZone_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, 100663668);
			InputControlMapping.NativeMethodInfoPtr_get_UpperDeadZone_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, 100663669);
			InputControlMapping.NativeMethodInfoPtr_set_UpperDeadZone_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, 100663670);
			InputControlMapping.NativeMethodInfoPtr_get_Source_Public_get_InputControlSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, 100663671);
			InputControlMapping.NativeMethodInfoPtr_set_Source_Public_set_Void_InputControlSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, 100663672);
			InputControlMapping.NativeMethodInfoPtr_get_Target_Public_get_InputControlType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, 100663673);
			InputControlMapping.NativeMethodInfoPtr_set_Target_Public_set_Void_InputControlType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, 100663674);
			InputControlMapping.NativeMethodInfoPtr_get_SourceRange_Public_get_InputRangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, 100663675);
			InputControlMapping.NativeMethodInfoPtr_set_SourceRange_Public_set_Void_InputRangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, 100663676);
			InputControlMapping.NativeMethodInfoPtr_get_TargetRange_Public_get_InputRangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, 100663677);
			InputControlMapping.NativeMethodInfoPtr_set_TargetRange_Public_set_Void_InputRangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, 100663678);
			InputControlMapping.NativeMethodInfoPtr_ApplyToValue_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, 100663679);
			InputControlMapping.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr, 100663680);
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000291 RID: 657 RVA: 0x00011484 File Offset: 0x0000F684
		// (set) Token: 0x06000292 RID: 658 RVA: 0x000114BC File Offset: 0x0000F6BC
		public unsafe string Name
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 769389, RefRangeEnd = 769393, XrefRangeStart = 769385, XrefRangeEnd = 769389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlMapping.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlMapping.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000293 RID: 659 RVA: 0x00011500 File Offset: 0x0000F700
		// (set) Token: 0x06000294 RID: 660 RVA: 0x0001153C File Offset: 0x0000F73C
		public unsafe bool Invert
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlMapping.NativeMethodInfoPtr_get_Invert_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlMapping.NativeMethodInfoPtr_set_Invert_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000295 RID: 661 RVA: 0x0001157C File Offset: 0x0000F77C
		// (set) Token: 0x06000296 RID: 662 RVA: 0x000115B8 File Offset: 0x0000F7B8
		public unsafe float Scale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlMapping.NativeMethodInfoPtr_get_Scale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 604702, RefRangeEnd = 604705, XrefRangeStart = 604702, XrefRangeEnd = 604705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlMapping.NativeMethodInfoPtr_set_Scale_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000297 RID: 663 RVA: 0x000115F8 File Offset: 0x0000F7F8
		// (set) Token: 0x06000298 RID: 664 RVA: 0x00011634 File Offset: 0x0000F834
		public unsafe bool Raw
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlMapping.NativeMethodInfoPtr_get_Raw_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlMapping.NativeMethodInfoPtr_set_Raw_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000299 RID: 665 RVA: 0x00011674 File Offset: 0x0000F874
		// (set) Token: 0x0600029A RID: 666 RVA: 0x000116B0 File Offset: 0x0000F8B0
		public unsafe bool Passive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlMapping.NativeMethodInfoPtr_get_Passive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlMapping.NativeMethodInfoPtr_set_Passive_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600029B RID: 667 RVA: 0x000116F0 File Offset: 0x0000F8F0
		// (set) Token: 0x0600029C RID: 668 RVA: 0x0001172C File Offset: 0x0000F92C
		public unsafe bool IgnoreInitialZeroValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlMapping.NativeMethodInfoPtr_get_IgnoreInitialZeroValue_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlMapping.NativeMethodInfoPtr_set_IgnoreInitialZeroValue_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600029D RID: 669 RVA: 0x0001176C File Offset: 0x0000F96C
		// (set) Token: 0x0600029E RID: 670 RVA: 0x000117A8 File Offset: 0x0000F9A8
		public unsafe float Sensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlMapping.NativeMethodInfoPtr_get_Sensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlMapping.NativeMethodInfoPtr_set_Sensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600029F RID: 671 RVA: 0x000117E8 File Offset: 0x0000F9E8
		// (set) Token: 0x060002A0 RID: 672 RVA: 0x00011824 File Offset: 0x0000FA24
		public unsafe float LowerDeadZone
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlMapping.NativeMethodInfoPtr_get_LowerDeadZone_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlMapping.NativeMethodInfoPtr_set_LowerDeadZone_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x00011864 File Offset: 0x0000FA64
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x000118A0 File Offset: 0x0000FAA0
		public unsafe float UpperDeadZone
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlMapping.NativeMethodInfoPtr_get_UpperDeadZone_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlMapping.NativeMethodInfoPtr_set_UpperDeadZone_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x000118E0 File Offset: 0x0000FAE0
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x0001191C File Offset: 0x0000FB1C
		public unsafe InputControlSource Source
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlMapping.NativeMethodInfoPtr_get_Source_Public_get_InputControlSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlMapping.NativeMethodInfoPtr_set_Source_Public_set_Void_InputControlSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x0001195C File Offset: 0x0000FB5C
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x00011998 File Offset: 0x0000FB98
		public unsafe InputControlType Target
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlMapping.NativeMethodInfoPtr_get_Target_Public_get_InputControlType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 170594, RefRangeEnd = 170603, XrefRangeStart = 170594, XrefRangeEnd = 170603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlMapping.NativeMethodInfoPtr_set_Target_Public_set_Void_InputControlType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x000119D8 File Offset: 0x0000FBD8
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x00011A14 File Offset: 0x0000FC14
		public unsafe InputRangeType SourceRange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlMapping.NativeMethodInfoPtr_get_SourceRange_Public_get_InputRangeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 135903, RefRangeEnd = 135917, XrefRangeStart = 135903, XrefRangeEnd = 135917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlMapping.NativeMethodInfoPtr_set_SourceRange_Public_set_Void_InputRangeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x00011A54 File Offset: 0x0000FC54
		// (set) Token: 0x060002AA RID: 682 RVA: 0x00011A90 File Offset: 0x0000FC90
		public unsafe InputRangeType TargetRange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlMapping.NativeMethodInfoPtr_get_TargetRange_Public_get_InputRangeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlMapping.NativeMethodInfoPtr_set_TargetRange_Public_set_Void_InputRangeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00011AD0 File Offset: 0x0000FCD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 769404, RefRangeEnd = 769405, XrefRangeStart = 769393, XrefRangeEnd = 769404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ApplyToValue(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlMapping.NativeMethodInfoPtr_ApplyToValue_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00011B1C File Offset: 0x0000FD1C
		[CallerCount(3827)]
		[CachedScanResults(RefRangeStart = 769410, RefRangeEnd = 773237, XrefRangeStart = 769405, XrefRangeEnd = 769410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputControlMapping()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputControlMapping>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlMapping.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00002EDE File Offset: 0x000010DE
		public InputControlMapping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060002AE RID: 686 RVA: 0x00011B58 File Offset: 0x0000FD58
		// (set) Token: 0x060002AF RID: 687 RVA: 0x00002EE7 File Offset: 0x000010E7
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputControlMapping.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputControlMapping.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x00011B80 File Offset: 0x0000FD80
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x00002F06 File Offset: 0x00001106
		public unsafe bool invert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputControlMapping.NativeFieldInfoPtr_invert);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputControlMapping.NativeFieldInfoPtr_invert)) = value;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x00011BA8 File Offset: 0x0000FDA8
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x00002F21 File Offset: 0x00001121
		public unsafe float scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputControlMapping.NativeFieldInfoPtr_scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputControlMapping.NativeFieldInfoPtr_scale)) = value;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x00011BD0 File Offset: 0x0000FDD0
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x00002F3C File Offset: 0x0000113C
		public unsafe bool raw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputControlMapping.NativeFieldInfoPtr_raw);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputControlMapping.NativeFieldInfoPtr_raw)) = value;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x00011BF8 File Offset: 0x0000FDF8
		// (set) Token: 0x060002B7 RID: 695 RVA: 0x00002F57 File Offset: 0x00001157
		public unsafe bool passive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputControlMapping.NativeFieldInfoPtr_passive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputControlMapping.NativeFieldInfoPtr_passive)) = value;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x00011C20 File Offset: 0x0000FE20
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x00002F72 File Offset: 0x00001172
		public unsafe bool ignoreInitialZeroValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputControlMapping.NativeFieldInfoPtr_ignoreInitialZeroValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputControlMapping.NativeFieldInfoPtr_ignoreInitialZeroValue)) = value;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060002BA RID: 698 RVA: 0x00011C48 File Offset: 0x0000FE48
		// (set) Token: 0x060002BB RID: 699 RVA: 0x00002F8D File Offset: 0x0000118D
		public unsafe float sensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputControlMapping.NativeFieldInfoPtr_sensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputControlMapping.NativeFieldInfoPtr_sensitivity)) = value;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060002BC RID: 700 RVA: 0x00011C70 File Offset: 0x0000FE70
		// (set) Token: 0x060002BD RID: 701 RVA: 0x00002FA8 File Offset: 0x000011A8
		public unsafe float lowerDeadZone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputControlMapping.NativeFieldInfoPtr_lowerDeadZone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputControlMapping.NativeFieldInfoPtr_lowerDeadZone)) = value;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060002BE RID: 702 RVA: 0x00011C98 File Offset: 0x0000FE98
		// (set) Token: 0x060002BF RID: 703 RVA: 0x00002FC3 File Offset: 0x000011C3
		public unsafe float upperDeadZone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputControlMapping.NativeFieldInfoPtr_upperDeadZone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputControlMapping.NativeFieldInfoPtr_upperDeadZone)) = value;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x00011CC0 File Offset: 0x0000FEC0
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x00002FDE File Offset: 0x000011DE
		public unsafe InputControlSource source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputControlMapping.NativeFieldInfoPtr_source);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputControlMapping.NativeFieldInfoPtr_source)) = value;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x00011CE8 File Offset: 0x0000FEE8
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x00002FF9 File Offset: 0x000011F9
		public unsafe InputControlType target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputControlMapping.NativeFieldInfoPtr_target);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputControlMapping.NativeFieldInfoPtr_target)) = value;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x00011D10 File Offset: 0x0000FF10
		// (set) Token: 0x060002C5 RID: 709 RVA: 0x00003014 File Offset: 0x00001214
		public unsafe InputRangeType sourceRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputControlMapping.NativeFieldInfoPtr_sourceRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputControlMapping.NativeFieldInfoPtr_sourceRange)) = value;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x00011D38 File Offset: 0x0000FF38
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x0000302F File Offset: 0x0000122F
		public unsafe InputRangeType targetRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputControlMapping.NativeFieldInfoPtr_targetRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputControlMapping.NativeFieldInfoPtr_targetRange)) = value;
			}
		}

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeFieldInfoPtr_invert;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeFieldInfoPtr_scale;

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeFieldInfoPtr_raw;

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeFieldInfoPtr_passive;

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeFieldInfoPtr_ignoreInitialZeroValue;

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeFieldInfoPtr_sensitivity;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeFieldInfoPtr_lowerDeadZone;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeFieldInfoPtr_upperDeadZone;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeFieldInfoPtr_target;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeFieldInfoPtr_sourceRange;

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeFieldInfoPtr_targetRange;

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeMethodInfoPtr_get_Invert_Public_get_Boolean_0;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeMethodInfoPtr_set_Invert_Public_set_Void_Boolean_0;

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeMethodInfoPtr_get_Scale_Public_get_Single_0;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeMethodInfoPtr_set_Scale_Public_set_Void_Single_0;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeMethodInfoPtr_get_Raw_Public_get_Boolean_0;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeMethodInfoPtr_set_Raw_Public_set_Void_Boolean_0;

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeMethodInfoPtr_get_Passive_Public_get_Boolean_0;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeMethodInfoPtr_set_Passive_Public_set_Void_Boolean_0;

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreInitialZeroValue_Public_get_Boolean_0;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeMethodInfoPtr_set_IgnoreInitialZeroValue_Public_set_Void_Boolean_0;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeMethodInfoPtr_get_Sensitivity_Public_get_Single_0;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeMethodInfoPtr_set_Sensitivity_Public_set_Void_Single_0;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeMethodInfoPtr_get_LowerDeadZone_Public_get_Single_0;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeMethodInfoPtr_set_LowerDeadZone_Public_set_Void_Single_0;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeMethodInfoPtr_get_UpperDeadZone_Public_get_Single_0;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeMethodInfoPtr_set_UpperDeadZone_Public_set_Void_Single_0;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeMethodInfoPtr_get_Source_Public_get_InputControlSource_0;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeMethodInfoPtr_set_Source_Public_set_Void_InputControlSource_0;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeMethodInfoPtr_get_Target_Public_get_InputControlType_0;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeMethodInfoPtr_set_Target_Public_set_Void_InputControlType_0;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeMethodInfoPtr_get_SourceRange_Public_get_InputRangeType_0;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeMethodInfoPtr_set_SourceRange_Public_set_Void_InputRangeType_0;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetRange_Public_get_InputRangeType_0;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetRange_Public_set_Void_InputRangeType_0;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToValue_Public_Single_Single_0;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
