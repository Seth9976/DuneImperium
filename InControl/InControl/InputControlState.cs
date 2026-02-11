using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace InControl
{
	// Token: 0x0200002A RID: 42
	[StructLayout(2)]
	public struct InputControlState
	{
		// Token: 0x060002D3 RID: 723 RVA: 0x0001205C File Offset: 0x0001025C
		// Note: this type is marked as 'beforefieldinit'.
		static InputControlState()
		{
			Il2CppClassPointerStore<InputControlState>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "InputControlState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputControlState>.NativeClassPtr);
			InputControlState.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlState>.NativeClassPtr, "State");
			InputControlState.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlState>.NativeClassPtr, "Value");
			InputControlState.NativeFieldInfoPtr_RawValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlState>.NativeClassPtr, "RawValue");
			InputControlState.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlState>.NativeClassPtr, 100663690);
			InputControlState.NativeMethodInfoPtr_Set_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlState>.NativeClassPtr, 100663691);
			InputControlState.NativeMethodInfoPtr_Set_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlState>.NativeClassPtr, 100663692);
			InputControlState.NativeMethodInfoPtr_Set_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlState>.NativeClassPtr, 100663693);
			InputControlState.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_InputControlState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlState>.NativeClassPtr, 100663694);
			InputControlState.NativeMethodInfoPtr_op_Implicit_Public_Static_Single_InputControlState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlState>.NativeClassPtr, 100663695);
			InputControlState.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InputControlState_InputControlState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlState>.NativeClassPtr, 100663696);
			InputControlState.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InputControlState_InputControlState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlState>.NativeClassPtr, 100663697);
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00012168 File Offset: 0x00010368
		[CallerCount(0)]
		public unsafe void Reset()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlState.NativeMethodInfoPtr_Reset_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00012190 File Offset: 0x00010390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773268, XrefRangeEnd = 773272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlState.NativeMethodInfoPtr_Set_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x000121C4 File Offset: 0x000103C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 773276, RefRangeEnd = 773277, XrefRangeStart = 773272, XrefRangeEnd = 773276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(float value, float threshold)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threshold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlState.NativeMethodInfoPtr_Set_Public_Void_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00012204 File Offset: 0x00010404
		[CallerCount(0)]
		public unsafe void Set(bool state)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlState.NativeMethodInfoPtr_Set_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00012238 File Offset: 0x00010438
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 441993, RefRangeEnd = 442038, XrefRangeStart = 441993, XrefRangeEnd = 442038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator bool(InputControlState state)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlState.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_InputControlState_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00012278 File Offset: 0x00010478
		[CallerCount(0)]
		public unsafe static implicit operator float(InputControlState state)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlState.NativeMethodInfoPtr_op_Implicit_Public_Static_Single_InputControlState_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002DA RID: 730 RVA: 0x000122B8 File Offset: 0x000104B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773277, XrefRangeEnd = 773278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(InputControlState a, InputControlState b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlState.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InputControlState_InputControlState_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00012304 File Offset: 0x00010504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773278, XrefRangeEnd = 773279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(InputControlState a, InputControlState b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlState.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InputControlState_InputControlState_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0000305C File Offset: 0x0000125C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputControlState>.NativeClassPtr, ref this));
		}

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeFieldInfoPtr_RawValue;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_Single_0;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_Single_Single_0;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_Boolean_0;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_InputControlState_0;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Single_InputControlState_0;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InputControlState_InputControlState_0;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InputControlState_InputControlState_0;

		// Token: 0x04000307 RID: 775
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool State;

		// Token: 0x04000308 RID: 776
		[FieldOffset(4)]
		public float Value;

		// Token: 0x04000309 RID: 777
		[FieldOffset(8)]
		public float RawValue;
	}
}
