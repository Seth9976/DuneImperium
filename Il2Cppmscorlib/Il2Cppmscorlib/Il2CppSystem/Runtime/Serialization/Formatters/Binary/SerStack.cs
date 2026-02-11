using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200036F RID: 879
	public sealed class SerStack : Object
	{
		// Token: 0x060036CF RID: 14031 RVA: 0x0010D76C File Offset: 0x0010B96C
		// Note: this type is marked as 'beforefieldinit'.
		static SerStack()
		{
			Il2CppClassPointerStore<SerStack>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "SerStack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerStack>.NativeClassPtr);
			SerStack.NativeFieldInfoPtr_objects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerStack>.NativeClassPtr, "objects");
			SerStack.NativeFieldInfoPtr_stackId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerStack>.NativeClassPtr, "stackId");
			SerStack.NativeFieldInfoPtr_top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerStack>.NativeClassPtr, "top");
			SerStack.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerStack>.NativeClassPtr, 100671559);
			SerStack.NativeMethodInfoPtr_Push_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerStack>.NativeClassPtr, 100671560);
			SerStack.NativeMethodInfoPtr_Pop_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerStack>.NativeClassPtr, 100671561);
			SerStack.NativeMethodInfoPtr_IncreaseCapacity_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerStack>.NativeClassPtr, 100671562);
			SerStack.NativeMethodInfoPtr_Peek_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerStack>.NativeClassPtr, 100671563);
			SerStack.NativeMethodInfoPtr_PeekPeek_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerStack>.NativeClassPtr, 100671564);
			SerStack.NativeMethodInfoPtr_IsEmpty_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerStack>.NativeClassPtr, 100671565);
		}

		// Token: 0x060036D0 RID: 14032 RVA: 0x0010D864 File Offset: 0x0010BA64
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1390929, RefRangeEnd = 1390936, XrefRangeStart = 1390923, XrefRangeEnd = 1390929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerStack(string stackId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerStack>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(stackId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerStack.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036D1 RID: 14033 RVA: 0x0010D8B0 File Offset: 0x0010BAB0
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 1390947, RefRangeEnd = 1390967, XrefRangeStart = 1390936, XrefRangeEnd = 1390947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerStack.NativeMethodInfoPtr_Push_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036D2 RID: 14034 RVA: 0x0010D8F4 File Offset: 0x0010BAF4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1390968, RefRangeEnd = 1390971, XrefRangeStart = 1390967, XrefRangeEnd = 1390968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerStack.NativeMethodInfoPtr_Pop_Internal_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060036D3 RID: 14035 RVA: 0x0010D934 File Offset: 0x0010BB34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1390971, XrefRangeEnd = 1390977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncreaseCapacity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerStack.NativeMethodInfoPtr_IncreaseCapacity_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036D4 RID: 14036 RVA: 0x0010D968 File Offset: 0x0010BB68
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1390977, RefRangeEnd = 1390982, XrefRangeStart = 1390977, XrefRangeEnd = 1390977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerStack.NativeMethodInfoPtr_Peek_Internal_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060036D5 RID: 14037 RVA: 0x0010D9A8 File Offset: 0x0010BBA8
		[CallerCount(0)]
		public unsafe Object PeekPeek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerStack.NativeMethodInfoPtr_PeekPeek_Internal_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060036D6 RID: 14038 RVA: 0x0010D9E8 File Offset: 0x0010BBE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1390982, RefRangeEnd = 1390983, XrefRangeStart = 1390982, XrefRangeEnd = 1390982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsEmpty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerStack.NativeMethodInfoPtr_IsEmpty_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060036D7 RID: 14039 RVA: 0x00013E80 File Offset: 0x00012080
		public SerStack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x060036D8 RID: 14040 RVA: 0x0010DA24 File Offset: 0x0010BC24
		// (set) Token: 0x060036D9 RID: 14041 RVA: 0x00013E89 File Offset: 0x00012089
		public unsafe Il2CppReferenceArray<Object> objects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerStack.NativeFieldInfoPtr_objects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerStack.NativeFieldInfoPtr_objects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x060036DA RID: 14042 RVA: 0x0010DA54 File Offset: 0x0010BC54
		// (set) Token: 0x060036DB RID: 14043 RVA: 0x00013EA8 File Offset: 0x000120A8
		public unsafe string stackId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerStack.NativeFieldInfoPtr_stackId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerStack.NativeFieldInfoPtr_stackId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x060036DC RID: 14044 RVA: 0x0010DA7C File Offset: 0x0010BC7C
		// (set) Token: 0x060036DD RID: 14045 RVA: 0x00013EC7 File Offset: 0x000120C7
		public unsafe int top
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerStack.NativeFieldInfoPtr_top);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerStack.NativeFieldInfoPtr_top)) = value;
			}
		}

		// Token: 0x04002C96 RID: 11414
		private static readonly IntPtr NativeFieldInfoPtr_objects;

		// Token: 0x04002C97 RID: 11415
		private static readonly IntPtr NativeFieldInfoPtr_stackId;

		// Token: 0x04002C98 RID: 11416
		private static readonly IntPtr NativeFieldInfoPtr_top;

		// Token: 0x04002C99 RID: 11417
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

		// Token: 0x04002C9A RID: 11418
		private static readonly IntPtr NativeMethodInfoPtr_Push_Internal_Void_Object_0;

		// Token: 0x04002C9B RID: 11419
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Internal_Object_0;

		// Token: 0x04002C9C RID: 11420
		private static readonly IntPtr NativeMethodInfoPtr_IncreaseCapacity_Internal_Void_0;

		// Token: 0x04002C9D RID: 11421
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Internal_Object_0;

		// Token: 0x04002C9E RID: 11422
		private static readonly IntPtr NativeMethodInfoPtr_PeekPeek_Internal_Object_0;

		// Token: 0x04002C9F RID: 11423
		private static readonly IntPtr NativeMethodInfoPtr_IsEmpty_Internal_Boolean_0;
	}
}
