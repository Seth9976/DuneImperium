using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.input
{
	// Token: 0x02000054 RID: 84
	public class Press : Object
	{
		// Token: 0x060002D8 RID: 728 RVA: 0x0000FDD0 File Offset: 0x0000DFD0
		// Note: this type is marked as 'beforefieldinit'.
		static Press()
		{
			Il2CppClassPointerStore<Press>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input", "Press");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Press>.NativeClassPtr);
			Press.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Press>.NativeClassPtr, "source");
			Press.NativeMethodInfoPtr_get_Down_Public_get_InputSample_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Press>.NativeClassPtr, 100663641);
			Press.NativeMethodInfoPtr_get_Current_Public_get_InputSample_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Press>.NativeClassPtr, 100663642);
			Press.NativeMethodInfoPtr_get_Up_Public_get_Nullable_1_InputSample_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Press>.NativeClassPtr, 100663643);
			Press.NativeMethodInfoPtr__ctor_Internal_Void_MutablePress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Press>.NativeClassPtr, 100663644);
			Press.NativeMethodInfoPtr_System_IComparable_dwd_core_input_Press__CompareTo_Private_Virtual_Final_New_Int32_Press_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Press>.NativeClassPtr, 100663645);
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x0000FE78 File Offset: 0x0000E078
		public unsafe InputSample Down
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 1121126, RefRangeEnd = 1121140, XrefRangeStart = 1121126, XrefRangeEnd = 1121126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Press.NativeMethodInfoPtr_get_Down_Public_get_InputSample_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new InputSample(intPtr);
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060002DA RID: 730 RVA: 0x0000FEB0 File Offset: 0x0000E0B0
		public unsafe InputSample Current
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1121141, RefRangeEnd = 1121150, XrefRangeStart = 1121140, XrefRangeEnd = 1121141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Press.NativeMethodInfoPtr_get_Current_Public_get_InputSample_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new InputSample(intPtr);
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060002DB RID: 731 RVA: 0x0000FEE8 File Offset: 0x0000E0E8
		public unsafe Nullable<InputSample> Up
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1121151, RefRangeEnd = 1121159, XrefRangeStart = 1121150, XrefRangeEnd = 1121151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Press.NativeMethodInfoPtr_get_Up_Public_get_Nullable_1_InputSample_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<InputSample>(intPtr);
			}
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0000FF20 File Offset: 0x0000E120
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Press(MutablePress source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Press>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Press.NativeMethodInfoPtr__ctor_Internal_Void_MutablePress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0000FF6C File Offset: 0x0000E16C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121159, XrefRangeEnd = 1121177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_IComparable_dwd_core_input_Press__CompareTo(Press other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Press.NativeMethodInfoPtr_System_IComparable_dwd_core_input_Press__CompareTo_Private_Virtual_Final_New_Int32_Press_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00003A33 File Offset: 0x00001C33
		public Press(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060002DF RID: 735 RVA: 0x0000FFBC File Offset: 0x0000E1BC
		// (set) Token: 0x060002E0 RID: 736 RVA: 0x00003A3C File Offset: 0x00001C3C
		public unsafe MutablePress source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Press.NativeFieldInfoPtr_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MutablePress>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Press.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeMethodInfoPtr_get_Down_Public_get_InputSample_0;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_get_InputSample_0;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeMethodInfoPtr_get_Up_Public_get_Nullable_1_InputSample_0;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_MutablePress_0;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr_System_IComparable_dwd_core_input_Press__CompareTo_Private_Virtual_Final_New_Int32_Press_0;
	}
}
