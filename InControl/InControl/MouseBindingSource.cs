using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;

namespace InControl
{
	// Token: 0x02000018 RID: 24
	public class MouseBindingSource : BindingSource
	{
		// Token: 0x060000E2 RID: 226 RVA: 0x0000AD50 File Offset: 0x00008F50
		// Note: this type is marked as 'beforefieldinit'.
		static MouseBindingSource()
		{
			Il2CppClassPointerStore<MouseBindingSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "MouseBindingSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseBindingSource>.NativeClassPtr);
			MouseBindingSource.NativeFieldInfoPtr__Control_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseBindingSource>.NativeClassPtr, "<Control>k__BackingField");
			MouseBindingSource.NativeFieldInfoPtr_ScaleX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseBindingSource>.NativeClassPtr, "ScaleX");
			MouseBindingSource.NativeFieldInfoPtr_ScaleY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseBindingSource>.NativeClassPtr, "ScaleY");
			MouseBindingSource.NativeFieldInfoPtr_ScaleZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseBindingSource>.NativeClassPtr, "ScaleZ");
			MouseBindingSource.NativeFieldInfoPtr_JitterThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseBindingSource>.NativeClassPtr, "JitterThreshold");
			MouseBindingSource.NativeMethodInfoPtr_get_Control_Public_get_Mouse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseBindingSource>.NativeClassPtr, 100663437);
			MouseBindingSource.NativeMethodInfoPtr_set_Control_Protected_set_Void_Mouse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseBindingSource>.NativeClassPtr, 100663438);
			MouseBindingSource.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseBindingSource>.NativeClassPtr, 100663439);
			MouseBindingSource.NativeMethodInfoPtr__ctor_Public_Void_Mouse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseBindingSource>.NativeClassPtr, 100663440);
			MouseBindingSource.NativeMethodInfoPtr_ButtonIsPressed_Internal_Static_Boolean_Mouse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseBindingSource>.NativeClassPtr, 100663441);
			MouseBindingSource.NativeMethodInfoPtr_NegativeScrollWheelIsActive_Internal_Static_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseBindingSource>.NativeClassPtr, 100663442);
			MouseBindingSource.NativeMethodInfoPtr_PositiveScrollWheelIsActive_Internal_Static_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseBindingSource>.NativeClassPtr, 100663443);
			MouseBindingSource.NativeMethodInfoPtr_GetValue_Internal_Static_Single_Mouse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseBindingSource>.NativeClassPtr, 100663444);
			MouseBindingSource.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseBindingSource>.NativeClassPtr, 100663445);
			MouseBindingSource.NativeMethodInfoPtr_GetState_Public_Virtual_Boolean_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseBindingSource>.NativeClassPtr, 100663446);
			MouseBindingSource.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseBindingSource>.NativeClassPtr, 100663447);
			MouseBindingSource.NativeMethodInfoPtr_get_DeviceName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseBindingSource>.NativeClassPtr, 100663448);
			MouseBindingSource.NativeMethodInfoPtr_get_DeviceClass_Public_Virtual_get_InputDeviceClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseBindingSource>.NativeClassPtr, 100663449);
			MouseBindingSource.NativeMethodInfoPtr_get_DeviceStyle_Public_Virtual_get_InputDeviceStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseBindingSource>.NativeClassPtr, 100663450);
			MouseBindingSource.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_BindingSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseBindingSource>.NativeClassPtr, 100663451);
			MouseBindingSource.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseBindingSource>.NativeClassPtr, 100663452);
			MouseBindingSource.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseBindingSource>.NativeClassPtr, 100663453);
			MouseBindingSource.NativeMethodInfoPtr_get_BindingSourceType_Public_Virtual_get_BindingSourceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseBindingSource>.NativeClassPtr, 100663454);
			MouseBindingSource.NativeMethodInfoPtr_Save_Public_Virtual_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseBindingSource>.NativeClassPtr, 100663455);
			MouseBindingSource.NativeMethodInfoPtr_Load_Public_Virtual_Void_BinaryReader_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseBindingSource>.NativeClassPtr, 100663456);
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x0000AF74 File Offset: 0x00009174
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x0000AFB0 File Offset: 0x000091B0
		public unsafe Mouse Control
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseBindingSource.NativeMethodInfoPtr_get_Control_Public_get_Mouse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseBindingSource.NativeMethodInfoPtr_set_Control_Protected_set_Void_Mouse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000AFF0 File Offset: 0x000091F0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseBindingSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseBindingSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseBindingSource.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000B02C File Offset: 0x0000922C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 767585, RefRangeEnd = 767587, XrefRangeStart = 767585, XrefRangeEnd = 767587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseBindingSource(Mouse mouseControl)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseBindingSource>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mouseControl;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseBindingSource.NativeMethodInfoPtr__ctor_Public_Void_Mouse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000B074 File Offset: 0x00009274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767863, XrefRangeEnd = 767874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ButtonIsPressed(Mouse control)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref control;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseBindingSource.NativeMethodInfoPtr_ButtonIsPressed_Internal_Static_Boolean_Mouse_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000B0B4 File Offset: 0x000092B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767874, XrefRangeEnd = 767888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool NegativeScrollWheelIsActive(float threshold)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref threshold;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseBindingSource.NativeMethodInfoPtr_NegativeScrollWheelIsActive_Internal_Static_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000B0F4 File Offset: 0x000092F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767888, XrefRangeEnd = 767902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool PositiveScrollWheelIsActive(float threshold)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref threshold;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseBindingSource.NativeMethodInfoPtr_PositiveScrollWheelIsActive_Internal_Static_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000B134 File Offset: 0x00009334
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 767913, RefRangeEnd = 767914, XrefRangeStart = 767902, XrefRangeEnd = 767913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetValue(Mouse mouseControl)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mouseControl;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseBindingSource.NativeMethodInfoPtr_GetValue_Internal_Static_Single_Mouse_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000B174 File Offset: 0x00009374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767914, XrefRangeEnd = 767918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float GetValue(InputDevice inputDevice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDevice);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseBindingSource.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_InputDevice_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000B1CC File Offset: 0x000093CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767918, XrefRangeEnd = 767922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetState(InputDevice inputDevice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDevice);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseBindingSource.NativeMethodInfoPtr_GetState_Public_Virtual_Boolean_InputDevice_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000ED RID: 237 RVA: 0x0000B224 File Offset: 0x00009424
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767922, XrefRangeEnd = 767925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseBindingSource.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000EE RID: 238 RVA: 0x0000B268 File Offset: 0x00009468
		public unsafe override string DeviceName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767925, XrefRangeEnd = 767927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseBindingSource.NativeMethodInfoPtr_get_DeviceName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000EF RID: 239 RVA: 0x0000B2AC File Offset: 0x000094AC
		public unsafe override InputDeviceClass DeviceClass
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseBindingSource.NativeMethodInfoPtr_get_DeviceClass_Public_Virtual_get_InputDeviceClass_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x0000B2F4 File Offset: 0x000094F4
		public unsafe override InputDeviceStyle DeviceStyle
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseBindingSource.NativeMethodInfoPtr_get_DeviceStyle_Public_Virtual_get_InputDeviceStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000B33C File Offset: 0x0000953C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767927, XrefRangeEnd = 767929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(BindingSource other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseBindingSource.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_BindingSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000B394 File Offset: 0x00009594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767929, XrefRangeEnd = 767931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseBindingSource.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000B3EC File Offset: 0x000095EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseBindingSource.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x0000B434 File Offset: 0x00009634
		public unsafe override BindingSourceType BindingSourceType
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 25008, RefRangeEnd = 25013, XrefRangeStart = 25008, XrefRangeEnd = 25013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseBindingSource.NativeMethodInfoPtr_get_BindingSourceType_Public_Virtual_get_BindingSourceType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000B47C File Offset: 0x0000967C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Save(BinaryWriter writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseBindingSource.NativeMethodInfoPtr_Save_Public_Virtual_Void_BinaryWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000B4CC File Offset: 0x000096CC
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseBindingSource.NativeMethodInfoPtr_Load_Public_Virtual_Void_BinaryReader_UInt16_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000241F File Offset: 0x0000061F
		public MouseBindingSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x0000B528 File Offset: 0x00009728
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x00002428 File Offset: 0x00000628
		public unsafe Mouse _Control_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseBindingSource.NativeFieldInfoPtr__Control_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseBindingSource.NativeFieldInfoPtr__Control_k__BackingField)) = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000FA RID: 250 RVA: 0x0000B550 File Offset: 0x00009750
		// (set) Token: 0x060000FB RID: 251 RVA: 0x00002443 File Offset: 0x00000643
		public unsafe static float ScaleX
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(MouseBindingSource.NativeFieldInfoPtr_ScaleX, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MouseBindingSource.NativeFieldInfoPtr_ScaleX, (void*)(&value));
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000FC RID: 252 RVA: 0x0000B56C File Offset: 0x0000976C
		// (set) Token: 0x060000FD RID: 253 RVA: 0x00002451 File Offset: 0x00000651
		public unsafe static float ScaleY
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(MouseBindingSource.NativeFieldInfoPtr_ScaleY, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MouseBindingSource.NativeFieldInfoPtr_ScaleY, (void*)(&value));
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000FE RID: 254 RVA: 0x0000B588 File Offset: 0x00009788
		// (set) Token: 0x060000FF RID: 255 RVA: 0x0000245F File Offset: 0x0000065F
		public unsafe static float ScaleZ
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(MouseBindingSource.NativeFieldInfoPtr_ScaleZ, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MouseBindingSource.NativeFieldInfoPtr_ScaleZ, (void*)(&value));
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000100 RID: 256 RVA: 0x0000B5A4 File Offset: 0x000097A4
		// (set) Token: 0x06000101 RID: 257 RVA: 0x0000246D File Offset: 0x0000066D
		public unsafe static float JitterThreshold
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(MouseBindingSource.NativeFieldInfoPtr_JitterThreshold, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MouseBindingSource.NativeFieldInfoPtr_JitterThreshold, (void*)(&value));
			}
		}

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeFieldInfoPtr__Control_k__BackingField;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeFieldInfoPtr_ScaleX;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeFieldInfoPtr_ScaleY;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeFieldInfoPtr_ScaleZ;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeFieldInfoPtr_JitterThreshold;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_get_Control_Public_get_Mouse_0;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeMethodInfoPtr_set_Control_Protected_set_Void_Mouse_0;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Mouse_0;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeMethodInfoPtr_ButtonIsPressed_Internal_Static_Boolean_Mouse_0;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeMethodInfoPtr_NegativeScrollWheelIsActive_Internal_Static_Boolean_Single_0;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeMethodInfoPtr_PositiveScrollWheelIsActive_Internal_Static_Boolean_Single_0;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Internal_Static_Single_Mouse_0;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Single_InputDevice_0;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeMethodInfoPtr_GetState_Public_Virtual_Boolean_InputDevice_0;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeMethodInfoPtr_get_DeviceName_Public_Virtual_get_String_0;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeMethodInfoPtr_get_DeviceClass_Public_Virtual_get_InputDeviceClass_0;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeMethodInfoPtr_get_DeviceStyle_Public_Virtual_get_InputDeviceStyle_0;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_BindingSource_0;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr_get_BindingSourceType_Public_Virtual_get_BindingSourceType_0;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Virtual_Void_BinaryWriter_0;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_BinaryReader_UInt16_0;
	}
}
