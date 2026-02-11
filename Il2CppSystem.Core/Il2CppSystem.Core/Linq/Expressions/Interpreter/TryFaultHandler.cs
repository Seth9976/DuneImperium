using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000CA RID: 202
	public sealed class TryFaultHandler : Object
	{
		// Token: 0x06000C46 RID: 3142 RVA: 0x000426C8 File Offset: 0x000408C8
		// Note: this type is marked as 'beforefieldinit'.
		static TryFaultHandler()
		{
			Il2CppClassPointerStore<TryFaultHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "TryFaultHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TryFaultHandler>.NativeClassPtr);
			TryFaultHandler.NativeFieldInfoPtr_TryStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TryFaultHandler>.NativeClassPtr, "TryStartIndex");
			TryFaultHandler.NativeFieldInfoPtr_TryEndIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TryFaultHandler>.NativeClassPtr, "TryEndIndex");
			TryFaultHandler.NativeFieldInfoPtr_FinallyStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TryFaultHandler>.NativeClassPtr, "FinallyStartIndex");
			TryFaultHandler.NativeFieldInfoPtr_FinallyEndIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TryFaultHandler>.NativeClassPtr, "FinallyEndIndex");
			TryFaultHandler.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TryFaultHandler>.NativeClassPtr, 100665528);
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x0004275C File Offset: 0x0004095C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TryFaultHandler(int tryStart, int tryEnd, int finallyStart, int finallyEnd)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TryFaultHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tryStart;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tryEnd;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref finallyStart;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref finallyEnd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TryFaultHandler.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x00005BA1 File Offset: 0x00003DA1
		public TryFaultHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000C49 RID: 3145 RVA: 0x000427D0 File Offset: 0x000409D0
		// (set) Token: 0x06000C4A RID: 3146 RVA: 0x00005BAA File Offset: 0x00003DAA
		public unsafe int TryStartIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryFaultHandler.NativeFieldInfoPtr_TryStartIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryFaultHandler.NativeFieldInfoPtr_TryStartIndex)) = value;
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000C4B RID: 3147 RVA: 0x000427F8 File Offset: 0x000409F8
		// (set) Token: 0x06000C4C RID: 3148 RVA: 0x00005BC5 File Offset: 0x00003DC5
		public unsafe int TryEndIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryFaultHandler.NativeFieldInfoPtr_TryEndIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryFaultHandler.NativeFieldInfoPtr_TryEndIndex)) = value;
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000C4D RID: 3149 RVA: 0x00042820 File Offset: 0x00040A20
		// (set) Token: 0x06000C4E RID: 3150 RVA: 0x00005BE0 File Offset: 0x00003DE0
		public unsafe int FinallyStartIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryFaultHandler.NativeFieldInfoPtr_FinallyStartIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryFaultHandler.NativeFieldInfoPtr_FinallyStartIndex)) = value;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000C4F RID: 3151 RVA: 0x00042848 File Offset: 0x00040A48
		// (set) Token: 0x06000C50 RID: 3152 RVA: 0x00005BFB File Offset: 0x00003DFB
		public unsafe int FinallyEndIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryFaultHandler.NativeFieldInfoPtr_FinallyEndIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TryFaultHandler.NativeFieldInfoPtr_FinallyEndIndex)) = value;
			}
		}

		// Token: 0x04000908 RID: 2312
		private static readonly IntPtr NativeFieldInfoPtr_TryStartIndex;

		// Token: 0x04000909 RID: 2313
		private static readonly IntPtr NativeFieldInfoPtr_TryEndIndex;

		// Token: 0x0400090A RID: 2314
		private static readonly IntPtr NativeFieldInfoPtr_FinallyStartIndex;

		// Token: 0x0400090B RID: 2315
		private static readonly IntPtr NativeFieldInfoPtr_FinallyEndIndex;

		// Token: 0x0400090C RID: 2316
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Int32_0;
	}
}
