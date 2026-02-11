using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.EventSystems;

namespace dwd.core.input.compositeModule
{
	// Token: 0x02000085 RID: 133
	public class CurrentInputModuleType : UIBehaviour
	{
		// Token: 0x060005CA RID: 1482 RVA: 0x0001933C File Offset: 0x0001753C
		// Note: this type is marked as 'beforefieldinit'.
		static CurrentInputModuleType()
		{
			Il2CppClassPointerStore<CurrentInputModuleType>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.compositeModule", "CurrentInputModuleType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurrentInputModuleType>.NativeClassPtr);
			CurrentInputModuleType.NativeFieldInfoPtr__Version_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurrentInputModuleType>.NativeClassPtr, "<Version>k__BackingField");
			CurrentInputModuleType.NativeFieldInfoPtr__CurrentType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurrentInputModuleType>.NativeClassPtr, "<CurrentType>k__BackingField");
			CurrentInputModuleType.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurrentInputModuleType>.NativeClassPtr, 100664012);
			CurrentInputModuleType.NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurrentInputModuleType>.NativeClassPtr, 100664013);
			CurrentInputModuleType.NativeMethodInfoPtr_get_CurrentType_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurrentInputModuleType>.NativeClassPtr, 100664014);
			CurrentInputModuleType.NativeMethodInfoPtr_set_CurrentType_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurrentInputModuleType>.NativeClassPtr, 100664015);
			CurrentInputModuleType.NativeMethodInfoPtr_get_IsGamepad_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurrentInputModuleType>.NativeClassPtr, 100664016);
			CurrentInputModuleType.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurrentInputModuleType>.NativeClassPtr, 100664017);
			CurrentInputModuleType.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurrentInputModuleType>.NativeClassPtr, 100664018);
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x00019420 File Offset: 0x00017620
		// (set) Token: 0x060005CC RID: 1484 RVA: 0x0001945C File Offset: 0x0001765C
		public unsafe virtual ulong Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurrentInputModuleType.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurrentInputModuleType.NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x0001949C File Offset: 0x0001769C
		// (set) Token: 0x060005CE RID: 1486 RVA: 0x000194D4 File Offset: 0x000176D4
		public unsafe string CurrentType
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurrentInputModuleType.NativeMethodInfoPtr_get_CurrentType_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurrentInputModuleType.NativeMethodInfoPtr_set_CurrentType_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x00019518 File Offset: 0x00017718
		public unsafe bool IsGamepad
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1124869, RefRangeEnd = 1124875, XrefRangeStart = 1124866, XrefRangeEnd = 1124869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurrentInputModuleType.NativeMethodInfoPtr_get_IsGamepad_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00019554 File Offset: 0x00017754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124875, XrefRangeEnd = 1124886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurrentInputModuleType.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00019588 File Offset: 0x00017788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124886, XrefRangeEnd = 1124890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CurrentInputModuleType()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CurrentInputModuleType>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurrentInputModuleType.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00005301 File Offset: 0x00003501
		public CurrentInputModuleType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x000195C4 File Offset: 0x000177C4
		// (set) Token: 0x060005D4 RID: 1492 RVA: 0x0000530A File Offset: 0x0000350A
		public unsafe ulong _Version_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurrentInputModuleType.NativeFieldInfoPtr__Version_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurrentInputModuleType.NativeFieldInfoPtr__Version_k__BackingField)) = value;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060005D5 RID: 1493 RVA: 0x000195EC File Offset: 0x000177EC
		// (set) Token: 0x060005D6 RID: 1494 RVA: 0x00005325 File Offset: 0x00003525
		public unsafe string _CurrentType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurrentInputModuleType.NativeFieldInfoPtr__CurrentType_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurrentInputModuleType.NativeFieldInfoPtr__CurrentType_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeFieldInfoPtr__Version_k__BackingField;

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeFieldInfoPtr__CurrentType_k__BackingField;

		// Token: 0x04000383 RID: 899
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x04000384 RID: 900
		private static readonly IntPtr NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0;

		// Token: 0x04000385 RID: 901
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentType_Public_get_String_0;

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentType_Private_set_Void_String_0;

		// Token: 0x04000387 RID: 903
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGamepad_Public_get_Boolean_0;

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
