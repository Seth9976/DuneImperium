using System;
using dwd.core.input.compositeModule;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace validators
{
	// Token: 0x0200000F RID: 15
	public class InputModuleValidator : VersionedView<CurrentInputModuleType>
	{
		// Token: 0x0600005B RID: 91 RVA: 0x00003974 File Offset: 0x00001B74
		// Note: this type is marked as 'beforefieldinit'.
		static InputModuleValidator()
		{
			Il2CppClassPointerStore<InputModuleValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("validators.dll", "validators", "InputModuleValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputModuleValidator>.NativeClassPtr);
			InputModuleValidator.NativeFieldInfoPtr_inputModuleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputModuleValidator>.NativeClassPtr, "inputModuleType");
			InputModuleValidator.NativeFieldInfoPtr__Valid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputModuleValidator>.NativeClassPtr, "<Valid>k__BackingField");
			InputModuleValidator.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputModuleValidator>.NativeClassPtr, 100663334);
			InputModuleValidator.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputModuleValidator>.NativeClassPtr, 100663335);
			InputModuleValidator.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputModuleValidator>.NativeClassPtr, 100663336);
			InputModuleValidator.NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputModuleValidator>.NativeClassPtr, 100663337);
			InputModuleValidator.NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputModuleValidator>.NativeClassPtr, 100663338);
			InputModuleValidator.NativeMethodInfoPtr_GetModel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputModuleValidator>.NativeClassPtr, 100663339);
			InputModuleValidator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputModuleValidator>.NativeClassPtr, 100663340);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00003A58 File Offset: 0x00001C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267598, XrefRangeEnd = 1267607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputModuleValidator.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00003A8C File Offset: 0x00001C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267607, XrefRangeEnd = 1267615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputModuleValidator.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00003AC8 File Offset: 0x00001CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267615, XrefRangeEnd = 1267616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputModuleValidator.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00003B04 File Offset: 0x00001D04
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00003B40 File Offset: 0x00001D40
		public unsafe virtual bool Valid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputModuleValidator.NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputModuleValidator.NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003B80 File Offset: 0x00001D80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1267626, RefRangeEnd = 1267628, XrefRangeStart = 1267616, XrefRangeEnd = 1267626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetModel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputModuleValidator.NativeMethodInfoPtr_GetModel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00003BB4 File Offset: 0x00001DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267628, XrefRangeEnd = 1267635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputModuleValidator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputModuleValidator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputModuleValidator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000022E0 File Offset: 0x000004E0
		public InputModuleValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00003BF0 File Offset: 0x00001DF0
		// (set) Token: 0x06000065 RID: 101 RVA: 0x000022E9 File Offset: 0x000004E9
		public unsafe string inputModuleType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputModuleValidator.NativeFieldInfoPtr_inputModuleType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputModuleValidator.NativeFieldInfoPtr_inputModuleType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00003C18 File Offset: 0x00001E18
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00002308 File Offset: 0x00000508
		public unsafe bool _Valid_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputModuleValidator.NativeFieldInfoPtr__Valid_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputModuleValidator.NativeFieldInfoPtr__Valid_k__BackingField)) = value;
			}
		}

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr_inputModuleType;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr__Valid_k__BackingField;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_GetModel_Private_Void_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
