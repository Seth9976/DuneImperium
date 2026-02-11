using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x020000B6 RID: 182
	[StructLayout(2)]
	public struct Controller
	{
		// Token: 0x06000BC9 RID: 3017 RVA: 0x0004FF40 File Offset: 0x0004E140
		// Note: this type is marked as 'beforefieldinit'.
		static Controller()
		{
			Il2CppClassPointerStore<Controller>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "Controller");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Controller>.NativeClassPtr);
			Controller.NativeFieldInfoPtr_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "Handle");
			Controller.NativeMethodInfoPtr__ctor_Internal_Void_InputHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100666203);
			Controller.NativeMethodInfoPtr_get_Id_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100666204);
			Controller.NativeMethodInfoPtr_get_InputType_Public_get_InputType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100666205);
			Controller.NativeMethodInfoPtr_set_ActionSet_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100666206);
			Controller.NativeMethodInfoPtr_DeactivateLayer_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100666207);
			Controller.NativeMethodInfoPtr_ActivateLayer_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100666208);
			Controller.NativeMethodInfoPtr_ClearLayers_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100666209);
			Controller.NativeMethodInfoPtr_GetDigitalState_Public_DigitalState_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100666210);
			Controller.NativeMethodInfoPtr_GetAnalogState_Public_AnalogState_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100666211);
			Controller.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100666212);
			Controller.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Controller_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100666213);
			Controller.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Controller_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100666214);
			Controller.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100666215);
			Controller.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100666216);
			Controller.NativeMethodInfoPtr_Equals_Public_Boolean_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100666217);
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x000500B0 File Offset: 0x0004E2B0
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 315640, RefRangeEnd = 315684, XrefRangeStart = 315640, XrefRangeEnd = 315684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Controller(InputHandle_t inputHandle_t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle_t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr__ctor_Internal_Void_InputHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000BCB RID: 3019 RVA: 0x000500E4 File Offset: 0x0004E2E4
		public unsafe ulong Id
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_get_Id_Public_get_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000BCC RID: 3020 RVA: 0x00050114 File Offset: 0x0004E314
		public unsafe InputType InputType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946184, XrefRangeEnd = 946190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_get_InputType_Public_get_InputType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700011E RID: 286
		// (set) Token: 0x06000BCD RID: 3021 RVA: 0x00050144 File Offset: 0x0004E344
		public unsafe string ActionSet
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946190, XrefRangeEnd = 946198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_set_ActionSet_Public_set_Void_String_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x0005017C File Offset: 0x0004E37C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946198, XrefRangeEnd = 946206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeactivateLayer(string layer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(layer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_DeactivateLayer_Public_Void_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x000501B4 File Offset: 0x0004E3B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946206, XrefRangeEnd = 946214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateLayer(string layer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(layer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_ActivateLayer_Public_Void_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x000501EC File Offset: 0x0004E3EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946214, XrefRangeEnd = 946220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearLayers()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_ClearLayers_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x00050214 File Offset: 0x0004E414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946220, XrefRangeEnd = 946227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DigitalState GetDigitalState(string actionName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_GetDigitalState_Public_DigitalState_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x00050258 File Offset: 0x0004E458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946227, XrefRangeEnd = 946233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnalogState GetAnalogState(string actionName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_GetAnalogState_Public_AnalogState_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x0005029C File Offset: 0x0004E49C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946233, XrefRangeEnd = 946247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x000502C8 File Offset: 0x0004E4C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946247, XrefRangeEnd = 946248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Controller a, Controller b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Controller_Controller_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x00050314 File Offset: 0x0004E514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946248, XrefRangeEnd = 946249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Controller a, Controller b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Controller_Controller_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x00050360 File Offset: 0x0004E560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946249, XrefRangeEnd = 946255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x000503A4 File Offset: 0x0004E5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946255, XrefRangeEnd = 946256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x000503D4 File Offset: 0x0004E5D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946256, XrefRangeEnd = 946257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Controller p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Controller.NativeMethodInfoPtr_Equals_Public_Boolean_Controller_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x00002EAB File Offset: 0x000010AB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Controller>.NativeClassPtr, ref this));
		}

		// Token: 0x0400125E RID: 4702
		private static readonly IntPtr NativeFieldInfoPtr_Handle;

		// Token: 0x0400125F RID: 4703
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_InputHandle_t_0;

		// Token: 0x04001260 RID: 4704
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_UInt64_0;

		// Token: 0x04001261 RID: 4705
		private static readonly IntPtr NativeMethodInfoPtr_get_InputType_Public_get_InputType_0;

		// Token: 0x04001262 RID: 4706
		private static readonly IntPtr NativeMethodInfoPtr_set_ActionSet_Public_set_Void_String_0;

		// Token: 0x04001263 RID: 4707
		private static readonly IntPtr NativeMethodInfoPtr_DeactivateLayer_Public_Void_String_0;

		// Token: 0x04001264 RID: 4708
		private static readonly IntPtr NativeMethodInfoPtr_ActivateLayer_Public_Void_String_0;

		// Token: 0x04001265 RID: 4709
		private static readonly IntPtr NativeMethodInfoPtr_ClearLayers_Public_Void_0;

		// Token: 0x04001266 RID: 4710
		private static readonly IntPtr NativeMethodInfoPtr_GetDigitalState_Public_DigitalState_String_0;

		// Token: 0x04001267 RID: 4711
		private static readonly IntPtr NativeMethodInfoPtr_GetAnalogState_Public_AnalogState_String_0;

		// Token: 0x04001268 RID: 4712
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001269 RID: 4713
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Controller_Controller_0;

		// Token: 0x0400126A RID: 4714
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Controller_Controller_0;

		// Token: 0x0400126B RID: 4715
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400126C RID: 4716
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400126D RID: 4717
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_Controller_0;

		// Token: 0x0400126E RID: 4718
		[FieldOffset(0)]
		public InputHandle_t Handle;
	}
}
