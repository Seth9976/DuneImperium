using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;

namespace InControl
{
	// Token: 0x02000020 RID: 32
	[StructLayout(2)]
	public struct UnknownDeviceControl
	{
		// Token: 0x0600021B RID: 539 RVA: 0x0000F8A8 File Offset: 0x0000DAA8
		// Note: this type is marked as 'beforefieldinit'.
		static UnknownDeviceControl()
		{
			Il2CppClassPointerStore<UnknownDeviceControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "UnknownDeviceControl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnknownDeviceControl>.NativeClassPtr);
			UnknownDeviceControl.NativeFieldInfoPtr_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnknownDeviceControl>.NativeClassPtr, "None");
			UnknownDeviceControl.NativeFieldInfoPtr_Control = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnknownDeviceControl>.NativeClassPtr, "Control");
			UnknownDeviceControl.NativeFieldInfoPtr_SourceRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnknownDeviceControl>.NativeClassPtr, "SourceRange");
			UnknownDeviceControl.NativeFieldInfoPtr_IsButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnknownDeviceControl>.NativeClassPtr, "IsButton");
			UnknownDeviceControl.NativeFieldInfoPtr_IsAnalog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnknownDeviceControl>.NativeClassPtr, "IsAnalog");
			UnknownDeviceControl.NativeMethodInfoPtr__ctor_Public_Void_InputControlType_InputRangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownDeviceControl>.NativeClassPtr, 100663603);
			UnknownDeviceControl.NativeMethodInfoPtr_GetValue_Internal_Single_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownDeviceControl>.NativeClassPtr, 100663604);
			UnknownDeviceControl.NativeMethodInfoPtr_get_Index_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownDeviceControl>.NativeClassPtr, 100663605);
			UnknownDeviceControl.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_UnknownDeviceControl_UnknownDeviceControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownDeviceControl>.NativeClassPtr, 100663606);
			UnknownDeviceControl.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_UnknownDeviceControl_UnknownDeviceControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownDeviceControl>.NativeClassPtr, 100663607);
			UnknownDeviceControl.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UnknownDeviceControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownDeviceControl>.NativeClassPtr, 100663608);
			UnknownDeviceControl.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownDeviceControl>.NativeClassPtr, 100663609);
			UnknownDeviceControl.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownDeviceControl>.NativeClassPtr, 100663610);
			UnknownDeviceControl.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_UnknownDeviceControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownDeviceControl>.NativeClassPtr, 100663611);
			UnknownDeviceControl.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownDeviceControl>.NativeClassPtr, 100663612);
			UnknownDeviceControl.NativeMethodInfoPtr_Save_Internal_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownDeviceControl>.NativeClassPtr, 100663613);
			UnknownDeviceControl.NativeMethodInfoPtr_Load_Internal_Void_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownDeviceControl>.NativeClassPtr, 100663614);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000FA2C File Offset: 0x0000DC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769097, XrefRangeEnd = 769101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnknownDeviceControl(InputControlType control, InputRangeType sourceRange)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref control;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceRange;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownDeviceControl.NativeMethodInfoPtr__ctor_Public_Void_InputControlType_InputRangeType_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0000FA6C File Offset: 0x0000DC6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 769107, RefRangeEnd = 769108, XrefRangeStart = 769101, XrefRangeEnd = 769107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetValue(InputDevice device)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(device);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownDeviceControl.NativeMethodInfoPtr_GetValue_Internal_Single_InputDevice_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600021E RID: 542 RVA: 0x0000FAB0 File Offset: 0x0000DCB0
		public unsafe int Index
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownDeviceControl.NativeMethodInfoPtr_get_Index_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000FAE0 File Offset: 0x0000DCE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769108, XrefRangeEnd = 769111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(UnknownDeviceControl a, UnknownDeviceControl b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownDeviceControl.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_UnknownDeviceControl_UnknownDeviceControl_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000FB2C File Offset: 0x0000DD2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769111, XrefRangeEnd = 769117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(UnknownDeviceControl a, UnknownDeviceControl b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownDeviceControl.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_UnknownDeviceControl_UnknownDeviceControl_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000FB78 File Offset: 0x0000DD78
		[CallerCount(0)]
		public unsafe bool Equals(UnknownDeviceControl other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownDeviceControl.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UnknownDeviceControl_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000FBB8 File Offset: 0x0000DDB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769117, XrefRangeEnd = 769122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownDeviceControl.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0000FBFC File Offset: 0x0000DDFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769122, XrefRangeEnd = 769124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownDeviceControl.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000FC2C File Offset: 0x0000DE2C
		[CallerCount(0)]
		public unsafe static implicit operator bool(UnknownDeviceControl control)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref control;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownDeviceControl.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_UnknownDeviceControl_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000FC6C File Offset: 0x0000DE6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769124, XrefRangeEnd = 769133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownDeviceControl.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000FC98 File Offset: 0x0000DE98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769133, XrefRangeEnd = 769134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Save(BinaryWriter writer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownDeviceControl.NativeMethodInfoPtr_Save_Internal_Void_BinaryWriter_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000FCD0 File Offset: 0x0000DED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769134, XrefRangeEnd = 769138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(BinaryReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownDeviceControl.NativeMethodInfoPtr_Load_Internal_Void_BinaryReader_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00002BB1 File Offset: 0x00000DB1
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnknownDeviceControl>.NativeClassPtr, ref this));
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000229 RID: 553 RVA: 0x0000FD08 File Offset: 0x0000DF08
		// (set) Token: 0x0600022A RID: 554 RVA: 0x00002BC3 File Offset: 0x00000DC3
		public unsafe static UnknownDeviceControl None
		{
			get
			{
				UnknownDeviceControl unknownDeviceControl;
				IL2CPP.il2cpp_field_static_get_value(UnknownDeviceControl.NativeFieldInfoPtr_None, (void*)(&unknownDeviceControl));
				return unknownDeviceControl;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnknownDeviceControl.NativeFieldInfoPtr_None, (void*)(&value));
			}
		}

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeFieldInfoPtr_None;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeFieldInfoPtr_Control;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeFieldInfoPtr_SourceRange;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeFieldInfoPtr_IsButton;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeFieldInfoPtr_IsAnalog;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_InputControlType_InputRangeType_0;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Internal_Single_InputDevice_0;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeMethodInfoPtr_get_Index_Public_get_Int32_0;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_UnknownDeviceControl_UnknownDeviceControl_0;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_UnknownDeviceControl_UnknownDeviceControl_0;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UnknownDeviceControl_0;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_UnknownDeviceControl_0;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeMethodInfoPtr_Save_Internal_Void_BinaryWriter_0;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeMethodInfoPtr_Load_Internal_Void_BinaryReader_0;

		// Token: 0x0400027B RID: 635
		[FieldOffset(0)]
		public InputControlType Control;

		// Token: 0x0400027C RID: 636
		[FieldOffset(4)]
		public InputRangeType SourceRange;

		// Token: 0x0400027D RID: 637
		[FieldOffset(8)]
		[MarshalAs(4)]
		public bool IsButton;

		// Token: 0x0400027E RID: 638
		[FieldOffset(9)]
		[MarshalAs(4)]
		public bool IsAnalog;
	}
}
