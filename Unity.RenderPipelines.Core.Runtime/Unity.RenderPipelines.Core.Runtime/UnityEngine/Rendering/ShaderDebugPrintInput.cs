using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200007C RID: 124
	[StructLayout(2)]
	public struct ShaderDebugPrintInput
	{
		// Token: 0x06000841 RID: 2113 RVA: 0x0002C660 File Offset: 0x0002A860
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderDebugPrintInput()
		{
			Il2CppClassPointerStore<ShaderDebugPrintInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ShaderDebugPrintInput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderDebugPrintInput>.NativeClassPtr);
			ShaderDebugPrintInput.NativeFieldInfoPtr__pos_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDebugPrintInput>.NativeClassPtr, "<pos>k__BackingField");
			ShaderDebugPrintInput.NativeFieldInfoPtr__leftDown_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDebugPrintInput>.NativeClassPtr, "<leftDown>k__BackingField");
			ShaderDebugPrintInput.NativeFieldInfoPtr__rightDown_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDebugPrintInput>.NativeClassPtr, "<rightDown>k__BackingField");
			ShaderDebugPrintInput.NativeFieldInfoPtr__middleDown_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDebugPrintInput>.NativeClassPtr, "<middleDown>k__BackingField");
			ShaderDebugPrintInput.NativeMethodInfoPtr_get_pos_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintInput>.NativeClassPtr, 100664595);
			ShaderDebugPrintInput.NativeMethodInfoPtr_set_pos_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintInput>.NativeClassPtr, 100664596);
			ShaderDebugPrintInput.NativeMethodInfoPtr_get_leftDown_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintInput>.NativeClassPtr, 100664597);
			ShaderDebugPrintInput.NativeMethodInfoPtr_set_leftDown_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintInput>.NativeClassPtr, 100664598);
			ShaderDebugPrintInput.NativeMethodInfoPtr_get_rightDown_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintInput>.NativeClassPtr, 100664599);
			ShaderDebugPrintInput.NativeMethodInfoPtr_set_rightDown_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintInput>.NativeClassPtr, 100664600);
			ShaderDebugPrintInput.NativeMethodInfoPtr_get_middleDown_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintInput>.NativeClassPtr, 100664601);
			ShaderDebugPrintInput.NativeMethodInfoPtr_set_middleDown_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintInput>.NativeClassPtr, 100664602);
			ShaderDebugPrintInput.NativeMethodInfoPtr_String_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintInput>.NativeClassPtr, 100664603);
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000842 RID: 2114 RVA: 0x0002C794 File Offset: 0x0002A994
		// (set) Token: 0x06000843 RID: 2115 RVA: 0x0002C7C4 File Offset: 0x0002A9C4
		public unsafe Vector2 pos
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderDebugPrintInput.NativeMethodInfoPtr_get_pos_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 315640, RefRangeEnd = 315684, XrefRangeStart = 315640, XrefRangeEnd = 315684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderDebugPrintInput.NativeMethodInfoPtr_set_pos_Public_set_Void_Vector2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000844 RID: 2116 RVA: 0x0002C7F8 File Offset: 0x0002A9F8
		// (set) Token: 0x06000845 RID: 2117 RVA: 0x0002C828 File Offset: 0x0002AA28
		public unsafe bool leftDown
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderDebugPrintInput.NativeMethodInfoPtr_get_leftDown_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 685136, RefRangeEnd = 685137, XrefRangeStart = 685136, XrefRangeEnd = 685137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderDebugPrintInput.NativeMethodInfoPtr_set_leftDown_Public_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000846 RID: 2118 RVA: 0x0002C85C File Offset: 0x0002AA5C
		// (set) Token: 0x06000847 RID: 2119 RVA: 0x0002C88C File Offset: 0x0002AA8C
		public unsafe bool rightDown
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderDebugPrintInput.NativeMethodInfoPtr_get_rightDown_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 685139, RefRangeEnd = 685140, XrefRangeStart = 685139, XrefRangeEnd = 685140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderDebugPrintInput.NativeMethodInfoPtr_set_rightDown_Public_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000848 RID: 2120 RVA: 0x0002C8C0 File Offset: 0x0002AAC0
		// (set) Token: 0x06000849 RID: 2121 RVA: 0x0002C8F0 File Offset: 0x0002AAF0
		public unsafe bool middleDown
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderDebugPrintInput.NativeMethodInfoPtr_get_middleDown_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 685142, RefRangeEnd = 685143, XrefRangeStart = 685142, XrefRangeEnd = 685143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderDebugPrintInput.NativeMethodInfoPtr_set_middleDown_Public_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x0002C924 File Offset: 0x0002AB24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965463, XrefRangeEnd = 965491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string String()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderDebugPrintInput.NativeMethodInfoPtr_String_Public_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x0000546C File Offset: 0x0000366C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShaderDebugPrintInput>.NativeClassPtr, ref this));
		}

		// Token: 0x04000619 RID: 1561
		private static readonly IntPtr NativeFieldInfoPtr__pos_k__BackingField;

		// Token: 0x0400061A RID: 1562
		private static readonly IntPtr NativeFieldInfoPtr__leftDown_k__BackingField;

		// Token: 0x0400061B RID: 1563
		private static readonly IntPtr NativeFieldInfoPtr__rightDown_k__BackingField;

		// Token: 0x0400061C RID: 1564
		private static readonly IntPtr NativeFieldInfoPtr__middleDown_k__BackingField;

		// Token: 0x0400061D RID: 1565
		private static readonly IntPtr NativeMethodInfoPtr_get_pos_Public_get_Vector2_0;

		// Token: 0x0400061E RID: 1566
		private static readonly IntPtr NativeMethodInfoPtr_set_pos_Public_set_Void_Vector2_0;

		// Token: 0x0400061F RID: 1567
		private static readonly IntPtr NativeMethodInfoPtr_get_leftDown_Public_get_Boolean_0;

		// Token: 0x04000620 RID: 1568
		private static readonly IntPtr NativeMethodInfoPtr_set_leftDown_Public_set_Void_Boolean_0;

		// Token: 0x04000621 RID: 1569
		private static readonly IntPtr NativeMethodInfoPtr_get_rightDown_Public_get_Boolean_0;

		// Token: 0x04000622 RID: 1570
		private static readonly IntPtr NativeMethodInfoPtr_set_rightDown_Public_set_Void_Boolean_0;

		// Token: 0x04000623 RID: 1571
		private static readonly IntPtr NativeMethodInfoPtr_get_middleDown_Public_get_Boolean_0;

		// Token: 0x04000624 RID: 1572
		private static readonly IntPtr NativeMethodInfoPtr_set_middleDown_Public_set_Void_Boolean_0;

		// Token: 0x04000625 RID: 1573
		private static readonly IntPtr NativeMethodInfoPtr_String_Public_String_0;

		// Token: 0x04000626 RID: 1574
		[FieldOffset(0)]
		public Vector2 _pos_k__BackingField;

		// Token: 0x04000627 RID: 1575
		[FieldOffset(8)]
		[MarshalAs(4)]
		public bool _leftDown_k__BackingField;

		// Token: 0x04000628 RID: 1576
		[FieldOffset(9)]
		[MarshalAs(4)]
		public bool _rightDown_k__BackingField;

		// Token: 0x04000629 RID: 1577
		[FieldOffset(10)]
		[MarshalAs(4)]
		public bool _middleDown_k__BackingField;
	}
}
