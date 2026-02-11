using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace InControl
{
	// Token: 0x0200000C RID: 12
	public class BindingListenOptions : Object
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00008350 File Offset: 0x00006550
		// Note: this type is marked as 'beforefieldinit'.
		static BindingListenOptions()
		{
			Il2CppClassPointerStore<BindingListenOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "BindingListenOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingListenOptions>.NativeClassPtr);
			BindingListenOptions.NativeFieldInfoPtr_IncludeControllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingListenOptions>.NativeClassPtr, "IncludeControllers");
			BindingListenOptions.NativeFieldInfoPtr_IncludeUnknownControllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingListenOptions>.NativeClassPtr, "IncludeUnknownControllers");
			BindingListenOptions.NativeFieldInfoPtr_IncludeNonStandardControls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingListenOptions>.NativeClassPtr, "IncludeNonStandardControls");
			BindingListenOptions.NativeFieldInfoPtr_IncludeMouseButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingListenOptions>.NativeClassPtr, "IncludeMouseButtons");
			BindingListenOptions.NativeFieldInfoPtr_IncludeMouseScrollWheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingListenOptions>.NativeClassPtr, "IncludeMouseScrollWheel");
			BindingListenOptions.NativeFieldInfoPtr_IncludeKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingListenOptions>.NativeClassPtr, "IncludeKeys");
			BindingListenOptions.NativeFieldInfoPtr_IncludeModifiersAsFirstClassKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingListenOptions>.NativeClassPtr, "IncludeModifiersAsFirstClassKeys");
			BindingListenOptions.NativeFieldInfoPtr_MaxAllowedBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingListenOptions>.NativeClassPtr, "MaxAllowedBindings");
			BindingListenOptions.NativeFieldInfoPtr_MaxAllowedBindingsPerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingListenOptions>.NativeClassPtr, "MaxAllowedBindingsPerType");
			BindingListenOptions.NativeFieldInfoPtr_AllowDuplicateBindingsPerSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingListenOptions>.NativeClassPtr, "AllowDuplicateBindingsPerSet");
			BindingListenOptions.NativeFieldInfoPtr_UnsetDuplicateBindingsOnSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingListenOptions>.NativeClassPtr, "UnsetDuplicateBindingsOnSet");
			BindingListenOptions.NativeFieldInfoPtr_RejectRedundantBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingListenOptions>.NativeClassPtr, "RejectRedundantBindings");
			BindingListenOptions.NativeFieldInfoPtr_ReplaceBinding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingListenOptions>.NativeClassPtr, "ReplaceBinding");
			BindingListenOptions.NativeFieldInfoPtr_OnBindingFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingListenOptions>.NativeClassPtr, "OnBindingFound");
			BindingListenOptions.NativeFieldInfoPtr_OnBindingAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingListenOptions>.NativeClassPtr, "OnBindingAdded");
			BindingListenOptions.NativeFieldInfoPtr_OnBindingRejected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingListenOptions>.NativeClassPtr, "OnBindingRejected");
			BindingListenOptions.NativeFieldInfoPtr_OnBindingEnded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingListenOptions>.NativeClassPtr, "OnBindingEnded");
			BindingListenOptions.NativeMethodInfoPtr_CallOnBindingFound_Public_Boolean_PlayerAction_BindingSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingListenOptions>.NativeClassPtr, 100663342);
			BindingListenOptions.NativeMethodInfoPtr_CallOnBindingAdded_Public_Void_PlayerAction_BindingSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingListenOptions>.NativeClassPtr, 100663343);
			BindingListenOptions.NativeMethodInfoPtr_CallOnBindingRejected_Public_Void_PlayerAction_BindingSource_BindingSourceRejectionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingListenOptions>.NativeClassPtr, 100663344);
			BindingListenOptions.NativeMethodInfoPtr_CallOnBindingEnded_Public_Void_PlayerAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingListenOptions>.NativeClassPtr, 100663345);
			BindingListenOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingListenOptions>.NativeClassPtr, 100663346);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00008538 File Offset: 0x00006738
		[CallerCount(0)]
		public unsafe bool CallOnBindingFound(PlayerAction playerAction, BindingSource bindingSource)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerAction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bindingSource);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingListenOptions.NativeMethodInfoPtr_CallOnBindingFound_Public_Boolean_PlayerAction_BindingSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00008598 File Offset: 0x00006798
		[CallerCount(0)]
		public unsafe void CallOnBindingAdded(PlayerAction playerAction, BindingSource bindingSource)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerAction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bindingSource);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingListenOptions.NativeMethodInfoPtr_CallOnBindingAdded_Public_Void_PlayerAction_BindingSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000085EC File Offset: 0x000067EC
		[CallerCount(0)]
		public unsafe void CallOnBindingRejected(PlayerAction playerAction, BindingSource bindingSource, BindingSourceRejectionType bindingSourceRejectionType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerAction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bindingSource);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingSourceRejectionType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingListenOptions.NativeMethodInfoPtr_CallOnBindingRejected_Public_Void_PlayerAction_BindingSource_BindingSourceRejectionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00008650 File Offset: 0x00006850
		[CallerCount(0)]
		public unsafe void CallOnBindingEnded(PlayerAction playerAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingListenOptions.NativeMethodInfoPtr_CallOnBindingEnded_Public_Void_PlayerAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00008694 File Offset: 0x00006894
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 767577, RefRangeEnd = 767578, XrefRangeStart = 767576, XrefRangeEnd = 767577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BindingListenOptions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BindingListenOptions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingListenOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000020C5 File Offset: 0x000002C5
		public BindingListenOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000041 RID: 65 RVA: 0x000086D0 File Offset: 0x000068D0
		// (set) Token: 0x06000042 RID: 66 RVA: 0x000020CE File Offset: 0x000002CE
		public unsafe bool IncludeControllers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingListenOptions.NativeFieldInfoPtr_IncludeControllers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingListenOptions.NativeFieldInfoPtr_IncludeControllers)) = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000043 RID: 67 RVA: 0x000086F8 File Offset: 0x000068F8
		// (set) Token: 0x06000044 RID: 68 RVA: 0x000020E9 File Offset: 0x000002E9
		public unsafe bool IncludeUnknownControllers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingListenOptions.NativeFieldInfoPtr_IncludeUnknownControllers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingListenOptions.NativeFieldInfoPtr_IncludeUnknownControllers)) = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00008720 File Offset: 0x00006920
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00002104 File Offset: 0x00000304
		public unsafe bool IncludeNonStandardControls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingListenOptions.NativeFieldInfoPtr_IncludeNonStandardControls);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingListenOptions.NativeFieldInfoPtr_IncludeNonStandardControls)) = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00008748 File Offset: 0x00006948
		// (set) Token: 0x06000048 RID: 72 RVA: 0x0000211F File Offset: 0x0000031F
		public unsafe bool IncludeMouseButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingListenOptions.NativeFieldInfoPtr_IncludeMouseButtons);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingListenOptions.NativeFieldInfoPtr_IncludeMouseButtons)) = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00008770 File Offset: 0x00006970
		// (set) Token: 0x0600004A RID: 74 RVA: 0x0000213A File Offset: 0x0000033A
		public unsafe bool IncludeMouseScrollWheel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingListenOptions.NativeFieldInfoPtr_IncludeMouseScrollWheel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingListenOptions.NativeFieldInfoPtr_IncludeMouseScrollWheel)) = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00008798 File Offset: 0x00006998
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00002155 File Offset: 0x00000355
		public unsafe bool IncludeKeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingListenOptions.NativeFieldInfoPtr_IncludeKeys);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingListenOptions.NativeFieldInfoPtr_IncludeKeys)) = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600004D RID: 77 RVA: 0x000087C0 File Offset: 0x000069C0
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00002170 File Offset: 0x00000370
		public unsafe bool IncludeModifiersAsFirstClassKeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingListenOptions.NativeFieldInfoPtr_IncludeModifiersAsFirstClassKeys);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingListenOptions.NativeFieldInfoPtr_IncludeModifiersAsFirstClassKeys)) = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600004F RID: 79 RVA: 0x000087E8 File Offset: 0x000069E8
		// (set) Token: 0x06000050 RID: 80 RVA: 0x0000218B File Offset: 0x0000038B
		public unsafe uint MaxAllowedBindings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingListenOptions.NativeFieldInfoPtr_MaxAllowedBindings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingListenOptions.NativeFieldInfoPtr_MaxAllowedBindings)) = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00008810 File Offset: 0x00006A10
		// (set) Token: 0x06000052 RID: 82 RVA: 0x000021A6 File Offset: 0x000003A6
		public unsafe uint MaxAllowedBindingsPerType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingListenOptions.NativeFieldInfoPtr_MaxAllowedBindingsPerType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingListenOptions.NativeFieldInfoPtr_MaxAllowedBindingsPerType)) = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00008838 File Offset: 0x00006A38
		// (set) Token: 0x06000054 RID: 84 RVA: 0x000021C1 File Offset: 0x000003C1
		public unsafe bool AllowDuplicateBindingsPerSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingListenOptions.NativeFieldInfoPtr_AllowDuplicateBindingsPerSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingListenOptions.NativeFieldInfoPtr_AllowDuplicateBindingsPerSet)) = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00008860 File Offset: 0x00006A60
		// (set) Token: 0x06000056 RID: 86 RVA: 0x000021DC File Offset: 0x000003DC
		public unsafe bool UnsetDuplicateBindingsOnSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingListenOptions.NativeFieldInfoPtr_UnsetDuplicateBindingsOnSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingListenOptions.NativeFieldInfoPtr_UnsetDuplicateBindingsOnSet)) = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00008888 File Offset: 0x00006A88
		// (set) Token: 0x06000058 RID: 88 RVA: 0x000021F7 File Offset: 0x000003F7
		public unsafe bool RejectRedundantBindings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingListenOptions.NativeFieldInfoPtr_RejectRedundantBindings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingListenOptions.NativeFieldInfoPtr_RejectRedundantBindings)) = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000059 RID: 89 RVA: 0x000088B0 File Offset: 0x00006AB0
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00002212 File Offset: 0x00000412
		public unsafe BindingSource ReplaceBinding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingListenOptions.NativeFieldInfoPtr_ReplaceBinding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BindingSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingListenOptions.NativeFieldInfoPtr_ReplaceBinding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600005B RID: 91 RVA: 0x000088E0 File Offset: 0x00006AE0
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00002231 File Offset: 0x00000431
		public unsafe Func<PlayerAction, BindingSource, bool> OnBindingFound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingListenOptions.NativeFieldInfoPtr_OnBindingFound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerAction, BindingSource, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingListenOptions.NativeFieldInfoPtr_OnBindingFound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00008910 File Offset: 0x00006B10
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00002250 File Offset: 0x00000450
		public unsafe Action<PlayerAction, BindingSource> OnBindingAdded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingListenOptions.NativeFieldInfoPtr_OnBindingAdded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PlayerAction, BindingSource>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingListenOptions.NativeFieldInfoPtr_OnBindingAdded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00008940 File Offset: 0x00006B40
		// (set) Token: 0x06000060 RID: 96 RVA: 0x0000226F File Offset: 0x0000046F
		public unsafe Action<PlayerAction, BindingSource, BindingSourceRejectionType> OnBindingRejected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingListenOptions.NativeFieldInfoPtr_OnBindingRejected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PlayerAction, BindingSource, BindingSourceRejectionType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingListenOptions.NativeFieldInfoPtr_OnBindingRejected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00008970 File Offset: 0x00006B70
		// (set) Token: 0x06000062 RID: 98 RVA: 0x0000228E File Offset: 0x0000048E
		public unsafe Action<PlayerAction> OnBindingEnded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingListenOptions.NativeFieldInfoPtr_OnBindingEnded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PlayerAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingListenOptions.NativeFieldInfoPtr_OnBindingEnded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeFieldInfoPtr_IncludeControllers;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeFieldInfoPtr_IncludeUnknownControllers;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeFieldInfoPtr_IncludeNonStandardControls;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeFieldInfoPtr_IncludeMouseButtons;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeFieldInfoPtr_IncludeMouseScrollWheel;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeFieldInfoPtr_IncludeKeys;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeFieldInfoPtr_IncludeModifiersAsFirstClassKeys;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeFieldInfoPtr_MaxAllowedBindings;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeFieldInfoPtr_MaxAllowedBindingsPerType;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeFieldInfoPtr_AllowDuplicateBindingsPerSet;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeFieldInfoPtr_UnsetDuplicateBindingsOnSet;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr_RejectRedundantBindings;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeFieldInfoPtr_ReplaceBinding;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeFieldInfoPtr_OnBindingFound;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeFieldInfoPtr_OnBindingAdded;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeFieldInfoPtr_OnBindingRejected;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeFieldInfoPtr_OnBindingEnded;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_CallOnBindingFound_Public_Boolean_PlayerAction_BindingSource_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_CallOnBindingAdded_Public_Void_PlayerAction_BindingSource_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_CallOnBindingRejected_Public_Void_PlayerAction_BindingSource_BindingSourceRejectionType_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_CallOnBindingEnded_Public_Void_PlayerAction_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
