using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;

namespace InControl
{
	// Token: 0x02000011 RID: 17
	public class DeviceBindingSource : BindingSource
	{
		// Token: 0x0600007D RID: 125 RVA: 0x000091DC File Offset: 0x000073DC
		// Note: this type is marked as 'beforefieldinit'.
		static DeviceBindingSource()
		{
			Il2CppClassPointerStore<DeviceBindingSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "DeviceBindingSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeviceBindingSource>.NativeClassPtr);
			DeviceBindingSource.NativeFieldInfoPtr__Control_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceBindingSource>.NativeClassPtr, "<Control>k__BackingField");
			DeviceBindingSource.NativeMethodInfoPtr_get_Control_Public_get_InputControlType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBindingSource>.NativeClassPtr, 100663367);
			DeviceBindingSource.NativeMethodInfoPtr_set_Control_Protected_set_Void_InputControlType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBindingSource>.NativeClassPtr, 100663368);
			DeviceBindingSource.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBindingSource>.NativeClassPtr, 100663369);
			DeviceBindingSource.NativeMethodInfoPtr__ctor_Public_Void_InputControlType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBindingSource>.NativeClassPtr, 100663370);
			DeviceBindingSource.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBindingSource>.NativeClassPtr, 100663371);
			DeviceBindingSource.NativeMethodInfoPtr_GetState_Public_Virtual_Boolean_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBindingSource>.NativeClassPtr, 100663372);
			DeviceBindingSource.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBindingSource>.NativeClassPtr, 100663373);
			DeviceBindingSource.NativeMethodInfoPtr_get_DeviceName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBindingSource>.NativeClassPtr, 100663374);
			DeviceBindingSource.NativeMethodInfoPtr_get_DeviceClass_Public_Virtual_get_InputDeviceClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBindingSource>.NativeClassPtr, 100663375);
			DeviceBindingSource.NativeMethodInfoPtr_get_DeviceStyle_Public_Virtual_get_InputDeviceStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBindingSource>.NativeClassPtr, 100663376);
			DeviceBindingSource.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_BindingSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBindingSource>.NativeClassPtr, 100663377);
			DeviceBindingSource.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBindingSource>.NativeClassPtr, 100663378);
			DeviceBindingSource.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBindingSource>.NativeClassPtr, 100663379);
			DeviceBindingSource.NativeMethodInfoPtr_get_BindingSourceType_Public_Virtual_get_BindingSourceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBindingSource>.NativeClassPtr, 100663380);
			DeviceBindingSource.NativeMethodInfoPtr_Save_Public_Virtual_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBindingSource>.NativeClassPtr, 100663381);
			DeviceBindingSource.NativeMethodInfoPtr_Load_Public_Virtual_Void_BinaryReader_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBindingSource>.NativeClassPtr, 100663382);
			DeviceBindingSource.NativeMethodInfoPtr_get_IsValid_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceBindingSource>.NativeClassPtr, 100663383);
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00009374 File Offset: 0x00007574
		// (set) Token: 0x0600007F RID: 127 RVA: 0x000093B0 File Offset: 0x000075B0
		public unsafe InputControlType Control
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceBindingSource.NativeMethodInfoPtr_get_Control_Public_get_InputControlType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 311421, RefRangeEnd = 311423, XrefRangeStart = 311421, XrefRangeEnd = 311423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceBindingSource.NativeMethodInfoPtr_set_Control_Protected_set_Void_InputControlType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000093F0 File Offset: 0x000075F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767583, XrefRangeEnd = 767584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeviceBindingSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeviceBindingSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceBindingSource.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000942C File Offset: 0x0000762C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 767585, RefRangeEnd = 767587, XrefRangeStart = 767584, XrefRangeEnd = 767585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeviceBindingSource(InputControlType control)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeviceBindingSource>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref control;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceBindingSource.NativeMethodInfoPtr__ctor_Public_Void_InputControlType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00009474 File Offset: 0x00007674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767587, XrefRangeEnd = 767588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float GetValue(InputDevice inputDevice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDevice);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeviceBindingSource.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_InputDevice_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000094CC File Offset: 0x000076CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767588, XrefRangeEnd = 767589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetState(InputDevice inputDevice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDevice);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeviceBindingSource.NativeMethodInfoPtr_GetState_Public_Virtual_Boolean_InputDevice_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00009524 File Offset: 0x00007724
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767589, XrefRangeEnd = 767599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeviceBindingSource.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00009568 File Offset: 0x00007768
		public unsafe override string DeviceName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767599, XrefRangeEnd = 767607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeviceBindingSource.NativeMethodInfoPtr_get_DeviceName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000086 RID: 134 RVA: 0x000095AC File Offset: 0x000077AC
		public unsafe override InputDeviceClass DeviceClass
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeviceBindingSource.NativeMethodInfoPtr_get_DeviceClass_Public_Virtual_get_InputDeviceClass_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000087 RID: 135 RVA: 0x000095F4 File Offset: 0x000077F4
		public unsafe override InputDeviceStyle DeviceStyle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeviceBindingSource.NativeMethodInfoPtr_get_DeviceStyle_Public_Virtual_get_InputDeviceStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000963C File Offset: 0x0000783C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767607, XrefRangeEnd = 767609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(BindingSource other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeviceBindingSource.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_BindingSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00009694 File Offset: 0x00007894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767609, XrefRangeEnd = 767611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeviceBindingSource.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000096EC File Offset: 0x000078EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767611, XrefRangeEnd = 767612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeviceBindingSource.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00009734 File Offset: 0x00007934
		public unsafe override BindingSourceType BindingSourceType
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeviceBindingSource.NativeMethodInfoPtr_get_BindingSourceType_Public_Virtual_get_BindingSourceType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000977C File Offset: 0x0000797C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767612, XrefRangeEnd = 767613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Save(BinaryWriter writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeviceBindingSource.NativeMethodInfoPtr_Save_Public_Virtual_Void_BinaryWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000097CC File Offset: 0x000079CC
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeviceBindingSource.NativeMethodInfoPtr_Load_Public_Virtual_Void_BinaryReader_UInt16_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00009828 File Offset: 0x00007A28
		public unsafe override bool IsValid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767613, XrefRangeEnd = 767617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeviceBindingSource.NativeMethodInfoPtr_get_IsValid_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000022DE File Offset: 0x000004DE
		public DeviceBindingSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00009870 File Offset: 0x00007A70
		// (set) Token: 0x06000091 RID: 145 RVA: 0x000022E7 File Offset: 0x000004E7
		public unsafe InputControlType _Control_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceBindingSource.NativeFieldInfoPtr__Control_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceBindingSource.NativeFieldInfoPtr__Control_k__BackingField)) = value;
			}
		}

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeFieldInfoPtr__Control_k__BackingField;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_get_Control_Public_get_InputControlType_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_set_Control_Protected_set_Void_InputControlType_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_InputControlType_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Single_InputDevice_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_GetState_Public_Virtual_Boolean_InputDevice_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_get_DeviceName_Public_Virtual_get_String_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_get_DeviceClass_Public_Virtual_get_InputDeviceClass_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_get_DeviceStyle_Public_Virtual_get_InputDeviceStyle_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_BindingSource_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_get_BindingSourceType_Public_Virtual_get_BindingSourceType_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Virtual_Void_BinaryWriter_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_BinaryReader_UInt16_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Internal_Virtual_get_Boolean_0;
	}
}
