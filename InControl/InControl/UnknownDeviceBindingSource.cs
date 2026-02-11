using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;

namespace InControl
{
	// Token: 0x0200001E RID: 30
	public class UnknownDeviceBindingSource : BindingSource
	{
		// Token: 0x060001FA RID: 506 RVA: 0x0000EF08 File Offset: 0x0000D108
		// Note: this type is marked as 'beforefieldinit'.
		static UnknownDeviceBindingSource()
		{
			Il2CppClassPointerStore<UnknownDeviceBindingSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "UnknownDeviceBindingSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnknownDeviceBindingSource>.NativeClassPtr);
			UnknownDeviceBindingSource.NativeFieldInfoPtr__Control_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnknownDeviceBindingSource>.NativeClassPtr, "<Control>k__BackingField");
			UnknownDeviceBindingSource.NativeMethodInfoPtr_get_Control_Public_get_UnknownDeviceControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownDeviceBindingSource>.NativeClassPtr, 100663580);
			UnknownDeviceBindingSource.NativeMethodInfoPtr_set_Control_Protected_set_Void_UnknownDeviceControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownDeviceBindingSource>.NativeClassPtr, 100663581);
			UnknownDeviceBindingSource.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownDeviceBindingSource>.NativeClassPtr, 100663582);
			UnknownDeviceBindingSource.NativeMethodInfoPtr__ctor_Public_Void_UnknownDeviceControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownDeviceBindingSource>.NativeClassPtr, 100663583);
			UnknownDeviceBindingSource.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownDeviceBindingSource>.NativeClassPtr, 100663584);
			UnknownDeviceBindingSource.NativeMethodInfoPtr_GetState_Public_Virtual_Boolean_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownDeviceBindingSource>.NativeClassPtr, 100663585);
			UnknownDeviceBindingSource.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownDeviceBindingSource>.NativeClassPtr, 100663586);
			UnknownDeviceBindingSource.NativeMethodInfoPtr_get_DeviceName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownDeviceBindingSource>.NativeClassPtr, 100663587);
			UnknownDeviceBindingSource.NativeMethodInfoPtr_get_DeviceClass_Public_Virtual_get_InputDeviceClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownDeviceBindingSource>.NativeClassPtr, 100663588);
			UnknownDeviceBindingSource.NativeMethodInfoPtr_get_DeviceStyle_Public_Virtual_get_InputDeviceStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownDeviceBindingSource>.NativeClassPtr, 100663589);
			UnknownDeviceBindingSource.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_BindingSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownDeviceBindingSource>.NativeClassPtr, 100663590);
			UnknownDeviceBindingSource.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownDeviceBindingSource>.NativeClassPtr, 100663591);
			UnknownDeviceBindingSource.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownDeviceBindingSource>.NativeClassPtr, 100663592);
			UnknownDeviceBindingSource.NativeMethodInfoPtr_get_BindingSourceType_Public_Virtual_get_BindingSourceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownDeviceBindingSource>.NativeClassPtr, 100663593);
			UnknownDeviceBindingSource.NativeMethodInfoPtr_get_IsValid_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownDeviceBindingSource>.NativeClassPtr, 100663594);
			UnknownDeviceBindingSource.NativeMethodInfoPtr_Load_Public_Virtual_Void_BinaryReader_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownDeviceBindingSource>.NativeClassPtr, 100663595);
			UnknownDeviceBindingSource.NativeMethodInfoPtr_Save_Public_Virtual_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownDeviceBindingSource>.NativeClassPtr, 100663596);
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060001FB RID: 507 RVA: 0x0000F0A0 File Offset: 0x0000D2A0
		// (set) Token: 0x060001FC RID: 508 RVA: 0x0000F0DC File Offset: 0x0000D2DC
		public unsafe UnknownDeviceControl Control
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownDeviceBindingSource.NativeMethodInfoPtr_get_Control_Public_get_UnknownDeviceControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownDeviceBindingSource.NativeMethodInfoPtr_set_Control_Protected_set_Void_UnknownDeviceControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000F11C File Offset: 0x0000D31C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 768928, RefRangeEnd = 768929, XrefRangeStart = 768923, XrefRangeEnd = 768928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnknownDeviceBindingSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnknownDeviceBindingSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownDeviceBindingSource.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000F158 File Offset: 0x0000D358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768929, XrefRangeEnd = 768930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnknownDeviceBindingSource(UnknownDeviceControl control)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnknownDeviceBindingSource>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref control;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownDeviceBindingSource.NativeMethodInfoPtr__ctor_Public_Void_UnknownDeviceControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000F1A0 File Offset: 0x0000D3A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768930, XrefRangeEnd = 768939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float GetValue(InputDevice device)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(device);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnknownDeviceBindingSource.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_InputDevice_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000F1F8 File Offset: 0x0000D3F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768939, XrefRangeEnd = 768943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetState(InputDevice device)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(device);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnknownDeviceBindingSource.NativeMethodInfoPtr_GetState_Public_Virtual_Boolean_InputDevice_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000201 RID: 513 RVA: 0x0000F250 File Offset: 0x0000D450
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768943, XrefRangeEnd = 768963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnknownDeviceBindingSource.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000202 RID: 514 RVA: 0x0000F294 File Offset: 0x0000D494
		public unsafe override string DeviceName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768963, XrefRangeEnd = 768971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnknownDeviceBindingSource.NativeMethodInfoPtr_get_DeviceName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000203 RID: 515 RVA: 0x0000F2D8 File Offset: 0x0000D4D8
		public unsafe override InputDeviceClass DeviceClass
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 25008, RefRangeEnd = 25013, XrefRangeStart = 25008, XrefRangeEnd = 25013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnknownDeviceBindingSource.NativeMethodInfoPtr_get_DeviceClass_Public_Virtual_get_InputDeviceClass_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000204 RID: 516 RVA: 0x0000F320 File Offset: 0x0000D520
		public unsafe override InputDeviceStyle DeviceStyle
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnknownDeviceBindingSource.NativeMethodInfoPtr_get_DeviceStyle_Public_Virtual_get_InputDeviceStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000F368 File Offset: 0x0000D568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768971, XrefRangeEnd = 768979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(BindingSource other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnknownDeviceBindingSource.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_BindingSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000F3C0 File Offset: 0x0000D5C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768979, XrefRangeEnd = 768987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnknownDeviceBindingSource.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000F418 File Offset: 0x0000D618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768987, XrefRangeEnd = 768992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnknownDeviceBindingSource.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000208 RID: 520 RVA: 0x0000F460 File Offset: 0x0000D660
		public unsafe override BindingSourceType BindingSourceType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnknownDeviceBindingSource.NativeMethodInfoPtr_get_BindingSourceType_Public_Virtual_get_BindingSourceType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000209 RID: 521 RVA: 0x0000F4A8 File Offset: 0x0000D6A8
		public unsafe override bool IsValid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768992, XrefRangeEnd = 768999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnknownDeviceBindingSource.NativeMethodInfoPtr_get_IsValid_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000F4F0 File Offset: 0x0000D6F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768999, XrefRangeEnd = 769006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(BinaryReader reader, ushort dataFormatVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataFormatVersion;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnknownDeviceBindingSource.NativeMethodInfoPtr_Load_Public_Virtual_Void_BinaryReader_UInt16_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0000F54C File Offset: 0x0000D74C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769006, XrefRangeEnd = 769010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Save(BinaryWriter writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnknownDeviceBindingSource.NativeMethodInfoPtr_Save_Public_Virtual_Void_BinaryWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00002B4E File Offset: 0x00000D4E
		public UnknownDeviceBindingSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600020D RID: 525 RVA: 0x0000F59C File Offset: 0x0000D79C
		// (set) Token: 0x0600020E RID: 526 RVA: 0x00002B57 File Offset: 0x00000D57
		public unsafe UnknownDeviceControl _Control_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnknownDeviceBindingSource.NativeFieldInfoPtr__Control_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnknownDeviceBindingSource.NativeFieldInfoPtr__Control_k__BackingField)) = value;
			}
		}

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeFieldInfoPtr__Control_k__BackingField;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeMethodInfoPtr_get_Control_Public_get_UnknownDeviceControl_0;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeMethodInfoPtr_set_Control_Protected_set_Void_UnknownDeviceControl_0;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UnknownDeviceControl_0;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Single_InputDevice_0;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeMethodInfoPtr_GetState_Public_Virtual_Boolean_InputDevice_0;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeMethodInfoPtr_get_DeviceName_Public_Virtual_get_String_0;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeMethodInfoPtr_get_DeviceClass_Public_Virtual_get_InputDeviceClass_0;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeMethodInfoPtr_get_DeviceStyle_Public_Virtual_get_InputDeviceStyle_0;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_BindingSource_0;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeMethodInfoPtr_get_BindingSourceType_Public_Virtual_get_BindingSourceType_0;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Internal_Virtual_get_Boolean_0;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_BinaryReader_UInt16_0;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Virtual_Void_BinaryWriter_0;
	}
}
