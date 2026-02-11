using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.IO;

namespace InControl
{
	// Token: 0x02000014 RID: 20
	public class KeyBindingSource : BindingSource
	{
		// Token: 0x0600009E RID: 158 RVA: 0x00009B98 File Offset: 0x00007D98
		// Note: this type is marked as 'beforefieldinit'.
		static KeyBindingSource()
		{
			Il2CppClassPointerStore<KeyBindingSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "KeyBindingSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyBindingSource>.NativeClassPtr);
			KeyBindingSource.NativeFieldInfoPtr__Control_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyBindingSource>.NativeClassPtr, "<Control>k__BackingField");
			KeyBindingSource.NativeMethodInfoPtr_get_Control_Public_get_KeyCombo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyBindingSource>.NativeClassPtr, 100663390);
			KeyBindingSource.NativeMethodInfoPtr_set_Control_Protected_set_Void_KeyCombo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyBindingSource>.NativeClassPtr, 100663391);
			KeyBindingSource.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyBindingSource>.NativeClassPtr, 100663392);
			KeyBindingSource.NativeMethodInfoPtr__ctor_Public_Void_KeyCombo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyBindingSource>.NativeClassPtr, 100663393);
			KeyBindingSource.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Key_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyBindingSource>.NativeClassPtr, 100663394);
			KeyBindingSource.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyBindingSource>.NativeClassPtr, 100663395);
			KeyBindingSource.NativeMethodInfoPtr_GetState_Public_Virtual_Boolean_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyBindingSource>.NativeClassPtr, 100663396);
			KeyBindingSource.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyBindingSource>.NativeClassPtr, 100663397);
			KeyBindingSource.NativeMethodInfoPtr_get_DeviceName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyBindingSource>.NativeClassPtr, 100663398);
			KeyBindingSource.NativeMethodInfoPtr_get_DeviceClass_Public_Virtual_get_InputDeviceClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyBindingSource>.NativeClassPtr, 100663399);
			KeyBindingSource.NativeMethodInfoPtr_get_DeviceStyle_Public_Virtual_get_InputDeviceStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyBindingSource>.NativeClassPtr, 100663400);
			KeyBindingSource.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_BindingSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyBindingSource>.NativeClassPtr, 100663401);
			KeyBindingSource.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyBindingSource>.NativeClassPtr, 100663402);
			KeyBindingSource.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyBindingSource>.NativeClassPtr, 100663403);
			KeyBindingSource.NativeMethodInfoPtr_get_BindingSourceType_Public_Virtual_get_BindingSourceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyBindingSource>.NativeClassPtr, 100663404);
			KeyBindingSource.NativeMethodInfoPtr_Load_Public_Virtual_Void_BinaryReader_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyBindingSource>.NativeClassPtr, 100663405);
			KeyBindingSource.NativeMethodInfoPtr_Save_Public_Virtual_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyBindingSource>.NativeClassPtr, 100663406);
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00009D30 File Offset: 0x00007F30
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x00009D6C File Offset: 0x00007F6C
		public unsafe KeyCombo Control
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyBindingSource.NativeMethodInfoPtr_get_Control_Public_get_KeyCombo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyBindingSource.NativeMethodInfoPtr_set_Control_Protected_set_Void_KeyCombo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00009DAC File Offset: 0x00007FAC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyBindingSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyBindingSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyBindingSource.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00009DE8 File Offset: 0x00007FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767649, XrefRangeEnd = 767650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyBindingSource(KeyCombo keyCombo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyBindingSource>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyCombo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyBindingSource.NativeMethodInfoPtr__ctor_Public_Void_KeyCombo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00009E30 File Offset: 0x00008030
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 767652, RefRangeEnd = 767654, XrefRangeStart = 767650, XrefRangeEnd = 767652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyBindingSource([Optional] Il2CppStructArray<Key> keys)
		{
			if (keys == null)
			{
				keys = new Il2CppStructArray<Key>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyBindingSource>.NativeClassPtr));
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyBindingSource.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Key_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00009E88 File Offset: 0x00008088
		[CallerCount(0)]
		public unsafe override float GetValue(InputDevice inputDevice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDevice);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyBindingSource.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_InputDevice_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00009EE0 File Offset: 0x000080E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767654, XrefRangeEnd = 767658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetState(InputDevice inputDevice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDevice);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyBindingSource.NativeMethodInfoPtr_GetState_Public_Virtual_Boolean_InputDevice_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00009F38 File Offset: 0x00008138
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767658, XrefRangeEnd = 767662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyBindingSource.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00009F7C File Offset: 0x0000817C
		public unsafe override string DeviceName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767662, XrefRangeEnd = 767664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyBindingSource.NativeMethodInfoPtr_get_DeviceName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00009FC0 File Offset: 0x000081C0
		public unsafe override InputDeviceClass DeviceClass
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyBindingSource.NativeMethodInfoPtr_get_DeviceClass_Public_Virtual_get_InputDeviceClass_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x0000A008 File Offset: 0x00008208
		public unsafe override InputDeviceStyle DeviceStyle
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyBindingSource.NativeMethodInfoPtr_get_DeviceStyle_Public_Virtual_get_InputDeviceStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000A050 File Offset: 0x00008250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767664, XrefRangeEnd = 767669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(BindingSource other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyBindingSource.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_BindingSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000A0A8 File Offset: 0x000082A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767669, XrefRangeEnd = 767674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyBindingSource.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000A100 File Offset: 0x00008300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767674, XrefRangeEnd = 767679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyBindingSource.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000AD RID: 173 RVA: 0x0000A148 File Offset: 0x00008348
		public unsafe override BindingSourceType BindingSourceType
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyBindingSource.NativeMethodInfoPtr_get_BindingSourceType_Public_Virtual_get_BindingSourceType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000A190 File Offset: 0x00008390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767679, XrefRangeEnd = 767683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyBindingSource.NativeMethodInfoPtr_Load_Public_Virtual_Void_BinaryReader_UInt16_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000A1EC File Offset: 0x000083EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767683, XrefRangeEnd = 767687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Save(BinaryWriter writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyBindingSource.NativeMethodInfoPtr_Save_Public_Virtual_Void_BinaryWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002341 File Offset: 0x00000541
		public KeyBindingSource(params Key[] keys)
			: this(new Il2CppStructArray<Key>(keys))
		{
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000234F File Offset: 0x0000054F
		public KeyBindingSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x0000A23C File Offset: 0x0000843C
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x00002358 File Offset: 0x00000558
		public unsafe KeyCombo _Control_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyBindingSource.NativeFieldInfoPtr__Control_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyBindingSource.NativeFieldInfoPtr__Control_k__BackingField)) = value;
			}
		}

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeFieldInfoPtr__Control_k__BackingField;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr_get_Control_Public_get_KeyCombo_0;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr_set_Control_Protected_set_Void_KeyCombo_0;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_KeyCombo_0;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Key_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Single_InputDevice_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_GetState_Public_Virtual_Boolean_InputDevice_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_get_DeviceName_Public_Virtual_get_String_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_get_DeviceClass_Public_Virtual_get_InputDeviceClass_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_get_DeviceStyle_Public_Virtual_get_InputDeviceStyle_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_BindingSource_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_get_BindingSourceType_Public_Virtual_get_BindingSourceType_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_BinaryReader_UInt16_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Virtual_Void_BinaryWriter_0;
	}
}
