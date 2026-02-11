using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000102 RID: 258
	public class AxisStack : Object
	{
		// Token: 0x06001751 RID: 5969 RVA: 0x00079FB8 File Offset: 0x000781B8
		// Note: this type is marked as 'beforefieldinit'.
		static AxisStack()
		{
			Il2CppClassPointerStore<AxisStack>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "AxisStack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AxisStack>.NativeClassPtr);
			AxisStack.NativeFieldInfoPtr__stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisStack>.NativeClassPtr, "_stack");
			AxisStack.NativeFieldInfoPtr__subtree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisStack>.NativeClassPtr, "_subtree");
			AxisStack.NativeFieldInfoPtr__parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisStack>.NativeClassPtr, "_parent");
			AxisStack.NativeMethodInfoPtr_get_Subtree_Internal_get_ForwardAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisStack>.NativeClassPtr, 100666955);
			AxisStack.NativeMethodInfoPtr_get_Length_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisStack>.NativeClassPtr, 100666956);
			AxisStack.NativeMethodInfoPtr__ctor_Public_Void_ForwardAxis_ActiveAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisStack>.NativeClassPtr, 100666957);
			AxisStack.NativeMethodInfoPtr_Push_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisStack>.NativeClassPtr, 100666958);
			AxisStack.NativeMethodInfoPtr_Pop_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisStack>.NativeClassPtr, 100666959);
			AxisStack.NativeMethodInfoPtr_Equal_Internal_Static_Boolean_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisStack>.NativeClassPtr, 100666960);
			AxisStack.NativeMethodInfoPtr_MoveToParent_Internal_Void_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisStack>.NativeClassPtr, 100666961);
			AxisStack.NativeMethodInfoPtr_MoveToChild_Internal_Boolean_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisStack>.NativeClassPtr, 100666962);
			AxisStack.NativeMethodInfoPtr_MoveToAttribute_Internal_Boolean_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisStack>.NativeClassPtr, 100666963);
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06001752 RID: 5970 RVA: 0x0007A0D8 File Offset: 0x000782D8
		public unsafe ForwardAxis Subtree
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisStack.NativeMethodInfoPtr_get_Subtree_Internal_get_ForwardAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ForwardAxis>(intPtr3) : null;
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06001753 RID: 5971 RVA: 0x0007A118 File Offset: 0x00078318
		public unsafe int Length
		{
			[CallerCount(212)]
			[CachedScanResults(RefRangeStart = 390432, RefRangeEnd = 390644, XrefRangeStart = 390431, XrefRangeEnd = 390432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisStack.NativeMethodInfoPtr_get_Length_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x0007A154 File Offset: 0x00078354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390644, XrefRangeEnd = 390653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AxisStack(ForwardAxis faxis, ActiveAxis parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AxisStack>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(faxis);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisStack.NativeMethodInfoPtr__ctor_Public_Void_ForwardAxis_ActiveAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x0007A1B4 File Offset: 0x000783B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 390659, RefRangeEnd = 390662, XrefRangeStart = 390653, XrefRangeEnd = 390659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push(int depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref depth;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisStack.NativeMethodInfoPtr_Push_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x0007A1F4 File Offset: 0x000783F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390662, XrefRangeEnd = 390663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisStack.NativeMethodInfoPtr_Pop_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x0007A228 File Offset: 0x00078428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390663, XrefRangeEnd = 390666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Equal(string thisname, string thisURN, string name, string URN)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(thisname);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(thisURN);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(URN);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisStack.NativeMethodInfoPtr_Equal_Internal_Static_Boolean_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x0007A2A0 File Offset: 0x000784A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 390677, RefRangeEnd = 390679, XrefRangeStart = 390666, XrefRangeEnd = 390677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveToParent(string name, string URN, int depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(URN);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisStack.NativeMethodInfoPtr_MoveToParent_Internal_Void_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x0007A304 File Offset: 0x00078504
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 390687, RefRangeEnd = 390688, XrefRangeStart = 390679, XrefRangeEnd = 390687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveToChild(string name, string URN, int depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(URN);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisStack.NativeMethodInfoPtr_MoveToChild_Internal_Boolean_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x0007A374 File Offset: 0x00078574
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 390690, RefRangeEnd = 390691, XrefRangeStart = 390688, XrefRangeEnd = 390690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveToAttribute(string name, string URN, int depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(URN);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisStack.NativeMethodInfoPtr_MoveToAttribute_Internal_Boolean_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x00009F67 File Offset: 0x00008167
		public AxisStack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x0600175C RID: 5980 RVA: 0x0007A3E4 File Offset: 0x000785E4
		// (set) Token: 0x0600175D RID: 5981 RVA: 0x00009F70 File Offset: 0x00008170
		public unsafe ArrayList _stack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisStack.NativeFieldInfoPtr__stack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisStack.NativeFieldInfoPtr__stack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x0600175E RID: 5982 RVA: 0x0007A414 File Offset: 0x00078614
		// (set) Token: 0x0600175F RID: 5983 RVA: 0x00009F8F File Offset: 0x0000818F
		public unsafe ForwardAxis _subtree
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisStack.NativeFieldInfoPtr__subtree);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ForwardAxis>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisStack.NativeFieldInfoPtr__subtree), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06001760 RID: 5984 RVA: 0x0007A444 File Offset: 0x00078644
		// (set) Token: 0x06001761 RID: 5985 RVA: 0x00009FAE File Offset: 0x000081AE
		public unsafe ActiveAxis _parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisStack.NativeFieldInfoPtr__parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActiveAxis>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisStack.NativeFieldInfoPtr__parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400125E RID: 4702
		private static readonly IntPtr NativeFieldInfoPtr__stack;

		// Token: 0x0400125F RID: 4703
		private static readonly IntPtr NativeFieldInfoPtr__subtree;

		// Token: 0x04001260 RID: 4704
		private static readonly IntPtr NativeFieldInfoPtr__parent;

		// Token: 0x04001261 RID: 4705
		private static readonly IntPtr NativeMethodInfoPtr_get_Subtree_Internal_get_ForwardAxis_0;

		// Token: 0x04001262 RID: 4706
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Internal_get_Int32_0;

		// Token: 0x04001263 RID: 4707
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ForwardAxis_ActiveAxis_0;

		// Token: 0x04001264 RID: 4708
		private static readonly IntPtr NativeMethodInfoPtr_Push_Internal_Void_Int32_0;

		// Token: 0x04001265 RID: 4709
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Internal_Void_0;

		// Token: 0x04001266 RID: 4710
		private static readonly IntPtr NativeMethodInfoPtr_Equal_Internal_Static_Boolean_String_String_String_String_0;

		// Token: 0x04001267 RID: 4711
		private static readonly IntPtr NativeMethodInfoPtr_MoveToParent_Internal_Void_String_String_Int32_0;

		// Token: 0x04001268 RID: 4712
		private static readonly IntPtr NativeMethodInfoPtr_MoveToChild_Internal_Boolean_String_String_Int32_0;

		// Token: 0x04001269 RID: 4713
		private static readonly IntPtr NativeMethodInfoPtr_MoveToAttribute_Internal_Boolean_String_String_Int32_0;
	}
}
