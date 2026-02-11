using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000029 RID: 41
	[Serializable]
	[StructLayout(2)]
	public struct InputControlSource
	{
		// Token: 0x060002C8 RID: 712 RVA: 0x00011D60 File Offset: 0x0000FF60
		// Note: this type is marked as 'beforefieldinit'.
		static InputControlSource()
		{
			Il2CppClassPointerStore<InputControlSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "InputControlSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputControlSource>.NativeClassPtr);
			InputControlSource.NativeFieldInfoPtr_sourceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlSource>.NativeClassPtr, "sourceType");
			InputControlSource.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlSource>.NativeClassPtr, "index");
			InputControlSource.NativeMethodInfoPtr_get_SourceType_Public_get_InputControlSourceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlSource>.NativeClassPtr, 100663681);
			InputControlSource.NativeMethodInfoPtr_set_SourceType_Public_set_Void_InputControlSourceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlSource>.NativeClassPtr, 100663682);
			InputControlSource.NativeMethodInfoPtr_get_Index_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlSource>.NativeClassPtr, 100663683);
			InputControlSource.NativeMethodInfoPtr_set_Index_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlSource>.NativeClassPtr, 100663684);
			InputControlSource.NativeMethodInfoPtr__ctor_Public_Void_InputControlSourceType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlSource>.NativeClassPtr, 100663685);
			InputControlSource.NativeMethodInfoPtr__ctor_Public_Void_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlSource>.NativeClassPtr, 100663686);
			InputControlSource.NativeMethodInfoPtr_GetValue_Public_Single_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlSource>.NativeClassPtr, 100663687);
			InputControlSource.NativeMethodInfoPtr_GetState_Public_Boolean_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlSource>.NativeClassPtr, 100663688);
			InputControlSource.NativeMethodInfoPtr_ToCode_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlSource>.NativeClassPtr, 100663689);
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x00011E6C File Offset: 0x0001006C
		// (set) Token: 0x060002CA RID: 714 RVA: 0x00011E9C File Offset: 0x0001009C
		public unsafe InputControlSourceType SourceType
		{
			[CallerCount(200)]
			[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlSource.NativeMethodInfoPtr_get_SourceType_Public_get_InputControlSourceType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 320163, RefRangeEnd = 320170, XrefRangeStart = 320163, XrefRangeEnd = 320170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlSource.NativeMethodInfoPtr_set_SourceType_Public_set_Void_InputControlSourceType_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060002CB RID: 715 RVA: 0x00011ED0 File Offset: 0x000100D0
		// (set) Token: 0x060002CC RID: 716 RVA: 0x00011F00 File Offset: 0x00010100
		public unsafe int Index
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlSource.NativeMethodInfoPtr_get_Index_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 320170, RefRangeEnd = 320176, XrefRangeStart = 320170, XrefRangeEnd = 320176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlSource.NativeMethodInfoPtr_set_Index_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00011F34 File Offset: 0x00010134
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 283577, RefRangeEnd = 283616, XrefRangeStart = 283577, XrefRangeEnd = 283616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputControlSource(InputControlSourceType sourceType, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sourceType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlSource.NativeMethodInfoPtr__ctor_Public_Void_InputControlSourceType_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00011F74 File Offset: 0x00010174
		[CallerCount(0)]
		public unsafe InputControlSource(KeyCode keyCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlSource.NativeMethodInfoPtr__ctor_Public_Void_KeyCode_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00011FA8 File Offset: 0x000101A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 773239, RefRangeEnd = 773241, XrefRangeStart = 773237, XrefRangeEnd = 773239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetValue(InputDevice inputDevice)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDevice);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlSource.NativeMethodInfoPtr_GetValue_Public_Single_InputDevice_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00011FEC File Offset: 0x000101EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 773247, RefRangeEnd = 773249, XrefRangeStart = 773241, XrefRangeEnd = 773247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetState(InputDevice inputDevice)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDevice);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlSource.NativeMethodInfoPtr_GetState_Public_Boolean_InputDevice_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00012030 File Offset: 0x00010230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773249, XrefRangeEnd = 773268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControlSource.NativeMethodInfoPtr_ToCode_Public_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000304A File Offset: 0x0000124A
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputControlSource>.NativeClassPtr, ref this));
		}

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeFieldInfoPtr_sourceType;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeMethodInfoPtr_get_SourceType_Public_get_InputControlSourceType_0;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeMethodInfoPtr_set_SourceType_Public_set_Void_InputControlSourceType_0;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeMethodInfoPtr_get_Index_Public_get_Int32_0;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeMethodInfoPtr_set_Index_Public_set_Void_Int32_0;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_InputControlSourceType_Int32_0;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_KeyCode_0;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Single_InputDevice_0;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeMethodInfoPtr_GetState_Public_Boolean_InputDevice_0;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeMethodInfoPtr_ToCode_Public_String_0;

		// Token: 0x040002FA RID: 762
		[FieldOffset(0)]
		public InputControlSourceType sourceType;

		// Token: 0x040002FB RID: 763
		[FieldOffset(4)]
		public int index;
	}
}
