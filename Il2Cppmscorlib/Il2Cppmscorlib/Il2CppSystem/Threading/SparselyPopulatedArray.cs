using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200019E RID: 414
	public class SparselyPopulatedArray<T> : Object where T : class
	{
		// Token: 0x06001AF8 RID: 6904 RVA: 0x000A3858 File Offset: 0x000A1A58
		// Note: this type is marked as 'beforefieldinit'.
		static SparselyPopulatedArray()
		{
			Il2CppClassPointerStore<SparselyPopulatedArray<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "SparselyPopulatedArray`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SparselyPopulatedArray<T>>.NativeClassPtr);
			SparselyPopulatedArray<T>.NativeFieldInfoPtr__head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparselyPopulatedArray<T>>.NativeClassPtr, "_head");
			SparselyPopulatedArray<T>.NativeFieldInfoPtr__tail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparselyPopulatedArray<T>>.NativeClassPtr, "_tail");
			SparselyPopulatedArray<T>.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArray<T>>.NativeClassPtr, 100667967);
			SparselyPopulatedArray<T>.NativeMethodInfoPtr_get_Tail_Internal_get_SparselyPopulatedArrayFragment_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArray<T>>.NativeClassPtr, 100667968);
			SparselyPopulatedArray<T>.NativeMethodInfoPtr_Add_Internal_SparselyPopulatedArrayAddInfo_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArray<T>>.NativeClassPtr, 100667969);
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x000A3928 File Offset: 0x000A1B28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1352952, RefRangeEnd = 1352953, XrefRangeStart = 1352945, XrefRangeEnd = 1352952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SparselyPopulatedArray(int initialSize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SparselyPopulatedArray<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparselyPopulatedArray<T>.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06001AFA RID: 6906 RVA: 0x000A3970 File Offset: 0x000A1B70
		public unsafe SparselyPopulatedArrayFragment<T> Tail
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1352954, RefRangeEnd = 1352955, XrefRangeStart = 1352953, XrefRangeEnd = 1352954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparselyPopulatedArray<T>.NativeMethodInfoPtr_get_Tail_Internal_get_SparselyPopulatedArrayFragment_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SparselyPopulatedArrayFragment<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x000A39B0 File Offset: 0x000A1BB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1352989, RefRangeEnd = 1352990, XrefRangeStart = 1352955, XrefRangeEnd = 1352989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SparselyPopulatedArrayAddInfo<T> Add(T element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = element;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref element;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SparselyPopulatedArray<T>.NativeMethodInfoPtr_Add_Internal_SparselyPopulatedArrayAddInfo_1_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return new SparselyPopulatedArrayAddInfo<T>(intPtr2);
			}
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x00008A21 File Offset: 0x00006C21
		public SparselyPopulatedArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06001AFD RID: 6909 RVA: 0x000A3A30 File Offset: 0x000A1C30
		// (set) Token: 0x06001AFE RID: 6910 RVA: 0x00008A2A File Offset: 0x00006C2A
		public unsafe SparselyPopulatedArrayFragment<T> _head
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArray<T>.NativeFieldInfoPtr__head);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SparselyPopulatedArrayFragment<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArray<T>.NativeFieldInfoPtr__head), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06001AFF RID: 6911 RVA: 0x000A3A60 File Offset: 0x000A1C60
		// (set) Token: 0x06001B00 RID: 6912 RVA: 0x00008A49 File Offset: 0x00006C49
		public unsafe SparselyPopulatedArrayFragment<T> _tail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArray<T>.NativeFieldInfoPtr__tail);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SparselyPopulatedArrayFragment<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArray<T>.NativeFieldInfoPtr__tail), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040018C8 RID: 6344
		private static readonly IntPtr NativeFieldInfoPtr__head;

		// Token: 0x040018C9 RID: 6345
		private static readonly IntPtr NativeFieldInfoPtr__tail;

		// Token: 0x040018CA RID: 6346
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x040018CB RID: 6347
		private static readonly IntPtr NativeMethodInfoPtr_get_Tail_Internal_get_SparselyPopulatedArrayFragment_1_T_0;

		// Token: 0x040018CC RID: 6348
		private static readonly IntPtr NativeMethodInfoPtr_Add_Internal_SparselyPopulatedArrayAddInfo_1_T_T_0;
	}
}
