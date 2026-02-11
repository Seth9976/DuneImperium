using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.IO
{
	// Token: 0x0200017A RID: 378
	public sealed class WaitForChangedResult : ValueType
	{
		// Token: 0x06001713 RID: 5907 RVA: 0x00076B30 File Offset: 0x00074D30
		// Note: this type is marked as 'beforefieldinit'.
		static WaitForChangedResult()
		{
			Il2CppClassPointerStore<WaitForChangedResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.IO", "WaitForChangedResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForChangedResult>.NativeClassPtr);
			WaitForChangedResult.NativeFieldInfoPtr_TimedOutResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForChangedResult>.NativeClassPtr, "TimedOutResult");
			WaitForChangedResult.NativeFieldInfoPtr__ChangeType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForChangedResult>.NativeClassPtr, "<ChangeType>k__BackingField");
			WaitForChangedResult.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForChangedResult>.NativeClassPtr, "<Name>k__BackingField");
			WaitForChangedResult.NativeFieldInfoPtr__OldName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForChangedResult>.NativeClassPtr, "<OldName>k__BackingField");
			WaitForChangedResult.NativeFieldInfoPtr__TimedOut_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForChangedResult>.NativeClassPtr, "<TimedOut>k__BackingField");
			WaitForChangedResult.NativeMethodInfoPtr__ctor_Internal_Void_WatcherChangeTypes_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForChangedResult>.NativeClassPtr, 100666965);
			WaitForChangedResult.NativeMethodInfoPtr_set_ChangeType_Public_set_Void_WatcherChangeTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForChangedResult>.NativeClassPtr, 100666966);
			WaitForChangedResult.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForChangedResult>.NativeClassPtr, 100666967);
			WaitForChangedResult.NativeMethodInfoPtr_set_OldName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForChangedResult>.NativeClassPtr, 100666968);
			WaitForChangedResult.NativeMethodInfoPtr_set_TimedOut_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForChangedResult>.NativeClassPtr, 100666969);
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x00076C28 File Offset: 0x00074E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 469333, XrefRangeEnd = 469338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitForChangedResult(WatcherChangeTypes changeType, string name, string oldName, bool timedOut)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForChangedResult>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref changeType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(oldName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timedOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForChangedResult.NativeMethodInfoPtr__ctor_Internal_Void_WatcherChangeTypes_String_String_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006CF RID: 1743
		// (set) Token: 0x06001715 RID: 5909 RVA: 0x00076CA8 File Offset: 0x00074EA8
		public unsafe WatcherChangeTypes ChangeType
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 320163, RefRangeEnd = 320170, XrefRangeStart = 320163, XrefRangeEnd = 320170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForChangedResult.NativeMethodInfoPtr_set_ChangeType_Public_set_Void_WatcherChangeTypes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (set) Token: 0x06001716 RID: 5910 RVA: 0x00076CEC File Offset: 0x00074EEC
		public unsafe string Name
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 315685, RefRangeEnd = 315686, XrefRangeStart = 315685, XrefRangeEnd = 315686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForChangedResult.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (set) Token: 0x06001717 RID: 5911 RVA: 0x00076D34 File Offset: 0x00074F34
		public unsafe string OldName
		{
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForChangedResult.NativeMethodInfoPtr_set_OldName_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (set) Token: 0x06001718 RID: 5912 RVA: 0x00076D7C File Offset: 0x00074F7C
		public unsafe bool TimedOut
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForChangedResult.NativeMethodInfoPtr_set_TimedOut_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001719 RID: 5913 RVA: 0x00009F17 File Offset: 0x00008117
		public WaitForChangedResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x00009F20 File Offset: 0x00008120
		public WaitForChangedResult()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForChangedResult>.NativeClassPtr))
		{
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x0600171B RID: 5915 RVA: 0x00076DC0 File Offset: 0x00074FC0
		// (set) Token: 0x0600171C RID: 5916 RVA: 0x00009F32 File Offset: 0x00008132
		public unsafe static WaitForChangedResult TimedOutResult
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WaitForChangedResult>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(WaitForChangedResult.NativeFieldInfoPtr_TimedOutResult, intPtr);
				return new WaitForChangedResult(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WaitForChangedResult>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WaitForChangedResult.NativeFieldInfoPtr_TimedOutResult, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x0600171D RID: 5917 RVA: 0x00076DFC File Offset: 0x00074FFC
		// (set) Token: 0x0600171E RID: 5918 RVA: 0x00009F49 File Offset: 0x00008149
		public unsafe WatcherChangeTypes _ChangeType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForChangedResult.NativeFieldInfoPtr__ChangeType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForChangedResult.NativeFieldInfoPtr__ChangeType_k__BackingField)) = value;
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x0600171F RID: 5919 RVA: 0x00076E24 File Offset: 0x00075024
		// (set) Token: 0x06001720 RID: 5920 RVA: 0x00009F64 File Offset: 0x00008164
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForChangedResult.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForChangedResult.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06001721 RID: 5921 RVA: 0x00076E4C File Offset: 0x0007504C
		// (set) Token: 0x06001722 RID: 5922 RVA: 0x00009F83 File Offset: 0x00008183
		public unsafe string _OldName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForChangedResult.NativeFieldInfoPtr__OldName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForChangedResult.NativeFieldInfoPtr__OldName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06001723 RID: 5923 RVA: 0x00076E74 File Offset: 0x00075074
		// (set) Token: 0x06001724 RID: 5924 RVA: 0x00009FA2 File Offset: 0x000081A2
		public unsafe bool _TimedOut_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForChangedResult.NativeFieldInfoPtr__TimedOut_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForChangedResult.NativeFieldInfoPtr__TimedOut_k__BackingField)) = value;
			}
		}

		// Token: 0x040011FE RID: 4606
		private static readonly IntPtr NativeFieldInfoPtr_TimedOutResult;

		// Token: 0x040011FF RID: 4607
		private static readonly IntPtr NativeFieldInfoPtr__ChangeType_k__BackingField;

		// Token: 0x04001200 RID: 4608
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04001201 RID: 4609
		private static readonly IntPtr NativeFieldInfoPtr__OldName_k__BackingField;

		// Token: 0x04001202 RID: 4610
		private static readonly IntPtr NativeFieldInfoPtr__TimedOut_k__BackingField;

		// Token: 0x04001203 RID: 4611
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_WatcherChangeTypes_String_String_Boolean_0;

		// Token: 0x04001204 RID: 4612
		private static readonly IntPtr NativeMethodInfoPtr_set_ChangeType_Public_set_Void_WatcherChangeTypes_0;

		// Token: 0x04001205 RID: 4613
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x04001206 RID: 4614
		private static readonly IntPtr NativeMethodInfoPtr_set_OldName_Public_set_Void_String_0;

		// Token: 0x04001207 RID: 4615
		private static readonly IntPtr NativeMethodInfoPtr_set_TimedOut_Public_set_Void_Boolean_0;
	}
}
