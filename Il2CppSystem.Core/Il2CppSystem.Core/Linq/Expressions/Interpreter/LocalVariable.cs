using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000E5 RID: 229
	public sealed class LocalVariable : Object
	{
		// Token: 0x06000DCB RID: 3531 RVA: 0x0004D308 File Offset: 0x0004B508
		// Note: this type is marked as 'beforefieldinit'.
		static LocalVariable()
		{
			Il2CppClassPointerStore<LocalVariable>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "LocalVariable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalVariable>.NativeClassPtr);
			LocalVariable.NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalVariable>.NativeClassPtr, "Index");
			LocalVariable.NativeFieldInfoPtr__flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalVariable>.NativeClassPtr, "_flags");
			LocalVariable.NativeMethodInfoPtr_get_IsBoxed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalVariable>.NativeClassPtr, 100665834);
			LocalVariable.NativeMethodInfoPtr_set_IsBoxed_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalVariable>.NativeClassPtr, 100665835);
			LocalVariable.NativeMethodInfoPtr_get_InClosure_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalVariable>.NativeClassPtr, 100665836);
			LocalVariable.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalVariable>.NativeClassPtr, 100665837);
			LocalVariable.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalVariable>.NativeClassPtr, 100665838);
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000DCC RID: 3532 RVA: 0x0004D3C4 File Offset: 0x0004B5C4
		// (set) Token: 0x06000DCD RID: 3533 RVA: 0x0004D400 File Offset: 0x0004B600
		public unsafe bool IsBoxed
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1024777, RefRangeEnd = 1024779, XrefRangeStart = 1024777, XrefRangeEnd = 1024777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalVariable.NativeMethodInfoPtr_get_IsBoxed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalVariable.NativeMethodInfoPtr_set_IsBoxed_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000DCE RID: 3534 RVA: 0x0004D440 File Offset: 0x0004B640
		public unsafe bool InClosure
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1024779, RefRangeEnd = 1024782, XrefRangeStart = 1024779, XrefRangeEnd = 1024779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalVariable.NativeMethodInfoPtr_get_InClosure_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x0004D47C File Offset: 0x0004B67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024782, XrefRangeEnd = 1024783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalVariable(int index, bool closure)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalVariable>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref closure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalVariable.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x0004D4D4 File Offset: 0x0004B6D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024783, XrefRangeEnd = 1024798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalVariable.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x00006245 File Offset: 0x00004445
		public LocalVariable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000DD2 RID: 3538 RVA: 0x0004D50C File Offset: 0x0004B70C
		// (set) Token: 0x06000DD3 RID: 3539 RVA: 0x0000624E File Offset: 0x0000444E
		public unsafe int Index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariable.NativeFieldInfoPtr_Index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariable.NativeFieldInfoPtr_Index)) = value;
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000DD4 RID: 3540 RVA: 0x0004D534 File Offset: 0x0004B734
		// (set) Token: 0x06000DD5 RID: 3541 RVA: 0x00006269 File Offset: 0x00004469
		public unsafe int _flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariable.NativeFieldInfoPtr__flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariable.NativeFieldInfoPtr__flags)) = value;
			}
		}

		// Token: 0x04000A2B RID: 2603
		private static readonly IntPtr NativeFieldInfoPtr_Index;

		// Token: 0x04000A2C RID: 2604
		private static readonly IntPtr NativeFieldInfoPtr__flags;

		// Token: 0x04000A2D RID: 2605
		private static readonly IntPtr NativeMethodInfoPtr_get_IsBoxed_Public_get_Boolean_0;

		// Token: 0x04000A2E RID: 2606
		private static readonly IntPtr NativeMethodInfoPtr_set_IsBoxed_Public_set_Void_Boolean_0;

		// Token: 0x04000A2F RID: 2607
		private static readonly IntPtr NativeMethodInfoPtr_get_InClosure_Public_get_Boolean_0;

		// Token: 0x04000A30 RID: 2608
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Boolean_0;

		// Token: 0x04000A31 RID: 2609
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
