using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000101 RID: 257
	public class AxisElement : Object
	{
		// Token: 0x06001742 RID: 5954 RVA: 0x00079C80 File Offset: 0x00077E80
		// Note: this type is marked as 'beforefieldinit'.
		static AxisElement()
		{
			Il2CppClassPointerStore<AxisElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "AxisElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AxisElement>.NativeClassPtr);
			AxisElement.NativeFieldInfoPtr_curNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisElement>.NativeClassPtr, "curNode");
			AxisElement.NativeFieldInfoPtr_rootDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisElement>.NativeClassPtr, "rootDepth");
			AxisElement.NativeFieldInfoPtr_curDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisElement>.NativeClassPtr, "curDepth");
			AxisElement.NativeFieldInfoPtr_isMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisElement>.NativeClassPtr, "isMatch");
			AxisElement.NativeMethodInfoPtr_get_CurNode_Internal_get_DoubleLinkAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisElement>.NativeClassPtr, 100666950);
			AxisElement.NativeMethodInfoPtr__ctor_Internal_Void_DoubleLinkAxis_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisElement>.NativeClassPtr, 100666951);
			AxisElement.NativeMethodInfoPtr_SetDepth_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisElement>.NativeClassPtr, 100666952);
			AxisElement.NativeMethodInfoPtr_MoveToParent_Internal_Void_Int32_ForwardAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisElement>.NativeClassPtr, 100666953);
			AxisElement.NativeMethodInfoPtr_MoveToChild_Internal_Boolean_String_String_Int32_ForwardAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisElement>.NativeClassPtr, 100666954);
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06001743 RID: 5955 RVA: 0x00079D64 File Offset: 0x00077F64
		public unsafe DoubleLinkAxis CurNode
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisElement.NativeMethodInfoPtr_get_CurNode_Internal_get_DoubleLinkAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DoubleLinkAxis>(intPtr3) : null;
			}
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x00079DA4 File Offset: 0x00077FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390425, XrefRangeEnd = 390427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AxisElement(DoubleLinkAxis node, int depth)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AxisElement>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisElement.NativeMethodInfoPtr__ctor_Internal_Void_DoubleLinkAxis_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x00079E00 File Offset: 0x00078000
		[CallerCount(0)]
		public unsafe void SetDepth(int depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref depth;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisElement.NativeMethodInfoPtr_SetDepth_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x00079E40 File Offset: 0x00078040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390427, XrefRangeEnd = 390428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveToParent(int depth, ForwardAxis parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref depth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisElement.NativeMethodInfoPtr_MoveToParent_Internal_Void_Int32_ForwardAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x00079E90 File Offset: 0x00078090
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 390430, RefRangeEnd = 390431, XrefRangeStart = 390428, XrefRangeEnd = 390430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveToChild(string name, string URN, int depth, ForwardAxis parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(URN);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisElement.NativeMethodInfoPtr_MoveToChild_Internal_Boolean_String_String_Int32_ForwardAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x00009EEE File Offset: 0x000080EE
		public AxisElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06001749 RID: 5961 RVA: 0x00079F10 File Offset: 0x00078110
		// (set) Token: 0x0600174A RID: 5962 RVA: 0x00009EF7 File Offset: 0x000080F7
		public unsafe DoubleLinkAxis curNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisElement.NativeFieldInfoPtr_curNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DoubleLinkAxis>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisElement.NativeFieldInfoPtr_curNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x0600174B RID: 5963 RVA: 0x00079F40 File Offset: 0x00078140
		// (set) Token: 0x0600174C RID: 5964 RVA: 0x00009F16 File Offset: 0x00008116
		public unsafe int rootDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisElement.NativeFieldInfoPtr_rootDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisElement.NativeFieldInfoPtr_rootDepth)) = value;
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x0600174D RID: 5965 RVA: 0x00079F68 File Offset: 0x00078168
		// (set) Token: 0x0600174E RID: 5966 RVA: 0x00009F31 File Offset: 0x00008131
		public unsafe int curDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisElement.NativeFieldInfoPtr_curDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisElement.NativeFieldInfoPtr_curDepth)) = value;
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x0600174F RID: 5967 RVA: 0x00079F90 File Offset: 0x00078190
		// (set) Token: 0x06001750 RID: 5968 RVA: 0x00009F4C File Offset: 0x0000814C
		public unsafe bool isMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisElement.NativeFieldInfoPtr_isMatch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisElement.NativeFieldInfoPtr_isMatch)) = value;
			}
		}

		// Token: 0x04001255 RID: 4693
		private static readonly IntPtr NativeFieldInfoPtr_curNode;

		// Token: 0x04001256 RID: 4694
		private static readonly IntPtr NativeFieldInfoPtr_rootDepth;

		// Token: 0x04001257 RID: 4695
		private static readonly IntPtr NativeFieldInfoPtr_curDepth;

		// Token: 0x04001258 RID: 4696
		private static readonly IntPtr NativeFieldInfoPtr_isMatch;

		// Token: 0x04001259 RID: 4697
		private static readonly IntPtr NativeMethodInfoPtr_get_CurNode_Internal_get_DoubleLinkAxis_0;

		// Token: 0x0400125A RID: 4698
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DoubleLinkAxis_Int32_0;

		// Token: 0x0400125B RID: 4699
		private static readonly IntPtr NativeMethodInfoPtr_SetDepth_Internal_Void_Int32_0;

		// Token: 0x0400125C RID: 4700
		private static readonly IntPtr NativeMethodInfoPtr_MoveToParent_Internal_Void_Int32_ForwardAxis_0;

		// Token: 0x0400125D RID: 4701
		private static readonly IntPtr NativeMethodInfoPtr_MoveToChild_Internal_Boolean_String_String_Int32_ForwardAxis_0;
	}
}
